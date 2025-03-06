<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReportCurrencySetupSingle
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
        Me.CurrencySetupDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
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
        Me.XrLabelCurrency = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderCurrency = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelExchangeRate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderExchangeRate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelCurrencySymbol = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderCurrencySymbol = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.CompanySettingsDataSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CurrencySetupDataSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabelCurrency,Me.XrLabelExchangeRate,Me.XrLabelCurrencySymbol,Me.XrLabelHeaderCurrency,Me.XrLabelHeaderExchangeRate,Me.XrLabelHeaderCurrencySymbol})
        Me.Detail.HeightF = 108!
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
        'CurrencySetupDataSource
        '
        Me.CurrencySetupDataSource.DataSource = GetType(MoCTIMIS.CurrencySetupTable.CurrencySetupTableDataTable)
        Me.CurrencySetupDataSource.Name = "CurrencySetupDataSource"
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
        'XrLabelCurrency
        '
        Me.XrLabelCurrency.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Currency")})
        Me.XrLabelCurrency.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelCurrency.LocationFloat = New DevExpress.Utils.PointFloat(113!, 8!)
        Me.XrLabelCurrency.Name = "XrLabelCurrency"
        Me.XrLabelCurrency.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelCurrency.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelCurrency.StylePriority.UseFont = false
        Me.XrLabelCurrency.StylePriority.UseTextAlignment = false
        Me.XrLabelCurrency.Text = "XrLabelCurrency"
        Me.XrLabelCurrency.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderCurrency
        '
        Me.XrLabelHeaderCurrency.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderCurrency.LocationFloat = New DevExpress.Utils.PointFloat(13!, 8!)
        Me.XrLabelHeaderCurrency.Name = "XrLabelHeaderCurrency"
        Me.XrLabelHeaderCurrency.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderCurrency.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderCurrency.StylePriority.UseFont = false
        Me.XrLabelHeaderCurrency.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderCurrency.Text = "Currency:"
        Me.XrLabelHeaderCurrency.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelExchangeRate
        '
        Me.XrLabelExchangeRate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ExchangeRate, {0:n2}")})
        Me.XrLabelExchangeRate.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelExchangeRate.LocationFloat = New DevExpress.Utils.PointFloat(113!, 26!)
        Me.XrLabelExchangeRate.Name = "XrLabelExchangeRate"
        Me.XrLabelExchangeRate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelExchangeRate.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelExchangeRate.StylePriority.UseFont = false
        Me.XrLabelExchangeRate.StylePriority.UseTextAlignment = false
        Me.XrLabelExchangeRate.Text = "XrLabelExchangeRate"
        Me.XrLabelExchangeRate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderExchangeRate
        '
        Me.XrLabelHeaderExchangeRate.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderExchangeRate.LocationFloat = New DevExpress.Utils.PointFloat(13!, 26!)
        Me.XrLabelHeaderExchangeRate.Name = "XrLabelHeaderExchangeRate"
        Me.XrLabelHeaderExchangeRate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderExchangeRate.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderExchangeRate.StylePriority.UseFont = false
        Me.XrLabelHeaderExchangeRate.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderExchangeRate.Text = "Exchange Rate:"
        Me.XrLabelHeaderExchangeRate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelCurrencySymbol
        '
        Me.XrLabelCurrencySymbol.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CurrencySymbol")})
        Me.XrLabelCurrencySymbol.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelCurrencySymbol.LocationFloat = New DevExpress.Utils.PointFloat(113!, 52!)
        Me.XrLabelCurrencySymbol.Name = "XrLabelCurrencySymbol"
        Me.XrLabelCurrencySymbol.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelCurrencySymbol.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelCurrencySymbol.StylePriority.UseFont = false
        Me.XrLabelCurrencySymbol.StylePriority.UseTextAlignment = false
        Me.XrLabelCurrencySymbol.Text = "XrLabelCurrencySymbol"
        Me.XrLabelCurrencySymbol.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderCurrencySymbol
        '
        Me.XrLabelHeaderCurrencySymbol.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderCurrencySymbol.LocationFloat = New DevExpress.Utils.PointFloat(13!, 52!)
        Me.XrLabelHeaderCurrencySymbol.Name = "XrLabelHeaderCurrencySymbol"
        Me.XrLabelHeaderCurrencySymbol.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderCurrencySymbol.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderCurrencySymbol.StylePriority.UseFont = false
        Me.XrLabelHeaderCurrencySymbol.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderCurrencySymbol.Text = "Currency Symbol:"
        Me.XrLabelHeaderCurrencySymbol.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XtraReportCurrencySetupMultiple
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.CompanySettingsDataSource, Me.CurrencySetupDataSource})
        Me.DataSource = Me.CurrencySetupDataSource
        Me.Margins = New System.Drawing.Printing.Margins(41, 60, 31, 25)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None
        Me.Version = "17.1"
        CType(Me.CompanySettingsDataSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CurrencySetupDataSource,System.ComponentModel.ISupportInitialize).EndInit
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
    Public WithEvents CurrencySetupDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Public WithEvents XrLabelReportTitle As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportDateCriteria As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportDateField As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportCriteriaLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelCurrency As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderCurrency As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelExchangeRate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderExchangeRate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelCurrencySymbol As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderCurrencySymbol As DevExpress.XtraReports.UI.XRLabel
End Class

