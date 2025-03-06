Imports System.Data.SqlClient
Imports System.IO

Public Class frmMessages
    Dim UsersComboBox As New ComboBox
    Dim LoadedAttachmentname As String
    Dim AttachmentFile As Byte()
    Dim SelectedEmployees As New ListView
     
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
      


    Private Sub tmrUnloadReceipients_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUnlockReceipients.Tick
        If PanelReceipients.Size.Height < 314 Then
            PanelReceipients.Height += 12
        Else
            PanelReceipients.Height = 314
            tmrUnlockReceipients.Enabled = False
            chkCheckAll.Visible = True
        End If



    End Sub




    Private Sub tmrLoadReceipients_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLockReceipients.Tick
        If PanelReceipients.Size.Height > 0 Then
            PanelReceipients.Height -= 12
        Else
            PanelReceipients.Height = 0
            PanelReceipients.Visible = False
            tmrLockReceipients.Enabled = False
        End If



    End Sub




    Private Sub chkCheckAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheckAll.CheckedChanged
        If chkCheckAll.Checked = True Then
            For Each Item As ListViewItem In lvReceipientsEmployees.Items
                If Item.Checked = False Then
                    Item.Checked = True
                End If
            Next

            'For Each Item As ListViewItem In lvReceipientsEmployers.Items
            '    If Item.Checked = False Then
            '        Item.Checked = True
            '    End If
            'Next
        Else
            For Each Item As ListViewItem In lvReceipientsEmployees.Items
                If Item.Checked = True Then
                    Item.Checked = False
                End If
            Next

            'For Each Item As ListViewItem In lvReceipientsEmployers.Items
            '    If Item.Checked = True Then
            '        Item.Checked = False
            '    End If
            'Next
        End If



    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        Me.WindowState = FormWindowState.Minimized



    End Sub




    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        Me.Close()



    End Sub




    Private Sub LoadEmployers()
        'Dim con As SqlConnection = New SqlConnection
        'con.ConnectionString = MyConnectionString
        'Dim Query As String = "Select EmployerID,FirstName,MiddleName,LastName,Gender,Photograph From employer"
        'Dim FullName As String = Nothing

        'Try
        '    con.Open()
        '    Dim MyTableAdapter As SqlDataAdapter = New SqlDataAdapter(Query, con)
        '    Dim MyTable As New DataTable

        '    MyTableAdapter.Fill(MyTable)
        '    con.Close()

        '    If MyTable.Rows.Count > 0 Then

        '        For Each Record In MyTable.Rows
        '            If Record("MiddleName") <> "" Then
        '                FullName = Record("FirstName") & " " & Record("MiddleName") & " " & Record("LastName")
        '            Else
        '                FullName = Record("FirstName") & " " & Record("LastName")
        '            End If

        '            Dim MyListviewitem As New ListViewItem
        '            Dim MyPhoto As Bitmap = Nothing

        '            Try
        '                Dim newMstream As New System.IO.MemoryStream(CType(Record("Photograph"), Byte()))
        '                'Dim ImageFromDB As New Bitmap(newMstream)
        '                ReceipientImageList.Images.Add(Bitmap.FromStream((newMstream)))
        '                MyListviewitem.ImageIndex = ReceipientImageList.Images.Count - 1
        '            Catch ex As Exception
        '                If Record("Gender") = "Male" Then
        '                    MyListviewitem.ImageIndex = 0
        '                ElseIf Record("Gender") = "Female" Then
        '                    MyListviewitem.ImageIndex = 1
        '                End If
        '            End Try

        '            MyListviewitem.Tag = Record("EmployerID")
        '            MyListviewitem.Text = FullName
        '            lvReceipientsEmployers.Items.Add(MyListviewitem)

        '            Dim UserString As String = Record("EmployerID") & ":" & MyListviewitem.ImageIndex.ToString & ":" & MyListviewitem.Text & ":" & "Employer"
        '            UsersComboBox.Items.Add(UserString)
        '        Next

        '    End If

        '   
        'Catch ex As Exception
        '    MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try



    End Sub




    Private Sub LoadDepartments()
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT Distinct(Department) FROM MainLogin"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)
            Dim MyTable As New DataTable

            ConTableAdapter.Fill(MyTable)

            For Each Record In MyTable.Rows
                lstDepartments.Items.Add(Record("Department").ToString.ToUpper)
            Next

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub




    Private Sub LoadEmployeesbyDepartmen(ByVal Department As String)

        lvReceipientsEmployees.Items.Clear()
        'lvReceipientsEmployers.Items.Clear()
        UsersComboBox.Items.Clear()

        Try
            Dim con As SqlConnection = New SqlConnection
            con.ConnectionString = MyConnectionString
            Dim Query As String = "Select AccountID,FirstName,MiddleName,LastName,Gender From mainlogin WHERE Department = '" & Department & "'"
            Dim FullName As String = Nothing

            Dim MyTableAdapter As SqlDataAdapter = New SqlDataAdapter(Query, con)
            Dim MyTable As New DataTable

            MyTableAdapter.Fill(MyTable)

            If MyTable.Rows.Count > 0 Then

                For Each Record In MyTable.Rows
                    If Record("MiddleName") <> "" Then
                        FullName = Record("FirstName") & " " & Record("MiddleName") & " " & Record("LastName")
                    Else
                        FullName = Record("FirstName") & " " & Record("LastName")
                    End If

                    Dim MyListviewitem As New ListViewItem
                    Dim MyPhoto As Bitmap = Nothing

                    'Try
                    '    Dim newMstream As New System.IO.MemoryStream(CType(Record("Photograph"), Byte()))
                    '    'Dim ImageFromDB As New Bitmap(newMstream)
                    '    ReceipientImageList.Images.Add(Bitmap.FromStream((newMstream)))
                    '    MyListviewitem.ImageIndex = ReceipientImageList.Images.Count - 1
                    'Catch ex As Exception

                    If Record("Gender") = "Male" Then
                        MyListviewitem.ImageIndex = 0
                    ElseIf Record("Gender") = "Female" Then
                        MyListviewitem.ImageIndex = 1
                    End If

                    'End Try

                    MyListviewitem.Tag = Record("AccountID")
                    MyListviewitem.Text = FullName

                    Dim IsItemFound As Boolean = False
                    For Each TheItem As ListViewItem In SelectedEmployees.Items
                        If TheItem.Tag = MyListviewitem.Tag Then
                            IsItemFound = True
                        End If
                    Next

                    If IsItemFound = True Then
                        MyListviewitem.Checked = True
                    End If

                    lvReceipientsEmployees.Items.Add(MyListviewitem)

                    Dim UserString As String = Record("AccountID") & ":" & MyListviewitem.ImageIndex.ToString & ":" & MyListviewitem.Text & ":" & "Employee"
                    UsersComboBox.Items.Add(UserString)
                Next

            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub




    Private Sub LoadEmployees() Handles cmdRefresh.Click, Me.Load
        lblUserName.Text = FullNameofUser

        'lvReceipientsEmployees.Items.Clear()
        'lvReceipientsEmployers.Items.Clear()
        'UsersComboBox.Items.Clear()

        'Dim con As SqlConnection = New SqlConnection
        'con.ConnectionString = MyConnectionString
        'Dim Query As String = "Select AccountID,FirstName,MiddleName,LastName,Gender From mainlogin"
        'Dim FullName As String = Nothing

        'Try

        '    Dim MyTableAdapter As SqlDataAdapter = New SqlDataAdapter(Query, con)
        '    Dim MyTable As New DataTable

        '    MyTableAdapter.Fill(MyTable)

        '    If MyTable.Rows.Count > 0 Then

        '        For Each Record In MyTable.Rows
        '            If Record("MiddleName") <> "" Then
        '                FullName = Record("FirstName") & " " & Record("MiddleName") & " " & Record("LastName")
        '            Else
        '                FullName = Record("FirstName") & " " & Record("LastName")
        '            End If

        '            Dim MyListviewitem As New ListViewItem
        '            Dim MyPhoto As Bitmap = Nothing

        '            Try
        '                Dim newMstream As New System.IO.MemoryStream(CType(Record("Photograph"), Byte()))
        '                'Dim ImageFromDB As New Bitmap(newMstream)
        '                ReceipientImageList.Images.Add(Bitmap.FromStream((newMstream)))
        '                MyListviewitem.ImageIndex = ReceipientImageList.Images.Count - 1
        '            Catch ex As Exception
        '                If Record("Gender") = "Male" Then
        '                    MyListviewitem.ImageIndex = 0
        '                ElseIf Record("Gender") = "Female" Then
        '                    MyListviewitem.ImageIndex = 1
        '                End If
        '            End Try

        '            MyListviewitem.Tag = Record("AccountID")
        '            MyListviewitem.Text = FullName
        '            lvReceipientsEmployees.Items.Add(MyListviewitem)

        '            Dim UserString As String = Record("AccountID") & ":" & MyListviewitem.ImageIndex.ToString & ":" & MyListviewitem.Text & ":" & "Employee"
        '            UsersComboBox.Items.Add(UserString)
        '        Next

        '    End If

        CheckNormalMessagesCount()
        CheckOldMessagesCount()
        CheckSentMessagesCount()
        CheckUrgentMessagesCount()
        lblUserName.Text = FullNameofUser
        LoadDepartments()

        'LoadEmployers()

        'Catch ex As Exception
        '    MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try



    End Sub


