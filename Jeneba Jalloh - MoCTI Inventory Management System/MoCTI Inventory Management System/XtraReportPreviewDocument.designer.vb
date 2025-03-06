<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReportPreviewDocument
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
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPreviewPictureBox = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.AccountDocumentDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrBarCodeStaffID = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrLabelDepartment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelDocID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelFullName = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelDivision = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CompanySettingsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelReportCriteriaLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabelStaffProfileID = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.AccountDocumentDataSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CompanySettingsDataSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPreviewPictureBox})
        Me.Detail.HeightF = 905.2083!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPreviewPictureBox
        '
        Me.XrPreviewPictureBox.LocationFloat = New DevExpress.Utils.PointFloat(7.999992!, 4.166667!)
        Me.XrPreviewPictureBox.Name = "XrPreviewPictureBox"
        Me.XrPreviewPictureBox.SizeF = New System.Drawing.SizeF(736.4583!, 892.7083!)
        Me.XrPreviewPictureBox.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 35.41667!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 19.79167!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'AccountDocumentDataSource
        '
        Me.AccountDocumentDataSource.DataSource = GetType(MoCTIMIS._StaffProfilesTable.StaffProfilesTableDataTable)
        Me.AccountDocumentDataSource.Name = "AccountDocumentDataSource"
        '
        'PageHeader
        '
        Me.PageHeader.HeightF = 0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7})
        Me.PageFooter.HeightF = 29.16667!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.XrLabel7.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(10.56245!, 0.9999593!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(411.1667!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Powered by: FastArchieve - Banking Edition"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrBarCodeStaffID, Me.XrLabelDepartment, Me.XrLabel11, Me.XrLabelDocID, Me.XrLabel10, Me.XrLabel5, Me.XrLabelFullName, Me.XrLabelDivision, Me.XrLabel6, Me.XrLabel1, Me.XrPictureBox1, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4, Me.XrLabel8, Me.XrLabelReportCriteriaLabel, Me.XrPageInfo2, Me.XrLabelStaffProfileID})
        Me.ReportHeader.HeightF = 165.625!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLine1
        '
        Me.XrLine1.ForeColor = System.Drawing.Color.Gray
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(8.166659!, 159.625!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(731.25!, 2.0!)
        Me.XrLine1.StylePriority.UseForeColor = False
        '
        'XrBarCodeStaffID
        '
        Me.XrBarCodeStaffID.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrBarCodeStaffID.LocationFloat = New DevExpress.Utils.PointFloat(455.9167!, 113.5833!)
        Me.XrBarCodeStaffID.Name = "XrBarCodeStaffID"
        Me.XrBarCodeStaffID.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCodeStaffID.ShowText = False
        Me.XrBarCodeStaffID.SizeF = New System.Drawing.SizeF(282.2915!, 39.66666!)
        Me.XrBarCodeStaffID.StylePriority.UseTextAlignment = False
        Me.XrBarCodeStaffID.Symbology = Code128Generator1
        Me.XrBarCodeStaffID.Text = "68"
        Me.XrBarCodeStaffID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabelDepartment
        '
        Me.XrLabelDepartment.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabelDepartment.LocationFloat = New DevExpress.Utils.PointFloat(532.5005!, 80.56246!)
        Me.XrLabelDepartment.Name = "XrLabelDepartment"
        Me.XrLabelDepartment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelDepartment.SizeF = New System.Drawing.SizeF(209.7077!, 23.00002!)
        Me.XrLabelDepartment.StylePriority.UseFont = False
        Me.XrLabelDepartment.StylePriority.UseTextAlignment = False
        Me.XrLabelDepartment.Text = "OPENING OF ACCOUNT"
        Me.XrLabelDepartment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(419.2503!, 80.5625!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(108.0417!, 23.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Department:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelDocID
        '
        Me.XrLabelDocID.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabelDocID.LocationFloat = New DevExpress.Utils.PointFloat(83.5008!, 133.1667!)
        Me.XrLabelDocID.Name = "XrLabelDocID"
        Me.XrLabelDocID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelDocID.SizeF = New System.Drawing.SizeF(151.3743!, 21.00002!)
        Me.XrLabelDocID.StylePriority.UseFont = False
        Me.XrLabelDocID.StylePriority.UseTextAlignment = False
        Me.XrLabelDocID.Text = "OPENING OF ACCOUNT"
        Me.XrLabelDocID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(10.87577!, 133.1667!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(71.29169!, 21.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Doc. ID:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(10.87577!, 112.1667!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(71.29169!, 21.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Full Name:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelFullName
        '
        Me.XrLabelFullName.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabelFullName.LocationFloat = New DevExpress.Utils.PointFloat(83.5008!, 112.1667!)
        Me.XrLabelFullName.Name = "XrLabelFullName"
        Me.XrLabelFullName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelFullName.SizeF = New System.Drawing.SizeF(364.916!, 21.0!)
        Me.XrLabelFullName.StylePriority.UseFont = False
        Me.XrLabelFullName.StylePriority.UseTextAlignment = False
        Me.XrLabelFullName.Text = "OPENING OF ACCOUNT"
        Me.XrLabelFullName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelDivision
        '
        Me.XrLabelDivision.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabelDivision.LocationFloat = New DevExpress.Utils.PointFloat(531.4175!, 57.14347!)
        Me.XrLabelDivision.Name = "XrLabelDivision"
        Me.XrLabelDivision.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelDivision.SizeF = New System.Drawing.SizeF(213.8742!, 23.0!)
        Me.XrLabelDivision.StylePriority.UseFont = False
        Me.XrLabelDivision.StylePriority.UseTextAlignment = False
        Me.XrLabelDivision.Text = "OPENING OF ACCOUNT"
        Me.XrLabelDivision.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(418.0841!, 57.14347!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(108.0417!, 23.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Division:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "NameofCompany")})
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(108.5834!, 10.00001!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(289.5833!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'CompanySettingsDataSource
        '
        Me.CompanySettingsDataSource.DataSource = GetType(MoCTIMIS.CompanySettingDataSet.CompanySettingDataTableDataTable)
        Me.CompanySettingsDataSource.Name = "CompanySettingsDataSource"
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.CompanySettingsDataSource, "Logo")})
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(93.95032!, 93.39261!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "Address")})
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(108.5834!, 33.00002!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
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
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(109.625!, 56.125!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
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
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(288.4015!, 23!)
        Me.XrLabel4.StylePriority.UseFont = false
        Me.XrLabel4.StylePriority.UseTextAlignment = false
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(418.0841!, 10.38062!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(105.75!, 23!)
        Me.XrLabel8.StylePriority.UseTextAlignment = false
        Me.XrLabel8.Text = "Print Date/Time:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelReportCriteriaLabel
        '
        Me.XrLabelReportCriteriaLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabelReportCriteriaLabel.LocationFloat = New DevExpress.Utils.PointFloat(418.0841!, 34.14345!)
        Me.XrLabelReportCriteriaLabel.Name = "XrLabelReportCriteriaLabel"
        Me.XrLabelReportCriteriaLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelReportCriteriaLabel.SizeF = New System.Drawing.SizeF(108.0417!, 23!)
        Me.XrLabelReportCriteriaLabel.StylePriority.UseFont = false
        Me.XrLabelReportCriteriaLabel.StylePriority.UseTextAlignment = false
        Me.XrLabelReportCriteriaLabel.Text = "Staff Profile ID:"
        Me.XrLabelReportCriteriaLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(531.4175!, 10.55772!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(214.5833!, 23!)
        Me.XrPageInfo2.StylePriority.UseTextAlignment = false
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrPageInfo2.TextFormatString = "{0:dd/MM/yyyy hh:mm:ss tt}"
        '
        'XrLabelStaffProfileID
        '
        Me.XrLabelStaffProfileID.Font = New System.Drawing.Font("Times New Roman", 10!)
        Me.XrLabelStaffProfileID.LocationFloat = New DevExpress.Utils.PointFloat(531.4175!, 34.14345!)
        Me.XrLabelStaffProfileID.Name = "XrLabelStaffProfileID"
        Me.XrLabelStaffProfileID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabelStaffProfileID.SizeF = New System.Drawing.SizeF(213.8742!, 23!)
        Me.XrLabelStaffProfileID.StylePriority.UseFont = false
        Me.XrLabelStaffProfileID.StylePriority.UseTextAlignment = false
        Me.XrLabelStaffProfileID.Text = "OPENING OF ACCOUNT"
        Me.XrLabelStaffProfileID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XtraReportPreviewDocument
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter, Me.ReportHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.AccountDocumentDataSource, Me.CompanySettingsDataSource})
        Me.DataSource = Me.AccountDocumentDataSource
        Me.Margins = New System.Drawing.Printing.Margins(42, 35, 35, 20)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None
        Me.Version = "17.2"
        CType(Me.AccountDocumentDataSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CompanySettingsDataSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Public WithEvents CompanySettingsDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Public WithEvents AccountDocumentDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Public WithEvents XrLabelDivision As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportCriteriaLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Public WithEvents XrLabelStaffProfileID As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelDocID As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelFullName As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelDepartment As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrBarCodeStaffID As DevExpress.XtraReports.UI.XRBarCode
    Public WithEvents XrPreviewPictureBox As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Public WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
End Class
