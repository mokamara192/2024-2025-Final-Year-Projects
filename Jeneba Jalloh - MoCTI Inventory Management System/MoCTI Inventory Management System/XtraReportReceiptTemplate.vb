Public Class XtraReportReceiptTemplate
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Public WithEvents DebtorsDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Public WithEvents CompanySettingsDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Public WithEvents lblprintdatevalue As DevExpress.XtraReports.UI.XRPageInfo
    Public WithEvents lblTitle As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents lblprintdate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents lblTitle2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox9 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox8 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox7 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox6 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox5 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Public WithEvents lblPreparedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox12 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox11 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox10 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox17 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox16 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox14 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox13 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox15 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox18 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine9 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine8 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine10 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine11 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine12 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine13 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape2 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape1 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine14 As DevExpress.XtraReports.UI.XRLine
    Public WithEvents lblmanualdate As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents lblmanualdatevalue As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportReceiptTemplate))
        Dim ShapeRectangle1 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Dim ShapeRectangle2 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Dim EaN128Generator1 As DevExpress.XtraPrinting.BarCode.EAN128Generator = New DevExpress.XtraPrinting.BarCode.EAN128Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPictureBox18 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox17 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox16 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox14 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox13 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox12 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox11 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox10 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine()
        Me.lblPreparedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox9 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox8 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox7 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox6 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox5 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
        Me.lblmanualdate = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblmanualdatevalue = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine14 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrShape2 = New DevExpress.XtraReports.UI.XRShape()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrShape1 = New DevExpress.XtraReports.UI.XRShape()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine13 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine10 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine11 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine12 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine9 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine8 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitle2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox15 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.CompanySettingsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.lblTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DebtorsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.lblprintdatevalue = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.lblprintdate = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        CType(Me.CompanySettingsDataSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DebtorsDataSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox18, Me.XrPictureBox17, Me.XrPictureBox16, Me.XrPictureBox14, Me.XrPictureBox13, Me.XrPictureBox12, Me.XrPictureBox11, Me.XrPictureBox10, Me.XrLine6, Me.lblPreparedBy, Me.XrPictureBox9, Me.XrPictureBox8, Me.XrPictureBox7, Me.XrPictureBox6, Me.XrPictureBox5, Me.XrPictureBox4, Me.XrLine3, Me.XrLabel16, Me.XrPanel2, Me.XrPictureBox3, Me.XrPictureBox15})
        Me.Detail.HeightF = 758.3333!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPictureBox18
        '
        Me.XrPictureBox18.BorderWidth = 0!
        Me.XrPictureBox18.Image = CType(resources.GetObject("XrPictureBox18.Image"),System.Drawing.Image)
        Me.XrPictureBox18.LocationFloat = New DevExpress.Utils.PointFloat(644.793!, 700.625!)
        Me.XrPictureBox18.Name = "XrPictureBox18"
        Me.XrPictureBox18.SizeF = New System.Drawing.SizeF(62.58337!, 35.83325!)
        Me.XrPictureBox18.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox18.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox17
        '
        Me.XrPictureBox17.BorderWidth = 0!
        Me.XrPictureBox17.Image = CType(resources.GetObject("XrPictureBox17.Image"),System.Drawing.Image)
        Me.XrPictureBox17.LocationFloat = New DevExpress.Utils.PointFloat(551.0425!, 704.6249!)
        Me.XrPictureBox17.Name = "XrPictureBox17"
        Me.XrPictureBox17.SizeF = New System.Drawing.SizeF(101.1251!, 35.83325!)
        Me.XrPictureBox17.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox17.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox16
        '
        Me.XrPictureBox16.BorderWidth = 0!
        Me.XrPictureBox16.Image = CType(resources.GetObject("XrPictureBox16.Image"),System.Drawing.Image)
        Me.XrPictureBox16.LocationFloat = New DevExpress.Utils.PointFloat(432.1669!, 700.4583!)
        Me.XrPictureBox16.Name = "XrPictureBox16"
        Me.XrPictureBox16.SizeF = New System.Drawing.SizeF(117.7917!, 41.04163!)
        Me.XrPictureBox16.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox16.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox14
        '
        Me.XrPictureBox14.BorderWidth = 0!
        Me.XrPictureBox14.Image = CType(resources.GetObject("XrPictureBox14.Image"),System.Drawing.Image)
        Me.XrPictureBox14.LocationFloat = New DevExpress.Utils.PointFloat(215.5002!, 698.3749!)
        Me.XrPictureBox14.Name = "XrPictureBox14"
        Me.XrPictureBox14.SizeF = New System.Drawing.SizeF(117.7917!, 41.04163!)
        Me.XrPictureBox14.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox14.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox13
        '
        Me.XrPictureBox13.BorderWidth = 0!
        Me.XrPictureBox13.Image = CType(resources.GetObject("XrPictureBox13.Image"),System.Drawing.Image)
        Me.XrPictureBox13.LocationFloat = New DevExpress.Utils.PointFloat(101.9586!, 702.4999!)
        Me.XrPictureBox13.Name = "XrPictureBox13"
        Me.XrPictureBox13.SizeF = New System.Drawing.SizeF(111.5417!, 36.875!)
        Me.XrPictureBox13.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox13.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox12
        '
        Me.XrPictureBox12.BorderWidth = 0!
        Me.XrPictureBox12.Image = CType(resources.GetObject("XrPictureBox12.Image"),System.Drawing.Image)
        Me.XrPictureBox12.LocationFloat = New DevExpress.Utils.PointFloat(398.375!, 627.5417!)
        Me.XrPictureBox12.Name = "XrPictureBox12"
        Me.XrPictureBox12.SizeF = New System.Drawing.SizeF(60.41666!, 62.91663!)
        Me.XrPictureBox12.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox12.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox11
        '
        Me.XrPictureBox11.BorderWidth = 0!
        Me.XrPictureBox11.Image = CType(resources.GetObject("XrPictureBox11.Image"),System.Drawing.Image)
        Me.XrPictureBox11.LocationFloat = New DevExpress.Utils.PointFloat(62.37507!, 639!)
        Me.XrPictureBox11.Name = "XrPictureBox11"
        Me.XrPictureBox11.SizeF = New System.Drawing.SizeF(78.20833!, 62.91663!)
        Me.XrPictureBox11.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox11.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox10
        '
        Me.XrPictureBox10.BorderWidth = 0!
        Me.XrPictureBox10.Image = CType(resources.GetObject("XrPictureBox10.Image"),System.Drawing.Image)
        Me.XrPictureBox10.LocationFloat = New DevExpress.Utils.PointFloat(578.1251!, 640.0417!)
        Me.XrPictureBox10.Name = "XrPictureBox10"
        Me.XrPictureBox10.SizeF = New System.Drawing.SizeF(78.20833!, 62.91663!)
        Me.XrPictureBox10.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox10.StylePriority.UseBorderWidth = false
        '
        'XrLine6
        '
        Me.XrLine6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLine6.BorderWidth = 1.5!
        Me.XrLine6.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine6.LineWidth = 2
        Me.XrLine6.LocationFloat = New DevExpress.Utils.PointFloat(531.2708!, 586.9374!)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.SizeF = New System.Drawing.SizeF(185.1667!, 2.083374!)
        Me.XrLine6.StylePriority.UseBorderDashStyle = false
        Me.XrLine6.StylePriority.UseBorderWidth = false
        '
        'lblPreparedBy
        '
        Me.lblPreparedBy.Font = New System.Drawing.Font("Calibri", 18!)
        Me.lblPreparedBy.LocationFloat = New DevExpress.Utils.PointFloat(414.4795!, 565.4375!)
        Me.lblPreparedBy.Name = "lblPreparedBy"
        Me.lblPreparedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblPreparedBy.SizeF = New System.Drawing.SizeF(112.2917!, 26!)
        Me.lblPreparedBy.StylePriority.UseFont = false
        Me.lblPreparedBy.StylePriority.UseTextAlignment = false
        Me.lblPreparedBy.Text = "Signature:"
        Me.lblPreparedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox9
        '
        Me.XrPictureBox9.BorderWidth = 0!
        Me.XrPictureBox9.Image = CType(resources.GetObject("XrPictureBox9.Image"),System.Drawing.Image)
        Me.XrPictureBox9.LocationFloat = New DevExpress.Utils.PointFloat(454.6667!, 632.4584!)
        Me.XrPictureBox9.Name = "XrPictureBox9"
        Me.XrPictureBox9.SizeF = New System.Drawing.SizeF(68.75!, 67.08325!)
        Me.XrPictureBox9.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox9.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox8
        '
        Me.XrPictureBox8.BorderWidth = 0!
        Me.XrPictureBox8.Image = CType(resources.GetObject("XrPictureBox8.Image"),System.Drawing.Image)
        Me.XrPictureBox8.LocationFloat = New DevExpress.Utils.PointFloat(522.6251!, 635.7917!)
        Me.XrPictureBox8.Name = "XrPictureBox8"
        Me.XrPictureBox8.SizeF = New System.Drawing.SizeF(67.70825!, 66.04163!)
        Me.XrPictureBox8.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox8.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox7
        '
        Me.XrPictureBox7.BorderWidth = 0!
        Me.XrPictureBox7.Image = CType(resources.GetObject("XrPictureBox7.Image"),System.Drawing.Image)
        Me.XrPictureBox7.LocationFloat = New DevExpress.Utils.PointFloat(655.5!, 640.375!)
        Me.XrPictureBox7.Name = "XrPictureBox7"
        Me.XrPictureBox7.SizeF = New System.Drawing.SizeF(60.41666!, 62.91663!)
        Me.XrPictureBox7.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox7.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox6
        '
        Me.XrPictureBox6.BorderWidth = 0!
        Me.XrPictureBox6.Image = CType(resources.GetObject("XrPictureBox6.Image"),System.Drawing.Image)
        Me.XrPictureBox6.LocationFloat = New DevExpress.Utils.PointFloat(337.1667!, 627.5417!)
        Me.XrPictureBox6.Name = "XrPictureBox6"
        Me.XrPictureBox6.SizeF = New System.Drawing.SizeF(60.41663!, 62.91669!)
        Me.XrPictureBox6.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox6.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox5
        '
        Me.XrPictureBox5.BorderWidth = 0!
        Me.XrPictureBox5.Image = CType(resources.GetObject("XrPictureBox5.Image"),System.Drawing.Image)
        Me.XrPictureBox5.LocationFloat = New DevExpress.Utils.PointFloat(271.1667!, 625.4584!)
        Me.XrPictureBox5.Name = "XrPictureBox5"
        Me.XrPictureBox5.SizeF = New System.Drawing.SizeF(60.41666!, 62.91663!)
        Me.XrPictureBox5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox5.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox4
        '
        Me.XrPictureBox4.BorderWidth = 0!
        Me.XrPictureBox4.Image = CType(resources.GetObject("XrPictureBox4.Image"),System.Drawing.Image)
        Me.XrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(138.75!, 635.75!)
        Me.XrPictureBox4.Name = "XrPictureBox4"
        Me.XrPictureBox4.SizeF = New System.Drawing.SizeF(60.41666!, 62.91669!)
        Me.XrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox4.StylePriority.UseBorderWidth = false
        '
        'XrLine3
        '
        Me.XrLine3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine3.LineWidth = 2
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(148.9792!, 587.3956!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(185.1667!, 2.083374!)
        Me.XrLine3.StylePriority.UseBorderDashStyle = false
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Calibri", 18!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(19.68775!, 566.9791!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(124.7917!, 23!)
        Me.XrLabel16.StylePriority.UseFont = false
        Me.XrLabel16.StylePriority.UseTextAlignment = false
        Me.XrLabel16.Text = "TOTAL: Le "
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPanel2
        '
        Me.XrPanel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblmanualdate, Me.lblmanualdatevalue, Me.XrLine14, Me.XrLabel15, Me.XrShape2, Me.XrLabel14, Me.XrShape1, Me.XrLabel13, Me.XrLine13, Me.XrLabel12, Me.XrLine10, Me.XrLine11, Me.XrLine12, Me.XrLabel10, Me.XrLine9, Me.XrLine8, Me.XrLine2, Me.XrLabel8, Me.XrLine1, Me.XrLabel6, Me.lblTitle2, Me.XrLabel11})
        Me.XrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(6.749948!, 0!)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.SizeF = New System.Drawing.SizeF(738.5001!, 502.0833!)
        Me.XrPanel2.StylePriority.UseBorders = false
        Me.XrPanel2.StylePriority.UseBorderWidth = false
        '
        'lblmanualdate
        '
        Me.lblmanualdate.Font = New System.Drawing.Font("Times New Roman", 14!, System.Drawing.FontStyle.Bold)
        Me.lblmanualdate.LocationFloat = New DevExpress.Utils.PointFloat(549.9586!, 10!)
        Me.lblmanualdate.Name = "lblmanualdate"
        Me.lblmanualdate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblmanualdate.SizeF = New System.Drawing.SizeF(57.29138!, 23!)
        Me.lblmanualdate.StylePriority.UseFont = false
        Me.lblmanualdate.StylePriority.UseTextAlignment = false
        Me.lblmanualdate.Text = "Date:"
        Me.lblmanualdate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblmanualdatevalue
        '
        Me.lblmanualdatevalue.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblmanualdatevalue.Font = New System.Drawing.Font("Times New Roman", 14!)
        Me.lblmanualdatevalue.LocationFloat = New DevExpress.Utils.PointFloat(608.292!, 11.9166!)
        Me.lblmanualdatevalue.Name = "lblmanualdatevalue"
        Me.lblmanualdatevalue.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblmanualdatevalue.SizeF = New System.Drawing.SizeF(127.0831!, 17.99999!)
        Me.lblmanualdatevalue.StylePriority.UseBorders = false
        Me.lblmanualdatevalue.StylePriority.UseFont = false
        Me.lblmanualdatevalue.StylePriority.UseTextAlignment = false
        Me.lblmanualdatevalue.Text = "......................."
        Me.lblmanualdatevalue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine14
        '
        Me.XrLine14.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine14.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine14.LineWidth = 2
        Me.XrLine14.LocationFloat = New DevExpress.Utils.PointFloat(542.5836!, 431.4167!)
        Me.XrLine14.Name = "XrLine14"
        Me.XrLine14.SizeF = New System.Drawing.SizeF(187.7084!, 2.083344!)
        Me.XrLine14.StylePriority.UseBorderDashStyle = false
        Me.XrLine14.StylePriority.UseBorders = false
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel15.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(456.2813!, 412.6458!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(81.24976!, 22.99997!)
        Me.XrLabel15.StylePriority.UseBorders = false
        Me.XrLabel15.StylePriority.UseFont = false
        Me.XrLabel15.StylePriority.UseTextAlignment = false
        Me.XrLabel15.Text = "Balance:"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrShape2
        '
        Me.XrShape2.LocationFloat = New DevExpress.Utils.PointFloat(374.9271!, 413.0208!)
        Me.XrShape2.Name = "XrShape2"
        Me.XrShape2.Shape = ShapeRectangle1
        Me.XrShape2.SizeF = New System.Drawing.SizeF(26.04167!, 21.875!)
        '
        'XrLabel14
        '
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel14.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(241.6981!, 412.0625!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(130.2081!, 22.99997!)
        Me.XrLabel14.StylePriority.UseBorders = false
        Me.XrLabel14.StylePriority.UseFont = false
        Me.XrLabel14.StylePriority.UseTextAlignment = false
        Me.XrLabel14.Text = "Part Payment"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrShape1
        '
        Me.XrShape1.LocationFloat = New DevExpress.Utils.PointFloat(189.4584!, 414.5416!)
        Me.XrShape1.Name = "XrShape1"
        Me.XrShape1.Shape = ShapeRectangle2
        Me.XrShape1.SizeF = New System.Drawing.SizeF(26.04167!, 21.875!)
        '
        'XrLabel13
        '
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel13.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(58.31267!, 412.4583!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(127.0831!, 22.99997!)
        Me.XrLabel13.StylePriority.UseBorders = false
        Me.XrLabel13.StylePriority.UseFont = false
        Me.XrLabel13.StylePriority.UseTextAlignment = false
        Me.XrLabel13.Text = "Full Payment"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine13
        '
        Me.XrLine13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine13.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine13.LineWidth = 2
        Me.XrLine13.LocationFloat = New DevExpress.Utils.PointFloat(307.9789!, 367.5835!)
        Me.XrLine13.Name = "XrLine13"
        Me.XrLine13.SizeF = New System.Drawing.SizeF(422.0834!, 2.083313!)
        Me.XrLine13.StylePriority.UseBorderDashStyle = false
        Me.XrLine13.StylePriority.UseBorders = false
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(56.60439!, 344.7083!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(244.7081!, 29.99997!)
        Me.XrLabel12.StylePriority.UseBorders = false
        Me.XrLabel12.StylePriority.UseFont = false
        Me.XrLabel12.StylePriority.UseTextAlignment = false
        Me.XrLabel12.Text = "Paid by Cash/Cheque No:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine10
        '
        Me.XrLine10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine10.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine10.LineWidth = 2
        Me.XrLine10.LocationFloat = New DevExpress.Utils.PointFloat(57.87487!, 318.6667!)
        Me.XrLine10.Name = "XrLine10"
        Me.XrLine10.SizeF = New System.Drawing.SizeF(677.0417!, 5.208336!)
        Me.XrLine10.StylePriority.UseBorderDashStyle = false
        Me.XrLine10.StylePriority.UseBorders = false
        '
        'XrLine11
        '
        Me.XrLine11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine11.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine11.LineWidth = 2
        Me.XrLine11.LocationFloat = New DevExpress.Utils.PointFloat(55.27067!, 278.125!)
        Me.XrLine11.Name = "XrLine11"
        Me.XrLine11.SizeF = New System.Drawing.SizeF(677.0417!, 5.208336!)
        Me.XrLine11.StylePriority.UseBorderDashStyle = false
        Me.XrLine11.StylePriority.UseBorders = false
        '
        'XrLine12
        '
        Me.XrLine12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine12.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine12.LineWidth = 2
        Me.XrLine12.LocationFloat = New DevExpress.Utils.PointFloat(248.5622!, 238.6667!)
        Me.XrLine12.Name = "XrLine12"
        Me.XrLine12.SizeF = New System.Drawing.SizeF(484.4166!, 4.166641!)
        Me.XrLine12.StylePriority.UseBorderDashStyle = false
        Me.XrLine12.StylePriority.UseBorders = false
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(53.521!, 217.875!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(191.583!, 30.99997!)
        Me.XrLabel10.StylePriority.UseBorders = false
        Me.XrLabel10.StylePriority.UseFont = false
        Me.XrLabel10.StylePriority.UseTextAlignment = false
        Me.XrLabel10.Text = "Being payment for"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine9
        '
        Me.XrLine9.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine9.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine9.LineWidth = 2
        Me.XrLine9.LocationFloat = New DevExpress.Utils.PointFloat(55.7292!, 178.8125!)
        Me.XrLine9.Name = "XrLine9"
        Me.XrLine9.SizeF = New System.Drawing.SizeF(677.0417!, 5.208336!)
        Me.XrLine9.StylePriority.UseBorderDashStyle = false
        Me.XrLine9.StylePriority.UseBorders = false
        '
        'XrLine8
        '
        Me.XrLine8.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine8.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine8.LineWidth = 2
        Me.XrLine8.LocationFloat = New DevExpress.Utils.PointFloat(53.125!, 138.2708!)
        Me.XrLine8.Name = "XrLine8"
        Me.XrLine8.SizeF = New System.Drawing.SizeF(677.0417!, 5.208336!)
        Me.XrLine8.StylePriority.UseBorderDashStyle = false
        Me.XrLine8.StylePriority.UseBorders = false
        '
        'XrLine2
        '
        Me.XrLine2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(170.375!, 99.8126!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(562.4585!, 5.208336!)
        Me.XrLine2.StylePriority.UseBorderDashStyle = false
        Me.XrLine2.StylePriority.UseBorders = false
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(51.37532!, 81.02082!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(117.7081!, 29.99998!)
        Me.XrLabel8.StylePriority.UseBorders = false
        Me.XrLabel8.StylePriority.UseFont = false
        Me.XrLabel8.StylePriority.UseTextAlignment = false
        Me.XrLabel8.Text = "The sum of "
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine1
        '
        Me.XrLine1.BorderColor = System.Drawing.Color.White
        Me.XrLine1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine1.LineWidth = 2
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(209.8334!, 59.18749!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(522!, 5.125011!)
        Me.XrLine1.StylePriority.UseBorderColor = false
        Me.XrLine1.StylePriority.UseBorderDashStyle = false
        Me.XrLine1.StylePriority.UseBorders = false
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(51.37532!, 39.64596!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(154.7501!, 28.99997!)
        Me.XrLabel6.StylePriority.UseBorders = false
        Me.XrLabel6.StylePriority.UseFont = false
        Me.XrLabel6.StylePriority.UseTextAlignment = false
        Me.XrLabel6.Text = "Received From:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblTitle2
        '
        Me.lblTitle2.Angle = 90!
        Me.lblTitle2.BackColor = System.Drawing.Color.DimGray
        Me.lblTitle2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTitle2.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTitle2.ForeColor = System.Drawing.Color.White
        Me.lblTitle2.LocationFloat = New DevExpress.Utils.PointFloat(3.083324!, 270.2501!)
        Me.lblTitle2.Multiline = true
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblTitle2.SizeF = New System.Drawing.SizeF(37.37508!, 227.4586!)
        Me.lblTitle2.StylePriority.UseBackColor = false
        Me.lblTitle2.StylePriority.UseBorders = false
        Me.lblTitle2.StylePriority.UseFont = false
        Me.lblTitle2.StylePriority.UseForeColor = false
        Me.lblTitle2.StylePriority.UseTextAlignment = False
        Me.lblTitle2.Text = "Transfer"
        Me.lblTitle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.Angle = 90.0!
        Me.XrLabel11.BackColor = System.Drawing.Color.Chocolate
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel11.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.ForeColor = System.Drawing.Color.White
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(3.125286!, 3.125064!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(37.37507!, 266.6665!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "[InputedBy]"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.BorderWidth = 0!
        Me.XrPictureBox3.Image = CType(resources.GetObject("XrPictureBox3.Image"), System.Drawing.Image)
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(198.8334!, 632.4584!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(78.20833!, 62.91663!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox3.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox15
        '
        Me.XrPictureBox15.BorderWidth = 0!
        Me.XrPictureBox15.Image = CType(resources.GetObject("XrPictureBox15.Image"), System.Drawing.Image)
        Me.XrPictureBox15.LocationFloat = New DevExpress.Utils.PointFloat(318.6252!, 697.3333!)
        Me.XrPictureBox15.Name = "XrPictureBox15"
        Me.XrPictureBox15.SizeF = New System.Drawing.SizeF(126.125!, 44.16663!)
        Me.XrPictureBox15.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox15.StylePriority.UseBorderWidth = False
        '
        'CompanySettingsDataSource
        '
        Me.CompanySettingsDataSource.DataSource = GetType(MoCTIMIS.CompanySettingDataSet.CompanySettingDataTableDataTable)
        Me.CompanySettingsDataSource.Name = "CompanySettingsDataSource"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.DimGray
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.LocationFloat = New DevExpress.Utils.PointFloat(13.3651!, 221.7917!)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitle.SizeF = New System.Drawing.SizeF(729.3746!, 34.20839!)
        Me.lblTitle.StylePriority.UseBackColor = False
        Me.lblTitle.StylePriority.UseFont = False
        Me.lblTitle.StylePriority.UseForeColor = False
        Me.lblTitle.StylePriority.UseTextAlignment = False
        Me.lblTitle.Text = "PROFOMA Transfer"
        Me.lblTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 18.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 13.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DebtorsDataSource
        '
        Me.DebtorsDataSource.DataSource = GetType(MoCTIMIS.DebtorsTable.DebtorsTableDataTable)
        Me.DebtorsDataSource.Name = "DebtorsDataSource"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel17, Me.XrLabel5, Me.XrLabel9, Me.lblTitle, Me.XrLabel1, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4, Me.XrLabel7, Me.XrPictureBox1, Me.XrLabel33, Me.XrLabel34, Me.XrBarCode1, Me.lblprintdatevalue, Me.lblprintdate})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("DebtorID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 285.1664!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBandExceptFirstEntry
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "SubName")})
        Me.XrLabel17.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(138.2917!, 0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(245.8333!, 23.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.Text = "XrLabel12"
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(20.21873!, 173.6249!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(88.50014!, 22.99997!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "License No:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "RegistrationNo")})
        Me.XrLabel9.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(109.7813!, 173.6249!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(224.9999!, 23.00003!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "XrLabel5"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "NameofCompany")})
        Me.XrLabel1.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(127.1926!, 13.16657!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(531.5728!, 46.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "Address")})
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(232.8177!, 56.12491!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(332.2916!, 20.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "PhoneNo")})
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(233.8176!, 74.12499!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(332.2916!, 20.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "Email")})
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(233.8176!, 92.12507!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(332.2916!, 20.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(11.90116!, 109.6251!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(733.3644!, 61.37491!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Importer of Computers, Stationaries, Phones and General Accessories. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Providing " &
    "Hardware Maintenance, Networking and General ICT Supports"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.CompanySettingsDataSource, "Logo")})
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(19.98974!, 6.999911!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(103.125!, 96.16685!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel33
        '
        Me.XrLabel33.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(20.00029!, 195.7501!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(88.50014!, 22.99997!)
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "Transfer No:"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel34
        '
        Me.XrLabel34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebtorID")})
        Me.XrLabel34.Font = New System.Drawing.Font("Rockwell", 14!, System.Drawing.FontStyle.Bold)
        Me.XrLabel34.ForeColor = System.Drawing.Color.Sienna
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(110.1567!, 194.2709!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(224.9583!, 25!)
        Me.XrLabel34.StylePriority.UseFont = false
        Me.XrLabel34.StylePriority.UseForeColor = false
        Me.XrLabel34.StylePriority.UseTextAlignment = false
        Me.XrLabel34.Text = "XrLabel34"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = true
        Me.XrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebtorID")})
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(481.9067!, 193.125!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100!)
        Me.XrBarCode1.ShowText = false
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(265.2083!, 23.625!)
        Me.XrBarCode1.Symbology = EaN128Generator1
        '
        'lblprintdatevalue
        '
        Me.lblprintdatevalue.LocationFloat = New DevExpress.Utils.PointFloat(647.1151!, 170.125!)
        Me.lblprintdatevalue.Name = "lblprintdatevalue"
        Me.lblprintdatevalue.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblprintdatevalue.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.lblprintdatevalue.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.lblprintdatevalue.StylePriority.UseTextAlignment = false
        Me.lblprintdatevalue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.lblprintdatevalue.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'lblprintdate
        '
        Me.lblprintdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblprintdate.LocationFloat = New DevExpress.Utils.PointFloat(568.9896!, 170.125!)
        Me.lblprintdate.Name = "lblprintdate"
        Me.lblprintdate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lblprintdate.SizeF = New System.Drawing.SizeF(78.12512!, 22.99998!)
        Me.lblprintdate.StylePriority.UseFont = false
        Me.lblprintdate.StylePriority.UseTextAlignment = false
        Me.lblprintdate.Text = "Print Date:"
        Me.lblprintdate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupFooter1
        '
        Me.GroupFooter1.HeightF = 9.375!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'PageHeader
        '
        Me.PageHeader.HeightF = 0!
        Me.PageHeader.Name = "PageHeader"
        '
        'ReportHeader
        '
        Me.ReportHeader.HeightF = 0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XtraReportReceiptTemplate
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupFooter1, Me.PageHeader, Me.ReportHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DebtorsDataSource, Me.CompanySettingsDataSource})
        Me.DataSource = Me.DebtorsDataSource
        Me.Margins = New System.Drawing.Printing.Margins(29, 45, 18, 13)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None
        Me.Version = "17.2"
        CType(Me.CompanySettingsDataSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DebtorsDataSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

End Class