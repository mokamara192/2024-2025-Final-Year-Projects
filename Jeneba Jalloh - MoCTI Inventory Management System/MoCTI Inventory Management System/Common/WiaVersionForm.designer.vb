<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WiaVersionForm
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
        Me._btnOk = New System.Windows.Forms.Button()
        Me._lbWiaVersions = New System.Windows.Forms.ListBox()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.SuspendLayout
        '
        '_btnCancel
        '
        Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnCancel.ForeColor = System.Drawing.Color.Black
        Me._btnCancel.Location = New System.Drawing.Point(255, 113)
        Me._btnCancel.Name = "_btnCancel"
        Me._btnCancel.Size = New System.Drawing.Size(75, 27)
        Me._btnCancel.TabIndex = 5
        Me._btnCancel.Text = "&Cancel"
        Me._btnCancel.UseVisualStyleBackColor = true
        '
        '_btnOk
        '
        Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me._btnOk.ForeColor = System.Drawing.Color.Black
        Me._btnOk.Location = New System.Drawing.Point(174, 113)
        Me._btnOk.Name = "_btnOk"
        Me._btnOk.Size = New System.Drawing.Size(75, 27)
        Me._btnOk.TabIndex = 4
        Me._btnOk.Text = "OK"
        Me._btnOk.UseVisualStyleBackColor = true
        '
        '_lbWiaVersions
        '
        Me._lbWiaVersions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me._lbWiaVersions.FormattingEnabled = true
        Me._lbWiaVersions.Location = New System.Drawing.Point(12, 12)
        Me._lbWiaVersions.Name = "_lbWiaVersions"
        Me._lbWiaVersions.Size = New System.Drawing.Size(318, 95)
        Me._lbWiaVersions.TabIndex = 3
        '
        'WiaVersionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 145)
        Me.Controls.Add(Me._btnCancel)
        Me.Controls.Add(Me._btnOk)
        Me.Controls.Add(Me._lbWiaVersions)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "WiaVersionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wia Version"
        Me.ResumeLayout(false)

End Sub

    Private WithEvents _btnCancel As Button
    Private WithEvents _btnOk As Button
    Private WithEvents _lbWiaVersions As ListBox
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
End Class
