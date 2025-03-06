Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmSynchronize
    Dim MyReportTable As New DataTable

    'Dim TheTableName As String
    Dim TheSyncConnectionString As String

    Dim TotalNoofRecords As Integer
    Dim TotalSynced As Integer
    Dim TotalSyncedDuplicates As Integer

    Dim TotalForeignSynced As Integer
    Dim TotalForeignSyncedDuplicates As Integer

    Dim Operation As String
    Dim TheSyncType As String

    Dim TablesToSync As New ArrayList
    Dim DateField As String
    Dim StartDate As DateTime
    Dim EndDate As DateTime
    Dim EntireDatabaseCondition As Boolean


    Private Sub MyLoading() Handles Me.Load
        CheckSyncAccess()
        lblNoofRecords.Text = ""
        GetAllRelations(DatabaseName)

    End Sub


    Private Sub CheckSyncAccess()
        If radPush.Checked Then
            If RecordAccessLevel.Contains("Sync Update") Then
                radUpdate.Enabled = True
            Else
                radUpdate.Enabled = False
            End If

            If RecordAccessLevel.Contains("Sync Delete") Then
                radDelete.Enabled = True
            Else
                radDelete.Enabled = False
            End If
        Else
            radUpdate.Enabled = True
            radDelete.Enabled = True
        End If

    End Sub

    Private Sub GetAllRelations(ByVal DatabaseName As String)
        Try
            Dim TheConnectionstring As String = ""

            If radPull.Checked Then
                If My.Settings.DBServerIPAddress.Contains(".\") Or My.Settings.DBServerIPAddress.Contains("\") Then
                    TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & ";Database=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                Else
                    TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & "," & My.Settings.DBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                End If
            Else
                If My.Settings.LocalDBServerIPAddress.Contains(".\") Or My.Settings.LocalDBServerIPAddress.Contains("\") Then
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & ";Database=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                Else
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & "," & My.Settings.LocalDBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                End If
            End If

            Dim Conn As New SqlConnection(TheConnectionstring)
            Dim Query As String = "SELECT * FROM " & DatabaseName & ".INFORMATION_SCHEMA.tables WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY TABLE_NAME ASC"
            Dim MyTable As New DataTable

            Dim conTableAdapter As New SqlDataAdapter(Query, Conn)
            conTableAdapter.Fill(MyTable)

            TablesComboBox.Properties.Items.Clear()

            If MyTable.Rows.Count > 0 Then
                For Each Record In MyTable.Rows
                    If Record("TABLE_NAME") <> "sysdiagrams" And Record("TABLE_NAME").ToString.ToUpper <> "MAINLOGIN" And Record("TABLE_NAME").ToString.ToUpper <> "MESSAGE" And Record("TABLE_NAME").ToString.ToUpper <> "DIGITALARCHIEVE" And Record("TABLE_NAME").ToString.ToUpper <> "LOGIN" And Record("TABLE_NAME").ToString.ToUpper <> "PROGRAMVERSION" And Record("TABLE_NAME").ToString.ToUpper <> "PROGRAMUPDATES" And Record("TABLE_NAME").ToString.ToUpper <> "TBLUSERLOG" Then
                        TablesComboBox.Properties.Items.Add(Record("TABLE_NAME"))
                    End If
                Next
            End If

            If TablesComboBox.Properties.Items.Count > 0 Then
                TablesComboBox.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub LoadRecords(ByVal TableName As String)
        Try
            Dim TheConnectionstring As String = ""

            If radPull.Checked Then
                If My.Settings.DBServerIPAddress.Contains(".\") Or My.Settings.DBServerIPAddress.Contains("\") Then
                    TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & ";Database=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                Else
                    TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & "," & My.Settings.DBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                End If
            Else
                If My.Settings.LocalDBServerIPAddress.Contains(".\") Or My.Settings.LocalDBServerIPAddress.Contains("\") Then
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & ";Database=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                Else
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & "," & My.Settings.LocalDBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                End If
            End If

            Dim Conn As New SqlClient.SqlConnection(TheConnectionstring)

            Dim Query As String

            If SearchDateFieldComboBox.Text = "" Then
                Query = " SELECT * FROM " & TableName
            Else
                Query = " SELECT * FROM " & TableName
            End If

            If SearchDateFieldComboBox.Text <> "" Then
                Query = Query & " WHERE " & SearchDateFieldComboBox.Text & " BETWEEN '" & StartDateTimePicker.DateTime.ToString("yyyy-MM-dd") & "' AND '" & EndDateTimePicker.DateTime.ToString("yyyy-MM-dd") & "'"
            End If

            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            MyReportTable.Rows.Clear()

            If MyReportTable.Columns.Count > 0 Then
                MyReportTable.Columns.Clear()
            End If

            ConTableAdapter.Fill(MyReportTable)

            SyncDataGridView.DataSource = Nothing

            If GridView1.Columns.Count > 0 Then
                GridView1.Columns.Clear()
            End If

            lblNoofRecords.Text = MyReportTable.Rows.Count & " Record(s) Found.."
            SyncDataGridView.DataSource = MyReportTable

            If MyReportTable.Rows.Count > 0 Then
                cmdStart.Enabled = True
            Else
                cmdStart.Enabled = False
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub TablesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TablesComboBox.SelectedIndexChanged
        PrepareSearchCombobx()
        'LoadRecords(TablesComboBox.Text)

    End Sub


    Private Sub radPull_CheckedChanged(sender As Object, e As EventArgs) Handles radPull.CheckedChanged
        'LoadRecords(TablesComboBox.Text)
        CheckSyncAccess()

    End Sub

    Private Function GetPrimaryKey(ByVal TableName As String, ByVal DatabaseName As String) As String
        Try
            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT * FROM " & DatabaseName & ".INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE TABLE_NAME = '" & TableName & "' AND CONSTRAINT_NAME LIKE '%PK%'"

            Dim MyTable As New DataTable

            Dim conTableAdapter As New SqlDataAdapter(Query, Conn)
            conTableAdapter.Fill(MyTable)

            If MyTable.Rows.Count > 0 Then
                Return MyTable.Rows(0).Item("COLUMN_NAME")
            Else
                Return ""
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click

        If MessageBox.Show("ARE YOU SURE YOU WANT TO START THE SYNCHONIZATION PROCESS?", "Sync Process", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            If radUpdate.Checked Then
                Operation = "Update"
            ElseIf radDelete.Checked
                Operation = "Delete"
            Else
                Operation = "Ignore"
            End If

            If radPush.Checked Then
                TheSyncType = "Push"
            Else
                TheSyncType = "Pull"
            End If

            TablesToSync.Clear()

            If radEntireDatabase.Checked Then
                For Each item In TablesComboBox.Properties.Items
                    TablesToSync.Add(item)
                Next
            Else
                TablesToSync.Add(TablesComboBox.Text)
            End If

            'TheTableName = TablesComboBox.Text
            TotalNoofRecords = 0

            For Each TheTableName In TablesToSync
                TotalNoofRecords += GetTotalNoofRecords(TheTableName)
            Next

            EntireDatabaseCondition = radEntireDatabase.Checked
            DateField = SearchDateFieldComboBox.Text
            StartDate = StartDateTimePicker.DateTime
            EndDate = EndDateTimePicker.DateTime

            TotalSynced = 0
            TotalSyncedDuplicates = 0
            TotalForeignSynced = 0
            TotalForeignSyncedDuplicates = 0
            ProgressPanelSync.Caption = "Synching.."
            ProgressPanelSync.Description = "Initializing.."
            ProgressPanelSync.Show()

            If SyncBackgroundWorker.IsBusy Then
                MessageBox.Show("Sync is progress. Click on the Progress Windows to cancel the current operation.", "In Progress", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub
            Else
                SyncBackgroundWorker.RunWorkerAsync()
            End If

            If radPush.Checked Then
                If My.Settings.DBServerIPAddress.Contains(".\") Or My.Settings.DBServerIPAddress.Contains("\") Then
                    TheSyncConnectionString = "Data Source=" & My.Settings.DBServerIPAddress & ";Database=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                Else
                    TheSyncConnectionString = "Data Source=" & My.Settings.DBServerIPAddress & "," & My.Settings.DBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                End If
            Else
                If My.Settings.LocalDBServerIPAddress.Contains(".\") Or My.Settings.LocalDBServerIPAddress.Contains("\") Then
                    TheSyncConnectionString = "Data Source=" & My.Settings.LocalDBServerIPAddress & ";Database=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                Else
                    TheSyncConnectionString = "Data Source=" & My.Settings.LocalDBServerIPAddress & "," & My.Settings.LocalDBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                End If
            End If

        End If


    End Sub

    Private Function ValidateID(ByVal RecordID As String, ByVal TableName As String, ByVal PrimaryKey As String) As Boolean
        Try
            Dim TheConnectionstring As String = ""

            If TheSyncType = "Push" Then
                If My.Settings.DBServerIPAddress.Contains(".\") Or My.Settings.DBServerIPAddress.Contains("\") Then
                    TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & ";Database=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                Else
                    TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & "," & My.Settings.DBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                End If
            Else
                If My.Settings.LocalDBServerIPAddress.Contains(".\") Or My.Settings.LocalDBServerIPAddress.Contains("\") Then
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & ";Database=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                Else
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & "," & My.Settings.LocalDBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                End If
            End If

            Dim Conn As New SqlClient.SqlConnection(TheConnectionstring)

            Dim Query As String = "SELECT Count(*) FROM " & TableName & " WHERE " & PrimaryKey & " = '" & RecordID & "'"
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

    'Private Function GetData(ByVal Tablename As String, ByVal FKey As String, ByVal FKeyValue As String) As DataTable
    '    Try
    '        Dim TheConnectionstring As String = ""

    '        If TheSyncType = "Pull" Then
    '            If My.Settings.DBServerIPAddress.Contains(".\") Or My.Settings.DBServerIPAddress.Contains("\") Then
    '                TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & ";Database=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
    '            Else
    '                TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & "," & My.Settings.DBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
    '            End If
    '        Else
    '            If My.Settings.LocalDBServerIPAddress.Contains(".\") Or My.Settings.LocalDBServerIPAddress.Contains("\") Then
    '                TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & ";Database=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
    '            Else
    '                TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & "," & My.Settings.LocalDBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
    '            End If
    '        End If

    '        Dim Conn As New SqlClient.SqlConnection(TheConnectionstring)

    '        Dim Query As String = " SELECT * FROM " & Tablename

    '        If FKey <> "" Then
    '            Query = Query & " WHERE " & FKey & " = '" & FKeyValue & "'"
    '        End If

    '        Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

    '        Dim MyTable As New DataTable

    '        ConTableAdapter.Fill(MyTable)

    '        Return MyTable

    '    Catch Ex As Exception
    '        MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Function

    Private Function GetData(ByVal Tablename As String, ByVal FKey As String, ByVal FKeyValue As String, ByVal Optional DateField As String = "", ByVal Optional StartDate As DateTime = Nothing, ByVal Optional EndDate As DateTime = Nothing) As DataTable
        Try
            Dim TheConnectionstring As String = ""

            If TheSyncType = "Pull" Then
                If My.Settings.DBServerIPAddress.Contains(".\") Or My.Settings.DBServerIPAddress.Contains("\") Then
                    TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & ";Database=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                Else
                    TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & "," & My.Settings.DBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                End If
            Else
                If My.Settings.LocalDBServerIPAddress.Contains(".\") Or My.Settings.LocalDBServerIPAddress.Contains("\") Then
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & ";Database=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                Else
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & "," & My.Settings.LocalDBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                End If
            End If

            Dim Conn As New SqlClient.SqlConnection(TheConnectionstring)

            Dim Query As String = " SELECT * FROM " & Tablename

            If FKey <> "" Then
                Query = Query & " WHERE " & FKey & " = '" & FKeyValue & "'"
            End If

            If DateField <> "" Then
                If Query.Contains("WHERE") Then
                    Query = Query & " AND " & DateField & " BETWEEN '" & StartDate.ToString("yyyy-MM-dd") & "' AND '" & EndDate.ToString("yyyy-MM-dd") & "'"
                Else
                    Query = Query & " WHERE " & DateField & " BETWEEN '" & StartDate.ToString("yyyy-MM-dd") & "' AND '" & EndDate.ToString("yyyy-MM-dd") & "'"
                End If
            End If

            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MyTable As New DataTable

            ConTableAdapter.Fill(MyTable)

            Return MyTable

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function GetTotalNoofRecords(ByVal TableName As String) As Integer
        Try
            Dim TheConnectionstring As String = ""

            If TheSyncType = "Pull" Then
                If My.Settings.DBServerIPAddress.Contains(".\") Or My.Settings.DBServerIPAddress.Contains("\") Then
                    TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & ";Database=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                Else
                    TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & "," & My.Settings.DBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                End If
            Else
                If My.Settings.LocalDBServerIPAddress.Contains(".\") Or My.Settings.LocalDBServerIPAddress.Contains("\") Then
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & ";Database=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                Else
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & "," & My.Settings.LocalDBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                End If
            End If

            Dim Conn As New SqlClient.SqlConnection(TheConnectionstring)

            Dim Query As String = "SELECT Count(*) FROM " & TableName
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Conn.Open()
            Dim Recordcount As Integer = ConCommand.ExecuteScalar
            Conn.Close()

            Return Recordcount

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    Private Function InsertForeignData(ByVal Tablename As String, ByVal FKey As String, ByVal FKeyValue As String) As Boolean
        Try
            Dim TheConnectionstring As String = ""

            If TheSyncType = "Push" Then
                If My.Settings.DBServerIPAddress.Contains(".\") Or My.Settings.DBServerIPAddress.Contains("\") Then
                    TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & ";Database=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                Else
                    TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & "," & My.Settings.DBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                End If
            Else
                If My.Settings.LocalDBServerIPAddress.Contains(".\") Or My.Settings.LocalDBServerIPAddress.Contains("\") Then
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & ";Database=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                Else
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & "," & My.Settings.LocalDBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                End If
            End If

            Dim thepk As String = GetPrimaryKey(Tablename, DatabaseName)

            If thepk <> "" Then

                Dim TheForeignRecords As DataTable = GetData(Tablename, FKey, FKeyValue)
                Dim allupdatefields As String = ""

                'Dim PKIdentityCondition As Boolean = ValidateIdentityFieldCondition(Tablename, thepk)

                For Each column As DataColumn In TheForeignRecords.Columns
                    If Not ValidateIdentityFieldCondition(Tablename, column.ColumnName) Then
                        If allupdatefields = "" Then
                            allupdatefields = column.ColumnName & " = @" & column.ColumnName
                        Else
                            allupdatefields = allupdatefields & ", " & column.ColumnName & " = @" & column.ColumnName
                        End If
                    End If
                Next

                Dim allfields As String = ""
                Dim allparameterfields As String = ""

                For Each column As DataColumn In TheForeignRecords.Columns
                    If Not ValidateIdentityFieldCondition(Tablename, column.ColumnName) Then
                        If allfields = "" Then
                            allfields = column.ColumnName
                        Else
                            allfields = allfields & ", " & column.ColumnName
                        End If
                    End If
                Next

                For Each column As DataColumn In TheForeignRecords.Columns
                    If Not ValidateIdentityFieldCondition(Tablename, column.ColumnName) Then
                        If allparameterfields = "" Then
                            allparameterfields = "@" & column.ColumnName
                        Else
                            allparameterfields = allparameterfields & ", @" & column.ColumnName
                        End If
                    End If

                Next

                'WORKING ON THE FOREIGN KEYS RELATIONSHIP CHECKS
                Dim AllForeignKeys As New ArrayList
                Dim thekeys As String = GatherAllForeignKeysforRelatedTable(Tablename)
                Dim TheKeysplit As String() = thekeys.Trim.Split(",")

                For Each kitem In TheKeysplit
                    If kitem <> "" Then
                        AllForeignKeys.Add(kitem)
                    End If
                Next
 
                For Each item In TheForeignRecords.Rows
                    If SyncBackgroundWorker.CancellationPending() Then
                        Exit Function
                    End If

                    TotalForeignSynced += 1

                    Try
                        Dim continuecondition As Boolean = False

                        If Operation = "Ignore" Then
                            If Not ValidateID(item(thepk), Tablename, thepk) Then

                                For each TheKeyItem In AllForeignKeys
                                    Dim split1 As String() = TheKeyItem.ToString.Split(":")
                                    Dim thetablename As String =Split1(1)
                                    Dim thefkey As String = Split1(0)

                                    If Not ValidateID(item(thefkey), thetablename, thefkey) Then
                                        InsertForeignData(thetablename, thefkey,item(thefkey))
                                    End If
                                Next

                                Dim Conn As New SqlClient.SqlConnection(TheSyncConnectionString)
                                Dim Query As String = ""

                                Query = "INSERT INTO " & Tablename & " (" & allfields & ") VALUES (" & allparameterfields & ")"
                                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                                With ConCommand.Parameters
                                    For Each column As DataColumn In TheForeignRecords.Columns
                                        ConCommand.Parameters.AddWithValue("@" & column.ColumnName, item(column.ColumnName))
                                    Next
                                End With

                                Conn.Open()
                                ConCommand.ExecuteNonQuery()
                                Conn.Close()
                            Else
                                TotalForeignSyncedDuplicates += 1
                            End If
                        ElseIf Operation = "Update" Then
                            If Not ValidateID(item(thepk), Tablename, thepk) Then
                                Dim Conn As New SqlClient.SqlConnection(TheSyncConnectionString)
                                Dim Query As String = ""

                                Query = "INSERT INTO " & Tablename & " (" & allfields & ") VALUES (" & allparameterfields & ")"
                                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                                With ConCommand.Parameters
                                    For Each column As DataColumn In TheForeignRecords.Columns
                                        ConCommand.Parameters.AddWithValue("@" & column.ColumnName, item(column.ColumnName))
                                    Next
                                End With

                                Conn.Open()
                                ConCommand.ExecuteNonQuery()
                                Conn.Close()
                            Else
                                Dim Conn As New SqlClient.SqlConnection(TheSyncConnectionString)
                                Dim Query As String = ""

                                Query = "UPDATE " & Tablename & " SET " & allupdatefields & " WHERE " & thepk & " = '" & item(thepk) & "'"
                                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                                With ConCommand.Parameters
                                    For Each column As DataColumn In TheForeignRecords.Columns
                                        ConCommand.Parameters.AddWithValue("@" & column.ColumnName, item(column.ColumnName))
                                    Next
                                End With

                                Conn.Open()
                                ConCommand.ExecuteNonQuery()
                                Conn.Close()

                                TotalForeignSyncedDuplicates += 1
                            End If
                        ElseIf Operation = "Delete" Then
                            If Not ValidateID(item(thepk), Tablename, thepk) Then
                                Dim Conn As New SqlClient.SqlConnection(TheSyncConnectionString)
                                Dim Query As String = ""

                                Query = "INSERT INTO " & Tablename & " (" & allfields & ") VALUES (" & allparameterfields & ")"
                                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                                With ConCommand.Parameters
                                    For Each column As DataColumn In TheForeignRecords.Columns
                                        ConCommand.Parameters.AddWithValue("@" & column.ColumnName, item(column.ColumnName))
                                    Next
                                End With

                                Conn.Open()
                                ConCommand.ExecuteNonQuery()
                                Conn.Close()
                            Else
                                Dim Conn As New SqlClient.SqlConnection(TheSyncConnectionString)
                                Dim Query As String = ""

                                Query = "DELETE FROM " & Tablename & " WHERE " & thepk & " = '" & item(thepk) & "'"
                                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                                Conn.Open()
                                ConCommand.ExecuteNonQuery()
                                Conn.Close()

                                TotalForeignSyncedDuplicates += 1
                            End If
                        End If

                        SyncBackgroundWorker.ReportProgress(1)

                    Catch ex As Exception
                        MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                Next

            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Sub SyncBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles SyncBackgroundWorker.DoWork
        For Each TheTableName In TablesToSync
            Dim thepk As String = GetPrimaryKey(TheTableName, DatabaseName)

            If thepk <> "" Then

                Dim allupdatefields As String = ""

                Dim MySingleTable As New DataTable

                If Not EntireDatabaseCondition Then
                    MySingleTable = GetData(TheTableName, "", "", DateField, StartDate, EndDate)
                Else
                    MySingleTable = GetData(TheTableName, "", "")
                End If

                'Dim PKIdentityCondition As Boolean = ValidateIdentityFieldCondition(TheTableName, thepk)

                For Each column As DataColumn In MySingleTable.Columns
                    If Not ValidateIdentityFieldCondition(TheTableName, column.ColumnName) Then
                        If allupdatefields = "" Then
                            allupdatefields = column.ColumnName & " = @" & column.ColumnName
                        Else
                            allupdatefields = allupdatefields & ", " & column.ColumnName & " = @" & column.ColumnName
                        End If
                    End If
                Next

                Dim allfields As String = ""
                Dim allparameterfields As String = ""

                For Each column As DataColumn In MySingleTable.Columns
                    If Not ValidateIdentityFieldCondition(TheTableName, column.ColumnName) Then
                        If allfields = "" Then
                            allfields = column.ColumnName
                        Else
                            allfields = allfields & ", " & column.ColumnName
                        End If
                    End If
                Next

                For Each column As DataColumn In MySingleTable.Columns
                    If Not ValidateIdentityFieldCondition(TheTableName, column.ColumnName) Then
                        If allparameterfields = "" Then
                            allparameterfields = "@" & column.ColumnName
                        Else
                            allparameterfields = allparameterfields & ", @" & column.ColumnName
                        End If
                    End If

                Next


                Dim AllRelatedTables As String = GetAllTablesRelatedTo(TheTableName)
                Dim TheRelatedSplit As String() = AllRelatedTables.Trim.Split(",")

                For Each item In MySingleTable.Rows
                    If SyncBackgroundWorker.CancellationPending() Then

                        Exit Sub
                    End If

                    TotalSynced += 1

                    If Operation = "Delete" Then
                        For Each table In TheRelatedSplit
                            If table <> "" Then
                                InsertForeignData(table, thepk, item(thepk))
                            End If
                        Next
                    End If

                    Try
                        Dim continuecondition As Boolean = False

                        If Operation = "Ignore" Then
                            If Not ValidateID(item(thepk), TheTableName, thepk) Then
                                Dim Conn As New SqlClient.SqlConnection(TheSyncConnectionString)
                                Dim Query As String = ""

                                Query = "INSERT INTO " & TheTableName & " (" & allfields & ") VALUES (" & allparameterfields & ")"
                                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                                With ConCommand.Parameters
                                    For Each column As DataColumn In MySingleTable.Columns
                                        ConCommand.Parameters.AddWithValue("@" & column.ColumnName, item(column.ColumnName))
                                    Next
                                End With

                                Conn.Open()
                                ConCommand.ExecuteNonQuery()
                                Conn.Close()
                            Else
                                TotalSyncedDuplicates += 1
                            End If
                        ElseIf Operation = "Update" Then
                            If Not ValidateID(item(thepk), TheTableName, thepk) Then
                                Dim Conn As New SqlClient.SqlConnection(TheSyncConnectionString)
                                Dim Query As String = ""

                                Query = "INSERT INTO " & TheTableName & " (" & allfields & ") VALUES (" & allparameterfields & ")"
                                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                                With ConCommand.Parameters
                                    For Each column As DataColumn In MySingleTable.Columns
                                        ConCommand.Parameters.AddWithValue("@" & column.ColumnName, item(column.ColumnName))
                                    Next
                                End With

                                Conn.Open()
                                ConCommand.ExecuteNonQuery()
                                Conn.Close()
                            Else
                                Dim Conn As New SqlClient.SqlConnection(TheSyncConnectionString)
                                Dim Query As String = ""

                                Query = "UPDATE " & TheTableName & " SET " & allupdatefields & " WHERE " & thepk & " = '" & item(thepk) & "'"
                                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                                With ConCommand.Parameters
                                    For Each column As DataColumn In MySingleTable.Columns
                                        ConCommand.Parameters.AddWithValue("@" & column.ColumnName, item(column.ColumnName))
                                    Next
                                End With

                                Conn.Open()
                                ConCommand.ExecuteNonQuery()
                                Conn.Close()

                                TotalSyncedDuplicates += 1
                            End If
                        ElseIf Operation = "Delete" Then
                            If Not ValidateID(item(thepk), TheTableName, thepk) Then
                                Dim Conn As New SqlClient.SqlConnection(TheSyncConnectionString)
                                Dim Query As String = ""

                                Query = "INSERT INTO " & TheTableName & " (" & allfields & ") VALUES (" & allparameterfields & ")"
                                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                                With ConCommand.Parameters
                                    For Each column As DataColumn In MySingleTable.Columns
                                        ConCommand.Parameters.AddWithValue("@" & column.ColumnName, item(column.ColumnName))
                                    Next
                                End With

                                Conn.Open()
                                ConCommand.ExecuteNonQuery()
                                Conn.Close()
                            Else
                                Dim Conn As New SqlClient.SqlConnection(TheSyncConnectionString)
                                Dim Query As String = ""

                                Query = "DELETE FROM " & TheTableName & " WHERE " & thepk & " = '" & item(thepk) & "'"
                                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                                Conn.Open()
                                ConCommand.ExecuteNonQuery()
                                Conn.Close()

                                TotalSyncedDuplicates += 1
                            End If
                        End If

                        If Operation <> "Delete" Then
                            For Each table In TheRelatedSplit
                                If table <> "" Then
                                    InsertForeignData(table, thepk, item(thepk))
                                End If
                            Next
                        End If

                        SyncBackgroundWorker.ReportProgress(1)

                    Catch ex As Exception
                        MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try


                Next

            Else
                MessageBox.Show("Table " & TheTableName & " does not have a primary key. Please set a primary key for the table. Data in this table will not be synchronize in this process.", "No Primary Key", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Next


    End Sub


    Private Sub SyncBackgroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles SyncBackgroundWorker.ProgressChanged
        ProgressPanelSync.Caption = "Synching. Please wait.."
        Dim Percentage As Single = ((TotalSynced / TotalNoofRecords) * 100).ToString("n2")
        ProgressPanelSync.Description = "Synching: " & TotalSynced & "/" & TotalNoofRecords & " (" & Percentage & "%)   Duplicates: " & TotalSyncedDuplicates & " [Related Records: " & TotalForeignSynced & ", Duplicates: " & TotalForeignSyncedDuplicates & "]"

    End Sub


    Private Sub SyncBackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles SyncBackgroundWorker.RunWorkerCompleted
        ProgressPanelSync.Caption = "Synchronization Complete"

    End Sub


    Private Sub ProgressPanelSync_Click(sender As Object, e As EventArgs) Handles ProgressPanelSync.Click
        If SyncBackgroundWorker.IsBusy Then
            If MessageBox.Show("Do you wish to cancel the sync?", "Canceling", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                SyncBackgroundWorker.CancelAsync()
            End If
        Else
            ProgressPanelSync.Hide()
        End If

    End Sub


    Private Function ValidateIdentityFieldCondition(ByVal TableName As String, ByVal ColumnName As String) As Boolean
        Try
            Dim TheConnectionstring As String = ""
            Dim TheDatabaseName As String = ""

            If TheSyncType = "Push" Then
                If My.Settings.DBServerIPAddress.Contains(".\") Or My.Settings.DBServerIPAddress.Contains("\") Then
                    TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & ";Database=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                Else
                    TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & "," & My.Settings.DBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
                End If

                TheDatabaseName = My.Settings.DBDatabaseName
            Else
                If My.Settings.LocalDBServerIPAddress.Contains(".\") Or My.Settings.LocalDBServerIPAddress.Contains("\") Then
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & ";Database=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                Else
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & "," & My.Settings.LocalDBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                End If

                TheDatabaseName = My.Settings.LocalDBDatabaseName
            End If

            Dim Conn As New SqlClient.SqlConnection(TheConnectionstring)

            Dim Query As String = "select COLUMN_NAME, TABLE_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_SCHEMA = 'dbo' and COLUMNPROPERTY(object_id(TABLE_NAME), COLUMN_NAME, 'IsIdentity') = 1 AND TABLE_NAME = '" & TableName & "' AND COLUMN_NAME = '" & ColumnName & "'"
            Dim MYtABLE As New DataTable
            Dim ContableAdpater As New SqlClient.SqlDataAdapter(Query, Conn)

            ContableAdpater.Fill(MYtABLE)

            If MYtABLE.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


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



    Private Sub PrepareSearchCombobx()
        Try
            SearchDateFieldComboBox.Properties.Items.Clear()
            SearchDateFieldComboBox.Text = ""

            Dim Allfields As String = GetAllFields(TablesComboBox.Text, DatabaseName)
            Dim splitfields As String() = Allfields.Trim.Split(",")

            Dim QueryString As String = ""

            For Each field In splitfields

                Dim ColumnType As String = GetColumnDataType(TablesComboBox.Text, field).ToUpper

                If ColumnType.Contains("DATE") Then
                    SearchDateFieldComboBox.Properties.Items.Add(field)
                End If

            Next

            'If SearchDateFieldComboBox.Properties.Items.Count > 0 Then
            '    SearchDateFieldComboBox.SelectedIndex = 0
            'End If

            StartDateTimePicker.DateTime = DateTime.Today
            EndDateTimePicker.DateTime = DateTime.Today
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        LoadRecords(TablesComboBox.Text)

    End Sub


    Private Sub radUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles radUpdate.CheckedChanged
        If radUpdate.Checked Then
            If MessageBox.Show("You have chose to Update records when a duplicate is detected. ARE YOU SURE THIS IS WHAT YOU WANT TO DO?", "Updating Records", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                radIgnore.Checked = True
            End If
        End If

    End Sub


    Private Sub radDelete_CheckedChanged(sender As Object, e As EventArgs) Handles radDelete.CheckedChanged
        If radDelete.Checked Then
            If MessageBox.Show("WARNING!! You have chose to Delete records from the destination database when they are detected. ARE YOU SURE THIS IS WHAT YOU WANT TO DO?", "Deleting Records", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                radIgnore.Checked = True
            End If
        End If

    End Sub


    'Private Sub cmdDateSearch_Click(sender As Object, e As EventArgs) Handles cmdDateSearch.Click
    '    If SearchDateFieldComboBox.SelectedIndex <> -1 Then
    '        Try
    '            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

    '            Dim Query As String = " SELECT ID,ElectionYear,Region,District,Constituency,Ward,CentreNo,Station,Election,Party,TotalVotes,RegDate,InputedBy FROM PoolingStationVotes WHERE " & SearchDateFieldComboBox.Text & " BETWEEN '" & StartDateTimePicker.DateTime.ToString("yyy-MM-dd") & "' AND '" & EndDateTimePicker.DateTime.ToString("yyyy-MM-dd") & "' ORDER BY ID DESC "
    '            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

    '            Dim MyTable As New DataTable
    '            ConTableAdapter.Fill(MyTable)

    '            If MyTable.Rows.Count > 0 Then
    '                MyReportTable.Rows.Clear()
    '                MyReportTable = MyTable.Copy()

    '                PoolingStationVotesDataGridView.DataSource = MyReportTable
    '                Me.PanelNew.Visible = False

    '                isDateSearchUsed = True
    '                MessageBox.Show("Search Complete. " & MyTable.Rows.Count & " record(s) found.", "Search Complete", MessageBoxButtons.OK, MessageBoxIcon.Warning)

    '                'If MyReportTable.Rows.Count > 0 Then
    '                'DisplayRecordInfo(MyReportTable.Rows(0).Item("ID"))
    '                'End If
    '            Else
    '                MessageBox.Show("No Record was found matching the search criteria. Please verify and try again.", "Empty Result", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            End If


    '        Catch Ex As Exception
    '            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    Else
    '        MessageBox.Show("Please select the Date condition you wish to use and specify the start and end date criteria", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End If


    'End Sub

#End Region

    Private Function GetAllTablesRelatedTo(ByVal TheTable As String) As String
        'THIS METHOD GATHERS ALL TABLES THAT HAVE A FOREIGN KEY REFERENCING THE TABLE SPECIFIED IN THE PARAMETER ABOVE
        ' --------------------------------------------------------------------------------------------------------

        Try
            Dim ThePrimaryKey As String = GetPrimaryKey(TheTable, DatabaseName)

            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            'Dim Query As String = "SELECT TABLE_NAME,COLUMN_NAME FROM " & txtDatabaseName.Text & ".INFORMATION_SCHEMA.COLUMNS WHERE COLUMN_NAME = '" & ThePrimaryKey & "' AND TABLE_NAME NOT LIKE '%VIEW%'"
            Dim Query As String = "Use " & DatabaseName & "; Select object_name(rkeyid) Parent_Table,object_name(fkeyid) Child_Table,object_name(constid) FKey_Name,c1.name FKey_Col,c2.name Ref_KeyCol From sys.sysforeignkeys s Inner join sys.syscolumns c1	on ( s.fkeyid = c1.id And s.fkey = c1.colid ) Inner join syscolumns c2	on ( s.rkeyid = c2.id And s.rkey = c2.colid ) Order by Parent_Table,Child_Table"

            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MyTable As New DataTable

            ConTableAdapter.Fill(MyTable)

            Dim FullTables As String = ""

            If MyTable.Rows.Count > 0 Then

                For Each Record In MyTable.Rows
                    If Record("Parent_Table").ToString = TheTable Then
                        If FullTables = "" Then
                            FullTables = Record("Child_Table").ToString
                        Else
                            FullTables += "," & Record("Child_Table").ToString
                        End If
                    End If
                Next

            End If

            Return FullTables
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function


    Public Function GatherAllForeignKeysforRelatedTable(ByVal TheTable As String) As String
        'THIS METHOD GATHERS ALL FOREIGN KEYS FOR A PARTICULAR TABLE (TheTable) AND CONSTRUCTS A STRING OF THE KEYS
        ' --------------------------------------------------------------------------------------------------------
        'THIS METHOD SOMETIMES RETURNS THE NAME INCOMPLETE eg. FK__SchoolTer__schoo__4B973090

        Dim FullStringofForeignKeys As String
        Dim OnlyForeignKeys As New ArrayList

        If TheTable.Contains("_") Then
            FullStringofForeignKeys = ""
            OnlyForeignKeys.Clear()
            Exit Function
        End If

        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT * FROM " & DatabaseName & ".INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE CONSTRAINT_NAME LIKE 'FK%' AND TABLE_NAME = '" & TheTable & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim MyTable As New DataTable

            ConTableAdapter.Fill(MyTable)

            FullStringofForeignKeys = ""
            OnlyForeignKeys.Clear()

            If MyTable.Rows.Count > 0 Then

                For Each Record In MyTable.Rows
                    If Record("CONSTRAINT_NAME").ToString.Contains("FK__") = False Then

                        Dim SplitValue As String() = Record("CONSTRAINT_NAME").ToString.Trim.Split("_")

                        'Dim TheOuterForeignKeyTable As String = CheckforForeignKeyTable(TheTable)
                        Dim TheFTable As String = SplitValue(2)

                        Dim FullString As String = Nothing
                        Dim Splitchar As Char() = TheFTable.ToCharArray

                        For Each TheChar In Splitchar
                            If IsNumeric(TheChar) = False Then
                                FullString += TheChar.ToString
                            End If
                        Next

                        'OutertablePrimaryKey_OutTableName_LocalColumnName
                        'eg. DefendantID_Defendant_TheDefendantID

                        If FullString <> "" Then
                            If FullStringofForeignKeys = "" Then
                                FullStringofForeignKeys = GetPrimaryKey(FullString, DatabaseName) & ":" & FullString '& ":" & TheTable
                                OnlyForeignKeys.Add(GetPrimaryKey(FullString, DatabaseName))
                            Else
                                FullStringofForeignKeys += "," & GetPrimaryKey(FullString, DatabaseName) & ":" & FullString '& ":" & TheTable
                                OnlyForeignKeys.Add(GetPrimaryKey(FullString, DatabaseName))
                            End If
                        End If

                    End If

                Next

            Else
                FullStringofForeignKeys = ""
            End If

            Return FullStringofForeignKeys

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try

    End Function


    Private Sub radEntireDatabase_CheckedChanged(sender As Object, e As EventArgs) Handles radEntireDatabase.CheckedChanged
        If radEntireDatabase.Checked Then
            TablesComboBox.Enabled = False
            chkDateFilter.Checked = False

            cmdStart.Enabled = True
            cmdSearch.Enabled = False

            SearchDateFieldComboBox.Text = ""
        Else
            TablesComboBox.Enabled = True

            If MyReportTable.Rows.Count > 0 Then
                cmdStart.Enabled = False
            End If

            cmdSearch.Enabled = True
        End If

    End Sub


    Private Sub chkDateFilter_CheckedChanged(sender As Object, e As EventArgs) Handles chkDateFilter.CheckedChanged
        If chkDateFilter.Checked Then
            SearchDateFieldComboBox.Enabled = True
            StartDateTimePicker.Enabled = True
            EndDateTimePicker.Enabled = True
        Else
            SearchDateFieldComboBox.Text = ""
            SearchDateFieldComboBox.Enabled = False
            StartDateTimePicker.Enabled = False
            EndDateTimePicker.Enabled = False
        End If

    End Sub
End Class
