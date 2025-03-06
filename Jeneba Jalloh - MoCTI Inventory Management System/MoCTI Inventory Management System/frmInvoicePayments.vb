
Imports Excel = Microsoft.Office.Interop.Excel

Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Public Class frmTransferPayments
    Dim CurrentRowIndex As Integer
    Dim WasCellEdited As Boolean
    Dim PrimaryKeyValuetoDelete As String
    Dim isDateSearchUsed As Boolean

    Dim ExportFileName As String
    Dim ExportCount As Integer
    Dim ExpectedNoValues As Integer
    Dim NoofColumns As Integer
    Public isCalled As Boolean
    Dim LoadedIPaymentID As String
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
        LoadGeneratedTransferNo()
    End Sub

    Private Sub MyLoading_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        LoadRecords()
        If AccessibleFeatures.Contains("Import Wizard") Then
            ImportWizardToolStripMenuItem.Enabled = True
        Else
            ImportWizardToolStripMenuItem.Enabled = False
        End If
        If Not isCalled Then
            LoadGeneratedTransferNo()
        End If

    End Sub

    Private Sub LoadRecords()
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT  IPaymentID,GeneratedTransferNo,PaidBy,PaymentDate,CurrentAmount,Discount,AmountPaid,Balance,PaymentMode,RefChequeNo,Bank,Comment,RegDate,InputedBy FROM TransferPayments ORDER BY IPaymentID DESC "
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            MyReportTable.Rows.Clear()
            ConTableAdapter.Fill(MyReportTable)

            TransferPaymentsDataGridView.DataSource = MyReportTable
            isDateSearchUsed = False
            'If MyReportTable.Rows.Count > 0 Then
            'DisplayRecordInfo(MyReportTable.Rows(0).Item("IPaymentID"))
            'End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateID(ByVal IPaymentID As String) As Boolean
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT Count(*) FROM TransferPayments WHERE IPaymentID = '" & IPaymentID & "'"
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

            Dim Query As String = "SELECT Count(*) FROM TransferPayments WHERE IPaymentID LIKE 'I" & DateTime.Today.ToString("yyMM") & "%'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Conn.Open()
            Dim Recordcount As Integer = ConCommand.ExecuteScalar
            Conn.Close()
            Dim IsIDGenerated As Boolean = False
            Dim Start As String = Nothing

            While IsIDGenerated = False
                Recordcount += 1
                If Recordcount >= 0 And Recordcount < 10 Then
                    Start = "I" & CurrentUserID & DateTime.Today.ToString("yyMMdd") & "000" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                ElseIf Recordcount >= 10 And Recordcount < 100 Then
                    Start = "I" & CurrentUserID & DateTime.Today.ToString("yyMMdd") & "00" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                ElseIf Recordcount >= 100 And Recordcount < 1000 Then
                    Start = "I" & CurrentUserID & DateTime.Today.ToString("yyMMdd") & "0" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                ElseIf Recordcount >= 1000 And Recordcount < 10000 Then
                    Start = "I" & CurrentUserID & DateTime.Today.ToString("yyMMdd") & "" & Recordcount
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
            LoadedIPaymentID = ""
            GeneratedTransferNoGridBox.EditValue = ""
        End If
        IPaymentIDTextBox.Text = ""
        PaidByTextBox.Text = ""
        PaymentDateDateTimePicker.DateTime = DateTime.Now
        CurrentAmountTextBox.Text = ""
        AmountPaidTextBox.Text = ""
        DiscountTextBox.Text = ""
        BalanceTextBox.Text = ""
        PaymentModeTextBox.Text = ""
        RefChequeNoTextBox.Text = ""
        BankTextBox.Text = ""
        CommentTextBox.Text = ""
        RegDateTextBox.Text = ""

        RegDateTextBox.Text = Date.Today
        RegDateTextBox.ReadOnly = True

        InputedByTextBox.Text = ""

        InputedByTextBox.Text = CurrentUserID
        InputedByTextBox.ReadOnly = True

        cmdPrintReceipt.Enabled = False

        IPaymentIDTextBox.Text = GenerateID()

    End Sub

    Private Sub cmdSave_Click() 'Handles cmdSave.Click
        Try
            If IPaymentIDTextBox.Text <> "" Then
                If ValidateID(IPaymentIDTextBox.Text) Then
                    MessageBox.Show("This IPayment ID already exist in this table. DUPLICATE 'IPAYMENT ID' ARE NOT ALLOWED. Please verify and try again.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Exit Sub
                End If
            End If
            If Not ValidateAllForeignKeys() Then

                Exit Sub
            End If
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "INSERT INTO TransferPayments (IPaymentID,GeneratedTransferNo,PaidBy,PaymentDate,CurrentAmount,Discount,AmountPaid,Balance,PaymentMode,RefChequeNo,Bank,Comment,RegDate,InputedBy) VALUES(@IPaymentID,@GeneratedTransferNo,@PaidBy,@PaymentDate,@CurrentAmount,@Discount,@AmountPaid,@Balance,@PaymentMode,@RefChequeNo,@Bank,@Comment,@RegDate,@InputedBy)"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)
            With ConCommand.Parameters
                .AddWithValue("@IPaymentID", IPaymentIDTextBox.Text)
                .AddWithValue("@GeneratedTransferNo", GeneratedTransferNoGridBox.EditValue)
                .AddWithValue("@PaidBy", PaidByTextBox.Text)
                .AddWithValue("@PaymentDate", PaymentDateDateTimePicker.DateTime.Date)
                .AddWithValue("@CurrentAmount", CurrentAmountTextBox.Text)
                .AddWithValue("@AmountPaid", AmountPaidTextBox.Text)
                .AddWithValue("@Discount", DiscountTextBox.Text)
                .AddWithValue("@Balance", BalanceTextBox.Text)
                .AddWithValue("@PaymentMode", PaymentModeTextBox.Text)
                .AddWithValue("@RefChequeNo", RefChequeNoTextBox.Text)
                .AddWithValue("@Bank", BankTextBox.Text)
                .AddWithValue("@Comment", CommentTextBox.Text)
                .AddWithValue("@RegDate", Date.Today)
                .AddWithValue("@InputedBy", InputedByTextBox.Text)
            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

            lblInformation.Text = "Successfully Inserted a new record"
            CreateLog(CurrentUserID, FullNameofUser, "Insert of new record in table (" & "TransferPayments" & " With ID (" & IPaymentIDTextBox.Text & ")", 0)
            LoadRecords()
            'cmdAdd_Click()
            DisplayRecordInfo(IPaymentIDTextBox.Text)

        Catch Ex As Exception
            If Ex.Message.ToUpper.Contains("FOREIGN") Then
                MessageBox.Show("Record Constraint Violation. Please make sure that GeneratedTransferNo:Transfers:GeneratedTransferNo have values. If any does not have an applicable value then please select 'N/A' from the drop down list." & Ex.Message, "Incomplete entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End Try
    End Sub

    Private Sub cmdUpdate_Click() 'Handles cmdUpdate.Click
        Try
            If Not ValidateID(LoadedIPaymentID) Then
                MessageBox.Show("The loaded IPayment ID (" & LoadedIPaymentID & ") was not found in the database table. UPDATE OPERATION WILL NOT BE SUCCESSFULL. Please verify and try again.", "Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub
            End If
            If Not ValidateAllForeignKeys() Then

                Exit Sub
            End If
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "UPDATE TransferPayments SET GeneratedTransferNo =@GeneratedTransferNo, PaidBy =@PaidBy, PaymentDate =@PaymentDate, CurrentAmount =@CurrentAmount, Discount = @Discount, AmountPaid =@AmountPaid, Balance =@Balance, PaymentMode =@PaymentMode, RefChequeNo =@RefChequeNo, Bank =@Bank, Comment =@Comment, RegDate =@RegDate, InputedBy =@InputedBy WHERE IPaymentID = '" & LoadedIPaymentID & "'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)
            With ConCommand.Parameters
                .AddWithValue("@IPaymentID", IPaymentIDTextBox.Text)
                .AddWithValue("@GeneratedTransferNo", GeneratedTransferNoGridBox.EditValue)
                .AddWithValue("@PaidBy", PaidByTextBox.Text)
                .AddWithValue("@PaymentDate", PaymentDateDateTimePicker.DateTime.Date)
                .AddWithValue("@CurrentAmount", CurrentAmountTextBox.Text)
                .AddWithValue("@AmountPaid", AmountPaidTextBox.Text)
                .AddWithValue("@Discount", DiscountTextBox.Text)
                .AddWithValue("@Balance", BalanceTextBox.Text)
                .AddWithValue("@PaymentMode", PaymentModeTextBox.Text)
                .AddWithValue("@RefChequeNo", RefChequeNoTextBox.Text)
                .AddWithValue("@Bank", BankTextBox.Text)
                .AddWithValue("@Comment", CommentTextBox.Text)
                .AddWithValue("@RegDate", Date.Today)
                .AddWithValue("@InputedBy", InputedByTextBox.Text)
            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()
            lblInformation.Text = "Successfully Updated a record"
            CreateLog(CurrentUserID, FullNameofUser, "Update of record in table (" & "TransferPayments" & " With ID (" & IPaymentIDTextBox.Text & ")", 0)
        Catch Ex As Exception
            If Ex.Message.ToUpper.Contains("FOREIGN") Then
                MessageBox.Show("Record Constraint Violation. Please make sure that GeneratedTransferNo:Transfers:GeneratedTransferNo have values. If any does not have an applicable value then please select 'N/A' from the drop down list." & Ex.Message, "Incomplete entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                    ThePKey = IPaymentIDTextBox.Text
                Else
                    ThePKey = GridView1.GetFocusedDataRow.Item("IPaymentID")
                End If

                Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
                Dim Query As String = "DELETE FROM TransferPayments WHERE IPaymentID = '" & ThePKey & "'"
                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                Conn.Open()
                ConCommand.ExecuteNonQuery()
                Conn.Close()
                lblInformation.Text = "Record Deleted"
                CreateLog(CurrentUserID, FullNameofUser, "Delete of record in table (" & "TransferPayments" & " With ID (" & ThePKey & ")", 0)
                LoadRecords()
                Dim TheNewPKey As String = ""
                If MyReportTable.Rows.Count > 0 Then
                    TheNewPKey = GridView1.GetFocusedDataRow.Item("IPaymentID")
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


    'Private Sub IPaymentIDTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles IPaymentIDTextBox.TextChanged
    'DisplayRecordInfo(IPaymentIDTextBox.Text)
    'End Sub

    Private Sub LoadGeneratedTransferNo()

        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "Select  GeneratedTransferNo,TransferType,TransferDate,OfficeType,TransferNo,OutgoneTransfer From Transfers ORDER BY RowNumber DESC"

            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTableTransfers As New DataTable

            ConTableAdap.Fill(MyTableTransfers)

            GeneratedTransferNoGridBox.Properties.DataSource = Nothing
            GeneratedTransferNoGridBox.Properties.DataSource = MyTableTransfers

            GeneratedTransferNoGridBox.Properties.DisplayMember = "GeneratedTransferNo"
            GeneratedTransferNoGridBox.Properties.ValueMember = "GeneratedTransferNo"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub DisplayRecordInfo(ByVal RecordID As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT IPaymentID,GeneratedTransferNo,PaidBy,PaymentDate,CurrentAmount,Discount,AmountPaid,Balance,PaymentMode,RefChequeNo,Bank,Comment,RegDate,InputedBy FROM TransferPayments WHERE IPaymentID = '" & RecordID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)
            MySingleReportTable.Rows.Clear()
            ConTableAdapter.Fill(MySingleReportTable)

            If MySingleReportTable.Rows.Count > 0 Then
                lblInformation.Text = "Displaying details Of a record"
                IPaymentIDTextBox.Text = MySingleReportTable.Rows(0).Item("IPaymentID").ToString
                GeneratedTransferNoGridBox.EditValue = MySingleReportTable.Rows(0).Item("GeneratedTransferNo").ToString
                PaidByTextBox.Text = MySingleReportTable.Rows(0).Item("PaidBy").ToString
                PaymentDateDateTimePicker.DateTime = MySingleReportTable.Rows(0).Item("PaymentDate")
                CurrentAmountTextBox.Text = MySingleReportTable.Rows(0).Item("CurrentAmount").ToString
                AmountPaidTextBox.Text = MySingleReportTable.Rows(0).Item("AmountPaid").ToString
                DiscountTextBox.Text = MySingleReportTable.Rows(0).Item("Discount").ToString
                BalanceTextBox.Text = MySingleReportTable.Rows(0).Item("Balance").ToString
                PaymentModeTextBox.Text = MySingleReportTable.Rows(0).Item("PaymentMode").ToString
                RefChequeNoTextBox.Text = MySingleReportTable.Rows(0).Item("RefChequeNo").ToString
                BankTextBox.Text = MySingleReportTable.Rows(0).Item("Bank").ToString
                CommentTextBox.Text = MySingleReportTable.Rows(0).Item("Comment").ToString
                RegDateTextBox.Text = MySingleReportTable.Rows(0).Item("RegDate").ToString

                RegDateTextBox.ReadOnly = True

                InputedByTextBox.Text = MySingleReportTable.Rows(0).Item("InputedBy").ToString

                InputedByTextBox.ReadOnly = True

                XtraTabControlRelated.Visible = True
                LoadTransferPaymentDocumentsRecords(IPaymentIDTextBox.Text)
                LoadedIPaymentID = IPaymentIDTextBox.Text

                lblInformation.Text = "Displaying details Of a record"
                cmdPrintReceipt.Enabled = True
            Else
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "TransferPaymentDocuments"

    Private Sub LoadTransferPaymentDocumentsRecords(ByVal RecordID As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT ID,IPaymentID,FileType,FileName,GeneratedFileName,DocumentType,FileStatus,Description,RegDate,InputtedBy FROM TransferPaymentDocuments WHERE IPaymentID = '" & RecordID & "' ORDER BY ID DESC "
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            TransferPaymentDocumentsGridView.DataSource = MYTABLE

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdAddTransferPaymentDocuments_Click(sender As Object, e As EventArgs) Handles cmdAddTransferPaymentDocuments.Click
        Try
            Dim MyForm As New frmTransferPaymentDocuments
            MyForm.isCalled = True
            MyForm.PrepareForm()
            MyForm.NewToolStripButton.PerformClick()
            MyForm.IPaymentIDGridBox.EditValue = Me.IPaymentIDTextBox.Text

            MyForm.WindowState = FormWindowState.Normal
            MyForm.FormBorderStyle = FormBorderStyle.Sizable
            MyForm.ShowDialog()

            LoadTransferPaymentDocumentsRecords(IPaymentIDTextBox.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdRemoveTransferPaymentDocuments_Click(sender As Object, e As EventArgs) Handles cmdRemoveTransferPaymentDocuments.Click

        If RecordAccessLevel.Contains("Delete") Then
            If MessageBox.Show("Do you really want to delete the current record?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                Try
                    '**************************
                    '**************************
                    Dim RecordID As String = GridViewTransferPaymentDocuments.GetFocusedRowCellDisplayText(GridViewTransferPaymentDocuments.Columns("ID"))

                    Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
                    Dim Query As String = "DELETE FROM TransferPaymentDocuments WHERE ID = '" & RecordID & "'"
                    Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                    Conn.Open()
                    ConCommand.ExecuteNonQuery()
                    Conn.Close()

                    CreateLog(CurrentUserID, FullNameofUser, "Delete of TransferPaymentDocuments for " + IPaymentIDTextBox.Text, 0)
                    LoadTransferPaymentDocumentsRecords(IPaymentIDTextBox.Text)

                Catch Ex As Exception
                    MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Sorry you are not allowed to use this function. Please consult your administrator for assistance.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cmdOpenRecordTransferPaymentDocuments_Click(sender As Object, e As EventArgs) Handles cmdOpenRecordTransferPaymentDocuments.Click

        Try
            Dim TransferPaymentDocumentsID As String = GridViewTransferPaymentDocuments.GetFocusedRowCellDisplayText(GridViewTransferPaymentDocuments.Columns("ID"))
            Dim TransferPaymentDocumentsForm As New frmTransferPaymentDocuments
            TransferPaymentDocumentsForm.FormBorderStyle = FormBorderStyle.Sizable
            TransferPaymentDocumentsForm.StartPosition = FormStartPosition.CenterParent
            TransferPaymentDocumentsForm.PrepareForm()

            TransferPaymentDocumentsForm.OpenNEWToolStripButton_Click()
            TransferPaymentDocumentsForm.DisplayRecordInfo(TransferPaymentDocumentsID)
            TransferPaymentDocumentsForm.Show(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub cmdSearchTransferPaymentDocuments_Click(sender As Object, e As EventArgs) Handles cmdSearchTransferPaymentDocuments.Click
        Me.GridViewTransferPaymentDocuments.OptionsFind.AlwaysVisible = Not Me.GridViewTransferPaymentDocuments.OptionsFind.AlwaysVisible

    End Sub

#End Region

    Private Function ValidateAllForeignKeys() As Boolean

        'If Not ValidateUniversalID("TransferPaymentDocuments", "ID", IDGridBox.EditValue) Then
        '    MessageBox.Show("Please provide an acceptable value for '"ID & "' from its drop-down list before saving the record.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Return False
        'End If


        Return True
    End Function

    'Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
    '       Try
    '	Dim MyCompanyTable As New DataTable
    '       MyCompanyTable = GetCompanyData()

    '       Dim MyDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument '= New CrystalReportTransferPayments
    '       MyDocument.SummaryInfo.ReportTitle = "Transfer Payments"
    '	      Dim MyTable As New DataTable
    '       Dim TableName As String = "TransferPayments"
    '       Dim Fields As String = "IPaymentID"
    '       Dim Values As String = IPaymentIDTextBox.Text
    '       MyTable = UniversalGetDatafromTable(TableName, Fields, Values)
    '	    Dim MyQRCodeTable As DataTable = New QRandBarcodeDataSet.QRandLinearCodeDataTable
    '           Dim QrCodeData As String = "TransferPayments Report - Printed on: " & DateTime.Today
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
            MySearch.FormName = "frmTransferPayments"
            MySearch.TableName = "TransferPayments"
            MySearch.PrimaryKey = "IPaymentID"

            If MySearch.ShowDialog() = DialogResult.OK Then
                MyReportTable = MySearch.SearchTable
                TransferPaymentsDataGridView.DataSource = MyReportTable
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
            myReport.cboTableName.SelectedIndex = myReport.FindItemIndex("TransferPayments")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub ImportWizardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportWizardToolStripMenuItem.Click
        Try
            Dim MyImportForm As New frmImports
            MyImportForm.LoadTables()
            MyImportForm.cboTableName.SelectedIndex = MyImportForm.FindItemIndex("TransferPayments")
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
            Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("IPaymentID"))
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
            Dim QueryItems As String = "IPaymentID,GeneratedTransferNo,PaidBy,PaymentDate,CurrentAmount,Discount,AmountPaid,Balance,PaymentMode,RefChequeNo,Bank,Comment,RegDate,InputedBy"
            Dim TableName As String = "TransferPayments"
            Dim Condition As String

            If SearchToolStripComboBox.Text = "" Then
                Condition = ""
            Else
                Condition = "IPaymentID = '" & SearchToolStripComboBox.Text & "'"
            End If

            Dim OrderByCondition As String = "ORDER BY IPaymentID DESC"

            Dim MyTable As DataTable = GetDataForTable(QueryItems, TableName, Condition, OrderByCondition)

            If SearchToolStripComboBox.Text = "" Then
                MyReportTable.Rows.Clear()
                MyReportTable.Columns.Clear()

                MyReportTable = MyTable
                TransferPaymentsDataGridView.DataSource = MyReportTable
            Else
                OpenNEWToolStripButton_Click()
                DisplayRecordInfo(MyTable.Rows(0).Item("IPaymentID"))
            End If
            isDateSearchUsed = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


    Private Sub MySearchItemsLoading() Handles Me.Load
        Dim QueryItem As String = "IPaymentID"
        Dim TableName As String = "TransferPayments"
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
        Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("IPaymentID"))
        'DisplayRecordInfo(DRecordID)

        Dim MyTable As DataTable = GetDataForTable(" * ", "TransferPayments", "IPaymentID = '" & DRecordID & "'", " ORDER BY IPaymentID ASC")

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

                Dim Query As String = " SELECT IPaymentID,GeneratedTransferNo,PaidBy,PaymentDate,CurrentAmount,Discount,AmountPaid,Balance,PaymentMode,RefChequeNo,Bank,Comment,RegDate,InputedBy FROM TransferPayments ORDER BY IPaymentID DESC "
                Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

                MyReportTable.Rows.Clear()
                ConTableAdapter.Fill(MyReportTable)

                TransferPaymentsDataGridView.DataSource = MyReportTable

                If MyReportTable.Rows.Count > 0 Then
                    DisplayRecordInfo(MyReportTable.Rows(0).Item("IPaymentID"))
                End If

            Catch Ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub frmTransferPayments_GotFocus(sender As Object, e As EventArgs) Handles Me.Activated
        CurrentDisplayedFormName = Me.Name
    End Sub

#End Region
    Private Sub cmdPrevious_Click(sender As Object, e As EventArgs) Handles cmdPrevious.Click
        GridView1.MovePrev()
        Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("IPaymentID"))
        DisplayRecordInfo(DRecordID)
    End Sub
    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        GridView1.MoveNext()
        Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("IPaymentID"))
        DisplayRecordInfo(DRecordID)
    End Sub



    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Try

            If PanelNew.Visible = False Then
                Dim RecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("IPaymentID"))
                DisplayRecordInfo(RecordID)
            End If

            If MySingleReportTable.Rows.Count = 0 Then
                MessageBox.Show("No data was loaded. Please select a record before proceeding with the printing process.", "Empty Set", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim MyCompanyTable As New DataTable
            MyCompanyTable = GetCompanyData()

            Dim MyDocument As New XtraReportTransferPaymentsSingle
            MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
            MyDocument.TransferPaymentsDataSource.DataSource = MySingleReportTable
            MyDocument.XrLabelReportTitle.Text = "Transfer Payments"

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

            Dim MyDocument As New XtraReportTransferPaymentsMultiple
            MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
            MyDocument.TransferPaymentsDataSource.DataSource = MyReportTable
            MyDocument.XrLabelReportTitle.Text = "TransferPayments"

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

            Dim Allfields As String = GetAllFields("TransferPayments", DatabaseName)
            Dim splitfields As String() = Allfields.Trim.Split(",")

            Dim QueryString As String = ""

            For Each field In splitfields

                Dim ColumnType As String = GetColumnDataType("TransferPayments", field).ToUpper

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

                Dim Query As String = " SELECT IPaymentID,GeneratedTransferNo,PaidBy,PaymentDate,CurrentAmount,Discount,AmountPaid,Balance,PaymentMode,RefChequeNo,Bank,Comment,RegDate,InputedBy FROM TransferPayments WHERE " & SearchDateFieldComboBox.Text & " BETWEEN '" & StartDateTimePicker.DateTime.ToString("yyy-MM-dd") & "' AND '" & EndDateTimePicker.DateTime.ToString("yyyy-MM-dd") & "' ORDER BY IPaymentID DESC "
                Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

                Dim MyTable As New DataTable
                ConTableAdapter.Fill(MyTable)

                If MyTable.Rows.Count > 0 Then
                    MyReportTable.Rows.Clear()
                    MyReportTable = MyTable.Copy()

                    TransferPaymentsDataGridView.DataSource = MyReportTable
                    Me.PanelNew.Visible = False

                    isDateSearchUsed = True
                    MessageBox.Show("Search Complete. " & MyTable.Rows.Count & " record(s) found.", "Search Complete", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    'If MyReportTable.Rows.Count > 0 Then
                    'DisplayRecordInfo(MyReportTable.Rows(0).Item("IPaymentID"))
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

#Region "Transfer PAYMENT DOCUMENTS FILES ACCESS SECTION"


    Private Sub cmdOpenTransferPaymentDocuments_Click(sender As Object, e As EventArgs) Handles cmdOpenTransferPaymentDocuments.Click
        Dim RecordID As String = GridViewTransferPaymentDocuments.GetFocusedRowCellDisplayText(GridViewTransferPaymentDocuments.Columns("ID"))
        Dim InfoTable As DataTable = GetFileInformation(RecordID, "TransferPaymentDocuments")

        Dim ItemDescription As String = InfoTable.Rows(0).Item("Description")
        'Dim TheSplit As String() = ItemDescription.Trim.Split(":")
        Dim TheFileName As String = InfoTable.Rows(0).Item("FileName")
        Dim TheRegDate As String = InfoTable.Rows(0).Item("RegDate")
        Dim TheGeneratedfileName As String = InfoTable.Rows(0).Item("GeneratedFileName")

        If TheFileName.ToUpper.Contains(".JPG") Or TheFileName.ToUpper.Contains(".PNG") Or TheFileName.ToUpper.Contains(".BMP") Or TheFileName.ToUpper.Contains(".JPEG") Then
            Dim TheBytes As Byte() = GetDocumentData(RecordID, "GeneratedFileName", "TransferPaymentDocuments", "ID")

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
            Dim TheBytes As Byte() = GetDocumentData(RecordID, "GeneratedFileName", "TransferPaymentDocuments", "ID")

            If TheBytes Is Nothing Then
                MessageBox.Show("File Not Found on File Server. Please contact the System Administrator", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub
            End If

            Dim MyForm As New frmWordProcessor
            MyForm.RichEditControl1.OpenXmlBytes() = TheBytes
            MyForm.WindowState = FormWindowState.Maximized
            MyForm.Show(Me)
        ElseIf TheFileName.ToUpper.Contains(".PDF") Then
            Dim TheBytes As Byte() = GetDocumentData(RecordID, "GeneratedFileName", "TransferPaymentDocuments", "ID")

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
            Dim TheBytes As Byte() = GetDocumentData(RecordID, "GeneratedFileName", "TransferPaymentDocuments", "ID")

            If TheBytes Is Nothing Then
                MessageBox.Show("File Not Found on File Server. Please contact the System Administrator", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub
            End If

            Dim MyForm As New frmSpreadsheet
            MyForm.SpreadsheetControl1.LoadDocument(TheBytes, DevExpress.Spreadsheet.DocumentFormat.Xlsx)
            MyForm.WindowState = FormWindowState.Maximized
            MyForm.Show(Me)

        ElseIf TheFileName.ToUpper.Contains(".MP4") Or TheFileName.ToUpper.Contains(".AVI") Or TheFileName.ToUpper.Contains(".MPEG") Or TheFileName.ToUpper.Contains(".3GP") Or TheFileName.ToUpper.Contains(".MKV") Or TheFileName.ToUpper.Contains(".MP3") Or TheFileName.ToUpper.Contains(".WAV") Or TheFileName.ToUpper.Contains(".M4A") Then

            Dim MyForm As New frmVideoPlayer
            MyForm.FileNameTextBox.Text = TheFileName
            MyForm.RegDateTextBox.Text = "Date: " & TheRegDate
            MyForm.PreparePlaylist()

            Dim FullPath As String = "\\" & FILEServerIPAddress & "\" & FILEFolder & "\TransferPaymentDocuments\" & TheGeneratedfileName
            MyForm.PlayList.clear()
            MyForm.AddItemToPlaylist(FullPath)

            'MyForm.AxWindowsMediaPlayer1.newMedia(FullPath)
            MyForm.WindowState = FormWindowState.Maximized
            MyForm.Show(Me)

        Else
            Dim TheBytes As Byte() = GetDocumentData(RecordID, "GeneratedFileName", "TransferPaymentDocuments", "ID")

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

    End Sub


    Private Sub cmdDownloadTransferPaymentDocuments_Click(sender As Object, e As EventArgs) Handles cmdDownloadTransferPaymentDocuments.Click
        Try
            Dim RecordID As String = GridViewTransferPaymentDocuments.GetFocusedRowCellDisplayText(GridViewTransferPaymentDocuments.Columns("ID"))

            Dim TheBytes As Byte() = GetDocumentData(RecordID, "GeneratedFileName", "TransferPaymentDocuments", "ID")
            Dim InfoTable As DataTable = GetFileInformation(RecordID, "TransferPaymentDocuments")

            Dim ItemDescription As String = InfoTable.Rows(0).Item("Description")
            'Dim TheSplit As String() = ItemDescription.Trim.Split(":")
            Dim TheFileName As String = InfoTable.Rows(0).Item("FileName")
            Dim TheRegDate As String = InfoTable.Rows(0).Item("RegDate")
            Dim TheGeneratedfileName As String = InfoTable.Rows(0).Item("GeneratedFileName")


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
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdExploreAllTransferPaymentDocuments_Click(sender As Object, e As EventArgs) Handles cmdExploreAllTransferPaymentDocuments.Click

        Dim MyForm As New frmOpenandViewDocuments
        MyForm.ForeignKeyField = "IPaymentID"
        MyForm.ForeignKeyValue = IPaymentIDTextBox.Text
        MyForm.TableName = "TransferPaymentDocuments"

        MyForm.BarStaticItemTransactionNo.Caption = IPaymentIDTextBox.Text
        MyForm.BarStaticItemTotalAmount.Caption = ""
        MyForm.BarStaticItemNetBalance.Caption = ""

        MyForm.ShowDialog()


    End Sub

    Private Sub cmdPrintReceipt_Click(sender As Object, e As EventArgs) Handles cmdPrintReceipt.Click
        PrintToolStripMenuItem.PerformClick()
    End Sub

    Private Sub GeneratedTransferNoGridBox_EditValueChanged(sender As Object, e As EventArgs) Handles GeneratedTransferNoGridBox.EditValueChanged
        If Not ValidateID(IPaymentIDTextBox.Text) Then
            'Dim TransferDiscount As Double = GetDiscountFromTransfer(GeneratedTransferNoGridBox.EditValue)
            Dim Amountdue As Double = GetTotalTransferAmount(GeneratedTransferNoGridBox.EditValue)
            Dim Paid As Double = GetTotalAmountPaid(GeneratedTransferNoGridBox.EditValue)

            Dim balance As Double = Amountdue - Paid
            CurrentAmountTextBox.Text = balance
        End If
    End Sub

    Private Sub AmountPaidTextBox_EditValueChanged(sender As Object, e As EventArgs) Handles AmountPaidTextBox.EditValueChanged, CurrentAmountTextBox.EditValueChanged, DiscountTextBox.EditValueChanged
        If IsNumeric(AmountPaidTextBox.Text) And IsNumeric(CurrentAmountTextBox.Text) And IsNumeric(DiscountTextBox.Text) Then
            Dim balance As Double = CDbl(CurrentAmountTextBox.Text) - CDbl(AmountPaidTextBox.Text) - CDbl(DiscountTextBox.Text)
            BalanceTextBox.Text = balance
        Else
            BalanceTextBox.Text = ""
        End If
    End Sub

    Private Function GetDiscountFromTransfer(ByVal GenreatedTransferNo As String) As Double
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT Discount as Total FROM Transfers WHERE GeneratedTransferNo = '" & GenreatedTransferNo & "'"
            Dim ConCommand As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim Mytable As New DataTable
            ConCommand.Fill(Mytable)

            If Mytable.Rows.Count > 0 Then

                If Not IsDBNull(Mytable.Rows(0).Item("Total")) Then
                    Return CDbl(Mytable.Rows(0).Item("Total"))
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

    Private Function GetTotalTransferAmount(ByVal GenreatedTransferNo As String) As Double
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT sum(TotalCost) as Total FROM TransferItems WHERE GeneratedTransferNo = '" & GenreatedTransferNo & "'"
            Dim ConCommand As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim Mytable As New DataTable
            ConCommand.Fill(Mytable)

            If Mytable.Rows.Count > 0 Then

                If Not IsDBNull(Mytable.Rows(0).Item("Total")) Then
                    Return CDbl(Mytable.Rows(0).Item("Total"))
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

    Private Function GetTotalAmountPaid(ByVal GenreatedTransferNo As String) As Double
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT sum(AmountPaid) as Total FROM TransferPayments WHERE GeneratedTransferNo = '" & GenreatedTransferNo & "'"
            Dim ConCommand As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim Mytable As New DataTable
            ConCommand.Fill(Mytable)

            If Mytable.Rows.Count > 0 Then

                If Not IsDBNull(Mytable.Rows(0).Item("Total")) Then
                    Return CDbl(Mytable.Rows(0).Item("Total"))
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

#End Region



End Class