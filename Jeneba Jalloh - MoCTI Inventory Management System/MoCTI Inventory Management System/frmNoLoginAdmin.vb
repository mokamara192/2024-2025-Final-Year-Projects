Public Class frmNoLoginAdmin


    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()

    End Sub


    Private Sub cmdYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdYes.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()

    End Sub


    Private Sub cmdNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNo.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()

    End Sub
End Class
