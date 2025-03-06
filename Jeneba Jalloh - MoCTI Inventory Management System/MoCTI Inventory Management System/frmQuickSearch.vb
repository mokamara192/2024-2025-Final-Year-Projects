Imports System.Data.SqlClient

Public Class frmQuickSearch
     
    Dim SearchFilters As String = Nothing
    Public TableName As String
    Public PrimaryKey As String
    Public FormName As String
    Public ClientSector As String = ""

    Public SearchTable As New DataTable

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
     

    Private Sub PanelTop_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelHeader.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If


    End Sub
     

    Private Sub PanelTop_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelHeader.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If

    End Sub



    Private Sub PanelTop_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelHeader.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If


    End Sub



    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()


    End Sub



    Private Sub lstFields_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFields.SelectedIndexChanged
        Try

            Dim itemfound As Boolean = False
            Dim DataType As String = GetColumnDataType(TableName, lstFields.SelectedItem)

            If SearchFilters IsNot Nothing Then
                Dim SplitField As String() = SearchFilters.Trim.Split(",")
                Dim TheField As String = lstFields.SelectedItem

                For Each item In SplitField
                    If item.Contains(TheField) Then

                        If DataType.ToUpper.Contains("DATE") Then
                            Dim SplitFilter As String() = item.Trim.Split("*")
                            txtFilter.Text = SplitFilter(1).ToString
                            itemfound = True
                        Else
                            Dim SplitFilter As String() = item.Trim.Split("=")
                            txtFilter.Text = SplitFilter(1).ToString.Replace("'", "")
                            itemfound = True
                        End If

                    End If
                Next
            End If

            If itemfound = False Then
                txtFilter.Text = ""
            End If

            txtFilter.Focus()
            txtFilter.Select(txtFilter.Text.Length, 0)

            If DataType.ToUpper.Contains("DATE") Then
                txtFilter.ReadOnly = True
                Me.PanelDatePickers.Visible = True
                Me.PanelDatePickers.BringToFront()
            Else
                txtFilter.ReadOnly = False
                Me.PanelDatePickers.Visible = False
                Me.PanelDatePickers.BringToFront()
            End If

            Me.PanelPreview.Visible = False
            cboPreview.Items.Clear()
            cboPreview.Text = ""

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub




    Private Sub RemoveFromSearch(ByVal Field As String)

        Try
            Dim NewSearch As String = Nothing

            If SearchFilters.Contains(",") Then
                Dim SplitSearch As String() = SearchFilters.Trim.Split(",")

                For Each item In SplitSearch
                    If item.Contains(Field) = False Then
                        If NewSearch = Nothing Then
                            NewSearch = item
                        Else
                            NewSearch += "," & item
                        End If
                    End If
                Next
            Else
                If SearchFilters.Contains(Field) Then
                    NewSearch = ""
                End If
            End If

            SearchFilters = NewSearch

            If SearchFilters = "" Then
                cmdSearch.Enabled = False
            Else
                cmdSearch.Enabled = True
            End If

        Catch ex As Exception
            'MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try






    End Sub




    Private Sub UpdateSearchFilter(ByVal Field As String, ByVal Filter As String)
        Try

            Dim NewSearchFilter As String = Nothing

            Dim DataType As String = GetColumnDataType(TableName, lstFields.SelectedItem)

            If DataType.ToUpper.Contains("DATE") Then
                If SearchFilters = Nothing Then
                    NewSearchFilter = Field & "*" & Filter & ""
                Else
                    If SearchFilters.Contains(",") Then

                        Dim SplitTheFilter As String() = SearchFilters.Trim.Split(",")

                        For Each singleItem In SplitTheFilter

                            If singleItem.Contains(Field) = False Then
                                If NewSearchFilter = Nothing Then
                                    NewSearchFilter = singleItem
                                Else
                                    NewSearchFilter += "," & singleItem
                                End If
                            Else
                                If Filter <> "" Then
                                    If NewSearchFilter = Nothing Then
                                        NewSearchFilter = Field & "*" & Filter & ""
                                    Else
                                        NewSearchFilter += "," & Field & "*" & Filter & ""
                                    End If
                                End If
                            End If

                        Next

                        If NewSearchFilter.Contains(Field) = False Then
                            NewSearchFilter += "," & Field & "*" & Filter & ""
                        End If

                    Else

                        If SearchFilters.Contains(Field) Then
                            NewSearchFilter = Field & "*" & Filter & ""
                        Else
                            NewSearchFilter = SearchFilters & "," & Field & "*" & Filter & ""
                        End If

                    End If

                End If

            Else
                If SearchFilters = Nothing Then
                    NewSearchFilter = Field & "='%" & Filter & "%'"
                Else
                    If SearchFilters.Contains(",") Then

                        Dim SplitTheFilter As String() = SearchFilters.Trim.Split(",")

                        For Each singleItem In SplitTheFilter

                            If singleItem.Contains(Field) = False Then
                                If NewSearchFilter = Nothing Then
                                    NewSearchFilter = singleItem
                                Else
                                    NewSearchFilter += "," & singleItem
                                End If
                            Else
                                If Filter <> "" Then
                                    If NewSearchFilter = Nothing Then
                                        NewSearchFilter = Field & "='%" & Filter & "%'"
                                    Else
                                        NewSearchFilter += "," & Field & "='%" & Filter & "%'"
                                    End If
                                End If
                            End If

                        Next

                        If NewSearchFilter.Contains(Field) = False Then
                            NewSearchFilter += "," & Field & "='%" & Filter & "%'"
                        End If

                    Else

                        If SearchFilters.Contains(Field) Then
                            NewSearchFilter = Field & "='%" & Filter & "%'"
                        Else
                            NewSearchFilter = SearchFilters & "," & Field & "='%" & Filter & "%'"
                        End If

                    End If

                End If
            End If



            SearchFilters = NewSearchFilter

            If SearchFilters = "" Then
                cmdSearch.Enabled = False
            Else
                cmdSearch.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub





    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If cmdSearch.Enabled = True Then
                cmdSearch_Click()
            End If
        End If



    End Sub




    Private Sub txtFilter_KeyUp() Handles txtFilter.KeyUp
        If txtFilter.Text = "" Then
            RemoveFromSearch(lstFields.SelectedItem)
        Else
            UpdateSearchFilter(lstFields.SelectedItem, txtFilter.Text)
        End If



    End Sub


    Private Sub ProcessLoad() Handles Me.Load

        GridView1.OptionsBehavior.ReadOnly = True
        GridView1.OptionsView.ColumnAutoWidth = True

        GridView1.BestFitColumns()


    End Sub


    Private Sub MyLoading() Handles Me.Load
  
        QuickPreviewDialogResult = ""
        LoadFields()
        LoadSomeRecords()

        Dim DFormName As String = TableName.Replace("tbl", "")
        DFormName = DFormName.Replace("Tbl", "")
        DFormName = DFormName.Replace("tBl", "")
        DFormName = DFormName.Replace("tbL", "")
        DFormName = DFormName.Replace("TBl", "")
        DFormName = DFormName.Replace("TBL", "")

        lblTableName.Text = SeparateText(DFormName)
         

    End Sub



    Private Sub LoadFields()
        Try
            Dim DFields As String = GetAllFields(TableName, DatabaseName)

            Dim Thesplit As String() = DFields.Trim.Split(",")
            lstFields.Items.Clear()

            For Each Item In Thesplit
                lstFields.Items.Add(Item)
            Next

            If lstFields.Items.Count > 0 Then
                lstFields.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub




    Private Sub LoadSomeRecords()
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String

            If ClientSector = "" Then
                Query = "SELECT TOP 15 * FROM " & TableName & " ORDER BY " & PrimaryKey & " DESC"
            Else
                Query = "SELECT TOP 15 * FROM " & TableName & " WHERE ClientSector = '" & ClientSector & "' ORDER BY " & PrimaryKey & " DESC "
            End If

            Dim ConTableAdp As New SqlClient.SqlDataAdapter(Query, Conn)

            SearchTable.Rows.Clear()
            ConTableAdp.Fill(SearchTable)
            PreviewDataGridView.DataSource = SearchTable

            lblnoofrecords.Text = SearchTable.Rows.Count & " Record(s)"

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Function GetAllFields(ByVal TableName As String, ByVal DatabaseName As String) As String
        Try
            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" & TableName & "'"

            Dim MyTable As New DataTable

            Dim conTableAdapter As New SqlDataAdapter(Query, Conn)
            conTableAdapter.Fill(MyTable)

            Dim AllFields As String = ""

            If MyTable.Rows.Count > 0 Then
                For Each Record In MyTable.Rows
                    If AllFields = "" Then
                        AllFields = Record("COLUMN_NAME")
                    Else
                        AllFields = AllFields & "," & Record("COLUMN_NAME")
                    End If
                Next
            End If

            Return AllFields

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function



    Private Sub SearchBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles SearchBackgroundWorker.DoWork
        Try

            Dim QueryFields As String = SearchFilters.Replace(",", " AND ")

            If chkfindexclusivematch.Checked = True Then
                'ONLY HAVE TO CHENGE THE % TO "" Since the = sign is already in the query
                QueryFields = QueryFields.Replace("%", "")
            Else
                QueryFields = QueryFields.Replace("=", " LIKE ")
            End If

            QueryFields = QueryFields.Replace("*", " ")

            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String

            If ClientSector = "" Then
                Query = "SELECT * FROM " & TableName & " WHERE " & QueryFields & " ORDER BY " & PrimaryKey & " DESC"
            Else
                Query = "SELECT * FROM " & TableName & " WHERE " & QueryFields & " AND ClientSector = '" & ClientSector & "' ORDER BY " & PrimaryKey & " DESC"
            End If

            Dim ConTableAdp As New SqlClient.SqlDataAdapter(Query, Conn)
            ConTableAdp.SelectCommand.CommandTimeout = 25000

            ConTableAdp.Fill(SearchTable)

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Private Sub SearchBackgroundWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles SearchBackgroundWorker.ProgressChanged



    End Sub



    Private Sub SearchBackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles SearchBackgroundWorker.RunWorkerCompleted
        Me.PanelSearch.Visible = False
        Me.tmrPleasewait.Enabled = False

        PreviewDataGridView.DataSource = Nothing
        PreviewDataGridView.DataSource = SearchTable
        lblnoofrecords.Text = SearchTable.Rows.Count & " Record(s)"

        cmdSearch.Enabled = True
        lstFields.Enabled = True
        txtFilter.Enabled = True


    End Sub



    Private Sub cmdSearch_Click() Handles cmdSearch.Click
        If SearchBackgroundWorker.IsBusy = False Then
            PreviewDataGridView.DataSource = Nothing
            Me.PanelDatePickers.Visible = False
            Me.PanelSearch.Visible = True
            Me.tmrPleasewait.Enabled = True
            SearchTable.Rows.Clear()
            lblnoofrecords.Text = ""
            SearchBackgroundWorker.RunWorkerAsync()
            cmdSearch.Enabled = False
            lstFields.Enabled = False
            txtFilter.Enabled = False
        End If


    End Sub



    Private Sub cmdAccept_Click(sender As Object, e As EventArgs)

        QuickPreviewDialogResult = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns(GetPrimaryKey(TableName, DatabaseName)))

        Me.DialogResult = System.Windows.Forms.DialogResult.OK


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        LoadFields()
        LoadSomeRecords()
        SearchFilters = ""

        ProcessLoad()


    End Sub




    Private Sub cmdPreview_Click(sender As Object, e As EventArgs) Handles cmdPreview.Click
        Try

            Dim DataType As String = GetColumnDataType(TableName, lstFields.SelectedItem)

            If DataType.ToUpper.Contains("DATE") Then
                Me.PanelPreview.Visible = False

                If Me.PanelDatePickers.Visible = True Then
                    Me.PanelDatePickers.Visible = False
                Else
                    Me.PanelDatePickers.Visible = True
                    Me.PanelDatePickers.BringToFront()
                End If

            Else
                If Me.PanelPreview.Visible = False Then
                    Me.PanelDatePickers.Visible = False

                    Me.PanelPreview.Visible = True
                    Me.PanelPreview.BringToFront()

                    Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
                    Dim Query As String

                    If ClientSector = "" Then
                        Query = "SELECT DISTINCT(" & lstFields.SelectedItem & ") FROM " & TableName & " ORDER BY " & lstFields.SelectedItem & " DESC"
                    Else
                        Query = "SELECT DISTINCT(" & lstFields.SelectedItem & ") FROM " & TableName & " WHERE ClientSector = '" & ClientSector & "' ORDER BY " & lstFields.SelectedItem & " DESC"
                    End If

                    Dim ConTableAdp As New SqlClient.SqlDataAdapter(Query, Conn)
                    ConTableAdp.SelectCommand.CommandTimeout = 25000

                    Dim MyTable As New DataTable

                    ConTableAdp.Fill(MyTable)

                    Dim DField As String = lstFields.SelectedItem

                    cboPreview.Items.Clear()
                    cboPreview.Text = ""

                    If DataType.ToUpper.Contains("DATE") Then
                        For Each Item In MyTable.Rows
                            cboPreview.Items.Add(Format(CDate(Item(DField)), "yyyy-MM-dd"))
                        Next
                    Else
                        For Each Item In MyTable.Rows
                            cboPreview.Items.Add(Item(DField))
                        Next
                    End If

                    PreviewDataGridView.DataSource = SearchTable

                Else
                    Me.PanelPreview.Visible = False
                    cboPreview.Items.Clear()
                End If
            End If



        Catch ex As Exception
            cboPreview.Items.Clear()
            cboPreview.Text = ""
            If ex.Message.ToUpper.Contains("TIME") Then
                MessageBox.Show("No Preview is available because the field is probably Binary in nature. Please do not use it in doing the search operation.", "Invalid Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try


    End Sub




    Private Sub cmdClosePanelPreview_Click(sender As Object, e As EventArgs) Handles cmdClosePanelPreview.Click
        Me.PanelPreview.Visible = False
        cboPreview.Items.Clear()
        cboPreview.Text = ""


    End Sub




    Private Sub cboPreview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPreview.SelectedIndexChanged
        If cboPreview.SelectedIndex <> -1 Then
            txtFilter.Text = cboPreview.SelectedItem
            txtFilter_KeyUp()
            cmdSearch.Enabled = True
        End If


    End Sub



    Private Sub cmdClosePanelDate_Click(sender As Object, e As EventArgs) Handles cmdClosePanelDate.Click
        Me.PanelDatePickers.Visible = False


    End Sub



    Private Sub FromDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FromDateTimePicker.ValueChanged
        txtFilter.Text = "BETWEEN '" & Format(FromDateTimePicker.Value.Date, "yyyy-MM-dd") & "' AND '" & Format(ToDateTimePicker.Value.Date, "yyyy-MM-dd") & "'"
        txtFilter_KeyUp()
        cmdSearch.Enabled = True


    End Sub



    Private Sub ToDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles ToDateTimePicker.ValueChanged
        txtFilter.Text = "BETWEEN '" & Format(FromDateTimePicker.Value.Date, "yyyy-MM-dd") & "' AND '" & Format(ToDateTimePicker.Value.Date, "yyyy-MM-dd") & "'"
        txtFilter_KeyUp()
        cmdSearch.Enabled = True


    End Sub



    Private Sub tmrPleasewait_Tick(sender As Object, e As EventArgs) Handles tmrPleasewait.Tick
        lblPleasewait.Visible = Not lblPleasewait.Visible


    End Sub



    Private Sub cmdTransferResult_Click(sender As Object, e As EventArgs) Handles cmdAddNew.Click

'       For Each Cont As Control In frmDashboardNew.XtraTabControlFull.SelectedTabPage.Controls
'            For Each Cont2 As Control In Cont.Controls
'                If TypeOf Cont2 Is Panel Then
'                    For Each Cont3 As Control In Cont2.Controls
'                        If TypeOf Cont3 Is DevExpress.XtraGrid.GridControl Then
'                            CType(Cont3, DevExpress.XtraGrid.GridControl).DataSource = SearchTable
'                        End If
'                    Next
'                End If
'            Next
'        Next

Me.DialogResult = DialogResult.OK
        Me.Close()



    End Sub


End Class
