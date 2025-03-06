<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgressForm
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
        Me._btnCancel = New System.Windows.Forms.Button()
        Me._progress = New System.Windows.Forms.ProgressBar()
        Me._lblInformation = New System.Windows.Forms.Label()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        '_btnCancel
        '
        Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnCancel.ForeColor = System.Drawing.Color.Black
        Me._btnCancel.Location = New System.Drawing.Point(293, 138)
        Me._btnCancel.Name = "_btnCancel"
        Me._btnCancel.Size = New System.Drawing.Size(113, 26)
        Me._btnCancel.TabIndex = 5
        Me._btnCancel.Text = "&Cancel"
        Me._btnCancel.UseVisualStyleBackColor = true
        '
        '_progress
        '
        Me._progress.Location = New System.Drawing.Point(12, 110)
        Me._progress.Name = "_progress"
        Me._progress.Size = New System.Drawing.Size(394, 20)
        Me._progress.TabIndex = 4
        '
        '_lblInformation
        '
        Me._lblInformation.ForeColor = System.Drawing.Color.White
        Me._lblInformation.Location = New System.Drawing.Point(15, 36)
        Me._lblInformation.Name = "_lblInformation"
        Me._lblInformation.Size = New System.Drawing.Size(311, 67)
        Me._lblInformation.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.SandyBrown
        Me.LabelControl1.Appearance.Options.UseFont = true
        Me.LabelControl1.Appearance.Options.UseForeColor = true
        Me.LabelControl1.Location = New System.Drawing.Point(15, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(227, 18)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Document Scan in Progress."
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseFont = true
        Me.LabelControl2.Appearance.Options.UseForeColor = true
        Me.LabelControl2.Location = New System.Drawing.Point(248, 11)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(93, 19)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Please wait..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MoCTIMIS.My.Resources.Resources.scanner_folder_icon_55268
        Me.PictureBox1.Location = New System.Drawing.Point(332, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = false
        '
        'frmProgressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 173)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me._btnCancel)
        Me.Controls.Add(Me._progress)
        Me.Controls.Add(Me._lblInformation)
        Me.DoubleBuffered = true
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmProgressForm"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Scan Progress"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents _btnCancel As Button
    Private WithEvents _progress As ProgressBar
    Private WithEvents _lblInformation As Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As PictureBox
End Class
