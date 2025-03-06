<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompanySettings
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompanySettings))
        Me.CompanyIDLabel = New DevExpress.XtraEditors.LabelControl()
        Me.NameofCompanyLabel = New DevExpress.XtraEditors.LabelControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CompanySettingsDataGridView = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AddressLabel = New DevExpress.XtraEditors.LabelControl()
        Me.PhoneNoLabel = New DevExpress.XtraEditors.LabelControl()
        Me.EmailLabel = New DevExpress.XtraEditors.LabelControl()
        Me.LogoLabel = New DevExpress.XtraEditors.LabelControl()
        Me.Logo_Label = New DevExpress.XtraEditors.LabelControl()
        Me.CompanyIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameofCompanyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyIDTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.NameofCompanyTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.AddressTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.PhoneNoTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.cmdBrowseLogo = New DevExpress.XtraEditors.SimpleButton()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelOrange = New DevExpress.XtraEditors.PanelControl()
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelBody = New DevExpress.XtraEditors.PanelControl()
        Me.SubNameTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.RegistrationNoTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdBrowseStamp = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblInformation = New DevExpress.XtraEditors.LabelControl()
        Me.lblFormName = New DevExpress.XtraEditors.LabelControl()
        Me.StampPictureBox = New DevExpress.XtraEditors.PictureEdit()
        Me.LogoPictureBox = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CompanySettingsDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CompanyIDTextBox.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NameofCompanyTextBox.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.AddressTextBox.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PhoneNoTextBox.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EmailTextBox.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TopMenuStrip.SuspendLayout
        CType(Me.PanelOrange,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelBody,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelBody.SuspendLayout
        CType(Me.SubNameTextBox.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RegistrationNoTextBox.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.StampPictureBox.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LogoPictureBox.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'CompanyIDLabel
        '
        Me.CompanyIDLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CompanyIDLabel.Appearance.Options.UseFont = true
        Me.CompanyIDLabel.Location = New System.Drawing.Point(28, 92)
        Me.CompanyIDLabel.Name = "CompanyIDLabel"
        Me.CompanyIDLabel.Size = New System.Drawing.Size(69, 15)
        Me.CompanyIDLabel.TabIndex = 1
        Me.CompanyIDLabel.Text = "Company ID:"
        '
        'NameofCompanyLabel
        '
        Me.NameofCompanyLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.NameofCompanyLabel.Appearance.Options.UseFont = true
        Me.NameofCompanyLabel.Location = New System.Drawing.Point(28, 118)
        Me.NameofCompanyLabel.Name = "NameofCompanyLabel"
        Me.NameofCompanyLabel.Size = New System.Drawing.Size(102, 15)
        Me.NameofCompanyLabel.TabIndex = 1
        Me.NameofCompanyLabel.Text = "Name of Company:"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.CompanySettingsDataGridView
        Me.GridView1.Name = "GridView1"
        '
        'CompanySettingsDataGridView
        '
        Me.CompanySettingsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.CompanySettingsDataGridView.Location = New System.Drawing.Point(22, 291)
        Me.CompanySettingsDataGridView.MainView = Me.GridView2
        Me.CompanySettingsDataGridView.Name = "CompanySettingsDataGridView"
        Me.CompanySettingsDataGridView.Size = New System.Drawing.Size(965, 325)
        Me.CompanySettingsDataGridView.TabIndex = 23
        Me.CompanySettingsDataGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView1})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.CompanySettingsDataGridView
        Me.GridView2.Name = "GridView2"
        '
        'AddressLabel
        '
        Me.AddressLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AddressLabel.Appearance.Options.UseFont = true
        Me.AddressLabel.Location = New System.Drawing.Point(28, 170)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(47, 15)
        Me.AddressLabel.TabIndex = 1
        Me.AddressLabel.Text = "Address:"
        '
        'PhoneNoLabel
        '
        Me.PhoneNoLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.PhoneNoLabel.Appearance.Options.UseFont = true
        Me.PhoneNoLabel.Location = New System.Drawing.Point(28, 196)
        Me.PhoneNoLabel.Name = "PhoneNoLabel"
        Me.PhoneNoLabel.Size = New System.Drawing.Size(55, 15)
        Me.PhoneNoLabel.TabIndex = 1
        Me.PhoneNoLabel.Text = "Phone No:"
        '
        'EmailLabel
        '
        Me.EmailLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.EmailLabel.Appearance.Options.UseFont = true
        Me.EmailLabel.Location = New System.Drawing.Point(28, 222)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(34, 15)
        Me.EmailLabel.TabIndex = 1
        Me.EmailLabel.Text = "Email:"
        '
        'LogoLabel
        '
        Me.LogoLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LogoLabel.Appearance.Options.UseFont = true
        Me.LogoLabel.Location = New System.Drawing.Point(358, 67)
        Me.LogoLabel.Name = "LogoLabel"
        Me.LogoLabel.Size = New System.Drawing.Size(28, 15)
        Me.LogoLabel.TabIndex = 1
        Me.LogoLabel.Text = "Logo:"
        '
        'Logo_Label
        '
        Me.Logo_Label.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Logo_Label.Appearance.Options.UseFont = true
        Me.Logo_Label.Location = New System.Drawing.Point(22, 184)
        Me.Logo_Label.Name = "Logo_Label"
        Me.Logo_Label.Size = New System.Drawing.Size(70, 13)
        Me.Logo_Label.TabIndex = 1
        Me.Logo_Label.Text = "Logo:"
        '
        'CompanyIDDataGridViewTextBoxColumn
        '
        Me.CompanyIDDataGridViewTextBoxColumn.DataPropertyName = "CompanyID"
        Me.CompanyIDDataGridViewTextBoxColumn.HeaderText = "CompanyID"
        Me.CompanyIDDataGridViewTextBoxColumn.Name = "CompanyIDDataGridViewTextBoxColumn"
        Me.CompanyIDDataGridViewTextBoxColumn.ReadOnly = true
        '
        'NameofCompanyDataGridViewTextBoxColumn
        '
        Me.NameofCompanyDataGridViewTextBoxColumn.DataPropertyName = "NameofCompany"
        Me.NameofCompanyDataGridViewTextBoxColumn.HeaderText = "NameofCompany"
        Me.NameofCompanyDataGridViewTextBoxColumn.Name = "NameofCompanyDataGridViewTextBoxColumn"
        Me.NameofCompanyDataGridViewTextBoxColumn.ReadOnly = true
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = true
        '
        'PhoneNoDataGridViewTextBoxColumn
        '
        Me.PhoneNoDataGridViewTextBoxColumn.DataPropertyName = "PhoneNo"
        Me.PhoneNoDataGridViewTextBoxColumn.HeaderText = "PhoneNo"
        Me.PhoneNoDataGridViewTextBoxColumn.Name = "PhoneNoDataGridViewTextBoxColumn"
        Me.PhoneNoDataGridViewTextBoxColumn.ReadOnly = true
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = true
        '
        'LogoDataGridViewTextBoxColumn
        '
        Me.LogoDataGridViewTextBoxColumn.DataPropertyName = "Logo"
        Me.LogoDataGridViewTextBoxColumn.HeaderText = "Logo"
        Me.LogoDataGridViewTextBoxColumn.Name = "LogoDataGridViewTextBoxColumn"
        Me.LogoDataGridViewTextBoxColumn.ReadOnly = true
        '
        'CompanyIDTextBox
        '
        Me.CompanyIDTextBox.Location = New System.Drawing.Point(139, 89)
        Me.CompanyIDTextBox.Name = "CompanyIDTextBox"
        Me.CompanyIDTextBox.Properties.ReadOnly = true
        Me.CompanyIDTextBox.Size = New System.Drawing.Size(166, 20)
        Me.CompanyIDTextBox.TabIndex = 1
        '
        'NameofCompanyTextBox
        '
        Me.NameofCompanyTextBox.Location = New System.Drawing.Point(139, 115)
        Me.NameofCompanyTextBox.Name = "NameofCompanyTextBox"
        Me.NameofCompanyTextBox.Size = New System.Drawing.Size(166, 20)
        Me.NameofCompanyTextBox.TabIndex = 1
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(139, 167)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(166, 20)
        Me.AddressTextBox.TabIndex = 3
        '
        'PhoneNoTextBox
        '
        Me.PhoneNoTextBox.Location = New System.Drawing.Point(139, 193)
        Me.PhoneNoTextBox.Name = "PhoneNoTextBox"
        Me.PhoneNoTextBox.Size = New System.Drawing.Size(166, 20)
        Me.PhoneNoTextBox.TabIndex = 4
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(139, 219)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(166, 20)
        Me.EmailTextBox.TabIndex = 5
        '
        'cmdBrowseLogo
        '
        Me.cmdBrowseLogo.ImageOptions.Image = CType(resources.GetObject("cmdBrowseLogo.ImageOptions.Image"),System.Drawing.Image)
        Me.cmdBrowseLogo.Location = New System.Drawing.Point(358, 196)
        Me.cmdBrowseLogo.Name = "cmdBrowseLogo"
        Me.cmdBrowseLogo.Size = New System.Drawing.Size(119, 27)
        Me.cmdBrowseLogo.TabIndex = 12
        Me.cmdBrowseLogo.Text = "Browse"
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TopMenuStrip.AutoSize = false
        Me.TopMenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 4)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(1015, 24)
        Me.TopMenuStrip.TabIndex = 85
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "&Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.SearchToolStripMenuItem, Me.AdvancedSummaryToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.PrintToolStripMenuItem.Text = "Print Current Record"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'AdvancedSummaryToolStripMenuItem
        '
        Me.AdvancedSummaryToolStripMenuItem.Name = "AdvancedSummaryToolStripMenuItem"
        Me.AdvancedSummaryToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AdvancedSummaryToolStripMenuItem.Text = "Advanced Summary"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'PanelOrange
        '
        Me.PanelOrange.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.PanelOrange.Appearance.Options.UseBackColor = true
        Me.PanelOrange.Location = New System.Drawing.Point(-4, 2)
        Me.PanelOrange.Name = "PanelOrange"
        Me.PanelOrange.Size = New System.Drawing.Size(1250, 10)
        Me.PanelOrange.TabIndex = 84
        Me.PanelOrange.Visible = false
        '
        'cmdAdd
        '
        Me.cmdAdd.ImageOptions.Image = CType(resources.GetObject("cmdAdd.ImageOptions.Image"),System.Drawing.Image)
        Me.cmdAdd.Location = New System.Drawing.Point(709, 87)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(102, 27)
        Me.cmdAdd.TabIndex = 12
        Me.cmdAdd.Text = "Add New"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = CType(resources.GetObject("cmdSave.ImageOptions.Image"),System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(709, 120)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(102, 27)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "Save"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.ImageOptions.Image = CType(resources.GetObject("cmdUpdate.ImageOptions.Image"),System.Drawing.Image)
        Me.cmdUpdate.Location = New System.Drawing.Point(709, 153)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(102, 27)
        Me.cmdUpdate.TabIndex = 12
        Me.cmdUpdate.Text = "Update"
        '
        'cmdDelete
        '
        Me.cmdDelete.ImageOptions.Image = CType(resources.GetObject("cmdDelete.ImageOptions.Image"),System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(709, 186)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(102, 27)
        Me.cmdDelete.TabIndex = 12
        Me.cmdDelete.Text = "Delete"
        '
        'PanelBody
        '
        Me.PanelBody.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.PanelBody.Appearance.Options.UseBackColor = true
        Me.PanelBody.Controls.Add(Me.LogoPictureBox)
        Me.PanelBody.Controls.Add(Me.StampPictureBox)
        Me.PanelBody.Controls.Add(Me.SubNameTextBox)
        Me.PanelBody.Controls.Add(Me.LabelControl3)
        Me.PanelBody.Controls.Add(Me.RegistrationNoTextBox)
        Me.PanelBody.Controls.Add(Me.LabelControl2)
        Me.PanelBody.Controls.Add(Me.cmdBrowseStamp)
        Me.PanelBody.Controls.Add(Me.LabelControl1)
        Me.PanelBody.Controls.Add(Me.TopMenuStrip)
        Me.PanelBody.Controls.Add(Me.PanelOrange)
        Me.PanelBody.Controls.Add(Me.lblInformation)
        Me.PanelBody.Controls.Add(Me.lblFormName)
        Me.PanelBody.Controls.Add(Me.CompanySettingsDataGridView)
        Me.PanelBody.Controls.Add(Me.cmdDelete)
        Me.PanelBody.Controls.Add(Me.cmdUpdate)
        Me.PanelBody.Controls.Add(Me.cmdAdd)
        Me.PanelBody.Controls.Add(Me.cmdSave)
        Me.PanelBody.Controls.Add(Me.CompanyIDTextBox)
        Me.PanelBody.Controls.Add(Me.NameofCompanyTextBox)
        Me.PanelBody.Controls.Add(Me.AddressTextBox)
        Me.PanelBody.Controls.Add(Me.PhoneNoTextBox)
        Me.PanelBody.Controls.Add(Me.EmailTextBox)
        Me.PanelBody.Controls.Add(Me.cmdBrowseLogo)
        Me.PanelBody.Controls.Add(Me.CompanyIDLabel)
        Me.PanelBody.Controls.Add(Me.NameofCompanyLabel)
        Me.PanelBody.Controls.Add(Me.AddressLabel)
        Me.PanelBody.Controls.Add(Me.PhoneNoLabel)
        Me.PanelBody.Controls.Add(Me.EmailLabel)
        Me.PanelBody.Controls.Add(Me.LogoLabel)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(0, 0)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(1015, 631)
        Me.PanelBody.TabIndex = 1
        '
        'SubNameTextBox
        '
        Me.SubNameTextBox.Location = New System.Drawing.Point(139, 141)
        Me.SubNameTextBox.Name = "SubNameTextBox"
        Me.SubNameTextBox.Size = New System.Drawing.Size(166, 20)
        Me.SubNameTextBox.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl3.Appearance.Options.UseFont = true
        Me.LabelControl3.Location = New System.Drawing.Point(28, 144)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 15)
        Me.LabelControl3.TabIndex = 92
        Me.LabelControl3.Text = "Sub Name"
        '
        'RegistrationNoTextBox
        '
        Me.RegistrationNoTextBox.Location = New System.Drawing.Point(139, 245)
        Me.RegistrationNoTextBox.Name = "RegistrationNoTextBox"
        Me.RegistrationNoTextBox.Size = New System.Drawing.Size(166, 20)
        Me.RegistrationNoTextBox.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl2.Appearance.Options.UseFont = true
        Me.LabelControl2.Location = New System.Drawing.Point(28, 248)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(88, 15)
        Me.LabelControl2.TabIndex = 90
        Me.LabelControl2.Text = "Registration No:"
        '
        'cmdBrowseStamp
        '
        Me.cmdBrowseStamp.ImageOptions.Image = CType(resources.GetObject("cmdBrowseStamp.ImageOptions.Image"),System.Drawing.Image)
        Me.cmdBrowseStamp.Location = New System.Drawing.Point(495, 196)
        Me.cmdBrowseStamp.Name = "cmdBrowseStamp"
        Me.cmdBrowseStamp.Size = New System.Drawing.Size(116, 27)
        Me.cmdBrowseStamp.TabIndex = 88
        Me.cmdBrowseStamp.Text = "Browse"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl1.Appearance.Options.UseFont = true
        Me.LabelControl1.Location = New System.Drawing.Point(496, 67)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(91, 15)
        Me.LabelControl1.TabIndex = 87
        Me.LabelControl1.Text = "Company Stamp:"
        '
        'lblInformation
        '
        Me.lblInformation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblInformation.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblInformation.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInformation.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblInformation.Appearance.Options.UseBackColor = true
        Me.lblInformation.Appearance.Options.UseFont = true
        Me.lblInformation.Appearance.Options.UseForeColor = true
        Me.lblInformation.Location = New System.Drawing.Point(358, 35)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(0, 20)
        Me.lblInformation.TabIndex = 1
        '
        'lblFormName
        '
        Me.lblFormName.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblFormName.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFormName.Appearance.Options.UseBackColor = true
        Me.lblFormName.Appearance.Options.UseFont = true
        Me.lblFormName.Location = New System.Drawing.Point(28, 48)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(166, 26)
        Me.lblFormName.TabIndex = 1
        Me.lblFormName.Text = "Company Settings"
        '
        'StampPictureBox
        '
        Me.StampPictureBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.StampPictureBox.Location = New System.Drawing.Point(496, 86)
        Me.StampPictureBox.Name = "StampPictureBox"
        Me.StampPictureBox.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.StampPictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.StampPictureBox.Size = New System.Drawing.Size(115, 104)
        Me.StampPictureBox.TabIndex = 93
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.LogoPictureBox.Location = New System.Drawing.Point(358, 86)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.LogoPictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.LogoPictureBox.Size = New System.Drawing.Size(119, 104)
        Me.LogoPictureBox.TabIndex = 94
        '
        'frmCompanySettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 631)
        Me.Controls.Add(Me.PanelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCompanySettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CompanySettings"
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CompanySettingsDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CompanyIDTextBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NameofCompanyTextBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.AddressTextBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PhoneNoTextBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EmailTextBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.TopMenuStrip.ResumeLayout(false)
        Me.TopMenuStrip.PerformLayout
        CType(Me.PanelOrange,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelBody,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelBody.ResumeLayout(false)
        Me.PanelBody.PerformLayout
        CType(Me.SubNameTextBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RegistrationNoTextBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.StampPictureBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LogoPictureBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CompanyIDTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NameofCompanyTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AddressTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PhoneNoTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdBrowseLogo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CompanyIDLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NameofCompanyLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AddressLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PhoneNoLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmailLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LogoLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Logo_Label As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CompanyIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameofCompanyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelOrange As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CompanySettingsDataGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents PanelBody As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblInformation As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFormName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TopMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancedSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdBrowseStamp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RegistrationNoTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SubNameTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LogoPictureBox As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents StampPictureBox As DevExpress.XtraEditors.PictureEdit
End Class
