<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpenandViewDocuments
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpenandViewDocuments))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItemPrevious = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemNext = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemDownload = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemOpenDocument = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItemTransactionNo = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItemTotalAmount = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem5 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItemNetBalance = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lstDocuments = New DevExpress.XtraEditors.ListBoxControl()
        Me.DocumentListView = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.RibbonControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainerControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainerControl1.SuspendLayout
        CType(Me.lstDocuments,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl1.SuspendLayout
        Me.SuspendLayout
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItemPrevious, Me.BarButtonItemNext, Me.BarButtonItemDownload, Me.BarButtonItemOpenDocument, Me.BarStaticItem1, Me.BarStaticItemTransactionNo, Me.BarStaticItem3, Me.BarStaticItemTotalAmount, Me.BarStaticItem5, Me.BarStaticItemNetBalance})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 11
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.RibbonControl1.Size = New System.Drawing.Size(911, 143)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BarButtonItemPrevious
        '
        Me.BarButtonItemPrevious.Caption = "Previous"
        Me.BarButtonItemPrevious.Id = 1
        Me.BarButtonItemPrevious.ImageOptions.Image = CType(resources.GetObject("BarButtonItemPrevious.ImageOptions.Image"),System.Drawing.Image)
        Me.BarButtonItemPrevious.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemPrevious.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.BarButtonItemPrevious.Name = "BarButtonItemPrevious"
        '
        'BarButtonItemNext
        '
        Me.BarButtonItemNext.Caption = "Next"
        Me.BarButtonItemNext.Id = 2
        Me.BarButtonItemNext.ImageOptions.Image = CType(resources.GetObject("BarButtonItemNext.ImageOptions.Image"),System.Drawing.Image)
        Me.BarButtonItemNext.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemNext.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.BarButtonItemNext.Name = "BarButtonItemNext"
        '
        'BarButtonItemDownload
        '
        Me.BarButtonItemDownload.Caption = "Download File"
        Me.BarButtonItemDownload.Id = 3
        Me.BarButtonItemDownload.ImageOptions.Image = CType(resources.GetObject("BarButtonItemDownload.ImageOptions.Image"),System.Drawing.Image)
        Me.BarButtonItemDownload.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemDownload.ImageOptions.LargeImage"),System.Drawing.Image)
        Me.BarButtonItemDownload.Name = "BarButtonItemDownload"
        '
        'BarButtonItemOpenDocument
        '
        Me.BarButtonItemOpenDocument.Caption = "Open File"
        Me.BarButtonItemOpenDocument.Id = 4
        Me.BarButtonItemOpenDocument.ImageOptions.Image = CType(resources.GetObject("BarButtonItemOpenDocument.ImageOptions.Image"),System.Drawing.Image)
        Me.BarButtonItemOpenDocument.Name = "BarButtonItemOpenDocument"
        Me.BarButtonItemOpenDocument.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Parent Key Value:"
        Me.BarStaticItem1.Id = 5
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarStaticItemTransactionNo
        '
        Me.BarStaticItemTransactionNo.Caption = "DEFAULT"
        Me.BarStaticItemTransactionNo.Id = 6
        Me.BarStaticItemTransactionNo.Name = "BarStaticItemTransactionNo"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "Other Keys: "
        Me.BarStaticItem3.Id = 7
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'BarStaticItemTotalAmount
        '
        Me.BarStaticItemTotalAmount.Caption = "DEFAULT"
        Me.BarStaticItemTotalAmount.Id = 8
        Me.BarStaticItemTotalAmount.Name = "BarStaticItemTotalAmount"
        '
        'BarStaticItem5
        '
        Me.BarStaticItem5.Caption = "Other Info: "
        Me.BarStaticItem5.Id = 9
        Me.BarStaticItem5.Name = "BarStaticItem5"
        '
        'BarStaticItemNetBalance
        '
        Me.BarStaticItemNetBalance.Caption = "DEFAULT"
        Me.BarStaticItemNetBalance.Id = 10
        Me.BarStaticItemNetBalance.Name = "BarStaticItemNetBalance"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Operations"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItemOpenDocument)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Open File"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItemDownload)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Download"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItemTransactionNo)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem3)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItemTotalAmount)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem5)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItemNetBalance)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 549)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(911, 31)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(2, 2)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.lstDocuments)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.DocumentListView)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(907, 402)
        Me.SplitContainerControl1.SplitterPosition = 157
        Me.SplitContainerControl1.TabIndex = 1
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Chocolate
        Me.LabelControl3.Appearance.Options.UseBackColor = true
        Me.LabelControl3.Appearance.Options.UseFont = true
        Me.LabelControl3.Appearance.Options.UseForeColor = true
        Me.LabelControl3.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(115, 20)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Documents Types"
        '
        'lstDocuments
        '
        Me.lstDocuments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lstDocuments.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lstDocuments.Appearance.Options.UseFont = true
        Me.lstDocuments.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstDocuments.Location = New System.Drawing.Point(1, 28)
        Me.lstDocuments.Name = "lstDocuments"
        Me.lstDocuments.Size = New System.Drawing.Size(156, 373)
        Me.lstDocuments.TabIndex = 0
        '
        'DocumentListView
        '
        Me.DocumentListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentListView.LargeImageList = Me.ImageList1
        Me.DocumentListView.Location = New System.Drawing.Point(0, 0)
        Me.DocumentListView.Name = "DocumentListView"
        Me.DocumentListView.Size = New System.Drawing.Size(745, 402)
        Me.DocumentListView.SmallImageList = Me.ImageList1
        Me.DocumentListView.TabIndex = 0
        Me.DocumentListView.UseCompatibleStateImageBehavior = false
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "word icon.png")
        Me.ImageList1.Images.SetKeyName(1, "adobe-pdf-logo.jpg")
        Me.ImageList1.Images.SetKeyName(2, "excel logo.jpg")
        Me.ImageList1.Images.SetKeyName(3, "thumbnail.png")
        Me.ImageList1.Images.SetKeyName(4, "konqsidebar_mediaplayer-2.png")
        Me.ImageList1.Images.SetKeyName(5, "media-cdrom-audio.png")
        Me.ImageList1.Images.SetKeyName(6, "applications-other.png")
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SplitContainerControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 143)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(911, 406)
        Me.PanelControl1.TabIndex = 4
        '
        'frmOpenandViewDocuments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 580)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "frmOpenandViewDocuments"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Files Viewer"
        CType(Me.RibbonControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SplitContainerControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainerControl1.ResumeLayout(false)
        CType(Me.lstDocuments,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout


End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lstDocuments As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents BarButtonItemPrevious As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemNext As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemDownload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents DocumentListView As ListView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItemOpenDocument As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItemTransactionNo As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItemTotalAmount As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem5 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItemNetBalance As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
