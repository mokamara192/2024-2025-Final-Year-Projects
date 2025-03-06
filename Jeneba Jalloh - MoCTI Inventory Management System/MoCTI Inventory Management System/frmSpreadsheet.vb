Public Class frmSpreadsheet


    Private Sub BackstageViewTabItem1_SelectedChanged(sender As Object, e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs) Handles BackstageViewTabItem1.ItemPressed
        Try
            SpreadsheetControl1.LoadDocument()
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
