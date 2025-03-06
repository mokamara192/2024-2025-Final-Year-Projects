Public Class XtraReportLetterheadTemplate
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Public WithEvents DebtorsDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Public WithEvents CompanySettingsDataSource As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrPictureBox3 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox9 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox8 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox7 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox6 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox5 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox12 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox11 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox10 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox17 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox16 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox14 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox13 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox15 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox18 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReportLetterheadTemplate))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPictureBox18 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox17 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox16 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox14 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox13 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox12 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox11 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox10 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox9 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox8 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox7 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox6 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox5 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox15 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.CompanySettingsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DebtorsDataSource = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        CType(Me.XrRichText1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CompanySettingsDataSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DebtorsDataSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText1, Me.XrLine1, Me.XrPictureBox18, Me.XrPictureBox17, Me.XrPictureBox16, Me.XrPictureBox14, Me.XrPictureBox13, Me.XrPictureBox12, Me.XrPictureBox11, Me.XrPictureBox10, Me.XrPictureBox9, Me.XrPictureBox8, Me.XrPictureBox7, Me.XrPictureBox6, Me.XrPictureBox5, Me.XrPictureBox4, Me.XrPictureBox3, Me.XrPictureBox15})
        Me.Detail.HeightF = 852.0833!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrRichText1
        '
        Me.XrRichText1.Font = New System.Drawing.Font("Calibri", 12!)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(12.66667!, 3.125!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(730.2084!, 691.6667!)
        Me.XrRichText1.StylePriority.UseFont = false
        '
        'XrLine1
        '
        Me.XrLine1.BorderColor = System.Drawing.Color.DarkGray
        Me.XrLine1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLine1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLine1.BorderWidth = 2!
        Me.XrLine1.ForeColor = System.Drawing.Color.Chocolate
        Me.XrLine1.LineWidth = 2
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(11.00016!, 709.5833!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(728.9167!, 4.166687!)
        Me.XrLine1.StylePriority.UseBorderColor = false
        Me.XrLine1.StylePriority.UseBorderDashStyle = false
        Me.XrLine1.StylePriority.UseBorders = false
        Me.XrLine1.StylePriority.UseBorderWidth = false
        Me.XrLine1.StylePriority.UseForeColor = false
        '
        'XrPictureBox18
        '
        Me.XrPictureBox18.BorderWidth = 0!
        Me.XrPictureBox18.Image = CType(resources.GetObject("XrPictureBox18.Image"),System.Drawing.Image)
        Me.XrPictureBox18.LocationFloat = New DevExpress.Utils.PointFloat(631.2515!, 795.0416!)
        Me.XrPictureBox18.Name = "XrPictureBox18"
        Me.XrPictureBox18.SizeF = New System.Drawing.SizeF(62.58337!, 35.83325!)
        Me.XrPictureBox18.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox18.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox17
        '
        Me.XrPictureBox17.BorderWidth = 0!
        Me.XrPictureBox17.Image = CType(resources.GetObject("XrPictureBox17.Image"),System.Drawing.Image)
        Me.XrPictureBox17.LocationFloat = New DevExpress.Utils.PointFloat(537.5012!, 799.0416!)
        Me.XrPictureBox17.Name = "XrPictureBox17"
        Me.XrPictureBox17.SizeF = New System.Drawing.SizeF(101.1251!, 35.83325!)
        Me.XrPictureBox17.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox17.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox16
        '
        Me.XrPictureBox16.BorderWidth = 0!
        Me.XrPictureBox16.Image = CType(resources.GetObject("XrPictureBox16.Image"),System.Drawing.Image)
        Me.XrPictureBox16.LocationFloat = New DevExpress.Utils.PointFloat(418.6254!, 794.8749!)
        Me.XrPictureBox16.Name = "XrPictureBox16"
        Me.XrPictureBox16.SizeF = New System.Drawing.SizeF(117.7917!, 41.04163!)
        Me.XrPictureBox16.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox16.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox14
        '
        Me.XrPictureBox14.BorderWidth = 0!
        Me.XrPictureBox14.Image = CType(resources.GetObject("XrPictureBox14.Image"),System.Drawing.Image)
        Me.XrPictureBox14.LocationFloat = New DevExpress.Utils.PointFloat(201.9586!, 792.7916!)
        Me.XrPictureBox14.Name = "XrPictureBox14"
        Me.XrPictureBox14.SizeF = New System.Drawing.SizeF(117.7917!, 41.04163!)
        Me.XrPictureBox14.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox14.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox13
        '
        Me.XrPictureBox13.BorderWidth = 0!
        Me.XrPictureBox13.Image = CType(resources.GetObject("XrPictureBox13.Image"),System.Drawing.Image)
        Me.XrPictureBox13.LocationFloat = New DevExpress.Utils.PointFloat(88.41702!, 796.9167!)
        Me.XrPictureBox13.Name = "XrPictureBox13"
        Me.XrPictureBox13.SizeF = New System.Drawing.SizeF(111.5417!, 36.875!)
        Me.XrPictureBox13.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox13.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox12
        '
        Me.XrPictureBox12.BorderWidth = 0!
        Me.XrPictureBox12.Image = CType(resources.GetObject("XrPictureBox12.Image"),System.Drawing.Image)
        Me.XrPictureBox12.LocationFloat = New DevExpress.Utils.PointFloat(384.8335!, 721.9584!)
        Me.XrPictureBox12.Name = "XrPictureBox12"
        Me.XrPictureBox12.SizeF = New System.Drawing.SizeF(60.41666!, 62.91663!)
        Me.XrPictureBox12.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox12.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox11
        '
        Me.XrPictureBox11.BorderWidth = 0!
        Me.XrPictureBox11.Image = CType(resources.GetObject("XrPictureBox11.Image"),System.Drawing.Image)
        Me.XrPictureBox11.LocationFloat = New DevExpress.Utils.PointFloat(48.83353!, 733.4166!)
        Me.XrPictureBox11.Name = "XrPictureBox11"
        Me.XrPictureBox11.SizeF = New System.Drawing.SizeF(78.20833!, 62.91663!)
        Me.XrPictureBox11.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox11.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox10
        '
        Me.XrPictureBox10.BorderWidth = 0!
        Me.XrPictureBox10.Image = CType(resources.GetObject("XrPictureBox10.Image"),System.Drawing.Image)
        Me.XrPictureBox10.LocationFloat = New DevExpress.Utils.PointFloat(564.5837!, 734.4581!)
        Me.XrPictureBox10.Name = "XrPictureBox10"
        Me.XrPictureBox10.SizeF = New System.Drawing.SizeF(78.20833!, 62.91663!)
        Me.XrPictureBox10.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox10.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox9
        '
        Me.XrPictureBox9.BorderWidth = 0!
        Me.XrPictureBox9.Image = CType(resources.GetObject("XrPictureBox9.Image"),System.Drawing.Image)
        Me.XrPictureBox9.LocationFloat = New DevExpress.Utils.PointFloat(441.1252!, 726.8751!)
        Me.XrPictureBox9.Name = "XrPictureBox9"
        Me.XrPictureBox9.SizeF = New System.Drawing.SizeF(68.75!, 67.08325!)
        Me.XrPictureBox9.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox9.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox8
        '
        Me.XrPictureBox8.BorderWidth = 0!
        Me.XrPictureBox8.Image = CType(resources.GetObject("XrPictureBox8.Image"),System.Drawing.Image)
        Me.XrPictureBox8.LocationFloat = New DevExpress.Utils.PointFloat(509.0836!, 730.2084!)
        Me.XrPictureBox8.Name = "XrPictureBox8"
        Me.XrPictureBox8.SizeF = New System.Drawing.SizeF(67.70825!, 66.04163!)
        Me.XrPictureBox8.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox8.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox7
        '
        Me.XrPictureBox7.BorderWidth = 0!
        Me.XrPictureBox7.Image = CType(resources.GetObject("XrPictureBox7.Image"),System.Drawing.Image)
        Me.XrPictureBox7.LocationFloat = New DevExpress.Utils.PointFloat(641.9586!, 734.7917!)
        Me.XrPictureBox7.Name = "XrPictureBox7"
        Me.XrPictureBox7.SizeF = New System.Drawing.SizeF(60.41666!, 62.91663!)
        Me.XrPictureBox7.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox7.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox6
        '
        Me.XrPictureBox6.BorderWidth = 0!
        Me.XrPictureBox6.Image = CType(resources.GetObject("XrPictureBox6.Image"),System.Drawing.Image)
        Me.XrPictureBox6.LocationFloat = New DevExpress.Utils.PointFloat(323.6252!, 721.9581!)
        Me.XrPictureBox6.Name = "XrPictureBox6"
        Me.XrPictureBox6.SizeF = New System.Drawing.SizeF(60.41663!, 62.91669!)
        Me.XrPictureBox6.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox6.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox5
        '
        Me.XrPictureBox5.BorderWidth = 0!
        Me.XrPictureBox5.Image = CType(resources.GetObject("XrPictureBox5.Image"),System.Drawing.Image)
        Me.XrPictureBox5.LocationFloat = New DevExpress.Utils.PointFloat(257.6252!, 719.8752!)
        Me.XrPictureBox5.Name = "XrPictureBox5"
        Me.XrPictureBox5.SizeF = New System.Drawing.SizeF(60.41666!, 62.91663!)
        Me.XrPictureBox5.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox5.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox4
        '
        Me.XrPictureBox4.BorderWidth = 0!
        Me.XrPictureBox4.Image = CType(resources.GetObject("XrPictureBox4.Image"),System.Drawing.Image)
        Me.XrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(125.2084!, 730.1666!)
        Me.XrPictureBox4.Name = "XrPictureBox4"
        Me.XrPictureBox4.SizeF = New System.Drawing.SizeF(60.41666!, 62.91669!)
        Me.XrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox4.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.BorderWidth = 0!
        Me.XrPictureBox3.Image = CType(resources.GetObject("XrPictureBox3.Image"),System.Drawing.Image)
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(185.2918!, 726.8751!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(78.20833!, 62.91663!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox3.StylePriority.UseBorderWidth = false
        '
        'XrPictureBox15
        '
        Me.XrPictureBox15.BorderWidth = 0!
        Me.XrPictureBox15.Image = CType(resources.GetObject("XrPictureBox15.Image"),System.Drawing.Image)
        Me.XrPictureBox15.LocationFloat = New DevExpress.Utils.PointFloat(305.0837!, 791.7499!)
        Me.XrPictureBox15.Name = "XrPictureBox15"
        Me.XrPictureBox15.SizeF = New System.Drawing.SizeF(126.125!, 44.16663!)
        Me.XrPictureBox15.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        Me.XrPictureBox15.StylePriority.UseBorderWidth = False
        '
        'CompanySettingsDataSource
        '
        Me.CompanySettingsDataSource.DataSource = GetType(MoCTIMIS.CompanySettingDataSet.CompanySettingDataTableDataTable)
        Me.CompanySettingsDataSource.Name = "CompanySettingsDataSource"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 30.5!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 13.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DebtorsDataSource
        '
        Me.DebtorsDataSource.DataSource = GetType(MoCTIMIS.DebtorsTable.DebtorsTableDataTable)
        Me.DebtorsDataSource.Name = "DebtorsDataSource"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8, Me.XrLabel6, Me.XrLabel12, Me.XrLabel5, Me.XrLine3, Me.XrLine2, Me.XrLabel1, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4, Me.XrLabel7, Me.XrPictureBox1})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("DebtorID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 255.625!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBandExceptFirstEntry
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "SubName")})
        Me.XrLabel8.Font = New System.Drawing.Font("Segoe Script", 12!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(138.4167!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(245.8333!, 23!)
        Me.XrLabel8.StylePriority.UseFont = false
        Me.XrLabel8.Text = "XrLabel12"
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "RegistrationNo")})
        Me.XrLabel6.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(105.6565!, 229.8541!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(224.9999!, 23.00003!)
        Me.XrLabel6.StylePriority.UseFont = false
        Me.XrLabel6.StylePriority.UseTextAlignment = false
        Me.XrLabel6.Text = "XrLabel5"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(16.09386!, 229.8541!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(89.50014!, 22.99997!)
        Me.XrLabel12.StylePriority.UseFont = false
        Me.XrLabel12.StylePriority.UseTextAlignment = false
        Me.XrLabel12.Text = "License No:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.DimGray
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 12!)
        Me.XrLabel5.ForeColor = System.Drawing.Color.White
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(15.79167!, 189.5833!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(729.1667!, 31.25!)
        Me.XrLabel5.StylePriority.UseBackColor = false
        Me.XrLabel5.StylePriority.UseFont = false
        Me.XrLabel5.StylePriority.UseForeColor = false
        Me.XrLabel5.StylePriority.UseTextAlignment = false
        Me.XrLabel5.Text = "TO WHOM IT MAY CONCERN"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine3
        '
        Me.XrLine3.BorderColor = System.Drawing.Color.DarkGray
        Me.XrLine3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLine3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine3.BorderWidth = 1!
        Me.XrLine3.ForeColor = System.Drawing.Color.DimGray
        Me.XrLine3.LineWidth = 5
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(16.33331!, 178.8958!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(726.75!, 5!)
        Me.XrLine3.StylePriority.UseBorderColor = false
        Me.XrLine3.StylePriority.UseBorderDashStyle = false
        Me.XrLine3.StylePriority.UseBorders = false
        Me.XrLine3.StylePriority.UseBorderWidth = false
        Me.XrLine3.StylePriority.UseForeColor = false
        '
        'XrLine2
        '
        Me.XrLine2.BorderColor = System.Drawing.Color.DarkGray
        Me.XrLine2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLine2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLine2.BorderWidth = 2!
        Me.XrLine2.ForeColor = System.Drawing.Color.Chocolate
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(15.16663!, 222.6459!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(728.9167!, 4.166687!)
        Me.XrLine2.StylePriority.UseBorderColor = false
        Me.XrLine2.StylePriority.UseBorderDashStyle = false
        Me.XrLine2.StylePriority.UseBorders = false
        Me.XrLine2.StylePriority.UseBorderWidth = false
        Me.XrLine2.StylePriority.UseForeColor = false
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "NameofCompany")})
        Me.XrLabel1.Font = New System.Drawing.Font("Segoe UI", 28!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(127.1926!, 16.16657!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(531.5728!, 46!)
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.StylePriority.UseTextAlignment = false
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "Address")})
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(232.8177!, 60.12491!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(332.2916!, 20!)
        Me.XrLabel2.StylePriority.UseFont = false
        Me.XrLabel2.StylePriority.UseTextAlignment = false
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "PhoneNo")})
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(233.8176!, 78.12499!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(332.2916!, 20!)
        Me.XrLabel3.StylePriority.UseFont = false
        Me.XrLabel3.StylePriority.UseTextAlignment = false
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.CompanySettingsDataSource, "Email")})
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 11!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(233.8176!, 96.12507!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(332.2916!, 20!)
        Me.XrLabel4.StylePriority.UseFont = false
        Me.XrLabel4.StylePriority.UseTextAlignment = false
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Segoe UI", 15!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(11.90116!, 112.6251!)
        Me.XrLabel7.Multiline = true
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(733.3644!, 61.37491!)
        Me.XrLabel7.StylePriority.UseFont = false
        Me.XrLabel7.StylePriority.UseTextAlignment = false
        Me.XrLabel7.Text = "Importer of Computers, Stationaries, Phones and General Accessories. "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Providing "& _ 
    "Hardware Maintenance, Networking and General ICT Supports"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.CompanySettingsDataSource, "Logo")})
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(19.98974!, 9.999911!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(103.125!, 96.16685!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'GroupFooter1
        '
        Me.GroupFooter1.HeightF = 9.375!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'PageHeader
        '
        Me.PageHeader.HeightF = 0!
        Me.PageHeader.Name = "PageHeader"
        '
        'ReportHeader
        '
        Me.ReportHeader.HeightF = 0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XtraReportLetterheadTemplate
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupFooter1, Me.PageHeader, Me.ReportHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DebtorsDataSource, Me.CompanySettingsDataSource})
        Me.DataSource = Me.DebtorsDataSource
        Me.Margins = New System.Drawing.Printing.Margins(29, 45, 30, 13)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None
        Me.Version = "17.2"
        CType(Me.XrRichText1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CompanySettingsDataSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DebtorsDataSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

End Class