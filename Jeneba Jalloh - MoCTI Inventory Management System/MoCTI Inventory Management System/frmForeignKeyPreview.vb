Public Class frmForeignKeyPreview


    Private Sub cmdClosePanelSelector_Click(sender As Object, e As EventArgs) Handles cmdClosePanelSelector.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub


    Private Sub cmdAccept_Click(sender As Object, e As EventArgs) Handles cmdAccept.Click
        SelectorValue = SelectorComboBox.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub
End Class
