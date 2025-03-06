<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransferPaymentDocuments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferPaymentDocuments))
        Me.cmdPrevious = New System.Windows.Forms.ToolStripButton()
        Me.cmdNext = New System.Windows.Forms.ToolStripButton()
        Me.PanelSelectaDocumentSource = New System.Windows.Forms.Panel()
        Me.cmdBrowseForFile = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdScanDocument = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdClosePanelDocumentSource = New DevExpress.XtraEditors.SimpleButton()
        Me.lblScanOperation = New DevExpress.XtraEditors.LabelControl()
        Me.lblOperation = New DevExpress.XtraEditors.LabelControl()
        Me.lblSelectaDocumentSource = New DevExpress.XtraEditors.LabelControl()
        Me.cmdDownloadFile = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdViewFile = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdRemoveFile = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAddFile = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdViewAllFiles = New DevExpress.XtraEditors.SimpleButton()
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
        Me.IDLabel = New DevExpress.XtraEditors.LabelControl()
        Me.IPaymentIDLabel = New DevExpress.XtraEditors.LabelControl()
        Me.FileTypeLabel = New DevExpress.XtraEditors.LabelControl()
        Me.FileNameLabel = New DevExpress.XtraEditors.LabelControl()
        Me.GeneratedFileNameLabel = New DevExpress.XtraEditors.LabelControl()
        Me.DocumentTypeLabel = New DevExpress.XtraEditors.LabelControl()
        Me.FileStatusLabel = New DevExpress.XtraEditors.LabelControl()
        Me.DescriptionLabel = New DevExpress.XtraEditors.LabelControl()
        Me.RegDateLabel = New DevExpress.XtraEditors.LabelControl()
        Me.InputtedByLabel = New DevExpress.XtraEditors.LabelControl()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPaymentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GeneratedFileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputtedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.IPaymentIDGridBox = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FileTypeTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.FileNameTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.GeneratedFileNameTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.DocumentTypeTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.FileStatusTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.RegDateTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.InputtedByTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SearchToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TransferPaymentDocumentsDataGridView = New DevExpress.XtraGrid.GridControl()
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
        Me.PanelSelectaDocumentSource.SuspendLayout()
        CType(Me.PanelSearchByDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSearchByDate.SuspendLayout()
        CType(Me.EndDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchDateFieldComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IPaymentIDGridBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileTypeTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileNameTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneratedFileNameTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentTypeTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileStatusTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegDateTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputtedByTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferPaymentDocumentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomStatusStrip.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.TopToolStrip.SuspendLayout()
        CType(Me.PanelBody, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBody.SuspendLayout()
        CType(Me.PanelNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNew.SuspendLayout()
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
        'PanelSelectaDocumentSource
        '
        Me.PanelSelectaDocumentSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSelectaDocumentSource.Controls.Add(Me.cmdBrowseForFile)
        Me.PanelSelectaDocumentSource.Controls.Add(Me.cmdScanDocument)
        Me.PanelSelectaDocumentSource.Controls.Add(Me.cmdClosePanelDocumentSource)
        Me.PanelSelectaDocumentSource.Controls.Add(Me.lblScanOperation)
        Me.PanelSelectaDocumentSource.Controls.Add(Me.lblOperation)
        Me.PanelSelectaDocumentSource.Controls.Add(Me.lblSelectaDocumentSource)
        Me.PanelSelectaDocumentSource.Location = New System.Drawing.Point(349, 206)
        Me.PanelSelectaDocumentSource.Name = "PanelSelectaDocumentSource"
        Me.PanelSelectaDocumentSource.Size = New System.Drawing.Size(286, 132)
        Me.PanelSelectaDocumentSource.TabIndex = 54
        Me.PanelSelectaDocumentSource.Visible = False
        '
        'cmdBrowseForFile
        '
        Me.cmdBrowseForFile.ImageOptions.Image = CType(resources.GetObject("cmdBrowseForFile.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdBrowseForFile.Location = New System.Drawing.Point(150, 64)
        Me.cmdBrowseForFile.Name = "cmdBrowseForFile"
        Me.cmdBrowseForFile.Size = New System.Drawing.Size(115, 28)
        Me.cmdBrowseForFile.TabIndex = 52
        Me.cmdBrowseForFile.Text = "Browse for File"
        Me.cmdBrowseForFile.ToolTip = "Click here to add a new document as an update to the currently selected file"
        '
        'cmdScanDocument
        '
        Me.cmdScanDocument.ImageOptions.Image = CType(resources.GetObject("cmdScanDocument.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdScanDocument.Location = New System.Drawing.Point(23, 64)
        Me.cmdScanDocument.Name = "cmdScanDocument"
        Me.cmdScanDocument.Size = New System.Drawing.Size(121, 28)
        Me.cmdScanDocument.TabIndex = 52
        Me.cmdScanDocument.Text = "Scan Document"
        Me.cmdScanDocument.ToolTip = "Click here to add a new document to this archieve."
        '
        'cmdClosePanelDocumentSource
        '
        Me.cmdClosePanelDocumentSource.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClosePanelDocumentSource.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClosePanelDocumentSource.Appearance.Options.UseFont = True
        Me.cmdClosePanelDocumentSource.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cmdClosePanelDocumentSource.Location = New System.Drawing.Point(256, -1)
        Me.cmdClosePanelDocumentSource.Name = "cmdClosePanelDocumentSource"
        Me.cmdClosePanelDocumentSource.Size = New System.Drawing.Size(29, 28)
        Me.cmdClosePanelDocumentSource.TabIndex = 49
        Me.cmdClosePanelDocumentSource.Text = "X"
        '
        'lblScanOperation
        '
        Me.lblScanOperation.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblScanOperation.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScanOperation.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblScanOperation.Appearance.Options.UseBackColor = True
        Me.lblScanOperation.Appearance.Options.UseFont = True
        Me.lblScanOperation.Appearance.Options.UseForeColor = True
        Me.lblScanOperation.Location = New System.Drawing.Point(72, 30)
        Me.lblScanOperation.Name = "lblScanOperation"
        Me.lblScanOperation.Size = New System.Drawing.Size(143, 18)
        Me.lblScanOperation.TabIndex = 1
        Me.lblScanOperation.Text = "Adding New Document"
        '
        'lblOperation
        '
        Me.lblOperation.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblOperation.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperation.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblOperation.Appearance.Options.UseBackColor = True
        Me.lblOperation.Appearance.Options.UseFont = True
        Me.lblOperation.Appearance.Options.UseForeColor = True
        Me.lblOperation.Location = New System.Drawing.Point(8, 32)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(59, 15)
        Me.lblOperation.TabIndex = 1
        Me.lblOperation.Text = "Operation:"
        '
        'lblSelectaDocumentSource
        '
        Me.lblSelectaDocumentSource.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblSelectaDocumentSource.Appearance.Font = New System.Drawing.Font("Franklin Gothic Demi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectaDocumentSource.Appearance.ForeColor = System.Drawing.Color.Chocolate
        Me.lblSelectaDocumentSource.Appearance.Options.UseBackColor = True
        Me.lblSelectaDocumentSource.Appearance.Options.UseFont = True
        Me.lblSelectaDocumentSource.Appearance.Options.UseForeColor = True
        Me.lblSelectaDocumentSource.Location = New System.Drawing.Point(8, 8)
        Me.lblSelectaDocumentSource.Name = "lblSelectaDocumentSource"
        Me.lblSelectaDocumentSource.Size = New System.Drawing.Size(175, 20)
        Me.lblSelectaDocumentSource.TabIndex = 1
        Me.lblSelectaDocumentSource.Text = "Select a Document Source"
        '
        'cmdDownloadFile
        '
        Me.cmdDownloadFile.Enabled = False
        Me.cmdDownloadFile.ImageOptions.Image = CType(resources.GetObject("cmdDownloadFile.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdDownloadFile.Location = New System.Drawing.Point(400, 167)
        Me.cmdDownloadFile.Name = "cmdDownloadFile"
        Me.cmdDownloadFile.Size = New System.Drawing.Size(150, 31)
        Me.cmdDownloadFile.TabIndex = 49
        Me.cmdDownloadFile.Text = "Download"
        '
        'cmdViewFile
        '
        Me.cmdViewFile.Enabled = False
        Me.cmdViewFile.ImageOptions.Image = CType(resources.GetObject("cmdViewFile.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdViewFile.Location = New System.Drawing.Point(400, 130)
        Me.cmdViewFile.Name = "cmdViewFile"
        Me.cmdViewFile.Size = New System.Drawing.Size(150, 31)
        Me.cmdViewFile.TabIndex = 49
        Me.cmdViewFile.Text = "View File"
        '
        'cmdRemoveFile
        '
        Me.cmdRemoveFile.Enabled = False
        Me.cmdRemoveFile.ImageOptions.Image = CType(resources.GetObject("cmdRemoveFile.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdRemoveFile.Location = New System.Drawing.Point(400, 93)
        Me.cmdRemoveFile.Name = "cmdRemoveFile"
        Me.cmdRemoveFile.Size = New System.Drawing.Size(150, 31)
        Me.cmdRemoveFile.TabIndex = 49
        Me.cmdRemoveFile.Text = "Remove File"
        '
        'cmdAddFile
        '
        Me.cmdAddFile.ImageOptions.Image = CType(resources.GetObject("cmdAddFile.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAddFile.Location = New System.Drawing.Point(400, 56)
        Me.cmdAddFile.Name = "cmdAddFile"
        Me.cmdAddFile.Size = New System.Drawing.Size(150, 31)
        Me.cmdAddFile.TabIndex = 49
        Me.cmdAddFile.Text = "Add File"
        '
        'cmdViewAllFiles
        '
        Me.cmdViewAllFiles.Enabled = False
        Me.cmdViewAllFiles.ImageOptions.Image = CType(resources.GetObject("cmdViewAllFiles.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdViewAllFiles.Location = New System.Drawing.Point(400, 204)
        Me.cmdViewAllFiles.Name = "cmdViewAllFiles"
        Me.cmdViewAllFiles.Size = New System.Drawing.Size(150, 31)
        Me.cmdViewAllFiles.TabIndex = 55
        Me.cmdViewAllFiles.Text = "View All Related Files"
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
        'IDLabel
        '
        Me.IDLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLabel.Appearance.Options.UseFont = True
        Me.IDLabel.Location = New System.Drawing.Point(28, 62)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(15, 15)
        Me.IDLabel.TabIndex = 1
        Me.IDLabel.Text = "ID:"
        '
        'IPaymentIDLabel
        '
        Me.IPaymentIDLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPaymentIDLabel.Appearance.Options.UseFont = True
        Me.IPaymentIDLabel.Location = New System.Drawing.Point(28, 88)
        Me.IPaymentIDLabel.Name = "IPaymentIDLabel"
        Me.IPaymentIDLabel.Size = New System.Drawing.Size(69, 15)
        Me.IPaymentIDLabel.TabIndex = 1
        Me.IPaymentIDLabel.Text = "IPayment ID:"
        '
        'FileTypeLabel
        '
        Me.FileTypeLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileTypeLabel.Appearance.Options.UseFont = True
        Me.FileTypeLabel.Location = New System.Drawing.Point(28, 114)
        Me.FileTypeLabel.Name = "FileTypeLabel"
        Me.FileTypeLabel.Size = New System.Drawing.Size(51, 15)
        Me.FileTypeLabel.TabIndex = 1
        Me.FileTypeLabel.Text = "File Type:"
        '
        'FileNameLabel
        '
        Me.FileNameLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileNameLabel.Appearance.Options.UseFont = True
        Me.FileNameLabel.Location = New System.Drawing.Point(28, 140)
        Me.FileNameLabel.Name = "FileNameLabel"
        Me.FileNameLabel.Size = New System.Drawing.Size(57, 15)
        Me.FileNameLabel.TabIndex = 1
        Me.FileNameLabel.Text = "File Name:"
        '
        'GeneratedFileNameLabel
        '
        Me.GeneratedFileNameLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneratedFileNameLabel.Appearance.Options.UseFont = True
        Me.GeneratedFileNameLabel.Location = New System.Drawing.Point(28, 166)
        Me.GeneratedFileNameLabel.Name = "GeneratedFileNameLabel"
        Me.GeneratedFileNameLabel.Size = New System.Drawing.Size(116, 15)
        Me.GeneratedFileNameLabel.TabIndex = 1
        Me.GeneratedFileNameLabel.Text = "Generated File Name:"
        '
        'DocumentTypeLabel
        '
        Me.DocumentTypeLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentTypeLabel.Appearance.Options.UseFont = True
        Me.DocumentTypeLabel.Location = New System.Drawing.Point(28, 192)
        Me.DocumentTypeLabel.Name = "DocumentTypeLabel"
        Me.DocumentTypeLabel.Size = New System.Drawing.Size(86, 15)
        Me.DocumentTypeLabel.TabIndex = 1
        Me.DocumentTypeLabel.Text = "Document Type:"
        '
        'FileStatusLabel
        '
        Me.FileStatusLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileStatusLabel.Appearance.Options.UseFont = True
        Me.FileStatusLabel.Location = New System.Drawing.Point(28, 218)
        Me.FileStatusLabel.Name = "FileStatusLabel"
        Me.FileStatusLabel.Size = New System.Drawing.Size(60, 15)
        Me.FileStatusLabel.TabIndex = 1
        Me.FileStatusLabel.Text = "File Status:"
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Appearance.Options.UseFont = True
        Me.DescriptionLabel.Location = New System.Drawing.Point(28, 244)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(67, 15)
        Me.DescriptionLabel.TabIndex = 1
        Me.DescriptionLabel.Text = "Description:"
        '
        'RegDateLabel
        '
        Me.RegDateLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegDateLabel.Appearance.Options.UseFont = True
        Me.RegDateLabel.Location = New System.Drawing.Point(28, 286)
        Me.RegDateLabel.Name = "RegDateLabel"
        Me.RegDateLabel.Size = New System.Drawing.Size(50, 15)
        Me.RegDateLabel.TabIndex = 1
        Me.RegDateLabel.Text = "Reg Date:"
        '
        'InputtedByLabel
        '
        Me.InputtedByLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputtedByLabel.Appearance.Options.UseFont = True
        Me.InputtedByLabel.Location = New System.Drawing.Point(28, 312)
        Me.InputtedByLabel.Name = "InputtedByLabel"
        Me.InputtedByLabel.Size = New System.Drawing.Size(65, 15)
        Me.InputtedByLabel.TabIndex = 1
        Me.InputtedByLabel.Text = "Inputted By:"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IPaymentIDDataGridViewTextBoxColumn
        '
        Me.IPaymentIDDataGridViewTextBoxColumn.DataPropertyName = "IPaymentID"
        Me.IPaymentIDDataGridViewTextBoxColumn.HeaderText = "IPaymentID"
        Me.IPaymentIDDataGridViewTextBoxColumn.Name = "IPaymentIDDataGridViewTextBoxColumn"
        Me.IPaymentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FileTypeDataGridViewTextBoxColumn
        '
        Me.FileTypeDataGridViewTextBoxColumn.DataPropertyName = "FileType"
        Me.FileTypeDataGridViewTextBoxColumn.HeaderText = "FileType"
        Me.FileTypeDataGridViewTextBoxColumn.Name = "FileTypeDataGridViewTextBoxColumn"
        Me.FileTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FileNameDataGridViewTextBoxColumn
        '
        Me.FileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName"
        Me.FileNameDataGridViewTextBoxColumn.HeaderText = "FileName"
        Me.FileNameDataGridViewTextBoxColumn.Name = "FileNameDataGridViewTextBoxColumn"
        Me.FileNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GeneratedFileNameDataGridViewTextBoxColumn
        '
        Me.GeneratedFileNameDataGridViewTextBoxColumn.DataPropertyName = "GeneratedFileName"
        Me.GeneratedFileNameDataGridViewTextBoxColumn.HeaderText = "GeneratedFileName"
        Me.GeneratedFileNameDataGridViewTextBoxColumn.Name = "GeneratedFileNameDataGridViewTextBoxColumn"
        Me.GeneratedFileNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocumentTypeDataGridViewTextBoxColumn
        '
        Me.DocumentTypeDataGridViewTextBoxColumn.DataPropertyName = "DocumentType"
        Me.DocumentTypeDataGridViewTextBoxColumn.HeaderText = "DocumentType"
        Me.DocumentTypeDataGridViewTextBoxColumn.Name = "DocumentTypeDataGridViewTextBoxColumn"
        Me.DocumentTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FileStatusDataGridViewTextBoxColumn
        '
        Me.FileStatusDataGridViewTextBoxColumn.DataPropertyName = "FileStatus"
        Me.FileStatusDataGridViewTextBoxColumn.HeaderText = "FileStatus"
        Me.FileStatusDataGridViewTextBoxColumn.Name = "FileStatusDataGridViewTextBoxColumn"
        Me.FileStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RegDateDataGridViewTextBoxColumn
        '
        Me.RegDateDataGridViewTextBoxColumn.DataPropertyName = "RegDate"
        Me.RegDateDataGridViewTextBoxColumn.HeaderText = "RegDate"
        Me.RegDateDataGridViewTextBoxColumn.Name = "RegDateDataGridViewTextBoxColumn"
        Me.RegDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InputtedByDataGridViewTextBoxColumn
        '
        Me.InputtedByDataGridViewTextBoxColumn.DataPropertyName = "InputtedBy"
        Me.InputtedByDataGridViewTextBoxColumn.HeaderText = "InputtedBy"
        Me.InputtedByDataGridViewTextBoxColumn.Name = "InputtedByDataGridViewTextBoxColumn"
        Me.InputtedByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDTextBox
        '
        Me.IDTextBox.EnterMoveNextControl = True
        Me.IDTextBox.Location = New System.Drawing.Point(155, 59)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.IDTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.IDTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.IDTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.IDTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.IDTextBox.Properties.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(166, 22)
        Me.IDTextBox.TabIndex = 1
        '
        'IPaymentIDGridBox
        '
        Me.IPaymentIDGridBox.Location = New System.Drawing.Point(155, 85)
        Me.IPaymentIDGridBox.Name = "IPaymentIDGridBox"
        Me.IPaymentIDGridBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.IPaymentIDGridBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IPaymentIDGridBox.Properties.NullText = ""
        Me.IPaymentIDGridBox.Size = New System.Drawing.Size(166, 22)
        Me.IPaymentIDGridBox.TabIndex = 1
        '
        'FileTypeTextBox
        '
        Me.FileTypeTextBox.EnterMoveNextControl = True
        Me.FileTypeTextBox.Location = New System.Drawing.Point(155, 111)
        Me.FileTypeTextBox.Name = "FileTypeTextBox"
        Me.FileTypeTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.FileTypeTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.FileTypeTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.FileTypeTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.FileTypeTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.FileTypeTextBox.Size = New System.Drawing.Size(166, 22)
        Me.FileTypeTextBox.TabIndex = 1
        '
        'FileNameTextBox
        '
        Me.FileNameTextBox.EnterMoveNextControl = True
        Me.FileNameTextBox.Location = New System.Drawing.Point(155, 137)
        Me.FileNameTextBox.Name = "FileNameTextBox"
        Me.FileNameTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.FileNameTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.FileNameTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.FileNameTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.FileNameTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.FileNameTextBox.Size = New System.Drawing.Size(166, 22)
        Me.FileNameTextBox.TabIndex = 1
        '
        'GeneratedFileNameTextBox
        '
        Me.GeneratedFileNameTextBox.EnterMoveNextControl = True
        Me.GeneratedFileNameTextBox.Location = New System.Drawing.Point(155, 163)
        Me.GeneratedFileNameTextBox.Name = "GeneratedFileNameTextBox"
        Me.GeneratedFileNameTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.GeneratedFileNameTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.GeneratedFileNameTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.GeneratedFileNameTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.GeneratedFileNameTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.GeneratedFileNameTextBox.Size = New System.Drawing.Size(166, 22)
        Me.GeneratedFileNameTextBox.TabIndex = 1
        '
        'DocumentTypeTextBox
        '
        Me.DocumentTypeTextBox.EnterMoveNextControl = True
        Me.DocumentTypeTextBox.Location = New System.Drawing.Point(155, 189)
        Me.DocumentTypeTextBox.Name = "DocumentTypeTextBox"
        Me.DocumentTypeTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.DocumentTypeTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.DocumentTypeTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.DocumentTypeTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.DocumentTypeTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DocumentTypeTextBox.Size = New System.Drawing.Size(166, 22)
        Me.DocumentTypeTextBox.TabIndex = 1
        '
        'FileStatusTextBox
        '
        Me.FileStatusTextBox.EnterMoveNextControl = True
        Me.FileStatusTextBox.Location = New System.Drawing.Point(155, 215)
        Me.FileStatusTextBox.Name = "FileStatusTextBox"
        Me.FileStatusTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.FileStatusTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.FileStatusTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.FileStatusTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.FileStatusTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.FileStatusTextBox.Size = New System.Drawing.Size(166, 22)
        Me.FileStatusTextBox.TabIndex = 1
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.EnterMoveNextControl = True
        Me.DescriptionTextBox.Location = New System.Drawing.Point(155, 241)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.DescriptionTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.DescriptionTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.DescriptionTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.DescriptionTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DescriptionTextBox.Size = New System.Drawing.Size(166, 22)
        Me.DescriptionTextBox.TabIndex = 1
        '
        'RegDateTextBox
        '
        Me.RegDateTextBox.EnterMoveNextControl = True
        Me.RegDateTextBox.Location = New System.Drawing.Point(155, 283)
        Me.RegDateTextBox.Name = "RegDateTextBox"
        Me.RegDateTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RegDateTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.RegDateTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.RegDateTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.RegDateTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RegDateTextBox.Properties.ReadOnly = True
        Me.RegDateTextBox.Size = New System.Drawing.Size(166, 22)
        Me.RegDateTextBox.TabIndex = 1
        '
        'InputtedByTextBox
        '
        Me.InputtedByTextBox.EnterMoveNextControl = True
        Me.InputtedByTextBox.Location = New System.Drawing.Point(155, 309)
        Me.InputtedByTextBox.Name = "InputtedByTextBox"
        Me.InputtedByTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.InputtedByTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.InputtedByTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.InputtedByTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.InputtedByTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.InputtedByTextBox.Size = New System.Drawing.Size(166, 22)
        Me.InputtedByTextBox.TabIndex = 1
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
        Me.GridView1.GridControl = Me.TransferPaymentDocumentsDataGridView
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.SearchInPreview = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'TransferPaymentDocumentsDataGridView
        '
        Me.TransferPaymentDocumentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransferPaymentDocumentsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TransferPaymentDocumentsDataGridView.MainView = Me.GridView1
        Me.TransferPaymentDocumentsDataGridView.Name = "TransferPaymentDocumentsDataGridView"
        Me.TransferPaymentDocumentsDataGridView.Size = New System.Drawing.Size(783, 551)
        Me.TransferPaymentDocumentsDataGridView.TabIndex = 23
        Me.TransferPaymentDocumentsDataGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.cmdClosePanelNew.Location = New System.Drawing.Point(715, 2)
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
        Me.PanelNew.Controls.Add(Me.cmdClosePanelNew)
        Me.PanelNew.Controls.Add(Me.lblFormName)
        Me.PanelNew.Controls.Add(Me.PanelSelectaDocumentSource)
        Me.PanelNew.Controls.Add(Me.cmdDownloadFile)
        Me.PanelNew.Controls.Add(Me.cmdViewFile)
        Me.PanelNew.Controls.Add(Me.cmdRemoveFile)
        Me.PanelNew.Controls.Add(Me.cmdAddFile)
        Me.PanelNew.Controls.Add(Me.IDTextBox)
        Me.PanelNew.Controls.Add(Me.IPaymentIDGridBox)
        Me.PanelNew.Controls.Add(Me.FileTypeTextBox)
        Me.PanelNew.Controls.Add(Me.FileNameTextBox)
        Me.PanelNew.Controls.Add(Me.GeneratedFileNameTextBox)
        Me.PanelNew.Controls.Add(Me.DocumentTypeTextBox)
        Me.PanelNew.Controls.Add(Me.FileStatusTextBox)
        Me.PanelNew.Controls.Add(Me.DescriptionTextBox)
        Me.PanelNew.Controls.Add(Me.RegDateTextBox)
        Me.PanelNew.Controls.Add(Me.InputtedByTextBox)
        Me.PanelNew.Controls.Add(Me.IDLabel)
        Me.PanelNew.Controls.Add(Me.IPaymentIDLabel)
        Me.PanelNew.Controls.Add(Me.FileTypeLabel)
        Me.PanelNew.Controls.Add(Me.FileNameLabel)
        Me.PanelNew.Controls.Add(Me.GeneratedFileNameLabel)
        Me.PanelNew.Controls.Add(Me.DocumentTypeLabel)
        Me.PanelNew.Controls.Add(Me.FileStatusLabel)
        Me.PanelNew.Controls.Add(Me.DescriptionLabel)
        Me.PanelNew.Controls.Add(Me.RegDateLabel)
        Me.PanelNew.Controls.Add(Me.InputtedByLabel)
        Me.PanelNew.Location = New System.Drawing.Point(113, 77)
        Me.PanelNew.Name = "PanelNew"
        Me.PanelNew.Size = New System.Drawing.Size(746, 444)
        Me.PanelNew.TabIndex = 99
        Me.PanelNew.Visible = False
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
        Me.lblFormName.Size = New System.Drawing.Size(260, 26)
        Me.lblFormName.TabIndex = 1
        Me.lblFormName.Text = "Transfer Payment Documents"
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
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.TransferPaymentDocumentsDataGridView)
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
        'frmTransferPaymentDocuments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 631)
        Me.Controls.Add(Me.PanelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransferPaymentDocuments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "TransferPaymentDocuments"
        Me.PanelSelectaDocumentSource.ResumeLayout(False)
        Me.PanelSelectaDocumentSource.PerformLayout()
        CType(Me.PanelSearchByDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSearchByDate.ResumeLayout(False)
        Me.PanelSearchByDate.PerformLayout()
        CType(Me.EndDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchDateFieldComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IPaymentIDGridBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileTypeTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileNameTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneratedFileNameTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentTypeTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileStatusTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegDateTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputtedByTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferPaymentDocumentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents IDTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IPaymentIDGridBox As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents FileTypeTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FileNameTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GeneratedFileNameTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DocumentTypeTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FileStatusTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RegDateTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents InputtedByTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IPaymentIDLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FileTypeLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FileNameLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GeneratedFileNameLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DocumentTypeLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FileStatusLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DescriptionLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RegDateLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents InputtedByLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IPaymentIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GeneratedFileNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InputtedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents TransferPaymentDocumentsDataGridView As DevExpress.XtraGrid.GridControl
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
    Friend WithEvents cmdDownloadFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdViewFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRemoveFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAddFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelSelectaDocumentSource As Panel
    Friend WithEvents cmdBrowseForFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdScanDocument As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClosePanelDocumentSource As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblScanOperation As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblOperation As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSelectaDocumentSource As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdViewAllFiles As DevExpress.XtraEditors.SimpleButton
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
End Class
