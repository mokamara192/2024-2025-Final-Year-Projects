Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Net

Public Class frmLocateServer
    Dim TheFirstSetIP As String
    Dim ScannedIPs As Integer
    Dim CurrentIP As String
    Dim ServerLocated As Boolean
    Dim DetectedServers As New ArrayList
    Dim AvailableRanges As New ArrayList
    'Dim UsedRanges As New ArrayList
    Dim NoofThreads As Integer
    Dim NoofCompleted As Integer

    Dim PortNumber As String
    Dim Username As String
    Dim Password As String
    Dim DatabaseName As String

    'CHECK CONNECTION
    Dim SelectedIPAddress As String
    Dim SelectedUserName, SelectedPassword As String


    Private Sub LoadSettings() Handles MyBase.Load
        Try

            If My.Settings.DBDatabaseName = "" Then
                DatabaseName = My.Settings.LocalDBDatabaseName
                PortNumber = My.Settings.LocalDBPortNumber
                Username = My.Settings.LocalDBUsername
                Password = My.Settings.LocalDBPassword
            Else
                DatabaseName = My.Settings.DBDatabaseName
                PortNumber = My.Settings.DBPortNumber
                Username = My.Settings.DBUsername
                Password = My.Settings.DBPassword
            End If

            txtDatabaseName.Text = DatabaseName
            txtPortNo.Text = PortNumber
            txtServerUsername.Text = Username
            txtServerPassword.Text = Password

            'If ServerIPAddress.Contains(".\") Or ServerIPAddress.Contains("\") Then
            '    MyConnectionString = "Data Source=" & ServerIPAddress & ";Database=" & DatabaseName & ";User ID=" & Username & ";Password=" & Password
            'Else
            '    MyConnectionString = "Data Source=" & ServerIPAddress & "," & PortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & DatabaseName & ";User ID=" & Username & ";Password=" & Password
            'End If

        Catch ex As Exception
            MessageBox.Show("Unable to load settings, please reload the program and try again", "Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub


    Private Sub MyLoading() Handles Me.Load
        LoadSettings()

        Try
            If Not SearchBackgroundWorker.IsBusy Then
                MyListView.Items.Clear()
                cmdOK.Enabled = False

                ProgressPanelSearch.Caption = "Looking for Available Servers"
                ProgressPanelSearch.Description = "Initializing"
                ProgressPanelSearch.Show()

                TheFirstSetIP = ""
                Dim TheIPClass As System.Net.IPHostEntry
                TheIPClass = Dns.Resolve(Dns.GetHostName())

                If TheIPClass.AddressList IsNot Nothing Then
                    If TheIPClass.AddressList.Count > 0 Then
                        Dim TheSplit As String() = TheIPClass.AddressList(0).ToString.Trim.Split(".")

                        For i = 0 To TheSplit.Count - 2
                            If TheFirstSetIP = "" Then
                                TheFirstSetIP = TheSplit(i)
                            Else
                                TheFirstSetIP = TheFirstSetIP & "." & TheSplit(i)
                            End If
                        Next

                    Else
                        MessageBox.Show("This Computer is NOT Connected to any network. Please connect to a network before proceeding.", "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("This Computer is NOT Connected to any network. Please connect to a network before proceeding.", "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.Close()
                End If


                SearchBackgroundWorker.RunWorkerAsync()
            Else
                MessageBox.Show("A search is already in progress. Please wait or cancel the current search to start a new one", "Search in progress", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        If MyListView.SelectedItems.Count > 0 Then
            If MyListView.SelectedItems(0).Text.Contains("Access Denied") Then
                SelectedIPAddress = MyListView.SelectedItems(0).Tag
                Me.PanelAccessDenied.Visible = True
                Me.PanelAccessDenied.BringToFront()
                Me.cmdAccept.Enabled = False

                MyListView.Enabled = False
            Else
                Dim theIP As String = MyListView.SelectedItems(0).Tag
                MyConnectionString = "Data Source=" & theIP & "," & PortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & DatabaseName & ";User ID=" & Username & ";Password=" & Password

                If MessageBox.Show("Do you wish to set the selected server as a permanent choice for now?", "Setting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try

                        My.Settings.DBServerIPAddress = theIP
                        My.Settings.Save()

                    Catch ex As Exception
                        MessageBox.Show("Unable to save the settings. Please make sure the application is run as Administrator. You can however use the system as it is now.", "Saving Not Applicable", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                End If

                Me.Close()
            End If


        End If

    End Sub


    Private Sub ProgressPanelSearch_Click(sender As Object, e As EventArgs) Handles ProgressPanelSearch.Click
        If SearchBackgroundWorker.IsBusy Then
            If MessageBox.Show("Do you wish to cancel the scan?", "Canceling", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                SearchBackgroundWorker.CancelAsync()
            End If
        Else
            ProgressPanelSearch.Hide()
        End If

    End Sub


    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        Try
            If Not SearchBackgroundWorker.IsBusy Then

                DatabaseName = txtDatabaseName.Text
                PortNumber = txtPortNo.Text
                Username = txtServerUsername.Text
                Password = txtServerPassword.Text

                MyListView.Items.Clear()
                cmdOK.Enabled = False

                DetectedServers.Clear()
                AvailableRanges.Clear()
                ScannedIPs = 0

                NoofThreads = 0
                NoofCompleted = 0

                ProgressPanelSearch.Caption = "Looking for Available Servers"
                ProgressPanelSearch.Description = "Initializing"
                ProgressPanelSearch.Show()

                TheFirstSetIP = ""
                Dim TheIPClass As System.Net.IPHostEntry
                TheIPClass = Dns.Resolve(Dns.GetHostName())

                If TheIPClass.AddressList IsNot Nothing Then
                    If TheIPClass.AddressList.Count > 0 Then
                        Dim TheSplit As String() = TheIPClass.AddressList(0).ToString.Trim.Split(".")

                        For i = 0 To TheSplit.Count - 2
                            If TheFirstSetIP = "" Then
                                TheFirstSetIP = TheSplit(i)
                            Else
                                TheFirstSetIP = TheFirstSetIP & "." & TheSplit(i)
                            End If
                        Next

                    Else
                        MessageBox.Show("This Computer is NOT Connected to any network. Please connect to a network before proceeding.", "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        Exit Sub
                    End If
                Else
                    MessageBox.Show("This Computer is NOT Connected to any network. Please connect to a network before proceeding.", "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Exit Sub
                End If

                SearchBackgroundWorker.RunWorkerAsync()
            Else
                MessageBox.Show("A search is already in progress. Please wait or cancel the current search to start a new one", "Search in progress", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub MyListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MyListView.SelectedIndexChanged
        If MyListView.Items.Count > 0 Then
            If MyListView.SelectedIndices.Count > 0 Then
                cmdOK.Enabled = True
            Else
                cmdOK.Enabled = False
            End If
        Else
            cmdOK.Enabled = False
        End If

    End Sub

#Region "SEARCH BACKGROUND WORKER"


    Private Sub SearchSeparately()
        Try
            If AvailableRanges.Count > 0 Then

                Dim theindex As Integer = AvailableRanges.Count - 1
                Dim theRange As String = AvailableRanges.Item(theindex)
                AvailableRanges.RemoveAt(theindex)

                Dim thesplit As String() = theRange.Trim.Split("-")
                Dim start As Integer = CInt(thesplit(0))
                Dim theend As Integer = CInt(thesplit(1))

                Dim TestConnectionString As String
                Dim FullIP As String = ""

                For i = start To theend
                    Try
                        If SearchBackgroundWorker.CancellationPending Then
                            Exit For
                        End If

                        FullIP = TheFirstSetIP & "." & i
                        CurrentIP = FullIP
                        ScannedIPs += 1

                        TestConnectionString = "Data Source=" & FullIP & "," & PortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & DatabaseName & ";User ID=" & Username & ";Password=" & Password

                        Dim Conn As New SqlClient.SqlConnection(TestConnectionString)
                        Conn.Open()

                        Dim ComputerName As String = GetComputerName(TestConnectionString)
                        Dim FullNameandIP As String = ComputerName & ":" & FullIP
                        DetectedServers.Add(FullNameandIP)

                        If SearchBackgroundWorker.IsBusy Then
                            SearchBackgroundWorker.ReportProgress(1)
                        Else

                            Exit Sub
                        End If

                    Catch ex As Exception
                        If SearchBackgroundWorker.IsBusy Then
                            If ex.Message.Contains("Login") Then
                                Dim FullNameandIP As String = "Access Denied:" & FullIP
                                DetectedServers.Add(FullNameandIP)
                                SearchBackgroundWorker.ReportProgress(1)
                            Else
                                SearchBackgroundWorker.ReportProgress(1)
                            End If

                        Else

                            Exit Sub
                        End If
                    End Try
                Next

                NoofCompleted += 1

            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function GetComputerName(ByVal ConnectionString) As String
        Try

            Dim Conn As New SqlClient.SqlConnection(ConnectionString)

            Dim Query As String = " SELECT ComputerName FROM ProgramVersion "
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            Dim Mytable As New DataTable
            ConTableAdapter.Fill(Mytable)

            If Mytable.Rows.Count > 0 Then
                Return Mytable.Rows(0).Item("ComputerName")
            Else
                Return "Unknown"
            End If

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Sub SearchBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles SearchBackgroundWorker.DoWork
        Try

            Dim lastno As Integer = 1

            While True

                If lastno < 254 Then
                    If (lastno + 5) > 254 Then
                        Dim range As String = lastno & "-" & "254"
                        AvailableRanges.Add(range)
                        Dim MyThread As New System.Threading.Thread(AddressOf SearchSeparately)
                        MyThread.Start()
                        NoofThreads += 1
                        lastno = 254
                        Exit While
                        System.Threading.Thread.Sleep(200)
                    Else
                        Dim range As String = lastno & "-" & ((lastno - 1) + 5)
                        AvailableRanges.Add(range)
                        Dim MyThread As New System.Threading.Thread(AddressOf SearchSeparately)
                        MyThread.Start()
                        NoofThreads += 1
                        lastno = lastno + 5
                        System.Threading.Thread.Sleep(200)
                    End If
                Else
                    Exit While
                End If

            End While

            While True
                If NoofThreads = NoofCompleted Then
                    SearchBackgroundWorker.ReportProgress(1)
                    Exit While
                Else
                    SearchBackgroundWorker.ReportProgress(1)
                End If

                If SearchBackgroundWorker.CancellationPending Then
                    Exit While
                End If

                System.Threading.Thread.Sleep(500)
            End While

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub SearchBackgroundWorker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles SearchBackgroundWorker.ProgressChanged
        Try
            ProgressPanelSearch.Description = "Scanning: Total: " & ScannedIPs & ", Detected: " & DetectedServers.Count & ", Current IP: " & CurrentIP

            If e.ProgressPercentage = 1 Then

            ElseIf e.ProgressPercentage = 2

            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub SearchBackgroundWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles SearchBackgroundWorker.RunWorkerCompleted

        If DetectedServers.Count > 0 Then
            ProgressPanelSearch.Caption = "Server(s) Found"
            ProgressPanelSearch.Description = "Please select on of the located servers."
        Else
            ProgressPanelSearch.Caption = "No Server Found"
            ProgressPanelSearch.Description = "Please make sure the server is online"
        End If

        Try
            Dim theindices As New ArrayList

            For i = DetectedServers.Count - 1 To 0 Step -1
                Dim isFound As Boolean = False
                Dim FullNameandIP As String() = DetectedServers(i).ToString.Split(":")
                Dim ComputerName As String = FullNameandIP(0)
                Dim IPAdd As String = FullNameandIP(1)

                Dim myitem As New ListViewItem
                myitem.ImageIndex = 0
                myitem.Text = ComputerName & " (" & IPAdd & ")"
                myitem.Tag = IPAdd

                MyListView.Items.Add(myitem)
                theindices.Add(i)
            Next

            For Each index In theindices
                DetectedServers.RemoveAt(index)
            Next

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub cmdCheckConnection_Click(sender As Object, e As EventArgs) Handles cmdCheckConnection.Click
        SelectedUserName = CheckUserNameTextBox.Text
        SelectedPassword = CheckPasswordTextBox.Text

        Dim Conn As SqlConnection = New SqlConnection
        ConnectionTimeout = Conn.ConnectionTimeout

        ConnectionStatus = ""
        CheckConnectionBackgroundWorker1.RunWorkerAsync()
        frmCheckConnection.ShowDialog()

    End Sub


    Private Sub CheckConnectionBackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles CheckConnectionBackgroundWorker1.DoWork
        Try
            Dim TestConnectionString As String
            'Data Source=192.168.2.45,1433;Network Library=DBMSSOCN;Initial Catalog=myDatabase;User ID=myUsername;Password=mypassword

            If SelectedIPAddress.Contains(".\") Or SelectedIPAddress.Contains("\") Then
                TestConnectionString = "Data Source=" & SelectedIPAddress & ";Database=" & DatabaseName & ";User ID=" & SelectedUserName & ";Password=" & SelectedPassword
            Else
                TestConnectionString = "Data Source=" & SelectedIPAddress & "," & PortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & DatabaseName & ";User ID=" & SelectedUserName & ";Password=" & SelectedPassword
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
            cmdAccept.Enabled = True
        ElseIf e.Result = "Failed" Then
            ConnectionStatus = "Failed"
            cmdAccept.Enabled = False
        End If


    End Sub


    Private Sub cmdAccept_Click(sender As Object, e As EventArgs) Handles cmdAccept.Click
        Dim theIP As String = SelectedIPAddress
        'MyConnectionString = "Data Source=" & theIP & "," & PortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & DatabaseName & ";User ID=" & Username & ";Password=" & Password
         
        My.Settings.DBServerIPAddress = theIP
        My.Settings.DBUsername = SelectedUserName
        My.Settings.DBPassword = SelectedPassword
        My.Settings.DBDatabaseName = txtDatabaseName.Text
        My.Settings.DBPortNumber = txtPortNo.Text
      
        My.Settings.Save()

         MyListView.Enabled = True
        Me.Close()

    End Sub


    Private Sub cmdClosePanelAccess_Click(sender As Object, e As EventArgs) Handles cmdClosePanelAccess.Click
        Me.PanelAccessDenied.Visible = False
        MyListView.Enabled = True

    End Sub

#End Region
End Class
