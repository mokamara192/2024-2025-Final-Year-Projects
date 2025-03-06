<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScanDocumentTypeandQuantity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScanDocumentTypeandQuantity))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DocumentTypeQuanfityGridView = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DocumentTypeCheckBox = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cmdScan = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.DocumentTypeQuanfityGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DocumentTypeCheckBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DocumentTypeQuanfityGridView
        '
        Me.DocumentTypeQuanfityGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.DocumentTypeQuanfityGridView.Location = New System.Drawing.Point(12, 70)
        Me.DocumentTypeQuanfityGridView.MainView = Me.GridView1
        Me.DocumentTypeQuanfityGridView.Name = "DocumentTypeQuanfityGridView"
        Me.DocumentTypeQuanfityGridView.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.DocumentTypeCheckBox})
        Me.DocumentTypeQuanfityGridView.Size = New System.Drawing.Size(456, 265)
        Me.DocumentTypeQuanfityGridView.TabIndex = 1
        Me.DocumentTypeQuanfityGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.DocumentTypeQuanfityGridView
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = false
        '
        'DocumentTypeCheckBox
        '
        Me.DocumentTypeCheckBox.AutoHeight = false
        Me.DocumentTypeCheckBox.Name = "DocumentTypeCheckBox"
        '
        'cmdScan
        '
        Me.cmdScan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmdScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdScan.ImageOptions.Image = CType(resources.GetObject("cmdScan.ImageOptions.Image"),System.Drawing.Image)
        Me.cmdScan.Location = New System.Drawing.Point(291, 341)
        Me.cmdScan.Name = "cmdScan"
        Me.cmdScan.Size = New System.Drawing.Size(177, 28)
        Me.cmdScan.TabIndex = 2
        Me.cmdScan.Text = "Scan Using Multi-Page Mode"
        Me.cmdScan.ToolTip = "Click here to add a new document as an update to the currently selected file"
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl20.Appearance.ForeColor = System.Drawing.Color.SandyBrown
        Me.LabelControl20.Appearance.Options.UseBackColor = true
        Me.LabelControl20.Appearance.Options.UseFont = true
        Me.LabelControl20.Appearance.Options.UseForeColor = true
        Me.LabelControl20.Location = New System.Drawing.Point(12, 10)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(241, 20)
        Me.LabelControl20.TabIndex = 54
        Me.LabelControl20.Text = "Specify Document Type and Quantity"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl13.Appearance.Options.UseFont = true
        Me.LabelControl13.Appearance.Options.UseTextOptions = true
        Me.LabelControl13.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl13.Location = New System.Drawing.Point(12, 30)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(455, 36)
        Me.LabelControl13.TabIndex = 57
        Me.LabelControl13.Text = "Click on the Checkbox to Select Type and Speficy the Quantity of pages to scan. F"& _ 
    "astArchieve will assign the pages with respect to the specifications made here."
        '
        'frmScanDocumentTypeandQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 379)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.DocumentTypeQuanfityGridView)
        Me.Controls.Add(Me.cmdScan)
        Me.Controls.Add(Me.LabelControl20)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmScanDocumentTypeandQuantity"
        Me.Text = "Document Type and Quantity"
        CType(Me.DocumentTypeQuanfityGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DocumentTypeCheckBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DocumentTypeQuanfityGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdScan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DocumentTypeCheckBox As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
