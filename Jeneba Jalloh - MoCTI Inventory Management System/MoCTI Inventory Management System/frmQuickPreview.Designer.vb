<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuickPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuickPreview))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelBody = New DevExpress.XtraEditors.PanelControl()
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFilter = New DevExpress.XtraEditors.TextEdit()
        Me.lstFields = New System.Windows.Forms.ListBox()
        Me.cmdAccept = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTableName = New DevExpress.XtraEditors.LabelControl()
        Me.PreviewDataGridView = New DevExpress.XtraGrid.GridControl()
        Me.PanelHeader = New DevExpress.XtraEditors.PanelControl()
        Me.lblQuickPreviewTitle = New DevExpress.XtraEditors.LabelControl()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAddNew = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelBody.SuspendLayout()
        CType(Me.PreviewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBody
        '
         Me.PanelBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBody.Controls.Add(Me.cmdAddNew)
        Me.PanelBody.Controls.Add(Me.cmdRefresh)
        Me.PanelBody.Controls.Add(Me.cmdSearch)
        Me.PanelBody.Controls.Add(Me.Label3)
        Me.PanelBody.Controls.Add(Me.Label2)
        Me.PanelBody.Controls.Add(Me.Label1)
        Me.PanelBody.Controls.Add(Me.txtFilter)
        Me.PanelBody.Controls.Add(Me.lstFields)
        Me.PanelBody.Controls.Add(Me.cmdAccept)
        Me.PanelBody.Controls.Add(Me.Label4)
        Me.PanelBody.Controls.Add(Me.lblTableName)
        Me.PanelBody.Controls.Add(Me.PreviewDataGridView)
        Me.PanelBody.Controls.Add(Me.PanelHeader)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(0, 0)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(690, 450)
        Me.PanelBody.TabIndex = 0
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(593, 186)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(84, 25)
        Me.cmdRefresh.TabIndex = 9
        Me.cmdRefresh.Text = "Refresh"
        '
        'cmdSearch
        '
        Me.cmdSearch.Enabled = False
        Me.cmdSearch.Location = New System.Drawing.Point(194, 119)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(155, 26)
        Me.cmdSearch.TabIndex = 8
        Me.cmdSearch.Text = "&Search"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(383, 423)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(294, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "The table above shows the result of the search query."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(191, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Filter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Fields"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.PreviewDataGridView
        Me.GridView1.Name = "GridView1"
        '
        'txtFilter
        '
        Me.txtFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.Location = New System.Drawing.Point(194, 89)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(155, 22)
        Me.txtFilter.TabIndex = 7
        '
        'lstFields
        '
        Me.lstFields.FormattingEnabled = True
        Me.lstFields.Location = New System.Drawing.Point(11, 89)
        Me.lstFields.Name = "lstFields"
        Me.lstFields.Size = New System.Drawing.Size(175, 121)
        Me.lstFields.TabIndex = 6
        '
        'cmdAccept
        '
        Me.cmdAccept.Location = New System.Drawing.Point(9, 418)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(80, 26)
        Me.cmdAccept.TabIndex = 5
        Me.cmdAccept.Text = "&OK"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(397, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 123)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "To Search for a particular Record, please click on any of the search fields you wish to use as a base for the Search and type in the Filter (eg. The Name of the Person) and Click Search. Note: You can select more than one field, just select the first field and enter the filter afterwhich you can select another field and do the same."
        '
        'lblTableName
        '
        Me.lblTableName.AutoSize = True
        Me.lblTableName.BackColor = System.Drawing.Color.Transparent
        Me.lblTableName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTableName.Location = New System.Drawing.Point(9, 32)
        Me.lblTableName.Name = "lblTableName"
        Me.lblTableName.Size = New System.Drawing.Size(95, 21)
        Me.lblTableName.TabIndex = 1
        Me.lblTableName.Text = "Quick Preview"
        '
        'PreviewDataGridView
        '
        Me.PreviewDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PreviewDataGridView.Location = New System.Drawing.Point(10, 217)
        Me.PreviewDataGridView.Name = "PreviewDataGridView"
        Me.PreviewDataGridView.Size = New System.Drawing.Size(667, 196)
        Me.PreviewDataGridView.TabIndex = 4
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelHeader.Controls.Add(Me.lblQuickPreviewTitle)
        Me.PanelHeader.Controls.Add(Me.cmdClose)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(688, 25)
        Me.PanelHeader.TabIndex = 3
        '
        'lblQuickPreviewTitle
        '
        Me.lblQuickPreviewTitle.AutoSize = True
        Me.lblQuickPreviewTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblQuickPreviewTitle.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuickPreviewTitle.ForeColor = System.Drawing.Color.White
        Me.lblQuickPreviewTitle.Location = New System.Drawing.Point(6, 4)
        Me.lblQuickPreviewTitle.Name = "lblQuickPreviewTitle"
        Me.lblQuickPreviewTitle.Size = New System.Drawing.Size(83, 17)
        Me.lblQuickPreviewTitle.TabIndex = 1
        Me.lblQuickPreviewTitle.Text = "Data Preview"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Location = New System.Drawing.Point(660, 1)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(25, 22)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "X"
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Location = New System.Drawing.Point(469, 186)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(118, 25)
        Me.cmdAddNew.TabIndex = 10
        Me.cmdAddNew.Text = "Verify / &Add New"
        '
        'frmQuickPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 450)
        Me.Controls.Add(Me.PanelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQuickPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmQuickPreview"
        Me.PanelBody.ResumeLayout(False)
        Me.PanelBody.PerformLayout()
        CType(Me.PreviewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelBody As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelHeader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblQuickPreviewTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PreviewDataGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents lblTableName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAccept As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lstFields As System.Windows.Forms.ListBox
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFilter As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAddNew As DevExpress.XtraEditors.SimpleButton
End Class
