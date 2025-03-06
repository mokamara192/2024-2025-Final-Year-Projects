Imports System.Drawing.Imaging
Imports System.IO
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraNavBar.ViewInfo

Imports Leadtools
Imports Leadtools.Codecs
Imports Leadtools.Controls
Imports Leadtools.Twain
Imports Leadtools.Wia
Imports Leadtools.WinForms.CommonDialogs.File

Public Class frmNewScanningDocument
    Public TableName As String
    Public ForeignKeyField As String
    Public ForeignKeyValue As String
    Dim DocumentList As New ArrayList(50)
    Dim CurrentImage As Image = Nothing
    Dim theGeneratedFileName As String
    Dim theSelectedTag As String
    Dim theSelectedDescription As String
    Public FolderName As String = ""
    Dim theSelectedCaption As String = ""

    'SCANNING PROPERTIES
    Public _codecs As RasterCodecs
    Public _wiaSession As WiaSession
    Public _wiaAcquireOptions As WiaAcquireOptions = WiaAcquireOptions.Empty

    Public _wiaVersion As WiaVersion
    Public _transferMode As WiaTransferMode
    Public _errorList As New ArrayList
    Public _selectedWiaItem As Object = Nothing
    Public _capabilitiesList As New ArrayList
    Public _formatsList As New ArrayList

    Public _forCapabilities As Boolean = False
    Public _showUserInterface As Boolean = False
    Public _acquireFromFeeder As Boolean = True

    Public _progressDlg As frmProgressForm
    Private _scanCount As Integer = 0
    Private _wiaAvailable As Boolean = False
    Private _wiaSourceSelected As Boolean = False
    Private _wiaVideoStreamSource As Boolean = False
    Private _wiaAcquiring As Boolean = False
    Private menuItem1 As MenuItem
    Private WithEvents _miOptionsShowUI As MenuItem
    Private _sourceItem As Object = Nothing
    Private _enumeratedWiaItems As New ArrayList
    Private _openInitialPath As String = ""

    Dim MyViewer As New ImageViewer

    Dim MyScannedImages(100) As RasterImage

    Private Sub MyLoading() Handles Me.Load

        If UserGroup = "Supervisor" Or UserGroup = "Administrator" Then
            RibbonPage4.Visible = True
        Else
            RibbonPage4.Visible = False
        End If

        ScanFullPath = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & FolderName

        DocumentTypeandQuantityDataTable = New DocumentTypeandQuanfityDataSet.TypeDataTableDataTable()
        BarButtonItemDelete.Enabled = False
        BarButtonItemDownload.Enabled = False
        BarButtonItemOpen.Enabled = False
        BarButtonItemSaveProperties.Enabled = False
        BarButtonChangeDocumentation.Enabled = False
        BarButtonPrint.Enabled = False
        PreviewPictureBox.Image = Nothing

        LoadGeneralFileType(BarLabelTypeofDocumentation.Caption, BarLabelClientType.Caption)
        LoadDocumentationType(BarLabelClientType.Caption)
        LoadDocuments()

    End Sub


    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If Not Support.SetLicense() Then
        '    Return
        'End If

        If _wiaVersion = 0 Then
            _wiaVersion = WiaVersion.Version2
        End If

        'Using WiaVersionDlg As WiaVersionForm = New WiaVersionForm()
        '    If WiaVersionDlg.ShowDialog() = DialogResult.OK Then
        '        _wiaVersion = WiaVersionDlg._selectedWiaVersion
        '    Else
        '        Return
        '    End If
        'End Using

        ' initialize the codecs object
        _codecs = New RasterCodecs()

        _wiaAvailable = WiaSession.IsAvailable(_wiaVersion)
        If _wiaAvailable Then
            _wiaSession = New WiaSession()
            _wiaSession.Startup(_wiaVersion)
            '_miWiaSelectSource.Enabled = True

            ' Set the default acquire path for file transfer to My Documents folder.
            Dim myDocumentsPath As String
            HelperFunctions.GetFormatFilterAndExtension()

            myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            _wiaAcquireOptions.FileName = String.Format("{0}{1}{2}", myDocumentsPath, "\WiaTest.", HelperFunctions.Extension)

            If _wiaProperties.DataTransfer.TransferMode = WiaTransferMode.None Then ' GetProperties() method not called yet.
                _transferMode = WiaTransferMode.Memory
            Else
                _transferMode = _wiaProperties.DataTransfer.TransferMode
            End If

            AddHandler _wiaSession.AcquireEvent, AddressOf _wiaSession_AcquireEvent
        Else
            '_miWiaSelectSource.Enabled = False
        End If

        'EnableMenuItems(False)
        _errorList = New ArrayList()
        _capabilitiesList = New ArrayList()
        _formatsList = New ArrayList()
        _flagValuesStrings = New ArrayList()
    End Sub

    Private Sub MainForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' prevent the application from closing while acquiring.
        If _wiaAcquiring Then
            e.Cancel = True
            Return
        End If

        Try
            RemoveHandler _wiaSession.AcquireEvent, AddressOf _wiaSession_AcquireEvent

            If _wiaAvailable Then
                _wiaSession.Shutdown()
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub LoadGeneralFileType(ByVal DocumentationType As String, ByVal Optional Division As String = "")

        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String

            If Division <> "" Then
                Query = "Select Distinct(FileType) From FileTypes WHERE Division = '" & Division & "'"
            Else
                Query = "Select Distinct(FileType) From FileTypes"
            End If

            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTable As New DataTable

            ConTableAdap.Fill(MyTable)

            FileTypeComboBox.Properties.Items.Clear()
            FileTypeChangeComboBox.Properties.Items.Clear()
            ScanFileTypeComboBox.Properties.Items.Clear()

            If MyTable.Rows.Count > 0 Then
                For Each Record In MyTable.Rows
                    FileTypeComboBox.Properties.Items.Add(Record("FileType"))
                    FileTypeChangeComboBox.Properties.Items.Add(Record("FileType"))
                    ScanFileTypeComboBox.Properties.Items.Add(Record("FileType"))
                Next
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub LoadChangedFileType(ByVal DocumentationType As String, ByVal Optional Division As String = "")

        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String

            If Division <> "" Then
                Query = "Select Distinct(FileType) From FileTypes WHERE Division = '" & Division & "'"
            Else
                Query = "Select Distinct(FileType) From FileTypes"
            End If

            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTable As New DataTable

            ConTableAdap.Fill(MyTable)

            FileTypeChangeComboBox.Properties.Items.Clear()

            If MyTable.Rows.Count > 0 Then
                For Each Record In MyTable.Rows
                    FileTypeChangeComboBox.Properties.Items.Add(Record("FileType"))
                Next
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub LoadScanFileType(ByVal DocumentationType As String, ByVal Optional Division As String = "")

        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String

            If Division <> "" Then
                Query = "Select Distinct(FileType) From FileTypes WHERE Division = '" & Division & "'"
            Else
                Query = "Select Distinct(FileType) From FileTypes"
            End If

            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTable As New DataTable

            ConTableAdap.Fill(MyTable)

            ScanFileTypeComboBox.Properties.Items.Clear()

            If MyTable.Rows.Count > 0 Then
                For Each Record In MyTable.Rows
                    ScanFileTypeComboBox.Properties.Items.Add(Record("FileType"))
                Next
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Sub
    Private Sub LoadDocumentationType(ByVal Division As String)

        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "Select DISTINCT(Division) From FileTypes WHERE Division = '" & Division & "'"

            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTable As New DataTable

            ConTableAdap.Fill(MyTable)

            DivisionComboBox.Properties.Items.Clear()
            ScanDivisionComboBox.Properties.Items.Clear()

            If MyTable.Rows.Count > 0 Then
                For Each Record In MyTable.Rows
                    DivisionComboBox.Properties.Items.Add(Record("Division").ToString.ToUpper())
                    ScanDivisionComboBox.Properties.Items.Add(Record("Division").ToString.ToUpper())
                Next
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub LoadDocuments()
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = ""

            If BarLabelTypeofDocumentation.Caption.ToUpper.Contains("ALL") Then
                Query = " SELECT ID, FileName, GeneratedFileName, FileStatus, FileType, ApprovalStatus, SupervisedBy FROM " & TableName & " WHERE " & ForeignKeyField & " = '" & ForeignKeyValue & "' ORDER BY ID DESC"
            Else
                Query = " SELECT ID, FileName, GeneratedFileName, FileStatus, FileType, ApprovalStatus, SupervisedBy FROM " & TableName & " WHERE " & ForeignKeyField & " = '" & ForeignKeyValue & "' AND FileType = '" & BarLabelTypeofDocumentation.Caption & "' ORDER BY ID DESC"
            End If

            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            Dim thefileTypes As New ArrayList

            PreviewGallery.Gallery.Groups.Clear()

            If MYTABLE.Rows.Count > 0 Then

                For Each item In MYTABLE.Rows
                    If Not thefileTypes.Contains(item("FileType")) Then
                        thefileTypes.Add(item("FileType"))
                    End If
                Next

                NavBarAttachedDocuments.Groups.Clear()

                For Each FileType In thefileTypes
                    Dim group1 As GalleryItemGroup = New GalleryItemGroup()
                    group1.Caption = FileType
                    PreviewGallery.Gallery.Groups.Add(group1)

                    '*********************************************
                    'THE NAVBAR REORDERING GROUP

                    Dim TheNavGroup As NavBarGroup = New NavBarGroup
                    NavBarAttachedDocuments.Groups.Add(TheNavGroup)
                    TheNavGroup.Caption = FileType

                    For Each item In MYTABLE.Rows
                        If item("FileType").ToString() = FileType Then
                            Dim TheImage As Image = Nothing

                            Try
                                Dim TheByte As Byte() = GetDocumentData(item("ID"))
                                Dim MyMemoryStream As New System.IO.MemoryStream(TheByte)
                                TheImage = Image.FromStream(MyMemoryStream)
                            Catch ex As Exception
                                If item("FileName").ToString.ToUpper.Contains(".DOC") Then
                                    TheImage = ImageList1.Images(0)
                                ElseIf item("FileName").ToString.ToUpper.Contains(".PDF") Then
                                    TheImage = ImageList1.Images(1)
                                ElseIf item("FileName").ToString.ToUpper.Contains(".XLS") Then
                                    TheImage = ImageList1.Images(2)
                                ElseIf item("FileName").ToString.ToUpper.Contains(".GIF") Then
                                    TheImage = ImageList1.Images(5)
                                Else
                                    TheImage = ImageList1.Images(4)
                                End If
                            End Try

                            'group1.Items.Add(New GalleryItem(TheImage, TheImage, item("GeneratedFileName"), item("FileName"), 0, 0, item("ID"), item("GeneratedFileName")))

                            Dim supervisedby As String = ""

                            If item("SupervisedBy") <> "" Then
                                supervisedby = " (" & item("SupervisedBy") & ")"
                            End If

                            Dim myGalleryItem As GalleryItem = New GalleryItem(TheImage, TheImage, item("ID") & " (" & item("ApprovalStatus").ToString.ToUpper() & ")", item("FileName"), 0, 0, item("ID"), item("GeneratedFileName") & supervisedby)

                            If item("ApprovalStatus").ToString.ToUpper() = "APPROVED" Then
                                myGalleryItem.AppearanceCaption.Normal.ForeColor = Color.LightGreen
                            ElseIf item("ApprovalStatus").ToString.ToUpper() = "DISAPPROVED" Then
                                myGalleryItem.AppearanceCaption.Normal.ForeColor = Color.Red
                            Else
                                myGalleryItem.AppearanceCaption.Normal.ForeColor = Color.White
                            End If

                            group1.Items.Add(myGalleryItem)

                            '*********************************************
                            'THE NAVBAR REORDERING SECTION ITEMS

                            Dim TheWidth As Integer
                            Dim TheHeight As Integer

                            If TheImage.Width >= 30 Then
                                Dim Percent As Single = 30 / TheImage.Width

                                TheWidth = TheImage.Width * Percent
                                TheHeight = TheImage.Height * Percent
                            End If

                            Dim g As Graphics
                            Dim captured As Bitmap = New System.Drawing.Bitmap(TheWidth, TheHeight, System.Drawing.Imaging.PixelFormat.Format24bppRgb)
                            g = Graphics.FromImage(captured)
                            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                            g.DrawImage(TheImage, New Rectangle(0, 0, TheWidth, TheHeight), New Rectangle(0, 0, TheImage.Width, TheImage.Height), GraphicsUnit.Pixel)

                            Dim IndexItem As NavBarItem = New NavBarItem
                            IndexItem.Caption = item("GeneratedFileName")
                            IndexItem.SmallImage = captured
                            IndexItem.Tag = item("ID")

                            'IndexItem .LargeImage = TheImage

                            TheNavGroup.ItemLinks.Add(IndexItem)
                            NavBarAttachedDocuments.Items.Add(IndexItem)
                        End If
                    Next
                Next

            End If

            LoadDocumentCompletionRecords(BarStaticItemAccRecordID.Caption)

            For Each thegroup As NavBarGroup In NavBarAttachedDocuments.Groups
                thegroup.Expanded = True
            Next

        Catch Ex As Exception
            XtraMessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ReloadLoadPreviewDocuments()
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = ""

            If BarLabelTypeofDocumentation.Caption.ToUpper.Contains("ALL") Then
                Query = " SELECT ID, FileName, GeneratedFileName, FileStatus, FileType FROM " & TableName & " WHERE " & ForeignKeyField & " = '" & ForeignKeyValue & "' ORDER BY ID DESC"
            Else
                Query = " SELECT ID, FileName, GeneratedFileName, FileStatus, FileType FROM " & TableName & " WHERE " & ForeignKeyField & " = '" & ForeignKeyValue & "' AND FileType = '" & BarLabelTypeofDocumentation.Caption & "' ORDER BY ID DESC"
            End If

            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            Dim thefileTypes As New ArrayList

            PreviewGallery.Gallery.Groups.Clear()

            If MYTABLE.Rows.Count > 0 Then

                For Each item In MYTABLE.Rows
                    If Not thefileTypes.Contains(item("FileType")) Then
                        thefileTypes.Add(item("FileType"))
                    End If
                Next

                For Each FileType In thefileTypes
                    Dim group1 As GalleryItemGroup = New GalleryItemGroup()
                    group1.Caption = FileType
                    PreviewGallery.Gallery.Groups.Add(group1)

                    For Each item In MYTABLE.Rows
                        If item("FileType").ToString() = FileType Then
                            Dim TheImage As Image = Nothing

                            Try
                                Dim TheByte As Byte() = GetDocumentData(item("ID"))
                                Dim MyMemoryStream As New System.IO.MemoryStream(TheByte)
                                TheImage = Image.FromStream(MyMemoryStream)
                            Catch ex As Exception
                                If item("FileName").ToString.ToUpper.Contains(".DOC") Then
                                    TheImage = ImageList1.Images(0)
                                ElseIf item("FileName").ToString.ToUpper.Contains(".PDF") Then
                                    TheImage = ImageList1.Images(1)
                                ElseIf item("FileName").ToString.ToUpper.Contains(".XLS") Then
                                    TheImage = ImageList1.Images(2)
                                ElseIf item("FileName").ToString.ToUpper.Contains(".GIF") Then
                                    TheImage = ImageList1.Images(5)
                                Else
                                    TheImage = ImageList1.Images(4)
                                End If
                            End Try

                            group1.Items.Add(New GalleryItem(TheImage, TheImage, item("GeneratedFileName"), item("FileName"), 0, 0, item("ID"), item("GeneratedFileName")))

                        End If
                    Next
                Next

            End If

            LoadDocumentCompletionRecords(BarStaticItemAccRecordID.Caption)

        Catch Ex As Exception
            XtraMessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Function GetDocumentData(ByVal ID As String) As Byte()

        Try
            Dim theName As String = GetDocumentGeneratedName(ID)
            Dim FullPath As String = "\\" & My.Settings.FileServerAddress & "\" & My.Settings.FileServerFolder & "\" & FolderName

            If Not My.Computer.FileSystem.DirectoryExists(FullPath) Then
                My.Computer.FileSystem.CreateDirectory(FullPath)
            End If

            If My.Computer.FileSystem.DirectoryExists(FullPath) Then
                FullPath = FullPath & "\" & theName

                If My.Computer.FileSystem.FileExists(FullPath) Then
                    Dim TheBytes As Byte() = My.Computer.FileSystem.ReadAllBytes(FullPath)
                    Return TheBytes
                End If

            Else
                MessageBox.Show("Error Accessing/Creating Directory. Please Verify", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Function


    Private Function GetDocumentGeneratedName(ByVal RecordID As String) As String
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT GeneratedFileName FROM StaffFilesData WHERE ID = '" & RecordID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            If MYTABLE.Rows.Count > 0 Then
                Return MYTABLE.Rows(0).Item("GeneratedFileName")
            Else
                Return ""
            End If

        Catch Ex As Exception
            XtraMessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Function

    Private Sub BarButtonItemOpen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemOpen.ItemClick
        Try
            Dim Thecount As Integer = PreviewGallery.Gallery.GetCheckedItems.Count

            If Thecount = 0 Then
                XtraMessageBox.Show("Please select a file from the list on the left before proceeding.", "Missing Selection", MessageBoxButtons.OK)
            End If

            Dim TheBytes As Byte() = GetDocumentData(theSelectedTag)
            Dim ItemDescription As String = theSelectedDescription
            'Dim TheSplit As String() = ItemDescription.Trim.Split(":")
            Dim TheFileName As String = ItemDescription

            If TheBytes Is Nothing Then
                MessageBox.Show("File Not Found on File Server. Please contact the System Administrator", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If TheFileName.ToUpper.Contains(".JPG") Or TheFileName.ToUpper.Contains(".PNG") Or TheFileName.ToUpper.Contains(".BMP") Or TheFileName.ToUpper.Contains(".JPEG") Or TheFileName.ToUpper.Contains(".GIF") Or TheFileName.ToUpper.Contains(".TIFF") Then
                Dim MyImageForm As New frmViewImage

                Dim MyMemoryStream As New System.IO.MemoryStream(TheBytes)
                Dim MyImage As Image = Image.FromStream(MyMemoryStream)
                MyImageForm.ImagePictureBox.Image = MyImage

                MyImageForm.BarStaticItemDocumentName.Caption = TheFileName
                MyImageForm.BarStaticItemDocumentDescription.Caption = ItemDescription

                MyImageForm.Show(Me)

            ElseIf TheFileName.ToUpper.Contains(".DOC") Then
                Dim MyForm As New frmWordProcessor
                MyForm.RichEditControl1.OpenXmlBytes() = TheBytes
                MyForm.Show(Me)
            ElseIf TheFileName.ToUpper.Contains(".PDF") Then
                Dim MyForm As New frmViewPDF
                Dim MyMemoryStream As New System.IO.MemoryStream(TheBytes)
                MyForm.MyPdfViewer.LoadDocument(MyMemoryStream)
                MyForm.Show(Me)
            ElseIf TheFileName.ToUpper.Contains(".XLS") Then
                Dim MyForm As New frmSpreadsheet
                MyForm.SpreadsheetControl1.LoadDocument(TheBytes, DevExpress.Spreadsheet.DocumentFormat.Xlsx)
                MyForm.Show(Me)
            Else

                Dim FSD As New SaveFileDialog
                FSD.FileName = TheFileName
                FSD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
                Dim Thesplit2 As String() = Nothing

                If TheFileName.Contains(".") Then
                    Thesplit2 = TheFileName.Trim.Split(".")
                Else
                    FSD.Filter = "All Files|*.*"
                End If

                If Thesplit2.Count > 0 Then
                    Dim TheFilter As String = Thesplit2(1) & "|*" & Thesplit2(1)
                    FSD.Filter = TheFilter
                End If

                FSD.AddExtension = False

                If FSD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    My.Computer.FileSystem.WriteAllBytes(FSD.FileName & "." & Thesplit2(1), TheBytes, False)

                    If FileIO.FileSystem.FileExists(FSD.FileName & "." & Thesplit2(1)) Then
                        System.Diagnostics.Process.Start(FSD.FileName & "." & Thesplit2(1))
                    Else
                        MessageBox.Show("File Could not be opened." & System.Environment.NewLine & "Path: " & FSD.FileName & "." & Thesplit2(1), "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

            End If


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BarButtonItemDownload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemDownload.ItemClick
        Try

            If theSelectedTag = "" Then
                XtraMessageBox.Show("Please select a file from the list on the left before proceeding.", "Missing Selection", MessageBoxButtons.OK)
                Exit Sub
            End If

            Dim TheBytes As Byte() = GetDocumentData(theSelectedTag)
            Dim ItemDescription As String = theSelectedDescription
            'Dim TheSplit As String() = ItemDescription.Trim.Split(":")
            Dim TheFileName As String = ItemDescription

            Dim FSD As New SaveFileDialog
            FSD.FileName = TheFileName
            FSD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            Dim Thesplit2 As String() = Nothing

            If TheFileName.Contains(".") Then
                Thesplit2 = TheFileName.Trim.Split(".")
            Else
                FSD.Filter = "All Files|*.*"
            End If

            If Thesplit2.Count > 0 Then
                Dim TheFilter As String = Thesplit2(1) & "|*." & Thesplit2(1)
                FSD.Filter = TheFilter
            End If

            FSD.AddExtension = False

            If FSD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllBytes(FSD.FileName & "." & Thesplit2(1), TheBytes, False)

                If MessageBox.Show("File Successfully Downloaded, Would you like to open it?" & System.Environment.NewLine & "Path: " & FSD.FileName & "." & Thesplit2(1), "Download Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    If FileIO.FileSystem.FileExists(FSD.FileName & "." & Thesplit2(1)) Then
                        System.Diagnostics.Process.Start(FSD.FileName & "." & Thesplit2(1))
                    Else
                        MessageBox.Show("File Could not be opened." & System.Environment.NewLine & "Path: " & FSD.FileName & "." & Thesplit2(1), "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub PreviewGallery_DoubleClick(sender As Object, e As EventArgs) Handles PreviewGallery.DoubleClick
        Try
            theSelectedTag = PreviewGallery.Gallery.GetCheckedItem().Tag
            theSelectedDescription = PreviewGallery.Gallery.GetCheckedItem().Description
            theSelectedCaption = PreviewGallery.Gallery.GetCheckedItem().Caption

            Try
                theSelectedDescription = PreviewGallery.Gallery.GetCheckedItem().Description

                Dim TheBytes As Byte() = GetDocumentData(theSelectedTag)
                Dim MyMemoryStream As New System.IO.MemoryStream(TheBytes)
                PreviewPictureBox.Image = Image.FromStream(MyMemoryStream)
                CurrentImage = Image.FromStream(MyMemoryStream)
                PreviewPictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
                PicturePropertiesAccordionControl.Enabled = True
                theGeneratedFileName =  GetDocumentGeneratedName(theSelectedTag)

                AccordionControlElement1.Expanded = True
                AccordionControlElement2.Expanded = True
                AccordionControlElement4.Expanded = True
                AccordionControlElement3.Expanded = True

                BarButtonItemDelete.Enabled = True
                BarButtonItemDownload.Enabled = True
                BarButtonItemOpen.Enabled = True
                BarButtonItemSaveProperties.Enabled = True
                BarButtonPrint.Enabled = True
                BarButtonChangeDocumentation.Enabled = True

                XtraTabControlDocument.SelectedTabPageIndex = 0
            Catch ex As Exception
                PreviewPictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Clip
                PreviewPictureBox.Image = My.Resources.no_preview_300x300
                CurrentImage = Nothing
                PicturePropertiesAccordionControl.Enabled = False
                theGeneratedFileName =  GetDocumentGeneratedName(theSelectedTag)

                AccordionControlElement1.Expanded = False
                AccordionControlElement2.Expanded = False
                AccordionControlElement4.Expanded = False
                AccordionControlElement3.Expanded = True

                BarButtonItemDelete.Enabled = True
                BarButtonItemDownload.Enabled = True
                BarButtonItemOpen.Enabled = True
                BarButtonItemSaveProperties.Enabled = True
                BarButtonChangeDocumentation.Enabled = True
                BarButtonPrint.Enabled = False
                XtraTabControlDocument.SelectedTabPageIndex = 0
            End Try

            'End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

#Region "PICTURE PROPERTIES"

    Protected Overridable Sub OnChangeColor()
        If CurrentImage Is Nothing Then
            Return
        End If
        PreviewPictureBox.Image = UniversalFilter.ApplyFilter(CurrentImage, CurrentImage.Size, tbRed.Value, tbGreen.Value, tbBlue.Value)
        PreviewPictureBox.Refresh()
    End Sub

    Private Sub tbRed_EditValueChanged(sender As Object, e As EventArgs) Handles tbRed.EditValueChanged
        OnChangeColor()
    End Sub

    Private Sub tbGreen_EditValueChanged(sender As Object, e As EventArgs) Handles tbGreen.EditValueChanged
        OnChangeColor()
    End Sub

    Private Sub tbBlue_EditValueChanged(sender As Object, e As EventArgs) Handles tbBlue.EditValueChanged
        OnChangeColor()
    End Sub

    Private Sub tbBrightness_EditValueChanged(sender As Object, e As EventArgs) Handles tbBrightness.EditValueChanged
        If CurrentImage Is Nothing Then
            Return
        End If
        Dim val As Integer = tbBrightness.Value
        PreviewPictureBox.Image = UniversalFilter.ApplyFilter(CurrentImage, CurrentImage.Size, val, val, val)
        PreviewPictureBox.Refresh()
    End Sub

    Private Sub tbContrast_EditValueChanged(sender As Object, e As EventArgs) Handles tbContrast.EditValueChanged
        If CurrentImage Is Nothing Then
            Return
        End If
        Dim val As Integer = tbContrast.Value
        PreviewPictureBox.Image = ContrastFilter.ApplyFilter(CurrentImage, CurrentImage.Size, val)
        PreviewPictureBox.Refresh()
    End Sub
#End Region

#Region "Filters"
    Private _filterList As List(Of FilterBase)
    Protected Overridable ReadOnly Property FilterList() As List(Of FilterBase)
        Get
            If _filterList Is Nothing Then
                _filterList = New List(Of FilterBase)() From {New PolaroidFilter(), New BGRFilter(), New GBRFilter(), New SepiaFilter(), New GrayScaleFilter(), New NegativeFilter()}
            End If
            Return _filterList
        End Get
    End Property
    Private _universalFilter As UniversalFilter
    Protected Overridable ReadOnly Property UniversalFilter() As UniversalFilter
        Get
            If _universalFilter Is Nothing Then
                _universalFilter = New UniversalFilter()
            End If
            Return _universalFilter
        End Get
    End Property
    Private _contrastFilter As ContrastFilter
    Protected Overridable ReadOnly Property ContrastFilter() As ContrastFilter
        Get
            If _contrastFilter Is Nothing Then
                _contrastFilter = New ContrastFilter()
            End If
            Return _contrastFilter
        End Get
    End Property


#End Region

    Private Sub cmdBrowseForFile_Click(sender As Object, e As EventArgs) Handles cmdBrowseForFile.Click
        Try

            If FileTypeComboBox.SelectedIndex = -1 Then
                MessageBox.Show("Please select the File Type before proceeding.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FileTypeComboBox.PerformClick(FileTypeComboBox.Properties.Buttons(0))
                Exit Sub
            End If

            Dim OFD1 As New OpenFileDialog
            OFD1.FileName = ""
            OFD1.Multiselect = True
            OFD1.Filter = "All Files|*.*"

            If OFD1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                For Each item In OFD1.FileNames
                    InsertANewDocument(item, FileTypeComboBox.Text, BarLabelClientType.Caption)
                Next

                LoadDocuments()
                LoadDocumentCompletionRecords(BarStaticItemAccRecordID.Caption)
                UpdateAccountDocumentCompletionStatus(BarStaticItemAccRecordID.Caption, BarLabelDocumentCompletion.Caption)
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub InsertANewDocument(ByVal FileName As String, ByVal FileType As String, ByVal DocumentationType As String, ByVal Optional FileData As Byte() = Nothing)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "INSERT INTO StaffFilesData (StaffProfileID,Division,FileType,FileName,GeneratedFileName,FileStatus,RegDate,InputtedBy) VALUES( @StaffProfileID, @Division, @FileType, @FileName, @GeneratedFileName, @FileStatus, @RegDate, @InputtedBy)"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Dim GenerateFileName As String

            With ConCommand.Parameters

                .AddWithValue("@StaffProfileID", BarStaticItemAccRecordID.Caption)
                .AddWithValue("@FileType", FileType)
                .AddWithValue("@Division", DocumentationType)

                Dim FileExtension As String
                If FileName.Contains("\") Then
                    Dim FullName As String() = FileName.Trim.Split("\")
                    .AddWithValue("@FileName", FullName(FullName.Length - 1))

                    Dim thesplit As String() = FullName(FullName.Length - 1).Trim.Split(".")
                    FileExtension = thesplit(1)
                Else
                    .AddWithValue("@FileName", FileName)
                    Dim thesplit As String() = FileName.Trim.Split(".")
                    FileExtension = thesplit(1)
                End If

                GenerateFileName = GenerateDocumentFileName(FileExtension)

                .AddWithValue("@GeneratedFileName", GenerateFileName)
                .AddWithValue("@FileStatus", "Current")
                .AddWithValue("@RegDate", Date.Today)
                .AddWithValue("@InputtedBy", CurrentUserID)

            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

            'INSERT THE DOCUMENT TO THE FILE SERVER
            If FileName.Contains("\") Then
                'Dim FullName As String() = FileName.Trim.Split("\")

                If FileName.ToUpper.EndsWith("JPG") Or FileName.ToUpper.EndsWith("JPEG") Or FileName.ToUpper.EndsWith("PNG") Or FileName.ToUpper.EndsWith("BMP") Then
                    Dim MyReducedImage As Bitmap = ReduceImageSize(FileName, 0.6, 0.6)
                    Dim MyMemoryStream As New System.IO.MemoryStream()
                    MyReducedImage.Save(MyMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)

                    InsertDocumentToFileStream(GenerateFileName, MyMemoryStream.ToArray, FolderName)
                Else
                    Dim TheBytes As Byte() = My.Computer.FileSystem.ReadAllBytes(FileName)
                    InsertDocumentToFileStream(GenerateFileName, TheBytes, FolderName)
                End If

            Else
                InsertDocumentToFileStream(GenerateFileName, FileData, FolderName)
            End If

            CreateLog(CurrentUserID, FullNameofUser, "Insert of new Account Document record for " & BarStaticItemAccRecordID.Caption, 0)

        Catch Ex As Exception
            XtraMessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Function GetNoofFiles() As Integer
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT Count(ID) AS Total FROM StaffFilesData"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            If MYTABLE.Rows.Count > 0 Then
                Return MYTABLE.Rows(0).Item("Total")
            Else
                Return 0
            End If

        Catch Ex As Exception
            XtraMessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Function


    Private Function ValidateGeneratedFileName(ByVal FileName As String) As Boolean
        Try
            Dim FullPath As String = "\\" & My.Settings.FileServerAddress & "\" & My.Settings.FileServerFolder & "\" & FolderName

            If Not My.Computer.FileSystem.DirectoryExists(FullPath) Then
                My.Computer.FileSystem.CreateDirectory(FullPath)
            End If

            If My.Computer.FileSystem.DirectoryExists(FullPath) Then
                FullPath = FullPath & "\" & FileName

                If My.Computer.FileSystem.FileExists(FullPath) Then
                    Return True
                Else
                    Return False
                End If
            Else
                MessageBox.Show("Error Accessing/Creating Directory. Please Verify", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Function


    Private Function GenerateDocumentFileName(ByVal FileExtension As String) As String

A:
        Dim RandomGen As New Random
        Dim RandomValue As String = RandomGen.NextDouble.ToString
        Dim RandomSplit As String() = RandomValue.Trim.Split(".")

        Dim TotalNoofDocuments As Integer = GetNoofFiles()
        Dim GeneratedFileValue As String = DateTime.Now.ToString("yyyyMMdd-HHmmss") & "-" & TotalNoofDocuments & "-" & RandomSplit(1).Substring(3, 5) & ".dfc"

        If ValidateGeneratedFileName(GeneratedFileValue) Then
            GoTo A
        Else
            Return GeneratedFileValue
        End If

    End Function

    Private Sub BarButtonItemAddFile_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemAddFile.ItemClick
        'If BarLabelTypeofDocumentation.Caption.ToUpper.Contains("OPENING") Then
        Me.PanelSelectaDocumentSource.Visible = True
        Me.PanelSelectaDocumentSource.BringToFront()
        'Else
        '    Try

        '        Dim OFD1 As New OpenFileDialog
        '        OFD1.FileName = ""
        '        OFD1.Multiselect = False
        '        OFD1.Filter = "All Files|*.*"

        '        If OFD1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        '            InsertANewDocument(OFD1.FileName, BarLabelTypeofDocumentation.Caption, BarLabelTypeofDocumentation.Caption)
        '            LoadDocuments()
        '            LoadDocumentCompletionRecords(BarStaticItemAccRecordID.Caption)
        '            UpdateAccountDocumentCompletionStatus(BarStaticItemAccRecordID.Caption, BarLabelDocumentCompletion.Caption)
        '        End If

        '    Catch ex As Exception
        '        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        '    End Try
        'End If

    End Sub

    Private Sub cmdClosePanelDocumentSource_Click(sender As Object, e As EventArgs) Handles cmdClosePanelDocumentSource.Click
        Me.PanelSelectaDocumentSource.Visible = False
    End Sub

    Private Sub UpdateAccountDocumentCompletionStatus(ByVal RecordID As String, ByVal DocumentStatus As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "UPDATE StaffProfiles SET DocumentCompletion = @DocumentCompletion WHERE StaffProfileID = '" & RecordID & "'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            With ConCommand.Parameters
                .AddWithValue("@DocumentCompletion", DocumentStatus)
            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

        Catch Ex As Exception
            XtraMessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BarButtonItemDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemDelete.ItemClick
        If MessageBox.Show("Do you really want to delete this document?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            Try
                Dim DocumentID As String = theSelectedTag

                'DELETING THE RECORD FROM THE FILE SERVER
                Dim DocumentGeneratedName As String = GetDocumentGeneratedName(DocumentID)
                DeleteDocumentFromFileStream(DocumentGeneratedName)


                Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
                Dim Query As String = "DELETE FROM StaffFilesData WHERE ID = '" & DocumentID & "'"
                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                Conn.Open()
                ConCommand.ExecuteNonQuery()
                Conn.Close()

                CreateLog(CurrentUserID, FullNameofUser, "Delete of Account Document for Acc Record No: " & BarStaticItemAccRecordID.Caption & "", 0)

                Dim RecordID As String = BarStaticItemAccRecordID.Caption
                LoadDocuments()

                LoadDocumentCompletionRecords(BarStaticItemAccRecordID.Caption)
                UpdateAccountDocumentCompletionStatus(BarStaticItemAccRecordID.Caption, BarLabelDocumentCompletion.Caption)

                PreviewPictureBox.Image = Nothing
                PicturePropertiesAccordionControl.Enabled = False

                BarButtonItemDelete.Enabled = False
                BarButtonItemDownload.Enabled = False
                BarButtonItemOpen.Enabled = False
                BarButtonItemSaveProperties.Enabled = False

            Catch Ex As Exception
                XtraMessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK)
            End Try
        End If
    End Sub


    Private Sub DeleteDocumentFromFileStream(ByVal FileName As String)

        Try
            Dim FullPath As String = "\\" & My.Settings.FileServerAddress & "\" & My.Settings.FileServerFolder & "\" & FolderName

            If Not My.Computer.FileSystem.DirectoryExists(FullPath) Then
                My.Computer.FileSystem.CreateDirectory(FullPath)
            End If

            If My.Computer.FileSystem.DirectoryExists(FullPath) Then
                FullPath = FullPath & "\" & FileName

                If My.Computer.FileSystem.FileExists(FullPath) Then
                    My.Computer.FileSystem.DeleteFile(FullPath)
                End If

            Else
                MessageBox.Show("Error Accessing/Creating Directory. Please Verify", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Sub


    Private Sub LoadDocumentCompletionRecords(ByVal RecordID As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT FileType,FileName,FileStatus FROM StaffFilesData WHERE StaffProfileID = '" & RecordID & "' ORDER BY ID DESC "
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            Dim SavedFiles As New ArrayList

            For Each item In MYTABLE.Rows
                SavedFiles.Add(item("FileType"))
            Next

            Dim TheRequiredFiles As ArrayList = LoadAllTheRequiredFiles(BarLabelClientType.Caption)

            Dim Missing As New ArrayList

            For Each item In TheRequiredFiles
                If Not SavedFiles.Contains(item) Then
                    Missing.Add(item)
                End If
            Next

            If Missing.Count > 0 Then
                BarLabelDocumentCompletion.Caption = Missing.Count & " OUTSTANDING"
            Else
                BarLabelDocumentCompletion.Caption = "COMPLETE"
            End If

        Catch Ex As Exception
            XtraMessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub


    Private Function LoadAllTheRequiredFiles(ByVal Division As String) As ArrayList

        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String

            Query = "Select FileType From FileTypes WHERE Division = '" & Division & "'"

            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTable As New DataTable

            ConTableAdap.Fill(MyTable)

            Dim MyArraylist As New ArrayList

            If MyTable.Rows.Count > 0 Then
                For Each Record In MyTable.Rows
                    MyArraylist.Add(Record("FileType"))
                Next
            End If

            Return MyArraylist

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Function

    Private Sub cmdFlip_Click(sender As Object, e As EventArgs) Handles cmdFlip.Click
        PreviewPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PreviewPictureBox.Refresh()
    End Sub

    Private Sub cmdFlipHorizontal_Click(sender As Object, e As EventArgs) Handles cmdFlipHorizontal.Click
        PreviewPictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        PreviewPictureBox.Refresh()
    End Sub

    Private Sub cmdFlipVertical_Click(sender As Object, e As EventArgs) Handles cmdFlipVertical.Click
        PreviewPictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
        PreviewPictureBox.Refresh()
    End Sub

    Private Sub AccordionContentContainer1_Click(sender As Object, e As EventArgs) Handles AccordionContentContainer1.Click

    End Sub

    Private Sub BarButtonItemSaveProperties_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemSaveProperties.ItemClick
        Try
            'Dim FileName As String = "S" & CurrentUserID & DateTime.Now.ToString("yyyyMMddHHmmss") & ".jpg"

            Dim MyMemoryStream As New System.IO.MemoryStream()
            PreviewPictureBox.Image.Save(MyMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)

            InsertDocumentToFileStream(theGeneratedFileName, MyMemoryStream.ToArray, FolderName)
            XtraMessageBox.Show("Image was successfully saved to the File Server.", "Saved", MessageBoxButtons.OK)


            Dim RecordID As String = BarStaticItemAccRecordID.Caption
            LoadDocuments()

            LoadDocumentCompletionRecords(BarStaticItemAccRecordID.Caption)
            UpdateAccountDocumentCompletionStatus(BarStaticItemAccRecordID.Caption, BarLabelDocumentCompletion.Caption)


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Sub


    Private Sub NavBarAttachedDocuments_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarAttachedDocuments.LinkClicked
        Try
            theSelectedTag = e.Link.Item.Tag
            theSelectedDescription = e.Link.Item.Caption
            theSelectedCaption = e.Link.Item.Caption

            Try
                'theSelectedDescription = PreviewGallery.Gallery.GetCheckedItem().Description

                Dim TheBytes As Byte() = GetDocumentData(theSelectedTag)
                Dim MyMemoryStream As New System.IO.MemoryStream(TheBytes)
                PreviewPictureBox.Image = Image.FromStream(MyMemoryStream)
                CurrentImage = Image.FromStream(MyMemoryStream)
                PreviewPictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
                PicturePropertiesAccordionControl.Enabled = True
                theGeneratedFileName = GetDocumentGeneratedName(theSelectedTag)

                AccordionControlElement1.Expanded = True
                AccordionControlElement2.Expanded = True
                AccordionControlElement4.Expanded = True
                AccordionControlElement3.Expanded = True

                BarButtonItemDelete.Enabled = True
                BarButtonItemDownload.Enabled = True
                BarButtonItemOpen.Enabled = True
                BarButtonItemSaveProperties.Enabled = True
                BarButtonPrint.Enabled = True
                BarButtonChangeDocumentation.Enabled = True
                XtraTabControlDocument.SelectedTabPageIndex = 0

            Catch ex As Exception
                PreviewPictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Clip
                PreviewPictureBox.Image = My.Resources.no_preview_300x300
                CurrentImage = Nothing
                PicturePropertiesAccordionControl.Enabled = False
                theGeneratedFileName =  GetDocumentGeneratedName(theSelectedTag)

                AccordionControlElement1.Expanded = False
                AccordionControlElement2.Expanded = False
                AccordionControlElement4.Expanded = False
                AccordionControlElement3.Expanded = True

                BarButtonItemDelete.Enabled = True
                BarButtonItemDownload.Enabled = True
                BarButtonItemOpen.Enabled = True
                BarButtonItemSaveProperties.Enabled = True
                BarButtonPrint.Enabled = False
                BarButtonChangeDocumentation.Enabled =
                     XtraTabControlDocument.SelectedTabPageIndex = 0
            End Try

            'End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub UpdateDocumentTypes(ByVal ID As String, ByVal DocumentationType As String, ByVal FileType As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "UPDATE StaffFilesData SET DocumentationType = @DocumentationType, FileType = @FileType WHERE ID = '" & ID & "'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            With ConCommand.Parameters

                .AddWithValue("@FileType", FileType)
                .AddWithValue("@DocumentationType", DocumentationType)

            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

            CreateLog(CurrentUserID, FullNameofUser, "Moved a document with ID: " & ID & " to another file type of " & BarLabelTypeofDocumentation.Caption, 0)

        Catch Ex As Exception
            XtraMessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub NavBarAttachedDocuments_Click(sender As Object, e As EventArgs) Handles NavBarAttachedDocuments.Click

    End Sub

    Private Sub NavBarAttachedDocuments_DragDrop(sender As Object, e As DragEventArgs) Handles NavBarAttachedDocuments.DragDrop

    End Sub

    'Private Sub NavBarAttachedDocuments_NavDragOver(sender As Object, e As NavBarDragDropEventArgs) Handles NavBarAttachedDocuments.NavDragOver
    '    Dim item As NavBarItem = CType(e.Data.GetData(GetType(NavBarItemLink)), NavBarItemLink).Item
    '    e.Effect = System.Windows.Forms.DragDropEffects.Move
    '    e.Group.ItemLinks.Remove(item)
    'End Sub

    Private Sub NavBarAttachedDocuments_NavDragDrop(sender As Object, e As NavBarDragDropEventArgs) Handles NavBarAttachedDocuments.NavDragDrop
        Try
            'e.Group.ItemLinks.Insert(e.InsertPosition, CType(e.Data.GetData(GetType(NavBarItemLink)),NavBarItemLink).Item)

            Dim theitem = CType(e.Data.GetData(GetType(NavBarItemLink)), NavBarItemLink).Item
            'Dim TargetGroup As NavBarGroup = e.Group
            'If e.InsertPosition <> TargetGroup.VisibleItemLinks.Count Then
            '    e.Effect = DragDropEffects.None
            'End If

            UpdateDocumentTypes(theitem.Tag.ToString(), BarLabelTypeofDocumentation.Caption, e.Group.Caption)
            ReloadLoadPreviewDocuments()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonRefresh.ItemClick
        MyLoading()
    End Sub

    Private Sub BarButtonPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonPrint.ItemClick
        If CurrentImage IsNot Nothing Then
            Dim AccountTable As DataTable = GetAccountDetails(BarStaticItemAccRecordID.Caption)

            Dim MyDocument As New XtraReportPreviewDocument
            MyDocument.XrLabelDocID.Text = theSelectedTag
            MyDocument.XrLabelFullName.Text = AccountTable.Rows(0).Item("FirstName") & " " & AccountTable.Rows(0).Item("MiddleName") & " " & AccountTable.Rows(0).Item("LastName")
            MyDocument.XrLabelDepartment.Text = AccountTable.Rows(0).Item("Department")
            MyDocument.XrLabelDivision.Text = AccountTable.Rows(0).Item("Division") 'GetDocumentFileType(theSelectedTag)
            MyDocument.XrLabelStaffProfileID.Text =  AccountTable.Rows(0).Item("StaffProfileID") 'GetDocumentDocumentationFileType(theSelectedTag)
            MyDocument.XrPreviewPictureBox.Image = PreviewPictureBox.Image
            MyDocument.XrBarCodeStaffID.Text = AccountTable.Rows(0).Item("StaffID")

            Dim MyCompanyTable As New DataTable
            MyCompanyTable = GetCompanyData()
            MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable

            Dim MyViewer As New frmNewReportViewer
            MyViewer.WindowState = FormWindowState.Maximized
            MyViewer.DocumentViewer1.DocumentSource = MyDocument
            MyViewer.Show(Me)

        End If
    End Sub


    Private Function GetDocumentFileType(ByVal RecordID As String) As String
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT FileType FROM StaffFilesData WHERE ID = '" & RecordID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            If MYTABLE.Rows.Count > 0 Then
                Return MYTABLE.Rows(0).Item("FileType")
            Else
                Return ""
            End If

        Catch Ex As Exception
            XtraMessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Function

    Private Function GetDocumentDocumentationFileType(ByVal RecordID As String) As String
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT DocumentationType FROM StaffFilesData WHERE ID = '" & RecordID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            If MYTABLE.Rows.Count > 0 Then
                Return MYTABLE.Rows(0).Item("DocumentationType")
            Else
                Return ""
            End If

        Catch Ex As Exception
            XtraMessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Function

    Private Function GetAccountDetails(ByVal StaffProfileID As String) As DataTable

        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String

            Query = "Select * From StaffProfiles WHERE StaffProfileID = '" & StaffProfileID & "'"

            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTable As New DataTable

            ConTableAdap.Fill(MyTable)

            Return MyTable
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try

    End Function

    Private Sub cmdClosePanelDocumentation_Click(sender As Object, e As EventArgs) Handles cmdClosePanelDocumentation.Click
        Me.PanelDocumentationType.Visible = False
    End Sub

    Private Sub cmdAcceptDocumentChange_Click(sender As Object, e As EventArgs) Handles cmdAcceptDocumentChange.Click
        If MessageBox.Show("Do you really wish to transfer the current opened document to " & DivisionComboBox.Text & " documentation type as " & FileTypeChangeComboBox.Text & " ?", "Changing Type", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            UpdateDocumentTypes(theSelectedTag, DivisionComboBox.Text, FileTypeChangeComboBox.Text)
            Me.PanelDocumentationType.Visible = False
            LoadDocuments()
            PreviewPictureBox.Image = Nothing
        End If
    End Sub

    Private Sub BarButtonChangeDocumentation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonChangeDocumentation.ItemClick
        Me.PanelDocumentationType.Visible = True
    End Sub

    Private Sub DocumentationTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DivisionComboBox.SelectedIndexChanged
        LoadChangedFileType(DivisionComboBox.Text, BarLabelClientType.Caption)
        FileTypeChangeComboBox.Text = ""
    End Sub

    Private Sub cmdClosePanelFlatbedScan_Click(sender As Object, e As EventArgs) Handles cmdClosePanelFlatbedScan.Click
        Me.PanelFlatbedScan.Visible = False
    End Sub

    Private Sub cmdClosePanelMethodofScanning_Click(sender As Object, e As EventArgs) Handles cmdClosePanelMethodofScanning.Click
        Me.PanelMethodofScanning.Visible = False
    End Sub

    Private Sub cmdSinglePaperScan_Click(sender As Object, e As EventArgs) Handles cmdSinglePaperScan.Click
        Me.PanelMethodofScanning.Visible = False
        Me.PanelFlatbedScan.Visible = True
        Me.PanelFlatbedScan.BringToFront()
    End Sub

    Private Sub BarButtonScanningPreferences_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonScanningPreferences.ItemClick
        _forCapabilities = False
        Using DeviceItemsDlg As WiaDeviceItemsForm = New WiaDeviceItemsForm()
            DeviceItemsDlg.MainForm = Me
            If DeviceItemsDlg.ShowDialog(Me) = DialogResult.OK Then
                Using PropertiesDlg As WiaPropertiesForm = New WiaPropertiesForm()
                    PropertiesDlg.MainForm = Me
                    If PropertiesDlg.ShowDialog(Me) = DialogResult.OK Then
                        If _errorList.Count > 0 Then
                            Using ErrorsDlg As WiaPropertiesErrorsForm = New WiaPropertiesErrorsForm()
                                ErrorsDlg.MainForm = Me
                                ErrorsDlg.ShowDialog(Me)
                            End Using
                        End If
                    End If
                End Using
            End If
        End Using
    End Sub

    Private Sub BarButtonErrorCodes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonErrorCodes.ItemClick
        Using ErrorsDlg As WiaPropertiesErrorsForm = New WiaPropertiesErrorsForm()
            ErrorsDlg.MainForm = Me
            ErrorsDlg.ShowDialog(Me)
        End Using
    End Sub

    Private Sub BarButtonSupportedCapabilities_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonSupportedCapabilities.ItemClick
        _forCapabilities = True
        Using DeviceItemsDlg As WiaDeviceItemsForm = New WiaDeviceItemsForm()
            DeviceItemsDlg.MainForm = Me
            If DeviceItemsDlg.ShowDialog(Me) = DialogResult.OK Then
                Using SupportedCapsDlg As SupportedCapabilitiesForm = New SupportedCapabilitiesForm()
                    SupportedCapsDlg.MainForm = Me
                    SupportedCapsDlg.ShowDialog(Me)
                End Using
            End If
        End Using
    End Sub

    Private Sub BarButtonSupportedFormats_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonSupportedFormats.ItemClick
        _forCapabilities = True
        Using DeviceItemsDlg As WiaDeviceItemsForm = New WiaDeviceItemsForm()
            DeviceItemsDlg.MainForm = Me
            If DeviceItemsDlg.ShowDialog(Me) = DialogResult.OK Then
                Using SupportedFormatsDlg As SupportedFormatsForm = New SupportedFormatsForm()
                    SupportedFormatsDlg.MainForm = Me
                    SupportedFormatsDlg.ShowDialog(Me)
                End Using
            End If
        End Using
    End Sub

    Private Sub BarButtonAcquireOptions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonAcquireOptions.ItemClick
        Using AcquireOptionsDlg As AcquireOptionsForm = New AcquireOptionsForm()
            AcquireOptionsDlg.MainForm = Me
            AcquireOptionsDlg.ShowDialog(Me)
        End Using
    End Sub

    Private Sub BarToggleSwitchScanUI_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarToggleSwitchScanUI.CheckedChanged
        _showUserInterface = BarToggleSwitchScanUI.Checked
    End Sub

    Private Sub BarButtonSelectScanner_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonSelectScanner.ItemClick
        Try

            Dim res As DialogResult = _wiaSession.SelectDeviceDlg(Me.Handle, WiaDeviceType.Scanner, WiaSelectSourceFlags.NoDefault)

            If res = DialogResult.OK Then
                _wiaSourceSelected = True
                If _wiaSession.SelectedDeviceType = WiaDeviceType.StreamingVideo Then
                    _wiaVideoStreamSource = True
                Else
                    _wiaVideoStreamSource = False
                End If
            End If
        Catch ex As Exception
            _wiaSourceSelected = False
            _wiaVideoStreamSource = False
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub _wiaSession_AcquireEvent(ByVal sender As Object, ByVal e As WiaAcquireEventArgs)
        Dim strInfoMsg As String

        ' Update the progress bar with the received percent value;
        If _progressDlg.Visible Then
            ' Show the user some information about the file we are acquiring 
            ' to (if the user chooses file transfer).

            If (e.Flags And WiaAcquiredPageFlags.StartOfPage) = WiaAcquiredPageFlags.StartOfPage Then
                If _transferMode = WiaTransferMode.File Then
                    strInfoMsg = String.Format("Transferring to file: " & Constants.vbLf + Constants.vbLf & "{0}", e.FileName)
                    _progressDlg.InformationString = strInfoMsg
                End If
            End If

            If ((e.Flags And WiaAcquiredPageFlags.StartOfPage) = WiaAcquiredPageFlags.StartOfPage) AndAlso ((e.Flags And WiaAcquiredPageFlags.EndOfPage) <> WiaAcquiredPageFlags.EndOfPage) Then
                _progressDlg.Percent = 0
            Else
                _progressDlg.Percent = CInt(e.Percent)
            End If

            Application.DoEvents()

            If _progressDlg.Abort Then
                e.Cancel = True
            End If
        End If

        If Not _transferMode = WiaTransferMode.File Then
            If Not e.Image Is Nothing Then
                _scanCount += 1
                Dim childCaption As String = String.Format("WIA Scanned page {0}", _scanCount.ToString())

                MyViewer.Image = e.Image

                If XtraTabPageScanningDesk.Controls.Count = 0 Then
                    MyViewer.Dock = DockStyle.Fill
                    XtraTabPageScanningDesk.Controls.Add(MyViewer)
                End If

                XtraTabPageScanningDesk.Text = childCaption
                MyScannedImages(_scanCount) = e.Image

                Application.DoEvents()
            End If
        End If
    End Sub

    Private Function SelectAcquireSource(ByVal ScanType As String) As DialogResult
        _forCapabilities = True

        Dim dlgResult As DialogResult = DialogResult.Cancel

        Using DeviceItemsDlg As WiaDeviceItemsForm = New WiaDeviceItemsForm()
            DeviceItemsDlg.MainForm = Me
            DeviceItemsDlg.WiaDeviceItemsForm_Load()

            If DeviceItemsDlg._tvWiaDeviceItems.Nodes.Count > 0 Then
                If DeviceItemsDlg._tvWiaDeviceItems.Nodes(0).Nodes.Count > 0 Then
                    If DeviceItemsDlg._tvWiaDeviceItems.Nodes(0).Nodes.Count > 1 Then
                        If ScanType = "Flatbed" Then
                            DeviceItemsDlg._tvWiaDeviceItems.SelectedNode = DeviceItemsDlg._tvWiaDeviceItems.Nodes(0).Nodes(0)
                        Else
                            DeviceItemsDlg._tvWiaDeviceItems.SelectedNode = DeviceItemsDlg._tvWiaDeviceItems.Nodes(0).Nodes(1)
                        End If
                    Else
                        DeviceItemsDlg._tvWiaDeviceItems.SelectedNode = DeviceItemsDlg._tvWiaDeviceItems.Nodes(0).Nodes(0)
                    End If

                    Me._selectedWiaItem = (CType(DeviceItemsDlg._tvWiaDeviceItems.SelectedNode.Tag, ItemData)).Item
                    dlgResult = DialogResult.OK

                End If

                _sourceItem = _selectedWiaItem

                'dlgResult = DeviceItemsDlg.ShowDialog(Me)
                'If dlgResult = DialogResult.OK Then

                'End If
            End If

        End Using

        Return dlgResult
    End Function

    Private Sub _wiaSession_EnumItemsEvent(ByVal sender As Object, ByVal e As WiaEnumItemsEventArgs)
        _enumeratedWiaItems.Add(e.Item)
    End Sub

    Private Sub cmdStatFlatbedScan_Click(sender As Object, e As EventArgs) Handles cmdStatFlatbedScan.Click
        Dim flags As WiaAcquireFlags = WiaAcquireFlags.NoDefault
        Dim showProgress As Boolean = True
        _scanCount = 0

        PrepareScanFolder()

        _transferMode = WiaTransferMode.File

        _progressDlg = New frmProgressForm("Transferring...", "", 100)

        _progressDlg.Location = New Point(15, (Me.Height - _progressDlg.Height - 20))

        _wiaAcquiring = True

        If _showUserInterface Then
            flags = WiaAcquireFlags.UseCommonUI Or WiaAcquireFlags.ShowUserInterface
        Else
            ' Check if the selected device is scanner and that it has multiple sources (Feeder & Flatbed)
            ' then show the select source dialog box.
            If SelectAcquireSource("Flatbed") <> DialogResult.OK Then
                _wiaAcquiring = False
                Return
            End If
        End If

        If _showUserInterface Then
            If _wiaVersion = WiaVersion.Version2 Then
                showProgress = False
            End If
        End If

        If showProgress Then
            ' Show the progress dialog.
            _progressDlg.Show(Me)
        End If

        Try
            XtraTabControlDocument.SelectedTabPageIndex = 1
            ScanPreviewPictureBox.Image = Nothing

            Dim therandom As New Random
            Dim theScanFileName As String = "FL" & Now.ToString("ddMMhhmmss") & therandom.NextDouble.ToString().Substring(7, 2) & CurrentUserID & ".JPG"

            _wiaAcquireOptions.FileName = ScanFullPath & "\" & theScanFileName
            _wiaSession.AcquireOptions = _wiaAcquireOptions

            If _wiaProperties.DataTransfer.TransferMode = WiaTransferMode.None Then ' GetProperties() method not called yet.
                _transferMode = WiaTransferMode.Memory
            Else
                _transferMode = _wiaProperties.DataTransfer.TransferMode
            End If

            ' Disable the minimize and maximize buttons.
            Me.MinimizeBox = False
            Me.MaximizeBox = False

            '#If Not LEADTOOLS_V19_OR_LATER Then
            'Dim dlgResult As DialogResult = _wiaSession.Acquire(Me, _sourceItem, flags)
            '#Else
            '#End If ' #If Not LEADTOOLS_V19_OR_LATER Then

            Dim dlgResult As DialogResult = _wiaSession.Acquire(Me.Handle, _sourceItem, flags)

            If (dlgResult <> DialogResult.OK) Then
                Return
            End If

            If My.Computer.FileSystem.FileExists(ScanFullPath & "\" & theScanFileName) Then
                'GET THE SCANNED FILE AND CONVERT IT TO BYTES 
                Dim TheImage As Image = ReduceImageSize(ScanFullPath & "\" & theScanFileName, 0, 0)

                'theimage = Me._twain32.GetImage(0)

                ScanPreviewPictureBox.Image = TheImage

                InsertANewDocument(ScanFullPath & "\" & theScanFileName, ScanFileTypeComboBox.Text, ScanDivisionComboBox.Text)
                LoadDocuments()
                LoadDocumentCompletionRecords(BarStaticItemAccRecordID.Caption)

                ' Enable back the minimize and maximize buttons.
                Me.MinimizeBox = True
                Me.MaximizeBox = True

                If _progressDlg.Visible Then
                    If (Not _progressDlg.Abort) Then
                        _progressDlg.Dispose()
                    End If
                End If

                If Not _sourceItem Is Nothing Then
                    _sourceItem = Nothing
                End If

            End If


            'If _wiaSession.FilesCount > 0 Then ' This property indicates how many files where saved when the transfer mode is File mode.
            '    Dim strMsg As String = "Acquired page was saved to:" & Constants.vbLf + Constants.vbLf
            '    If _wiaSession.FilesPaths.Count > 0 Then
            '        Dim i As Integer = 0
            '        Do While i < _wiaSession.FilesPaths.Count
            '            Dim strTemp As String = String.Format("{0}" & Constants.vbLf, _wiaSession.FilesPaths(i))
            '            strMsg &= strTemp
            '            i += 1
            '        Loop
            '        MessageBox.Show(Me, strMsg, "File Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    End If
            'Else
            '    If _wiaVersion = WiaVersion.Version2 Then
            '        'WIA 2.0 sometimes doesn't return the acquired files count and paths, so this message will show 
            '        'the directory where the saved files were saved.
            '        Dim len As Integer = _wiaAcquireOptions.FileName.LastIndexOf("\")
            '        Dim strFilesDirectory As String = _wiaAcquireOptions.FileName.Substring(0, len)
            '        Dim strMsg As String = String.Format("Acquired page was saved to: {0}{1}{2}", Constants.vbLf, Constants.vbLf, strFilesDirectory)
            '        MessageBox.Show(Me, strMsg, "File Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    End If
            'End If

            _wiaAcquiring = False
        Catch ex As Exception
            ' Enable back the minimize and maximize buttons.
            Me.MinimizeBox = True
            Me.MaximizeBox = True

            _wiaAcquiring = False
            If _progressDlg.Visible Then
                If (Not _progressDlg.Abort) Then
                    _progressDlg.Dispose()
                End If
            End If

            Messager.ShowError(Me, ex)
        Finally
            ' Enable back the minimize and maximize buttons.
            Me.MinimizeBox = True
            Me.MaximizeBox = True

            _wiaAcquiring = False
        End Try
    End Sub

    Private Sub PrepareScanFolder()
        Try

            If Not My.Computer.FileSystem.DirectoryExists(ScanFullPath) Then
                My.Computer.FileSystem.CreateDirectory(ScanFullPath)
            End If

            If My.Computer.FileSystem.DirectoryExists(ScanFullPath) Then
                For Each thefile In Directory.GetFiles(ScanFullPath)
                    My.Computer.FileSystem.DeleteFile(thefile)
                Next
            Else
                MessageBox.Show("Error Accessing/Creating Directory. Please Verify", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cmdMultiPaperScan_Click(sender As Object, e As EventArgs) Handles cmdMultiPaperScan.Click

        Dim TheDocumenTypes As New frmScanDocumentTypeandQuantity

        DocumentTypeandQuantityDataTable.Rows.Clear()

        Dim theno As Integer = 1
        For Each item In FileTypeComboBox.Properties.Items
            DocumentTypeandQuantityDataTable.Rows.Add(theno, item, "")
            theno += 1
        Next

        If TheDocumenTypes.ShowDialog = DialogResult.OK Then

            Dim DocumentsScanPrepList As New ArrayList

            For Each item In DocumentTypeandQuantityDataTable.Rows
                If IsNumeric(item("Quantity")) Then
                    If CInt(item("Quantity")) > 0 Then
                        For i = 1 To CInt(item("Quantity"))
                            DocumentsScanPrepList.Add(item("FileType"))
                        Next
                    End If
                End If
            Next

            PrepareScanFolder()

            _scanCount = 0

            ScanPreviewPictureBox.Image = Nothing
            XtraTabControlDocument.SelectedTabPageIndex = 1

            For Each item In DocumentsScanPrepList

                Dim therandom As New Random
                Dim theScanFileName As String = "FD" & Now.ToString("ddMMhhmmss") & therandom.NextDouble.ToString().Substring(7, 3) & CurrentUserID & ".JPG"

                _wiaAcquireOptions.FileName = ScanFullPath & "\" & theScanFileName
                _wiaAcquireOptions.OverwriteExisting = False

                _progressDlg = New frmProgressForm("Transferring...", "", 100)

                _progressDlg.Location = New Point(15, (Me.Height - _progressDlg.Height - 20))

                _wiaAcquiring = True


                Dim flags As WiaAcquireFlags = WiaAcquireFlags.None
                Dim showProgress As Boolean = True

                If _showUserInterface Then
                    flags = WiaAcquireFlags.UseCommonUI Or WiaAcquireFlags.ShowUserInterface
                Else
                    ' Check if the selected device is scanner and that it has multiple sources (Feeder & Flatbed)
                    ' then show the select source dialog box.
                    If SelectAcquireSource("Feeder") <> DialogResult.OK Then
                        _wiaAcquiring = False
                        Return
                    End If
                End If

                If _showUserInterface Then
                    If _wiaVersion = WiaVersion.Version2 Then
                        showProgress = False
                    End If
                End If

                If showProgress Then
                    ' Show the progress dialog.
                    _progressDlg.Show(Me)
                End If

                Try
                    _wiaSession.AcquireOptions = _wiaAcquireOptions

                    'SetWIAProperty(Item.Properties, WIA_IPS_PAGE_SIZE, 0);

                    If _wiaProperties.DataTransfer.TransferMode = WiaTransferMode.None Then ' GetProperties() method not called yet.
                        _transferMode = WiaTransferMode.Memory
                    Else
                        _transferMode = _wiaProperties.DataTransfer.TransferMode
                    End If

                    _wiaProperties.MaximumNumberOfPages = DocumentsScanPrepList.Count
                    _wiaProperties.ScanningMode = WiaScanningModeFlags.AutoAdvance
                    _wiaProperties.ImageType = WiaImageType.Color

                    _wiaSession.SetProperties(_selectedWiaItem, _wiaProperties)

                    ' Disable the minimize and maximize buttons.
                    Me.MinimizeBox = False
                    Me.MaximizeBox = False

                    Dim dlgResult As DialogResult = _wiaSession.Acquire(Me.Handle, _sourceItem, flags)

                    If (dlgResult <> DialogResult.OK) Then
                        Return
                    End If

                    If My.Computer.FileSystem.FileExists(ScanFullPath & "\" & theScanFileName) Then
                        'GET THE SCANNED FILE AND CONVERT IT TO BYTES 
                        Dim TheImage As Image = ReduceImageSize(ScanFullPath & "\" & theScanFileName, 0, 0)

                        'theimage = Me._twain32.GetImage(0)

                        ScanPreviewPictureBox.Image = TheImage

                        InsertANewDocument(ScanFullPath & "\" & theScanFileName, item, BarLabelClientType.Caption)

                        ' Enable back the minimize and maximize buttons.
                        Me.MinimizeBox = True
                        Me.MaximizeBox = True

                        If _progressDlg.Visible Then
                            If (Not _progressDlg.Abort) Then
                                _progressDlg.Dispose()
                            End If
                        End If

                        If Not _sourceItem Is Nothing Then
                            _sourceItem = Nothing
                        End If

                    End If


                    'If _wiaSession.FilesCount > 0 Then ' This property indicates how many files where saved when the transfer mode is File mode.
                    '    Dim strMsg As String = "Acquired page(s) were saved to:" & Constants.vbLf + Constants.vbLf
                    '    If _wiaSession.FilesPaths.Count > 0 Then
                    '        Dim i As Integer = 0
                    '        Do While i < _wiaSession.FilesPaths.Count
                    '            Dim strTemp As String = String.Format("{0}" & Constants.vbLf, _wiaSession.FilesPaths(i))
                    '            strMsg &= strTemp
                    '            i += 1
                    '        Loop
                    '        MessageBox.Show(Me, strMsg, "File Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '    End If
                    'Else
                    '    If _wiaVersion = WiaVersion.Version2 Then
                    '        'WIA 2.0 sometimes doesn't return the acquired files count and paths, so this message will show 
                    '        'the directory where the saved files were saved.
                    '        Dim len As Integer = _wiaAcquireOptions.FileName.LastIndexOf("\")
                    '        Dim strFilesDirectory As String = _wiaAcquireOptions.FileName.Substring(0, len)
                    '        Dim strMsg As String = String.Format("Acquired page(s) were saved to:{0}{1}{2}", Constants.vbLf, Constants.vbLf, strFilesDirectory)
                    '        MessageBox.Show(Me, strMsg, "File Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '    End If
                    'End If

                Catch ex As Exception
                    ' Enable back the minimize and maximize buttons.
                    Me.MinimizeBox = True
                    Me.MaximizeBox = True

                    _wiaAcquiring = False
                    If _progressDlg.Visible Then
                        If (Not _progressDlg.Abort) Then
                            _progressDlg.Dispose()
                        End If
                    End If

                    Messager.ShowError(Me, ex)
                Finally
                    ' Enable back the minimize and maximize buttons.
                    Me.MinimizeBox = True
                    Me.MaximizeBox = True

                    _wiaAcquiring = False
                End Try

            Next

            PanelMethodofScanning.Visible = False
            _wiaAcquiring = False
            LoadDocuments()
            LoadDocumentCompletionRecords(BarStaticItemAccRecordID.Caption)

        End If

    End Sub

    Private Sub BarButtonItemNewScan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemNewScan.ItemClick
        PanelMethodofScanning.Visible = True
        PanelMethodofScanning.BringToFront()
        PanelFlatbedScan.Visible = False
    End Sub

    Private Sub ScanDocumentTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ScanDivisionComboBox.SelectedIndexChanged
        LoadScanFileType(ScanDivisionComboBox.Text, BarLabelClientType.Caption)
    End Sub

    Private Sub BarButtonApproveSelected_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonApproveSelected.ItemClick
        UpdateAccountDocumentSupervisionStatus(theSelectedTag, "Approved")

        For Each item As GalleryItem In PreviewGallery.Gallery.GetAllItems
            If item.Caption = theSelectedCaption Then
                Dim thesplit As String() = item.Caption.Trim.Split("(")
                item.Caption = theSelectedTag & "(APPROVED)"
                item.Hint = GetDocumentGeneratedName(theSelectedTag) & " (" & FullNameofUser & ")"
                item.AppearanceCaption.Normal.ForeColor = Color.LightGreen
            End If
        Next

        XtraMessageBox.Show("Operation completed successfully!", "Done", MessageBoxButtons.OK)

    End Sub

    Private Sub UpdateAccountDocumentSupervisionStatus(ByVal ID As String, ByVal ApprovalStatus As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "UPDATE StaffFilesData SET ApprovalStatus = @ApprovalStatus, SupervisedBy = @SupervisedBy, SupervisorID = @SupervisorID WHERE ID = '" & ID & "'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            With ConCommand.Parameters
                .AddWithValue("@ApprovalStatus", ApprovalStatus)
                .AddWithValue("@SupervisedBy", FullNameofUser)
                .AddWithValue("@SupervisorID", CurrentUserID)
            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

        Catch Ex As Exception
            XtraMessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub BarButtonDisapproveSelected_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonDisapproveSelected.ItemClick
        UpdateAccountDocumentSupervisionStatus(theSelectedTag, "Disapproved")

        For Each item As GalleryItem In PreviewGallery.Gallery.GetAllItems
            If item.Caption = theSelectedCaption Then
                Dim thesplit As String() = item.Caption.Trim.Split("(")
                item.Caption = theSelectedTag & "(DISAPPROVED)"
                item.Hint = GetDocumentGeneratedName(theSelectedTag) & " (" & FullNameofUser & ")"
                item.AppearanceCaption.Normal.ForeColor = Color.Red
            End If
        Next

        XtraMessageBox.Show("Operation completed successfully!", "Done", MessageBoxButtons.OK)

    End Sub

    Private Sub BarButtonApproveAll_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonApproveAll.ItemClick
        If XtraMessageBox.Show("Do you wish to APPROVE all unsupervised documents of the account?", "Caution", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim theTable As DataTable = GetAllUnsupervisedDocuments()

            For Each record In theTable.Rows
                UpdateAccountDocumentSupervisionStatus(record("ID"), "Approved")
            Next

            LoadDocuments()
            LoadDocumentCompletionRecords(BarStaticItemAccRecordID.Caption)
            UpdateAccountDocumentCompletionStatus(BarStaticItemAccRecordID.Caption, BarLabelDocumentCompletion.Caption)

            XtraMessageBox.Show("Operation completed successfully!", "Done", MessageBoxButtons.OK)

        End If
    End Sub

    Private Function GetAllUnsupervisedDocuments() As DataTable
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = ""

            If BarLabelTypeofDocumentation.Caption.ToUpper.Contains("ALL") Then
                Query = " SELECT ID, FileName, GeneratedFileName, FileStatus, FileType FROM " & TableName & " WHERE " & ForeignKeyField & " = '" & ForeignKeyValue & "' AND ApprovalStatus IN ('Disapproved', 'New')) ORDER BY ID DESC"
            Else
                Query = " SELECT ID, FileName, GeneratedFileName, FileStatus, FileType FROM " & TableName & " WHERE " & ForeignKeyField & " = '" & ForeignKeyValue & "' AND FileType = '" & BarLabelTypeofDocumentation.Caption & "' AND ApprovalStatus IN ('Disapproved', 'New')) ORDER BY ID DESC"
            End If

            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            Return MYTABLE

        Catch Ex As Exception
            XtraMessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK)
            Return New DataTable
        End Try
    End Function

    Private Function GetAllSupervisedByMeDocuments() As DataTable
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = ""

            If BarLabelTypeofDocumentation.Caption.ToUpper.Contains("ALL") Then
                Query = " SELECT ID, FileName, GeneratedFileName, FileStatus, FileType FROM " & TableName & " WHERE " & ForeignKeyField & " = '" & ForeignKeyValue & "' AND ApprovalStatus = 'Approved' AND SupervisorID = '" & CurrentUserID & "' ORDER BY ID DESC"
            Else
                Query = " SELECT ID, FileName, GeneratedFileName, FileStatus, FileType FROM " & TableName & " WHERE " & ForeignKeyField & " = '" & ForeignKeyValue & "' AND FileType = '" & BarLabelTypeofDocumentation.Caption & "' AND ApprovalStatus = 'Approved' AND SupervisorID = '" & CurrentUserID & "' ORDER BY ID DESC"
            End If

            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            Return MYTABLE

        Catch Ex As Exception
            XtraMessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK)
            Return New DataTable
        End Try
    End Function

    Private Function GetAllDocuments() As DataTable
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = ""

            If BarLabelTypeofDocumentation.Caption.ToUpper.Contains("ALL") Then
                Query = " SELECT ID, FileName, GeneratedFileName, FileStatus, FileType FROM " & TableName & " WHERE " & ForeignKeyField & " = '" & ForeignKeyValue & "' ORDER BY ID DESC"
            Else
                Query = " SELECT ID, FileName, GeneratedFileName, FileStatus, FileType FROM " & TableName & " WHERE " & ForeignKeyField & " = '" & ForeignKeyValue & "' AND FileType = '" & BarLabelTypeofDocumentation.Caption & "' ORDER BY ID DESC"
            End If

            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            Return MYTABLE

        Catch Ex As Exception
            XtraMessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK)
            Return New DataTable
        End Try
    End Function

    Private Sub BarButtonDisaproveAll_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonDisaproveAll.ItemClick
        If XtraMessageBox.Show("Do you wish to DISAPPROVE all unsupervised documents of the account?", "Caution", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim theTable As DataTable = GetAllUnsupervisedDocuments()

            For Each record In theTable.Rows
                UpdateAccountDocumentSupervisionStatus(record("ID"), "Disapproved")
            Next

            LoadDocuments()
            LoadDocumentCompletionRecords(BarStaticItemAccRecordID.Caption)
            UpdateAccountDocumentCompletionStatus(BarStaticItemAccRecordID.Caption, BarLabelDocumentCompletion.Caption)

            XtraMessageBox.Show("Operation completed successfully!", "Done", MessageBoxButtons.OK)

        End If

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonReturnAll.ItemClick
        If XtraMessageBox.Show("Do you wish to DISAPPROVE all documents of the account?", "Caution", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim theTable As DataTable = GetAllUnsupervisedDocuments()

            For Each record In theTable.Rows
                UpdateAccountDocumentSupervisionStatus(record("ID"), "Disapproved")
            Next

            LoadDocuments()
            LoadDocumentCompletionRecords(BarStaticItemAccRecordID.Caption)
            UpdateAccountDocumentCompletionStatus(BarStaticItemAccRecordID.Caption, BarLabelDocumentCompletion.Caption)

            XtraMessageBox.Show("Operation completed successfully!", "Done", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub BarButtonDisapproveAllsupervised_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonDisapproveAllsupervised.ItemClick
        If XtraMessageBox.Show("Do you wish to DISAPPROVE all documents of this account supervised by you?", "Caution", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim theTable As DataTable = GetAllUnsupervisedDocuments()

            For Each record In theTable.Rows
                UpdateAccountDocumentSupervisionStatus(record("ID"), "Disapproved")
            Next

            LoadDocuments()
            LoadDocumentCompletionRecords(BarStaticItemAccRecordID.Caption)
            UpdateAccountDocumentCompletionStatus(BarStaticItemAccRecordID.Caption, BarLabelDocumentCompletion.Caption)

            XtraMessageBox.Show("Operation completed successfully!", "Done", MessageBoxButtons.OK)
        End If
    End Sub
End Class

Public Class ItemData
    Private _item As Object
    Private _node As Object

    Public Sub New(ByVal wiaItem As Object)
        _item = wiaItem
    End Sub

    Public Property Item() As Object
        Get
            Return _item
        End Get
        Set(ByVal value As Object)
            _item = value
        End Set
    End Property

    'Used to save corresponding TreeNode.
    Public Property Node() As Object
        Get
            Return _node
        End Get
        Set(ByVal value As Object)
            _node = value
        End Set
    End Property
End Class

#Region "IMAGE PROPERTIES CLASSES"

Public Class UniversalFilter
    Inherits FilterBase
    Public Sub New()
        b = 0
        g = b
        r = g
    End Sub
    Private r, g, b As Integer
    Public Shadows Function ApplyFilter(ByVal image As Image, ByVal size As Size, ByVal r As Integer, ByVal g As Integer, ByVal b As Integer) As Image
        Me.r = r
        Me.g = g
        Me.b = b
        Return ApplyMatrix(image, size, Matrix)
    End Function
    Public Overrides ReadOnly Property Name() As String
        Get
            Return "Universal"
        End Get
    End Property
    Protected Overrides ReadOnly Property Matrix() As ColorMatrix
        Get
            Return New ColorMatrix(New Single()() {New Single() {1 + CSng(r / 255.0F), 0, 0, 0, 0}, New Single() {0, 1 + CSng(g / 255.0F), 0, 0, 0}, New Single() {0, 0, 1 + CSng(b / 255.0F), 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0.1F, 0.1F, 0.1F, 0, 1}})
        End Get
    End Property
End Class
Public Class PolaroidFilter
    Inherits FilterBase
    Public Overrides ReadOnly Property Name() As String
        Get
            Return "Polaroid"
        End Get
    End Property
    Protected Overrides ReadOnly Property Matrix() As ColorMatrix
        Get
            Return New ColorMatrix(New Single()() {New Single() {1.438F, -0.062F, -0.062F, 0, 0}, New Single() {-0.122F, 1.378F, -0.122F, 0, 0}, New Single() {0.016F, -0.016F, 1.438F, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0.03F, 0.05F, -0.2F, 0, 1}})
        End Get
    End Property
End Class
Public Class GrayScaleFilter
    Inherits FilterBase
    Public Overrides ReadOnly Property Name() As String
        Get
            Return "GrayScale"
        End Get
    End Property
    Protected Overrides ReadOnly Property Matrix() As ColorMatrix
        Get
            Return New ColorMatrix(New Single()() {New Single() {0.3F, 0.3F, 0.3F, 0, 0}, New Single() {0.59F, 0.59F, 0.59F, 0, 0}, New Single() {0.11F, 0.11F, 0.11F, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1}})
        End Get
    End Property
End Class
Public Class NegativeFilter
    Inherits FilterBase
    Public Overrides ReadOnly Property Name() As String
        Get
            Return "Negative"
        End Get
    End Property
    Protected Overrides ReadOnly Property Matrix() As ColorMatrix
        Get
            Return New ColorMatrix(New Single()() {New Single() {-1, 0, 0, 0, 0}, New Single() {0, -1, 0, 0, 0}, New Single() {0, 0, -1, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {1, 1, 1, 0, 1}})
        End Get
    End Property
End Class
Public Class SepiaFilter
    Inherits FilterBase
    Public Overrides ReadOnly Property Name() As String
        Get
            Return "Sepia"
        End Get
    End Property
    Protected Overrides ReadOnly Property Matrix() As ColorMatrix
        Get
            Return New ColorMatrix(New Single()() {New Single() {0.393F, 0.349F, 0.272F, 0, 0}, New Single() {0.769F, 0.686F, 0.534F, 0, 0}, New Single() {0.189F, 0.168F, 0.131F, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1}})
        End Get
    End Property
End Class
Public Class BGRFilter
    Inherits FilterBase
    Public Overrides ReadOnly Property Name() As String
        Get
            Return "BGR"
        End Get
    End Property
    Protected Overrides ReadOnly Property Matrix() As ColorMatrix
        Get
            Return New ColorMatrix(New Single()() {New Single() {0, 0, 1, 0, 0}, New Single() {0, 1, 0, 0, 0}, New Single() {1, 0, 0, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1}})
        End Get
    End Property
End Class
Public Class GBRFilter
    Inherits FilterBase
    Public Overrides ReadOnly Property Name() As String
        Get
            Return "GBR"
        End Get
    End Property
    Protected Overrides ReadOnly Property Matrix() As ColorMatrix
        Get
            Return New ColorMatrix(New Single()() {New Single() {0, 1, 0, 0, 0}, New Single() {0, 0, 1, 0, 0}, New Single() {1, 0, 0, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1}})
        End Get
    End Property
End Class
Public Class ContrastFilter
    Inherits FilterBase
    Public Sub New()
        translate = 0
        scale = translate
    End Sub
    Private scale As Single
    Private translate As Single
    Public Overrides ReadOnly Property Name() As String
        Get
            Return "Contrast"
        End Get
    End Property
    Public Shadows Function ApplyFilter(ByVal image As Image, ByVal size As Size, ByVal val As Integer) As Image
        scale = val
        translate = (-0.5F * scale + 0.5F) * 255.0F
        Return ApplyMatrix(image, size, Matrix)
    End Function
    Protected Overrides ReadOnly Property Matrix() As ColorMatrix
        Get
            Return New ColorMatrix(New Single()() {New Single() {1 + scale / 100, 0, 0, 0, translate}, New Single() {0, 1 + scale / 100, 0, 0, translate}, New Single() {0, 0, 1 + scale / 100, 0, translate}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1}})
        End Get
    End Property
End Class
Public Class FilterBase
    Public Overridable ReadOnly Property Name() As String
        Get
            Return String.Empty
        End Get
    End Property
    Public Function ApplyFilter(ByVal image As Image, ByVal size As Size) As Image
        Return ApplyMatrix(image, size, Matrix)
    End Function
    Protected Overridable ReadOnly Property Matrix() As ColorMatrix
        Get
            Return New ColorMatrix()
        End Get
    End Property
    Protected Function ApplyMatrix(ByVal image As Image, ByVal size As Size, ByVal matrix As ColorMatrix) As Bitmap
        Dim src As New Bitmap(image, size)
        Dim dest As New Bitmap(src.Width, src.Height, PixelFormat.Format32bppArgb)
        Using graphics As Graphics = Graphics.FromImage(dest)
            Dim bmpAttributes As New ImageAttributes()
            bmpAttributes.SetColorMatrix(matrix)
            graphics.DrawImage(src, New Rectangle(0, 0, src.Width, src.Height), 0, 0, src.Width, src.Height, GraphicsUnit.Pixel, bmpAttributes)
        End Using
        src.Dispose()
        Return dest
    End Function
End Class

#End Region





