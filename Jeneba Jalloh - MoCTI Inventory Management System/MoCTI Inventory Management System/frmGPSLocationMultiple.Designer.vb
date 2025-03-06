<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPSLocationMultiple
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try

    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGPSLocationMultiple))
        Dim MapTypeControlOptions1 As Pegazux.GoogleMaps.MapTypeControlOptions = New Pegazux.GoogleMaps.MapTypeControlOptions()
        Dim NavigationControlOptions1 As Pegazux.GoogleMaps.NavigationControlOptions = New Pegazux.GoogleMaps.NavigationControlOptions()
        Dim ScaleControlOptions1 As Pegazux.GoogleMaps.ScaleControlOptions = New Pegazux.GoogleMaps.ScaleControlOptions()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbMapType = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbZoom = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.btnMoveLeft = New System.Windows.Forms.ToolStripButton()
        Me.btnMoveDown = New System.Windows.Forms.ToolStripButton()
        Me.btnMoveUp = New System.Windows.Forms.ToolStripButton()
        Me.btnMoveRight = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.cmdAddMarker = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.cmdAddAllMarkers = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblBounds = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblMousePosition = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel11 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblMapZoom = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.PanelGPSLocator = New System.Windows.Forms.Panel()
        Me.PartyOfficesDataGridView = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GoogleMap1 = New Pegazux.GoogleMaps.GoogleMap()
        Me.tmrLocateResidence = New System.Windows.Forms.Timer(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tmrAddMarkers = New System.Windows.Forms.Timer(Me.components)
        Me.cmdMeasurePropertyArea = New System.Windows.Forms.Button()
        Me.PanelCOVER = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdFullScreen = New System.Windows.Forms.Button()
        Me.cmdCaptureScreen = New System.Windows.Forms.Button()
        Me.lblAddingMarkers = New System.Windows.Forms.Label()
        Me.tmrAnimateMarkers = New System.Windows.Forms.Timer(Me.components)
        Me.cmdCancel = New System.Windows.Forms.Label()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.ToolStrip1.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        Me.StatusStrip2.SuspendLayout
        Me.ToolStrip2.SuspendLayout
        Me.PanelGPSLocator.SuspendLayout
        CType(Me.PartyOfficesDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelCOVER.SuspendLayout
        CType(Me.SplitContainerControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainerControl1.SuspendLayout
        Me.SuspendLayout
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(78,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(97,Byte),Integer))
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripLabel1, Me.cmbMapType, Me.ToolStripLabel2, Me.cmbZoom, Me.ToolStripLabel3, Me.btnMoveLeft, Me.btnMoveDown, Me.btnMoveUp, Me.btnMoveRight, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.cmdAddMarker, Me.ToolStripSeparator2, Me.ToolStripButton7, Me.cmdAddAllMarkers})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1020, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = Global.MoCTIMIS.My.Resources.Resources.arrow_circle_double_135
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(90, 22)
        Me.ToolStripButton2.Text = "Restart Map"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.ToolStripLabel1.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripLabel1.Text = "Map type:"
        '
        'cmbMapType
        '
        Me.cmbMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMapType.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.cmbMapType.Name = "cmbMapType"
        Me.cmbMapType.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.ToolStripLabel2.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripLabel2.Text = "Zoom:"
        '
        'cmbZoom
        '
        Me.cmbZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbZoom.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.cmbZoom.Items.AddRange(New Object() {"0%", "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%", "110%", "120%", "130%", "140%", "150%", "160%", "170%", "180%", "190%", "200%", "210%"})
        Me.cmbZoom.Name = "cmbZoom"
        Me.cmbZoom.Size = New System.Drawing.Size(75, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.ToolStripLabel3.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripLabel3.Text = "Navigation:"
        '
        'btnMoveLeft
        '
        Me.btnMoveLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMoveLeft.Image = Global.MoCTIMIS.My.Resources.Resources.arrow_180
        Me.btnMoveLeft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMoveLeft.Name = "btnMoveLeft"
        Me.btnMoveLeft.Size = New System.Drawing.Size(23, 22)
        Me.btnMoveLeft.Text = "Move left"
        '
        'btnMoveDown
        '
        Me.btnMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMoveDown.Image = Global.MoCTIMIS.My.Resources.Resources.arrow_270
        Me.btnMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.Size = New System.Drawing.Size(23, 22)
        Me.btnMoveDown.Text = "Move down"
        '
        'btnMoveUp
        '
        Me.btnMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMoveUp.Image = Global.MoCTIMIS.My.Resources.Resources.arrow_090
        Me.btnMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(23, 22)
        Me.btnMoveUp.Text = "Move up"
        '
        'btnMoveRight
        '
        Me.btnMoveRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMoveRight.Image = Global.MoCTIMIS.My.Resources.Resources.arrow
        Me.btnMoveRight.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMoveRight.Name = "btnMoveRight"
        Me.btnMoveRight.Size = New System.Drawing.Size(23, 22)
        Me.btnMoveRight.Text = "Move right"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.MoCTIMIS.My.Resources.Resources.printer
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(79, 22)
        Me.ToolStripButton1.Text = "Print map"
        '
        'cmdAddMarker
        '
        Me.cmdAddMarker.Enabled = False
        Me.cmdAddMarker.ForeColor = System.Drawing.Color.White
        Me.cmdAddMarker.Image = Global.MoCTIMIS.My.Resources.Resources.marker
        Me.cmdAddMarker.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAddMarker.Name = "cmdAddMarker"
        Me.cmdAddMarker.Size = New System.Drawing.Size(89, 22)
        Me.cmdAddMarker.Text = "Add marker"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton7.Image = Global.MoCTIMIS.My.Resources.Resources.iPhoto_icon
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(89, 22)
        Me.ToolStripButton7.Text = "Save Screen"
        '
        'cmdAddAllMarkers
        '
        Me.cmdAddAllMarkers.Enabled = False
        Me.cmdAddAllMarkers.ForeColor = System.Drawing.Color.White
        Me.cmdAddAllMarkers.Image = Global.MoCTIMIS.My.Resources.Resources.marker
        Me.cmdAddAllMarkers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAddAllMarkers.Name = "cmdAddAllMarkers"
        Me.cmdAddAllMarkers.Size = New System.Drawing.Size(104, 22)
        Me.cmdAddAllMarkers.Text = "Add all marker"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl1, Me.lblBounds, Me.ToolStripStatusLabel1, Me.info})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 611)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1020, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(77, 17)
        Me.lbl1.Text = "Map Bounds:"
        '
        'lblBounds
        '
        Me.lblBounds.BackColor = System.Drawing.Color.Transparent
        Me.lblBounds.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBounds.Name = "lblBounds"
        Me.lblBounds.Size = New System.Drawing.Size(30, 17)
        Me.lblBounds.Text = "(0,0)"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(28, 17)
        Me.ToolStripStatusLabel1.Text = "       "
        '
        'info
        '
        Me.info.BackColor = System.Drawing.Color.Transparent
        Me.info.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(16, 17)
        Me.info.Text = "..."
        '
        'StatusStrip2
        '
        Me.StatusStrip2.BackgroundImage = Global.MoCTIMIS.My.Resources.Resources.TOOLBAR2
        Me.StatusStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8, Me.lblMousePosition, Me.ToolStripStatusLabel10, Me.ToolStripStatusLabel11, Me.lblMapZoom})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 589)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(1020, 22)
        Me.StatusStrip2.TabIndex = 18
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(72, 17)
        Me.ToolStripStatusLabel5.Text = "Map Center:"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(30, 17)
        Me.ToolStripStatusLabel6.Text = "(0,0)"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(28, 17)
        Me.ToolStripStatusLabel7.Text = "       "
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(92, 17)
        Me.ToolStripStatusLabel8.Text = "Mouse position:"
        '
        'lblMousePosition
        '
        Me.lblMousePosition.BackColor = System.Drawing.Color.Transparent
        Me.lblMousePosition.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMousePosition.Name = "lblMousePosition"
        Me.lblMousePosition.Size = New System.Drawing.Size(30, 17)
        Me.lblMousePosition.Text = "(0,0)"
        '
        'ToolStripStatusLabel10
        '
        Me.ToolStripStatusLabel10.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel10.Name = "ToolStripStatusLabel10"
        Me.ToolStripStatusLabel10.Size = New System.Drawing.Size(673, 17)
        Me.ToolStripStatusLabel10.Spring = True
        '
        'ToolStripStatusLabel11
        '
        Me.ToolStripStatusLabel11.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripStatusLabel11.Name = "ToolStripStatusLabel11"
        Me.ToolStripStatusLabel11.Size = New System.Drawing.Size(67, 17)
        Me.ToolStripStatusLabel11.Text = "Map zoom:"
        '
        'lblMapZoom
        '
        Me.lblMapZoom.BackColor = System.Drawing.Color.Transparent
        Me.lblMapZoom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMapZoom.Name = "lblMapZoom"
        Me.lblMapZoom.Size = New System.Drawing.Size(13, 17)
        Me.lblMapZoom.Text = "0"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackgroundImage = Global.MoCTIMIS.My.Resources.Resources.TOOLBAR
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton6})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1020, 25)
        Me.ToolStrip2.TabIndex = 20
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(64, 22)
        Me.ToolStripButton3.Text = "FitBounds"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripButton4.Text = "PanBy"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripButton5.Text = "PanTo"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(84, 22)
        Me.ToolStripButton6.Text = "PanToBounds"
        '
        'PanelGPSLocator
        '
        Me.PanelGPSLocator.BackColor = System.Drawing.Color.White
        Me.PanelGPSLocator.Controls.Add(Me.PartyOfficesDataGridView)
        Me.PanelGPSLocator.Controls.Add(Me.lblTitle)
        Me.PanelGPSLocator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGPSLocator.Location = New System.Drawing.Point(0, 0)
        Me.PanelGPSLocator.Name = "PanelGPSLocator"
        Me.PanelGPSLocator.Size = New System.Drawing.Size(293, 536)
        Me.PanelGPSLocator.TabIndex = 21
        '
        'PartyOfficesDataGridView
        '
        Me.PartyOfficesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PartyOfficesDataGridView.Location = New System.Drawing.Point(7, 26)
        Me.PartyOfficesDataGridView.MainView = Me.GridView1
        Me.PartyOfficesDataGridView.Name = "PartyOfficesDataGridView"
        Me.PartyOfficesDataGridView.Size = New System.Drawing.Size(282, 507)
        Me.PartyOfficesDataGridView.TabIndex = 3
        Me.PartyOfficesDataGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.PartyOfficesDataGridView
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(7, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(212, 16)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "List of all Processed Records"
        '
        'GoogleMap1
        '
        Me.GoogleMap1.AutoSize = True
        Me.GoogleMap1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GoogleMap1.BackGroundColor = System.Drawing.Color.Empty
        Me.GoogleMap1.Center.Lat = 1.05462794227589R
        Me.GoogleMap1.Center.Lng = -28.4765625R
        Me.GoogleMap1.Center.NoWrap = False
        Me.GoogleMap1.DisableDefaultUI = False
        Me.GoogleMap1.DisableDoubleClickZoom = False
        Me.GoogleMap1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GoogleMap1.Draggable = True
        Me.GoogleMap1.DraggableCursor = Pegazux.GoogleMaps.Cursors.pointer
        Me.GoogleMap1.DraggingCursor = Pegazux.GoogleMaps.Cursors.move
        Me.GoogleMap1.KeyboardShortcuts = True
        Me.GoogleMap1.Location = New System.Drawing.Point(0, 0)
        Me.GoogleMap1.MapTypeControl = True
        MapTypeControlOptions1.MapTypeIds = New Pegazux.GoogleMaps.MapTypeId() {Pegazux.GoogleMaps.MapTypeId.TERRAIN, Pegazux.GoogleMaps.MapTypeId.ROADMAP, Pegazux.GoogleMaps.MapTypeId.ROADMAP, Pegazux.GoogleMaps.MapTypeId.ROADMAP}
        MapTypeControlOptions1.Position = Pegazux.GoogleMaps.ControlPosition.TOP_RIGHT
        MapTypeControlOptions1.Style = Pegazux.GoogleMaps.MapTypeControlStyle.DROPDOWN_MENU
        Me.GoogleMap1.MapTypeControlOptions = MapTypeControlOptions1
        Me.GoogleMap1.MapTypeId = Pegazux.GoogleMaps.MapTypeId.ROADMAP
        Me.GoogleMap1.Name = "GoogleMap1"
        Me.GoogleMap1.NavigationControl = True
        NavigationControlOptions1.Position = Pegazux.GoogleMaps.ControlPosition.LEFT_TOP
        NavigationControlOptions1.Style = Pegazux.GoogleMaps.NavigationControlStyle.ZOOM_PAN
        Me.GoogleMap1.NavigationControlOptions = NavigationControlOptions1
        Me.GoogleMap1.NoClear = False
        Me.GoogleMap1.ScaleControl = True
        ScaleControlOptions1.Position = Pegazux.GoogleMaps.ControlPosition.BOTTOM_LEFT
        Me.GoogleMap1.ScaleControlOptions = ScaleControlOptions1
        Me.GoogleMap1.Scrollwheel = False
        Me.GoogleMap1.ShowControls = True
        Me.GoogleMap1.Size = New System.Drawing.Size(716, 536)
        Me.GoogleMap1.StreetViewControl = True
        Me.GoogleMap1.TabIndex = 22
        Me.GoogleMap1.UseMarkerClusterer = False
        Me.GoogleMap1.Zoom = 1
        '
        'tmrLocateResidence
        '
        Me.tmrLocateResidence.Interval = 1000
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.BackgroundImage = Global.MoCTIMIS.My.Resources.Resources.TOOLBAR
        Me.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdClose.FlatAppearance.BorderSize = 0
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(930, 25)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(90, 24)
        Me.cmdClose.TabIndex = 23
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'tmrAddMarkers
        '
        Me.tmrAddMarkers.Interval = 250
        '
        'cmdMeasurePropertyArea
        '
        Me.cmdMeasurePropertyArea.BackgroundImage = Global.MoCTIMIS.My.Resources.Resources.TOOLBAR
        Me.cmdMeasurePropertyArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdMeasurePropertyArea.FlatAppearance.BorderSize = 0
        Me.cmdMeasurePropertyArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMeasurePropertyArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMeasurePropertyArea.ForeColor = System.Drawing.Color.White
        Me.cmdMeasurePropertyArea.Location = New System.Drawing.Point(244, 25)
        Me.cmdMeasurePropertyArea.Name = "cmdMeasurePropertyArea"
        Me.cmdMeasurePropertyArea.Size = New System.Drawing.Size(151, 24)
        Me.cmdMeasurePropertyArea.TabIndex = 24
        Me.cmdMeasurePropertyArea.Text = "Measure Property Area"
        Me.cmdMeasurePropertyArea.UseVisualStyleBackColor = True
        '
        'PanelCOVER
        '
        Me.PanelCOVER.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelCOVER.BackColor = System.Drawing.Color.DimGray
        Me.PanelCOVER.Controls.Add(Me.Label8)
        Me.PanelCOVER.Controls.Add(Me.Label7)
        Me.PanelCOVER.Controls.Add(Me.Label6)
        Me.PanelCOVER.Location = New System.Drawing.Point(0, 527)
        Me.PanelCOVER.Name = "PanelCOVER"
        Me.PanelCOVER.Size = New System.Drawing.Size(384, 62)
        Me.PanelCOVER.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(5, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(379, 40)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Display may be slow depending on you internet connection. Hence a high speed inte" &
    "rnet connection is recommended for a clear preview."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(89, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(292, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Satellite View/Road Map/ Terrain (Supported)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label6.Location = New System.Drawing.Point(3, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Information"
        '
        'cmdFullScreen
        '
        Me.cmdFullScreen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFullScreen.BackgroundImage = Global.MoCTIMIS.My.Resources.Resources.TOOLBAR
        Me.cmdFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFullScreen.FlatAppearance.BorderSize = 0
        Me.cmdFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFullScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFullScreen.ForeColor = System.Drawing.Color.White
        Me.cmdFullScreen.Location = New System.Drawing.Point(820, 25)
        Me.cmdFullScreen.Name = "cmdFullScreen"
        Me.cmdFullScreen.Size = New System.Drawing.Size(99, 24)
        Me.cmdFullScreen.TabIndex = 26
        Me.cmdFullScreen.Text = "Full screen"
        Me.cmdFullScreen.UseVisualStyleBackColor = True
        '
        'cmdCaptureScreen
        '
        Me.cmdCaptureScreen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCaptureScreen.BackgroundImage = Global.MoCTIMIS.My.Resources.Resources.TOOLBAR
        Me.cmdCaptureScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdCaptureScreen.FlatAppearance.BorderSize = 0
        Me.cmdCaptureScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCaptureScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCaptureScreen.ForeColor = System.Drawing.Color.White
        Me.cmdCaptureScreen.Location = New System.Drawing.Point(730, 25)
        Me.cmdCaptureScreen.Name = "cmdCaptureScreen"
        Me.cmdCaptureScreen.Size = New System.Drawing.Size(99, 24)
        Me.cmdCaptureScreen.TabIndex = 27
        Me.cmdCaptureScreen.Text = "Capture Map"
        Me.cmdCaptureScreen.UseVisualStyleBackColor = True
        '
        'lblAddingMarkers
        '
        Me.lblAddingMarkers.AutoSize = True
        Me.lblAddingMarkers.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddingMarkers.ForeColor = System.Drawing.Color.White
        Me.lblAddingMarkers.Image = Global.MoCTIMIS.My.Resources.Resources.TOOLBAR
        Me.lblAddingMarkers.Location = New System.Drawing.Point(420, 29)
        Me.lblAddingMarkers.Name = "lblAddingMarkers"
        Me.lblAddingMarkers.Size = New System.Drawing.Size(164, 15)
        Me.lblAddingMarkers.TabIndex = 28
        Me.lblAddingMarkers.Text = "Adding Markers.. Please wait.."
        Me.lblAddingMarkers.Visible = False
        '
        'tmrAnimateMarkers
        '
        Me.tmrAnimateMarkers.Interval = 300
        '
        'cmdCancel
        '
        Me.cmdCancel.AutoSize = True
        Me.cmdCancel.BackColor = System.Drawing.Color.Transparent
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.Salmon
        Me.cmdCancel.Image = Global.MoCTIMIS.My.Resources.Resources.TOOLBAR
        Me.cmdCancel.Location = New System.Drawing.Point(601, 27)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(47, 17)
        Me.cmdCancel.TabIndex = 28
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.Visible = false
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
        Me.SplitContainerControl1.Location = New System.Drawing.Point(4, 50)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GoogleMap1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelGPSLocator)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1014, 536)
        Me.SplitContainerControl1.SplitterPosition = 716
        Me.SplitContainerControl1.TabIndex = 29
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'frmGPSLocationMultiple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 633)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.lblAddingMarkers)
        Me.Controls.Add(Me.cmdCaptureScreen)
        Me.Controls.Add(Me.cmdFullScreen)
        Me.Controls.Add(Me.PanelCOVER)
        Me.Controls.Add(Me.cmdMeasurePropertyArea)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.Name = "frmGPSLocationMultiple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GPS Location - Multiple"
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.StatusStrip2.ResumeLayout(false)
        Me.StatusStrip2.PerformLayout
        Me.ToolStrip2.ResumeLayout(false)
        Me.ToolStrip2.PerformLayout
        Me.PanelGPSLocator.ResumeLayout(false)
        Me.PanelGPSLocator.PerformLayout
        CType(Me.PartyOfficesDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelCOVER.ResumeLayout(false)
        Me.PanelCOVER.PerformLayout
        CType(Me.SplitContainerControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainerControl1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout


End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbMapType As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbZoom As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnMoveLeft As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMoveDown As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMoveUp As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMoveRight As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAddMarker As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblBounds As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblMousePosition As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel10 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel11 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblMapZoom As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanelGPSLocator As System.Windows.Forms.Panel
    Friend WithEvents GoogleMap1 As Pegazux.GoogleMaps.GoogleMap
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents tmrLocateResidence As System.Windows.Forms.Timer
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents tmrAddMarkers As System.Windows.Forms.Timer
    Friend WithEvents cmdAddAllMarkers As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdMeasurePropertyArea As System.Windows.Forms.Button
    Friend WithEvents PanelCOVER As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdFullScreen As System.Windows.Forms.Button
    Friend WithEvents cmdCaptureScreen As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblAddingMarkers As System.Windows.Forms.Label
    Friend WithEvents tmrAnimateMarkers As System.Windows.Forms.Timer
    Friend WithEvents cmdCancel As System.Windows.Forms.Label
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents PartyOfficesDataGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
End Class
