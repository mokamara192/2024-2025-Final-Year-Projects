<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportViewer))
        Me.PanelBody = New DevExpress.XtraEditors.PanelControl()
        Me.MyCrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PanelOrange = New DevExpress.XtraEditors.PanelControl()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelBody.SuspendLayout()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBody
        '
        Me.PanelBody.BackColor = System.Drawing.Color.White
        Me.PanelBody.Controls.Add(Me.MyCrystalReportViewer)
        Me.PanelBody.Controls.Add(Me.PanelOrange)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(0, 131)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(894, 434)
        Me.PanelBody.TabIndex = 2
        '
        'MyCrystalReportViewer
        '
        Me.MyCrystalReportViewer.ActiveViewIndex = -1
        Me.MyCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.MyCrystalReportViewer.DisplayBackgroundEdge = False
        Me.MyCrystalReportViewer.DisplayToolbar = False
        Me.MyCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyCrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.MyCrystalReportViewer.Name = "MyCrystalReportViewer"
        Me.MyCrystalReportViewer.Size = New System.Drawing.Size(894, 434)
        Me.MyCrystalReportViewer.TabIndex = 85
        Me.MyCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'PanelOrange
        '
        Me.PanelOrange.BackColor = System.Drawing.Color.Chocolate
        Me.PanelOrange.Location = New System.Drawing.Point(-4, 24)
        Me.PanelOrange.Name = "PanelOrange"
        Me.PanelOrange.Size = New System.Drawing.Size(990, 10)
        Me.PanelOrange.TabIndex = 84
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 8
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.RibbonControl1.Size = New System.Drawing.Size(894, 131)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Print"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageUri.Uri = "Print"
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Export"
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ImageUri.Uri = "SaveAndNew"
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Refresh"
        Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ImageUri.Uri = "Refresh"
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Next Page"
        Me.BarButtonItem4.Glyph = CType(resources.GetObject("BarButtonItem4.Glyph"), System.Drawing.Image)
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.ImageUri.Uri = "DoubleNext"
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Previous Page"
        Me.BarButtonItem5.Glyph = CType(resources.GetObject("BarButtonItem5.Glyph"), System.Drawing.Image)
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.ImageUri.Uri = "DoublePrev"
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Move First"
        Me.BarButtonItem6.Glyph = CType(resources.GetObject("BarButtonItem6.Glyph"), System.Drawing.Image)
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.ImageUri.Uri = "DoubleFirst"
        Me.BarButtonItem6.LargeGlyph = CType(resources.GetObject("BarButtonItem6.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Move Last"
        Me.BarButtonItem7.Glyph = CType(resources.GetObject("BarButtonItem7.Glyph"), System.Drawing.Image)
        Me.BarButtonItem7.Id = 7
        Me.BarButtonItem7.ImageUri.Uri = "DoubleLast"
        Me.BarButtonItem7.LargeGlyph = CType(resources.GetObject("BarButtonItem7.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Home"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Report Actions"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Page Navigation"
        '
        'frmReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 565)
        Me.Controls.Add(Me.PanelBody)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReportViewer"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelBody.ResumeLayout(False)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()


    End Sub
    Friend WithEvents PanelBody As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelOrange As DevExpress.XtraEditors.PanelControl
    Friend WithEvents MyCrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
