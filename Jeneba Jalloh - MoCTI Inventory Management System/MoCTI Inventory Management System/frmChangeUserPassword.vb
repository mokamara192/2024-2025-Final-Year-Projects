 Public Class frmChangeUserPassword
 

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        txtCurrentPassword.Text = ""
        txtConfirmPassword.Text = ""
        txtNewPassword.Text = ""
        Me.Close()



    End Sub



    Private Sub cmdChange_Click(sender As Object, e As EventArgs) Handles cmdChange.Click
        If txtNewPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            MessageBox.Show("Please provide all required information before clicking the Change Password button.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)


            Exit Sub
        End If

        If txtCurrentPassword.Text = CurrentPassword Then
            If txtNewPassword.Text = txtConfirmPassword.Text Then

                Try
                    Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
                    Dim Query As String = "Update MainLogin Set Password = ENCRYPTBYPASSPHRASE(N'mypassword',@Password), RenewDate=@RenewDate Where AccountID='" & CurrentUserID & "'"

                    Dim MyCommand As New SqlClient.SqlCommand(Query, Conn)

                    With MyCommand.Parameters
                        .AddWithValue("@Password", txtNewPassword.Text.ToString)
                        .AddWithValue("@RenewDate", Date.Today)
                    End With

                    Conn.Open()
                    MyCommand.ExecuteNonQuery()
                    Conn.Close()

                    CreateLog(CurrentUserID, FullNameofUser, "Changed his/her account password", 0)

                    CurrentPassword = txtNewPassword.Text

                    MessageBox.Show("Password successfully changed. Please login next time using you new password.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    cmdClose.PerformClick()

                Catch ex As Exception
                    MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Password confirmation mismatch. Please verify the Passwords entered and try again.", "Password Confirmation Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("The password entered is not you current password. Please enter you current password and try again.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub



    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        txtCurrentPassword.Clear()
        txtConfirmPassword.Clear()
        txtNewPassword.Clear()
        Me.Close()


    End Sub
End Class
