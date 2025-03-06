<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReportGeneralSalesItemsSingle
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
        Me.GeneralSalesItemsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
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
        Me.XrLabelItemID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderItemID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelGPaymentID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderGPaymentID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelStockID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderStockID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelWholesaleQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderWholesaleQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelWholesaleUnitCost = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderWholesaleUnitCost = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelWholesaleTotalCost = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderWholesaleTotalCost = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRetailQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRetailQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRetailUnitCost = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRetailUnitCost = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRetailTotalCost = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRetailTotalCost = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRegDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRegDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelInputtedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderInputtedBy = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.CompanySettingsDataSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GeneralSalesItemsDataSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabelItemID,Me.XrLabelGPaymentID,Me.XrLabelStockID,Me.XrLabelWholesaleQuantity,Me.XrLabelWholesaleUnitCost,Me.XrLabelWholesaleTotalCost,Me.XrLabelRetailQuantity,Me.XrLabelRetailUnitCost,Me.XrLabelRetailTotalCost,Me.XrLabelComment,Me.XrLabelRegDate,Me.XrLabelInputtedBy,Me.XrLabelHeaderItemID,Me.XrLabelHeaderGPaymentID,Me.XrLabelHeaderStockID,Me.XrLabelHeaderWholesaleQuantity,Me.XrLabelHeaderWholesaleUnitCost,Me.XrLabelHeaderWholesaleTotalCost,Me.XrLabelHeaderRetailQuantity,Me.XrLabelHeaderRetailUnitCost,Me.XrLabelHeaderRetailTotalCost,Me.XrLabelHeaderComment,Me.XrLabelHeaderRegDate,Me.XrLabelHeaderInputtedBy})
        Me.Detail.HeightF = 432!
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
        'GeneralSalesItemsDataSource
        '
        Me.GeneralSalesItemsDataSource.DataSource = GetType(MoCTIMIS._GeneralSalesItemsTable.GeneralSalesItemsTableDataTable)
        Me.GeneralSalesItemsDataSource.Name = "GeneralSalesItemsDataSource"
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
        'XrLabelItemID
        '
        Me.XrLabelItemID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ItemID")})
        Me.XrLabelItemID.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelItemID.LocationFloat = New DevExpress.Utils.PointFloat(113!, 8!)
        Me.XrLabelItemID.Name = "XrLabelItemID"
        Me.XrLabelItemID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelItemID.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelItemID.StylePriority.UseFont = false
        Me.XrLabelItemID.StylePriority.UseTextAlignment = false
        Me.XrLabelItemID.Text = "XrLabelItemID"
        Me.XrLabelItemID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderItemID
        '
        Me.XrLabelHeaderItemID.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderItemID.LocationFloat = New DevExpress.Utils.PointFloat(13!, 8!)
        Me.XrLabelHeaderItemID.Name = "XrLabelHeaderItemID"
        Me.XrLabelHeaderItemID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderItemID.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderItemID.StylePriority.UseFont = false
        Me.XrLabelHeaderItemID.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderItemID.Text = "Item ID:"
        Me.XrLabelHeaderItemID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelGPaymentID
        '
        Me.XrLabelGPaymentID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GPaymentID")})
        Me.XrLabelGPaymentID.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelGPaymentID.LocationFloat = New DevExpress.Utils.PointFloat(113!, 26!)
        Me.XrLabelGPaymentID.Name = "XrLabelGPaymentID"
        Me.XrLabelGPaymentID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelGPaymentID.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelGPaymentID.StylePriority.UseFont = false
        Me.XrLabelGPaymentID.StylePriority.UseTextAlignment = false
        Me.XrLabelGPaymentID.Text = "XrLabelGPaymentID"
        Me.XrLabelGPaymentID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderGPaymentID
        '
        Me.XrLabelHeaderGPaymentID.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderGPaymentID.LocationFloat = New DevExpress.Utils.PointFloat(13!, 26!)
        Me.XrLabelHeaderGPaymentID.Name = "XrLabelHeaderGPaymentID"
        Me.XrLabelHeaderGPaymentID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderGPaymentID.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderGPaymentID.StylePriority.UseFont = false
        Me.XrLabelHeaderGPaymentID.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderGPaymentID.Text = "GPayment ID:"
        Me.XrLabelHeaderGPaymentID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelStockID
        '
        Me.XrLabelStockID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "StockID, {0:#,#}")})
        Me.XrLabelStockID.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelStockID.LocationFloat = New DevExpress.Utils.PointFloat(113!, 52!)
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
        Me.XrLabelHeaderStockID.LocationFloat = New DevExpress.Utils.PointFloat(13!, 52!)
        Me.XrLabelHeaderStockID.Name = "XrLabelHeaderStockID"
        Me.XrLabelHeaderStockID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderStockID.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderStockID.StylePriority.UseFont = false
        Me.XrLabelHeaderStockID.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderStockID.Text = "Stock ID:"
        Me.XrLabelHeaderStockID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelWholesaleQuantity
        '
        Me.XrLabelWholesaleQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "WholesaleQuantity, {0:n2}")})
        Me.XrLabelWholesaleQuantity.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelWholesaleQuantity.LocationFloat = New DevExpress.Utils.PointFloat(113!, 78!)
        Me.XrLabelWholesaleQuantity.Name = "XrLabelWholesaleQuantity"
        Me.XrLabelWholesaleQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelWholesaleQuantity.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelWholesaleQuantity.StylePriority.UseFont = false
        Me.XrLabelWholesaleQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelWholesaleQuantity.Text = "XrLabelWholesaleQuantity"
        Me.XrLabelWholesaleQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderWholesaleQuantity
        '
        Me.XrLabelHeaderWholesaleQuantity.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderWholesaleQuantity.LocationFloat = New DevExpress.Utils.PointFloat(13!, 78!)
        Me.XrLabelHeaderWholesaleQuantity.Name = "XrLabelHeaderWholesaleQuantity"
        Me.XrLabelHeaderWholesaleQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderWholesaleQuantity.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderWholesaleQuantity.StylePriority.UseFont = false
        Me.XrLabelHeaderWholesaleQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderWholesaleQuantity.Text = "Wholesale Quantity:"
        Me.XrLabelHeaderWholesaleQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelWholesaleUnitCost
        '
        Me.XrLabelWholesaleUnitCost.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "WholesaleUnitCost, {0:n2}")})
        Me.XrLabelWholesaleUnitCost.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelWholesaleUnitCost.LocationFloat = New DevExpress.Utils.PointFloat(113!, 104!)
        Me.XrLabelWholesaleUnitCost.Name = "XrLabelWholesaleUnitCost"
        Me.XrLabelWholesaleUnitCost.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelWholesaleUnitCost.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelWholesaleUnitCost.StylePriority.UseFont = false
        Me.XrLabelWholesaleUnitCost.StylePriority.UseTextAlignment = false
        Me.XrLabelWholesaleUnitCost.Text = "XrLabelWholesaleUnitCost"
        Me.XrLabelWholesaleUnitCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderWholesaleUnitCost
        '
        Me.XrLabelHeaderWholesaleUnitCost.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderWholesaleUnitCost.LocationFloat = New DevExpress.Utils.PointFloat(13!, 104!)
        Me.XrLabelHeaderWholesaleUnitCost.Name = "XrLabelHeaderWholesaleUnitCost"
        Me.XrLabelHeaderWholesaleUnitCost.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderWholesaleUnitCost.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderWholesaleUnitCost.StylePriority.UseFont = false
        Me.XrLabelHeaderWholesaleUnitCost.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderWholesaleUnitCost.Text = "Wholesale Unit Cost:"
        Me.XrLabelHeaderWholesaleUnitCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelWholesaleTotalCost
        '
        Me.XrLabelWholesaleTotalCost.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "WholesaleTotalCost, {0:n2}")})
        Me.XrLabelWholesaleTotalCost.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelWholesaleTotalCost.LocationFloat = New DevExpress.Utils.PointFloat(113!, 130!)
        Me.XrLabelWholesaleTotalCost.Name = "XrLabelWholesaleTotalCost"
        Me.XrLabelWholesaleTotalCost.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelWholesaleTotalCost.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelWholesaleTotalCost.StylePriority.UseFont = false
        Me.XrLabelWholesaleTotalCost.StylePriority.UseTextAlignment = false
        Me.XrLabelWholesaleTotalCost.Text = "XrLabelWholesaleTotalCost"
        Me.XrLabelWholesaleTotalCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderWholesaleTotalCost
        '
        Me.XrLabelHeaderWholesaleTotalCost.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderWholesaleTotalCost.LocationFloat = New DevExpress.Utils.PointFloat(13!, 130!)
        Me.XrLabelHeaderWholesaleTotalCost.Name = "XrLabelHeaderWholesaleTotalCost"
        Me.XrLabelHeaderWholesaleTotalCost.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderWholesaleTotalCost.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderWholesaleTotalCost.StylePriority.UseFont = false
        Me.XrLabelHeaderWholesaleTotalCost.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderWholesaleTotalCost.Text = "Wholesale Total Cost:"
        Me.XrLabelHeaderWholesaleTotalCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelRetailQuantity
        '
        Me.XrLabelRetailQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RetailQuantity, {0:n2}")})
        Me.XrLabelRetailQuantity.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelRetailQuantity.LocationFloat = New DevExpress.Utils.PointFloat(113!, 156!)
        Me.XrLabelRetailQuantity.Name = "XrLabelRetailQuantity"
        Me.XrLabelRetailQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelRetailQuantity.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelRetailQuantity.StylePriority.UseFont = false
        Me.XrLabelRetailQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelRetailQuantity.Text = "XrLabelRetailQuantity"
        Me.XrLabelRetailQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRetailQuantity
        '
        Me.XrLabelHeaderRetailQuantity.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRetailQuantity.LocationFloat = New DevExpress.Utils.PointFloat(13!, 156!)
        Me.XrLabelHeaderRetailQuantity.Name = "XrLabelHeaderRetailQuantity"
        Me.XrLabelHeaderRetailQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderRetailQuantity.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderRetailQuantity.StylePriority.UseFont = false
        Me.XrLabelHeaderRetailQuantity.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderRetailQuantity.Text = "Retail Quantity:"
        Me.XrLabelHeaderRetailQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelRetailUnitCost
        '
        Me.XrLabelRetailUnitCost.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RetailUnitCost, {0:n2}")})
        Me.XrLabelRetailUnitCost.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelRetailUnitCost.LocationFloat = New DevExpress.Utils.PointFloat(113!, 182!)
        Me.XrLabelRetailUnitCost.Name = "XrLabelRetailUnitCost"
        Me.XrLabelRetailUnitCost.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelRetailUnitCost.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelRetailUnitCost.StylePriority.UseFont = false
        Me.XrLabelRetailUnitCost.StylePriority.UseTextAlignment = false
        Me.XrLabelRetailUnitCost.Text = "XrLabelRetailUnitCost"
        Me.XrLabelRetailUnitCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRetailUnitCost
        '
        Me.XrLabelHeaderRetailUnitCost.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRetailUnitCost.LocationFloat = New DevExpress.Utils.PointFloat(13!, 182!)
        Me.XrLabelHeaderRetailUnitCost.Name = "XrLabelHeaderRetailUnitCost"
        Me.XrLabelHeaderRetailUnitCost.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderRetailUnitCost.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderRetailUnitCost.StylePriority.UseFont = false
        Me.XrLabelHeaderRetailUnitCost.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderRetailUnitCost.Text = "Retail Unit Cost:"
        Me.XrLabelHeaderRetailUnitCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelRetailTotalCost
        '
        Me.XrLabelRetailTotalCost.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RetailTotalCost, {0:n2}")})
        Me.XrLabelRetailTotalCost.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelRetailTotalCost.LocationFloat = New DevExpress.Utils.PointFloat(113!, 208!)
        Me.XrLabelRetailTotalCost.Name = "XrLabelRetailTotalCost"
        Me.XrLabelRetailTotalCost.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelRetailTotalCost.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelRetailTotalCost.StylePriority.UseFont = false
        Me.XrLabelRetailTotalCost.StylePriority.UseTextAlignment = false
        Me.XrLabelRetailTotalCost.Text = "XrLabelRetailTotalCost"
        Me.XrLabelRetailTotalCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRetailTotalCost
        '
        Me.XrLabelHeaderRetailTotalCost.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRetailTotalCost.LocationFloat = New DevExpress.Utils.PointFloat(13!, 208!)
        Me.XrLabelHeaderRetailTotalCost.Name = "XrLabelHeaderRetailTotalCost"
        Me.XrLabelHeaderRetailTotalCost.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderRetailTotalCost.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderRetailTotalCost.StylePriority.UseFont = false
        Me.XrLabelHeaderRetailTotalCost.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderRetailTotalCost.Text = "Retail Total Cost:"
        Me.XrLabelHeaderRetailTotalCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelComment
        '
        Me.XrLabelComment.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Comment")})
        Me.XrLabelComment.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelComment.LocationFloat = New DevExpress.Utils.PointFloat(113!, 234!)
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
        Me.XrLabelHeaderComment.LocationFloat = New DevExpress.Utils.PointFloat(13!, 234!)
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
        Me.XrLabelRegDate.LocationFloat = New DevExpress.Utils.PointFloat(113!, 260!)
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
        Me.XrLabelHeaderRegDate.LocationFloat = New DevExpress.Utils.PointFloat(13!, 260!)
        Me.XrLabelHeaderRegDate.Name = "XrLabelHeaderRegDate"
        Me.XrLabelHeaderRegDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderRegDate.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderRegDate.StylePriority.UseFont = false
        Me.XrLabelHeaderRegDate.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderRegDate.Text = "Reg Date:"
        Me.XrLabelHeaderRegDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelInputtedBy
        '
        Me.XrLabelInputtedBy.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InputtedBy")})
        Me.XrLabelInputtedBy.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelInputtedBy.LocationFloat = New DevExpress.Utils.PointFloat(113!, 286!)
        Me.XrLabelInputtedBy.Name = "XrLabelInputtedBy"
        Me.XrLabelInputtedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelInputtedBy.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelInputtedBy.StylePriority.UseFont = false
        Me.XrLabelInputtedBy.StylePriority.UseTextAlignment = false
        Me.XrLabelInputtedBy.Text = "XrLabelInputtedBy"
        Me.XrLabelInputtedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderInputtedBy
        '
        Me.XrLabelHeaderInputtedBy.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderInputtedBy.LocationFloat = New DevExpress.Utils.PointFloat(13!, 286!)
        Me.XrLabelHeaderInputtedBy.Name = "XrLabelHeaderInputtedBy"
        Me.XrLabelHeaderInputtedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderInputtedBy.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderInputtedBy.StylePriority.UseFont = false
        Me.XrLabelHeaderInputtedBy.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderInputtedBy.Text = "Inputted By:"
        Me.XrLabelHeaderInputtedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XtraReportGeneralSalesItemsMultiple
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.CompanySettingsDataSource, Me.GeneralSalesItemsDataSource})
        Me.DataSource = Me.GeneralSalesItemsDataSource
        Me.Margins = New System.Drawing.Printing.Margins(41, 60, 31, 25)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None
        Me.Version = "17.1"
        CType(Me.CompanySettingsDataSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GeneralSalesItemsDataSource,System.ComponentModel.ISupportInitialize).EndInit
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
    Public WithEvents GeneralSalesItemsDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Public WithEvents XrLabelReportTitle As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportDateCriteria As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportDateField As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportCriteriaLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelItemID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderItemID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelGPaymentID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderGPaymentID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelStockID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderStockID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelWholesaleQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderWholesaleQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelWholesaleUnitCost As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderWholesaleUnitCost As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelWholesaleTotalCost As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderWholesaleTotalCost As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRetailQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRetailQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRetailUnitCost As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRetailUnitCost As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRetailTotalCost As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRetailTotalCost As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRegDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRegDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelInputtedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderInputtedBy As DevExpress.XtraReports.UI.XRLabel
End Class

