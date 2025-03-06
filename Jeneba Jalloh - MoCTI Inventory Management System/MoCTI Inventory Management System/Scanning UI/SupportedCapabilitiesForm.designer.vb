<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupportedCapabilitiesForm
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
        Me._lblCapabilitiesCount = New System.Windows.Forms.Label()
        Me._lvCapabilities = New System.Windows.Forms.ListView()
        Me.label1 = New System.Windows.Forms.Label()
        Me._btnClose = New System.Windows.Forms.Button()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.SuspendLayout
        '
        '_lblCapabilitiesCount
        '
        Me._lblCapabilitiesCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me._lblCapabilitiesCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._lblCapabilitiesCount.ForeColor = System.Drawing.Color.White
        Me._lblCapabilitiesCount.Location = New System.Drawing.Point(133, 391)
        Me._lblCapabilitiesCount.Name = "_lblCapabilitiesCount"
        Me._lblCapabilitiesCount.Size = New System.Drawing.Size(47, 18)
        Me._lblCapabilitiesCount.TabIndex = 7
        Me._lblCapabilitiesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_lvCapabilities
        '
        Me._lvCapabilities.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me._lvCapabilities.FullRowSelect = true
        Me._lvCapabilities.GridLines = true
        Me._lvCapabilities.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me._lvCapabilities.Location = New System.Drawing.Point(12, 12)
        Me._lvCapabilities.MultiSelect = false
        Me._lvCapabilities.Name = "_lvCapabilities"
        Me._lvCapabilities.Size = New System.Drawing.Size(581, 374)
        Me._lvCapabilities.TabIndex = 6
        Me._lvCapabilities.UseCompatibleStateImageBehavior = false
        Me._lvCapabilities.View = System.Windows.Forms.View.Details
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(9, 392)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(121, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "WIA Capabilities Count:"
        '
        '_btnClose
        '
        Me._btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnClose.ForeColor = System.Drawing.Color.Black
        Me._btnClose.Location = New System.Drawing.Point(492, 392)
        Me._btnClose.Name = "_btnClose"
        Me._btnClose.Size = New System.Drawing.Size(101, 27)
        Me._btnClose.TabIndex = 4
        Me._btnClose.Text = "&Close"
        Me._btnClose.UseVisualStyleBackColor = true
        '
        'SupportedCapabilitiesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 427)
        Me.Controls.Add(Me._lblCapabilitiesCount)
        Me.Controls.Add(Me._lvCapabilities)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me._btnClose)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "SupportedCapabilitiesForm"
        Me.Text = "Supported Capabilities"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents _lblCapabilitiesCount As Label
    Private WithEvents _lvCapabilities As ListView
    Private WithEvents label1 As Label
    Private WithEvents _btnClose As Button
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
End Class
