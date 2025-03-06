Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmReport


#Region "SUMMARY REPORT"

    Dim CorrectList As New ComboBox
    Dim FilterTable As New DataTable

    Dim ExportFileName As String
    Dim ExportCount As Integer
    Dim ExpectedNoValues As Integer
    Dim NoofColumns As Integer

    Private Function getCompanySettings() As DataTable
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT * FROM CompanySettings"

            Dim MyTable As New DataTable
            Dim Contableadap As New SqlClient.SqlDataAdapter(Query, Conn)

            Contableadap.Fill(MyTable)

            Return MyTable

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function




    Private Sub cmdPrintReport_Click(sender As Object, e As EventArgs) Handles cmdPrintReport.Click

        If cboDateField.SelectedIndex = -1 And chkDate.Checked = True Then
            MessageBox.Show("Please select the date field", "Missing info", MessageBoxButtons.OK, MessageBoxIcon.Information)



            Exit Sub
        End If

        Dim MySummaryTable As New DataTable
        Dim ColumnNames As New ListBox

        Try
            Dim Conn As New SqlConnection(MyConnectionString)

            Dim EStartDate As String = ReportStartDateDateTimePicker1.Value.Year & "-" & ReportStartDateDateTimePicker1.Value.Month & "-" & ReportStartDateDateTimePicker1.Value.Day
            Dim EEndDate As String = ReportEndDateDateTimePicker2.Value.Year & "-" & ReportEndDateDateTimePicker2.Value.Month & "-" & ReportEndDateDateTimePicker2.Value.Day

            Dim TheFields As String = Nothing

            For Each Item In lstReport.Items
                If TheFields = Nothing Then
                    TheFields = Item
                Else
                    TheFields = TheFields & ", " & Item
                End If
            Next

            Dim Query As String

            Dim AdditionalQuery As String = gatherAdditionQueryfromFilterTable()

            If chkDate.Checked = True Then
                If FilterTable.Rows.Count > 0 Then
                    Query = " SELECT " & TheFields & " FROM " & CorrectList.Items(cboTableName.SelectedIndex) & " WHERE " & cboDateField.Text & " BETWEEN '" & EStartDate & "' AND '" & EEndDate & "'" & " AND " & AdditionalQuery
                Else
                    Query = " SELECT " & TheFields & " FROM " & CorrectList.Items(cboTableName.SelectedIndex) & " WHERE " & cboDateField.Text & " BETWEEN '" & EStartDate & "' AND '" & EEndDate & "'"
                End If
            Else
                If FilterTable.Rows.Count > 0 Then
                    Query = " SELECT " & TheFields & " FROM " & CorrectList.Items(cboTableName.SelectedIndex) & " WHERE " & AdditionalQuery
                Else
                    Query = " SELECT " & TheFields & " FROM " & CorrectList.Items(cboTableName.SelectedIndex)
                End If

            End If

            Dim ConTableAdapter As New SqlDataAdapter(Query, Conn)

            ConTableAdapter.Fill(MySummaryTable)

            If MySummaryTable.Rows.Count > 0 Then

                Dim MyDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument

                If radRecordlistandSummary.Checked = True Then
                    MyDocument = New CrystalReportUniversalReport
                ElseIf radRecordlistonly.Checked = True Then
                    MyDocument = New CrystalReportUniversalRecordList
                Else
                    MyDocument = New CrystalReportUniversalSummaryOnly
                End If


                For i = 0 To lstReport.Items.Count - 1
                    Dim iNum As Integer = i + 1
                    ColumnNames.Items.Add(MySummaryTable.Columns(i).ColumnName)
                    MySummaryTable.Columns(i).ColumnName = "Field" & iNum

                    If radRecordlistonly.Checked = False Then
                        Dim MyRepTable As DataTable = New SummaryDataSet.SummaryDataTable

                        If chkDate.Checked = True Then
                            MyRepTable = generateReportSummaryGroup(SeparateText(lstReport.Items(i)), CorrectList.Items(cboTableName.SelectedIndex), lstReport.Items(i), cboDateField.Text, ReportStartDateDateTimePicker1.Value.Date, ReportEndDateDateTimePicker2.Value.Date, True)
                        Else
                            MyRepTable = generateReportSummaryGroup(SeparateText(lstReport.Items(i)), CorrectList.Items(cboTableName.SelectedIndex), lstReport.Items(i), cboDateField.Text, ReportStartDateDateTimePicker1.Value.Date, ReportEndDateDateTimePicker2.Value.Date, False)
                        End If




                        MyDocument.Subreports.Item(i).SetDataSource(MyRepTable)
                    End If

                Next

                Dim MyCompanyTable As New DataTable
                MyCompanyTable = getCompanySettings()

                MyDocument.Database.Tables(0).SetDataSource(MySummaryTable)
                MyDocument.Database.Tables(1).SetDataSource(MyCompanyTable)

                Dim ReportDate As String

                If chkDate.Checked = True Then
                    ReportDate = "Report Summary From: " & ReportStartDateDateTimePicker1.Value.Date & " To " & ReportEndDateDateTimePicker2.Value.Date
                Else
                    ReportDate = "Report Summary (without specifying a date)"
                End If

                Dim myParameterFieldDefinitions As ParameterFieldDefinitions
                Dim myParameterFieldDefinition As ParameterFieldDefinition
                Dim myParameterValues As New ParameterValues
                Dim myParameterDiscreteValue As New ParameterDiscreteValue

                myParameterDiscreteValue.Value = txtReportTitle.Text
                myParameterFieldDefinitions = MyDocument.DataDefinition.ParameterFields
                myParameterFieldDefinition = myParameterFieldDefinitions.Item("ReportType")
                myParameterValues = myParameterFieldDefinition.CurrentValues
                myParameterValues.Clear()
                myParameterValues.Add(myParameterDiscreteValue)
                myParameterFieldDefinition.ApplyCurrentValues(myParameterValues)

                myParameterDiscreteValue.Value = ReportDate
                myParameterFieldDefinitions = MyDocument.DataDefinition.ParameterFields
                myParameterFieldDefinition = myParameterFieldDefinitions.Item("ReportDate")
                myParameterValues = myParameterFieldDefinition.CurrentValues
                myParameterValues.Clear()
                myParameterValues.Add(myParameterDiscreteValue)
                myParameterFieldDefinition.ApplyCurrentValues(myParameterValues)


                For i = 0 To ColumnNames.Items.Count - 1

                    Dim FineName As String = SeparateText(ColumnNames.Items(i))
                    myParameterDiscreteValue.Value = FineName
                    myParameterFieldDefinitions = MyDocument.DataDefinition.ParameterFields
                    Dim ItemName As String = "Field" & (i + 1)
                    myParameterFieldDefinition = myParameterFieldDefinitions.Item(ItemName)
                    myParameterValues = myParameterFieldDefinition.CurrentValues
                    myParameterValues.Clear()
                    myParameterValues.Add(myParameterDiscreteValue)
                    myParameterFieldDefinition.ApplyCurrentValues(myParameterValues)

                Next

                Try
                    If lstReport.Items.Count < 8 Then
                        For i = lstReport.Items.Count To 8

                            myParameterDiscreteValue.Value = " "
                            myParameterFieldDefinitions = MyDocument.DataDefinition.ParameterFields
                            Dim ItemName As String = "Field" & (i + 1)
                            myParameterFieldDefinition = myParameterFieldDefinitions.Item(ItemName)
                            myParameterValues = myParameterFieldDefinition.CurrentValues
                            myParameterValues.Clear()
                            myParameterValues.Add(myParameterDiscreteValue)
                            myParameterFieldDefinition.ApplyCurrentValues(myParameterValues)

                        Next
                    End If

                Catch ex As Exception

                End Try


                Dim MyReportViewer As New frmReportViewer
        MyReportViewer.WindowState = FormWindowState.Maximized
                MyReportViewer.MyCrystalReportViewer.ReportSource = MyDocument
                MyReportViewer.ShowDialog()

            Else
                MessageBox.Show("No Record found for the dates specified", "Empty Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub

    Private Function gatherAdditionQueryfromFilterTable() As String
        Dim Query As String = Nothing

        For Each Record In FilterTable.Rows
            If Query = Nothing Then
                Query = Record("GroupName") & " = '" & Record("TheColumn") & "'"
            Else
                Query = Query & " AND " & Record("GroupName") & " = '" & Record("TheColumn") & "'"
            End If
        Next

        Return Query

    End Function



    Public Sub LoadTables() Handles Me.Load
        Try
            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT TABLE_NAME FROM " & DatabaseName & ".INFORMATION_SCHEMA.tables ORDER BY TABLE_NAME ASC"
            Dim MyTable As New DataTable

            Dim conTableAdapter As New SqlDataAdapter(Query, Conn)
            conTableAdapter.Fill(MyTable)

            cboTableName.Items.Clear()
            cboDateField.Items.Clear()
            CorrectList.Items.Clear()

            If MyTable.Rows.Count > 0 Then
                For Each Record In MyTable.Rows
                    If Record("TABLE_NAME") <> "sysdiagrams" Then
                        CorrectList.Items.Add(Record("TABLE_NAME"))

                        Dim TheTable As String = Record("TABLE_NAME").ToString.Replace("tbl", "")
                        TheTable = TheTable.Replace("tbL", "")

                        cboTableName.Items.Add(SeparateText(TheTable))
                    End If
                Next
            End If

            If cboTableName.Items.Count > 0 Then
                cboTableName.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub




    Private Sub LoadDateFields(ByVal TableName As String)
        Try
            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT COLUMN_NAME FROM " & DatabaseName & ".INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" & TableName & "' AND DATA_TYPE LIKE '%DATE%' ORDER BY COLUMN_NAME ASC"

            Dim MyTable As New DataTable

            Dim conTableAdapter As New SqlDataAdapter(Query, Conn)
            conTableAdapter.Fill(MyTable)

            cboDateField.Items.Clear()

            If MyTable.Rows.Count > 0 Then
                For Each Record In MyTable.Rows
                    cboDateField.Items.Add(Record("COLUMN_NAME"))
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


    Public Function FindItemIndex(ByVal TheItem As String) As Integer
        Try
            Dim dIndex As Integer = 0

            For Each item In CorrectList.Items
                If item = TheItem Then
                    Return dIndex
                    Exit For
                Else
                    dIndex += 1
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function



    Private Sub LoadFields()
        Try
            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT COLUMN_NAME FROM " & DatabaseName & ".INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" & CorrectList.Items(cboTableName.SelectedIndex) & "' ORDER BY COLUMN_NAME ASC"

            Dim MyTable As New DataTable

            Dim conTableAdapter As New SqlDataAdapter(Query, Conn)
            conTableAdapter.Fill(MyTable)

            lstDatabase.Items.Clear()
            lstReport.Items.Clear()

            If MyTable.Rows.Count > 0 Then
                For Each Record In MyTable.Rows
                    lstDatabase.Items.Add(Record("COLUMN_NAME"))
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub




    Private Sub cmdmove_Click() Handles cmdmove.Click
        If lstDatabase.SelectedIndex <> -1 Then
            If lstReport.Items.Count < 8 Then
                Dim DIndex As Integer = lstDatabase.SelectedIndex
                lstReport.Items.Add(lstDatabase.Items(lstDatabase.SelectedIndex))
                lstDatabase.Items.RemoveAt(DIndex)

                lblFieldsRemaining.Text = 8 - lstReport.Items.Count & " Field(s) Remaining"

                If lstReport.SelectedIndex = -1 Then
                    lstFilter.Items.Clear()
                End If
            Else
                MessageBox.Show("You have reached the maximum No. of field to display in the report (8 Max)", "Maximum Reached", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If



    End Sub




    Private Sub cmdreturn_Click() Handles cmdreturn.Click
        If lstReport.SelectedIndex <> -1 Then
            DeleteGroupfromGroupTable(lstReport.SelectedItem)

            Dim DIndex As Integer = lstReport.SelectedIndex
            lstDatabase.Items.Add(lstReport.Items(lstReport.SelectedIndex))
            lstReport.Items.RemoveAt(DIndex)

            lblFieldsRemaining.Text = 8 - lstReport.Items.Count & " Fields Remaining"

            lstFilter.Items.Clear()

        End If



    End Sub




    Private Sub cboTableName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTableName.SelectedIndexChanged
        LoadFields()

        If cboTableName.SelectedIndex <> -1 Then
            LoadDateFields(CorrectList.Items(cboTableName.SelectedIndex))
        End If

        Dim thename As String = cboTableName.Text
        thename = thename.Replace("tbl", "")
        Dim reportTitle As String = SeparateText(thename) & " Report"
        txtReportTitle.Text = reportTitle

        lstFilter.Items.Clear()
        FilterTable.Rows.Clear()




    End Sub

#End Region




    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()

    End Sub




    Private Sub cmdMinimize_Click(sender As Object, e As EventArgs) Handles cmdMinimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub




    Private Sub lstDatabase_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstDatabase.MouseClick
        If lstDatabase.SelectedIndex <> -1 Then
            cmdmove_Click()
        End If

    End Sub




    Private Sub lstReport_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstReport.MouseDoubleClick
        If lstReport.SelectedIndex <> -1 Then
            cmdreturn_Click()
        End If

    End Sub




    Private Sub chkDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkDate.CheckedChanged
        If chkDate.Checked = True Then
            cboDateField.Enabled = True
            gbDate.Enabled = True
        Else
            cboDateField.Enabled = False
            gbDate.Enabled = False
        End If

    End Sub




    Private Sub lstReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstReport.SelectedIndexChanged
        If lstReport.SelectedIndex <> -1 Then
            getListofFilters(CorrectList.Items(cboTableName.SelectedIndex), lstReport.SelectedItem)
            lstFilter.SelectedItem = getTheValuefromFilterTable(lstReport.SelectedItem)
        End If

    End Sub




    Private Sub getListofFilters(ByVal TableName As String, ByVal ColumnName As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT DISTINCT(" & ColumnName & ") AS TheValues FROM " & TableName

            Dim MyTable As New DataTable
            Dim Contableadap As New SqlClient.SqlDataAdapter(Query, Conn)

            Contableadap.Fill(MyTable)

            lstFilter.Items.Clear()

            For Each Record In MyTable.Rows
                lstFilter.Items.Add(Record("TheValues"))
            Next

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub




    Private Sub MyLoading() Handles Me.Load
        FilterTable.Columns.Add("GroupName")
        FilterTable.Columns.Add("TheColumn")

    End Sub




    Private Sub lstFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFilter.SelectedIndexChanged
        If lstFilter.SelectedIndex <> -1 Then
            AddDatatoGroupTable(lstReport.SelectedItem, lstFilter.SelectedItem)
            cmdremove.Enabled = True
        Else
            cmdremove.Enabled = False
        End If

    End Sub




    Private Sub AddDatatoGroupTable(ByVal GroupName As String, ByVal TheColumn As String)
        Try
            DeleteGroupfromGroupTable(GroupName)

            FilterTable.Rows.Add(GroupName, TheColumn)

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub




    Private Sub DeleteGroupfromGroupTable(ByVal GroupName As String)
        Try
            Dim IndexToRemove As Integer = 0
            Dim isGroupfound As Boolean = False

            For Each Item In FilterTable.Rows
                If Item("GroupName") = GroupName Then
                    isGroupfound = True
                    Exit For
                Else
                    IndexToRemove += 1
                End If
            Next

            If isGroupfound = True Then
                FilterTable.Rows.RemoveAt(IndexToRemove)
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Function getTheValuefromFilterTable(ByVal TableName As String) As String
        Try
            For Each Item In FilterTable.Rows
                If Item("GroupName") = TableName Then
                    Return Item("TheColumn")
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
 

    Private Sub cmdremove_Click(sender As Object, e As EventArgs) Handles cmdremove.Click
        If lstFilter.SelectedIndex <> -1 Then
            DeleteGroupfromGroupTable(lstReport.SelectedItem)
            lstFilter.SelectedIndex = -1
        End If

    End Sub



    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click


        If cboDateField.SelectedIndex = -1 And chkDate.Checked = True Then
            MessageBox.Show("Please select the date field", "Missing info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Exit Sub
        End If

        If chkRestrict.Checked = True Then
            If lstReport.Items.Count = 0 Then
                MessageBox.Show("Please select atleast one field before clicking search.", "Missing field(s)", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Exit Sub
            End If
        End If

        Try
            Dim Conn As New SqlConnection(MyConnectionString)

            Dim EStartDate As String = ReportStartDateDateTimePicker1.Value.Year & "-" & ReportStartDateDateTimePicker1.Value.Month & "-" & ReportStartDateDateTimePicker1.Value.Day
            Dim EEndDate As String = ReportEndDateDateTimePicker2.Value.Year & "-" & ReportEndDateDateTimePicker2.Value.Month & "-" & ReportEndDateDateTimePicker2.Value.Day

            Dim TheFields As String = Nothing

            For Each Item In lstReport.Items
                If TheFields = Nothing Then
                    TheFields = Item
                Else
                    TheFields = TheFields & ", " & Item
                End If
            Next

            Dim Query As String

            Dim AdditionalQuery As String = gatherAdditionQueryfromFilterTable()

            If chkRestrict.Checked = True Then
                If chkDate.Checked = True Then
                    If FilterTable.Rows.Count > 0 Then
                        Query = " SELECT " & TheFields & " FROM " & CorrectList.Items(cboTableName.SelectedIndex) & " WHERE " & cboDateField.Text & " BETWEEN '" & EStartDate & "' AND '" & EEndDate & "'" & " AND " & AdditionalQuery
                    Else
                        Query = " SELECT " & TheFields & " FROM " & CorrectList.Items(cboTableName.SelectedIndex) & " WHERE " & cboDateField.Text & " BETWEEN '" & EStartDate & "' AND '" & EEndDate & "'"
                    End If
                Else
                    If FilterTable.Rows.Count > 0 Then
                        Query = " SELECT " & TheFields & " FROM " & CorrectList.Items(cboTableName.SelectedIndex) & " WHERE " & AdditionalQuery
                    Else
                        Query = " SELECT " & TheFields & " FROM " & CorrectList.Items(cboTableName.SelectedIndex)
                    End If

                End If
            Else
                If chkDate.Checked = True Then
                    If FilterTable.Rows.Count > 0 Then
                        Query = " SELECT * FROM " & CorrectList.Items(cboTableName.SelectedIndex) & " WHERE " & cboDateField.Text & " BETWEEN '" & EStartDate & "' AND '" & EEndDate & "'" & " AND " & AdditionalQuery
                    Else
                        Query = " SELECT * FROM " & CorrectList.Items(cboTableName.SelectedIndex) & " WHERE " & cboDateField.Text & " BETWEEN '" & EStartDate & "' AND '" & EEndDate & "'"
                    End If
                Else
                    If FilterTable.Rows.Count > 0 Then
                        Query = " SELECT * FROM " & CorrectList.Items(cboTableName.SelectedIndex) & " WHERE " & AdditionalQuery
                    Else
                        Query = " SELECT * FROM " & CorrectList.Items(cboTableName.SelectedIndex)
                    End If

                End If
            End If


            Dim ConTableAdapter As New SqlDataAdapter(Query, Conn)

            Dim MyTable As New DataTable
            ConTableAdapter.Fill(MyTable)

            lblNoofRecords.Text = MyTable.Rows.Count & " Record(s)"
            SearchDataGridView.DataSource = MyTable

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub
     

    'Private Sub SearchDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles SearchDataGridView.DataError


    'End Sub


End Class
