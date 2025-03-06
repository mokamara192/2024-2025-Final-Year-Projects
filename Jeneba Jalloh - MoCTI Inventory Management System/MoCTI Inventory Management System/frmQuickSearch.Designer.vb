<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuickSearch
    Inherits System.Windows.Forms.Form

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
        Me.PanelBody = New DevExpress.XtraEditors.PanelControl()
        Me.lblnoofrecords = New DevExpress.XtraEditors.LabelControl()
        Me.PanelDatePickers = New DevExpress.XtraEditors.PanelControl()
        Me.cmdClosePanelDate = New DevExpress.XtraEditors.SimpleButton()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelPreview = New DevExpress.XtraEditors.PanelControl()
        Me.cboPreview = New System.Windows.Forms.ComboBox()
        Me.cmdClosePanelPreview = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdPreview = New DevExpress.XtraEditors.SimpleButton()
        Me.chkfindexclusivematch = New System.Windows.Forms.CheckBox()
        Me.PanelSearch = New DevExpress.XtraEditors.PanelControl()
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.lblPleasewait = New DevExpress.XtraEditors.LabelControl()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdAddNew = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFilter = New DevExpress.XtraEditors.TextEdit()
        Me.lstFields = New System.Windows.Forms.ListBox()
        Me.lblTableName = New DevExpress.XtraEditors.LabelControl()
        Me.PreviewDataGridView = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelHeader = New DevExpress.XtraEditors.PanelControl()
        Me.lblQuickPreviewTitle = New DevExpress.XtraEditors.LabelControl()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.SearchBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.tmrPleasewait = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PanelBody, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBody.SuspendLayout()
        CType(Me.PanelDatePickers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatePickers.SuspendLayout()
        CType(Me.PanelPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPreview.SuspendLayout()
        CType(Me.PanelSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSearch.SuspendLayout()
        CType(Me.txtFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBody
        '
        Me.PanelBody.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PanelBody.Appearance.Options.UseBackColor = True
        Me.PanelBody.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelBody.Controls.Add(Me.lblnoofrecords)
        Me.PanelBody.Controls.Add(Me.PanelDatePickers)
        Me.PanelBody.Controls.Add(Me.PanelPreview)
        Me.PanelBody.Controls.Add(Me.cmdPreview)
        Me.PanelBody.Controls.Add(Me.chkfindexclusivematch)
        Me.PanelBody.Controls.Add(Me.PanelSearch)
        Me.PanelBody.Controls.Add(Me.cmdAddNew)
        Me.PanelBody.Controls.Add(Me.cmdRefresh)
        Me.PanelBody.Controls.Add(Me.cmdSearch)
        Me.PanelBody.Controls.Add(Me.Label3)
        Me.PanelBody.Controls.Add(Me.Label2)
        Me.PanelBody.Controls.Add(Me.Label1)
        Me.PanelBody.Controls.Add(Me.txtFilter)
        Me.PanelBody.Controls.Add(Me.lstFields)
        Me.PanelBody.Controls.Add(Me.lblTableName)
        Me.PanelBody.Controls.Add(Me.PreviewDataGridView)
        Me.PanelBody.Controls.Add(Me.PanelHeader)
        Me.PanelBody.Controls.Add(Me.Label4)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(0, 0)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(720, 450)
        Me.PanelBody.TabIndex = 1
        '
        'lblnoofrecords
        '
        Me.lblnoofrecords.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblnoofrecords.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnoofrecords.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblnoofrecords.Appearance.Options.UseBackColor = True
        Me.lblnoofrecords.Appearance.Options.UseFont = True
        Me.lblnoofrecords.Appearance.Options.UseForeColor = True
        Me.lblnoofrecords.Location = New System.Drawing.Point(138, 421)
        Me.lblnoofrecords.Name = "lblnoofrecords"
        Me.lblnoofrecords.Size = New System.Drawing.Size(64, 15)
        Me.lblnoofrecords.TabIndex = 21
        Me.lblnoofrecords.Text = "0 Record(s)"
        '
        'PanelDatePickers
        '
        Me.PanelDatePickers.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelDatePickers.Controls.Add(Me.cmdClosePanelDate)
        Me.PanelDatePickers.Controls.Add(Me.Label7)
        Me.PanelDatePickers.Controls.Add(Me.Label6)
        Me.PanelDatePickers.Controls.Add(Me.ToDateTimePicker)
        Me.PanelDatePickers.Controls.Add(Me.FromDateTimePicker)
        Me.PanelDatePickers.Controls.Add(Me.Label8)
        Me.PanelDatePickers.Location = New System.Drawing.Point(194, 151)
        Me.PanelDatePickers.Name = "PanelDatePickers"
        Me.PanelDatePickers.Size = New System.Drawing.Size(377, 77)
        Me.PanelDatePickers.TabIndex = 20
        Me.PanelDatePickers.Visible = False
        '
        'cmdClosePanelDate
        '
        Me.cmdClosePanelDate.Location = New System.Drawing.Point(350, 1)
        Me.cmdClosePanelDate.Name = "cmdClosePanelDate"
        Me.cmdClosePanelDate.Size = New System.Drawing.Size(25, 22)
        Me.cmdClosePanelDate.TabIndex = 3
        Me.cmdClosePanelDate.Text = "X"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(194, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "To:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "From:"
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "dd/MMMM/yyyy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(221, 31)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(137, 21)
        Me.ToDateTimePicker.TabIndex = 0
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.CustomFormat = "dd/MMMM/yyyy"
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(47, 31)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(137, 21)
        Me.FromDateTimePicker.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Appearance.Options.UseBackColor = True
        Me.Label8.Appearance.Options.UseFont = True
        Me.Label8.Appearance.Options.UseForeColor = True
        Me.Label8.Location = New System.Drawing.Point(4, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Date Picker"
        '
        'PanelPreview
        '
        Me.PanelPreview.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelPreview.Controls.Add(Me.cboPreview)
        Me.PanelPreview.Controls.Add(Me.cmdClosePanelPreview)
        Me.PanelPreview.Controls.Add(Me.Label5)
        Me.PanelPreview.Location = New System.Drawing.Point(403, 88)
        Me.PanelPreview.Name = "PanelPreview"
        Me.PanelPreview.Size = New System.Drawing.Size(214, 240)
        Me.PanelPreview.TabIndex = 19
        Me.PanelPreview.Visible = False
        '
        'cboPreview
        '
        Me.cboPreview.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPreview.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPreview.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboPreview.FormattingEnabled = True
        Me.cboPreview.Location = New System.Drawing.Point(5, 32)
        Me.cboPreview.Name = "cboPreview"
        Me.cboPreview.Size = New System.Drawing.Size(201, 203)
        Me.cboPreview.TabIndex = 3
        '
        'cmdClosePanelPreview
        '
        Me.cmdClosePanelPreview.Location = New System.Drawing.Point(186, 3)
        Me.cmdClosePanelPreview.Name = "cmdClosePanelPreview"
        Me.cmdClosePanelPreview.Size = New System.Drawing.Size(25, 22)
        Me.cmdClosePanelPreview.TabIndex = 2
        Me.cmdClosePanelPreview.Text = "X"
        '
        'Label5
        '
        Me.Label5.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Appearance.Options.UseBackColor = True
        Me.Label5.Appearance.Options.UseFont = True
        Me.Label5.Appearance.Options.UseForeColor = True
        Me.Label5.Location = New System.Drawing.Point(4, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Quick Preview"
        '
        'cmdPreview
        '
        Me.cmdPreview.Location = New System.Drawing.Point(370, 88)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(27, 23)
        Me.cmdPreview.TabIndex = 18
        Me.cmdPreview.Text = "V"
        '
        'chkfindexclusivematch
        '
        Me.chkfindexclusivematch.AutoSize = True
        Me.chkfindexclusivematch.Checked = True
        Me.chkfindexclusivematch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkfindexclusivematch.Location = New System.Drawing.Point(239, 68)
        Me.chkfindexclusivematch.Name = "chkfindexclusivematch"
        Me.chkfindexclusivematch.Size = New System.Drawing.Size(125, 17)
        Me.chkfindexclusivematch.TabIndex = 17
        Me.chkfindexclusivematch.Text = "Find exclusive match"
        Me.chkfindexclusivematch.UseVisualStyleBackColor = True
        '
        'PanelSearch
        '
        Me.PanelSearch.Controls.Add(Me.Label10)
        Me.PanelSearch.Controls.Add(Me.lblPleasewait)
        Me.PanelSearch.Controls.Add(Me.Label9)
        Me.PanelSearch.Location = New System.Drawing.Point(194, 151)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(197, 70)
        Me.PanelSearch.TabIndex = 15
        Me.PanelSearch.Visible = False
        '
        'Label10
        '
        Me.Label10.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Appearance.Options.UseBackColor = True
        Me.Label10.Appearance.Options.UseFont = True
        Me.Label10.Appearance.Options.UseForeColor = True
        Me.Label10.Location = New System.Drawing.Point(34, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "This shouldn't take long.."
        '
        'lblPleasewait
        '
        Me.lblPleasewait.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblPleasewait.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleasewait.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPleasewait.Appearance.Options.UseBackColor = True
        Me.lblPleasewait.Appearance.Options.UseFont = True
        Me.lblPleasewait.Appearance.Options.UseForeColor = True
        Me.lblPleasewait.Location = New System.Drawing.Point(40, 23)
        Me.lblPleasewait.Name = "lblPleasewait"
        Me.lblPleasewait.Size = New System.Drawing.Size(122, 18)
        Me.lblPleasewait.TabIndex = 1
        Me.lblPleasewait.Text = "Please wait a little.."
        '
        'Label9
        '
        Me.Label9.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Appearance.ForeColor = System.Drawing.Color.Chocolate
        Me.Label9.Appearance.Options.UseBackColor = True
        Me.Label9.Appearance.Options.UseFont = True
        Me.Label9.Appearance.Options.UseForeColor = True
        Me.Label9.Location = New System.Drawing.Point(5, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Searching"
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Location = New System.Drawing.Point(10, 417)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(118, 26)
        Me.cmdAddNew.TabIndex = 10
        Me.cmdAddNew.Text = "&Transfer Result"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(623, 211)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(84, 25)
        Me.cmdRefresh.TabIndex = 9
        Me.cmdRefresh.Text = "Refresh"
        '
        'cmdSearch
        '
        Me.cmdSearch.Enabled = False
        Me.cmdSearch.Location = New System.Drawing.Point(194, 119)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(170, 26)
        Me.cmdSearch.TabIndex = 8
        Me.cmdSearch.Text = "&Search"
        '
        'Label3
        '
        Me.Label3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Appearance.Options.UseBackColor = True
        Me.Label3.Appearance.Options.UseFont = True
        Me.Label3.Appearance.Options.UseForeColor = True
        Me.Label3.Location = New System.Drawing.Point(413, 422)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(287, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "The table above shows the result of the search query."
        '
        'Label2
        '
        Me.Label2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Appearance.Options.UseFont = True
        Me.Label2.Location = New System.Drawing.Point(191, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Filter"
        '
        'Label1
        '
        Me.Label1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Appearance.Options.UseBackColor = True
        Me.Label1.Appearance.Options.UseFont = True
        Me.Label1.Appearance.Options.UseForeColor = True
        Me.Label1.Location = New System.Drawing.Point(10, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Fields"
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(194, 89)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.Properties.Appearance.Options.UseFont = True
        Me.txtFilter.Size = New System.Drawing.Size(170, 22)
        Me.txtFilter.TabIndex = 7
        '
        'lstFields
        '
        Me.lstFields.FormattingEnabled = True
        Me.lstFields.Location = New System.Drawing.Point(11, 89)
        Me.lstFields.Name = "lstFields"
        Me.lstFields.Size = New System.Drawing.Size(175, 147)
        Me.lstFields.TabIndex = 6
        '
        'lblTableName
        '
        Me.lblTableName.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblTableName.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableName.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTableName.Appearance.Options.UseBackColor = True
        Me.lblTableName.Appearance.Options.UseFont = True
        Me.lblTableName.Appearance.Options.UseForeColor = True
        Me.lblTableName.Location = New System.Drawing.Point(9, 32)
        Me.lblTableName.Name = "lblTableName"
        Me.lblTableName.Size = New System.Drawing.Size(91, 21)
        Me.lblTableName.TabIndex = 1
        Me.lblTableName.Text = "Quick Search"
        '
        'PreviewDataGridView
        '
        Me.PreviewDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PreviewDataGridView.Location = New System.Drawing.Point(10, 248)
        Me.PreviewDataGridView.MainView = Me.GridView1
        Me.PreviewDataGridView.Name = "PreviewDataGridView"
        Me.PreviewDataGridView.Size = New System.Drawing.Size(699, 165)
        Me.PreviewDataGridView.TabIndex = 4
        Me.PreviewDataGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.PreviewDataGridView
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.PreviewDataGridView
        Me.GridView2.Name = "GridView2"
        '
        'PanelHeader
        '
        Me.PanelHeader.Appearance.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelHeader.Appearance.Options.UseBackColor = True
        Me.PanelHeader.Controls.Add(Me.lblQuickPreviewTitle)
        Me.PanelHeader.Controls.Add(Me.cmdClose)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(2, 2)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(716, 25)
        Me.PanelHeader.TabIndex = 3
        '
        'lblQuickPreviewTitle
        '
        Me.lblQuickPreviewTitle.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblQuickPreviewTitle.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuickPreviewTitle.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblQuickPreviewTitle.Appearance.Options.UseBackColor = True
        Me.lblQuickPreviewTitle.Appearance.Options.UseFont = True
        Me.lblQuickPreviewTitle.Appearance.Options.UseForeColor = True
        Me.lblQuickPreviewTitle.Location = New System.Drawing.Point(6, 4)
        Me.lblQuickPreviewTitle.Name = "lblQuickPreviewTitle"
        Me.lblQuickPreviewTitle.Size = New System.Drawing.Size(124, 17)
        Me.lblQuickPreviewTitle.TabIndex = 1
        Me.lblQuickPreviewTitle.Text = "Simple Search Engine"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Location = New System.Drawing.Point(690, 1)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(25, 22)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "X"
        '
        'Label4
        '
        Me.Label4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Appearance.Options.UseBackColor = True
        Me.Label4.Appearance.Options.UseFont = True
        Me.Label4.Appearance.Options.UseForeColor = True
        Me.Label4.Location = New System.Drawing.Point(435, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 4
        '
        'SearchBackgroundWorker
        '
        Me.SearchBackgroundWorker.WorkerReportsProgress = True
        Me.SearchBackgroundWorker.WorkerSupportsCancellation = True
        '
        'tmrPleasewait
        '
        Me.tmrPleasewait.Interval = 500
        '
        'frmQuickSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 450)
        Me.Controls.Add(Me.PanelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQuickSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmQuickSearch"
        CType(Me.PanelBody, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBody.ResumeLayout(False)
        Me.PanelBody.PerformLayout()
        CType(Me.PanelDatePickers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatePickers.ResumeLayout(False)
        Me.PanelDatePickers.PerformLayout()
        CType(Me.PanelPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPreview.ResumeLayout(False)
        Me.PanelPreview.PerformLayout()
        CType(Me.PanelSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        CType(Me.txtFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelBody As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdAddNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFilter As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lstFields As System.Windows.Forms.ListBox
    Friend WithEvents lblTableName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PreviewDataGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents PanelHeader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblQuickPreviewTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelDatePickers As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdClosePanelDate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents FromDateTimePicker As DateTimePicker
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelPreview As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboPreview As ComboBox
    Friend WithEvents cmdClosePanelPreview As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdPreview As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkfindexclusivematch As CheckBox
    Friend WithEvents PanelSearch As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPleasewait As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SearchBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrPleasewait As Timer
    Friend WithEvents lblnoofrecords As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