#Region "Moving the Form"



    Private Sub Form_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) 

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If




    End Sub




    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) 

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If




    End Sub




    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) 

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing

        End If



    End Sub

#End Region




    'Private Sub radEmployers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If radEmployers.Checked = True Then
    '        lvReceipientsEmployers.BringToFront()
    '    Else
    '        lvReceipientsEmployees.BringToFront()
    '    End If



    'End Sub




    Private Sub cmdReceipients_Click() Handles cmdReceipients.Click, cmdReceipient2.Click
        If PanelReceipients.Visible = True Then
            tmrLockReceipients.Enabled = True
            tmrUnlockReceipients.Enabled = False
            chkCheckAll.Visible = False
        Else
            tmrLockReceipients.Enabled = False
            tmrUnlockReceipients.Enabled = True
            PanelReceipients.Visible = True
            PanelReceipients.BringToFront()
        End If



    End Sub




    Private Sub Panel2_Paint() Handles PanelBody.Click
        tmrLockReceipients.Enabled = True
        tmrUnlockReceipients.Enabled = False
        chkCheckAll.Visible = False



    End Sub




    Private Sub cmdSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSend.Click
        If txtMessage.Text <> "" Then



            If txtSubject.Text <> "" Then
A:              If SelectedEmployees.Items.Count > 0 Then
                    For Each Item As ListViewItem In SelectedEmployees.Items
                            For Each ComboItem As String In UsersComboBox.Items
                                If ComboItem.Contains(Item.Tag.ToString) Then
                                    Dim SplitName As String() = ComboItem.Trim.Split(":")
                                    If chkUrgency.Checked = True Then



                                        SendMessage(Item.Tag.ToString, txtMessage.Text, "Urgent", txtSubject.Text, SplitName(2), LoadedAttachmentname)
                                    Else



                                        SendMessage(Item.Tag.ToString, txtMessage.Text, "Not-Urgent", txtSubject.Text, SplitName(2), LoadedAttachmentname)
                                    End If
                                End If
                            Next
                    Next

                    'For Each Item As ListViewItem In lvReceipientsEmployers.Items
                    '    If Item.Checked = True Then
                    '        For Each ComboItem As String In UsersComboBox.Items
                    '            If ComboItem.Contains(Item.Tag.ToString) Then
                    '                Dim SplitName As String() = ComboItem.Trim.Split(":")
                    '                If chkUrgency.Checked = True Then



                    '                    SendMessage(Item.Tag.ToString, txtMessage.Text, "Urgent", txtSubject.Text, SplitName(2), LoadedAttachmentname)
                    '                Else



                    '                    SendMessage(Item.Tag.ToString, txtMessage.Text, "Not-Urgent", txtSubject.Text, SplitName(2), LoadedAttachmentname)
                    '                End If
                    '            End If
                    '        Next
                    '    End If
                    'Next

                    txtMessage.Clear()



                    txtSubject.Text = ""
                    chkCheckAll.Checked = False
                    chkUrgency.Checked = False
                    LoadedAttachmentname = ""
                    MessageBox.Show("Message(s) Sent", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Please select atleast one receipient for the Message", "Missing Receipients", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tmrLockReceipients.Enabled = False
                    tmrUnlockReceipients.Enabled = True
                    PanelReceipients.Visible = True
                    PanelReceipients.BringToFront()
                End If
            Else



                If MessageBox.Show("This message has no MessageSubject, would you like to add one?", "No MessageSubject", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then



                    txtSubject.Text = "No MessageSubject"
                    GoTo A
                Else



                    txtSubject.Focus()
                End If
            End If
        Else
            MessageBox.Show("Please enter a message prior to clicking the Send button", "Missing Text", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMessage.Focus()
        End If



    End Sub




    Private Sub SendMessage(ByVal DReceipient As String, ByVal TheMessage As String, ByVal Urgency As String, ByVal MessageSubject As String, ByVal ReceipientName As String, ByVal AttachmentName As String)
        Dim con As SqlConnection = New SqlConnection
        con.ConnectionString = MyConnectionString
        Dim Query As String

        If AttachmentName <> "" Then



            Query = "Insert Into message(SenderID,ReceipientID,MessageBody,Urgency,MessageSubject,SenderName,ReceipientName,InputDate, MessageStatus, Attachment, AttachmentName) Values(@SenderID,@ReceipientID,@MessageBody,@Urgency,@MessageSubject,@SenderName,@ReceipientName,@InputDate, @MessageStatus, @Attachment, @AttachmentName)"
        Else



            Query = "Insert Into message(SenderID,ReceipientID,MessageBody,Urgency,MessageSubject,SenderName,ReceipientName,InputDate, MessageStatus) Values(@SenderID,@ReceipientID,@MessageBody,@Urgency,@MessageSubject,@SenderName,@ReceipientName,@InputDate, @MessageStatus)"
        End If

        Try
            con.Open()
            Dim conCommand As SqlCommand = New SqlCommand(Query, con)
            Dim MyDTP As New DateTimePicker
            'Dim FullDate As String = MyDTP.Value.Year & "-" & MyDTP.Value.Month & "-" & MyDTP.Value.Day

            With conCommand.Parameters
                .AddWithValue("@SenderID", CurrentUserID)
                .AddWithValue("@ReceipientID", DReceipient)
                .AddWithValue("@MessageBody", TheMessage)
                .AddWithValue("@Urgency", Urgency)



                .AddWithValue("@MessageSubject", MessageSubject)
                .AddWithValue("@SenderName", FullNameofUser)
                .AddWithValue("@InputDate", MyDTP.Value)
                .AddWithValue("@ReceipientName", ReceipientName)
                .AddWithValue("@MessageStatus", "UnRead")

                If AttachmentName <> "" Then
                    .AddWithValue("@Attachment", GetByteData(txtAttachment.Text))
                    .AddWithValue("@AttachmentName", AttachmentName)
                End If

            End With

            conCommand.ExecuteNonQuery()
 
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show("Connection Error, Please try again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try



    End Sub

    Private Function GetByteData(ByVal FilePath As String) As Byte()
        Try

            If FilePath.ToCharArray.Count > 0 Then

                Dim fInfo As New FileInfo(FilePath)

                Dim numBytes As Long = fInfo.Length

                Dim fStream As New FileStream(FilePath, FileMode.Open, FileAccess.Read)

                Dim br As New BinaryReader(fStream)

                Dim data As Byte() = br.ReadBytes(CInt(numBytes))

                br.Close()

                fStream.Close()

                Return data
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function




    Public Sub LoadNewMessages()
        lvNewMessages.Items.Clear()
        Dim con As SqlConnection = New SqlConnection
        con.ConnectionString = MyConnectionString



        Dim Query As String = "Select MessageID,SenderID,SenderName,MessageSubject,Urgency,InputDate From message Where ReceipientID='" & CurrentUserID & "' And MessageStatus='UnRead'"
        Dim FullName As String = Nothing
        Dim MessageText As String = Nothing
        Dim MessageTag As String = Nothing

        Try

            Dim MyTableAdapter As SqlDataAdapter = New SqlDataAdapter(Query, con)
            Dim MyTable As New DataTable
            MyTableAdapter.Fill(MyTable)

            If MyTable.Rows.Count > 0 Then
                pbStatus.Visible = False
                lblStatus.Visible = False

                For Each Record In MyTable.Rows
                    Dim CompleteDate As New DateTimePicker
                    CompleteDate.Value = Record("InputDate")
                    Dim ConvertedDate As String = CompleteDate.Value.Day & "/" & CompleteDate.Value.Month & "/" & CompleteDate.Value.Year



                    MessageTag = Record("SenderName") & ":" & Record("MessageSubject") & ":" & Record("Urgency") & ":" & ConvertedDate & ":" & Record("MessageID") & ":" & Record("SenderID")



                    MessageText = Record("SenderName").ToString.ToUpper & " - " & Record("MessageSubject") & " - Urgency: " & Record("Urgency")

                    Dim Mylistviewitem As ListViewItem = New ListViewItem

                    If Record("Urgency") = "Urgent" Then
                        Mylistviewitem.Font = New Font("Calibri", 10, FontStyle.Regular)
                        Mylistviewitem.ForeColor = Color.Sienna
                        'Mylistviewitem.Group = lvNewMessages.Groups("UrgentListViewGroup")
                    Else
                        Mylistviewitem.Font = New Font("Calibri", 10, FontStyle.Regular)
                        Mylistviewitem.ForeColor = Color.Black
                    End If

                    'Mylistviewitem.Text = MessageText
                    'Mylistviewitem.Tag = MessageTag

                    Dim ItemSplit As String() = Nothing

                    For Each Item As String In UsersComboBox.Items
                        If Item.Contains(Record("SenderID")) Then
                            ItemSplit = Item.ToString.Trim.Split(":")
                            Mylistviewitem.ImageIndex = ItemSplit(1)
                        End If
                    Next


                    Mylistviewitem = lvNewMessages.Items.Add(Record("SenderName"))

                    With Mylistviewitem



                        .SubItems.Add(Record("MessageSubject"))



                        .SubItems.Add(Record("Urgency"))



                        .SubItems.Add(ConvertedDate)

                        Mylistviewitem.Tag = MessageTag

                        If ItemSplit IsNot Nothing Then
                            If ItemSplit.Count > 1 Then
                                If ItemSplit(1) <> "" Then
                                    'Mylistviewitem.ImageIndex = TheIndex
                                End If
                            Else
                                'Mylistviewitem.ImageIndex = TheIndex
                            End If
                        Else
                            'Mylistviewitem.ImageIndex = 0
                        End If

                    End With


                    'lvNewMessages.Items.Add(Mylistviewitem)

                Next

            Else
                lblStatus.Visible = True
                pbStatus.Visible = True
                lblStatus.Text = "Inbox Empty"
                lblStatus.BringToFront()
                pbStatus.BringToFront()
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub




    Public Sub LoadOldMessages()
        lvRead.Items.Clear()
        Dim con As SqlConnection = New SqlConnection
        con.ConnectionString = MyConnectionString



        Dim Query As String = "Select MessageID,SenderID,SenderName,MessageSubject,Urgency,InputDate From message Where ReceipientID='" & CurrentUserID & "' And MessageStatus='Read'"
        Dim FullName As String = Nothing
        Dim MessageText As String = Nothing
        Dim MessageTag As String = Nothing

        'Try
        con.Open()
        Dim MyTableAdapter As SqlDataAdapter = New SqlDataAdapter(Query, con)
        Dim MyTable As New DataTable
        MyTableAdapter.Fill(MyTable)
        con.Close()

        If MyTable.Rows.Count > 0 Then

            For Each Record In MyTable.Rows
                Dim CompleteDate As New DateTimePicker
                CompleteDate.Value = Record("InputDate")
                Dim ConvertedDate As String = CompleteDate.Value.Day & "/" & CompleteDate.Value.Month & "/" & CompleteDate.Value.Year
                MessageTag = Record("MessageID") & ":" & Record("SenderID")

                Dim TheIndex As Integer
                Dim Mylistviewitem As ListViewItem = New ListViewItem

                Dim ItemSplit As String() = Nothing

                For Each Item As String In UsersComboBox.Items
                    If Item.Contains(Record("SenderID")) Then
                        ItemSplit = Item.ToString.Trim.Split(":")
                        TheIndex = ItemSplit(1)
                    End If
                Next

                Mylistviewitem = lvRead.Items.Add(Record("SenderName"))

                With Mylistviewitem



                    .SubItems.Add(Record("MessageSubject"))



                    .SubItems.Add(Record("Urgency"))



                    .SubItems.Add(ConvertedDate)



                    .SubItems.Add(Record("MessageID"))
                    Mylistviewitem.Tag = MessageTag

                    If (Not ItemSplit Is Nothing) Then
                        If ItemSplit(1) <> "" Then
                            Mylistviewitem.ImageIndex = TheIndex
                        End If
                    Else
                        Mylistviewitem.ImageIndex = TheIndex
                    End If

                End With


            Next

        Else
            lblStatus.Visible = True
            pbStatus.Visible = True
            lblStatus.Text = "No Old Messages"
            lblStatus.BringToFront()
            pbStatus.BringToFront()
        End If

        'Catch ex As Exception
        '    MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try



    End Sub




    Public Sub LoadSentMessages()
        lvSent.Items.Clear()
        Dim con As SqlConnection = New SqlConnection
        con.ConnectionString = MyConnectionString



        Dim Query As String = "Select MessageID,SenderID,SenderName,ReceipientName,MessageSubject,Urgency,InputDate,MessageStatus,ReceipientID From message Where SenderID='" & CurrentUserID & "'"
        Dim FullName As String = Nothing
        Dim MessageText As String = Nothing
        Dim MessageTag As String = Nothing

        Try
            con.Open()
            Dim MyTableAdapter As SqlDataAdapter = New SqlDataAdapter(Query, con)
            Dim MyTable As New DataTable
            MyTableAdapter.Fill(MyTable)
            con.Close()

            If MyTable.Rows.Count > 0 Then

                For Each Record In MyTable.Rows
                    Dim CompleteDate As New DateTimePicker
                    CompleteDate.Value = Record("InputDate")
                    Dim ConvertedDate As String = CompleteDate.Value.Day & "/" & CompleteDate.Value.Month & "/" & CompleteDate.Value.Year
                    MessageTag = Record("MessageID")

                    Dim Mylistviewitem As ListViewItem = New ListViewItem

                    Dim ItemSplit As String() = Nothing
                    Dim TheIndex As String = Nothing

                    For Each Item As String In UsersComboBox.Items
                        ItemSplit = Item.ToString.Trim.Split(":")
                        If ItemSplit(0) = Record("ReceipientID") Then
                            TheIndex = ItemSplit(1)
                        End If
                    Next

                    Mylistviewitem = lvSent.Items.Add(Record("ReceipientName"))

                    With Mylistviewitem



                        .SubItems.Add(Record("MessageStatus"))



                        .SubItems.Add(Record("MessageSubject"))



                        .SubItems.Add(Record("Urgency"))



                        .SubItems.Add(ConvertedDate)



                        .SubItems.Add(Record("MessageID"))
                        Mylistviewitem.Tag = MessageTag

                        If ItemSplit IsNot Nothing Then
                            If ItemSplit.Count > 1 Then
                                If ItemSplit(1) <> "" Then
                                    Mylistviewitem.ImageIndex = TheIndex
                                End If
                            Else
                                Mylistviewitem.ImageIndex = TheIndex
                            End If
                        Else
                            Mylistviewitem.ImageIndex = 0
                        End If

                    End With

                Next

            Else
                lblStatus.Visible = True
                pbStatus.Visible = True
                lblStatus.Text = "Outbox Empty"
                lblStatus.BringToFront()
                pbStatus.BringToFront()

            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub


#Region "Moving the Form"




    Private Sub Panel4_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If




    End Sub




    Private Sub Panel4_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If




    End Sub




    Private Sub Panel4_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = PanelNewMessage.Location.X + (e.X - MouseDownX)
            temp.Y = PanelNewMessage.Location.Y + (e.Y - MouseDownY)
            PanelNewMessage.Location = temp
            temp = Nothing

        End If



    End Sub

#End Region




    Private Sub cmdCloseNewMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCloseNewMessage.Click
        PanelNewMessage.Visible = False



    End Sub




    Private Sub cmdNewMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewMessage.Click, cmdNewMessages.Click
        PanelNewMessage.Visible = True
        PanelNewMessage.Location = New Point(203, 21)
        PanelNewMessage.BringToFront()


        txtSubject.Focus()


    End Sub




    Private Sub PanelNewMessage_TheClick() Handles PanelNewMessage.Click
        PanelNewMessage.BringToFront()



    End Sub




    Private Sub PanelReceipients_Paint() Handles PanelReceipients.Click
        PanelReceipients.BringToFront()



    End Sub




    Private Sub lvNewMessages_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lvNewMessages.MouseClick
        If lvNewMessages.SelectedItems.Count > 0 Then
            If e.Button = System.Windows.Forms.MouseButtons.Left Then
                ToolTip1.Hide(lvNewMessages)
                Dim TheText As String() = lvNewMessages.FocusedItem.Tag.ToString.Trim.Split(":")
                ToolTip1.ToolTipTitle = "Message Info"



                Dim TheMessage As String = "From: " & TheText(0) & vbNewLine & "MessageSubject: " & TheText(1) & vbNewLine & "Urgency: " & TheText(2) & vbNewLine & "Date: " & TheText(3)
                ToolTip1.Show(TheMessage, lvNewMessages, e.X - 15, e.Y - 100)
            End If
        End If



    End Sub




    Private Sub lvNewMessage_SelectedindexChanged(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lvNewMessages.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            If lvNewMessages.SelectedItems.Count > 0 Then
                Dim con As SqlConnection = New SqlConnection
                con.ConnectionString = MyConnectionString

                Dim theID As String() = lvNewMessages.FocusedItem.Tag.ToString.Trim.Split(":")



                Dim Query As String = "Select MessageBody,SenderName,MessageSubject,InputDate,SenderID,AttachmentName,Attachment From message Where MessageID='" & theID(4) & "'"
                Dim FullName As String = Nothing
                Dim MessageText As String = Nothing
                Dim MessageTag As String = Nothing

                Try

                    Dim MyTableAdapter As SqlDataAdapter = New SqlDataAdapter(Query, con)
                    Dim MyTable As New DataTable
                    MyTableAdapter.Fill(MyTable)

                    If MyTable.Rows.Count > 0 Then
                        PanelMain.Visible = False
                        PanelViewMessage.Visible = True

                        txtViewMessage.Text = MyTable.Rows(0).Item("MessageBody")
                        lblSender.Text = MyTable.Rows(0).Item("SenderName")



                        lblSubject.Text = MyTable.Rows(0).Item("MessageSubject")

                        Dim MYDTP As New DateTimePicker
                        MYDTP.Value = MyTable.Rows(0).Item("InputDate")

                        lblDate.Text = MYDTP.Value.Day & "/" & MYDTP.Value.Month & "/" & MYDTP.Value.Year

                        For Each item As String In UsersComboBox.Items
                            If item.Contains("Employer") And item.Contains(MyTable.Rows(0).Item("SenderID")) Then
                                pbSender.Image = DisplayEmployerSenderImage(MyTable.Rows(0).Item("SenderID"))
                            ElseIf item.Contains("Employee") And item.Contains(MyTable.Rows(0).Item("SenderID")) Then
                                pbSender.Image = DisplayEmployeeSenderImage(MyTable.Rows(0).Item("SenderID"))
                            End If
                        Next


                        If IsDBNull(MyTable.Rows(0).Item("AttachmentName")) = False Then
                            If MyTable.Rows(0).Item("AttachmentName") <> "" Then
                                Dim lvitem As New ListViewItem
                                lvitem.Tag = MyTable.Rows(0).Item("AttachmentName")
                                lvitem.Text = MyTable.Rows(0).Item("AttachmentName")
                                lvitem.ImageIndex = 0

                                MyListView.Items.Clear()
                                MyListView.Items.Add(lvitem)
                                AttachmentFile = MyTable.Rows(0).Item("Attachment")
                            Else
                                MyListView.Items.Clear()
                                AttachmentFile = Nothing
                            End If
                        Else
                            MyListView.Items.Clear()
                            AttachmentFile = Nothing
                        End If
                    End If

                    UpdateMessageInfo()

                    lvNewMessages.FocusedItem.Font = New Font("Calibri", 10, FontStyle.Regular)

                Catch ex As Exception
                    MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If



    End Sub

    Private Function DisplayEmployeeSenderImage(ByVal DSender As String) As Image
        Dim con As SqlConnection = New SqlConnection
        con.ConnectionString = MyConnectionString
        Dim Query As String = "Select Photograph From employeeregistration Where AccountID='" & DSender & "'"
        Dim FullName As String = Nothing

        Try
            con.Open()
            Dim MyTableAdapter As SqlDataAdapter = New SqlDataAdapter(Query, con)
            Dim MyTable As New DataTable

            MyTableAdapter.Fill(MyTable)
            con.Close()

            If MyTable.Rows.Count > 0 Then
                Dim newMstream As New System.IO.MemoryStream(CType(MyTable.Rows(0).Item("Photograph"), Byte()))
                'Dim ImageFromDB As New Bitmap(newMstream)
                ReceipientImageList.Images.Add(Bitmap.FromStream((newMstream)))
                DisplayEmployeeSenderImage = Bitmap.FromStream((newMstream))
                Return DisplayEmployeeSenderImage
            End If

        Catch EX As Exception
            'MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Private Function DisplayEmployerSenderImage(ByVal DSender As String) As Image
        Dim con As SqlConnection = New SqlConnection
        con.ConnectionString = MyConnectionString
        Dim Query As String = "Select Photograph From employer Where EmployerID='" & DSender & "'"
        Dim FullName As String = Nothing

        Try
            con.Open()
            Dim MyTableAdapter As SqlDataAdapter = New SqlDataAdapter(Query, con)
            Dim MyTable As New DataTable

            MyTableAdapter.Fill(MyTable)
            con.Close()

            If MyTable.Rows.Count > 0 Then
                Dim newMstream As New System.IO.MemoryStream(CType(MyTable.Rows(0).Item("Photograph"), Byte()))
                'Dim ImageFromDB As New Bitmap(newMstream)
                ReceipientImageList.Images.Add(Bitmap.FromStream((newMstream)))
                DisplayEmployerSenderImage = Bitmap.FromStream((newMstream))
                Return DisplayEmployerSenderImage
            End If

        Catch EX As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function





    Private Sub UpdateMessageInfo()
        Dim con As SqlConnection = New SqlConnection
        con.ConnectionString = MyConnectionString

        Dim theID As String() = lvNewMessages.FocusedItem.Tag.ToString.Trim.Split(":")
        Dim Query As String = "Update message Set MessageStatus=@MessageStatus Where MessageID='" & theID(4) & "'"

        Try
            con.Open()

            Dim concommand As SqlCommand = New SqlCommand(Query, con)
            concommand.Parameters.AddWithValue("@MessageStatus", "Read")
            concommand.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub



    Private Sub lvNewMessage_mouseleave() Handles lvNewMessages.MouseLeave
        ToolTip1.Hide(lvNewMessages)



    End Sub




    Private Sub cmdCloseReceipient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCloseReceipient.Click
        cmdReceipients_Click()



    End Sub




    Private Sub LoadContextMenu(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lvNewMessages.MouseClick, lvRead.MouseClick, lvSent.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            If lvNewMessages.Visible = True Then
                If lvNewMessages.SelectedItems.Count > 0 Then
                    DeleteToolStripMenuItem.Enabled = True
                    ReplyToolStripMenuItem.Enabled = True
                    ContextMenuStrip1.Show(Cursor.Position)
                Else
                    DeleteToolStripMenuItem.Enabled = False
                    ReplyToolStripMenuItem.Enabled = False
                    ContextMenuStrip1.Show(Cursor.Position)
                End If
            ElseIf lvSent.Visible = True Then
                If lvSent.SelectedItems.Count > 0 Then
                    DeleteToolStripMenuItem.Enabled = True
                    ReplyToolStripMenuItem.Enabled = False
                    ContextMenuStrip1.Show(Cursor.Position)
                Else
                    DeleteToolStripMenuItem.Enabled = False
                    ReplyToolStripMenuItem.Enabled = False
                    ContextMenuStrip1.Show(Cursor.Position)
                End If
            ElseIf lvRead.Visible = True Then
                If lvRead.SelectedItems.Count = 1 Then
                    DeleteToolStripMenuItem.Enabled = True
                    ReplyToolStripMenuItem.Enabled = True
                    ContextMenuStrip1.Show(Cursor.Position)
                ElseIf lvRead.SelectedItems.Count > 1 Then
                    DeleteToolStripMenuItem.Enabled = True
                    ReplyToolStripMenuItem.Enabled = False
                    ContextMenuStrip1.Show(Cursor.Position)
                Else
                    DeleteToolStripMenuItem.Enabled = False
                    ReplyToolStripMenuItem.Enabled = False
                    ContextMenuStrip1.Show(Cursor.Position)
                End If
            End If
        End If



    End Sub




    Private Sub DeleteMessage(ByVal MessageID As String)
        If MessageBox.Show("Please confirm the delete operation, note that this process is irreversible!", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
            Dim con As New SqlConnection
            con.ConnectionString = MyConnectionString
            Dim Query As String = "Delete From message Where MessageID='" & MessageID & "'"
            Try
                con.Open()
                Dim ConCommand As New SqlCommand(Query, con)
                ConCommand.ExecuteNonQuery()
                con.Close()

                Dim NewPictureBox As New PictureBox
                pbSender.Image = NewPictureBox.Image

            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If



    End Sub




    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If lvNewMessages.Visible = True Then
            Dim MessageID As String() = lvNewMessages.FocusedItem.Tag.ToString.Trim.Split(":")
            DeleteMessage(MessageID(4))
            lvNewMessages.FocusedItem.Remove()
        ElseIf lvSent.Visible = True Then
            For Each MyListviewitem As ListViewItem In lvSent.SelectedItems
                DeleteMessage(MyListviewitem.Tag.ToString)
                MyListviewitem.Remove()
            Next
        ElseIf lvRead.Visible = True Then
            For Each Mylistviewitem As ListViewItem In lvRead.SelectedItems
                Dim MessageID As String() = lvRead.FocusedItem.Tag.ToString.Trim.Split(":")
                DeleteMessage(MessageID(0))
                Mylistviewitem.Remove()
            Next
        End If

        PanelMain.Visible = True
        PanelViewMessage.Visible = False
        lblSender.Text = ""



        lblSubject.Text = ""
        lblDate.Text = ""
        txtViewMessage.Clear()




    End Sub




    Private Sub ReplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplyToolStripMenuItem.Click
        Dim TheSenderID As String = Nothing

        If lvNewMessages.Visible = True Then



            Dim SenderID As String() = lvNewMessages.FocusedItem.SubItems(0).Tag.ToString.Trim.Split(":")
            TheSenderID = SenderID(5)
        ElseIf lvRead.Visible = True Then
            For Each MyItem As ListViewItem In lvRead.SelectedItems
                Dim SenderID As String() = MyItem.Tag.ToString.Trim.Split(":")
                TheSenderID = SenderID(1)
            Next
        End If

        For Each ITEM As ListViewItem In SelectedEmployees.Items
            If ITEM.Tag.ToString = TheSenderID Then
                ITEM.Checked = True
            Else
                ITEM.Checked = False
            End If
        Next

        'For Each ITEM As ListViewItem In lvReceipientsEmployers.Items
        '    If ITEM.Tag.ToString = TheSenderID Then
        '        ITEM.Checked = True
        '    Else
        '        ITEM.Checked = False
        '    End If
        'Next

        PanelNewMessage.Location = New Point(203, 21)
        PanelNewMessage.Visible = True
        PanelNewMessage.BringToFront()



        txtSubject.Focus()



    End Sub




    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        If lvNewMessages.Visible = True Then
            LoadNewMessages()
        ElseIf lvSent.Visible = True Then
            LoadSentMessages()
        ElseIf lvRead.Visible = True Then
            LoadOldMessages()
        End If




    End Sub




    Private Sub cmdInbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInbox.Click, lblUrgentInbox.Click, lblNormalInbox.Click
        PanelMessageSummary.Visible = False
        lvNewMessages.Visible = True
        lvSent.Visible = False
        lvRead.Visible = False
        LoadNewMessages()
        lblView.Text = "Inbox"



    End Sub




    Private Sub cmdOutbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOutbox.Click, lblOutbox.Click
        PanelMessageSummary.Visible = False
        lvNewMessages.Visible = False
        lvSent.Visible = True
        lvRead.Visible = False
        pbStatus.Visible = False
        lblStatus.Visible = False
        LoadSentMessages()
        lblView.Text = "Outbox"



    End Sub




    Private Sub cmdRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRead.Click, lblRead.Click
        PanelMessageSummary.Visible = False
        lvNewMessages.Visible = False
        lvSent.Visible = False
        lvRead.Visible = True
        pbStatus.Visible = False
        lblStatus.Visible = False
        LoadOldMessages()
        lblView.Text = "Old Messages"



    End Sub




    Private Sub cmdMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMainMenu.Click
        PanelViewMessage.Visible = False
        PanelMain.Visible = True



    End Sub




    Public Sub CheckUrgentMessagesCount()
        Dim con As SqlConnection = New SqlConnection
        con.ConnectionString = MyConnectionString

        Dim Query As String = "Select Count(*) From message Where ReceipientID='" & CurrentUserID & "' And Urgency='Urgent' And MessageStatus='UnRead'"

        Try
            con.Open()
            Dim concommand As SqlCommand = New SqlCommand(Query, con)
            lblUrgentInbox.Text = concommand.ExecuteScalar
            con.Close()

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub




    Public Sub CheckNormalMessagesCount()
        Dim con As SqlConnection = New SqlConnection
        con.ConnectionString = MyConnectionString

        Dim Query As String = "Select Count(*) From message Where ReceipientID='" & CurrentUserID & "' And Urgency='Not-Urgent' And MessageStatus='UnRead'"

        Try
            con.Open()
            Dim concommand As SqlCommand = New SqlCommand(Query, con)
            lblNormalInbox.Text = concommand.ExecuteScalar
            con.Close()

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub




    Public Sub CheckOldMessagesCount()
        Dim con As SqlConnection = New SqlConnection
        con.ConnectionString = MyConnectionString

        Dim Query As String = "Select Count(*) From message Where ReceipientID='" & CurrentUserID & "' And MessageStatus='Read'"

        Try
            con.Open()
            Dim concommand As SqlCommand = New SqlCommand(Query, con)
            lblRead.Text = concommand.ExecuteScalar
            con.Close()

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub




    Public Sub CheckSentMessagesCount()
        Dim con As SqlConnection = New SqlConnection
        con.ConnectionString = MyConnectionString

        Dim Query As String = "Select Count(*) From message Where SenderID='" & CurrentUserID & "'"

        Try
            con.Open()
            Dim concommand As SqlCommand = New SqlCommand(Query, con)
            lblOutbox.Text = concommand.ExecuteScalar
            con.Close()

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub




    Private Sub cmdSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSummary.Click
        CheckNormalMessagesCount()
        CheckOldMessagesCount()
        CheckSentMessagesCount()
        CheckUrgentMessagesCount()

        PanelMessageSummary.Visible = True
        lvRead.Visible = False
        lvSent.Visible = False
        lvNewMessages.Visible = False
        lblView.Text = "Messaging System"

        lblStatus.Visible = False
        pbStatus.Visible = False
        lblStatus.Text = ""
        lblStatus.SendToBack()
        pbStatus.SendToBack()



    End Sub




    Private Sub lvSent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles lvSent.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            If lvSent.SelectedItems.Count = 1 Then
                Dim con As SqlConnection = New SqlConnection
                con.ConnectionString = MyConnectionString
                Dim theID As String

                For Each MyItem As ListViewItem In lvSent.SelectedItems
                    theID = MyItem.Tag.ToString
                Next




                Dim Query As String = "Select MessageBody,SenderName,MessageSubject,InputDate,SenderID,Attachment,AttachmentName From message Where MessageID='" & theID & "'"
                Dim FullName As String = Nothing
                Dim MessageText As String = Nothing
                Dim MessageTag As String = Nothing

                Try

                    Dim MyTableAdapter As SqlDataAdapter = New SqlDataAdapter(Query, con)
                    Dim MyTable As New DataTable
                    MyTableAdapter.Fill(MyTable)

                    If MyTable.Rows.Count > 0 Then
                        PanelMain.Visible = False
                        PanelViewMessage.Visible = True

                        txtViewMessage.Text = MyTable.Rows(0).Item("MessageBody")
                        lblSender.Text = MyTable.Rows(0).Item("SenderName")



                        lblSubject.Text = MyTable.Rows(0).Item("MessageSubject")

                        Dim MYDTP As New DateTimePicker
                        MYDTP.Value = MyTable.Rows(0).Item("InputDate")

                        lblDate.Text = MYDTP.Value.Day & "/" & MYDTP.Value.Month & "/" & MYDTP.Value.Year

                        For Each item As String In UsersComboBox.Items
                            If item.Contains("Employer") And item.Contains(MyTable.Rows(0).Item("SenderID")) Then
                                pbSender.Image = DisplayEmployerSenderImage(MyTable.Rows(0).Item("SenderID"))
                            ElseIf item.Contains("Employee") And item.Contains(MyTable.Rows(0).Item("SenderID")) Then
                                pbSender.Image = DisplayEmployeeSenderImage(MyTable.Rows(0).Item("SenderID"))
                            End If
                        Next

                        If IsDBNull(MyTable.Rows(0).Item("AttachmentName")) = False Then
                            If MyTable.Rows(0).Item("AttachmentName") <> "" Then
                                Dim lvitem As New ListViewItem
                                lvitem.Tag = MyTable.Rows(0).Item("AttachmentName")
                                lvitem.Text = MyTable.Rows(0).Item("AttachmentName")
                                lvitem.ImageIndex = 0

                                MyListView.Items.Clear()
                                MyListView.Items.Add(lvitem)
                                AttachmentFile = MyTable.Rows(0).Item("Attachment")
                            Else
                                MyListView.Items.Clear()
                                AttachmentFile = Nothing
                            End If
                        Else
                            MyListView.Items.Clear()
                            AttachmentFile = Nothing
                        End If

                    End If

                Catch ex As Exception
                    MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If



    End Sub




    Private Sub lvRead_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles lvRead.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            If lvRead.SelectedItems.Count = 1 Then
                Dim con As SqlConnection = New SqlConnection
                con.ConnectionString = MyConnectionString

                Dim theID As String = Nothing

                For Each MyItem As ListViewItem In lvRead.SelectedItems
                    Dim SplitString As String() = MyItem.Tag.ToString.Trim.Split(":")
                    theID = SplitString(0)
                Next

                Dim Query As String = "Select * From message Where MessageID='" & theID & "'"
                Dim FullName As String = Nothing
                Dim MessageText As String = Nothing
                Dim MessageTag As String = Nothing

                Try

                    Dim MyTableAdapter As SqlDataAdapter = New SqlDataAdapter(Query, con)
                    Dim MyTable2 As New DataTable
                    MyTableAdapter.Fill(MyTable2)

                    If MyTable2.Rows.Count > 0 Then
                        PanelMain.Visible = False
                        PanelViewMessage.Visible = True

                        txtViewMessage.Text = MyTable2.Rows(0).Item("MessageBody")
                        lblSender.Text = MyTable2.Rows(0).Item("SenderName")



                        lblSubject.Text = MyTable2.Rows(0).Item("MessageSubject")

                        Dim MYDTP As New DateTimePicker
                        MYDTP.Value = MyTable2.Rows(0).Item("InputDate")

                        lblDate.Text = MYDTP.Value.Day & "/" & MYDTP.Value.Month & "/" & MYDTP.Value.Year

                        For Each item As String In UsersComboBox.Items
                            If item.Contains("Employer") And item.Contains(MyTable2.Rows(0).Item("SenderID")) Then
                                pbSender.Image = DisplayEmployerSenderImage(MyTable2.Rows(0).Item("SenderID"))
                            ElseIf item.Contains("Employee") And item.Contains(MyTable2.Rows(0).Item("SenderID")) Then
                                pbSender.Image = DisplayEmployeeSenderImage(MyTable2.Rows(0).Item("SenderID"))
                            End If
                        Next

                        If IsDBNull(MyTable2.Rows(0).Item("AttachmentName")) = False Then
                            If MyTable2.Rows(0).Item("AttachmentName") <> "" Then
                                Dim lvitem As New ListViewItem
                                lvitem.Tag = MyTable2.Rows(0).Item("AttachmentName")
                                lvitem.Text = MyTable2.Rows(0).Item("AttachmentName")
                                lvitem.ImageIndex = 0

                                MyListView.Items.Clear()
                                MyListView.Items.Add(lvitem)
                                AttachmentFile = MyTable2.Rows(0).Item("Attachment")
                            Else
                                MyListView.Items.Clear()
                                AttachmentFile = Nothing
                            End If
                        Else
                            MyListView.Items.Clear()
                            AttachmentFile = Nothing
                        End If

                    End If

                Catch ex As Exception
                    MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If

        End If



    End Sub




    'Private Sub CheckSystemLock() Handles Me.SizeChanged
    '    Try
    '        If IsSystemLocked = True Then
    '            frmSystemLock.WindowState = FormWindowState.Maximized
    '            frmSystemLock.BringToFront()
    '        End If
    '    Catch ex As Exception

    '    End Try



    'End Sub




    Private Sub txtViewMessage_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtViewMessage.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Right And txtViewMessage.SelectionLength > 0 Then
            ContextMenuStrip2.Show(Cursor.Position, ToolStripDropDownDirection.BelowRight)
        End If



    End Sub




    Private Sub CopySelectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopySelectionToolStripMenuItem.Click
        Clipboard.SetData(System.Windows.Forms.DataFormats.Text, txtViewMessage.SelectedText)



    End Sub




    Private Sub HideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideToolStripMenuItem.Click
        ContextMenuStrip2.Hide()



    End Sub




    Private Sub cmdReceipients_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReceipients.Click, cmdReceipient2.Click




    End Sub




    Private Sub cmdAttachFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAttachFile.Click
        Try
            Dim OFD1 As New OpenFileDialog
            OFD1.FileName = ""
            OFD1.Multiselect = False
            OFD1.Filter = "All Files|*.*"
            If OFD1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                LoadedAttachmentname = OFD1.SafeFileName
                txtAttachment.Text = OFD1.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub




    Private Sub MyListView_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyListView.MouseDoubleClick
        If MyListView.SelectedItems.Count > 0 Then
            Dim FSD As New SaveFileDialog
            FSD.FileName = MyListView.SelectedItems(0).Text
            FSD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            Dim Thesplit As String() = Nothing

            If MyListView.SelectedItems(0).Text.Contains(".") Then
                Thesplit = MyListView.SelectedItems(0).Text.Trim.Split(".")
            Else
                FSD.Filter = "All Files|*.*"
            End If

            If Thesplit.Count > 0 Then
                Dim TheFilter As String = Thesplit(1) & "|*" & Thesplit(1)
                FSD.Filter = TheFilter
            End If
             
            FSD.AddExtension = False

            If FSD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllBytes(FSD.FileName & "." & Thesplit(1), AttachmentFile, False)
                MessageBox.Show("Files successfully downloaded.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If




    End Sub
  



    Private Sub lstDepartments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDepartments.SelectedIndexChanged
        If lstDepartments.SelectedIndex <> -1 Then
            LoadEmployeesbyDepartmen(lstDepartments.SelectedItem)
        End If



    End Sub




    Private Sub lvReceipientsEmployees_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvReceipientsEmployees.ItemChecked
        If e.Item.Checked = True Then
            Dim IsItemFound As Boolean = False
            For Each TheItem As ListViewItem In SelectedEmployees.Items
                If TheItem.Tag = e.Item.Tag Then
                    IsItemFound = True
                End If
            Next

            If IsItemFound = False Then
                SelectedEmployees.Items.Add(e.Item.Clone)
            End If
        ElseIf e.Item.Checked = False Then

            Dim isItemFound As Boolean = False
            Dim ItemIndex As Integer
            For Each TheItem As ListViewItem In SelectedEmployees.Items
                If TheItem.Tag <> e.Item.Tag Then
                    ItemIndex += 1
                Else
                    isItemFound = True
                    Exit For
                End If
            Next

            If isItemFound = True Then
                SelectedEmployees.Items.RemoveAt(ItemIndex)
            End If
        End If



    End Sub
   
End Class
