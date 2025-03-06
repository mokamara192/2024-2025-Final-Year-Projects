Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Public Class frmImports

    Dim NotUploadedDataTable As New DataTable
    Dim CorrectList As New ComboBox
    Dim FilterTable As New DataTable
    Dim UploadTable As New DataTable
    Dim ExcellFileName As String
    Dim ImportInsertQuery As String
    Dim ImportValidationQuery As String

    Dim DuplicateRecords As Integer = 0

    Dim IsPrimaryKeyIncluded As Boolean
    Dim PrimaryKey As String
    Dim AlltheFieldsintheTable As New ComboBox
    Dim AllParameters As String
    Dim CurrentRecord As Integer
    Dim DPrimaryKeyforImportation As String
    Dim TheTableName As String
    Dim DForeignKeyforImportation As String
    Dim DForeignKeyTable As String
    Dim isPrimaryKeyConstratintChecked As Boolean
    Dim DExcellFieldRepresentintthePK As String
 
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer





    Private Sub PanelTop_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) 'Handles PanelHeader.MouseDown

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





    Private Sub PanelTop2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelHeader2.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If




    End Sub




    Private Sub PanelTop2_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelHeader2.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If


    End Sub




    Private Sub PanelTop2_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelHeader2.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.PanelRemap.Location.X + (e.X - MouseDownX)
            temp.Y = Me.PanelRemap.Location.Y + (e.Y - MouseDownY)
            Me.PanelRemap.Location = temp
            temp = Nothing
        End If


    End Sub



    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        Try
            Dim OFD1 As New OpenFileDialog
            Dim TotalFileSize As Single = Nothing

            OFD1.Filter = "ODK File|*.xlsx;*.xls"
            OFD1.FileName = ""
            OFD1.Multiselect = False

            If OFD1.ShowDialog = System.Windows.Forms.DialogResult.OK Then

                txtExcellPath.Text = OFD1.FileName
                FileName = OFD1.FileName
                ExcellFileName = OFD1.FileName

                If NotUploadedDataTable.Rows.Count > 0 Then
                    NotUploadedDataTable.Rows.Clear()
                End If

                If NotUploadedDataTable.Columns.Count > 0 Then
                    NotUploadedDataTable.Columns.Clear()
                End If

                ImportDataGridView.DataSource = Nothing

                LoadingExcellBackgroundWorker.RunWorkerAsync()

                If cboTableName.SelectedIndex <> -1 Then
                    cmdColumnMapper.Enabled = True
                Else
                    cmdColumnMapper.Enabled = False
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Public Sub LoadTables() Handles Me.Load

        Me.PanelNotLoaded.Location = New Point((frmDashboardNew.Width / 3) + 15, (frmDashboardNew.Height / 3) + 20)

        Try
            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT TABLE_NAME FROM " & DatabaseName & ".INFORMATION_SCHEMA.tables WHERE TABLE_TYPE NOT LIKE '%VIEW%' AND TABLE_NAME NOT LIKE 'MainLogin' AND TABLE_NAME NOT LIKE 'tblUserLog' ORDER BY TABLE_NAME ASC"
            Dim MyTable As New DataTable

            Dim conTableAdapter As New SqlDataAdapter(Query, Conn)
            conTableAdapter.Fill(MyTable)

            cboTableName.Items.Clear()
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

        ResetValidateDataGridView()


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

            cboDatabaseField.Items.Clear()
            AlltheFieldsintheTable.Items.Clear()

            If MyTable.Rows.Count > 0 Then
                For Each Record In MyTable.Rows
                    Dim ColumnType As String = GetColumnDataTypeByThePrimaryKey(CorrectList.Items(cboTableName.SelectedIndex), Record("COLUMN_NAME")).ToString.ToUpper

                    If Not ColumnType.Contains("BINARY") And Not ColumnType.Contains("IMAGE") Then
                        cboDatabaseField.Items.Add(Record("COLUMN_NAME"))
                        AlltheFieldsintheTable.Items.Add(Record("COLUMN_NAME"))
                    End If

                Next
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub



    Private Sub cmdAutoMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAutoMap.Click

