Public Class XtraReportTransferHardcopyMore
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
    Public WithEvents CompanySettingsDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents lblprintdatevalue As DevExpress.XtraReports.UI.XRPageInfo
    Public WithEvents lblTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblprintdate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents lblTransferNo As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents MyBarCode As DevExpress.XtraReports.UI.XRBarCode
    Public WithEvents addressline As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Public WithEvents lblTotalCurrency As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine7 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabelPreparedBy As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents lblAddress As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents lblTo As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents TransferItemsDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents BindingSource1 As BindingSource
    Public WithEvents XrSubreportTransferItems As DevExpress.XtraReports.UI.XRSubreport
    Public WithEvents lblTotal As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents lblAmountInWords As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pbApprovedBy As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents pbPreparedBy As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents lblmanualdate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblmanualdatevalue As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pbStamp As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents pbApprovedByStamp As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents pbApprovedBySignatureMore As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents pbStampMore As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo
    Public WithEvents XrSubreportTransferItemsMore As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelApprovedBy As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelAccountNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPictureBox7 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox6 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox8 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox10 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox11 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox12 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox13 As DevExpress.XtraReports.UI.XRPictureBox

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportTransferHardcopyMore))
        Dim EaN128Generator1 As DevExpress.XtraPrinting.BarCode.EAN128Generator = New DevExpress.XtraPrinting.BarCode.EAN128Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPictureBox7 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox6 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox8 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox10 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox11 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox12 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrSubreportTransferItems = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrLabelAccountNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabelApprovedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.pbStamp = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.pbApprovedBy = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.lblAmountInWords = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine7 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabelPreparedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.lblTotalCurrency = New DevExpress.XtraReports.UI.XRLabel()
        Me.pbPreparedBy = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.pbApprovedByStamp = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.CompanySettingsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.lblTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.lblmanualdate = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblmanualdatevalue = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTo = New DevExpress.XtraReports.UI.XRLabel()
        Me.addressline = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTransferNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.MyBarCode = New DevExpress.XtraReports.UI.XRBarCode()
        Me.lblprintdatevalue = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblprintdate = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.TransferItemsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.pbApprovedBySignatureMore = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.pbStampMore = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrSubreportTransferItemsMore = New DevExpress.XtraReports.UI.XRSubreport()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox13 = New DevExpress.XtraReports.UI.XRPictureBox()
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferItemsDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox7, Me.XrPictureBox4, Me.XrPictureBox6, Me.XrPictureBox3, Me.XrPictureBox8, Me.XrPictureBox10, Me.XrPictureBox11, Me.XrPictureBox12, Me.XrSubreportTransferItems, Me.XrLabelAccountNo, Me.XrLabel12, Me.XrLine2, Me.XrLabelApprovedBy, Me.XrPageInfo1, Me.pbStamp, Me.XrLine4, Me.pbApprovedBy, Me.lblAmountInWords, Me.lblTotal, Me.XrLabel11, Me.XrLine7, Me.XrLine6, Me.XrLabelPreparedBy, Me.XrLabel17, Me.XrLine3, Me.lblTotalCurrency, Me.pbPreparedBy, Me.pbApprovedByStamp})
        Me.Detail.HeightF = 751.8958!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPictureBox7
        '
        Me.XrPictureBox7.BorderWidth = 0!
        Me.XrPictureBox7.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox7.ImageSource"))
        Me.XrPictureBox7.LocationFloat = New DevExpress.Utils.PointFloat(641.6251!, 582.0417!)
        Me.XrPictureBox7.Name = "XrPictureBox7"
        Me.XrPictureBox7.SizeF = New System.Drawing.SizeF(60.41666!, 62.91663!)
        Me.XrPictureBox7.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox7.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox4
        '
        Me.XrPictureBox4.BorderWidth = 0!
        Me.XrPictureBox4.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox4.ImageSource"))
        Me.XrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(131.0833!, 579.4167!)
        Me.XrPictureBox4.Name = "XrPictureBox4"
        Me.XrPictureBox4.SizeF = New System.Drawing.SizeF(104.5833!, 65.41669!)
        Me.XrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox4.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox6
        '
        Me.XrPictureBox6.BorderWidth = 0!
        Me.XrPictureBox6.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox6.ImageSource"))
        Me.XrPictureBox6.LocationFloat = New DevExpress.Utils.PointFloat(318.0416!, 572.2083!)
        Me.XrPictureBox6.Name = "XrPictureBox6"
        Me.XrPictureBox6.SizeF = New System.Drawing.SizeF(71.87494!, 71.25006!)
        Me.XrPictureBox6.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox6.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.BorderWidth = 0!
        Me.XrPictureBox3.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox3.ImageSource"))
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(240.5415!, 578.8335!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(73.20833!, 64.375!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox3.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox8
        '
        Me.XrPictureBox8.BorderWidth = 0!
        Me.XrPictureBox8.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox8.ImageSource"))
        Me.XrPictureBox8.LocationFloat = New DevExpress.Utils.PointFloat(482.4166!, 574.1251!)
        Me.XrPictureBox8.Name = "XrPictureBox8"
        Me.XrPictureBox8.SizeF = New System.Drawing.SizeF(67.70825!, 66.04163!)
        Me.XrPictureBox8.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox8.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox10
        '
        Me.XrPictureBox10.BorderWidth = 0!
        Me.XrPictureBox10.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox10.ImageSource"))
        Me.XrPictureBox10.LocationFloat = New DevExpress.Utils.PointFloat(560.0836!, 577.5416!)
        Me.XrPictureBox10.Name = "XrPictureBox10"
        Me.XrPictureBox10.SizeF = New System.Drawing.SizeF(78.20833!, 62.91663!)
        Me.XrPictureBox10.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox10.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox11
        '
        Me.XrPictureBox11.BorderWidth = 0!
        Me.XrPictureBox11.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox11.ImageSource"))
        Me.XrPictureBox11.LocationFloat = New DevExpress.Utils.PointFloat(50.54168!, 582.6667!)
        Me.XrPictureBox11.Name = "XrPictureBox11"
        Me.XrPictureBox11.SizeF = New System.Drawing.SizeF(78.20833!, 62.91663!)
        Me.XrPictureBox11.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox11.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox12
        '
        Me.XrPictureBox12.BorderWidth = 0!
        Me.XrPictureBox12.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox12.ImageSource"))
        Me.XrPictureBox12.LocationFloat = New DevExpress.Utils.PointFloat(394.875!, 573.0417!)
        Me.XrPictureBox12.Name = "XrPictureBox12"
        Me.XrPictureBox12.SizeF = New System.Drawing.SizeF(81.25!, 73.33331!)
        Me.XrPictureBox12.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox12.StylePriority.UseBorderWidth = False
        '
        'XrSubreportTransferItems
        '
        Me.XrSubreportTransferItems.CanShrink = True
        Me.XrSubreportTransferItems.LocationFloat = New DevExpress.Utils.PointFloat(54.33334!, 3.125!)
        Me.XrSubreportTransferItems.Name = "XrSubreportTransferItems"
        Me.XrSubreportTransferItems.ReportSource = New MoCTIMIS.XtraReportTransferItemsSubReportNoEnd()
        Me.XrSubreportTransferItems.SizeF = New System.Drawing.SizeF(686.4584!, 443.8333!)
        '
        'XrLabelAccountNo
        '
        Me.XrLabelAccountNo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLabelAccountNo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabelAccountNo.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.XrLabelAccountNo.ForeColor = System.Drawing.Color.Black
        Me.XrLabelAccountNo.LocationFloat = New DevExpress.Utils.PointFloat(135.271!, 533.3021!)
        Me.XrLabelAccountNo.Name = "XrLabelAccountNo"
        Me.XrLabelAccountNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelAccountNo.SizeF = New System.Drawing.SizeF(602.2499!, 23.95831!)
        Me.XrLabelAccountNo.StylePriority.UseBorderDashStyle = False
        Me.XrLabelAccountNo.StylePriority.UseBorders = False
        Me.XrLabelAccountNo.StylePriority.UseFont = False
        Me.XrLabelAccountNo.StylePriority.UseForeColor = False
        Me.XrLabelAccountNo.StylePriority.UseTextAlignment = False
        Me.XrLabelAccountNo.Text = "GTB (201-3031-333-2592)"
        Me.XrLabelAccountNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(22.18771!, 533.177!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(110.2083!, 23.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Bank Account:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine2
        '
        Me.XrLine2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(20.6459!, 559.5103!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(714.8334!, 2.083374!)
        Me.XrLine2.StylePriority.UseBorderDashStyle = False
        '
        'XrLabelApprovedBy
        '
        Me.XrLabelApprovedBy.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.XrLabelApprovedBy.LocationFloat = New DevExpress.Utils.PointFloat(525.5416!, 725.4479!)
        Me.XrLabelApprovedBy.Name = "XrLabelApprovedBy"
        Me.XrLabelApprovedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelApprovedBy.SizeF = New System.Drawing.SizeF(184.1667!, 26.0!)
        Me.XrLabelApprovedBy.StylePriority.UseFont = False
        Me.XrLabelApprovedBy.StylePriority.UseTextAlignment = False
        Me.XrLabelApprovedBy.Text = "Approved By"
        Me.XrLabelApprovedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrPageInfo1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(556.1667!, 361.0833!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseForeColor = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrPageInfo1.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'pbStamp
        '
        Me.pbStamp.LocationFloat = New DevExpress.Utils.PointFloat(489.75!, 309.0417!)
        Me.pbStamp.Name = "pbStamp"
        Me.pbStamp.SizeF = New System.Drawing.SizeF(238.5417!, 137.4167!)
        Me.pbStamp.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLine4
        '
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(46.0!, 448.9583!)
        Me.XrLine4.LockedInUserDesigner = True
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(694.7501!, 2.083313!)
        '
        'pbApprovedBy
        '
        Me.pbApprovedBy.LocationFloat = New DevExpress.Utils.PointFloat(512.0001!, 674.0208!)
        Me.pbApprovedBy.Name = "pbApprovedBy"
        Me.pbApprovedBy.SizeF = New System.Drawing.SizeF(205.0834!, 76.08325!)
        Me.pbApprovedBy.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'lblAmountInWords
        '
        Me.lblAmountInWords.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.lblAmountInWords.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.lblAmountInWords.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAmountInWords.ForeColor = System.Drawing.Color.Black
        Me.lblAmountInWords.LocationFloat = New DevExpress.Utils.PointFloat(22.35422!, 505.1875!)
        Me.lblAmountInWords.Name = "lblAmountInWords"
        Me.lblAmountInWords.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAmountInWords.SizeF = New System.Drawing.SizeF(716.6249!, 23.95831!)
        Me.lblAmountInWords.StylePriority.UseBorderDashStyle = False
        Me.lblAmountInWords.StylePriority.UseBorders = False
        Me.lblAmountInWords.StylePriority.UseFont = False
        Me.lblAmountInWords.StylePriority.UseForeColor = False
        Me.lblAmountInWords.StylePriority.UseTextAlignment = False
        Me.lblAmountInWords.Text = "Four hundred thousand leones"
        Me.lblAmountInWords.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.LocationFloat = New DevExpress.Utils.PointFloat(542.1465!, 459.2708!)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTotal.SizeF = New System.Drawing.SizeF(199.9583!, 25.0!)
        Me.lblTotal.StylePriority.UseFont = False
        Me.lblTotal.StylePriority.UseForeColor = False
        Me.lblTotal.StylePriority.UseTextAlignment = False
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Angle = 90.0!
        Me.XrLabel11.BackColor = System.Drawing.Color.SlateGray
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NameofCompany]")})
        Me.XrLabel11.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.ForeColor = System.Drawing.Color.White
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(8.833568!, 1.04173!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(37.37507!, 446.8748!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "[InputedBy]"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        'XrLabelPreparedBy
        '
        Me.XrLabelPreparedBy.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.XrLabelPreparedBy.LocationFloat = New DevExpress.Utils.PointFloat(39.47932!, 725.8958!)
        Me.XrLabelPreparedBy.Name = "XrLabelPreparedBy"
        Me.XrLabelPreparedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelPreparedBy.SizeF = New System.Drawing.SizeF(184.1667!, 26.0!)
        Me.XrLabelPreparedBy.StylePriority.UseFont = False
        Me.XrLabelPreparedBy.StylePriority.UseTextAlignment = False
        Me.XrLabelPreparedBy.Text = "Prepared By"
        Me.XrLabelPreparedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(22.81265!, 482.1042!)
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
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(545.2291!, 487.479!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(198.1667!, 2.083374!)
        Me.XrLine3.StylePriority.UseBorderDashStyle = False
        '
        'lblTotalCurrency
        '
        Me.lblTotalCurrency.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCurrency.LocationFloat = New DevExpress.Utils.PointFloat(425.9377!, 459.0625!)
        Me.lblTotalCurrency.Name = "lblTotalCurrency"
        Me.lblTotalCurrency.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTotalCurrency.SizeF = New System.Drawing.SizeF(113.3334!, 23.0!)
        Me.lblTotalCurrency.StylePriority.UseFont = False
        Me.lblTotalCurrency.StylePriority.UseTextAlignment = False
        Me.lblTotalCurrency.Text = "TOTAL: Le "
        Me.lblTotalCurrency.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'pbPreparedBy
        '
        Me.pbPreparedBy.LocationFloat = New DevExpress.Utils.PointFloat(30.54167!, 672.1249!)
        Me.pbPreparedBy.Name = "pbPreparedBy"
        Me.pbPreparedBy.SizeF = New System.Drawing.SizeF(199.8333!, 79.08325!)
        Me.pbPreparedBy.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'pbApprovedByStamp
        '
        Me.pbApprovedByStamp.LocationFloat = New DevExpress.Utils.PointFloat(529.8754!, 390.3542!)
        Me.pbApprovedByStamp.Name = "pbApprovedByStamp"
        Me.pbApprovedByStamp.SizeF = New System.Drawing.SizeF(155.0834!, 59.41656!)
        Me.pbApprovedByStamp.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'CompanySettingsDataSource
        '
        Me.CompanySettingsDataSource.DataSource = GetType(MoCTIMIS.CompanySettingDataSet.CompanySettingDataTableDataTable)
        Me.CompanySettingsDataSource.Name = "CompanySettingsDataSource"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.TopMargin.HeightF = 12.79167!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 7.791646!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox13, Me.XrLabel7, Me.XrPictureBox1, Me.XrPanel1, Me.XrLabel33, Me.lblTransferNo, Me.MyBarCode, Me.lblprintdatevalue, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.lblprintdate})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("DebtorID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 337.4999!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBandExceptFirstEntry
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Logo]")})
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(14.78141!, 7.916578!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(103.125!, 99.29186!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrPanel1
        '
        Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblmanualdate, Me.lblmanualdatevalue, Me.lblAddress, Me.lblTo, Me.addressline, Me.XrLine1, Me.XrLabel8, Me.XrLabel6, Me.lblTitle})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 226.7917!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(741.8649!, 105.7916!)
        Me.XrPanel1.StylePriority.UseBorders = False
        Me.XrPanel1.StylePriority.UseBorderWidth = False
        '
        'lblmanualdate
        '
        Me.lblmanualdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblmanualdate.LocationFloat = New DevExpress.Utils.PointFloat(545.9325!, 74.95829!)
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
        Me.lblmanualdatevalue.LocationFloat = New DevExpress.Utils.PointFloat(600.0993!, 76.91668!)
        Me.lblmanualdatevalue.Name = "lblmanualdatevalue"
        Me.lblmanualdatevalue.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblmanualdatevalue.SizeF = New System.Drawing.SizeF(127.0831!, 17.99999!)
        Me.lblmanualdatevalue.StylePriority.UseBorders = False
        Me.lblmanualdatevalue.StylePriority.UseFont = False
        Me.lblmanualdatevalue.StylePriority.UseTextAlignment = False
        Me.lblmanualdatevalue.Text = "........................"
        Me.lblmanualdatevalue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblAddress
        '
        Me.lblAddress.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblAddress.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.LocationFloat = New DevExpress.Utils.PointFloat(92.82831!, 72.10414!)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAddress.SizeF = New System.Drawing.SizeF(448.9166!, 21.87497!)
        Me.lblAddress.StylePriority.UseBorders = False
        Me.lblAddress.StylePriority.UseFont = False
        Me.lblAddress.StylePriority.UseForeColor = False
        Me.lblAddress.StylePriority.UseTextAlignment = False
        Me.lblAddress.Text = "lblAddress"
        Me.lblAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblTo
        '
        Me.lblTo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lblTo.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.ForeColor = System.Drawing.Color.Black
        Me.lblTo.LocationFloat = New DevExpress.Utils.PointFloat(91.78664!, 36.68751!)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTo.SizeF = New System.Drawing.SizeF(631.2083!, 24.99995!)
        Me.lblTo.StylePriority.UseBorders = False
        Me.lblTo.StylePriority.UseFont = False
        Me.lblTo.StylePriority.UseForeColor = False
        Me.lblTo.StylePriority.UseTextAlignment = False
        Me.lblTo.Text = "lblTo"
        Me.lblTo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'addressline
        '
        Me.addressline.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.addressline.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.addressline.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.addressline.LocationFloat = New DevExpress.Utils.PointFloat(91.66663!, 95.43756!)
        Me.addressline.Name = "addressline"
        Me.addressline.SizeF = New System.Drawing.SizeF(450.0001!, 2.083336!)
        Me.addressline.StylePriority.UseBorderDashStyle = False
        Me.addressline.StylePriority.UseBorders = False
        '
        'XrLine1
        '
        Me.XrLine1.BorderColor = System.Drawing.Color.White
        Me.XrLine1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.XrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(46.875!, 61.68748!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(676.0417!, 2.0!)
        Me.XrLine1.StylePriority.UseBorderColor = False
        Me.XrLine1.StylePriority.UseBorderDashStyle = False
        Me.XrLine1.StylePriority.UseBorders = False
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(11.45862!, 74.52081!)
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
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(11.45862!, 40.14588!)
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
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(21.00029!, 202.7501!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(88.50014!, 22.99997!)
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "Transfer No:"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblTransferNo
        '
        Me.lblTransferNo.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTransferNo.ForeColor = System.Drawing.Color.Sienna
        Me.lblTransferNo.LocationFloat = New DevExpress.Utils.PointFloat(111.1567!, 201.2709!)
        Me.lblTransferNo.Name = "lblTransferNo"
        Me.lblTransferNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTransferNo.SizeF = New System.Drawing.SizeF(224.9583!, 25.0!)
        Me.lblTransferNo.StylePriority.UseFont = False
        Me.lblTransferNo.StylePriority.UseForeColor = False
        Me.lblTransferNo.StylePriority.UseTextAlignment = False
        Me.lblTransferNo.Text = "lblTransferNo"
        Me.lblTransferNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'MyBarCode
        '
        Me.MyBarCode.AutoModule = True
        Me.MyBarCode.LocationFloat = New DevExpress.Utils.PointFloat(458.9484!, 201.125!)
        Me.MyBarCode.Name = "MyBarCode"
        Me.MyBarCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.MyBarCode.ShowText = False
        Me.MyBarCode.SizeF = New System.Drawing.SizeF(289.1666!, 22.625!)
        Me.MyBarCode.Symbology = EaN128Generator1
        '
        'lblprintdatevalue
        '
        Me.lblprintdatevalue.LocationFloat = New DevExpress.Utils.PointFloat(648.1151!, 178.125!)
        Me.lblprintdatevalue.Name = "lblprintdatevalue"
        Me.lblprintdatevalue.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblprintdatevalue.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.lblprintdatevalue.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.lblprintdatevalue.StylePriority.UseTextAlignment = False
        Me.lblprintdatevalue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.lblprintdatevalue.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'XrLabel4
        '
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Email]")})
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(209.0784!, 98.95841!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(332.2916!, 20.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PhoneNo]")})
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(209.0784!, 79.95837!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(332.2916!, 20.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Address]")})
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(209.0784!, 60.95826!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(332.2916!, 20.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NameofCompany]")})
        Me.XrLabel1.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(139.8544!, 8.999913!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(470.7395!, 54.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblprintdate
        '
        Me.lblprintdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblprintdate.LocationFloat = New DevExpress.Utils.PointFloat(569.9896!, 178.125!)
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
        Me.GroupFooter1.HeightF = 0!
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
        'TransferItemsDataSource
        '
        Me.TransferItemsDataSource.DataSource = GetType(MoCTIMIS._TransferItemsTable.TransferItemsTableDataTable)
        Me.TransferItemsDataSource.Name = "TransferItemsDataSource"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(330.6667!, 0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(101.0417!, 23.95837!)
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrPageInfo2.TextFormatString = "Page {0} of {1}"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2})
        Me.PageFooter.HeightF = 23.95837!
        Me.PageFooter.Name = "PageFooter"
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox2, Me.XrLabel5, Me.pbApprovedBySignatureMore, Me.pbStampMore, Me.XrPageInfo3, Me.XrSubreportTransferItemsMore})
        Me.ReportFooter.HeightF = 583.4166!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Logo]")})
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(26.52098!, 9.874843!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(70.83333!, 57.62519!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel5
        '
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NameofCompany]")})
        Me.XrLabel5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(101.1979!, 9.16658!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(613.8645!, 54.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel1"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'pbApprovedBySignatureMore
        '
        Me.pbApprovedBySignatureMore.LocationFloat = New DevExpress.Utils.PointFloat(539.5214!, 521.4063!)
        Me.pbApprovedBySignatureMore.Name = "pbApprovedBySignatureMore"
        Me.pbApprovedBySignatureMore.SizeF = New System.Drawing.SizeF(155.0834!, 59.41656!)
        Me.pbApprovedBySignatureMore.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'pbStampMore
        '
        Me.pbStampMore.LocationFloat = New DevExpress.Utils.PointFloat(499.3958!, 440.0938!)
        Me.pbStampMore.Name = "pbStampMore"
        Me.pbStampMore.SizeF = New System.Drawing.SizeF(238.5417!, 135.4167!)
        Me.pbStampMore.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrPageInfo3
        '
        Me.XrPageInfo3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrPageInfo3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(565.8126!, 492.1354!)
        Me.XrPageInfo3.Name = "XrPageInfo3"
        Me.XrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo3.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrPageInfo3.StylePriority.UseFont = False
        Me.XrPageInfo3.StylePriority.UseForeColor = False
        Me.XrPageInfo3.StylePriority.UseTextAlignment = False
        Me.XrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrPageInfo3.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'XrSubreportTransferItemsMore
        '
        Me.XrSubreportTransferItemsMore.CanShrink = True
        Me.XrSubreportTransferItemsMore.LocationFloat = New DevExpress.Utils.PointFloat(26.47915!, 68.75!)
        Me.XrSubreportTransferItemsMore.Name = "XrSubreportTransferItemsMore"
        Me.XrSubreportTransferItemsMore.ReportSource = New MoCTIMIS.XtraReportTransferItemsSubReportMore()
        Me.XrSubreportTransferItemsMore.SizeF = New System.Drawing.SizeF(712.5!, 511.3333!)
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(8.541965!, 117.4584!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(733.3644!, 61.37491!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Ministry of Commuincation, Technology and Innovation (MoCTI) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inventory Manageme" &
    "nt System"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPictureBox13
        '
        Me.XrPictureBox13.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox13.ImageSource"))
        Me.XrPictureBox13.LocationFloat = New DevExpress.Utils.PointFloat(634.7814!, 8.749924!)
        Me.XrPictureBox13.Name = "XrPictureBox13"
        Me.XrPictureBox13.SizeF = New System.Drawing.SizeF(103.125!, 99.29186!)
        Me.XrPictureBox13.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XtraReportTransferHardcopyMore
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupFooter1, Me.PageHeader, Me.ReportHeader, Me.PageFooter, Me.ReportFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.CompanySettingsDataSource, Me.TransferItemsDataSource})
        Me.DataSource = Me.CompanySettingsDataSource
        Me.Margins = New System.Drawing.Printing.Margins(29, 44, 13, 8)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None
        Me.Version = "18.2"
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferItemsDataSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

End Class