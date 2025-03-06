
Imports Excel = Microsoft.Office.Interop.Excel

Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Public Class frmGeneralSales
    Dim CurrentRowIndex As Integer
    Dim WasCellEdited As Boolean
    Dim PrimaryKeyValuetoDelete As String
    Dim isDateSearchUsed As Boolean

    Dim ExportFileName As String
    Dim ExportCount As Integer
    Dim ExpectedNoValues As Integer
    Dim NoofColumns As Integer
    Public isCalled As Boolean
    Dim LoadedGPaymentID As String
    Public MyReportTable As New DataTable
    Dim MySingleReportTable As New DataTable
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
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT  GPaymentID,OutgoneSales,TransactionPosted,PaidBy,PaymentDate,TotalAmount,AmountPaid,Balance,Comment,RegDate,InputedBy FROM GeneralSales ORDER BY GPaymentID DESC "
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            MyReportTable.Rows.Clear()
            ConTableAdapter.Fill(MyReportTable)

            GeneralSalesDataGridView.DataSource = MyReportTable
            isDateSearchUsed = False
            'If MyReportTable.Rows.Count > 0 Then
            'DisplayRecordInfo(MyReportTable.Rows(0).Item("GPaymentID"))
            'End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateID(ByVal GPaymentID As String) As Boolean
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT Count(*) FROM GeneralSales WHERE GPaymentID = '" & GPaymentID & "'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Conn.Open()
            Dim Recordcount As Integer = ConCommand.ExecuteScalar
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
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT Count(*) FROM GeneralSales WHERE GPaymentID LIKE 'G" & DateTime.Today.ToString("yyMM") & "%'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Conn.Open()
            Dim Recordcount As Integer = ConCommand.ExecuteScalar
            Conn.Close()
            Dim IsIDGenerated As Boolean = False
            Dim Start As String = Nothing

            While IsIDGenerated = False
                Recordcount += 1
                If Recordcount >= 0 And Recordcount < 10 Then
                    Start = "G" & CurrentUserID & DateTime.Today.ToString("yyMMdd") & "000" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                ElseIf Recordcount >= 10 And Recordcount < 100 Then
                    Start = "G" & CurrentUserID & DateTime.Today.ToString("yyMMdd") & "00" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                ElseIf Recordcount >= 100 And Recordcount < 1000 Then
                    Start = "G" & CurrentUserID & DateTime.Today.ToString("yyMMdd") & "0" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                ElseIf Recordcount >= 1000 And Recordcount < 10000 Then
                    Start = "G" & CurrentUserID & DateTime.Today.ToString("yyMMdd") & "" & Recordcount
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

    Private Sub cmdAdd_Click() 'Handles cmdAdd.Click


        lblInformation.Text = "Adding new record"
        XtraTabControlRelated.Visible = False
        If Not isCalled Then
            LoadedGPaymentID = ""
        End If
        GPaymentIDTextBox.Text = ""
        OutgoneSalesCheckEdit.Checked = False

        PaidByTextBox.Text = ""
        PaymentDateDateTimePicker.DateTime = DateTime.Now
        TotalAmountTextBox.Text = "0"
        AmountPaidTextBox.Text = "0"
        BalanceTextBox.Text = "0"
        CommentTextBox.Text = ""
        RegDateTextBox.Text = ""

        RegDateTextBox.Text = Date.Today
        RegDateTextBox.ReadOnly = True

        InputedByTextBox.Text = ""

        InputedByTextBox.Text = CurrentUserID
        InputedByTextBox.ReadOnly = True

        cmdPostCheckButton.Checked = False

        GPaymentIDTextBox.Text = GenerateID()

    End Sub

    Private Sub cmdSave_Click() 'Handles cmdSave.Click
        Try
            If GPaymentIDTextBox.Text <> "" Then
                If ValidateID(GPaymentIDTextBox.Text) Then
                    MessageBox.Show("This GPayment ID already exist in this table. DUPLICATE 'GPAYMENT ID' ARE NOT ALLOWED. Please verify and try again.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Exit Sub
                End If
            End If
            If Not ValidateAllForeignKeys() Then

                Exit Sub
            End If
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "INSERT INTO GeneralSales (GPaymentID,OutgoneSales,PaidBy,PaymentDate,TotalAmount,AmountPaid,Balance,Comment,RegDate,InputedBy) VALUES(@GPaymentID,@OutgoneSales,@PaidBy,@PaymentDate,@TotalAmount,@AmountPaid,@Balance,@Comment,@RegDate,@InputedBy)"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)
            With ConCommand.Parameters
                .AddWithValue("@GPaymentID", GPaymentIDTextBox.Text)
                .AddWithValue("@OutgoneSales", OutgoneSalesCheckEdit.Checked)

                .AddWithValue("@PaidBy", PaidByTextBox.Text)
                .AddWithValue("@PaymentDate", PaymentDateDateTimePicker.DateTime.Date)
                .AddWithValue("@TotalAmount", TotalAmountTextBox.Text)
                .AddWithValue("@AmountPaid", AmountPaidTextBox.Text)
                .AddWithValue("@Balance", BalanceTextBox.Text)
                .AddWithValue("@Comment", CommentTextBox.Text)
                .AddWithValue("@RegDate", Date.Today)
                .AddWithValue("@InputedBy", InputedByTextBox.Text)
            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

            lblInformation.Text = "Successfully Inserted a new record"
            CreateLog(CurrentUserID, FullNameofUser, "Insert of new record in table (" & "GeneralSales" & " With ID (" & GPaymentIDTextBox.Text & ")", 0)
            LoadRecords()
            'cmdAdd_Click()
            DisplayRecordInfo(GPaymentIDTextBox.Text)

        Catch Ex As Exception
            If Ex.Message.ToUpper.Contains("FOREIGN") Then
                MessageBox.Show("Record Constraint Violation. Please make sure that  have values. If any does not have an applicable value then please select 'N/A' from the drop down list." & Ex.Message, "Incomplete entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End Try
    End Sub

    Private Sub cmdUpdate_Click() 'Handles cmdUpdate.Click
        Try
            If Not ValidateID(LoadedGPaymentID) Then
                MessageBox.Show("The loaded GPayment ID (" & LoadedGPaymentID & ") was not found in the database table. UPDATE OPERATION WILL NOT BE SUCCESSFULL. Please verify and try again.", "Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub
            End If
            If Not ValidateAllForeignKeys() Then

                Exit Sub
            End If
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "UPDATE GeneralSales SET OutgoneSales =@OutgoneSales, PaidBy =@PaidBy, PaymentDate =@PaymentDate, TotalAmount =@TotalAmount, AmountPaid =@AmountPaid, Balance =@Balance, Comment =@Comment, RegDate =@RegDate, InputedBy =@InputedBy WHERE GPaymentID = '" & LoadedGPaymentID & "'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)
            With ConCommand.Parameters
                .AddWithValue("@GPaymentID", GPaymentIDTextBox.Text)
                .AddWithValue("@OutgoneSales", OutgoneSalesCheckEdit.Checked)

                .AddWithValue("@PaidBy", PaidByTextBox.Text)
                .AddWithValue("@PaymentDate", PaymentDateDateTimePicker.DateTime.Date)
                .AddWithValue("@TotalAmount", TotalAmountTextBox.Text)
                .AddWithValue("@AmountPaid", AmountPaidTextBox.Text)
                .AddWithValue("@Balance", BalanceTextBox.Text)
                .AddWithValue("@Comment", CommentTextBox.Text)
                .AddWithValue("@RegDate", Date.Today)
                .AddWithValue("@InputedBy", InputedByTextBox.Text)
            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()
            lblInformation.Text = "Successfully Updated a record"
            CreateLog(CurrentUserID, FullNameofUser, "Update of record in table (" & "GeneralSales" & " With ID (" & GPaymentIDTextBox.Text & ")", 0)
        Catch Ex As Exception
            If Ex.Message.ToUpper.Contains("FOREIGN") Then
                MessageBox.Show("Record Constraint Violation. Please make sure that  have values. If any does not have an applicable value then please select 'N/A' from the drop down list." & Ex.Message, "Incomplete entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End Try
    End Sub

    Private Sub cmdDelete_Click() 'Handles cmdDelete.Click
        If MessageBox.Show("Do you really want to delete the current record?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            Try
                Dim ThePKey As String = ""
                If PanelNew.Visible Then
                    ThePKey = GPaymentIDTextBox.Text
                Else
                    ThePKey = GridView1.GetFocusedDataRow.Item("GPaymentID")
                End If

                Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
                Dim Query As String = "DELETE FROM GeneralSales WHERE GPaymentID = '" & ThePKey & "'"
                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                Conn.Open()
                ConCommand.ExecuteNonQuery()
                Conn.Close()
                lblInformation.Text = "Record Deleted"
                CreateLog(CurrentUserID, FullNameofUser, "Delete of record in table (" & "GeneralSales" & " With ID (" & ThePKey & ")", 0)
                LoadRecords()
                Dim TheNewPKey As String = ""
                If MyReportTable.Rows.Count > 0 Then
                    TheNewPKey = GridView1.GetFocusedDataRow.Item("GPaymentID")
                End If

                If PanelNew.Visible Then
                    If ThePKey <> "" Then
                        DisplayRecordInfo(TheNewPKey)
                    End If
                End If


            Catch Ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    'Private Sub GPaymentIDTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GPaymentIDTextBox.TextChanged
    'DisplayRecordInfo(GPaymentIDTextBox.Text)
    'End Sub
    Public Sub DisplayRecordInfo(ByVal RecordID As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT GPaymentID,OutgoneSales,TransactionPosted,PaidBy,PaymentDate,TotalAmount,AmountPaid,Balance,Comment,RegDate,InputedBy FROM GeneralSales WHERE GPaymentID = '" & RecordID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)
            MySingleReportTable.Rows.Clear()
            ConTableAdapter.Fill(MySingleReportTable)

            If MySingleReportTable.Rows.Count > 0 Then
                lblInformation.Text = "Displaying details Of a record"
                GPaymentIDTextBox.Text = MySingleReportTable.Rows(0).Item("GPaymentID").ToString
                OutgoneSalesCheckEdit.Checked = CByte(MySingleReportTable.Rows(0).Item("OutgoneSales"))

                PaidByTextBox.Text = MySingleReportTable.Rows(0).Item("PaidBy").ToString
                PaymentDateDateTimePicker.DateTime = MySingleReportTable.Rows(0).Item("PaymentDate")
                TotalAmountTextBox.Text = MySingleReportTable.Rows(0).Item("TotalAmount").ToString
                AmountPaidTextBox.Text = MySingleReportTable.Rows(0).Item("AmountPaid").ToString
                BalanceTextBox.Text = MySingleReportTable.Rows(0).Item("Balance").ToString
                CommentTextBox.Text = MySingleReportTable.Rows(0).Item("Comment").ToString
                RegDateTextBox.Text = MySingleReportTable.Rows(0).Item("RegDate").ToString

                RegDateTextBox.ReadOnly = True

                InputedByTextBox.Text = MySingleReportTable.Rows(0).Item("InputedBy").ToString

                InputedByTextBox.ReadOnly = True

                If MySingleReportTable.Rows(0).Item("TransactionPosted") = True Then
                    cmdPostCheckButton.Checked = True
                    cmdPrintReceipt.Enabled = True
                Else
                    cmdPostCheckButton.Checked = False
                    cmdPrintReceipt.Enabled = False
                End If

                XtraTabControlRelated.Visible = True
                LoadGeneralSalesItemsRecords(GPaymentIDTextBox.Text)
                LoadedGPaymentID = GPaymentIDTextBox.Text

                cmdPrintReceipt.Enabled = True
                lblInformation.Text = "Displaying details Of a record"

            Else
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "GeneralSalesItems"

    Private Sub LoadGeneralSalesItemsRecords(ByVal RecordID As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT ItemID, GPaymentID, StockID, (SELECT NameOfItem FROM Inventory WHERE Inventory.StockID = GeneralSalesItems.StockID) AS NameOfItem, SalesCategory, UnitOfMeasurement, Quantity, UnitCost, TotalCost, SalesCategory, Comment, RegDate, InputtedBy FROM GeneralSalesItems WHERE GPaymentID = '" & RecordID & "' ORDER BY RowNumber DESC "
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            GeneralSalesItemsGridView.DataSource = MYTABLE

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdAddGeneralSalesItems_Click(sender As Object, e As EventArgs) Handles cmdAddGeneralSalesItems.Click
        Try
            If cmdPostCheckButton.Checked Then
                MessageBox.Show("This Transaction is ALREADY POSTED. Please unPost it by Clicking the 'Post Transaction' button again before REMOVING or ADDING ITEMS?", "ALREADY POSTED", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim MyForm As New frmGeneralSalesItems
            MyForm.isCalled = True
            MyForm.PrepareForm()
            MyForm.NewToolStripButton.PerformClick()
            MyForm.GPaymentIDGridBox.EditValue = Me.GPaymentIDTextBox.Text

            MyForm.WindowState = FormWindowState.Normal
            MyForm.FormBorderStyle = FormBorderStyle.Sizable
            MyForm.ShowDialog()

            DisplayRecordInfo(GPaymentIDTextBox.Text)

            'LoadGeneralSalesItemsRecords(GPaymentIDTextBox.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdRemoveGeneralSalesItems_Click(sender As Object, e As EventArgs) Handles cmdRemoveGeneralSalesItems.Click

        If RecordAccessLevel.Contains("Delete") Then
            If cmdPostCheckButton.Checked Then
                MessageBox.Show("This Transaction is ALREADY POSTED. Please unPost it by Clicking the 'Post Transaction' button again before REMOVING or ADDING ITEMS?", "ALREADY POSTED", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("Do you really want to delete the current record?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                Try
                    '**************************
                    '**************************
                    Dim RecordID As String = GridViewGeneralSalesItems.GetFocusedRowCellDisplayText(GridViewGeneralSalesItems.Columns("ItemID"))
                    Dim StockID As String = GridViewGeneralSalesItems.GetFocusedRowCellDisplayText(GridViewGeneralSalesItems.Columns("StockID"))
                    Dim SalesCategory As String = GridViewGeneralSalesItems.GetFocusedRowCellDisplayText(GridViewGeneralSalesItems.Columns("SalesCategory"))
                    Dim Quantity As Double = GridViewGeneralSalesItems.GetFocusedRowCellDisplayText(GridViewGeneralSalesItems.Columns("Quantity"))

                    Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
                    Dim Query As String = "DELETE FROM GeneralSalesItems WHERE ItemID = '" & RecordID & "'"
                    Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                    Conn.Open()
                    ConCommand.ExecuteNonQuery()
                    Conn.Close()

                    'UPDATESTOCKQuantity(StockID, SalesCategory, Quantity)

                    UPDATEGeneralSalesTotalAmount(GPaymentIDTextBox.Text)

                    CreateLog(CurrentUserID, FullNameofUser, "Delete of GeneralSalesItems for " + GPaymentIDTextBox.Text, 0)

                    DisplayRecordInfo(GPaymentIDTextBox.Text)

                    'LoadGeneralSalesItemsRecords(GPaymentIDTextBox.Text)

                Catch Ex As Exception
                    MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Sorry you are not allowed to use this function. Please consult your administrator for assistance.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Private Function GetGeneralSalesItemsSumTotalAmount(ByVal GPaymentID As String) As Double
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT SUM(TotalCost) AS Total FROM GeneralSalesItems WHERE GPaymentID = '" & GPaymentID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim TheTable As New DataTable
            ConTableAdapter.Fill(TheTable)

            If TheTable.Rows.Count > 0 Then
                If Not IsDBNull(TheTable.Rows(0).Item("Total")) Then
                    Return CDbl(TheTable.Rows(0).Item("Total"))
                Else
                    Return 0
                End If
            Else
                Return 0
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
            Return 0
        End Try
    End Function

    Private Function GetGeneralSalesItemsSumAmountPaid(ByVal GPaymentID As String) As Double
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT AmountPaid AS Total FROM GeneralSales WHERE GPaymentID = '" & GPaymentID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim TheTable As New DataTable
            ConTableAdapter.Fill(TheTable)

            If TheTable.Rows.Count > 0 Then
                If Not IsDBNull(TheTable.Rows(0).Item("Total")) Then
                    Return CDbl(TheTable.Rows(0).Item("Total"))
                Else
                    Return 0
                End If
            Else
                Return 0
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
            Return 0
        End Try
    End Function

    Private Sub UPDATEGeneralSalesTotalAmount(ByVal GPaymentID As String)
        Try
            Dim TheTotal As Double = GetGeneralSalesItemsSumTotalAmount(GPaymentID)
            Dim TheAmountPaid As Double = GetGeneralSalesItemsSumAmountPaid(GPaymentID)

            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "UPDATE GeneralSales SET TotalAmount =@TotalAmount, Balance =@Balance WHERE GPaymentID = '" & GPaymentID & "'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            With ConCommand.Parameters
                .AddWithValue("@TotalAmount", TheTotal)
                .AddWithValue("@Balance", TheTotal - TheAmountPaid)
            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

            CreateLog(CurrentUserID, FullNameofUser, "Update TotalAmount of GeneralSales to " & GPaymentID, 0)
        Catch Ex As Exception
            If Ex.Message.ToUpper.Contains("FOREIGN") Then
                MessageBox.Show("Record Constraint Violation. Please make sure that  have values. If any does not have an applicable value then please select 'N/A' from the drop down list." & Ex.Message, "Incomplete entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Private Sub cmdOpenRecordGeneralSalesItems_Click(sender As Object, e As EventArgs) Handles cmdOpenRecordGeneralSalesItems.Click

        Try
            Dim GeneralSalesItemsID As String = GridViewGeneralSalesItems.GetFocusedRowCellDisplayText(GridViewGeneralSalesItems.Columns("ItemID"))
            Dim GeneralSalesItemsForm As New frmGeneralSalesItems
            GeneralSalesItemsForm.FormBorderStyle = FormBorderStyle.Sizable
            GeneralSalesItemsForm.StartPosition = FormStartPosition.CenterParent
            GeneralSalesItemsForm.PrepareForm()

            GeneralSalesItemsForm.OpenNEWToolStripButton_Click()
            GeneralSalesItemsForm.DisplayRecordInfo(GeneralSalesItemsID)
            GeneralSalesItemsForm.Show(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub cmdSearchGeneralSalesItems_Click(sender As Object, e As EventArgs) Handles cmdSearchGeneralSalesItems.Click
        Me.GridViewGeneralSalesItems.OptionsFind.AlwaysVisible = Not Me.GridViewGeneralSalesItems.OptionsFind.AlwaysVisible

    End Sub

#End Region

    Private Function ValidateAllForeignKeys() As Boolean

        'If Not ValidateUniversalID("GeneralSalesItems", "ItemID", ItemIDGridBox.EditValue) Then
        '    MessageBox.Show("Please provide an acceptable value for '"Item ID & "' from its drop-down list before saving the record.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Return False
        'End If


        Return True
    End Function

    'Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
    '       Try
    '	Dim MyCompanyTable As New DataTable
    '       MyCompanyTable = GetCompanyData()

    '       Dim MyDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument '= New CrystalReportGeneralSales
    '       MyDocument.SummaryInfo.ReportTitle = "General Sales"
    '	      Dim MyTable As New DataTable
    '       Dim TableName As String = "GeneralSales"
    '       Dim Fields As String = "GPaymentID"
    '       Dim Values As String = GPaymentIDTextBox.Text
    '       MyTable = UniversalGetDatafromTable(TableName, Fields, Values)
    '	    Dim MyQRCodeTable As DataTable = New QRandBarcodeDataSet.QRandLinearCodeDataTable
    '           Dim QrCodeData As String = "GeneralSales Report - Printed on: " & DateTime.Today
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



    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        'Me.PanelSearch.Visible = True
        'Me.PanelSearch.BringToFront()
        Try
            Dim MySearch As New frmQuickSearch
            MySearch.FormName = "frmGeneralSales"
            MySearch.TableName = "GeneralSales"
            MySearch.PrimaryKey = "GPaymentID"

            If MySearch.ShowDialog() = DialogResult.OK Then
                MyReportTable = MySearch.SearchTable
                GeneralSalesDataGridView.DataSource = MyReportTable
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub AdvancedSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedSummaryToolStripMenuItem.Click
        Try
            Dim myReport As New frmReport
            myReport.WindowState = FormWindowState.Maximized

            myReport.LoadTables()
            myReport.Show(Me)
            myReport.cboTableName.SelectedIndex = myReport.FindItemIndex("GeneralSales")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub ImportWizardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportWizardToolStripMenuItem.Click
        Try
            Dim MyImportForm As New frmImports
            MyImportForm.LoadTables()
            MyImportForm.cboTableName.SelectedIndex = MyImportForm.FindItemIndex("GeneralSales")
            MyImportForm.cboTableName.Enabled = False

            MyImportForm.WindowState = FormWindowState.Maximized

            MyImportForm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("GPaymentID"))
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
            Dim QueryItems As String = "GPaymentID,OutgoneSales,TransactionPosted,PaidBy,PaymentDate,TotalAmount,AmountPaid,Balance,Comment,RegDate,InputedBy"
            Dim TableName As String = "GeneralSales"
            Dim Condition As String

            If SearchToolStripComboBox.Text = "" Then
                Condition = ""
            Else
                Condition = "GPaymentID = '" & SearchToolStripComboBox.Text & "'"
            End If

            Dim OrderByCondition As String = "ORDER BY GPaymentID DESC"

            Dim MyTable As DataTable = GetDataForTable(QueryItems, TableName, Condition, OrderByCondition)

            If SearchToolStripComboBox.Text = "" Then
                MyReportTable.Rows.Clear()
                MyReportTable.Columns.Clear()

                MyReportTable = MyTable
                GeneralSalesDataGridView.DataSource = MyReportTable
            Else
                OpenNEWToolStripButton_Click()
                DisplayRecordInfo(MyTable.Rows(0).Item("GPaymentID"))
            End If
            isDateSearchUsed = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


    Private Sub MySearchItemsLoading() Handles Me.Load
        Dim QueryItem As String = "GPaymentID"
        Dim TableName As String = "GeneralSales"
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
        Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("GPaymentID"))
        'DisplayRecordInfo(DRecordID)

        Dim MyTable As DataTable = GetDataForTable(" * ", "GeneralSales", "GPaymentID = '" & DRecordID & "'", " ORDER BY GPaymentID ASC")

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
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub SelectAll_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                GridView1.SelectAll()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        Try
            GridView1.CopyToClipboard()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CopytoClipboard_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                GridView1.CopyToClipboard()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub ExpandAllGroups_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                GridView1.ExpandAllGroups()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub ColumnChooser_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                GridView1.ColumnsCustomization()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub RecordFilter_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                GridView1.ShowFindPanel()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub BestFitallColumns_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                GridView1.BestFitColumns()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub FilterEditor_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                GridView1.ShowFilterEditor(GridView1.FocusedColumn)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub LoadAllRecords_Click()
        If CurrentDisplayedFormName = Me.Name Then
            Try
                Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

                Dim Query As String = " SELECT GPaymentID,OutgoneSales,TransactionPosted,PaidBy,PaymentDate,TotalAmount,AmountPaid,Balance,Comment,RegDate,InputedBy FROM GeneralSales ORDER BY GPaymentID DESC "
                Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

                MyReportTable.Rows.Clear()
                ConTableAdapter.Fill(MyReportTable)

                GeneralSalesDataGridView.DataSource = MyReportTable

                If MyReportTable.Rows.Count > 0 Then
                    DisplayRecordInfo(MyReportTable.Rows(0).Item("GPaymentID"))
                End If

            Catch Ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub frmGeneralSales_GotFocus(sender As Object, e As EventArgs) Handles Me.Activated
        CurrentDisplayedFormName = Me.Name
    End Sub

#End Region
    Private Sub cmdPrevious_Click(sender As Object, e As EventArgs) Handles cmdPrevious.Click
        GridView1.MovePrev()
        Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("GPaymentID"))
        DisplayRecordInfo(DRecordID)
    End Sub
    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        GridView1.MoveNext()
        Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("GPaymentID"))
        DisplayRecordInfo(DRecordID)
    End Sub

    Private Function GetGeneralSalesItemsView(ByVal GPaymentID As String) As DataTable
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT ItemID, StockID, GPaymentID, Quantity, UnitCost, TotalCost, UnitOfMeasurement, SalesCategory, RegDate, NameOfItem, ItemCategory FROM View_GeneralSales WHERE GPaymentID = '" & GPaymentID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MyTable As New DataTable
            ConTableAdapter.Fill(MyTable)

            Return MyTable

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Try

            If PanelNew.Visible = False Then
                Dim RecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("GPaymentID"))
                DisplayRecordInfo(RecordID)
            End If

            If MySingleReportTable.Rows.Count = 0 Then
                MessageBox.Show("No data was loaded. Please select a record before proceeding with the printing process.", "Empty Set", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            DisplayRecordInfo(GPaymentIDTextBox.Text)

            Dim MyCompanyTable As New DataTable
            MyCompanyTable = GetCompanyData()

            Dim MyDocument As New XtraReportGeneralSalesSingle
            MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
            MyDocument.GeneralSalesDataSource.DataSource = MySingleReportTable

            Dim GeneralSalesItemsTable = GetGeneralSalesItemsView(GPaymentIDTextBox.Text)

            MyDocument.GeneralSalesItemsDataSource.DataSource = GeneralSalesItemsTable

            MyDocument.XrLabelReportTitle.Text = "General Sales Receipt"

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
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

            Dim MyDocument As New XtraReportGeneralSalesMultiple
            MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
            MyDocument.GeneralSalesDataSource.DataSource = MyReportTable

            MyDocument.XrLabelReportTitle.Text = "General Sales Report"

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
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Sub FormLoadingSetup() Handles Me.Load
        Try
            SearchDateFieldComboBox.Properties.Items.Clear()
            SearchDateFieldComboBox.Text = ""

            Dim Allfields As String = GetAllFields("GeneralSales", DatabaseName)
            Dim splitfields As String() = Allfields.Trim.Split(",")

            Dim QueryString As String = ""

            For Each field In splitfields

                Dim ColumnType As String = GetColumnDataType("GeneralSales", field).ToUpper

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
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

                Dim Query As String = " SELECT GPaymentID,OutgoneSales,TransactionPosted,PaidBy,PaymentDate,TotalAmount,AmountPaid,Balance,Comment,RegDate,InputedBy FROM GeneralSales WHERE " & SearchDateFieldComboBox.Text & " BETWEEN '" & StartDateTimePicker.DateTime.ToString("yyy-MM-dd") & "' AND '" & EndDateTimePicker.DateTime.ToString("yyyy-MM-dd") & "' ORDER BY GPaymentID DESC "
                Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

                Dim MyTable As New DataTable
                ConTableAdapter.Fill(MyTable)

                If MyTable.Rows.Count > 0 Then
                    MyReportTable.Rows.Clear()
                    MyReportTable = MyTable.Copy()

                    GeneralSalesDataGridView.DataSource = MyReportTable
                    Me.PanelNew.Visible = False

                    isDateSearchUsed = True
                    MessageBox.Show("Search Complete. " & MyTable.Rows.Count & " record(s) found.", "Search Complete", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    'If MyReportTable.Rows.Count > 0 Then
                    'DisplayRecordInfo(MyReportTable.Rows(0).Item("GPaymentID"))
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

    Private Sub cmdPrintReceipt_Click(sender As Object, e As EventArgs) Handles cmdPrintReceipt.Click
        PrintToolStripMenuItem.PerformClick()
    End Sub

    Private Sub AmountPaidTextBox_EditValueChanged(sender As Object, e As EventArgs) Handles AmountPaidTextBox.EditValueChanged

    End Sub

    Private Sub AmountPaidTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles AmountPaidTextBox.KeyUp
        If IsNumeric(TotalAmountTextBox.Text) And IsNumeric(AmountPaidTextBox.Text) Then
            BalanceTextBox.Text = CDbl(TotalAmountTextBox.Text) - CDbl(AmountPaidTextBox.Text)
        Else
            BalanceTextBox.Text = 0
        End If
    End Sub

#End Region


#Region "UPDATING THE STOCK IN THE INVENTORY"
    Private Sub cmdPostCheckButton_CheckedChanged(sender As Object, e As EventArgs) Handles cmdPostCheckButton.CheckedChanged

    End Sub

    Private Function GETGeneralSalesItemsRecords(ByVal RecordID As String) As DataTable
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT ItemID, GPaymentID, StockID, SalesCategory, Quantity, UnitCost, TotalCost, UnitOfMeasurement, SalesCategory, Comment, RegDate, InputtedBy FROM GeneralSalesItems WHERE GPaymentID = '" & RecordID & "' ORDER BY RowNumber DESC "
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            Return MYTABLE

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New DataTable
        End Try

    End Function

    Private Sub UPDATESTOCKQuantity(ByVal StockID As String, ByVal SalesCategory As String, ByVal TheAmount As Double)
        Try

            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String
            Dim theSign As String

            If TheAmount > 0 Then
                theSign = "+"
            Else
                theSign = "-"
            End If

            If SalesCategory.Contains("RETAIL") Then
                Query = "UPDATE Inventory SET RetailQuantity = RetailQuantity " & theSign & " " & Math.Abs(TheAmount) & " WHERE StockID = '" & StockID & "'"
            Else
                Query = "UPDATE Inventory SET WholesaleQuantity = WholesaleQuantity " & theSign & " " & Math.Abs(TheAmount) & " WHERE StockID = '" & StockID & "'"
            End If

            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

            If SalesCategory.Contains("RETAIL") Then
                CreateLog(CurrentUserID, FullNameofUser, "Updated RetailQuantity of Inventory by " & TheAmount, 0)
            Else
                CreateLog(CurrentUserID, FullNameofUser, "Updated WholesaleQuantity of Inventory by " & TheAmount, 0)
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UPDATETransferTransactionPostedStatus(ByVal GPaymentID As String, ByVal TransactionPosted As Boolean)
        Try

            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "UPDATE GeneralSales SET TransactionPosted = @TransactionPosted WHERE GPaymentID = '" & GPaymentID & "'"

            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            ConCommand.Parameters.AddWithValue("@TransactionPosted", TransactionPosted)

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdPostCheckButton_Click(sender As Object, e As EventArgs) Handles cmdPostCheckButton.Click
        If Not cmdPostCheckButton.Checked Then
            If MessageBox.Show("Do you really wish to POST this TRANSACTION. This will REDUCE the Quantity of the Stock in the Inventory appropriately.", "Posting Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim TheItems As DataTable = GETGeneralSalesItemsRecords(GPaymentIDTextBox.Text)

                For Each item In TheItems.Rows
                    UPDATESTOCKQuantity(item("StockID"), item("SalesCategory"), CDbl(item("Quantity")) * -1)
                Next

                cmdPrintReceipt.Enabled = True
                UPDATETransferTransactionPostedStatus(GPaymentIDTextBox.Text, True)
            Else
                cmdPostCheckButton.Checked = True
            End If
        Else
            If MessageBox.Show("Do you really wish to unPOST this TRANSACTION. This will INCREASE the Quantity of the Stock in the Inventory appropriately.", "unPosting Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim TheItems As DataTable = GETGeneralSalesItemsRecords(GPaymentIDTextBox.Text)

                For Each item In TheItems.Rows
                    UPDATESTOCKQuantity(item("StockID"), item("SalesCategory"), CDbl(item("Quantity")))
                Next

                cmdPrintReceipt.Enabled = False
                UPDATETransferTransactionPostedStatus(GPaymentIDTextBox.Text, False)
            Else
                cmdPostCheckButton.Checked = True
            End If
        End If
    End Sub

#End Region




End Class