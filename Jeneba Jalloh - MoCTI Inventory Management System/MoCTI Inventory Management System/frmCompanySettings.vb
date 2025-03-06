
Public Class frmCompanySettings
    Dim MyReportTable As New DataTable
    Dim MySingleReportTable As New DataTable
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer



    Private Sub PanelTop_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) 'Handles PanelHeader.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If



    End Sub



    Private Sub PanelTop_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) 'Handles PanelHeader.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If



    End Sub



    Private Sub PanelTop_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) 'Handles PanelHeader.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing

        End If


    End Sub




    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()


    End Sub



    Private Sub cmdMinimize_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.WindowState = FormWindowState.Minimized


    End Sub


    Private Sub MyLoading_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        LoadRecords()

        If RecordAccessLevel.Contains("Save") Then
            cmdSave.Visible = True
        Else
            cmdSave.Visible = False
        End If

        If RecordAccessLevel.Contains("Update") Then
            cmdUpdate.Visible = True
        Else
            cmdUpdate.Visible = False
        End If

        If RecordAccessLevel.Contains("Delete") Then
            cmdDelete.Visible = True
        Else
            cmdDelete.Visible = False
        End If

    End Sub

    Private Sub LoadRecords()
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT TOP 250 CompanyID,NameofCompany,SubName,Address,PhoneNo,Email,Logo,Stamp,RegistrationNo FROM CompanySettings"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)

            MyReportTable.Rows.Clear()
            ConTableAdapter.Fill(MyReportTable)

            CompanySettingsDataGridView.DataSource = MyReportTable
            If MyReportTable.Rows.Count > 0 Then
                DisplayRecordInfo(MyReportTable.Rows(0).Item("CompanyID"))
            End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
        End Try

    End Sub

    Private Function ValidateID(ByVal CompanyID As String) As Boolean
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT Count(*) FROM CompanySettings WHERE CompanyID = '" & CompanyID & "'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Conn.Open()
            Dim Recordcount As Integer = ConCommand.ExecuteScalar
            Conn.Close()
            If Recordcount > 0 Then
                Return True
            Else
                Return False
            End If
        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
            Return True
        End Try
    End Function

    Private Function GenerateID() As String
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "SELECT Count(*) FROM CompanySettings"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

            Conn.Open()
            Dim Recordcount As Integer = ConCommand.ExecuteScalar
            Conn.Close()
            Dim IsIDGenerated As Boolean = False
            Dim Start As String = Nothing

            While IsIDGenerated = False
                Recordcount += 1
                If Recordcount >= 0 And Recordcount < 10 Then
                    Start = "C0" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If
                ElseIf Recordcount >= 10 And Recordcount < 100 Then
                    Start = "C" & Recordcount
                    If ValidateID(Start) = False Then
                        Return Start
                        Exit While
                    End If

                End If
            End While

        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
            Return "Connection Error"
        End Try
    End Function


    Private Sub cmdAdd_Click() Handles cmdAdd.Click


        lblInformation.Text = "Adding new record"
        CompanyIDTextBox.Text = ""
        NameofCompanyTextBox.Text = ""
        AddressTextBox.Text = ""
        PhoneNoTextBox.Text = ""
        EmailTextBox.Text = ""
        LogoPictureBox.Image = Nothing
        StampPictureBox.Image = Nothing
        RegistrationNoTextBox.Text = ""
        SubNameTextBox.Text = ""

        CompanyIDTextBox.Text = GenerateID()

        cmdSave.Enabled = True
        cmdUpdate.Enabled = False
        cmdDelete.Enabled = False


    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "INSERT INTO CompanySettings (CompanyID,NameofCompany,SubName,Address,PhoneNo,Email,Logo,Stamp,RegistrationNo) VALUES(@CompanyID, @NameofCompany, @SubName, @Address, @PhoneNo, @Email, @Logo, @Stamp, @RegistrationNo)"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)
            With ConCommand.Parameters
                .AddWithValue("@CompanyID", CompanyIDTextBox.Text)
                .AddWithValue("@NameofCompany", NameofCompanyTextBox.Text)
                .AddWithValue("@Address", AddressTextBox.Text)
                .AddWithValue("@PhoneNo", PhoneNoTextBox.Text)
                .AddWithValue("@Email", EmailTextBox.Text)
                .AddWithValue("@RegistrationNo", RegistrationNoTextBox.Text)
                .AddWithValue("@SubName", SubNameTextBox.Text)

                If LogoPictureBox.Image IsNot Nothing Then
                    Dim MyMemoryStream As New System.IO.MemoryStream
                    Dim theimage As Bitmap = LogoPictureBox.Image
                    theimage.MakeTransparent(Color.White)

                    theimage.Save(MyMemoryStream, System.Drawing.Imaging.ImageFormat.Png)
                    .AddWithValue("@Logo", MyMemoryStream.ToArray)

                Else
                    Dim MyMemoryStream As New System.IO.MemoryStream
                    .AddWithValue("@Logo", MyMemoryStream.ToArray)

                End If

                If StampPictureBox.Image IsNot Nothing Then
                    Dim MyMemoryStream As New System.IO.MemoryStream
                    Dim theimage As Bitmap = StampPictureBox.Image
                    theimage.MakeTransparent(Color.White)

                    theimage.Save(MyMemoryStream, System.Drawing.Imaging.ImageFormat.Png)
                    .AddWithValue("@Stamp", MyMemoryStream.ToArray)

                Else
                    Dim MyMemoryStream As New System.IO.MemoryStream
                    .AddWithValue("@Stamp", MyMemoryStream.ToArray)

                End If
            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()

            lblInformation.Text = "Successfully Inserted a new record"
            CreateLog(CurrentUserID, FullNameofUser, "Insert of new record in table (" & "CompanySettings" & " With ID (" & CompanyIDTextBox.Text & ")", 0)
            LoadRecords()

        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
        End Try

    End Sub


    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = "UPDATE CompanySettings SET NameofCompany =@NameofCompany, SubName = @SubName, Address =@Address, Stamp = @Stamp, PhoneNo =@PhoneNo, Email =@Email, Logo =@Logo, RegistrationNo = @RegistrationNo WHERE CompanyID = '" & CompanyIDTextBox.Text & "'"
            Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)
            With ConCommand.Parameters
                .AddWithValue("@CompanyID", CompanyIDTextBox.Text)
                .AddWithValue("@NameofCompany", NameofCompanyTextBox.Text)
                .AddWithValue("@Address", AddressTextBox.Text)
                .AddWithValue("@PhoneNo", PhoneNoTextBox.Text)
                .AddWithValue("@Email", EmailTextBox.Text)
                .AddWithValue("@RegistrationNo", RegistrationNoTextBox.Text)
                .AddWithValue("@SubName", SubNameTextBox.Text)

              If LogoPictureBox.Image IsNot Nothing Then
                    Dim MyMemoryStream As New System.IO.MemoryStream
                    Dim theimage As Bitmap = LogoPictureBox.Image
                    theimage.MakeTransparent(Color.White)

                    theimage.Save(MyMemoryStream, System.Drawing.Imaging.ImageFormat.Png)
                    .AddWithValue("@Logo", MyMemoryStream.ToArray)

                Else
                    Dim MyMemoryStream As New System.IO.MemoryStream
                    .AddWithValue("@Logo", MyMemoryStream.ToArray)

                End If

                If StampPictureBox.Image IsNot Nothing Then
                    Dim MyMemoryStream As New System.IO.MemoryStream
                    Dim theimage As Bitmap = StampPictureBox.Image
                    theimage.MakeTransparent(Color.White)

                    theimage.Save(MyMemoryStream, System.Drawing.Imaging.ImageFormat.Png)
                    .AddWithValue("@Stamp", MyMemoryStream.ToArray)

                Else
                    Dim MyMemoryStream As New System.IO.MemoryStream
                    .AddWithValue("@Stamp", MyMemoryStream.ToArray)

                End If
            End With

            Conn.Open()
            ConCommand.ExecuteNonQuery()
            Conn.Close()
            lblInformation.Text = "Successfully Updated a record"
            CreateLog(CurrentUserID, FullNameofUser, "Update of record in table (" & "CompanySettings" & " With ID (" & CompanyIDTextBox.Text & ")", 0)
        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
        End Try

    End Sub


    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Do you really want to delete the current record?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            Try
                Dim Conn As New SqlClient.SqlConnection(MyConnectionString)
                Dim Query As String = "DELETE FROM CompanySettings WHERE CompanyID = '" & CompanyIDTextBox.Text & "'"
                Dim ConCommand As New SqlClient.SqlCommand(Query, Conn)

                Conn.Open()
                ConCommand.ExecuteNonQuery()
                Conn.Close()
                lblInformation.Text = "Record Deleted"
                CreateLog(CurrentUserID, FullNameofUser, "Delete of record in table (" & "CompanySettings" & " With ID (" & CompanyIDTextBox.Text & ")", 0)
                LoadRecords()

            Catch Ex As Exception
                MessageBox.Show(Ex.Message)
            End Try
        End If

    End Sub



    Private Sub CompanyIDTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CompanyIDTextBox.TextChanged
        DisplayRecordInfo(CompanyIDTextBox.Text)

    End Sub

    Private Sub DisplayRecordInfo(ByVal RecordID As String)
        Try
            Dim Conn As New SqlClient.SqlConnection(MyConnectionString)

            Dim Query As String = " SELECT CompanyID,NameofCompany,SubName,Address,PhoneNo,Email,Logo,Stamp,RegistrationNo FROM CompanySettings WHERE CompanyID = '" & RecordID & "'"
            Dim ConTableAdapter As New SqlClient.SqlDataAdapter(Query, Conn)
            MySingleReportTable.Rows.Clear()
            ConTableAdapter.Fill(MySingleReportTable)

            If MySingleReportTable.Rows.Count > 0 Then
                lblInformation.Text = "Displaying details of a record"
                CompanyIDTextBox.Text = MySingleReportTable.Rows(0).Item("CompanyID")
                NameofCompanyTextBox.Text = MySingleReportTable.Rows(0).Item("NameofCompany")
                AddressTextBox.Text = MySingleReportTable.Rows(0).Item("Address")
                PhoneNoTextBox.Text = MySingleReportTable.Rows(0).Item("PhoneNo")
                EmailTextBox.Text = MySingleReportTable.Rows(0).Item("Email")
                RegistrationNoTextBox.Text = MySingleReportTable.Rows(0).Item("RegistrationNo")
                SubNameTextBox.Text = MySingleReportTable.Rows(0).Item("SubName")

                Try
                    Dim MyByte As Byte() = MySingleReportTable.Rows(0).Item("Logo")

                    Dim MyStream As System.IO.MemoryStream = New System.IO.MemoryStream(MyByte)
                    LogoPictureBox.Image = Image.FromStream(MyStream)
                Catch ex As Exception
                    LogoPictureBox.Image = Nothing
                End Try

                Try
                    Dim MyByte As Byte() = MySingleReportTable.Rows(0).Item("Stamp")

                    Dim MyStream As System.IO.MemoryStream = New System.IO.MemoryStream(MyByte)
                    StampPictureBox.Image = Image.FromStream(MyStream)
                Catch ex As Exception
                    StampPictureBox.Image = Nothing
                End Try

                lblInformation.Text = "Displaying details of a record"
            Else
            End If
            cmdSave.Enabled = False
            cmdUpdate.Enabled = True
            cmdDelete.Enabled = True

        Catch Ex As Exception
            MessageBox.Show(Ex.Message)
        End Try

    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub



    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Do you really want to logout? All other opened windows will be closed.", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            frmLogin.Show()
            frmDashboardNew.Close()
            Me.Close()
        End If

    End Sub



    Private Sub CompanySettingsDataGridView_CellContentClick(ByVal sender As Object, ByVal e As EventArgs) Handles GridView1.FocusedRowChanged
        DisplayRecordInfo(GridView1.GetFocusedRowCellDisplayText(GridView1.Columns(0)))

    End Sub




    Private Sub cmdBrowseLogo_Click() Handles cmdBrowseLogo.Click

        Try
            Dim OFD1 As New OpenFileDialog
            OFD1.FileName = ""
            OFD1.Multiselect = False
            OFD1.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp"

            If OFD1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                LogoPictureBox.Image = Image.FromFile(OFD1.FileName)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SearchToolStripMenuItem.Click
        'Me.PanelSearch.Visible = True
        'Me.PanelSearch.BringToFront()
        Try
            Dim MySearch As New frmQuickSearch
            MySearch.FormName = "frmCompanySettings"
            MySearch.TableName = "CompanySettings"
            MySearch.PrimaryKey = "CompanyID"

            MySearch.Show(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    Private Sub AdvancedSummaryToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AdvancedSummaryToolStripMenuItem.Click
        Try
            Dim myReport As New frmReport
            myReport.WindowState = FormWindowState.Maximized

            myReport.LoadTables()
            myReport.Show(Me)
            myReport.cboTableName.SelectedIndex = myReport.FindItemIndex("CompanySettings")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub cmdBrowseStamp_Click(sender As Object, e As EventArgs) Handles cmdBrowseStamp.Click

        Try
            Dim OFD1 As New OpenFileDialog
            OFD1.FileName = ""
            OFD1.Multiselect = False
            OFD1.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp"

            If OFD1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                StampPictureBox.Image = Image.FromFile(OFD1.FileName)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class
