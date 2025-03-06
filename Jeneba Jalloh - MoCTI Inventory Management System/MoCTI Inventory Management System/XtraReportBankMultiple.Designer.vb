<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReportBankMultiple
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.CompanySettingsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.BankDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelReportTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrlblTotalNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrSummaryTotalNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelReportCriteriaLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabelReportDateCriteria = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelReportDateField = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelBankAccountID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderBankAccountID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelNameOfBank = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderNameOfBank = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelAccountName = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderAccountName = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelAccountNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderAccountNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        CType(Me.CompanySettingsDataSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BankDataSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLabelBankAccountID,Me.XrLabelNameOfBank,Me.XrLabelAccountName,Me.XrLabelAccountNo,Me.XrLabelAddress,Me.XrLabelComment})
        Me.Detail.HeightF = 30.42868!
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
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLabelHeaderBankAccountID, Me.XrLabelHeaderNameOfBank, Me.XrLabelHeaderAccountName, Me.XrLabelHeaderAccountNo, Me.XrLabelHeaderAddress, Me.XrLabelHeaderComment})
        Me.PageHeader.HeightF = 46.43748!
        Me.PageHeader.Name = "PageHeader"
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSummaryTotalNo, Me.XrlblTotalNo})
        Me.ReportFooter.HeightF = 19.79167!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrSummaryTotalNo
        '
        Me.XrSummaryTotalNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BankAccountID")})
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
        'BankDataSource
        '
        Me.BankDataSource.DataSource = GetType(MoCTIMIS.BankTable.BankTableDataTable)
        Me.BankDataSource.Name = "BankDataSource"
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
        'XrLabelBankAccountID
        '
        Me.XrLabelBankAccountID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BankAccountID, {0:#,#}")})
        Me.XrLabelBankAccountID.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelBankAccountID.LocationFloat = New DevExpress.Utils.PointFloat(13!, 0!)
        Me.XrLabelBankAccountID.Name = "XrLabelBankAccountID"
        Me.XrLabelBankAccountID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelBankAccountID.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelBankAccountID.StylePriority.UseFont = false
        Me.XrLabelBankAccountID.StylePriority.UseTextAlignment = false
        Me.XrLabelBankAccountID.Text = "XrLabelBankAccountID"
        Me.XrLabelBankAccountID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderBankAccountID
        '
        Me.XrLabelHeaderBankAccountID.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderBankAccountID.LocationFloat = New DevExpress.Utils.PointFloat(13!, 17.14183!)
        Me.XrLabelHeaderBankAccountID.Name = "XrLabelHeaderBankAccountID"
        Me.XrLabelHeaderBankAccountID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderBankAccountID.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderBankAccountID.StylePriority.UseFont = false
        Me.XrLabelHeaderBankAccountID.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderBankAccountID.Text = "Bank Account ID"
        Me.XrLabelHeaderBankAccountID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelNameOfBank
        '
        Me.XrLabelNameOfBank.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NameOfBank")})
        Me.XrLabelNameOfBank.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelNameOfBank.LocationFloat = New DevExpress.Utils.PointFloat(113!, 0!)
        Me.XrLabelNameOfBank.Name = "XrLabelNameOfBank"
        Me.XrLabelNameOfBank.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelNameOfBank.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelNameOfBank.StylePriority.UseFont = false
        Me.XrLabelNameOfBank.StylePriority.UseTextAlignment = false
        Me.XrLabelNameOfBank.Text = "XrLabelNameOfBank"
        Me.XrLabelNameOfBank.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderNameOfBank
        '
        Me.XrLabelHeaderNameOfBank.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderNameOfBank.LocationFloat = New DevExpress.Utils.PointFloat(113!, 17.14183!)
        Me.XrLabelHeaderNameOfBank.Name = "XrLabelHeaderNameOfBank"
        Me.XrLabelHeaderNameOfBank.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderNameOfBank.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderNameOfBank.StylePriority.UseFont = false
        Me.XrLabelHeaderNameOfBank.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderNameOfBank.Text = "Name Of Bank"
        Me.XrLabelHeaderNameOfBank.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelAccountName
        '
        Me.XrLabelAccountName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AccountName")})
        Me.XrLabelAccountName.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelAccountName.LocationFloat = New DevExpress.Utils.PointFloat(226!, 0!)
        Me.XrLabelAccountName.Name = "XrLabelAccountName"
        Me.XrLabelAccountName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelAccountName.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelAccountName.StylePriority.UseFont = false
        Me.XrLabelAccountName.StylePriority.UseTextAlignment = false
        Me.XrLabelAccountName.Text = "XrLabelAccountName"
        Me.XrLabelAccountName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderAccountName
        '
        Me.XrLabelHeaderAccountName.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderAccountName.LocationFloat = New DevExpress.Utils.PointFloat(226!, 17.14183!)
        Me.XrLabelHeaderAccountName.Name = "XrLabelHeaderAccountName"
        Me.XrLabelHeaderAccountName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderAccountName.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderAccountName.StylePriority.UseFont = false
        Me.XrLabelHeaderAccountName.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderAccountName.Text = "Account Name"
        Me.XrLabelHeaderAccountName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelAccountNo
        '
        Me.XrLabelAccountNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AccountNo")})
        Me.XrLabelAccountNo.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelAccountNo.LocationFloat = New DevExpress.Utils.PointFloat(339!, 0!)
        Me.XrLabelAccountNo.Name = "XrLabelAccountNo"
        Me.XrLabelAccountNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelAccountNo.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelAccountNo.StylePriority.UseFont = false
        Me.XrLabelAccountNo.StylePriority.UseTextAlignment = false
        Me.XrLabelAccountNo.Text = "XrLabelAccountNo"
        Me.XrLabelAccountNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderAccountNo
        '
        Me.XrLabelHeaderAccountNo.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderAccountNo.LocationFloat = New DevExpress.Utils.PointFloat(339!, 17.14183!)
        Me.XrLabelHeaderAccountNo.Name = "XrLabelHeaderAccountNo"
        Me.XrLabelHeaderAccountNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderAccountNo.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderAccountNo.StylePriority.UseFont = false
        Me.XrLabelHeaderAccountNo.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderAccountNo.Text = "Account No"
        Me.XrLabelHeaderAccountNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelAddress
        '
        Me.XrLabelAddress.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Address")})
        Me.XrLabelAddress.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelAddress.LocationFloat = New DevExpress.Utils.PointFloat(452!, 0!)
        Me.XrLabelAddress.Name = "XrLabelAddress"
        Me.XrLabelAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96!)
        Me.XrLabelAddress.SizeF = New System.Drawing.SizeF(100!, 23!)
        Me.XrLabelAddress.StylePriority.UseFont = false
        Me.XrLabelAddress.StylePriority.UseTextAlignment = false
        Me.XrLabelAddress.Text = "XrLabelAddress"
        Me.XrLabelAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderAddress
        '
        Me.XrLabelHeaderAddress.Font = New System.Drawing.Font("Times New Roman", 11!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderAddress.LocationFloat = New DevExpress.Utils.PointFloat(452!, 17.14183!)
        Me.XrLabelHeaderAddress.Name = "XrLabelHeaderAddress"
        Me.XrLabelHeaderAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderAddress.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderAddress.StylePriority.UseFont = false
        Me.XrLabelHeaderAddress.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderAddress.Text = "Address"
        Me.XrLabelHeaderAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelComment
        '
        Me.XrLabelComment.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Comment")})
        Me.XrLabelComment.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabelComment.LocationFloat = New DevExpress.Utils.PointFloat(565!, 0!)
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
        Me.XrLabelHeaderComment.LocationFloat = New DevExpress.Utils.PointFloat(565!, 17.14183!)
        Me.XrLabelHeaderComment.Name = "XrLabelHeaderComment"
        Me.XrLabelHeaderComment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelHeaderComment.SizeF = New System.Drawing.SizeF(100.0!, 23!)
        Me.XrLabelHeaderComment.StylePriority.UseFont = false
        Me.XrLabelHeaderComment.StylePriority.UseTextAlignment = false
        Me.XrLabelHeaderComment.Text = "Comment"
        Me.XrLabelHeaderComment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(14.88942!, 42.36779!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(723.8582!, 2.70433!)
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(13.08654!, 26.14183!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(722.9567!, 2!)
        '
        'XtraReportBankMultiple
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.CompanySettingsDataSource, Me.BankDataSource})
        Me.DataSource = Me.BankDataSource
        Me.Margins = New System.Drawing.Printing.Margins(41, 60, 31, 25)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None
        Me.Version = "17.1"
        CType(Me.CompanySettingsDataSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BankDataSource,System.ComponentModel.ISupportInitialize).EndInit
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
    Public WithEvents BankDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Public WithEvents XrLabelReportTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Public WithEvents XrLabelReportDateCriteria As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportDateField As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportCriteriaLabel As DevExpress.XtraReports.UI.XRLabel
   Friend WithEvents XrSummaryTotalNo As DevExpress.XtraReports.UI.XRLabel
   Friend WithEvents XrlblTotalNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelBankAccountID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderBankAccountID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelNameOfBank As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderNameOfBank As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelAccountName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderAccountName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelAccountNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderAccountNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderComment As DevExpress.XtraReports.UI.XRLabel
End Class

