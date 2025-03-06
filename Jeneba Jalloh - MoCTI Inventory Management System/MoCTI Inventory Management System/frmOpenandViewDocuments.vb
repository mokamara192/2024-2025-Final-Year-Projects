Public Class frmOpenandViewDocuments
    Public TableName As String
    Public ForeignKeyField As String
    Public ForeignKeyValue As String
    Dim DocumentList As New ArrayList(50)


    Private Sub MyLoading() Handles Me.Load
        LoadDocumentTypes()

    End Sub



    Private Sub LoadDocumentTypes()
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT distinct(FileType) FROM " & TableName & " WHERE " & ForeignKeyField & " = '" & ForeignKeyValue & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            lstDocuments.Items.Clear()

            For Each item In MYTABLE.Rows
                lstDocuments.Items.Add(item("FileType"))
            Next

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub LoadDocumentsForListView(ByVal FileType As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT ID, FileName, GeneratedFileName,FileStatus, RegDate FROM " & TableName & " WHERE FileType = '" & FileType & "' AND " & ForeignKeyField & " = '" & ForeignKeyValue & "' ORDER BY ID DESC"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            If MYTABLE.Rows.Count > 0 Then

                DocumentListView.Items.Clear()

                For Each item In MYTABLE.Rows
                    Dim MyListViewItem As New ListViewItem

                    MyListViewItem.Name = "Doc" & item("ID")
                    MyListViewItem.Tag = item("ID")
                    MyListViewItem.Text = item("FileName") & " : " & item("FileStatus") & ":" & CDate(item("RegDate")).ToString("dd/MM/yyyy hh:mm:ss tt")

                    If item("FileName").ToString.ToUpper.Contains(".JPG") Or item("FileName").ToString.ToUpper.Contains(".PNG") Or item("FileName").ToString.ToUpper.Contains(".BMP") Or item("FileName").ToString.ToUpper.Contains(".JPEG") Or item("FileName").ToString.ToUpper.Contains(".TIFF") Then
                        'Dim MyBytes As Byte() = item("FileData")
                        'Dim MyMemoryStream As New System.IO.MemoryStream(MyBytes)
                        'Dim MyImage As Image = Image.FromStream(MyMemoryStream)

                        'ImageList1.Images.Add(MyImage)
                        'MyListViewItem.ImageIndex = ImageList1.Images.Count - 1

                        MyListViewItem.ImageIndex = 3

                    ElseIf item("FileName").ToString.ToUpper.Contains(".DOC") Then
                        MyListViewItem.ImageIndex = 0

                    ElseIf item("FileName").ToString.ToUpper.Contains(".PDF") Then
                        MyListViewItem.ImageIndex = 1

                    ElseIf item("FileName").ToString.ToUpper.Contains(".XLS") Then
                        MyListViewItem.ImageIndex = 2

                    ElseIf item("FileName").ToUpper.Contains(".MP4") Or item("FileName").ToUpper.Contains(".AVI") Or item("FileName").ToUpper.Contains(".MPEG") Or item("FileName").ToUpper.Contains(".3GP") Or item("FileName").ToUpper.Contains(".MKV")
                        MyListViewItem.ImageIndex = 4

                    ElseIf item("FileName").ToUpper.Contains(".MP3") Or item("FileName").ToUpper.Contains(".WAV") Or item("FileName").ToUpper.Contains(".M4A") Then
                        MyListViewItem.ImageIndex = 5

                    Else
                        MyListViewItem.ImageIndex = 6

                    End If

                    DocumentListView.Items.Add(MyListViewItem)
                Next
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function GetDocumentGeneratedName(ByVal RecordID As String) As String
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT GeneratedFileName FROM " & TableName & " WHERE ID = '" & RecordID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            If MYTABLE.Rows.Count > 0 Then
                Return MYTABLE.Rows(0).Item("GeneratedFileName")
            Else
                Return ""
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Function GetDocumentDataLocalFunction(ByVal ID As String) As Byte()

        Try
            Dim theName As String = GetDocumentGeneratedName(ID)
            Dim FullPath As String = "\\" & FILEServerIPAddress & "\" & FILEFolder & "\" & TableName

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
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function


    Private Sub lstDocuments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDocuments.SelectedIndexChanged
        LoadDocumentsForListView(lstDocuments.SelectedItem)

    End Sub


    Private Sub DocumentListView_DoubleClick() Handles DocumentListView.DoubleClick
        If DocumentListView.SelectedItems.Count > 0 Then
            Dim ItemDescription As String = DocumentListView.SelectedItems(0).Text
            Dim TheSplit As String() = ItemDescription.Trim.Split(":")
            Dim TheFileName As String = TheSplit(0)
            Dim TheRegDate As String = TheSplit(2)

            If TheFileName.ToUpper.Contains(".JPG") Or TheFileName.ToUpper.Contains(".PNG") Or TheFileName.ToUpper.Contains(".BMP") Or TheFileName.ToUpper.Contains(".JPEG") Then
                Dim TheBytes As Byte() = GetDocumentDataLocalFunction(DocumentListView.SelectedItems(0).Tag)

                If TheBytes Is Nothing Then
                    MessageBox.Show("File Not Found on File Server. Please contact the System Administrator", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Exit Sub
                End If

                Dim MyImageForm As New frmViewImage

                Dim MyMemoryStream As New System.IO.MemoryStream(TheBytes)
                Dim MyImage As Image = Image.FromStream(MyMemoryStream)
                MyImageForm.ImagePictureBox.Image = MyImage

                MyImageForm.BarStaticItemDocumentName.Caption = TheFileName
                MyImageForm.BarStaticItemDocumentDescription.Caption = ItemDescription

                MyImageForm.Show(Me)

            ElseIf TheFileName.ToUpper.Contains(".DOC") Then
                Dim TheBytes As Byte() = GetDocumentDataLocalFunction(DocumentListView.SelectedItems(0).Tag)

                If TheBytes Is Nothing Then
                    MessageBox.Show("File Not Found on File Server. Please contact the System Administrator", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Exit Sub
                End If

                Dim MyForm As New frmWordProcessor
                MyForm.RichEditControl1.OpenXmlBytes() = TheBytes
                MyForm.WindowState = FormWindowState.Maximized
                MyForm.Show(Me)
            ElseIf TheFileName.ToUpper.Contains(".PDF") Then
                Dim TheBytes As Byte() = GetDocumentDataLocalFunction(DocumentListView.SelectedItems(0).Tag)

                If TheBytes Is Nothing Then
                    MessageBox.Show("File Not Found on File Server. Please contact the System Administrator", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Exit Sub
                End If

                Dim MyForm As New frmViewPDF
                Dim MyMemoryStream As New System.IO.MemoryStream(TheBytes)
                MyForm.MyPdfViewer.LoadDocument(MyMemoryStream)
                MyForm.WindowState = FormWindowState.Maximized
                MyForm.Show(Me)
            ElseIf TheFileName.ToUpper.Contains(".XLS") Then
                Dim TheBytes As Byte() = GetDocumentDataLocalFunction(DocumentListView.SelectedItems(0).Tag)

                If TheBytes Is Nothing Then
                    MessageBox.Show("File Not Found on File Server. Please contact the System Administrator", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Exit Sub
                End If

                Dim MyForm As New frmSpreadsheet
                MyForm.SpreadsheetControl1.LoadDocument(TheBytes, DevExpress.Spreadsheet.DocumentFormat.Xlsx)
                MyForm.WindowState = FormWindowState.Maximized
                MyForm.Show(Me)

            ElseIf TheFileName.ToUpper.Contains(".MP4") Or TheFileName.ToUpper.Contains(".AVI") Or TheFileName.ToUpper.Contains(".MPEG") Or TheFileName.ToUpper.Contains(".3GP") Or TheFileName.ToUpper.Contains(".MKV") Or TheFileName.ToUpper.Contains(".MP3") Or TheFileName.ToUpper.Contains(".WAV") Or TheFileName.ToUpper.Contains(".M4A")

                Dim MyForm As New frmVideoPlayer
                MyForm.FileNameTextBox.Text = TheFileName
                MyForm.RegDateTextBox.Text = "Date: " & TheRegDate
                MyForm.PreparePlaylist()

                Dim FileName As String =GetDocumentGeneratedName( DocumentListView.SelectedItems(0).Tag)
                Dim FullPath As String = "\\" & FILEServerIPAddress & "\" & FILEFolder & "\" & TableName & "\" & FileName
                MyForm.PlayList.clear()
                MyForm.AddItemToPlaylist(FullPath)

                'MyForm.AxWindowsMediaPlayer1.newMedia(FullPath)
                MyForm.WindowState = FormWindowState.Maximized
                MyForm.Show(Me)

            Else
                Dim TheBytes As Byte() = GetDocumentDataLocalFunction(DocumentListView.SelectedItems(0).Tag)

                If TheBytes Is Nothing Then
                    MessageBox.Show("File Not Found on File Server. Please contact the System Administrator", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Exit Sub
                End If

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



        Else
            MessageBox.Show("Please select a file from the View before proceeding.", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub


    Private Sub BarButtonItemDownload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemDownload.ItemClick
        If DocumentListView.SelectedItems.Count > 0 Then
            Dim TheBytes As Byte() = GetDocumentDataLocalFunction(DocumentListView.SelectedItems(0).Tag)
            Dim ItemDescription As String = DocumentListView.SelectedItems(0).Text
            Dim TheSplit As String() = ItemDescription.Trim.Split(":")
            Dim TheFileName As String = TheSplit(0)

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

        Else
            MessageBox.Show("Please select a file from the View before proceeding.", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub BarButtonItemOpenDocument_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItemOpenDocument.ItemClick
        DocumentListView_DoubleClick

    End Sub


    Private Sub DocumentListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DocumentListView.SelectedIndexChanged


    End Sub
End Class
