
    Imports Excel = Microsoft.Office.Interop.Excel

    Imports DevExpress.XtraGrid.Views.Grid
   Imports DevExpress.XtraEditors

Public Class frmProgramUpdates
    Dim CurrentRowIndex As Integer
    Dim WasCellEdited As Boolean
    Dim PrimaryKeyValuetoDelete As String
    Dim isDateSearchUsed As Boolean

    Dim ExportFileName As String
    Dim ExportCount As Integer
    Dim ExpectedNoValues As Integer
    Dim NoofColumns As Integer
    Public isCalled As Boolean
    Dim LoadedVersion As String
Public MyReportTable as New Datatable
Dim MySingleReportTable as New Datatable
Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer



    Private Sub PanelNew_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelNew.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If

    End Sub
     

    Private Sub PanelNew_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelNew.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If

    End Sub
     

    Private Sub PanelNew_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) 'Handles PanelNew.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.PanelNew.Location.X + (e.X - MouseDownX)
            temp.Y = Me.PanelNew.Location.Y + (e.Y - MouseDownY)
            Me.PanelNew.Location = temp
            temp = Nothing
        End If

    End Sub



    Private Sub cmdClose_Click(sender As Object, e As EventArgs) 'Handles cmdClose.Click
        Me.Close()

    End Sub


    Private Sub cmdMinimize_Click(sender As Object, e As EventArgs) 'Handles cmdMinimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub


    Public Sub PrepareForm()
   End Sub

Private Sub MyLoading_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
LoadRecords()
	If AccessibleFeatures.Contains("Import Wizard") Then
            ImportWizardToolStripMenuItem.Enabled = True
        Else
            ImportWizardToolStripMenuItem.Enabled = False
        End If

End Sub
Private Sub LoadRecords()
Try
Dim Conn as New Sqlclient.SqlConnection(MyConnectionString)

Dim Query as String = " SELECT  Version,UpdateFile,FileName,UpdatePriority,Description,RegDate,InputtedBy FROM ProgramUpdates ORDER BY Version DESC "
Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

MyReportTable.Rows.Clear
ConTableAdapter.Fill(MyReportTable)

ProgramUpdatesDataGridView.Datasource = MyReportTable
isDateSearchUsed = False
'If MyReportTable.Rows.Count > 0 Then
'DisplayRecordInfo(MyReportTable.Rows(0).Item("Version"))
'End If
Catch Ex as Exception
MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
End Try
End Sub

Private Function ValidateID(ByVal Version As String) As Boolean
Try
Dim Conn as New Sqlclient.SqlConnection(MyConnectionString)

Dim Query as String = "SELECT Count(*) FROM ProgramUpdates WHERE Version = '" & Version & "'"
Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

Conn.Open
Dim Recordcount As Integer = Concommand.ExecuteScalar
Conn.Close
If Recordcount > 0 Then
Return True
Else
Return False
End If
Catch Ex as Exception
MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
Return True
End Try
End Function

Private Function GenerateID() As String
Try
Dim Conn as New Sqlclient.SqlConnection(MyConnectionString)

Dim Query as String = "SELECT Count(*) FROM ProgramUpdates WHERE Version LIKE 'VER" & DateTime.Today.ToString("yyMMdd") & "%'"
Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

Conn.Open
Dim Recordcount As Integer = Concommand.ExecuteScalar
Conn.Close
Dim IsIDGenerated As Boolean = False
Dim Start As String = Nothing

While IsIDGenerated = False
Recordcount += 1
                If Recordcount >= 0 And Recordcount < 10 Then
                    Start = "VER" & CurrentUserID & DateTime.Today.ToString("yyMMdd") & "000" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                ElseIf Recordcount >= 10 And Recordcount < 100 Then
                    Start = "VER" & CurrentUserID & DateTime.Today.ToString("yyMMdd") & "00" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                ElseIf Recordcount >= 100 And Recordcount < 1000 Then
                    Start = "VER" & CurrentUserID & DateTime.Today.ToString("yyMMdd") & "0" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                ElseIf Recordcount >= 1000 And Recordcount < 10000 Then
                    Start = "VER" & CurrentUserID & DateTime.Today.ToString("yyMMdd") & "" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                End If
End While

Catch Ex as Exception
MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
Return "Connection Error"
End Try
End Function

Private Sub cmdAdd_Click() 'Handles cmdAdd.Click


lblInformation.Text = "Adding new record"
If Not isCalled Then
LoadedVersion = ""
 End If
VersionTextBox.Text =  ""
UpdateFilePictureBox.Image = Nothing
FileNameTextBox.Text =  ""
UpdatePriorityTextBox.Text =  ""
DescriptionTextBox.Text =  ""
RegDateTextBox.Text =  ""

RegDateTextBox.Text =  Date.Today
RegDateTextBox.ReadOnly =  True

InputtedByTextBox.Text =  ""

VersionTextBox.Text = GenerateID

End Sub

