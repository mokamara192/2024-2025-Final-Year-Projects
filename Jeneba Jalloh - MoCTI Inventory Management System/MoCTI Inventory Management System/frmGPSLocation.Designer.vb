<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPSLocation
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
        Dim MapTypeControlOptions1 As Pegazux.GoogleMaps.MapTypeControlOptions = New Pegazux.GoogleMaps.MapTypeControlOptions()
        Dim NavigationControlOptions1 As Pegazux.GoogleMaps.NavigationControlOptions = New Pegazux.GoogleMaps.NavigationControlOptions()
        Dim ScaleControlOptions1 As Pegazux.GoogleMaps.ScaleControlOptions = New Pegazux.GoogleMaps.ScaleControlOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGPSLocation))
        Me.CM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InformacinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitarMarkerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkGeneratePolyLine = New System.Windows.Forms.CheckBox()
        Me.PanelGPSLocator = New System.Windows.Forms.Panel()
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.GoogleMap1 = New Pegazux.GoogleMaps.GoogleMap()
        Me.tmrLocateResidence = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblMousePosition = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel11 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblMapZoom = New System.Windows.Forms.ToolStripStatusLabel()
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
        Me.btnAddMarker = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblBounds = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.chkDetectCordinates = New System.Windows.Forms.CheckBox()
        Me.cmdMeasurePropertyArea = New System.Windows.Forms.Button()
        Me.cmdFullScreen = New System.Windows.Forms.Button()
        Me.PanelCOVER = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.CM.SuspendLayout
        Me.PanelGPSLocator.SuspendLayout
        CType(Me.VGridControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip2.SuspendLayout
        Me.StatusStrip2.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        Me.StatusStrip1.SuspendLayout
        Me.PanelCOVER.SuspendLayout
        Me.SuspendLayout
        '
        'CM
        '
        Me.CM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformacinToolStripMenuItem, Me.ToolStripMenuItem1, Me.QuitarMarkerToolStripMenuItem})
        Me.CM.Name = "ContextMenuStrip1"
        Me.CM.Size = New System.Drawing.Size(149, 54)
        '
        'InformacinToolStripMenuItem
        '
        Me.InformacinToolStripMenuItem.Name = "InformacinToolStripMenuItem"
        Me.InformacinToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.InformacinToolStripMenuItem.Text = "Informacin..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(145, 6)
        '
        'QuitarMarkerToolStripMenuItem
        '
        Me.QuitarMarkerToolStripMenuItem.Name = "QuitarMarkerToolStripMenuItem"
        Me.QuitarMarkerToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.QuitarMarkerToolStripMenuItem.Text = "Quitar marker"
        '
        'chkGeneratePolyLine
        '
        Me.chkGeneratePolyLine.BackColor = System.Drawing.Color.SteelBlue
        Me.chkGeneratePolyLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkGeneratePolyLine.ForeColor = System.Drawing.Color.White
        Me.chkGeneratePolyLine.Location = New System.Drawing.Point(823, 1)
        Me.chkGeneratePolyLine.Name = "chkGeneratePolyLine"
        Me.chkGeneratePolyLine.Size = New System.Drawing.Size(116, 23)
        Me.chkGeneratePolyLine.TabIndex = 13
        Me.chkGeneratePolyLine.Text = "Generate Polylines"
        Me.chkGeneratePolyLine.UseVisualStyleBackColor = false
        '
        'PanelGPSLocator
        '
        Me.PanelGPSLocator.BackColor = System.Drawing.Color.White
        Me.PanelGPSLocator.Controls.Add(Me.VGridControl1)
        Me.PanelGPSLocator.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelGPSLocator.Location = New System.Drawing.Point(807, 50)
        Me.PanelGPSLocator.Name = "PanelGPSLocator"
        Me.PanelGPSLocator.Size = New System.Drawing.Size(213, 539)
        Me.PanelGPSLocator.TabIndex = 20
        '
        'VGridControl1
        '
        Me.VGridControl1.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.VGridControl1.Appearance.RecordValue.Options.UseFont = true
        Me.VGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.Size = New System.Drawing.Size(213, 539)
        Me.VGridControl1.TabIndex = 1
        '
        'GoogleMap1
        '
        Me.GoogleMap1.BackGroundColor = System.Drawing.Color.Empty
        Me.GoogleMap1.Center.Lat = 0R
        Me.GoogleMap1.Center.Lng = 0R
        Me.GoogleMap1.Center.NoWrap = false
        Me.GoogleMap1.DisableDefaultUI = false
        Me.GoogleMap1.DisableDoubleClickZoom = false
        Me.GoogleMap1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GoogleMap1.Draggable = true
        Me.GoogleMap1.DraggableCursor = Pegazux.GoogleMaps.Cursors.pointer
        Me.GoogleMap1.DraggingCursor = Pegazux.GoogleMaps.Cursors.move
        Me.GoogleMap1.KeyboardShortcuts = true
        Me.GoogleMap1.Location = New System.Drawing.Point(0, 50)
        Me.GoogleMap1.MapTypeControl = true
        MapTypeControlOptions1.MapTypeIds = New Pegazux.GoogleMaps.MapTypeId() {Pegazux.GoogleMaps.MapTypeId.TERRAIN, Pegazux.GoogleMaps.MapTypeId.ROADMAP, Pegazux.GoogleMaps.MapTypeId.ROADMAP, Pegazux.GoogleMaps.MapTypeId.ROADMAP}
        MapTypeControlOptions1.Position = Pegazux.GoogleMaps.ControlPosition.TOP_RIGHT
        MapTypeControlOptions1.Style = Pegazux.GoogleMaps.MapTypeControlStyle.DROPDOWN_MENU
        Me.GoogleMap1.MapTypeControlOptions = MapTypeControlOptions1
        Me.GoogleMap1.MapTypeId = Pegazux.GoogleMaps.MapTypeId.ROADMAP
        Me.GoogleMap1.Name = "GoogleMap1"
        Me.GoogleMap1.NavigationControl = true
        NavigationControlOptions1.Position = Pegazux.GoogleMaps.ControlPosition.LEFT_TOP
        NavigationControlOptions1.Style = Pegazux.GoogleMaps.NavigationControlStyle.ZOOM_PAN
        Me.GoogleMap1.NavigationControlOptions = NavigationControlOptions1
        Me.GoogleMap1.NoClear = false
        Me.GoogleMap1.ScaleControl = true
        ScaleControlOptions1.Position = Pegazux.GoogleMaps.ControlPosition.BOTTOM_LEFT
        Me.GoogleMap1.ScaleControlOptions = ScaleControlOptions1
        Me.GoogleMap1.Scrollwheel = true
        Me.GoogleMap1.ShowControls = true
        Me.GoogleMap1.Size = New System.Drawing.Size(807, 539)
        Me.GoogleMap1.StreetViewControl = true
        Me.GoogleMap1.TabIndex = 21
        Me.GoogleMap1.UseMarkerClusterer = false
        Me.GoogleMap1.Zoom = 1
        '
        'tmrLocateResidence
        '
        Me.tmrLocateResidence.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImage = Global.MoCTIMIS.My.Resources.Resources.TOOLBAR
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(927, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 24)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.ToolStrip2.TabIndex = 19
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
        Me.cmdClose.TabIndex = 18
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'StatusStrip2
        '
        Me.StatusStrip2.BackgroundImage = Global.MoCTIMIS.My.Resources.Resources.TOOLBAR2
        Me.StatusStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8, Me.lblMousePosition, Me.ToolStripStatusLabel10, Me.ToolStripStatusLabel11, Me.lblMapZoom})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 589)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(1020, 22)
        Me.StatusStrip2.TabIndex = 17
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripLabel1, Me.cmbMapType, Me.ToolStripLabel2, Me.cmbZoom, Me.ToolStripLabel3, Me.btnMoveLeft, Me.btnMoveDown, Me.btnMoveUp, Me.btnMoveRight, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.btnAddMarker, Me.ToolStripSeparator2, Me.ToolStripButton7})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1020, 25)
        Me.ToolStrip1.TabIndex = 12
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
        'btnAddMarker
        '
        Me.btnAddMarker.ForeColor = System.Drawing.Color.White
        Me.btnAddMarker.Image = Global.MoCTIMIS.My.Resources.Resources.marker
        Me.btnAddMarker.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddMarker.Name = "btnAddMarker"
        Me.btnAddMarker.Size = New System.Drawing.Size(89, 22)
        Me.btnAddMarker.Text = "Add marker"
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
        Me.ToolStripButton7.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripButton7.Text = "Save Defaulter Map"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl1, Me.lblBounds, Me.ToolStripStatusLabel1, Me.info})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 611)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1020, 22)
        Me.StatusStrip1.TabIndex = 11
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
        'chkDetectCordinates
        '
        Me.chkDetectCordinates.BackgroundImage = Global.MoCTIMIS.My.Resources.Resources.TOOLBAR
        Me.chkDetectCordinates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chkDetectCordinates.ForeColor = System.Drawing.Color.LawnGreen
        Me.chkDetectCordinates.Location = New System.Drawing.Point(250, 26)
        Me.chkDetectCordinates.Name = "chkDetectCordinates"
        Me.chkDetectCordinates.Size = New System.Drawing.Size(116, 23)
        Me.chkDetectCordinates.TabIndex = 14
        Me.chkDetectCordinates.Text = "Detect Cordinates"
        Me.chkDetectCordinates.UseVisualStyleBackColor = True
        '
        'cmdMeasurePropertyArea
        '
        Me.cmdMeasurePropertyArea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdMeasurePropertyArea.BackgroundImage = Global.MoCTIMIS.My.Resources.Resources.TOOLBAR
        Me.cmdMeasurePropertyArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdMeasurePropertyArea.FlatAppearance.BorderSize = 0
        Me.cmdMeasurePropertyArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMeasurePropertyArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMeasurePropertyArea.ForeColor = System.Drawing.Color.White
        Me.cmdMeasurePropertyArea.Location = New System.Drawing.Point(250, 25)
        Me.cmdMeasurePropertyArea.Name = "cmdMeasurePropertyArea"
        Me.cmdMeasurePropertyArea.Size = New System.Drawing.Size(151, 24)
        Me.cmdMeasurePropertyArea.TabIndex = 23
        Me.cmdMeasurePropertyArea.Text = "Measure Property Area"
        Me.cmdMeasurePropertyArea.UseVisualStyleBackColor = True
        '
        'cmdFullScreen
        '
        Me.cmdFullScreen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFullScreen.BackgroundImage = Global.MoCTIMIS.My.Resources.Resources.TOOLBAR
        Me.cmdFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFullScreen.FlatAppearance.BorderSize = 0
        Me.cmdFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFullScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdFullScreen.ForeColor = System.Drawing.Color.White
        Me.cmdFullScreen.Location = New System.Drawing.Point(804, 26)
        Me.cmdFullScreen.Name = "cmdFullScreen"
        Me.cmdFullScreen.Size = New System.Drawing.Size(99, 24)
        Me.cmdFullScreen.TabIndex = 29
        Me.cmdFullScreen.Text = "Full screen"
        Me.cmdFullScreen.UseVisualStyleBackColor = true
        '
        'PanelCOVER
        '
        Me.PanelCOVER.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.PanelCOVER.BackColor = System.Drawing.Color.DimGray
        Me.PanelCOVER.Controls.Add(Me.Label12)
        Me.PanelCOVER.Controls.Add(Me.Label13)
        Me.PanelCOVER.Controls.Add(Me.Label14)
        Me.PanelCOVER.Location = New System.Drawing.Point(0, 527)
        Me.PanelCOVER.Name = "PanelCOVER"
        Me.PanelCOVER.Size = New System.Drawing.Size(384, 62)
        Me.PanelCOVER.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label12.Location = New System.Drawing.Point(5, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(379, 40)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Display may be slow depending on you internet connection. Hence a high speed inte"& _ 
    "rnet connection is recommended for a clear preview."
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label13.Location = New System.Drawing.Point(89, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(292, 18)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Satellite View/Road Map/ Terrain (Supported)"
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label14.Location = New System.Drawing.Point(3, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Information"
        '
        'frmGPSLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 633)
        Me.Controls.Add(Me.PanelCOVER)
        Me.Controls.Add(Me.cmdFullScreen)
        Me.Controls.Add(Me.cmdMeasurePropertyArea)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GoogleMap1)
        Me.Controls.Add(Me.PanelGPSLocator)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.chkDetectCordinates)
        Me.Controls.Add(Me.chkGeneratePolyLine)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.Name = "frmGPSLocation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multi Cordinates GPS Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CM.ResumeLayout(false)
        Me.PanelGPSLocator.ResumeLayout(false)
        CType(Me.VGridControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip2.ResumeLayout(false)
        Me.ToolStrip2.PerformLayout
        Me.StatusStrip2.ResumeLayout(false)
        Me.StatusStrip2.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.PanelCOVER.ResumeLayout(false)
        Me.PanelCOVER.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout


End Sub
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblBounds As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel11 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel10 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblMapZoom As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblMousePosition As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnAddMarker As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbMapType As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbZoom As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnMoveLeft As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMoveDown As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMoveUp As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMoveRight As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CM As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents InformacinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuitarMarkerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents chkDetectCordinates As System.Windows.Forms.CheckBox
    Friend WithEvents chkGeneratePolyLine As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanelGPSLocator As System.Windows.Forms.Panel
    Friend WithEvents GoogleMap1 As Pegazux.GoogleMaps.GoogleMap
    Friend WithEvents tmrLocateResidence As System.Windows.Forms.Timer
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdMeasurePropertyArea As System.Windows.Forms.Button
    Friend WithEvents cmdFullScreen As System.Windows.Forms.Button
    Friend WithEvents PanelCOVER As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
End Class
