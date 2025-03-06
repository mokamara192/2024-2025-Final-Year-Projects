<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
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
        Me.StockIDLabel = New DevExpress.XtraEditors.LabelControl()
        Me.NameOfItemLabel = New DevExpress.XtraEditors.LabelControl()
        Me.ItemCategoryLabel = New DevExpress.XtraEditors.LabelControl()
        Me.RetailUnitPriceLabel = New DevExpress.XtraEditors.LabelControl()
        Me.RetailUnitOfMeasurementLabel = New DevExpress.XtraEditors.LabelControl()
        Me.RetailQuantityLabel = New DevExpress.XtraEditors.LabelControl()
        Me.RetailLowQuantityLabel = New DevExpress.XtraEditors.LabelControl()
        Me.WholesaleUnitPriceLabel = New DevExpress.XtraEditors.LabelControl()
        Me.WholesaleUnitOfMeasurementLabel = New DevExpress.XtraEditors.LabelControl()
        Me.WholesaleQuantityLabel = New DevExpress.XtraEditors.LabelControl()
        Me.WholesaleLowQuantityLabel = New DevExpress.XtraEditors.LabelControl()
        Me.CommentLabel = New DevExpress.XtraEditors.LabelControl()
        Me.RegDateLabel = New DevExpress.XtraEditors.LabelControl()
        Me.InputedByLabel = New DevExpress.XtraEditors.LabelControl()
        Me.StockIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameOfItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailUnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailUnitOfMeasurementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailLowQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WholesaleUnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WholesaleUnitOfMeasurementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WholesaleQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WholesaleLowQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockIDTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.NameOfItemTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.ItemCategoryGridBox = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.RetailUnitPriceTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.RetailUnitOfMeasurementGridBox = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.RetailQuantityTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.RetailLowQuantityTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.WholesaleUnitPriceTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.WholesaleUnitOfMeasurementGridBox = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.WholesaleQuantityTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.WholesaleLowQuantityTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.CommentTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.RegDateTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.InputedByTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabControlRelated = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPageGeneralSalesItems = New DevExpress.XtraTab.XtraTabPage()
        Me.GeneralSalesItemsGridView = New DevExpress.XtraGrid.GridControl()
        Me.GridViewGeneralSalesItems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolStripGeneralSalesItems = New System.Windows.Forms.ToolStrip()
        Me.cmdAddGeneralSalesItems = New System.Windows.Forms.ToolStripButton()
        Me.cmdOpenRecordGeneralSalesItems = New System.Windows.Forms.ToolStripButton()
        Me.cmdRemoveGeneralSalesItems = New System.Windows.Forms.ToolStripButton()
        Me.cmdSearchGeneralSalesItems = New System.Windows.Forms.ToolStripButton()
        Me.XtraTabPageTransferItems = New DevExpress.XtraTab.XtraTabPage()
        Me.TransferItemsGridView = New DevExpress.XtraGrid.GridControl()
        Me.GridViewTransferItems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolStripTransferItems = New System.Windows.Forms.ToolStrip()
        Me.cmdAddTransferItems = New System.Windows.Forms.ToolStripButton()
        Me.cmdOpenRecordTransferItems = New System.Windows.Forms.ToolStripButton()
        Me.cmdRemoveTransferItems = New System.Windows.Forms.ToolStripButton()
        Me.cmdSearchTransferItems = New System.Windows.Forms.ToolStripButton()
        Me.XtraTabPageStockReorder = New DevExpress.XtraTab.XtraTabPage()
        Me.StockReorderGridView = New DevExpress.XtraGrid.GridControl()
        Me.GridViewStockReorder = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolStripStockReorder = New System.Windows.Forms.ToolStrip()
        Me.cmdAddStockReorder = New System.Windows.Forms.ToolStripButton()
        Me.cmdOpenRecordStockReorder = New System.Windows.Forms.ToolStripButton()
        Me.cmdRemoveStockReorder = New System.Windows.Forms.ToolStripButton()
        Me.cmdSearchStockReorder = New System.Windows.Forms.ToolStripButton()
        Me.lblGeneralSalesItemsInfo = New DevExpress.XtraEditors.LabelControl()
        Me.lblTransferItemsInfo = New DevExpress.XtraEditors.LabelControl()
        Me.lblStockReorderInfo = New DevExpress.XtraEditors.LabelControl()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SearchToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.InventoryDataGridView = New DevExpress.XtraGrid.GridControl()
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
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
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
        CType(Me.StockIDTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameOfItemTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemCategoryGridBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetailUnitPriceTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetailUnitOfMeasurementGridBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetailQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetailLowQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WholesaleUnitPriceTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WholesaleUnitOfMeasurementGridBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WholesaleQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WholesaleLowQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegDateTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputedByTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControlRelated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControlRelated.SuspendLayout()
        Me.XtraTabPageGeneralSalesItems.SuspendLayout()
        CType(Me.GeneralSalesItemsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewGeneralSalesItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripGeneralSalesItems.SuspendLayout()
        Me.XtraTabPageTransferItems.SuspendLayout()
        CType(Me.TransferItemsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTransferItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripTransferItems.SuspendLayout()
        Me.XtraTabPageStockReorder.SuspendLayout()
        CType(Me.StockReorderGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewStockReorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripStockReorder.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomStatusStrip.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.TopToolStrip.SuspendLayout()
        CType(Me.PanelBody, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBody.SuspendLayout()
        CType(Me.PanelNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNew.SuspendLayout()
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
        Me.cmdPrevious.Size = New System.Drawing.Size(88, 28)
        Me.cmdPrevious.Text = "Previous"
        '
        'cmdNext
        '
        Me.cmdNext.Image = CType(resources.GetObject("cmdNext.Image"), System.Drawing.Image)
        Me.cmdNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(64, 28)
        Me.cmdNext.Text = "Next"
        '
        'SearchByDateToolStripMenuItem
        '
        Me.SearchByDateToolStripMenuItem.Name = "SearchByDateToolStripMenuItem"
        Me.SearchByDateToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
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
        Me.PanelSearchByDate.Location = New System.Drawing.Point(677, 15)
        Me.PanelSearchByDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelSearchByDate.Name = "PanelSearchByDate"
        Me.PanelSearchByDate.Size = New System.Drawing.Size(323, 193)
        Me.PanelSearchByDate.TabIndex = 100
        Me.PanelSearchByDate.Visible = False
        '
        'cmdDateSearch
        '
        Me.cmdDateSearch.Location = New System.Drawing.Point(93, 145)
        Me.cmdDateSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDateSearch.Name = "cmdDateSearch"
        Me.cmdDateSearch.Size = New System.Drawing.Size(160, 33)
        Me.cmdDateSearch.TabIndex = 54
        Me.cmdDateSearch.Text = "Search"
        '
        'EndDateTimePicker
        '
        Me.EndDateTimePicker.EditValue = Nothing
        Me.EndDateTimePicker.Location = New System.Drawing.Point(93, 113)
        Me.EndDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EndDateTimePicker.Name = "EndDateTimePicker"
        Me.EndDateTimePicker.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.EndDateTimePicker.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EndDateTimePicker.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EndDateTimePicker.Size = New System.Drawing.Size(160, 24)
        Me.EndDateTimePicker.TabIndex = 53
        '
        'lblEndDate
        '
        Me.lblEndDate.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.Appearance.Options.UseFont = True
        Me.lblEndDate.Location = New System.Drawing.Point(14, 113)
        Me.lblEndDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(63, 19)
        Me.lblEndDate.TabIndex = 51
        Me.lblEndDate.Text = "End Date:"
        '
        'StartDateTimePicker
        '
        Me.StartDateTimePicker.EditValue = Nothing
        Me.StartDateTimePicker.Location = New System.Drawing.Point(93, 81)
        Me.StartDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StartDateTimePicker.Name = "StartDateTimePicker"
        Me.StartDateTimePicker.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.StartDateTimePicker.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StartDateTimePicker.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StartDateTimePicker.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.StartDateTimePicker.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDateTimePicker.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.StartDateTimePicker.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDateTimePicker.Size = New System.Drawing.Size(160, 24)
        Me.StartDateTimePicker.TabIndex = 53
        '
        'lblStartDate
        '
        Me.lblStartDate.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.Appearance.Options.UseFont = True
        Me.lblStartDate.Location = New System.Drawing.Point(14, 81)
        Me.lblStartDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(69, 19)
        Me.lblStartDate.TabIndex = 51
        Me.lblStartDate.Text = "Start Date:"
        '
        'lblDateField
        '
        Me.lblDateField.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateField.Appearance.Options.UseFont = True
        Me.lblDateField.Location = New System.Drawing.Point(14, 49)
        Me.lblDateField.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblDateField.Name = "lblDateField"
        Me.lblDateField.Size = New System.Drawing.Size(70, 19)
        Me.lblDateField.TabIndex = 51
        Me.lblDateField.Text = "Date Field:"
        '
        'SearchDateFieldComboBox
        '
        Me.SearchDateFieldComboBox.Location = New System.Drawing.Point(93, 47)
        Me.SearchDateFieldComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchDateFieldComboBox.Name = "SearchDateFieldComboBox"
        Me.SearchDateFieldComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SearchDateFieldComboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchDateFieldComboBox.Properties.Sorted = True
        Me.SearchDateFieldComboBox.Size = New System.Drawing.Size(160, 24)
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
        Me.lblSearchTitle.Location = New System.Drawing.Point(9, 6)
        Me.lblSearchTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblSearchTitle.Name = "lblSearchTitle"
        Me.lblSearchTitle.Size = New System.Drawing.Size(134, 25)
        Me.lblSearchTitle.TabIndex = 50
        Me.lblSearchTitle.Text = "Search by Date"
        '
        'cmdCloseSearchbyDate
        '
        Me.cmdCloseSearchbyDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCloseSearchbyDate.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseSearchbyDate.Appearance.Options.UseFont = True
        Me.cmdCloseSearchbyDate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdCloseSearchbyDate.Location = New System.Drawing.Point(289, 0)
        Me.cmdCloseSearchbyDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCloseSearchbyDate.Name = "cmdCloseSearchbyDate"
        Me.cmdCloseSearchbyDate.Size = New System.Drawing.Size(34, 34)
        Me.cmdCloseSearchbyDate.TabIndex = 49
        Me.cmdCloseSearchbyDate.Text = "X"
        '
        'StockIDLabel
        '
        Me.StockIDLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockIDLabel.Appearance.Options.UseFont = True
        Me.StockIDLabel.Location = New System.Drawing.Point(22, 41)
        Me.StockIDLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StockIDLabel.Name = "StockIDLabel"
        Me.StockIDLabel.Size = New System.Drawing.Size(172, 19)
        Me.StockIDLabel.TabIndex = 1
        Me.StockIDLabel.Text = "Stock ID (Auto Generated):"
        '
        'NameOfItemLabel
        '
        Me.NameOfItemLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameOfItemLabel.Appearance.Options.UseFont = True
        Me.NameOfItemLabel.Location = New System.Drawing.Point(22, 73)
        Me.NameOfItemLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NameOfItemLabel.Name = "NameOfItemLabel"
        Me.NameOfItemLabel.Size = New System.Drawing.Size(95, 19)
        Me.NameOfItemLabel.TabIndex = 1
        Me.NameOfItemLabel.Text = "Name Of Item:"
        '
        'ItemCategoryLabel
        '
        Me.ItemCategoryLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemCategoryLabel.Appearance.Options.UseFont = True
        Me.ItemCategoryLabel.Location = New System.Drawing.Point(22, 105)
        Me.ItemCategoryLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ItemCategoryLabel.Name = "ItemCategoryLabel"
        Me.ItemCategoryLabel.Size = New System.Drawing.Size(95, 19)
        Me.ItemCategoryLabel.TabIndex = 1
        Me.ItemCategoryLabel.Text = "Item Category:"
        '
        'RetailUnitPriceLabel
        '
        Me.RetailUnitPriceLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetailUnitPriceLabel.Appearance.Options.UseFont = True
        Me.RetailUnitPriceLabel.Location = New System.Drawing.Point(22, 72)
        Me.RetailUnitPriceLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RetailUnitPriceLabel.Name = "RetailUnitPriceLabel"
        Me.RetailUnitPriceLabel.Size = New System.Drawing.Size(109, 19)
        Me.RetailUnitPriceLabel.TabIndex = 1
        Me.RetailUnitPriceLabel.Text = "Retail Unit Price:"
        '
        'RetailUnitOfMeasurementLabel
        '
        Me.RetailUnitOfMeasurementLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetailUnitOfMeasurementLabel.Appearance.Options.UseFont = True
        Me.RetailUnitOfMeasurementLabel.Location = New System.Drawing.Point(22, 41)
        Me.RetailUnitOfMeasurementLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RetailUnitOfMeasurementLabel.Name = "RetailUnitOfMeasurementLabel"
        Me.RetailUnitOfMeasurementLabel.Size = New System.Drawing.Size(187, 19)
        Me.RetailUnitOfMeasurementLabel.TabIndex = 1
        Me.RetailUnitOfMeasurementLabel.Text = "Retail Unit Of Measurement:"
        '
        'RetailQuantityLabel
        '
        Me.RetailQuantityLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetailQuantityLabel.Appearance.Options.UseFont = True
        Me.RetailQuantityLabel.Location = New System.Drawing.Point(22, 105)
        Me.RetailQuantityLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RetailQuantityLabel.Name = "RetailQuantityLabel"
        Me.RetailQuantityLabel.Size = New System.Drawing.Size(102, 19)
        Me.RetailQuantityLabel.TabIndex = 1
        Me.RetailQuantityLabel.Text = "Retail Quantity:"
        '
        'RetailLowQuantityLabel
        '
        Me.RetailLowQuantityLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetailLowQuantityLabel.Appearance.Options.UseFont = True
        Me.RetailLowQuantityLabel.Location = New System.Drawing.Point(22, 137)
        Me.RetailLowQuantityLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RetailLowQuantityLabel.Name = "RetailLowQuantityLabel"
        Me.RetailLowQuantityLabel.Size = New System.Drawing.Size(173, 19)
        Me.RetailLowQuantityLabel.TabIndex = 1
        Me.RetailLowQuantityLabel.Text = "Retail Low Quantity (Alert)"
        '
        'WholesaleUnitPriceLabel
        '
        Me.WholesaleUnitPriceLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WholesaleUnitPriceLabel.Appearance.Options.UseFont = True
        Me.WholesaleUnitPriceLabel.Location = New System.Drawing.Point(22, 71)
        Me.WholesaleUnitPriceLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WholesaleUnitPriceLabel.Name = "WholesaleUnitPriceLabel"
        Me.WholesaleUnitPriceLabel.Size = New System.Drawing.Size(140, 19)
        Me.WholesaleUnitPriceLabel.TabIndex = 1
        Me.WholesaleUnitPriceLabel.Text = "Wholesale Unit Price:"
        '
        'WholesaleUnitOfMeasurementLabel
        '
        Me.WholesaleUnitOfMeasurementLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WholesaleUnitOfMeasurementLabel.Appearance.Options.UseFont = True
        Me.WholesaleUnitOfMeasurementLabel.Location = New System.Drawing.Point(22, 39)
        Me.WholesaleUnitOfMeasurementLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WholesaleUnitOfMeasurementLabel.Name = "WholesaleUnitOfMeasurementLabel"
        Me.WholesaleUnitOfMeasurementLabel.Size = New System.Drawing.Size(218, 19)
        Me.WholesaleUnitOfMeasurementLabel.TabIndex = 1
        Me.WholesaleUnitOfMeasurementLabel.Text = "Wholesale Unit Of Measurement:"
        '
        'WholesaleQuantityLabel
        '
        Me.WholesaleQuantityLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WholesaleQuantityLabel.Appearance.Options.UseFont = True
        Me.WholesaleQuantityLabel.Location = New System.Drawing.Point(22, 103)
        Me.WholesaleQuantityLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WholesaleQuantityLabel.Name = "WholesaleQuantityLabel"
        Me.WholesaleQuantityLabel.Size = New System.Drawing.Size(133, 19)
        Me.WholesaleQuantityLabel.TabIndex = 1
        Me.WholesaleQuantityLabel.Text = "Wholesale Quantity:"
        '
        'WholesaleLowQuantityLabel
        '
        Me.WholesaleLowQuantityLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WholesaleLowQuantityLabel.Appearance.Options.UseFont = True
        Me.WholesaleLowQuantityLabel.Location = New System.Drawing.Point(22, 135)
        Me.WholesaleLowQuantityLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WholesaleLowQuantityLabel.Name = "WholesaleLowQuantityLabel"
        Me.WholesaleLowQuantityLabel.Size = New System.Drawing.Size(208, 19)
        Me.WholesaleLowQuantityLabel.TabIndex = 1
        Me.WholesaleLowQuantityLabel.Text = "Wholesale Low Quantity (Alert):"
        '
        'CommentLabel
        '
        Me.CommentLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommentLabel.Appearance.Options.UseFont = True
        Me.CommentLabel.Location = New System.Drawing.Point(16, 108)
        Me.CommentLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CommentLabel.Name = "CommentLabel"
        Me.CommentLabel.Size = New System.Drawing.Size(66, 19)
        Me.CommentLabel.TabIndex = 1
        Me.CommentLabel.Text = "Comment:"
        '
        'RegDateLabel
        '
        Me.RegDateLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegDateLabel.Appearance.Options.UseFont = True
        Me.RegDateLabel.Location = New System.Drawing.Point(16, 41)
        Me.RegDateLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RegDateLabel.Name = "RegDateLabel"
        Me.RegDateLabel.Size = New System.Drawing.Size(64, 19)
        Me.RegDateLabel.TabIndex = 1
        Me.RegDateLabel.Text = "Reg Date:"
        '
        'InputedByLabel
        '
        Me.InputedByLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputedByLabel.Appearance.Options.UseFont = True
        Me.InputedByLabel.Location = New System.Drawing.Point(16, 75)
        Me.InputedByLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InputedByLabel.Name = "InputedByLabel"
        Me.InputedByLabel.Size = New System.Drawing.Size(73, 19)
        Me.InputedByLabel.TabIndex = 1
        Me.InputedByLabel.Text = "Inputed By:"
        '
        'StockIDDataGridViewTextBoxColumn
        '
        Me.StockIDDataGridViewTextBoxColumn.DataPropertyName = "StockID"
        Me.StockIDDataGridViewTextBoxColumn.HeaderText = "StockID"
        Me.StockIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StockIDDataGridViewTextBoxColumn.Name = "StockIDDataGridViewTextBoxColumn"
        Me.StockIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockIDDataGridViewTextBoxColumn.Width = 125
        '
        'NameOfItemDataGridViewTextBoxColumn
        '
        Me.NameOfItemDataGridViewTextBoxColumn.DataPropertyName = "NameOfItem"
        Me.NameOfItemDataGridViewTextBoxColumn.HeaderText = "NameOfItem"
        Me.NameOfItemDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameOfItemDataGridViewTextBoxColumn.Name = "NameOfItemDataGridViewTextBoxColumn"
        Me.NameOfItemDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameOfItemDataGridViewTextBoxColumn.Width = 125
        '
        'ItemCategoryDataGridViewTextBoxColumn
        '
        Me.ItemCategoryDataGridViewTextBoxColumn.DataPropertyName = "ItemCategory"
        Me.ItemCategoryDataGridViewTextBoxColumn.HeaderText = "ItemCategory"
        Me.ItemCategoryDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemCategoryDataGridViewTextBoxColumn.Name = "ItemCategoryDataGridViewTextBoxColumn"
        Me.ItemCategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemCategoryDataGridViewTextBoxColumn.Width = 125
        '
        'RetailUnitPriceDataGridViewTextBoxColumn
        '
        Me.RetailUnitPriceDataGridViewTextBoxColumn.DataPropertyName = "RetailUnitPrice"
        Me.RetailUnitPriceDataGridViewTextBoxColumn.HeaderText = "RetailUnitPrice"
        Me.RetailUnitPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RetailUnitPriceDataGridViewTextBoxColumn.Name = "RetailUnitPriceDataGridViewTextBoxColumn"
        Me.RetailUnitPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.RetailUnitPriceDataGridViewTextBoxColumn.Width = 125
        '
        'RetailUnitOfMeasurementDataGridViewTextBoxColumn
        '
        Me.RetailUnitOfMeasurementDataGridViewTextBoxColumn.DataPropertyName = "RetailUnitOfMeasurement"
        Me.RetailUnitOfMeasurementDataGridViewTextBoxColumn.HeaderText = "RetailUnitOfMeasurement"
        Me.RetailUnitOfMeasurementDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RetailUnitOfMeasurementDataGridViewTextBoxColumn.Name = "RetailUnitOfMeasurementDataGridViewTextBoxColumn"
        Me.RetailUnitOfMeasurementDataGridViewTextBoxColumn.ReadOnly = True
        Me.RetailUnitOfMeasurementDataGridViewTextBoxColumn.Width = 125
        '
        'RetailQuantityDataGridViewTextBoxColumn
        '
        Me.RetailQuantityDataGridViewTextBoxColumn.DataPropertyName = "RetailQuantity"
        Me.RetailQuantityDataGridViewTextBoxColumn.HeaderText = "RetailQuantity"
        Me.RetailQuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RetailQuantityDataGridViewTextBoxColumn.Name = "RetailQuantityDataGridViewTextBoxColumn"
        Me.RetailQuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.RetailQuantityDataGridViewTextBoxColumn.Width = 125
        '
        'RetailLowQuantityDataGridViewTextBoxColumn
        '
        Me.RetailLowQuantityDataGridViewTextBoxColumn.DataPropertyName = "RetailLowQuantity"
        Me.RetailLowQuantityDataGridViewTextBoxColumn.HeaderText = "RetailLowQuantity"
        Me.RetailLowQuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RetailLowQuantityDataGridViewTextBoxColumn.Name = "RetailLowQuantityDataGridViewTextBoxColumn"
        Me.RetailLowQuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.RetailLowQuantityDataGridViewTextBoxColumn.Width = 125
        '
        'WholesaleUnitPriceDataGridViewTextBoxColumn
        '
        Me.WholesaleUnitPriceDataGridViewTextBoxColumn.DataPropertyName = "WholesaleUnitPrice"
        Me.WholesaleUnitPriceDataGridViewTextBoxColumn.HeaderText = "WholesaleUnitPrice"
        Me.WholesaleUnitPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WholesaleUnitPriceDataGridViewTextBoxColumn.Name = "WholesaleUnitPriceDataGridViewTextBoxColumn"
        Me.WholesaleUnitPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.WholesaleUnitPriceDataGridViewTextBoxColumn.Width = 125
        '
        'WholesaleUnitOfMeasurementDataGridViewTextBoxColumn
        '
        Me.WholesaleUnitOfMeasurementDataGridViewTextBoxColumn.DataPropertyName = "WholesaleUnitOfMeasurement"
        Me.WholesaleUnitOfMeasurementDataGridViewTextBoxColumn.HeaderText = "WholesaleUnitOfMeasurement"
        Me.WholesaleUnitOfMeasurementDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WholesaleUnitOfMeasurementDataGridViewTextBoxColumn.Name = "WholesaleUnitOfMeasurementDataGridViewTextBoxColumn"
        Me.WholesaleUnitOfMeasurementDataGridViewTextBoxColumn.ReadOnly = True
        Me.WholesaleUnitOfMeasurementDataGridViewTextBoxColumn.Width = 125
        '
        'WholesaleQuantityDataGridViewTextBoxColumn
        '
        Me.WholesaleQuantityDataGridViewTextBoxColumn.DataPropertyName = "WholesaleQuantity"
        Me.WholesaleQuantityDataGridViewTextBoxColumn.HeaderText = "WholesaleQuantity"
        Me.WholesaleQuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WholesaleQuantityDataGridViewTextBoxColumn.Name = "WholesaleQuantityDataGridViewTextBoxColumn"
        Me.WholesaleQuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.WholesaleQuantityDataGridViewTextBoxColumn.Width = 125
        '
        'WholesaleLowQuantityDataGridViewTextBoxColumn
        '
        Me.WholesaleLowQuantityDataGridViewTextBoxColumn.DataPropertyName = "WholesaleLowQuantity"
        Me.WholesaleLowQuantityDataGridViewTextBoxColumn.HeaderText = "WholesaleLowQuantity"
        Me.WholesaleLowQuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WholesaleLowQuantityDataGridViewTextBoxColumn.Name = "WholesaleLowQuantityDataGridViewTextBoxColumn"
        Me.WholesaleLowQuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.WholesaleLowQuantityDataGridViewTextBoxColumn.Width = 125
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "Comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "Comment"
        Me.CommentDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        Me.CommentDataGridViewTextBoxColumn.ReadOnly = True
        Me.CommentDataGridViewTextBoxColumn.Width = 125
        '
        'RegDateDataGridViewTextBoxColumn
        '
        Me.RegDateDataGridViewTextBoxColumn.DataPropertyName = "RegDate"
        Me.RegDateDataGridViewTextBoxColumn.HeaderText = "RegDate"
        Me.RegDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RegDateDataGridViewTextBoxColumn.Name = "RegDateDataGridViewTextBoxColumn"
        Me.RegDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.RegDateDataGridViewTextBoxColumn.Width = 125
        '
        'InputedByDataGridViewTextBoxColumn
        '
        Me.InputedByDataGridViewTextBoxColumn.DataPropertyName = "InputedBy"
        Me.InputedByDataGridViewTextBoxColumn.HeaderText = "InputedBy"
        Me.InputedByDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InputedByDataGridViewTextBoxColumn.Name = "InputedByDataGridViewTextBoxColumn"
        Me.InputedByDataGridViewTextBoxColumn.ReadOnly = True
        Me.InputedByDataGridViewTextBoxColumn.Width = 125
        '
        'StockIDTextBox
        '
        Me.StockIDTextBox.EnterMoveNextControl = True
        Me.StockIDTextBox.Location = New System.Drawing.Point(200, 38)
        Me.StockIDTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StockIDTextBox.Name = "StockIDTextBox"
        Me.StockIDTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.StockIDTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.StockIDTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.StockIDTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.StockIDTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.StockIDTextBox.Properties.ReadOnly = True
        Me.StockIDTextBox.Size = New System.Drawing.Size(239, 24)
        Me.StockIDTextBox.TabIndex = 1
        '
        'NameOfItemTextBox
        '
        Me.NameOfItemTextBox.EnterMoveNextControl = True
        Me.NameOfItemTextBox.Location = New System.Drawing.Point(149, 70)
        Me.NameOfItemTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NameOfItemTextBox.Name = "NameOfItemTextBox"
        Me.NameOfItemTextBox.Properties.Appearance.BackColor = System.Drawing.Color.PeachPuff
        Me.NameOfItemTextBox.Properties.Appearance.Options.UseBackColor = True
        Me.NameOfItemTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.NameOfItemTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.NameOfItemTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.NameOfItemTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.NameOfItemTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.NameOfItemTextBox.Size = New System.Drawing.Size(290, 24)
        Me.NameOfItemTextBox.TabIndex = 1
        '
        'ItemCategoryGridBox
        '
        Me.ItemCategoryGridBox.Location = New System.Drawing.Point(149, 102)
        Me.ItemCategoryGridBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ItemCategoryGridBox.Name = "ItemCategoryGridBox"
        Me.ItemCategoryGridBox.Properties.Appearance.BackColor = System.Drawing.Color.PeachPuff
        Me.ItemCategoryGridBox.Properties.Appearance.Options.UseBackColor = True
        Me.ItemCategoryGridBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ItemCategoryGridBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemCategoryGridBox.Properties.NullText = ""
        Me.ItemCategoryGridBox.Size = New System.Drawing.Size(290, 24)
        Me.ItemCategoryGridBox.TabIndex = 1
        '
        'RetailUnitPriceTextBox
        '
        Me.RetailUnitPriceTextBox.EnterMoveNextControl = True
        Me.RetailUnitPriceTextBox.Location = New System.Drawing.Point(245, 66)
        Me.RetailUnitPriceTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RetailUnitPriceTextBox.Name = "RetailUnitPriceTextBox"
        Me.RetailUnitPriceTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RetailUnitPriceTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.RetailUnitPriceTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.RetailUnitPriceTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.RetailUnitPriceTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RetailUnitPriceTextBox.Properties.Mask.EditMask = "n"
        Me.RetailUnitPriceTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RetailUnitPriceTextBox.Size = New System.Drawing.Size(194, 24)
        Me.RetailUnitPriceTextBox.TabIndex = 1
        '
        'RetailUnitOfMeasurementGridBox
        '
        Me.RetailUnitOfMeasurementGridBox.Location = New System.Drawing.Point(245, 36)
        Me.RetailUnitOfMeasurementGridBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RetailUnitOfMeasurementGridBox.Name = "RetailUnitOfMeasurementGridBox"
        Me.RetailUnitOfMeasurementGridBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RetailUnitOfMeasurementGridBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RetailUnitOfMeasurementGridBox.Properties.NullText = ""
        Me.RetailUnitOfMeasurementGridBox.Size = New System.Drawing.Size(194, 24)
        Me.RetailUnitOfMeasurementGridBox.TabIndex = 1
        '
        'RetailQuantityTextBox
        '
        Me.RetailQuantityTextBox.EnterMoveNextControl = True
        Me.RetailQuantityTextBox.Location = New System.Drawing.Point(245, 100)
        Me.RetailQuantityTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RetailQuantityTextBox.Name = "RetailQuantityTextBox"
        Me.RetailQuantityTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RetailQuantityTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.RetailQuantityTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.RetailQuantityTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.RetailQuantityTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RetailQuantityTextBox.Properties.Mask.EditMask = "n0"
        Me.RetailQuantityTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RetailQuantityTextBox.Size = New System.Drawing.Size(194, 24)
        Me.RetailQuantityTextBox.TabIndex = 1
        '
        'RetailLowQuantityTextBox
        '
        Me.RetailLowQuantityTextBox.EnterMoveNextControl = True
        Me.RetailLowQuantityTextBox.Location = New System.Drawing.Point(245, 132)
        Me.RetailLowQuantityTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RetailLowQuantityTextBox.Name = "RetailLowQuantityTextBox"
        Me.RetailLowQuantityTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RetailLowQuantityTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.RetailLowQuantityTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.RetailLowQuantityTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.RetailLowQuantityTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RetailLowQuantityTextBox.Properties.Mask.EditMask = "n0"
        Me.RetailLowQuantityTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RetailLowQuantityTextBox.Size = New System.Drawing.Size(194, 24)
        Me.RetailLowQuantityTextBox.TabIndex = 1
        '
        'WholesaleUnitPriceTextBox
        '
        Me.WholesaleUnitPriceTextBox.EnterMoveNextControl = True
        Me.WholesaleUnitPriceTextBox.Location = New System.Drawing.Point(245, 68)
        Me.WholesaleUnitPriceTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WholesaleUnitPriceTextBox.Name = "WholesaleUnitPriceTextBox"
        Me.WholesaleUnitPriceTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.WholesaleUnitPriceTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.WholesaleUnitPriceTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.WholesaleUnitPriceTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.WholesaleUnitPriceTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.WholesaleUnitPriceTextBox.Properties.Mask.EditMask = "n"
        Me.WholesaleUnitPriceTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.WholesaleUnitPriceTextBox.Size = New System.Drawing.Size(194, 24)
        Me.WholesaleUnitPriceTextBox.TabIndex = 1
        '
        'WholesaleUnitOfMeasurementGridBox
        '
        Me.WholesaleUnitOfMeasurementGridBox.Location = New System.Drawing.Point(245, 37)
        Me.WholesaleUnitOfMeasurementGridBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WholesaleUnitOfMeasurementGridBox.Name = "WholesaleUnitOfMeasurementGridBox"
        Me.WholesaleUnitOfMeasurementGridBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.WholesaleUnitOfMeasurementGridBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WholesaleUnitOfMeasurementGridBox.Properties.NullText = ""
        Me.WholesaleUnitOfMeasurementGridBox.Size = New System.Drawing.Size(194, 24)
        Me.WholesaleUnitOfMeasurementGridBox.TabIndex = 1
        '
        'WholesaleQuantityTextBox
        '
        Me.WholesaleQuantityTextBox.EnterMoveNextControl = True
        Me.WholesaleQuantityTextBox.Location = New System.Drawing.Point(245, 100)
        Me.WholesaleQuantityTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WholesaleQuantityTextBox.Name = "WholesaleQuantityTextBox"
        Me.WholesaleQuantityTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.WholesaleQuantityTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.WholesaleQuantityTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.WholesaleQuantityTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.WholesaleQuantityTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.WholesaleQuantityTextBox.Properties.Mask.EditMask = "n0"
        Me.WholesaleQuantityTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.WholesaleQuantityTextBox.Size = New System.Drawing.Size(194, 24)
        Me.WholesaleQuantityTextBox.TabIndex = 1
        '
        'WholesaleLowQuantityTextBox
        '
        Me.WholesaleLowQuantityTextBox.EnterMoveNextControl = True
        Me.WholesaleLowQuantityTextBox.Location = New System.Drawing.Point(245, 132)
        Me.WholesaleLowQuantityTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WholesaleLowQuantityTextBox.Name = "WholesaleLowQuantityTextBox"
        Me.WholesaleLowQuantityTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.WholesaleLowQuantityTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.WholesaleLowQuantityTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.WholesaleLowQuantityTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.WholesaleLowQuantityTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.WholesaleLowQuantityTextBox.Properties.Mask.EditMask = "n0"
        Me.WholesaleLowQuantityTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.WholesaleLowQuantityTextBox.Size = New System.Drawing.Size(194, 24)
        Me.WholesaleLowQuantityTextBox.TabIndex = 1
        '
        'CommentTextBox
        '
        Me.CommentTextBox.EnterMoveNextControl = True
        Me.CommentTextBox.Location = New System.Drawing.Point(98, 103)
        Me.CommentTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.CommentTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.CommentTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.CommentTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.CommentTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CommentTextBox.Size = New System.Drawing.Size(344, 24)
        Me.CommentTextBox.TabIndex = 1
        '
        'RegDateTextBox
        '
        Me.RegDateTextBox.EnterMoveNextControl = True
        Me.RegDateTextBox.Location = New System.Drawing.Point(98, 36)
        Me.RegDateTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RegDateTextBox.Name = "RegDateTextBox"
        Me.RegDateTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RegDateTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.RegDateTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.RegDateTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.RegDateTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RegDateTextBox.Properties.ReadOnly = True
        Me.RegDateTextBox.Size = New System.Drawing.Size(344, 24)
        Me.RegDateTextBox.TabIndex = 1
        '
        'InputedByTextBox
        '
        Me.InputedByTextBox.EnterMoveNextControl = True
        Me.InputedByTextBox.Location = New System.Drawing.Point(98, 70)
        Me.InputedByTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InputedByTextBox.Name = "InputedByTextBox"
        Me.InputedByTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.InputedByTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.InputedByTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.InputedByTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.InputedByTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.InputedByTextBox.Size = New System.Drawing.Size(344, 24)
        Me.InputedByTextBox.TabIndex = 1
        '
        'XtraTabControlRelated
        '
        Me.XtraTabControlRelated.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControlRelated.Location = New System.Drawing.Point(504, 213)
        Me.XtraTabControlRelated.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabControlRelated.Name = "XtraTabControlRelated"
        Me.XtraTabControlRelated.SelectedTabPage = Me.XtraTabPageGeneralSalesItems
        Me.XtraTabControlRelated.Size = New System.Drawing.Size(477, 414)
        Me.XtraTabControlRelated.TabIndex = 56
        Me.XtraTabControlRelated.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPageGeneralSalesItems, Me.XtraTabPageTransferItems, Me.XtraTabPageStockReorder})
        '
        'XtraTabPageGeneralSalesItems
        '
        Me.XtraTabPageGeneralSalesItems.Controls.Add(Me.GeneralSalesItemsGridView)
        Me.XtraTabPageGeneralSalesItems.Controls.Add(Me.ToolStripGeneralSalesItems)
        Me.XtraTabPageGeneralSalesItems.ImageOptions.Image = CType(resources.GetObject("XtraTabPageGeneralSalesItems.ImageOptions.Image"), System.Drawing.Image)
        Me.XtraTabPageGeneralSalesItems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPageGeneralSalesItems.Name = "XtraTabPageGeneralSalesItems"
        Me.XtraTabPageGeneralSalesItems.Size = New System.Drawing.Size(470, 380)
        Me.XtraTabPageGeneralSalesItems.Text = "General Sales Items"
        '
        'GeneralSalesItemsGridView
        '
        Me.GeneralSalesItemsGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GeneralSalesItemsGridView.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GeneralSalesItemsGridView.Location = New System.Drawing.Point(0, 27)
        Me.GeneralSalesItemsGridView.MainView = Me.GridViewGeneralSalesItems
        Me.GeneralSalesItemsGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GeneralSalesItemsGridView.Name = "GeneralSalesItemsGridView"
        Me.GeneralSalesItemsGridView.Size = New System.Drawing.Size(470, 353)
        Me.GeneralSalesItemsGridView.TabIndex = 71
        Me.GeneralSalesItemsGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewGeneralSalesItems})
        '
        'GridViewGeneralSalesItems
        '
        Me.GridViewGeneralSalesItems.DetailHeight = 431
        Me.GridViewGeneralSalesItems.GridControl = Me.GeneralSalesItemsGridView
        Me.GridViewGeneralSalesItems.Name = "GridViewGeneralSalesItems"
        Me.GridViewGeneralSalesItems.OptionsBehavior.ReadOnly = True
        Me.GridViewGeneralSalesItems.OptionsFind.SearchInPreview = True
        Me.GridViewGeneralSalesItems.OptionsView.ColumnAutoWidth = False
        Me.GridViewGeneralSalesItems.OptionsView.ShowFooter = True
        '
        'ToolStripGeneralSalesItems
        '
        Me.ToolStripGeneralSalesItems.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripGeneralSalesItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddGeneralSalesItems, Me.cmdOpenRecordGeneralSalesItems, Me.cmdRemoveGeneralSalesItems, Me.cmdSearchGeneralSalesItems})
        Me.ToolStripGeneralSalesItems.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripGeneralSalesItems.Name = "ToolStripGeneralSalesItems"
        Me.ToolStripGeneralSalesItems.Size = New System.Drawing.Size(470, 27)
        Me.ToolStripGeneralSalesItems.TabIndex = 72
        '
        'cmdAddGeneralSalesItems
        '
        Me.cmdAddGeneralSalesItems.Image = Global.MoCTIMIS.My.Resources.Resources.add_16x16
        Me.cmdAddGeneralSalesItems.Name = "cmdAddGeneralSalesItems"
        Me.cmdAddGeneralSalesItems.Size = New System.Drawing.Size(95, 24)
        Me.cmdAddGeneralSalesItems.Text = "Add New"
        '
        'cmdOpenRecordGeneralSalesItems
        '
        Me.cmdOpenRecordGeneralSalesItems.Image = Global.MoCTIMIS.My.Resources.Resources.article_16x16
        Me.cmdOpenRecordGeneralSalesItems.Name = "cmdOpenRecordGeneralSalesItems"
        Me.cmdOpenRecordGeneralSalesItems.Size = New System.Drawing.Size(120, 24)
        Me.cmdOpenRecordGeneralSalesItems.Text = "Open Record"
        '
        'cmdRemoveGeneralSalesItems
        '
        Me.cmdRemoveGeneralSalesItems.Image = Global.MoCTIMIS.My.Resources.Resources.delete_16x16
        Me.cmdRemoveGeneralSalesItems.Name = "cmdRemoveGeneralSalesItems"
        Me.cmdRemoveGeneralSalesItems.Size = New System.Drawing.Size(77, 24)
        Me.cmdRemoveGeneralSalesItems.Text = "Delete"
        '
        'cmdSearchGeneralSalesItems
        '
        Me.cmdSearchGeneralSalesItems.Image = Global.MoCTIMIS.My.Resources.Resources.system_search_3
        Me.cmdSearchGeneralSalesItems.Name = "cmdSearchGeneralSalesItems"
        Me.cmdSearchGeneralSalesItems.Size = New System.Drawing.Size(77, 24)
        Me.cmdSearchGeneralSalesItems.Text = "Search"
        '
        'XtraTabPageTransferItems
        '
        Me.XtraTabPageTransferItems.Controls.Add(Me.TransferItemsGridView)
        Me.XtraTabPageTransferItems.Controls.Add(Me.ToolStripTransferItems)
        Me.XtraTabPageTransferItems.ImageOptions.Image = CType(resources.GetObject("XtraTabPageTransferItems.ImageOptions.Image"), System.Drawing.Image)
        Me.XtraTabPageTransferItems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPageTransferItems.Name = "XtraTabPageTransferItems"
        Me.XtraTabPageTransferItems.Size = New System.Drawing.Size(470, 380)
        Me.XtraTabPageTransferItems.Text = "Transfer Items"
        '
        'TransferItemsGridView
        '
        Me.TransferItemsGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransferItemsGridView.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferItemsGridView.Location = New System.Drawing.Point(0, 27)
        Me.TransferItemsGridView.MainView = Me.GridViewTransferItems
        Me.TransferItemsGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferItemsGridView.Name = "TransferItemsGridView"
        Me.TransferItemsGridView.Size = New System.Drawing.Size(470, 353)
        Me.TransferItemsGridView.TabIndex = 71
        Me.TransferItemsGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTransferItems})
        '
        'GridViewTransferItems
        '
        Me.GridViewTransferItems.DetailHeight = 431
        Me.GridViewTransferItems.GridControl = Me.TransferItemsGridView
        Me.GridViewTransferItems.Name = "GridViewTransferItems"
        Me.GridViewTransferItems.OptionsBehavior.ReadOnly = True
        Me.GridViewTransferItems.OptionsFind.SearchInPreview = True
        Me.GridViewTransferItems.OptionsView.ColumnAutoWidth = False
        Me.GridViewTransferItems.OptionsView.ShowFooter = True
        '
        'ToolStripTransferItems
        '
        Me.ToolStripTransferItems.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripTransferItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddTransferItems, Me.cmdOpenRecordTransferItems, Me.cmdRemoveTransferItems, Me.cmdSearchTransferItems})
        Me.ToolStripTransferItems.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripTransferItems.Name = "ToolStripTransferItems"
        Me.ToolStripTransferItems.Size = New System.Drawing.Size(470, 27)
        Me.ToolStripTransferItems.TabIndex = 72
        '
        'cmdAddTransferItems
        '
        Me.cmdAddTransferItems.Image = Global.MoCTIMIS.My.Resources.Resources.add_16x16
        Me.cmdAddTransferItems.Name = "cmdAddTransferItems"
        Me.cmdAddTransferItems.Size = New System.Drawing.Size(95, 24)
        Me.cmdAddTransferItems.Text = "Add New"
        '
        'cmdOpenRecordTransferItems
        '
        Me.cmdOpenRecordTransferItems.Image = Global.MoCTIMIS.My.Resources.Resources.article_16x16
        Me.cmdOpenRecordTransferItems.Name = "cmdOpenRecordTransferItems"
        Me.cmdOpenRecordTransferItems.Size = New System.Drawing.Size(120, 24)
        Me.cmdOpenRecordTransferItems.Text = "Open Record"
        '
        'cmdRemoveTransferItems
        '
        Me.cmdRemoveTransferItems.Image = Global.MoCTIMIS.My.Resources.Resources.delete_16x16
        Me.cmdRemoveTransferItems.Name = "cmdRemoveTransferItems"
        Me.cmdRemoveTransferItems.Size = New System.Drawing.Size(77, 24)
        Me.cmdRemoveTransferItems.Text = "Delete"
        '
        'cmdSearchTransferItems
        '
        Me.cmdSearchTransferItems.Image = Global.MoCTIMIS.My.Resources.Resources.system_search_3
        Me.cmdSearchTransferItems.Name = "cmdSearchTransferItems"
        Me.cmdSearchTransferItems.Size = New System.Drawing.Size(77, 24)
        Me.cmdSearchTransferItems.Text = "Search"
        '
        'XtraTabPageStockReorder
        '
        Me.XtraTabPageStockReorder.Controls.Add(Me.StockReorderGridView)
        Me.XtraTabPageStockReorder.Controls.Add(Me.ToolStripStockReorder)
        Me.XtraTabPageStockReorder.ImageOptions.Image = CType(resources.GetObject("XtraTabPageStockReorder.ImageOptions.Image"), System.Drawing.Image)
        Me.XtraTabPageStockReorder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPageStockReorder.Name = "XtraTabPageStockReorder"
        Me.XtraTabPageStockReorder.Size = New System.Drawing.Size(470, 380)
        Me.XtraTabPageStockReorder.Text = "Stock Reorder"
        '
        'StockReorderGridView
        '
        Me.StockReorderGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StockReorderGridView.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StockReorderGridView.Location = New System.Drawing.Point(0, 27)
        Me.StockReorderGridView.MainView = Me.GridViewStockReorder
        Me.StockReorderGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StockReorderGridView.Name = "StockReorderGridView"
        Me.StockReorderGridView.Size = New System.Drawing.Size(470, 353)
        Me.StockReorderGridView.TabIndex = 71
        Me.StockReorderGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewStockReorder})
        '
        'GridViewStockReorder
        '
        Me.GridViewStockReorder.DetailHeight = 431
        Me.GridViewStockReorder.GridControl = Me.StockReorderGridView
        Me.GridViewStockReorder.Name = "GridViewStockReorder"
        Me.GridViewStockReorder.OptionsBehavior.ReadOnly = True
        Me.GridViewStockReorder.OptionsFind.SearchInPreview = True
        Me.GridViewStockReorder.OptionsView.ColumnAutoWidth = False
        Me.GridViewStockReorder.OptionsView.ShowFooter = True
        '
        'ToolStripStockReorder
        '
        Me.ToolStripStockReorder.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripStockReorder.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddStockReorder, Me.cmdOpenRecordStockReorder, Me.cmdRemoveStockReorder, Me.cmdSearchStockReorder})
        Me.ToolStripStockReorder.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripStockReorder.Name = "ToolStripStockReorder"
        Me.ToolStripStockReorder.Size = New System.Drawing.Size(470, 27)
        Me.ToolStripStockReorder.TabIndex = 72
        '
        'cmdAddStockReorder
        '
        Me.cmdAddStockReorder.Image = Global.MoCTIMIS.My.Resources.Resources.add_16x16
        Me.cmdAddStockReorder.Name = "cmdAddStockReorder"
        Me.cmdAddStockReorder.Size = New System.Drawing.Size(95, 24)
        Me.cmdAddStockReorder.Text = "Add New"
        '
        'cmdOpenRecordStockReorder
        '
        Me.cmdOpenRecordStockReorder.Image = Global.MoCTIMIS.My.Resources.Resources.article_16x16
        Me.cmdOpenRecordStockReorder.Name = "cmdOpenRecordStockReorder"
        Me.cmdOpenRecordStockReorder.Size = New System.Drawing.Size(120, 24)
        Me.cmdOpenRecordStockReorder.Text = "Open Record"
        '
        'cmdRemoveStockReorder
        '
        Me.cmdRemoveStockReorder.Image = Global.MoCTIMIS.My.Resources.Resources.delete_16x16
        Me.cmdRemoveStockReorder.Name = "cmdRemoveStockReorder"
        Me.cmdRemoveStockReorder.Size = New System.Drawing.Size(77, 24)
        Me.cmdRemoveStockReorder.Text = "Delete"
        '
        'cmdSearchStockReorder
        '
        Me.cmdSearchStockReorder.Image = Global.MoCTIMIS.My.Resources.Resources.system_search_3
        Me.cmdSearchStockReorder.Name = "cmdSearchStockReorder"
        Me.cmdSearchStockReorder.Size = New System.Drawing.Size(77, 24)
        Me.cmdSearchStockReorder.Text = "Search"
        '
        'lblGeneralSalesItemsInfo
        '
        Me.lblGeneralSalesItemsInfo.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblGeneralSalesItemsInfo.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneralSalesItemsInfo.Appearance.ForeColor = System.Drawing.Color.Chocolate
        Me.lblGeneralSalesItemsInfo.Appearance.Options.UseBackColor = True
        Me.lblGeneralSalesItemsInfo.Appearance.Options.UseFont = True
        Me.lblGeneralSalesItemsInfo.Appearance.Options.UseForeColor = True
        Me.lblGeneralSalesItemsInfo.Location = New System.Drawing.Point(18, 14)
        Me.lblGeneralSalesItemsInfo.Name = "lblGeneralSalesItemsInfo"
        Me.lblGeneralSalesItemsInfo.Size = New System.Drawing.Size(95, 21)
        Me.lblGeneralSalesItemsInfo.TabIndex = 74
        Me.lblGeneralSalesItemsInfo.Text = "General Sales Items"
        '
        'lblTransferItemsInfo
        '
        Me.lblTransferItemsInfo.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblTransferItemsInfo.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransferItemsInfo.Appearance.ForeColor = System.Drawing.Color.Chocolate
        Me.lblTransferItemsInfo.Appearance.Options.UseBackColor = True
        Me.lblTransferItemsInfo.Appearance.Options.UseFont = True
        Me.lblTransferItemsInfo.Appearance.Options.UseForeColor = True
        Me.lblTransferItemsInfo.Location = New System.Drawing.Point(18, 14)
        Me.lblTransferItemsInfo.Name = "lblTransferItemsInfo"
        Me.lblTransferItemsInfo.Size = New System.Drawing.Size(95, 21)
        Me.lblTransferItemsInfo.TabIndex = 74
        Me.lblTransferItemsInfo.Text = "Transfer Items"
        '
        'lblStockReorderInfo
        '
        Me.lblStockReorderInfo.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblStockReorderInfo.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockReorderInfo.Appearance.ForeColor = System.Drawing.Color.Chocolate
        Me.lblStockReorderInfo.Appearance.Options.UseBackColor = True
        Me.lblStockReorderInfo.Appearance.Options.UseFont = True
        Me.lblStockReorderInfo.Appearance.Options.UseForeColor = True
        Me.lblStockReorderInfo.Location = New System.Drawing.Point(18, 14)
        Me.lblStockReorderInfo.Name = "lblStockReorderInfo"
        Me.lblStockReorderInfo.Size = New System.Drawing.Size(95, 21)
        Me.lblStockReorderInfo.TabIndex = 74
        Me.lblStockReorderInfo.Text = "Stock Reorder"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'SearchToolStripLabel
        '
        Me.SearchToolStripLabel.ForeColor = System.Drawing.Color.Black
        Me.SearchToolStripLabel.Name = "SearchToolStripLabel"
        Me.SearchToolStripLabel.Size = New System.Drawing.Size(56, 28)
        Me.SearchToolStripLabel.Text = "Search:"
        '
        'SearchToolStripComboBox
        '
        Me.SearchToolStripComboBox.Name = "SearchToolStripComboBox"
        Me.SearchToolStripComboBox.Size = New System.Drawing.Size(233, 31)
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.ForeColor = System.Drawing.Color.Black
        Me.SearchToolStripButton.Image = CType(resources.GetObject("SearchToolStripButton.Image"), System.Drawing.Image)
        Me.SearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(112, 28)
        Me.SearchToolStripButton.Text = "Start Search"
        '
        'GridView1
        '
        Me.GridView1.DetailHeight = 431
        Me.GridView1.GridControl = Me.InventoryDataGridView
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.SearchInPreview = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'InventoryDataGridView
        '
        Me.InventoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InventoryDataGridView.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InventoryDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.InventoryDataGridView.MainView = Me.GridView1
        Me.InventoryDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InventoryDataGridView.Name = "InventoryDataGridView"
        Me.InventoryDataGridView.Size = New System.Drawing.Size(913, 678)
        Me.InventoryDataGridView.TabIndex = 23
        Me.InventoryDataGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BottomStatusStrip
        '
        Me.BottomStatusStrip.BackColor = System.Drawing.Color.Transparent
        Me.BottomStatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BottomStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoofRecordsLabelToolStripStatusLabel, Me.NoofRecordsToolStripStatusLabel, Me.lblInformation})
        Me.BottomStatusStrip.Location = New System.Drawing.Point(2, 749)
        Me.BottomStatusStrip.Name = "BottomStatusStrip"
        Me.BottomStatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.BottomStatusStrip.Size = New System.Drawing.Size(1180, 26)
        Me.BottomStatusStrip.TabIndex = 89
        Me.BottomStatusStrip.Text = "StatusStrip1"
        '
        'NoofRecordsLabelToolStripStatusLabel
        '
        Me.NoofRecordsLabelToolStripStatusLabel.ForeColor = System.Drawing.Color.Black
        Me.NoofRecordsLabelToolStripStatusLabel.Name = "NoofRecordsLabelToolStripStatusLabel"
        Me.NoofRecordsLabelToolStripStatusLabel.Size = New System.Drawing.Size(111, 20)
        Me.NoofRecordsLabelToolStripStatusLabel.Text = "No of Records: "
        '
        'NoofRecordsToolStripStatusLabel
        '
        Me.NoofRecordsToolStripStatusLabel.ForeColor = System.Drawing.Color.Black
        Me.NoofRecordsToolStripStatusLabel.Name = "NoofRecordsToolStripStatusLabel"
        Me.NoofRecordsToolStripStatusLabel.Size = New System.Drawing.Size(17, 20)
        Me.NoofRecordsToolStripStatusLabel.Text = "0"
        '
        'lblInformation
        '
        Me.lblInformation.ForeColor = System.Drawing.Color.Black
        Me.lblInformation.Image = Global.MoCTIMIS.My.Resources.Resources.edit_paste_9
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(1035, 20)
        Me.lblInformation.Spring = True
        Me.lblInformation.Text = "Information"
        '
        'cmdClosePanelNew
        '
        Me.cmdClosePanelNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClosePanelNew.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClosePanelNew.Appearance.Options.UseFont = True
        Me.cmdClosePanelNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdClosePanelNew.Location = New System.Drawing.Point(961, 2)
        Me.cmdClosePanelNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdClosePanelNew.Name = "cmdClosePanelNew"
        Me.cmdClosePanelNew.Size = New System.Drawing.Size(34, 34)
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
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 4)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.TopMenuStrip.Size = New System.Drawing.Size(1184, 30)
        Me.TopMenuStrip.TabIndex = 85
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(139, 26)
        Me.LogoutToolStripMenuItem.Text = "&Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.PrintAllListedRecordsToolStripMenuItem, Me.SearchToolStripMenuItem, Me.SearchByDateToolStripMenuItem, Me.AdvancedSummaryToolStripMenuItem, Me.ImportWizardToolStripMenuItem, Me.ExportToExcellToolStripMenuItem})
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(58, 26)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.PrintToolStripMenuItem.Text = "Print Current Record"
        '
        'PrintAllListedRecordsToolStripMenuItem
        '
        Me.PrintAllListedRecordsToolStripMenuItem.Name = "PrintAllListedRecordsToolStripMenuItem"
        Me.PrintAllListedRecordsToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.PrintAllListedRecordsToolStripMenuItem.Text = "Print All Listed Records"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.SearchToolStripMenuItem.Text = "General Search"
        '
        'AdvancedSummaryToolStripMenuItem
        '
        Me.AdvancedSummaryToolStripMenuItem.Name = "AdvancedSummaryToolStripMenuItem"
        Me.AdvancedSummaryToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.AdvancedSummaryToolStripMenuItem.Text = "Advanced Summary"
        '
        'ImportWizardToolStripMenuItem
        '
        Me.ImportWizardToolStripMenuItem.Name = "ImportWizardToolStripMenuItem"
        Me.ImportWizardToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.ImportWizardToolStripMenuItem.Text = "Import Wizard"
        '
        'ExportToExcellToolStripMenuItem
        '
        Me.ExportToExcellToolStripMenuItem.Name = "ExportToExcellToolStripMenuItem"
        Me.ExportToExcellToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.ExportToExcellToolStripMenuItem.Text = "Export to Excel"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 26)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TopToolStrip
        '
        Me.TopToolStrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopToolStrip.AutoSize = False
        Me.TopToolStrip.BackColor = System.Drawing.Color.Transparent
        Me.TopToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.TopToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TopToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.DeleteToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.HelpToolStripButton, Me.ToolStripSeparator2, Me.SearchToolStripLabel, Me.SearchToolStripComboBox, Me.SearchToolStripButton, Me.cmdPrevious, Me.cmdNext})
        Me.TopToolStrip.Location = New System.Drawing.Point(0, 33)
        Me.TopToolStrip.Name = "TopToolStrip"
        Me.TopToolStrip.Size = New System.Drawing.Size(1185, 31)
        Me.TopToolStrip.TabIndex = 88
        Me.TopToolStrip.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(63, 28)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(69, 28)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(64, 28)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(29, 28)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'DeleteToolStripButton
        '
        Me.DeleteToolStripButton.Image = CType(resources.GetObject("DeleteToolStripButton.Image"), System.Drawing.Image)
        Me.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteToolStripButton.Name = "DeleteToolStripButton"
        Me.DeleteToolStripButton.Size = New System.Drawing.Size(77, 28)
        Me.DeleteToolStripButton.Text = "&Delete"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(29, 28)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(29, 28)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(29, 28)
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
        Me.PanelBody.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(1184, 777)
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
        Me.PanelNew.Controls.Add(Me.GroupControl4)
        Me.PanelNew.Controls.Add(Me.GroupControl3)
        Me.PanelNew.Controls.Add(Me.LabelControl1)
        Me.PanelNew.Controls.Add(Me.GroupControl2)
        Me.PanelNew.Controls.Add(Me.GroupControl1)
        Me.PanelNew.Controls.Add(Me.XtraTabControlRelated)
        Me.PanelNew.Controls.Add(Me.cmdClosePanelNew)
        Me.PanelNew.Controls.Add(Me.lblFormName)
        Me.PanelNew.Location = New System.Drawing.Point(73, 54)
        Me.PanelNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelNew.Name = "PanelNew"
        Me.PanelNew.Size = New System.Drawing.Size(997, 651)
        Me.PanelNew.TabIndex = 99
        Me.PanelNew.Visible = False
        '
        'GroupControl4
        '
        Me.GroupControl4.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl4.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl4.Controls.Add(Me.StockIDTextBox)
        Me.GroupControl4.Controls.Add(Me.NameOfItemTextBox)
        Me.GroupControl4.Controls.Add(Me.ItemCategoryGridBox)
        Me.GroupControl4.Controls.Add(Me.StockIDLabel)
        Me.GroupControl4.Controls.Add(Me.NameOfItemLabel)
        Me.GroupControl4.Controls.Add(Me.ItemCategoryLabel)
        Me.GroupControl4.Location = New System.Drawing.Point(31, 60)
        Me.GroupControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(461, 144)
        Me.GroupControl4.TabIndex = 60
        Me.GroupControl4.Text = "Detail of Inventory Item"
        '
        'GroupControl3
        '
        Me.GroupControl3.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl3.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl3.Controls.Add(Me.RetailUnitPriceTextBox)
        Me.GroupControl3.Controls.Add(Me.RetailUnitOfMeasurementGridBox)
        Me.GroupControl3.Controls.Add(Me.RetailQuantityTextBox)
        Me.GroupControl3.Controls.Add(Me.RetailLowQuantityTextBox)
        Me.GroupControl3.Controls.Add(Me.RetailUnitPriceLabel)
        Me.GroupControl3.Controls.Add(Me.RetailUnitOfMeasurementLabel)
        Me.GroupControl3.Controls.Add(Me.RetailQuantityLabel)
        Me.GroupControl3.Controls.Add(Me.RetailLowQuantityLabel)
        Me.GroupControl3.Location = New System.Drawing.Point(31, 210)
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(461, 169)
        Me.GroupControl3.TabIndex = 59
        Me.GroupControl3.Text = "RETAIL/SINGLE ITEM Section"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(31, 563)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(461, 62)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "The 'Price' can be in a form of GST or other incuring costs of MoCTI for the resp" &
    "ective item"
        '
        'GroupControl2
        '
        Me.GroupControl2.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl2.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl2.Controls.Add(Me.WholesaleUnitPriceTextBox)
        Me.GroupControl2.Controls.Add(Me.WholesaleUnitOfMeasurementGridBox)
        Me.GroupControl2.Controls.Add(Me.WholesaleQuantityTextBox)
        Me.GroupControl2.Controls.Add(Me.WholesaleLowQuantityTextBox)
        Me.GroupControl2.Controls.Add(Me.WholesaleUnitPriceLabel)
        Me.GroupControl2.Controls.Add(Me.WholesaleUnitOfMeasurementLabel)
        Me.GroupControl2.Controls.Add(Me.WholesaleQuantityLabel)
        Me.GroupControl2.Controls.Add(Me.WholesaleLowQuantityLabel)
        Me.GroupControl2.Location = New System.Drawing.Point(31, 384)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(461, 171)
        Me.GroupControl2.TabIndex = 58
        Me.GroupControl2.Text = "WHOLESALE/BULK ITEMS Section"
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl1.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.RegDateTextBox)
        Me.GroupControl1.Controls.Add(Me.InputedByTextBox)
        Me.GroupControl1.Controls.Add(Me.RegDateLabel)
        Me.GroupControl1.Controls.Add(Me.InputedByLabel)
        Me.GroupControl1.Controls.Add(Me.CommentTextBox)
        Me.GroupControl1.Controls.Add(Me.CommentLabel)
        Me.GroupControl1.Location = New System.Drawing.Point(504, 60)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(471, 145)
        Me.GroupControl1.TabIndex = 57
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
        Me.lblFormName.Location = New System.Drawing.Point(31, 21)
        Me.lblFormName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(109, 34)
        Me.lblFormName.TabIndex = 1
        Me.lblFormName.Text = "Inventory"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Location = New System.Drawing.Point(3, 60)
        Me.SplitContainerControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.InventoryDataGridView)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.VGridControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1177, 678)
        Me.SplitContainerControl1.SplitterPosition = 258
        Me.SplitContainerControl1.TabIndex = 91
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'VGridControl1
        '
        Me.VGridControl1.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VGridControl1.Appearance.RecordValue.Options.UseFont = True
        Me.VGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.VGridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.OptionsView.MinRowAutoHeight = 12
        Me.VGridControl1.RecordWidth = 117
        Me.VGridControl1.RowHeaderWidth = 117
        Me.VGridControl1.Size = New System.Drawing.Size(258, 678)
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
        Me.PanelExporting.Location = New System.Drawing.Point(381, 305)
        Me.PanelExporting.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelExporting.Name = "PanelExporting"
        Me.PanelExporting.Size = New System.Drawing.Size(344, 165)
        Me.PanelExporting.TabIndex = 87
        Me.PanelExporting.Visible = False
        '
        'PanelProgressbarContainer
        '
        Me.PanelProgressbarContainer.Controls.Add(Me.PanelProgressbar)
        Me.PanelProgressbarContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelProgressbarContainer.Location = New System.Drawing.Point(2, 152)
        Me.PanelProgressbarContainer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelProgressbarContainer.Name = "PanelProgressbarContainer"
        Me.PanelProgressbarContainer.Size = New System.Drawing.Size(340, 11)
        Me.PanelProgressbarContainer.TabIndex = 59
        '
        'PanelProgressbar
        '
        Me.PanelProgressbar.Appearance.BackColor = System.Drawing.Color.LimeGreen
        Me.PanelProgressbar.Appearance.Options.UseBackColor = True
        Me.PanelProgressbar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelProgressbar.Location = New System.Drawing.Point(2, 2)
        Me.PanelProgressbar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelProgressbar.Name = "PanelProgressbar"
        Me.PanelProgressbar.Size = New System.Drawing.Size(12, 7)
        Me.PanelProgressbar.TabIndex = 0
        '
        'cmdCloseExport
        '
        Me.cmdCloseExport.Appearance.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseExport.Appearance.Options.UseFont = True
        Me.cmdCloseExport.Location = New System.Drawing.Point(309, -1)
        Me.cmdCloseExport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCloseExport.Name = "cmdCloseExport"
        Me.cmdCloseExport.Size = New System.Drawing.Size(34, 34)
        Me.cmdCloseExport.TabIndex = 47
        Me.cmdCloseExport.Text = "X"
        '
        'lblExportPercentage
        '
        Me.lblExportPercentage.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExportPercentage.Appearance.Options.UseFont = True
        Me.lblExportPercentage.Location = New System.Drawing.Point(217, 123)
        Me.lblExportPercentage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblExportPercentage.Name = "lblExportPercentage"
        Me.lblExportPercentage.Size = New System.Drawing.Size(82, 18)
        Me.lblExportPercentage.TabIndex = 57
        Me.lblExportPercentage.Text = "0% Complete"
        '
        'lblNoRows
        '
        Me.lblNoRows.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRows.Appearance.Options.UseFont = True
        Me.lblNoRows.Location = New System.Drawing.Point(10, 100)
        Me.lblNoRows.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblNoRows.Name = "lblNoRows"
        Me.lblNoRows.Size = New System.Drawing.Size(101, 18)
        Me.lblNoRows.TabIndex = 57
        Me.lblNoRows.Text = "Records: 12/51"
        '
        'lblNoValues
        '
        Me.lblNoValues.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoValues.Appearance.Options.UseFont = True
        Me.lblNoValues.Location = New System.Drawing.Point(10, 122)
        Me.lblNoValues.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblNoValues.Name = "lblNoValues"
        Me.lblNoValues.Size = New System.Drawing.Size(88, 18)
        Me.lblNoValues.TabIndex = 57
        Me.lblNoValues.Text = "Values: 12/51"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MoCTIMIS.My.Resources.Resources.edit_paste_9
        Me.PictureBox2.Location = New System.Drawing.Point(253, 37)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(83, 76)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'lblExportStatus
        '
        Me.lblExportStatus.Appearance.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExportStatus.Appearance.Options.UseFont = True
        Me.lblExportStatus.Location = New System.Drawing.Point(56, 39)
        Me.lblExportStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblExportStatus.Name = "lblExportStatus"
        Me.lblExportStatus.Size = New System.Drawing.Size(117, 25)
        Me.lblExportStatus.TabIndex = 57
        Me.lblExportStatus.Text = "Please Wait..."
        '
        'Label26
        '
        Me.Label26.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Appearance.Options.UseFont = True
        Me.Label26.Location = New System.Drawing.Point(9, 10)
        Me.Label26.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(164, 25)
        Me.Label26.TabIndex = 57
        Me.Label26.Text = "Exporting to Excell"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 777)
        Me.Controls.Add(Me.PanelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Inventory"
        CType(Me.PanelSearchByDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSearchByDate.ResumeLayout(False)
        Me.PanelSearchByDate.PerformLayout()
        CType(Me.EndDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchDateFieldComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockIDTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameOfItemTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemCategoryGridBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetailUnitPriceTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetailUnitOfMeasurementGridBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetailQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetailLowQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WholesaleUnitPriceTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WholesaleUnitOfMeasurementGridBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WholesaleQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WholesaleLowQuantityTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegDateTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputedByTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControlRelated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControlRelated.ResumeLayout(False)
        Me.XtraTabPageGeneralSalesItems.ResumeLayout(False)
        Me.XtraTabPageGeneralSalesItems.PerformLayout()
        CType(Me.GeneralSalesItemsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewGeneralSalesItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripGeneralSalesItems.ResumeLayout(False)
        Me.ToolStripGeneralSalesItems.PerformLayout()
        Me.XtraTabPageTransferItems.ResumeLayout(False)
        Me.XtraTabPageTransferItems.PerformLayout()
        CType(Me.TransferItemsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTransferItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripTransferItems.ResumeLayout(False)
        Me.ToolStripTransferItems.PerformLayout()
        Me.XtraTabPageStockReorder.ResumeLayout(False)
        Me.XtraTabPageStockReorder.PerformLayout()
        CType(Me.StockReorderGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewStockReorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripStockReorder.ResumeLayout(False)
        Me.ToolStripStockReorder.PerformLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents StockIDTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NameOfItemTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemCategoryGridBox As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents RetailUnitPriceTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RetailUnitOfMeasurementGridBox As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents RetailQuantityTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RetailLowQuantityTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WholesaleUnitPriceTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WholesaleUnitOfMeasurementGridBox As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents WholesaleQuantityTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WholesaleLowQuantityTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CommentTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RegDateTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents InputedByTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StockIDLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NameOfItemLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ItemCategoryLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RetailUnitPriceLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RetailUnitOfMeasurementLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RetailQuantityLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RetailLowQuantityLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents WholesaleUnitPriceLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents WholesaleUnitOfMeasurementLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents WholesaleQuantityLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents WholesaleLowQuantityLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CommentLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RegDateLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents InputedByLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents StockIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameOfItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemCategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetailUnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetailUnitOfMeasurementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetailQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetailLowQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WholesaleUnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WholesaleUnitOfMeasurementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WholesaleQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WholesaleLowQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents InventoryDataGridView As DevExpress.XtraGrid.GridControl
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
    Friend WithEvents XtraTabControlRelated As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents ToolStripGeneralSalesItems As System.Windows.Forms.ToolStrip
    Friend WithEvents XtraTabPageGeneralSalesItems As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblGeneralSalesItemsInfo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdOpenRecordGeneralSalesItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAddGeneralSalesItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRemoveGeneralSalesItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSearchGeneralSalesItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents GeneralSalesItemsGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewGeneralSalesItems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolStripTransferItems As System.Windows.Forms.ToolStrip
    Friend WithEvents XtraTabPageTransferItems As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblTransferItemsInfo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdOpenRecordTransferItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAddTransferItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRemoveTransferItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSearchTransferItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents TransferItemsGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTransferItems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolStripStockReorder As System.Windows.Forms.ToolStrip
        Friend WithEvents XtraTabPageStockReorder As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents lblStockReorderInfo As DevExpress.XtraEditors.LabelControl
        Friend WithEvents cmdOpenRecordStockReorder As System.Windows.Forms.ToolStripButton
        Friend WithEvents cmdAddStockReorder As System.Windows.Forms.ToolStripButton
        Friend WithEvents cmdRemoveStockReorder As System.Windows.Forms.ToolStripButton
        Friend WithEvents cmdSearchStockReorder As System.Windows.Forms.ToolStripButton
        Friend WithEvents StockReorderGridView As DevExpress.XtraGrid.GridControl
       Friend WithEvents GridViewStockReorder As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
