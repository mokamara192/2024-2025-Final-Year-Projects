<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckConnection
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckConnection))
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelProgressbarContainer = New DevExpress.XtraEditors.PanelControl()
        Me.PanelProgressbar = New DevExpress.XtraEditors.PanelControl()
        Me.lblConnection = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.tmrProgressbar = New System.Windows.Forms.Timer(Me.components)
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PanelProgressbarContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProgressbarContainer.SuspendLayout()
        CType(Me.PanelProgressbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Appearance.Options.UseBackColor = True
        Me.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Panel1.Controls.Add(Me.PictureEdit1)
        Me.Panel1.Controls.Add(Me.cmdClose)
        Me.Panel1.Controls.Add(Me.cmdExit)
        Me.Panel1.Controls.Add(Me.PanelProgressbarContainer)
        Me.Panel1.Controls.Add(Me.lblConnection)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 139)
        Me.Panel1.TabIndex = 2
        '
        'cmdClose
        '
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdClose.Location = New System.Drawing.Point(359, 2)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(24, 22)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "X"
        Me.cmdClose.Visible = False
        '
        'PanelProgressbarContainer
        '
        Me.PanelProgressbarContainer.Controls.Add(Me.PanelProgressbar)
        Me.PanelProgressbarContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelProgressbarContainer.Location = New System.Drawing.Point(2, 126)
        Me.PanelProgressbarContainer.Name = "PanelProgressbarContainer"
        Me.PanelProgressbarContainer.Size = New System.Drawing.Size(381, 11)
        Me.PanelProgressbarContainer.TabIndex = 1
        '
        'PanelProgressbar
        '
        Me.PanelProgressbar.Appearance.BackColor = System.Drawing.Color.IndianRed
        Me.PanelProgressbar.Appearance.Options.UseBackColor = True
        Me.PanelProgressbar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelProgressbar.Location = New System.Drawing.Point(2, 2)
        Me.PanelProgressbar.Name = "PanelProgressbar"
        Me.PanelProgressbar.Size = New System.Drawing.Size(10, 7)
        Me.PanelProgressbar.TabIndex = 0
        '
        'lblConnection
        '
        Me.lblConnection.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnection.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblConnection.Appearance.Options.UseFont = True
        Me.lblConnection.Appearance.Options.UseForeColor = True
        Me.lblConnection.Location = New System.Drawing.Point(58, 38)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(171, 19)
        Me.lblConnection.TabIndex = 0
        Me.lblConnection.Text = "Establishing Connection.."
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Appearance.Options.UseFont = True
        Me.Label1.Location = New System.Drawing.Point(58, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Checking Connection preferences.."
        '
        'tmrProgressbar
        '
        Me.tmrProgressbar.Interval = 250
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(12, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(47, 61)
        Me.PictureEdit1.TabIndex = 107
        '
        'cmdExit
        '
        Me.cmdExit.ImageOptions.Image = CType(resources.GetObject("cmdExit.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(13, 89)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(98, 26)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "&Close"
        Me.cmdExit.Visible = False
        '
        'frmCheckConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 139)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCheckConnection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Connection"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PanelProgressbarContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProgressbarContainer.ResumeLayout(False)
        CType(Me.PanelProgressbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelProgressbarContainer As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelProgressbar As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblConnection As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tmrProgressbar As System.Windows.Forms.Timer
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
