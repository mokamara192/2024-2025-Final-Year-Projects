<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockReorder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockReorder))
        Me.cmdPrevious = New System.Windows.Forms.ToolStripButton()
        Me.cmdNext = New System.Windows.Forms.ToolStripButton()
        Me.SearchByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelSearchByDate = New DevExpress.XtraEditors.PanelControl()
        Me.cmdDateSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.EndDateTimePicker = New DevExpress.XtraEditors.DateEdit()
        Me.lblEndDate = New DevExpress.XtraEditors.LabelControl()
        Me.StartDateTimePicker = New DevExpress.XtraEditors.DateEdit()
        Me.lblStartDate = New DevExpress.XtraEditors.LabelControl()
        Me.lblDateField = New DevExpress.XtraEditors.LabelControl()
        Me.SearchDateFieldComboBox = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblSearchTitle = New DevExpress.XtraEditors.LabelControl()
        Me.cmdCloseSearchbyDate = New DevExpress.XtraEditors.SimpleButton()
        Me.ReorderIDLabel = New DevExpress.XtraEditors.LabelControl()
        Me.StockIDLabel = New DevExpress.XtraEditors.LabelControl()
        Me.CurrentRetailQuantityLabel = New DevExpress.XtraEditors.LabelControl()
        Me.ReorderRetailQuantityLabel = New DevExpress.XtraEditors.LabelControl()
        Me.NewRetailQuantityLabel = New DevExpress.XtraEditors.LabelControl()
        Me.CurrentWholesaleQuantityLabel = New DevExpress.XtraEditors.LabelControl()
        Me.ReorderWholesaleQuantityLabel = New DevExpress.XtraEditors.LabelControl()
        Me.NewWholesaleQuantityLabel = New DevExpress.XtraEditors.LabelControl()
        Me.ReorderDateLabel = New DevExpress.XtraEditors.LabelControl()
        Me.RorderSourceLabel = New DevExpress.XtraEditors.LabelControl()
        Me.SupervisorLabel = New DevExpress.XtraEditors.LabelControl()
        Me.CommentLabel = New DevExpress.XtraEditors.LabelControl()
        Me.RegDateLabel = New DevExpress.XtraEditors.LabelControl()
        Me.InputedByLabel = New DevExpress.XtraEditors.LabelControl()
        Me.ReorderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentRetailQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReorderRetailQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewRetailQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentWholesaleQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReorderWholesaleQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewWholesaleQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReorderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RorderSourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupervisorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReorderIDTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.StockIDGridBox = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.CurrentRetailQuantityTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.ReorderRetailQuantityTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.NewRetailQuantityTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.CurrentWholesaleQuantityTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.ReorderWholesaleQuantityTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.NewWholesaleQuantityTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.ReorderDateDateTimePicker = New DevExpress.XtraEditors.DateEdit()
        Me.RorderSourceTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.SupervisorTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.CommentTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.RegDateTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.InputedByTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SearchToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.StockReorderDataGridView = New DevExpress.XtraGrid.GridControl()
        Me.BottomStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.NoofRecordsLabelToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NoofRecordsToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblInformation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdClosePanelNew = New DevExpress.XtraEditors.SimpleButton()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintAllListedRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportWizardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToExcellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PanelBody = New DevExpress.XtraEditors.PanelControl()
        Me.PanelNew = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lblFormName = New DevExpress.XtraEditors.LabelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.PanelExporting = New DevExpress.XtraEditors.PanelControl()
        Me.PanelProgressbarContainer = New DevExpress.XtraEditors.PanelControl()
        Me.PanelProgressbar = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCloseExport = New DevExpress.XtraEditors.SimpleButton()
        Me.lblExportPercentage = New DevExpress.XtraEditors.LabelControl()
        Me.lblNoRows = New DevExpress.XtraEditors.LabelControl()
        Me.lblNoValues = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblExportStatus = New DevExpress.XtraEditors.LabelControl()
        Me.Label26 = New DevExpress.XtraEditors.LabelControl()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        CType(Me.PanelSearchByDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSearchByDate.SuspendLayout()
        CType(Me.EndDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchDateFieldComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReorderIDTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockIDGridBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentRetailQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReorderRetailQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewRetailQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentWholesaleQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReorderWholesaleQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewWholesaleQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReorderDateDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReorderDateDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RorderSourceTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupervisorTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegDateTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputedByTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockReorderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomStatusStrip.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.TopToolStrip.SuspendLayout()
        CType(Me.PanelBody, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBody.SuspendLayout()
        CType(Me.PanelNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNew.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelExporting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelExporting.SuspendLayout()
        CType(Me.PanelProgressbarContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProgressbarContainer.SuspendLayout()
        CType(Me.PanelProgressbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Image = CType(resources.GetObject("cmdPrevious.Image"), System.Drawing.Image)
        Me.cmdPrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(72, 22)
        Me.cmdPrevious.Text = "Previous"
        '
        'cmdNext
        '
        Me.cmdNext.Image = CType(resources.GetObject("cmdNext.Image"), System.Drawing.Image)
        Me.cmdNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(51, 22)
        Me.cmdNext.Text = "Next"
        '
        'SearchByDateToolStripMenuItem
        '
        Me.SearchByDateToolStripMenuItem.Name = "SearchByDateToolStripMenuItem"
        Me.SearchByDateToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SearchByDateToolStripMenuItem.Text = "Search by Date"
        '
        'PanelSearchByDate
        '
        Me.PanelSearchByDate.Controls.Add(Me.cmdDateSearch)
        Me.PanelSearchByDate.Controls.Add(Me.EndDateTimePicker)
        Me.PanelSearchByDate.Controls.Add(Me.lblEndDate)
        Me.PanelSearchByDate.Controls.Add(Me.StartDateTimePicker)
        Me.PanelSearchByDate.Controls.Add(Me.lblStartDate)
        Me.PanelSearchByDate.Controls.Add(Me.lblDateField)
        Me.PanelSearchByDate.Controls.Add(Me.SearchDateFieldComboBox)
        Me.PanelSearchByDate.Controls.Add(Me.lblSearchTitle)
        Me.PanelSearchByDate.Controls.Add(Me.cmdCloseSearchbyDate)
        Me.PanelSearchByDate.Location = New System.Drawing.Point(580, 12)
        Me.PanelSearchByDate.Name = "PanelSearchByDate"
        Me.PanelSearchByDate.Size = New System.Drawing.Size(277, 157)
        Me.PanelSearchByDate.TabIndex = 100
        Me.PanelSearchByDate.Visible = False
        '
        'cmdDateSearch
        '
        Me.cmdDateSearch.Location = New System.Drawing.Point(80, 118)
        Me.cmdDateSearch.Name = "cmdDateSearch"
        Me.cmdDateSearch.Size = New System.Drawing.Size(137, 27)
        Me.cmdDateSearch.TabIndex = 54
        Me.cmdDateSearch.Text = "Search"
        '
        'EndDateTimePicker
        '
        Me.EndDateTimePicker.EditValue = Nothing
        Me.EndDateTimePicker.Location = New System.Drawing.Point(80, 92)
        Me.EndDateTimePicker.Name = "EndDateTimePicker"
        Me.EndDateTimePicker.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.EndDateTimePicker.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EndDateTimePicker.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EndDateTimePicker.Size = New System.Drawing.Size(137, 22)
        Me.EndDateTimePicker.TabIndex = 53
        '
        'lblEndDate
        '
        Me.lblEndDate.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.Appearance.Options.UseFont = True
        Me.lblEndDate.Location = New System.Drawing.Point(12, 92)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(51, 15)
        Me.lblEndDate.TabIndex = 51
        Me.lblEndDate.Text = "End Date:"
        '
        'StartDateTimePicker
        '
        Me.StartDateTimePicker.EditValue = Nothing
        Me.StartDateTimePicker.Location = New System.Drawing.Point(80, 66)
        Me.StartDateTimePicker.Name = "StartDateTimePicker"
        Me.StartDateTimePicker.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.StartDateTimePicker.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StartDateTimePicker.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StartDateTimePicker.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.StartDateTimePicker.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDateTimePicker.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.StartDateTimePicker.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDateTimePicker.Size = New System.Drawing.Size(137, 22)
        Me.StartDateTimePicker.TabIndex = 53
        '
        'lblStartDate
        '
        Me.lblStartDate.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.Appearance.Options.UseFont = True
        Me.lblStartDate.Location = New System.Drawing.Point(12, 66)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(57, 15)
        Me.lblStartDate.TabIndex = 51
        Me.lblStartDate.Text = "Start Date:"
        '
        'lblDateField
        '
        Me.lblDateField.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateField.Appearance.Options.UseFont = True
        Me.lblDateField.Location = New System.Drawing.Point(12, 40)
        Me.lblDateField.Name = "lblDateField"
        Me.lblDateField.Size = New System.Drawing.Size(58, 15)
        Me.lblDateField.TabIndex = 51
        Me.lblDateField.Text = "Date Field:"
        '
        'SearchDateFieldComboBox
        '
        Me.SearchDateFieldComboBox.Location = New System.Drawing.Point(80, 38)
        Me.SearchDateFieldComboBox.Name = "SearchDateFieldComboBox"
        Me.SearchDateFieldComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SearchDateFieldComboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchDateFieldComboBox.Properties.Sorted = True
        Me.SearchDateFieldComboBox.Size = New System.Drawing.Size(137, 22)
        Me.SearchDateFieldComboBox.TabIndex = 52
        '
        'lblSearchTitle
        '
        Me.lblSearchTitle.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblSearchTitle.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchTitle.Appearance.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblSearchTitle.Appearance.Options.UseBackColor = True
        Me.lblSearchTitle.Appearance.Options.UseFont = True
        Me.lblSearchTitle.Appearance.Options.UseForeColor = True
        Me.lblSearchTitle.Location = New System.Drawing.Point(8, 5)
        Me.lblSearchTitle.Name = "lblSearchTitle"
        Me.lblSearchTitle.Size = New System.Drawing.Size(108, 21)
        Me.lblSearchTitle.TabIndex = 50
        Me.lblSearchTitle.Text = "Search by Date"
        '
        'cmdCloseSearchbyDate
        '
        Me.cmdCloseSearchbyDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCloseSearchbyDate.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseSearchbyDate.Appearance.Options.UseFont = True
        Me.cmdCloseSearchbyDate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdCloseSearchbyDate.Location = New System.Drawing.Point(248, 0)
        Me.cmdCloseSearchbyDate.Name = "cmdCloseSearchbyDate"
        Me.cmdCloseSearchbyDate.Size = New System.Drawing.Size(29, 28)
        Me.cmdCloseSearchbyDate.TabIndex = 49
        Me.cmdCloseSearchbyDate.Text = "X"
        '
        'ReorderIDLabel
        '
        Me.ReorderIDLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReorderIDLabel.Appearance.Options.UseFont = True
        Me.ReorderIDLabel.Location = New System.Drawing.Point(18, 34)
        Me.ReorderIDLabel.Name = "ReorderIDLabel"
        Me.ReorderIDLabel.Size = New System.Drawing.Size(61, 15)
        Me.ReorderIDLabel.TabIndex = 1
        Me.ReorderIDLabel.Text = "Reorder ID:"
        '
        'StockIDLabel
        '
        Me.StockIDLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockIDLabel.Appearance.Options.UseFont = True
        Me.StockIDLabel.Location = New System.Drawing.Point(18, 60)
        Me.StockIDLabel.Name = "StockIDLabel"
        Me.StockIDLabel.Size = New System.Drawing.Size(47, 15)
        Me.StockIDLabel.TabIndex = 1
        Me.StockIDLabel.Text = "Stock ID:"
        '
        'CurrentRetailQuantityLabel
        '
        Me.CurrentRetailQuantityLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentRetailQuantityLabel.Appearance.Options.UseFont = True
        Me.CurrentRetailQuantityLabel.Location = New System.Drawing.Point(18, 31)
        Me.CurrentRetailQuantityLabel.Name = "CurrentRetailQuantityLabel"
        Me.CurrentRetailQuantityLabel.Size = New System.Drawing.Size(130, 15)
        Me.CurrentRetailQuantityLabel.TabIndex = 1
        Me.CurrentRetailQuantityLabel.Text = "Current Retail Quantity:"
        '
        'ReorderRetailQuantityLabel
        '
        Me.ReorderRetailQuantityLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReorderRetailQuantityLabel.Appearance.Options.UseFont = True
        Me.ReorderRetailQuantityLabel.Location = New System.Drawing.Point(18, 57)
        Me.ReorderRetailQuantityLabel.Name = "ReorderRetailQuantityLabel"
        Me.ReorderRetailQuantityLabel.Size = New System.Drawing.Size(132, 15)
        Me.ReorderRetailQuantityLabel.TabIndex = 1
        Me.ReorderRetailQuantityLabel.Text = "Reorder Retail Quantity:"
        '
        'NewRetailQuantityLabel
        '
        Me.NewRetailQuantityLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewRetailQuantityLabel.Appearance.Options.UseFont = True
        Me.NewRetailQuantityLabel.Location = New System.Drawing.Point(18, 83)
        Me.NewRetailQuantityLabel.Name = "NewRetailQuantityLabel"
        Me.NewRetailQuantityLabel.Size = New System.Drawing.Size(112, 15)
        Me.NewRetailQuantityLabel.TabIndex = 1
        Me.NewRetailQuantityLabel.Text = "New Retail Quantity:"
        '
        'CurrentWholesaleQuantityLabel
        '
        Me.CurrentWholesaleQuantityLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentWholesaleQuantityLabel.Appearance.Options.UseFont = True
        Me.CurrentWholesaleQuantityLabel.Location = New System.Drawing.Point(18, 36)
        Me.CurrentWholesaleQuantityLabel.Name = "CurrentWholesaleQuantityLabel"
        Me.CurrentWholesaleQuantityLabel.Size = New System.Drawing.Size(157, 15)
        Me.CurrentWholesaleQuantityLabel.TabIndex = 1
        Me.CurrentWholesaleQuantityLabel.Text = "Current Wholesale Quantity:"
        '
        'ReorderWholesaleQuantityLabel
        '
        Me.ReorderWholesaleQuantityLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReorderWholesaleQuantityLabel.Appearance.Options.UseFont = True
        Me.ReorderWholesaleQuantityLabel.Location = New System.Drawing.Point(18, 62)
        Me.ReorderWholesaleQuantityLabel.Name = "ReorderWholesaleQuantityLabel"
        Me.ReorderWholesaleQuantityLabel.Size = New System.Drawing.Size(159, 15)
        Me.ReorderWholesaleQuantityLabel.TabIndex = 1
        Me.ReorderWholesaleQuantityLabel.Text = "Reorder Wholesale Quantity:"
        '
        'NewWholesaleQuantityLabel
        '
        Me.NewWholesaleQuantityLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewWholesaleQuantityLabel.Appearance.Options.UseFont = True
        Me.NewWholesaleQuantityLabel.Location = New System.Drawing.Point(18, 88)
        Me.NewWholesaleQuantityLabel.Name = "NewWholesaleQuantityLabel"
        Me.NewWholesaleQuantityLabel.Size = New System.Drawing.Size(139, 15)
        Me.NewWholesaleQuantityLabel.TabIndex = 1
        Me.NewWholesaleQuantityLabel.Text = "New Wholesale Quantity:"
        '
        'ReorderDateLabel
        '
        Me.ReorderDateLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReorderDateLabel.Appearance.Options.UseFont = True
        Me.ReorderDateLabel.Location = New System.Drawing.Point(22, 35)
        Me.ReorderDateLabel.Name = "ReorderDateLabel"
        Me.ReorderDateLabel.Size = New System.Drawing.Size(74, 15)
        Me.ReorderDateLabel.TabIndex = 1
        Me.ReorderDateLabel.Text = "Reorder Date:"
        '
        'RorderSourceLabel
        '
        Me.RorderSourceLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RorderSourceLabel.Appearance.Options.UseFont = True
        Me.RorderSourceLabel.Location = New System.Drawing.Point(22, 61)
        Me.RorderSourceLabel.Name = "RorderSourceLabel"
        Me.RorderSourceLabel.Size = New System.Drawing.Size(80, 15)
        Me.RorderSourceLabel.TabIndex = 1
        Me.RorderSourceLabel.Text = "Rorder Source:"
        '
        'SupervisorLabel
        '
        Me.SupervisorLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupervisorLabel.Appearance.Options.UseFont = True
        Me.SupervisorLabel.Location = New System.Drawing.Point(22, 87)
        Me.SupervisorLabel.Name = "SupervisorLabel"
        Me.SupervisorLabel.Size = New System.Drawing.Size(62, 15)
        Me.SupervisorLabel.TabIndex = 1
        Me.SupervisorLabel.Text = "Supervisor:"
        '
        'CommentLabel
        '
        Me.CommentLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommentLabel.Appearance.Options.UseFont = True
        Me.CommentLabel.Location = New System.Drawing.Point(22, 113)
        Me.CommentLabel.Name = "CommentLabel"
        Me.CommentLabel.Size = New System.Drawing.Size(54, 15)
        Me.CommentLabel.TabIndex = 1
        Me.CommentLabel.Text = "Comment:"
        '
        'RegDateLabel
        '
        Me.RegDateLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegDateLabel.Appearance.Options.UseFont = True
        Me.RegDateLabel.Location = New System.Drawing.Point(17, 35)
        Me.RegDateLabel.Name = "RegDateLabel"
        Me.RegDateLabel.Size = New System.Drawing.Size(50, 15)
        Me.RegDateLabel.TabIndex = 1
        Me.RegDateLabel.Text = "Reg Date:"
        '
        'InputedByLabel
        '
        Me.InputedByLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputedByLabel.Appearance.Options.UseFont = True
        Me.InputedByLabel.Location = New System.Drawing.Point(17, 63)
        Me.InputedByLabel.Name = "InputedByLabel"
        Me.InputedByLabel.Size = New System.Drawing.Size(61, 15)
        Me.InputedByLabel.TabIndex = 1
        Me.InputedByLabel.Text = "Inputed By:"
        '
        'ReorderIDDataGridViewTextBoxColumn
        '
        Me.ReorderIDDataGridViewTextBoxColumn.DataPropertyName = "ReorderID"
        Me.ReorderIDDataGridViewTextBoxColumn.HeaderText = "ReorderID"
        Me.ReorderIDDataGridViewTextBoxColumn.Name = "ReorderIDDataGridViewTextBoxColumn"
        Me.ReorderIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockIDDataGridViewTextBoxColumn
        '
        Me.StockIDDataGridViewTextBoxColumn.DataPropertyName = "StockID"
        Me.StockIDDataGridViewTextBoxColumn.HeaderText = "StockID"
        Me.StockIDDataGridViewTextBoxColumn.Name = "StockIDDataGridViewTextBoxColumn"
        Me.StockIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrentRetailQuantityDataGridViewTextBoxColumn
        '
        Me.CurrentRetailQuantityDataGridViewTextBoxColumn.DataPropertyName = "CurrentRetailQuantity"
        Me.CurrentRetailQuantityDataGridViewTextBoxColumn.HeaderText = "CurrentRetailQuantity"
        Me.CurrentRetailQuantityDataGridViewTextBoxColumn.Name = "CurrentRetailQuantityDataGridViewTextBoxColumn"
        Me.CurrentRetailQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReorderRetailQuantityDataGridViewTextBoxColumn
        '
        Me.ReorderRetailQuantityDataGridViewTextBoxColumn.DataPropertyName = "ReorderRetailQuantity"
        Me.ReorderRetailQuantityDataGridViewTextBoxColumn.HeaderText = "ReorderRetailQuantity"
        Me.ReorderRetailQuantityDataGridViewTextBoxColumn.Name = "ReorderRetailQuantityDataGridViewTextBoxColumn"
        Me.ReorderRetailQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NewRetailQuantityDataGridViewTextBoxColumn
        '
        Me.NewRetailQuantityDataGridViewTextBoxColumn.DataPropertyName = "NewRetailQuantity"
        Me.NewRetailQuantityDataGridViewTextBoxColumn.HeaderText = "NewRetailQuantity"
        Me.NewRetailQuantityDataGridViewTextBoxColumn.Name = "NewRetailQuantityDataGridViewTextBoxColumn"
        Me.NewRetailQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrentWholesaleQuantityDataGridViewTextBoxColumn
        '
        Me.CurrentWholesaleQuantityDataGridViewTextBoxColumn.DataPropertyName = "CurrentWholesaleQuantity"
        Me.CurrentWholesaleQuantityDataGridViewTextBoxColumn.HeaderText = "CurrentWholesaleQuantity"
        Me.CurrentWholesaleQuantityDataGridViewTextBoxColumn.Name = "CurrentWholesaleQuantityDataGridViewTextBoxColumn"
        Me.CurrentWholesaleQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReorderWholesaleQuantityDataGridViewTextBoxColumn
        '
        Me.ReorderWholesaleQuantityDataGridViewTextBoxColumn.DataPropertyName = "ReorderWholesaleQuantity"
        Me.ReorderWholesaleQuantityDataGridViewTextBoxColumn.HeaderText = "ReorderWholesaleQuantity"
        Me.ReorderWholesaleQuantityDataGridViewTextBoxColumn.Name = "ReorderWholesaleQuantityDataGridViewTextBoxColumn"
        Me.ReorderWholesaleQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NewWholesaleQuantityDataGridViewTextBoxColumn
        '
        Me.NewWholesaleQuantityDataGridViewTextBoxColumn.DataPropertyName = "NewWholesaleQuantity"
        Me.NewWholesaleQuantityDataGridViewTextBoxColumn.HeaderText = "NewWholesaleQuantity"
        Me.NewWholesaleQuantityDataGridViewTextBoxColumn.Name = "NewWholesaleQuantityDataGridViewTextBoxColumn"
        Me.NewWholesaleQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReorderDateDataGridViewTextBoxColumn
        '
        Me.ReorderDateDataGridViewTextBoxColumn.DataPropertyName = "ReorderDate"
        Me.ReorderDateDataGridViewTextBoxColumn.HeaderText = "ReorderDate"
        Me.ReorderDateDataGridViewTextBoxColumn.Name = "ReorderDateDataGridViewTextBoxColumn"
        Me.ReorderDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RorderSourceDataGridViewTextBoxColumn
        '
        Me.RorderSourceDataGridViewTextBoxColumn.DataPropertyName = "RorderSource"
        Me.RorderSourceDataGridViewTextBoxColumn.HeaderText = "RorderSource"
        Me.RorderSourceDataGridViewTextBoxColumn.Name = "RorderSourceDataGridViewTextBoxColumn"
        Me.RorderSourceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupervisorDataGridViewTextBoxColumn
        '
        Me.SupervisorDataGridViewTextBoxColumn.DataPropertyName = "Supervisor"
        Me.SupervisorDataGridViewTextBoxColumn.HeaderText = "Supervisor"
        Me.SupervisorDataGridViewTextBoxColumn.Name = "SupervisorDataGridViewTextBoxColumn"
        Me.SupervisorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "Comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "Comment"
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        Me.CommentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RegDateDataGridViewTextBoxColumn
        '
        Me.RegDateDataGridViewTextBoxColumn.DataPropertyName = "RegDate"
        Me.RegDateDataGridViewTextBoxColumn.HeaderText = "RegDate"
        Me.RegDateDataGridViewTextBoxColumn.Name = "RegDateDataGridViewTextBoxColumn"
        Me.RegDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InputedByDataGridViewTextBoxColumn
        '
        Me.InputedByDataGridViewTextBoxColumn.DataPropertyName = "InputedBy"
        Me.InputedByDataGridViewTextBoxColumn.HeaderText = "InputedBy"
        Me.InputedByDataGridViewTextBoxColumn.Name = "InputedByDataGridViewTextBoxColumn"
        Me.InputedByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReorderIDTextBox
        '
        Me.ReorderIDTextBox.EnterMoveNextControl = True
        Me.ReorderIDTextBox.Location = New System.Drawing.Point(85, 30)
        Me.ReorderIDTextBox.Name = "ReorderIDTextBox"
        Me.ReorderIDTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.ReorderIDTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.ReorderIDTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.ReorderIDTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.ReorderIDTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ReorderIDTextBox.Properties.ReadOnly = True
        Me.ReorderIDTextBox.Size = New System.Drawing.Size(261, 22)
        Me.ReorderIDTextBox.TabIndex = 1
        '
        'StockIDGridBox
        '
        Me.StockIDGridBox.Location = New System.Drawing.Point(85, 56)
        Me.StockIDGridBox.Name = "StockIDGridBox"
        Me.StockIDGridBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.StockIDGridBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StockIDGridBox.Properties.NullText = ""
        Me.StockIDGridBox.Size = New System.Drawing.Size(261, 22)
        Me.StockIDGridBox.TabIndex = 1
        '
        'CurrentRetailQuantityTextBox
        '
        Me.CurrentRetailQuantityTextBox.EnterMoveNextControl = True
        Me.CurrentRetailQuantityTextBox.Location = New System.Drawing.Point(185, 28)
        Me.CurrentRetailQuantityTextBox.Name = "CurrentRetailQuantityTextBox"
        Me.CurrentRetailQuantityTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.CurrentRetailQuantityTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.CurrentRetailQuantityTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.CurrentRetailQuantityTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.CurrentRetailQuantityTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CurrentRetailQuantityTextBox.Properties.ReadOnly = True
        Me.CurrentRetailQuantityTextBox.Size = New System.Drawing.Size(166, 22)
        Me.CurrentRetailQuantityTextBox.TabIndex = 1
        '
        'ReorderRetailQuantityTextBox
        '
        Me.ReorderRetailQuantityTextBox.EnterMoveNextControl = True
        Me.ReorderRetailQuantityTextBox.Location = New System.Drawing.Point(185, 54)
        Me.ReorderRetailQuantityTextBox.Name = "ReorderRetailQuantityTextBox"
        Me.ReorderRetailQuantityTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.ReorderRetailQuantityTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.ReorderRetailQuantityTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.ReorderRetailQuantityTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.ReorderRetailQuantityTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ReorderRetailQuantityTextBox.Size = New System.Drawing.Size(166, 22)
        Me.ReorderRetailQuantityTextBox.TabIndex = 1
        '
        'NewRetailQuantityTextBox
        '
        Me.NewRetailQuantityTextBox.EnterMoveNextControl = True
        Me.NewRetailQuantityTextBox.Location = New System.Drawing.Point(185, 80)
        Me.NewRetailQuantityTextBox.Name = "NewRetailQuantityTextBox"
        Me.NewRetailQuantityTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.NewRetailQuantityTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.NewRetailQuantityTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.NewRetailQuantityTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.NewRetailQuantityTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.NewRetailQuantityTextBox.Properties.ReadOnly = True
        Me.NewRetailQuantityTextBox.Size = New System.Drawing.Size(166, 22)
        Me.NewRetailQuantityTextBox.TabIndex = 1
        '
        'CurrentWholesaleQuantityTextBox
        '
        Me.CurrentWholesaleQuantityTextBox.EnterMoveNextControl = True
        Me.CurrentWholesaleQuantityTextBox.Location = New System.Drawing.Point(185, 33)
        Me.CurrentWholesaleQuantityTextBox.Name = "CurrentWholesaleQuantityTextBox"
        Me.CurrentWholesaleQuantityTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.CurrentWholesaleQuantityTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.CurrentWholesaleQuantityTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.CurrentWholesaleQuantityTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.CurrentWholesaleQuantityTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CurrentWholesaleQuantityTextBox.Properties.ReadOnly = True
        Me.CurrentWholesaleQuantityTextBox.Size = New System.Drawing.Size(166, 22)
        Me.CurrentWholesaleQuantityTextBox.TabIndex = 1
        '
        'ReorderWholesaleQuantityTextBox
        '
        Me.ReorderWholesaleQuantityTextBox.EnterMoveNextControl = True
        Me.ReorderWholesaleQuantityTextBox.Location = New System.Drawing.Point(185, 59)
        Me.ReorderWholesaleQuantityTextBox.Name = "ReorderWholesaleQuantityTextBox"
        Me.ReorderWholesaleQuantityTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.ReorderWholesaleQuantityTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.ReorderWholesaleQuantityTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.ReorderWholesaleQuantityTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.ReorderWholesaleQuantityTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ReorderWholesaleQuantityTextBox.Size = New System.Drawing.Size(166, 22)
        Me.ReorderWholesaleQuantityTextBox.TabIndex = 1
        '
        'NewWholesaleQuantityTextBox
        '
        Me.NewWholesaleQuantityTextBox.EnterMoveNextControl = True
        Me.NewWholesaleQuantityTextBox.Location = New System.Drawing.Point(185, 85)
        Me.NewWholesaleQuantityTextBox.Name = "NewWholesaleQuantityTextBox"
        Me.NewWholesaleQuantityTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.NewWholesaleQuantityTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.NewWholesaleQuantityTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.NewWholesaleQuantityTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.NewWholesaleQuantityTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.NewWholesaleQuantityTextBox.Properties.ReadOnly = True
        Me.NewWholesaleQuantityTextBox.Size = New System.Drawing.Size(166, 22)
        Me.NewWholesaleQuantityTextBox.TabIndex = 1
        '
        'ReorderDateDateTimePicker
        '
        Me.ReorderDateDateTimePicker.EditValue = Nothing
        Me.ReorderDateDateTimePicker.Location = New System.Drawing.Point(109, 32)
        Me.ReorderDateDateTimePicker.Name = "ReorderDateDateTimePicker"
        Me.ReorderDateDateTimePicker.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ReorderDateDateTimePicker.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReorderDateDateTimePicker.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReorderDateDateTimePicker.Properties.Mask.BeepOnError = True
        Me.ReorderDateDateTimePicker.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.ReorderDateDateTimePicker.Size = New System.Drawing.Size(166, 22)
        Me.ReorderDateDateTimePicker.TabIndex = 1
        '
        'RorderSourceTextBox
        '
        Me.RorderSourceTextBox.EnterMoveNextControl = True
        Me.RorderSourceTextBox.Location = New System.Drawing.Point(109, 58)
        Me.RorderSourceTextBox.Name = "RorderSourceTextBox"
        Me.RorderSourceTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RorderSourceTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.RorderSourceTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.RorderSourceTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.RorderSourceTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RorderSourceTextBox.Size = New System.Drawing.Size(166, 22)
        Me.RorderSourceTextBox.TabIndex = 1
        '
        'SupervisorTextBox
        '
        Me.SupervisorTextBox.EnterMoveNextControl = True
        Me.SupervisorTextBox.Location = New System.Drawing.Point(109, 84)
        Me.SupervisorTextBox.Name = "SupervisorTextBox"
        Me.SupervisorTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.SupervisorTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.SupervisorTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.SupervisorTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.SupervisorTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SupervisorTextBox.Size = New System.Drawing.Size(166, 22)
        Me.SupervisorTextBox.TabIndex = 1
        '
        'CommentTextBox
        '
        Me.CommentTextBox.EnterMoveNextControl = True
        Me.CommentTextBox.Location = New System.Drawing.Point(109, 110)
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.CommentTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.CommentTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.CommentTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.CommentTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CommentTextBox.Size = New System.Drawing.Size(166, 22)
        Me.CommentTextBox.TabIndex = 1
        '
        'RegDateTextBox
        '
        Me.RegDateTextBox.EnterMoveNextControl = True
        Me.RegDateTextBox.Location = New System.Drawing.Point(92, 31)
        Me.RegDateTextBox.Name = "RegDateTextBox"
        Me.RegDateTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RegDateTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.RegDateTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.RegDateTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.RegDateTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RegDateTextBox.Properties.ReadOnly = True
        Me.RegDateTextBox.Size = New System.Drawing.Size(185, 22)
        Me.RegDateTextBox.TabIndex = 1
        '
        'InputedByTextBox
        '
        Me.InputedByTextBox.EnterMoveNextControl = True
        Me.InputedByTextBox.Location = New System.Drawing.Point(92, 59)
        Me.InputedByTextBox.Name = "InputedByTextBox"
        Me.InputedByTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.InputedByTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.InputedByTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.InputedByTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.InputedByTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.InputedByTextBox.Size = New System.Drawing.Size(185, 22)
        Me.InputedByTextBox.TabIndex = 1
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SearchToolStripLabel
        '
        Me.SearchToolStripLabel.ForeColor = System.Drawing.Color.Black
        Me.SearchToolStripLabel.Name = "SearchToolStripLabel"
        Me.SearchToolStripLabel.Size = New System.Drawing.Size(45, 22)
        Me.SearchToolStripLabel.Text = "Search:"
        '
        'SearchToolStripComboBox
        '
        Me.SearchToolStripComboBox.Name = "SearchToolStripComboBox"
        Me.SearchToolStripComboBox.Size = New System.Drawing.Size(200, 25)
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.ForeColor = System.Drawing.Color.Black
        Me.SearchToolStripButton.Image = CType(resources.GetObject("SearchToolStripButton.Image"), System.Drawing.Image)
        Me.SearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(89, 22)
        Me.SearchToolStripButton.Text = "Start Search"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.StockReorderDataGridView
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.SearchInPreview = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'StockReorderDataGridView
        '
        Me.StockReorderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StockReorderDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.StockReorderDataGridView.MainView = Me.GridView1
        Me.StockReorderDataGridView.Name = "StockReorderDataGridView"
        Me.StockReorderDataGridView.Size = New System.Drawing.Size(784, 551)
        Me.StockReorderDataGridView.TabIndex = 23
        Me.StockReorderDataGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BottomStatusStrip
        '
        Me.BottomStatusStrip.BackColor = System.Drawing.Color.Transparent
        Me.BottomStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoofRecordsLabelToolStripStatusLabel, Me.NoofRecordsToolStripStatusLabel, Me.lblInformation})
        Me.BottomStatusStrip.Location = New System.Drawing.Point(2, 607)
        Me.BottomStatusStrip.Name = "BottomStatusStrip"
        Me.BottomStatusStrip.Size = New System.Drawing.Size(1011, 22)
        Me.BottomStatusStrip.TabIndex = 89
        Me.BottomStatusStrip.Text = "StatusStrip1"
        '
        'NoofRecordsLabelToolStripStatusLabel
        '
        Me.NoofRecordsLabelToolStripStatusLabel.ForeColor = System.Drawing.Color.Black
        Me.NoofRecordsLabelToolStripStatusLabel.Name = "NoofRecordsLabelToolStripStatusLabel"
        Me.NoofRecordsLabelToolStripStatusLabel.Size = New System.Drawing.Size(88, 17)
        Me.NoofRecordsLabelToolStripStatusLabel.Text = "No of Records: "
        '
        'NoofRecordsToolStripStatusLabel
        '
        Me.NoofRecordsToolStripStatusLabel.ForeColor = System.Drawing.Color.Black
        Me.NoofRecordsToolStripStatusLabel.Name = "NoofRecordsToolStripStatusLabel"
        Me.NoofRecordsToolStripStatusLabel.Size = New System.Drawing.Size(13, 17)
        Me.NoofRecordsToolStripStatusLabel.Text = "0"
        '
        'lblInformation
        '
        Me.lblInformation.ForeColor = System.Drawing.Color.Black
        Me.lblInformation.Image = Global.MoCTIMIS.My.Resources.Resources.edit_paste_9
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(895, 17)
        Me.lblInformation.Spring = True
        Me.lblInformation.Text = "Information"
        '
        'cmdClosePanelNew
        '
        Me.cmdClosePanelNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClosePanelNew.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClosePanelNew.Appearance.Options.UseFont = True
        Me.cmdClosePanelNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdClosePanelNew.Location = New System.Drawing.Point(807, 2)
        Me.cmdClosePanelNew.Name = "cmdClosePanelNew"
        Me.cmdClosePanelNew.Size = New System.Drawing.Size(29, 28)
        Me.cmdClosePanelNew.TabIndex = 48
        Me.cmdClosePanelNew.Text = "X"
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopMenuStrip.AutoSize = False
        Me.TopMenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.TopMenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 3)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(1015, 24)
        Me.TopMenuStrip.TabIndex = 85
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "&Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.PrintAllListedRecordsToolStripMenuItem, Me.SearchToolStripMenuItem, Me.SearchByDateToolStripMenuItem, Me.AdvancedSummaryToolStripMenuItem, Me.ImportWizardToolStripMenuItem, Me.ExportToExcellToolStripMenuItem})
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PrintToolStripMenuItem.Text = "Print Current Record"
        '
        'PrintAllListedRecordsToolStripMenuItem
        '
        Me.PrintAllListedRecordsToolStripMenuItem.Name = "PrintAllListedRecordsToolStripMenuItem"
        Me.PrintAllListedRecordsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PrintAllListedRecordsToolStripMenuItem.Text = "Print All Listed Records"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SearchToolStripMenuItem.Text = "General Search"
        '
        'AdvancedSummaryToolStripMenuItem
        '
        Me.AdvancedSummaryToolStripMenuItem.Name = "AdvancedSummaryToolStripMenuItem"
        Me.AdvancedSummaryToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AdvancedSummaryToolStripMenuItem.Text = "Advanced Summary"
        '
        'ImportWizardToolStripMenuItem
        '
        Me.ImportWizardToolStripMenuItem.Name = "ImportWizardToolStripMenuItem"
        Me.ImportWizardToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ImportWizardToolStripMenuItem.Text = "Import Wizard"
        '
        'ExportToExcellToolStripMenuItem
        '
        Me.ExportToExcellToolStripMenuItem.Name = "ExportToExcellToolStripMenuItem"
        Me.ExportToExcellToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ExportToExcellToolStripMenuItem.Text = "Export to Excel"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TopToolStrip
        '
        Me.TopToolStrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopToolStrip.AutoSize = False
        Me.TopToolStrip.BackColor = System.Drawing.Color.Transparent
        Me.TopToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.TopToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.DeleteToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.HelpToolStripButton, Me.ToolStripSeparator2, Me.SearchToolStripLabel, Me.SearchToolStripComboBox, Me.SearchToolStripButton, Me.cmdPrevious, Me.cmdNext})
        Me.TopToolStrip.Location = New System.Drawing.Point(0, 27)
        Me.TopToolStrip.Name = "TopToolStrip"
        Me.TopToolStrip.Size = New System.Drawing.Size(1016, 25)
        Me.TopToolStrip.TabIndex = 88
        Me.TopToolStrip.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(51, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(56, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(51, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteToolStripButton
        '
        Me.DeleteToolStripButton.Image = CType(resources.GetObject("DeleteToolStripButton.Image"), System.Drawing.Image)
        Me.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteToolStripButton.Name = "DeleteToolStripButton"
        Me.DeleteToolStripButton.Size = New System.Drawing.Size(60, 22)
        Me.DeleteToolStripButton.Text = "&Delete"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'PanelBody
        '
        Me.PanelBody.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelBody.Appearance.Options.UseBackColor = True
        Me.PanelBody.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelBody.Controls.Add(Me.PanelNew)
        Me.PanelBody.Controls.Add(Me.PanelSearchByDate)
        Me.PanelBody.Controls.Add(Me.BottomStatusStrip)
        Me.PanelBody.Controls.Add(Me.SplitContainerControl1)
        Me.PanelBody.Controls.Add(Me.TopMenuStrip)
        Me.PanelBody.Controls.Add(Me.PanelExporting)
        Me.PanelBody.Controls.Add(Me.TopToolStrip)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(0, 0)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(1015, 631)
        Me.PanelBody.TabIndex = 1
        '
        'PanelNew
        '
        Me.PanelNew.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelNew.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelNew.Appearance.Options.UseBackColor = True
        Me.PanelNew.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelNew.Controls.Add(Me.GroupControl5)
        Me.PanelNew.Controls.Add(Me.GroupControl4)
        Me.PanelNew.Controls.Add(Me.GroupControl3)
        Me.PanelNew.Controls.Add(Me.GroupControl2)
        Me.PanelNew.Controls.Add(Me.GroupControl1)
        Me.PanelNew.Controls.Add(Me.cmdClosePanelNew)
        Me.PanelNew.Controls.Add(Me.lblFormName)
        Me.PanelNew.Location = New System.Drawing.Point(47, 77)
        Me.PanelNew.Name = "PanelNew"
        Me.PanelNew.Size = New System.Drawing.Size(838, 497)
        Me.PanelNew.TabIndex = 99
        Me.PanelNew.Visible = False
        '
        'GroupControl5
        '
        Me.GroupControl5.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl5.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl5.Controls.Add(Me.CurrentRetailQuantityTextBox)
        Me.GroupControl5.Controls.Add(Me.NewRetailQuantityLabel)
        Me.GroupControl5.Controls.Add(Me.ReorderRetailQuantityLabel)
        Me.GroupControl5.Controls.Add(Me.ReorderRetailQuantityTextBox)
        Me.GroupControl5.Controls.Add(Me.CurrentRetailQuantityLabel)
        Me.GroupControl5.Controls.Add(Me.NewRetailQuantityTextBox)
        Me.GroupControl5.Location = New System.Drawing.Point(26, 145)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(371, 115)
        Me.GroupControl5.TabIndex = 53
        Me.GroupControl5.Text = "GroupControl5"
        '
        'GroupControl4
        '
        Me.GroupControl4.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl4.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl4.Controls.Add(Me.ReorderDateDateTimePicker)
        Me.GroupControl4.Controls.Add(Me.RorderSourceTextBox)
        Me.GroupControl4.Controls.Add(Me.SupervisorTextBox)
        Me.GroupControl4.Controls.Add(Me.CommentTextBox)
        Me.GroupControl4.Controls.Add(Me.ReorderDateLabel)
        Me.GroupControl4.Controls.Add(Me.RorderSourceLabel)
        Me.GroupControl4.Controls.Add(Me.SupervisorLabel)
        Me.GroupControl4.Controls.Add(Me.CommentLabel)
        Me.GroupControl4.Location = New System.Drawing.Point(405, 49)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(302, 143)
        Me.GroupControl4.TabIndex = 52
        Me.GroupControl4.Text = "Other Details of Reorder"
        '
        'GroupControl3
        '
        Me.GroupControl3.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl3.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl3.Controls.Add(Me.ReorderIDTextBox)
        Me.GroupControl3.Controls.Add(Me.StockIDGridBox)
        Me.GroupControl3.Controls.Add(Me.ReorderIDLabel)
        Me.GroupControl3.Controls.Add(Me.StockIDLabel)
        Me.GroupControl3.Location = New System.Drawing.Point(26, 49)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(371, 90)
        Me.GroupControl3.TabIndex = 51
        Me.GroupControl3.Text = "Details of Reorder"
        '
        'GroupControl2
        '
        Me.GroupControl2.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl2.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl2.Controls.Add(Me.CurrentWholesaleQuantityTextBox)
        Me.GroupControl2.Controls.Add(Me.ReorderWholesaleQuantityTextBox)
        Me.GroupControl2.Controls.Add(Me.NewWholesaleQuantityTextBox)
        Me.GroupControl2.Controls.Add(Me.CurrentWholesaleQuantityLabel)
        Me.GroupControl2.Controls.Add(Me.ReorderWholesaleQuantityLabel)
        Me.GroupControl2.Controls.Add(Me.NewWholesaleQuantityLabel)
        Me.GroupControl2.Location = New System.Drawing.Point(26, 266)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(371, 119)
        Me.GroupControl2.TabIndex = 50
        Me.GroupControl2.Text = "Wholesale Section"
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl1.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.RegDateTextBox)
        Me.GroupControl1.Controls.Add(Me.InputedByTextBox)
        Me.GroupControl1.Controls.Add(Me.RegDateLabel)
        Me.GroupControl1.Controls.Add(Me.InputedByLabel)
        Me.GroupControl1.Location = New System.Drawing.Point(403, 291)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(304, 94)
        Me.GroupControl1.TabIndex = 49
        Me.GroupControl1.Text = "System Audit"
        '
        'lblFormName
        '
        Me.lblFormName.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblFormName.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormName.Appearance.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblFormName.Appearance.Options.UseBackColor = True
        Me.lblFormName.Appearance.Options.UseFont = True
        Me.lblFormName.Appearance.Options.UseForeColor = True
        Me.lblFormName.Location = New System.Drawing.Point(27, 17)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(129, 26)
        Me.lblFormName.TabIndex = 1
        Me.lblFormName.Text = "Stock Reorder"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Location = New System.Drawing.Point(3, 49)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.StockReorderDataGridView)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.VGridControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1009, 551)
        Me.SplitContainerControl1.SplitterPosition = 221
        Me.SplitContainerControl1.TabIndex = 91
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'VGridControl1
        '
        Me.VGridControl1.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VGridControl1.Appearance.RecordValue.Options.UseFont = True
        Me.VGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.Size = New System.Drawing.Size(221, 551)
        Me.VGridControl1.TabIndex = 0
        '
        'PanelExporting
        '
        Me.PanelExporting.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PanelExporting.Appearance.Options.UseForeColor = True
        Me.PanelExporting.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelExporting.Controls.Add(Me.PanelProgressbarContainer)
        Me.PanelExporting.Controls.Add(Me.cmdCloseExport)
        Me.PanelExporting.Controls.Add(Me.lblExportPercentage)
        Me.PanelExporting.Controls.Add(Me.lblNoRows)
        Me.PanelExporting.Controls.Add(Me.lblNoValues)
        Me.PanelExporting.Controls.Add(Me.PictureBox2)
        Me.PanelExporting.Controls.Add(Me.lblExportStatus)
        Me.PanelExporting.Controls.Add(Me.Label26)
        Me.PanelExporting.Location = New System.Drawing.Point(327, 248)
        Me.PanelExporting.Name = "PanelExporting"
        Me.PanelExporting.Size = New System.Drawing.Size(295, 134)
        Me.PanelExporting.TabIndex = 87
        Me.PanelExporting.Visible = False
        '
        'PanelProgressbarContainer
        '
        Me.PanelProgressbarContainer.Controls.Add(Me.PanelProgressbar)
        Me.PanelProgressbarContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelProgressbarContainer.Location = New System.Drawing.Point(2, 123)
        Me.PanelProgressbarContainer.Name = "PanelProgressbarContainer"
        Me.PanelProgressbarContainer.Size = New System.Drawing.Size(291, 9)
        Me.PanelProgressbarContainer.TabIndex = 59
        '
        'PanelProgressbar
        '
        Me.PanelProgressbar.Appearance.BackColor = System.Drawing.Color.LimeGreen
        Me.PanelProgressbar.Appearance.Options.UseBackColor = True
        Me.PanelProgressbar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelProgressbar.Location = New System.Drawing.Point(2, 2)
        Me.PanelProgressbar.Name = "PanelProgressbar"
        Me.PanelProgressbar.Size = New System.Drawing.Size(10, 5)
        Me.PanelProgressbar.TabIndex = 0
        '
        'cmdCloseExport
        '
        Me.cmdCloseExport.Appearance.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseExport.Appearance.Options.UseFont = True
        Me.cmdCloseExport.Location = New System.Drawing.Point(265, -1)
        Me.cmdCloseExport.Name = "cmdCloseExport"
        Me.cmdCloseExport.Size = New System.Drawing.Size(29, 28)
        Me.cmdCloseExport.TabIndex = 47
        Me.cmdCloseExport.Text = "X"
        '
        'lblExportPercentage
        '
        Me.lblExportPercentage.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExportPercentage.Appearance.Options.UseFont = True
        Me.lblExportPercentage.Location = New System.Drawing.Point(186, 100)
        Me.lblExportPercentage.Name = "lblExportPercentage"
        Me.lblExportPercentage.Size = New System.Drawing.Size(70, 14)
        Me.lblExportPercentage.TabIndex = 57
        Me.lblExportPercentage.Text = "0% Complete"
        '
        'lblNoRows
        '
        Me.lblNoRows.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRows.Appearance.Options.UseFont = True
        Me.lblNoRows.Location = New System.Drawing.Point(9, 81)
        Me.lblNoRows.Name = "lblNoRows"
        Me.lblNoRows.Size = New System.Drawing.Size(83, 15)
        Me.lblNoRows.TabIndex = 57
        Me.lblNoRows.Text = "Records: 12/51"
        '
        'lblNoValues
        '
        Me.lblNoValues.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoValues.Appearance.Options.UseFont = True
        Me.lblNoValues.Location = New System.Drawing.Point(9, 99)
        Me.lblNoValues.Name = "lblNoValues"
        Me.lblNoValues.Size = New System.Drawing.Size(74, 15)
        Me.lblNoValues.TabIndex = 57
        Me.lblNoValues.Text = "Values: 12/51"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MoCTIMIS.My.Resources.Resources.edit_paste_9
        Me.PictureBox2.Location = New System.Drawing.Point(217, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'lblExportStatus
        '
        Me.lblExportStatus.Appearance.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExportStatus.Appearance.Options.UseFont = True
        Me.lblExportStatus.Location = New System.Drawing.Point(48, 32)
        Me.lblExportStatus.Name = "lblExportStatus"
        Me.lblExportStatus.Size = New System.Drawing.Size(94, 21)
        Me.lblExportStatus.TabIndex = 57
        Me.lblExportStatus.Text = "Please Wait..."
        '
        'Label26
        '
        Me.Label26.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Appearance.Options.UseFont = True
        Me.Label26.Location = New System.Drawing.Point(8, 8)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(134, 21)
        Me.Label26.TabIndex = 57
        Me.Label26.Text = "Exporting to Excell"
        '
        'frmStockReorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 631)
        Me.Controls.Add(Me.PanelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStockReorder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "StockReorder"
        CType(Me.PanelSearchByDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSearchByDate.ResumeLayout(False)
        Me.PanelSearchByDate.PerformLayout()
        CType(Me.EndDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchDateFieldComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReorderIDTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockIDGridBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentRetailQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReorderRetailQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewRetailQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentWholesaleQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReorderWholesaleQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewWholesaleQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReorderDateDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReorderDateDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RorderSourceTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupervisorTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegDateTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputedByTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockReorderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomStatusStrip.ResumeLayout(False)
        Me.BottomStatusStrip.PerformLayout()
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.TopToolStrip.ResumeLayout(False)
        Me.TopToolStrip.PerformLayout()
        CType(Me.PanelBody, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBody.ResumeLayout(False)
        Me.PanelBody.PerformLayout()
        CType(Me.PanelNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNew.ResumeLayout(False)
        Me.PanelNew.PerformLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelExporting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelExporting.ResumeLayout(False)
        Me.PanelExporting.PerformLayout()
        CType(Me.PanelProgressbarContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProgressbarContainer.ResumeLayout(False)
        CType(Me.PanelProgressbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReorderIDTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents StockIDGridBox As DevExpress.XtraEditors.GridLookUpEdit
Friend WithEvents CurrentRetailQuantityTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents ReorderRetailQuantityTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents NewRetailQuantityTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents CurrentWholesaleQuantityTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents ReorderWholesaleQuantityTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents NewWholesaleQuantityTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents ReorderDateDateTimePicker As DevExpress.XtraEditors.DateEdit
Friend WithEvents RorderSourceTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents SupervisorTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents CommentTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents RegDateTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents InputedByTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents ReorderIDLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents StockIDLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents CurrentRetailQuantityLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents ReorderRetailQuantityLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents NewRetailQuantityLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents CurrentWholesaleQuantityLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents ReorderWholesaleQuantityLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents NewWholesaleQuantityLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents ReorderDateLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents RorderSourceLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents SupervisorLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents CommentLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents RegDateLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents InputedByLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents ReorderIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents StockIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents CurrentRetailQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents ReorderRetailQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents NewRetailQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents CurrentWholesaleQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents ReorderWholesaleQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents NewWholesaleQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents ReorderDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents RorderSourceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents SupervisorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents CommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents RegDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents InputedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintAllListedRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchByDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelSearchByDate As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdDateSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EndDateTimePicker As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblEndDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents StartDateTimePicker As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblStartDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateField As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SearchDateFieldComboBox As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblSearchTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCloseSearchbyDate As DevExpress.XtraEditors.SimpleButton
Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
Friend WithEvents PanelSearch As DevExpress.XtraEditors.PanelControl
Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
Friend WithEvents SearchToolStripLabel As System.Windows.Forms.ToolStripLabel
Friend WithEvents SearchToolStripComboBox As ToolStripComboBox
Friend WithEvents SearchToolStripButton As System.Windows.Forms.ToolStripButton
Friend WithEvents cmdClosePanelNew As DevExpress.XtraEditors.SimpleButton
Friend WithEvents BottomStatusStrip As System.Windows.Forms.StatusStrip
Friend WithEvents NoofRecordsLabelToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
Friend WithEvents NoofRecordsToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
Friend WithEvents lblInformation As System.Windows.Forms.ToolStripStatusLabel
Friend WithEvents StockReorderDataGridView As DevExpress.XtraGrid.GridControl
Friend WithEvents PanelBody As DevExpress.XtraEditors.PanelControl
Friend WithEvents lblFormName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TopToolStrip As ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TopMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancedSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportWizardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    'Friend WithEvents MyExportBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ExportToExcellToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelNew As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelExporting As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelProgressbarContainer As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelProgressbar As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCloseExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblExportPercentage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNoRows As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNoValues As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblExportStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdPrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdNext As System.Windows.Forms.ToolStripButton
   Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
End Class
