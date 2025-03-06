Public Class frmScanDocumentTypeandQuantity

    Private Sub Myloading() Handles Me.Load
        DocumentTypeQuanfityGridView.DataSource = DocumentTypeandQuantityDataTable
    End Sub

    Private Sub cmdScan_Click(sender As Object, e As EventArgs) Handles cmdScan.Click
        Me.DialogResult = DialogResult.OK

        'If GridView1.SelectedRowsCount > 0 Then
        '         Dim TheSelectedItems As New ArrayList

        '        For Each item In GridView8.GetSelectedRows
        '            TheSelectedItems.Add(item)
        '        Next

        '        Dim myComparer = New myReverserClass()
        '        TheSelectedItems.Sort(myComparer)
        'End If

    End Sub
End Class