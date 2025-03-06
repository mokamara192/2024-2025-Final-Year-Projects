<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XtraReportTransferOfficesMultiple
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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.CompanySettingsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.TransferOfficesDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
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
        Me.XrLabelOfficeID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderOfficeID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelGeneratedTransferNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderGeneratedTransferNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelNameOfOffice = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderNameOfOffice = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelResidentialAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderResidentialAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelPhoneNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderPhoneNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelEmailAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderEmailAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferOfficesDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLabelOfficeID, Me.XrLabelGeneratedTransferNo, Me.XrLabelNameOfOffice, Me.XrLabelResidentialAddress, Me.XrLabelPhoneNo, Me.XrLabelEmailAddress})
        Me.Detail.HeightF = 30.42868!
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
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLabelHeaderOfficeID, Me.XrLabelHeaderGeneratedTransferNo, Me.XrLabelHeaderNameOfOffice, Me.XrLabelHeaderResidentialAddress, Me.XrLabelHeaderPhoneNo, Me.XrLabelHeaderEmailAddress})
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
        Me.XrSummaryTotalNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OfficeID")})
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
        'TransferOfficesDataSource
        '
        Me.TransferOfficesDataSource.DataSource = GetType(MoCTIMIS._TransferOfficesTable.TransferOfficesTableDataTable)
        Me.TransferOfficesDataSource.Name = "TransferOfficesDataSource"
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
        'XrLabelOfficeID
        '
        Me.XrLabelOfficeID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OfficeID")})
        Me.XrLabelOfficeID.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelOfficeID.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 0!)
        Me.XrLabelOfficeID.Name = "XrLabelOfficeID"
        Me.XrLabelOfficeID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelOfficeID.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelOfficeID.StylePriority.UseFont = False
        Me.XrLabelOfficeID.StylePriority.UseTextAlignment = False
        Me.XrLabelOfficeID.Text = "XrLabelOfficeID"
        Me.XrLabelOfficeID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderOfficeID
        '
        Me.XrLabelHeaderOfficeID.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderOfficeID.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 17.14183!)
        Me.XrLabelHeaderOfficeID.Name = "XrLabelHeaderOfficeID"
        Me.XrLabelHeaderOfficeID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderOfficeID.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderOfficeID.StylePriority.UseFont = False
        Me.XrLabelHeaderOfficeID.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderOfficeID.Text = "Office ID"
        Me.XrLabelHeaderOfficeID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelGeneratedTransferNo
        '
        Me.XrLabelGeneratedTransferNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GeneratedTransferNo")})
        Me.XrLabelGeneratedTransferNo.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelGeneratedTransferNo.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 0!)
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
        Me.XrLabelHeaderGeneratedTransferNo.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 17.14183!)
        Me.XrLabelHeaderGeneratedTransferNo.Name = "XrLabelHeaderGeneratedTransferNo"
        Me.XrLabelHeaderGeneratedTransferNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderGeneratedTransferNo.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderGeneratedTransferNo.StylePriority.UseFont = False
        Me.XrLabelHeaderGeneratedTransferNo.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderGeneratedTransferNo.Text = "Generated Transfer No"
        Me.XrLabelHeaderGeneratedTransferNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelNameOfOffice
        '
        Me.XrLabelNameOfOffice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NameOfOffice")})
        Me.XrLabelNameOfOffice.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelNameOfOffice.LocationFloat = New DevExpress.Utils.PointFloat(226.0!, 0!)
        Me.XrLabelNameOfOffice.Name = "XrLabelNameOfOffice"
        Me.XrLabelNameOfOffice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelNameOfOffice.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelNameOfOffice.StylePriority.UseFont = False
        Me.XrLabelNameOfOffice.StylePriority.UseTextAlignment = False
        Me.XrLabelNameOfOffice.Text = "XrLabelNameOfOffice"
        Me.XrLabelNameOfOffice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderNameOfOffice
        '
        Me.XrLabelHeaderNameOfOffice.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderNameOfOffice.LocationFloat = New DevExpress.Utils.PointFloat(226.0!, 17.14183!)
        Me.XrLabelHeaderNameOfOffice.Name = "XrLabelHeaderNameOfOffice"
        Me.XrLabelHeaderNameOfOffice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderNameOfOffice.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderNameOfOffice.StylePriority.UseFont = False
        Me.XrLabelHeaderNameOfOffice.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderNameOfOffice.Text = "Name Of Office"
        Me.XrLabelHeaderNameOfOffice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelResidentialAddress
        '
        Me.XrLabelResidentialAddress.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResidentialAddress")})
        Me.XrLabelResidentialAddress.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelResidentialAddress.LocationFloat = New DevExpress.Utils.PointFloat(339.0!, 0!)
        Me.XrLabelResidentialAddress.Name = "XrLabelResidentialAddress"
        Me.XrLabelResidentialAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelResidentialAddress.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelResidentialAddress.StylePriority.UseFont = False
        Me.XrLabelResidentialAddress.StylePriority.UseTextAlignment = False
        Me.XrLabelResidentialAddress.Text = "XrLabelResidentialAddress"
        Me.XrLabelResidentialAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderResidentialAddress
        '
        Me.XrLabelHeaderResidentialAddress.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderResidentialAddress.LocationFloat = New DevExpress.Utils.PointFloat(339.0!, 17.14183!)
        Me.XrLabelHeaderResidentialAddress.Name = "XrLabelHeaderResidentialAddress"
        Me.XrLabelHeaderResidentialAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderResidentialAddress.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderResidentialAddress.StylePriority.UseFont = False
        Me.XrLabelHeaderResidentialAddress.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderResidentialAddress.Text = "Residential Address"
        Me.XrLabelHeaderResidentialAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelPhoneNo
        '
        Me.XrLabelPhoneNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PhoneNo")})
        Me.XrLabelPhoneNo.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelPhoneNo.LocationFloat = New DevExpress.Utils.PointFloat(452.0!, 0!)
        Me.XrLabelPhoneNo.Name = "XrLabelPhoneNo"
        Me.XrLabelPhoneNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelPhoneNo.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelPhoneNo.StylePriority.UseFont = False
        Me.XrLabelPhoneNo.StylePriority.UseTextAlignment = False
        Me.XrLabelPhoneNo.Text = "XrLabelPhoneNo"
        Me.XrLabelPhoneNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderPhoneNo
        '
        Me.XrLabelHeaderPhoneNo.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderPhoneNo.LocationFloat = New DevExpress.Utils.PointFloat(452.0!, 17.14183!)
        Me.XrLabelHeaderPhoneNo.Name = "XrLabelHeaderPhoneNo"
        Me.XrLabelHeaderPhoneNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderPhoneNo.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderPhoneNo.StylePriority.UseFont = False
        Me.XrLabelHeaderPhoneNo.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderPhoneNo.Text = "Phone No"
        Me.XrLabelHeaderPhoneNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelEmailAddress
        '
        Me.XrLabelEmailAddress.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EmailAddress")})
        Me.XrLabelEmailAddress.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelEmailAddress.LocationFloat = New DevExpress.Utils.PointFloat(565.0!, 0!)
        Me.XrLabelEmailAddress.Name = "XrLabelEmailAddress"
        Me.XrLabelEmailAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelEmailAddress.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelEmailAddress.StylePriority.UseFont = False
        Me.XrLabelEmailAddress.StylePriority.UseTextAlignment = False
        Me.XrLabelEmailAddress.Text = "XrLabelEmailAddress"
        Me.XrLabelEmailAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderEmailAddress
        '
        Me.XrLabelHeaderEmailAddress.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderEmailAddress.LocationFloat = New DevExpress.Utils.PointFloat(565.0!, 17.14183!)
        Me.XrLabelHeaderEmailAddress.Name = "XrLabelHeaderEmailAddress"
        Me.XrLabelHeaderEmailAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderEmailAddress.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderEmailAddress.StylePriority.UseFont = False
        Me.XrLabelHeaderEmailAddress.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderEmailAddress.Text = "Email Address"
        Me.XrLabelHeaderEmailAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        Me.XrLine2.SizeF = New System.Drawing.SizeF(722.9567!, 2.0!)
        '
        'XtraReportTransferOfficesMultiple
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.CompanySettingsDataSource, Me.TransferOfficesDataSource})
        Me.DataSource = Me.TransferOfficesDataSource
        Me.Margins = New System.Drawing.Printing.Margins(41, 60, 31, 25)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None
        Me.Version = "17.1"
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferOfficesDataSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public WithEvents TransferOfficesDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Public WithEvents XrLabelReportTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Public WithEvents XrLabelReportDateCriteria As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportDateField As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportCriteriaLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrSummaryTotalNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrlblTotalNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelOfficeID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderOfficeID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelGeneratedTransferNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderGeneratedTransferNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelNameOfOffice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderNameOfOffice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelResidentialAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderResidentialAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelPhoneNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderPhoneNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelEmailAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderEmailAddress As DevExpress.XtraReports.UI.XRLabel
End Class

