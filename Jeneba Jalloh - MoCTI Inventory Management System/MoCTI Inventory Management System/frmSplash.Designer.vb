<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.PanelProgressbarContainer = New DevExpress.XtraEditors.PanelControl()
        Me.PanelProgressbar = New DevExpress.XtraEditors.PanelControl()
        Me.lblPercentage = New DevExpress.XtraEditors.LabelControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.tmrLoad = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitle1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitleBottom = New DevExpress.XtraEditors.LabelControl()
        Me.lblVersion = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelHeader = New DevExpress.XtraEditors.PanelControl()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.pbProjectLogo = New System.Windows.Forms.PictureBox()
        Me.lblTitle2 = New DevExpress.XtraEditors.LabelControl()
        Me.tmrLoadComplete = New System.Windows.Forms.Timer(Me.components)
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        CType(Me.PanelProgressbarContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProgressbarContainer.SuspendLayout()
        CType(Me.PanelProgressbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProjectLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelProgressbarContainer
        '
        Me.PanelProgressbarContainer.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.PanelProgressbarContainer.Appearance.Options.UseBackColor = True
        Me.PanelProgressbarContainer.Controls.Add(Me.PanelProgressbar)
        Me.PanelProgressbarContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelProgressbarContainer.Location = New System.Drawing.Point(0, 341)
        Me.PanelProgressbarContainer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelProgressbarContainer.Name = "PanelProgressbarContainer"
        Me.PanelProgressbarContainer.Size = New System.Drawing.Size(442, 11)
        Me.PanelProgressbarContainer.TabIndex = 0
        '
        'PanelProgressbar
        '
        Me.PanelProgressbar.Appearance.BackColor = System.Drawing.Color.SandyBrown
        Me.PanelProgressbar.Appearance.Options.UseBackColor = True
        Me.PanelProgressbar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelProgressbar.Location = New System.Drawing.Point(2, 2)
        Me.PanelProgressbar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelProgressbar.Name = "PanelProgressbar"
        Me.PanelProgressbar.Size = New System.Drawing.Size(12, 7)
        Me.PanelProgressbar.TabIndex = 0
        '
        'lblPercentage
        '
        Me.lblPercentage.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblPercentage.Appearance.Options.UseForeColor = True
        Me.lblPercentage.Location = New System.Drawing.Point(9, 18)
        Me.lblPercentage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(77, 16)
        Me.lblPercentage.TabIndex = 2
        Me.lblPercentage.Text = "0% Complete"
        '
        'Label5
        '
        Me.Label5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label5.Appearance.Options.UseFont = True
        Me.Label5.Appearance.Options.UseForeColor = True
        Me.Label5.Location = New System.Drawing.Point(10, 287)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(228, 22)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Central University (CUSL)"
        '
        'tmrLoad
        '
        Me.tmrLoad.Enabled = True
        Me.tmrLoad.Interval = 40
        '
        'lblTitle1
        '
        Me.lblTitle1.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTitle1.Appearance.Options.UseFont = True
        Me.lblTitle1.Appearance.Options.UseForeColor = True
        Me.lblTitle1.Location = New System.Drawing.Point(49, 114)
        Me.lblTitle1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(342, 25)
        Me.lblTitle1.TabIndex = 1
        Me.lblTitle1.Text = "MoCTI Inventory Management System"
        '
        'lblTitleBottom
        '
        Me.lblTitleBottom.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleBottom.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblTitleBottom.Appearance.Options.UseFont = True
        Me.lblTitleBottom.Appearance.Options.UseForeColor = True
        Me.lblTitleBottom.Location = New System.Drawing.Point(117, 140)
        Me.lblTitleBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblTitleBottom.Name = "lblTitleBottom"
        Me.lblTitleBottom.Size = New System.Drawing.Size(221, 18)
        Me.lblTitleBottom.TabIndex = 1
        Me.lblTitleBottom.Text = "Management Information System"
        '
        'lblVersion
        '
        Me.lblVersion.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblVersion.Appearance.Options.UseFont = True
        Me.lblVersion.Appearance.Options.UseForeColor = True
        Me.lblVersion.Location = New System.Drawing.Point(169, 161)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(91, 18)
        Me.lblVersion.TabIndex = 1
        Me.lblVersion.Text = "Version: 1.0.1"
        '
        'Panel1
        '
        Me.Panel1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel1.Appearance.Options.UseBackColor = True
        Me.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lblTitle1)
        Me.Panel1.Controls.Add(Me.lblTitleBottom)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblVersion)
        Me.Panel1.Controls.Add(Me.PanelHeader)
        Me.Panel1.Controls.Add(Me.cmdClose)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.pbProjectLogo)
        Me.Panel1.Controls.Add(Me.lblPercentage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 341)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.MoCTIMIS.My.Resources.Resources.RHSILogo
        Me.PictureBox2.Location = New System.Drawing.Point(341, 259)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(85, 73)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label1.Appearance.Options.UseFont = True
        Me.Label1.Appearance.Options.UseForeColor = True
        Me.Label1.Location = New System.Drawing.Point(10, 312)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Designed by: Jeneba Jalloh"
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(416, 82)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelHeader
        '
        Me.PanelHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelHeader.Appearance.Options.UseBackColor = True
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(2, 2)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(438, 10)
        Me.PanelHeader.TabIndex = 9
        Me.PanelHeader.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(408, 14)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(27, 25)
        Me.cmdClose.TabIndex = 8
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "X"
        '
        'pbProjectLogo
        '
        Me.pbProjectLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbProjectLogo.Image = Global.MoCTIMIS.My.Resources.Resources.IVMSLogo
        Me.pbProjectLogo.Location = New System.Drawing.Point(157, 20)
        Me.pbProjectLogo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pbProjectLogo.Name = "pbProjectLogo"
        Me.pbProjectLogo.Size = New System.Drawing.Size(115, 100)
        Me.pbProjectLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProjectLogo.TabIndex = 58
        Me.pbProjectLogo.TabStop = False
        '
        'lblTitle2
        '
        Me.lblTitle2.Appearance.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblTitle2.Appearance.Options.UseFont = True
        Me.lblTitle2.Appearance.Options.UseForeColor = True
        Me.lblTitle2.Location = New System.Drawing.Point(146, 83)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(466, 29)
        Me.lblTitle2.TabIndex = 1
        Me.lblTitle2.Text = "ORLABU Electrical Installation and Equipments"
        '
        'tmrLoadComplete
        '
        Me.tmrLoadComplete.Interval = 70
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 352)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelProgressbarContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSplash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Maroon
        CType(Me.PanelProgressbarContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProgressbarContainer.ResumeLayout(False)
        CType(Me.PanelProgressbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProjectLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelProgressbarContainer As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelProgressbar As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblPercentage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl

    Friend WithEvents tmrLoad As System.Windows.Forms.Timer
    Friend WithEvents lblTitle1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitleBottom As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblVersion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pbProjectLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelHeader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tmrLoadComplete As System.Windows.Forms.Timer
    Friend WithEvents lblTitle2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents PictureBox2 As PictureBox
End Class
