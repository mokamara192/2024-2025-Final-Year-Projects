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

Public Class frmScanner
    Public FolderName As String

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

    Private sub MyLoading Handles Me.Load
        
        ScanFullPath = My.Computer.FileSystem.SpecialDirectories.Temp & "\" & FolderName

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

    End sub

    Private Sub selectButton_Click(sender As System.Object, e As System.EventArgs) Handles BarButtonItemSelectScanner.ItemClick

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

                'If XtraTabPageScanningDesk.Controls.Count = 0 Then
                '    MyViewer.Dock = DockStyle.Fill
                '    XtraTabPageScanningDesk.Controls.Add(MyViewer)
                'End If

                'XtraTabPageScanningDesk.Text = childCaption
                MyScannedImages(_scanCount) = e.Image

                Application.DoEvents()
            End If
        End If
    End Sub

    Private Function SelectAcquireSource(ByVal ScanType As String) As DialogResult
        _forCapabilities = True

        Dim dlgResult As DialogResult = DialogResult.Cancel

        Using DeviceItemsDlg As WiaDeviceItemsFormSingleScanner = New WiaDeviceItemsFormSingleScanner()
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

 
    Private Sub BarButtonItemCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemCancel.ItemClick
        Me.DialogResult = DialogResult.Cancel
        Me.Dispose()

    End Sub


    Private Sub scanButton_Click(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemScan.ItemClick
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
            'XtraTabControlDocument.SelectedTabPageIndex = 1
            ScanPictureBox.Image = Nothing

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

                ScanPictureBox.Image = TheImage

                InsertANewDocument(ScanFullPath & "\" & theScanFileName, BarStaticItemFileType.Caption, BarStaticItemDivision.Caption)
               
                'LoadDocuments()
                'LoadDocumentCompletionRecords(BarStaticItemAccRecordID.Caption)

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

     Private Sub InsertANewDocument(ByVal FileName As String, ByVal FileType As String, ByVal Division As String, ByVal Optional FileData As Byte() = Nothing)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "INSERT INTO StaffFilesData (StaffProfileID,Division,FileType,FileName,GeneratedFileName,FileStatus,RegDate,InputtedBy) VALUES( @StaffProfileID, @Division, @FileType, @FileName, @GeneratedFileName, @FileStatus, @RegDate, @InputtedBy)"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Dim GenerateFileName As String

            With ConCommand.Parameters

                .AddWithValue("@StaffProfileID", BarStaticItemStaffProfileID.Caption)
                .AddWithValue("@FileType", FileType)
                .AddWithValue("@Division", Division)

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

            CreateLog(CurrentUserID, FullNameofUser, "Insert of new Document record for " & BarStaticItemStaffProfileID.Caption, 0)

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

    Private Sub BarButtonItemFlipHorizontal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemRotateLeft.ItemClick
        ScanPictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        ScanPictureBox.Refresh()

    End Sub


    Private Sub BarButtonItemRotateRight_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemRotateRight.ItemClick
        ScanPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        ScanPictureBox.Refresh()

    End Sub


    Private Sub BarButtonItemSaveDocument_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemSaveDocument.ItemClick
        Me.DialogResult = DialogResult.OK
        Me.Close()
        Me.Dispose()

    End Sub


    Private Sub BarButtonItemFlipVertical_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemFlipVertical.ItemClick
        ScanPictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
        ScanPictureBox.Refresh()

    End Sub
End Class
