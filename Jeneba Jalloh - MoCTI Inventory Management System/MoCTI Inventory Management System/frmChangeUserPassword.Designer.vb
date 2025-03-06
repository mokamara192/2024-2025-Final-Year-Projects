<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeUserPassword
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
        Me.PanelBody = New DevExpress.XtraEditors.PanelControl()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdChange = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelHeader = New DevExpress.XtraEditors.PanelControl()
        Me.lblProjectName = New DevExpress.XtraEditors.LabelControl()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelBody.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBody
        '
        Me.PanelBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBody.Controls.Add(Me.txtConfirmPassword)
        Me.PanelBody.Controls.Add(Me.txtNewPassword)
        Me.PanelBody.Controls.Add(Me.txtCurrentPassword)
        Me.PanelBody.Controls.Add(Me.Label3)
        Me.PanelBody.Controls.Add(Me.Label2)
        Me.PanelBody.Controls.Add(Me.Label4)
        Me.PanelBody.Controls.Add(Me.Label5)
        Me.PanelBody.Controls.Add(Me.Label1)
        Me.PanelBody.Controls.Add(Me.cmdCancel)
        Me.PanelBody.Controls.Add(Me.cmdChange)
        Me.PanelBody.Controls.Add(Me.PanelHeader)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(0, 0)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(519, 241)
        Me.PanelBody.TabIndex = 0
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(121, 144)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(207, 21)
        Me.txtConfirmPassword.TabIndex = 2
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(121, 109)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(207, 21)
        Me.txtNewPassword.TabIndex = 1
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(121, 76)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPassword.Size = New System.Drawing.Size(207, 21)
        Me.txtCurrentPassword.TabIndex = 0
        Me.txtCurrentPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Confirm Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "New Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Change Password"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(353, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 114)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Change you user password by providing the current password that you are presently" &
    " using. Afterwards provide a new password and confirm it in the confirm textbox " &
    "below it."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Current Password:"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(231, 178)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(97, 28)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(120, 178)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(105, 28)
        Me.cmdChange.TabIndex = 3
        Me.cmdChange.Text = "Change Password"
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelHeader.Controls.Add(Me.lblProjectName)
        Me.PanelHeader.Controls.Add(Me.cmdClose)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(517, 25)
        Me.PanelHeader.TabIndex = 4
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.BackColor = System.Drawing.Color.Transparent
        Me.lblProjectName.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectName.ForeColor = System.Drawing.Color.Black
        Me.lblProjectName.Location = New System.Drawing.Point(6, 4)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(138, 17)
        Me.lblProjectName.TabIndex = 1
        Me.lblProjectName.Text = "Change User Password"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Location = New System.Drawing.Point(491, 1)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(25, 22)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "X"
        '
        'frmChangeUserPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 241)
        Me.Controls.Add(Me.PanelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChangeUserPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change User Password"
        Me.PanelBody.ResumeLayout(False)
        Me.PanelBody.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents PanelBody As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdChange As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelHeader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblProjectName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
End Class
