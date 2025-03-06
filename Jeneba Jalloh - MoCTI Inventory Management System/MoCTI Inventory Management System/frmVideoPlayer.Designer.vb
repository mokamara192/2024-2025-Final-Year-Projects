<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVideoPlayer
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVideoPlayer))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FileNameTextBox = New System.Windows.Forms.Label()
        Me.RegDateTextBox = New System.Windows.Forms.Label()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(2, 26)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(861, 535)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "File Name:"
        '
        'FileNameTextBox
        '
        Me.FileNameTextBox.AutoSize = True
        Me.FileNameTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileNameTextBox.Location = New System.Drawing.Point(61, 5)
        Me.FileNameTextBox.Name = "FileNameTextBox"
        Me.FileNameTextBox.Size = New System.Drawing.Size(170, 16)
        Me.FileNameTextBox.TabIndex = 1
        Me.FileNameTextBox.Text = "Looking at the Start.mp4"
        '
        'RegDateTextBox
        '
        Me.RegDateTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegDateTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegDateTextBox.Location = New System.Drawing.Point(653, 5)
        Me.RegDateTextBox.Name = "RegDateTextBox"
        Me.RegDateTextBox.Size = New System.Drawing.Size(207, 18)
        Me.RegDateTextBox.TabIndex = 1
        Me.RegDateTextBox.Text = "Date: 11/02/2017"
        Me.RegDateTextBox.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmVideoPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 562)
        Me.Controls.Add(Me.RegDateTextBox)
        Me.Controls.Add(Me.FileNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Name = "frmVideoPlayer"
        Me.Text = "Video Player"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label1 As Label
    Friend WithEvents FileNameTextBox As Label
    Friend WithEvents RegDateTextBox As Label
End Class
