<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WiaDeviceItemsForm
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
        Me._tvWiaDeviceItems = New System.Windows.Forms.TreeView()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.SuspendLayout
        '
        '_btnCancel
        '
        Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnCancel.ForeColor = System.Drawing.Color.Black
        Me._btnCancel.Location = New System.Drawing.Point(134, 231)
        Me._btnCancel.Name = "_btnCancel"
        Me._btnCancel.Size = New System.Drawing.Size(75, 27)
        Me._btnCancel.TabIndex = 5
        Me._btnCancel.Text = "&Cancel"
        Me._btnCancel.UseVisualStyleBackColor = true
        '
        '_btnOk
        '
        Me._btnOk.ForeColor = System.Drawing.Color.Black
        Me._btnOk.Location = New System.Drawing.Point(53, 231)
        Me._btnOk.Name = "_btnOk"
        Me._btnOk.Size = New System.Drawing.Size(75, 27)
        Me._btnOk.TabIndex = 4
        Me._btnOk.Text = "&OK"
        Me._btnOk.UseVisualStyleBackColor = true
        '
        '_tvWiaDeviceItems
        '
        Me._tvWiaDeviceItems.Location = New System.Drawing.Point(12, 12)
        Me._tvWiaDeviceItems.Name = "_tvWiaDeviceItems"
        Me._tvWiaDeviceItems.Size = New System.Drawing.Size(239, 213)
        Me._tvWiaDeviceItems.TabIndex = 3
        '
        'WiaDeviceItemsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 267)
        Me.Controls.Add(Me._btnCancel)
        Me.Controls.Add(Me._btnOk)
        Me.Controls.Add(Me._tvWiaDeviceItems)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "WiaDeviceItemsForm"
        Me.Text = "WIADeviceItemsForm"
        Me.ResumeLayout(false)

End Sub

    Private WithEvents _btnCancel As Button
    Private WithEvents _btnOk As Button
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents _tvWiaDeviceItems As TreeView
End Class
