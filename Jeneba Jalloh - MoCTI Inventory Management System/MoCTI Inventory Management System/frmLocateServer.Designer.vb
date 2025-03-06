<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocateServer
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try

    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocateServer))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.MyListView = New System.Windows.Forms.ListView()
        Me.MyImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressPanelSearch = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.SearchBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.PanelAccessDenied = New DevExpress.XtraEditors.PanelControl()
        Me.cmdAccept = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCheckConnection = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckUserNameTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdClosePanelAccess = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckConnectionBackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtServerPassword = New System.Windows.Forms.TextBox()
        Me.Label58 = New DevExpress.XtraEditors.LabelControl()
        Me.txtServerUsername = New DevExpress.XtraEditors.TextEdit()
        Me.Label57 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPortNo = New DevExpress.XtraEditors.TextEdit()
        Me.Label55 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDatabaseName = New DevExpress.XtraEditors.TextEdit()
        Me.Label54 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.PanelAccessDenied,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelAccessDenied.SuspendLayout
        CType(Me.CheckUserNameTextBox.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl1.SuspendLayout
        CType(Me.txtServerUsername.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPortNo.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDatabaseName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'MyListView
        '
        Me.MyListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.MyListView.LargeImageList = Me.MyImageList
        Me.MyListView.Location = New System.Drawing.Point(10, 145)
        Me.MyListView.Name = "MyListView"
        Me.MyListView.Size = New System.Drawing.Size(813, 348)
        Me.MyListView.SmallImageList = Me.MyImageList
        Me.MyListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.MyListView.TabIndex = 0
        Me.MyListView.UseCompatibleStateImageBehavior = false
        '
        'MyImageList
        '
        Me.MyImageList.ImageStream = CType(resources.GetObject("MyImageList.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.MyImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.MyImageList.Images.SetKeyName(0, "download (4).jpg")
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Chocolate
        Me.LabelControl1.Appearance.Options.UseFont = true
        Me.LabelControl1.Appearance.Options.UseForeColor = true
        Me.LabelControl1.Location = New System.Drawing.Point(67, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(297, 21)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Locate Remote Database Server Engine"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(65, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 54)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'ProgressPanelSearch
        '
        Me.ProgressPanelSearch.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanelSearch.Appearance.Options.UseBackColor = true
        Me.ProgressPanelSearch.BarAnimationElementThickness = 2
        Me.ProgressPanelSearch.Location = New System.Drawing.Point(245, 229)
        Me.ProgressPanelSearch.Name = "ProgressPanelSearch"
        Me.ProgressPanelSearch.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ProgressPanelSearch.Size = New System.Drawing.Size(362, 66)
        Me.ProgressPanelSearch.TabIndex = 4
        Me.ProgressPanelSearch.Text = "ProgressPanel1"
        Me.ProgressPanelSearch.Visible = false
        '
        'SearchBackgroundWorker
        '
        Me.SearchBackgroundWorker.WorkerReportsProgress = true
        Me.SearchBackgroundWorker.WorkerSupportsCancellation = true
        '
        'PanelAccessDenied
        '
        Me.PanelAccessDenied.Controls.Add(Me.cmdAccept)
        Me.PanelAccessDenied.Controls.Add(Me.cmdCheckConnection)
        Me.PanelAccessDenied.Controls.Add(Me.CheckPasswordTextBox)
        Me.PanelAccessDenied.Controls.Add(Me.LabelControl3)
        Me.PanelAccessDenied.Controls.Add(Me.CheckUserNameTextBox)
        Me.PanelAccessDenied.Controls.Add(Me.LabelControl4)
        Me.PanelAccessDenied.Controls.Add(Me.cmdClosePanelAccess)
        Me.PanelAccessDenied.Controls.Add(Me.LabelControl2)
        Me.PanelAccessDenied.Controls.Add(Me.Label2)
        Me.PanelAccessDenied.Location = New System.Drawing.Point(245, 166)
        Me.PanelAccessDenied.Name = "PanelAccessDenied"
        Me.PanelAccessDenied.Size = New System.Drawing.Size(308, 204)
        Me.PanelAccessDenied.TabIndex = 8
        Me.PanelAccessDenied.Visible = false
        '
        'cmdAccept
        '
        Me.cmdAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.cmdAccept.Enabled = false
        Me.cmdAccept.ImageOptions.Image = CType(resources.GetObject("cmdAccept.ImageOptions.Image"),System.Drawing.Image)
        Me.cmdAccept.Location = New System.Drawing.Point(146, 154)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(140, 26)
        Me.cmdAccept.TabIndex = 57
        Me.cmdAccept.Text = "Accept"
        '
        'cmdCheckConnection
        '
        Me.cmdCheckConnection.ImageOptions.Image = CType(resources.GetObject("cmdCheckConnection.ImageOptions.Image"),System.Drawing.Image)
        Me.cmdCheckConnection.Location = New System.Drawing.Point(11, 154)
        Me.cmdCheckConnection.Name = "cmdCheckConnection"
        Me.cmdCheckConnection.Size = New System.Drawing.Size(129, 26)
        Me.cmdCheckConnection.TabIndex = 56
        Me.cmdCheckConnection.Text = "Check Connection"
        '
        'CheckPasswordTextBox
        '
        Me.CheckPasswordTextBox.Location = New System.Drawing.Point(80, 118)
        Me.CheckPasswordTextBox.Name = "CheckPasswordTextBox"
        Me.CheckPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CheckPasswordTextBox.Size = New System.Drawing.Size(206, 21)
        Me.CheckPasswordTextBox.TabIndex = 54
        Me.CheckPasswordTextBox.Text = "password"
        Me.CheckPasswordTextBox.UseSystemPasswordChar = true
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl3.Appearance.Options.UseFont = true
        Me.LabelControl3.Location = New System.Drawing.Point(11, 120)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 15)
        Me.LabelControl3.TabIndex = 52
        Me.LabelControl3.Text = "Password:"
        '
        'CheckUserNameTextBox
        '
        Me.CheckUserNameTextBox.EditValue = "administrator"
        Me.CheckUserNameTextBox.Location = New System.Drawing.Point(80, 95)
        Me.CheckUserNameTextBox.Name = "CheckUserNameTextBox"
        Me.CheckUserNameTextBox.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CheckUserNameTextBox.Properties.UseSystemPasswordChar = true
        Me.CheckUserNameTextBox.Size = New System.Drawing.Size(207, 20)
        Me.CheckUserNameTextBox.TabIndex = 55
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl4.Appearance.Options.UseFont = true
        Me.LabelControl4.Location = New System.Drawing.Point(10, 97)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 15)
        Me.LabelControl4.TabIndex = 53
        Me.LabelControl4.Text = "Username:"
        '
        'cmdClosePanelAccess
        '
        Me.cmdClosePanelAccess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmdClosePanelAccess.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdClosePanelAccess.Appearance.Options.UseFont = true
        Me.cmdClosePanelAccess.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdClosePanelAccess.Location = New System.Drawing.Point(276, 2)
        Me.cmdClosePanelAccess.Name = "cmdClosePanelAccess"
        Me.cmdClosePanelAccess.Size = New System.Drawing.Size(29, 28)
        Me.cmdClosePanelAccess.TabIndex = 51
        Me.cmdClosePanelAccess.Text = "X"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Chocolate
        Me.LabelControl2.Appearance.Options.UseBackColor = true
        Me.LabelControl2.Appearance.Options.UseFont = true
        Me.LabelControl2.Appearance.Options.UseForeColor = true
        Me.LabelControl2.Location = New System.Drawing.Point(8, 8)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(105, 20)
        Me.LabelControl2.TabIndex = 50
        Me.LabelControl2.Text = "Access Deined! "
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 58)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Connection to the server was not established because the Username or Password of "& _ 
    "the SQL Server was incorrect. Please provide the correct SQL Server credentials "& _ 
    "and click ""Check Connection"""
        '
        'CheckConnectionBackgroundWorker1
        '
        Me.CheckConnectionBackgroundWorker1.WorkerReportsProgress = true
        Me.CheckConnectionBackgroundWorker1.WorkerSupportsCancellation = true
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl1.CaptionImageOptions.Image"),System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.txtServerPassword)
        Me.GroupControl1.Controls.Add(Me.Label58)
        Me.GroupControl1.Controls.Add(Me.txtServerUsername)
        Me.GroupControl1.Controls.Add(Me.Label57)
        Me.GroupControl1.Controls.Add(Me.txtPortNo)
        Me.GroupControl1.Controls.Add(Me.Label55)
        Me.GroupControl1.Controls.Add(Me.txtDatabaseName)
        Me.GroupControl1.Controls.Add(Me.Label54)
        Me.GroupControl1.Location = New System.Drawing.Point(536, 16)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(285, 123)
        Me.GroupControl1.TabIndex = 6
        Me.GroupControl1.Text = "Remote Connection Parameters"
        '
        'txtServerPassword
        '
        Me.txtServerPassword.Location = New System.Drawing.Point(113, 93)
        Me.txtServerPassword.Name = "txtServerPassword"
        Me.txtServerPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtServerPassword.Size = New System.Drawing.Size(139, 21)
        Me.txtServerPassword.TabIndex = 39
        Me.txtServerPassword.Text = "password"
        Me.txtServerPassword.UseSystemPasswordChar = true
        '
        'Label58
        '
        Me.Label58.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label58.Appearance.Options.UseFont = true
        Me.Label58.Location = New System.Drawing.Point(44, 95)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(57, 15)
        Me.Label58.TabIndex = 37
        Me.Label58.Text = "Password:"
        '
        'txtServerUsername
        '
        Me.txtServerUsername.EditValue = "administrator"
        Me.txtServerUsername.Location = New System.Drawing.Point(113, 70)
        Me.txtServerUsername.Name = "txtServerUsername"
        Me.txtServerUsername.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtServerUsername.Properties.UseSystemPasswordChar = true
        Me.txtServerUsername.Size = New System.Drawing.Size(140, 20)
        Me.txtServerUsername.TabIndex = 40
        '
        'Label57
        '
        Me.Label57.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label57.Appearance.Options.UseFont = true
        Me.Label57.Location = New System.Drawing.Point(43, 72)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(58, 15)
        Me.Label57.TabIndex = 38
        Me.Label57.Text = "Username:"
        '
        'txtPortNo
        '
        Me.txtPortNo.EditValue = "1433"
        Me.txtPortNo.Location = New System.Drawing.Point(113, 48)
        Me.txtPortNo.Name = "txtPortNo"
        Me.txtPortNo.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPortNo.Properties.UseSystemPasswordChar = true
        Me.txtPortNo.Size = New System.Drawing.Size(74, 20)
        Me.txtPortNo.TabIndex = 35
        '
        'Label55
        '
        Me.Label55.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label55.Appearance.Options.UseFont = true
        Me.Label55.Location = New System.Drawing.Point(54, 50)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(47, 15)
        Me.Label55.TabIndex = 33
        Me.Label55.Text = "Port No.:"
        '
        'txtDatabaseName
        '
        Me.txtDatabaseName.EditValue = "DIGICAB"
        Me.txtDatabaseName.Location = New System.Drawing.Point(113, 26)
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDatabaseName.Properties.UseSystemPasswordChar = true
        Me.txtDatabaseName.Size = New System.Drawing.Size(159, 20)
        Me.txtDatabaseName.TabIndex = 36
        '
        'Label54
        '
        Me.Label54.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label54.Appearance.Options.UseFont = true
        Me.Label54.Location = New System.Drawing.Point(12, 28)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(89, 15)
        Me.Label54.TabIndex = 34
        Me.Label54.Text = "Database Name:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"),System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(712, 497)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(111, 30)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "Close"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.ImageOptions.Image = CType(resources.GetObject("cmdRefresh.ImageOptions.Image"),System.Drawing.Image)
        Me.cmdRefresh.Location = New System.Drawing.Point(10, 109)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(111, 30)
        Me.cmdRefresh.TabIndex = 1
        Me.cmdRefresh.Text = "Refresh"
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.cmdOK.Enabled = false
        Me.cmdOK.ImageOptions.Image = CType(resources.GetObject("cmdOK.ImageOptions.Image"),System.Drawing.Image)
        Me.cmdOK.Location = New System.Drawing.Point(8, 497)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(111, 30)
        Me.cmdOK.TabIndex = 1
        Me.cmdOK.Text = "Connect"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"),Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(8, 16)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = true
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(57, 81)
        Me.PictureEdit1.TabIndex = 7
        '
        'frmLocateServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 539)
        Me.Controls.Add(Me.PanelAccessDenied)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.ProgressPanelSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.MyListView)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Name = "frmLocateServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locate Database Server"
        CType(Me.PanelAccessDenied,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelAccessDenied.ResumeLayout(false)
        Me.PanelAccessDenied.PerformLayout
        CType(Me.CheckUserNameTextBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        Me.GroupControl1.PerformLayout
        CType(Me.txtServerUsername.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPortNo.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDatabaseName.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout


End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents MyListView As ListView
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressPanelSearch As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents SearchBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents MyImageList As ImageList
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtPortNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDatabaseName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtServerPassword As TextBox
    Friend WithEvents Label58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtServerUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PanelAccessDenied As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdAccept As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCheckConnection As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckPasswordTextBox As TextBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckUserNameTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdClosePanelAccess As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckConnectionBackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