Private Sub cmdSave_Click() 'Handles cmdSave.Click
Try
            If VersionTextBox.Text <> "" Then
                If ValidateID(VersionTextBox.Text) Then
                    MessageBox.Show("This Version already exist in this table. DUPLICATE 'VERSION' ARE NOT ALLOWED. Please verify and try again.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Exit Sub
                End If
            End If
 If Not ValidateAllForeignKeys() Then

   Exit Sub
 End If
Dim Conn as New Sqlclient.SqlConnection(MyConnectionString)

Dim Query as String = "INSERT INTO ProgramUpdates (Version,UpdateFile,FileName,UpdatePriority,Description,RegDate,InputtedBy) VALUES(@Version,@UpdateFile,@FileName,@UpdatePriority,@Description,@RegDate,@InputtedBy)"
Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)
With ConCommand.Parameters
.AddWithValue("@Version", VersionTextBox.Text)
If UpdateFilePictureBox.Image IsNot Nothing Then
Dim MyMemoryStream As New System.IO.MemoryStream
UpdateFilePictureBox.Image.Save(MyMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
.AddWithValue("@UpdateFile", MyMemoryStream.Toarray)

Else
Dim MyMemoryStream As New System.IO.MemoryStream
.AddWithValue("@UpdateFile", MyMemoryStream.Toarray)

End If
.AddWithValue("@FileName", FileNameTextBox.Text)
.AddWithValue("@UpdatePriority", UpdatePriorityTextBox.Text)
.AddWithValue("@Description", DescriptionTextBox.Text)
.AddWithValue("@RegDate", Date.Today)
.AddWithValue("@InputtedBy", InputtedByTextBox.Text)
End With

Conn.Open
ConCommand.ExecuteNonQuery
Conn.Close

lblInformation.Text = "Successfully Inserted a new record"
CreateLog(CurrentUserID, FullNameofUser, "Insert of new record in table (" & "ProgramUpdates" & " With ID (" & VersionTextBox.Text & ")", 0)
LoadRecords()
'cmdAdd_Click()
DisplayRecordInfo(VersionTextBox.Text)

Catch Ex as Exception
           If Ex.Message.ToUpper.Contains("FOREIGN") Then
                MessageBox.Show("Record Constraint Violation. Please make sure that  have values. If any does not have an applicable value then please select 'N/A' from the drop down list." & Ex.Message , "Incomplete entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
           Else
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If 

End Try
End Sub

Private Sub cmdUpdate_Click() 'Handles cmdUpdate.Click
Try
                If Not ValidateID(LoadedVersion) Then
                    MessageBox.Show("The loaded Version (" & LoadedVersion & ") was not found in the database table. UPDATE OPERATION WILL NOT BE SUCCESSFULL. Please verify and try again.", "Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Exit Sub
                End If
 If Not ValidateAllForeignKeys() Then

   Exit Sub
 End If
Dim Conn as New Sqlclient.SqlConnection(MyConnectionString)

Dim Query as String = "UPDATE ProgramUpdates SET UpdateFile =@UpdateFile, FileName =@FileName, UpdatePriority =@UpdatePriority, Description =@Description, RegDate =@RegDate, InputtedBy =@InputtedBy WHERE Version = '" & LoadedVersion & "'"
Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)
With ConCommand.Parameters
.AddWithValue("@Version", VersionTextBox.Text)
If UpdateFilePictureBox.Image IsNot Nothing Then
Dim MyMemoryStream As New System.IO.MemoryStream
UpdateFilePictureBox.Image.Save(MyMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
.AddWithValue("@UpdateFile", MyMemoryStream.Toarray)

Else
Dim MyMemoryStream As New System.IO.MemoryStream
.AddWithValue("@UpdateFile", MyMemoryStream.Toarray)

End If
.AddWithValue("@FileName", FileNameTextBox.Text)
.AddWithValue("@UpdatePriority", UpdatePriorityTextBox.Text)
.AddWithValue("@Description", DescriptionTextBox.Text)
.AddWithValue("@RegDate", Date.Today)
.AddWithValue("@InputtedBy", InputtedByTextBox.Text)
End With

Conn.Open
ConCommand.ExecuteNonQuery
Conn.Close
lblInformation.Text = "Successfully Updated a record"
CreateLog(CurrentUserID, FullNameofUser, "Update of record in table (" & "ProgramUpdates" & " With ID (" & VersionTextBox.Text & ")", 0)
Catch Ex as Exception
           If Ex.Message.ToUpper.Contains("FOREIGN") Then
                MessageBox.Show("Record Constraint Violation. Please make sure that  have values. If any does not have an applicable value then please select 'N/A' from the drop down list." & Ex.Message , "Incomplete entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
           Else
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If 

End Try
End Sub

Private Sub cmdDelete_Click() 'Handles cmdDelete.Click
IF MessageBox.Show("Do you really want to delete the current record?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) = System.Windows.Forms.DialogResult.Yes Then
Try
 Dim ThePKey As String = ""
 If PanelNew.Visible Then
 ThePKey = VersionTextBox.Text
 Else
 ThePKey = GridView1.GetFocusedDataRow.Item("Version")
 End If
 
Dim Conn as New Sqlclient.SqlConnection(MyConnectionString)
Dim Query as String = "DELETE FROM ProgramUpdates WHERE Version = '" & ThePKey & "'"
Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

Conn.Open
ConCommand.ExecuteNonQuery
Conn.Close
lblInformation.Text = "Record Deleted"
CreateLog(CurrentUserID, FullNameofUser, "Delete of record in table (" & "ProgramUpdates" & " With ID (" & ThePKey & ")", 0)
LoadRecords()
 Dim TheNewPKey As String = ""
 If MyReportTable.Rows.Count > 0 Then
 TheNewPKey = GridView1.GetFocusedDataRow.Item("Version")
 End If
 
 If PanelNew.Visible Then
 If ThePKey <> "" Then
 DisplayRecordInfo(TheNewPKey)
 End If
 End If
 

Catch Ex as Exception
MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
End Try
End If
End Sub


'Private Sub VersionTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles VersionTextBox.TextChanged
'DisplayRecordInfo(VersionTextBox.Text)
'End Sub
Public Sub DisplayRecordInfo(ByVal RecordID As String)
Try
Dim Conn as New Sqlclient.SqlConnection(MyConnectionString)

Dim Query as String = " SELECT Version,UpdateFile,FileName,UpdatePriority,Description,RegDate,InputtedBy FROM ProgramUpdates WHERE Version = '"& RecordID & "'"
Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)
MySingleReportTable.rows.Clear()
ConTableAdapter.Fill(MySingleReportTable)

If MySingleReportTable.Rows.Count > 0 Then
lblInformation.Text = "Displaying details Of a record"
VersionTextBox.Text = MySingleReportTable.Rows(0).Item("Version").ToString
Try
Dim MyByte As Byte() = MySingleReportTable.Rows(0).Item("UpdateFile")

Dim MyStream As System.IO.MemoryStream = New System.IO.MemoryStream(MyByte)
UpdateFilePictureBox.Image = Image.FromStream(MyStream)
Catch ex As Exception
UpdateFilePictureBox.Image = Nothing
End Try
FileNameTextBox.Text = MySingleReportTable.Rows(0).Item("FileName").ToString
UpdatePriorityTextBox.Text = MySingleReportTable.Rows(0).Item("UpdatePriority").ToString
DescriptionTextBox.Text = MySingleReportTable.Rows(0).Item("Description").ToString
RegDateTextBox.Text = MySingleReportTable.Rows(0).Item("RegDate").ToString

RegDateTextBox.ReadOnly = True

InputtedByTextBox.Text = MySingleReportTable.Rows(0).Item("InputtedBy").ToString
LoadedVersion = VersionTextBox.Text

lblInformation.Text = "Displaying details Of a record"

Else
End If

Catch Ex As Exception
    MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
End Try
End Sub


    Private Function ValidateAllForeignKeys() As Boolean


    Return True
    End Function

'Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
'       Try
'	Dim MyCompanyTable As New DataTable
'       MyCompanyTable = GetCompanyData()

'       Dim MyDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument '= New CrystalReportProgramUpdates
'       MyDocument.SummaryInfo.ReportTitle = "Program Updates"
'	      Dim MyTable As New DataTable
'       Dim TableName As String = "ProgramUpdates"
'       Dim Fields As String = "Version"
'       Dim Values As String = VersionTextBox.Text
'       MyTable = UniversalGetDatafromTable(TableName, Fields, Values)
'	    Dim MyQRCodeTable As DataTable = New QRandBarcodeDataSet.QRandLinearCodeDataTable
'           Dim QrCodeData As String = "ProgramUpdates Report - Printed on: " & DateTime.Today
'           Dim LinearCodeData As String = DateTime.Today
'           MyQRCodeTable.Rows.Add(GenerateQRCODE(QrCodeData), GenerateLinearCode(LinearCodeData))

'           MyDocument.Database.Tables(2).SetDataSource(MyQRCodeTable)

'       MyDocument.Database.Tables(0).SetDataSource(MyCompanyTable)
'       MyDocument.Database.Tables(1).SetDataSource(MyTable)

'       Dim MyReportViewer As New frmReportViewer
'       MyReportViewer.WindowState = FormWindowState.Maximized
'       
'       MyReportViewer.MyCrystalReportViewer.ReportSource = MyDocument
'       MyReportViewer.ShowDialog()
'       Catch ex As Exception
'       End Try

'   End Sub



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


Private Sub ExportToExcellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcellToolStripMenuItem.Click
      ExportToExcel2007_Click()
End Sub



 Private Sub cmdBrowseUpdateFile_Click() Handles cmdBrowseUpdateFile.Click

        Try
            Dim OFD1 As New OpenFileDialog
            OFD1.FileName = ""
            OFD1.Multiselect = False
            OFD1.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp"

            If OFD1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
UpdateFilePictureBox.Image = Image.FromFile(OFD1.FileName)
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

   Private Sub cmdCameraUpdateFile_Click(sender As Object, e As EventArgs) Handles cmdCameraUpdateFile.Click
        Try
            Dim MyCamera As New DevExpress.XtraEditors.Camera.TakePictureDialog

            MyCamera.Caption = "Please take a picture" 
            If MyCamera.ShowDialog() = System.Windows.Forms.DialogResult.OK Then 
                Dim i As Image = MyCamera.Image
                UpdateFilePicturebox.Image = i 
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        'Me.PanelSearch.Visible = True
        'Me.PanelSearch.BringToFront()
	Try
            Dim MySearch As New frmQuickSearch
            MySearch.FormName = "frmProgramUpdates"
            MySearch.TableName = "ProgramUpdates"
            MySearch.PrimaryKey = "Version"
           
         if MySearch.ShowDialog() = DialogResult.OK
            MyReportTable = MySearch.SearchTable
           ProgramUpdatesDataGridView.DataSource = MyReportTable
  End If


        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
     

 Private Sub AdvancedSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedSummaryToolStripMenuItem.Click
        Try
            Dim myReport As New frmReport
            myReport.WindowState = FormWindowState.Maximized

            myReport.LoadTables()
            myReport.Show(Me)
            myReport.cboTableName.SelectedIndex = myReport.FindItemIndex("ProgramUpdates")
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


   Private Sub ImportWizardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportWizardToolStripMenuItem.Click
        Try
            Dim MyImportForm As New frmImports
            MyImportForm.LoadTables()
            MyImportForm.cboTableName.SelectedIndex = MyImportForm.FindItemIndex("ProgramUpdates")
            MyImportForm.cboTableName.Enabled = False

           MyImportForm.WindowState = FormWindowState.Maximized

            MyImportForm.Show()

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#Region "TOOLSTRIP SECTION"


    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        cmdAdd_Click()

        DeleteToolStripButton.Enabled = False
       OpenNEWToolStripButton_Click()

        'SET DELETE BUTTON TO BE ENABLED IN THE DISPLAYINFORMATION METHOD

    End Sub


    Public Sub OpenNEWToolStripButton_Click() 'Handles OpenToolStripButton.Click
      Me.PanelNew.Width = SplitContainerControl1.Width
      Me.PanelNew.Height = SplitContainerControl1.Height
      Me.PanelNew.Location = New Point(0, Me.TopMenuStrip.Height + Me.TopToolStrip.Height)
       Me.PanelNew.Visible = True
       Me.PanelNew.BringToFront()
      Me.PanelSearchByDate.Visible = False


    End Sub

    Private Sub OpenToolStripButton_Click() Handles OpenToolStripButton.Click
      Try
	    Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("Version"))
        DisplayRecordInfo(DRecordID)
      Catch ex As Exception
      End Try
      Me.PanelNew.Width = SplitContainerControl1.Width
      Me.PanelNew.Height = SplitContainerControl1.Height
      Me.PanelNew.Location = New Point(0, Me.TopMenuStrip.Height + Me.TopToolStrip.Height)
       Me.PanelNew.Visible = True
       Me.PanelNew.BringToFront()
      Me.PanelSearchByDate.Visible = False


    End Sub



    Private Sub SearchToolStripComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchToolStripComboBox.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SearchToolStripButton.PerformClick()
        End If


    End Sub



    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        If lblInformation.Text.ToUpper.Contains("DISPLAYING") Or lblInformation.Text.ToUpper.Contains("UPDATED") Then
            If RecordAccessLevel.Contains("Update") Then
                cmdUpdate_Click()
            Else
                MessageBox.Show("Sorry. You are not allowed to perform this action. Please consult your system administrator for assistance.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If RecordAccessLevel.Contains("Save") Then
                cmdSave_Click()
                'Me.PanelNew.Visible = False
            Else
                MessageBox.Show("Sorry. You are not allowed to perform this action. Please consult your system administrator for assistance.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub


    Private Sub DeleteToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click
        If RecordAccessLevel.Contains("Delete") Then
            cmdDelete_Click()
        Else
            MessageBox.Show("Sorry. You are not allowed to perform this action. Please consult your system administrator for assistance.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Private Sub PrintToolStripButton_Click() Handles PrintToolStripButton.Click
       PrintGridView_Click()

    End Sub


    Private Sub cmdClosePanelNew_Click(sender As Object, e As EventArgs) Handles cmdClosePanelNew.Click
        Me.PanelNew.Visible = False 
    'LoadRecords()

    End Sub


    Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs) Handles HelpToolStripButton.Click
        'frmAbout.ShowDialog()

    End Sub


    Private Sub SearchToolStripButton_Click() Handles SearchToolStripButton.Click

        Try
            Dim QueryItems As String = "Version,UpdateFile,FileName,UpdatePriority,Description,RegDate,InputtedBy"
            Dim TableName As String = "ProgramUpdates"
            Dim Condition As String

            If SearchToolStripComboBox.Text = "" Then
                Condition = ""
            Else
                Condition = "Version = '" & SearchToolStripComboBox.Text & "'"
            End If

            Dim OrderByCondition As String = "ORDER BY Version DESC"

	    Dim MyTable As DataTable = GetDataForTable(QueryItems, TableName, Condition, OrderByCondition)

            If SearchToolStripComboBox.Text = "" Then
                MyReportTable.Rows.Clear
                MyReportTable.Columns.Clear

                MyReportTable = MyTable
                ProgramUpdatesDataGridView.DataSource = MyReportTable
            Else
                OpenNEWToolStripButton_Click()
                DisplayRecordInfo(MyTable.Rows(0).Item("Version"))
            End If
            isDateSearchUsed = False
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


    Private Sub MySearchItemsLoading() Handles Me.Load
        Dim QueryItem As String = "Version"
        Dim TableName As String = "ProgramUpdates"
	Dim MyTable As DataTable = GetDataForTable("TOP 50 (" & QueryItem & ")", TableName, "", " ORDER BY " & QueryItem & " DESC")

        For Each Record In MyTable.Rows
            SearchToolStripComboBox.Items.Add(Record(QueryItem))
        Next


        'PopulateDatainSearchToolStripButtonCombobox(QueryItem, TableName, SearchToolStripComboBox)

    End Sub


    Private Sub DataGridView_DataSourceChanged(sender As Object, e As EventArgs) Handles GridView1.FocusedRowChanged
        NoofRecordsToolStripStatusLabel.Text = GridView1.RowCount
    End Sub


    Private Sub DataGridView_FocusedRowChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GridView1.FocusedRowChanged
	    Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("Version"))
      'DisplayRecordInfo(DRecordID)

        Dim MyTable As DataTable = GetDataForTable(" * ", "ProgramUpdates", "Version = '" & DRecordID & "'", " ORDER BY Version ASC")

        VGridControl1.OptionsBehavior.SmartExpand = True
        VGridControl1.OptionsView.ShowHorzLines = True
        VGridControl1.OptionsView.ShowVertLines = False

        VGridControl1.DataSource = MyTable

    End Sub

#End Region


#Region "DASHBOARD RIBBON EVENT HANDLERS"


    Private Sub MyLoadingRibbonbuttonsEvents() Handles Me.Load

        AddHandler frmDashboardNew.BarButtonItemAddNew.ItemClick, AddressOf Me.Ribbon_AddNew
        AddHandler frmDashboardNew.BarButtonItemSave.ItemClick, AddressOf Me.Ribbon_Save
        AddHandler frmDashboardNew.BarButtonItemDelete.ItemClick, AddressOf Me.Ribbon_Delete
        AddHandler frmDashboardNew.BarButtonItemSearch.ItemClick, AddressOf Me.Ribbon_Search
        'AddHandler frmDashboardNew.BarButtonItemPrint.ItemClick, AddressOf Me.Ribbon_Print
        AddHandler frmDashboardNew.BarButtonItemOpen.ItemClick, AddressOf Me.Ribbon_Open


    End Sub


    Private Sub Ribbon_AddNew()
        If CurrentDisplayedFormName = Me.Name Then
            cmdAdd_Click()

           OpenNEWToolStripButton_Click()
        End If

    End Sub


    Private Sub Ribbon_Save()

frmDashboardNew.BarButtonItemSave.Enabled = False
        If CurrentDisplayedFormName = Me.Name Then
            If Not lblInformation.Text.ToUpper.Contains("DISPLAY") And Not lblInformation.Text.ToUpper.Contains("UPDATED") Then
                If RecordAccessLevel.Contains("Save") Then
                    cmdSave_Click()
                Else
                    MessageBox.Show("Sorry you are not allowed to use this function. Please consult your administrator for assistance.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                If CurrentDisplayedFormName = Me.Name Then
                    If RecordAccessLevel.Contains("Update") Then
                        cmdUpdate_Click()
                    Else
                        MessageBox.Show("Sorry you are not allowed to use this function. Please consult your administrator for assistance.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If

        End If

frmDashboardNew.BarButtonItemSave.Enabled = True


    End Sub
 

    Private Sub Ribbon_Delete()

        If CurrentDisplayedFormName = Me.Name Then
            If RecordAccessLevel.Contains("Delete") Then
                cmdDelete_Click()
            Else
                MessageBox.Show("Sorry you are not allowed to use this function. Please consult your administrator for assistance.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        

    End Sub


    Private Sub Ribbon_Open()

        If CurrentDisplayedFormName = Me.Name Then
           OpenToolStripButton_Click()
        End If


    End Sub


    Private Sub Ribbon_Print()

        If CurrentDisplayedFormName = Me.Name Then
            PrintToolStripMenuItem.PerformClick()
        End If


    End Sub


    Private Sub Ribbon_Search()
        If CurrentDisplayedFormName = Me.Name Then
            SearchToolStripMenuItem.PerformClick()
        End If

    End Sub

#End Region


#Region "EXPORTING AND OTHER FUNCTIONS FROM DASHBOARD BUTTONS"


    Private Sub MyRibbonExportandOthersEvents() Handles Me.Load

        AddHandler frmDashboardNew.BarButtonItemExportCSV.ItemClick, AddressOf Me.ExportToCSV_Click
        AddHandler frmDashboardNew.BarButtonItemExportHTML.ItemClick, AddressOf Me.ExportToHTML_Click
        AddHandler frmDashboardNew.BarButtonItemExportMHT.ItemClick, AddressOf Me.ExportToMHT_Click
        AddHandler frmDashboardNew.BarButtonItemExportPDF.ItemClick, AddressOf Me.ExportToPDF_Click
        AddHandler frmDashboardNew.BarButtonItemExportText.ItemClick, AddressOf Me.ExportToText_Click
        AddHandler frmDashboardNew.BarButtonItemExportWord.ItemClick, AddressOf Me.ExportToRTF_Click
        AddHandler frmDashboardNew.BarButtonItemExportXLS.ItemClick, AddressOf Me.ExportToExcel2003_Click
        AddHandler frmDashboardNew.BarButtonItemExportXLSX.ItemClick, AddressOf Me.ExportToExcel2007_Click

        AddHandler frmDashboardNew.BarButtonItemSelectAll.ItemClick, AddressOf Me.SelectAll_Click
        AddHandler frmDashboardNew.BarButtonItemCopytoClipboard.ItemClick, AddressOf Me.CopytoClipboard_Click
        AddHandler frmDashboardNew.BarButtonItemPrint.ItemClick, AddressOf Me.PrintGridView_Click
        AddHandler frmDashboardNew.BarButtonItemExpandAllGroups.ItemClick, AddressOf Me.ExpandAllGroups_Click
        AddHandler frmDashboardNew.BarButtonItemAlternateRowColor.ItemClick, AddressOf Me.AlternateRowColor_Click
        AddHandler frmDashboardNew.BarButtonItemColumnChooser.ItemClick, AddressOf Me.ColumnChooser_Click
        AddHandler frmDashboardNew.BarButtonItemRecordFilter.ItemClick, AddressOf Me.RecordFilter_Click
        AddHandler frmDashboardNew.BarButtonItemBestFitallColumns.ItemClick, AddressOf Me.BestFitallColumns_Click
        AddHandler frmDashboardNew.BarButtonItemFilterEditor.ItemClick, AddressOf Me.FilterEditor_Click
        AddHandler frmDashboardNew.BarButtonItemLoadAllRecords.ItemClick, AddressOf Me.LoadAllRecords_Click


        GridView1.OptionsSelection.MultiSelect = True
        GridView1.Appearance.EvenRow.BackColor = Color.WhiteSmoke
        GridView1.OptionsView.EnableAppearanceEvenRow = False
        GridView1.OptionsBehavior.ReadOnly = True
      GridView1.OptionsView.ShowFooter = True
      GridView1.OptionsMenu.EnableFooterMenu = True
      GridView1.OptionsMenu.EnableGroupPanelMenu = True
        GridView1.OptionsView.ColumnAutoWidth = False
        SplitContainerControl1.Collapsed = False


    End Sub

  Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
  OpenToolStripButton_Click()
  End Sub

    Private Sub ExportToExcel2003_Click()

        If CurrentDisplayedFormName = Me.Name Then

            Try
                Dim SVD1 As New SaveFileDialog()
                SVD1.Filter = "Excel (2003)|*.xls"

                If SVD1.ShowDialog() <> DialogResult.Cancel Then
                    Dim TheExtension As String = New System.IO.FileInfo(SVD1.FileName).Extension
                    GridView1.OptionsPrint.PrintDetails = True
                    GridView1.OptionsPrint.ExpandAllDetails = True
                    GridView1.ExportToXls(SVD1.FileName)

                    If FileIO.FileSystem.FileExists(SVD1.FileName) Then
                        System.Diagnostics.Process.Start(SVD1.FileName)
                    Else
                        MessageBox.Show("File Could not be opened." & System.Environment.NewLine & "Path: " & SVD1.FileName, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub


    Private Sub ExportToExcel2007_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                Dim SVD1 As New SaveFileDialog()
                SVD1.Filter = "Excel (2007)|*.xlsx"

                If SVD1.ShowDialog() <> DialogResult.Cancel Then
                    Dim TheExtension As String = New System.IO.FileInfo(SVD1.FileName).Extension
                    GridView1.OptionsPrint.PrintDetails = True
                    GridView1.OptionsPrint.ExpandAllDetails = True
                    GridView1.ExportToXlsx(SVD1.FileName)

                    If FileIO.FileSystem.FileExists(SVD1.FileName) Then
                        System.Diagnostics.Process.Start(SVD1.FileName)
                    Else
                        MessageBox.Show("File Could not be opened." & System.Environment.NewLine & "Path: " & SVD1.FileName, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If



    End Sub


    Private Sub ExportToText_Click()
        If CurrentDisplayedFormName = Me.Name Then

            Try
                Dim SVD1 As New SaveFileDialog()
                SVD1.Filter = "Text|*.txt"

                If SVD1.ShowDialog() <> DialogResult.Cancel Then
                    Dim TheExtension As String = New System.IO.FileInfo(SVD1.FileName).Extension
                    GridView1.OptionsPrint.PrintDetails = True
                    GridView1.OptionsPrint.ExpandAllDetails = True
                    GridView1.ExportToText(SVD1.FileName)

                    If FileIO.FileSystem.FileExists(SVD1.FileName) Then
                        System.Diagnostics.Process.Start(SVD1.FileName)
                    Else
                        MessageBox.Show("File Could not be opened." & System.Environment.NewLine & "Path: " & SVD1.FileName, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If


    End Sub


    Private Sub ExportToRTF_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                Dim SVD1 As New SaveFileDialog()
                SVD1.Filter = "Doc|*.rtf"

                If SVD1.ShowDialog() <> DialogResult.Cancel Then
                    Dim TheExtension As String = New System.IO.FileInfo(SVD1.FileName).Extension
                    GridView1.OptionsPrint.PrintDetails = True
                    GridView1.OptionsPrint.ExpandAllDetails = True
                    GridView1.ExportToRtf(SVD1.FileName)

                    If FileIO.FileSystem.FileExists(SVD1.FileName) Then
                        System.Diagnostics.Process.Start(SVD1.FileName)
                    Else
                        MessageBox.Show("File Could not be opened." & System.Environment.NewLine & "Path: " & SVD1.FileName, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If



    End Sub



    Private Sub ExportToPDF_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                Dim SVD1 As New SaveFileDialog()
                SVD1.Filter = "PDF|*.pdf"

                If SVD1.ShowDialog() <> DialogResult.Cancel Then
                    Dim TheExtension As String = New System.IO.FileInfo(SVD1.FileName).Extension
                    GridView1.OptionsPrint.PrintDetails = True
                    GridView1.OptionsPrint.AllowMultilineHeaders = True
                    GridView1.OptionsPrint.ExpandAllDetails = True
                    GridView1.ExportToPdf(SVD1.FileName)

                    If FileIO.FileSystem.FileExists(SVD1.FileName) Then
                        System.Diagnostics.Process.Start(SVD1.FileName)
                    Else
                        MessageBox.Show("File Could not be opened." & System.Environment.NewLine & "Path: " & SVD1.FileName, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub ExportToMHT_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                Dim SVD1 As New SaveFileDialog()
                SVD1.Filter = "MHT|*.mht"

                If SVD1.ShowDialog() <> DialogResult.Cancel Then
                    Dim TheExtension As String = New System.IO.FileInfo(SVD1.FileName).Extension
                    GridView1.OptionsPrint.PrintDetails = True
                    GridView1.OptionsPrint.ExpandAllDetails = True
                    GridView1.ExportToMht(SVD1.FileName)

                    If FileIO.FileSystem.FileExists(SVD1.FileName) Then
                        System.Diagnostics.Process.Start(SVD1.FileName)
                    Else
                        MessageBox.Show("File Could not be opened." & System.Environment.NewLine & "Path: " & SVD1.FileName, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If



    End Sub



    Private Sub ExportToHTML_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                Dim SVD1 As New SaveFileDialog()
                SVD1.Filter = "HTML|*.html"

                If SVD1.ShowDialog() <> DialogResult.Cancel Then
                    Dim TheExtension As String = New System.IO.FileInfo(SVD1.FileName).Extension
                    GridView1.OptionsPrint.PrintDetails = True
                    GridView1.OptionsPrint.ExpandAllDetails = True
                    GridView1.ExportToHtml(SVD1.FileName)

                    If FileIO.FileSystem.FileExists(SVD1.FileName) Then
                        System.Diagnostics.Process.Start(SVD1.FileName)
                    Else
                        MessageBox.Show("File Could not be opened." & System.Environment.NewLine & "Path: " & SVD1.FileName, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If



    End Sub


    Private Sub ExportToCSV_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                Dim SVD1 As New SaveFileDialog()
                SVD1.Filter = "CSV|*.csv"

                If SVD1.ShowDialog() <> DialogResult.Cancel Then
                    Dim TheExtension As String = New System.IO.FileInfo(SVD1.FileName).Extension
                    GridView1.OptionsPrint.PrintDetails = True
                    GridView1.OptionsPrint.ExpandAllDetails = True
                    GridView1.ExportToCsv(SVD1.FileName)

                    If FileIO.FileSystem.FileExists(SVD1.FileName) Then
                        System.Diagnostics.Process.Start(SVD1.FileName)
                    Else
                        MessageBox.Show("File Could not be opened." & System.Environment.NewLine & "Path: " & SVD1.FileName, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub SelectAll_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                GridView1.SelectAll()
            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
Try
      GridView1.CopyToClipboard()
Catch ex As Exception
      MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
End Try

    End Sub

    Private Sub CopytoClipboard_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                GridView1.CopyToClipboard()
            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub PrintGridView_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
      GridView1.OptionsPrint.AllowMultilineHeaders = True
      GridView1.OptionsPrint.PrintHeader = True
      GridView1.OptionsPrint.PrintFooter = True
      GridView1.OptionsPrint.UsePrintStyles = True
      GridView1.OptionsPrint.RtfReportHeader = frmDashboardNew.XtraTabControlFull.SelectedTabPage.Text
                GridView1.ShowPrintPreview()
            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub ExpandAllGroups_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                GridView1.ExpandAllGroups()
            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub GridView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles GridView1.MouseDown
        Try
            Dim view As GridView = TryCast(sender, GridView)
            Dim hitInfo As ViewInfo.GridHitInfo = view.CalcHitInfo(e.Location)
            If hitInfo.HitTest = ViewInfo.GridHitTest.ColumnButton Then
                view.SelectAll()
            End If
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub AlternateRowColor_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try

                If GridView1.OptionsView.EnableAppearanceEvenRow Then
                    GridView1.OptionsView.EnableAppearanceEvenRow = False
                Else
                    GridView1.Appearance.EvenRow.BackColor = Color.WhiteSmoke
                    GridView1.OptionsView.EnableAppearanceEvenRow = True
                End If

            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub ColumnChooser_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                GridView1.ColumnsCustomization()
            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub RecordFilter_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                GridView1.ShowFindPanel()

            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub BestFitallColumns_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                GridView1.BestFitColumns()

            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub FilterEditor_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                GridView1.ShowFilterEditor(GridView1.FocusedColumn)
            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub LoadAllRecords_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

                Dim Query As String = " SELECT Version,UpdateFile,FileName,UpdatePriority,Description,RegDate,InputtedBy FROM ProgramUpdates ORDER BY Version DESC "
                Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

                MyReportTable.Rows.Clear()
                ConTableAdapter.Fill(MyReportTable)

                ProgramUpdatesDataGridView.DataSource = MyReportTable

                If MyReportTable.Rows.Count > 0 Then
                    DisplayRecordInfo(MyReportTable.Rows(0).Item("Version"))
                End If

            Catch Ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

Private Sub frmProgramUpdates_GotFocus(sender As Object, e As EventArgs) Handles Me.Activated
      CurrentDisplayedFormName = Me.Name
End Sub

#End Region
Private Sub cmdPrevious_Click(sender As Object, e As EventArgs) Handles cmdPrevious.Click
GridView1.MovePrev()
	    Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("Version"))
        DisplayRecordInfo(DRecordID)
End Sub
Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
GridView1.MoveNext()
	    Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("Version"))
        DisplayRecordInfo(DRecordID)
End Sub



     Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Try

If PanelNew.Visible = False Then
Dim RecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("Version"))
DisplayRecordInfo(RecordID)
End If

If MySingleReportTable.Rows.Count = 0 Then
MessageBox.Show("No data was loaded. Please select a record before proceeding with the printing process.", "Empty Set", MessageBoxButtons.OK, MessageBoxIcon.Warning)
Exit Sub
 End If
            Dim MyCompanyTable As New DataTable
            MyCompanyTable = GetCompanyData()

            Dim MyDocument As New XtraReportProgramUpdatesSingle
            MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
            MyDocument.ProgramUpdatesDataSource.DataSource = MySingleReportTable
            MyDocument.XrLabelReportTitle.Text = "Program Updates"

            If MyCompanyTable.Rows.Count > 0 Then
                Dim MYBytes As Byte() = MyCompanyTable.Rows(0).Item("Logo")
                Dim MyMemoryStream As New System.IO.MemoryStream(MYBytes)
                Dim MyImage As Image = Image.FromStream(MyMemoryStream)

                MyDocument.Watermark.Image = MyImage
                MyDocument.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Zoom
                MyDocument.Watermark.ImageTransparency = 250
                MyDocument.Watermark.ImageAlign = ContentAlignment.MiddleCenter
            End If

            MyDocument.CreateDocument()

            Dim MyViewer As New frmNewReportViewer
            MyViewer.WindowState = FormWindowState.Maximized
            MyViewer.DocumentViewer1.DocumentSource = MyDocument
            MyViewer.Show(Me)

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub PrintAllListedRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintAllListedRecordsToolStripMenuItem.Click
        Try

If MyReportTable.Rows.Count = 0 Then
MessageBox.Show("No data has been loaded. Please make sure there are records in the table before proceeding with the printing process.", "Empty Set", MessageBoxButtons.OK, MessageBoxIcon.Warning)
Exit Sub
 End If

            Dim MyCompanyTable As New DataTable
            MyCompanyTable = GetCompanyData()

            Dim MyDocument As New XtraReportProgramUpdatesMultiple
            MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
            MyDocument.ProgramUpdatesDataSource.DataSource = MyReportTable
            MyDocument.XrLabelReportTitle.Text = "ProgramUpdates"

            If isDateSearchUsed Then
                MyDocument.XrLabelReportDateField.Text = SearchDateFieldComboBox.Text
                MyDocument.XrLabelReportDateCriteria.Text = StartDateTimePicker.DateTime.ToString("dd/MM/yyyy") & "  -  " & EndDateTimePicker.DateTime.ToString("dd/MM/yyyy")
                MyDocument.XrLabelReportCriteriaLabel.Visible = True
            Else
                MyDocument.XrLabelReportDateField.Visible = False
                MyDocument.XrLabelReportDateCriteria.Visible = False
                MyDocument.XrLabelReportCriteriaLabel.Visible = False
            End If

            If MyCompanyTable.Rows.Count > 0 Then
                Dim MYBytes As Byte() = MyCompanyTable.Rows(0).Item("Logo")
                Dim MyMemoryStream As New System.IO.MemoryStream(MYBytes)
                Dim MyImage As Image = Image.FromStream(MyMemoryStream)

                MyDocument.Watermark.Image = MyImage
                MyDocument.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Zoom
                MyDocument.Watermark.ImageTransparency = 250
                MyDocument.Watermark.ImageAlign = ContentAlignment.MiddleCenter
            End If

            MyDocument.CreateDocument()

            Dim MyViewer As New frmNewReportViewer
            MyViewer.WindowState = FormWindowState.Maximized
            MyViewer.DocumentViewer1.DocumentSource = MyDocument
            MyViewer.Show(Me)

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


#Region "SEARCH BY DATE"

    Private Function GetAllFields(ByVal TableName As String, ByVal DatabaseName As String) As String
        Try
            Dim Conn As New System.Data.SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT COLUMN_NAME FROM " & DatabaseName & ".INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" & TableName & "'"

            Dim MyTable As New DataTable

            Dim conTableAdapter As New System.Data.SqlClient.SqlDataAdapter(Query, Conn)
            conTableAdapter.Fill(MyTable)

            Dim AllFields As String = ""

            If MyTable.Rows.Count > 0 Then
                For Each Record In MyTable.Rows
                    If Record("COLUMN_NAME").ToString.ToUpper <> "CREATEDON" And Record("COLUMN_NAME").ToString.ToUpper <> "CREATEDBY" And Record("COLUMN_NAME").ToString.ToUpper <> "MODIFIEDBY" And Record("COLUMN_NAME").ToString.ToUpper <> "MODIFIEDON" And Record("COLUMN_NAME").ToString.ToUpper <> "DELETEFLAQ" And Record("COLUMN_NAME").ToString.ToUpper <> "ROWNUMBER" Then
                        If AllFields = "" Then
                            AllFields = Record("COLUMN_NAME")
                        Else
                            AllFields = AllFields & "," & Record("COLUMN_NAME")
                        End If
                    End If
                Next
            End If

            Return AllFields

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Sub FormLoadingSetup() Handles Me.Load
        Try
            SearchDateFieldComboBox.Properties.Items.Clear()
            SearchDateFieldComboBox.Text = ""

            Dim Allfields As String = GetAllFields("ProgramUpdates", DatabaseName)
            Dim splitfields As String() = Allfields.Trim.Split(",")

            Dim QueryString As String = ""

            For Each field In splitfields

                Dim ColumnType As String = GetColumnDataType("ProgramUpdates", field).ToUpper

                If ColumnType.Contains("DATE") Then
                    SearchDateFieldComboBox.Properties.Items.Add(field)
                End If

            Next

            If SearchDateFieldComboBox.Properties.Items.Count > 0 Then
                SearchDateFieldComboBox.SelectedIndex = 0
            End If

            StartDateTimePicker.DateTime = DateTime.Today
            EndDateTimePicker.DateTime = DateTime.Today
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


    Private Sub SearchByDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchByDateToolStripMenuItem.Click
        Me.PanelSearchByDate.Visible = True
        Me.PanelSearchByDate.BringToFront()

    End Sub


    Private Sub cmdCloseSearchbyDate_Click(sender As Object, e As EventArgs) Handles cmdCloseSearchbyDate.Click
        Me.PanelSearchByDate.Visible = False

    End Sub


    Private Sub cmdDateSearch_Click(sender As Object, e As EventArgs) Handles cmdDateSearch.Click
        If SearchDateFieldComboBox.SelectedIndex <> -1 Then
            Try
                Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

                Dim Query As String = " SELECT Version,UpdateFile,FileName,UpdatePriority,Description,RegDate,InputtedBy FROM ProgramUpdates WHERE " & SearchDateFieldComboBox.Text & " BETWEEN '" & StartDateTimePicker.DateTime.ToString("yyy-MM-dd") & "' AND '" & EndDateTimePicker.DateTime.ToString("yyyy-MM-dd") & "' ORDER BY Version DESC "
                Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

                Dim MyTable As New DataTable
                ConTableAdapter.Fill(MyTable)

                If MyTable.Rows.Count > 0 Then
                    MyReportTable.Rows.Clear()
                    MyReportTable = MyTable.Copy()

                    ProgramUpdatesDataGridView.DataSource = MyReportTable
                    Me.PanelNew.Visible = False

                   isDateSearchUsed = True
                    MessageBox.Show("Search Complete. " & MyTable.Rows.Count & " record(s) found.", "Search Complete", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    'If MyReportTable.Rows.Count > 0 Then
                    'DisplayRecordInfo(MyReportTable.Rows(0).Item("Version"))
                    'End If
                Else
                    MessageBox.Show("No Record was found matching the search criteria. Please verify and try again.", "Empty Result", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If


            Catch Ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select the Date condition you wish to use and specify the start and end date criteria", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
#End Region




End Class