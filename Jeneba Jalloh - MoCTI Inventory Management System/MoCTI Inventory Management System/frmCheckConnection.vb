Public Class frmCheckConnection

    Dim CurrentIncrement As Single


    Private Sub tmrProgressbar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrProgressbar.Tick
        If PanelProgressbar.Width < PanelProgressbarContainer.Width Then
            CurrentIncrement += 0.25
            Dim Increment As Single = CurrentIncrement / ConnectionTimeout * 100
            Dim RealIncrement As Integer = Increment / 100 * PanelProgressbarContainer.Width

            PanelProgressbar.Width = RealIncrement
        End If

        If ConnectionStatus = "Successfull" Then
            lblConnection.Text = "Connection Established.."
            lblConnection.Font = New Font("Calibri", 12, FontStyle.Bold)
            lblConnection.ForeColor = Color.Green
            tmrProgressbar.Enabled = False
            cmdExit.Visible = True
            cmdClose.Visible = True
        ElseIf ConnectionStatus = "Failed" Then
            lblConnection.Text = "Connection Failed.."
            lblConnection.Font = New Font("Calibri", 12, FontStyle.Bold)
            lblConnection.ForeColor = Color.Sienna
            tmrProgressbar.Enabled = False
            cmdExit.Visible = True
            cmdClose.Visible = True
        End If

    End Sub


    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        tmrProgressbar.Enabled = False

        lblConnection.Text = "Establishing Connection.."
        lblConnection.Font = New Font("Calibri", 10, FontStyle.Regular)
        lblConnection.ForeColor = Color.Black

        CurrentIncrement = 0
        PanelProgressbar.Width = 10

        cmdExit.Visible = False
        cmdClose.Visible = False
        Me.Close()

    End Sub


    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        tmrProgressbar.Enabled = False
        lblConnection.Text = "Establishing Connection.."
        lblConnection.Font = New Font("Calibri", 10, FontStyle.Regular)
        lblConnection.ForeColor = Color.Black

        CurrentIncrement = 0
        PanelProgressbar.Width = 10

        cmdExit.Visible = False
        cmdClose.Visible = False
        Me.Close()

    End Sub


    Private Sub Me_Loading() Handles MyBase.Load
        tmrProgressbar.Enabled = True

    End Sub

End Class
