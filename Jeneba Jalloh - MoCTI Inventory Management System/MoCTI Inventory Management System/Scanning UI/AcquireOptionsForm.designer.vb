<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AcquireOptionsForm
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
        Me._gbTransferMode = New System.Windows.Forms.GroupBox()
        Me._rdMemoryMode = New System.Windows.Forms.RadioButton()
        Me._rdFileMode = New System.Windows.Forms.RadioButton()
        Me._gbFileModeOptions = New System.Windows.Forms.GroupBox()
        Me._cbAppendToFile = New System.Windows.Forms.CheckBox()
        Me._cbOverwriteExisting = New System.Windows.Forms.CheckBox()
        Me._cbSaveToOneFile = New System.Windows.Forms.CheckBox()
        Me._btnBrowse = New System.Windows.Forms.Button()
        Me._tbFileName = New System.Windows.Forms.TextBox()
        Me._lblFileName = New System.Windows.Forms.Label()
        Me._gbTransferBufferOptions = New System.Windows.Forms.GroupBox()
        Me._numMemoryBufferSize = New System.Windows.Forms.NumericUpDown()
        Me._cbEnableDoubleBuffer = New System.Windows.Forms.CheckBox()
        Me._lblMemoryBufferSize = New System.Windows.Forms.Label()
        Me._btnOk = New System.Windows.Forms.Button()
        Me._btnCancel = New System.Windows.Forms.Button()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me._gbTransferMode.SuspendLayout
        Me._gbFileModeOptions.SuspendLayout
        Me._gbTransferBufferOptions.SuspendLayout
        CType(Me._numMemoryBufferSize,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        '_gbTransferMode
        '
        Me._gbTransferMode.Controls.Add(Me._rdMemoryMode)
        Me._gbTransferMode.Controls.Add(Me._rdFileMode)
        Me._gbTransferMode.ForeColor = System.Drawing.Color.White
        Me._gbTransferMode.Location = New System.Drawing.Point(12, 12)
        Me._gbTransferMode.Name = "_gbTransferMode"
        Me._gbTransferMode.Size = New System.Drawing.Size(252, 89)
        Me._gbTransferMode.TabIndex = 11
        Me._gbTransferMode.TabStop = false
        Me._gbTransferMode.Text = "Transfer Mode"
        '
        '_rdMemoryMode
        '
        Me._rdMemoryMode.AutoSize = true
        Me._rdMemoryMode.Location = New System.Drawing.Point(9, 38)
        Me._rdMemoryMode.Name = "_rdMemoryMode"
        Me._rdMemoryMode.Size = New System.Drawing.Size(92, 17)
        Me._rdMemoryMode.TabIndex = 0
        Me._rdMemoryMode.TabStop = true
        Me._rdMemoryMode.Text = "Memory Mode"
        Me._rdMemoryMode.UseVisualStyleBackColor = true
        '
        '_rdFileMode
        '
        Me._rdFileMode.AutoSize = true
        Me._rdFileMode.Location = New System.Drawing.Point(139, 38)
        Me._rdFileMode.Name = "_rdFileMode"
        Me._rdFileMode.Size = New System.Drawing.Size(70, 17)
        Me._rdFileMode.TabIndex = 1
        Me._rdFileMode.TabStop = true
        Me._rdFileMode.Text = "File Mode"
        Me._rdFileMode.UseVisualStyleBackColor = true
        '
        '_gbFileModeOptions
        '
        Me._gbFileModeOptions.Controls.Add(Me._cbAppendToFile)
        Me._gbFileModeOptions.Controls.Add(Me._cbOverwriteExisting)
        Me._gbFileModeOptions.Controls.Add(Me._cbSaveToOneFile)
        Me._gbFileModeOptions.Controls.Add(Me._btnBrowse)
        Me._gbFileModeOptions.Controls.Add(Me._tbFileName)
        Me._gbFileModeOptions.Controls.Add(Me._lblFileName)
        Me._gbFileModeOptions.ForeColor = System.Drawing.Color.White
        Me._gbFileModeOptions.Location = New System.Drawing.Point(12, 107)
        Me._gbFileModeOptions.Name = "_gbFileModeOptions"
        Me._gbFileModeOptions.Size = New System.Drawing.Size(252, 142)
        Me._gbFileModeOptions.TabIndex = 12
        Me._gbFileModeOptions.TabStop = false
        Me._gbFileModeOptions.Text = "File Mode Options"
        '
        '_cbAppendToFile
        '
        Me._cbAppendToFile.AutoSize = true
        Me._cbAppendToFile.Location = New System.Drawing.Point(9, 108)
        Me._cbAppendToFile.Name = "_cbAppendToFile"
        Me._cbAppendToFile.Size = New System.Drawing.Size(97, 17)
        Me._cbAppendToFile.TabIndex = 6
        Me._cbAppendToFile.Text = "Append To File"
        Me._cbAppendToFile.UseVisualStyleBackColor = true
        '
        '_cbOverwriteExisting
        '
        Me._cbOverwriteExisting.AutoSize = true
        Me._cbOverwriteExisting.Location = New System.Drawing.Point(9, 85)
        Me._cbOverwriteExisting.Name = "_cbOverwriteExisting"
        Me._cbOverwriteExisting.Size = New System.Drawing.Size(114, 17)
        Me._cbOverwriteExisting.TabIndex = 5
        Me._cbOverwriteExisting.Text = "Overwrite Existing"
        Me._cbOverwriteExisting.UseVisualStyleBackColor = true
        '
        '_cbSaveToOneFile
        '
        Me._cbSaveToOneFile.AutoSize = true
        Me._cbSaveToOneFile.Location = New System.Drawing.Point(9, 62)
        Me._cbSaveToOneFile.Name = "_cbSaveToOneFile"
        Me._cbSaveToOneFile.Size = New System.Drawing.Size(107, 17)
        Me._cbSaveToOneFile.TabIndex = 4
        Me._cbSaveToOneFile.Text = "Save To One File"
        Me._cbSaveToOneFile.UseVisualStyleBackColor = true
        '
        '_btnBrowse
        '
        Me._btnBrowse.Location = New System.Drawing.Point(217, 23)
        Me._btnBrowse.Name = "_btnBrowse"
        Me._btnBrowse.Size = New System.Drawing.Size(29, 23)
        Me._btnBrowse.TabIndex = 3
        Me._btnBrowse.Text = "&..."
        Me._btnBrowse.UseVisualStyleBackColor = true
        '
        '_tbFileName
        '
        Me._tbFileName.Location = New System.Drawing.Point(66, 25)
        Me._tbFileName.Name = "_tbFileName"
        Me._tbFileName.ReadOnly = true
        Me._tbFileName.Size = New System.Drawing.Size(144, 21)
        Me._tbFileName.TabIndex = 2
        '
        '_lblFileName
        '
        Me._lblFileName.AutoSize = true
        Me._lblFileName.Location = New System.Drawing.Point(6, 28)
        Me._lblFileName.Name = "_lblFileName"
        Me._lblFileName.Size = New System.Drawing.Size(53, 13)
        Me._lblFileName.TabIndex = 0
        Me._lblFileName.Text = "File Name"
        '
        '_gbTransferBufferOptions
        '
        Me._gbTransferBufferOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me._gbTransferBufferOptions.Controls.Add(Me._numMemoryBufferSize)
        Me._gbTransferBufferOptions.Controls.Add(Me._cbEnableDoubleBuffer)
        Me._gbTransferBufferOptions.Controls.Add(Me._lblMemoryBufferSize)
        Me._gbTransferBufferOptions.ForeColor = System.Drawing.Color.White
        Me._gbTransferBufferOptions.Location = New System.Drawing.Point(270, 12)
        Me._gbTransferBufferOptions.Name = "_gbTransferBufferOptions"
        Me._gbTransferBufferOptions.Size = New System.Drawing.Size(241, 89)
        Me._gbTransferBufferOptions.TabIndex = 13
        Me._gbTransferBufferOptions.TabStop = false
        Me._gbTransferBufferOptions.Text = "Transfer Buffer Options"
        '
        '_numMemoryBufferSize
        '
        Me._numMemoryBufferSize.Location = New System.Drawing.Point(145, 24)
        Me._numMemoryBufferSize.Maximum = New Decimal(New Integer() {65535000, 0, 0, 0})
        Me._numMemoryBufferSize.Name = "_numMemoryBufferSize"
        Me._numMemoryBufferSize.Size = New System.Drawing.Size(78, 21)
        Me._numMemoryBufferSize.TabIndex = 11
        '
        '_cbEnableDoubleBuffer
        '
        Me._cbEnableDoubleBuffer.AutoSize = true
        Me._cbEnableDoubleBuffer.Location = New System.Drawing.Point(9, 55)
        Me._cbEnableDoubleBuffer.Name = "_cbEnableDoubleBuffer"
        Me._cbEnableDoubleBuffer.Size = New System.Drawing.Size(127, 17)
        Me._cbEnableDoubleBuffer.TabIndex = 8
        Me._cbEnableDoubleBuffer.Text = "Enable Double Buffer"
        Me._cbEnableDoubleBuffer.UseVisualStyleBackColor = true
        '
        '_lblMemoryBufferSize
        '
        Me._lblMemoryBufferSize.AutoSize = true
        Me._lblMemoryBufferSize.Location = New System.Drawing.Point(6, 26)
        Me._lblMemoryBufferSize.Name = "_lblMemoryBufferSize"
        Me._lblMemoryBufferSize.Size = New System.Drawing.Size(138, 13)
        Me._lblMemoryBufferSize.TabIndex = 0
        Me._lblMemoryBufferSize.Text = "Memory Buffer Size (Bytes)"
        '
        '_btnOk
        '
        Me._btnOk.ForeColor = System.Drawing.Color.Black
        Me._btnOk.Location = New System.Drawing.Point(338, 222)
        Me._btnOk.Name = "_btnOk"
        Me._btnOk.Size = New System.Drawing.Size(80, 28)
        Me._btnOk.TabIndex = 14
        Me._btnOk.Text = "&OK"
        Me._btnOk.UseVisualStyleBackColor = true
        '
        '_btnCancel
        '
        Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnCancel.ForeColor = System.Drawing.Color.Black
        Me._btnCancel.Location = New System.Drawing.Point(424, 222)
        Me._btnCancel.Name = "_btnCancel"
        Me._btnCancel.Size = New System.Drawing.Size(80, 28)
        Me._btnCancel.TabIndex = 15
        Me._btnCancel.Text = "&Cancel"
        Me._btnCancel.UseVisualStyleBackColor = true
        '
        'AcquireOptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 266)
        Me.Controls.Add(Me._gbTransferMode)
        Me.Controls.Add(Me._gbFileModeOptions)
        Me.Controls.Add(Me._gbTransferBufferOptions)
        Me.Controls.Add(Me._btnOk)
        Me.Controls.Add(Me._btnCancel)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.Name = "AcquireOptionsForm"
        Me.Text = "AcquireOptionsForm"
        Me._gbTransferMode.ResumeLayout(false)
        Me._gbTransferMode.PerformLayout
        Me._gbFileModeOptions.ResumeLayout(false)
        Me._gbFileModeOptions.PerformLayout
        Me._gbTransferBufferOptions.ResumeLayout(false)
        Me._gbTransferBufferOptions.PerformLayout
        CType(Me._numMemoryBufferSize,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Private WithEvents _gbTransferMode As GroupBox
    Private WithEvents _rdMemoryMode As RadioButton
    Private WithEvents _rdFileMode As RadioButton
    Private WithEvents _gbFileModeOptions As GroupBox
    Private WithEvents _cbAppendToFile As CheckBox
    Private WithEvents _cbOverwriteExisting As CheckBox
    Private WithEvents _cbSaveToOneFile As CheckBox
    Private WithEvents _btnBrowse As Button
    Private WithEvents _tbFileName As TextBox
    Private WithEvents _lblFileName As Label
    Private WithEvents _gbTransferBufferOptions As GroupBox
    Private WithEvents _numMemoryBufferSize As NumericUpDown
    Private WithEvents _cbEnableDoubleBuffer As CheckBox
    Private WithEvents _lblMemoryBufferSize As Label
    Private WithEvents _btnOk As Button
    Private WithEvents _btnCancel As Button
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
End Class
