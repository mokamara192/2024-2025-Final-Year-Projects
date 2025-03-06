<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReportInventorySingle
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
        Me.XrLabelStockID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelNameOfItem = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelItemCategory = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRetailUnitPrice = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRetailUnitOfMeasurement = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRetailQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRetailLowQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelWholesaleUnitPrice = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelWholesaleUnitOfMeasurement = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelWholesaleQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelWholesaleLowQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelRegDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelInputedBy = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderStockID = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderNameOfItem = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderItemCategory = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRetailUnitPrice = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRetailUnitOfMeasurement = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRetailQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRetailLowQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderWholesaleUnitPrice = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderWholesaleUnitOfMeasurement = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderWholesaleQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderWholesaleLowQuantity = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderComment = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderRegDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabelHeaderInputedBy = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.InventoryDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.CompanySettingsDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrLabel5, Me.XrLabelStockID, Me.XrLabelNameOfItem, Me.XrLabelItemCategory, Me.XrLabelRetailUnitPrice, Me.XrLabelRetailUnitOfMeasurement, Me.XrLabelRetailQuantity, Me.XrLabelRetailLowQuantity, Me.XrLabelWholesaleUnitPrice, Me.XrLabelWholesaleUnitOfMeasurement, Me.XrLabelWholesaleQuantity, Me.XrLabelWholesaleLowQuantity, Me.XrLabelComment, Me.XrLabelRegDate, Me.XrLabelInputedBy, Me.XrLabelHeaderStockID, Me.XrLabelHeaderNameOfItem, Me.XrLabelHeaderItemCategory, Me.XrLabelHeaderRetailUnitPrice, Me.XrLabelHeaderRetailUnitOfMeasurement, Me.XrLabelHeaderRetailQuantity, Me.XrLabelHeaderRetailLowQuantity, Me.XrLabelHeaderWholesaleUnitPrice, Me.XrLabelHeaderWholesaleUnitOfMeasurement, Me.XrLabelHeaderWholesaleQuantity, Me.XrLabelHeaderWholesaleLowQuantity, Me.XrLabelHeaderComment, Me.XrLabelHeaderRegDate, Me.XrLabelHeaderInputedBy})
        Me.Detail.HeightF = 504.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabelStockID
        '
        Me.XrLabelStockID.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelStockID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "StockID")})
        Me.XrLabelStockID.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelStockID.LocationFloat = New DevExpress.Utils.PointFloat(250.5!, 7.999992!)
        Me.XrLabelStockID.Name = "XrLabelStockID"
        Me.XrLabelStockID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelStockID.SizeF = New System.Drawing.SizeF(246.875!, 23.0!)
        Me.XrLabelStockID.StylePriority.UseBorders = False
        Me.XrLabelStockID.StylePriority.UseFont = False
        Me.XrLabelStockID.StylePriority.UseTextAlignment = False
        Me.XrLabelStockID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabelStockID.TextFormatString = "{0:#,#}"
        '
        'XrLabelNameOfItem
        '
        Me.XrLabelNameOfItem.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelNameOfItem.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NameOfItem")})
        Me.XrLabelNameOfItem.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelNameOfItem.LocationFloat = New DevExpress.Utils.PointFloat(250.5!, 35.00001!)
        Me.XrLabelNameOfItem.Name = "XrLabelNameOfItem"
        Me.XrLabelNameOfItem.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelNameOfItem.SizeF = New System.Drawing.SizeF(246.875!, 23.0!)
        Me.XrLabelNameOfItem.StylePriority.UseBorders = False
        Me.XrLabelNameOfItem.StylePriority.UseFont = False
        Me.XrLabelNameOfItem.StylePriority.UseTextAlignment = False
        Me.XrLabelNameOfItem.Text = "XrLabelNameOfItem"
        Me.XrLabelNameOfItem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelItemCategory
        '
        Me.XrLabelItemCategory.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelItemCategory.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ItemCategory")})
        Me.XrLabelItemCategory.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelItemCategory.LocationFloat = New DevExpress.Utils.PointFloat(250.5!, 61.0!)
        Me.XrLabelItemCategory.Name = "XrLabelItemCategory"
        Me.XrLabelItemCategory.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelItemCategory.SizeF = New System.Drawing.SizeF(246.875!, 23.0!)
        Me.XrLabelItemCategory.StylePriority.UseBorders = False
        Me.XrLabelItemCategory.StylePriority.UseFont = False
        Me.XrLabelItemCategory.StylePriority.UseTextAlignment = False
        Me.XrLabelItemCategory.Text = "XrLabelItemCategory"
        Me.XrLabelItemCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelRetailUnitPrice
        '
        Me.XrLabelRetailUnitPrice.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelRetailUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RetailUnitPrice, {0:n2}")})
        Me.XrLabelRetailUnitPrice.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelRetailUnitPrice.LocationFloat = New DevExpress.Utils.PointFloat(252.5833!, 129.7083!)
        Me.XrLabelRetailUnitPrice.Name = "XrLabelRetailUnitPrice"
        Me.XrLabelRetailUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelRetailUnitPrice.SizeF = New System.Drawing.SizeF(246.875!, 23.00001!)
        Me.XrLabelRetailUnitPrice.StylePriority.UseBorders = False
        Me.XrLabelRetailUnitPrice.StylePriority.UseFont = False
        Me.XrLabelRetailUnitPrice.StylePriority.UseTextAlignment = False
        Me.XrLabelRetailUnitPrice.Text = "XrLabelRetailUnitPrice"
        Me.XrLabelRetailUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelRetailUnitOfMeasurement
        '
        Me.XrLabelRetailUnitOfMeasurement.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelRetailUnitOfMeasurement.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RetailUnitOfMeasurement")})
        Me.XrLabelRetailUnitOfMeasurement.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelRetailUnitOfMeasurement.LocationFloat = New DevExpress.Utils.PointFloat(252.5833!, 155.7083!)
        Me.XrLabelRetailUnitOfMeasurement.Name = "XrLabelRetailUnitOfMeasurement"
        Me.XrLabelRetailUnitOfMeasurement.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelRetailUnitOfMeasurement.SizeF = New System.Drawing.SizeF(246.875!, 22.99998!)
        Me.XrLabelRetailUnitOfMeasurement.StylePriority.UseBorders = False
        Me.XrLabelRetailUnitOfMeasurement.StylePriority.UseFont = False
        Me.XrLabelRetailUnitOfMeasurement.StylePriority.UseTextAlignment = False
        Me.XrLabelRetailUnitOfMeasurement.Text = "XrLabelRetailUnitOfMeasurement"
        Me.XrLabelRetailUnitOfMeasurement.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelRetailQuantity
        '
        Me.XrLabelRetailQuantity.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelRetailQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RetailQuantity, {0:n2}")})
        Me.XrLabelRetailQuantity.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelRetailQuantity.LocationFloat = New DevExpress.Utils.PointFloat(252.5833!, 181.7083!)
        Me.XrLabelRetailQuantity.Name = "XrLabelRetailQuantity"
        Me.XrLabelRetailQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelRetailQuantity.SizeF = New System.Drawing.SizeF(246.875!, 23.0!)
        Me.XrLabelRetailQuantity.StylePriority.UseBorders = False
        Me.XrLabelRetailQuantity.StylePriority.UseFont = False
        Me.XrLabelRetailQuantity.StylePriority.UseTextAlignment = False
        Me.XrLabelRetailQuantity.Text = "XrLabelRetailQuantity"
        Me.XrLabelRetailQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelRetailLowQuantity
        '
        Me.XrLabelRetailLowQuantity.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelRetailLowQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RetailLowQuantity, {0:n2}")})
        Me.XrLabelRetailLowQuantity.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelRetailLowQuantity.LocationFloat = New DevExpress.Utils.PointFloat(252.5833!, 207.7084!)
        Me.XrLabelRetailLowQuantity.Name = "XrLabelRetailLowQuantity"
        Me.XrLabelRetailLowQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelRetailLowQuantity.SizeF = New System.Drawing.SizeF(246.875!, 23.0!)
        Me.XrLabelRetailLowQuantity.StylePriority.UseBorders = False
        Me.XrLabelRetailLowQuantity.StylePriority.UseFont = False
        Me.XrLabelRetailLowQuantity.StylePriority.UseTextAlignment = False
        Me.XrLabelRetailLowQuantity.Text = "XrLabelRetailLowQuantity"
        Me.XrLabelRetailLowQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelWholesaleUnitPrice
        '
        Me.XrLabelWholesaleUnitPrice.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelWholesaleUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "WholesaleUnitPrice, {0:n2}")})
        Me.XrLabelWholesaleUnitPrice.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelWholesaleUnitPrice.LocationFloat = New DevExpress.Utils.PointFloat(249.4583!, 274.3333!)
        Me.XrLabelWholesaleUnitPrice.Name = "XrLabelWholesaleUnitPrice"
        Me.XrLabelWholesaleUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelWholesaleUnitPrice.SizeF = New System.Drawing.SizeF(246.875!, 23.0!)
        Me.XrLabelWholesaleUnitPrice.StylePriority.UseBorders = False
        Me.XrLabelWholesaleUnitPrice.StylePriority.UseFont = False
        Me.XrLabelWholesaleUnitPrice.StylePriority.UseTextAlignment = False
        Me.XrLabelWholesaleUnitPrice.Text = "XrLabelWholesaleUnitPrice"
        Me.XrLabelWholesaleUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelWholesaleUnitOfMeasurement
        '
        Me.XrLabelWholesaleUnitOfMeasurement.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelWholesaleUnitOfMeasurement.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "WholesaleUnitOfMeasurement")})
        Me.XrLabelWholesaleUnitOfMeasurement.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelWholesaleUnitOfMeasurement.LocationFloat = New DevExpress.Utils.PointFloat(249.4583!, 300.3333!)
        Me.XrLabelWholesaleUnitOfMeasurement.Name = "XrLabelWholesaleUnitOfMeasurement"
        Me.XrLabelWholesaleUnitOfMeasurement.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelWholesaleUnitOfMeasurement.SizeF = New System.Drawing.SizeF(246.875!, 22.99998!)
        Me.XrLabelWholesaleUnitOfMeasurement.StylePriority.UseBorders = False
        Me.XrLabelWholesaleUnitOfMeasurement.StylePriority.UseFont = False
        Me.XrLabelWholesaleUnitOfMeasurement.StylePriority.UseTextAlignment = False
        Me.XrLabelWholesaleUnitOfMeasurement.Text = "XrLabelWholesaleUnitOfMeasurement"
        Me.XrLabelWholesaleUnitOfMeasurement.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelWholesaleQuantity
        '
        Me.XrLabelWholesaleQuantity.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelWholesaleQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "WholesaleQuantity, {0:n2}")})
        Me.XrLabelWholesaleQuantity.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelWholesaleQuantity.LocationFloat = New DevExpress.Utils.PointFloat(249.4583!, 326.3334!)
        Me.XrLabelWholesaleQuantity.Name = "XrLabelWholesaleQuantity"
        Me.XrLabelWholesaleQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelWholesaleQuantity.SizeF = New System.Drawing.SizeF(246.875!, 23.0!)
        Me.XrLabelWholesaleQuantity.StylePriority.UseBorders = False
        Me.XrLabelWholesaleQuantity.StylePriority.UseFont = False
        Me.XrLabelWholesaleQuantity.StylePriority.UseTextAlignment = False
        Me.XrLabelWholesaleQuantity.Text = "XrLabelWholesaleQuantity"
        Me.XrLabelWholesaleQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelWholesaleLowQuantity
        '
        Me.XrLabelWholesaleLowQuantity.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelWholesaleLowQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "WholesaleLowQuantity, {0:n2}")})
        Me.XrLabelWholesaleLowQuantity.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelWholesaleLowQuantity.LocationFloat = New DevExpress.Utils.PointFloat(249.4583!, 352.3333!)
        Me.XrLabelWholesaleLowQuantity.Name = "XrLabelWholesaleLowQuantity"
        Me.XrLabelWholesaleLowQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelWholesaleLowQuantity.SizeF = New System.Drawing.SizeF(246.875!, 23.0!)
        Me.XrLabelWholesaleLowQuantity.StylePriority.UseBorders = False
        Me.XrLabelWholesaleLowQuantity.StylePriority.UseFont = False
        Me.XrLabelWholesaleLowQuantity.StylePriority.UseTextAlignment = False
        Me.XrLabelWholesaleLowQuantity.Text = "XrLabelWholesaleLowQuantity"
        Me.XrLabelWholesaleLowQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelComment
        '
        Me.XrLabelComment.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabelComment.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Comment")})
        Me.XrLabelComment.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabelComment.LocationFloat = New DevExpress.Utils.PointFloat(250.5!, 406.4583!)
        Me.XrLabelComment.Name = "XrLabelComment"
        Me.XrLabelComment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelComment.SizeF = New System.Drawing.SizeF(246.875!, 23.0!)
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
        Me.XrLabelRegDate.LocationFloat = New DevExpress.Utils.PointFloat(250.5!, 432.4584!)
        Me.XrLabelRegDate.Name = "XrLabelRegDate"
        Me.XrLabelRegDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelRegDate.SizeF = New System.Drawing.SizeF(246.875!, 23.0!)
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
        Me.XrLabelInputedBy.LocationFloat = New DevExpress.Utils.PointFloat(250.5!, 458.4583!)
        Me.XrLabelInputedBy.Name = "XrLabelInputedBy"
        Me.XrLabelInputedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelInputedBy.SizeF = New System.Drawing.SizeF(246.875!, 23.0!)
        Me.XrLabelInputedBy.StylePriority.UseBorders = False
        Me.XrLabelInputedBy.StylePriority.UseFont = False
        Me.XrLabelInputedBy.StylePriority.UseTextAlignment = False
        Me.XrLabelInputedBy.Text = "XrLabelInputedBy"
        Me.XrLabelInputedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderStockID
        '
        Me.XrLabelHeaderStockID.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderStockID.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 7.999992!)
        Me.XrLabelHeaderStockID.Name = "XrLabelHeaderStockID"
        Me.XrLabelHeaderStockID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderStockID.SizeF = New System.Drawing.SizeF(229.1667!, 23.0!)
        Me.XrLabelHeaderStockID.StylePriority.UseFont = False
        Me.XrLabelHeaderStockID.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderStockID.Text = "Stock ID:"
        Me.XrLabelHeaderStockID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderNameOfItem
        '
        Me.XrLabelHeaderNameOfItem.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderNameOfItem.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 35.00001!)
        Me.XrLabelHeaderNameOfItem.Name = "XrLabelHeaderNameOfItem"
        Me.XrLabelHeaderNameOfItem.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderNameOfItem.SizeF = New System.Drawing.SizeF(229.1667!, 23.0!)
        Me.XrLabelHeaderNameOfItem.StylePriority.UseFont = False
        Me.XrLabelHeaderNameOfItem.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderNameOfItem.Text = "Name Of Item:"
        Me.XrLabelHeaderNameOfItem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderItemCategory
        '
        Me.XrLabelHeaderItemCategory.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderItemCategory.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 61.0!)
        Me.XrLabelHeaderItemCategory.Name = "XrLabelHeaderItemCategory"
        Me.XrLabelHeaderItemCategory.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderItemCategory.SizeF = New System.Drawing.SizeF(229.1667!, 23.0!)
        Me.XrLabelHeaderItemCategory.StylePriority.UseFont = False
        Me.XrLabelHeaderItemCategory.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderItemCategory.Text = "Item Category:"
        Me.XrLabelHeaderItemCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRetailUnitPrice
        '
        Me.XrLabelHeaderRetailUnitPrice.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRetailUnitPrice.LocationFloat = New DevExpress.Utils.PointFloat(15.08338!, 129.7083!)
        Me.XrLabelHeaderRetailUnitPrice.Name = "XrLabelHeaderRetailUnitPrice"
        Me.XrLabelHeaderRetailUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderRetailUnitPrice.SizeF = New System.Drawing.SizeF(229.1667!, 23.00001!)
        Me.XrLabelHeaderRetailUnitPrice.StylePriority.UseFont = False
        Me.XrLabelHeaderRetailUnitPrice.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderRetailUnitPrice.Text = "Retail Unit Price:"
        Me.XrLabelHeaderRetailUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRetailUnitOfMeasurement
        '
        Me.XrLabelHeaderRetailUnitOfMeasurement.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRetailUnitOfMeasurement.LocationFloat = New DevExpress.Utils.PointFloat(15.08338!, 155.7083!)
        Me.XrLabelHeaderRetailUnitOfMeasurement.Name = "XrLabelHeaderRetailUnitOfMeasurement"
        Me.XrLabelHeaderRetailUnitOfMeasurement.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderRetailUnitOfMeasurement.SizeF = New System.Drawing.SizeF(229.1667!, 22.99998!)
        Me.XrLabelHeaderRetailUnitOfMeasurement.StylePriority.UseFont = False
        Me.XrLabelHeaderRetailUnitOfMeasurement.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderRetailUnitOfMeasurement.Text = "Retail Unit Of Measurement:"
        Me.XrLabelHeaderRetailUnitOfMeasurement.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRetailQuantity
        '
        Me.XrLabelHeaderRetailQuantity.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRetailQuantity.LocationFloat = New DevExpress.Utils.PointFloat(15.08338!, 181.7083!)
        Me.XrLabelHeaderRetailQuantity.Name = "XrLabelHeaderRetailQuantity"
        Me.XrLabelHeaderRetailQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderRetailQuantity.SizeF = New System.Drawing.SizeF(229.1667!, 23.0!)
        Me.XrLabelHeaderRetailQuantity.StylePriority.UseFont = False
        Me.XrLabelHeaderRetailQuantity.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderRetailQuantity.Text = "Retail Quantity:"
        Me.XrLabelHeaderRetailQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRetailLowQuantity
        '
        Me.XrLabelHeaderRetailLowQuantity.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRetailLowQuantity.LocationFloat = New DevExpress.Utils.PointFloat(15.08338!, 207.7084!)
        Me.XrLabelHeaderRetailLowQuantity.Name = "XrLabelHeaderRetailLowQuantity"
        Me.XrLabelHeaderRetailLowQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderRetailLowQuantity.SizeF = New System.Drawing.SizeF(229.1667!, 23.0!)
        Me.XrLabelHeaderRetailLowQuantity.StylePriority.UseFont = False
        Me.XrLabelHeaderRetailLowQuantity.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderRetailLowQuantity.Text = "Retail Low Quantity:"
        Me.XrLabelHeaderRetailLowQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderWholesaleUnitPrice
        '
        Me.XrLabelHeaderWholesaleUnitPrice.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderWholesaleUnitPrice.LocationFloat = New DevExpress.Utils.PointFloat(11.95838!, 274.3333!)
        Me.XrLabelHeaderWholesaleUnitPrice.Name = "XrLabelHeaderWholesaleUnitPrice"
        Me.XrLabelHeaderWholesaleUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderWholesaleUnitPrice.SizeF = New System.Drawing.SizeF(229.1667!, 23.0!)
        Me.XrLabelHeaderWholesaleUnitPrice.StylePriority.UseFont = False
        Me.XrLabelHeaderWholesaleUnitPrice.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderWholesaleUnitPrice.Text = "Wholesale Unit Price:"
        Me.XrLabelHeaderWholesaleUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderWholesaleUnitOfMeasurement
        '
        Me.XrLabelHeaderWholesaleUnitOfMeasurement.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderWholesaleUnitOfMeasurement.LocationFloat = New DevExpress.Utils.PointFloat(11.95838!, 300.3333!)
        Me.XrLabelHeaderWholesaleUnitOfMeasurement.Name = "XrLabelHeaderWholesaleUnitOfMeasurement"
        Me.XrLabelHeaderWholesaleUnitOfMeasurement.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderWholesaleUnitOfMeasurement.SizeF = New System.Drawing.SizeF(229.1667!, 22.99998!)
        Me.XrLabelHeaderWholesaleUnitOfMeasurement.StylePriority.UseFont = False
        Me.XrLabelHeaderWholesaleUnitOfMeasurement.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderWholesaleUnitOfMeasurement.Text = "Wholesale Unit Of Measurement:"
        Me.XrLabelHeaderWholesaleUnitOfMeasurement.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderWholesaleQuantity
        '
        Me.XrLabelHeaderWholesaleQuantity.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderWholesaleQuantity.LocationFloat = New DevExpress.Utils.PointFloat(11.95838!, 326.3334!)
        Me.XrLabelHeaderWholesaleQuantity.Name = "XrLabelHeaderWholesaleQuantity"
        Me.XrLabelHeaderWholesaleQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderWholesaleQuantity.SizeF = New System.Drawing.SizeF(229.1667!, 23.0!)
        Me.XrLabelHeaderWholesaleQuantity.StylePriority.UseFont = False
        Me.XrLabelHeaderWholesaleQuantity.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderWholesaleQuantity.Text = "Wholesale Quantity:"
        Me.XrLabelHeaderWholesaleQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderWholesaleLowQuantity
        '
        Me.XrLabelHeaderWholesaleLowQuantity.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderWholesaleLowQuantity.LocationFloat = New DevExpress.Utils.PointFloat(11.95838!, 352.3333!)
        Me.XrLabelHeaderWholesaleLowQuantity.Name = "XrLabelHeaderWholesaleLowQuantity"
        Me.XrLabelHeaderWholesaleLowQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderWholesaleLowQuantity.SizeF = New System.Drawing.SizeF(229.1667!, 23.0!)
        Me.XrLabelHeaderWholesaleLowQuantity.StylePriority.UseFont = False
        Me.XrLabelHeaderWholesaleLowQuantity.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderWholesaleLowQuantity.Text = "Wholesale Low Quantity:"
        Me.XrLabelHeaderWholesaleLowQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderComment
        '
        Me.XrLabelHeaderComment.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderComment.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 406.4583!)
        Me.XrLabelHeaderComment.Name = "XrLabelHeaderComment"
        Me.XrLabelHeaderComment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderComment.SizeF = New System.Drawing.SizeF(229.1667!, 23.0!)
        Me.XrLabelHeaderComment.StylePriority.UseFont = False
        Me.XrLabelHeaderComment.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderComment.Text = "Comment:"
        Me.XrLabelHeaderComment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderRegDate
        '
        Me.XrLabelHeaderRegDate.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderRegDate.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 432.4584!)
        Me.XrLabelHeaderRegDate.Name = "XrLabelHeaderRegDate"
        Me.XrLabelHeaderRegDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderRegDate.SizeF = New System.Drawing.SizeF(229.1667!, 23.0!)
        Me.XrLabelHeaderRegDate.StylePriority.UseFont = False
        Me.XrLabelHeaderRegDate.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderRegDate.Text = "Reg Date:"
        Me.XrLabelHeaderRegDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabelHeaderInputedBy
        '
        Me.XrLabelHeaderInputedBy.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabelHeaderInputedBy.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 458.4583!)
        Me.XrLabelHeaderInputedBy.Name = "XrLabelHeaderInputedBy"
        Me.XrLabelHeaderInputedBy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabelHeaderInputedBy.SizeF = New System.Drawing.SizeF(229.1667!, 23.0!)
        Me.XrLabelHeaderInputedBy.StylePriority.UseFont = False
        Me.XrLabelHeaderInputedBy.StylePriority.UseTextAlignment = False
        Me.XrLabelHeaderInputedBy.Text = "Inputed By:"
        Me.XrLabelHeaderInputedBy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        'InventoryDataSource
        '
        Me.InventoryDataSource.DataSource = GetType(MoCTIMIS.InventoryTable.InventoryTableDataTable)
        Me.InventoryDataSource.Name = "InventoryDataSource"
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(14.04171!, 103.7083!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(229.1667!, 23.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "RETAIL SECTION"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(13.00004!, 249.5417!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(229.1667!, 23.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "WHOLESALE SECTION"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XtraReportInventorySingle
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter})
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
    Public WithEvents XrLabelReportDateCriteria As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportDateField As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLabelReportCriteriaLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelStockID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderStockID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelNameOfItem As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderNameOfItem As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelItemCategory As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderItemCategory As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRetailUnitPrice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRetailUnitPrice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRetailUnitOfMeasurement As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRetailUnitOfMeasurement As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRetailQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRetailQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRetailLowQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRetailLowQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelWholesaleUnitPrice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderWholesaleUnitPrice As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelWholesaleUnitOfMeasurement As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderWholesaleUnitOfMeasurement As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelWholesaleQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderWholesaleQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelWholesaleLowQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderWholesaleLowQuantity As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderComment As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelRegDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderRegDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelInputedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabelHeaderInputedBy As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
End Class

