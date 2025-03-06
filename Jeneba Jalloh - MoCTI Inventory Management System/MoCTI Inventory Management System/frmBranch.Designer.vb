<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBranch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBranch))
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
        Me.BranchIDLabel = New DevExpress.XtraEditors.LabelControl()
        Me.BranchNameLabel = New DevExpress.XtraEditors.LabelControl()
        Me.BranchCityLabel = New DevExpress.XtraEditors.LabelControl()
        Me.BranchAddressLabel = New DevExpress.XtraEditors.LabelControl()
        Me.BranchPhoneNoLabel = New DevExpress.XtraEditors.LabelControl()
        Me.RegDateLabel = New DevExpress.XtraEditors.LabelControl()
        Me.InputedByLabel = New DevExpress.XtraEditors.LabelControl()
        Me.BranchIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchCityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchPhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchIDTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.BranchNameTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.BranchCityTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.BranchAddressTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.BranchPhoneNoTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.RegDateTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.InputedByTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SearchToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BranchDataGridView = New DevExpress.XtraGrid.GridControl()
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
        CType(Me.PanelSearchByDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSearchByDate.SuspendLayout()
        CType(Me.EndDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchDateFieldComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchIDTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchNameTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchCityTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchAddressTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchPhoneNoTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegDateTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputedByTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'BranchIDLabel
        '
        Me.BranchIDLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BranchIDLabel.Appearance.Options.UseFont = True
        Me.BranchIDLabel.Location = New System.Drawing.Point(28, 62)
        Me.BranchIDLabel.Name = "BranchIDLabel"
        Me.BranchIDLabel.Size = New System.Drawing.Size(57, 15)
        Me.BranchIDLabel.TabIndex = 1
        Me.BranchIDLabel.Text = "Branch ID:"
        '
        'BranchNameLabel
        '
        Me.BranchNameLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BranchNameLabel.Appearance.Options.UseFont = True
        Me.BranchNameLabel.Location = New System.Drawing.Point(28, 88)
        Me.BranchNameLabel.Name = "BranchNameLabel"
        Me.BranchNameLabel.Size = New System.Drawing.Size(76, 15)
        Me.BranchNameLabel.TabIndex = 1
        Me.BranchNameLabel.Text = "Branch Name:"
        '
        'BranchCityLabel
        '
        Me.BranchCityLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BranchCityLabel.Appearance.Options.UseFont = True
        Me.BranchCityLabel.Location = New System.Drawing.Point(28, 114)
        Me.BranchCityLabel.Name = "BranchCityLabel"
        Me.BranchCityLabel.Size = New System.Drawing.Size(66, 15)
        Me.BranchCityLabel.TabIndex = 1
        Me.BranchCityLabel.Text = "Branch City:"
        '
        'BranchAddressLabel
        '
        Me.BranchAddressLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BranchAddressLabel.Appearance.Options.UseFont = True
        Me.BranchAddressLabel.Location = New System.Drawing.Point(28, 140)
        Me.BranchAddressLabel.Name = "BranchAddressLabel"
        Me.BranchAddressLabel.Size = New System.Drawing.Size(89, 15)
        Me.BranchAddressLabel.TabIndex = 1
        Me.BranchAddressLabel.Text = "Branch Address:"
        '
        'BranchPhoneNoLabel
        '
        Me.BranchPhoneNoLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BranchPhoneNoLabel.Appearance.Options.UseFont = True
        Me.BranchPhoneNoLabel.Location = New System.Drawing.Point(28, 166)
        Me.BranchPhoneNoLabel.Name = "BranchPhoneNoLabel"
        Me.BranchPhoneNoLabel.Size = New System.Drawing.Size(97, 15)
        Me.BranchPhoneNoLabel.TabIndex = 1
        Me.BranchPhoneNoLabel.Text = "Branch Phone No:"
        '
        'RegDateLabel
        '
        Me.RegDateLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegDateLabel.Appearance.Options.UseFont = True
        Me.RegDateLabel.Location = New System.Drawing.Point(28, 218)
        Me.RegDateLabel.Name = "RegDateLabel"
        Me.RegDateLabel.Size = New System.Drawing.Size(50, 15)
        Me.RegDateLabel.TabIndex = 1
        Me.RegDateLabel.Text = "Reg Date:"
        '
        'InputedByLabel
        '
        Me.InputedByLabel.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputedByLabel.Appearance.Options.UseFont = True
        Me.InputedByLabel.Location = New System.Drawing.Point(28, 244)
        Me.InputedByLabel.Name = "InputedByLabel"
        Me.InputedByLabel.Size = New System.Drawing.Size(61, 15)
        Me.InputedByLabel.TabIndex = 1
        Me.InputedByLabel.Text = "Inputed By:"
        '
        'BranchIDDataGridViewTextBoxColumn
        '
        Me.BranchIDDataGridViewTextBoxColumn.DataPropertyName = "BranchID"
        Me.BranchIDDataGridViewTextBoxColumn.HeaderText = "BranchID"
        Me.BranchIDDataGridViewTextBoxColumn.Name = "BranchIDDataGridViewTextBoxColumn"
        Me.BranchIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BranchNameDataGridViewTextBoxColumn
        '
        Me.BranchNameDataGridViewTextBoxColumn.DataPropertyName = "BranchName"
        Me.BranchNameDataGridViewTextBoxColumn.HeaderText = "BranchName"
        Me.BranchNameDataGridViewTextBoxColumn.Name = "BranchNameDataGridViewTextBoxColumn"
        Me.BranchNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BranchCityDataGridViewTextBoxColumn
        '
        Me.BranchCityDataGridViewTextBoxColumn.DataPropertyName = "BranchCity"
        Me.BranchCityDataGridViewTextBoxColumn.HeaderText = "BranchCity"
        Me.BranchCityDataGridViewTextBoxColumn.Name = "BranchCityDataGridViewTextBoxColumn"
        Me.BranchCityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BranchAddressDataGridViewTextBoxColumn
        '
        Me.BranchAddressDataGridViewTextBoxColumn.DataPropertyName = "BranchAddress"
        Me.BranchAddressDataGridViewTextBoxColumn.HeaderText = "BranchAddress"
        Me.BranchAddressDataGridViewTextBoxColumn.Name = "BranchAddressDataGridViewTextBoxColumn"
        Me.BranchAddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BranchPhoneNoDataGridViewTextBoxColumn
        '
        Me.BranchPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "BranchPhoneNo"
        Me.BranchPhoneNoDataGridViewTextBoxColumn.HeaderText = "BranchPhoneNo"
        Me.BranchPhoneNoDataGridViewTextBoxColumn.Name = "BranchPhoneNoDataGridViewTextBoxColumn"
        Me.BranchPhoneNoDataGridViewTextBoxColumn.ReadOnly = True
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
        'BranchIDTextBox
        '
        Me.BranchIDTextBox.EnterMoveNextControl = True
        Me.BranchIDTextBox.Location = New System.Drawing.Point(140, 59)
        Me.BranchIDTextBox.Name = "BranchIDTextBox"
        Me.BranchIDTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BranchIDTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.BranchIDTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.BranchIDTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.BranchIDTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BranchIDTextBox.Properties.ReadOnly = True
        Me.BranchIDTextBox.Size = New System.Drawing.Size(166, 22)
        Me.BranchIDTextBox.TabIndex = 1
        '
        'BranchNameTextBox
        '
        Me.BranchNameTextBox.EnterMoveNextControl = True
        Me.BranchNameTextBox.Location = New System.Drawing.Point(140, 85)
        Me.BranchNameTextBox.Name = "BranchNameTextBox"
        Me.BranchNameTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BranchNameTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.BranchNameTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.BranchNameTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.BranchNameTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BranchNameTextBox.Size = New System.Drawing.Size(166, 22)
        Me.BranchNameTextBox.TabIndex = 1
        '
        'BranchCityTextBox
        '
        Me.BranchCityTextBox.EnterMoveNextControl = True
        Me.BranchCityTextBox.Location = New System.Drawing.Point(140, 111)
        Me.BranchCityTextBox.Name = "BranchCityTextBox"
        Me.BranchCityTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BranchCityTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.BranchCityTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.BranchCityTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.BranchCityTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BranchCityTextBox.Size = New System.Drawing.Size(166, 22)
        Me.BranchCityTextBox.TabIndex = 1
        '
        'BranchAddressTextBox
        '
        Me.BranchAddressTextBox.EnterMoveNextControl = True
        Me.BranchAddressTextBox.Location = New System.Drawing.Point(140, 137)
        Me.BranchAddressTextBox.Name = "BranchAddressTextBox"
        Me.BranchAddressTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BranchAddressTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.BranchAddressTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.BranchAddressTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.BranchAddressTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BranchAddressTextBox.Size = New System.Drawing.Size(166, 22)
        Me.BranchAddressTextBox.TabIndex = 1
        '
        'BranchPhoneNoTextBox
        '
        Me.BranchPhoneNoTextBox.EnterMoveNextControl = True
        Me.BranchPhoneNoTextBox.Location = New System.Drawing.Point(140, 163)
        Me.BranchPhoneNoTextBox.Name = "BranchPhoneNoTextBox"
        Me.BranchPhoneNoTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BranchPhoneNoTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.BranchPhoneNoTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.BranchPhoneNoTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.BranchPhoneNoTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BranchPhoneNoTextBox.Size = New System.Drawing.Size(166, 22)
        Me.BranchPhoneNoTextBox.TabIndex = 1
        '
        'RegDateTextBox
        '
        Me.RegDateTextBox.EnterMoveNextControl = True
        Me.RegDateTextBox.Location = New System.Drawing.Point(140, 215)
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
        'InputedByTextBox
        '
        Me.InputedByTextBox.EnterMoveNextControl = True
        Me.InputedByTextBox.Location = New System.Drawing.Point(140, 241)
        Me.InputedByTextBox.Name = "InputedByTextBox"
        Me.InputedByTextBox.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.RoyalBlue
        Me.InputedByTextBox.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Navy
        Me.InputedByTextBox.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.InputedByTextBox.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.InputedByTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.InputedByTextBox.Size = New System.Drawing.Size(166, 22)
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
        Me.GridView1.GridControl = Me.BranchDataGridView
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.SearchInPreview = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'BranchDataGridView
        '
        Me.BranchDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BranchDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.BranchDataGridView.MainView = Me.GridView1
        Me.BranchDataGridView.Name = "BranchDataGridView"
        Me.BranchDataGridView.Size = New System.Drawing.Size(783, 551)
        Me.BranchDataGridView.TabIndex = 23
        Me.BranchDataGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.PanelNew.Controls.Add(Me.BranchIDTextBox)
        Me.PanelNew.Controls.Add(Me.BranchNameTextBox)
        Me.PanelNew.Controls.Add(Me.BranchCityTextBox)
        Me.PanelNew.Controls.Add(Me.BranchAddressTextBox)
        Me.PanelNew.Controls.Add(Me.BranchPhoneNoTextBox)
        Me.PanelNew.Controls.Add(Me.RegDateTextBox)
        Me.PanelNew.Controls.Add(Me.InputedByTextBox)
        Me.PanelNew.Controls.Add(Me.BranchIDLabel)
        Me.PanelNew.Controls.Add(Me.BranchNameLabel)
        Me.PanelNew.Controls.Add(Me.BranchCityLabel)
        Me.PanelNew.Controls.Add(Me.BranchAddressLabel)
        Me.PanelNew.Controls.Add(Me.BranchPhoneNoLabel)
        Me.PanelNew.Controls.Add(Me.RegDateLabel)
        Me.PanelNew.Controls.Add(Me.InputedByLabel)
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
        Me.lblFormName.Size = New System.Drawing.Size(66, 26)
        Me.lblFormName.TabIndex = 1
        Me.lblFormName.Text = "Branch"
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
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.BranchDataGridView)
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
        Me.PanelProgressbar.Location = New System.Drawing.Point(0, 0)
        Me.PanelProgressbar.Name = "PanelProgressbar"
        Me.PanelProgressbar.Size = New System.Drawing.Size(10, 9)
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
        'frmBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 631)
        Me.Controls.Add(Me.PanelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBranch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Branch"
        CType(Me.PanelSearchByDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSearchByDate.ResumeLayout(False)
        Me.PanelSearchByDate.PerformLayout()
        CType(Me.EndDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateTimePicker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateTimePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchDateFieldComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchIDTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchNameTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchCityTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchAddressTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchPhoneNoTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegDateTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputedByTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BranchIDTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents BranchNameTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents BranchCityTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents BranchAddressTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents BranchPhoneNoTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents RegDateTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents InputedByTextBox As DevExpress.XtraEditors.TextEdit
Friend WithEvents BranchIDLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents BranchNameLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents BranchCityLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents BranchAddressLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents BranchPhoneNoLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents RegDateLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents InputedByLabel As DevExpress.XtraEditors.LabelControl
Friend WithEvents BranchIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents BranchNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents BranchCityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents BranchAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
Friend WithEvents BranchPhoneNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
Friend WithEvents BranchDataGridView As DevExpress.XtraGrid.GridControl
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
End Class
