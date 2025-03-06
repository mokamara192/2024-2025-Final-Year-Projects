<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XtraReportTransfersSingle
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
        Me.TransfersDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
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
        Me.XrLabelGeneratedTransferNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderGeneratedTransferNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelOutgoneTransfer = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderOutgoneTransfer = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelTransferNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderTransferNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelTransferType = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderTransferType = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelTransferDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderTransferDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelOfficeType = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderOfficeType = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelTotalAmount = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderTotalAmount = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelTransferStatus = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderTransferStatus = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelSupervision = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderSupervision = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelDocumentCompletion = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderDocumentCompletion = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRegDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRegDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelInputtedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderInputtedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelCurrency = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderCurrency = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelExchangeRate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderExchangeRate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelBankAccountID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderBankAccountID = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransfersDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabelGeneratedTransferNo, Me.XrLabelOutgoneTransfer, Me.XrLabelTransferNo, Me.XrLabelTransferType, Me.XrLabelTransferDate, Me.XrLabelOfficeType, Me.XrLabelTotalAmount, Me.XrLabelTransferStatus, Me.XrLabelComment, Me.XrLabelSupervision, Me.XrLabelDocumentCompletion, Me.XrLabelRegDate, Me.XrLabelInputtedBy, Me.XrLabelCurrency, Me.XrLabelExchangeRate, Me.XrLabelBankAccountID, Me.XrLabelHeaderGeneratedTransferNo, Me.XrLabelHeaderOutgoneTransfer, Me.XrLabelHeaderTransferNo, Me.XrLabelHeaderTransferType, Me.XrLabelHeaderTransferDate, Me.XrLabelHeaderOfficeType, Me.XrLabelHeaderTotalAmount, Me.XrLabelHeaderTransferStatus, Me.XrLabelHeaderComment, Me.XrLabelHeaderSupervision, Me.XrLabelHeaderDocumentCompletion, Me.XrLabelHeaderRegDate, Me.XrLabelHeaderInputtedBy, Me.XrLabelHeaderCurrency, Me.XrLabelHeaderExchangeRate, Me.XrLabelHeaderBankAccountID})
        Me.Detail.HeightF = 576.0!
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
        'TransfersDataSource
        '
        Me.TransfersDataSource.DataSource = GetType(MoCTIMIS.TransfersDataSet.TransfersDataTable)
        Me.TransfersDataSource.Name = "TransfersDataSource"
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
        'XrLabelGeneratedTransferNo
        '
        Me.XrLabelGeneratedTransferNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GeneratedTransferNo")})
        Me.XrLabelGeneratedTransferNo.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelGeneratedTransferNo.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 8.0!)
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
        Me.XrLabelHeaderGeneratedTransferNo.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 8.0!)
        Me.XrLabelHeaderGeneratedTransferNo.Name = "XrLabelHeaderGeneratedTransferNo"
        Me.XrLabelHeaderGeneratedTransferNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderGeneratedTransferNo.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderGeneratedTransferNo.StylePriority.UseFont = False
        Me.XrLabelHeaderGeneratedTransferNo.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderGeneratedTransferNo.Text = "Generated Transfer No:"
        Me.XrLabelHeaderGeneratedTransferNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelOutgoneTransfer
        '
        Me.XrLabelOutgoneTransfer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OutgoneTransfer")})
        Me.XrLabelOutgoneTransfer.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelOutgoneTransfer.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 26.0!)
        Me.XrLabelOutgoneTransfer.Name = "XrLabelOutgoneTransfer"
        Me.XrLabelOutgoneTransfer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelOutgoneTransfer.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelOutgoneTransfer.StylePriority.UseFont = False
        Me.XrLabelOutgoneTransfer.StylePriority.UseTextAlignment = False
        Me.XrLabelOutgoneTransfer.Text = "XrLabelOutgoneTransfer"
        Me.XrLabelOutgoneTransfer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderOutgoneTransfer
        '
        Me.XrLabelHeaderOutgoneTransfer.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderOutgoneTransfer.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 26.0!)
        Me.XrLabelHeaderOutgoneTransfer.Name = "XrLabelHeaderOutgoneTransfer"
        Me.XrLabelHeaderOutgoneTransfer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderOutgoneTransfer.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderOutgoneTransfer.StylePriority.UseFont = False
        Me.XrLabelHeaderOutgoneTransfer.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderOutgoneTransfer.Text = "Outgone Transfer:"
        Me.XrLabelHeaderOutgoneTransfer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelTransferNo
        '
        Me.XrLabelTransferNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TransferNo")})
        Me.XrLabelTransferNo.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelTransferNo.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 52.0!)
        Me.XrLabelTransferNo.Name = "XrLabelTransferNo"
        Me.XrLabelTransferNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelTransferNo.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelTransferNo.StylePriority.UseFont = False
        Me.XrLabelTransferNo.StylePriority.UseTextAlignment = False
        Me.XrLabelTransferNo.Text = "XrLabelTransferNo"
        Me.XrLabelTransferNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderTransferNo
        '
        Me.XrLabelHeaderTransferNo.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderTransferNo.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 52.0!)
        Me.XrLabelHeaderTransferNo.Name = "XrLabelHeaderTransferNo"
        Me.XrLabelHeaderTransferNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderTransferNo.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderTransferNo.StylePriority.UseFont = False
        Me.XrLabelHeaderTransferNo.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderTransferNo.Text = "Transfer No:"
        Me.XrLabelHeaderTransferNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelTransferType
        '
        Me.XrLabelTransferType.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TransferType")})
        Me.XrLabelTransferType.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelTransferType.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 78.0!)
        Me.XrLabelTransferType.Name = "XrLabelTransferType"
        Me.XrLabelTransferType.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelTransferType.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelTransferType.StylePriority.UseFont = False
        Me.XrLabelTransferType.StylePriority.UseTextAlignment = False
        Me.XrLabelTransferType.Text = "XrLabelTransferType"
        Me.XrLabelTransferType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderTransferType
        '
        Me.XrLabelHeaderTransferType.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderTransferType.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 78.0!)
        Me.XrLabelHeaderTransferType.Name = "XrLabelHeaderTransferType"
        Me.XrLabelHeaderTransferType.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderTransferType.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderTransferType.StylePriority.UseFont = False
        Me.XrLabelHeaderTransferType.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderTransferType.Text = "Transfer Type:"
        Me.XrLabelHeaderTransferType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelTransferDate
        '
        Me.XrLabelTransferDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TransferDate, {0:dd/MM/yyyy}")})
        Me.XrLabelTransferDate.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelTransferDate.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 104.0!)
        Me.XrLabelTransferDate.Name = "XrLabelTransferDate"
        Me.XrLabelTransferDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelTransferDate.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelTransferDate.StylePriority.UseFont = False
        Me.XrLabelTransferDate.StylePriority.UseTextAlignment = False
        Me.XrLabelTransferDate.Text = "XrLabelTransferDate"
        Me.XrLabelTransferDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderTransferDate
        '
        Me.XrLabelHeaderTransferDate.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderTransferDate.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 104.0!)
        Me.XrLabelHeaderTransferDate.Name = "XrLabelHeaderTransferDate"
        Me.XrLabelHeaderTransferDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderTransferDate.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderTransferDate.StylePriority.UseFont = False
        Me.XrLabelHeaderTransferDate.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderTransferDate.Text = "Transfer Date:"
        Me.XrLabelHeaderTransferDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelOfficeType
        '
        Me.XrLabelOfficeType.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OfficeType")})
        Me.XrLabelOfficeType.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelOfficeType.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 130.0!)
        Me.XrLabelOfficeType.Name = "XrLabelOfficeType"
        Me.XrLabelOfficeType.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelOfficeType.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelOfficeType.StylePriority.UseFont = False
        Me.XrLabelOfficeType.StylePriority.UseTextAlignment = False
        Me.XrLabelOfficeType.Text = "XrLabelOfficeType"
        Me.XrLabelOfficeType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderOfficeType
        '
        Me.XrLabelHeaderOfficeType.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderOfficeType.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 130.0!)
        Me.XrLabelHeaderOfficeType.Name = "XrLabelHeaderOfficeType"
        Me.XrLabelHeaderOfficeType.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderOfficeType.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderOfficeType.StylePriority.UseFont = False
        Me.XrLabelHeaderOfficeType.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderOfficeType.Text = "Office Type:"
        Me.XrLabelHeaderOfficeType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelTotalAmount
        '
        Me.XrLabelTotalAmount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TotalAmount, {0:n2}")})
        Me.XrLabelTotalAmount.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelTotalAmount.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 156.0!)
        Me.XrLabelTotalAmount.Name = "XrLabelTotalAmount"
        Me.XrLabelTotalAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelTotalAmount.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelTotalAmount.StylePriority.UseFont = False
        Me.XrLabelTotalAmount.StylePriority.UseTextAlignment = False
        Me.XrLabelTotalAmount.Text = "XrLabelTotalAmount"
        Me.XrLabelTotalAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderTotalAmount
        '
        Me.XrLabelHeaderTotalAmount.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderTotalAmount.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 156.0!)
        Me.XrLabelHeaderTotalAmount.Name = "XrLabelHeaderTotalAmount"
        Me.XrLabelHeaderTotalAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderTotalAmount.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderTotalAmount.StylePriority.UseFont = False
        Me.XrLabelHeaderTotalAmount.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderTotalAmount.Text = "Total Amount:"
        Me.XrLabelHeaderTotalAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelTransferStatus
        '
        Me.XrLabelTransferStatus.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TransferStatus")})
        Me.XrLabelTransferStatus.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelTransferStatus.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 182.0!)
        Me.XrLabelTransferStatus.Name = "XrLabelTransferStatus"
        Me.XrLabelTransferStatus.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelTransferStatus.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelTransferStatus.StylePriority.UseFont = False
        Me.XrLabelTransferStatus.StylePriority.UseTextAlignment = False
        Me.XrLabelTransferStatus.Text = "XrLabelTransferStatus"
        Me.XrLabelTransferStatus.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderTransferStatus
        '
        Me.XrLabelHeaderTransferStatus.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderTransferStatus.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 182.0!)
        Me.XrLabelHeaderTransferStatus.Name = "XrLabelHeaderTransferStatus"
        Me.XrLabelHeaderTransferStatus.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderTransferStatus.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderTransferStatus.StylePriority.UseFont = False
        Me.XrLabelHeaderTransferStatus.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderTransferStatus.Text = "Transfer Status:"
        Me.XrLabelHeaderTransferStatus.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelComment
        '
        Me.XrLabelComment.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Comment")})
        Me.XrLabelComment.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelComment.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 208.0!)
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
        Me.XrLabelHeaderComment.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 208.0!)
        Me.XrLabelHeaderComment.Name = "XrLabelHeaderComment"
        Me.XrLabelHeaderComment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderComment.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderComment.StylePriority.UseFont = False
        Me.XrLabelHeaderComment.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderComment.Text = "Comment:"
        Me.XrLabelHeaderComment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelSupervision
        '
        Me.XrLabelSupervision.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Supervision")})
        Me.XrLabelSupervision.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelSupervision.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 234.0!)
        Me.XrLabelSupervision.Name = "XrLabelSupervision"
        Me.XrLabelSupervision.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelSupervision.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelSupervision.StylePriority.UseFont = False
        Me.XrLabelSupervision.StylePriority.UseTextAlignment = False
        Me.XrLabelSupervision.Text = "XrLabelSupervision"
        Me.XrLabelSupervision.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderSupervision
        '
        Me.XrLabelHeaderSupervision.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderSupervision.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 234.0!)
        Me.XrLabelHeaderSupervision.Name = "XrLabelHeaderSupervision"
        Me.XrLabelHeaderSupervision.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderSupervision.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderSupervision.StylePriority.UseFont = False
        Me.XrLabelHeaderSupervision.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderSupervision.Text = "Supervision:"
        Me.XrLabelHeaderSupervision.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelDocumentCompletion
        '
        Me.XrLabelDocumentCompletion.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DocumentCompletion")})
        Me.XrLabelDocumentCompletion.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelDocumentCompletion.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 260.0!)
        Me.XrLabelDocumentCompletion.Name = "XrLabelDocumentCompletion"
        Me.XrLabelDocumentCompletion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelDocumentCompletion.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelDocumentCompletion.StylePriority.UseFont = False
        Me.XrLabelDocumentCompletion.StylePriority.UseTextAlignment = False
        Me.XrLabelDocumentCompletion.Text = "XrLabelDocumentCompletion"
        Me.XrLabelDocumentCompletion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderDocumentCompletion
        '
        Me.XrLabelHeaderDocumentCompletion.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderDocumentCompletion.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 260.0!)
        Me.XrLabelHeaderDocumentCompletion.Name = "XrLabelHeaderDocumentCompletion"
        Me.XrLabelHeaderDocumentCompletion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderDocumentCompletion.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderDocumentCompletion.StylePriority.UseFont = False
        Me.XrLabelHeaderDocumentCompletion.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderDocumentCompletion.Text = "Document Completion:"
        Me.XrLabelHeaderDocumentCompletion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelRegDate
        '
        Me.XrLabelRegDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RegDate")})
        Me.XrLabelRegDate.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelRegDate.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 286.0!)
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
        Me.XrLabelHeaderRegDate.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 286.0!)
        Me.XrLabelHeaderRegDate.Name = "XrLabelHeaderRegDate"
        Me.XrLabelHeaderRegDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderRegDate.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderRegDate.StylePriority.UseFont = False
        Me.XrLabelHeaderRegDate.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderRegDate.Text = "Reg Date:"
        Me.XrLabelHeaderRegDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelInputtedBy
        '
        Me.XrLabelInputtedBy.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InputtedBy")})
        Me.XrLabelInputtedBy.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelInputtedBy.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 312.0!)
        Me.XrLabelInputtedBy.Name = "XrLabelInputtedBy"
        Me.XrLabelInputtedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelInputtedBy.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelInputtedBy.StylePriority.UseFont = False
        Me.XrLabelInputtedBy.StylePriority.UseTextAlignment = False
        Me.XrLabelInputtedBy.Text = "XrLabelInputtedBy"
        Me.XrLabelInputtedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderInputtedBy
        '
        Me.XrLabelHeaderInputtedBy.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderInputtedBy.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 312.0!)
        Me.XrLabelHeaderInputtedBy.Name = "XrLabelHeaderInputtedBy"
        Me.XrLabelHeaderInputtedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderInputtedBy.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderInputtedBy.StylePriority.UseFont = False
        Me.XrLabelHeaderInputtedBy.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderInputtedBy.Text = "Inputted By:"
        Me.XrLabelHeaderInputtedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelCurrency
        '
        Me.XrLabelCurrency.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Currency")})
        Me.XrLabelCurrency.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelCurrency.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 338.0!)
        Me.XrLabelCurrency.Name = "XrLabelCurrency"
        Me.XrLabelCurrency.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelCurrency.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelCurrency.StylePriority.UseFont = False
        Me.XrLabelCurrency.StylePriority.UseTextAlignment = False
        Me.XrLabelCurrency.Text = "XrLabelCurrency"
        Me.XrLabelCurrency.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderCurrency
        '
        Me.XrLabelHeaderCurrency.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderCurrency.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 338.0!)
        Me.XrLabelHeaderCurrency.Name = "XrLabelHeaderCurrency"
        Me.XrLabelHeaderCurrency.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderCurrency.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderCurrency.StylePriority.UseFont = False
        Me.XrLabelHeaderCurrency.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderCurrency.Text = "Currency:"
        Me.XrLabelHeaderCurrency.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelExchangeRate
        '
        Me.XrLabelExchangeRate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ExchangeRate, {0:n2}")})
        Me.XrLabelExchangeRate.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelExchangeRate.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 364.0!)
        Me.XrLabelExchangeRate.Name = "XrLabelExchangeRate"
        Me.XrLabelExchangeRate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelExchangeRate.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelExchangeRate.StylePriority.UseFont = False
        Me.XrLabelExchangeRate.StylePriority.UseTextAlignment = False
        Me.XrLabelExchangeRate.Text = "XrLabelExchangeRate"
        Me.XrLabelExchangeRate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderExchangeRate
        '
        Me.XrLabelHeaderExchangeRate.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderExchangeRate.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 364.0!)
        Me.XrLabelHeaderExchangeRate.Name = "XrLabelHeaderExchangeRate"
        Me.XrLabelHeaderExchangeRate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderExchangeRate.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderExchangeRate.StylePriority.UseFont = False
        Me.XrLabelHeaderExchangeRate.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderExchangeRate.Text = "Exchange Rate:"
        Me.XrLabelHeaderExchangeRate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelBankAccountID
        '
        Me.XrLabelBankAccountID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BankAccountID, {0:#,#}")})
        Me.XrLabelBankAccountID.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelBankAccountID.LocationFloat = New DevExpress.Utils.PointFloat(113.0!, 390.0!)
        Me.XrLabelBankAccountID.Name = "XrLabelBankAccountID"
        Me.XrLabelBankAccountID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabelBankAccountID.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelBankAccountID.StylePriority.UseFont = False
        Me.XrLabelBankAccountID.StylePriority.UseTextAlignment = False
        Me.XrLabelBankAccountID.Text = "XrLabelBankAccountID"
        Me.XrLabelBankAccountID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderBankAccountID
        '
        Me.XrLabelHeaderBankAccountID.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderBankAccountID.LocationFloat = New DevExpress.Utils.PointFloat(13.0!, 390.0!)
        Me.XrLabelHeaderBankAccountID.Name = "XrLabelHeaderBankAccountID"
        Me.XrLabelHeaderBankAccountID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderBankAccountID.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderBankAccountID.StylePriority.UseFont = False
        Me.XrLabelHeaderBankAccountID.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderBankAccountID.Text = "Bank Account ID:"
        Me.XrLabelHeaderBankAccountID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XtraReportTransfersMultiple
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.CompanySettingsDataSource, Me.TransfersDataSource})
        Me.DataSource = Me.TransfersDataSource
        Me.Margins = New System.Drawing.Printing.Margins(41, 60, 31, 25)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None
        Me.Version = "17.1"
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransfersDataSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public WithEvents TransfersDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Public WithEvents XrLabelReportTitle As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportDateCriteria As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportDateField As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportCriteriaLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelGeneratedTransferNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderGeneratedTransferNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelOutgoneTransfer As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderOutgoneTransfer As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelTransferNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderTransferNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelTransferType As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderTransferType As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelTransferDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderTransferDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelOfficeType As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderOfficeType As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelTotalAmount As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderTotalAmount As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelTransferStatus As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderTransferStatus As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelSupervision As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderSupervision As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelDocumentCompletion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderDocumentCompletion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRegDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRegDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelInputtedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderInputtedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelCurrency As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderCurrency As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelExchangeRate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderExchangeRate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelBankAccountID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderBankAccountID As DevExpress.XtraReports.UI.XRLabel
End Class

