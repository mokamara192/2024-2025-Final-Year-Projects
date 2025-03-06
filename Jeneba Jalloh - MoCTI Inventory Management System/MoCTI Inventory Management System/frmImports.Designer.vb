<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImports
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LoadingExcellBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelRemap = New DevExpress.XtraEditors.PanelControl()
        Me.cmdValidateForeignkey = New DevExpress.XtraEditors.SimpleButton()
        Me.ValidationDataGridView = New System.Windows.Forms.DataGridView()
        Me.Validate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Condition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelHeader2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdClosePanelRemap = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAutoMap = New DevExpress.XtraEditors.SimpleButton()
        Me.RemapingDataGridView = New System.Windows.Forms.DataGridView()
        Me.DatabaseField = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExcellField = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdAccept = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdMapColumn = New DevExpress.XtraEditors.SimpleButton()
        Me.cboExcellField = New System.Windows.Forms.ComboBox()
        Me.cboDatabaseField = New System.Windows.Forms.ComboBox()
        Me.Label11 = New DevExpress.XtraEditors.LabelControl()
        Me.Label12 = New DevExpress.XtraEditors.LabelControl()
        Me.Label13 = New DevExpress.XtraEditors.LabelControl()
        Me.lblSummary = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.lblOverallCondition = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelNotLoaded = New DevExpress.XtraEditors.PanelControl()
        Me.lblLoaded = New DevExpress.XtraEditors.LabelControl()
        Me.lblLoaded2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdNewImport = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelProgress = New DevExpress.XtraEditors.PanelControl()
        Me.PanelProgressbarContainer = New DevExpress.XtraEditors.PanelControl()
        Me.PanelProgressbar = New DevExpress.XtraEditors.PanelControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.lblPercentage = New DevExpress.XtraEditors.LabelControl()
        Me.lblCurrentRecord = New DevExpress.XtraEditors.LabelControl()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImport = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBrowse = New DevExpress.XtraEditors.SimpleButton()
        Me.txtExcellPath = New DevExpress.XtraEditors.TextEdit()
        Me.cmdColumnMapper = New DevExpress.XtraEditors.SimpleButton()
        Me.cboTableName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblNoofRecords = New DevExpress.XtraEditors.LabelControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.Label34 = New DevExpress.XtraEditors.LabelControl()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.ValidatePKBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.ImportDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.PanelRemap.SuspendLayout()
        CType(Me.ValidationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader2.SuspendLayout()
        CType(Me.RemapingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNotLoaded.SuspendLayout()
        Me.PanelProgress.SuspendLayout()
        Me.PanelProgressbarContainer.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ImportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadingExcellBackgroundWorker
        '
        Me.LoadingExcellBackgroundWorker.WorkerReportsProgress = True
        Me.LoadingExcellBackgroundWorker.WorkerSupportsCancellation = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.PanelRemap)
        Me.Panel1.Controls.Add(Me.PanelNotLoaded)
        Me.Panel1.Controls.Add(Me.cmdNewImport)
        Me.Panel1.Controls.Add(Me.PanelProgress)
        Me.Panel1.Controls.Add(Me.cmdCancel)
        Me.Panel1.Controls.Add(Me.cmdImport)
        Me.Panel1.Controls.Add(Me.cmdBrowse)
        Me.Panel1.Controls.Add(Me.txtExcellPath)
        Me.Panel1.Controls.Add(Me.cmdColumnMapper)
        Me.Panel1.Controls.Add(Me.cboTableName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblNoofRecords)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.ImportDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(949, 529)
        Me.Panel1.TabIndex = 2
        '
        'PanelRemap
        '
        Me.PanelRemap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelRemap.Controls.Add(Me.cmdValidateForeignkey)
        Me.PanelRemap.Controls.Add(Me.ValidationDataGridView)
        Me.PanelRemap.Controls.Add(Me.PanelHeader2)
        Me.PanelRemap.Controls.Add(Me.cmdAutoMap)
        Me.PanelRemap.Controls.Add(Me.RemapingDataGridView)
        Me.PanelRemap.Controls.Add(Me.cmdAccept)
        Me.PanelRemap.Controls.Add(Me.cmdRemove)
        Me.PanelRemap.Controls.Add(Me.cmdMapColumn)
        Me.PanelRemap.Controls.Add(Me.cboExcellField)
        Me.PanelRemap.Controls.Add(Me.cboDatabaseField)
        Me.PanelRemap.Controls.Add(Me.Label11)
        Me.PanelRemap.Controls.Add(Me.Label12)
        Me.PanelRemap.Controls.Add(Me.Label13)
        Me.PanelRemap.Controls.Add(Me.lblSummary)
        Me.PanelRemap.Controls.Add(Me.Label3)
        Me.PanelRemap.Controls.Add(Me.lblOverallCondition)
        Me.PanelRemap.Controls.Add(Me.Label2)
        Me.PanelRemap.Location = New System.Drawing.Point(98, 70)
        Me.PanelRemap.Name = "PanelRemap"
        Me.PanelRemap.Size = New System.Drawing.Size(763, 452)
        Me.PanelRemap.TabIndex = 76
        Me.PanelRemap.Visible = False
        '
        'cmdValidateForeignkey
        '
        Me.cmdValidateForeignkey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdValidateForeignkey.Location = New System.Drawing.Point(528, 280)
        Me.cmdValidateForeignkey.Name = "cmdValidateForeignkey"
        Me.cmdValidateForeignkey.Size = New System.Drawing.Size(100, 29)
        Me.cmdValidateForeignkey.TabIndex = 34
        Me.cmdValidateForeignkey.Text = "Validate FK"
        Me.cmdValidateForeignkey.Visible = False
        '
        'ValidationDataGridView
        '
        Me.ValidationDataGridView.AllowUserToAddRows = False
        Me.ValidationDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ValidationDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ValidationDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.ValidationDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValidationDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ValidationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ValidationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Validate, Me.Condition})
        Me.ValidationDataGridView.Location = New System.Drawing.Point(518, 94)
        Me.ValidationDataGridView.Name = "ValidationDataGridView"
        Me.ValidationDataGridView.ReadOnly = True
        Me.ValidationDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ValidationDataGridView.Size = New System.Drawing.Size(236, 150)
        Me.ValidationDataGridView.TabIndex = 33
        '
        'Validate
        '
        Me.Validate.HeaderText = "Validate"
        Me.Validate.Name = "Validate"
        Me.Validate.ReadOnly = True
        '
        'Condition
        '
        Me.Condition.HeaderText = "Condition"
        Me.Condition.Name = "Condition"
        Me.Condition.ReadOnly = True
        '
        'PanelHeader2
        '
        Me.PanelHeader2.BackColor = System.Drawing.Color.RoyalBlue
        Me.PanelHeader2.Controls.Add(Me.Label7)
        Me.PanelHeader2.Controls.Add(Me.cmdClosePanelRemap)
        Me.PanelHeader2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader2.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader2.Name = "PanelHeader2"
        Me.PanelHeader2.Size = New System.Drawing.Size(761, 25)
        Me.PanelHeader2.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(6, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Column Remapper"
        '
        'cmdClosePanelRemap
        '
        Me.cmdClosePanelRemap.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClosePanelRemap.Location = New System.Drawing.Point(735, 1)
        Me.cmdClosePanelRemap.Name = "cmdClosePanelRemap"
        Me.cmdClosePanelRemap.Size = New System.Drawing.Size(25, 22)
        Me.cmdClosePanelRemap.TabIndex = 0
        Me.cmdClosePanelRemap.TabStop = False
        Me.cmdClosePanelRemap.Text = "X"
        '
        'cmdAutoMap
        '
        Me.cmdAutoMap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAutoMap.Location = New System.Drawing.Point(22, 280)
        Me.cmdAutoMap.Name = "cmdAutoMap"
        Me.cmdAutoMap.Size = New System.Drawing.Size(107, 27)
        Me.cmdAutoMap.TabIndex = 11
        Me.cmdAutoMap.Text = "Auto Map"
        '
        'RemapingDataGridView
        '
        Me.RemapingDataGridView.AllowUserToAddRows = False
        Me.RemapingDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RemapingDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.RemapingDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.RemapingDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.RemapingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RemapingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DatabaseField, Me.ExcellField})
        Me.RemapingDataGridView.Location = New System.Drawing.Point(22, 315)
        Me.RemapingDataGridView.Name = "RemapingDataGridView"
        Me.RemapingDataGridView.ReadOnly = True
        Me.RemapingDataGridView.Size = New System.Drawing.Size(489, 122)
        Me.RemapingDataGridView.TabIndex = 9
        '
        'DatabaseField
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        Me.DatabaseField.DefaultCellStyle = DataGridViewCellStyle3
        Me.DatabaseField.HeaderText = "Database Field"
        Me.DatabaseField.Name = "DatabaseField"
        Me.DatabaseField.ReadOnly = True
        Me.DatabaseField.Width = 240
        '
        'ExcellField
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ExcellField.DefaultCellStyle = DataGridViewCellStyle4
        Me.ExcellField.HeaderText = "Excell Field"
        Me.ExcellField.Name = "ExcellField"
        Me.ExcellField.ReadOnly = True
        Me.ExcellField.Width = 240
        '
        'cmdAccept
        '
        Me.cmdAccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccept.Location = New System.Drawing.Point(654, 408)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(100, 29)
        Me.cmdAccept.TabIndex = 8
        Me.cmdAccept.Text = "Accept"
        '
        'cmdRemove
        '
        Me.cmdRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove.Location = New System.Drawing.Point(227, 197)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(83, 29)
        Me.cmdRemove.TabIndex = 8
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.Visible = False
        '
        'cmdMapColumn
        '
        Me.cmdMapColumn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMapColumn.Location = New System.Drawing.Point(227, 162)
        Me.cmdMapColumn.Name = "cmdMapColumn"
        Me.cmdMapColumn.Size = New System.Drawing.Size(83, 30)
        Me.cmdMapColumn.TabIndex = 8
        Me.cmdMapColumn.Text = "Map ==>"
        '
        'cboExcellField
        '
        Me.cboExcellField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboExcellField.FormattingEnabled = True
        Me.cboExcellField.Location = New System.Drawing.Point(320, 94)
        Me.cboExcellField.Name = "cboExcellField"
        Me.cboExcellField.Size = New System.Drawing.Size(191, 185)
        Me.cboExcellField.TabIndex = 6
        '
        'cboDatabaseField
        '
        Me.cboDatabaseField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboDatabaseField.FormattingEnabled = True
        Me.cboDatabaseField.Location = New System.Drawing.Point(23, 94)
        Me.cboDatabaseField.Name = "cboDatabaseField"
        Me.cboDatabaseField.Size = New System.Drawing.Size(194, 185)
        Me.cboDatabaseField.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label11.Location = New System.Drawing.Point(318, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 18)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Excell Field"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Brown
        Me.Label12.Location = New System.Drawing.Point(21, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 18)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Database Field"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(18, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(202, 19)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Advanced Column Remapping"
        '
        'lblSummary
        '
        Me.lblSummary.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummary.ForeColor = System.Drawing.Color.Black
        Me.lblSummary.Location = New System.Drawing.Point(527, 318)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(227, 80)
        Me.lblSummary.TabIndex = 32
        Me.lblSummary.Text = "Summary:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(525, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 15)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Overall Condition:"
        '
        'lblOverallCondition
        '
        Me.lblOverallCondition.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverallCondition.ForeColor = System.Drawing.Color.Red
        Me.lblOverallCondition.Location = New System.Drawing.Point(634, 255)
        Me.lblOverallCondition.Name = "lblOverallCondition"
        Me.lblOverallCondition.Size = New System.Drawing.Size(110, 18)
        Me.lblOverallCondition.TabIndex = 32
        Me.lblOverallCondition.Text = "Failed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(517, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Validations"
        '
        'PanelNotLoaded
        '
        Me.PanelNotLoaded.Controls.Add(Me.lblLoaded)
        Me.PanelNotLoaded.Controls.Add(Me.lblLoaded2)
        Me.PanelNotLoaded.Location = New System.Drawing.Point(316, 250)
        Me.PanelNotLoaded.Name = "PanelNotLoaded"
        Me.PanelNotLoaded.Size = New System.Drawing.Size(315, 96)
        Me.PanelNotLoaded.TabIndex = 84
        '
        'lblLoaded
        '
        Me.lblLoaded.AutoSize = True
        Me.lblLoaded.BackColor = System.Drawing.Color.Transparent
        Me.lblLoaded.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoaded.ForeColor = System.Drawing.Color.Firebrick
        Me.lblLoaded.Location = New System.Drawing.Point(82, 22)
        Me.lblLoaded.Name = "lblLoaded"
        Me.lblLoaded.Size = New System.Drawing.Size(148, 25)
        Me.lblLoaded.TabIndex = 25
        Me.lblLoaded.Text = "No Data Loaded"
        '
        'lblLoaded2
        '
        Me.lblLoaded2.AutoSize = True
        Me.lblLoaded2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoaded2.Location = New System.Drawing.Point(34, 51)
        Me.lblLoaded2.Name = "lblLoaded2"
        Me.lblLoaded2.Size = New System.Drawing.Size(253, 15)
        Me.lblLoaded2.TabIndex = 32
        Me.lblLoaded2.Text = "Please browse for an Excel Data File to load.."
        '
        'cmdNewImport
        '
        Me.cmdNewImport.Location = New System.Drawing.Point(155, 29)
        Me.cmdNewImport.Name = "cmdNewImport"
        Me.cmdNewImport.Size = New System.Drawing.Size(83, 27)
        Me.cmdNewImport.TabIndex = 82
        Me.cmdNewImport.Text = "New Import"
        '
        'PanelProgress
        '
        Me.PanelProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelProgress.Controls.Add(Me.PanelProgressbarContainer)
        Me.PanelProgress.Controls.Add(Me.Label5)
        Me.PanelProgress.Controls.Add(Me.lblPercentage)
        Me.PanelProgress.Controls.Add(Me.lblCurrentRecord)
        Me.PanelProgress.Location = New System.Drawing.Point(253, 466)
        Me.PanelProgress.Name = "PanelProgress"
        Me.PanelProgress.Size = New System.Drawing.Size(685, 51)
        Me.PanelProgress.TabIndex = 81
        Me.PanelProgress.Visible = False
        '
        'PanelProgressbarContainer
        '
        Me.PanelProgressbarContainer.Controls.Add(Me.PanelProgressbar)
        Me.PanelProgressbarContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelProgressbarContainer.Location = New System.Drawing.Point(0, 39)
        Me.PanelProgressbarContainer.Name = "PanelProgressbarContainer"
        Me.PanelProgressbarContainer.Size = New System.Drawing.Size(685, 12)
        Me.PanelProgressbarContainer.TabIndex = 0
        '
        'PanelProgressbar
        '
        Me.PanelProgressbar.BackColor = System.Drawing.Color.Silver
        Me.PanelProgressbar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelProgressbar.Location = New System.Drawing.Point(0, 0)
        Me.PanelProgressbar.Name = "PanelProgressbar"
        Me.PanelProgressbar.Size = New System.Drawing.Size(10, 12)
        Me.PanelProgressbar.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(614, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Percentage"
        '
        'lblPercentage
        '
        Me.lblPercentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPercentage.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage.Location = New System.Drawing.Point(513, 21)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(165, 15)
        Me.lblPercentage.TabIndex = 32
        Me.lblPercentage.Text = "38% Complete.."
        '
        'lblCurrentRecord
        '
        Me.lblCurrentRecord.AutoSize = True
        Me.lblCurrentRecord.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentRecord.Location = New System.Drawing.Point(4, 20)
        Me.lblCurrentRecord.Name = "lblCurrentRecord"
        Me.lblCurrentRecord.Size = New System.Drawing.Size(91, 15)
        Me.lblCurrentRecord.TabIndex = 32
        Me.lblCurrentRecord.Text = "Record: 50/280"
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.Location = New System.Drawing.Point(145, 482)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(97, 28)
        Me.cmdCancel.TabIndex = 80
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.Visible = False
        '
        'cmdImport
        '
        Me.cmdImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdImport.Enabled = False
        Me.cmdImport.Location = New System.Drawing.Point(43, 482)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(97, 28)
        Me.cmdImport.TabIndex = 80
        Me.cmdImport.Text = "Start &Import"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(549, 85)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(82, 27)
        Me.cmdBrowse.TabIndex = 79
        Me.cmdBrowse.Text = "&Browse"
        '
        'txtExcellPath
        '
        Me.txtExcellPath.Location = New System.Drawing.Point(82, 89)
        Me.txtExcellPath.Name = "txtExcellPath"
        Me.txtExcellPath.ReadOnly = True
        Me.txtExcellPath.Size = New System.Drawing.Size(461, 20)
        Me.txtExcellPath.TabIndex = 78
        '
        'cmdColumnMapper
        '
        Me.cmdColumnMapper.Enabled = False
        Me.cmdColumnMapper.Location = New System.Drawing.Point(82, 113)
        Me.cmdColumnMapper.Name = "cmdColumnMapper"
        Me.cmdColumnMapper.Size = New System.Drawing.Size(109, 27)
        Me.cmdColumnMapper.TabIndex = 42
        Me.cmdColumnMapper.Text = "Map Columns"
        '
        'cboTableName
        '
        Me.cboTableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTableName.FormattingEnabled = True
        Me.cboTableName.Location = New System.Drawing.Point(81, 64)
        Me.cboTableName.Name = "cboTableName"
        Me.cboTableName.Size = New System.Drawing.Size(143, 21)
        Me.cboTableName.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Excel File:"
        '
        'lblNoofRecords
        '
        Me.lblNoofRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoofRecords.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoofRecords.Location = New System.Drawing.Point(751, 137)
        Me.lblNoofRecords.Name = "lblNoofRecords"
        Me.lblNoofRecords.Size = New System.Drawing.Size(183, 20)
        Me.lblNoofRecords.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 66)
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
        Me.Label34.Location = New System.Drawing.Point(11, 31)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(146, 21)
        Me.Label34.TabIndex = 25
        Me.Label34.Text = "Data Import Wizard"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(946, 24)
        Me.MenuStrip1.TabIndex = 83
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewImportToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewImportToolStripMenuItem
        '
        Me.NewImportToolStripMenuItem.Name = "NewImportToolStripMenuItem"
        Me.NewImportToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.NewImportToolStripMenuItem.Text = "New Import"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MapColumnsToolStripMenuItem, Me.StartImportToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'MapColumnsToolStripMenuItem
        '
        Me.MapColumnsToolStripMenuItem.Name = "MapColumnsToolStripMenuItem"
        Me.MapColumnsToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.MapColumnsToolStripMenuItem.Text = "Map Columns"
        '
        'StartImportToolStripMenuItem
        '
        Me.StartImportToolStripMenuItem.Name = "StartImportToolStripMenuItem"
        Me.StartImportToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.StartImportToolStripMenuItem.Text = "Start Import"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowseToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'BrowseToolStripMenuItem
        '
        Me.BrowseToolStripMenuItem.Name = "BrowseToolStripMenuItem"
        Me.BrowseToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.BrowseToolStripMenuItem.Text = "Browse For Excell File"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ImportBackgroundWorker
        '
        Me.ImportBackgroundWorker.WorkerReportsProgress = True
        Me.ImportBackgroundWorker.WorkerSupportsCancellation = True
        '
        'ValidatePKBackgroundWorker
        '
        Me.ValidatePKBackgroundWorker.WorkerReportsProgress = True
        Me.ValidatePKBackgroundWorker.WorkerSupportsCancellation = True
        '
        'ImportDataGridView
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ImportDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.ImportDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImportDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.ImportDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ImportDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ImportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ImportDataGridView.Location = New System.Drawing.Point(9, 164)
        Me.ImportDataGridView.Name = "ImportDataGridView"
        Me.ImportDataGridView.Size = New System.Drawing.Size(929, 296)
        Me.ImportDataGridView.TabIndex = 86
        '
        'frmImports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 529)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmImports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Import Wizard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelRemap.ResumeLayout(False)
        Me.PanelRemap.PerformLayout()
        CType(Me.ValidationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader2.ResumeLayout(False)
        Me.PanelHeader2.PerformLayout()
        CType(Me.RemapingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNotLoaded.ResumeLayout(False)
        Me.PanelNotLoaded.PerformLayout()
        Me.PanelProgress.ResumeLayout(False)
        Me.PanelProgress.PerformLayout()
        Me.PanelProgressbarContainer.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ImportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents LoadingExcellBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdNewImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelRemap As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelHeader2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdClosePanelRemap As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAutoMap As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RemapingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DatabaseField As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExcellField As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdAccept As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdMapColumn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboExcellField As System.Windows.Forms.ComboBox
    Friend WithEvents cboDatabaseField As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelProgress As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelProgressbarContainer As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelProgressbar As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPercentage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCurrentRecord As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtExcellPath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdColumnMapper As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboTableName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ImportBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblNoofRecords As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MapColumnsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblLoaded As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLoaded2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ValidationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Validate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Condition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblOverallCondition As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdValidateForeignkey As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblSummary As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ValidatePKBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelNotLoaded As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ImportDataGridView As System.Windows.Forms.DataGridView
End Class
