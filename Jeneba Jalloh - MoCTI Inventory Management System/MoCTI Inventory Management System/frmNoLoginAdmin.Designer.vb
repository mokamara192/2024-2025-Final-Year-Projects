<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoLoginAdmin
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
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel2 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel3 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdNo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdYes = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.cmdClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 19)
        Me.Panel1.TabIndex = 1
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(414, -3)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(19, 26)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Administrative Account"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(435, 191)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cmdNo)
        Me.Panel3.Controls.Add(Me.cmdYes)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(435, 191)
        Me.Panel3.TabIndex = 2
        '
        'cmdNo
        '
        Me.cmdNo.Location = New System.Drawing.Point(226, 120)
        Me.cmdNo.Name = "cmdNo"
        Me.cmdNo.Size = New System.Drawing.Size(82, 28)
        Me.cmdNo.TabIndex = 2
        Me.cmdNo.Text = "&No"
        '
        'cmdYes
        '
        Me.cmdYes.Location = New System.Drawing.Point(135, 120)
        Me.cmdYes.Name = "cmdYes"
        Me.cmdYes.Size = New System.Drawing.Size(82, 28)
        Me.cmdYes.TabIndex = 2
        Me.cmdYes.Text = "&Yes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(47, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(361, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Would you like to create an Administrative User Account?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(83, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No Administrative User Account"
        '
        'frmNoLoginAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 210)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNoLoginAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "No Login Admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdNo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdYes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
End Class
