<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReportStockReorderSingle
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.CompanySettingsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.StockReorderDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelReportTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelReportCriteriaLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabelReportDateCriteria = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelReportDateField = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelReorderID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderReorderID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelStockID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderStockID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelCurrentRetailQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderCurrentRetailQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelReorderRetailQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderReorderRetailQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelNewRetailQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderNewRetailQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelCurrentWholesaleQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderCurrentWholesaleQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelReorderWholesaleQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderReorderWholesaleQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelNewWholesaleQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderNewWholesaleQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelReorderDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderReorderDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRorderSource = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRorderSource = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelSupervisor = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderSupervisor = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRegDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRegDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelInputedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderInputedBy = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.CompanySettingsDataSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.StockReorderDataSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabelReorderID,Me.XrLabelStockID,Me.XrLabelCurrentRetailQuantity,Me.XrLabelReorderRetailQuantity,Me.XrLabelNewRetailQuantity,Me.XrLabelCurrentWholesaleQuantity,Me.XrLabelReorderWholesaleQuantity,Me.XrLabelNewWholesaleQuantity,Me.XrLabelReorderDate,Me.XrLabelRorderSource,Me.XrLabelSupervisor,Me.XrLabelComment,Me.XrLabelRegDate,Me.XrLabelInputedBy,Me.XrLabelHeaderReorderID,Me.XrLabelHeaderStockID,Me.XrLabelHeaderCurrentRetailQuantity,Me.XrLabelHeaderReorderRetailQuantity,Me.XrLabelHeaderNewRetailQuantity,Me.XrLabelHeaderCurrentWholesaleQuantity,Me.XrLabelHeaderReorderWholesaleQuantity,Me.XrLabelHeaderNewWholesaleQuantity,Me.XrLabelHeaderReorderDate,Me.XrLabelHeaderRorderSource,Me.XrLabelHeaderSupervisor,Me.XrLabelHeaderComment,Me.XrLabelHeaderRegDate,Me.XrLabelHeaderInputedBy})
        Me.Detail.HeightF = 504!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 31.11298!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 25.27318!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'CompanySettingsDataSource
        '
        Me.CompanySettingsDataSource.DataSource = GetType(MoCTIMIS.CompanySettingDataSet.CompanySettingDataTableDataTable)
        Me.CompanySettingsDataSource.Name = "CompanySettingsDataSource"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabelReportDateField, Me.XrLabelReportDateCriteria, Me.XrPageInfo2, Me.XrLabelReportCriteriaLabel, Me.XrLabel8, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrPictureBox1, Me.XrLabel1, Me.XrLabelReportTitle})
        Me.ReportHeader.HeightF = 139.7035!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'PageHeader
        '
        Me.PageHeader.HeightF = 15.43748!
        Me.PageHeader.Name = "PageHeader"
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 19.79167!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.PageFooter.HeightF = 32.29167!
        Me.PageFooter.Name = "PageFooter"
        '
        'StockReorderDataSource
        '
        Me.StockReorderDataSource.DataSource = GetType(MoCTIMIS.StockReorderTable.StockReorderTableDataTable)
        Me.StockReorderDataSource.Name = "StockReorderDataSource"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "NameofCompany")})
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(108.5833!, 10!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(289.5833!, 23!)
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.StylePriority.UseTextAlignment = false
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.CompanySettingsDataSource, "Logo")})
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(9.999963!, 10!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(93.95032!, 93.39261!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "Address")})
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(108.5833!, 33!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(289.5833!, 23!)
        Me.XrLabel2.StylePriority.UseFont = false
        Me.XrLabel2.StylePriority.UseTextAlignment = false
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "Email")})
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(109.625!, 56.12499!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(288.5417!, 23!)
        Me.XrLabel3.StylePriority.UseFont = false
        Me.XrLabel3.StylePriority.UseTextAlignment = false
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "PhoneNo")})
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(109.4447!, 79.54568!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(288.4015!, 23!)
        Me.XrLabel4.StylePriority.UseFont = false
        Me.XrLabel4.StylePriority.UseTextAlignment = false
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelReportTitle
        '
        Me.XrLabelReportTitle.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Bold)
        Me.XrLabelReportTitle.LocationFloat = New DevExpress.Utils.PointFloat(145.5024!, 104.0817!)
        Me.XrLabelReportTitle.Name = "XrLabelReportTitle"
        Me.XrLabelReportTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelReportTitle.SizeF = New System.Drawing.SizeF(467.7885!, 27.99999!)
        Me.XrLabelReportTitle.StylePriority.UseFont = false
        Me.XrLabelReportTitle.StylePriority.UseTextAlignment = false
        Me.XrLabelReportTitle.Text = "Report Title"
        Me.XrLabelReportTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Format = "Page {0} of {1}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(343.8197!, 4.72597!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrPageInfo1.StylePriority.UseTextAlignment = false
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(416.0008!, 8.713944!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(98.45834!, 23!)
        Me.XrLabel8.StylePriority.UseTextAlignment = false
        Me.XrLabel8.Text = "Print Date/Time:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelReportCriteriaLabel
        '
        Me.XrLabelReportCriteriaLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabelReportCriteriaLabel.LocationFloat = New DevExpress.Utils.PointFloat(418.1674!, 47.1851!)
        Me.XrLabelReportCriteriaLabel.Name = "XrLabelReportCriteriaLabel"
        Me.XrLabelReportCriteriaLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelReportCriteriaLabel.SizeF = New System.Drawing.SizeF(107.4583!, 23!)
        Me.XrLabelReportCriteriaLabel.StylePriority.UseFont = false
        Me.XrLabelReportCriteriaLabel.StylePriority.UseTextAlignment = false
        Me.XrLabelReportCriteriaLabel.Text = "Report Criteria:"
        Me.XrLabelReportCriteriaLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Format = "{0:dd/MM/yyyy hh:mm:ss tt}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(516.2964!, 8.891042!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(220.8333!, 23!)
        Me.XrPageInfo2.StylePriority.UseTextAlignment = false
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelReportDateCriteria
        '
        Me.XrLabelReportDateCriteria.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelReportDateCriteria.LocationFloat = New DevExpress.Utils.PointFloat(419.0289!, 71.16827!)
        Me.XrLabelReportDateCriteria.Name = "XrLabelReportDateCriteria"
        Me.XrLabelReportDateCriteria.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelReportDateCriteria.SizeF = New System.Drawing.SizeF(319.2972!, 23!)
        Me.XrLabelReportDateCriteria.StylePriority.UseFont = false
        Me.XrLabelReportDateCriteria.StylePriority.UseTextAlignment = false
        Me.XrLabelReportDateCriteria.Text = "11/01/2018 - 30-01-2018"
        Me.XrLabelReportDateCriteria.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelReportDateField
        '
        Me.XrLabelReportDateField.Font = New System.Drawing.Font("Times New Roman", 10!)
        Me.XrLabelReportDateField.LocationFloat = New DevExpress.Utils.PointFloat(526.2091!, 47.14343!)
        Me.XrLabelReportDateField.Name = "XrLabelReportDateField"
        Me.XrLabelReportDateField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelReportDateField.SizeF = New System.Drawing.SizeF(212.6666!, 23!)
        Me.XrLabelReportDateField.StylePriority.UseFont = false
        Me.XrLabelReportDateField.StylePriority.UseTextAlignment = false
        Me.XrLabelReportDateField.Text = "EmploymentDate"
        Me.XrLabelReportDateField.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelReorderID
        '
        Me.XrLabelReorderID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ReorderID, {0:#,#}")})
        Me.XrLabelReorderID.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelReorderID.LocationFloat = New DevExpress.Utils.PointFloat(113!, 8!)
        Me.XrLabelReorderID.Name = "XrLabelReorderID"
        Me.XrLabelReorderID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelReorderID.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelReorderID.StylePriority.UseFont = false
        Me.XrLabelReorderID.StylePriority.UseTextAlignment = false
        Me.XrLabelReorderID.Text = "XrLabelReorderID"
        Me.XrLabelReorderID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderReorderID
        '
        Me.XrLabelHeaderReorderID.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderReorderID.LocationFloat = New DevExpress.Utils.PointFloat(13!, 8!)
        Me.XrLabelHeaderReorderID.Name = "XrLabelHeaderReorderID"
        Me.XrLabelHeaderReorderID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderReorderID.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderReorderID.StylePriority.UseFont = false
        Me.XrLabelHeaderReorderID.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderReorderID.Text = "Reorder ID:"
        Me.XrLabelHeaderReorderID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelStockID
        '
        Me.XrLabelStockID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "StockID, {0:#,#}")})
        Me.XrLabelStockID.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelStockID.LocationFloat = New DevExpress.Utils.PointFloat(113!, 26!)
        Me.XrLabelStockID.Name = "XrLabelStockID"
        Me.XrLabelStockID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelStockID.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelStockID.StylePriority.UseFont = false
        Me.XrLabelStockID.StylePriority.UseTextAlignment = false
        Me.XrLabelStockID.Text = "XrLabelStockID"
        Me.XrLabelStockID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderStockID
        '
        Me.XrLabelHeaderStockID.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderStockID.LocationFloat = New DevExpress.Utils.PointFloat(13!, 26!)
        Me.XrLabelHeaderStockID.Name = "XrLabelHeaderStockID"
        Me.XrLabelHeaderStockID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderStockID.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderStockID.StylePriority.UseFont = false
        Me.XrLabelHeaderStockID.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderStockID.Text = "Stock ID:"
        Me.XrLabelHeaderStockID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelCurrentRetailQuantity
        '
        Me.XrLabelCurrentRetailQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CurrentRetailQuantity, {0:n2}")})
        Me.XrLabelCurrentRetailQuantity.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelCurrentRetailQuantity.LocationFloat = New DevExpress.Utils.PointFloat(113!, 52!)
        Me.XrLabelCurrentRetailQuantity.Name = "XrLabelCurrentRetailQuantity"
        Me.XrLabelCurrentRetailQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelCurrentRetailQuantity.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelCurrentRetailQuantity.StylePriority.UseFont = false
        Me.XrLabelCurrentRetailQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelCurrentRetailQuantity.Text = "XrLabelCurrentRetailQuantity"
        Me.XrLabelCurrentRetailQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderCurrentRetailQuantity
        '
        Me.XrLabelHeaderCurrentRetailQuantity.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderCurrentRetailQuantity.LocationFloat = New DevExpress.Utils.PointFloat(13!, 52!)
        Me.XrLabelHeaderCurrentRetailQuantity.Name = "XrLabelHeaderCurrentRetailQuantity"
        Me.XrLabelHeaderCurrentRetailQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderCurrentRetailQuantity.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderCurrentRetailQuantity.StylePriority.UseFont = false
        Me.XrLabelHeaderCurrentRetailQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderCurrentRetailQuantity.Text = "Current Retail Quantity:"
        Me.XrLabelHeaderCurrentRetailQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelReorderRetailQuantity
        '
        Me.XrLabelReorderRetailQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ReorderRetailQuantity, {0:n2}")})
        Me.XrLabelReorderRetailQuantity.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelReorderRetailQuantity.LocationFloat = New DevExpress.Utils.PointFloat(113!, 78!)
        Me.XrLabelReorderRetailQuantity.Name = "XrLabelReorderRetailQuantity"
        Me.XrLabelReorderRetailQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelReorderRetailQuantity.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelReorderRetailQuantity.StylePriority.UseFont = false
        Me.XrLabelReorderRetailQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelReorderRetailQuantity.Text = "XrLabelReorderRetailQuantity"
        Me.XrLabelReorderRetailQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderReorderRetailQuantity
        '
        Me.XrLabelHeaderReorderRetailQuantity.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderReorderRetailQuantity.LocationFloat = New DevExpress.Utils.PointFloat(13!, 78!)
        Me.XrLabelHeaderReorderRetailQuantity.Name = "XrLabelHeaderReorderRetailQuantity"
        Me.XrLabelHeaderReorderRetailQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderReorderRetailQuantity.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderReorderRetailQuantity.StylePriority.UseFont = false
        Me.XrLabelHeaderReorderRetailQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderReorderRetailQuantity.Text = "Reorder Retail Quantity:"
        Me.XrLabelHeaderReorderRetailQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelNewRetailQuantity
        '
        Me.XrLabelNewRetailQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NewRetailQuantity, {0:n2}")})
        Me.XrLabelNewRetailQuantity.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelNewRetailQuantity.LocationFloat = New DevExpress.Utils.PointFloat(113!, 104!)
        Me.XrLabelNewRetailQuantity.Name = "XrLabelNewRetailQuantity"
        Me.XrLabelNewRetailQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelNewRetailQuantity.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelNewRetailQuantity.StylePriority.UseFont = false
        Me.XrLabelNewRetailQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelNewRetailQuantity.Text = "XrLabelNewRetailQuantity"
        Me.XrLabelNewRetailQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderNewRetailQuantity
        '
        Me.XrLabelHeaderNewRetailQuantity.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderNewRetailQuantity.LocationFloat = New DevExpress.Utils.PointFloat(13!, 104!)
        Me.XrLabelHeaderNewRetailQuantity.Name = "XrLabelHeaderNewRetailQuantity"
        Me.XrLabelHeaderNewRetailQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderNewRetailQuantity.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderNewRetailQuantity.StylePriority.UseFont = false
        Me.XrLabelHeaderNewRetailQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderNewRetailQuantity.Text = "New Retail Quantity:"
        Me.XrLabelHeaderNewRetailQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelCurrentWholesaleQuantity
        '
        Me.XrLabelCurrentWholesaleQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CurrentWholesaleQuantity, {0:n2}")})
        Me.XrLabelCurrentWholesaleQuantity.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelCurrentWholesaleQuantity.LocationFloat = New DevExpress.Utils.PointFloat(113!, 130!)
        Me.XrLabelCurrentWholesaleQuantity.Name = "XrLabelCurrentWholesaleQuantity"
        Me.XrLabelCurrentWholesaleQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelCurrentWholesaleQuantity.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelCurrentWholesaleQuantity.StylePriority.UseFont = false
        Me.XrLabelCurrentWholesaleQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelCurrentWholesaleQuantity.Text = "XrLabelCurrentWholesaleQuantity"
        Me.XrLabelCurrentWholesaleQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderCurrentWholesaleQuantity
        '
        Me.XrLabelHeaderCurrentWholesaleQuantity.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderCurrentWholesaleQuantity.LocationFloat = New DevExpress.Utils.PointFloat(13!, 130!)
        Me.XrLabelHeaderCurrentWholesaleQuantity.Name = "XrLabelHeaderCurrentWholesaleQuantity"
        Me.XrLabelHeaderCurrentWholesaleQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderCurrentWholesaleQuantity.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderCurrentWholesaleQuantity.StylePriority.UseFont = false
        Me.XrLabelHeaderCurrentWholesaleQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderCurrentWholesaleQuantity.Text = "Current Wholesale Quantity:"
        Me.XrLabelHeaderCurrentWholesaleQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelReorderWholesaleQuantity
        '
        Me.XrLabelReorderWholesaleQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ReorderWholesaleQuantity, {0:n2}")})
        Me.XrLabelReorderWholesaleQuantity.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelReorderWholesaleQuantity.LocationFloat = New DevExpress.Utils.PointFloat(113!, 156!)
        Me.XrLabelReorderWholesaleQuantity.Name = "XrLabelReorderWholesaleQuantity"
        Me.XrLabelReorderWholesaleQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelReorderWholesaleQuantity.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelReorderWholesaleQuantity.StylePriority.UseFont = false
        Me.XrLabelReorderWholesaleQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelReorderWholesaleQuantity.Text = "XrLabelReorderWholesaleQuantity"
        Me.XrLabelReorderWholesaleQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderReorderWholesaleQuantity
        '
        Me.XrLabelHeaderReorderWholesaleQuantity.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderReorderWholesaleQuantity.LocationFloat = New DevExpress.Utils.PointFloat(13!, 156!)
        Me.XrLabelHeaderReorderWholesaleQuantity.Name = "XrLabelHeaderReorderWholesaleQuantity"
        Me.XrLabelHeaderReorderWholesaleQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderReorderWholesaleQuantity.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderReorderWholesaleQuantity.StylePriority.UseFont = false
        Me.XrLabelHeaderReorderWholesaleQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderReorderWholesaleQuantity.Text = "Reorder Wholesale Quantity:"
        Me.XrLabelHeaderReorderWholesaleQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelNewWholesaleQuantity
        '
        Me.XrLabelNewWholesaleQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NewWholesaleQuantity, {0:n2}")})
        Me.XrLabelNewWholesaleQuantity.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelNewWholesaleQuantity.LocationFloat = New DevExpress.Utils.PointFloat(113!, 182!)
        Me.XrLabelNewWholesaleQuantity.Name = "XrLabelNewWholesaleQuantity"
        Me.XrLabelNewWholesaleQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelNewWholesaleQuantity.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelNewWholesaleQuantity.StylePriority.UseFont = false
        Me.XrLabelNewWholesaleQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelNewWholesaleQuantity.Text = "XrLabelNewWholesaleQuantity"
        Me.XrLabelNewWholesaleQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderNewWholesaleQuantity
        '
        Me.XrLabelHeaderNewWholesaleQuantity.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderNewWholesaleQuantity.LocationFloat = New DevExpress.Utils.PointFloat(13!, 182!)
        Me.XrLabelHeaderNewWholesaleQuantity.Name = "XrLabelHeaderNewWholesaleQuantity"
        Me.XrLabelHeaderNewWholesaleQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderNewWholesaleQuantity.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderNewWholesaleQuantity.StylePriority.UseFont = false
        Me.XrLabelHeaderNewWholesaleQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderNewWholesaleQuantity.Text = "New Wholesale Quantity:"
        Me.XrLabelHeaderNewWholesaleQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelReorderDate
        '
        Me.XrLabelReorderDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ReorderDate, {0:dd/MM/yyyy}")})
        Me.XrLabelReorderDate.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelReorderDate.LocationFloat = New DevExpress.Utils.PointFloat(113!, 208!)
        Me.XrLabelReorderDate.Name = "XrLabelReorderDate"
        Me.XrLabelReorderDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelReorderDate.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelReorderDate.StylePriority.UseFont = false
        Me.XrLabelReorderDate.StylePriority.UseTextAlignment = false
        Me.XrLabelReorderDate.Text = "XrLabelReorderDate"
        Me.XrLabelReorderDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderReorderDate
        '
        Me.XrLabelHeaderReorderDate.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderReorderDate.LocationFloat = New DevExpress.Utils.PointFloat(13!, 208!)
        Me.XrLabelHeaderReorderDate.Name = "XrLabelHeaderReorderDate"
        Me.XrLabelHeaderReorderDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderReorderDate.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderReorderDate.StylePriority.UseFont = false
        Me.XrLabelHeaderReorderDate.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderReorderDate.Text = "Reorder Date:"
        Me.XrLabelHeaderReorderDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelRorderSource
        '
        Me.XrLabelRorderSource.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RorderSource")})
        Me.XrLabelRorderSource.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelRorderSource.LocationFloat = New DevExpress.Utils.PointFloat(113!, 234!)
        Me.XrLabelRorderSource.Name = "XrLabelRorderSource"
        Me.XrLabelRorderSource.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelRorderSource.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelRorderSource.StylePriority.UseFont = false
        Me.XrLabelRorderSource.StylePriority.UseTextAlignment = false
        Me.XrLabelRorderSource.Text = "XrLabelRorderSource"
        Me.XrLabelRorderSource.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRorderSource
        '
        Me.XrLabelHeaderRorderSource.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRorderSource.LocationFloat = New DevExpress.Utils.PointFloat(13!, 234!)
        Me.XrLabelHeaderRorderSource.Name = "XrLabelHeaderRorderSource"
        Me.XrLabelHeaderRorderSource.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderRorderSource.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderRorderSource.StylePriority.UseFont = false
        Me.XrLabelHeaderRorderSource.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderRorderSource.Text = "Rorder Source:"
        Me.XrLabelHeaderRorderSource.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelSupervisor
        '
        Me.XrLabelSupervisor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Supervisor")})
        Me.XrLabelSupervisor.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelSupervisor.LocationFloat = New DevExpress.Utils.PointFloat(113!, 260!)
        Me.XrLabelSupervisor.Name = "XrLabelSupervisor"
        Me.XrLabelSupervisor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelSupervisor.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelSupervisor.StylePriority.UseFont = false
        Me.XrLabelSupervisor.StylePriority.UseTextAlignment = false
        Me.XrLabelSupervisor.Text = "XrLabelSupervisor"
        Me.XrLabelSupervisor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderSupervisor
        '
        Me.XrLabelHeaderSupervisor.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderSupervisor.LocationFloat = New DevExpress.Utils.PointFloat(13!, 260!)
        Me.XrLabelHeaderSupervisor.Name = "XrLabelHeaderSupervisor"
        Me.XrLabelHeaderSupervisor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderSupervisor.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderSupervisor.StylePriority.UseFont = false
        Me.XrLabelHeaderSupervisor.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderSupervisor.Text = "Supervisor:"
        Me.XrLabelHeaderSupervisor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelComment
        '
        Me.XrLabelComment.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Comment")})
        Me.XrLabelComment.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelComment.LocationFloat = New DevExpress.Utils.PointFloat(113!, 286!)
        Me.XrLabelComment.Name = "XrLabelComment"
        Me.XrLabelComment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelComment.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelComment.StylePriority.UseFont = false
        Me.XrLabelComment.StylePriority.UseTextAlignment = false
        Me.XrLabelComment.Text = "XrLabelComment"
        Me.XrLabelComment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderComment
        '
        Me.XrLabelHeaderComment.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderComment.LocationFloat = New DevExpress.Utils.PointFloat(13!, 286!)
        Me.XrLabelHeaderComment.Name = "XrLabelHeaderComment"
        Me.XrLabelHeaderComment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderComment.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderComment.StylePriority.UseFont = false
        Me.XrLabelHeaderComment.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderComment.Text = "Comment:"
        Me.XrLabelHeaderComment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelRegDate
        '
        Me.XrLabelRegDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RegDate")})
        Me.XrLabelRegDate.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelRegDate.LocationFloat = New DevExpress.Utils.PointFloat(113!, 312!)
        Me.XrLabelRegDate.Name = "XrLabelRegDate"
        Me.XrLabelRegDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelRegDate.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelRegDate.StylePriority.UseFont = false
        Me.XrLabelRegDate.StylePriority.UseTextAlignment = false
        Me.XrLabelRegDate.Text = "XrLabelRegDate"
        Me.XrLabelRegDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRegDate
        '
        Me.XrLabelHeaderRegDate.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRegDate.LocationFloat = New DevExpress.Utils.PointFloat(13!, 312!)
        Me.XrLabelHeaderRegDate.Name = "XrLabelHeaderRegDate"
        Me.XrLabelHeaderRegDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderRegDate.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderRegDate.StylePriority.UseFont = false
        Me.XrLabelHeaderRegDate.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderRegDate.Text = "Reg Date:"
        Me.XrLabelHeaderRegDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelInputedBy
        '
        Me.XrLabelInputedBy.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InputedBy")})
        Me.XrLabelInputedBy.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelInputedBy.LocationFloat = New DevExpress.Utils.PointFloat(113!, 338!)
        Me.XrLabelInputedBy.Name = "XrLabelInputedBy"
        Me.XrLabelInputedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelInputedBy.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelInputedBy.StylePriority.UseFont = false
        Me.XrLabelInputedBy.StylePriority.UseTextAlignment = false
        Me.XrLabelInputedBy.Text = "XrLabelInputedBy"
        Me.XrLabelInputedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderInputedBy
        '
        Me.XrLabelHeaderInputedBy.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderInputedBy.LocationFloat = New DevExpress.Utils.PointFloat(13!, 338!)
        Me.XrLabelHeaderInputedBy.Name = "XrLabelHeaderInputedBy"
        Me.XrLabelHeaderInputedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderInputedBy.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderInputedBy.StylePriority.UseFont = false
        Me.XrLabelHeaderInputedBy.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderInputedBy.Text = "Inputed By:"
        Me.XrLabelHeaderInputedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XtraReportStockReorderMultiple
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.CompanySettingsDataSource, Me.StockReorderDataSource})
        Me.DataSource = Me.StockReorderDataSource
        Me.Margins = New System.Drawing.Printing.Margins(41, 60, 31, 25)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None
        Me.Version = "17.1"
        CType(Me.CompanySettingsDataSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.StockReorderDataSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit


End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Public WithEvents CompanySettingsDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Public WithEvents StockReorderDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Public WithEvents XrLabelReportTitle As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportDateCriteria As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportDateField As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportCriteriaLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelReorderID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderReorderID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelStockID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderStockID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelCurrentRetailQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderCurrentRetailQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelReorderRetailQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderReorderRetailQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelNewRetailQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderNewRetailQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelCurrentWholesaleQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderCurrentWholesaleQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelReorderWholesaleQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderReorderWholesaleQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelNewWholesaleQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderNewWholesaleQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelReorderDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderReorderDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRorderSource As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRorderSource As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelSupervisor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderSupervisor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRegDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRegDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelInputedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderInputedBy As DevExpress.XtraReports.UI.XRLabel
End Class

