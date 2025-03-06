<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupportedFormatsForm
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
        Me._btnCLose = New System.Windows.Forms.Button()
        Me._lvFormats = New System.Windows.Forms.ListView()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.SuspendLayout
        '
        '_btnCLose
        '
        Me._btnCLose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnCLose.ForeColor = System.Drawing.Color.Black
        Me._btnCLose.Location = New System.Drawing.Point(341, 196)
        Me._btnCLose.Name = "_btnCLose"
        Me._btnCLose.Size = New System.Drawing.Size(96, 27)
        Me._btnCLose.TabIndex = 3
        Me._btnCLose.Text = "&Close"
        Me._btnCLose.UseVisualStyleBackColor = true
        '
        '_lvFormats
        '
        Me._lvFormats.FullRowSelect = true
        Me._lvFormats.GridLines = true
        Me._lvFormats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me._lvFormats.Location = New System.Drawing.Point(12, 12)
        Me._lvFormats.Name = "_lvFormats"
        Me._lvFormats.Size = New System.Drawing.Size(425, 178)
        Me._lvFormats.TabIndex = 2
        Me._lvFormats.UseCompatibleStateImageBehavior = false
        Me._lvFormats.View = System.Windows.Forms.View.Details
        '
        'SupportedFormatsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 229)
        Me.Controls.Add(Me._btnCLose)
        Me.Controls.Add(Me._lvFormats)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "SupportedFormatsForm"
        Me.Text = "Supported Formats"
        Me.ResumeLayout(false)

End Sub

    Private WithEvents _btnCLose As Button
    Private WithEvents _lvFormats As ListView
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
End Class
