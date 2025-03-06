<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XtraReportTransferItemsSingle
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.TransferItemsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
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
        Me.XrLabelGeneratedTransferNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderGeneratedTransferNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelStockID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderStockID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelSalesCategory = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderSalesCategory = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelUnitCost = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderUnitCost = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelTotalCost = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderTotalCost = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRegDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRegDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelInputedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderInputedBy = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferItemsDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabelItemID, Me.XrLabelGeneratedTransferNo, Me.XrLabelStockID, Me.XrLabelSalesCategory, Me.XrLabelQuantity, Me.XrLabelUnitCost, Me.XrLabelTotalCost, Me.XrLabelComment, Me.XrLabelRegDate, Me.XrLabelInputedBy, Me.XrLabelHeaderItemID, Me.XrLabelHeaderGeneratedTransferNo, Me.XrLabelHeaderStockID, Me.XrLabelHeaderSalesCategory, Me.XrLabelHeaderQuantity, Me.XrLabelHeaderUnitCost, Me.XrLabelHeaderTotalCost, Me.XrLabelHeaderComment, Me.XrLabelHeaderRegDate, Me.XrLabelHeaderInputedBy})
        Me.Detail.HeightF = 360.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        'TransferItemsDataSource
        '
        Me.TransferItemsDataSource.DataSource = GetType(MoCTIMIS._TransferItemsTable.TransferItemsTableDataTable)
        Me.TransferItemsDataSource.Name = "TransferItemsDataSource"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "NameofCompany")})
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(108.5833!, 10.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(289.5833!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.CompanySettingsDataSource, "Logo")})
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(9.999963!, 10.0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(93.95032!, 93.39261!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "Address")})
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(108.5833!, 33.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(289.5833!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "Email")})
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(109.625!, 56.12499!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(288.5417!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "PhoneNo")})
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(109.4447!, 79.54568!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(288.4015!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelReportTitle
        '
        Me.XrLabelReportTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelReportTitle.LocationFloat = New DevExpress.Utils.PointFloat(145.5024!, 104.0817!)
        Me.XrLabelReportTitle.Name = "XrLabelReportTitle"
        Me.XrLabelReportTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelReportTitle.SizeF = New System.Drawing.SizeF(467.7885!, 27.99999!)
        Me.XrLabelReportTitle.StylePriority.UseFont = False
        Me.XrLabelReportTitle.StylePriority.UseTextAlignment = False
        Me.XrLabelReportTitle.Text = "Report Title"
        Me.XrLabelReportTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Format = "Page {0} of {1}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(343.8197!, 4.72597!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        'XrPageInfo2
        '
        Me.XrPageInfo2.Format = "{0:dd/MM/yyyy hh:mm:ss tt}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(516.2964!, 8.891042!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(220.8333!, 23.0!)
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        'XrLabelItemID
        '
        Me.XrLabelItemID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ItemID")})
        Me.XrLabelItemID.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelItemID.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 8.0!)
        Me.XrLabelItemID.Name = "XrLabelItemID"
        Me.XrLabelItemID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelItemID.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelItemID.StylePriority.UseFont = False
        Me.XrLabelItemID.StylePriority.UseTextAlignment = False
        Me.XrLabelItemID.Text = "XrLabelItemID"
        Me.XrLabelItemID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderItemID
        '
        Me.XrLabelHeaderItemID.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderItemID.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 8.0!)
        Me.XrLabelHeaderItemID.Name = "XrLabelHeaderItemID"
        Me.XrLabelHeaderItemID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderItemID.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderItemID.StylePriority.UseFont = False
        Me.XrLabelHeaderItemID.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderItemID.Text = "Item ID:"
        Me.XrLabelHeaderItemID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelGeneratedTransferNo
        '
        Me.XrLabelGeneratedTransferNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GeneratedTransferNo")})
        Me.XrLabelGeneratedTransferNo.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelGeneratedTransferNo.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 26.0!)
        Me.XrLabelGeneratedTransferNo.Name = "XrLabelGeneratedTransferNo"
        Me.XrLabelGeneratedTransferNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelGeneratedTransferNo.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelGeneratedTransferNo.StylePriority.UseFont = False
        Me.XrLabelGeneratedTransferNo.StylePriority.UseTextAlignment = False
        Me.XrLabelGeneratedTransferNo.Text = "XrLabelGeneratedTransferNo"
        Me.XrLabelGeneratedTransferNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderGeneratedTransferNo
        '
        Me.XrLabelHeaderGeneratedTransferNo.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderGeneratedTransferNo.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 26.0!)
        Me.XrLabelHeaderGeneratedTransferNo.Name = "XrLabelHeaderGeneratedTransferNo"
        Me.XrLabelHeaderGeneratedTransferNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderGeneratedTransferNo.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderGeneratedTransferNo.StylePriority.UseFont = False
        Me.XrLabelHeaderGeneratedTransferNo.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderGeneratedTransferNo.Text = "Generated Transfer No:"
        Me.XrLabelHeaderGeneratedTransferNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelStockID
        '
        Me.XrLabelStockID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "StockID, {0:#,#}")})
        Me.XrLabelStockID.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelStockID.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 52.0!)
        Me.XrLabelStockID.Name = "XrLabelStockID"
        Me.XrLabelStockID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelStockID.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelStockID.StylePriority.UseFont = False
        Me.XrLabelStockID.StylePriority.UseTextAlignment = False
        Me.XrLabelStockID.Text = "XrLabelStockID"
        Me.XrLabelStockID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderStockID
        '
        Me.XrLabelHeaderStockID.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderStockID.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 52.0!)
        Me.XrLabelHeaderStockID.Name = "XrLabelHeaderStockID"
        Me.XrLabelHeaderStockID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderStockID.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderStockID.StylePriority.UseFont = False
        Me.XrLabelHeaderStockID.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderStockID.Text = "Stock ID:"
        Me.XrLabelHeaderStockID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelSalesCategory
        '
        Me.XrLabelSalesCategory.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SalesCategory")})
        Me.XrLabelSalesCategory.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelSalesCategory.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 78.0!)
        Me.XrLabelSalesCategory.Name = "XrLabelSalesCategory"
        Me.XrLabelSalesCategory.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelSalesCategory.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelSalesCategory.StylePriority.UseFont = False
        Me.XrLabelSalesCategory.StylePriority.UseTextAlignment = False
        Me.XrLabelSalesCategory.Text = "XrLabelSalesCategory"
        Me.XrLabelSalesCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderSalesCategory
        '
        Me.XrLabelHeaderSalesCategory.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderSalesCategory.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 78.0!)
        Me.XrLabelHeaderSalesCategory.Name = "XrLabelHeaderSalesCategory"
        Me.XrLabelHeaderSalesCategory.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderSalesCategory.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderSalesCategory.StylePriority.UseFont = False
        Me.XrLabelHeaderSalesCategory.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderSalesCategory.Text = "Sales Category:"
        Me.XrLabelHeaderSalesCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelQuantity
        '
        Me.XrLabelQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Quantity, {0:n2}")})
        Me.XrLabelQuantity.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelQuantity.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 104.0!)
        Me.XrLabelQuantity.Name = "XrLabelQuantity"
        Me.XrLabelQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelQuantity.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelQuantity.StylePriority.UseFont = False
        Me.XrLabelQuantity.StylePriority.UseTextAlignment = False
        Me.XrLabelQuantity.Text = "XrLabelQuantity"
        Me.XrLabelQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderQuantity
        '
        Me.XrLabelHeaderQuantity.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderQuantity.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 104.0!)
        Me.XrLabelHeaderQuantity.Name = "XrLabelHeaderQuantity"
        Me.XrLabelHeaderQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderQuantity.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderQuantity.StylePriority.UseFont = False
        Me.XrLabelHeaderQuantity.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderQuantity.Text = "Quantity:"
        Me.XrLabelHeaderQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelUnitCost
        '
        Me.XrLabelUnitCost.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "UnitCost, {0:n2}")})
        Me.XrLabelUnitCost.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelUnitCost.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 130.0!)
        Me.XrLabelUnitCost.Name = "XrLabelUnitCost"
        Me.XrLabelUnitCost.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelUnitCost.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelUnitCost.StylePriority.UseFont = False
        Me.XrLabelUnitCost.StylePriority.UseTextAlignment = False
        Me.XrLabelUnitCost.Text = "XrLabelUnitCost"
        Me.XrLabelUnitCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderUnitCost
        '
        Me.XrLabelHeaderUnitCost.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderUnitCost.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 130.0!)
        Me.XrLabelHeaderUnitCost.Name = "XrLabelHeaderUnitCost"
        Me.XrLabelHeaderUnitCost.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderUnitCost.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderUnitCost.StylePriority.UseFont = False
        Me.XrLabelHeaderUnitCost.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderUnitCost.Text = "Unit Cost:"
        Me.XrLabelHeaderUnitCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelTotalCost
        '
        Me.XrLabelTotalCost.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalCost, {0:n2}")})
        Me.XrLabelTotalCost.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelTotalCost.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 156.0!)
        Me.XrLabelTotalCost.Name = "XrLabelTotalCost"
        Me.XrLabelTotalCost.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelTotalCost.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelTotalCost.StylePriority.UseFont = False
        Me.XrLabelTotalCost.StylePriority.UseTextAlignment = False
        Me.XrLabelTotalCost.Text = "XrLabelTotalCost"
        Me.XrLabelTotalCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderTotalCost
        '
        Me.XrLabelHeaderTotalCost.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderTotalCost.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 156.0!)
        Me.XrLabelHeaderTotalCost.Name = "XrLabelHeaderTotalCost"
        Me.XrLabelHeaderTotalCost.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderTotalCost.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderTotalCost.StylePriority.UseFont = False
        Me.XrLabelHeaderTotalCost.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderTotalCost.Text = "Total Cost:"
        Me.XrLabelHeaderTotalCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelComment
        '
        Me.XrLabelComment.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Comment")})
        Me.XrLabelComment.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelComment.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 182.0!)
        Me.XrLabelComment.Name = "XrLabelComment"
        Me.XrLabelComment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelComment.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelComment.StylePriority.UseFont = False
        Me.XrLabelComment.StylePriority.UseTextAlignment = False
        Me.XrLabelComment.Text = "XrLabelComment"
        Me.XrLabelComment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderComment
        '
        Me.XrLabelHeaderComment.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderComment.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 182.0!)
        Me.XrLabelHeaderComment.Name = "XrLabelHeaderComment"
        Me.XrLabelHeaderComment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderComment.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderComment.StylePriority.UseFont = False
        Me.XrLabelHeaderComment.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderComment.Text = "Comment:"
        Me.XrLabelHeaderComment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelRegDate
        '
        Me.XrLabelRegDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RegDate")})
        Me.XrLabelRegDate.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelRegDate.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 208.0!)
        Me.XrLabelRegDate.Name = "XrLabelRegDate"
        Me.XrLabelRegDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelRegDate.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelRegDate.StylePriority.UseFont = False
        Me.XrLabelRegDate.StylePriority.UseTextAlignment = False
        Me.XrLabelRegDate.Text = "XrLabelRegDate"
        Me.XrLabelRegDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRegDate
        '
        Me.XrLabelHeaderRegDate.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRegDate.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 208.0!)
        Me.XrLabelHeaderRegDate.Name = "XrLabelHeaderRegDate"
        Me.XrLabelHeaderRegDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderRegDate.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderRegDate.StylePriority.UseFont = False
        Me.XrLabelHeaderRegDate.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderRegDate.Text = "Reg Date:"
        Me.XrLabelHeaderRegDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelInputedBy
        '
        Me.XrLabelInputedBy.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InputedBy")})
        Me.XrLabelInputedBy.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelInputedBy.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 234.0!)
        Me.XrLabelInputedBy.Name = "XrLabelInputedBy"
        Me.XrLabelInputedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelInputedBy.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelInputedBy.StylePriority.UseFont = False
        Me.XrLabelInputedBy.StylePriority.UseTextAlignment = False
        Me.XrLabelInputedBy.Text = "XrLabelInputedBy"
        Me.XrLabelInputedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderInputedBy
        '
        Me.XrLabelHeaderInputedBy.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderInputedBy.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 234.0!)
        Me.XrLabelHeaderInputedBy.Name = "XrLabelHeaderInputedBy"
        Me.XrLabelHeaderInputedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderInputedBy.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderInputedBy.StylePriority.UseFont = False
        Me.XrLabelHeaderInputedBy.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderInputedBy.Text = "Inputed By:"
        Me.XrLabelHeaderInputedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XtraReportTransferItemsMultiple
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.CompanySettingsDataSource, Me.TransferItemsDataSource})
        Me.DataSource = Me.TransferItemsDataSource
        Me.Margins = New System.Drawing.Printing.Margins(41, 60, 31, 25)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None
        Me.Version = "17.1"
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferItemsDataSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public WithEvents TransferItemsDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Public WithEvents XrLabelReportTitle As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportDateCriteria As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportDateField As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportCriteriaLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelItemID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderItemID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelGeneratedTransferNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderGeneratedTransferNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelStockID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderStockID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelSalesCategory As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderSalesCategory As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelUnitCost As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderUnitCost As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelTotalCost As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderTotalCost As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRegDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRegDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelInputedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderInputedBy As DevExpress.XtraReports.UI.XRLabel
End Class

