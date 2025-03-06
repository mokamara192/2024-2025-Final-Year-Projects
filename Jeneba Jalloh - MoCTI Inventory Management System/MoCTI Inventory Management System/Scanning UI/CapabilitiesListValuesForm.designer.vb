<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapabilitiesListValuesForm
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
        Me._lbValues = New System.Windows.Forms.ListBox()
        Me._lblValues = New System.Windows.Forms.Label()
        Me._btnClose = New System.Windows.Forms.Button()
        Me._tbPropertyName = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        '_lbValues
        '
        Me._lbValues.FormattingEnabled = true
        Me._lbValues.Location = New System.Drawing.Point(14, 63)
        Me._lbValues.Name = "_lbValues"
        Me._lbValues.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me._lbValues.Size = New System.Drawing.Size(323, 121)
        Me._lbValues.TabIndex = 8
        '
        '_lblValues
        '
        Me._lblValues.AutoSize = true
        Me._lblValues.Location = New System.Drawing.Point(14, 47)
        Me._lblValues.Name = "_lblValues"
        Me._lblValues.Size = New System.Drawing.Size(58, 13)
        Me._lblValues.TabIndex = 7
        Me._lblValues.Text = "List Values"
        '
        '_btnClose
        '
        Me._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnClose.Location = New System.Drawing.Point(247, 193)
        Me._btnClose.Name = "_btnClose"
        Me._btnClose.Size = New System.Drawing.Size(91, 26)
        Me._btnClose.TabIndex = 9
        Me._btnClose.Text = "&Close"
        Me._btnClose.UseVisualStyleBackColor = true
        '
        '_tbPropertyName
        '
        Me._tbPropertyName.Location = New System.Drawing.Point(120, 14)
        Me._tbPropertyName.Name = "_tbPropertyName"
        Me._tbPropertyName.ReadOnly = true
        Me._tbPropertyName.Size = New System.Drawing.Size(217, 20)
        Me._tbPropertyName.TabIndex = 6
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(14, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(77, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Property Name"
        '
        'CapabilitiesListValuesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 229)
        Me.Controls.Add(Me._lbValues)
        Me.Controls.Add(Me._lblValues)
        Me.Controls.Add(Me._btnClose)
        Me.Controls.Add(Me._tbPropertyName)
        Me.Controls.Add(Me.label1)
        Me.Name = "CapabilitiesListValuesForm"
        Me.Text = "CapabilitiesListValuesForm"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents _lbValues As ListBox
    Private WithEvents _lblValues As Label
    Private WithEvents _btnClose As Button
    Private WithEvents _tbPropertyName As TextBox
    Private WithEvents label1 As Label
End Class
