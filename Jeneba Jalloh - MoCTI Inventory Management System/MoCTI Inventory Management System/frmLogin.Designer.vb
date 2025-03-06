<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.MyToggleSwitch = New DevExpress.XtraEditors.ToggleSwitch()
        Me.cmdSettings2 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.Label49 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdProductActivation = New DevExpress.XtraEditors.SimpleButton()
        Me.txtUsername = New DevExpress.XtraEditors.TextEdit()
        Me.cmdCheckforUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.Label31 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTime = New DevExpress.XtraEditors.LabelControl()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblProjectLogo2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblVersion = New DevExpress.XtraEditors.LabelControl()
        Me.cmdLocateServer = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.CheckforAdminAccBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.lblTitle1 = New DevExpress.XtraEditors.LabelControl()
        Me.pbProjectLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblDaysRemaining = New DevExpress.XtraEditors.LabelControl()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.MyToggleSwitch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProjectLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(551, 416)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.White
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.PictureBox2)
        Me.XtraTabPage1.Controls.Add(Me.lblTitle1)
        Me.XtraTabPage1.Controls.Add(Me.pbProjectLogo)
        Me.XtraTabPage1.Controls.Add(Me.MyToggleSwitch)
        Me.XtraTabPage1.Controls.Add(Me.cmdSettings2)
        Me.XtraTabPage1.Controls.Add(Me.cmdCancel)
        Me.XtraTabPage1.Controls.Add(Me.cmdLogin)
        Me.XtraTabPage1.Controls.Add(Me.Label49)
        Me.XtraTabPage1.Controls.Add(Me.cmdProductActivation)
        Me.XtraTabPage1.Controls.Add(Me.txtUsername)
        Me.XtraTabPage1.Controls.Add(Me.cmdCheckforUpdate)
        Me.XtraTabPage1.Controls.Add(Me.Label31)
        Me.XtraTabPage1.Controls.Add(Me.lblTime)
        Me.XtraTabPage1.Controls.Add(Me.txtPassword)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Controls.Add(Me.lblProjectLogo2)
        Me.XtraTabPage1.Controls.Add(Me.lblDaysRemaining)
        Me.XtraTabPage1.Controls.Add(Me.lblVersion)
        Me.XtraTabPage1.Controls.Add(Me.cmdLocateServer)
        Me.XtraTabPage1.Controls.Add(Me.PictureEdit1)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(547, 388)
        Me.XtraTabPage1.Text = "Login"
        '
        'MyToggleSwitch
        '
        Me.MyToggleSwitch.Location = New System.Drawing.Point(50, 345)
        Me.MyToggleSwitch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MyToggleSwitch.Name = "MyToggleSwitch"
        Me.MyToggleSwitch.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyToggleSwitch.Properties.Appearance.ForeColor = System.Drawing.Color.Brown
        Me.MyToggleSwitch.Properties.Appearance.Options.UseFont = True
        Me.MyToggleSwitch.Properties.Appearance.Options.UseForeColor = True
        Me.MyToggleSwitch.Properties.OffText = "Offline"
        Me.MyToggleSwitch.Properties.OnText = "Online"
        Me.MyToggleSwitch.Size = New System.Drawing.Size(147, 29)
        Me.MyToggleSwitch.TabIndex = 103
        '
        'cmdSettings2
        '
        Me.cmdSettings2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdSettings2.ImageOptions.Image = CType(resources.GetObject("cmdSettings2.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSettings2.Location = New System.Drawing.Point(14, 9)
        Me.cmdSettings2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSettings2.Name = "cmdSettings2"
        Me.cmdSettings2.Size = New System.Drawing.Size(128, 33)
        Me.cmdSettings2.TabIndex = 100
        Me.cmdSettings2.Text = "Settings"
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCancel.Appearance.Options.UseForeColor = True
        Me.cmdCancel.Location = New System.Drawing.Point(299, 251)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(93, 36)
        Me.cmdCancel.TabIndex = 0
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdLogin
        '
        Me.cmdLogin.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdLogin.Appearance.Options.UseForeColor = True
        Me.cmdLogin.ImageOptions.Image = CType(resources.GetObject("cmdLogin.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdLogin.Location = New System.Drawing.Point(192, 251)
        Me.cmdLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(99, 36)
        Me.cmdLogin.TabIndex = 0
        Me.cmdLogin.Text = "Login"
        '
        'Label49
        '
        Me.Label49.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Appearance.Options.UseFont = True
        Me.Label49.Location = New System.Drawing.Point(112, 217)
        Me.Label49.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(66, 19)
        Me.Label49.TabIndex = 17
        Me.Label49.Text = "Password:"
        '
        'cmdProductActivation
        '
        Me.cmdProductActivation.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProductActivation.Appearance.Options.UseFont = True
        Me.cmdProductActivation.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdProductActivation.ImageOptions.Image = CType(resources.GetObject("cmdProductActivation.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdProductActivation.Location = New System.Drawing.Point(6, 261)
        Me.cmdProductActivation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdProductActivation.Name = "cmdProductActivation"
        Me.cmdProductActivation.Size = New System.Drawing.Size(128, 30)
        Me.cmdProductActivation.TabIndex = 96
        Me.cmdProductActivation.Text = "Product Activation"
        Me.cmdProductActivation.Visible = False
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(192, 176)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Properties.Appearance.Options.UseFont = True
        Me.txtUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtUsername.Size = New System.Drawing.Size(199, 28)
        Me.txtUsername.TabIndex = 18
        '
        'cmdCheckforUpdate
        '
        Me.cmdCheckforUpdate.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheckforUpdate.Appearance.Options.UseFont = True
        Me.cmdCheckforUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdCheckforUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCheckforUpdate.ImageOptions.Image = CType(resources.GetObject("cmdCheckforUpdate.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCheckforUpdate.Location = New System.Drawing.Point(14, 38)
        Me.cmdCheckforUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCheckforUpdate.Name = "cmdCheckforUpdate"
        Me.cmdCheckforUpdate.Size = New System.Drawing.Size(145, 33)
        Me.cmdCheckforUpdate.TabIndex = 66
        Me.cmdCheckforUpdate.Text = "Check for Update"
        Me.cmdCheckforUpdate.Visible = False
        '
        'Label31
        '
        Me.Label31.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Appearance.Options.UseFont = True
        Me.Label31.Location = New System.Drawing.Point(112, 180)
        Me.Label31.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(70, 19)
        Me.Label31.TabIndex = 16
        Me.Label31.Text = "Username:"
        '
        'lblTime
        '
        Me.lblTime.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Appearance.Options.UseBackColor = True
        Me.lblTime.Appearance.Options.UseFont = True
        Me.lblTime.Appearance.Options.UseForeColor = True
        Me.lblTime.Location = New System.Drawing.Point(442, 25)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(86, 29)
        Me.lblTime.TabIndex = 65
        Me.lblTime.Text = "14:45:11"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(192, 212)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Properties.Appearance.Options.UseFont = True
        Me.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Properties.UseSystemPasswordChar = True
        Me.txtPassword.Size = New System.Drawing.Size(199, 28)
        Me.txtPassword.TabIndex = 19
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(52, 322)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(128, 23)
        Me.LabelControl1.TabIndex = 63
        Me.LabelControl1.Text = "Connection Type"
        '
        'lblProjectLogo2
        '
        Me.lblProjectLogo2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectLogo2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblProjectLogo2.Appearance.Options.UseFont = True
        Me.lblProjectLogo2.Appearance.Options.UseForeColor = True
        Me.lblProjectLogo2.Location = New System.Drawing.Point(149, 116)
        Me.lblProjectLogo2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblProjectLogo2.Name = "lblProjectLogo2"
        Me.lblProjectLogo2.Size = New System.Drawing.Size(280, 24)
        Me.lblProjectLogo2.TabIndex = 63
        Me.lblProjectLogo2.Text = "Management Information System"
        '
        'lblVersion
        '
        Me.lblVersion.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblVersion.Appearance.Options.UseFont = True
        Me.lblVersion.Appearance.Options.UseForeColor = True
        Me.lblVersion.Location = New System.Drawing.Point(223, 140)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(89, 19)
        Me.lblVersion.TabIndex = 61
        Me.lblVersion.Text = "Version: 1.0.1"
        '
        'cmdLocateServer
        '
        Me.cmdLocateServer.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLocateServer.Appearance.Options.UseFont = True
        Me.cmdLocateServer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdLocateServer.ImageOptions.Image = CType(resources.GetObject("cmdLocateServer.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdLocateServer.Location = New System.Drawing.Point(6, 288)
        Me.cmdLocateServer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLocateServer.Name = "cmdLocateServer"
        Me.cmdLocateServer.Size = New System.Drawing.Size(128, 30)
        Me.cmdLocateServer.TabIndex = 102
        Me.cmdLocateServer.Text = "Locate Server"
        Me.cmdLocateServer.Visible = False
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(6, 320)
        Me.PictureEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(41, 57)
        Me.PictureEdit1.TabIndex = 104
        '
        'Panel1
        '
        Me.Panel1.Appearance.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Appearance.Options.UseBackColor = True
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(466, 310)
        Me.Panel1.TabIndex = 102
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 1000
        '
        'CheckforAdminAccBackgroundWorker
        '
        Me.CheckforAdminAccBackgroundWorker.WorkerReportsProgress = True
        Me.CheckforAdminAccBackgroundWorker.WorkerSupportsCancellation = True
        '
        'lblTitle1
        '
        Me.lblTitle1.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTitle1.Appearance.Options.UseFont = True
        Me.lblTitle1.Appearance.Options.UseForeColor = True
        Me.lblTitle1.Location = New System.Drawing.Point(103, 94)
        Me.lblTitle1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(342, 25)
        Me.lblTitle1.TabIndex = 108
        Me.lblTitle1.Text = "MoCTI Inventory Management System"
        '
        'pbProjectLogo
        '
        Me.pbProjectLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbProjectLogo.Image = Global.MoCTIMIS.My.Resources.Resources.IVMSLogo
        Me.pbProjectLogo.Location = New System.Drawing.Point(211, 0)
        Me.pbProjectLogo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pbProjectLogo.Name = "pbProjectLogo"
        Me.pbProjectLogo.Size = New System.Drawing.Size(115, 100)
        Me.pbProjectLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProjectLogo.TabIndex = 109
        Me.pbProjectLogo.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.MoCTIMIS.My.Resources.Resources.RHSILogo
        Me.PictureBox2.Location = New System.Drawing.Point(452, 288)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(85, 73)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 110
        Me.PictureBox2.TabStop = False
        '
        'lblDaysRemaining
        '
        Me.lblDaysRemaining.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaysRemaining.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblDaysRemaining.Appearance.Options.UseFont = True
        Me.lblDaysRemaining.Appearance.Options.UseForeColor = True
        Me.lblDaysRemaining.Appearance.Options.UseTextOptions = True
        Me.lblDaysRemaining.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblDaysRemaining.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDaysRemaining.Location = New System.Drawing.Point(380, 366)
        Me.lblDaysRemaining.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblDaysRemaining.Name = "lblDaysRemaining"
        Me.lblDaysRemaining.Size = New System.Drawing.Size(155, 18)
        Me.lblDaysRemaining.TabIndex = 61
        Me.lblDaysRemaining.Text = "Version: 1.0.1"
        Me.lblDaysRemaining.Visible = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 416)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.DimGray
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.MyToggleSwitch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProjectLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblProjectLogo2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblVersion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCheckforUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdProductActivation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSettings2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tmrTime As Timer
    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents CheckforAdminAccBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmdLocateServer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MyToggleSwitch As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblTitle1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pbProjectLogo As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblDaysRemaining As DevExpress.XtraEditors.LabelControl
End Class
