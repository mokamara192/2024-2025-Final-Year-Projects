<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransfers
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransfers))
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
        Me.GeneratedTransferNoLabel = New DevExpress.XtraEditors.LabelControl()
        Me.OutgoneTransferLabel = New DevExpress.XtraEditors.LabelControl()
        Me.TransferNoLabel = New DevExpress.XtraEditors.LabelControl()
        Me.TransferTypeLabel = New DevExpress.XtraEditors.LabelControl()
        Me.TransferDateLabel = New DevExpress.XtraEditors.LabelControl()
        Me.OfficeTypeLabel = New DevExpress.XtraEditors.LabelControl()
        Me.TotalAmountLabel = New DevExpress.XtraEditors.LabelControl()
        Me.TransferStatusLabel = New DevExpress.XtraEditors.LabelControl()
        Me.CommentLabel = New DevExpress.XtraEditors.LabelControl()
        Me.SupervisionLabel = New DevExpress.XtraEditors.LabelControl()
        Me.DocumentCompletionLabel = New DevExpress.XtraEditors.LabelControl()
        Me.RegDateLabel = New DevExpress.XtraEditors.LabelControl()
        Me.InputtedByLabel = New DevExpress.XtraEditors.LabelControl()
        Me.CurrencyLabel = New DevExpress.XtraEditors.LabelControl()
        Me.ExchangeRateLabel = New DevExpress.XtraEditors.LabelControl()
        Me.BankAccountIDLabel = New DevExpress.XtraEditors.LabelControl()
        Me.GeneratedTransferNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutgoneTransferDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransferNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransferTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransferDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OfficeTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransferStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupervisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentCompletionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputtedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExchangeRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankAccountIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneratedTransferNoTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.OutgoneTransferCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.TransferNoTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.TransferDateDateTimePicker = New DevExpress.XtraEditors.DateEdit()
        Me.TotalAmountTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.CommentTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.DocumentCompletionTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.RegDateTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.InputtedByTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.CurrencyGridBox = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ExchangeRateTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.BankAccountIDGridBox = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.XtraTabControlRelated = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPageTransferOfficeLink = New DevExpress.XtraTab.XtraTabPage()
        Me.TransferOfficeLinkGridView = New DevExpress.XtraGrid.GridControl()
        Me.GridViewTransferOfficeLink = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolStripTransferOfficeLink = New System.Windows.Forms.ToolStrip()
        Me.cmdAddTransferOfficeLink = New System.Windows.Forms.ToolStripButton()
        Me.cmdOpenRecordTransferOfficeLink = New System.Windows.Forms.ToolStripButton()
        Me.cmdRemoveTransferOfficeLink = New System.Windows.Forms.ToolStripButton()
        Me.cmdSearchTransferOfficeLink = New System.Windows.Forms.ToolStripButton()
        Me.XtraTabPageTransferItems = New DevExpress.XtraTab.XtraTabPage()
        Me.TransferItemsGridView = New DevExpress.XtraGrid.GridControl()
        Me.GridViewTransferItems = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolStripTransferItems = New System.Windows.Forms.ToolStrip()
        Me.cmdAddTransferItems = New System.Windows.Forms.ToolStripButton()
        Me.cmdOpenRecordTransferItems = New System.Windows.Forms.ToolStripButton()
        Me.cmdRemoveTransferItems = New System.Windows.Forms.ToolStripButton()
        Me.cmdSearchTransferItems = New System.Windows.Forms.ToolStripButton()
        Me.XtraTabPageTransferPayments = New DevExpress.XtraTab.XtraTabPage()
        Me.TransferPaymentsGridView = New DevExpress.XtraGrid.GridControl()
        Me.GridViewTransferPayments = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolStripTransferPayments = New System.Windows.Forms.ToolStrip()
        Me.cmdAddTransferPayments = New System.Windows.Forms.ToolStripButton()
        Me.cmdOpenRecordTransferPayments = New System.Windows.Forms.ToolStripButton()
        Me.cmdRemoveTransferPayments = New System.Windows.Forms.ToolStripButton()
        Me.cmdSearchTransferPayments = New System.Windows.Forms.ToolStripButton()
        Me.XtraTabPageTransferFilesData = New DevExpress.XtraTab.XtraTabPage()
        Me.TransferFilesDataGridView = New DevExpress.XtraGrid.GridControl()
        Me.GridViewTransferFilesData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolStripTransferFilesData = New System.Windows.Forms.ToolStrip()
        Me.cmdAddTransferFilesData = New System.Windows.Forms.ToolStripButton()
        Me.cmdOpenRecordTransferFilesData = New System.Windows.Forms.ToolStripButton()
        Me.cmdOpenTransferFilesData = New System.Windows.Forms.ToolStripButton()
        Me.cmdDownloadTransferFilesData = New System.Windows.Forms.ToolStripButton()
        Me.cmdExploreAllTransferFilesData = New System.Windows.Forms.ToolStripButton()
        Me.cmdRemoveTransferFilesData = New System.Windows.Forms.ToolStripButton()
        Me.cmdSearchTransferFilesData = New System.Windows.Forms.ToolStripButton()
        Me.lblTransferOfficeLinkInfo = New DevExpress.XtraEditors.LabelControl()
        Me.lblTransferFilesDataInfo = New DevExpress.XtraEditors.LabelControl()
        Me.lblTransferItemsInfo = New DevExpress.XtraEditors.LabelControl()
        Me.lblTransferPaymentsInfo = New DevExpress.XtraEditors.LabelControl()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SearchToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TransfersDataGridView = New DevExpress.XtraGrid.GridControl()
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
        Me.PrintTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.cmdPostCheckButton = New DevExpress.XtraEditors.CheckButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.OfficeTypeTextBox = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TransferTypeTextBox = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TransferStatusTextBox = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SupervisionTextBox = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.cmdPrintStatement = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdMakePayment = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.radHDusemanualdate = New System.Windows.Forms.RadioButton()
        Me.radHDusesystemdate = New System.Windows.Forms.RadioButton()
        Me.cmdPrintHardcopyTransfer = New DevExpress.XtraEditors.SimpleButton()
        Me.lblFormName = New DevExpress.XtraEditors.LabelControl()
        Me.PanelOfficestatement = New System.Windows.Forms.Panel()
        Me.OfficeIDGridBox = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdPrintOfficestatement = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCloseOfficestatement = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelTransferTemplate = New System.Windows.Forms.Panel()
        Me.radManualDate = New System.Windows.Forms.RadioButton()
        Me.radSystemDate = New System.Windows.Forms.RadioButton()
        Me.TemplateTransferTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.numCustPrintCount = New DevExpress.XtraEditors.SpinEdit()
        Me.cmdPrintOfficeDocument = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdClosePanelCustAgreements = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
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
        CType(Me.GeneratedTransferNoTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutgoneTransferCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferNoTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferDateDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferDateDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalAmountTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentCompletionTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegDateTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputtedByTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyGridBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExchangeRateTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankAccountIDGridBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControlRelated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControlRelated.SuspendLayout()
        Me.XtraTabPageTransferOfficeLink.SuspendLayout()
        CType(Me.TransferOfficeLinkGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTransferOfficeLink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripTransferOfficeLink.SuspendLayout()
        Me.XtraTabPageTransferItems.SuspendLayout()
        CType(Me.TransferItemsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTransferItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripTransferItems.SuspendLayout()
        Me.XtraTabPageTransferPayments.SuspendLayout()
        CType(Me.TransferPaymentsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTransferPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripTransferPayments.SuspendLayout()
        Me.XtraTabPageTransferFilesData.SuspendLayout()
        CType(Me.TransferFilesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTransferFilesData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripTransferFilesData.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransfersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomStatusStrip.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.TopToolStrip.SuspendLayout()
        CType(Me.PanelBody, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBody.SuspendLayout()
        CType(Me.PanelNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNew.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.OfficeTypeTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferTypeTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferStatusTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupervisionTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.PanelOfficestatement.SuspendLayout()
        CType(Me.OfficeIDGridBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTransferTemplate.SuspendLayout()
        CType(Me.numCustPrintCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GeneratedTransferNoLabel
        '
        Me.GeneratedTransferNoLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneratedTransferNoLabel.Appearance.Options.UseFont = True
        Me.GeneratedTransferNoLabel.Location = New System.Drawing.Point(20, 39)
        Me.GeneratedTransferNoLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GeneratedTransferNoLabel.Name = "GeneratedTransferNoLabel"
        Me.GeneratedTransferNoLabel.Size = New System.Drawing.Size(152, 19)
        Me.GeneratedTransferNoLabel.TabIndex = 1
        Me.GeneratedTransferNoLabel.Text = "Generated Transfer No:"
        '
        'OutgoneTransferLabel
        '
        Me.OutgoneTransferLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutgoneTransferLabel.Appearance.Options.UseFont = True
        Me.OutgoneTransferLabel.Location = New System.Drawing.Point(20, 71)
        Me.OutgoneTransferLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OutgoneTransferLabel.Name = "OutgoneTransferLabel"
        Me.OutgoneTransferLabel.Size = New System.Drawing.Size(118, 19)
        Me.OutgoneTransferLabel.TabIndex = 1
        Me.OutgoneTransferLabel.Text = "Outgone Transfer:"
        '
        'TransferNoLabel
        '
        Me.TransferNoLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransferNoLabel.Appearance.Options.UseFont = True
        Me.TransferNoLabel.Location = New System.Drawing.Point(20, 103)
        Me.TransferNoLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferNoLabel.Name = "TransferNoLabel"
        Me.TransferNoLabel.Size = New System.Drawing.Size(80, 19)
        Me.TransferNoLabel.TabIndex = 1
        Me.TransferNoLabel.Text = "Transfer No:"
        '
        'TransferTypeLabel
        '
        Me.TransferTypeLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransferTypeLabel.Appearance.Options.UseFont = True
        Me.TransferTypeLabel.Location = New System.Drawing.Point(20, 135)
        Me.TransferTypeLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferTypeLabel.Name = "TransferTypeLabel"
        Me.TransferTypeLabel.Size = New System.Drawing.Size(93, 19)
        Me.TransferTypeLabel.TabIndex = 1
        Me.TransferTypeLabel.Text = "Transfer Type:"
        '
        'TransferDateLabel
        '
        Me.TransferDateLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransferDateLabel.Appearance.Options.UseFont = True
        Me.TransferDateLabel.Location = New System.Drawing.Point(20, 167)
        Me.TransferDateLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferDateLabel.Name = "TransferDateLabel"
        Me.TransferDateLabel.Size = New System.Drawing.Size(93, 19)
        Me.TransferDateLabel.TabIndex = 1
        Me.TransferDateLabel.Text = "Transfer Date:"
        '
        'OfficeTypeLabel
        '
        Me.OfficeTypeLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfficeTypeLabel.Appearance.Options.UseFont = True
        Me.OfficeTypeLabel.Location = New System.Drawing.Point(20, 199)
        Me.OfficeTypeLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OfficeTypeLabel.Name = "OfficeTypeLabel"
        Me.OfficeTypeLabel.Size = New System.Drawing.Size(79, 19)
        Me.OfficeTypeLabel.TabIndex = 1
        Me.OfficeTypeLabel.Text = "Office Type:"
        '
        'TotalAmountLabel
        '
        Me.TotalAmountLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmountLabel.Appearance.Options.UseFont = True
        Me.TotalAmountLabel.Location = New System.Drawing.Point(20, 231)
        Me.TotalAmountLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TotalAmountLabel.Name = "TotalAmountLabel"
        Me.TotalAmountLabel.Size = New System.Drawing.Size(91, 19)
        Me.TotalAmountLabel.TabIndex = 1
        Me.TotalAmountLabel.Text = "Total Amount:"
        '
        'TransferStatusLabel
        '
        Me.TransferStatusLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransferStatusLabel.Appearance.Options.UseFont = True
        Me.TransferStatusLabel.Location = New System.Drawing.Point(20, 362)
        Me.TransferStatusLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferStatusLabel.Name = "TransferStatusLabel"
        Me.TransferStatusLabel.Size = New System.Drawing.Size(102, 19)
        Me.TransferStatusLabel.TabIndex = 1
        Me.TransferStatusLabel.Text = "Transfer Status:"
        '
        'CommentLabel
        '
        Me.CommentLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommentLabel.Appearance.Options.UseFont = True
        Me.CommentLabel.Location = New System.Drawing.Point(20, 396)
        Me.CommentLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CommentLabel.Name = "CommentLabel"
        Me.CommentLabel.Size = New System.Drawing.Size(66, 19)
        Me.CommentLabel.TabIndex = 1
        Me.CommentLabel.Text = "Comment:"
        '
        'SupervisionLabel
        '
        Me.SupervisionLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupervisionLabel.Appearance.Options.UseFont = True
        Me.SupervisionLabel.Location = New System.Drawing.Point(20, 428)
        Me.SupervisionLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SupervisionLabel.Name = "SupervisionLabel"
        Me.SupervisionLabel.Size = New System.Drawing.Size(78, 19)
        Me.SupervisionLabel.TabIndex = 1
        Me.SupervisionLabel.Text = "Supervision:"
        '
        'DocumentCompletionLabel
        '
        Me.DocumentCompletionLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentCompletionLabel.Appearance.Options.UseFont = True
        Me.DocumentCompletionLabel.Location = New System.Drawing.Point(20, 460)
        Me.DocumentCompletionLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DocumentCompletionLabel.Name = "DocumentCompletionLabel"
        Me.DocumentCompletionLabel.Size = New System.Drawing.Size(148, 19)
        Me.DocumentCompletionLabel.TabIndex = 1
        Me.DocumentCompletionLabel.Text = "Document Completion:"
        '
        'RegDateLabel
        '
        Me.RegDateLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegDateLabel.Appearance.Options.UseFont = True
        Me.RegDateLabel.Location = New System.Drawing.Point(20, 41)
        Me.RegDateLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RegDateLabel.Name = "RegDateLabel"
        Me.RegDateLabel.Size = New System.Drawing.Size(64, 19)
        Me.RegDateLabel.TabIndex = 1
        Me.RegDateLabel.Text = "Reg Date:"
        '
        'InputtedByLabel
        '
        Me.InputtedByLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputtedByLabel.Appearance.Options.UseFont = True
        Me.InputtedByLabel.Location = New System.Drawing.Point(20, 73)
        Me.InputtedByLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InputtedByLabel.Name = "InputtedByLabel"
        Me.InputtedByLabel.Size = New System.Drawing.Size(78, 19)
        Me.InputtedByLabel.TabIndex = 1
        Me.InputtedByLabel.Text = "Inputted By:"
        '
        'CurrencyLabel
        '
        Me.CurrencyLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrencyLabel.Appearance.Options.UseFont = True
        Me.CurrencyLabel.Location = New System.Drawing.Point(20, 265)
        Me.CurrencyLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CurrencyLabel.Name = "CurrencyLabel"
        Me.CurrencyLabel.Size = New System.Drawing.Size(61, 19)
        Me.CurrencyLabel.TabIndex = 1
        Me.CurrencyLabel.Text = "Currency:"
        '
        'ExchangeRateLabel
        '
        Me.ExchangeRateLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExchangeRateLabel.Appearance.Options.UseFont = True
        Me.ExchangeRateLabel.Location = New System.Drawing.Point(20, 297)
        Me.ExchangeRateLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ExchangeRateLabel.Name = "ExchangeRateLabel"
        Me.ExchangeRateLabel.Size = New System.Drawing.Size(100, 19)
        Me.ExchangeRateLabel.TabIndex = 1
        Me.ExchangeRateLabel.Text = "Exchange Rate:"
        '
        'BankAccountIDLabel
        '
        Me.BankAccountIDLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BankAccountIDLabel.Appearance.Options.UseFont = True
        Me.BankAccountIDLabel.Location = New System.Drawing.Point(20, 329)
        Me.BankAccountIDLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BankAccountIDLabel.Name = "BankAccountIDLabel"
        Me.BankAccountIDLabel.Size = New System.Drawing.Size(110, 19)
        Me.BankAccountIDLabel.TabIndex = 1
        Me.BankAccountIDLabel.Text = "Bank Account ID:"
        '
        'GeneratedTransferNoDataGridViewTextBoxColumn
        '
        Me.GeneratedTransferNoDataGridViewTextBoxColumn.DataPropertyName = "GeneratedTransferNo"
        Me.GeneratedTransferNoDataGridViewTextBoxColumn.HeaderText = "GeneratedTransferNo"
        Me.GeneratedTransferNoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GeneratedTransferNoDataGridViewTextBoxColumn.Name = "GeneratedTransferNoDataGridViewTextBoxColumn"
        Me.GeneratedTransferNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.GeneratedTransferNoDataGridViewTextBoxColumn.Width = 125
        '
        'OutgoneTransferDataGridViewTextBoxColumn
        '
        Me.OutgoneTransferDataGridViewTextBoxColumn.DataPropertyName = "OutgoneTransfer"
        Me.OutgoneTransferDataGridViewTextBoxColumn.HeaderText = "OutgoneTransfer"
        Me.OutgoneTransferDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OutgoneTransferDataGridViewTextBoxColumn.Name = "OutgoneTransferDataGridViewTextBoxColumn"
        Me.OutgoneTransferDataGridViewTextBoxColumn.ReadOnly = True
        Me.OutgoneTransferDataGridViewTextBoxColumn.Width = 125
        '
        'TransferNoDataGridViewTextBoxColumn
        '
        Me.TransferNoDataGridViewTextBoxColumn.DataPropertyName = "TransferNo"
        Me.TransferNoDataGridViewTextBoxColumn.HeaderText = "TransferNo"
        Me.TransferNoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TransferNoDataGridViewTextBoxColumn.Name = "TransferNoDataGridViewTextBoxColumn"
        Me.TransferNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransferNoDataGridViewTextBoxColumn.Width = 125
        '
        'TransferTypeDataGridViewTextBoxColumn
        '
        Me.TransferTypeDataGridViewTextBoxColumn.DataPropertyName = "TransferType"
        Me.TransferTypeDataGridViewTextBoxColumn.HeaderText = "TransferType"
        Me.TransferTypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TransferTypeDataGridViewTextBoxColumn.Name = "TransferTypeDataGridViewTextBoxColumn"
        Me.TransferTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransferTypeDataGridViewTextBoxColumn.Width = 125
        '
        'TransferDateDataGridViewTextBoxColumn
        '
        Me.TransferDateDataGridViewTextBoxColumn.DataPropertyName = "TransferDate"
        Me.TransferDateDataGridViewTextBoxColumn.HeaderText = "TransferDate"
        Me.TransferDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TransferDateDataGridViewTextBoxColumn.Name = "TransferDateDataGridViewTextBoxColumn"
        Me.TransferDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransferDateDataGridViewTextBoxColumn.Width = 125
        '
        'OfficeTypeDataGridViewTextBoxColumn
        '
        Me.OfficeTypeDataGridViewTextBoxColumn.DataPropertyName = "OfficeType"
        Me.OfficeTypeDataGridViewTextBoxColumn.HeaderText = "OfficeType"
        Me.OfficeTypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OfficeTypeDataGridViewTextBoxColumn.Name = "OfficeTypeDataGridViewTextBoxColumn"
        Me.OfficeTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.OfficeTypeDataGridViewTextBoxColumn.Width = 125
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalAmountDataGridViewTextBoxColumn.Width = 125
        '
        'TransferStatusDataGridViewTextBoxColumn
        '
        Me.TransferStatusDataGridViewTextBoxColumn.DataPropertyName = "TransferStatus"
        Me.TransferStatusDataGridViewTextBoxColumn.HeaderText = "TransferStatus"
        Me.TransferStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TransferStatusDataGridViewTextBoxColumn.Name = "TransferStatusDataGridViewTextBoxColumn"
        Me.TransferStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransferStatusDataGridViewTextBoxColumn.Width = 125
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
        'SupervisionDataGridViewTextBoxColumn
        '
        Me.SupervisionDataGridViewTextBoxColumn.DataPropertyName = "Supervision"
        Me.SupervisionDataGridViewTextBoxColumn.HeaderText = "Supervision"
        Me.SupervisionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SupervisionDataGridViewTextBoxColumn.Name = "SupervisionDataGridViewTextBoxColumn"
        Me.SupervisionDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupervisionDataGridViewTextBoxColumn.Width = 125
        '
        'DocumentCompletionDataGridViewTextBoxColumn
        '
        Me.DocumentCompletionDataGridViewTextBoxColumn.DataPropertyName = "DocumentCompletion"
        Me.DocumentCompletionDataGridViewTextBoxColumn.HeaderText = "DocumentCompletion"
        Me.DocumentCompletionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DocumentCompletionDataGridViewTextBoxColumn.Name = "DocumentCompletionDataGridViewTextBoxColumn"
        Me.DocumentCompletionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocumentCompletionDataGridViewTextBoxColumn.Width = 125
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
        'InputtedByDataGridViewTextBoxColumn
        '
        Me.InputtedByDataGridViewTextBoxColumn.DataPropertyName = "InputtedBy"
        Me.InputtedByDataGridViewTextBoxColumn.HeaderText = "InputtedBy"
        Me.InputtedByDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InputtedByDataGridViewTextBoxColumn.Name = "InputtedByDataGridViewTextBoxColumn"
        Me.InputtedByDataGridViewTextBoxColumn.ReadOnly = True
        Me.InputtedByDataGridViewTextBoxColumn.Width = 125
        '
        'CurrencyDataGridViewTextBoxColumn
        '
        Me.CurrencyDataGridViewTextBoxColumn.DataPropertyName = "Currency"
        Me.CurrencyDataGridViewTextBoxColumn.HeaderText = "Currency"
        Me.CurrencyDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CurrencyDataGridViewTextBoxColumn.Name = "CurrencyDataGridViewTextBoxColumn"
        Me.CurrencyDataGridViewTextBoxColumn.ReadOnly = True
        Me.CurrencyDataGridViewTextBoxColumn.Width = 125
        '
        'ExchangeRateDataGridViewTextBoxColumn
        '
        Me.ExchangeRateDataGridViewTextBoxColumn.DataPropertyName = "ExchangeRate"
        Me.ExchangeRateDataGridViewTextBoxColumn.HeaderText = "ExchangeRate"
        Me.ExchangeRateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExchangeRateDataGridViewTextBoxColumn.Name = "ExchangeRateDataGridViewTextBoxColumn"
        Me.ExchangeRateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExchangeRateDataGridViewTextBoxColumn.Width = 125
        '
        'BankAccountIDDataGridViewTextBoxColumn
        '
        Me.BankAccountIDDataGridViewTextBoxColumn.DataPropertyName = "BankAccountID"
        Me.BankAccountIDDataGridViewTextBoxColumn.HeaderText = "BankAccountID"
        Me.BankAccountIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BankAccountIDDataGridViewTextBoxColumn.Name = "BankAccountIDDataGridViewTextBoxColumn"
        Me.BankAccountIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.BankAccountIDDataGridViewTextBoxColumn.Width = 125
        '
        'GeneratedTransferNoTextBox
        '
        Me.GeneratedTransferNoTextBox.EnterMoveNextControl = True
        Me.GeneratedTransferNoTextBox.Location = New System.Drawing.Point(173, 37)
        Me.GeneratedTransferNoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GeneratedTransferNoTextBox.Name = "GeneratedTransferNoTextBox"
        Me.GeneratedTransferNoTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.GeneratedTransferNoTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.GeneratedTransferNoTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.GeneratedTransferNoTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.GeneratedTransferNoTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.GeneratedTransferNoTextBox.Properties.ReadOnly = True
        Me.GeneratedTransferNoTextBox.Size = New System.Drawing.Size(194, 24)
        Me.GeneratedTransferNoTextBox.TabIndex = 1
        '
        'OutgoneTransferCheckEdit
        '
        Me.OutgoneTransferCheckEdit.Location = New System.Drawing.Point(173, 69)
        Me.OutgoneTransferCheckEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OutgoneTransferCheckEdit.Name = "OutgoneTransferCheckEdit"
        Me.OutgoneTransferCheckEdit.Properties.Caption = "Outgone Transfer"
        Me.OutgoneTransferCheckEdit.Size = New System.Drawing.Size(194, 20)
        Me.OutgoneTransferCheckEdit.TabIndex = 1
        '
        'TransferNoTextBox
        '
        Me.TransferNoTextBox.EnterMoveNextControl = True
        Me.TransferNoTextBox.Location = New System.Drawing.Point(173, 101)
        Me.TransferNoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferNoTextBox.Name = "TransferNoTextBox"
        Me.TransferNoTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.TransferNoTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.TransferNoTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.TransferNoTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TransferNoTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TransferNoTextBox.Size = New System.Drawing.Size(194, 24)
        Me.TransferNoTextBox.TabIndex = 1
        '
        'TransferDateDateTimePicker
        '
        Me.TransferDateDateTimePicker.EditValue = Nothing
        Me.TransferDateDateTimePicker.Location = New System.Drawing.Point(173, 165)
        Me.TransferDateDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferDateDateTimePicker.Name = "TransferDateDateTimePicker"
        Me.TransferDateDateTimePicker.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TransferDateDateTimePicker.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TransferDateDateTimePicker.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TransferDateDateTimePicker.Properties.Mask.BeepOnError = True
        Me.TransferDateDateTimePicker.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.TransferDateDateTimePicker.Size = New System.Drawing.Size(194, 24)
        Me.TransferDateDateTimePicker.TabIndex = 1
        '
        'TotalAmountTextBox
        '
        Me.TotalAmountTextBox.EnterMoveNextControl = True
        Me.TotalAmountTextBox.Location = New System.Drawing.Point(173, 229)
        Me.TotalAmountTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TotalAmountTextBox.Name = "TotalAmountTextBox"
        Me.TotalAmountTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.TotalAmountTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.TotalAmountTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.TotalAmountTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TotalAmountTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TotalAmountTextBox.Properties.ReadOnly = True
        Me.TotalAmountTextBox.Size = New System.Drawing.Size(194, 24)
        Me.TotalAmountTextBox.TabIndex = 1
        '
        'CommentTextBox
        '
        Me.CommentTextBox.EnterMoveNextControl = True
        Me.CommentTextBox.Location = New System.Drawing.Point(173, 394)
        Me.CommentTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.CommentTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.CommentTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.CommentTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.CommentTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CommentTextBox.Size = New System.Drawing.Size(194, 24)
        Me.CommentTextBox.TabIndex = 1
        '
        'DocumentCompletionTextBox
        '
        Me.DocumentCompletionTextBox.EnterMoveNextControl = True
        Me.DocumentCompletionTextBox.Location = New System.Drawing.Point(173, 458)
        Me.DocumentCompletionTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DocumentCompletionTextBox.Name = "DocumentCompletionTextBox"
        Me.DocumentCompletionTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.DocumentCompletionTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.DocumentCompletionTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.DocumentCompletionTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.DocumentCompletionTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DocumentCompletionTextBox.Properties.ReadOnly = True
        Me.DocumentCompletionTextBox.Size = New System.Drawing.Size(194, 24)
        Me.DocumentCompletionTextBox.TabIndex = 1
        '
        'RegDateTextBox
        '
        Me.RegDateTextBox.EnterMoveNextControl = True
        Me.RegDateTextBox.Location = New System.Drawing.Point(103, 36)
        Me.RegDateTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RegDateTextBox.Name = "RegDateTextBox"
        Me.RegDateTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RegDateTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.RegDateTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.RegDateTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.RegDateTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RegDateTextBox.Properties.ReadOnly = True
        Me.RegDateTextBox.Size = New System.Drawing.Size(194, 24)
        Me.RegDateTextBox.TabIndex = 1
        '
        'InputtedByTextBox
        '
        Me.InputtedByTextBox.EnterMoveNextControl = True
        Me.InputtedByTextBox.Location = New System.Drawing.Point(103, 68)
        Me.InputtedByTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InputtedByTextBox.Name = "InputtedByTextBox"
        Me.InputtedByTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.InputtedByTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.InputtedByTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.InputtedByTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.InputtedByTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.InputtedByTextBox.Properties.ReadOnly = True
        Me.InputtedByTextBox.Size = New System.Drawing.Size(194, 24)
        Me.InputtedByTextBox.TabIndex = 1
        '
        'CurrencyGridBox
        '
        Me.CurrencyGridBox.Location = New System.Drawing.Point(173, 262)
        Me.CurrencyGridBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CurrencyGridBox.Name = "CurrencyGridBox"
        Me.CurrencyGridBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CurrencyGridBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CurrencyGridBox.Properties.NullText = ""
        Me.CurrencyGridBox.Size = New System.Drawing.Size(194, 24)
        Me.CurrencyGridBox.TabIndex = 1
        '
        'ExchangeRateTextBox
        '
        Me.ExchangeRateTextBox.EnterMoveNextControl = True
        Me.ExchangeRateTextBox.Location = New System.Drawing.Point(173, 294)
        Me.ExchangeRateTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ExchangeRateTextBox.Name = "ExchangeRateTextBox"
        Me.ExchangeRateTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.ExchangeRateTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.ExchangeRateTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.ExchangeRateTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.ExchangeRateTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ExchangeRateTextBox.Properties.ReadOnly = True
        Me.ExchangeRateTextBox.Size = New System.Drawing.Size(194, 24)
        Me.ExchangeRateTextBox.TabIndex = 1
        '
        'BankAccountIDGridBox
        '
        Me.BankAccountIDGridBox.Location = New System.Drawing.Point(173, 326)
        Me.BankAccountIDGridBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BankAccountIDGridBox.Name = "BankAccountIDGridBox"
        Me.BankAccountIDGridBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BankAccountIDGridBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BankAccountIDGridBox.Properties.NullText = ""
        Me.BankAccountIDGridBox.Size = New System.Drawing.Size(194, 24)
        Me.BankAccountIDGridBox.TabIndex = 1
        '
        'XtraTabControlRelated
        '
        Me.XtraTabControlRelated.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControlRelated.Location = New System.Drawing.Point(408, 298)
        Me.XtraTabControlRelated.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabControlRelated.Name = "XtraTabControlRelated"
        Me.XtraTabControlRelated.SelectedTabPage = Me.XtraTabPageTransferOfficeLink
        Me.XtraTabControlRelated.Size = New System.Drawing.Size(563, 337)
        Me.XtraTabControlRelated.TabIndex = 56
        Me.XtraTabControlRelated.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPageTransferOfficeLink, Me.XtraTabPageTransferItems, Me.XtraTabPageTransferPayments, Me.XtraTabPageTransferFilesData})
        '
        'XtraTabPageTransferOfficeLink
        '
        Me.XtraTabPageTransferOfficeLink.Controls.Add(Me.TransferOfficeLinkGridView)
        Me.XtraTabPageTransferOfficeLink.Controls.Add(Me.ToolStripTransferOfficeLink)
        Me.XtraTabPageTransferOfficeLink.ImageOptions.Image = CType(resources.GetObject("XtraTabPageTransferOfficeLink.ImageOptions.Image"), System.Drawing.Image)
        Me.XtraTabPageTransferOfficeLink.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPageTransferOfficeLink.Name = "XtraTabPageTransferOfficeLink"
        Me.XtraTabPageTransferOfficeLink.Size = New System.Drawing.Size(556, 303)
        Me.XtraTabPageTransferOfficeLink.Text = "Transfer Office Link"
        '
        'TransferOfficeLinkGridView
        '
        Me.TransferOfficeLinkGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransferOfficeLinkGridView.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferOfficeLinkGridView.Location = New System.Drawing.Point(0, 27)
        Me.TransferOfficeLinkGridView.MainView = Me.GridViewTransferOfficeLink
        Me.TransferOfficeLinkGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferOfficeLinkGridView.Name = "TransferOfficeLinkGridView"
        Me.TransferOfficeLinkGridView.Size = New System.Drawing.Size(556, 276)
        Me.TransferOfficeLinkGridView.TabIndex = 71
        Me.TransferOfficeLinkGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTransferOfficeLink})
        '
        'GridViewTransferOfficeLink
        '
        Me.GridViewTransferOfficeLink.DetailHeight = 431
        Me.GridViewTransferOfficeLink.GridControl = Me.TransferOfficeLinkGridView
        Me.GridViewTransferOfficeLink.Name = "GridViewTransferOfficeLink"
        Me.GridViewTransferOfficeLink.OptionsBehavior.ReadOnly = True
        Me.GridViewTransferOfficeLink.OptionsFind.SearchInPreview = True
        Me.GridViewTransferOfficeLink.OptionsView.ColumnAutoWidth = False
        Me.GridViewTransferOfficeLink.OptionsView.ShowFooter = True
        '
        'ToolStripTransferOfficeLink
        '
        Me.ToolStripTransferOfficeLink.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripTransferOfficeLink.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddTransferOfficeLink, Me.cmdOpenRecordTransferOfficeLink, Me.cmdRemoveTransferOfficeLink, Me.cmdSearchTransferOfficeLink})
        Me.ToolStripTransferOfficeLink.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripTransferOfficeLink.Name = "ToolStripTransferOfficeLink"
        Me.ToolStripTransferOfficeLink.Size = New System.Drawing.Size(556, 27)
        Me.ToolStripTransferOfficeLink.TabIndex = 72
        '
        'cmdAddTransferOfficeLink
        '
        Me.cmdAddTransferOfficeLink.Image = Global.MoCTIMIS.My.Resources.Resources.add_16x16
        Me.cmdAddTransferOfficeLink.Name = "cmdAddTransferOfficeLink"
        Me.cmdAddTransferOfficeLink.Size = New System.Drawing.Size(95, 24)
        Me.cmdAddTransferOfficeLink.Text = "Add New"
        '
        'cmdOpenRecordTransferOfficeLink
        '
        Me.cmdOpenRecordTransferOfficeLink.Image = Global.MoCTIMIS.My.Resources.Resources.article_16x16
        Me.cmdOpenRecordTransferOfficeLink.Name = "cmdOpenRecordTransferOfficeLink"
        Me.cmdOpenRecordTransferOfficeLink.Size = New System.Drawing.Size(120, 24)
        Me.cmdOpenRecordTransferOfficeLink.Text = "Open Record"
        '
        'cmdRemoveTransferOfficeLink
        '
        Me.cmdRemoveTransferOfficeLink.Image = Global.MoCTIMIS.My.Resources.Resources.delete_16x16
        Me.cmdRemoveTransferOfficeLink.Name = "cmdRemoveTransferOfficeLink"
        Me.cmdRemoveTransferOfficeLink.Size = New System.Drawing.Size(77, 24)
        Me.cmdRemoveTransferOfficeLink.Text = "Delete"
        '
        'cmdSearchTransferOfficeLink
        '
        Me.cmdSearchTransferOfficeLink.Image = Global.MoCTIMIS.My.Resources.Resources.system_search_3
        Me.cmdSearchTransferOfficeLink.Name = "cmdSearchTransferOfficeLink"
        Me.cmdSearchTransferOfficeLink.Size = New System.Drawing.Size(77, 24)
        Me.cmdSearchTransferOfficeLink.Text = "Search"
        '
        'XtraTabPageTransferItems
        '
        Me.XtraTabPageTransferItems.Controls.Add(Me.TransferItemsGridView)
        Me.XtraTabPageTransferItems.Controls.Add(Me.ToolStripTransferItems)
        Me.XtraTabPageTransferItems.ImageOptions.Image = CType(resources.GetObject("XtraTabPageTransferItems.ImageOptions.Image"), System.Drawing.Image)
        Me.XtraTabPageTransferItems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPageTransferItems.Name = "XtraTabPageTransferItems"
        Me.XtraTabPageTransferItems.Size = New System.Drawing.Size(556, 303)
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
        Me.TransferItemsGridView.Size = New System.Drawing.Size(556, 276)
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
        Me.ToolStripTransferItems.Size = New System.Drawing.Size(556, 27)
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
        'XtraTabPageTransferPayments
        '
        Me.XtraTabPageTransferPayments.Controls.Add(Me.TransferPaymentsGridView)
        Me.XtraTabPageTransferPayments.Controls.Add(Me.ToolStripTransferPayments)
        Me.XtraTabPageTransferPayments.ImageOptions.Image = CType(resources.GetObject("XtraTabPageTransferPayments.ImageOptions.Image"), System.Drawing.Image)
        Me.XtraTabPageTransferPayments.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPageTransferPayments.Name = "XtraTabPageTransferPayments"
        Me.XtraTabPageTransferPayments.Size = New System.Drawing.Size(556, 303)
        Me.XtraTabPageTransferPayments.Text = "Transfer Payments"
        '
        'TransferPaymentsGridView
        '
        Me.TransferPaymentsGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransferPaymentsGridView.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferPaymentsGridView.Location = New System.Drawing.Point(0, 27)
        Me.TransferPaymentsGridView.MainView = Me.GridViewTransferPayments
        Me.TransferPaymentsGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferPaymentsGridView.Name = "TransferPaymentsGridView"
        Me.TransferPaymentsGridView.Size = New System.Drawing.Size(556, 276)
        Me.TransferPaymentsGridView.TabIndex = 71
        Me.TransferPaymentsGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTransferPayments})
        '
        'GridViewTransferPayments
        '
        Me.GridViewTransferPayments.DetailHeight = 431
        Me.GridViewTransferPayments.GridControl = Me.TransferPaymentsGridView
        Me.GridViewTransferPayments.Name = "GridViewTransferPayments"
        Me.GridViewTransferPayments.OptionsBehavior.ReadOnly = True
        Me.GridViewTransferPayments.OptionsFind.SearchInPreview = True
        Me.GridViewTransferPayments.OptionsView.ColumnAutoWidth = False
        Me.GridViewTransferPayments.OptionsView.ShowFooter = True
        '
        'ToolStripTransferPayments
        '
        Me.ToolStripTransferPayments.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripTransferPayments.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddTransferPayments, Me.cmdOpenRecordTransferPayments, Me.cmdRemoveTransferPayments, Me.cmdSearchTransferPayments})
        Me.ToolStripTransferPayments.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripTransferPayments.Name = "ToolStripTransferPayments"
        Me.ToolStripTransferPayments.Size = New System.Drawing.Size(556, 27)
        Me.ToolStripTransferPayments.TabIndex = 72
        '
        'cmdAddTransferPayments
        '
        Me.cmdAddTransferPayments.Image = Global.MoCTIMIS.My.Resources.Resources.add_16x16
        Me.cmdAddTransferPayments.Name = "cmdAddTransferPayments"
        Me.cmdAddTransferPayments.Size = New System.Drawing.Size(95, 24)
        Me.cmdAddTransferPayments.Text = "Add New"
        '
        'cmdOpenRecordTransferPayments
        '
        Me.cmdOpenRecordTransferPayments.Image = Global.MoCTIMIS.My.Resources.Resources.article_16x16
        Me.cmdOpenRecordTransferPayments.Name = "cmdOpenRecordTransferPayments"
        Me.cmdOpenRecordTransferPayments.Size = New System.Drawing.Size(120, 24)
        Me.cmdOpenRecordTransferPayments.Text = "Open Record"
        '
        'cmdRemoveTransferPayments
        '
        Me.cmdRemoveTransferPayments.Image = Global.MoCTIMIS.My.Resources.Resources.delete_16x16
        Me.cmdRemoveTransferPayments.Name = "cmdRemoveTransferPayments"
        Me.cmdRemoveTransferPayments.Size = New System.Drawing.Size(77, 24)
        Me.cmdRemoveTransferPayments.Text = "Delete"
        '
        'cmdSearchTransferPayments
        '
        Me.cmdSearchTransferPayments.Image = Global.MoCTIMIS.My.Resources.Resources.system_search_3
        Me.cmdSearchTransferPayments.Name = "cmdSearchTransferPayments"
        Me.cmdSearchTransferPayments.Size = New System.Drawing.Size(77, 24)
        Me.cmdSearchTransferPayments.Text = "Search"
        '
        'XtraTabPageTransferFilesData
        '
        Me.XtraTabPageTransferFilesData.Controls.Add(Me.TransferFilesDataGridView)
        Me.XtraTabPageTransferFilesData.Controls.Add(Me.ToolStripTransferFilesData)
        Me.XtraTabPageTransferFilesData.ImageOptions.Image = CType(resources.GetObject("XtraTabPageTransferFilesData.ImageOptions.Image"), System.Drawing.Image)
        Me.XtraTabPageTransferFilesData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPageTransferFilesData.Name = "XtraTabPageTransferFilesData"
        Me.XtraTabPageTransferFilesData.Size = New System.Drawing.Size(556, 303)
        Me.XtraTabPageTransferFilesData.Text = "Transfer Files Data"
        '
        'TransferFilesDataGridView
        '
        Me.TransferFilesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransferFilesDataGridView.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferFilesDataGridView.Location = New System.Drawing.Point(0, 27)
        Me.TransferFilesDataGridView.MainView = Me.GridViewTransferFilesData
        Me.TransferFilesDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferFilesDataGridView.Name = "TransferFilesDataGridView"
        Me.TransferFilesDataGridView.Size = New System.Drawing.Size(556, 276)
        Me.TransferFilesDataGridView.TabIndex = 71
        Me.TransferFilesDataGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTransferFilesData})
        '
        'GridViewTransferFilesData
        '
        Me.GridViewTransferFilesData.DetailHeight = 431
        Me.GridViewTransferFilesData.GridControl = Me.TransferFilesDataGridView
        Me.GridViewTransferFilesData.Name = "GridViewTransferFilesData"
        Me.GridViewTransferFilesData.OptionsBehavior.ReadOnly = True
        Me.GridViewTransferFilesData.OptionsFind.SearchInPreview = True
        Me.GridViewTransferFilesData.OptionsView.ColumnAutoWidth = False
        Me.GridViewTransferFilesData.OptionsView.ShowFooter = True
        '
        'ToolStripTransferFilesData
        '
        Me.ToolStripTransferFilesData.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripTransferFilesData.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddTransferFilesData, Me.cmdOpenRecordTransferFilesData, Me.cmdOpenTransferFilesData, Me.cmdDownloadTransferFilesData, Me.cmdExploreAllTransferFilesData, Me.cmdRemoveTransferFilesData, Me.cmdSearchTransferFilesData})
        Me.ToolStripTransferFilesData.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripTransferFilesData.Name = "ToolStripTransferFilesData"
        Me.ToolStripTransferFilesData.Size = New System.Drawing.Size(556, 27)
        Me.ToolStripTransferFilesData.TabIndex = 72
        '
        'cmdAddTransferFilesData
        '
        Me.cmdAddTransferFilesData.Image = Global.MoCTIMIS.My.Resources.Resources.add_16x16
        Me.cmdAddTransferFilesData.Name = "cmdAddTransferFilesData"
        Me.cmdAddTransferFilesData.Size = New System.Drawing.Size(95, 24)
        Me.cmdAddTransferFilesData.Text = "Add New"
        '
        'cmdOpenRecordTransferFilesData
        '
        Me.cmdOpenRecordTransferFilesData.Image = Global.MoCTIMIS.My.Resources.Resources.article_16x16
        Me.cmdOpenRecordTransferFilesData.Name = "cmdOpenRecordTransferFilesData"
        Me.cmdOpenRecordTransferFilesData.Size = New System.Drawing.Size(120, 24)
        Me.cmdOpenRecordTransferFilesData.Text = "Open Record"
        '
        'cmdOpenTransferFilesData
        '
        Me.cmdOpenTransferFilesData.Image = CType(resources.GetObject("cmdOpenTransferFilesData.Image"), System.Drawing.Image)
        Me.cmdOpenTransferFilesData.Name = "cmdOpenTransferFilesData"
        Me.cmdOpenTransferFilesData.Size = New System.Drawing.Size(96, 24)
        Me.cmdOpenTransferFilesData.Text = "Open File"
        '
        'cmdDownloadTransferFilesData
        '
        Me.cmdDownloadTransferFilesData.Image = CType(resources.GetObject("cmdDownloadTransferFilesData.Image"), System.Drawing.Image)
        Me.cmdDownloadTransferFilesData.Name = "cmdDownloadTransferFilesData"
        Me.cmdDownloadTransferFilesData.Size = New System.Drawing.Size(102, 24)
        Me.cmdDownloadTransferFilesData.Text = "Download"
        '
        'cmdExploreAllTransferFilesData
        '
        Me.cmdExploreAllTransferFilesData.Image = CType(resources.GetObject("cmdExploreAllTransferFilesData.Image"), System.Drawing.Image)
        Me.cmdExploreAllTransferFilesData.Name = "cmdExploreAllTransferFilesData"
        Me.cmdExploreAllTransferFilesData.Size = New System.Drawing.Size(110, 24)
        Me.cmdExploreAllTransferFilesData.Text = "Explorer All"
        '
        'cmdRemoveTransferFilesData
        '
        Me.cmdRemoveTransferFilesData.Image = Global.MoCTIMIS.My.Resources.Resources.delete_16x16
        Me.cmdRemoveTransferFilesData.Name = "cmdRemoveTransferFilesData"
        Me.cmdRemoveTransferFilesData.Size = New System.Drawing.Size(77, 24)
        Me.cmdRemoveTransferFilesData.Text = "Delete"
        '
        'cmdSearchTransferFilesData
        '
        Me.cmdSearchTransferFilesData.Image = Global.MoCTIMIS.My.Resources.Resources.system_search_3
        Me.cmdSearchTransferFilesData.Name = "cmdSearchTransferFilesData"
        Me.cmdSearchTransferFilesData.Size = New System.Drawing.Size(77, 24)
        Me.cmdSearchTransferFilesData.Text = "Search"
        '
        'lblTransferOfficeLinkInfo
        '
        Me.lblTransferOfficeLinkInfo.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblTransferOfficeLinkInfo.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransferOfficeLinkInfo.Appearance.ForeColor = System.Drawing.Color.Chocolate
        Me.lblTransferOfficeLinkInfo.Appearance.Options.UseBackColor = True
        Me.lblTransferOfficeLinkInfo.Appearance.Options.UseFont = True
        Me.lblTransferOfficeLinkInfo.Appearance.Options.UseForeColor = True
        Me.lblTransferOfficeLinkInfo.Location = New System.Drawing.Point(18, 14)
        Me.lblTransferOfficeLinkInfo.Name = "lblTransferOfficeLinkInfo"
        Me.lblTransferOfficeLinkInfo.Size = New System.Drawing.Size(95, 21)
        Me.lblTransferOfficeLinkInfo.TabIndex = 74
        Me.lblTransferOfficeLinkInfo.Text = "Transfer Office Link"
        '
        'lblTransferFilesDataInfo
        '
        Me.lblTransferFilesDataInfo.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblTransferFilesDataInfo.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransferFilesDataInfo.Appearance.ForeColor = System.Drawing.Color.Chocolate
        Me.lblTransferFilesDataInfo.Appearance.Options.UseBackColor = True
        Me.lblTransferFilesDataInfo.Appearance.Options.UseFont = True
        Me.lblTransferFilesDataInfo.Appearance.Options.UseForeColor = True
        Me.lblTransferFilesDataInfo.Location = New System.Drawing.Point(18, 14)
        Me.lblTransferFilesDataInfo.Name = "lblTransferFilesDataInfo"
        Me.lblTransferFilesDataInfo.Size = New System.Drawing.Size(95, 21)
        Me.lblTransferFilesDataInfo.TabIndex = 74
        Me.lblTransferFilesDataInfo.Text = "Transfer Files Data"
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
        'lblTransferPaymentsInfo
        '
        Me.lblTransferPaymentsInfo.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblTransferPaymentsInfo.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransferPaymentsInfo.Appearance.ForeColor = System.Drawing.Color.Chocolate
        Me.lblTransferPaymentsInfo.Appearance.Options.UseBackColor = True
        Me.lblTransferPaymentsInfo.Appearance.Options.UseFont = True
        Me.lblTransferPaymentsInfo.Appearance.Options.UseForeColor = True
        Me.lblTransferPaymentsInfo.Location = New System.Drawing.Point(18, 14)
        Me.lblTransferPaymentsInfo.Name = "lblTransferPaymentsInfo"
        Me.lblTransferPaymentsInfo.Size = New System.Drawing.Size(95, 21)
        Me.lblTransferPaymentsInfo.TabIndex = 74
        Me.lblTransferPaymentsInfo.Text = "Transfer Payments"
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
        Me.GridView1.GridControl = Me.TransfersDataGridView
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.SearchInPreview = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'TransfersDataGridView
        '
        Me.TransfersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransfersDataGridView.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransfersDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TransfersDataGridView.MainView = Me.GridView1
        Me.TransfersDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransfersDataGridView.Name = "TransfersDataGridView"
        Me.TransfersDataGridView.Size = New System.Drawing.Size(913, 678)
        Me.TransfersDataGridView.TabIndex = 23
        Me.TransfersDataGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.cmdClosePanelNew.Location = New System.Drawing.Point(957, 2)
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
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.PrintAllListedRecordsToolStripMenuItem, Me.SearchToolStripMenuItem, Me.SearchByDateToolStripMenuItem, Me.AdvancedSummaryToolStripMenuItem, Me.ImportWizardToolStripMenuItem, Me.ExportToExcellToolStripMenuItem, Me.PrintTemplateToolStripMenuItem})
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
        'PrintTemplateToolStripMenuItem
        '
        Me.PrintTemplateToolStripMenuItem.Name = "PrintTemplateToolStripMenuItem"
        Me.PrintTemplateToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.PrintTemplateToolStripMenuItem.Text = "Print Template"
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
        Me.PanelBody.Controls.Add(Me.PanelOfficestatement)
        Me.PanelBody.Controls.Add(Me.PanelTransferTemplate)
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
        Me.PanelNew.Controls.Add(Me.cmdPostCheckButton)
        Me.PanelNew.Controls.Add(Me.GroupControl3)
        Me.PanelNew.Controls.Add(Me.GroupControl2)
        Me.PanelNew.Controls.Add(Me.cmdPrintStatement)
        Me.PanelNew.Controls.Add(Me.cmdMakePayment)
        Me.PanelNew.Controls.Add(Me.GroupControl1)
        Me.PanelNew.Controls.Add(Me.XtraTabControlRelated)
        Me.PanelNew.Controls.Add(Me.cmdClosePanelNew)
        Me.PanelNew.Controls.Add(Me.lblFormName)
        Me.PanelNew.Location = New System.Drawing.Point(59, 48)
        Me.PanelNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelNew.Name = "PanelNew"
        Me.PanelNew.Size = New System.Drawing.Size(993, 652)
        Me.PanelNew.TabIndex = 99
        Me.PanelNew.Visible = False
        '
        'cmdPostCheckButton
        '
        Me.cmdPostCheckButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cmdPostCheckButton.Location = New System.Drawing.Point(19, 581)
        Me.cmdPostCheckButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPostCheckButton.Name = "cmdPostCheckButton"
        Me.cmdPostCheckButton.Size = New System.Drawing.Size(383, 42)
        Me.cmdPostCheckButton.TabIndex = 90
        Me.cmdPostCheckButton.Text = "POST TRANSACTION"
        '
        'GroupControl3
        '
        Me.GroupControl3.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl3.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl3.Controls.Add(Me.GeneratedTransferNoTextBox)
        Me.GroupControl3.Controls.Add(Me.OutgoneTransferCheckEdit)
        Me.GroupControl3.Controls.Add(Me.TransferNoTextBox)
        Me.GroupControl3.Controls.Add(Me.TransferDateDateTimePicker)
        Me.GroupControl3.Controls.Add(Me.TotalAmountTextBox)
        Me.GroupControl3.Controls.Add(Me.CommentTextBox)
        Me.GroupControl3.Controls.Add(Me.DocumentCompletionTextBox)
        Me.GroupControl3.Controls.Add(Me.CurrencyGridBox)
        Me.GroupControl3.Controls.Add(Me.ExchangeRateTextBox)
        Me.GroupControl3.Controls.Add(Me.BankAccountIDGridBox)
        Me.GroupControl3.Controls.Add(Me.GeneratedTransferNoLabel)
        Me.GroupControl3.Controls.Add(Me.OutgoneTransferLabel)
        Me.GroupControl3.Controls.Add(Me.TransferNoLabel)
        Me.GroupControl3.Controls.Add(Me.TransferTypeLabel)
        Me.GroupControl3.Controls.Add(Me.TransferDateLabel)
        Me.GroupControl3.Controls.Add(Me.OfficeTypeLabel)
        Me.GroupControl3.Controls.Add(Me.TotalAmountLabel)
        Me.GroupControl3.Controls.Add(Me.TransferStatusLabel)
        Me.GroupControl3.Controls.Add(Me.CommentLabel)
        Me.GroupControl3.Controls.Add(Me.SupervisionLabel)
        Me.GroupControl3.Controls.Add(Me.DocumentCompletionLabel)
        Me.GroupControl3.Controls.Add(Me.CurrencyLabel)
        Me.GroupControl3.Controls.Add(Me.ExchangeRateLabel)
        Me.GroupControl3.Controls.Add(Me.BankAccountIDLabel)
        Me.GroupControl3.Controls.Add(Me.OfficeTypeTextBox)
        Me.GroupControl3.Controls.Add(Me.TransferTypeTextBox)
        Me.GroupControl3.Controls.Add(Me.TransferStatusTextBox)
        Me.GroupControl3.Controls.Add(Me.SupervisionTextBox)
        Me.GroupControl3.Location = New System.Drawing.Point(19, 66)
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(384, 507)
        Me.GroupControl3.TabIndex = 89
        Me.GroupControl3.Text = "Detail of Transfer"
        '
        'OfficeTypeTextBox
        '
        Me.OfficeTypeTextBox.Location = New System.Drawing.Point(173, 197)
        Me.OfficeTypeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OfficeTypeTextBox.Name = "OfficeTypeTextBox"
        Me.OfficeTypeTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.OfficeTypeTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.OfficeTypeTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.OfficeTypeTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.OfficeTypeTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.OfficeTypeTextBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OfficeTypeTextBox.Properties.Items.AddRange(New Object() {"DEPARTMENT", "AGENCY", "OTHER"})
        Me.OfficeTypeTextBox.Size = New System.Drawing.Size(194, 24)
        Me.OfficeTypeTextBox.TabIndex = 1
        '
        'TransferTypeTextBox
        '
        Me.TransferTypeTextBox.Location = New System.Drawing.Point(173, 133)
        Me.TransferTypeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferTypeTextBox.Name = "TransferTypeTextBox"
        Me.TransferTypeTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.TransferTypeTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.TransferTypeTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.TransferTypeTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TransferTypeTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TransferTypeTextBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TransferTypeTextBox.Properties.Items.AddRange(New Object() {"PROFOMA", "TRANSFER REQUEST", "RECEIPT", "DELIVERY"})
        Me.TransferTypeTextBox.Size = New System.Drawing.Size(194, 24)
        Me.TransferTypeTextBox.TabIndex = 1
        '
        'TransferStatusTextBox
        '
        Me.TransferStatusTextBox.Location = New System.Drawing.Point(173, 359)
        Me.TransferStatusTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferStatusTextBox.Name = "TransferStatusTextBox"
        Me.TransferStatusTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.TransferStatusTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.TransferStatusTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.TransferStatusTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TransferStatusTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.TransferStatusTextBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TransferStatusTextBox.Properties.Items.AddRange(New Object() {"PENDING", "COMPLETE"})
        Me.TransferStatusTextBox.Size = New System.Drawing.Size(194, 24)
        Me.TransferStatusTextBox.TabIndex = 1
        '
        'SupervisionTextBox
        '
        Me.SupervisionTextBox.Location = New System.Drawing.Point(173, 426)
        Me.SupervisionTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SupervisionTextBox.Name = "SupervisionTextBox"
        Me.SupervisionTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.SupervisionTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.SupervisionTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.SupervisionTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.SupervisionTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SupervisionTextBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupervisionTextBox.Properties.Items.AddRange(New Object() {"APPROVED", "DISAPPROVED"})
        Me.SupervisionTextBox.Size = New System.Drawing.Size(194, 24)
        Me.SupervisionTextBox.TabIndex = 1
        '
        'GroupControl2
        '
        Me.GroupControl2.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl2.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl2.Controls.Add(Me.RegDateTextBox)
        Me.GroupControl2.Controls.Add(Me.InputtedByTextBox)
        Me.GroupControl2.Controls.Add(Me.RegDateLabel)
        Me.GroupControl2.Controls.Add(Me.InputtedByLabel)
        Me.GroupControl2.Location = New System.Drawing.Point(409, 66)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(313, 107)
        Me.GroupControl2.TabIndex = 88
        Me.GroupControl2.Text = "System Audit"
        '
        'cmdPrintStatement
        '
        Me.cmdPrintStatement.ImageOptions.Image = CType(resources.GetObject("cmdPrintStatement.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdPrintStatement.Location = New System.Drawing.Point(729, 245)
        Me.cmdPrintStatement.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPrintStatement.Name = "cmdPrintStatement"
        Me.cmdPrintStatement.Size = New System.Drawing.Size(238, 46)
        Me.cmdPrintStatement.TabIndex = 87
        Me.cmdPrintStatement.Text = "Print Payment Statement"
        Me.cmdPrintStatement.ToolTip = "Click here to add a new document to this archieve."
        '
        'cmdMakePayment
        '
        Me.cmdMakePayment.ImageOptions.Image = CType(resources.GetObject("cmdMakePayment.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdMakePayment.Location = New System.Drawing.Point(729, 186)
        Me.cmdMakePayment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMakePayment.Name = "cmdMakePayment"
        Me.cmdMakePayment.Size = New System.Drawing.Size(238, 46)
        Me.cmdMakePayment.TabIndex = 86
        Me.cmdMakePayment.Text = "Make Payment"
        Me.cmdMakePayment.ToolTip = "Click here to add a new document to this archieve."
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl1.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.radHDusemanualdate)
        Me.GroupControl1.Controls.Add(Me.radHDusesystemdate)
        Me.GroupControl1.Controls.Add(Me.cmdPrintHardcopyTransfer)
        Me.GroupControl1.Location = New System.Drawing.Point(409, 183)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(313, 108)
        Me.GroupControl1.TabIndex = 82
        Me.GroupControl1.Text = "Print Options"
        '
        'radHDusemanualdate
        '
        Me.radHDusemanualdate.AutoSize = True
        Me.radHDusemanualdate.Location = New System.Drawing.Point(168, 37)
        Me.radHDusemanualdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radHDusemanualdate.Name = "radHDusemanualdate"
        Me.radHDusemanualdate.Size = New System.Drawing.Size(130, 21)
        Me.radHDusemanualdate.TabIndex = 74
        Me.radHDusemanualdate.Text = "Use Manual Date"
        Me.radHDusemanualdate.UseVisualStyleBackColor = True
        '
        'radHDusesystemdate
        '
        Me.radHDusesystemdate.AutoSize = True
        Me.radHDusesystemdate.Checked = True
        Me.radHDusesystemdate.Location = New System.Drawing.Point(36, 37)
        Me.radHDusesystemdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radHDusesystemdate.Name = "radHDusesystemdate"
        Me.radHDusesystemdate.Size = New System.Drawing.Size(134, 21)
        Me.radHDusesystemdate.TabIndex = 75
        Me.radHDusesystemdate.TabStop = True
        Me.radHDusesystemdate.Text = "Use System Date"
        Me.radHDusesystemdate.UseVisualStyleBackColor = True
        '
        'cmdPrintHardcopyTransfer
        '
        Me.cmdPrintHardcopyTransfer.ImageOptions.Image = CType(resources.GetObject("cmdPrintHardcopyTransfer.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdPrintHardcopyTransfer.Location = New System.Drawing.Point(22, 65)
        Me.cmdPrintHardcopyTransfer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPrintHardcopyTransfer.Name = "cmdPrintHardcopyTransfer"
        Me.cmdPrintHardcopyTransfer.Size = New System.Drawing.Size(271, 34)
        Me.cmdPrintHardcopyTransfer.TabIndex = 73
        Me.cmdPrintHardcopyTransfer.Text = "Print Hardcopy Transfer"
        '
        'lblFormName
        '
        Me.lblFormName.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblFormName.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormName.Appearance.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblFormName.Appearance.Options.UseBackColor = True
        Me.lblFormName.Appearance.Options.UseFont = True
        Me.lblFormName.Appearance.Options.UseForeColor = True
        Me.lblFormName.Location = New System.Drawing.Point(19, 22)
        Me.lblFormName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(110, 34)
        Me.lblFormName.TabIndex = 1
        Me.lblFormName.Text = "Transfers"
        '
        'PanelOfficestatement
        '
        Me.PanelOfficestatement.BackColor = System.Drawing.Color.Transparent
        Me.PanelOfficestatement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelOfficestatement.Controls.Add(Me.OfficeIDGridBox)
        Me.PanelOfficestatement.Controls.Add(Me.LabelControl28)
        Me.PanelOfficestatement.Controls.Add(Me.cmdPrintOfficestatement)
        Me.PanelOfficestatement.Controls.Add(Me.cmdCloseOfficestatement)
        Me.PanelOfficestatement.Controls.Add(Me.LabelControl29)
        Me.PanelOfficestatement.Location = New System.Drawing.Point(365, 11)
        Me.PanelOfficestatement.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelOfficestatement.Name = "PanelOfficestatement"
        Me.PanelOfficestatement.Size = New System.Drawing.Size(304, 144)
        Me.PanelOfficestatement.TabIndex = 103
        Me.PanelOfficestatement.Visible = False
        '
        'OfficeIDGridBox
        '
        Me.OfficeIDGridBox.Location = New System.Drawing.Point(103, 43)
        Me.OfficeIDGridBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OfficeIDGridBox.Name = "OfficeIDGridBox"
        Me.OfficeIDGridBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.OfficeIDGridBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OfficeIDGridBox.Properties.NullText = ""
        Me.OfficeIDGridBox.Size = New System.Drawing.Size(194, 24)
        Me.OfficeIDGridBox.TabIndex = 63
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl28.Appearance.Options.UseFont = True
        Me.LabelControl28.Location = New System.Drawing.Point(14, 46)
        Me.LabelControl28.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(62, 19)
        Me.LabelControl28.TabIndex = 62
        Me.LabelControl28.Text = "Office ID:"
        '
        'cmdPrintOfficestatement
        '
        Me.cmdPrintOfficestatement.ImageOptions.Image = CType(resources.GetObject("cmdPrintOfficestatement.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdPrintOfficestatement.Location = New System.Drawing.Point(8, 90)
        Me.cmdPrintOfficestatement.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPrintOfficestatement.Name = "cmdPrintOfficestatement"
        Me.cmdPrintOfficestatement.Size = New System.Drawing.Size(290, 34)
        Me.cmdPrintOfficestatement.TabIndex = 59
        Me.cmdPrintOfficestatement.Text = "Print Statement"
        '
        'cmdCloseOfficestatement
        '
        Me.cmdCloseOfficestatement.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCloseOfficestatement.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseOfficestatement.Appearance.Options.UseFont = True
        Me.cmdCloseOfficestatement.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdCloseOfficestatement.Location = New System.Drawing.Point(269, -1)
        Me.cmdCloseOfficestatement.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCloseOfficestatement.Name = "cmdCloseOfficestatement"
        Me.cmdCloseOfficestatement.Size = New System.Drawing.Size(34, 34)
        Me.cmdCloseOfficestatement.TabIndex = 50
        Me.cmdCloseOfficestatement.Text = "X"
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl29.Appearance.ForeColor = System.Drawing.Color.Chocolate
        Me.LabelControl29.Appearance.Options.UseBackColor = True
        Me.LabelControl29.Appearance.Options.UseFont = True
        Me.LabelControl29.Appearance.Options.UseForeColor = True
        Me.LabelControl29.Location = New System.Drawing.Point(8, 6)
        Me.LabelControl29.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(187, 24)
        Me.LabelControl29.TabIndex = 1
        Me.LabelControl29.Text = "Print Office Statement"
        '
        'PanelTransferTemplate
        '
        Me.PanelTransferTemplate.BackColor = System.Drawing.Color.Transparent
        Me.PanelTransferTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTransferTemplate.Controls.Add(Me.radManualDate)
        Me.PanelTransferTemplate.Controls.Add(Me.radSystemDate)
        Me.PanelTransferTemplate.Controls.Add(Me.TemplateTransferTypeComboBox)
        Me.PanelTransferTemplate.Controls.Add(Me.LabelControl12)
        Me.PanelTransferTemplate.Controls.Add(Me.numCustPrintCount)
        Me.PanelTransferTemplate.Controls.Add(Me.cmdPrintOfficeDocument)
        Me.PanelTransferTemplate.Controls.Add(Me.cmdClosePanelCustAgreements)
        Me.PanelTransferTemplate.Controls.Add(Me.LabelControl25)
        Me.PanelTransferTemplate.Controls.Add(Me.LabelControl26)
        Me.PanelTransferTemplate.Location = New System.Drawing.Point(174, 11)
        Me.PanelTransferTemplate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelTransferTemplate.Name = "PanelTransferTemplate"
        Me.PanelTransferTemplate.Size = New System.Drawing.Size(304, 194)
        Me.PanelTransferTemplate.TabIndex = 104
        Me.PanelTransferTemplate.Visible = False
        '
        'radManualDate
        '
        Me.radManualDate.AutoSize = True
        Me.radManualDate.Location = New System.Drawing.Point(147, 112)
        Me.radManualDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radManualDate.Name = "radManualDate"
        Me.radManualDate.Size = New System.Drawing.Size(130, 21)
        Me.radManualDate.TabIndex = 63
        Me.radManualDate.Text = "Use Manual Date"
        Me.radManualDate.UseVisualStyleBackColor = True
        '
        'radSystemDate
        '
        Me.radSystemDate.AutoSize = True
        Me.radSystemDate.Checked = True
        Me.radSystemDate.Location = New System.Drawing.Point(19, 113)
        Me.radSystemDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radSystemDate.Name = "radSystemDate"
        Me.radSystemDate.Size = New System.Drawing.Size(134, 21)
        Me.radSystemDate.TabIndex = 63
        Me.radSystemDate.TabStop = True
        Me.radSystemDate.Text = "Use System Date"
        Me.radSystemDate.UseVisualStyleBackColor = True
        '
        'TemplateTransferTypeComboBox
        '
        Me.TemplateTransferTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TemplateTransferTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TemplateTransferTypeComboBox.FormattingEnabled = True
        Me.TemplateTransferTypeComboBox.Items.AddRange(New Object() {"Profoma", "Transfer", "Receipt", "Delivery Note", "Letterhead"})
        Me.TemplateTransferTypeComboBox.Location = New System.Drawing.Point(122, 43)
        Me.TemplateTransferTypeComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TemplateTransferTypeComboBox.Name = "TemplateTransferTypeComboBox"
        Me.TemplateTransferTypeComboBox.Size = New System.Drawing.Size(159, 24)
        Me.TemplateTransferTypeComboBox.TabIndex = 61
        Me.TemplateTransferTypeComboBox.Text = "Transfer"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(14, 46)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(105, 19)
        Me.LabelControl12.TabIndex = 62
        Me.LabelControl12.Text = "Document Type:"
        '
        'numCustPrintCount
        '
        Me.numCustPrintCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCustPrintCount.Location = New System.Drawing.Point(122, 78)
        Me.numCustPrintCount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numCustPrintCount.Name = "numCustPrintCount"
        Me.numCustPrintCount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.numCustPrintCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.numCustPrintCount.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numCustPrintCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCustPrintCount.Size = New System.Drawing.Size(99, 22)
        Me.numCustPrintCount.TabIndex = 60
        '
        'cmdPrintOfficeDocument
        '
        Me.cmdPrintOfficeDocument.Location = New System.Drawing.Point(8, 148)
        Me.cmdPrintOfficeDocument.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPrintOfficeDocument.Name = "cmdPrintOfficeDocument"
        Me.cmdPrintOfficeDocument.Size = New System.Drawing.Size(290, 34)
        Me.cmdPrintOfficeDocument.TabIndex = 59
        Me.cmdPrintOfficeDocument.Text = "Print Template"
        '
        'cmdClosePanelCustAgreements
        '
        Me.cmdClosePanelCustAgreements.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClosePanelCustAgreements.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClosePanelCustAgreements.Appearance.Options.UseFont = True
        Me.cmdClosePanelCustAgreements.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdClosePanelCustAgreements.Location = New System.Drawing.Point(269, -1)
        Me.cmdClosePanelCustAgreements.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdClosePanelCustAgreements.Name = "cmdClosePanelCustAgreements"
        Me.cmdClosePanelCustAgreements.Size = New System.Drawing.Size(34, 34)
        Me.cmdClosePanelCustAgreements.TabIndex = 50
        Me.cmdClosePanelCustAgreements.Text = "X"
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl25.Appearance.ForeColor = System.Drawing.Color.Chocolate
        Me.LabelControl25.Appearance.Options.UseBackColor = True
        Me.LabelControl25.Appearance.Options.UseFont = True
        Me.LabelControl25.Appearance.Options.UseForeColor = True
        Me.LabelControl25.Location = New System.Drawing.Point(8, 4)
        Me.LabelControl25.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(77, 24)
        Me.LabelControl25.TabIndex = 1
        Me.LabelControl25.Text = "Template"
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl26.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl26.Appearance.Options.UseBackColor = True
        Me.LabelControl26.Appearance.Options.UseFont = True
        Me.LabelControl26.Appearance.Options.UseForeColor = True
        Me.LabelControl26.Location = New System.Drawing.Point(14, 80)
        Me.LabelControl26.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(74, 18)
        Me.LabelControl26.TabIndex = 1
        Me.LabelControl26.Text = "Print Count:"
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
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.TransfersDataGridView)
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
        'frmTransfers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 777)
        Me.Controls.Add(Me.PanelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmTransfers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Transfers"
        CType(Me.PanelSearchByDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSearchByDate.ResumeLayout(False)
        Me.PanelSearchByDate.PerformLayout()
        CType(Me.EndDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchDateFieldComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneratedTransferNoTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutgoneTransferCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferNoTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferDateDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferDateDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalAmountTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentCompletionTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegDateTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputtedByTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyGridBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExchangeRateTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankAccountIDGridBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControlRelated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControlRelated.ResumeLayout(False)
        Me.XtraTabPageTransferOfficeLink.ResumeLayout(False)
        Me.XtraTabPageTransferOfficeLink.PerformLayout()
        CType(Me.TransferOfficeLinkGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTransferOfficeLink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripTransferOfficeLink.ResumeLayout(False)
        Me.ToolStripTransferOfficeLink.PerformLayout()
        Me.XtraTabPageTransferItems.ResumeLayout(False)
        Me.XtraTabPageTransferItems.PerformLayout()
        CType(Me.TransferItemsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTransferItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripTransferItems.ResumeLayout(False)
        Me.ToolStripTransferItems.PerformLayout()
        Me.XtraTabPageTransferPayments.ResumeLayout(False)
        Me.XtraTabPageTransferPayments.PerformLayout()
        CType(Me.TransferPaymentsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTransferPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripTransferPayments.ResumeLayout(False)
        Me.ToolStripTransferPayments.PerformLayout()
        Me.XtraTabPageTransferFilesData.ResumeLayout(False)
        Me.XtraTabPageTransferFilesData.PerformLayout()
        CType(Me.TransferFilesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTransferFilesData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripTransferFilesData.ResumeLayout(False)
        Me.ToolStripTransferFilesData.PerformLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransfersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.OfficeTypeTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferTypeTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferStatusTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupervisionTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.PanelOfficestatement.ResumeLayout(False)
        Me.PanelOfficestatement.PerformLayout()
        CType(Me.OfficeIDGridBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTransferTemplate.ResumeLayout(False)
        Me.PanelTransferTemplate.PerformLayout()
        CType(Me.numCustPrintCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GeneratedTransferNoTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OutgoneTransferCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TransferNoTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TransferDateDateTimePicker As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TotalAmountTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CommentTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DocumentCompletionTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RegDateTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents InputtedByTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CurrencyGridBox As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ExchangeRateTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BankAccountIDGridBox As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GeneratedTransferNoLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OutgoneTransferLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TransferNoLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TransferTypeLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TransferDateLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OfficeTypeLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TotalAmountLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TransferStatusLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CommentLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SupervisionLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DocumentCompletionLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RegDateLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents InputtedByLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CurrencyLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ExchangeRateLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BankAccountIDLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GeneratedTransferNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OutgoneTransferDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransferNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransferTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransferDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OfficeTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransferStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupervisionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentCompletionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InputtedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExchangeRateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankAccountIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents TransfersDataGridView As DevExpress.XtraGrid.GridControl
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
    Friend WithEvents ToolStripTransferOfficeLink As System.Windows.Forms.ToolStrip
    Friend WithEvents XtraTabPageTransferOfficeLink As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblTransferOfficeLinkInfo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdOpenRecordTransferOfficeLink As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAddTransferOfficeLink As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRemoveTransferOfficeLink As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSearchTransferOfficeLink As System.Windows.Forms.ToolStripButton
    Friend WithEvents TransferOfficeLinkGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTransferOfficeLink As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolStripTransferFilesData As System.Windows.Forms.ToolStrip
    Friend WithEvents XtraTabPageTransferFilesData As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblTransferFilesDataInfo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdOpenRecordTransferFilesData As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAddTransferFilesData As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRemoveTransferFilesData As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSearchTransferFilesData As System.Windows.Forms.ToolStripButton
    Friend WithEvents TransferFilesDataGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTransferFilesData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdExploreAllTransferFilesData As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDownloadTransferFilesData As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdOpenTransferFilesData As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripTransferItems As System.Windows.Forms.ToolStrip
    Friend WithEvents XtraTabPageTransferItems As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblTransferItemsInfo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdOpenRecordTransferItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAddTransferItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRemoveTransferItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSearchTransferItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents TransferItemsGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTransferItems As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolStripTransferPayments As System.Windows.Forms.ToolStrip
    Friend WithEvents XtraTabPageTransferPayments As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblTransferPaymentsInfo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdOpenRecordTransferPayments As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAddTransferPayments As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRemoveTransferPayments As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSearchTransferPayments As System.Windows.Forms.ToolStripButton
    Friend WithEvents TransferPaymentsGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTransferPayments As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents OfficeTypeTextBox As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TransferTypeTextBox As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TransferStatusTextBox As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SupervisionTextBox As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PanelOfficestatement As Panel
    Friend WithEvents OfficeIDGridBox As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdPrintOfficestatement As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCloseOfficestatement As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdPrintStatement As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdMakePayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents radHDusemanualdate As RadioButton
    Friend WithEvents radHDusesystemdate As RadioButton
    Friend WithEvents cmdPrintHardcopyTransfer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelTransferTemplate As Panel
    Friend WithEvents radManualDate As RadioButton
    Friend WithEvents radSystemDate As RadioButton
    Friend WithEvents TemplateTransferTypeComboBox As ComboBox
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents numCustPrintCount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents cmdPrintOfficeDocument As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClosePanelCustAgreements As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PrintTemplateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdPostCheckButton As DevExpress.XtraEditors.CheckButton
End Class
