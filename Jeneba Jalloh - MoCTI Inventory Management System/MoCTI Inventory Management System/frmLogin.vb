Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmLogin

    Public isTrialExpired As Boolean
    Dim LoadedUserID As String
    Dim Increment As Integer
    Dim Percentage As Integer
    Dim ValidRecords As Integer
    Dim ActualCode As String
    Dim RandomTimes As Integer
    Dim LoadedIMSI_ForManagement As String
    Dim IsRecordLoaded As Boolean
    Dim GeneratorTable As New DataTable
    Dim CurrentGeneratedRecord As Integer = Nothing
    Dim CurrentGeneratedIMSI As String
    Dim isLoginSuccessfull As Boolean

    Dim PreviousIPAddress As String
    Dim PreviousPortNo As String
    Dim PreviousDatabaseName As String
    Dim PreviousUsername As String
    Dim PreviousPassword As String
    Dim MissingMSISDN As Boolean = False
    Dim CancelAddingRecord As Boolean
    Dim UsernameConditionSatisfied As Boolean
    Dim LastRenewDate As Date

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer


    Private Sub MyLoading() Handles Me.Load
        LoadSettings()
        'CheckforLoginAdmin()

        If Not CheckforAdminAccBackgroundWorker.IsBusy Then
            CheckforAdminAccBackgroundWorker.RunWorkerAsync()
        End If

        lblVersion.Text = "Version: " & ProgramVersion

        LoadDaysRemaining()

        If lblDaysRemaining.Text = "0 day(s) remaining." Then
            cmdLogin.Enabled = False
            isTrialExpired = True
        ElseIf lblDaysRemaining.Text = "" Then
            cmdLogin.Enabled = True
            isTrialExpired = False
        End If

        Dim _printDialog As New System.Windows.Forms.PrintDialog
        MyPrinterName = _printDialog.PrinterSettings.PrinterName
        txtUsername.Focus()


    End Sub


    Private Sub LoadSettings()
        Try
            FILEServerIPAddress = My.Settings.LocalFileServerAddress
            FILEUsername = My.Settings.LocalFileServerUsername
            FILEPassword = My.Settings.LocalFileServerPassword
            FILEFolder = My.Settings.LocalFileServerFolder

            DatabaseName = My.Settings.LocalDBDatabaseName
            ServerIPAddress = My.Settings.LocalDBServerIPAddress
            PortNumber = My.Settings.LocalDBPortNumber
            Username = My.Settings.LocalDBUsername
            Password = My.Settings.LocalDBPassword

            If ServerIPAddress.Contains(".\") Or ServerIPAddress.Contains("\") Then
                MyConnectionString = "Data Source=" & ServerIPAddress & ";Database=" & DatabaseName & ";User ID=" & Username & ";Password=" & Password
            Else
                MyConnectionString = "Data Source=" & ServerIPAddress & "," & PortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & DatabaseName & ";User ID=" & Username & ";Password=" & Password
            End If

        Catch ex As Exception
            MessageBox.Show("Unable to load settings, please reload the program and try again", "Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Function CheckforLoginAdmin() As Integer
        Try
            Dim TheConnectionstring As String

            If My.Settings.LocalDBServerIPAddress.Contains(".\") Or My.Settings.LocalDBServerIPAddress.Contains("\") Then
                TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & ";Database=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
            Else
                TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & "," & My.Settings.LocalDBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
            End If

            Dim Query As String = "Select Count(AccountID) From MainLogin Where convert(nvarchar, DECRYPTBYPASSPHRASE(N'mypassword', UserGroup)) =  'Administrator'"
            Dim Conn As New SqlConnection(TheConnectionstring)

            Dim myCommand As New SqlCommand(Query, Conn)

            Conn.Open()
            Dim Count As Integer = myCommand.ExecuteScalar
            Conn.Close()

            If Count > 0 Then
                Return 1
            Else
                Return 2
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 3
        End Try

    End Function


    Private Function CheckforLoginAdmininRemoteDB() As Integer
        Try
            Dim TheConnectionstring As String

 	    If My.Settings.DBServerIPAddress.Contains(".\") Or My.Settings.DBServerIPAddress.Contains("\") Then
                TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & ";Database=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
            Else
                TheConnectionstring = "Data Source=" & My.Settings.DBServerIPAddress & "," & My.Settings.DBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.DBDatabaseName & ";User ID=" & My.Settings.DBUsername & ";Password=" & My.Settings.DBPassword
            End If


            Dim Query As String = "Select Count(AccountID) From MainLogin Where convert(nvarchar, DECRYPTBYPASSPHRASE(N'mypassword', UserGroup)) =  'Administrator'"
            Dim Conn As New SqlConnection(TheConnectionstring)

            Dim myCommand As New SqlCommand(Query, Conn)

            Conn.Open()
            Dim Count As Integer = myCommand.ExecuteScalar
            Conn.Close()

            If Count > 0 Then
                Return 1
            Else
                Return 2
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 3
        End Try

    End Function


    Private Sub cmdLogin_Click() Handles cmdLogin.Click

        Try

            isLoginSuccessfull = False
            Dim thecheck As Integer

            If MyToggleSwitch.IsOn Then
                thecheck = CheckforLoginAdmininRemoteDB()
            Else
                thecheck = CheckforLoginAdmin()
            End If

            If thecheck = 2 Then

                If frmNoLoginAdmin.ShowDialog = System.Windows.Forms.DialogResult.Yes Then
                    isLoginSuccessfull = True
                    frmDashboardNew.OpenAccountManagerforfirstUse()
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    Me.DialogResult = DialogResult.OK
                    'frmMain.Show()
                    Me.Close()
                End If

            ElseIf thecheck = 3 Then

                If MessageBox.Show("Connection Error! Would you like to verify the application settings?", "Connection Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                    frmSettings.Location = New Point(Me.Location.X, Me.Location.Y)
                    frmSettings.ShowDialog()
                End If

            End If

            If isLoginSuccessfull Then

                Exit Sub
            End If

            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = "Select AccountID, FirstName, MiddleName, LastName, CAST(DECRYPTBYPASSPHRASE(N'mypassword', UserGroup) AS NVARCHAR(1000)) AS UserGroup, AccountStatus, Branch, Department, CAST(DECRYPTBYPASSPHRASE(N'mypassword',AccessibleFeatures) AS NVARCHAR(1000)) AS AccessibleFeatures, CAST(DECRYPTBYPASSPHRASE(N'mypassword', RecordAccessLevel) AS NVARCHAR(1000)) AS RecordAccessLevel From mainlogin Where Username = '" & txtUsername.Text & "' And Convert(nvarchar(100), DECRYPTBYPASSPHRASE(N'mypassword', Password)) = @Password "
            Dim ConTableAdapt As New SqlDataAdapter(Query, Conn)

            ConTableAdapt.SelectCommand.Parameters.AddWithValue("@Password", txtPassword.Text)

            Dim MyTable As New DataTable

            ConTableAdapt.Fill(MyTable)

            If MyTable.Rows.Count > 0 Then
                isLoginSuccessfull = True

                RecordAccessLevel = MyTable.Rows(0).Item("RecordAccessLevel").ToString
                CurrentUserID = MyTable.Rows(0).Item("AccountID")
                UserAccountID = CurrentUserID

                CurrentUserName = txtUsername.Text
                CurrentPassword = txtPassword.Text
                AccessibleFeatures = MyTable.Rows(0).Item("AccessibleFeatures")
                UserGroup = MyTable.Rows(0).Item("UserGroup")

                If MyTable.Rows(0).Item("MiddleName") <> "" Then
                    FullNameofUser = MyTable.Rows(0).Item("FirstName") & " " & MyTable.Rows(0).Item("MiddleName") & " " & MyTable.Rows(0).Item("LastName")
                Else
                    FullNameofUser = MyTable.Rows(0).Item("FirstName") & " " & MyTable.Rows(0).Item("LastName")
                End If

                CreateLog(CurrentUserID, FullNameofUser, "Successfull login for username " & txtUsername.Text, 0)

                txtUsername.Text = ""
                txtPassword.Text = ""

                'frmMain.Show()
                Me.DialogResult = DialogResult.OK

                Me.Close()
            Else
                CreateLog(CurrentUserID, "", "Failed login for username " & txtUsername.Text, 0)
                MessageBox.Show("Invalid Username or Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show("Connection Error, Please verify the connectio and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try




    End Sub




    Private Sub cmdSettings2_Click() Handles cmdSettings2.Click

        frmSettings.Location = New Point(Me.Location.X, Me.Location.Y)
        frmSettings.ShowDialog()



    End Sub




    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If isTrialExpired = False Then
                cmdLogin_Click()
            End If
        End If


    End Sub


    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        frmDashboardNew.Close()


    End Sub



    Private Sub ExtendTrial()
        Try
            Dim cONN As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "UPDATE ProgramVersion SET ExpiryDate = @ExpiryDate"
            Dim conCommand As New SqlClient.SqlCommand(Query, cONN)

            With conCommand.Parameters
                .AddWithValue("@ExpiryDate", Date.Today.AddDays(14))
            End With

            cONN.Open()
            conCommand.ExecuteNonQuery()
            cONN.Close()

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub ActivateProduct()
        Try

            Dim cONN As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "UPDATE ProgramVersion SET ProgramStatus = 'Activated'"
            Dim conCommand As New SqlClient.SqlCommand(Query, cONN)

            cONN.Open()
            conCommand.ExecuteNonQuery()
            cONN.Close()

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    'Private Sub cmdProductActivation_Click(sender As Object, e As EventArgs) Handles cmdProductActivation.Click
    '    Me.PanelActivate.Visible = True
    '    Me.PanelActivate.BringToFront()


    'End Sub



    'Private Sub cmdExtend_Click(sender As Object, e As EventArgs)
    '    If radExtend.Checked = True Then
    '        If txtExtension.Text = "6KYDYJT4MB6V3JQ4KKFGP6C63" Then
    '            ExtendTrial()
    '            MessageBox.Show("Product Trial Period has been extended by 14 days. Thank you for using Gesman Plus.", "Trial Extended", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            cmdLogin.Enabled = True
    '            Me.PanelActivate.Visible = False
    '            txtExtension.Text = ""
    '            lblDaysRemaining.Text = "15 days(s) remaining"
    '        End If
    '    Else
    '        If txtExtension.Text = "6KYDYJT4MB6V3JQ4KKFGP6C63" Then
    '            ActivateProduct()
    '            MessageBox.Show("Product Successfully Activated. Thank you for purchasing Gesman Plus", "Trial Extended", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            cmdLogin.Enabled = True
    '            Me.PanelActivate.Visible = False
    '            txtExtension.Text = ""
    '            lblDaysRemaining.Text = ""
    '        End If
    '    End If
    'End Sub



    Private Sub LoadDaysRemaining()
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
            Dim Query As String = "SELECT ExpiryDate From ProgramVersion WHERE ProgramStatus = 'Trial'"
            Dim ConTableAdap As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTable As New DataTable

            ConTableAdap.Fill(MyTable)

            If MyTable.Rows.Count > 0 Then


                Dim DateDiff As TimeSpan = CDate(MyTable.Rows(0).Item("ExpiryDate")).Subtract(Date.Today)

                If DateDiff.TotalDays >= 0 Then
                    lblDaysRemaining.Text = CInt(DateDiff.TotalDays) & " day(s) remaining."
                Else
                    lblDaysRemaining.Text = "0 day(s) remaining."
                End If
            Else
                lblDaysRemaining.Text = ""
                isTrialExpired = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub tmrTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick
        lblTime.Text = Format(Now, "HH:mm:ss")
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    Me.PanelActivate.Visible = False
    'End Sub

    Private Sub cmdCheckforUpdate_Click(sender As Object, e As EventArgs) Handles cmdCheckforUpdate.Click
        'frmCheckforUpdate.Show()
    End Sub

    Private Sub CheckforAdminAccBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles CheckforAdminAccBackgroundWorker.DoWork

        Dim LoginAdminStatus As Integer = CheckforLoginAdmin()
        CheckforAdminAccBackgroundWorker.ReportProgress(LoginAdminStatus)
    End Sub


    Private Sub CheckforAdminAccBackgroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles CheckforAdminAccBackgroundWorker.ProgressChanged

        If e.ProgressPercentage = 2 Then

            If frmNoLoginAdmin.ShowDialog = System.Windows.Forms.DialogResult.Yes Then
                isLoginSuccessfull = True
                frmDashboardNew.OpenAccountManagerforfirstUse()
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                Me.DialogResult = DialogResult.OK
                'frmMain.Show()
                Me.Close()
            End If

        ElseIf e.ProgressPercentage = 3 Then

            If MessageBox.Show("Connection Error! Would you like to verify the application settings?", "Connection Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                frmSettings.Location = New Point(Me.Location.X, Me.Location.Y)
                frmSettings.ShowDialog()
            End If

        End If


    End Sub


    Private Sub CheckforAdminAccBackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles CheckforAdminAccBackgroundWorker.RunWorkerCompleted


    End Sub


    Private Sub cmdLocateServer_Click(sender As Object, e As EventArgs) Handles cmdLocateServer.Click
        Dim ServerLocateform As New frmLocateServer
        ServerLocateform.ShowDialog()

    End Sub


    Private Sub MyToggleSwitch_Toggled(sender As Object, e As EventArgs) Handles MyToggleSwitch.Toggled
        If Not MyToggleSwitch.IsOn Then
            DatabaseName = My.Settings.LocalDBDatabaseName
            ServerIPAddress = My.Settings.LocalDBServerIPAddress
            PortNumber = My.Settings.LocalDBPortNumber
            Username = My.Settings.LocalDBUsername
            Password = My.Settings.LocalDBPassword

            FILEServerIPAddress = My.Settings.LocalFileServerAddress
            FILEUsername = My.Settings.LocalFileServerUsername
            FILEPassword = My.Settings.LocalFileServerPassword
            FILEFolder = My.Settings.LocalFileServerFolder

            If ServerIPAddress.Contains(".\") Or ServerIPAddress.Contains("\") Then
                MyConnectionString = "Data Source=" & ServerIPAddress & ";Database=" & DatabaseName & ";User ID=" & Username & ";Password=" & Password
            Else
                MyConnectionString = "Data Source=" & ServerIPAddress & "," & PortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & DatabaseName & ";User ID=" & Username & ";Password=" & Password
            End If

            MyToggleSwitch.ForeColor = Color.Brown
        Else
            Try
                If frmDashboardNew.BarLabelRemoteServer.Caption = "Online" Then
                    MyToggleSwitch.ForeColor = Color.Green

                    DatabaseName = My.Settings.DBDatabaseName
                    ServerIPAddress = My.Settings.DBServerIPAddress
                    PortNumber = My.Settings.DBPortNumber
                    Username = My.Settings.DBUsername
                    Password = My.Settings.DBPassword

                    FILEServerIPAddress = My.Settings.FileServerAddress
                    FILEUsername = My.Settings.FileServerUsername
                    FILEPassword = My.Settings.FileServerPassword
                    FILEFolder = My.Settings.FileServerFolder

                    If ServerIPAddress.Contains(".\") Or ServerIPAddress.Contains("\") Then
                        MyConnectionString = "Data Source=" & ServerIPAddress & ";Database=" & DatabaseName & ";User ID=" & Username & ";Password=" & Password
                    Else
                        MyConnectionString = "Data Source=" & ServerIPAddress & "," & PortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & DatabaseName & ";User ID=" & Username & ";Password=" & Password
                    End If
                Else
                    MessageBox.Show("The Remote Database Server is currently offline so you cannot work online at this time. Please wait for the server to come online or you may work offline and synchronize you data later when the remote server becomes available.", "Remote Server Offline", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    MyToggleSwitch.IsOn = False
                End If

            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

End Class
