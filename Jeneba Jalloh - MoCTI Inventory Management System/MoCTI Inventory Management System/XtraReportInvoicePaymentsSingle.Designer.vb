<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class XtraReportTransferPaymentsSingle
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
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelIPaymentID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelGeneratedTransferNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelPaidBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelPaymentDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelCurrentAmount = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelAmountPaid = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelBalance = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelPaymentMode = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRefChequeNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelBank = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRegDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelInputedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderIPaymentID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderGeneratedTransferNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderPaidBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderPaymentDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderCurrentAmount = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderAmountPaid = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderBalance = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderPaymentMode = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRefChequeNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderBank = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRegDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderInputedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.CompanySettingsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
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
        Me.TransferPaymentsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferPaymentsDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrLabel11, Me.XrLine2, Me.XrLine1, Me.XrLabel9, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabelIPaymentID, Me.XrLabelGeneratedTransferNo, Me.XrLabelPaidBy, Me.XrLabelPaymentDate, Me.XrLabelCurrentAmount, Me.XrLabelAmountPaid, Me.XrLabelBalance, Me.XrLabelPaymentMode, Me.XrLabelRefChequeNo, Me.XrLabelBank, Me.XrLabelComment, Me.XrLabelRegDate, Me.XrLabelInputedBy, Me.XrLabelHeaderIPaymentID, Me.XrLabelHeaderGeneratedTransferNo, Me.XrLabelHeaderPaidBy, Me.XrLabelHeaderPaymentDate, Me.XrLabelHeaderCurrentAmount, Me.XrLabelHeaderAmountPaid, Me.XrLabelHeaderBalance, Me.XrLabelHeaderPaymentMode, Me.XrLabelHeaderRefChequeNo, Me.XrLabelHeaderBank, Me.XrLabelHeaderComment, Me.XrLabelHeaderRegDate, Me.XrLabelHeaderInputedBy})
        Me.Detail.HeightF = 416.9584!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(506.9167!, 206.7083!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(229.3333!, 3.125!)
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(19.41668!, 382.6667!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(250.0!, 2.083344!)
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(18.25002!, 387.4583!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(162.5!, 23.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "RECEIVED BY"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(374.5833!, 15.72914!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(231.25!, 26.12502!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Payment Details"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(12.00002!, 16.60414!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(231.25!, 26.12502!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Transaction Tracker"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(13.47919!, 183.9583!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(231.25!, 26.12502!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Payment Mode Details"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelIPaymentID
        '
        Me.XrLabelIPaymentID.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelIPaymentID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IPaymentID")})
        Me.XrLabelIPaymentID.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelIPaymentID.LocationFloat = New DevExpress.Utils.PointFloat(180.4167!, 49.45831!)
        Me.XrLabelIPaymentID.Name = "XrLabelIPaymentID"
        Me.XrLabelIPaymentID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelIPaymentID.SizeF = New System.Drawing.SizeF(183.3333!, 23.00001!)
        Me.XrLabelIPaymentID.StylePriority.UseBorders = False
        Me.XrLabelIPaymentID.StylePriority.UseFont = False
        Me.XrLabelIPaymentID.StylePriority.UseTextAlignment = False
        Me.XrLabelIPaymentID.Text = "XrLabelIPaymentID"
        Me.XrLabelIPaymentID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelGeneratedTransferNo
        '
        Me.XrLabelGeneratedTransferNo.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelGeneratedTransferNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GeneratedTransferNo")})
        Me.XrLabelGeneratedTransferNo.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelGeneratedTransferNo.LocationFloat = New DevExpress.Utils.PointFloat(180.4167!, 75.45834!)
        Me.XrLabelGeneratedTransferNo.Name = "XrLabelGeneratedTransferNo"
        Me.XrLabelGeneratedTransferNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelGeneratedTransferNo.SizeF = New System.Drawing.SizeF(183.3333!, 23.0!)
        Me.XrLabelGeneratedTransferNo.StylePriority.UseBorders = False
        Me.XrLabelGeneratedTransferNo.StylePriority.UseFont = False
        Me.XrLabelGeneratedTransferNo.StylePriority.UseTextAlignment = False
        Me.XrLabelGeneratedTransferNo.Text = "XrLabelGeneratedTransferNo"
        Me.XrLabelGeneratedTransferNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelPaidBy
        '
        Me.XrLabelPaidBy.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelPaidBy.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PaidBy")})
        Me.XrLabelPaidBy.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelPaidBy.LocationFloat = New DevExpress.Utils.PointFloat(504.875!, 46.45834!)
        Me.XrLabelPaidBy.Name = "XrLabelPaidBy"
        Me.XrLabelPaidBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelPaidBy.SizeF = New System.Drawing.SizeF(233.3333!, 23.0!)
        Me.XrLabelPaidBy.StylePriority.UseBorders = False
        Me.XrLabelPaidBy.StylePriority.UseFont = False
        Me.XrLabelPaidBy.StylePriority.UseTextAlignment = False
        Me.XrLabelPaidBy.Text = "XrLabelPaidBy"
        Me.XrLabelPaidBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelPaymentDate
        '
        Me.XrLabelPaymentDate.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelPaymentDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PaymentDate")})
        Me.XrLabelPaymentDate.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelPaymentDate.LocationFloat = New DevExpress.Utils.PointFloat(504.875!, 72.45833!)
        Me.XrLabelPaymentDate.Name = "XrLabelPaymentDate"
        Me.XrLabelPaymentDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelPaymentDate.SizeF = New System.Drawing.SizeF(233.3333!, 23.0!)
        Me.XrLabelPaymentDate.StylePriority.UseBorders = False
        Me.XrLabelPaymentDate.StylePriority.UseFont = False
        Me.XrLabelPaymentDate.StylePriority.UseTextAlignment = False
        Me.XrLabelPaymentDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabelPaymentDate.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'XrLabelCurrentAmount
        '
        Me.XrLabelCurrentAmount.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelCurrentAmount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CurrentAmount", "{0:n2}")})
        Me.XrLabelCurrentAmount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelCurrentAmount.LocationFloat = New DevExpress.Utils.PointFloat(504.875!, 100.4583!)
        Me.XrLabelCurrentAmount.Name = "XrLabelCurrentAmount"
        Me.XrLabelCurrentAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelCurrentAmount.SizeF = New System.Drawing.SizeF(233.3333!, 23.0!)
        Me.XrLabelCurrentAmount.StylePriority.UseBorders = False
        Me.XrLabelCurrentAmount.StylePriority.UseFont = False
        Me.XrLabelCurrentAmount.StylePriority.UseTextAlignment = False
        Me.XrLabelCurrentAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabelAmountPaid
        '
        Me.XrLabelAmountPaid.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelAmountPaid.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AmountPaid", "{0:n2}")})
        Me.XrLabelAmountPaid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelAmountPaid.LocationFloat = New DevExpress.Utils.PointFloat(504.875!, 126.4583!)
        Me.XrLabelAmountPaid.Name = "XrLabelAmountPaid"
        Me.XrLabelAmountPaid.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelAmountPaid.SizeF = New System.Drawing.SizeF(233.3333!, 23.0!)
        Me.XrLabelAmountPaid.StylePriority.UseBorders = False
        Me.XrLabelAmountPaid.StylePriority.UseFont = False
        Me.XrLabelAmountPaid.StylePriority.UseTextAlignment = False
        Me.XrLabelAmountPaid.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabelBalance
        '
        Me.XrLabelBalance.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelBalance.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Balance", "{0:n2}")})
        Me.XrLabelBalance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelBalance.LocationFloat = New DevExpress.Utils.PointFloat(504.875!, 180.4583!)
        Me.XrLabelBalance.Name = "XrLabelBalance"
        Me.XrLabelBalance.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelBalance.SizeF = New System.Drawing.SizeF(233.3333!, 23.0!)
        Me.XrLabelBalance.StylePriority.UseBorders = False
        Me.XrLabelBalance.StylePriority.UseFont = False
        Me.XrLabelBalance.StylePriority.UseTextAlignment = False
        Me.XrLabelBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabelPaymentMode
        '
        Me.XrLabelPaymentMode.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelPaymentMode.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PaymentMode")})
        Me.XrLabelPaymentMode.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelPaymentMode.LocationFloat = New DevExpress.Utils.PointFloat(180.4167!, 215.0834!)
        Me.XrLabelPaymentMode.Name = "XrLabelPaymentMode"
        Me.XrLabelPaymentMode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelPaymentMode.SizeF = New System.Drawing.SizeF(188.5417!, 23.0!)
        Me.XrLabelPaymentMode.StylePriority.UseBorders = False
        Me.XrLabelPaymentMode.StylePriority.UseFont = False
        Me.XrLabelPaymentMode.StylePriority.UseTextAlignment = False
        Me.XrLabelPaymentMode.Text = "XrLabelPaymentMode"
        Me.XrLabelPaymentMode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelRefChequeNo
        '
        Me.XrLabelRefChequeNo.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelRefChequeNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RefChequeNo")})
        Me.XrLabelRefChequeNo.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelRefChequeNo.LocationFloat = New DevExpress.Utils.PointFloat(180.4167!, 241.0833!)
        Me.XrLabelRefChequeNo.Name = "XrLabelRefChequeNo"
        Me.XrLabelRefChequeNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelRefChequeNo.SizeF = New System.Drawing.SizeF(188.5417!, 22.99998!)
        Me.XrLabelRefChequeNo.StylePriority.UseBorders = False
        Me.XrLabelRefChequeNo.StylePriority.UseFont = False
        Me.XrLabelRefChequeNo.StylePriority.UseTextAlignment = False
        Me.XrLabelRefChequeNo.Text = "XrLabelRefChequeNo"
        Me.XrLabelRefChequeNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelBank
        '
        Me.XrLabelBank.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelBank.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Bank")})
        Me.XrLabelBank.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelBank.LocationFloat = New DevExpress.Utils.PointFloat(180.4167!, 267.0833!)
        Me.XrLabelBank.Name = "XrLabelBank"
        Me.XrLabelBank.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelBank.SizeF = New System.Drawing.SizeF(235.4167!, 22.99998!)
        Me.XrLabelBank.StylePriority.UseBorders = False
        Me.XrLabelBank.StylePriority.UseFont = False
        Me.XrLabelBank.StylePriority.UseTextAlignment = False
        Me.XrLabelBank.Text = "XrLabelBank"
        Me.XrLabelBank.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelComment
        '
        Me.XrLabelComment.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Comment")})
        Me.XrLabelComment.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelComment.LocationFloat = New DevExpress.Utils.PointFloat(180.4167!, 293.0834!)
        Me.XrLabelComment.Name = "XrLabelComment"
        Me.XrLabelComment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelComment.SizeF = New System.Drawing.SizeF(246.875!, 23.0!)
        Me.XrLabelComment.StylePriority.UseFont = False
        Me.XrLabelComment.StylePriority.UseTextAlignment = False
        Me.XrLabelComment.Text = "XrLabelComment"
        Me.XrLabelComment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelRegDate
        '
        Me.XrLabelRegDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RegDate")})
        Me.XrLabelRegDate.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelRegDate.LocationFloat = New DevExpress.Utils.PointFloat(556.4584!, 265.7916!)
        Me.XrLabelRegDate.Name = "XrLabelRegDate"
        Me.XrLabelRegDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelRegDate.SizeF = New System.Drawing.SizeF(179.1667!, 23.0!)
        Me.XrLabelRegDate.StylePriority.UseFont = False
        Me.XrLabelRegDate.StylePriority.UseTextAlignment = False
        Me.XrLabelRegDate.Text = "XrLabelRegDate"
        Me.XrLabelRegDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabelRegDate.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'XrLabelInputedBy
        '
        Me.XrLabelInputedBy.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InputedBy")})
        Me.XrLabelInputedBy.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelInputedBy.LocationFloat = New DevExpress.Utils.PointFloat(556.4584!, 291.7916!)
        Me.XrLabelInputedBy.Name = "XrLabelInputedBy"
        Me.XrLabelInputedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelInputedBy.SizeF = New System.Drawing.SizeF(179.1667!, 23.00003!)
        Me.XrLabelInputedBy.StylePriority.UseFont = False
        Me.XrLabelInputedBy.StylePriority.UseTextAlignment = False
        Me.XrLabelInputedBy.Text = "XrLabelInputedBy"
        Me.XrLabelInputedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderIPaymentID
        '
        Me.XrLabelHeaderIPaymentID.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderIPaymentID.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 49.37499!)
        Me.XrLabelHeaderIPaymentID.Name = "XrLabelHeaderIPaymentID"
        Me.XrLabelHeaderIPaymentID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderIPaymentID.SizeF = New System.Drawing.SizeF(162.5!, 23.0!)
        Me.XrLabelHeaderIPaymentID.StylePriority.UseFont = False
        Me.XrLabelHeaderIPaymentID.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderIPaymentID.Text = "IPayment ID:"
        Me.XrLabelHeaderIPaymentID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderGeneratedTransferNo
        '
        Me.XrLabelHeaderGeneratedTransferNo.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderGeneratedTransferNo.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 75.37502!)
        Me.XrLabelHeaderGeneratedTransferNo.Name = "XrLabelHeaderGeneratedTransferNo"
        Me.XrLabelHeaderGeneratedTransferNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderGeneratedTransferNo.SizeF = New System.Drawing.SizeF(162.5!, 23.0!)
        Me.XrLabelHeaderGeneratedTransferNo.StylePriority.UseFont = False
        Me.XrLabelHeaderGeneratedTransferNo.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderGeneratedTransferNo.Text = "Transfer No:"
        Me.XrLabelHeaderGeneratedTransferNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderPaidBy
        '
        Me.XrLabelHeaderPaidBy.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderPaidBy.LocationFloat = New DevExpress.Utils.PointFloat(374.4583!, 46.45834!)
        Me.XrLabelHeaderPaidBy.Name = "XrLabelHeaderPaidBy"
        Me.XrLabelHeaderPaidBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderPaidBy.SizeF = New System.Drawing.SizeF(126.0417!, 23.0!)
        Me.XrLabelHeaderPaidBy.StylePriority.UseFont = False
        Me.XrLabelHeaderPaidBy.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderPaidBy.Text = "Paid By:"
        Me.XrLabelHeaderPaidBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderPaymentDate
        '
        Me.XrLabelHeaderPaymentDate.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderPaymentDate.LocationFloat = New DevExpress.Utils.PointFloat(374.4583!, 72.45833!)
        Me.XrLabelHeaderPaymentDate.Name = "XrLabelHeaderPaymentDate"
        Me.XrLabelHeaderPaymentDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderPaymentDate.SizeF = New System.Drawing.SizeF(126.0417!, 23.0!)
        Me.XrLabelHeaderPaymentDate.StylePriority.UseFont = False
        Me.XrLabelHeaderPaymentDate.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderPaymentDate.Text = "Payment Date:"
        Me.XrLabelHeaderPaymentDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderCurrentAmount
        '
        Me.XrLabelHeaderCurrentAmount.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderCurrentAmount.LocationFloat = New DevExpress.Utils.PointFloat(374.4583!, 100.4583!)
        Me.XrLabelHeaderCurrentAmount.Name = "XrLabelHeaderCurrentAmount"
        Me.XrLabelHeaderCurrentAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderCurrentAmount.SizeF = New System.Drawing.SizeF(126.0417!, 23.0!)
        Me.XrLabelHeaderCurrentAmount.StylePriority.UseFont = False
        Me.XrLabelHeaderCurrentAmount.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderCurrentAmount.Text = "Current Amount:"
        Me.XrLabelHeaderCurrentAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderAmountPaid
        '
        Me.XrLabelHeaderAmountPaid.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderAmountPaid.LocationFloat = New DevExpress.Utils.PointFloat(374.4583!, 126.4583!)
        Me.XrLabelHeaderAmountPaid.Name = "XrLabelHeaderAmountPaid"
        Me.XrLabelHeaderAmountPaid.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderAmountPaid.SizeF = New System.Drawing.SizeF(126.0417!, 23.0!)
        Me.XrLabelHeaderAmountPaid.StylePriority.UseFont = False
        Me.XrLabelHeaderAmountPaid.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderAmountPaid.Text = "Amount Paid:"
        Me.XrLabelHeaderAmountPaid.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderBalance
        '
        Me.XrLabelHeaderBalance.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderBalance.LocationFloat = New DevExpress.Utils.PointFloat(374.4583!, 180.4583!)
        Me.XrLabelHeaderBalance.Name = "XrLabelHeaderBalance"
        Me.XrLabelHeaderBalance.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderBalance.SizeF = New System.Drawing.SizeF(126.0417!, 23.0!)
        Me.XrLabelHeaderBalance.StylePriority.UseFont = False
        Me.XrLabelHeaderBalance.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderBalance.Text = "Balance:"
        Me.XrLabelHeaderBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderPaymentMode
        '
        Me.XrLabelHeaderPaymentMode.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderPaymentMode.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 215.0!)
        Me.XrLabelHeaderPaymentMode.Name = "XrLabelHeaderPaymentMode"
        Me.XrLabelHeaderPaymentMode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderPaymentMode.SizeF = New System.Drawing.SizeF(162.5!, 23.0!)
        Me.XrLabelHeaderPaymentMode.StylePriority.UseFont = False
        Me.XrLabelHeaderPaymentMode.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderPaymentMode.Text = "Payment Mode:"
        Me.XrLabelHeaderPaymentMode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRefChequeNo
        '
        Me.XrLabelHeaderRefChequeNo.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRefChequeNo.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 241.0!)
        Me.XrLabelHeaderRefChequeNo.Name = "XrLabelHeaderRefChequeNo"
        Me.XrLabelHeaderRefChequeNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderRefChequeNo.SizeF = New System.Drawing.SizeF(162.5!, 23.0!)
        Me.XrLabelHeaderRefChequeNo.StylePriority.UseFont = False
        Me.XrLabelHeaderRefChequeNo.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderRefChequeNo.Text = "Ref Cheque No:"
        Me.XrLabelHeaderRefChequeNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderBank
        '
        Me.XrLabelHeaderBank.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderBank.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 267.0!)
        Me.XrLabelHeaderBank.Name = "XrLabelHeaderBank"
        Me.XrLabelHeaderBank.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderBank.SizeF = New System.Drawing.SizeF(162.5!, 22.99998!)
        Me.XrLabelHeaderBank.StylePriority.UseFont = False
        Me.XrLabelHeaderBank.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderBank.Text = "Bank:"
        Me.XrLabelHeaderBank.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderComment
        '
        Me.XrLabelHeaderComment.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderComment.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 293.0!)
        Me.XrLabelHeaderComment.Name = "XrLabelHeaderComment"
        Me.XrLabelHeaderComment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderComment.SizeF = New System.Drawing.SizeF(162.5!, 23.0!)
        Me.XrLabelHeaderComment.StylePriority.UseFont = False
        Me.XrLabelHeaderComment.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderComment.Text = "Comment:"
        Me.XrLabelHeaderComment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRegDate
        '
        Me.XrLabelHeaderRegDate.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRegDate.LocationFloat = New DevExpress.Utils.PointFloat(463.0!, 265.7083!)
        Me.XrLabelHeaderRegDate.Name = "XrLabelHeaderRegDate"
        Me.XrLabelHeaderRegDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderRegDate.SizeF = New System.Drawing.SizeF(91.66669!, 23.0!)
        Me.XrLabelHeaderRegDate.StylePriority.UseFont = False
        Me.XrLabelHeaderRegDate.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderRegDate.Text = "Reg Date:"
        Me.XrLabelHeaderRegDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderInputedBy
        '
        Me.XrLabelHeaderInputedBy.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderInputedBy.LocationFloat = New DevExpress.Utils.PointFloat(463.0!, 291.7083!)
        Me.XrLabelHeaderInputedBy.Name = "XrLabelHeaderInputedBy"
        Me.XrLabelHeaderInputedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderInputedBy.SizeF = New System.Drawing.SizeF(91.66669!, 23.0!)
        Me.XrLabelHeaderInputedBy.StylePriority.UseFont = False
        Me.XrLabelHeaderInputedBy.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderInputedBy.Text = "Inputed By:"
        Me.XrLabelHeaderInputedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 19.65466!
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode1, Me.XrPageInfo2, Me.XrLabel8, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrPictureBox1, Me.XrLabel1, Me.XrLabelReportTitle})
        Me.ReportHeader.HeightF = 219.3725!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IPaymentID")})
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(417.5001!, 162.8333!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(323.9583!, 50.91667!)
        Me.XrBarCode1.Symbology = EaN128Generator1
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(584.0047!, 54.9327!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(157.2917!, 23.0!)
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrPageInfo2.TextFormatString = "{0:dd/MM/yyyy hh:mm:ss tt}"
        '
        'XrLabel8
        '
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(582.6675!, 29.75561!)
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
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(119.4447!, 99.54567!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(357.1515!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "Email")})
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(119.625!, 76.12498!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(357.2917!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "Address")})
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(118.5833!, 53.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(358.3333!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("ImageSource", Me.CompanySettingsDataSource, "Logo")})
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(9.999974!, 21.66667!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(101.242!, 101.7259!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "NameofCompany")})
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(118.5833!, 30.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(358.3333!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelReportTitle
        '
        Me.XrLabelReportTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelReportTitle.LocationFloat = New DevExpress.Utils.PointFloat(141.3358!, 126.2901!)
        Me.XrLabelReportTitle.Name = "XrLabelReportTitle"
        Me.XrLabelReportTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelReportTitle.SizeF = New System.Drawing.SizeF(467.7885!, 32.99998!)
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
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 19.79167!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 32.29167!
        Me.PageFooter.Name = "PageFooter"
        '
        'TransferPaymentsDataSource
        '
        Me.TransferPaymentsDataSource.DataSource = GetType(MoCTIMIS._TransferPaymentsTable.TransferPaymentsTableDataTable)
        Me.TransferPaymentsDataSource.Name = "TransferPaymentsDataSource"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(375.4583!, 153.4583!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(126.0417!, 23.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Discount:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Discount", "{0:n2}")})
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(505.875!, 153.4583!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(233.3333!, 23.0!)
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XtraReportTransferPaymentsSingle
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.CompanySettingsDataSource, Me.TransferPaymentsDataSource})
        Me.DataSource = Me.TransferPaymentsDataSource
        Me.Margins = New System.Drawing.Printing.Margins(41, 60, 20, 25)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None
        Me.Version = "18.2"
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferPaymentsDataSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public WithEvents TransferPaymentsDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Public WithEvents XrLabelReportTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelIPaymentID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderIPaymentID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelGeneratedTransferNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderGeneratedTransferNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelPaidBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderPaidBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelPaymentDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderPaymentDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelCurrentAmount As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderCurrentAmount As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelAmountPaid As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderAmountPaid As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelBalance As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderBalance As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelPaymentMode As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderPaymentMode As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRefChequeNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRefChequeNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelBank As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderBank As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRegDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRegDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelInputedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderInputedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
End Class

