Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmSettings
    Dim PreviousIPAddress As String
    Dim PreviousPortNo As String
    Dim PreviousDatabaseName As String
    Dim PreviousUsername As String
    Dim PreviousPassword As String

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer


    Private Sub PanelTop_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelTop.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If



    End Sub



    Private Sub PanelTop_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelTop.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If



    End Sub



    Private Sub PanelTop_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelTop.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If



    End Sub


#Region "Settings"



    Private Sub cmdSaveSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveSettings.Click
        Try
            'REMOTE SETTINGS
            My.Settings.FileServerAddress = txtFileServerAddress.Text
            My.Settings.FileServerUsername = txtFileServerUsername.Text
            My.Settings.FileServerPassword = txtFileServerPassword.Text
            My.Settings.FileServerFolder = txtFileServerSharedFolder.Text
            My.Settings.Save()

            My.Settings.DBServerIPAddress = txtIPAddress.Text
            My.Settings.DBPortNumber = txtPortNo.Text
            My.Settings.DBUsername = txtServerUsername.Text
            My.Settings.DBPassword = txtServerPassword.Text
            My.Settings.DBDatabaseName = txtDatabaseName.Text
            My.Settings.Save()


            'LOCAL SETTINGS
            My.Settings.LocalFileServerAddress = txtLocalFileIPAddress.Text
            My.Settings.LocalFileServerUsername = txtLocalFileUserName.Text
            My.Settings.LocalFileServerPassword = txtLocalFilePassword.Text
            My.Settings.LocalFileServerFolder = txtLocalFileSharedfolder.Text
            My.Settings.Save()

            My.Settings.LocalDBServerIPAddress = txtLocalServerIPAddress.Text
            My.Settings.LocalDBPortNumber = txtLocalPortNo.Text
            My.Settings.LocalDBUsername = txtLocalUserName.Text
            My.Settings.LocalDBPassword = txtLocalPassword.Text
            My.Settings.LocalDBDatabaseName = txtLocalDatabaseName.Text
            My.Settings.Save()

        Catch ex As Exception
            MessageBox.Show("Unable to save the settings, please reload the program as Administrator and try again", "Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        LoadSettings()
        Me.Close()



    End Sub



    Private Sub LoadSettings() Handles MyBase.Load
        Try

            'REMOTE SETTINGS
            txtFileServerAddress.Text = My.Settings.FileServerAddress
            txtFileServerUsername.Text = My.Settings.FileServerUsername
            txtFileServerPassword.Text = My.Settings.FileServerPassword
            txtFileServerSharedFolder.Text = My.Settings.FileServerFolder

            txtIPAddress.Text = My.Settings.DBServerIPAddress
            txtPortNo.Text = My.Settings.DBPortNumber
            txtServerUsername.Text = My.Settings.DBUsername
            txtServerPassword.Text = My.Settings.DBPassword
            txtDatabaseName.Text = My.Settings.DBDatabaseName

            DatabaseName = My.Settings.DBDatabaseName
            ServerIPAddress = My.Settings.DBServerIPAddress
            PortNumber = My.Settings.DBPortNumber
            Username = My.Settings.DBUsername
            Password = My.Settings.DBPassword


            'LOCAL SETTINGS
            txtLocalFileIPAddress.Text = My.Settings.LocalFileServerAddress
            txtLocalFileUserName.Text = My.Settings.LocalFileServerUsername
            txtLocalFilePassword.Text = My.Settings.LocalFileServerPassword
            txtLocalFileSharedfolder.Text = My.Settings.LocalFileServerFolder

            txtLocalServerIPAddress.Text = My.Settings.LocalDBServerIPAddress
            txtLocalPortNo.Text = My.Settings.LocalDBPortNumber
            txtLocalUserName.Text = My.Settings.LocalDBUsername
            txtLocalPassword.Text = My.Settings.LocalDBPassword
            txtLocalDatabaseName.Text = My.Settings.LocalDBDatabaseName

            'DatabaseName = My.Settings.LocalDBDatabaseName
            'ServerIPAddress = My.Settings.LocalDBServerIPAddress
            'PortNumber = My.Settings.LocalDBPortNumber
            'Username = My.Settings.LocalDBUsername
            'Password = My.Settings.LocalDBPassword

            'CREATING THE CONNECTION STRING 
            If txtLocalServerIPAddress.Text.Contains(".\") Or txtLocalServerIPAddress.Text.Contains("\") Then
                MyConnectionString = "Data Source=" & txtLocalServerIPAddress.Text & ";Database=" & txtLocalDatabaseName.Text & ";User ID=" & txtLocalUserName.Text & ";Password=" & txtLocalPassword.Text
            Else
                MyConnectionString = "Data Source=" & txtLocalServerIPAddress.Text & "," & txtLocalPortNo.Text & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & txtLocalDatabaseName.Text & ";User ID=" & txtLocalUserName.Text & ";Password=" & txtLocalPassword.Text
            End If

            'If txtIPAddress.Text.Contains(".\") Or txtIPAddress.Text.Contains("\") Then
            '    MyConnectionString = "Data Source=" & ServerIPAddress & ";Database=" & DatabaseName & ";User ID=" & Username & ";Password=" & Password
            'Else
            '    MyConnectionString = "Data Source=" & ServerIPAddress & "," & PortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & DatabaseName & ";User ID=" & Username & ";Password=" & Password
            'End If

        Catch ex As Exception
            MessageBox.Show("Unable to load settings, please reload the program and try again", "Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub



    Private Sub cmdCheckConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheckConnection.Click
        Dim Conn As SqlConnection = New SqlConnection
        ConnectionTimeout = Conn.ConnectionTimeout

        ConnectionStatus = ""
        CheckConnectionBackgroundWorker1.RunWorkerAsync()
        frmCheckConnection.ShowDialog()


    End Sub



    Private Sub CheckConnectionBackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles CheckConnectionBackgroundWorker1.DoWork
        Try
            Dim TestConnectionString As String
            'Data Source=192.168.2.45,1433;Network Library=DBMSSOCN;Initial Catalog=myDatabase;User ID=myUsername;Password=mypassword

            If txtIPAddress.Text.Contains(".\") Or txtIPAddress.Text.Contains("\") Then
                TestConnectionString = "Data Source=" & txtIPAddress.Text & ";Database=" & txtDatabaseName.Text & ";User ID=" & txtServerUsername.Text & ";Password=" & txtServerPassword.Text
            Else
                TestConnectionString = "Data Source=" & txtIPAddress.Text & "," & txtPortNo.Text & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & txtDatabaseName.Text & ";User ID=" & txtServerUsername.Text & ";Password=" & txtServerPassword.Text
            End If

            Dim Conn As New SqlClient.SqlConnection(TestConnectionString)

            Conn.Open()
            e.Result = "Successfull"
        Catch ex As Exception
            e.Result = "Failed"
        End Try


    End Sub



    Private Sub CheckConnectionBackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles CheckConnectionBackgroundWorker1.RunWorkerCompleted

        If e.Result = "Successfull" Then
            ConnectionStatus = "Successfull"
        ElseIf e.Result = "Failed" Then
            ConnectionStatus = "Failed"
        End If


    End Sub



    Private Sub cmdCancelSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelSettings.Click
        txtDatabaseName.Text = PreviousDatabaseName
        txtIPAddress.Text = PreviousIPAddress
        txtPortNo.Text = PreviousPortNo
        txtServerUsername.Text = PreviousUsername
        txtServerPassword.Text = PreviousPassword
        Me.Close()



    End Sub

#End Region



    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()


    End Sub


    Private Sub Label51_Click(sender As Object, e As EventArgs) Handles LabelControl5.Click, LabelControl4.Click, LabelControl14.Click, LabelControl13.Click


    End Sub


    Private Sub cmdLocateServer_Click(sender As Object, e As EventArgs) Handles cmdLocateServer.Click
        Dim ServerLocateform As New frmLocateServer
        ServerLocateform.ShowDialog()

    End Sub


    Private Sub cmdCheckConnectionLocal_Click(sender As Object, e As EventArgs) Handles cmdCheckConnectionLocal.Click
        Dim Conn As SqlConnection = New SqlConnection
        ConnectionTimeout = Conn.ConnectionTimeout

        ConnectionStatus = ""
        CheckLocalBackgroundWorker.RunWorkerAsync()
        frmCheckConnection.ShowDialog()


    End Sub


    Private Sub CheckLocalBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles CheckLocalBackgroundWorker.DoWork
        Try
            Dim TestConnectionString As String
            'Data Source=192.168.2.45,1433;Network Library=DBMSSOCN;Initial Catalog=myDatabase;User ID=myUsername;Password=mypassword

            If txtLocalServerIPAddress.Text.Contains(".\") Or txtLocalServerIPAddress.Text.Contains("\") Then
                TestConnectionString = "Data Source=" & txtLocalServerIPAddress.Text & ";Database=" & txtLocalDatabaseName.Text & ";User ID=" & txtLocalUserName.Text & ";Password=" & txtLocalPassword.Text
            Else
                TestConnectionString = "Data Source=" & txtLocalServerIPAddress.Text & "," & txtLocalPortNo.Text & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & txtLocalDatabaseName.Text & ";User ID=" & txtLocalUserName.Text & ";Password=" & txtLocalPassword.Text
            End If

            Dim Conn As New SqlClient.SqlConnection(TestConnectionString)

            Conn.Open()
            e.Result = "Successfull"
        Catch ex As Exception
            e.Result = "Failed"
        End Try


    End Sub


    Private Sub CheckLocalBackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles CheckLocalBackgroundWorker.RunWorkerCompleted

        If e.Result = "Successfull" Then
            ConnectionStatus = "Successfull"
        ElseIf e.Result = "Failed" Then
            ConnectionStatus = "Failed"
        End If


    End Sub

End Class
