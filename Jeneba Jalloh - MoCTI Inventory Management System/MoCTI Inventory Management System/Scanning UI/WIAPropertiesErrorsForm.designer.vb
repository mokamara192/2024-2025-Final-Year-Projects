<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WiaPropertiesErrorsForm
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
        Me._lvErrors = New System.Windows.Forms.ListView()
        Me._btnClear = New System.Windows.Forms.Button()
        Me._btnOk = New System.Windows.Forms.Button()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.SuspendLayout
        '
        '_lvErrors
        '
        Me._lvErrors.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me._lvErrors.FullRowSelect = true
        Me._lvErrors.GridLines = true
        Me._lvErrors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me._lvErrors.Location = New System.Drawing.Point(12, 12)
        Me._lvErrors.Name = "_lvErrors"
        Me._lvErrors.Size = New System.Drawing.Size(599, 370)
        Me._lvErrors.TabIndex = 3
        Me._lvErrors.UseCompatibleStateImageBehavior = false
        Me._lvErrors.View = System.Windows.Forms.View.Details
        '
        '_btnClear
        '
        Me._btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me._btnClear.ForeColor = System.Drawing.Color.Black
        Me._btnClear.Location = New System.Drawing.Point(455, 388)
        Me._btnClear.Name = "_btnClear"
        Me._btnClear.Size = New System.Drawing.Size(75, 26)
        Me._btnClear.TabIndex = 4
        Me._btnClear.Text = "&Clear"
        Me._btnClear.UseVisualStyleBackColor = true
        '
        '_btnOk
        '
        Me._btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnOk.ForeColor = System.Drawing.Color.Black
        Me._btnOk.Location = New System.Drawing.Point(536, 388)
        Me._btnOk.Name = "_btnOk"
        Me._btnOk.Size = New System.Drawing.Size(75, 26)
        Me._btnOk.TabIndex = 5
        Me._btnOk.Text = "&OK"
        Me._btnOk.UseVisualStyleBackColor = true
        '
        'WiaPropertiesErrorsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 423)
        Me.Controls.Add(Me._lvErrors)
        Me.Controls.Add(Me._btnClear)
        Me.Controls.Add(Me._btnOk)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "WiaPropertiesErrorsForm"
        Me.Text = "WIA Properties Errors"
        Me.ResumeLayout(false)

End Sub

    Private WithEvents _lvErrors As ListView
    Private WithEvents _btnClear As Button
    Private WithEvents _btnOk As Button
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
End Class
