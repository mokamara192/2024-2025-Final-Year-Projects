<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapabilitiesRangeValuesForm
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
        Me._tbIncrementValue = New System.Windows.Forms.TextBox()
        Me._tbNominalValue = New System.Windows.Forms.TextBox()
        Me._tbMaximumValue = New System.Windows.Forms.TextBox()
        Me._tbMinimumValue = New System.Windows.Forms.TextBox()
        Me._tbPropertyName = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me._btnClose = New System.Windows.Forms.Button()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.SuspendLayout
        '
        '_tbIncrementValue
        '
        Me._tbIncrementValue.Location = New System.Drawing.Point(114, 116)
        Me._tbIncrementValue.Name = "_tbIncrementValue"
        Me._tbIncrementValue.ReadOnly = true
        Me._tbIncrementValue.Size = New System.Drawing.Size(217, 21)
        Me._tbIncrementValue.TabIndex = 20
        '
        '_tbNominalValue
        '
        Me._tbNominalValue.Location = New System.Drawing.Point(114, 90)
        Me._tbNominalValue.Name = "_tbNominalValue"
        Me._tbNominalValue.ReadOnly = true
        Me._tbNominalValue.Size = New System.Drawing.Size(217, 21)
        Me._tbNominalValue.TabIndex = 18
        '
        '_tbMaximumValue
        '
        Me._tbMaximumValue.Location = New System.Drawing.Point(114, 64)
        Me._tbMaximumValue.Name = "_tbMaximumValue"
        Me._tbMaximumValue.ReadOnly = true
        Me._tbMaximumValue.Size = New System.Drawing.Size(217, 21)
        Me._tbMaximumValue.TabIndex = 16
        '
        '_tbMinimumValue
        '
        Me._tbMinimumValue.Location = New System.Drawing.Point(114, 38)
        Me._tbMinimumValue.Name = "_tbMinimumValue"
        Me._tbMinimumValue.ReadOnly = true
        Me._tbMinimumValue.Size = New System.Drawing.Size(217, 21)
        Me._tbMinimumValue.TabIndex = 14
        '
        '_tbPropertyName
        '
        Me._tbPropertyName.Location = New System.Drawing.Point(114, 12)
        Me._tbPropertyName.Name = "_tbPropertyName"
        Me._tbPropertyName.ReadOnly = true
        Me._tbPropertyName.Size = New System.Drawing.Size(217, 21)
        Me._tbPropertyName.TabIndex = 12
        '
        'label5
        '
        Me.label5.AutoSize = true
        Me.label5.Location = New System.Drawing.Point(8, 119)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(85, 13)
        Me.label5.TabIndex = 19
        Me.label5.Text = "Increment Value"
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(8, 93)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(73, 13)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Nominal Value"
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.Location = New System.Drawing.Point(8, 67)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(80, 13)
        Me.label3.TabIndex = 15
        Me.label3.Text = "Maximum Value"
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(8, 41)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(76, 13)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Minimum Value"
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(8, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(79, 13)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Property Name"
        '
        '_btnClose
        '
        Me._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnClose.Location = New System.Drawing.Point(256, 151)
        Me._btnClose.Name = "_btnClose"
        Me._btnClose.Size = New System.Drawing.Size(75, 23)
        Me._btnClose.TabIndex = 21
        Me._btnClose.Text = "&Close"
        Me._btnClose.UseVisualStyleBackColor = true
        '
        'CapabilitiesRangeValuesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 183)
        Me.Controls.Add(Me._tbIncrementValue)
        Me.Controls.Add(Me._tbNominalValue)
        Me.Controls.Add(Me._tbMaximumValue)
        Me.Controls.Add(Me._tbMinimumValue)
        Me.Controls.Add(Me._tbPropertyName)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me._btnClose)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "CapabilitiesRangeValuesForm"
        Me.Text = "Capabilities Range Values"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents _tbIncrementValue As TextBox
    Private WithEvents _tbNominalValue As TextBox
    Private WithEvents _tbMaximumValue As TextBox
    Private WithEvents _tbMinimumValue As TextBox
    Private WithEvents _tbPropertyName As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents _btnClose As Button
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
End Class
