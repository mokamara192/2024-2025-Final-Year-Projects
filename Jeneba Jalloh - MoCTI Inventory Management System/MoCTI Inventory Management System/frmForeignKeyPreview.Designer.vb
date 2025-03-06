<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForeignKeyPreview
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
        Me.PanelBody = New DevExpress.XtraEditors.PanelControl()
        Me.cmdClosePanelSelector = New DevExpress.XtraEditors.SimpleButton()
        Me.lblExportStatus = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.SelectorComboBox = New System.Windows.Forms.ComboBox()
        Me.cmdAccept = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBody
        '
        Me.PanelBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBody.Controls.Add(Me.cmdAccept)
        Me.PanelBody.Controls.Add(Me.SelectorComboBox)
        Me.PanelBody.Controls.Add(Me.Label1)
        Me.PanelBody.Controls.Add(Me.lblExportStatus)
        Me.PanelBody.Controls.Add(Me.cmdClosePanelSelector)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(0, 0)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(277, 289)
        Me.PanelBody.TabIndex = 0
        '
        'cmdClosePanelSelector
        '
        Me.cmdClosePanelSelector.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClosePanelSelector.Location = New System.Drawing.Point(250, 0)
        Me.cmdClosePanelSelector.Name = "cmdClosePanelSelector"
        Me.cmdClosePanelSelector.Size = New System.Drawing.Size(25, 22)
        Me.cmdClosePanelSelector.TabIndex = 2
        Me.cmdClosePanelSelector.TabStop = False
        Me.cmdClosePanelSelector.Text = "X"
        '
        'lblExportStatus
        '
        Me.lblExportStatus.AutoSize = True
        Me.lblExportStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExportStatus.Location = New System.Drawing.Point(5, 27)
        Me.lblExportStatus.Name = "lblExportStatus"
        Me.lblExportStatus.Size = New System.Drawing.Size(221, 15)
        Me.lblExportStatus.TabIndex = 58
        Me.lblExportStatus.Text = "Please select an item from the list below."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 21)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Value Selector"
        '
        'SelectorComboBox
        '
        Me.SelectorComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SelectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.SelectorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectorComboBox.FormattingEnabled = True
        Me.SelectorComboBox.Location = New System.Drawing.Point(5, 50)
        Me.SelectorComboBox.Name = "SelectorComboBox"
        Me.SelectorComboBox.Size = New System.Drawing.Size(266, 203)
        Me.SelectorComboBox.TabIndex = 59
        '
        'cmdAccept
        '
        Me.cmdAccept.Location = New System.Drawing.Point(5, 253)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(87, 27)
        Me.cmdAccept.TabIndex = 60
        Me.cmdAccept.Text = "&OK"
        '
        'frmForeignKeyPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 289)
        Me.Controls.Add(Me.PanelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmForeignKeyPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ForeignKeyPreview"
        Me.PanelBody.ResumeLayout(False)
        Me.PanelBody.PerformLayout()
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents PanelBody As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdClosePanelSelector As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblExportStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SelectorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAccept As DevExpress.XtraEditors.SimpleButton
End Class
