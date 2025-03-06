<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmScanner
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScanner))
        Me.selectButton = New System.Windows.Forms.Button()
        Me._twain32 = New Saraff.Twain.Twain32(Me.components)
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItemScan = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemSelectScanner = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemRotateLeft = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemRotateRight = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemFlipVertical = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItemSaveDocument = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItemStaffProfileID = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItemStaffID = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItemDivision = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItemFileType = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.ScanPictureBox = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ScanPictureBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'selectButton
        '
        Me.selectButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.selectButton.Location = New System.Drawing.Point(624, 550)
        Me.selectButton.Name = "selectButton"
        Me.selectButton.Size = New System.Drawing.Size(75, 23)
        Me.selectButton.TabIndex = 1
        Me.selectButton.Text = "Select DS"
        Me.selectButton.UseVisualStyleBackColor = True
        '
        '_twain32
        '
        Me._twain32.AppProductName = "Saraff.Twain"
        Me._twain32.Parent = Me
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItemScan, Me.BarButtonItemSelectScanner, Me.BarButtonItemCancel, Me.BarButtonItemRotateLeft, Me.BarButtonItemRotateRight, Me.BarButtonItemFlipVertical, Me.BarButtonItemSaveDocument, Me.BarStaticItem1, Me.BarStaticItemStaffProfileID, Me.BarStaticItem2, Me.BarStaticItemStaffID, Me.BarStaticItem3, Me.BarStaticItemDivision, Me.BarStaticItem4, Me.BarStaticItemFileType})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 17
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2})
        Me.RibbonControl1.Size = New System.Drawing.Size(792, 143)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BarButtonItemScan
        '
        Me.BarButtonItemScan.Caption = "Scan Document"
        Me.BarButtonItemScan.Id = 1
        Me.BarButtonItemScan.ImageOptions.LargeImage = Global.MoCTIMIS.My.Resources.Resources.Replacement_filing_cabinet22
        Me.BarButtonItemScan.Name = "BarButtonItemScan"
        Me.BarButtonItemScan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItemSelectScanner
        '
        Me.BarButtonItemSelectScanner.Caption = "Select Scanner"
        Me.BarButtonItemSelectScanner.Id = 2
        Me.BarButtonItemSelectScanner.ImageOptions.LargeImage = Global.MoCTIMIS.My.Resources.Resources.Hardware_Scanner_Camera_icon
        Me.BarButtonItemSelectScanner.Name = "BarButtonItemSelectScanner"
        Me.BarButtonItemSelectScanner.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItemCancel
        '
        Me.BarButtonItemCancel.Caption = "Cancel Scan"
        Me.BarButtonItemCancel.Id = 4
        Me.BarButtonItemCancel.Name = "BarButtonItemCancel"
        '
        'BarButtonItemRotateLeft
        '
        Me.BarButtonItemRotateLeft.Caption = "Flip Horizontal"
        Me.BarButtonItemRotateLeft.Id = 5
        Me.BarButtonItemRotateLeft.ImageOptions.Image = CType(resources.GetObject("BarButtonItemRotateLeft.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemRotateLeft.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemRotateLeft.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemRotateLeft.Name = "BarButtonItemRotateLeft"
        Me.BarButtonItemRotateLeft.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItemRotateRight
        '
        Me.BarButtonItemRotateRight.Caption = "Rotate Right"
        Me.BarButtonItemRotateRight.Id = 6
        Me.BarButtonItemRotateRight.ImageOptions.Image = CType(resources.GetObject("BarButtonItemRotateRight.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemRotateRight.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemRotateRight.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemRotateRight.Name = "BarButtonItemRotateRight"
        Me.BarButtonItemRotateRight.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItemFlipVertical
        '
        Me.BarButtonItemFlipVertical.Caption = "Flip Vertical"
        Me.BarButtonItemFlipVertical.Id = 7
        Me.BarButtonItemFlipVertical.ImageOptions.Image = CType(resources.GetObject("BarButtonItemFlipVertical.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemFlipVertical.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemFlipVertical.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemFlipVertical.Name = "BarButtonItemFlipVertical"
        Me.BarButtonItemFlipVertical.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItemSaveDocument
        '
        Me.BarButtonItemSaveDocument.Caption = "Save Document"
        Me.BarButtonItemSaveDocument.Enabled = False
        Me.BarButtonItemSaveDocument.Id = 8
        Me.BarButtonItemSaveDocument.ImageOptions.Image = CType(resources.GetObject("BarButtonItemSaveDocument.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItemSaveDocument.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItemSaveDocument.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItemSaveDocument.Name = "BarButtonItemSaveDocument"
        Me.BarButtonItemSaveDocument.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem1.Caption = "Staff Profile ID:"
        Me.BarStaticItem1.Id = 9
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarStaticItemStaffProfileID
        '
        Me.BarStaticItemStaffProfileID.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItemStaffProfileID.Caption = "BarStaticItem2"
        Me.BarStaticItemStaffProfileID.Id = 10
        Me.BarStaticItemStaffProfileID.Name = "BarStaticItemStaffProfileID"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem2.Caption = "Staff ID:"
        Me.BarStaticItem2.Id = 11
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'BarStaticItemStaffID
        '
        Me.BarStaticItemStaffID.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItemStaffID.Caption = "BarStaticItem3"
        Me.BarStaticItemStaffID.Id = 12
        Me.BarStaticItemStaffID.Name = "BarStaticItemStaffID"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem3.Caption = "Division:"
        Me.BarStaticItem3.Id = 13
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'BarStaticItemDivision
        '
        Me.BarStaticItemDivision.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItemDivision.Caption = "BarStaticItem4"
        Me.BarStaticItemDivision.Id = 14
        Me.BarStaticItemDivision.Name = "BarStaticItemDivision"
        '
        'BarStaticItem4
        '
        Me.BarStaticItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem4.Caption = "File Type:"
        Me.BarStaticItem4.Id = 15
        Me.BarStaticItem4.Name = "BarStaticItem4"
        '
        'BarStaticItemFileType
        '
        Me.BarStaticItemFileType.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItemFileType.Caption = "FileType"
        Me.BarStaticItemFileType.Id = 16
        Me.BarStaticItemFileType.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItemFileType.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black
        Me.BarStaticItemFileType.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItemFileType.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItemFileType.Name = "BarStaticItemFileType"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup4, Me.RibbonPageGroup5, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Operation"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ImageOptions.Image = Global.MoCTIMIS.My.Resources.Resources.Replacement_filing_cabinet22
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItemScan)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Scanning"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItemRotateRight)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Rotation"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItemRotateLeft)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItemFlipVertical)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Image Flipping"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItemSaveDocument)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Save"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Setting"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItemSelectScanner)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Source"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarButtonItemCancel)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItemStaffProfileID)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem2)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItemStaffID)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem3)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItemDivision)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem4)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItemFileType)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 554)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(792, 31)
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.ScanPictureBox)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 143)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(792, 411)
        Me.PanelControl1.TabIndex = 5
        '
        'ScanPictureBox
        '
        Me.ScanPictureBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.ScanPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScanPictureBox.Location = New System.Drawing.Point(2, 2)
        Me.ScanPictureBox.MenuManager = Me.RibbonControl1
        Me.ScanPictureBox.Name = "ScanPictureBox"
        Me.ScanPictureBox.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.ScanPictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.ScanPictureBox.Size = New System.Drawing.Size(788, 407)
        Me.ScanPictureBox.TabIndex = 0
        '
        'frmScanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 585)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.selectButton)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "frmScanner"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Document Scanner"
        CType(Me.RibbonControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl1.ResumeLayout(false)
        CType(Me.ScanPictureBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents selectButton As System.Windows.Forms.Button
    Friend WithEvents _twain32 As Saraff.Twain.Twain32
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents BarButtonItemScan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemSelectScanner As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItemCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemRotateLeft As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItemRotateRight As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ScanPictureBox As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents BarButtonItemFlipVertical As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItemSaveDocument As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItemStaffProfileID As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItemStaffID As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItemDivision As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItemFileType As DevExpress.XtraBars.BarStaticItem
End Class
