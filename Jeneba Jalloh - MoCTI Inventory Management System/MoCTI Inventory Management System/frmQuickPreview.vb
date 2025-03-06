Imports System.Data.SqlClient

Public Class frmQuickPreview
    Dim SearchFilters As String = Nothing
    Public TableName As String
    Public PrimaryKey As String
    Public FormName As String

    Public SearchTable As New DataTable

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

            If SearchFilters IsNot Nothing Then
                Dim SplitField As String() = SearchFilters.Trim.Split(",")
                Dim TheField As String = lstFields.SelectedItem

                For Each item In SplitField
                    If item.Contains(TheField) Then
                        Dim SplitFilter As String() = item.Trim.Split("=")
                        txtFilter.Text = SplitFilter(1).ToString.Replace("'", "")
                        itemfound = True
                    End If
                Next
            End If

            If itemfound = False Then
                txtFilter.Text = ""
            End If

            txtFilter.Focus()
            txtFilter.Select(txtFilter.Text.Length, 0)

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


    Private Sub txtFilter_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyUp
        If txtFilter.Text = "" Then
            RemoveFromSearch(lstFields.SelectedItem)
        Else
            UpdateSearchFilter(lstFields.SelectedItem, txtFilter.Text)
        End If


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


    'Private Sub PreviewDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles PreviewDataGridView.DataError


    'End Sub

    Private Sub LoadSomeRecords()
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT  * FROM " & TableName & " ORDER BY " & PrimaryKey & " DESC"
            Dim ConTableAdp As New SqlClient.SqlDataAdapter(Query, Conn)

            SearchTable.Rows.Clear()
            ConTableAdp.Fill(SearchTable)
            PreviewDataGridView.DataSource = SearchTable

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function GetAllFields(ByVal TableName As String, ByVal DatabaseName As String) As String
        Try
            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT COLUMN_NAME FROM " & DatabaseName & ".INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" & TableName & "'"

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



    Private Sub cmdSearch_Click() Handles cmdSearch.Click
        Try
            Dim QueryFields As String = SearchFilters.Replace(",", " AND ")

            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT  * FROM " & TableName & " WHERE " & QueryFields & " ORDER BY " & PrimaryKey & " DESC"
            Dim ConTableAdp As New SqlClient.SqlDataAdapter(Query, Conn)

            SearchTable.Rows.Clear()
            ConTableAdp.Fill(SearchTable)
            PreviewDataGridView.DataSource = SearchTable

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdAccept_Click(sender As Object, e As EventArgs) Handles cmdAccept.Click
        QuickPreviewDialogResult = GridView1.GetFocusedRowCellDisplayText(GridView1.Columns(0))
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        LoadFields()
        LoadSomeRecords()
        SearchFilters = ""

    End Sub
  

    Private Sub cmdAddNew_Click(sender As Object, e As EventArgs) Handles cmdAddNew.Click
         
        Select Case FormName
            Case "frmInventory"
                Dim MyForm = New frmInventory
                'MyForm.cmdMinimize.Visible = False

                Try
       MyForm.WindowState = FormWindowState.Maximized
         MyForm.ShowDialog(Me)
                Catch ex As Exception
       MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmTransferItems"
                Dim MyForm = New frmTransferItems
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmTransferFilesData"
                Dim MyForm = New frmTransferFilesData
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmGeneralSalesItems"
                Dim MyForm = New frmGeneralSalesItems
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmGeneralSales"
                Dim MyForm = New frmGeneralSales
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmTransferOfficeLink"
                Dim MyForm = New frmTransferOfficeLink
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmTransferOffices"
                Dim MyForm = New frmTransferOffices
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmBranch"
                Dim MyForm = New frmBranch
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmTransfers"
                Dim MyForm = New frmTransfers
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmCurrencySetup"
                Dim MyForm = New frmCurrencySetup
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmOfficeTypes"
                Dim MyForm = New frmOfficeTypes
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmFileTypes"
                Dim MyForm = New frmFileTypes
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmBank"
                Dim MyForm = New frmBank
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmIdentificationTypes"
                Dim MyForm = New frmIdentificationTypes
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmTransferPaymentDocuments"
                Dim MyForm = New frmTransferPaymentDocuments
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmTransferFileTypes"
                Dim MyForm = New frmTransferFileTypes
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmStockReorder"
                Dim MyForm = New frmStockReorder
                'MyForm.cmdMinimize.Visible = False

                Try
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.ShowDialog(Me)
                Catch ex As Exception
                    MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try

            Case "frmTransferPayments"
                Dim MyForm = New frmTransferPayments
                'MyForm.cmdMinimize.Visible = False

                Try
       MyForm.WindowState = FormWindowState.Maximized
         MyForm.ShowDialog(Me)
                Catch ex As Exception
       MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try
 
            Case "frmProgramUpdates"
                Dim MyForm = New frmProgramUpdates
                'MyForm.cmdMinimize.Visible = False

                Try
       MyForm.WindowState = FormWindowState.Maximized
         MyForm.ShowDialog(Me)
                Catch ex As Exception
       MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try
 
            Case "frmProgramVersion"
                Dim MyForm = New frmProgramVersion
                'MyForm.cmdMinimize.Visible = False

                Try
       MyForm.WindowState = FormWindowState.Maximized
         MyForm.ShowDialog(Me)
                Catch ex As Exception
       MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try
 
            Case "frmtblUserLog"
                Dim MyForm = New frmtblUserLog
                'MyForm.cmdMinimize.Visible = False

                Try
       MyForm.WindowState = FormWindowState.Maximized
         MyForm.ShowDialog(Me)
                Catch ex As Exception
       MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try
 
            Case "frmItemCategories"
                Dim MyForm = New frmItemCategories
                'MyForm.cmdMinimize.Visible = False

                Try
       MyForm.WindowState = FormWindowState.Maximized
         MyForm.ShowDialog(Me)
                Catch ex As Exception
       MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try
 
            Case "frmWholesaleUnitsOfMeasurement"
                Dim MyForm = New frmWholesaleUnitsOfMeasurement
                'MyForm.cmdMinimize.Visible = False

                Try
       MyForm.WindowState = FormWindowState.Maximized
         MyForm.ShowDialog(Me)
                Catch ex As Exception
       MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try
 
            Case "frmRetailUnitsOfMeasurement"
                Dim MyForm = New frmRetailUnitsOfMeasurement
                'MyForm.cmdMinimize.Visible = False

                Try
       MyForm.WindowState = FormWindowState.Maximized
         MyForm.ShowDialog(Me)
                Catch ex As Exception
       MyForm.WindowState = FormWindowState.Maximized
                    MyForm.WindowState = FormWindowState.Normal
                    MyForm.BringToFront()
                End Try
 
        End Select

    End Sub

End Class
