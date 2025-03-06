Imports System.Data.SqlClient

Public Class frmAccountManager

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

    Dim isLoadingFeatures As Boolean

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



    Private Sub PanelTop_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If




    End Sub



    Private Sub PanelTop_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If




    End Sub




    Private Sub PanelTop_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing

        End If



    End Sub

#Region "Manage Users"


    Private Sub LoadUserComboDown() Handles UserIDLookupEdit.EditValueChanged
        If UserIDLookupEdit.EditValue <> "" Then
            LoadUser()
            lblInfo.Text = "Displaying User Information"
        End If

    End Sub




    Private Sub LoadBranches()

        Dim Con As SqlConnection = New SqlConnection
        Con.ConnectionString = MyConnectionString
        Dim Query As String = "Select BranchName from Branch"
        Dim MyTable As New DataTable

        Try

            Con.Open()
            Dim MyDataAdapter As SqlDataAdapter = New SqlDataAdapter(Query, Con)

            MyDataAdapter.Fill(MyTable)

            cboBranch.Properties.Items.Clear()

            For Each Record In MyTable.Rows
                cboBranch.Properties.Items.Add(Record("BranchName"))
            Next

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub




    Private Sub LoadDepartments()

        Dim Con As SqlConnection = New SqlConnection
        Con.ConnectionString = MyConnectionString
        Dim Query As String = "Select DepName from tblDepartment"
        Dim MyTable As New DataTable

        Try

            Con.Open()
            Dim MyDataAdapter As SqlDataAdapter = New SqlDataAdapter(Query, Con)

            MyDataAdapter.Fill(MyTable)

            cboDepartment.Properties.Items.Clear()

            For Each Record In MyTable.Rows
                cboDepartment.Properties.Items.Add(Record("DepName"))
            Next

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub




    'Private Sub cboEmployeeID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If cboEmployeeID.SelectedIndex <> -1 Then
    '        Dim con As SqlConnection = New SqlConnection
    '        con.ConnectionString = MyConnectionString

    '        Dim Query As String = "Select * from EmployeeRegistration Where EmployeeID='" & cboEmployeeID.Text & "'"

    '        Try
    '            Dim MyDataAdapter As SqlDataAdapter = New SqlDataAdapter(Query, con)

    '            Dim MyDataTable As New DataTable

    '            MyDataTable.Rows.Clear()
    '            MyDataAdapter.Fill(MyDataTable)

    '            If MyDataTable.Rows.Count > 0 Then

    '                txtFirstName.Text = MyDataTable.Rows(0).Item("FirstName")
    '                txtLastName.Text = MyDataTable.Rows(0).Item("LastName")
    '                txtMiddleName.Text = MyDataTable.Rows(0).Item("MiddleName")

    '                cboGender.SelectedItem = MyDataTable.Rows(0).Item("Gender")

    '            End If

    '        Catch ex As Exception
    '            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End If



    'End Sub




    Private Sub MyLoading() Handles Me.Load
        Try
            'LoadBranches()
            'LoadDepartments()
            LoadUserIDs()
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub LoadUser() Handles cmdLoad.Click
        Try
            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = "Select AccountID, FirstName, MiddleName, LastName, UserName, Photograph, Signature, CAST(DECRYPTBYPASSPHRASE(N'mypassword',Password) AS NVARCHAR(1000)) AS Password, CAST(DECRYPTBYPASSPHRASE(N'mypassword',UserGroup) AS NVARCHAR(1000)) AS UserGroup, CAST(DECRYPTBYPASSPHRASE(N'mypassword',RecordAccessLevel) AS NVARCHAR(1000)) AS RecordAccessLevel, AccountStatus, RegDate, RenewDate, Gender, Branch, Department, CAST(DECRYPTBYPASSPHRASE(N'mypassword',AccessibleFeatures) AS NVARCHAR(1000)) AS AccessibleFeatures, AccessibleIndices, SecurityQuestion, CAST(DECRYPTBYPASSPHRASE(N'mypassword',Answer) AS NVARCHAR(1000)) AS Answer From MainLogin Where AccountID='" & UserIDLookupEdit.EditValue & "'"
            Dim MyReader As New SqlDataAdapter(Query, Conn)

            Dim MyTable As New DataTable
            MyReader.Fill(MyTable)

            For i = 0 To ChkFeatures.Items.Count - 1
                ChkFeatures.SetItemChecked(i, False)
            Next

            If MyTable.Rows.Count > 0 Then
                With MyTable
                    Me.PanelLink.Visible = False
                    Me.cmdLink.Visible = False

                    txtUserId.Text = .Rows(0).Item("AccountID")
                    txtFirstName.Text = .Rows(0).Item("FirstName")

                    Try
                        txtMiddleName.Text = .Rows(0).Item("MiddleName")
                    Catch ex As Exception
                        txtMiddleName.Text = ""
                    End Try

                    txtLastName.Text = .Rows(0).Item("LastName")
                    cboGender.SelectedItem = .Rows(0).Item("Gender")
                    txtManageUsername.Text = .Rows(0).Item("Username")

                    If IsDBNull(.Rows(0).Item("Password")) = False Then
                        txtManagePassword.Text = .Rows(0).Item("Password").ToString
                        txtConfirmPassword.Text = .Rows(0).Item("Password").ToString
                    Else
                        txtManagePassword.Text = ""
                        txtConfirmPassword.Text = ""
                    End If

                    If IsDBNull(.Rows(0).Item("UserGroup")) = False Then
                        cboUserGroup.SelectedItem = .Rows(0).Item("UserGroup").ToString
                    Else
                        cboUserGroup.SelectedIndex = -1
                    End If

                    cboBranch.Text = .Rows(0).Item("Branch").ToString
                    cboDepartment.Text = .Rows(0).Item("Department").ToString

                    txtAnswer.Text = .Rows(0).Item("Answer").ToString
                    txtQuestion.Text = .Rows(0).Item("SecurityQuestion").ToString
                    txtconfirmanswer.Text = .Rows(0).Item("Answer").ToString

                    cboAccountStatus.SelectedItem = .Rows(0).Item("AccountStatus").ToString
                    LastRenewDate = CDate(.Rows(0).Item("RenewDate"))

                    If .Rows(0).Item("RecordAccessLevel").ToString.Contains("Save") Then
                        chkSaveRecord.Checked = True
                    Else
                        chkSaveRecord.Checked = False
                    End If

                    If .Rows(0).Item("RecordAccessLevel").ToString.Contains("Update") Then
                        chkUpdateRecord.Checked = True
                    Else
                        chkUpdateRecord.Checked = False
                    End If

                    If .Rows(0).Item("RecordAccessLevel").ToString.Contains("Delete") Then
                        chkDeleteRecord.Checked = True
                    Else
                        chkDeleteRecord.Checked = False
                    End If

                    'SYNCHRONIZATION SECTION
                    If .Rows(0).Item("RecordAccessLevel").ToString.Contains("Sync Update") Then
                        chkSyncUpdateRecords.Checked = True
                    Else
                        chkSyncUpdateRecords.Checked = False
                    End If

                    If .Rows(0).Item("RecordAccessLevel").ToString.Contains("Sync Delete") Then
                        chkSyncDeleteRecords.Checked = True
                    Else
                        chkSyncDeleteRecords.Checked = False
                    End If

                    Dim ExpiryDate As Date = LastRenewDate.AddDays(30)


                    Dim DaysRemaining As TimeSpan = ExpiryDate.Subtract(Date.Now)

                    Select Case DaysRemaining.TotalDays
                        Case Is > 1
                            lblDaysRemaining.Text = DaysRemaining.Days & " Days Remaining"
                            lblDaysRemaining.ForeColor = Color.Black
                        Case Is = 1
                            lblDaysRemaining.Text = DaysRemaining.Days & " Day Remaining"
                            lblDaysRemaining.ForeColor = Color.Black
                        Case Is <= 0
                            lblDaysRemaining.Text = "Password Expired"
                            lblDaysRemaining.ForeColor = Color.Firebrick
                    End Select

                    Try
                        If Not IsDBNull(.Rows(0).Item("Signature")) Then
                            Dim TheBytes As Byte() = .Rows(0).Item("Signature")
                            Dim MyMemoryStream As New System.IO.MemoryStream(TheBytes)
                            SignaturePictureBox.Image = Image.FromStream(MyMemoryStream)
                        Else
                            SignaturePictureBox.Image = Nothing
                        End If
                    Catch ex As Exception
                        SignaturePictureBox.Image = Nothing
                    End Try


                    Try
                        If Not IsDBNull(.Rows(0).Item("Photograph")) Then
                            Dim TheBytes As Byte() = .Rows(0).Item("Photograph")
                            Dim MyMemoryStream As New System.IO.MemoryStream(TheBytes)
                            UserPictureBox.Image = Image.FromStream(MyMemoryStream)
                        Else
                            UserPictureBox.Image = Nothing
                        End If
                    Catch ex As Exception
                        SignaturePictureBox.Image = Nothing
                    End Try

                    'MessageBox.Show(MyTable.Rows(0).Item("AccessibleFeatures"))

                    LoadAccessibleFeatures(.Rows(0).Item("AccessibleIndices"))

                    txtFirstName.Enabled = True
                    txtMiddleName.Enabled = True
                    txtLastName.Enabled = True
                    txtUserId.Enabled = True
                    txtManagePassword.Enabled = True
                    txtManageUsername.Enabled = True

                    'txtUserId.ReadOnly = False

                    cboUserGroup.Enabled = True
                    cboAccountStatus.Enabled = True
                    cboGender.Enabled = True

                    cboBranch.Enabled = True
                    cboDepartment.Enabled = True

                    cmdSave.Enabled = True

                    LoadedUserID = .Rows(0).Item("AccountID")

                    IsRecordLoaded = True
                    cmdDelete.Enabled = True

                    UsernameConditionSatisfied = True

                End With
            Else
                MessageBox.Show("No Record found matching the User ID", "No Records Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub




    Private Sub LoadAccessibleFeatures(ByVal FullIndices As String)

        If FullIndices <> "" Then
            Try
                Dim SplitString As String() = FullIndices.ToString.Trim.Split(",")

                If SplitString.Length > 0 Then
                    For Each Item In SplitString
                        'If Item <> 0 And Item <> 11 And Item <> 17 And Item <> 33 And Item <> 40 Then
                        ChkFeatures.SetItemChecked(Item, True)
                        'Else
                        'ChkFeatures.SetItemChecked(Item, False)
                        'End If
                    Next
                End If

            Catch ex As Exception
                'MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If




    End Sub





    Private Sub ChkFeatures_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs) 'Handles ChkFeatures.ItemCheck
        Dim TheIndex As Integer = e.Index

        If TheIndex = 0 Then
            If e.CurrentValue = CheckState.Unchecked Then
                For i = TheIndex + 1 To 9 Step 1
                    ChkFeatures.SetItemChecked(i, True)
                Next
            Else
                For i = TheIndex + 1 To 9 Step 1
                    ChkFeatures.SetItemChecked(i, False)
                Next
            End If

        End If


        If TheIndex = 11 Then
            If e.CurrentValue = CheckState.Unchecked Then
                For i = TheIndex + 1 To 15 Step 1
                    ChkFeatures.SetItemChecked(i, True)
                Next
            Else
                For i = TheIndex + 1 To 15 Step 1
                    ChkFeatures.SetItemChecked(i, False)
                Next
            End If

        End If

        If TheIndex = 17 Then
            If e.CurrentValue = CheckState.Unchecked Then
                For i = TheIndex + 1 To 31 Step 1
                    ChkFeatures.SetItemChecked(i, True)
                Next
            Else
                For i = TheIndex + 1 To 31 Step 1
                    ChkFeatures.SetItemChecked(i, False)
                Next
            End If

        End If

        If TheIndex = 33 Then
            If e.CurrentValue = CheckState.Unchecked Then
                For i = TheIndex + 1 To 38 Step 1
                    ChkFeatures.SetItemChecked(i, True)
                Next
            Else
                For i = TheIndex + 1 To 38 Step 1
                    ChkFeatures.SetItemChecked(i, False)
                Next
            End If

        End If

        If TheIndex = 40 Then
            If e.CurrentValue = CheckState.Unchecked Then
                For i = TheIndex + 1 To 50 Step 1
                    ChkFeatures.SetItemChecked(i, True)
                Next
            Else
                For i = TheIndex + 1 To 50 Step 1
                    ChkFeatures.SetItemChecked(i, False)
                Next
            End If

        End If




    End Sub

    Private Function GenerateAccountID() As String
        Try
            Dim FNFirstLetter, LNFirstLetter As String
            FNFirstLetter = ""
            LNFirstLetter = ""

            If txtFirstName.Text <> "" Then

                FNFirstLetter = txtFirstName.Text.Substring(0, 1)
            End If

            If txtLastName.Text <> "" Then

                LNFirstLetter = txtLastName.Text.Substring(0, 1)
            End If

            Dim Recordcount As Integer

            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = "Select Count(AccountID) From MainLogin"

            Conn.Open()
            Dim CONCOMMAND As New SqlCommand(Query, Conn)

            Recordcount = CONCOMMAND.ExecuteScalar
            Conn.Close()

            Dim IsIDGenerated As Boolean = False

            Dim Start As String = Nothing

            While IsIDGenerated = False

                Recordcount += 1

                Dim theRandom As New Random
                Dim theranvalue As Double = theRandom.NextDouble()
                Dim thesplit As String() = theranvalue.ToString.Trim.Split(".")

                Dim theGeneratedIndex As String = thesplit(1).Substring(4, 2)

                Start = FNFirstLetter & LNFirstLetter & theGeneratedIndex
                If ValidateAccountID(Start) = False Then
                    Return Start
                    Exit While
                End If

            End While

        Catch ex As Exception
            Return "Connection Error"
        End Try

    End Function


    Private Function ValidateAccountID(ByVal AccountID As String) As Boolean
        Try
            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = " Select Count(AccountID) From MainLogin Where AccountID='" & AccountID & "'"

            Conn.Open()
            Dim Concommand As New SqlCommand(Query, Conn)

            Dim Recordcount As Integer = Concommand.ExecuteScalar
            Conn.Close()

            If Recordcount > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try

    End Function






    Private Sub SaveRecord() Handles cmdSave.Click
        If UsernameConditionSatisfied = True Then
            If ChkFeatures.CheckedItems.Count > 0 Then
                If txtConfirmPassword.Text = txtManagePassword.Text Then

                    If txtAnswer.Text <> txtconfirmanswer.Text Then
                        MessageBox.Show("Answer to security question is a mismatch. Please confirm the answer you provided.", "Confirm Answer", MessageBoxButtons.OK, MessageBoxIcon.Warning)



                        Exit Sub
                    End If

                    Try
                        If txtFirstName.Text <> String.Empty And txtLastName.Text <> String.Empty And cboGender.SelectedIndex <> -1 And txtManageUsername.Text <> String.Empty And txtManagePassword.Text <> String.Empty And cboUserGroup.SelectedIndex <> -1 And cboAccountStatus.SelectedIndex <> -1 And cboBranch.Text <> "" And cboDepartment.Text <> "" Then
                            If IsRecordLoaded = False Then
                                Dim Conn As New SqlConnection(MyConnectionString)
                                Dim Query As String = "Insert Into MainLogin (AccountID, FirstName, MiddleName, LastName, Gender,Photograph, Signature, Username, Password, AccountStatus, UserGroup, RegDate, RenewDate, AccessibleFeatures, AccessibleIndices, Branch, Department, SecurityQuestion, Answer, RecordAccessLevel) Values(@AccountID, @FirstName, @MiddleName, @LastName, @Gender, @Photograph, @Signature, @Username, ENCRYPTBYPASSPHRASE(N'mypassword', @Password), @AccountStatus, ENCRYPTBYPASSPHRASE(N'mypassword',@UserGroup), @RegDate, @RenewDate, ENCRYPTBYPASSPHRASE(N'mypassword',@AccessibleFeatures), @AccessibleIndices, @Branch, @Department, @SecurityQuestion, ENCRYPTBYPASSPHRASE(N'mypassword', @Answer), ENCRYPTBYPASSPHRASE(N'mypassword',@RecordAccessLevel))"

                                Dim MyCommand As New SqlCommand(Query, Conn)
                                Dim FullFeatures As String = ""

                                For Each Item In ChkFeatures.CheckedItems
                                    If FullFeatures = Nothing Then
                                        FullFeatures = Item
                                    Else
                                        FullFeatures = FullFeatures & "," & Item
                                    End If
                                Next

                                Dim FullIndices As String = ""

                                For Each Item3 In ChkFeatures.CheckedIndices
                                    If FullIndices = Nothing Then
                                        FullIndices = Item3
                                    Else
                                        FullIndices = FullIndices & "," & Item3
                                    End If
                                Next

                                With MyCommand.Parameters

                                    .AddWithValue("@AccountID", txtUserId.Text.ToString)
                                    .AddWithValue("@FirstName", txtFirstName.Text.ToString)
                                    .AddWithValue("@MiddleName", txtMiddleName.Text.ToString)
                                    .AddWithValue("@LastName", txtLastName.Text.ToString)
                                    .AddWithValue("@Gender", cboGender.SelectedItem.ToString)
                                    .AddWithValue("@Username", txtManageUsername.Text.ToString)
                                    .AddWithValue("@Password", txtManagePassword.Text.ToString)

                                    .AddWithValue("@UserGroup", cboUserGroup.SelectedItem.ToString)
                                    .AddWithValue("@AccountStatus", cboAccountStatus.SelectedItem.ToString)
                                    .AddWithValue("@RegDate", Date.Now)
                                    .AddWithValue("@RenewDate", Date.Now)

                                    .AddWithValue("@Branch", cboBranch.Text)
                                    .AddWithValue("@Department", cboDepartment.Text)

                                    .AddWithValue("@AccessibleFeatures", FullFeatures)
                                    .AddWithValue("@AccessibleIndices", FullIndices)

                                    .AddWithValue("@SecurityQuestion", txtQuestion.Text)
                                    .AddWithValue("@Answer", txtAnswer.Text)

                                    If SignaturePictureBox.Image IsNot Nothing Then
                                        Dim MyMemoryStream As New System.IO.MemoryStream()
                                        SignaturePictureBox.Image.Save(MyMemoryStream, System.Drawing.Imaging.ImageFormat.Png)

                                        .AddWithValue("@Signature", MyMemoryStream.ToArray)
                                    Else
                                        Dim MyMemoryStream As New System.IO.MemoryStream()
                                        .AddWithValue("@Signature", MyMemoryStream.ToArray)
                                    End If

                                    If UserPictureBox.Image IsNot Nothing Then
                                        Dim MyMemoryStream As New System.IO.MemoryStream()
                                        UserPictureBox.Image.Save(MyMemoryStream, System.Drawing.Imaging.ImageFormat.Png)

                                        .AddWithValue("@Photograph", MyMemoryStream.ToArray)
                                    Else
                                        Dim MyMemoryStream As New System.IO.MemoryStream()
                                        .AddWithValue("@Photograph", MyMemoryStream.ToArray)
                                    End If

                                    Dim RecordAccessLevel As String = " "

                                    If chkSaveRecord.Checked = True Then
                                        RecordAccessLevel = "Save"
                                    End If

                                    If chkUpdateRecord.Checked = True Then
                                        RecordAccessLevel = RecordAccessLevel & ",Update"
                                    End If

                                    If chkDeleteRecord.Checked = True Then
                                        RecordAccessLevel = RecordAccessLevel & ",Delete"
                                    End If

                                    'SYNCHRONIZATION SECTION
                                    If chkSyncUpdateRecords.Checked = True Then
                                        RecordAccessLevel = RecordAccessLevel & ",Sync Update"
                                    End If

                                    If chkSyncDeleteRecords.Checked = True Then
                                        RecordAccessLevel = RecordAccessLevel & ",Sync Delete"
                                    End If

                                    .AddWithValue("@RecordAccessLevel", RecordAccessLevel)

                                End With


                                Dim FullName As String = txtFirstName.Text & " " & txtMiddleName.Text & " " & txtLastName.Text

                                Conn.Open()
                                MyCommand.ExecuteNonQuery()
                                Conn.Close()

                                lblInfo.Text = "Record Inserted Successfully"
                                CreateLog(CurrentUserID, FullNameofUser, "Created a new user account for " & FullName & " as " & cboUserGroup.SelectedItem.ToString, 0)

                                UserIDLookupEdit.Enabled = True

                                LoadUserIDs()

                                txtFirstName.Text = ""
                                txtMiddleName.Text = ""
                                txtLastName.Text = ""
                                txtUserId.Text = ""
                                cboGender.SelectedIndex = -1
                                cboAccountStatus.SelectedIndex = -1
                                cboUserGroup.SelectedIndex = -1

                                txtConfirmPassword.Text = ""

                                cboBranch.Text = ""
                                txtManageUsername.Text = ""
                                txtManagePassword.Text = ""
                                cboDepartment.Text = ""
                                IsRecordLoaded = False

                            ElseIf IsRecordLoaded = True Then
                                Dim Conn As New SqlConnection(MyConnectionString)
                                Dim Query As String = "Update MainLogin Set FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName, Gender=@Gender, Photograph = @Photograph, Signature = @Signature, Username=@Username, Password = ENCRYPTBYPASSPHRASE(N'mypassword',@Password), AccountStatus=@AccountStatus, UserGroup= ENCRYPTBYPASSPHRASE(N'mypassword',@UserGroup), RenewDate=@RenewDate, Branch = @Branch, Department = @Department, AccessibleFeatures = ENCRYPTBYPASSPHRASE(N'mypassword',@AccessibleFeatures), AccessibleIndices = @AccessibleIndices, SecurityQuestion = @SecurityQuestion, Answer = ENCRYPTBYPASSPHRASE(N'mypassword',@Answer), RecordAccessLevel = ENCRYPTBYPASSPHRASE(N'mypassword',@RecordAccessLevel) Where AccountID='" & LoadedUserID & "'"
                                
                                Dim MyCommand As New SqlCommand(Query, Conn)

                                Dim FullFeatures As String = Nothing

                                For Each Item In ChkFeatures.CheckedItems
                                    If FullFeatures = Nothing Then
                                        FullFeatures = Item
                                    Else
                                        FullFeatures = FullFeatures & "," & Item
                                    End If
                                Next

                                Dim FullIndices As String = Nothing

                                For Each Item3 In ChkFeatures.CheckedIndices
                                    If FullIndices = Nothing Then
                                        FullIndices = Item3
                                    Else
                                        FullIndices = FullIndices & "," & Item3
                                    End If
                                Next

                                With MyCommand.Parameters
                                    .AddWithValue("@FirstName", txtFirstName.Text.ToString)
                                    .AddWithValue("@MiddleName", txtMiddleName.Text.ToString)
                                    .AddWithValue("@LastName", txtLastName.Text.ToString)
                                    .AddWithValue("@Gender", cboGender.SelectedItem.ToString)
                                    .AddWithValue("@Username", txtManageUsername.Text.ToString)
                                    .AddWithValue("@Password", txtManagePassword.Text.ToString)

                                    .AddWithValue("@UserGroup", cboUserGroup.SelectedItem.ToString)
                                    .AddWithValue("@AccountStatus", cboAccountStatus.SelectedItem.ToString)
                                    .AddWithValue("@RegDate", Date.Today)
                                    .AddWithValue("@RenewDate", Date.Today)

                                    .AddWithValue("@Branch", cboBranch.Text)
                                    .AddWithValue("@Department", cboDepartment.Text)

                                    .AddWithValue("@AccessibleFeatures", FullFeatures)
                                    .AddWithValue("@AccessibleIndices", FullIndices)

                                    .AddWithValue("@SecurityQuestion", txtQuestion.Text)
                                    .AddWithValue("@Answer", txtAnswer.Text)

                                    If SignaturePictureBox.Image IsNot Nothing Then
                                        Dim MyMemoryStream As New System.IO.MemoryStream()
                                        SignaturePictureBox.Image.Save(MyMemoryStream, System.Drawing.Imaging.ImageFormat.Png)

                                        .AddWithValue("@Signature", MyMemoryStream.ToArray)
                                    Else
                                        Dim MyMemoryStream As New System.IO.MemoryStream()
                                        .AddWithValue("@Signature", MyMemoryStream.ToArray)
                                    End If

                                    
                                    If UserPictureBox.Image IsNot Nothing Then
                                        Dim MyMemoryStream As New System.IO.MemoryStream()
                                        UserPictureBox.Image.Save(MyMemoryStream, System.Drawing.Imaging.ImageFormat.Png)

                                        .AddWithValue("@Photograph", MyMemoryStream.ToArray)
                                    Else
                                        Dim MyMemoryStream As New System.IO.MemoryStream()
                                        .AddWithValue("@Photograph", MyMemoryStream.ToArray)
                                    End If


                                    Dim RecordAccessLevel As String = " "

                                    If chkSaveRecord.Checked = True Then
                                        RecordAccessLevel = "Save"
                                    End If

                                    If chkUpdateRecord.Checked = True Then
                                        RecordAccessLevel = RecordAccessLevel & ",Update"
                                    End If

                                    If chkDeleteRecord.Checked = True Then
                                        RecordAccessLevel = RecordAccessLevel & ",Delete"
                                    End If

                                    'SYNCHRONIZATION SECTION
                                    If chkSyncUpdateRecords.Checked = True Then
                                        RecordAccessLevel = RecordAccessLevel & ",Sync Update"
                                    End If

                                    If chkSyncDeleteRecords.Checked = True Then
                                        RecordAccessLevel = RecordAccessLevel & ",Sync Delete"
                                    End If

                                    .AddWithValue("@RecordAccessLevel", RecordAccessLevel)

                                End With

                                Dim FullName As String = txtFirstName.Text & " " & txtMiddleName.Text & " " & txtLastName.Text

                                Conn.Open()
                                MyCommand.ExecuteNonQuery()
                                Conn.Close()

                                lblInfo.Text = "Record Successfully Updated"
                                CreateLog(CurrentUserID, FullNameofUser, "Updated a user account for " & FullName & " as " & cboUserGroup.SelectedItem.ToString, 0)


                                IsRecordLoaded = False
                                LoadUser()

                            End If

                        Else
                            MessageBox.Show("Pleaes provide all required information", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                    Catch EX As Exception
                        MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                Else
                    MessageBox.Show("Password and Confirmation Password do not match. Please verify.", "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Else
                MessageBox.Show("Please select at least one feature before clicking 'Save'", "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("Please correct all validation errors before clicking 'Save'", "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub





    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If IsRecordLoaded = True Then
            If MessageBox.Show("Do you really want to delete the current user account? This operation is irreversible.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                Dim Query As String = "Delete From MainLogin Where AccountID='" & LoadedUserID & "'"
                Dim Conn As New SqlConnection(MyConnectionString)

                Dim MyCommand As New SqlCommand(Query, Conn)

                Try
                    Conn.Open()
                    MyCommand.ExecuteNonQuery()
                    Conn.Close()

                    Dim FullName As String = txtFirstName.Text & " " & txtMiddleName.Text & " " & txtLastName.Text

                    lblInfo.Text = "Record Deleted Successfully"
                    CreateLog(CurrentUserID, FullNameofUser, "Deleted an account for " & FullName, 0)

                    CancelManage()
                    IsRecordLoaded = False
                    LoadUserIDs()

                Catch ex As Exception
                    MessageBox.Show("Connection Error, Please verify the connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End If



    End Sub




    Private Sub txtManagePassword_Validating1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) ' Handles txtManagePassword.Validating

        ErrorProvider1.SetError(txtManagePassword, Nothing)

        Dim UpperCheck As Boolean = Nothing
        Dim NumberCheck As Boolean = Nothing
        Dim SymbolCheck As Boolean = Nothing
        Dim WhiteSpaceDetected As Boolean = Nothing

        If String.IsNullOrWhiteSpace(txtManagePassword.Text) = True Then
            ErrorProvider1.SetError(txtManagePassword, "Please specify a password")
        End If

        If txtManagePassword.Text.ToCharArray.Count >= 8 Then

            For Each MyChar In txtManagePassword.Text.ToCharArray
                If Char.IsUpper(MyChar) = True Then
                    UpperCheck = True
                ElseIf Char.IsNumber(MyChar) = True Then
                    NumberCheck = True
                ElseIf Char.IsPunctuation(MyChar) = True Or Char.IsSymbol(MyChar) = True Then
                    SymbolCheck = True
                ElseIf Char.IsWhiteSpace(MyChar) = True Then
                    WhiteSpaceDetected = True
                End If
            Next

            If UpperCheck = False Then
                ErrorProvider1.SetError(txtManagePassword, "The password must contain atleast one Uppercase Character")
                'UserPasswordConditionSatisfied = False



                Exit Sub
            ElseIf NumberCheck = False Then
                ErrorProvider1.SetError(txtManagePassword, "The password must contain atleast one Number")
                'UserPasswordConditionSatisfied = False



                Exit Sub
            ElseIf SymbolCheck = False Then
                ErrorProvider1.SetError(txtManagePassword, "The password must contain atleast one Symbol")
                'UserPasswordConditionSatisfied = False



                Exit Sub
            ElseIf WhiteSpaceDetected = True Then
                ErrorProvider1.SetError(txtManagePassword, "White spaces are not allowed in the password")
                'UserPasswordConditionSatisfied = False



                Exit Sub
            End If

            'UserPasswordConditionSatisfied = True

        Else
            ErrorProvider1.SetError(txtManagePassword, "Password must be atleast 8 Characters long")
            'UserPasswordConditionSatisfied = False
        End If




    End Sub




    Private Sub txtManageUsername_Validating1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtManageUsername.Validating
        If IsRecordLoaded = False Then
            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = "Select Count(*) From MainLogin Where Username='" & txtManageUsername.Text & "'"

            Dim ConCommand As New SqlCommand(Query, Conn)

            Conn.Open()
            Dim RecordCount As Integer = ConCommand.ExecuteScalar
            Conn.Close()

            If RecordCount > 0 Then
                ErrorProvider1.SetError(txtManageUsername, "This username has already been taken by someone else, please specify another")
                UsernameConditionSatisfied = False
            Else
                ErrorProvider1.SetError(txtManageUsername, Nothing)
                UsernameConditionSatisfied = True
            End If
        End If



    End Sub




    Public Sub LoadUserIDs()
        Try
            Dim Conn As New SqlConnection(MyConnectionString)
            Dim Query As String = "Select AccountID, FirstName + ' ' + MiddleName + ' ' + LastName AS FullName, CAST(DECRYPTBYPASSPHRASE(N'mypassword',UserGroup) AS NVARCHAR(1000)) AS UserGroup, Branch, Department From MainLogin"
            Dim MyAdapter As New SqlDataAdapter(Query, Conn)

            Dim MyTable As New DataTable
            MyAdapter.Fill(MyTable)

            UserIDLookupEdit.Properties.DataSource = MyTable
            UserIDLookupEdit.Properties.DisplayMember = "FullName"
            UserIDLookupEdit.Properties.ValueMember = "AccountID"

            'If MyTable.Rows.Count > 0 Then
            '    UserIDLookupEdit.Properties.Items.Clear()

            '    For Each Record In MyTable.Rows
            '        UserIDLookupEdit.Properties.Items.Add(Record("AccountID"))
            '    Next
            'End If

        Catch ex As Exception

        End Try



    End Sub




    Private Sub AddNewRecord() Handles cmdAdd.Click
        txtUserId.Properties.ReadOnly = True

        UserPictureBox.Image = Nothing
        SignaturePictureBox.Image = Nothing

        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtUserId.Text = ""
        cboGender.SelectedIndex = -1
        cboAccountStatus.SelectedIndex = -1
        cboUserGroup.SelectedIndex = -1

        txtConfirmPassword.Text = ""

        cboBranch.Text = ""
        txtManageUsername.Text = ""
        txtManagePassword.Text = ""
        cboDepartment.Text = ""
        'txtUserId.ReadOnly = True

        txtAnswer.Text = ""
        txtQuestion.Text = ""
        txtconfirmanswer.Text = ""
        For i = 0 To ChkFeatures.Items.Count - 1
            ChkFeatures.SetItemChecked(i, False)
        Next

        chkDeleteRecord.Checked = False
        chkSaveRecord.Checked = False
        chkUpdateRecord.Checked = False

        chkSyncDeleteRecords.Checked = False
        chkSyncUpdateRecords.Checked = False

        Me.PanelLink.Visible = False
        Me.cmdLink.Visible = True

        txtFirstName.Enabled = True
        txtMiddleName.Enabled = True
        txtLastName.Enabled = True
        txtUserId.Enabled = True
        txtManagePassword.Enabled = True
        txtManageUsername.Enabled = True
        UserIDLookupEdit.Enabled = False
        cboUserGroup.Enabled = True
        cboAccountStatus.Enabled = True
        cboGender.Enabled = True

        cboDepartment.Enabled = True
        cboBranch.Enabled = True
        txtConfirmPassword.Enabled = True

        txtAnswer.Enabled = True
        txtQuestion.Enabled = True
        txtconfirmanswer.Enabled = True

        cmdAdd.Enabled = False
        cmdSave.Enabled = True
        cmdDelete.Enabled = False
        cmdLoad.Enabled = False
        UserIDLookupEdit.Enabled = False

        cmdCancelManage.Visible = True
        IsRecordLoaded = False

        txtUserId.Text = GenerateAccountID()



    End Sub




    Private Sub CancelManage() Handles cmdCancelManage.Click
        CancelAddingRecord = True

        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtUserId.Text = ""
        cboGender.SelectedIndex = -1
        cboAccountStatus.SelectedIndex = -1
        cboUserGroup.SelectedIndex = -1
        txtManageUsername.Text = ""
        txtManagePassword.Text = ""
        UserIDLookupEdit.EditValue = ""

        ErrorProvider1.SetError(txtFirstName, "")
        ErrorProvider1.SetError(txtLastName, "")
        ErrorProvider1.SetError(cboGender, "")
        ErrorProvider1.SetError(txtManageUsername, "")
        ErrorProvider1.SetError(txtManagePassword, "")
        ErrorProvider1.SetError(cboUserGroup, "")
        ErrorProvider1.SetError(cboAccountStatus, "")

        txtFirstName.Enabled = False
        txtMiddleName.Enabled = False
        txtLastName.Enabled = False
        txtUserId.Enabled = False
        txtManagePassword.Enabled = False
        txtManageUsername.Enabled = False
        UserIDLookupEdit.Enabled = True
        cboUserGroup.Enabled = False
        cboAccountStatus.Enabled = False
        cboGender.Enabled = False

        cmdAdd.Enabled = True
        cmdSave.Enabled = False
        cmdDelete.Enabled = False
        cmdLoad.Enabled = True

        cmdCancelManage.Visible = False
        IsRecordLoaded = False



    End Sub


    Private Sub cboUserID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles cboUserID.SelectedIndexChanged
        If UserIDLookupEdit.EditValue <> "" Then
            LoadUser()
        End If

    End Sub


    Private Sub txtFirstName_Validating() Handles txtFirstName.Validated

        ErrorProvider1.SetError(txtFirstName, "")

        With txtFirstName

            If .Text = String.Empty Then
                'e.Cancel = True
                ErrorProvider1.SetError(txtFirstName, "Required Field")
            End If

        End With



    End Sub




    Private Sub txtLastName_Validating() Handles txtLastName.Validated

        ErrorProvider1.SetError(txtLastName, "")

        With txtLastName
            If .Text = String.Empty Then
                'e.Cancel = True
                ErrorProvider1.SetError(txtLastName, "Required Field")
            End If
        End With



    End Sub




    Private Sub cboGender_Validating() Handles cboGender.Validated
        ErrorProvider1.SetError(cboGender, "")

        With cboGender
            If .SelectedIndex = -1 Then
                'e.Cancel = True
                ErrorProvider1.SetError(cboGender, "Required Field")
            End If
        End With



    End Sub




    Private Sub cboUserGroup_Validating() Handles cboUserGroup.Validated

        ErrorProvider1.SetError(cboUserGroup, "")

        With cboUserGroup
            If .SelectedIndex = -1 Then
                'e.Cancel = True
                ErrorProvider1.SetError(cboUserGroup, "Required Field")
            End If
        End With



    End Sub




    Private Sub cboAccountStatus_Validating() Handles cboAccountStatus.Validated

        ErrorProvider1.SetError(cboAccountStatus, "")

        With cboAccountStatus
            If .SelectedIndex = -1 Then
                'e.Cancel = True
                ErrorProvider1.SetError(cboAccountStatus, "Required Field")
            End If
        End With




    End Sub




    Private Sub cmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Do you really wish to logout? All other opened windows will be closed.", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            isLoginSuccessfull = False
            frmLogin.Show()
            Me.Close()
            frmDashboardNew.Close()
        End If



    End Sub




    Private Sub cmdMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized



    End Sub




    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()



    End Sub


#End Region




    Private Sub ChkFeatures_MouseClick(sender As Object, e As MouseEventArgs) 'Handles ChkFeatures.MouseClick
        Dim TheIndex As Integer = ChkFeatures.SelectedIndex

        For Each Item As Integer In ChkFeatures.CheckedIndices
            If Item = 0 Then
                For i = Item + 1 To 12 Step 1
                    ChkFeatures.SetItemChecked(i, True)
                Next

            End If
        Next




    End Sub




    Private Sub txtConfirmPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtConfirmPassword.Validating
        If txtManagePassword.Text <> txtConfirmPassword.Text Then
            ErrorProvider1.SetError(txtConfirmPassword, "Password mismatch")
        Else
            ErrorProvider1.SetError(txtConfirmPassword, Nothing)
        End If



    End Sub



    Private Sub cmdBrowseSignature_Click(sender As Object, e As EventArgs) Handles cmdBrowseSignature.Click
        Try
            Dim OFd1 As New OpenFileDialog
            OFd1.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp"
            OFd1.FileName = ""

            If OFd1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                SignaturePictureBox.Image = Image.FromFile(OFd1.FileName)
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        If Not ValidateAccountID(txtUserId.Text) And Not Me.PanelLink.Visible Then
            txtUserId.Text = GenerateAccountID()
        End If

    End Sub


    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        If Not ValidateAccountID(txtUserId.Text) And Not Me.PanelLink.Visible Then
            txtUserId.Text = GenerateAccountID()
        End If

    End Sub


    Private Sub cmdSelectAll_Click(sender As Object, e As EventArgs) Handles cmdSelectAll.Click
        If ChkFeatures.CheckedItems.Count = 0 Then
            For i = 0 To ChkFeatures.Items.Count - 1
                ChkFeatures.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To ChkFeatures.Items.Count - 1
                ChkFeatures.SetItemChecked(i, False)
            Next
        End If

    End Sub


    Private Sub cmdUnlock_Click(sender As Object, e As EventArgs) Handles cmdUnlock.Click
        txtUserId.Properties.ReadOnly = Not txtUserId.Properties.ReadOnly

    End Sub


    Private Sub cmdClosePanelLink_Click(sender As Object, e As EventArgs) Handles cmdClosePanelLink.Click
        Me.PanelLink.Visible = False

    End Sub


    Private Sub cmdLink_Click(sender As Object, e As EventArgs) Handles cmdLink.Click
        LoadLocalUserIDs()
        Me.PanelLink.Visible = True
        Me.PanelLink.BringToFront()

    End Sub


    Public Sub LoadLocalUserIDs()

        Try
            Dim TheConnectionstring As String

            If My.Settings.LocalDBServerIPAddress.Contains(".\") Or My.Settings.LocalDBServerIPAddress.Contains("\") Then
                TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & ";Database=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
            Else
                TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & "," & My.Settings.LocalDBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
            End If

            Dim Conn As New SqlConnection(TheConnectionstring)
            Dim Query As String = "Select AccountID, FirstName + ' ' + MiddleName + ' ' + LastName AS FullName, CAST(DECRYPTBYPASSPHRASE(N'mypassword',UserGroup) AS NVARCHAR(1000)) AS UserGroup, Branch, Department From MainLogin"
            Dim MyAdapter As New SqlDataAdapter(Query, Conn)

            Dim MyTable As New DataTable
            MyAdapter.Fill(MyTable)

            LinkLookUp.Properties.DataSource = MyTable
            LinkLookUp.Properties.DisplayMember = "FullName"
            LinkLookUp.Properties.ValueMember = "AccountID"

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub cmdLinkAccount_Click(sender As Object, e As EventArgs) Handles cmdLinkAccount.Click
        If LinkLookUp.Text <> "" Then
            Try
                Dim TheConnectionstring As String

                If My.Settings.LocalDBServerIPAddress.Contains(".\") Or My.Settings.LocalDBServerIPAddress.Contains("\") Then
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & ";Database=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                Else
                    TheConnectionstring = "Data Source=" & My.Settings.LocalDBServerIPAddress & "," & My.Settings.LocalDBPortNumber & ";Network Library=DBMSSOCN" & ";Initial Catalog=" & My.Settings.LocalDBDatabaseName & ";User ID=" & My.Settings.LocalDBUsername & ";Password=" & My.Settings.LocalDBPassword
                End If

                If Not ValidateAccountID(LinkLookUp.EditValue) Then

                    Dim Conn As New SqlConnection(TheConnectionstring)
                    Dim Query As String = "Select AccountID, FirstName, MiddleName, LastName, UserName, Signature, CAST(DECRYPTBYPASSPHRASE(N'mypassword',Password) AS NVARCHAR(1000)) AS Password, CAST(DECRYPTBYPASSPHRASE(N'mypassword',UserGroup) AS NVARCHAR(1000)) AS UserGroup, CAST(DECRYPTBYPASSPHRASE(N'mypassword',RecordAccessLevel) AS NVARCHAR(1000)) AS RecordAccessLevel, AccountStatus, RegDate, RenewDate, Gender, Branch, Department, CAST(DECRYPTBYPASSPHRASE(N'mypassword',AccessibleFeatures) AS NVARCHAR(1000)) AS AccessibleFeatures, AccessibleIndices, SecurityQuestion, CAST(DECRYPTBYPASSPHRASE(N'mypassword',Answer) AS NVARCHAR(1000)) AS Answer From MainLogin Where AccountID='" & LinkLookUp.EditValue & "'"
                    Dim MyReader As New SqlDataAdapter(Query, Conn)

                    Dim MyTable As New DataTable
                    MyReader.Fill(MyTable)

                    For i = 0 To ChkFeatures.Items.Count - 1
                        ChkFeatures.SetItemChecked(i, False)
                    Next

                    If MyTable.Rows.Count > 0 Then
                        With MyTable

                            txtUserId.Text = .Rows(0).Item("AccountID")
                            txtFirstName.Text = .Rows(0).Item("FirstName")

                            Try
                                txtMiddleName.Text = .Rows(0).Item("MiddleName")
                            Catch ex As Exception
                                txtMiddleName.Text = ""
                            End Try

                            txtLastName.Text = .Rows(0).Item("LastName")
                            cboGender.SelectedItem = .Rows(0).Item("Gender")
                            txtManageUsername.Text = .Rows(0).Item("Username")

                            If IsDBNull(.Rows(0).Item("Password")) = False Then
                                txtManagePassword.Text = .Rows(0).Item("Password").ToString
                                txtConfirmPassword.Text = .Rows(0).Item("Password").ToString
                            Else
                                txtManagePassword.Text = ""
                                txtConfirmPassword.Text = ""
                            End If

                            If IsDBNull(.Rows(0).Item("UserGroup")) = False Then
                                cboUserGroup.SelectedItem = .Rows(0).Item("UserGroup").ToString
                            Else
                                cboUserGroup.SelectedIndex = -1
                            End If

                            cboBranch.Text = .Rows(0).Item("Branch").ToString
                            cboDepartment.Text = .Rows(0).Item("Department").ToString

                            txtAnswer.Text = .Rows(0).Item("Answer").ToString
                            txtQuestion.Text = .Rows(0).Item("SecurityQuestion").ToString
                            txtconfirmanswer.Text = .Rows(0).Item("Answer").ToString

                            cboAccountStatus.SelectedItem = .Rows(0).Item("AccountStatus").ToString
                            LastRenewDate = CDate(.Rows(0).Item("RenewDate"))

                            If .Rows(0).Item("RecordAccessLevel").ToString.Contains("Save") Then
                                chkSaveRecord.Checked = True
                            Else
                                chkSaveRecord.Checked = False
                            End If

                            If .Rows(0).Item("RecordAccessLevel").ToString.Contains("Update") Then
                                chkUpdateRecord.Checked = True
                            Else
                                chkUpdateRecord.Checked = False
                            End If

                            If .Rows(0).Item("RecordAccessLevel").ToString.Contains("Delete") Then
                                chkDeleteRecord.Checked = True
                            Else
                                chkDeleteRecord.Checked = False
                            End If

                            'SYNCHRONIZATION SECTION
                            If .Rows(0).Item("RecordAccessLevel").ToString.Contains("Sync Update") Then
                                chkSyncUpdateRecords.Checked = True
                            Else
                                chkSyncUpdateRecords.Checked = False
                            End If

                            If .Rows(0).Item("RecordAccessLevel").ToString.Contains("Sync Delete") Then
                                chkSyncDeleteRecords.Checked = True
                            Else
                                chkSyncDeleteRecords.Checked = False
                            End If

                            Dim ExpiryDate As Date = LastRenewDate.AddDays(30)


                            Dim DaysRemaining As TimeSpan = ExpiryDate.Subtract(Date.Now)

                            Select Case DaysRemaining.TotalDays
                                Case Is > 1
                                    lblDaysRemaining.Text = DaysRemaining.Days & " Days Remaining"
                                    lblDaysRemaining.ForeColor = Color.Black
                                Case Is = 1
                                    lblDaysRemaining.Text = DaysRemaining.Days & " Day Remaining"
                                    lblDaysRemaining.ForeColor = Color.Black
                                Case Is <= 0
                                    lblDaysRemaining.Text = "Password Expired"
                                    lblDaysRemaining.ForeColor = Color.Firebrick
                            End Select

                            Try
                                If Not IsDBNull(.Rows(0).Item("Signature")) Then
                                    Dim TheBytes As Byte() = .Rows(0).Item("Signature")
                                    Dim MyMemoryStream As New System.IO.MemoryStream(TheBytes)
                                    SignaturePictureBox.Image = Image.FromStream(MyMemoryStream)
                                Else
                                    SignaturePictureBox.Image = Nothing
                                End If
                            Catch ex As Exception
                                SignaturePictureBox.Image = Nothing
                            End Try

                            'MessageBox.Show(MyTable.Rows(0).Item("AccessibleFeatures"))

                            LoadAccessibleFeatures(.Rows(0).Item("AccessibleIndices"))

                            txtFirstName.Enabled = True
                            txtMiddleName.Enabled = True
                            txtLastName.Enabled = True
                            txtUserId.Enabled = True
                            txtManagePassword.Enabled = True
                            txtManageUsername.Enabled = True

                            'txtUserId.ReadOnly = False

                            cboUserGroup.Enabled = True
                            cboAccountStatus.Enabled = True
                            cboGender.Enabled = True

                            cboBranch.Enabled = True
                            cboDepartment.Enabled = True

                            cmdSave.Enabled = True

                            'LoadedUserID = .Rows(0).Item("AccountID")

                            IsRecordLoaded = False
                            cmdDelete.Enabled = False

                            UsernameConditionSatisfied = True
                            Me.PanelLink.Hide()

                        End With
                    Else
                        MessageBox.Show("No Record found matching the User ID", "No Records Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Else
                    MessageBox.Show("This User Account ID is already in use in this computer. Please verify and try again.", "ID in Use", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select the account you wish to link this new user to.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub


    Private Sub LoadUser(sender As Object, e As EventArgs) Handles cmdLoad.Click


    End Sub


    Private Sub cmdLoadPicture_Click(sender As Object, e As EventArgs) Handles cmdLoadPicture.Click
        Try
            Dim OFd1 As New OpenFileDialog
            OFd1.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp"
            OFd1.FileName = ""

            If OFd1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                UserPictureBox.Image = Image.FromFile(OFd1.FileName)
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdCamera_Click(sender As Object, e As EventArgs) Handles cmdCamera.Click
        Try
            Dim MyCamera As New DevExpress.XtraEditors.Camera.TakePictureDialog
            MyCamera.Caption = "Please take a Picture"

            If MyCamera.ShowDialog() = System.Windows.Forms.DialogResult.OK Then 
                Dim i As Image = MyCamera.Image
                UserPictureBox.Image = i 
            End If

        Catch ex As Exception
            MessageBox.Show(Ex.Message, "Error Occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cmdClearPhoto_Click(sender As Object, e As EventArgs) Handles cmdClearPhoto.Click
        UserPictureBox.Image = Nothing

    End Sub

End Class
