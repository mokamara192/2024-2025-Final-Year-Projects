Public Class frmSplash



    Private Sub tmrLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoad.Tick
        If PanelProgressbar.Width < PanelProgressbarContainer.Width Then
            Me.PanelProgressbar.Width += 4
            Dim Percentage As Integer = PanelProgressbar.Width / PanelProgressbarContainer.Width * 100

            If Percentage >= 100 Then
                lblPercentage.Text = "100% Complete.."
            Else
                lblPercentage.Text = Percentage.ToString("F0") & "% Complete.."
            End If

        Else
            tmrLoad.Enabled = False
            tmrLoadComplete.Enabled = True
        End If


    End Sub


    Private Sub MyLoading() Handles Me.Load
        lblVersion.Text = "Version: " & ProgramVersion

    End Sub


    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Application.Exit()

    End Sub



    Private Sub tmrLoadComplete_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoadComplete.Tick
        If PanelProgressbarContainer.Height > 0 Then
            PanelProgressbarContainer.Height -= 1
            PanelHeader.Height -= 1
        Else
            tmrLoadComplete.Enabled = False
            'frmDashboardNew.Show()
            Me.Close()
        End If


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblTitleBottom_Click(sender As Object, e As EventArgs) Handles lblTitleBottom.Click

    End Sub
End Class
