
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class frmDigitalArchieve
    Dim CurrentRowIndex As Integer
    Dim WasCellEdited As Boolean
    Dim PrimaryKeyValuetoDelete As String

    Dim ExportFileName As String
    Dim ExportCount As Integer
    Dim ExpectedNoValues As Integer
    Dim NoofColumns As Integer
    Public MyReportTable As New Datatable
    Dim MySingleReportTable As New Datatable
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer




    Private Sub PanelTop_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) ''Handles PanelHeader.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If

    End Sub
     

    Private Sub PanelTop_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) 'Handles PanelHeader.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If

    End Sub



    Private Sub PanelTop_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) 'Handles PanelHeader.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing

        End If


    End Sub




    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdClose.Click
        Me.Close()


    End Sub



    Private Sub cmdMinimize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdMinimize.Click
        Me.WindowState = FormWindowState.Minimized


    End Sub


    Private Sub MyLoading_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        LoadRecords()

    End Sub


    Private Sub LoadRecords()
        Try
            Dim Conn As New Sqlclient.SqlConnection(MyConnectionString)


            Dim Query As String = "SELECT  ArchieveID,Subject,TypeOfAttachment,Title,DetailsOfDocument,SearchKeyword,TheFileName,SharedAccessLevel,RegDate,InputedBy FROM DigitalArchieve ORDER BY ArchieveID DESC"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            MyReportTable.Rows.Clear()
            ConTableAdapter.Fill(MyReportTable)

            DigitalArchieveDataGridView.DataSource = MyReportTable

            If MyReportTable.Rows.Count > 0 Then
                DisplayRecordInfo(MyReportTable.Rows(0).Item("ArchieveID"))
            End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function ValidateID(ByVal ArchieveID As String) As Boolean
        Try
            Dim Conn As New Sqlclient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT Count(*) FROM DigitalArchieve WHERE ArchieveID = '" & ArchieveID & "'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Conn.Open()
            Dim Recordcount As Integer = Concommand.ExecuteScalar
            Conn.Close()
            If Recordcount > 0 Then
                Return True
            Else
                Return False
            End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Private Function GenerateID() As String
        Try
            Dim Conn As New Sqlclient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT Count(*) FROM DigitalArchieve"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Conn.Open()
            Dim Recordcount As Integer = Concommand.ExecuteScalar
            Conn.Close()
            Dim IsIDGenerated As Boolean = False
            Dim Start As String = Nothing

            While IsIDGenerated = False
                Recordcount += 1
                If Recordcount >= 0 And Recordcount < 10 Then
                    Start = "ARC00000" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                ElseIf Recordcount >= 10 And Recordcount < 100 Then
                    Start = "ARC0000" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                ElseIf Recordcount >= 100 And Recordcount < 1000 Then
                    Start = "ARC000" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                ElseIf Recordcount >= 1000 And Recordcount < 10000 Then
                    Start = "ARC00" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                ElseIf Recordcount >= 10000 And Recordcount < 100000 Then
                    Start = "ARC0" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                ElseIf Recordcount >= 100000 And Recordcount < 1000000 Then
                    Start = "ARC" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                End If
            End While

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Connection Error"
        End Try
    End Function


    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        cmdDownload.Visible = False

        lblInformation.Text = "Adding new record"
        InputedByTextBox.Text = CurrentUserID
        ArchieveIDTextBox.Text = ""

        SubjectTextBox.Text = ""
        TypeOfAttachmentTextBox.Text = ""
        TitleTextBox.Text = ""
        DetailsOfDocumentTextBox.Text = ""
        SearchKeywordTextBox.Text = ""
        TheFileNameTextBox.Text = ""
        AttachmentFilePictureBox.Image = Nothing
        SharedAccessLevelTextBox.Text = ""
        RegDateTextBox.Text = ""

        RegDateTextBox.Text = DateTime.Now
        RegDateTextBox.ReadOnly = True
        lblNoPreview.Visible = False

        ArchieveIDTextBox.Text = GenerateID

        cmdSave.Enabled = True
        cmdUpdate.Enabled = False
        cmdDelete.Enabled = False


    End Sub


    Private Sub cmdSave_Click() 'Handles cmdSave.Click
        Try

            If SharedAccessLevelTextBox.Text = "" Then
                MessageBox.Show("Please select or provide a shared access level before proceeding.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub
            End If

            If TheFileNameTextBox.Text = "" Then
                MessageBox.Show("Please attach a file before proceeding.", "Missing Attachment", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub
            End If

            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)


            Dim Query As String = "INSERT INTO DigitalArchieve (ArchieveID,Subject,TypeOfAttachment,Title,DetailsOfDocument,SearchKeyword,TheFileName,AttachmentFile,SharedAccessLevel,RegDate,InputedBy) VALUES(@ArchieveID, @Subject, @TypeOfAttachment, @Title, @DetailsOfDocument, @SearchKeyword, @TheFileName, @AttachmentFile, @SharedAccessLevel, @RegDate,@InputedBy)"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)
            With ConCommand.Parameters
                .AddWithValue("@ArchieveID", ArchieveIDTextBox.Text)

                .AddWithValue("@Subject", SubjectTextBox.Text)
                .AddWithValue("@TypeOfAttachment", TypeOfAttachmentTextBox.Text)
                .AddWithValue("@Title", TitleTextBox.Text)
                .AddWithValue("@DetailsOfDocument", DetailsOfDocumentTextBox.Text)
                .AddWithValue("@SearchKeyword", SearchKeywordTextBox.Text)

                Dim SplitFileName As String() = TheFileNameTextBox.Text.Trim.Split("\")

                .AddWithValue("@TheFileName", SplitFileName(SplitFileName.Count - 1))
                .AddWithValue("@InputedBy", CurrentUserID)

                .AddWithValue("@AttachmentFile", GetByteData(TheFileNameTextBox.Text))

                .AddWithValue("@SharedAccessLevel", SharedAccessLevelTextBox.Text)
                .AddWithValue("@RegDate", Date.Today)
            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

            lblInformation.Text = "Successfully Inserted a new record"
            CreateLog(CurrentUserID, FullNameofUser, "Insert of new record in table (" & "DigitalArchieve" & " With ID (" & ArchieveIDTextBox.Text & ")", 0)
            LoadRecords()

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function GetByteData(ByVal FilePath As String) As Byte()
        Try

            If FilePath.ToCharArray.Count > 0 Then

                Dim fInfo As New FileInfo(FilePath)
                Dim numBytes As Long = fInfo.Length
                Dim fStream As New FileStream(FilePath, FileMode.Open, FileAccess.Read)
                Dim br As New BinaryReader(fStream)
                Dim data As Byte() = br.ReadBytes(CInt(numBytes))
                br.Close()
                fStream.Close()

                Return data
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function



    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try

            If SharedAccessLevelTextBox.Text = "" Then
                MessageBox.Show("Please select or provide a shared access level before proceeding.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub
            End If

            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String

            If TheFileNameTextBox.Text.Contains("\") Then

                Query = "UPDATE DigitalArchieve SET Subject =@Subject, TypeOfAttachment =@TypeOfAttachment, Title =@Title, DetailsOfDocument =@DetailsOfDocument, SearchKeyword =@SearchKeyword, AttachmentFile = @AttachmentFile, SharedAccessLevel =@SharedAccessLevel, TheFileName = @TheFileName WHERE ArchieveID = '" & ArchieveIDTextBox.Text & "'"
            Else

                Query = "UPDATE DigitalArchieve SET Subject =@Subject, TypeOfAttachment =@TypeOfAttachment, Title =@Title, DetailsOfDocument =@DetailsOfDocument, SearchKeyword =@SearchKeyword, SharedAccessLevel =@SharedAccessLevel WHERE ArchieveID = '" & ArchieveIDTextBox.Text & "'"
            End If

            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)
            With ConCommand.Parameters
                .AddWithValue("@ArchieveID", ArchieveIDTextBox.Text)

                .AddWithValue("@Subject", SubjectTextBox.Text)
                .AddWithValue("@TypeOfAttachment", TypeOfAttachmentTextBox.Text)
                .AddWithValue("@Title", TitleTextBox.Text)
                .AddWithValue("@DetailsOfDocument", DetailsOfDocumentTextBox.Text)
                .AddWithValue("@SearchKeyword", SearchKeywordTextBox.Text)

                If TheFileNameTextBox.Text.Contains("\") Then
                    .AddWithValue("@AttachmentFile", GetByteData(TheFileNameTextBox.Text))
                    Dim SplitFileName As String() = TheFileNameTextBox.Text.Trim.Split("\")

                    .AddWithValue("@TheFileName", SplitFileName(SplitFileName.Count - 1))
                End If

                .AddWithValue("@SharedAccessLevel", SharedAccessLevelTextBox.Text)
                .AddWithValue("@RegDate", Date.Today)
            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

            lblInformation.Text = "Successfully Updated a record"
            CreateLog(CurrentUserID, FullNameofUser, "Update of record in table (" & "DigitalArchieve" & " With ID (" & ArchieveIDTextBox.Text & ")", 0)

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Do you really want to delete the current record?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            Try
                Dim Conn As New Sqlclient.SqlConnection(MyConnectionString)
                Dim Query As String = "DELETE FROM DigitalArchieve WHERE ArchieveID = '" & ArchieveIDTextBox.Text & "'"
                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                Conn.Open()
                ConCommand.ExecuteNonQuery()
                Conn.Close()

                lblInformation.Text = "Record Deleted"
                CreateLog(CurrentUserID, FullNameofUser, "Delete of record in table (" & "DigitalArchieve" & " With ID (" & ArchieveIDTextBox.Text & ")", 0)
                LoadRecords()

            Catch Ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub



    Private Sub ArchieveIDTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) 'Handles ArchieveIDTextBox.TextChanged
        DisplayRecordInfo(ArchieveIDTextBox.Text)

    End Sub


    Private Sub DisplayRecordInfo(ByVal RecordID As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT ArchieveID,Subject,TypeOfAttachment,InputedBy,Title,DetailsOfDocument,SearchKeyword,TheFileName,AttachmentFile,SharedAccessLevel,RegDate FROM DigitalArchieve WHERE ArchieveID = '" & RecordID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)
            MySingleReportTable.rows.Clear()
            ConTableAdapter.Fill(MySingleReportTable)

            If MySingleReportTable.Rows.Count > 0 Then
                lblInformation.Text = "Displaying details of a record"
                ArchieveIDTextBox.Text = MySingleReportTable.Rows(0).Item("ArchieveID").ToString

                SubjectTextBox.Text = MySingleReportTable.Rows(0).Item("Subject").ToString
                TypeOfAttachmentTextBox.Text = MySingleReportTable.Rows(0).Item("TypeOfAttachment").ToString
                TitleTextBox.Text = MySingleReportTable.Rows(0).Item("Title").ToString
                DetailsOfDocumentTextBox.Text = MySingleReportTable.Rows(0).Item("DetailsOfDocument").ToString
                SearchKeywordTextBox.Text = MySingleReportTable.Rows(0).Item("SearchKeyword").ToString
                TheFileNameTextBox.Text = MySingleReportTable.Rows(0).Item("TheFileName").ToString
                InputedByTextBox.Text = MySingleReportTable.Rows(0).Item("InputedBy").ToString

                Try
                    Dim MyByte As Byte() = MySingleReportTable.Rows(0).Item("AttachmentFile")
                    Dim MyStream As System.IO.MemoryStream = New System.IO.MemoryStream(MyByte)
                    AttachmentFilePictureBox.Image = Image.FromStream(MyStream)
                    lblNoPreview.Visible = False
                Catch ex As Exception
                    lblNoPreview.Visible = True
                    AttachmentFilePictureBox.Image = Nothing
                End Try

                SharedAccessLevelTextBox.Text = MySingleReportTable.Rows(0).Item("SharedAccessLevel").ToString
                RegDateTextBox.Text = MySingleReportTable.Rows(0).Item("RegDate").ToString

                RegDateTextBox.ReadOnly = True

                If UserGroup.ToUpper = "ADMINISTRATOR" Then
                    cmdDownload.Visible = True
                Else
                    If SharedAccessLevelTextBox.Text.ToUpper = "ALL" Then
                        cmdDownload.Visible = True
                    Else
                        If UserGroup.ToUpper = SharedAccessLevelTextBox.Text.ToUpper Then
                            cmdDownload.Visible = True
                        Else
                            cmdDownload.Visible = False
                        End If
                    End If
                End If

                lblInformation.Text = "Displaying details of a record"

                cmdSave.Enabled = False
                cmdUpdate.Enabled = True
                cmdDelete.Enabled = True
            Else
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub PreviewDocument()

        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim TheArchieve As String = ArchieveIDTextBox.Text
            Dim Query As String = "Select AttachmentFile,TheFileName From DigitalArchieve Where ArchieveID = '" & TheArchieve & "'"
            Dim conTableADapter As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTable As New DataTable

            conTableADapter.Fill(MyTable)

            If MyTable.Rows.Count > 0 Then
                Dim MyBytes As Byte() = MyTable.Rows(0).Item("AttachmentFile")
                Dim SDB As New SaveFileDialog
                SDB.FileName = MyTable.Rows(0).Item("TheFileName")
                SDB.Title = "Save Evidence File"

                SDB.AddExtension = True

                'C# operation.docx
                Dim SplitFileName As String() = MyTable.Rows(0).Item("TheFileName").ToString.Trim.Split(".")

                SDB.Filter = "Document|" & "*." & SplitFileName(1)

                If TheFileNameTextBox.Text.ToUpper.Contains(".JPG") Or TheFileNameTextBox.Text.ToUpper.Contains(".JPEG") Or TheFileNameTextBox.Text.ToUpper.Contains(".PNG") Or TheFileNameTextBox.Text.ToUpper.Contains(".GIF") Or TheFileNameTextBox.Text.ToUpper.Contains(".BMP") Then
                    Dim MyStream As New System.IO.MemoryStream(MyBytes)
                    AttachmentFilePictureBox.Image = Image.FromStream(MyStream)
                Else
                    AttachmentFilePictureBox.Image = Nothing
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


    Private Sub DigitalArchieveDataGridView_CellContentClick(ByVal sender As Object, ByVal e As EventArgs) Handles GridView1.FocusedRowChanged
        DisplayRecordInfo(GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("ArchieveID")))

    End Sub


    Private Sub PrintToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrintToolStripMenuItem.Click
        Try
        Dim MyCompanyTable As New DataTable
        MyCompanyTable = GetCompanyData()

        Dim MyDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalReportDigitalArchieve
        MyDocument.SummaryInfo.ReportTitle = "Digital Archieve"
        Dim MyTable As New DataTable
        Dim TableName As String = "DigitalArchieve"
        Dim Fields As String = "ArchieveID"
        Dim Values As String = ArchieveIDTextBox.Text
        MyTable = UniversalGetDatafromTable(TableName, Fields, Values)

        MyDocument.Database.Tables(0).SetDataSource(MyCompanyTable)
        MyDocument.Database.Tables(1).SetDataSource(MyTable)

        Dim MyReportViewer As New frmReportViewer
        MyReportViewer.WindowState = FormWindowState.Maximized

        MyReportViewer.MyCrystalReportViewer.ReportSource = MyDocument
        MyReportViewer.ShowDialog()
        Catch ex As Exception
        End Try


    End Sub




    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()


    End Sub




    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Do you really want to logout? All other opened windows will be closed.", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            frmLogin.Show()
            frmDashboardNew.Close()
            Me.Close()
        End If


    End Sub






    Private Sub SearchToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SearchToolStripMenuItem.Click
        'Me.PanelSearch.Visible = True
        'Me.PanelSearch.BringToFront()
        Try
            Dim MySearch As New frmQuickSearch
            MySearch.FormName = "frmDigitalArchieve"
            MySearch.TableName = "DigitalArchieve"
            MySearch.PrimaryKey = "ArchieveID"

            MySearch.Show(Me)

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Private Sub AdvancedSummaryToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AdvancedSummaryToolStripMenuItem.Click
        Try
            Dim myReport As New frmReport
            myReport.WindowState = FormWindowState.Maximized

            myReport.LoadTables()
            myReport.Show(Me)
            myReport.cboTableName.SelectedIndex = myReport.FindItemIndex("DigitalArchieve")
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Private Sub ImportWizardToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ImportWizardToolStripMenuItem.Click
        Try
            Dim MyImportForm As New frmImports
            MyImportForm.LoadTables()
            MyImportForm.cboTableName.SelectedIndex = MyImportForm.FindItemIndex("DigitalArchieve")
            MyImportForm.cboTableName.Enabled = False

           MyImportForm.WindowState = FormWindowState.Maximized

            MyImportForm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub cmdDownload_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdDownload.Click
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim TheArchieve As String = ArchieveIDTextBox.Text
            Dim Query As String = String.Format("Select AttachmentFile,TheFileName From DigitalArchieve Where ArchieveID = '{0}'", TheArchieve)
            Dim conTableADapter As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTable As New DataTable

            conTableADapter.Fill(MyTable)

            If MyTable.Rows.Count > 0 Then
                Dim MyBytes As Byte() = MyTable.Rows(0).Item("AttachmentFile")
                Dim SDB As New SaveFileDialog
                SDB.FileName = MyTable.Rows(0).Item("TheFileName")
                SDB.Title = "Save Evidence File"

                SDB.AddExtension = True
 
                Dim SplitFileName As String() = MyTable.Rows(0).Item("TheFileName").ToString.Trim.Split(".")

                SDB.Filter = String.Format("Document|*.{0}", SplitFileName(1))

                If SDB.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    My.Computer.FileSystem.WriteAllBytes(SDB.FileName, MyBytes, False)

                    If MessageBox.Show("File was successfully downloaded. Would you like to open it?", "Download complete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                        Process.Start(SDB.FileName)
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub cmdBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdBrowseAttachmentFile.Click
        Try
            Dim OFD1 As New OpenFileDialog
            OFD1.Multiselect = False
            OFD1.Filter = "All Files|*.*"
            OFD1.Title = "Select a file"
            OFD1.FileName = ""

            If OFD1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                TheFileNameTextBox.Text = OFD1.FileName

                Try
                    AttachmentFilePictureBox.Image = Image.FromFile(OFD1.FileName)
                    lblNoPreview.Visible = False
                Catch ex As Exception
                    lblNoPreview.Visible = True
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
 


End Class
