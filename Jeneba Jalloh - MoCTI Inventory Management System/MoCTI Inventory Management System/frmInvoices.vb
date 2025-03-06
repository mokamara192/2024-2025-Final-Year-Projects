
Imports Excel = Microsoft.Office.Interop.Excel

Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class frmTransfers
    Dim CurrentRowIndex As Integer
    Dim WasCellEdited As Boolean
    Dim PrimaryKeyValuetoDelete As String
    Dim isDateSearchUsed As Boolean

    Dim ExportFileName As String
    Dim ExportCount As Integer
    Dim ExpectedNoValues As Integer
    Dim NoofColumns As Integer
    Public isCalled As Boolean
    Dim LoadedGeneratedTransferNo As String
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
        LoadBankAccountID()
        LoadCurrency()
    End Sub

    Private Sub MyLoading_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        LoadRecords()
        If AccessibleFeatures.Contains("Import Wizard") Then
            ImportWizardToolStripMenuItem.Enabled = True
        Else
            ImportWizardToolStripMenuItem.Enabled = False
        End If

        If Not isCalled Then
            LoadBankAccountID()
            LoadCurrency()
        End If

        LoadOfficeID()
    End Sub

    Private Sub LoadOfficeID()

        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "Select OfficeID,NameOfOffice From TransferOffices"

            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTableTransferOffices As New DataTable

            ConTableAdap.Fill(MyTableTransferOffices)

            OfficeIDGridBox.Properties.DataSource = Nothing
            OfficeIDGridBox.Properties.DataSource = MyTableTransferOffices

            OfficeIDGridBox.Properties.DisplayMember = "NameOfOffice"
            OfficeIDGridBox.Properties.ValueMember = "OfficeID"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Private Sub LoadRecords()
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT  GeneratedTransferNo,OutgoneTransfer,TransactionPosted,TransferNo,TransferType,TransferDate,OfficeType,TotalAmount,TransferStatus,Comment,Supervision,DocumentCompletion,RegDate,InputtedBy,Currency,ExchangeRate,BankAccountID FROM Transfers ORDER BY GeneratedTransferNo DESC "
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            MyReportTable.Rows.Clear()
            ConTableAdapter.Fill(MyReportTable)

            TransfersDataGridView.DataSource = MyReportTable
            isDateSearchUsed = False
            'If MyReportTable.Rows.Count > 0 Then
            'DisplayRecordInfo(MyReportTable.Rows(0).Item("GeneratedTransferNo"))
            'End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateID(ByVal GeneratedTransferNo As String) As Boolean
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT Count(*) FROM Transfers WHERE GeneratedTransferNo = '" & GeneratedTransferNo & "'"
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

            Dim Query As String = "SELECT Count(*) FROM Transfers WHERE GeneratedTransferNo LIKE 'G" & DateTime.Today.ToString("yyMM") & "%'"
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
            LoadedGeneratedTransferNo = ""
            BankAccountIDGridBox.EditValue = ""
            CurrencyGridBox.EditValue = ""
        End If
        GeneratedTransferNoTextBox.Text = ""
        OutgoneTransferCheckEdit.Checked = False

        TransferNoTextBox.Text = ""
        TransferTypeTextBox.Text = ""
        TransferDateDateTimePicker.DateTime = DateTime.Now
        OfficeTypeTextBox.Text = ""
        TotalAmountTextBox.Text = "0"
        TransferStatusTextBox.Text = ""
        CommentTextBox.Text = ""
        SupervisionTextBox.Text = ""
        DocumentCompletionTextBox.Text = ""
        RegDateTextBox.Text = ""

        RegDateTextBox.Text = Date.Today
        RegDateTextBox.ReadOnly = True

        InputtedByTextBox.Text = CurrentUserID
        ExchangeRateTextBox.Text = ""
        BankAccountIDGridBox.EditValue = ""

        cmdPostCheckButton.Checked = False

        GeneratedTransferNoTextBox.Text = GenerateID()

        cmdMakePayment.Enabled = False
        cmdPrintHardcopyTransfer.Enabled = False
        cmdPrintStatement.Enabled = False

    End Sub

    Private Sub cmdSave_Click() 'Handles cmdSave.Click
        Try
            If GeneratedTransferNoTextBox.Text <> "" Then
                If ValidateID(GeneratedTransferNoTextBox.Text) Then
                    MessageBox.Show("This Generated Transfer No already exist in this table. DUPLICATE 'GENERATED Transfer NO' ARE NOT ALLOWED. Please verify and try again.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Exit Sub
                End If
            End If
            If Not ValidateAllForeignKeys() Then

                Exit Sub
            End If
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "INSERT INTO Transfers (GeneratedTransferNo,OutgoneTransfer,TransferNo,TransferType,TransferDate,OfficeType,TotalAmount,TransferStatus,Comment,Supervision,DocumentCompletion,RegDate,InputtedBy,Currency,ExchangeRate,BankAccountID) VALUES(@GeneratedTransferNo,@OutgoneTransfer,@TransferNo,@TransferType,@TransferDate,@OfficeType,@TotalAmount,@TransferStatus,@Comment,@Supervision,@DocumentCompletion,@RegDate,@InputtedBy,@Currency,@ExchangeRate,@BankAccountID)"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)
            With ConCommand.Parameters
                .AddWithValue("@GeneratedTransferNo", GeneratedTransferNoTextBox.Text)
                .AddWithValue("@OutgoneTransfer", OutgoneTransferCheckEdit.Checked)

                .AddWithValue("@TransferNo", TransferNoTextBox.Text)
                .AddWithValue("@TransferType", TransferTypeTextBox.Text)
                .AddWithValue("@TransferDate", TransferDateDateTimePicker.DateTime.Date)
                .AddWithValue("@OfficeType", OfficeTypeTextBox.Text)
                .AddWithValue("@TotalAmount", TotalAmountTextBox.Text)
                .AddWithValue("@TransferStatus", TransferStatusTextBox.Text)
                .AddWithValue("@Comment", CommentTextBox.Text)
                .AddWithValue("@Supervision", SupervisionTextBox.Text)
                .AddWithValue("@DocumentCompletion", DocumentCompletionTextBox.Text)
                .AddWithValue("@RegDate", Date.Today)
                .AddWithValue("@InputtedBy", InputtedByTextBox.Text)
                .AddWithValue("@Currency", CurrencyGridBox.EditValue)
                .AddWithValue("@ExchangeRate", ExchangeRateTextBox.Text)
                .AddWithValue("@BankAccountID", BankAccountIDGridBox.EditValue)
            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

            lblInformation.Text = "Successfully Inserted a new record"
            CreateLog(CurrentUserID, FullNameofUser, "Insert of new record in table (" & "Transfers" & " With ID (" & GeneratedTransferNoTextBox.Text & ")", 0)
            LoadRecords()
            'cmdAdd_Click()
            DisplayRecordInfo(GeneratedTransferNoTextBox.Text)

        Catch Ex As Exception
            If Ex.Message.ToUpper.Contains("FOREIGN") Then
                MessageBox.Show("Record Constraint Violation. Please make sure that BankAccountID:Bank:BankAccountID,Currency:CurrencySetup:Currency have values. If any does not have an applicable value then please select 'N/A' from the drop down list." & Ex.Message, "Incomplete entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End Try
    End Sub

    Private Sub cmdUpdate_Click() 'Handles cmdUpdate.Click
        Try
            If Not ValidateID(LoadedGeneratedTransferNo) Then
                MessageBox.Show("The loaded Generated Transfer No (" & LoadedGeneratedTransferNo & ") was not found in the database table. UPDATE OPERATION WILL NOT BE SUCCESSFULL. Please verify and try again.", "Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub
            End If
            If Not ValidateAllForeignKeys() Then

                Exit Sub
            End If
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "UPDATE Transfers SET OutgoneTransfer =@OutgoneTransfer, TransferNo =@TransferNo, TransferType =@TransferType, TransferDate =@TransferDate, OfficeType =@OfficeType, TotalAmount =@TotalAmount, TransferStatus =@TransferStatus, Comment =@Comment, Supervision =@Supervision, DocumentCompletion =@DocumentCompletion, RegDate =@RegDate, InputtedBy =@InputtedBy, Currency =@Currency, ExchangeRate =@ExchangeRate, BankAccountID =@BankAccountID WHERE GeneratedTransferNo = '" & LoadedGeneratedTransferNo & "'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)
            With ConCommand.Parameters
                .AddWithValue("@GeneratedTransferNo", GeneratedTransferNoTextBox.Text)
                .AddWithValue("@OutgoneTransfer", OutgoneTransferCheckEdit.Checked)

                .AddWithValue("@TransferNo", TransferNoTextBox.Text)
                .AddWithValue("@TransferType", TransferTypeTextBox.Text)
                .AddWithValue("@TransferDate", TransferDateDateTimePicker.DateTime.Date)
                .AddWithValue("@OfficeType", OfficeTypeTextBox.Text)
                .AddWithValue("@TotalAmount", TotalAmountTextBox.Text)
                .AddWithValue("@TransferStatus", TransferStatusTextBox.Text)
                .AddWithValue("@Comment", CommentTextBox.Text)
                .AddWithValue("@Supervision", SupervisionTextBox.Text)
                .AddWithValue("@DocumentCompletion", DocumentCompletionTextBox.Text)
                .AddWithValue("@RegDate", Date.Today)
                .AddWithValue("@InputtedBy", InputtedByTextBox.Text)
                .AddWithValue("@Currency", CurrencyGridBox.EditValue)
                .AddWithValue("@ExchangeRate", ExchangeRateTextBox.Text)
                .AddWithValue("@BankAccountID", BankAccountIDGridBox.EditValue)
            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()
            lblInformation.Text = "Successfully Updated a record"
            CreateLog(CurrentUserID, FullNameofUser, "Update of record in table (" & "Transfers" & " With ID (" & GeneratedTransferNoTextBox.Text & ")", 0)
        Catch Ex As Exception
            If Ex.Message.ToUpper.Contains("FOREIGN") Then
                MessageBox.Show("Record Constraint Violation. Please make sure that BankAccountID:Bank:BankAccountID,Currency:CurrencySetup:Currency have values. If any does not have an applicable value then please select 'N/A' from the drop down list." & Ex.Message, "Incomplete entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                    ThePKey = GeneratedTransferNoTextBox.Text
                Else
                    ThePKey = GridView1.GetFocusedDataRow.Item("GeneratedTransferNo")
                End If

                Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
                Dim Query As String = "DELETE FROM Transfers WHERE GeneratedTransferNo = '" & ThePKey & "'"
                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                Conn.Open()
                ConCommand.ExecuteNonQuery()
                Conn.Close()
                lblInformation.Text = "Record Deleted"
                CreateLog(CurrentUserID, FullNameofUser, "Delete of record in table (" & "Transfers" & " With ID (" & ThePKey & ")", 0)
                LoadRecords()
                Dim TheNewPKey As String = ""
                If MyReportTable.Rows.Count > 0 Then
                    TheNewPKey = GridView1.GetFocusedDataRow.Item("GeneratedTransferNo")
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


    'Private Sub GeneratedTransferNoTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GeneratedTransferNoTextBox.TextChanged
    'DisplayRecordInfo(GeneratedTransferNoTextBox.Text)
    'End Sub

    Private Sub LoadBankAccountID()

        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "Select  BankAccountID,NameOfBank,AccountName From Bank"

            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTableBank As New DataTable

            ConTableAdap.Fill(MyTableBank)

            BankAccountIDGridBox.Properties.DataSource = Nothing
            BankAccountIDGridBox.Properties.DataSource = MyTableBank

            BankAccountIDGridBox.Properties.DisplayMember = "NameOfBank"
            BankAccountIDGridBox.Properties.ValueMember = "BankAccountID"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub LoadCurrency()

        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "Select Currency,ExchangeRate,CurrencySymbol From CurrencySetup"

            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTableCurrencySetup As New DataTable

            ConTableAdap.Fill(MyTableCurrencySetup)

            CurrencyGridBox.Properties.DataSource = Nothing
            CurrencyGridBox.Properties.DataSource = MyTableCurrencySetup

            CurrencyGridBox.Properties.DisplayMember = "Currency"
            CurrencyGridBox.Properties.ValueMember = "Currency"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Public Sub DisplayRecordInfo(ByVal RecordID As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT GeneratedTransferNo,OutgoneTransfer,TransactionPosted,TransferNo,TransferType,TransferDate,OfficeType,TotalAmount,TransferStatus,Comment,Supervision,DocumentCompletion,RegDate,InputtedBy,Currency,ExchangeRate,BankAccountID FROM Transfers WHERE GeneratedTransferNo = '" & RecordID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)
            MySingleReportTable.Rows.Clear()
            ConTableAdapter.Fill(MySingleReportTable)

            If MySingleReportTable.Rows.Count > 0 Then
                lblInformation.Text = "Displaying details Of a record"
                GeneratedTransferNoTextBox.Text = MySingleReportTable.Rows(0).Item("GeneratedTransferNo").ToString
                OutgoneTransferCheckEdit.Checked = CByte(MySingleReportTable.Rows(0).Item("OutgoneTransfer"))

                TransferNoTextBox.Text = MySingleReportTable.Rows(0).Item("TransferNo").ToString
                TransferTypeTextBox.Text = MySingleReportTable.Rows(0).Item("TransferType").ToString
                TransferDateDateTimePicker.DateTime = MySingleReportTable.Rows(0).Item("TransferDate")
                OfficeTypeTextBox.Text = MySingleReportTable.Rows(0).Item("OfficeType").ToString
                TotalAmountTextBox.Text = MySingleReportTable.Rows(0).Item("TotalAmount").ToString
                TransferStatusTextBox.Text = MySingleReportTable.Rows(0).Item("TransferStatus").ToString
                CommentTextBox.Text = MySingleReportTable.Rows(0).Item("Comment").ToString
                SupervisionTextBox.Text = MySingleReportTable.Rows(0).Item("Supervision").ToString
                DocumentCompletionTextBox.Text = MySingleReportTable.Rows(0).Item("DocumentCompletion").ToString
                RegDateTextBox.Text = MySingleReportTable.Rows(0).Item("RegDate").ToString

                RegDateTextBox.ReadOnly = True

                If MySingleReportTable.Rows(0).Item("TransactionPosted") = True Then
                    cmdPostCheckButton.Checked = True
                Else
                    cmdPostCheckButton.Checked = False
                End If

                InputtedByTextBox.Text = MySingleReportTable.Rows(0).Item("InputtedBy").ToString
                CurrencyGridBox.EditValue = MySingleReportTable.Rows(0).Item("Currency").ToString
                ExchangeRateTextBox.Text = MySingleReportTable.Rows(0).Item("ExchangeRate").ToString
                BankAccountIDGridBox.EditValue = MySingleReportTable.Rows(0).Item("BankAccountID").ToString

                XtraTabControlRelated.Visible = True
                LoadTransferOfficeLinkRecords(GeneratedTransferNoTextBox.Text)
                LoadTransferFilesDataRecords(GeneratedTransferNoTextBox.Text)
                LoadTransferItemsRecords(GeneratedTransferNoTextBox.Text)
                LoadTransferPaymentsRecords(GeneratedTransferNoTextBox.Text)
                LoadedGeneratedTransferNo = GeneratedTransferNoTextBox.Text

                cmdMakePayment.Enabled = True
                cmdPrintHardcopyTransfer.Enabled = True
                cmdPrintStatement.Enabled = True

                lblInformation.Text = "Displaying details Of a record"

            Else
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "TransferOfficeLink"

    Private Sub LoadTransferOfficeLinkRecords(ByVal RecordID As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT TransferOfficeID,GeneratedTransferNo,OfficeID,RegDate,InputedBy FROM TransferOfficeLink WHERE GeneratedTransferNo = '" & RecordID & "' ORDER BY TransferOfficeID DESC "
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            TransferOfficeLinkGridView.DataSource = MYTABLE

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdAddTransferOfficeLink_Click(sender As Object, e As EventArgs) Handles cmdAddTransferOfficeLink.Click
        Try
            Dim MyForm As New frmTransferOfficeLink
            MyForm.isCalled = True
            MyForm.PrepareForm()
            MyForm.NewToolStripButton.PerformClick()
            MyForm.GeneratedTransferNoGridBox.EditValue = Me.GeneratedTransferNoTextBox.Text

            MyForm.WindowState = FormWindowState.Normal
            MyForm.FormBorderStyle = FormBorderStyle.Sizable
            MyForm.ShowDialog()

            LoadTransferOfficeLinkRecords(GeneratedTransferNoTextBox.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdRemoveTransferOfficeLink_Click(sender As Object, e As EventArgs) Handles cmdRemoveTransferOfficeLink.Click

        If RecordAccessLevel.Contains("Delete") Then
            If MessageBox.Show("Do you really want to delete the current record?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                Try
                    '**************************
                    '**************************
                    Dim RecordID As String = GridViewTransferOfficeLink.GetFocusedRowCellDisplayText(GridViewTransferOfficeLink.Columns("TransferOfficeID"))

                    Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
                    Dim Query As String = "DELETE FROM TransferOfficeLink WHERE TransferOfficeID = '" & RecordID & "'"
                    Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                    Conn.Open()
                    ConCommand.ExecuteNonQuery()
                    Conn.Close()

                    CreateLog(CurrentUserID, FullNameofUser, "Delete of TransferOfficeLink for " + GeneratedTransferNoTextBox.Text, 0)
                    LoadTransferOfficeLinkRecords(GeneratedTransferNoTextBox.Text)

                Catch Ex As Exception
                    MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Sorry you are not allowed to use this function. Please consult your administrator for assistance.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cmdOpenRecordTransferOfficeLink_Click(sender As Object, e As EventArgs) Handles cmdOpenRecordTransferOfficeLink.Click

        Try
            Dim TransferOfficeLinkID As String = GridViewTransferOfficeLink.GetFocusedRowCellDisplayText(GridViewTransferOfficeLink.Columns("TransferOfficeID"))
            Dim TransferOfficeLinkForm As New frmTransferOfficeLink
            TransferOfficeLinkForm.FormBorderStyle = FormBorderStyle.Sizable
            TransferOfficeLinkForm.StartPosition = FormStartPosition.CenterParent
            TransferOfficeLinkForm.PrepareForm()

            TransferOfficeLinkForm.OpenNEWToolStripButton_Click()
            TransferOfficeLinkForm.DisplayRecordInfo(TransferOfficeLinkID)
            TransferOfficeLinkForm.Show(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub cmdSearchTransferOfficeLink_Click(sender As Object, e As EventArgs) Handles cmdSearchTransferOfficeLink.Click
        Me.GridViewTransferOfficeLink.OptionsFind.AlwaysVisible = Not Me.GridViewTransferOfficeLink.OptionsFind.AlwaysVisible

    End Sub

#End Region
#Region "TransferFilesData"

    Private Sub LoadTransferFilesDataRecords(ByVal RecordID As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT ID,GeneratedTransferNo,FileType,FileName,GeneratedFileName,FileStatus,Description,RegDate,InputtedBy FROM TransferFilesData WHERE GeneratedTransferNo = '" & RecordID & "' ORDER BY ID DESC "
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            TransferFilesDataGridView.DataSource = MYTABLE

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdAddTransferFilesData_Click(sender As Object, e As EventArgs) Handles cmdAddTransferFilesData.Click
        Try
            Dim MyForm As New frmTransferFilesData
            MyForm.isCalled = True
            MyForm.PrepareForm()
            MyForm.NewToolStripButton.PerformClick()
            MyForm.GeneratedTransferNoGridBox.EditValue = Me.GeneratedTransferNoTextBox.Text

            MyForm.WindowState = FormWindowState.Normal
            MyForm.FormBorderStyle = FormBorderStyle.Sizable
            MyForm.ShowDialog()

            LoadTransferFilesDataRecords(GeneratedTransferNoTextBox.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdRemoveTransferFilesData_Click(sender As Object, e As EventArgs) Handles cmdRemoveTransferFilesData.Click

        If RecordAccessLevel.Contains("Delete") Then
            If MessageBox.Show("Do you really want to delete the current record?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                Try
                    '**************************
                    '**************************
                    Dim RecordID As String = GridViewTransferFilesData.GetFocusedRowCellDisplayText(GridViewTransferFilesData.Columns("ID"))

                    Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
                    Dim Query As String = "DELETE FROM TransferFilesData WHERE ID = '" & RecordID & "'"
                    Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                    Conn.Open()
                    ConCommand.ExecuteNonQuery()
                    Conn.Close()

                    CreateLog(CurrentUserID, FullNameofUser, "Delete of TransferFilesData for " + GeneratedTransferNoTextBox.Text, 0)
                    LoadTransferFilesDataRecords(GeneratedTransferNoTextBox.Text)

                Catch Ex As Exception
                    MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Sorry you are not allowed to use this function. Please consult your administrator for assistance.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cmdOpenRecordTransferFilesData_Click(sender As Object, e As EventArgs) Handles cmdOpenRecordTransferFilesData.Click

        Try
            Dim TransferFilesDataID As String = GridViewTransferFilesData.GetFocusedRowCellDisplayText(GridViewTransferFilesData.Columns("ID"))
            Dim TransferFilesDataForm As New frmTransferFilesData
            TransferFilesDataForm.FormBorderStyle = FormBorderStyle.Sizable
            TransferFilesDataForm.StartPosition = FormStartPosition.CenterParent
            TransferFilesDataForm.PrepareForm()

            TransferFilesDataForm.OpenNEWToolStripButton_Click()
            TransferFilesDataForm.DisplayRecordInfo(TransferFilesDataID)
            TransferFilesDataForm.Show(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub cmdSearchTransferFilesData_Click(sender As Object, e As EventArgs) Handles cmdSearchTransferFilesData.Click
        Me.GridViewTransferFilesData.OptionsFind.AlwaysVisible = Not Me.GridViewTransferFilesData.OptionsFind.AlwaysVisible

    End Sub

#End Region
#Region "TransferItems"

    Private Sub LoadTransferItemsRecords(ByVal RecordID As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT ItemID,GeneratedTransferNo,StockID,(SELECT NameOfItem FROM Inventory WHERE Inventory.StockID = TransferItems.StockID) AS NameOfItem,SalesCategory,UnitOfMeasurement,Quantity,UnitCost,TotalCost,RegDate,InputedBy FROM TransferItems WHERE GeneratedTransferNo = '" & RecordID & "' ORDER BY ItemID DESC "
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            TransferItemsGridView.DataSource = MYTABLE

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdAddTransferItems_Click(sender As Object, e As EventArgs) Handles cmdAddTransferItems.Click
        Try
            If cmdPostCheckButton.Checked Then
                MessageBox.Show("This Transaction is ALREADY POSTED. Please unPost it by Clicking the 'Post Transaction' button again before REMOVING or ADDING ITEMS?", "ALREADY POSTED", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim MyForm As New frmTransferItems
            MyForm.isCalled = True
            MyForm.PrepareForm()
            MyForm.NewToolStripButton.PerformClick()
            MyForm.GeneratedTransferNoGridBox.EditValue = Me.GeneratedTransferNoTextBox.Text

            MyForm.WindowState = FormWindowState.Normal
            MyForm.FormBorderStyle = FormBorderStyle.Sizable
            MyForm.ShowDialog()

            DisplayRecordInfo(GeneratedTransferNoTextBox.Text)
            'LoadTransferItemsRecords(GeneratedTransferNoTextBox.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdRemoveTransferItems_Click(sender As Object, e As EventArgs) Handles cmdRemoveTransferItems.Click

        If RecordAccessLevel.Contains("Delete") Then
            If cmdPostCheckButton.Checked Then
                MessageBox.Show("This Transaction is ALREADY POSTED. Please unPost it by Clicking the 'Post Transaction' button again before REMOVING or ADDING ITEMS?", "ALREADY POSTED", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("Do you really want to delete the current record?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                Try
                    '**************************
                    '**************************
                    Dim RecordID As String = GridViewTransferItems.GetFocusedRowCellDisplayText(GridViewTransferItems.Columns("ItemID"))

                    Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
                    Dim Query As String = "DELETE FROM TransferItems WHERE ItemID = '" & RecordID & "'"
                    Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                    Conn.Open()
                    ConCommand.ExecuteNonQuery()
                    Conn.Close()

                    UPDATETransferTotalAmount(GeneratedTransferNoTextBox.Text)

                    CreateLog(CurrentUserID, FullNameofUser, "Delete of TransferItems for " + GeneratedTransferNoTextBox.Text, 0)

                    DisplayRecordInfo(GeneratedTransferNoTextBox.Text)
                    'LoadTransferItemsRecords(GeneratedTransferNoTextBox.Text)

                Catch Ex As Exception
                    MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Sorry you are not allowed to use this function. Please consult your administrator for assistance.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cmdOpenRecordTransferItems_Click(sender As Object, e As EventArgs) Handles cmdOpenRecordTransferItems.Click

        Try
            Dim TransferItemsID As String = GridViewTransferItems.GetFocusedRowCellDisplayText(GridViewTransferItems.Columns("ItemID"))
            Dim TransferItemsForm As New frmTransferItems
            TransferItemsForm.FormBorderStyle = FormBorderStyle.Sizable
            TransferItemsForm.StartPosition = FormStartPosition.CenterParent
            TransferItemsForm.PrepareForm()

            TransferItemsForm.OpenNEWToolStripButton_Click()
            TransferItemsForm.DisplayRecordInfo(TransferItemsID)
            TransferItemsForm.Show(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub cmdSearchTransferItems_Click(sender As Object, e As EventArgs) Handles cmdSearchTransferItems.Click
        Me.GridViewTransferItems.OptionsFind.AlwaysVisible = Not Me.GridViewTransferItems.OptionsFind.AlwaysVisible

    End Sub

#End Region
#Region "TransferPayments"

    Private Sub LoadTransferPaymentsRecords(ByVal RecordID As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT IPaymentID,GeneratedTransferNo,PaidBy,PaymentDate,CurrentAmount,AmountPaid,Balance,PaymentMode,RefChequeNo,Bank,Comment,RegDate,InputedBy FROM TransferPayments WHERE GeneratedTransferNo = '" & RecordID & "' ORDER BY IPaymentID DESC "
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            TransferPaymentsGridView.DataSource = MYTABLE

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdAddTransferPayments_Click(sender As Object, e As EventArgs) Handles cmdAddTransferPayments.Click
        Try
            Dim MyForm As New frmTransferPayments
            MyForm.isCalled = True
            MyForm.PrepareForm()
            MyForm.NewToolStripButton.PerformClick()
            MyForm.GeneratedTransferNoGridBox.EditValue = Me.GeneratedTransferNoTextBox.Text

            MyForm.WindowState = FormWindowState.Normal
            MyForm.FormBorderStyle = FormBorderStyle.Sizable
            MyForm.ShowDialog()

            LoadTransferPaymentsRecords(GeneratedTransferNoTextBox.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdRemoveTransferPayments_Click(sender As Object, e As EventArgs) Handles cmdRemoveTransferPayments.Click

        If RecordAccessLevel.Contains("Delete") Then
            If MessageBox.Show("Do you really want to delete the current record?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                Try
                    '**************************
                    '**************************
                    Dim RecordID As String = GridViewTransferPayments.GetFocusedRowCellDisplayText(GridViewTransferPayments.Columns("IPaymentID"))

                    Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
                    Dim Query As String = "DELETE FROM TransferPayments WHERE IPaymentID = '" & RecordID & "'"
                    Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                    Conn.Open()
                    ConCommand.ExecuteNonQuery()
                    Conn.Close()

                    CreateLog(CurrentUserID, FullNameofUser, "Delete of TransferPayments for " + GeneratedTransferNoTextBox.Text, 0)
                    LoadTransferPaymentsRecords(GeneratedTransferNoTextBox.Text)

                Catch Ex As Exception
                    MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Sorry you are not allowed to use this function. Please consult your administrator for assistance.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cmdOpenRecordTransferPayments_Click(sender As Object, e As EventArgs) Handles cmdOpenRecordTransferPayments.Click

        Try
            Dim TransferPaymentsID As String = GridViewTransferPayments.GetFocusedRowCellDisplayText(GridViewTransferPayments.Columns("IPaymentID"))
            Dim TransferPaymentsForm As New frmTransferPayments
            TransferPaymentsForm.FormBorderStyle = FormBorderStyle.Sizable
            TransferPaymentsForm.StartPosition = FormStartPosition.CenterParent
            TransferPaymentsForm.PrepareForm()

            TransferPaymentsForm.OpenNEWToolStripButton_Click()
            TransferPaymentsForm.DisplayRecordInfo(TransferPaymentsID)
            TransferPaymentsForm.Show(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub cmdSearchTransferPayments_Click(sender As Object, e As EventArgs) Handles cmdSearchTransferPayments.Click
        Me.GridViewTransferPayments.OptionsFind.AlwaysVisible = Not Me.GridViewTransferPayments.OptionsFind.AlwaysVisible

    End Sub

#End Region



    Private Function GetTransferItemsSumTotalAmount(ByVal GeneratedTransferNo As String) As Double
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT SUM(TotalCost) AS Total FROM TransferItems WHERE GeneratedTransferNo = '" & GeneratedTransferNo & "'"
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

    Private Function GetTransferItemsSumAmountPaid(ByVal GeneratedTransferNo As String) As Double
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT AmountPaid AS Total FROM Transfers WHERE GeneratedTransferNo = '" & GeneratedTransferNo & "'"
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

    Private Sub UPDATETransferTotalAmount(ByVal GeneratedTransferNo As String)
        Try
            Dim TheTotal As Double = GetTransferItemsSumTotalAmount(GeneratedTransferNo)
            Dim TheAmountPaid As Double = GetTransferItemsSumAmountPaid(GeneratedTransferNo)

            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "UPDATE Transfers SET TotalAmount = @TotalAmount, Balance = @Balance WHERE GeneratedTransferNo = '" & GeneratedTransferNo & "'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            With ConCommand.Parameters
                .AddWithValue("@TotalAmount", TheTotal)
                .AddWithValue("@Balance", TheTotal - TheAmountPaid)
            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

            CreateLog(CurrentUserID, FullNameofUser, "Update TotalAmount of Transfers to " & GeneratedTransferNo, 0)
        Catch Ex As Exception
            If Ex.Message.ToUpper.Contains("FOREIGN") Then
                MessageBox.Show("Record Constraint Violation. Please make sure that  have values. If any does not have an applicable value then please select 'N/A' from the drop down list." & Ex.Message, "Incomplete entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub


    Private Function ValidateAllForeignKeys() As Boolean

        'If Not ValidateUniversalID("TransferOfficeLink", "TransferOfficeID", TransferOfficeIDGridBox.EditValue) Then
        '    MessageBox.Show("Please provide an acceptable value for '"Transfer Office ID & "' from its drop-down list before saving the record.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Return False
        'End If

        'If Not ValidateUniversalID("TransferFilesData", "ID", IDGridBox.EditValue) Then
        '    MessageBox.Show("Please provide an acceptable value for '"ID & "' from its drop-down list before saving the record.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Return False
        'End If

        'If Not ValidateUniversalID("TransferItems", "ItemID", ItemIDGridBox.EditValue) Then
        '    MessageBox.Show("Please provide an acceptable value for '"Item ID & "' from its drop-down list before saving the record.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Return False
        'End If

        'If Not ValidateUniversalID("TransferPayments", "IPaymentID", IPaymentIDGridBox.EditValue) Then
        '    MessageBox.Show("Please provide an acceptable value for '"IPayment ID & "' from its drop-down list before saving the record.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Return False
        'End If


        Return True
    End Function

    'Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
    '       Try
    '	Dim MyCompanyTable As New DataTable
    '       MyCompanyTable = GetCompanyData()

    '       Dim MyDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument '= New CrystalReportTransfers
    '       MyDocument.SummaryInfo.ReportTitle = "Transfers"
    '	      Dim MyTable As New DataTable
    '       Dim TableName As String = "Transfers"
    '       Dim Fields As String = "GeneratedTransferNo"
    '       Dim Values As String = GeneratedTransferNoTextBox.Text
    '       MyTable = UniversalGetDatafromTable(TableName, Fields, Values)
    '	    Dim MyQRCodeTable As DataTable = New QRandBarcodeDataSet.QRandLinearCodeDataTable
    '           Dim QrCodeData As String = "Transfers Report - Printed on: " & DateTime.Today
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
            MySearch.FormName = "frmTransfers"
            MySearch.TableName = "Transfers"
            MySearch.PrimaryKey = "GeneratedTransferNo"

            If MySearch.ShowDialog() = DialogResult.OK Then
                MyReportTable = MySearch.SearchTable
                TransfersDataGridView.DataSource = MyReportTable
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
            myReport.cboTableName.SelectedIndex = myReport.FindItemIndex("Transfers")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub ImportWizardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportWizardToolStripMenuItem.Click
        Try
            Dim MyImportForm As New frmImports
            MyImportForm.LoadTables()
            MyImportForm.cboTableName.SelectedIndex = MyImportForm.FindItemIndex("Transfers")
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
            Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("GeneratedTransferNo"))
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
            Dim QueryItems As String = "GeneratedTransferNo,OutgoneTransfer,TransactionPosted,TransferNo,TransferType,TransferDate,OfficeType,TotalAmount,TransferStatus,Comment,Supervision,DocumentCompletion,RegDate,InputtedBy,Currency,ExchangeRate,BankAccountID"
            Dim TableName As String = "Transfers"
            Dim Condition As String

            If SearchToolStripComboBox.Text = "" Then
                Condition = ""
            Else
                Condition = "GeneratedTransferNo = '" & SearchToolStripComboBox.Text & "'"
            End If

            Dim OrderByCondition As String = "ORDER BY GeneratedTransferNo DESC"

            Dim MyTable As DataTable = GetDataForTable(QueryItems, TableName, Condition, OrderByCondition)

            If SearchToolStripComboBox.Text = "" Then
                MyReportTable.Rows.Clear()
                MyReportTable.Columns.Clear()

                MyReportTable = MyTable
                TransfersDataGridView.DataSource = MyReportTable
            Else
                OpenNEWToolStripButton_Click()
                DisplayRecordInfo(MyTable.Rows(0).Item("GeneratedTransferNo"))
            End If
            isDateSearchUsed = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


    Private Sub MySearchItemsLoading() Handles Me.Load
        Dim QueryItem As String = "GeneratedTransferNo"
        Dim TableName As String = "Transfers"
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
        Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("GeneratedTransferNo"))
        'DisplayRecordInfo(DRecordID)

        Dim MyTable As DataTable = GetDataForTable(" * ", "Transfers", "GeneratedTransferNo = '" & DRecordID & "'", " ORDER BY GeneratedTransferNo ASC")

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

                Dim Query As String = " SELECT GeneratedTransferNo,OutgoneTransfer,TransactionPosted,TransferNo,TransferType,TransferDate,OfficeType,TotalAmount,TransferStatus,Comment,Supervision,DocumentCompletion,RegDate,InputtedBy,Currency,ExchangeRate,BankAccountID FROM Transfers ORDER BY GeneratedTransferNo DESC "
                Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

                MyReportTable.Rows.Clear()
                ConTableAdapter.Fill(MyReportTable)

                TransfersDataGridView.DataSource = MyReportTable

                If MyReportTable.Rows.Count > 0 Then
                    DisplayRecordInfo(MyReportTable.Rows(0).Item("GeneratedTransferNo"))
                End If

            Catch Ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub frmTransfers_GotFocus(sender As Object, e As EventArgs) Handles Me.Activated
        CurrentDisplayedFormName = Me.Name
    End Sub

#End Region
    Private Sub cmdPrevious_Click(sender As Object, e As EventArgs) Handles cmdPrevious.Click
        GridView1.MovePrev()
        Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("GeneratedTransferNo"))
        DisplayRecordInfo(DRecordID)
    End Sub
    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        GridView1.MoveNext()
        Dim DRecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("GeneratedTransferNo"))
        DisplayRecordInfo(DRecordID)
    End Sub



    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Try

            If PanelNew.Visible = False Then
                Dim RecordID As String = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns("GeneratedTransferNo"))
                DisplayRecordInfo(RecordID)
            End If

            If MySingleReportTable.Rows.Count = 0 Then
                MessageBox.Show("No data was loaded. Please select a record before proceeding with the printing process.", "Empty Set", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim MyCompanyTable As New DataTable
            MyCompanyTable = GetCompanyData()

            Dim MyDocument As New XtraReportTransfersSingle
            MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
            MyDocument.TransfersDataSource.DataSource = MySingleReportTable
            MyDocument.XrLabelReportTitle.Text = "Transfers"

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

            Dim MyDocument As New XtraReportTransfersMultiple
            MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
            MyDocument.TransfersDataSource.DataSource = MyReportTable
            MyDocument.XrLabelReportTitle.Text = "Transfers"

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

            Dim Allfields As String = GetAllFields("Transfers", DatabaseName)
            Dim splitfields As String() = Allfields.Trim.Split(",")

            Dim QueryString As String = ""

            For Each field In splitfields

                Dim ColumnType As String = GetColumnDataType("Transfers", field).ToUpper

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

                Dim Query As String = " SELECT GeneratedTransferNo,OutgoneTransfer,TransactionPosted,TransferNo,TransferType,TransferDate,OfficeType,TotalAmount,TransferStatus,Comment,Supervision,DocumentCompletion,RegDate,InputtedBy,Currency,ExchangeRate,BankAccountID FROM Transfers WHERE " & SearchDateFieldComboBox.Text & " BETWEEN '" & StartDateTimePicker.DateTime.ToString("yyy-MM-dd") & "' AND '" & EndDateTimePicker.DateTime.ToString("yyyy-MM-dd") & "' ORDER BY GeneratedTransferNo DESC "
                Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

                Dim MyTable As New DataTable
                ConTableAdapter.Fill(MyTable)

                If MyTable.Rows.Count > 0 Then
                    MyReportTable.Rows.Clear()
                    MyReportTable = MyTable.Copy()

                    TransfersDataGridView.DataSource = MyReportTable
                    Me.PanelNew.Visible = False

                    isDateSearchUsed = True
                    MessageBox.Show("Search Complete. " & MyTable.Rows.Count & " record(s) found.", "Search Complete", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    'If MyReportTable.Rows.Count > 0 Then
                    'DisplayRecordInfo(MyReportTable.Rows(0).Item("GeneratedTransferNo"))
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

#Region "Transfer FILES DATA FILES ACCESS SECTION"


    Private Sub cmdOpenTransferFilesData_Click(sender As Object, e As EventArgs) Handles cmdOpenTransferFilesData.Click
        Dim RecordID As String = GridViewTransferFilesData.GetFocusedRowCellDisplayText(GridViewTransferFilesData.Columns("ID"))
        Dim InfoTable As DataTable = GetFileInformation(RecordID, "TransferFilesData")

        Dim ItemDescription As String = InfoTable.Rows(0).Item("Description")
        'Dim TheSplit As String() = ItemDescription.Trim.Split(":")
        Dim TheFileName As String = InfoTable.Rows(0).Item("FileName")
        Dim TheRegDate As String = InfoTable.Rows(0).Item("RegDate")
        Dim TheGeneratedfileName As String = InfoTable.Rows(0).Item("GeneratedFileName")

        If TheFileName.ToUpper.Contains(".JPG") Or TheFileName.ToUpper.Contains(".PNG") Or TheFileName.ToUpper.Contains(".BMP") Or TheFileName.ToUpper.Contains(".JPEG") Then
            Dim TheBytes As Byte() = GetDocumentData(RecordID, "GeneratedFileName", "TransferFilesData", "ID")

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
            Dim TheBytes As Byte() = GetDocumentData(RecordID, "GeneratedFileName", "TransferFilesData", "ID")

            If TheBytes Is Nothing Then
                MessageBox.Show("File Not Found on File Server. Please contact the System Administrator", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub
            End If

            Dim MyForm As New frmWordProcessor
            MyForm.RichEditControl1.OpenXmlBytes() = TheBytes
            MyForm.WindowState = FormWindowState.Maximized
            MyForm.Show(Me)
        ElseIf TheFileName.ToUpper.Contains(".PDF") Then
            Dim TheBytes As Byte() = GetDocumentData(RecordID, "GeneratedFileName", "TransferFilesData", "ID")

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
            Dim TheBytes As Byte() = GetDocumentData(RecordID, "GeneratedFileName", "TransferFilesData", "ID")

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

            Dim FullPath As String = "\\" & FILEServerIPAddress & "\" & FILEFolder & "\TransferFilesData\" & TheGeneratedfileName
            MyForm.PlayList.clear()
            MyForm.AddItemToPlaylist(FullPath)

            'MyForm.AxWindowsMediaPlayer1.newMedia(FullPath)
            MyForm.WindowState = FormWindowState.Maximized
            MyForm.Show(Me)

        Else
            Dim TheBytes As Byte() = GetDocumentData(RecordID, "GeneratedFileName", "TransferFilesData", "ID")

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


    Private Sub cmdDownloadTransferFilesData_Click(sender As Object, e As EventArgs) Handles cmdDownloadTransferFilesData.Click
        Try
            Dim RecordID As String = GridViewTransferFilesData.GetFocusedRowCellDisplayText(GridViewTransferFilesData.Columns("ID"))

            Dim TheBytes As Byte() = GetDocumentData(RecordID, "GeneratedFileName", "TransferFilesData", "ID")
            Dim InfoTable As DataTable = GetFileInformation(RecordID, "TransferFilesData")

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


    Private Sub cmdExploreAllTransferFilesData_Click(sender As Object, e As EventArgs) Handles cmdExploreAllTransferFilesData.Click

        Dim MyForm As New frmOpenandViewDocuments
        MyForm.ForeignKeyField = "GeneratedTransferNo"
        MyForm.ForeignKeyValue = GeneratedTransferNoTextBox.Text
        MyForm.TableName = "TransferFilesData"

        MyForm.BarStaticItemTransactionNo.Caption = GeneratedTransferNoTextBox.Text
        MyForm.BarStaticItemTotalAmount.Caption = ""
        MyForm.BarStaticItemNetBalance.Caption = ""

        MyForm.ShowDialog()


    End Sub


#End Region

#Region "OTHER FUNCTIONS"

    Private Sub cmdPrintOfficeDocument_Click(sender As Object, e As EventArgs) Handles cmdPrintOfficeDocument.Click
        Try
            Dim MyCompanyTable As New DataTable
            MyCompanyTable = GetCompanyData()

            'Dim MyAgreementTable As New DataTable
            'MyAgreementTable = GetAgreementData()

            Dim MyTable As DataTable = New DebtorsTable.DebtorsTableDataTable

            For index = 1 To numCustPrintCount.Value
                Dim Thearray As New ArrayList()

                For Each item In MyTable.Columns
                    Thearray.Add(Nothing)
                Next

                MyTable.Rows.Add(Thearray.ToArray)
                Dim lastrow As Integer = MyTable.Rows.Count

                MyTable.Rows(lastrow - 1).Item(0) = "I" & DateTime.Now.ToString("mmyyssddMMHH") + index
                MyTable.Rows(lastrow - 1).Item(13) = MyCompanyTable.Rows(0).Item("NameofCompany")
            Next


            If TemplateTransferTypeComboBox.Text.ToUpper.Contains("RECEIPT") Then
                Dim MyDocument As New XtraReportReceiptTemplate

                MyDocument.lblTitle.Text = TemplateTransferTypeComboBox.Text.ToUpper
                MyDocument.lblTitle2.Text = TemplateTransferTypeComboBox.Text.ToUpper

                If radManualDate.Checked Then
                    MyDocument.lblprintdate.Visible = False
                    MyDocument.lblprintdatevalue.Visible = False
                Else
                    MyDocument.lblmanualdate.Visible = False
                    MyDocument.lblmanualdatevalue.Visible = False
                End If

                If MyCompanyTable.Rows.Count > 0 Then
                    Dim MYBytes As Byte() = MyCompanyTable.Rows(0).Item("Logo")
                    Dim MyMemoryStream As New System.IO.MemoryStream(MYBytes)
                    Dim MyImage As Image = Image.FromStream(MyMemoryStream)

                    MyDocument.Watermark.Image = MyImage
                    MyDocument.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Clip
                    MyDocument.Watermark.ImageTransparency = 240
                    MyDocument.Watermark.ImageAlign = ContentAlignment.MiddleCenter
                End If


                'MyDocument.Watermark.Text = MyCompanyTable.Rows(0).Item("NameofCompany")
                'MyDocument.Watermark.ForeColor = Color.Black
                'MyDocument.Watermark.TextTransparency = 240
                'MyDocument.Watermark.Font = New Font("Segoe UI", 48)

                MyDocument.DebtorsDataSource.DataSource = MyTable
                'MyDocument.AgreementDataSource.DataSource = MyAgreementTable
                MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
                MyDocument.CreateDocument()

                Dim MyReportViewer As New frmNewReportViewer
                MyReportViewer.WindowState = FormWindowState.Maximized

                MyReportViewer.DocumentViewer1.DocumentSource = MyDocument
                MyReportViewer.ShowDialog()

            ElseIf TemplateTransferTypeComboBox.Text.ToUpper.Contains("DELIVERY") Then
                Dim MyDocument As New XtraReportDeliveryTemplate

                MyDocument.lblTitle.Text = TemplateTransferTypeComboBox.Text.ToUpper
                MyDocument.lblTitle2.Text = TemplateTransferTypeComboBox.Text.ToUpper

                If radManualDate.Checked Then
                    MyDocument.lblprintdate.Visible = False
                    MyDocument.lblprintdatevalue.Visible = False
                Else
                    MyDocument.lblmanualdate.Visible = False
                    MyDocument.lblmanualdatevalue.Visible = False

                    MyDocument.addressline.WidthF = 625
                End If

                MyDocument.lblPreparedBy.Text = "Delevered By"
                MyDocument.lblApprovedBy.Text = "Received By"

                Dim MYBytes As Byte() = MyCompanyTable.Rows(0).Item("Logo")
                Dim MyMemoryStream As New System.IO.MemoryStream(MYBytes)
                Dim MyImage As Image = Image.FromStream(MyMemoryStream)

                MyDocument.Watermark.Image = MyImage
                MyDocument.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Clip
                MyDocument.Watermark.ImageTransparency = 240
                MyDocument.Watermark.ImageAlign = ContentAlignment.MiddleCenter

                MyDocument.DebtorsDataSource.DataSource = MyTable
                MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
                MyDocument.CreateDocument()

                Dim MyReportViewer As New frmNewReportViewer
                MyReportViewer.WindowState = FormWindowState.Maximized

                MyReportViewer.DocumentViewer1.DocumentSource = MyDocument
                MyReportViewer.ShowDialog()
            ElseIf TemplateTransferTypeComboBox.Text.ToUpper.Contains("Transfer") Then
                Dim MyDocument As New XtraReportTransferTemplate

                MyDocument.lblTitle.Text = TemplateTransferTypeComboBox.Text.ToUpper
                MyDocument.lblTitle2.Text = TemplateTransferTypeComboBox.Text.ToUpper

                If radManualDate.Checked Then
                    MyDocument.lblprintdate.Visible = False
                    MyDocument.lblprintdatevalue.Visible = False
                Else
                    MyDocument.lblmanualdate.Visible = False
                    MyDocument.lblmanualdatevalue.Visible = False

                    MyDocument.addressline.WidthF = 625
                End If

                Dim MYBytes As Byte() = MyCompanyTable.Rows(0).Item("Logo")
                Dim MyMemoryStream As New System.IO.MemoryStream(MYBytes)
                Dim MyImage As Image = Image.FromStream(MyMemoryStream)

                MyDocument.Watermark.Image = MyImage
                MyDocument.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Clip
                MyDocument.Watermark.ImageTransparency = 240
                MyDocument.Watermark.ImageAlign = ContentAlignment.MiddleCenter

                'MyDocument.Watermark.Text = MyCompanyTable.Rows(0).Item("NameofCompany")
                'MyDocument.Watermark.ForeColor = Color.Black
                'MyDocument.Watermark.TextTransparency = 240
                'MyDocument.Watermark.Font = New Font("Segoe UI", 48)


                MyDocument.DebtorsDataSource.DataSource = MyTable
                'MyDocument.AgreementDataSource.DataSource = MyAgreementTable
                MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
                MyDocument.CreateDocument()

                Dim MyReportViewer As New frmNewReportViewer
                MyReportViewer.WindowState = FormWindowState.Maximized

                MyReportViewer.DocumentViewer1.DocumentSource = MyDocument
                MyReportViewer.ShowDialog()

            ElseIf TemplateTransferTypeComboBox.Text.ToUpper.Contains("LETTER") Then
                Dim MyDocument As New XtraReportLetterheadTemplate

                'MyDocument.lblTitle.Text = TemplateTransferTypeComboBox.Text.ToUpper
                'MyDocument.lblTitle2.Text = TemplateTransferTypeComboBox.Text.ToUpper

                'If radManualDate.Checked Then
                '    MyDocument.lblprintdate.Visible = False
                '    MyDocument.lblprintdatevalue.Visible = False
                'Else
                '    MyDocument.lblmanualdate.Visible = False
                '    MyDocument.lblmanualdatevalue.Visible = False

                '    MyDocument.addressline.WidthF = 625
                'End If

                Dim MYBytes As Byte() = MyCompanyTable.Rows(0).Item("Logo")
                Dim MyMemoryStream As New System.IO.MemoryStream(MYBytes)
                Dim MyImage As Image = Image.FromStream(MyMemoryStream)

                MyDocument.Watermark.Image = MyImage
                MyDocument.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Zoom
                MyDocument.Watermark.ImageTransparency = 240
                MyDocument.Watermark.ImageAlign = ContentAlignment.MiddleCenter

                'MyDocument.Watermark.Text = MyCompanyTable.Rows(0).Item("NameofCompany")
                'MyDocument.Watermark.ForeColor = Color.Black
                'MyDocument.Watermark.TextTransparency = 240
                'MyDocument.Watermark.Font = New Font("Segoe UI", 48)


                MyDocument.DebtorsDataSource.DataSource = MyTable
                'MyDocument.AgreementDataSource.DataSource = MyAgreementTable
                MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
                MyDocument.CreateDocument()

                Dim MyReportViewer As New frmNewReportViewer
                MyReportViewer.WindowState = FormWindowState.Maximized

                MyReportViewer.DocumentViewer1.DocumentSource = MyDocument
                MyReportViewer.ShowDialog()

            Else
                Dim MyDocument As New XtraReportTransferTemplate

                MyDocument.lblTitle.Text = TemplateTransferTypeComboBox.Text.ToUpper
                MyDocument.lblTitle2.Text = TemplateTransferTypeComboBox.Text.ToUpper

                If radManualDate.Checked Then
                    MyDocument.lblprintdate.Visible = False
                    MyDocument.lblprintdatevalue.Visible = False
                Else
                    MyDocument.lblmanualdate.Visible = False
                    MyDocument.lblmanualdatevalue.Visible = False

                    MyDocument.addressline.WidthF = 625
                End If

                Dim MYBytes As Byte() = MyCompanyTable.Rows(0).Item("Logo")
                Dim MyMemoryStream As New System.IO.MemoryStream(MYBytes)
                Dim MyImage As Image = Image.FromStream(MyMemoryStream)

                MyDocument.Watermark.Image = MyImage
                MyDocument.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Clip
                MyDocument.Watermark.ImageTransparency = 240
                MyDocument.Watermark.ImageAlign = ContentAlignment.MiddleCenter

                'MyDocument.Watermark.Text = MyCompanyTable.Rows(0).Item("NameofCompany")
                'MyDocument.Watermark.ForeColor = Color.Black
                'MyDocument.Watermark.TextTransparency = 240
                'MyDocument.Watermark.Font = New Font("Segoe UI", 48)


                MyDocument.DebtorsDataSource.DataSource = MyTable
                'MyDocument.AgreementDataSource.DataSource = MyAgreementTable
                MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
                MyDocument.CreateDocument()

                Dim MyReportViewer As New frmNewReportViewer
                MyReportViewer.WindowState = FormWindowState.Maximized

                MyReportViewer.DocumentViewer1.DocumentSource = MyDocument
                MyReportViewer.ShowDialog()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdClosePanelCustAgreements_Click(sender As Object, e As EventArgs) Handles cmdClosePanelCustAgreements.Click
        Me.PanelTransferTemplate.Visible = False
    End Sub

    Private Function GetOfficeName(ByVal RecordID As String) As String
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT NameOfOffice From View_TransferOfficesBrief WHERE GeneratedTransferNo = '" & RecordID & "' ORDER BY OfficeID DESC "
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            If MYTABLE.Rows.Count > 0 Then
                Dim FullName As String = ""

                For Each record In MYTABLE.Rows
                    If FullName = "" Then
                        FullName = record("NameOfOffice")
                    Else
                        FullName = FullName & ", " & record("NameOfOffice")
                    End If
                Next

                Return FullName

            Else
                Return ""
            End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
        End Try
    End Function

    Private Function GetOfficeAddress(ByVal RecordID As String) As String
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT ResidentialAddress From View_TransferOfficesBrief WHERE GeneratedTransferNo = '" & RecordID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            If MYTABLE.Rows.Count > 0 Then
                Return MYTABLE.Rows(0).Item("ResidentialAddress")
            Else
                Return ""
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
        End Try
    End Function



    Private Sub cmdCloseOfficestatement_Click(sender As Object, e As EventArgs) Handles cmdCloseOfficestatement.Click
        Me.PanelOfficestatement.Visible = False
    End Sub

    Private Sub cmdPrintOfficestatement_Click(sender As Object, e As EventArgs) Handles cmdPrintOfficestatement.Click
        Try
            Dim MyCompanyTable As New DataTable
            MyCompanyTable = GetCompanyData()

            Dim MyDocument As New XtraReportOfficestatements
            MyDocument.XrLabelReportTitle.Text = "Transfer Statement for " & OfficeIDGridBox.Text.ToUpper()

            Dim MYBytes As Byte() = MyCompanyTable.Rows(0).Item("Logo")
            Dim MyMemoryStream As New System.IO.MemoryStream(MYBytes)
            Dim MyImage As Image = Image.FromStream(MyMemoryStream)

            MyDocument.Watermark.Image = MyImage
            MyDocument.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Clip
            MyDocument.Watermark.ImageTransparency = 240
            MyDocument.Watermark.ImageAlign = ContentAlignment.MiddleCenter

            Dim MyTable As New DataTable
            Dim TableName As String = "View_TransferOfficesLink"
            Dim Fields As String = "OfficeID"
            Dim Values As String = OfficeIDGridBox.EditValue
            MyTable = UniversalGetDatafromTable(TableName, Fields, Values)


            MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
            MyDocument.OfficeLinkDataSource.DataSource = MyTable
            MyDocument.CreateDocument()

            Dim MyReportViewer As New frmNewReportViewer
            MyReportViewer.WindowState = FormWindowState.Maximized

            MyReportViewer.DocumentViewer1.DocumentSource = MyDocument
            MyReportViewer.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrintStatement_Click(sender As Object, e As EventArgs) Handles cmdPrintStatement.Click
        Me.PanelOfficestatement.Visible = True
        Me.PanelOfficestatement.BringToFront()
    End Sub

    Private Sub PrintTemplateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintTemplateToolStripMenuItem.Click
        Me.PanelTransferTemplate.Visible = True
        Me.PanelTransferTemplate.BringToFront()
    End Sub

    Private Sub cmdMakePayment_Click(sender As Object, e As EventArgs) Handles cmdMakePayment.Click
        Try
            Dim MyForm As New frmTransferPayments
            MyForm.NewToolStripButton.PerformClick()

            MyForm.isCalled = True
            MyForm.PrepareForm()
            MyForm.GeneratedTransferNoGridBox.EditValue = Me.GeneratedTransferNoTextBox.Text

            MyForm.WindowState = FormWindowState.Normal
            MyForm.FormBorderStyle = FormBorderStyle.Sizable
            MyForm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CurrencyGridBox_EditValueChanged(sender As Object, e As EventArgs) Handles CurrencyGridBox.EditValueChanged
        Try
            ExchangeRateTextBox.Text = GetExchangeRate(CurrencyGridBox.EditValue)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function GetExchangeRate(ByVal Currency As String) As Double

        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "Select Currency,ExchangeRate,CurrencySymbol From CurrencySetup WHERE Currency = '" & Currency & "'"

            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTableCurrencySetup As New DataTable

            ConTableAdap.Fill(MyTableCurrencySetup)

            If MyTableCurrencySetup.Rows.Count > 0 Then
                Return MyTableCurrencySetup.Rows(0).Item("ExchangeRate")
            Else
                Return 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try


    End Function


    Private Function GetTransferItems(ByVal RecordID As String) As DataTable
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT ItemID, NameOfItem, Quantity, UnitCost, TotalCost FROM View_TransferItemsInventory WHERE GeneratedTransferNo = '" & RecordID & "' ORDER BY ItemID ASC "
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            Return MYTABLE

        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
            Return New DataTable
        End Try
    End Function

    Private Sub cmdPrintHardcopyTransfer_Click(sender As Object, e As EventArgs) Handles cmdPrintHardcopyTransfer.Click
        Try
            Dim MyCompanyTable As New DataTable
            MyCompanyTable = GetCompanyData()

            Dim TransferItems As DataTable = GetTransferItems(GeneratedTransferNoTextBox.Text)

            If TransferItems.Rows.Count > 11 Then
                PrintHardCopyTransferMore()
            Else
                PrintHardCopyTransferSmall()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Function GetStamp() As Byte()
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT Stamp FROM CompanySettings"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            If MYTABLE.Rows.Count > 0 Then
                If Not IsDBNull(MYTABLE.Rows(0).Item("Stamp")) Then
                    Return MYTABLE.Rows(0).Item("Stamp")
                End If
            Else
                Return {0}
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
        End Try
    End Function

    Private Sub PrintHardCopyTransferSmall()
        Try
            Dim MyCompanyTable As New DataTable
            MyCompanyTable = GetCompanyData()

            Dim MyDocument As New XtraReportTransferHardcopy
            MyDocument.lblTo.Text = GetOfficeName(GeneratedTransferNoTextBox.Text).ToString().ToUpper()
            MyDocument.lblAddress.Text = GetOfficeAddress(GeneratedTransferNoTextBox.Text).ToString().ToUpper()
            MyDocument.lblTitle.Text = TransferTypeTextBox.Text.ToUpper
            'MyDocument.lblTitle2.Text = TransferTypeTextBox.Text.ToUpper

            Dim MYBytes As Byte() = MyCompanyTable.Rows(0).Item("Logo")
            Dim MyMemoryStream As New System.IO.MemoryStream(MYBytes)
            Dim MyImage As Image = Image.FromStream(MyMemoryStream)

            MyDocument.Watermark.Image = MyImage
            MyDocument.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Clip
            MyDocument.Watermark.ImageTransparency = 240
            MyDocument.Watermark.ImageAlign = ContentAlignment.MiddleCenter

            If TransferNoTextBox.Text <> "" Then
                MyDocument.lblTransferNo.Text = TransferNoTextBox.Text
                MyDocument.MyBarCode.Text = TransferNoTextBox.Text
            Else
                MyDocument.lblTransferNo.Text = GeneratedTransferNoTextBox.Text
                MyDocument.MyBarCode.Text = GeneratedTransferNoTextBox.Text
            End If

            MyDocument.XrLabelAccountNo.Text = BankAccountIDGridBox.EditValue 'AccountNoLookupGridView.Properties.GetDisplayTextByKeyValue(AccountNoLookupGridView.EditValue) & " - " & GetAccountName(AccountNoLookupGridView.EditValue) & " (" & AccountNoLookupGridView.EditValue & ")"

            If radHDusemanualdate.Checked Then
                MyDocument.lblprintdate.Visible = False
                MyDocument.lblprintdatevalue.Visible = False
            Else
                MyDocument.lblmanualdate.Visible = False
                MyDocument.lblmanualdatevalue.Visible = False

                MyDocument.addressline.WidthF = 625
            End If

            Dim TransferItems As DataTable = GetTransferItems(GeneratedTransferNoTextBox.Text)

            Dim TableofContentSubreport As XRSubreport = CType(MyDocument.Bands(BandKind.Detail).FindControl("XrSubreportTransferItems", True), XRSubreport)
            TableofContentSubreport.ReportSource.DataSource = TransferItems

            Dim TotalAmount As Double = 0

            For Each item In TransferItems.Rows
                TotalAmount += CDbl(item("TotalCost"))
            Next

            MyDocument.lblTotal.Text = TotalAmount.ToString("n2")
            MyDocument.lblAmountInWords.Text = AmountInWords(TotalAmount.ToString(), CurrencyGridBox.EditValue)

            If MyCompanyTable.Rows.Count > 0 Then
                MyDocument.lblTotalCurrency.Text = "TOTAL:  " & GetCurrencySymbol(CurrencyGridBox.EditValue)
            End If

            If TransferTypeTextBox.Text.ToUpper.Contains("DELIVERY") Then
                MyDocument.XrLabelPreparedBy.Text = "Received By"
                MyDocument.XrLabelApprovedBy.Text = "Delivered By"
            End If

            'MyDocument.Watermark.Text = MyCompanyTable.Rows(0).Item("NameofCompany")
            'MyDocument.Watermark.TextTransparency = 220
            'MyDocument.DrawWatermark = True

            If Not TransferTypeTextBox.Text.ToUpper.Contains("DELIVERY") Then
                Try
                    Dim Approvalbytes As Byte() = GetSupervisorSignature()
                    Dim ApprovalStream As New System.IO.MemoryStream(Approvalbytes)
                    MyDocument.pbApprovedBy.Image = Image.FromStream(ApprovalStream)
                    MyDocument.pbApprovedByStamp.Image = Image.FromStream(ApprovalStream)

                Catch ex As Exception

                End Try
            End If

            If Not TransferTypeTextBox.Text.ToUpper.Contains("DELIVERY") Then
                Try
                    Dim Preparedbytes As Byte() = GetUserSignature(CurrentUserID)
                    Dim PreparedStream As New System.IO.MemoryStream(Preparedbytes)
                    MyDocument.pbPreparedBy.Image = Image.FromStream(PreparedStream)
                Catch ex As Exception

                End Try
            End If

            Try
                Dim Stampbytes As Byte() = GetStamp()
                Dim StampStream As New System.IO.MemoryStream(Stampbytes)
                MyDocument.pbStamp.Image = Image.FromStream(StampStream)

            Catch ex As Exception

            End Try


            MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
            MyDocument.CreateDocument()

            Dim MyReportViewer As New frmNewReportViewer
            MyReportViewer.WindowState = FormWindowState.Maximized

            MyReportViewer.DocumentViewer1.DocumentSource = MyDocument
            MyReportViewer.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub PrintHardCopyTransferMore()
        Try
            Dim MyCompanyTable As New DataTable
            MyCompanyTable = GetCompanyData()

            Dim MyDocument As New XtraReportTransferHardcopyMore
            MyDocument.lblTo.Text = GetOfficeName(GeneratedTransferNoTextBox.Text).ToString().ToUpper()
            MyDocument.lblAddress.Text = GetOfficeAddress(GeneratedTransferNoTextBox.Text).ToString().ToUpper()
            MyDocument.lblTitle.Text = TransferTypeTextBox.Text.ToUpper
            'MyDocument.lblTitle2.Text = TransferTypeTextBox.Text.ToUpper

            Dim MYBytes As Byte() = MyCompanyTable.Rows(0).Item("Logo")
            Dim MyMemoryStream As New System.IO.MemoryStream(MYBytes)
            Dim MyImage As Image = Image.FromStream(MyMemoryStream)

            MyDocument.Watermark.Image = MyImage
            MyDocument.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Clip
            MyDocument.Watermark.ImageTransparency = 240
            MyDocument.Watermark.ImageAlign = ContentAlignment.MiddleCenter

            If TransferNoTextBox.Text <> "" Then
                MyDocument.lblTransferNo.Text = TransferNoTextBox.Text
                MyDocument.MyBarCode.Text = TransferNoTextBox.Text
            Else
                MyDocument.lblTransferNo.Text = GeneratedTransferNoTextBox.Text
                MyDocument.MyBarCode.Text = GeneratedTransferNoTextBox.Text
            End If

            MyDocument.XrLabelAccountNo.Text = BankAccountIDGridBox.EditValue 'BankAccountIDGridBox.Properties.GetDisplayTextByKeyValue(BankAccountIDGridBox.EditValue) & " - " & GetAccountName(AccountNoLookupGridView.EditValue) & " (" & AccountNoLookupGridView.EditValue & ")"

            If radHDusemanualdate.Checked Then
                MyDocument.lblprintdate.Visible = False
                MyDocument.lblprintdatevalue.Visible = False
            Else
                MyDocument.lblmanualdate.Visible = False
                MyDocument.lblmanualdatevalue.Visible = False

                MyDocument.addressline.WidthF = 625
            End If

            Dim TransferItems As DataTable = GetTransferItems(GeneratedTransferNoTextBox.Text)
            Dim MoreTransferItems As DataTable = TransferItems.Clone

            For i = 11 To TransferItems.Rows.Count - 1
                Dim TheArray As New ArrayList

                For ii = 0 To TransferItems.Columns.Count - 1
                    TheArray.Add(TransferItems.Rows(i).Item(ii))
                Next

                MoreTransferItems.Rows.Add(TheArray.ToArray)
            Next

            Dim TotalAmount As Double = 0

            For Each item In TransferItems.Rows
                TotalAmount += CDbl(item("TotalCost"))
            Next

            Dim TotalCount As Integer = TransferItems.Rows.Count - 1
            For i = TotalCount To 11 Step -1
                TransferItems.Rows.RemoveAt(i)
            Next

            Dim TableofContentSubreport As XRSubreport = CType(MyDocument.Bands(BandKind.Detail).FindControl("XrSubreportTransferItems", True), XRSubreport)
            TableofContentSubreport.ReportSource.DataSource = TransferItems

            Dim TableofContentSubreportMore As XRSubreport = CType(MyDocument.Bands(BandKind.ReportFooter).FindControl("XrSubreportTransferItemsMore", True), XRSubreport)
            TableofContentSubreportMore.ReportSource.DataSource = MoreTransferItems

            MyDocument.lblTotal.Text = TotalAmount.ToString("n2")
            MyDocument.lblAmountInWords.Text = AmountInWords(TotalAmount.ToString(), CurrencyGridBox.EditValue)

            If MyCompanyTable.Rows.Count > 0 Then
                MyDocument.lblTotalCurrency.Text = "TOTAL:  " & GetCurrencySymbol(CurrencyGridBox.EditValue)
            End If

            If TransferTypeTextBox.Text.ToUpper.Contains("DELIVERY") Then
                MyDocument.XrLabelPreparedBy.Text = "Received By"
                MyDocument.XrLabelApprovedBy.Text = "Delivered By"
            End If

            'MyDocument.Watermark.Text = MyCompanyTable.Rows(0).Item("NameofCompany")
            'MyDocument.Watermark.TextTransparency = 220
            'MyDocument.DrawWatermark = True

            If Not TransferTypeTextBox.Text.ToUpper.Contains("DELIVERY") Then
                Try
                    Dim Approvalbytes As Byte() = GetSupervisorSignature()
                    Dim ApprovalStream As New System.IO.MemoryStream(Approvalbytes)
                    MyDocument.pbApprovedBy.Image = Image.FromStream(ApprovalStream)
                    MyDocument.pbApprovedByStamp.Image = Image.FromStream(ApprovalStream)

                    If TransferItems.Rows.Count + MoreTransferItems.Rows.Count > 11 Then
                        MyDocument.pbApprovedBySignatureMore.Image = Image.FromStream(ApprovalStream)
                    End If
                Catch ex As Exception

                End Try
            End If

            If Not TransferTypeTextBox.Text.ToUpper.Contains("DELIVERY") Then
                Try
                    Dim Preparedbytes As Byte() = GetUserSignature(CurrentUserID)
                    Dim PreparedStream As New System.IO.MemoryStream(Preparedbytes)
                    MyDocument.pbPreparedBy.Image = Image.FromStream(PreparedStream)
                Catch ex As Exception

                End Try
            End If



            Try
                Dim Stampbytes As Byte() = GetStamp()
                Dim StampStream As New System.IO.MemoryStream(Stampbytes)
                MyDocument.pbStamp.Image = Image.FromStream(StampStream)

                If TransferItems.Rows.Count + MoreTransferItems.Rows.Count > 11 Then
                    MyDocument.pbStampMore.Image = Image.FromStream(StampStream)
                End If

            Catch ex As Exception

            End Try


            MyDocument.CompanySettingsDataSource.DataSource = MyCompanyTable
            MyDocument.CreateDocument()

            Dim MyReportViewer As New frmNewReportViewer
            MyReportViewer.WindowState = FormWindowState.Maximized

            MyReportViewer.DocumentViewer1.DocumentSource = MyDocument
            MyReportViewer.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function GetCurrencySymbol(ByVal Currency As String) As String
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT CurrencySymbol FROM CurrencySetup WHERE Currency = '" & Currency & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            If MYTABLE.Rows.Count > 0 Then
                Return MYTABLE.Rows(0).Item("CurrencySymbol")
            Else
                Return ""
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
            Return ""
        End Try
    End Function


    Private Function GetUserSignature(ByVal UserID As String) As Byte()
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT Signature FROM MainLogin WHERE AccountID = '" & UserID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            If MYTABLE.Rows.Count > 0 Then
                If Not IsDBNull(MYTABLE.Rows(0).Item("Signature")) Then
                    Return MYTABLE.Rows(0).Item("Signature")
                End If
            Else
                Return {0}
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
        End Try
    End Function


    Private Function GetSupervisorSignature() As Byte()
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT Signature FROM MainLogin WHERE CAST(DECRYPTBYPASSPHRASE(N'mypassword',UserGroup) AS NVARCHAR(1000)) = 'Supervisor'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MYTABLE As New DataTable

            ConTableAdapter.Fill(MYTABLE)

            If MYTABLE.Rows.Count > 0 Then
                If Not IsDBNull(MYTABLE.Rows(0).Item("Signature")) Then
                    Return MYTABLE.Rows(0).Item("Signature")
                End If
            Else
                Return {0}
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
        End Try
    End Function

#End Region


#Region "UPDATING THE STOCK IN THE INVENTORY"
    Private Sub cmdPostCheckButton_CheckedChanged(sender As Object, e As EventArgs) Handles cmdPostCheckButton.CheckedChanged

    End Sub

    Private Function GETGeneralSalesItemsRecords(ByVal RecordID As String) As DataTable
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT ItemID,GeneratedTransferNo,SalesCategory,StockID,UnitOfMeasurement,Quantity,UnitCost,TotalCost,RegDate,InputedBy FROM TransferItems WHERE GeneratedTransferNo = '" & RecordID & "' ORDER BY ItemID DESC "
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

    Private Sub UPDATETransferTransactionPostedStatus(ByVal GeneratedTransferNo As String, ByVal TransactionPosted As Boolean)
        Try

            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "UPDATE Transfers SET TransactionPosted = @TransactionPosted WHERE GeneratedTransferNo = '" & GeneratedTransferNo & "'"

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
                Dim TheItems As DataTable = GETGeneralSalesItemsRecords(GeneratedTransferNoTextBox.Text)

                For Each item In TheItems.Rows
                    UPDATESTOCKQuantity(item("StockID"), item("SalesCategory"), CDbl(item("Quantity")) * -1)
                Next

                UPDATETransferTransactionPostedStatus(GeneratedTransferNoTextBox.Text, True)
            Else
                cmdPostCheckButton.Checked = True
            End If
        Else
            If MessageBox.Show("Do you really wish to unPOST this TRANSACTION. This will INCREASE the Quantity of the Stock in the Inventory appropriately.", "unPosting Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim TheItems As DataTable = GETGeneralSalesItemsRecords(GeneratedTransferNoTextBox.Text)

                For Each item In TheItems.Rows
                    UPDATESTOCKQuantity(item("StockID"), item("SalesCategory"), CDbl(item("Quantity")))
                Next

                UPDATETransferTransactionPostedStatus(GeneratedTransferNoTextBox.Text, False)
            Else
                cmdPostCheckButton.Checked = True
            End If
        End If
    End Sub

#End Region

End Class