A:
        For Each record In cboDatabaseField.Items
            For Each recordexcell In cboExcellField.Items
                If recordexcell = record Then
                    RemapingDataGridView.Rows.Add(record, recordexcell)
                    cboDatabaseField.Items.Remove(record)
                    cboExcellField.Items.Remove(recordexcell)
                    GoTo A
                End If
            Next
        Next


    End Sub



    Private Sub RemapColumnsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdColumnMapper.Click
        cboExcellField.Items.Clear()

        For i = 0 To ImportDataGridView.Columns.Count - 1
            cboExcellField.Items.Add(ImportDataGridView.Columns(i).HeaderText)
        Next

        Me.PanelRemap.Visible = True
        Me.PanelRemap.BringToFront()

        cmdImport.Enabled = False
        cmdCancel.Visible = False

        IsPrimaryKeyIncluded = False

        If DForeignKeyforImportation <> "" Then
            cmdValidateForeignkey.Visible = True
            cmdAccept.Enabled = False
        End If

        isPrimaryKeyConstratintChecked = False



    End Sub




    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        If RemapingDataGridView.Rows.Count > 0 Then

            PrimaryKey = GetPrimaryKey(CorrectList.Items(cboTableName.SelectedIndex), DatabaseName)

            Dim FullStringofFieldsinRemap As String = ""
            AllParameters = ""
            Dim ValideQuery As String = ""

            For Each RECORD As DataGridViewRow In RemapingDataGridView.Rows
                For I = 0 To ImportDataGridView.Columns.Count - 1
                    If ImportDataGridView.Columns(I).HeaderText = RECORD.Cells("ExcellField").Value Then
                        ImportDataGridView.Columns(I).HeaderText = RECORD.Cells("DatabaseField").Value
                        ImportDataGridView.Columns(I).Name = RECORD.Cells("DatabaseField").Value

                        If RECORD.Cells("DatabaseField").Value = PrimaryKey Then
                            IsPrimaryKeyIncluded = True
                        End If

                        If FullStringofFieldsinRemap = "" Then
                            FullStringofFieldsinRemap = RECORD.Cells("DatabaseField").Value
                        Else
                            FullStringofFieldsinRemap = FullStringofFieldsinRemap & "," & RECORD.Cells("DatabaseField").Value
                        End If
                    End If
                Next
            Next

            Dim ShortQuery As String = ""
            Dim ValueQuery As String = ""

            For Each DRecord In AlltheFieldsintheTable.Items

                If ShortQuery = "" Then
                    ShortQuery = DRecord
                Else
                    ShortQuery += "," & DRecord
                End If

                If FullStringofFieldsinRemap.Contains(DRecord) Then
                    If ValueQuery = "" Then
                        ValueQuery = "@" & DRecord

                        If AllParameters = "" Then
                            AllParameters = "@" & DRecord
                        Else
                            AllParameters = AllParameters & ",@" & DRecord
                        End If
                    Else
                        ValueQuery += ", @" & DRecord

                        If AllParameters = "" Then
                            AllParameters = "@" & DRecord
                        Else
                            AllParameters = AllParameters & ",@" & DRecord
                        End If

                    End If

                    If ValideQuery = "" Then
                        ValideQuery = DRecord & " = @" & DRecord
                    Else
                        ValideQuery += " AND " & DRecord & " = @" & DRecord
                    End If

                Else
                    Dim ColumnType As String = GetColumnDataTypeByThePrimaryKey(CorrectList.Items(cboTableName.SelectedIndex), DRecord).ToString.ToUpper

                    If DRecord = PrimaryKey Then
                        If ValueQuery = "" Then
                            ValueQuery = "@" & DRecord
                        Else
                            ValueQuery += ", @" & DRecord
                        End If
                    Else
                        If ColumnType.Contains("CHAR") Then
                            If ValueQuery = "" Then
                                ValueQuery = "''"
                            Else
                                ValueQuery += ", ''"
                            End If
                        ElseIf ColumnType.Contains("INT") Then
                            If ValueQuery = "" Then
                                ValueQuery = "0"
                            Else
                                ValueQuery += ", 0"
                            End If
                        ElseIf ColumnType.Contains("DATE") Then
                            If ValueQuery = "" Then
                                ValueQuery = "'1900-01-01'"
                            Else
                                ValueQuery += ", '1900-01-01'"
                            End If
                        ElseIf ColumnType.Contains("IMAGE") Or ColumnType.Contains("BINARY") Then
                            If ValueQuery = "" Then
                                ValueQuery = "NULL"
                            Else
                                ValueQuery += ", NULL"
                            End If
                        ElseIf ColumnType.Contains("TEXT") Then
                            If ValueQuery = "" Then
                                ValueQuery = "''"
                            Else
                                ValueQuery += ", ''"
                            End If
                        ElseIf ColumnType.Contains("MONEY") Then
                            If ValueQuery = "" Then
                                ValueQuery = "0"
                            Else
                                ValueQuery += ", 0"
                            End If
                        ElseIf ColumnType.Contains("DECI") Then
                            If ValueQuery = "" Then
                                ValueQuery = "0"
                            Else
                                ValueQuery += ", 0"
                            End If
                        End If
 
                    End If
 
                End If

            Next

            ImportInsertQuery = "INSERT INTO " & CorrectList.Items(cboTableName.SelectedIndex) & " (" & ShortQuery & ") VALUES (" & ValueQuery & ")"
            ImportValidationQuery = "SELECT COUNT(" & PrimaryKey & ") FROM " & CorrectList.Items(cboTableName.SelectedIndex) & " WHERE " & ValideQuery
 
            Me.PanelRemap.Visible = False
            cmdImport.Enabled = True

        Else
            MessageBox.Show("Please Remap at least one 'Database Fields' to the Excell Worksheet.", "Incomplete Mapping", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub


#Region "LOADING EXCELL BACKGROUNDWORKER"



    Private Sub LoadingExcellBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles LoadingExcellBackgroundWorker.DoWork
        Try
            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter

            Dim MyConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & ExcellFileName & ";Excel 12.0 Xml;HDR=YES"
            MyConnection = New System.Data.OleDb.OleDbConnection(MyConnectionString)
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("Select * from [Sheet$]", MyConnection)
            MyCommand.TableMappings.Add("Table", "Sheet")

            If UploadTable.Rows.Count > 0 Then
                UploadTable.Rows.Clear()
            End If

            If UploadTable.Columns.Count > 0 Then
                UploadTable.Columns.Clear()
            End If

            MyCommand.Fill(UploadTable)
           
            MyConnection.Close()

            LoadingExcellBackgroundWorker.ReportProgress(1)

        Catch ex As Exception
            MessageBox.Show(ex.Message & ". Please make sure that the Sheet in the Excell File is Named: IMPORT")
        End Try


    End Sub



    Private Sub LoadingExcellBackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles LoadingExcellBackgroundWorker.ProgressChanged
        If e.ProgressPercentage = 1 Then

        End If


    End Sub



    Private Sub LoadingExcellBackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadingExcellBackgroundWorker.RunWorkerCompleted

        ImportDataGridView.DataSource = UploadTable
       
        cboExcellField.Items.Clear()

        For i = 0 To ImportDataGridView.Columns.Count - 1
            cboExcellField.Items.Add(ImportDataGridView.Columns(i).HeaderText)
        Next

        If RemapingDataGridView.Rows.Count > 0 Then
            RemapingDataGridView.Rows.Clear()
        End If

        If cboTableName.Items.Count > 0 Then
            cboTableName_SelectedIndexChanged()
        End If

        If cboDatabaseField.SelectedIndex <> -1 Then
            Me.PanelRemap.Visible = True
            Me.PanelRemap.BringToFront()
        End If

        lblNoofRecords.Text = ImportDataGridView.Rows.Count & " Record(s)"
        PanelNotLoaded.Visible = False



    End Sub

#End Region



    Private Sub cboTableName_SelectedIndexChanged() Handles cboTableName.SelectedIndexChanged
        If cboTableName.SelectedIndex <> -1 Then
            LoadFields()
            DPrimaryKeyforImportation = GetPrimaryKey(CorrectList.Items(cboTableName.SelectedIndex), DatabaseName)
             
            DForeignKeyTable = CheckforForeignKeyTable(CorrectList.Items(cboTableName.SelectedIndex))

            If DForeignKeyTable <> "" Then
                DForeignKeyforImportation = GetForeignKey(DForeignKeyTable, DatabaseName)
            Else
                DForeignKeyforImportation = ""
            End If
 
        End If


    End Sub



    Private Sub ResetValidateDataGridView()
        Try
            If ValidationDataGridView.Rows.Count > 0 Then
                ValidationDataGridView.Rows.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ValidationDataGridView.Rows.Add("At least on record", "Not-Validated")
        ValidationDataGridView.Rows.Add("Foreign Key", "Not-Validated")
        ValidationDataGridView.Rows.Add("Foreign Key Condition", "Not-Validated")
        ValidationDataGridView.Rows.Add("Primary Key", "Not-Validated")
        ValidationDataGridView.Rows.Add("Primary Key Condition", "Not-Validated")



    End Sub



    Private Sub cmdNewImport_Click(sender As Object, e As EventArgs) Handles cmdNewImport.Click
        Try
            cboTableName.SelectedIndex = 0
            txtExcellPath.Text = ""
            cboDatabaseField.Items.Clear()
            cboExcellField.Items.Clear()

            UploadTable.Rows.Clear()
            UploadTable.Columns.Clear()
             
            If RemapingDataGridView.Rows.Count > 0 Then
                RemapingDataGridView.Rows.Clear()
            End If
 
            LoadingExcellBackgroundWorker.CancelAsync()

            PanelProgress.Visible = False

            PanelNotLoaded.Visible = True
            ResetValidateDataGridView()

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Private Sub cmdMapColumn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMapColumn.Click
        Try

            If cboDatabaseField.SelectedIndex <> -1 And cboExcellField.SelectedIndex <> -1 Then

                If cboDatabaseField.SelectedItem <> DPrimaryKeyforImportation Then
                    RemapingDataGridView.Rows.Add(cboDatabaseField.SelectedItem, cboExcellField.SelectedItem)

                    cboDatabaseField.Items.RemoveAt(cboDatabaseField.SelectedIndex)
                    cboExcellField.Items.RemoveAt(cboExcellField.SelectedIndex)
                Else

                    'Dim DExcellfield As String = cboExcellField.SelectedItem

                    'For I = 0 To ImportReplicaDatagridview.Columns.Count - 1
                    '    If ImportReplicaDatagridview.Columns(I).HeaderText = DExcellfield Then
                    '        ImportReplicaDatagridview.Columns(I).HeaderText = DPrimaryKeyforImportation
                    '        ImportReplicaDatagridview.Columns(I).Name = DPrimaryKeyforImportation
                    '    End If
                    'Next

                    DExcellFieldRepresentintthePK = cboExcellField.SelectedItem

                    RemapingDataGridView.Rows.Add(cboDatabaseField.SelectedItem, cboExcellField.SelectedItem)

                    cboDatabaseField.Items.RemoveAt(cboDatabaseField.SelectedIndex)
                    cboExcellField.Items.RemoveAt(cboExcellField.SelectedIndex)
                End If


            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Private Sub cmdClosePanelRemap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClosePanelRemap.Click
        Me.PanelRemap.Visible = False


    End Sub



    Private Sub RemapingDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RemapingDataGridView.CellClick
        If RemapingDataGridView.Rows.Count > 0 Then
            If RemapingDataGridView.CurrentRow.Index <> -1 Then
                cmdRemove.Visible = True
            Else
                cmdRemove.Visible = False
            End If
        End If



    End Sub



    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click

        If RemapingDataGridView.CurrentRow.Cells(0).Value = DPrimaryKeyforImportation Then
            'Dim DDatabasefield As String = RemapingDataGridView.CurrentRow.Cells(0).Value

            'For I = 0 To ImportReplicaDatagridview.Columns.Count - 1
            '    If ImportReplicaDatagridview.Columns(I).HeaderText = DDatabasefield Then
            '        ImportReplicaDatagridview.Columns(I).HeaderText = RemapingDataGridView.CurrentRow.Cells(1).Value
            '        ImportReplicaDatagridview.Columns(I).Name = RemapingDataGridView.CurrentRow.Cells(1).Value
            '    End If
            'Next

            DExcellFieldRepresentintthePK = ""
        End If

        cboDatabaseField.Items.Add(RemapingDataGridView.CurrentRow.Cells(0).Value)
        cboExcellField.Items.Add(RemapingDataGridView.CurrentRow.Cells(1).Value)

        RemapingDataGridView.Rows.RemoveAt(RemapingDataGridView.CurrentRow.Index)


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
                Return " "
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function GetLastRecordID(ByVal TableName As String, ByVal DatabaseName As String) As String
        Try
            Dim Conn As New SqlConnection(MyConnectionString)
            Dim DPrimaryKey As String = GetPrimaryKey(TableName, DatabaseName)
            Dim Query As String = "SELECT TOP 1 " & DPrimaryKey & " FROM " & TableName & " ORDER BY " & DPrimaryKey & " DESC"

            Dim MyTable As New DataTable

            Dim conTableAdapter As New SqlDataAdapter(Query, Conn)
            conTableAdapter.Fill(MyTable)

            If MyTable.Rows.Count > 0 Then
                Return MyTable.Rows(0).Item(DPrimaryKey)
            Else
                Dim ColumnType As String = GetColumnDataTypeByThePrimaryKey(TableName, DPrimaryKey)
                If ColumnType.ToUpper.Contains("CHAR") Then
                    Dim FirstThreeChar As String = ""
                    For Each DChar In TableName.ToCharArray
                        If FirstThreeChar.ToCharArray.Count < 3 Then
                            FirstThreeChar = FirstThreeChar & DChar.ToString
                        End If
                    Next

                    Return FirstThreeChar & "000001"

                ElseIf ColumnType.ToUpper.Contains("INT") Then
                    Return 0
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Function GetColumnDataTypeByThePrimaryKey(ByVal TheTable As String, ByVal Columnname As String) As String
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "Select * From " & DatabaseName & ".INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" & TheTable & "' AND COLUMN_NAME = '" & Columnname & "'"
            Dim MYtABLE As New DataTable
            Dim ContableAdpater As New SqlClient.SqlDataAdapter(Query, Conn)

            ContableAdpater.Fill(MYtABLE)

            If MYtABLE.Rows.Count > 0 Then
                Return MYtABLE.Rows(0).Item("DATA_TYPE")
            Else
                Return "VARCHAR"
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


#Region "IMPORT GENERATOR"

    Private Function ValidateRecord(ByVal DRecord As DataGridViewRow) As Boolean
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim conCommand As New SqlClient.SqlCommand(ImportValidationQuery, Conn)

            Dim splitParameters As String() = AllParameters.Trim.Split(",")

            For Each DParam In splitParameters
                Dim CleanParam As String = DParam.Replace("@", "")
                conCommand.Parameters.AddWithValue(DParam, DRecord.Cells(CleanParam).Value.ToString)
            Next

            Conn.Open()
            Dim RecordCount As Integer
            RecordCount = conCommand.ExecuteScalar
            Conn.Close()

            If RecordCount > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Sub ImportBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ImportBackgroundWorker.DoWork

        Try
            DuplicateRecords = 0

            For Each Record As DataGridViewRow In ImportDataGridView.Rows

                If ImportBackgroundWorker.CancellationPending = False Then
                    CurrentRecord += 1

                    If ValidateRecord(Record) = False Then
                        Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
                        Dim ConCommand As New SqlClient.SqlCommand(ImportInsertQuery, Conn)

                        Dim splitParameters As String() = AllParameters.Trim.Split(",")

                        For Each DParam In splitParameters
                            Dim CleanParam As String = DParam.Replace("@", "")
                            ConCommand.Parameters.AddWithValue(DParam, Record.Cells(CleanParam).Value.ToString)
                        Next

                        If IsPrimaryKeyIncluded = False Then
                            Dim GeneratedID As String = UniversalGenerateRecordID(GetLastRecordID(TheTableName, DatabaseName), TheTableName, DPrimaryKeyforImportation)

                            ConCommand.Parameters.AddWithValue("@" & DPrimaryKeyforImportation, GeneratedID)
                        End If

                        Conn.Open()
                        ConCommand.ExecuteNonQuery()
                        Conn.Close()

                        ImportBackgroundWorker.ReportProgress(1)

                    Else
                        ImportBackgroundWorker.ReportProgress(1)
                        DuplicateRecords += 1
                    End If
                Else
                    e.Cancel = True
                    Exit For
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If ex.Message.ToString.ToUpper.Contains("PRIMARY") Then
                MessageBox.Show("You included the Primary key column in the Mapping. The Primary Key is " & DPrimaryKeyforImportation & ". Please do not include the primary key column in the remapping. If you must then choose a column that is unique.", "Primary Key Column not Unique", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try


    End Sub



    Private Sub ImportBackgroundWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles ImportBackgroundWorker.ProgressChanged
        lblCurrentRecord.Text = "Record: " & CurrentRecord & "/" & ImportDataGridView.Rows.Count

        Dim Percentage As Single = (CurrentRecord / ImportDataGridView.Rows.Count) * 100
        lblPercentage.Text = Percentage.ToString("F2") & "%" & " Complete.."

        PanelProgressbar.Width = (Percentage / 100) * PanelProgressbarContainer.Width



    End Sub



    Private Sub ImportBackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ImportBackgroundWorker.RunWorkerCompleted
        cmdCancel.Visible = False

        If e.Cancelled = False Then
            MessageBox.Show("Data Import was successfully completed. " & DuplicateRecords & " records were skipped because they already exist in the " & CorrectList.Items(cboTableName.SelectedIndex) & " table.", "Import Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmdImport.Enabled = False
        Else
            MessageBox.Show("Data Import was aborted by user..", "Import Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub


#End Region




    Private Sub cmdImport_Click(sender As Object, e As EventArgs) Handles cmdImport.Click

        CurrentRecord = 0
        cmdCancel.Visible = True
        Me.PanelProgress.Visible = True
        TheTableName = CorrectList.Items(cboTableName.SelectedIndex)

        ImportBackgroundWorker.RunWorkerAsync()



    End Sub



    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        ImportBackgroundWorker.CancelAsync()
        cmdCancel.Visible = False


    End Sub



    Private Sub cmdMinimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized


    End Sub



    Private Sub cmdClose_Click(sender As Object, e As EventArgs)
        Me.Close()


    End Sub



    Private Sub NewImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewImportToolStripMenuItem.Click
        cmdNewImport.PerformClick()


    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()


    End Sub



    Private Sub MapColumnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapColumnsToolStripMenuItem.Click
        cmdColumnMapper.PerformClick()


    End Sub



    Private Sub StartImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartImportToolStripMenuItem.Click
        cmdImport.PerformClick()


    End Sub



    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowseToolStripMenuItem.Click
        cmdBrowse.PerformClick()


    End Sub



    Private Sub cboExcellField_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExcellField.SelectedIndexChanged
        If cboDatabaseField.SelectedIndex <> -1 And cboExcellField.SelectedIndex <> -1 Then
            cmdMapColumn.PerformClick()
        End If


    End Sub
 


    Private Sub RemapingDataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles RemapingDataGridView.RowsAdded
        ValidatePrimaryKeyCondition()
        ValidateAtleastOneRecordCondition()
        ValidateForeignKeyCondition()

        ValidateOverallCondition()


    End Sub



    Private Sub RemapingDataGridView_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles RemapingDataGridView.RowsRemoved
        ValidatePrimaryKeyCondition()
        ValidateAtleastOneRecordCondition()
        ValidateForeignKeyCondition()

        ValidateOverallCondition()


    End Sub
 


    Private Sub ValidatePrimaryKeyCondition()
        Dim primaryKeycondition As Boolean = False

        For Each Record As DataGridViewRow In RemapingDataGridView.Rows
            If Record.Cells("DatabaseField").Value = DPrimaryKeyforImportation Then
                primaryKeycondition = True
            End If
        Next

        If primaryKeycondition = True Then
            ValidationDataGridView.Rows(3).Cells(1).Value = "Included"
             
            If ValidatePKBackgroundWorker.IsBusy = False Then
                If isPrimaryKeyConstratintChecked = False Then
                    ValidatePKBackgroundWorker.RunWorkerAsync()
                End If
            End If

        Else
            ValidationDataGridView.Rows(3).Cells(1).Value = "Will be auto-generated"
            ValidationDataGridView.Rows(4).Cells(1).Value = "Unique"
            isPrimaryKeyConstratintChecked = False
        End If


    End Sub



    Private Sub ValidateAtleastOneRecordCondition()
        If RemapingDataGridView.Rows.Count > 0 Then
            ValidationDataGridView.Rows(0).Cells(1).Value = "Passed"
        Else
            ValidationDataGridView.Rows(0).Cells(1).Value = "Failed"
        End If


    End Sub



    Private Sub ValidateOverallCondition()

        Dim FailedCondition As Boolean = False

        For Each Record As DataGridViewRow In ValidationDataGridView.Rows
            If Record.Cells("Condition").Value.contains("Not") Or Record.Cells("Condition").Value.contains("Failed") Then
                FailedCondition = True
            End If
        Next

        If FailedCondition = True Then
            lblOverallCondition.Text = "Failed"
            lblOverallCondition.ForeColor = Color.Red
            cmdAccept.Enabled = False

            If lblSummary.Text.Contains("row") = False Then
                lblSummary.Text = "There are validation errors. Please verify.."
            End If

        Else
            lblOverallCondition.Text = "Passed"
            lblOverallCondition.ForeColor = Color.Green
            cmdAccept.Enabled = True

            If lblSummary.Text.Contains("row") = False Then
                lblSummary.Text = "All conditions are satisfactory. Proceed by clicking the Accept button."
            End If

        End If
 


    End Sub

    Private Function CheckfortheAvailabilityinTable(ByVal ForeignKeyTable As String, ByVal KeyValue As String, ByVal KeyColumn As String) As Boolean
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT Count(" & KeyColumn & ") FROM " & ForeignKeyTable & " WHERE " & KeyColumn & " = '" & KeyValue & "'"
            Dim Concommand As New SqlClient.SqlCommand(Query, Conn)

            Conn.Open()
            Dim RecordCount As Integer = Concommand.ExecuteScalar
            Conn.Close()

            If RecordCount > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function



    Private Sub ValidateForeignKeyConstraintCondition()
        Dim ConditionStatisfied As Boolean = True
        Dim CurrentID As Integer = 0

        For Each Record As DataGridViewRow In ImportDataGridView.Rows
            If CheckfortheAvailabilityinTable(DForeignKeyTable, Record.Cells(DForeignKeyforImportation).Value, DForeignKeyforImportation) = False Then
                ConditionStatisfied = False
                Exit For
            End If
            CurrentID += 1
        Next

        If ConditionStatisfied = True Then
            ValidationDataGridView.Rows(2).Cells(1).Value = "Passed"
            lblSummary.Text = "All conditions are satisfactory"
        Else
            ValidationDataGridView.Rows(2).Cells(1).Value = "Failed"
            lblSummary.Text = "There is a foreign key constraint violation at row " & (CurrentID + 1) & " of the Excel Datagridview. Please verify and try again."
        End If

        ValidateOverallCondition()



    End Sub




    Private Sub ValidateForeignKeyCondition()

        If DForeignKeyforImportation <> "" Then
            Dim foreignkeycondition As Boolean = False

            For Each Record As DataGridViewRow In RemapingDataGridView.Rows
                If Record.Cells("DatabaseField").Value = DForeignKeyforImportation Then
                    foreignkeycondition = True
                End If
            Next

            If foreignkeycondition = True Then
                ValidationDataGridView.Rows(1).Cells(1).Value = "Included"
                cmdValidateForeignkey.Enabled = True
            Else
                ValidationDataGridView.Rows(1).Cells(1).Value = "Not Included"
                cmdValidateForeignkey.Enabled = False
            End If
        Else
            ValidationDataGridView.Rows(1).Cells(1).Value = "Passed"
            ValidationDataGridView.Rows(2).Cells(1).Value = "Passed"
            cmdValidateForeignkey.Enabled = True
        End If




    End Sub


    Private Function CheckforForeignKeyTable(ByVal TableName As String) As String

        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT * FROM " & DatabaseName & ".INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE TABLE_NAME = '" & TableName & "' AND CONSTRAINT_TYPE = 'FOREIGN KEY'"
            Dim MyTable As New DataTable

            Dim contableadap As New SqlClient.SqlDataAdapter(Query, Conn)

            contableadap.Fill(MyTable)

            If MyTable.Rows.Count > 0 Then
                Dim SplitString As String() = MyTable.Rows(0).Item("CONSTRAINT_NAME").ToString.Trim.Split("_")

                Dim TheFKTable As String = SplitString(2)

                Return TheFKTable
            Else
                Return ""
            End If
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function


    Private Function GetForeignKey(ByVal TableName As String, ByVal DatabaseName As String) As String
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



    Private Sub cmdValidateForeignkey_Click(sender As Object, e As EventArgs) Handles cmdValidateForeignkey.Click
        If DForeignKeyforImportation <> "" Then
            ValidateForeignKeyConstraintCondition()
        End If


    End Sub



    Private Sub ValidatePKBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ValidatePKBackgroundWorker.DoWork
        Try
            Dim ConditionStatisfied As Boolean = True
            Dim CurrentID As Integer = 0
            Dim ValidationStatus As String = ""
 
            For Each Record As DataGridViewRow In ImportDataGridView.Rows

                Dim FoundCount As Integer = 0
                For Each Record2 As DataGridViewRow In ImportDataGridView.Rows
                    If Record2.Cells(DExcellFieldRepresentintthePK).Value.ToString = Record.Cells(DExcellFieldRepresentintthePK).Value.ToString Then
                        FoundCount += 1
                    End If
                Next

                If FoundCount > 1 Then
                    ValidationStatus = "Failed"
                    Exit For
                End If

                CurrentID += 1
            Next

            If ValidationStatus = "Failed" Then
                ValidatePKBackgroundWorker.ReportProgress(2)
            Else
                ValidatePKBackgroundWorker.ReportProgress(1)
            End If
            
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Private Sub ValidatePKBackgroundWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles ValidatePKBackgroundWorker.ProgressChanged
        If e.ProgressPercentage = 2 Then
            ValidationDataGridView.Rows(4).Cells(1).Value = "Not Unique"
        ElseIf e.ProgressPercentage = 1 Then
            ValidationDataGridView.Rows(4).Cells(1).Value = "Unique"
        End If


    End Sub



    Private Sub ValidatePKBackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ValidatePKBackgroundWorker.RunWorkerCompleted
        isPrimaryKeyConstratintChecked = True
        ValidateOverallCondition()


    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click


    End Sub
End Class
