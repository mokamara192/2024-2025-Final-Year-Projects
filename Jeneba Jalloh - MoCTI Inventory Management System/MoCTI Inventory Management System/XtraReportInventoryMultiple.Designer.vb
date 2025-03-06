<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReportInventoryMultiple
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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabelStockID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelNameOfItem = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRetailUnitOfMeasurement = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRetailQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.CompanySettingsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabelReportDateField = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelReportDateCriteria = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabelReportCriteriaLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelReportTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabelHeaderStockID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderNameOfItem = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRetailUnitOfMeasurement = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRetailQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrSummaryTotalNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrlblTotalNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.InventoryDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.GroupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLabelStockID, Me.XrLabelNameOfItem, Me.XrLabelRetailUnitOfMeasurement, Me.XrLabelRetailQuantity})
        Me.Detail.HeightF = 30.42868!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(13.08654!, 26.14183!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(722.9567!, 2.0!)
        '
        'XrLabelStockID
        '
        Me.XrLabelStockID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "StockID")})
        Me.XrLabelStockID.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelStockID.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 0!)
        Me.XrLabelStockID.Name = "XrLabelStockID"
        Me.XrLabelStockID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelStockID.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelStockID.StylePriority.UseFont = False
        Me.XrLabelStockID.StylePriority.UseTextAlignment = False
        Me.XrLabelStockID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabelStockID.TextFormatString = "{0:#,#}"
        '
        'XrLabelNameOfItem
        '
        Me.XrLabelNameOfItem.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NameOfItem")})
        Me.XrLabelNameOfItem.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelNameOfItem.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 0!)
        Me.XrLabelNameOfItem.Name = "XrLabelNameOfItem"
        Me.XrLabelNameOfItem.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelNameOfItem.SizeF = New System.Drawing.SizeF(315.625!, 23.0!)
        Me.XrLabelNameOfItem.StylePriority.UseFont = False
        Me.XrLabelNameOfItem.StylePriority.UseTextAlignment = False
        Me.XrLabelNameOfItem.Text = "XrLabelNameOfItem"
        Me.XrLabelNameOfItem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelRetailUnitOfMeasurement
        '
        Me.XrLabelRetailUnitOfMeasurement.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "WholesaleQuantity")})
        Me.XrLabelRetailUnitOfMeasurement.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelRetailUnitOfMeasurement.LocationFloat = New DevExpress.Utils.PointFloat(431.1667!, 0!)
        Me.XrLabelRetailUnitOfMeasurement.Name = "XrLabelRetailUnitOfMeasurement"
        Me.XrLabelRetailUnitOfMeasurement.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelRetailUnitOfMeasurement.SizeF = New System.Drawing.SizeF(120.8333!, 23.0!)
        Me.XrLabelRetailUnitOfMeasurement.StylePriority.UseFont = False
        Me.XrLabelRetailUnitOfMeasurement.StylePriority.UseTextAlignment = False
        Me.XrLabelRetailUnitOfMeasurement.Text = "XrLabelRetailUnitOfMeasurement"
        Me.XrLabelRetailUnitOfMeasurement.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabelRetailUnitOfMeasurement.TextFormatString = "{0:n2}"
        '
        'XrLabelRetailQuantity
        '
        Me.XrLabelRetailQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RetailQuantity")})
        Me.XrLabelRetailQuantity.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelRetailQuantity.LocationFloat = New DevExpress.Utils.PointFloat(565.0!, 0!)
        Me.XrLabelRetailQuantity.Name = "XrLabelRetailQuantity"
        Me.XrLabelRetailQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelRetailQuantity.SizeF = New System.Drawing.SizeF(105.2084!, 23.0!)
        Me.XrLabelRetailQuantity.StylePriority.UseFont = False
        Me.XrLabelRetailQuantity.StylePriority.UseTextAlignment = False
        Me.XrLabelRetailQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabelRetailQuantity.TextFormatString = "{0:n2}"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 31.11298!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 25.27318!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
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
        'XrLabelReportDateField
        '
        Me.XrLabelReportDateField.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabelReportDateField.LocationFloat = New DevExpress.Utils.PointFloat(526.2091!, 47.14343!)
        Me.XrLabelReportDateField.Name = "XrLabelReportDateField"
        Me.XrLabelReportDateField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelReportDateField.SizeF = New System.Drawing.SizeF(212.6666!, 23.0!)
        Me.XrLabelReportDateField.StylePriority.UseFont = False
        Me.XrLabelReportDateField.StylePriority.UseTextAlignment = False
        Me.XrLabelReportDateField.Text = "EmploymentDate"
        Me.XrLabelReportDateField.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelReportDateCriteria
        '
        Me.XrLabelReportDateCriteria.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelReportDateCriteria.LocationFloat = New DevExpress.Utils.PointFloat(419.0289!, 71.16827!)
        Me.XrLabelReportDateCriteria.Name = "XrLabelReportDateCriteria"
        Me.XrLabelReportDateCriteria.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelReportDateCriteria.SizeF = New System.Drawing.SizeF(319.2972!, 23.0!)
        Me.XrLabelReportDateCriteria.StylePriority.UseFont = False
        Me.XrLabelReportDateCriteria.StylePriority.UseTextAlignment = False
        Me.XrLabelReportDateCriteria.Text = "11/01/2018 - 30-01-2018"
        Me.XrLabelReportDateCriteria.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(516.2964!, 8.891042!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(220.8333!, 23.0!)
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrPageInfo2.TextFormatString = "{0:dd/MM/yyyy hh:mm:ss tt}"
        '
        'XrLabelReportCriteriaLabel
        '
        Me.XrLabelReportCriteriaLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabelReportCriteriaLabel.LocationFloat = New DevExpress.Utils.PointFloat(418.1674!, 47.1851!)
        Me.XrLabelReportCriteriaLabel.Name = "XrLabelReportCriteriaLabel"
        Me.XrLabelReportCriteriaLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelReportCriteriaLabel.SizeF = New System.Drawing.SizeF(107.4583!, 23.0!)
        Me.XrLabelReportCriteriaLabel.StylePriority.UseFont = False
        Me.XrLabelReportCriteriaLabel.StylePriority.UseTextAlignment = False
        Me.XrLabelReportCriteriaLabel.Text = "Report Criteria:"
        Me.XrLabelReportCriteriaLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(416.0008!, 8.713944!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(98.45834!, 23.0!)
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Print Date/Time:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "PhoneNo")})
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(109.4447!, 79.54568!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(288.4015!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "Email")})
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(109.625!, 56.12499!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(288.5417!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "Address")})
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(108.5833!, 33.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(289.5833!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.CompanySettingsDataSource, "Logo")})
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(9.999963!, 10.0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(93.95032!, 93.39261!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "NameofCompany")})
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(108.5833!, 10.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(289.5833!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelReportTitle
        '
        Me.XrLabelReportTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelReportTitle.LocationFloat = New DevExpress.Utils.PointFloat(145.5024!, 104.0817!)
        Me.XrLabelReportTitle.Name = "XrLabelReportTitle"
        Me.XrLabelReportTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelReportTitle.SizeF = New System.Drawing.SizeF(467.7885!, 27.99999!)
        Me.XrLabelReportTitle.StylePriority.UseFont = False
        Me.XrLabelReportTitle.StylePriority.UseTextAlignment = False
        Me.XrLabelReportTitle.Text = "Report Title"
        Me.XrLabelReportTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'PageHeader
        '
        Me.PageHeader.HeightF = 0!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(18.01443!, 60.07611!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(723.8582!, 2.70433!)
        '
        'XrLabelHeaderStockID
        '
        Me.XrLabelHeaderStockID.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderStockID.LocationFloat = New DevExpress.Utils.PointFloat(16.12501!, 34.85015!)
        Me.XrLabelHeaderStockID.Name = "XrLabelHeaderStockID"
        Me.XrLabelHeaderStockID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderStockID.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderStockID.StylePriority.UseFont = False
        Me.XrLabelHeaderStockID.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderStockID.Text = "Stock ID"
        Me.XrLabelHeaderStockID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderNameOfItem
        '
        Me.XrLabelHeaderNameOfItem.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderNameOfItem.LocationFloat = New DevExpress.Utils.PointFloat(116.125!, 34.85015!)
        Me.XrLabelHeaderNameOfItem.Name = "XrLabelHeaderNameOfItem"
        Me.XrLabelHeaderNameOfItem.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderNameOfItem.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderNameOfItem.StylePriority.UseFont = False
        Me.XrLabelHeaderNameOfItem.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderNameOfItem.Text = "Name Of Item"
        Me.XrLabelHeaderNameOfItem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRetailUnitOfMeasurement
        '
        Me.XrLabelHeaderRetailUnitOfMeasurement.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRetailUnitOfMeasurement.LocationFloat = New DevExpress.Utils.PointFloat(435.3334!, 34.85015!)
        Me.XrLabelHeaderRetailUnitOfMeasurement.Name = "XrLabelHeaderRetailUnitOfMeasurement"
        Me.XrLabelHeaderRetailUnitOfMeasurement.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderRetailUnitOfMeasurement.SizeF = New System.Drawing.SizeF(119.7917!, 23.0!)
        Me.XrLabelHeaderRetailUnitOfMeasurement.StylePriority.UseFont = False
        Me.XrLabelHeaderRetailUnitOfMeasurement.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderRetailUnitOfMeasurement.Text = "Wholesale Quantity"
        Me.XrLabelHeaderRetailUnitOfMeasurement.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRetailQuantity
        '
        Me.XrLabelHeaderRetailQuantity.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRetailQuantity.LocationFloat = New DevExpress.Utils.PointFloat(568.125!, 34.85015!)
        Me.XrLabelHeaderRetailQuantity.Name = "XrLabelHeaderRetailQuantity"
        Me.XrLabelHeaderRetailQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderRetailQuantity.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderRetailQuantity.StylePriority.UseFont = False
        Me.XrLabelHeaderRetailQuantity.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderRetailQuantity.Text = "Retail Quantity"
        Me.XrLabelHeaderRetailQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSummaryTotalNo, Me.XrlblTotalNo})
        Me.ReportFooter.HeightF = 32.29167!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrSummaryTotalNo
        '
        Me.XrSummaryTotalNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "StockID")})
        Me.XrSummaryTotalNo.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrSummaryTotalNo.LocationFloat = New DevExpress.Utils.PointFloat(91.16671!, 4.645824!)
        Me.XrSummaryTotalNo.Name = "XrSummaryTotalNo"
        Me.XrSummaryTotalNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrSummaryTotalNo.SizeF = New System.Drawing.SizeF(122.9167!, 23.0!)
        Me.XrSummaryTotalNo.StylePriority.UseFont = False
        Me.XrSummaryTotalNo.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:#,#}"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Count
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrSummaryTotalNo.Summary = XrSummary1
        Me.XrSummaryTotalNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrlblTotalNo
        '
        Me.XrlblTotalNo.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrlblTotalNo.LocationFloat = New DevExpress.Utils.PointFloat(16.16669!, 4.645824!)
        Me.XrlblTotalNo.Name = "XrlblTotalNo"
        Me.XrlblTotalNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrlblTotalNo.SizeF = New System.Drawing.SizeF(72.83334!, 23.0!)
        Me.XrlblTotalNo.StylePriority.UseFont = False
        Me.XrlblTotalNo.StylePriority.UseTextAlignment = False
        Me.XrlblTotalNo.Text = "Total No:"
        Me.XrlblTotalNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.PageFooter.HeightF = 32.29167!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(343.8197!, 4.72597!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrPageInfo1.TextFormatString = "Page {0} of {1}"
        '
        'InventoryDataSource
        '
        Me.InventoryDataSource.DataSource = GetType(MoCTIMIS.InventoryTable.InventoryTableDataTable)
        Me.InventoryDataSource.Name = "InventoryDataSource"
        '
        'GroupHeaderBand1
        '
        Me.GroupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrLabel5, Me.XrLine1, Me.XrLabelHeaderRetailQuantity, Me.XrLabelHeaderNameOfItem, Me.XrLabelHeaderRetailUnitOfMeasurement, Me.XrLabelHeaderStockID})
        Me.GroupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ItemCategory", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeaderBand1.HeightF = 65.625!
        Me.GroupHeaderBand1.Name = "GroupHeaderBand1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel9, Me.XrLabel7})
        Me.GroupFooter1.HeightF = 29.16667!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(16.12504!, 2.558486!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(82.29167!, 23.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Item Category:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ItemCategory")})
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(100.7916!, 1.041667!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(357.2917!, 23.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel6.TextFormatString = "{0}"
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "StockID")})
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(76.54165!, 0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Count
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel7.Summary = XrSummary2
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel7.TextFormatString = "{0:#,#}"
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(18.20838!, 0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(57.29167!, 23.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Total No:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XtraReportInventoryMultiple
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter, Me.GroupHeaderBand1, Me.GroupFooter1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.CompanySettingsDataSource, Me.InventoryDataSource})
        Me.DataSource = Me.InventoryDataSource
        Me.Margins = New System.Drawing.Printing.Margins(41, 60, 31, 25)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None
        Me.Version = "18.1"
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

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
    Public WithEvents InventoryDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Public WithEvents XrLabelReportTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Public WithEvents XrLabelReportDateCriteria As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportDateField As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportCriteriaLabel As DevExpress.XtraReports.UI.XRLabel
   Friend WithEvents XrSummaryTotalNo As DevExpress.XtraReports.UI.XRLabel
   Friend WithEvents XrlblTotalNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelStockID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderStockID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelNameOfItem As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderNameOfItem As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRetailUnitOfMeasurement As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRetailUnitOfMeasurement As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRetailQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRetailQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
End Class

