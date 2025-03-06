<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransferPayments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferPayments))
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
        Me.IPaymentIDLabel = New DevExpress.XtraEditors.LabelControl()
        Me.GeneratedTransferNoLabel = New DevExpress.XtraEditors.LabelControl()
        Me.PaidByLabel = New DevExpress.XtraEditors.LabelControl()
        Me.PaymentDateLabel = New DevExpress.XtraEditors.LabelControl()
        Me.CurrentAmountLabel = New DevExpress.XtraEditors.LabelControl()
        Me.AmountPaidLabel = New DevExpress.XtraEditors.LabelControl()
        Me.BalanceLabel = New DevExpress.XtraEditors.LabelControl()
        Me.PaymentModeLabel = New DevExpress.XtraEditors.LabelControl()
        Me.RefChequeNoLabel = New DevExpress.XtraEditors.LabelControl()
        Me.BankLabel = New DevExpress.XtraEditors.LabelControl()
        Me.CommentLabel = New DevExpress.XtraEditors.LabelControl()
        Me.RegDateLabel = New DevExpress.XtraEditors.LabelControl()
        Me.InputedByLabel = New DevExpress.XtraEditors.LabelControl()
        Me.IPaymentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneratedTransferNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentModeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefChequeNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPaymentIDTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.GeneratedTransferNoGridBox = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PaidByTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.PaymentDateDateTimePicker = New DevExpress.XtraEditors.DateEdit()
        Me.CurrentAmountTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.AmountPaidTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.BalanceTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.RefChequeNoTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.CommentTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.RegDateTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.InputedByTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabControlRelated = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPageTransferPaymentDocuments = New DevExpress.XtraTab.XtraTabPage()
        Me.TransferPaymentDocumentsGridView = New DevExpress.XtraGrid.GridControl()
        Me.GridViewTransferPaymentDocuments = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolStripTransferPaymentDocuments = New System.Windows.Forms.ToolStrip()
        Me.cmdAddTransferPaymentDocuments = New System.Windows.Forms.ToolStripButton()
        Me.cmdOpenRecordTransferPaymentDocuments = New System.Windows.Forms.ToolStripButton()
        Me.cmdOpenTransferPaymentDocuments = New System.Windows.Forms.ToolStripButton()
        Me.cmdDownloadTransferPaymentDocuments = New System.Windows.Forms.ToolStripButton()
        Me.cmdExploreAllTransferPaymentDocuments = New System.Windows.Forms.ToolStripButton()
        Me.cmdRemoveTransferPaymentDocuments = New System.Windows.Forms.ToolStripButton()
        Me.cmdSearchTransferPaymentDocuments = New System.Windows.Forms.ToolStripButton()
        Me.lblTransferPaymentDocumentsInfo = New DevExpress.XtraEditors.LabelControl()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SearchToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TransferPaymentsDataGridView = New DevExpress.XtraGrid.GridControl()
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
        Me.cmdPrintReceipt = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.DiscountTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PaymentModeTextBox = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.BankTextBox = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lblFormName = New DevExpress.XtraEditors.LabelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.PanelExporting = New DevExpress.XtraEditors.PanelControl()
        Me.PanelProgressbarContainer = New DevExpress.XtraEditors.PanelControl()
        Me.PanelProgressbar = New DevExpress.XtraEditors.PanelControl()
        Me.lblExportPercentage = New DevExpress.XtraEditors.LabelControl()
        Me.lblNoRows = New DevExpress.XtraEditors.LabelControl()
        Me.lblNoValues = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblExportStatus = New DevExpress.XtraEditors.LabelControl()
        Me.Label26 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdCloseExport = New DevExpress.XtraEditors.SimpleButton()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        CType(Me.PanelSearchByDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSearchByDate.SuspendLayout()
        CType(Me.EndDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchDateFieldComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IPaymentIDTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneratedTransferNoGridBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaidByTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentDateDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentDateDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentAmountTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmountPaidTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefChequeNoTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegDateTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputedByTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControlRelated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControlRelated.SuspendLayout()
        Me.XtraTabPageTransferPaymentDocuments.SuspendLayout()
        CType(Me.TransferPaymentDocumentsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTransferPaymentDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripTransferPaymentDocuments.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferPaymentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomStatusStrip.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.TopToolStrip.SuspendLayout()
        CType(Me.PanelBody, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBody.SuspendLayout()
        CType(Me.PanelNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNew.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.DiscountTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentModeTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cmdDateSearch.Size = New System.Drawing.Size(206, 33)
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
        Me.EndDateTimePicker.Size = New System.Drawing.Size(206, 24)
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
        Me.StartDateTimePicker.Size = New System.Drawing.Size(206, 24)
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
        Me.SearchDateFieldComboBox.Size = New System.Drawing.Size(206, 24)
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
        'IPaymentIDLabel
        '
        Me.IPaymentIDLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPaymentIDLabel.Appearance.Options.UseFont = True
        Me.IPaymentIDLabel.Location = New System.Drawing.Point(22, 41)
        Me.IPaymentIDLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IPaymentIDLabel.Name = "IPaymentIDLabel"
        Me.IPaymentIDLabel.Size = New System.Drawing.Size(82, 19)
        Me.IPaymentIDLabel.TabIndex = 1
        Me.IPaymentIDLabel.Text = "IPayment ID:"
        '
        'GeneratedTransferNoLabel
        '
        Me.GeneratedTransferNoLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneratedTransferNoLabel.Appearance.Options.UseFont = True
        Me.GeneratedTransferNoLabel.Location = New System.Drawing.Point(22, 73)
        Me.GeneratedTransferNoLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GeneratedTransferNoLabel.Name = "GeneratedTransferNoLabel"
        Me.GeneratedTransferNoLabel.Size = New System.Drawing.Size(152, 19)
        Me.GeneratedTransferNoLabel.TabIndex = 1
        Me.GeneratedTransferNoLabel.Text = "Generated Transfer No:"
        '
        'PaidByLabel
        '
        Me.PaidByLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaidByLabel.Appearance.Options.UseFont = True
        Me.PaidByLabel.Location = New System.Drawing.Point(22, 105)
        Me.PaidByLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PaidByLabel.Name = "PaidByLabel"
        Me.PaidByLabel.Size = New System.Drawing.Size(52, 19)
        Me.PaidByLabel.TabIndex = 1
        Me.PaidByLabel.Text = "Paid By:"
        '
        'PaymentDateLabel
        '
        Me.PaymentDateLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentDateLabel.Appearance.Options.UseFont = True
        Me.PaymentDateLabel.Location = New System.Drawing.Point(22, 137)
        Me.PaymentDateLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PaymentDateLabel.Name = "PaymentDateLabel"
        Me.PaymentDateLabel.Size = New System.Drawing.Size(95, 19)
        Me.PaymentDateLabel.TabIndex = 1
        Me.PaymentDateLabel.Text = "Payment Date:"
        '
        'CurrentAmountLabel
        '
        Me.CurrentAmountLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentAmountLabel.Appearance.Options.UseFont = True
        Me.CurrentAmountLabel.Location = New System.Drawing.Point(22, 169)
        Me.CurrentAmountLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CurrentAmountLabel.Name = "CurrentAmountLabel"
        Me.CurrentAmountLabel.Size = New System.Drawing.Size(106, 19)
        Me.CurrentAmountLabel.TabIndex = 1
        Me.CurrentAmountLabel.Text = "Current Amount:"
        '
        'AmountPaidLabel
        '
        Me.AmountPaidLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountPaidLabel.Appearance.Options.UseFont = True
        Me.AmountPaidLabel.Location = New System.Drawing.Point(22, 201)
        Me.AmountPaidLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AmountPaidLabel.Name = "AmountPaidLabel"
        Me.AmountPaidLabel.Size = New System.Drawing.Size(86, 19)
        Me.AmountPaidLabel.TabIndex = 1
        Me.AmountPaidLabel.Text = "Amount Paid:"
        '
        'BalanceLabel
        '
        Me.BalanceLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceLabel.Appearance.Options.UseFont = True
        Me.BalanceLabel.Location = New System.Drawing.Point(22, 268)
        Me.BalanceLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BalanceLabel.Name = "BalanceLabel"
        Me.BalanceLabel.Size = New System.Drawing.Size(56, 19)
        Me.BalanceLabel.TabIndex = 1
        Me.BalanceLabel.Text = "Balance:"
        '
        'PaymentModeLabel
        '
        Me.PaymentModeLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentModeLabel.Appearance.Options.UseFont = True
        Me.PaymentModeLabel.Location = New System.Drawing.Point(22, 300)
        Me.PaymentModeLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PaymentModeLabel.Name = "PaymentModeLabel"
        Me.PaymentModeLabel.Size = New System.Drawing.Size(101, 19)
        Me.PaymentModeLabel.TabIndex = 1
        Me.PaymentModeLabel.Text = "Payment Mode:"
        '
        'RefChequeNoLabel
        '
        Me.RefChequeNoLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefChequeNoLabel.Appearance.Options.UseFont = True
        Me.RefChequeNoLabel.Location = New System.Drawing.Point(22, 332)
        Me.RefChequeNoLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RefChequeNoLabel.Name = "RefChequeNoLabel"
        Me.RefChequeNoLabel.Size = New System.Drawing.Size(101, 19)
        Me.RefChequeNoLabel.TabIndex = 1
        Me.RefChequeNoLabel.Text = "Ref Cheque No:"
        '
        'BankLabel
        '
        Me.BankLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BankLabel.Appearance.Options.UseFont = True
        Me.BankLabel.Location = New System.Drawing.Point(22, 364)
        Me.BankLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BankLabel.Name = "BankLabel"
        Me.BankLabel.Size = New System.Drawing.Size(36, 19)
        Me.BankLabel.TabIndex = 1
        Me.BankLabel.Text = "Bank:"
        '
        'CommentLabel
        '
        Me.CommentLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommentLabel.Appearance.Options.UseFont = True
        Me.CommentLabel.Location = New System.Drawing.Point(22, 396)
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
        Me.RegDateLabel.Location = New System.Drawing.Point(19, 43)
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
        Me.InputedByLabel.Location = New System.Drawing.Point(19, 75)
        Me.InputedByLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InputedByLabel.Name = "InputedByLabel"
        Me.InputedByLabel.Size = New System.Drawing.Size(73, 19)
        Me.InputedByLabel.TabIndex = 1
        Me.InputedByLabel.Text = "Inputed By:"
        '
        'IPaymentIDDataGridViewTextBoxColumn
        '
        Me.IPaymentIDDataGridViewTextBoxColumn.DataPropertyName = "IPaymentID"
        Me.IPaymentIDDataGridViewTextBoxColumn.HeaderText = "IPaymentID"
        Me.IPaymentIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IPaymentIDDataGridViewTextBoxColumn.Name = "IPaymentIDDataGridViewTextBoxColumn"
        Me.IPaymentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IPaymentIDDataGridViewTextBoxColumn.Width = 125
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
        'PaidByDataGridViewTextBoxColumn
        '
        Me.PaidByDataGridViewTextBoxColumn.DataPropertyName = "PaidBy"
        Me.PaidByDataGridViewTextBoxColumn.HeaderText = "PaidBy"
        Me.PaidByDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PaidByDataGridViewTextBoxColumn.Name = "PaidByDataGridViewTextBoxColumn"
        Me.PaidByDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaidByDataGridViewTextBoxColumn.Width = 125
        '
        'PaymentDateDataGridViewTextBoxColumn
        '
        Me.PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate"
        Me.PaymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate"
        Me.PaymentDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PaymentDateDataGridViewTextBoxColumn.Name = "PaymentDateDataGridViewTextBoxColumn"
        Me.PaymentDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaymentDateDataGridViewTextBoxColumn.Width = 125
        '
        'CurrentAmountDataGridViewTextBoxColumn
        '
        Me.CurrentAmountDataGridViewTextBoxColumn.DataPropertyName = "CurrentAmount"
        Me.CurrentAmountDataGridViewTextBoxColumn.HeaderText = "CurrentAmount"
        Me.CurrentAmountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CurrentAmountDataGridViewTextBoxColumn.Name = "CurrentAmountDataGridViewTextBoxColumn"
        Me.CurrentAmountDataGridViewTextBoxColumn.ReadOnly = True
        Me.CurrentAmountDataGridViewTextBoxColumn.Width = 125
        '
        'AmountPaidDataGridViewTextBoxColumn
        '
        Me.AmountPaidDataGridViewTextBoxColumn.DataPropertyName = "AmountPaid"
        Me.AmountPaidDataGridViewTextBoxColumn.HeaderText = "AmountPaid"
        Me.AmountPaidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AmountPaidDataGridViewTextBoxColumn.Name = "AmountPaidDataGridViewTextBoxColumn"
        Me.AmountPaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.AmountPaidDataGridViewTextBoxColumn.Width = 125
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.BalanceDataGridViewTextBoxColumn.Width = 125
        '
        'PaymentModeDataGridViewTextBoxColumn
        '
        Me.PaymentModeDataGridViewTextBoxColumn.DataPropertyName = "PaymentMode"
        Me.PaymentModeDataGridViewTextBoxColumn.HeaderText = "PaymentMode"
        Me.PaymentModeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PaymentModeDataGridViewTextBoxColumn.Name = "PaymentModeDataGridViewTextBoxColumn"
        Me.PaymentModeDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaymentModeDataGridViewTextBoxColumn.Width = 125
        '
        'RefChequeNoDataGridViewTextBoxColumn
        '
        Me.RefChequeNoDataGridViewTextBoxColumn.DataPropertyName = "RefChequeNo"
        Me.RefChequeNoDataGridViewTextBoxColumn.HeaderText = "RefChequeNo"
        Me.RefChequeNoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RefChequeNoDataGridViewTextBoxColumn.Name = "RefChequeNoDataGridViewTextBoxColumn"
        Me.RefChequeNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.RefChequeNoDataGridViewTextBoxColumn.Width = 125
        '
        'BankDataGridViewTextBoxColumn
        '
        Me.BankDataGridViewTextBoxColumn.DataPropertyName = "Bank"
        Me.BankDataGridViewTextBoxColumn.HeaderText = "Bank"
        Me.BankDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BankDataGridViewTextBoxColumn.Name = "BankDataGridViewTextBoxColumn"
        Me.BankDataGridViewTextBoxColumn.ReadOnly = True
        Me.BankDataGridViewTextBoxColumn.Width = 125
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
        'IPaymentIDTextBox
        '
        Me.IPaymentIDTextBox.EnterMoveNextControl = True
        Me.IPaymentIDTextBox.Location = New System.Drawing.Point(187, 36)
        Me.IPaymentIDTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IPaymentIDTextBox.Name = "IPaymentIDTextBox"
        Me.IPaymentIDTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.IPaymentIDTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.IPaymentIDTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.IPaymentIDTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.IPaymentIDTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.IPaymentIDTextBox.Properties.ReadOnly = True
        Me.IPaymentIDTextBox.Size = New System.Drawing.Size(255, 24)
        Me.IPaymentIDTextBox.TabIndex = 1
        '
        'GeneratedTransferNoGridBox
        '
        Me.GeneratedTransferNoGridBox.Location = New System.Drawing.Point(187, 68)
        Me.GeneratedTransferNoGridBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GeneratedTransferNoGridBox.Name = "GeneratedTransferNoGridBox"
        Me.GeneratedTransferNoGridBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.GeneratedTransferNoGridBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GeneratedTransferNoGridBox.Properties.NullText = ""
        Me.GeneratedTransferNoGridBox.Size = New System.Drawing.Size(255, 24)
        Me.GeneratedTransferNoGridBox.TabIndex = 1
        '
        'PaidByTextBox
        '
        Me.PaidByTextBox.EnterMoveNextControl = True
        Me.PaidByTextBox.Location = New System.Drawing.Point(187, 100)
        Me.PaidByTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PaidByTextBox.Name = "PaidByTextBox"
        Me.PaidByTextBox.Properties.Appearance.BackColor = System.Drawing.Color.PeachPuff
        Me.PaidByTextBox.Properties.Appearance.Options.UseBackColor = True
        Me.PaidByTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.PaidByTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.PaidByTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.PaidByTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.PaidByTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PaidByTextBox.Size = New System.Drawing.Size(255, 24)
        Me.PaidByTextBox.TabIndex = 1
        '
        'PaymentDateDateTimePicker
        '
        Me.PaymentDateDateTimePicker.EditValue = Nothing
        Me.PaymentDateDateTimePicker.Location = New System.Drawing.Point(187, 132)
        Me.PaymentDateDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PaymentDateDateTimePicker.Name = "PaymentDateDateTimePicker"
        Me.PaymentDateDateTimePicker.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PaymentDateDateTimePicker.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PaymentDateDateTimePicker.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PaymentDateDateTimePicker.Properties.Mask.BeepOnError = True
        Me.PaymentDateDateTimePicker.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.PaymentDateDateTimePicker.Size = New System.Drawing.Size(255, 24)
        Me.PaymentDateDateTimePicker.TabIndex = 1
        '
        'CurrentAmountTextBox
        '
        Me.CurrentAmountTextBox.EnterMoveNextControl = True
        Me.CurrentAmountTextBox.Location = New System.Drawing.Point(187, 164)
        Me.CurrentAmountTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CurrentAmountTextBox.Name = "CurrentAmountTextBox"
        Me.CurrentAmountTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.CurrentAmountTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.CurrentAmountTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.CurrentAmountTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.CurrentAmountTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CurrentAmountTextBox.Properties.ReadOnly = True
        Me.CurrentAmountTextBox.Size = New System.Drawing.Size(255, 24)
        Me.CurrentAmountTextBox.TabIndex = 1
        '
        'AmountPaidTextBox
        '
        Me.AmountPaidTextBox.EnterMoveNextControl = True
        Me.AmountPaidTextBox.Location = New System.Drawing.Point(187, 196)
        Me.AmountPaidTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AmountPaidTextBox.Name = "AmountPaidTextBox"
        Me.AmountPaidTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.AmountPaidTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.AmountPaidTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.AmountPaidTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.AmountPaidTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.AmountPaidTextBox.Size = New System.Drawing.Size(255, 24)
        Me.AmountPaidTextBox.TabIndex = 1
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.EnterMoveNextControl = True
        Me.BalanceTextBox.Location = New System.Drawing.Point(187, 263)
        Me.BalanceTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BalanceTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.BalanceTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.BalanceTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.BalanceTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BalanceTextBox.Properties.ReadOnly = True
        Me.BalanceTextBox.Size = New System.Drawing.Size(255, 24)
        Me.BalanceTextBox.TabIndex = 1
        '
        'RefChequeNoTextBox
        '
        Me.RefChequeNoTextBox.EnterMoveNextControl = True
        Me.RefChequeNoTextBox.Location = New System.Drawing.Point(187, 327)
        Me.RefChequeNoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RefChequeNoTextBox.Name = "RefChequeNoTextBox"
        Me.RefChequeNoTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RefChequeNoTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.RefChequeNoTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.RefChequeNoTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.RefChequeNoTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RefChequeNoTextBox.Size = New System.Drawing.Size(255, 24)
        Me.RefChequeNoTextBox.TabIndex = 1
        '
        'CommentTextBox
        '
        Me.CommentTextBox.EnterMoveNextControl = True
        Me.CommentTextBox.Location = New System.Drawing.Point(187, 391)
        Me.CommentTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.CommentTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.CommentTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.CommentTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.CommentTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CommentTextBox.Size = New System.Drawing.Size(255, 24)
        Me.CommentTextBox.TabIndex = 1
        '
        'RegDateTextBox
        '
        Me.RegDateTextBox.EnterMoveNextControl = True
        Me.RegDateTextBox.Location = New System.Drawing.Point(164, 39)
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
        'InputedByTextBox
        '
        Me.InputedByTextBox.EnterMoveNextControl = True
        Me.InputedByTextBox.Location = New System.Drawing.Point(164, 71)
        Me.InputedByTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InputedByTextBox.Name = "InputedByTextBox"
        Me.InputedByTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.InputedByTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.InputedByTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.InputedByTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.InputedByTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.InputedByTextBox.Properties.ReadOnly = True
        Me.InputedByTextBox.Size = New System.Drawing.Size(194, 24)
        Me.InputedByTextBox.TabIndex = 1
        '
        'XtraTabControlRelated
        '
        Me.XtraTabControlRelated.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControlRelated.Location = New System.Drawing.Point(483, 59)
        Me.XtraTabControlRelated.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabControlRelated.Name = "XtraTabControlRelated"
        Me.XtraTabControlRelated.SelectedTabPage = Me.XtraTabPageTransferPaymentDocuments
        Me.XtraTabControlRelated.Size = New System.Drawing.Size(421, 622)
        Me.XtraTabControlRelated.TabIndex = 56
        Me.XtraTabControlRelated.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPageTransferPaymentDocuments})
        '
        'XtraTabPageTransferPaymentDocuments
        '
        Me.XtraTabPageTransferPaymentDocuments.Controls.Add(Me.TransferPaymentDocumentsGridView)
        Me.XtraTabPageTransferPaymentDocuments.Controls.Add(Me.ToolStripTransferPaymentDocuments)
        Me.XtraTabPageTransferPaymentDocuments.ImageOptions.Image = CType(resources.GetObject("XtraTabPageTransferPaymentDocuments.ImageOptions.Image"), System.Drawing.Image)
        Me.XtraTabPageTransferPaymentDocuments.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPageTransferPaymentDocuments.Name = "XtraTabPageTransferPaymentDocuments"
        Me.XtraTabPageTransferPaymentDocuments.Size = New System.Drawing.Size(414, 588)
        Me.XtraTabPageTransferPaymentDocuments.Text = "Transfer Payment Documents"
        '
        'TransferPaymentDocumentsGridView
        '
        Me.TransferPaymentDocumentsGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransferPaymentDocumentsGridView.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferPaymentDocumentsGridView.Location = New System.Drawing.Point(0, 27)
        Me.TransferPaymentDocumentsGridView.MainView = Me.GridViewTransferPaymentDocuments
        Me.TransferPaymentDocumentsGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferPaymentDocumentsGridView.Name = "TransferPaymentDocumentsGridView"
        Me.TransferPaymentDocumentsGridView.Size = New System.Drawing.Size(414, 561)
        Me.TransferPaymentDocumentsGridView.TabIndex = 71
        Me.TransferPaymentDocumentsGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTransferPaymentDocuments})
        '
        'GridViewTransferPaymentDocuments
        '
        Me.GridViewTransferPaymentDocuments.DetailHeight = 431
        Me.GridViewTransferPaymentDocuments.GridControl = Me.TransferPaymentDocumentsGridView
        Me.GridViewTransferPaymentDocuments.Name = "GridViewTransferPaymentDocuments"
        Me.GridViewTransferPaymentDocuments.OptionsBehavior.ReadOnly = True
        Me.GridViewTransferPaymentDocuments.OptionsFind.SearchInPreview = True
        Me.GridViewTransferPaymentDocuments.OptionsView.ColumnAutoWidth = False
        Me.GridViewTransferPaymentDocuments.OptionsView.ShowFooter = True
        '
        'ToolStripTransferPaymentDocuments
        '
        Me.ToolStripTransferPaymentDocuments.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripTransferPaymentDocuments.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddTransferPaymentDocuments, Me.cmdOpenRecordTransferPaymentDocuments, Me.cmdOpenTransferPaymentDocuments, Me.cmdDownloadTransferPaymentDocuments, Me.cmdExploreAllTransferPaymentDocuments, Me.cmdRemoveTransferPaymentDocuments, Me.cmdSearchTransferPaymentDocuments})
        Me.ToolStripTransferPaymentDocuments.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripTransferPaymentDocuments.Name = "ToolStripTransferPaymentDocuments"
        Me.ToolStripTransferPaymentDocuments.Size = New System.Drawing.Size(414, 27)
        Me.ToolStripTransferPaymentDocuments.TabIndex = 72
        '
        'cmdAddTransferPaymentDocuments
        '
        Me.cmdAddTransferPaymentDocuments.Image = Global.MoCTIMIS.My.Resources.Resources.add_16x16
        Me.cmdAddTransferPaymentDocuments.Name = "cmdAddTransferPaymentDocuments"
        Me.cmdAddTransferPaymentDocuments.Size = New System.Drawing.Size(95, 24)
        Me.cmdAddTransferPaymentDocuments.Text = "Add New"
        '
        'cmdOpenRecordTransferPaymentDocuments
        '
        Me.cmdOpenRecordTransferPaymentDocuments.Image = Global.MoCTIMIS.My.Resources.Resources.article_16x16
        Me.cmdOpenRecordTransferPaymentDocuments.Name = "cmdOpenRecordTransferPaymentDocuments"
        Me.cmdOpenRecordTransferPaymentDocuments.Size = New System.Drawing.Size(120, 24)
        Me.cmdOpenRecordTransferPaymentDocuments.Text = "Open Record"
        '
        'cmdOpenTransferPaymentDocuments
        '
        Me.cmdOpenTransferPaymentDocuments.Image = CType(resources.GetObject("cmdOpenTransferPaymentDocuments.Image"), System.Drawing.Image)
        Me.cmdOpenTransferPaymentDocuments.Name = "cmdOpenTransferPaymentDocuments"
        Me.cmdOpenTransferPaymentDocuments.Size = New System.Drawing.Size(96, 24)
        Me.cmdOpenTransferPaymentDocuments.Text = "Open File"
        '
        'cmdDownloadTransferPaymentDocuments
        '
        Me.cmdDownloadTransferPaymentDocuments.Image = CType(resources.GetObject("cmdDownloadTransferPaymentDocuments.Image"), System.Drawing.Image)
        Me.cmdDownloadTransferPaymentDocuments.Name = "cmdDownloadTransferPaymentDocuments"
        Me.cmdDownloadTransferPaymentDocuments.Size = New System.Drawing.Size(102, 24)
        Me.cmdDownloadTransferPaymentDocuments.Text = "Download"
        '
        'cmdExploreAllTransferPaymentDocuments
        '
        Me.cmdExploreAllTransferPaymentDocuments.Image = CType(resources.GetObject("cmdExploreAllTransferPaymentDocuments.Image"), System.Drawing.Image)
        Me.cmdExploreAllTransferPaymentDocuments.Name = "cmdExploreAllTransferPaymentDocuments"
        Me.cmdExploreAllTransferPaymentDocuments.Size = New System.Drawing.Size(110, 24)
        Me.cmdExploreAllTransferPaymentDocuments.Text = "Explorer All"
        '
        'cmdRemoveTransferPaymentDocuments
        '
        Me.cmdRemoveTransferPaymentDocuments.Image = Global.MoCTIMIS.My.Resources.Resources.delete_16x16
        Me.cmdRemoveTransferPaymentDocuments.Name = "cmdRemoveTransferPaymentDocuments"
        Me.cmdRemoveTransferPaymentDocuments.Size = New System.Drawing.Size(77, 24)
        Me.cmdRemoveTransferPaymentDocuments.Text = "Delete"
        '
        'cmdSearchTransferPaymentDocuments
        '
        Me.cmdSearchTransferPaymentDocuments.Image = Global.MoCTIMIS.My.Resources.Resources.system_search_3
        Me.cmdSearchTransferPaymentDocuments.Name = "cmdSearchTransferPaymentDocuments"
        Me.cmdSearchTransferPaymentDocuments.Size = New System.Drawing.Size(77, 24)
        Me.cmdSearchTransferPaymentDocuments.Text = "Search"
        '
        'lblTransferPaymentDocumentsInfo
        '
        Me.lblTransferPaymentDocumentsInfo.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblTransferPaymentDocumentsInfo.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransferPaymentDocumentsInfo.Appearance.ForeColor = System.Drawing.Color.Chocolate
        Me.lblTransferPaymentDocumentsInfo.Appearance.Options.UseBackColor = True
        Me.lblTransferPaymentDocumentsInfo.Appearance.Options.UseFont = True
        Me.lblTransferPaymentDocumentsInfo.Appearance.Options.UseForeColor = True
        Me.lblTransferPaymentDocumentsInfo.Location = New System.Drawing.Point(18, 14)
        Me.lblTransferPaymentDocumentsInfo.Name = "lblTransferPaymentDocumentsInfo"
        Me.lblTransferPaymentDocumentsInfo.Size = New System.Drawing.Size(95, 21)
        Me.lblTransferPaymentDocumentsInfo.TabIndex = 74
        Me.lblTransferPaymentDocumentsInfo.Text = "Transfer Payment Documents"
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
        Me.GridView1.GridControl = Me.TransferPaymentsDataGridView
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.SearchInPreview = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'TransferPaymentsDataGridView
        '
        Me.TransferPaymentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransferPaymentsDataGridView.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferPaymentsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TransferPaymentsDataGridView.MainView = Me.GridView1
        Me.TransferPaymentsDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TransferPaymentsDataGridView.Name = "TransferPaymentsDataGridView"
        Me.TransferPaymentsDataGridView.Size = New System.Drawing.Size(913, 740)
        Me.TransferPaymentsDataGridView.TabIndex = 23
        Me.TransferPaymentsDataGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BottomStatusStrip
        '
        Me.BottomStatusStrip.BackColor = System.Drawing.Color.Transparent
        Me.BottomStatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BottomStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoofRecordsLabelToolStripStatusLabel, Me.NoofRecordsToolStripStatusLabel, Me.lblInformation})
        Me.BottomStatusStrip.Location = New System.Drawing.Point(2, 810)
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
        Me.cmdClosePanelNew.Location = New System.Drawing.Point(889, 2)
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
        Me.PanelBody.Controls.Add(Me.PanelSearchByDate)
        Me.PanelBody.Controls.Add(Me.PanelNew)
        Me.PanelBody.Controls.Add(Me.BottomStatusStrip)
        Me.PanelBody.Controls.Add(Me.SplitContainerControl1)
        Me.PanelBody.Controls.Add(Me.TopMenuStrip)
        Me.PanelBody.Controls.Add(Me.PanelExporting)
        Me.PanelBody.Controls.Add(Me.TopToolStrip)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(0, 0)
        Me.PanelBody.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(1184, 838)
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
        Me.PanelNew.Controls.Add(Me.cmdPrintReceipt)
        Me.PanelNew.Controls.Add(Me.GroupControl2)
        Me.PanelNew.Controls.Add(Me.GroupControl1)
        Me.PanelNew.Controls.Add(Me.XtraTabControlRelated)
        Me.PanelNew.Controls.Add(Me.cmdClosePanelNew)
        Me.PanelNew.Controls.Add(Me.lblFormName)
        Me.PanelNew.Location = New System.Drawing.Point(77, 95)
        Me.PanelNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelNew.Name = "PanelNew"
        Me.PanelNew.Size = New System.Drawing.Size(925, 702)
        Me.PanelNew.TabIndex = 99
        Me.PanelNew.Visible = False
        '
        'cmdPrintReceipt
        '
        Me.cmdPrintReceipt.Enabled = False
        Me.cmdPrintReceipt.ImageOptions.Image = CType(resources.GetObject("cmdPrintReceipt.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdPrintReceipt.Location = New System.Drawing.Point(15, 618)
        Me.cmdPrintReceipt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPrintReceipt.Name = "cmdPrintReceipt"
        Me.cmdPrintReceipt.Size = New System.Drawing.Size(462, 37)
        Me.cmdPrintReceipt.TabIndex = 64
        Me.cmdPrintReceipt.Text = "Print Payment Receipt"
        '
        'GroupControl2
        '
        Me.GroupControl2.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl2.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl2.Controls.Add(Me.DiscountTextBox)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Controls.Add(Me.IPaymentIDTextBox)
        Me.GroupControl2.Controls.Add(Me.GeneratedTransferNoGridBox)
        Me.GroupControl2.Controls.Add(Me.PaidByTextBox)
        Me.GroupControl2.Controls.Add(Me.PaymentDateDateTimePicker)
        Me.GroupControl2.Controls.Add(Me.CurrentAmountTextBox)
        Me.GroupControl2.Controls.Add(Me.AmountPaidTextBox)
        Me.GroupControl2.Controls.Add(Me.BalanceTextBox)
        Me.GroupControl2.Controls.Add(Me.RefChequeNoTextBox)
        Me.GroupControl2.Controls.Add(Me.CommentTextBox)
        Me.GroupControl2.Controls.Add(Me.IPaymentIDLabel)
        Me.GroupControl2.Controls.Add(Me.GeneratedTransferNoLabel)
        Me.GroupControl2.Controls.Add(Me.PaidByLabel)
        Me.GroupControl2.Controls.Add(Me.PaymentDateLabel)
        Me.GroupControl2.Controls.Add(Me.CurrentAmountLabel)
        Me.GroupControl2.Controls.Add(Me.AmountPaidLabel)
        Me.GroupControl2.Controls.Add(Me.BalanceLabel)
        Me.GroupControl2.Controls.Add(Me.PaymentModeLabel)
        Me.GroupControl2.Controls.Add(Me.RefChequeNoLabel)
        Me.GroupControl2.Controls.Add(Me.BankLabel)
        Me.GroupControl2.Controls.Add(Me.CommentLabel)
        Me.GroupControl2.Controls.Add(Me.PaymentModeTextBox)
        Me.GroupControl2.Controls.Add(Me.BankTextBox)
        Me.GroupControl2.Location = New System.Drawing.Point(15, 60)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(462, 431)
        Me.GroupControl2.TabIndex = 58
        Me.GroupControl2.Text = "Details of Payment"
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.EnterMoveNextControl = True
        Me.DiscountTextBox.Location = New System.Drawing.Point(187, 230)
        Me.DiscountTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.DiscountTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.DiscountTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.DiscountTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.DiscountTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DiscountTextBox.Size = New System.Drawing.Size(255, 24)
        Me.DiscountTextBox.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(22, 235)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Discount:"
        '
        'PaymentModeTextBox
        '
        Me.PaymentModeTextBox.Location = New System.Drawing.Point(187, 295)
        Me.PaymentModeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PaymentModeTextBox.Name = "PaymentModeTextBox"
        Me.PaymentModeTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.PaymentModeTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.PaymentModeTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.PaymentModeTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.PaymentModeTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PaymentModeTextBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PaymentModeTextBox.Properties.Items.AddRange(New Object() {"CHEQUE", "CASH", "BANK TRANSFER"})
        Me.PaymentModeTextBox.Size = New System.Drawing.Size(255, 24)
        Me.PaymentModeTextBox.TabIndex = 1
        '
        'BankTextBox
        '
        Me.BankTextBox.Location = New System.Drawing.Point(187, 359)
        Me.BankTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BankTextBox.Name = "BankTextBox"
        Me.BankTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BankTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.BankTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.BankTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.BankTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BankTextBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BankTextBox.Properties.Items.AddRange(New Object() {"SLCB", "GTB", "UTB", "FIBank", "RCB", "Standard Chartered", "KeyStone", "Access"})
        Me.BankTextBox.Size = New System.Drawing.Size(255, 24)
        Me.BankTextBox.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl1.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.RegDateTextBox)
        Me.GroupControl1.Controls.Add(Me.InputedByTextBox)
        Me.GroupControl1.Controls.Add(Me.RegDateLabel)
        Me.GroupControl1.Controls.Add(Me.InputedByLabel)
        Me.GroupControl1.Location = New System.Drawing.Point(15, 497)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(465, 112)
        Me.GroupControl1.TabIndex = 57
        Me.GroupControl1.Text = "GroupControl1"
        '
        'lblFormName
        '
        Me.lblFormName.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblFormName.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormName.Appearance.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblFormName.Appearance.Options.UseBackColor = True
        Me.lblFormName.Appearance.Options.UseFont = True
        Me.lblFormName.Appearance.Options.UseForeColor = True
        Me.lblFormName.Location = New System.Drawing.Point(15, 21)
        Me.lblFormName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(221, 34)
        Me.lblFormName.TabIndex = 1
        Me.lblFormName.Text = "Transfer Payments"
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
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.TransferPaymentsDataGridView)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.VGridControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1177, 740)
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
        Me.VGridControl1.Size = New System.Drawing.Size(258, 740)
        Me.VGridControl1.TabIndex = 0
        '
        'PanelExporting
        '
        Me.PanelExporting.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PanelExporting.Appearance.Options.UseForeColor = True
        Me.PanelExporting.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelExporting.Controls.Add(Me.PanelProgressbarContainer)
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
        'frmTransferPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 838)
        Me.Controls.Add(Me.PanelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmTransferPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "TransferPayments"
        CType(Me.PanelSearchByDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSearchByDate.ResumeLayout(False)
        Me.PanelSearchByDate.PerformLayout()
        CType(Me.EndDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchDateFieldComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IPaymentIDTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneratedTransferNoGridBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaidByTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentDateDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentDateDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentAmountTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmountPaidTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefChequeNoTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegDateTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputedByTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControlRelated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControlRelated.ResumeLayout(False)
        Me.XtraTabPageTransferPaymentDocuments.ResumeLayout(False)
        Me.XtraTabPageTransferPaymentDocuments.PerformLayout()
        CType(Me.TransferPaymentDocumentsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTransferPaymentDocuments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripTransferPaymentDocuments.ResumeLayout(False)
        Me.ToolStripTransferPaymentDocuments.PerformLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferPaymentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.DiscountTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentModeTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents IPaymentIDTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GeneratedTransferNoGridBox As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents PaidByTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PaymentDateDateTimePicker As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CurrentAmountTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AmountPaidTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BalanceTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RefChequeNoTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CommentTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RegDateTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents InputedByTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IPaymentIDLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GeneratedTransferNoLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PaidByLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PaymentDateLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CurrentAmountLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AmountPaidLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BalanceLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PaymentModeLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RefChequeNoLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BankLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CommentLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RegDateLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents InputedByLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IPaymentIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneratedTransferNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaidByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountPaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentModeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefChequeNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents TransferPaymentsDataGridView As DevExpress.XtraGrid.GridControl
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
    Friend WithEvents ToolStripTransferPaymentDocuments As System.Windows.Forms.ToolStrip
    Friend WithEvents XtraTabPageTransferPaymentDocuments As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblTransferPaymentDocumentsInfo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdOpenRecordTransferPaymentDocuments As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAddTransferPaymentDocuments As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRemoveTransferPaymentDocuments As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSearchTransferPaymentDocuments As System.Windows.Forms.ToolStripButton
    Friend WithEvents TransferPaymentDocumentsGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTransferPaymentDocuments As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdExploreAllTransferPaymentDocuments As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDownloadTransferPaymentDocuments As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdOpenTransferPaymentDocuments As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PaymentModeTextBox As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BankTextBox As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmdPrintReceipt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DiscountTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
