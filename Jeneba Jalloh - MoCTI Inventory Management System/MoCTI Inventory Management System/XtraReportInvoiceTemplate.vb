Public Class XtraReportTransferTemplate
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
    Public WithEvents addressline As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrRichText6 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText5 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText4 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText3 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitle2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox9 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox8 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox7 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox6 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox5 As DevExpress.XtraReports.UI.XRPictureBox
    Public WithEvents lblApprovedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine7 As DevExpress.XtraReports.UI.XRLine
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
    Public WithEvents lblmanualdate As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents lblmanualdatevalue As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportTransferTemplate))
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
        Me.lblApprovedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine7 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine()
        Me.lblPreparedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox9 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox8 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox7 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox6 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox5 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrRichText6 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText5 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText4 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText3 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrRichText2 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTitle2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox15 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.CompanySettingsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.lblTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DebtorsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.lblmanualdate = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblmanualdatevalue = New DevExpress.XtraReports.UI.XRLabel()
        Me.addressline = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.lblprintdatevalue = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.lblprintdate = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        CType(Me.XrRichText6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DebtorsDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox18, Me.XrPictureBox17, Me.XrPictureBox16, Me.XrPictureBox14, Me.XrPictureBox13, Me.XrPictureBox12, Me.XrPictureBox11, Me.XrPictureBox10, Me.lblApprovedBy, Me.XrLine7, Me.XrLine6, Me.lblPreparedBy, Me.XrPictureBox9, Me.XrPictureBox8, Me.XrPictureBox7, Me.XrPictureBox6, Me.XrPictureBox5, Me.XrPictureBox4, Me.XrLine5, Me.XrLine4, Me.XrLabel17, Me.XrLine3, Me.XrLabel16, Me.XrPanel2, Me.XrPictureBox3, Me.XrPictureBox15})
        Me.Detail.HeightF = 758.3333!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPictureBox18
        '
        Me.XrPictureBox18.BorderWidth = 0!
        Me.XrPictureBox18.Image = CType(resources.GetObject("XrPictureBox18.Image"), System.Drawing.Image)
        Me.XrPictureBox18.LocationFloat = New DevExpress.Utils.PointFloat(643.7513!, 639.1666!)
        Me.XrPictureBox18.Name = "XrPictureBox18"
        Me.XrPictureBox18.SizeF = New System.Drawing.SizeF(62.58337!, 35.83325!)
        Me.XrPictureBox18.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox18.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox17
        '
        Me.XrPictureBox17.BorderWidth = 0!
        Me.XrPictureBox17.Image = CType(resources.GetObject("XrPictureBox17.Image"), System.Drawing.Image)
        Me.XrPictureBox17.LocationFloat = New DevExpress.Utils.PointFloat(550.0009!, 643.1666!)
        Me.XrPictureBox17.Name = "XrPictureBox17"
        Me.XrPictureBox17.SizeF = New System.Drawing.SizeF(101.1251!, 35.83325!)
        Me.XrPictureBox17.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox17.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox16
        '
        Me.XrPictureBox16.BorderWidth = 0!
        Me.XrPictureBox16.Image = CType(resources.GetObject("XrPictureBox16.Image"), System.Drawing.Image)
        Me.XrPictureBox16.LocationFloat = New DevExpress.Utils.PointFloat(431.1252!, 638.9999!)
        Me.XrPictureBox16.Name = "XrPictureBox16"
        Me.XrPictureBox16.SizeF = New System.Drawing.SizeF(117.7917!, 41.04163!)
        Me.XrPictureBox16.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox16.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox14
        '
        Me.XrPictureBox14.BorderWidth = 0!
        Me.XrPictureBox14.Image = CType(resources.GetObject("XrPictureBox14.Image"), System.Drawing.Image)
        Me.XrPictureBox14.LocationFloat = New DevExpress.Utils.PointFloat(214.4585!, 636.9166!)
        Me.XrPictureBox14.Name = "XrPictureBox14"
        Me.XrPictureBox14.SizeF = New System.Drawing.SizeF(117.7917!, 41.04163!)
        Me.XrPictureBox14.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox14.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox13
        '
        Me.XrPictureBox13.BorderWidth = 0!
        Me.XrPictureBox13.Image = CType(resources.GetObject("XrPictureBox13.Image"), System.Drawing.Image)
        Me.XrPictureBox13.LocationFloat = New DevExpress.Utils.PointFloat(100.9169!, 641.0416!)
        Me.XrPictureBox13.Name = "XrPictureBox13"
        Me.XrPictureBox13.SizeF = New System.Drawing.SizeF(111.5417!, 36.875!)
        Me.XrPictureBox13.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox13.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox12
        '
        Me.XrPictureBox12.BorderWidth = 0!
        Me.XrPictureBox12.Image = CType(resources.GetObject("XrPictureBox12.Image"), System.Drawing.Image)
        Me.XrPictureBox12.LocationFloat = New DevExpress.Utils.PointFloat(397.3334!, 566.0834!)
        Me.XrPictureBox12.Name = "XrPictureBox12"
        Me.XrPictureBox12.SizeF = New System.Drawing.SizeF(60.41666!, 62.91663!)
        Me.XrPictureBox12.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox12.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox11
        '
        Me.XrPictureBox11.BorderWidth = 0!
        Me.XrPictureBox11.Image = CType(resources.GetObject("XrPictureBox11.Image"), System.Drawing.Image)
        Me.XrPictureBox11.LocationFloat = New DevExpress.Utils.PointFloat(61.3334!, 577.5417!)
        Me.XrPictureBox11.Name = "XrPictureBox11"
        Me.XrPictureBox11.SizeF = New System.Drawing.SizeF(78.20833!, 62.91663!)
        Me.XrPictureBox11.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox11.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox10
        '
        Me.XrPictureBox10.BorderWidth = 0!
        Me.XrPictureBox10.Image = CType(resources.GetObject("XrPictureBox10.Image"), System.Drawing.Image)
        Me.XrPictureBox10.LocationFloat = New DevExpress.Utils.PointFloat(577.0834!, 578.5833!)
        Me.XrPictureBox10.Name = "XrPictureBox10"
        Me.XrPictureBox10.SizeF = New System.Drawing.SizeF(78.20833!, 62.91663!)
        Me.XrPictureBox10.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox10.StylePriority.UseBorderWidth = False
        '
        'lblApprovedBy
        '
        Me.lblApprovedBy.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.lblApprovedBy.LocationFloat = New DevExpress.Utils.PointFloat(524.896!, 725.8958!)
        Me.lblApprovedBy.Name = "lblApprovedBy"
        Me.lblApprovedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblApprovedBy.SizeF = New System.Drawing.SizeF(184.1667!, 26.0!)
        Me.lblApprovedBy.StylePriority.UseFont = False
        Me.lblApprovedBy.StylePriority.UseTextAlignment = False
        Me.lblApprovedBy.Text = "Approved By"
        Me.lblApprovedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine7
        '
        Me.XrLine7.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLine7.BorderWidth = 1.5!
        Me.XrLine7.LocationFloat = New DevExpress.Utils.PointFloat(523.9791!, 723.3123!)
        Me.XrLine7.Name = "XrLine7"
        Me.XrLine7.SizeF = New System.Drawing.SizeF(185.1667!, 2.083374!)
        Me.XrLine7.StylePriority.UseBorderDashStyle = False
        Me.XrLine7.StylePriority.UseBorderWidth = False
        '
        'XrLine6
        '
        Me.XrLine6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLine6.BorderWidth = 1.5!
        Me.XrLine6.LocationFloat = New DevExpress.Utils.PointFloat(38.56239!, 723.3123!)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.SizeF = New System.Drawing.SizeF(185.1667!, 2.083374!)
        Me.XrLine6.StylePriority.UseBorderDashStyle = False
        Me.XrLine6.StylePriority.UseBorderWidth = False
        '
        'lblPreparedBy
        '
        Me.lblPreparedBy.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.lblPreparedBy.LocationFloat = New DevExpress.Utils.PointFloat(39.47932!, 725.8958!)
        Me.lblPreparedBy.Name = "lblPreparedBy"
        Me.lblPreparedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPreparedBy.SizeF = New System.Drawing.SizeF(184.1667!, 26.0!)
        Me.lblPreparedBy.StylePriority.UseFont = False
        Me.lblPreparedBy.StylePriority.UseTextAlignment = False
        Me.lblPreparedBy.Text = "Prepared By"
        Me.lblPreparedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox9
        '
        Me.XrPictureBox9.BorderWidth = 0!
        Me.XrPictureBox9.Image = CType(resources.GetObject("XrPictureBox9.Image"), System.Drawing.Image)
        Me.XrPictureBox9.LocationFloat = New DevExpress.Utils.PointFloat(453.6251!, 571.0001!)
        Me.XrPictureBox9.Name = "XrPictureBox9"
        Me.XrPictureBox9.SizeF = New System.Drawing.SizeF(68.75!, 67.08325!)
        Me.XrPictureBox9.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox9.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox8
        '
        Me.XrPictureBox8.BorderWidth = 0!
        Me.XrPictureBox8.Image = CType(resources.GetObject("XrPictureBox8.Image"), System.Drawing.Image)
        Me.XrPictureBox8.LocationFloat = New DevExpress.Utils.PointFloat(521.5834!, 574.3334!)
        Me.XrPictureBox8.Name = "XrPictureBox8"
        Me.XrPictureBox8.SizeF = New System.Drawing.SizeF(67.70825!, 66.04163!)
        Me.XrPictureBox8.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox8.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox7
        '
        Me.XrPictureBox7.BorderWidth = 0!
        Me.XrPictureBox7.Image = CType(resources.GetObject("XrPictureBox7.Image"), System.Drawing.Image)
        Me.XrPictureBox7.LocationFloat = New DevExpress.Utils.PointFloat(654.4584!, 578.9167!)
        Me.XrPictureBox7.Name = "XrPictureBox7"
        Me.XrPictureBox7.SizeF = New System.Drawing.SizeF(60.41666!, 62.91663!)
        Me.XrPictureBox7.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox7.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox6
        '
        Me.XrPictureBox6.BorderWidth = 0!
        Me.XrPictureBox6.Image = CType(resources.GetObject("XrPictureBox6.Image"), System.Drawing.Image)
        Me.XrPictureBox6.LocationFloat = New DevExpress.Utils.PointFloat(336.125!, 566.0833!)
        Me.XrPictureBox6.Name = "XrPictureBox6"
        Me.XrPictureBox6.SizeF = New System.Drawing.SizeF(60.41663!, 62.91669!)
        Me.XrPictureBox6.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox6.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox5
        '
        Me.XrPictureBox5.BorderWidth = 0!
        Me.XrPictureBox5.Image = CType(resources.GetObject("XrPictureBox5.Image"), System.Drawing.Image)
        Me.XrPictureBox5.LocationFloat = New DevExpress.Utils.PointFloat(270.125!, 564.0001!)
        Me.XrPictureBox5.Name = "XrPictureBox5"
        Me.XrPictureBox5.SizeF = New System.Drawing.SizeF(60.41666!, 62.91663!)
        Me.XrPictureBox5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox5.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox4
        '
        Me.XrPictureBox4.BorderWidth = 0!
        Me.XrPictureBox4.Image = CType(resources.GetObject("XrPictureBox4.Image"), System.Drawing.Image)
        Me.XrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(137.7083!, 574.2917!)
        Me.XrPictureBox4.Name = "XrPictureBox4"
        Me.XrPictureBox4.SizeF = New System.Drawing.SizeF(60.41666!, 62.91669!)
        Me.XrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox4.StylePriority.UseBorderWidth = False
        '
        'XrLine5
        '
        Me.XrLine5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine5.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(23.91666!, 560.9375!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.SizeF = New System.Drawing.SizeF(718.5834!, 2.083313!)
        Me.XrLine5.StylePriority.UseBorderDashStyle = False
        '
        'XrLine4
        '
        Me.XrLine4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine4.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(160.375!, 528.125!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(583.3334!, 3.125061!)
        Me.XrLine4.StylePriority.UseBorderDashStyle = False
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(22.81265!, 507.8125!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(136.25!, 23.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "Amount in Words:"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine3
        '
        Me.XrLine3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(555.2291!, 491.479!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(185.1667!, 2.083374!)
        Me.XrLine3.StylePriority.UseBorderDashStyle = False
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(425.9377!, 471.0625!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(124.7917!, 23.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "TOTAL: Le "
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPanel2
        '
        Me.XrPanel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText6, Me.XrRichText5, Me.XrRichText4, Me.XrRichText3, Me.XrRichText2, Me.XrLabel15, Me.XrLabel14, Me.XrLabel13, Me.XrLabel10, Me.XrLabel9, Me.lblTitle2, Me.XrLabel11, Me.XrRichText1})
        Me.XrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(6.749948!, 0!)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.SizeF = New System.Drawing.SizeF(738.5001!, 458.3333!)
        Me.XrPanel2.StylePriority.UseBorders = False
        Me.XrPanel2.StylePriority.UseBorderWidth = False
        '
        'XrRichText6
        '
        Me.XrRichText6.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.XrRichText6.LocationFloat = New DevExpress.Utils.PointFloat(679.6667!, 47.8749!)
        Me.XrRichText6.Name = "XrRichText6"
        Me.XrRichText6.SerializableRtfString = resources.GetString("XrRichText6.SerializableRtfString")
        Me.XrRichText6.SizeF = New System.Drawing.SizeF(54.1665!, 404.9584!)
        Me.XrRichText6.StylePriority.UseFont = False
        '
        'XrRichText5
        '
        Me.XrRichText5.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.XrRichText5.LocationFloat = New DevExpress.Utils.PointFloat(558.8751!, 47.70823!)
        Me.XrRichText5.Name = "XrRichText5"
        Me.XrRichText5.SerializableRtfString = resources.GetString("XrRichText5.SerializableRtfString")
        Me.XrRichText5.SizeF = New System.Drawing.SizeF(115.6249!, 404.9167!)
        Me.XrRichText5.StylePriority.UseFont = False
        '
        'XrRichText4
        '
        Me.XrRichText4.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.XrRichText4.LocationFloat = New DevExpress.Utils.PointFloat(461.1252!, 47.8749!)
        Me.XrRichText4.Name = "XrRichText4"
        Me.XrRichText4.SerializableRtfString = resources.GetString("XrRichText4.SerializableRtfString")
        Me.XrRichText4.SizeF = New System.Drawing.SizeF(91.66666!, 404.9167!)
        Me.XrRichText4.StylePriority.UseFont = False
        '
        'XrRichText3
        '
        Me.XrRichText3.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.XrRichText3.LocationFloat = New DevExpress.Utils.PointFloat(399.3127!, 47.8749!)
        Me.XrRichText3.Name = "XrRichText3"
        Me.XrRichText3.SerializableRtfString = resources.GetString("XrRichText3.SerializableRtfString")
        Me.XrRichText3.SizeF = New System.Drawing.SizeF(54.16663!, 404.9584!)
        Me.XrRichText3.StylePriority.UseFont = False
        '
        'XrRichText2
        '
        Me.XrRichText2.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.XrRichText2.LocationFloat = New DevExpress.Utils.PointFloat(44.25011!, 47.8749!)
        Me.XrRichText2.Name = "XrRichText2"
        Me.XrRichText2.SerializableRtfString = resources.GetString("XrRichText2.SerializableRtfString")
        Me.XrRichText2.SizeF = New System.Drawing.SizeF(66.66666!, 404.8751!)
        Me.XrRichText2.StylePriority.UseFont = False
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(559.0003!, 4.187489!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(174.7918!, 38.62502!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Amount"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(461.292!, 4.187457!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(91.24997!, 38.62502!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Unit Cost"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(398.9169!, 4.104137!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(55.00009!, 38.62505!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Qty"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(115.4586!, 4.145876!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(278.9584!, 38.62502!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Description"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(44.41693!, 4.145876!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(65.41676!, 38.62502!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Ser No."
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblTitle2
        '
        Me.lblTitle2.Angle = 90.0!
        Me.lblTitle2.BackColor = System.Drawing.Color.Gray
        Me.lblTitle2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTitle2.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.ForeColor = System.Drawing.Color.White
        Me.lblTitle2.LocationFloat = New DevExpress.Utils.PointFloat(3.083324!, 270.2501!)
        Me.lblTitle2.Multiline = True
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitle2.SizeF = New System.Drawing.SizeF(37.37508!, 183.7086!)
        Me.lblTitle2.StylePriority.UseBackColor = False
        Me.lblTitle2.StylePriority.UseBorders = False
        Me.lblTitle2.StylePriority.UseFont = False
        Me.lblTitle2.StylePriority.UseForeColor = False
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
        'XrRichText1
        '
        Me.XrRichText1.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(114.875!, 47.45823!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(278.125!, 404.9168!)
        Me.XrRichText1.StylePriority.UseFont = False
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.BorderWidth = 0!
        Me.XrPictureBox3.Image = CType(resources.GetObject("XrPictureBox3.Image"), System.Drawing.Image)
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(197.7917!, 571.0001!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(78.20833!, 62.91663!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox3.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox15
        '
        Me.XrPictureBox15.BorderWidth = 0!
        Me.XrPictureBox15.Image = CType(resources.GetObject("XrPictureBox15.Image"), System.Drawing.Image)
        Me.XrPictureBox15.LocationFloat = New DevExpress.Utils.PointFloat(317.5836!, 635.8749!)
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
        Me.lblTitle.BackColor = System.Drawing.Color.Gray
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.LocationFloat = New DevExpress.Utils.PointFloat(6.240082!, 3.125!)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTitle.SizeF = New System.Drawing.SizeF(729.3746!, 29.20839!)
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
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel18, Me.XrLabel12, Me.XrLabel5, Me.XrLabel1, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4, Me.XrLabel7, Me.XrPictureBox1, Me.XrPanel1, Me.XrLabel33, Me.XrLabel34, Me.XrBarCode1, Me.lblprintdatevalue, Me.lblprintdate})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("DebtorID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 339.3332!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBandExceptFirstEntry
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "SubName")})
        Me.XrLabel18.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(137.5417!, 0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(245.8333!, 23.0!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.Text = "XrLabel12"
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(20.74993!, 172.75!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(88.50014!, 22.99997!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "UNGM:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "RegistrationNo")})
        Me.XrLabel5.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(109.3231!, 172.2083!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(224.9999!, 23.00003!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "NameofCompany")})
        Me.XrLabel1.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(127.1926!, 14.16657!)
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
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(233.8176!, 75.12499!)
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
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(233.8176!, 94.12507!)
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
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(11.90116!, 110.6251!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(733.3644!, 60.3749!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Importer of Computers, Stationaries, Phones and General Accessories. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Providing " &
    "Hardware Maintenance, Networking and General ICT Supports"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.CompanySettingsDataSource, "Logo")})
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(19.98974!, 7.999911!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(103.125!, 96.16685!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrPanel1
        '
        Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblmanualdate, Me.lblmanualdatevalue, Me.addressline, Me.XrLine1, Me.XrLabel8, Me.XrLabel6, Me.lblTitle})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 219.7917!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(741.8649!, 114.7916!)
        Me.XrPanel1.StylePriority.UseBorders = False
        Me.XrPanel1.StylePriority.UseBorderWidth = False
        '
        'lblmanualdate
        '
        Me.lblmanualdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblmanualdate.LocationFloat = New DevExpress.Utils.PointFloat(549.0575!, 79.31245!)
        Me.lblmanualdate.Name = "lblmanualdate"
        Me.lblmanualdate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblmanualdate.SizeF = New System.Drawing.SizeF(53.12469!, 21.0!)
        Me.lblmanualdate.StylePriority.UseFont = False
        Me.lblmanualdate.StylePriority.UseTextAlignment = False
        Me.lblmanualdate.Text = "Date:"
        Me.lblmanualdate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblmanualdatevalue
        '
        Me.lblmanualdatevalue.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblmanualdatevalue.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.lblmanualdatevalue.LocationFloat = New DevExpress.Utils.PointFloat(603.2243!, 83.27086!)
        Me.lblmanualdatevalue.Name = "lblmanualdatevalue"
        Me.lblmanualdatevalue.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblmanualdatevalue.SizeF = New System.Drawing.SizeF(127.0831!, 17.99999!)
        Me.lblmanualdatevalue.StylePriority.UseBorders = False
        Me.lblmanualdatevalue.StylePriority.UseFont = False
        Me.lblmanualdatevalue.StylePriority.UseTextAlignment = False
        Me.lblmanualdatevalue.Text = "......................"
        Me.lblmanualdatevalue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'addressline
        '
        Me.addressline.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.addressline.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.addressline.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.addressline.LocationFloat = New DevExpress.Utils.PointFloat(91.6666!, 98.43756!)
        Me.addressline.Name = "addressline"
        Me.addressline.SizeF = New System.Drawing.SizeF(453.2083!, 2.083336!)
        Me.addressline.StylePriority.UseBorderDashStyle = False
        Me.addressline.StylePriority.UseBorders = False
        '
        'XrLine1
        '
        Me.XrLine1.BorderColor = System.Drawing.Color.White
        Me.XrLine1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(46.875!, 64.68748!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(676.0417!, 2.0!)
        Me.XrLine1.StylePriority.UseBorderColor = False
        Me.XrLine1.StylePriority.UseBorderDashStyle = False
        Me.XrLine1.StylePriority.UseBorders = False
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(11.45862!, 77.52081!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(73.95805!, 22.99999!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Address:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(11.45862!, 43.14588!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(34.16675!, 22.99997!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "To:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        Me.XrLabel34.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel34.ForeColor = System.Drawing.Color.Sienna
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(110.1567!, 194.2709!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(224.9583!, 25.0!)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseForeColor = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.Text = "XrLabel34"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebtorID")})
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(481.9067!, 193.125!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.ShowText = False
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(265.2083!, 23.625!)
        Me.XrBarCode1.Symbology = EaN128Generator1
        '
        'lblprintdatevalue
        '
        Me.lblprintdatevalue.LocationFloat = New DevExpress.Utils.PointFloat(647.1151!, 170.125!)
        Me.lblprintdatevalue.Name = "lblprintdatevalue"
        Me.lblprintdatevalue.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblprintdatevalue.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.lblprintdatevalue.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.lblprintdatevalue.StylePriority.UseTextAlignment = False
        Me.lblprintdatevalue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.lblprintdatevalue.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'lblprintdate
        '
        Me.lblprintdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblprintdate.LocationFloat = New DevExpress.Utils.PointFloat(568.9896!, 170.125!)
        Me.lblprintdate.Name = "lblprintdate"
        Me.lblprintdate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblprintdate.SizeF = New System.Drawing.SizeF(78.12512!, 22.99998!)
        Me.lblprintdate.StylePriority.UseFont = False
        Me.lblprintdate.StylePriority.UseTextAlignment = False
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
        'XtraReportTransferTemplate
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
        CType(Me.XrRichText6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XrRichText5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XrRichText4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XrRichText3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XrRichText2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.XrRichText1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CompanySettingsDataSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DebtorsDataSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

End Class