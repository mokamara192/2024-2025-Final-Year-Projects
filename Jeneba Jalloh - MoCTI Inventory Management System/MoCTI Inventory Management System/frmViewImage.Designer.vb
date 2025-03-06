<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewImage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewImage))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItemName = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItemDescription = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItemRotate = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemFlipVertical = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemFlipHorizontal = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemDownload = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItemZoom = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemRangeTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemRangeTrackBar()
        Me.BarStaticItemZoomLevel = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItemDocumentName = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem5 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItemDocumentDescription = New DevExpress.XtraBars.BarStaticItem()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.ProgressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.ImagePictureBox = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRangeTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ImagePictureBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarStaticItem1, Me.BarStaticItemName, Me.BarStaticItem2, Me.BarStaticItemDescription, Me.BarButtonItemRotate, Me.BarButtonItemFlipVertical, Me.BarButtonItemFlipHorizontal, Me.BarButtonItemDownload, Me.BarEditItemZoom, Me.BarStaticItemZoomLevel, Me.BarButtonItem1})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 12
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemRangeTrackBar1})
        Me.RibbonControl1.Size = New System.Drawing.Size(793, 142)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Name:"
        Me.BarStaticItem1.Id = 1
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarStaticItemName
        '
        Me.BarStaticItemName.Caption = "DEFAULT"
        Me.BarStaticItemName.Id = 2
        Me.BarStaticItemName.Name = "BarStaticItemName"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "Description:"
        Me.BarStaticItem2.Id = 3
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'BarStaticItemDescription
        '
        Me.BarStaticItemDescription.Caption = "DEFAULT"
        Me.BarStaticItemDescription.Id = 4
        Me.BarStaticItemDescription.Name = "BarStaticItemDescription"
        '
        'BarButtonItemRotate
        '
        Me.BarButtonItemRotate.Caption = "Rotate"
        Me.BarButtonItemRotate.Id = 5
        Me.BarButtonItemRotate.ImageOptions.Image = CType(resources.GetObject("BarButtonItemRotate.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemRotate.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemRotate.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemRotate.Name = "BarButtonItemRotate"
        '
        'BarButtonItemFlipVertical
        '
        Me.BarButtonItemFlipVertical.Caption = "Flip Vertical"
        Me.BarButtonItemFlipVertical.Id = 6
        Me.BarButtonItemFlipVertical.ImageOptions.Image = CType(resources.GetObject("BarButtonItemFlipVertical.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemFlipVertical.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemFlipVertical.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemFlipVertical.Name = "BarButtonItemFlipVertical"
        '
        'BarButtonItemFlipHorizontal
        '
        Me.BarButtonItemFlipHorizontal.Caption = "Flip Horizontal"
        Me.BarButtonItemFlipHorizontal.Id = 7
        Me.BarButtonItemFlipHorizontal.ImageOptions.Image = CType(resources.GetObject("BarButtonItemFlipHorizontal.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemFlipHorizontal.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemFlipHorizontal.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemFlipHorizontal.Name = "BarButtonItemFlipHorizontal"
        '
        'BarButtonItemDownload
        '
        Me.BarButtonItemDownload.Caption = "Download"
        Me.BarButtonItemDownload.Id = 8
        Me.BarButtonItemDownload.ImageOptions.Image = CType(resources.GetObject("BarButtonItemDownload.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemDownload.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemDownload.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemDownload.Name = "BarButtonItemDownload"
        '
        'BarEditItemZoom
        '
        Me.BarEditItemZoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarEditItemZoom.Caption = "Zoom"
        Me.BarEditItemZoom.Edit = Me.RepositoryItemRangeTrackBar1
        Me.BarEditItemZoom.Id = 9
        Me.BarEditItemZoom.Name = "BarEditItemZoom"
        '
        'RepositoryItemRangeTrackBar1
        '
        Me.RepositoryItemRangeTrackBar1.LabelAppearance.Options.UseTextOptions = True
        Me.RepositoryItemRangeTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemRangeTrackBar1.Maximum = 100
        Me.RepositoryItemRangeTrackBar1.Name = "RepositoryItemRangeTrackBar1"
        Me.RepositoryItemRangeTrackBar1.ShowLabels = True
        Me.RepositoryItemRangeTrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'BarStaticItemZoomLevel
        '
        Me.BarStaticItemZoomLevel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItemZoomLevel.Caption = "0%"
        Me.BarStaticItemZoomLevel.Id = 10
        Me.BarStaticItemZoomLevel.Name = "BarStaticItemZoomLevel"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem1.Caption = "Zoom:"
        Me.BarButtonItem1.Id = 11
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Document Options"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItemRotate)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Rotation"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItemFlipVertical)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItemFlipHorizontal)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Flip"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItemDownload)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Save Option"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem3)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItemDocumentName)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem5)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItemDocumentDescription)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItemZoomLevel)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 514)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(793, 23)
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "Name:"
        Me.BarStaticItem3.Id = 1
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'BarStaticItemDocumentName
        '
        Me.BarStaticItemDocumentName.Caption = "DEFAULT"
        Me.BarStaticItemDocumentName.Id = 2
        Me.BarStaticItemDocumentName.Name = "BarStaticItemDocumentName"
        '
        'BarStaticItem5
        '
        Me.BarStaticItem5.Caption = "Description:"
        Me.BarStaticItem5.Id = 3
        Me.BarStaticItem5.Name = "BarStaticItem5"
        '
        'BarStaticItemDocumentDescription
        '
        Me.BarStaticItemDocumentDescription.Caption = "DEFAULT"
        Me.BarStaticItemDocumentDescription.Id = 4
        Me.BarStaticItemDocumentDescription.Name = "BarStaticItemDocumentDescription"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.ProgressPanel1)
        Me.PanelControl1.Controls.Add(Me.ImagePictureBox)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 142)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(793, 372)
        Me.PanelControl1.TabIndex = 7
        '
        'ProgressPanel1
        '
        Me.ProgressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.Options.UseBackColor = True
        Me.ProgressPanel1.BarAnimationElementThickness = 2
        Me.ProgressPanel1.Location = New System.Drawing.Point(230, 113)
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.Size = New System.Drawing.Size(333, 66)
        Me.ProgressPanel1.TabIndex = 10
        Me.ProgressPanel1.Text = "ProgressPanel1"
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImagePictureBox.Location = New System.Drawing.Point(2, 2)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.ImagePictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.ImagePictureBox.Size = New System.Drawing.Size(789, 368)
        Me.ImagePictureBox.TabIndex = 0
        '
        'frmViewImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 537)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "frmViewImage"
        Me.Text = "Image Viewer"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRangeTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.ImagePictureBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Public WithEvents BarStaticItemName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Public WithEvents BarStaticItemDescription As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItemRotate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemFlipVertical As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemFlipHorizontal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemDownload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Public WithEvents BarStaticItemDocumentName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem5 As DevExpress.XtraBars.BarStaticItem
    Public WithEvents BarStaticItemDocumentDescription As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ImagePictureBox As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents BarEditItemZoom As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemRangeTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemRangeTrackBar
    Friend WithEvents BarStaticItemZoomLevel As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents ProgressPanel1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
