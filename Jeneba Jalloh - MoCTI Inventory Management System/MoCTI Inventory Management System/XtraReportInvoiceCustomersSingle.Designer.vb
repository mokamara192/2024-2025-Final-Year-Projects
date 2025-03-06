<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XtraReportTransferOfficesSingle
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
        Dim EaN128Generator1 As DevExpress.XtraPrinting.BarCode.EAN128Generator = New DevExpress.XtraPrinting.BarCode.EAN128Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrLabelOfficeID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelGeneratedTransferNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelNameOfOffice = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelResidentialAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelPhoneNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelEmailAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelOccupation = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelOfficeOfWork = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelWorkAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelIdentificationType = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelIdentificationNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBoxPhotograph = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabelComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRegDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelInputedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderOfficeID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderGeneratedTransferNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderNameOfOffice = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderResidentialAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderPhoneNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderEmailAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderOccupation = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderOfficeOfWork = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderWorkAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderIdentificationType = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderIdentificationNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderPhotograph = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRegDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderInputedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.TransferOfficesDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.CompanySettingsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelReportTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        CType(Me.TransferOfficesDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode1, Me.XrLabelOfficeID, Me.XrLabelGeneratedTransferNo, Me.XrLabelNameOfOffice, Me.XrLabelResidentialAddress, Me.XrLabelPhoneNo, Me.XrLabelEmailAddress, Me.XrLabelOccupation, Me.XrLabelOfficeOfWork, Me.XrLabelWorkAddress, Me.XrLabelIdentificationType, Me.XrLabelIdentificationNo, Me.XrPictureBoxPhotograph, Me.XrLabelComment, Me.XrLabelRegDate, Me.XrLabelInputedBy, Me.XrLabelHeaderOfficeID, Me.XrLabelHeaderGeneratedTransferNo, Me.XrLabelHeaderNameOfOffice, Me.XrLabelHeaderResidentialAddress, Me.XrLabelHeaderPhoneNo, Me.XrLabelHeaderEmailAddress, Me.XrLabelHeaderOccupation, Me.XrLabelHeaderOfficeOfWork, Me.XrLabelHeaderWorkAddress, Me.XrLabelHeaderIdentificationType, Me.XrLabelHeaderIdentificationNo, Me.XrLabelHeaderPhotograph, Me.XrLabelHeaderComment, Me.XrLabelHeaderRegDate, Me.XrLabelHeaderInputedBy})
        Me.Detail.HeightF = 474.375!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OfficeID")})
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(449.625!, 14.58333!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(285.4167!, 57.29167!)
        Me.XrBarCode1.Symbology = EaN128Generator1
        '
        'XrLabelOfficeID
        '
        Me.XrLabelOfficeID.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelOfficeID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OfficeID")})
        Me.XrLabelOfficeID.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelOfficeID.LocationFloat = New DevExpress.Utils.PointFloat(184.875!, 7.999992!)
        Me.XrLabelOfficeID.Name = "XrLabelOfficeID"
        Me.XrLabelOfficeID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelOfficeID.SizeF = New System.Drawing.SizeF(242.7083!, 23.0!)
        Me.XrLabelOfficeID.StylePriority.UseBorders = False
        Me.XrLabelOfficeID.StylePriority.UseFont = False
        Me.XrLabelOfficeID.StylePriority.UseTextAlignment = False
        Me.XrLabelOfficeID.Text = "XrLabelOfficeID"
        Me.XrLabelOfficeID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelGeneratedTransferNo
        '
        Me.XrLabelGeneratedTransferNo.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelGeneratedTransferNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OfficeType")})
        Me.XrLabelGeneratedTransferNo.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelGeneratedTransferNo.LocationFloat = New DevExpress.Utils.PointFloat(184.875!, 35.00001!)
        Me.XrLabelGeneratedTransferNo.Name = "XrLabelGeneratedTransferNo"
        Me.XrLabelGeneratedTransferNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelGeneratedTransferNo.SizeF = New System.Drawing.SizeF(242.7083!, 23.0!)
        Me.XrLabelGeneratedTransferNo.StylePriority.UseBorders = False
        Me.XrLabelGeneratedTransferNo.StylePriority.UseFont = False
        Me.XrLabelGeneratedTransferNo.StylePriority.UseTextAlignment = False
        Me.XrLabelGeneratedTransferNo.Text = "XrLabelGeneratedTransferNo"
        Me.XrLabelGeneratedTransferNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelNameOfOffice
        '
        Me.XrLabelNameOfOffice.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelNameOfOffice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NameOfOffice")})
        Me.XrLabelNameOfOffice.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelNameOfOffice.LocationFloat = New DevExpress.Utils.PointFloat(184.875!, 61.0!)
        Me.XrLabelNameOfOffice.Name = "XrLabelNameOfOffice"
        Me.XrLabelNameOfOffice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelNameOfOffice.SizeF = New System.Drawing.SizeF(242.7083!, 23.0!)
        Me.XrLabelNameOfOffice.StylePriority.UseBorders = False
        Me.XrLabelNameOfOffice.StylePriority.UseFont = False
        Me.XrLabelNameOfOffice.StylePriority.UseTextAlignment = False
        Me.XrLabelNameOfOffice.Text = "XrLabelNameOfOffice"
        Me.XrLabelNameOfOffice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelResidentialAddress
        '
        Me.XrLabelResidentialAddress.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelResidentialAddress.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResidentialAddress")})
        Me.XrLabelResidentialAddress.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelResidentialAddress.LocationFloat = New DevExpress.Utils.PointFloat(184.875!, 86.99998!)
        Me.XrLabelResidentialAddress.Name = "XrLabelResidentialAddress"
        Me.XrLabelResidentialAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelResidentialAddress.SizeF = New System.Drawing.SizeF(242.7083!, 23.00001!)
        Me.XrLabelResidentialAddress.StylePriority.UseBorders = False
        Me.XrLabelResidentialAddress.StylePriority.UseFont = False
        Me.XrLabelResidentialAddress.StylePriority.UseTextAlignment = False
        Me.XrLabelResidentialAddress.Text = "XrLabelResidentialAddress"
        Me.XrLabelResidentialAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelPhoneNo
        '
        Me.XrLabelPhoneNo.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelPhoneNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PhoneNo")})
        Me.XrLabelPhoneNo.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelPhoneNo.LocationFloat = New DevExpress.Utils.PointFloat(184.875!, 113.0!)
        Me.XrLabelPhoneNo.Name = "XrLabelPhoneNo"
        Me.XrLabelPhoneNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelPhoneNo.SizeF = New System.Drawing.SizeF(242.7083!, 22.99998!)
        Me.XrLabelPhoneNo.StylePriority.UseBorders = False
        Me.XrLabelPhoneNo.StylePriority.UseFont = False
        Me.XrLabelPhoneNo.StylePriority.UseTextAlignment = False
        Me.XrLabelPhoneNo.Text = "XrLabelPhoneNo"
        Me.XrLabelPhoneNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelEmailAddress
        '
        Me.XrLabelEmailAddress.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelEmailAddress.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EmailAddress")})
        Me.XrLabelEmailAddress.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelEmailAddress.LocationFloat = New DevExpress.Utils.PointFloat(184.875!, 139.0!)
        Me.XrLabelEmailAddress.Name = "XrLabelEmailAddress"
        Me.XrLabelEmailAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelEmailAddress.SizeF = New System.Drawing.SizeF(242.7083!, 23.0!)
        Me.XrLabelEmailAddress.StylePriority.UseBorders = False
        Me.XrLabelEmailAddress.StylePriority.UseFont = False
        Me.XrLabelEmailAddress.StylePriority.UseTextAlignment = False
        Me.XrLabelEmailAddress.Text = "XrLabelEmailAddress"
        Me.XrLabelEmailAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelOccupation
        '
        Me.XrLabelOccupation.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelOccupation.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Occupation")})
        Me.XrLabelOccupation.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelOccupation.LocationFloat = New DevExpress.Utils.PointFloat(184.875!, 165.0!)
        Me.XrLabelOccupation.Name = "XrLabelOccupation"
        Me.XrLabelOccupation.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelOccupation.SizeF = New System.Drawing.SizeF(242.7083!, 23.0!)
        Me.XrLabelOccupation.StylePriority.UseBorders = False
        Me.XrLabelOccupation.StylePriority.UseFont = False
        Me.XrLabelOccupation.StylePriority.UseTextAlignment = False
        Me.XrLabelOccupation.Text = "XrLabelOccupation"
        Me.XrLabelOccupation.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelOfficeOfWork
        '
        Me.XrLabelOfficeOfWork.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelOfficeOfWork.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OfficeOfWork")})
        Me.XrLabelOfficeOfWork.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelOfficeOfWork.LocationFloat = New DevExpress.Utils.PointFloat(184.875!, 191.0!)
        Me.XrLabelOfficeOfWork.Name = "XrLabelOfficeOfWork"
        Me.XrLabelOfficeOfWork.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelOfficeOfWork.SizeF = New System.Drawing.SizeF(242.7083!, 23.0!)
        Me.XrLabelOfficeOfWork.StylePriority.UseBorders = False
        Me.XrLabelOfficeOfWork.StylePriority.UseFont = False
        Me.XrLabelOfficeOfWork.StylePriority.UseTextAlignment = False
        Me.XrLabelOfficeOfWork.Text = "XrLabelOfficeOfWork"
        Me.XrLabelOfficeOfWork.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelWorkAddress
        '
        Me.XrLabelWorkAddress.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelWorkAddress.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "WorkAddress")})
        Me.XrLabelWorkAddress.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelWorkAddress.LocationFloat = New DevExpress.Utils.PointFloat(184.875!, 217.0!)
        Me.XrLabelWorkAddress.Name = "XrLabelWorkAddress"
        Me.XrLabelWorkAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelWorkAddress.SizeF = New System.Drawing.SizeF(242.7083!, 22.99997!)
        Me.XrLabelWorkAddress.StylePriority.UseBorders = False
        Me.XrLabelWorkAddress.StylePriority.UseFont = False
        Me.XrLabelWorkAddress.StylePriority.UseTextAlignment = False
        Me.XrLabelWorkAddress.Text = "XrLabelWorkAddress"
        Me.XrLabelWorkAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelIdentificationType
        '
        Me.XrLabelIdentificationType.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelIdentificationType.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IdentificationType")})
        Me.XrLabelIdentificationType.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelIdentificationType.LocationFloat = New DevExpress.Utils.PointFloat(184.875!, 243.0!)
        Me.XrLabelIdentificationType.Name = "XrLabelIdentificationType"
        Me.XrLabelIdentificationType.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelIdentificationType.SizeF = New System.Drawing.SizeF(242.7083!, 23.0!)
        Me.XrLabelIdentificationType.StylePriority.UseBorders = False
        Me.XrLabelIdentificationType.StylePriority.UseFont = False
        Me.XrLabelIdentificationType.StylePriority.UseTextAlignment = False
        Me.XrLabelIdentificationType.Text = "XrLabelIdentificationType"
        Me.XrLabelIdentificationType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelIdentificationNo
        '
        Me.XrLabelIdentificationNo.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelIdentificationNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IdentificationNo")})
        Me.XrLabelIdentificationNo.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelIdentificationNo.LocationFloat = New DevExpress.Utils.PointFloat(184.875!, 269.0!)
        Me.XrLabelIdentificationNo.Name = "XrLabelIdentificationNo"
        Me.XrLabelIdentificationNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelIdentificationNo.SizeF = New System.Drawing.SizeF(242.7083!, 23.0!)
        Me.XrLabelIdentificationNo.StylePriority.UseBorders = False
        Me.XrLabelIdentificationNo.StylePriority.UseFont = False
        Me.XrLabelIdentificationNo.StylePriority.UseTextAlignment = False
        Me.XrLabelIdentificationNo.Text = "XrLabelIdentificationNo"
        Me.XrLabelIdentificationNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBoxPhotograph
        '
        Me.XrPictureBoxPhotograph.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPictureBoxPhotograph.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Photograph")})
        Me.XrPictureBoxPhotograph.LocationFloat = New DevExpress.Utils.PointFloat(469.375!, 124.6667!)
        Me.XrPictureBoxPhotograph.Name = "XrPictureBoxPhotograph"
        Me.XrPictureBoxPhotograph.SizeF = New System.Drawing.SizeF(169.375!, 168.875!)
        Me.XrPictureBoxPhotograph.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBoxPhotograph.StylePriority.UseBorders = False
        '
        'XrLabelComment
        '
        Me.XrLabelComment.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelComment.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Comment")})
        Me.XrLabelComment.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelComment.LocationFloat = New DevExpress.Utils.PointFloat(184.875!, 329.375!)
        Me.XrLabelComment.Name = "XrLabelComment"
        Me.XrLabelComment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelComment.SizeF = New System.Drawing.SizeF(241.6667!, 23.0!)
        Me.XrLabelComment.StylePriority.UseBorders = False
        Me.XrLabelComment.StylePriority.UseFont = False
        Me.XrLabelComment.StylePriority.UseTextAlignment = False
        Me.XrLabelComment.Text = "XrLabelComment"
        Me.XrLabelComment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelRegDate
        '
        Me.XrLabelRegDate.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelRegDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RegDate")})
        Me.XrLabelRegDate.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelRegDate.LocationFloat = New DevExpress.Utils.PointFloat(184.875!, 355.375!)
        Me.XrLabelRegDate.Name = "XrLabelRegDate"
        Me.XrLabelRegDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelRegDate.SizeF = New System.Drawing.SizeF(241.6667!, 23.0!)
        Me.XrLabelRegDate.StylePriority.UseBorders = False
        Me.XrLabelRegDate.StylePriority.UseFont = False
        Me.XrLabelRegDate.StylePriority.UseTextAlignment = False
        Me.XrLabelRegDate.Text = "XrLabelRegDate"
        Me.XrLabelRegDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelInputedBy
        '
        Me.XrLabelInputedBy.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelInputedBy.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InputedBy")})
        Me.XrLabelInputedBy.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelInputedBy.LocationFloat = New DevExpress.Utils.PointFloat(184.875!, 381.375!)
        Me.XrLabelInputedBy.Name = "XrLabelInputedBy"
        Me.XrLabelInputedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelInputedBy.SizeF = New System.Drawing.SizeF(241.6667!, 23.0!)
        Me.XrLabelInputedBy.StylePriority.UseBorders = False
        Me.XrLabelInputedBy.StylePriority.UseFont = False
        Me.XrLabelInputedBy.StylePriority.UseTextAlignment = False
        Me.XrLabelInputedBy.Text = "XrLabelInputedBy"
        Me.XrLabelInputedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderOfficeID
        '
        Me.XrLabelHeaderOfficeID.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderOfficeID.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 7.999992!)
        Me.XrLabelHeaderOfficeID.Name = "XrLabelHeaderOfficeID"
        Me.XrLabelHeaderOfficeID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderOfficeID.SizeF = New System.Drawing.SizeF(166.6667!, 23.0!)
        Me.XrLabelHeaderOfficeID.StylePriority.UseFont = False
        Me.XrLabelHeaderOfficeID.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderOfficeID.Text = "Office ID:"
        Me.XrLabelHeaderOfficeID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderGeneratedTransferNo
        '
        Me.XrLabelHeaderGeneratedTransferNo.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderGeneratedTransferNo.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 35.00001!)
        Me.XrLabelHeaderGeneratedTransferNo.Name = "XrLabelHeaderGeneratedTransferNo"
        Me.XrLabelHeaderGeneratedTransferNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderGeneratedTransferNo.SizeF = New System.Drawing.SizeF(166.6667!, 23.0!)
        Me.XrLabelHeaderGeneratedTransferNo.StylePriority.UseFont = False
        Me.XrLabelHeaderGeneratedTransferNo.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderGeneratedTransferNo.Text = "Office Type:"
        Me.XrLabelHeaderGeneratedTransferNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderNameOfOffice
        '
        Me.XrLabelHeaderNameOfOffice.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderNameOfOffice.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 61.0!)
        Me.XrLabelHeaderNameOfOffice.Name = "XrLabelHeaderNameOfOffice"
        Me.XrLabelHeaderNameOfOffice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderNameOfOffice.SizeF = New System.Drawing.SizeF(166.6667!, 23.0!)
        Me.XrLabelHeaderNameOfOffice.StylePriority.UseFont = False
        Me.XrLabelHeaderNameOfOffice.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderNameOfOffice.Text = "Name Of Office:"
        Me.XrLabelHeaderNameOfOffice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderResidentialAddress
        '
        Me.XrLabelHeaderResidentialAddress.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderResidentialAddress.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 86.99998!)
        Me.XrLabelHeaderResidentialAddress.Name = "XrLabelHeaderResidentialAddress"
        Me.XrLabelHeaderResidentialAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderResidentialAddress.SizeF = New System.Drawing.SizeF(166.6667!, 23.00001!)
        Me.XrLabelHeaderResidentialAddress.StylePriority.UseFont = False
        Me.XrLabelHeaderResidentialAddress.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderResidentialAddress.Text = "Residential Address:"
        Me.XrLabelHeaderResidentialAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderPhoneNo
        '
        Me.XrLabelHeaderPhoneNo.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderPhoneNo.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 113.0!)
        Me.XrLabelHeaderPhoneNo.Name = "XrLabelHeaderPhoneNo"
        Me.XrLabelHeaderPhoneNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderPhoneNo.SizeF = New System.Drawing.SizeF(166.6667!, 22.99998!)
        Me.XrLabelHeaderPhoneNo.StylePriority.UseFont = False
        Me.XrLabelHeaderPhoneNo.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderPhoneNo.Text = "Phone No:"
        Me.XrLabelHeaderPhoneNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderEmailAddress
        '
        Me.XrLabelHeaderEmailAddress.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderEmailAddress.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 139.0!)
        Me.XrLabelHeaderEmailAddress.Name = "XrLabelHeaderEmailAddress"
        Me.XrLabelHeaderEmailAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderEmailAddress.SizeF = New System.Drawing.SizeF(166.6667!, 23.0!)
        Me.XrLabelHeaderEmailAddress.StylePriority.UseFont = False
        Me.XrLabelHeaderEmailAddress.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderEmailAddress.Text = "Email Address:"
        Me.XrLabelHeaderEmailAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderOccupation
        '
        Me.XrLabelHeaderOccupation.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderOccupation.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 165.0!)
        Me.XrLabelHeaderOccupation.Name = "XrLabelHeaderOccupation"
        Me.XrLabelHeaderOccupation.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderOccupation.SizeF = New System.Drawing.SizeF(166.6667!, 23.0!)
        Me.XrLabelHeaderOccupation.StylePriority.UseFont = False
        Me.XrLabelHeaderOccupation.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderOccupation.Text = "Occupation:"
        Me.XrLabelHeaderOccupation.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderOfficeOfWork
        '
        Me.XrLabelHeaderOfficeOfWork.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderOfficeOfWork.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 191.0!)
        Me.XrLabelHeaderOfficeOfWork.Name = "XrLabelHeaderOfficeOfWork"
        Me.XrLabelHeaderOfficeOfWork.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderOfficeOfWork.SizeF = New System.Drawing.SizeF(166.6667!, 23.0!)
        Me.XrLabelHeaderOfficeOfWork.StylePriority.UseFont = False
        Me.XrLabelHeaderOfficeOfWork.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderOfficeOfWork.Text = "Office Of Work:"
        Me.XrLabelHeaderOfficeOfWork.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderWorkAddress
        '
        Me.XrLabelHeaderWorkAddress.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderWorkAddress.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 217.0!)
        Me.XrLabelHeaderWorkAddress.Name = "XrLabelHeaderWorkAddress"
        Me.XrLabelHeaderWorkAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderWorkAddress.SizeF = New System.Drawing.SizeF(166.6667!, 22.99998!)
        Me.XrLabelHeaderWorkAddress.StylePriority.UseFont = False
        Me.XrLabelHeaderWorkAddress.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderWorkAddress.Text = "Work Address:"
        Me.XrLabelHeaderWorkAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderIdentificationType
        '
        Me.XrLabelHeaderIdentificationType.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderIdentificationType.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 243.0!)
        Me.XrLabelHeaderIdentificationType.Name = "XrLabelHeaderIdentificationType"
        Me.XrLabelHeaderIdentificationType.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderIdentificationType.SizeF = New System.Drawing.SizeF(166.6667!, 23.0!)
        Me.XrLabelHeaderIdentificationType.StylePriority.UseFont = False
        Me.XrLabelHeaderIdentificationType.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderIdentificationType.Text = "Identification Type:"
        Me.XrLabelHeaderIdentificationType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderIdentificationNo
        '
        Me.XrLabelHeaderIdentificationNo.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderIdentificationNo.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 269.0!)
        Me.XrLabelHeaderIdentificationNo.Name = "XrLabelHeaderIdentificationNo"
        Me.XrLabelHeaderIdentificationNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderIdentificationNo.SizeF = New System.Drawing.SizeF(166.6667!, 23.0!)
        Me.XrLabelHeaderIdentificationNo.StylePriority.UseFont = False
        Me.XrLabelHeaderIdentificationNo.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderIdentificationNo.Text = "Identification No:"
        Me.XrLabelHeaderIdentificationNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderPhotograph
        '
        Me.XrLabelHeaderPhotograph.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderPhotograph.LocationFloat = New DevExpress.Utils.PointFloat(467.1667!, 97.45833!)
        Me.XrLabelHeaderPhotograph.Name = "XrLabelHeaderPhotograph"
        Me.XrLabelHeaderPhotograph.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderPhotograph.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabelHeaderPhotograph.StylePriority.UseFont = False
        Me.XrLabelHeaderPhotograph.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderPhotograph.Text = "Photograph:"
        Me.XrLabelHeaderPhotograph.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderComment
        '
        Me.XrLabelHeaderComment.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderComment.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 329.375!)
        Me.XrLabelHeaderComment.Name = "XrLabelHeaderComment"
        Me.XrLabelHeaderComment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderComment.SizeF = New System.Drawing.SizeF(166.6667!, 23.0!)
        Me.XrLabelHeaderComment.StylePriority.UseFont = False
        Me.XrLabelHeaderComment.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderComment.Text = "Comment:"
        Me.XrLabelHeaderComment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRegDate
        '
        Me.XrLabelHeaderRegDate.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRegDate.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 355.375!)
        Me.XrLabelHeaderRegDate.Name = "XrLabelHeaderRegDate"
        Me.XrLabelHeaderRegDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderRegDate.SizeF = New System.Drawing.SizeF(166.6667!, 23.0!)
        Me.XrLabelHeaderRegDate.StylePriority.UseFont = False
        Me.XrLabelHeaderRegDate.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderRegDate.Text = "Reg Date:"
        Me.XrLabelHeaderRegDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderInputedBy
        '
        Me.XrLabelHeaderInputedBy.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderInputedBy.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 381.375!)
        Me.XrLabelHeaderInputedBy.Name = "XrLabelHeaderInputedBy"
        Me.XrLabelHeaderInputedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderInputedBy.SizeF = New System.Drawing.SizeF(166.6667!, 23.0!)
        Me.XrLabelHeaderInputedBy.StylePriority.UseFont = False
        Me.XrLabelHeaderInputedBy.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderInputedBy.Text = "Inputed By:"
        Me.XrLabelHeaderInputedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TransferOfficesDataSource
        '
        Me.TransferOfficesDataSource.DataSource = GetType(MoCTIMIS._TransferOfficesTable.TransferOfficesTableDataTable)
        Me.TransferOfficesDataSource.Name = "TransferOfficesDataSource"
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrLabel8, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrPictureBox1, Me.XrLabel1, Me.XrLabelReportTitle})
        Me.ReportHeader.HeightF = 142.4984!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(564.2131!, 46.39104!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(175.0!, 23.0!)
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrPageInfo2.TextFormatString = "{0:dd/MM/yyyy hh:mm:ss tt}"
        '
        'XrLabel8
        '
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(563.9175!, 20.17228!)
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
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(367.5681!, 23.0!)
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
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(367.7083!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "Address")})
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(108.5833!, 32.99999!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(368.75!, 23.0!)
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
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(108.5833!, 10.00001!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(368.75!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelReportTitle
        '
        Me.XrLabelReportTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelReportTitle.LocationFloat = New DevExpress.Utils.PointFloat(149.6691!, 114.4984!)
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
        'XtraReportTransferOfficesSingle
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.CompanySettingsDataSource, Me.TransferOfficesDataSource})
        Me.DataSource = Me.TransferOfficesDataSource
        Me.Margins = New System.Drawing.Printing.Margins(41, 60, 31, 25)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None
        Me.Version = "18.1"
        CType(Me.TransferOfficesDataSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents XrLabelOccupation As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderOccupation As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelOfficeOfWork As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderOfficeOfWork As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelWorkAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderWorkAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelIdentificationType As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderIdentificationType As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelIdentificationNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderIdentificationNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBoxPhotograph As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabelHeaderPhotograph As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRegDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRegDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelInputedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderInputedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
End Class

