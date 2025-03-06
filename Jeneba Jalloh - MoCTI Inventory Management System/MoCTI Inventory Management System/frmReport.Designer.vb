<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl()
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
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton()
        Me.chkRestrict = New System.Windows.Forms.CheckBox()
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.SearchDataGridView = New DevExpress.XtraGrid.GridControl()
        Me.cmdremove = New DevExpress.XtraEditors.SimpleButton()
        Me.lstFilter = New System.Windows.Forms.ListBox()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.gbDate = New DevExpress.XtraEditors.GroupControl()
        Me.ReportEndDateDateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label37 = New DevExpress.XtraEditors.LabelControl()
        Me.ReportStartDateDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label36 = New DevExpress.XtraEditors.LabelControl()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.cboDateField = New System.Windows.Forms.ComboBox()
        Me.cboTableName = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New DevExpress.XtraEditors.GroupControl()
        Me.radSummaryonly = New System.Windows.Forms.RadioButton()
        Me.radRecordlistonly = New System.Windows.Forms.RadioButton()
        Me.radRecordlistandSummary = New System.Windows.Forms.RadioButton()
        Me.txtReportTitle = New DevExpress.XtraEditors.TextEdit()
        Me.cmdreturn = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdmove = New DevExpress.XtraEditors.SimpleButton()
        Me.lstReport = New System.Windows.Forms.ListBox()
        Me.lstDatabase = New System.Windows.Forms.ListBox()
        Me.cmdPrintReport = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.lblFieldsRemaining = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblNoofRecords = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.Label34 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelHeader = New DevExpress.XtraEditors.PanelControl()
        Me.lblProjectName = New DevExpress.XtraEditors.LabelControl()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdMinimize = New DevExpress.XtraEditors.SimpleButton()
        Me.MyExportBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.PanelExporting.SuspendLayout()
        Me.PanelProgressbarContainer.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDate.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanelExporting)
        Me.Panel1.Controls.Add(Me.cmdExport)
        Me.Panel1.Controls.Add(Me.chkRestrict)
        Me.Panel1.Controls.Add(Me.cmdSearch)
        Me.Panel1.Controls.Add(Me.SearchDataGridView)
        Me.Panel1.Controls.Add(Me.cmdremove)
        Me.Panel1.Controls.Add(Me.lstFilter)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.gbDate)
        Me.Panel1.Controls.Add(Me.chkDate)
        Me.Panel1.Controls.Add(Me.cboDateField)
        Me.Panel1.Controls.Add(Me.cboTableName)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtReportTitle)
        Me.Panel1.Controls.Add(Me.cmdreturn)
        Me.Panel1.Controls.Add(Me.cmdmove)
        Me.Panel1.Controls.Add(Me.lstReport)
        Me.Panel1.Controls.Add(Me.lstDatabase)
        Me.Panel1.Controls.Add(Me.cmdPrintReport)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblFieldsRemaining)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblNoofRecords)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.PanelHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(949, 563)
        Me.Panel1.TabIndex = 1
        '
        'PanelExporting
        '
        Me.PanelExporting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelExporting.Controls.Add(Me.PanelProgressbarContainer)
        Me.PanelExporting.Controls.Add(Me.cmdCloseExport)
        Me.PanelExporting.Controls.Add(Me.lblExportPercentage)
        Me.PanelExporting.Controls.Add(Me.lblNoRows)
        Me.PanelExporting.Controls.Add(Me.lblNoValues)
        Me.PanelExporting.Controls.Add(Me.PictureBox2)
        Me.PanelExporting.Controls.Add(Me.lblExportStatus)
        Me.PanelExporting.Controls.Add(Me.Label26)
        Me.PanelExporting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PanelExporting.Location = New System.Drawing.Point(311, 204)
        Me.PanelExporting.Name = "PanelExporting"
        Me.PanelExporting.Size = New System.Drawing.Size(295, 134)
        Me.PanelExporting.TabIndex = 88
        Me.PanelExporting.Visible = False
        '
        'PanelProgressbarContainer
        '
        Me.PanelProgressbarContainer.Controls.Add(Me.PanelProgressbar)
        Me.PanelProgressbarContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelProgressbarContainer.Location = New System.Drawing.Point(0, 123)
        Me.PanelProgressbarContainer.Name = "PanelProgressbarContainer"
        Me.PanelProgressbarContainer.Size = New System.Drawing.Size(293, 9)
        Me.PanelProgressbarContainer.TabIndex = 59
        '
        'PanelProgressbar
        '
        Me.PanelProgressbar.BackColor = System.Drawing.Color.LimeGreen
        Me.PanelProgressbar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelProgressbar.Location = New System.Drawing.Point(0, 0)
        Me.PanelProgressbar.Name = "PanelProgressbar"
        Me.PanelProgressbar.Size = New System.Drawing.Size(10, 9)
        Me.PanelProgressbar.TabIndex = 0
        '
        'cmdCloseExport
        '
        Me.cmdCloseExport.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseExport.Location = New System.Drawing.Point(265, -1)
        Me.cmdCloseExport.Name = "cmdCloseExport"
        Me.cmdCloseExport.Size = New System.Drawing.Size(29, 28)
        Me.cmdCloseExport.TabIndex = 47
        Me.cmdCloseExport.Text = "X"
        '
        'lblExportPercentage
        '
        Me.lblExportPercentage.AutoSize = True
        Me.lblExportPercentage.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExportPercentage.Location = New System.Drawing.Point(186, 100)
        Me.lblExportPercentage.Name = "lblExportPercentage"
        Me.lblExportPercentage.Size = New System.Drawing.Size(83, 14)
        Me.lblExportPercentage.TabIndex = 57
        Me.lblExportPercentage.Text = "54% Complete"
        '
        'lblNoRows
        '
        Me.lblNoRows.AutoSize = True
        Me.lblNoRows.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoRows.Location = New System.Drawing.Point(9, 81)
        Me.lblNoRows.Name = "lblNoRows"
        Me.lblNoRows.Size = New System.Drawing.Size(90, 15)
        Me.lblNoRows.TabIndex = 57
        Me.lblNoRows.Text = "Records: 12/51"
        '
        'lblNoValues
        '
        Me.lblNoValues.AutoSize = True
        Me.lblNoValues.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoValues.Location = New System.Drawing.Point(9, 99)
        Me.lblNoValues.Name = "lblNoValues"
        Me.lblNoValues.Size = New System.Drawing.Size(81, 15)
        Me.lblNoValues.TabIndex = 57
        Me.lblNoValues.Text = "Values: 12/51"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MoCTIMIS.My.Resources.edit_paste_9
        Me.PictureBox2.Location = New System.Drawing.Point(217, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'lblExportStatus
        '
        Me.lblExportStatus.AutoSize = True
        Me.lblExportStatus.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExportStatus.Location = New System.Drawing.Point(48, 32)
        Me.lblExportStatus.Name = "lblExportStatus"
        Me.lblExportStatus.Size = New System.Drawing.Size(104, 21)
        Me.lblExportStatus.TabIndex = 57
        Me.lblExportStatus.Text = "Please Wait..."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 8)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(144, 21)
        Me.Label26.TabIndex = 57
        Me.Label26.Text = "Exporting to Excell"
        '
        'cmdExport
        '
        Me.cmdExport.Location = New System.Drawing.Point(757, 291)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(178, 27)
        Me.cmdExport.TabIndex = 50
        Me.cmdExport.Text = "Export to Excel"
        '
        'chkRestrict
        '
        Me.chkRestrict.AutoSize = True
        Me.chkRestrict.Location = New System.Drawing.Point(318, 353)
        Me.chkRestrict.Name = "chkRestrict"
        Me.chkRestrict.Size = New System.Drawing.Size(166, 17)
        Me.chkRestrict.TabIndex = 49
        Me.chkRestrict.Text = "Restrict to fields selected only"
        Me.chkRestrict.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(757, 258)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(178, 27)
        Me.cmdSearch.TabIndex = 48
        Me.cmdSearch.Text = "Search"
        '
        'SearchDataGridView
        '
        Me.SearchDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchDataGridView.Name = "SearchDataGridView"
        Me.SearchDataGridView.Size = New System.Drawing.Size(908, 145)
        Me.SearchDataGridView.TabIndex = 47
        '
        'cmdremove
        '
        Me.cmdremove.Location = New System.Drawing.Point(674, 140)
        Me.cmdremove.Name = "cmdremove"
        Me.cmdremove.Size = New System.Drawing.Size(72, 24)
        Me.cmdremove.TabIndex = 46
        Me.cmdremove.Text = "Remove"
        '
        'lstFilter
        '
        Me.lstFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFilter.FormattingEnabled = True
        Me.lstFilter.ItemHeight = 15
        Me.lstFilter.Location = New System.Drawing.Point(539, 168)
        Me.lstFilter.Name = "lstFilter"
        Me.lstFilter.Size = New System.Drawing.Size(207, 184)
        Me.lstFilter.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(536, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Filter"
        '
        'gbDate
        '
        Me.gbDate.Controls.Add(Me.ReportEndDateDateTimePicker2)
        Me.gbDate.Controls.Add(Me.Label37)
        Me.gbDate.Controls.Add(Me.ReportStartDateDateTimePicker1)
        Me.gbDate.Controls.Add(Me.Label36)
        Me.gbDate.Location = New System.Drawing.Point(318, 60)
        Me.gbDate.Name = "gbDate"
        Me.gbDate.Size = New System.Drawing.Size(271, 77)
        Me.gbDate.TabIndex = 43
        Me.gbDate.TabStop = False
        Me.gbDate.Text = "Date Selection"
        '
        'ReportEndDateDateTimePicker2
        '
        Me.ReportEndDateDateTimePicker2.CustomFormat = "dd MMMM yyyy"
        Me.ReportEndDateDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ReportEndDateDateTimePicker2.Location = New System.Drawing.Point(99, 44)
        Me.ReportEndDateDateTimePicker2.Name = "ReportEndDateDateTimePicker2"
        Me.ReportEndDateDateTimePicker2.Size = New System.Drawing.Size(151, 20)
        Me.ReportEndDateDateTimePicker2.TabIndex = 27
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(15, 45)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(50, 15)
        Me.Label37.TabIndex = 31
        Me.Label37.Text = "To Date:"
        '
        'ReportStartDateDateTimePicker1
        '
        Me.ReportStartDateDateTimePicker1.CustomFormat = "dd MMMM yyyy"
        Me.ReportStartDateDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ReportStartDateDateTimePicker1.Location = New System.Drawing.Point(99, 18)
        Me.ReportStartDateDateTimePicker1.Name = "ReportStartDateDateTimePicker1"
        Me.ReportStartDateDateTimePicker1.Size = New System.Drawing.Size(151, 20)
        Me.ReportStartDateDateTimePicker1.TabIndex = 26
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(15, 19)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(66, 15)
        Me.Label36.TabIndex = 32
        Me.Label36.Text = "From Date:"
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Checked = True
        Me.chkDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDate.Location = New System.Drawing.Point(89, 129)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(118, 17)
        Me.chkDate.TabIndex = 42
        Me.chkDate.Text = "Associate with date"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'cboDateField
        '
        Me.cboDateField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDateField.FormattingEnabled = True
        Me.cboDateField.Location = New System.Drawing.Point(89, 102)
        Me.cboDateField.Name = "cboDateField"
        Me.cboDateField.Size = New System.Drawing.Size(143, 21)
        Me.cboDateField.TabIndex = 41
        '
        'cboTableName
        '
        Me.cboTableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTableName.FormattingEnabled = True
        Me.cboTableName.Location = New System.Drawing.Point(89, 75)
        Me.cboTableName.Name = "cboTableName"
        Me.cboTableName.Size = New System.Drawing.Size(143, 21)
        Me.cboTableName.TabIndex = 41
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSummaryonly)
        Me.GroupBox1.Controls.Add(Me.radRecordlistonly)
        Me.GroupBox1.Controls.Add(Me.radRecordlistandSummary)
        Me.GroupBox1.Location = New System.Drawing.Point(757, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 90)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select type of Report"
        '
        'radSummaryonly
        '
        Me.radSummaryonly.AutoSize = True
        Me.radSummaryonly.Location = New System.Drawing.Point(19, 66)
        Me.radSummaryonly.Name = "radSummaryonly"
        Me.radSummaryonly.Size = New System.Drawing.Size(90, 17)
        Me.radSummaryonly.TabIndex = 0
        Me.radSummaryonly.Text = "Summary only"
        Me.radSummaryonly.UseVisualStyleBackColor = True
        '
        'radRecordlistonly
        '
        Me.radRecordlistonly.AutoSize = True
        Me.radRecordlistonly.Location = New System.Drawing.Point(19, 44)
        Me.radRecordlistonly.Name = "radRecordlistonly"
        Me.radRecordlistonly.Size = New System.Drawing.Size(97, 17)
        Me.radRecordlistonly.TabIndex = 0
        Me.radRecordlistonly.Text = "Record list only"
        Me.radRecordlistonly.UseVisualStyleBackColor = True
        '
        'radRecordlistandSummary
        '
        Me.radRecordlistandSummary.AutoSize = True
        Me.radRecordlistandSummary.Checked = True
        Me.radRecordlistandSummary.Location = New System.Drawing.Point(19, 21)
        Me.radRecordlistandSummary.Name = "radRecordlistandSummary"
        Me.radRecordlistandSummary.Size = New System.Drawing.Size(142, 17)
        Me.radRecordlistandSummary.TabIndex = 0
        Me.radRecordlistandSummary.TabStop = True
        Me.radRecordlistandSummary.Text = "Record list and Summary"
        Me.radRecordlistandSummary.UseVisualStyleBackColor = True
        '
        'txtReportTitle
        '
        Me.txtReportTitle.Location = New System.Drawing.Point(97, 331)
        Me.txtReportTitle.Name = "txtReportTitle"
        Me.txtReportTitle.Size = New System.Drawing.Size(129, 20)
        Me.txtReportTitle.TabIndex = 39
        '
        'cmdreturn
        '
        Me.cmdreturn.Location = New System.Drawing.Point(240, 270)
        Me.cmdreturn.Name = "cmdreturn"
        Me.cmdreturn.Size = New System.Drawing.Size(65, 25)
        Me.cmdreturn.TabIndex = 37
        Me.cmdreturn.Text = "< =="
        '
        'cmdmove
        '
        Me.cmdmove.Location = New System.Drawing.Point(240, 241)
        Me.cmdmove.Name = "cmdmove"
        Me.cmdmove.Size = New System.Drawing.Size(65, 25)
        Me.cmdmove.TabIndex = 38
        Me.cmdmove.Text = "== >"
        '
        'lstReport
        '
        Me.lstReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReport.FormattingEnabled = True
        Me.lstReport.ItemHeight = 15
        Me.lstReport.Location = New System.Drawing.Point(318, 168)
        Me.lstReport.Name = "lstReport"
        Me.lstReport.Size = New System.Drawing.Size(207, 154)
        Me.lstReport.TabIndex = 36
        '
        'lstDatabase
        '
        Me.lstDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDatabase.FormattingEnabled = True
        Me.lstDatabase.ItemHeight = 15
        Me.lstDatabase.Location = New System.Drawing.Point(23, 170)
        Me.lstDatabase.Name = "lstDatabase"
        Me.lstDatabase.Size = New System.Drawing.Size(205, 154)
        Me.lstDatabase.TabIndex = 35
        '
        'cmdPrintReport
        '
        Me.cmdPrintReport.Location = New System.Drawing.Point(757, 324)
        Me.cmdPrintReport.Name = "cmdPrintReport"
        Me.cmdPrintReport.Size = New System.Drawing.Size(178, 27)
        Me.cmdPrintReport.TabIndex = 10
        Me.cmdPrintReport.Text = "Print Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(315, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Report"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(315, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(340, 15)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Note: Printing the report will rely on the fields selected above"
        '
        'lblFieldsRemaining
        '
        Me.lblFieldsRemaining.AutoSize = True
        Me.lblFieldsRemaining.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFieldsRemaining.Location = New System.Drawing.Point(315, 331)
        Me.lblFieldsRemaining.Name = "lblFieldsRemaining"
        Me.lblFieldsRemaining.Size = New System.Drawing.Size(111, 15)
        Me.lblFieldsRemaining.TabIndex = 29
        Me.lblFieldsRemaining.Text = "8 Fields Remaining"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Database"
        '
        'lblNoofRecords
        '
        Me.lblNoofRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoofRecords.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoofRecords.Location = New System.Drawing.Point(719, 373)
        Me.lblNoofRecords.Name = "lblNoofRecords"
        Me.lblNoofRecords.Size = New System.Drawing.Size(211, 20)
        Me.lblNoofRecords.TabIndex = 30
        Me.lblNoofRecords.Text = "0 Record(s)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Search Result"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 333)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Report Title:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Date Field:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Table:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(11, 37)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(282, 21)
        Me.Label34.TabIndex = 25
        Me.Label34.Text = "Advanced Search and Summary Report"
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.lblProjectName)
        Me.PanelHeader.Controls.Add(Me.cmdClose)
        Me.PanelHeader.Controls.Add(Me.cmdMinimize)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(949, 25)
        Me.PanelHeader.TabIndex = 3
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.BackColor = System.Drawing.Color.Transparent
        Me.lblProjectName.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblProjectName.Location = New System.Drawing.Point(6, 4)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(159, 17)
        Me.lblProjectName.TabIndex = 1
        Me.lblProjectName.Text = "Advanced Record Explorer"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Location = New System.Drawing.Point(923, 1)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(25, 22)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "X"
        '
        'cmdMinimize
        '
        Me.cmdMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdMinimize.Location = New System.Drawing.Point(897, 0)
        Me.cmdMinimize.Name = "cmdMinimize"
        Me.cmdMinimize.Size = New System.Drawing.Size(25, 22)
        Me.cmdMinimize.TabIndex = 0
        Me.cmdMinimize.TabStop = False
        Me.cmdMinimize.Text = "_"
        '
        'MyExportBackgroundWorker
        '
        Me.MyExportBackgroundWorker.WorkerReportsProgress = True
        Me.MyExportBackgroundWorker.WorkerSupportsCancellation = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 563)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Advanced Search and Summary"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelExporting.ResumeLayout(False)
        Me.PanelExporting.PerformLayout()
        Me.PanelProgressbarContainer.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDate.ResumeLayout(False)
        Me.gbDate.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdremove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lstFilter As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gbDate As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ReportEndDateDateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ReportStartDateDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents cboDateField As System.Windows.Forms.ComboBox
    Friend WithEvents cboTableName As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents radSummaryonly As System.Windows.Forms.RadioButton
    Friend WithEvents radRecordlistonly As System.Windows.Forms.RadioButton
    Friend WithEvents radRecordlistandSummary As System.Windows.Forms.RadioButton
    Friend WithEvents txtReportTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdreturn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdmove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lstReport As System.Windows.Forms.ListBox
    Friend WithEvents lstDatabase As System.Windows.Forms.ListBox
    Friend WithEvents cmdPrintReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFieldsRemaining As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelHeader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblProjectName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdMinimize As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SearchDataGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkRestrict As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNoofRecords As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents MyExportBackgroundWorker As System.ComponentModel.BackgroundWorker
End Class
