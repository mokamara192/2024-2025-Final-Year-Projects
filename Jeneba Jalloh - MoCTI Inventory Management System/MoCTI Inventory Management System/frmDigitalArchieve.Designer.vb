<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDigitalArchieve
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
        Me.ArchieveIDLabel = New DevExpress.XtraEditors.LabelControl()

        Me.SubjectLabel = New DevExpress.XtraEditors.LabelControl()
        Me.TypeOfAttachmentLabel = New DevExpress.XtraEditors.LabelControl()
        Me.TitleLabel = New DevExpress.XtraEditors.LabelControl()
Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DetailsOfDocumentLabel = New DevExpress.XtraEditors.LabelControl()
        Me.SearchKeywordLabel = New DevExpress.XtraEditors.LabelControl()
        Me.TheFileNameLabel = New DevExpress.XtraEditors.LabelControl()
        Me.AttachmentFileLabel = New DevExpress.XtraEditors.LabelControl()
        Me.SharedAccessLevelLabel = New DevExpress.XtraEditors.LabelControl()
        Me.RegDateLabel = New DevExpress.XtraEditors.LabelControl()
        Me.ArchieveIDTextBox = New DevExpress.XtraEditors.TextEdit()

        Me.SubjectTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.TypeOfAttachmentTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.TitleTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.DetailsOfDocumentTextBox = New System.Windows.Forms.TextBox()
        Me.SearchKeywordTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.TheFileNameTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.cmdBrowseAttachmentFile = New DevExpress.XtraEditors.SimpleButton()
        Me.RegDateTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportWizardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToExcellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyExportBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.PanelOrange = New DevExpress.XtraEditors.PanelControl()
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelBody = New DevExpress.XtraEditors.PanelControl()
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
        Me.InputedByTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdDownload = New DevExpress.XtraEditors.SimpleButton()
        Me.SharedAccessLevelTextBox = New System.Windows.Forms.ComboBox()
        Me.PanelHeader = New DevExpress.XtraEditors.PanelControl()
        Me.lblProjectName = New DevExpress.XtraEditors.LabelControl()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdMinimize = New DevExpress.XtraEditors.SimpleButton()
        Me.lblInformation = New DevExpress.XtraEditors.LabelControl()
        Me.lblFormName = New DevExpress.XtraEditors.LabelControl()
        Me.AttachmentFilePictureBox = New System.Windows.Forms.PictureBox()
        Me.DigitalArchieveDataGridView = New DevExpress.XtraGrid.GridControl()
        Me.lblNoPreview = New DevExpress.XtraEditors.LabelControl()
        Me.TopMenuStrip.SuspendLayout()
        Me.PanelBody.SuspendLayout()
        Me.PanelExporting.SuspendLayout()
        Me.PanelProgressbarContainer.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        CType(Me.AttachmentFilePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalArchieveDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ArchieveIDLabel
        '
        Me.ArchieveIDLabel.AutoSize = True
        Me.ArchieveIDLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchieveIDLabel.Location = New System.Drawing.Point(28, 92)
        Me.ArchieveIDLabel.Name = "ArchieveIDLabel"
        Me.ArchieveIDLabel.Size = New System.Drawing.Size(72, 15)
        Me.ArchieveIDLabel.TabIndex = 1
        Me.ArchieveIDLabel.Text = "Archieve ID:"
        '

        'SubjectLabel
        '

        Me.SubjectLabel.AutoSize = True

        Me.SubjectLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.SubjectLabel.Location = New System.Drawing.Point(28, 118)

        Me.SubjectLabel.Name = "SubjectLabel"

        Me.SubjectLabel.Size = New System.Drawing.Size(50, 15)

        Me.SubjectLabel.TabIndex = 1

        Me.SubjectLabel.Text = "Subject:"
        '
        'TypeOfAttachmentLabel
        '
        Me.TypeOfAttachmentLabel.AutoSize = True
        Me.TypeOfAttachmentLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeOfAttachmentLabel.Location = New System.Drawing.Point(28, 144)
        Me.TypeOfAttachmentLabel.Name = "TypeOfAttachmentLabel"
        Me.TypeOfAttachmentLabel.Size = New System.Drawing.Size(115, 15)
        Me.TypeOfAttachmentLabel.TabIndex = 1
        Me.TypeOfAttachmentLabel.Text = "Type Of Attachment:"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(28, 170)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(34, 15)
        Me.TitleLabel.TabIndex = 1
        Me.TitleLabel.Text = "Title:"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.DigitalArchieveDataGridView
        Me.GridView1.Name = "GridView1"
        '
        'DetailsOfDocumentLabel
        '
        Me.DetailsOfDocumentLabel.AutoSize = True
        Me.DetailsOfDocumentLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsOfDocumentLabel.Location = New System.Drawing.Point(342, 79)
        Me.DetailsOfDocumentLabel.Name = "DetailsOfDocumentLabel"
        Me.DetailsOfDocumentLabel.Size = New System.Drawing.Size(123, 15)
        Me.DetailsOfDocumentLabel.TabIndex = 1
        Me.DetailsOfDocumentLabel.Text = "Details Of Document:"
        '
        'SearchKeywordLabel
        '
        Me.SearchKeywordLabel.AutoSize = True
        Me.SearchKeywordLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchKeywordLabel.Location = New System.Drawing.Point(28, 196)
        Me.SearchKeywordLabel.Name = "SearchKeywordLabel"
        Me.SearchKeywordLabel.Size = New System.Drawing.Size(97, 15)
        Me.SearchKeywordLabel.TabIndex = 1
        Me.SearchKeywordLabel.Text = "Search Keyword:"
        '
        'TheFileNameLabel
        '
        Me.TheFileNameLabel.AutoSize = True
        Me.TheFileNameLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheFileNameLabel.Location = New System.Drawing.Point(748, 357)
        Me.TheFileNameLabel.Name = "TheFileNameLabel"
        Me.TheFileNameLabel.Size = New System.Drawing.Size(86, 15)
        Me.TheFileNameLabel.TabIndex = 1
        Me.TheFileNameLabel.Text = "The File Name:"
        '
        'AttachmentFileLabel
        '
        Me.AttachmentFileLabel.AutoSize = True
        Me.AttachmentFileLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttachmentFileLabel.Location = New System.Drawing.Point(631, 76)
        Me.AttachmentFileLabel.Name = "AttachmentFileLabel"
        Me.AttachmentFileLabel.Size = New System.Drawing.Size(95, 15)
        Me.AttachmentFileLabel.TabIndex = 1
        Me.AttachmentFileLabel.Text = "Attachment File:"
        '
        'SharedAccessLevelLabel
        '
        Me.SharedAccessLevelLabel.AutoSize = True
        Me.SharedAccessLevelLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SharedAccessLevelLabel.Location = New System.Drawing.Point(28, 223)
        Me.SharedAccessLevelLabel.Name = "SharedAccessLevelLabel"
        Me.SharedAccessLevelLabel.Size = New System.Drawing.Size(118, 15)
        Me.SharedAccessLevelLabel.TabIndex = 1
        Me.SharedAccessLevelLabel.Text = "Shared Access Level:"
        '
        'RegDateLabel
        '
        Me.RegDateLabel.AutoSize = True
        Me.RegDateLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegDateLabel.Location = New System.Drawing.Point(28, 250)
        Me.RegDateLabel.Name = "RegDateLabel"
        Me.RegDateLabel.Size = New System.Drawing.Size(57, 15)
        Me.RegDateLabel.TabIndex = 1
        Me.RegDateLabel.Text = "Reg Date:"
        '
        'ArchieveIDTextBox
        '
        Me.ArchieveIDTextBox.Location = New System.Drawing.Point(153, 88)
        Me.ArchieveIDTextBox.Name = "ArchieveIDTextBox"
        Me.ArchieveIDTextBox.ReadOnly = True
        Me.ArchieveIDTextBox.Size = New System.Drawing.Size(70, 20)
        Me.ArchieveIDTextBox.TabIndex = 1
        '

        'SubjectTextBox
        '

        Me.SubjectTextBox.Location = New System.Drawing.Point(153, 114)

        Me.SubjectTextBox.Name = "SubjectTextBox"

        Me.SubjectTextBox.Size = New System.Drawing.Size(166, 20)

        Me.SubjectTextBox.TabIndex = 1
        '
        'TypeOfAttachmentTextBox
        '
        Me.TypeOfAttachmentTextBox.Location = New System.Drawing.Point(153, 140)
        Me.TypeOfAttachmentTextBox.Name = "TypeOfAttachmentTextBox"
        Me.TypeOfAttachmentTextBox.Size = New System.Drawing.Size(166, 20)
        Me.TypeOfAttachmentTextBox.TabIndex = 1
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(153, 166)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(166, 20)
        Me.TitleTextBox.TabIndex = 1
        '
        'DetailsOfDocumentTextBox
        '
        Me.DetailsOfDocumentTextBox.Location = New System.Drawing.Point(345, 104)
        Me.DetailsOfDocumentTextBox.Multiline = True
        Me.DetailsOfDocumentTextBox.Name = "DetailsOfDocumentTextBox"
        Me.DetailsOfDocumentTextBox.Size = New System.Drawing.Size(267, 133)
        Me.DetailsOfDocumentTextBox.TabIndex = 1
        '
        'SearchKeywordTextBox
        '
        Me.SearchKeywordTextBox.Location = New System.Drawing.Point(153, 192)
        Me.SearchKeywordTextBox.Name = "SearchKeywordTextBox"
        Me.SearchKeywordTextBox.Size = New System.Drawing.Size(166, 20)
        Me.SearchKeywordTextBox.TabIndex = 1
        '
        'TheFileNameTextBox
        '
        Me.TheFileNameTextBox.Location = New System.Drawing.Point(840, 356)
        Me.TheFileNameTextBox.Name = "TheFileNameTextBox"
        Me.TheFileNameTextBox.ReadOnly = True
        Me.TheFileNameTextBox.Size = New System.Drawing.Size(148, 20)
        Me.TheFileNameTextBox.TabIndex = 1
        '
        'cmdBrowseAttachmentFile
        '
        Me.cmdBrowseAttachmentFile.Location = New System.Drawing.Point(634, 350)
        Me.cmdBrowseAttachmentFile.Name = "cmdBrowseAttachmentFile"
        Me.cmdBrowseAttachmentFile.Size = New System.Drawing.Size(102, 27)
        Me.cmdBrowseAttachmentFile.TabIndex = 12
        Me.cmdBrowseAttachmentFile.Text = "Browse"
        '
        'RegDateTextBox
        '
        Me.RegDateTextBox.Location = New System.Drawing.Point(153, 246)
        Me.RegDateTextBox.Name = "RegDateTextBox"
        Me.RegDateTextBox.ReadOnly = True
        Me.RegDateTextBox.Size = New System.Drawing.Size(105, 20)
        Me.RegDateTextBox.TabIndex = 1
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopMenuStrip.AutoSize = False
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 26)
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
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.SearchToolStripMenuItem, Me.AdvancedSummaryToolStripMenuItem, Me.ImportWizardToolStripMenuItem, Me.ExportToExcellToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.PrintToolStripMenuItem.Text = "Print Current Record"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'AdvancedSummaryToolStripMenuItem
        '
        Me.AdvancedSummaryToolStripMenuItem.Name = "AdvancedSummaryToolStripMenuItem"
        Me.AdvancedSummaryToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AdvancedSummaryToolStripMenuItem.Text = "Advanced Summary"
        '
        'ImportWizardToolStripMenuItem
        '
        Me.ImportWizardToolStripMenuItem.Name = "ImportWizardToolStripMenuItem"
        Me.ImportWizardToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ImportWizardToolStripMenuItem.Text = "Import Wizard"
        '
        'ExportToExcellToolStripMenuItem
        '
        Me.ExportToExcellToolStripMenuItem.Name = "ExportToExcellToolStripMenuItem"
        Me.ExportToExcellToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ExportToExcellToolStripMenuItem.Text = "Export to Excel"
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MyExportBackgroundWorker
        '
        Me.MyExportBackgroundWorker.WorkerReportsProgress = True
        Me.MyExportBackgroundWorker.WorkerSupportsCancellation = True
        '
        'PanelOrange
        '
        Me.PanelOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelOrange.Location = New System.Drawing.Point(-4, 24)
        Me.PanelOrange.Name = "PanelOrange"
        Me.PanelOrange.Size = New System.Drawing.Size(1250, 10)
        Me.PanelOrange.TabIndex = 84
        Me.PanelOrange.Visible = False
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(345, 250)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(102, 27)
        Me.cmdAdd.TabIndex = 12
        Me.cmdAdd.Text = "Add New"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(345, 283)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(102, 27)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "Save"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(345, 316)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(102, 27)
        Me.cmdUpdate.TabIndex = 12
        Me.cmdUpdate.Text = "Update"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(345, 349)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(102, 27)
        Me.cmdDelete.TabIndex = 12
        Me.cmdDelete.Text = "Delete"
        '
        'PanelBody
        '
        Me.PanelBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.PanelBody.Controls.Add(Me.PanelExporting)
        Me.PanelBody.Controls.Add(Me.InputedByTextBox)
        Me.PanelBody.Controls.Add(Me.Label1)
        Me.PanelBody.Controls.Add(Me.cmdDownload)
        Me.PanelBody.Controls.Add(Me.SharedAccessLevelTextBox)
        Me.PanelBody.Controls.Add(Me.TopMenuStrip)
        Me.PanelBody.Controls.Add(Me.PanelOrange)
        Me.PanelBody.Controls.Add(Me.PanelHeader)
        Me.PanelBody.Controls.Add(Me.lblNoPreview)
        Me.PanelBody.Controls.Add(Me.lblFormName)
        Me.PanelBody.Controls.Add(Me.DigitalArchieveDataGridView)
        Me.PanelBody.Controls.Add(Me.cmdDelete)
        Me.PanelBody.Controls.Add(Me.cmdUpdate)
        Me.PanelBody.Controls.Add(Me.cmdAdd)
        Me.PanelBody.Controls.Add(Me.cmdSave)
        Me.PanelBody.Controls.Add(Me.ArchieveIDTextBox)

        Me.PanelBody.Controls.Add(Me.SubjectTextBox)
        Me.PanelBody.Controls.Add(Me.TypeOfAttachmentTextBox)
        Me.PanelBody.Controls.Add(Me.TitleTextBox)
        Me.PanelBody.Controls.Add(Me.DetailsOfDocumentTextBox)
        Me.PanelBody.Controls.Add(Me.SearchKeywordTextBox)
        Me.PanelBody.Controls.Add(Me.TheFileNameTextBox)
        Me.PanelBody.Controls.Add(Me.AttachmentFilePictureBox)
        Me.PanelBody.Controls.Add(Me.cmdBrowseAttachmentFile)
        Me.PanelBody.Controls.Add(Me.RegDateTextBox)
        Me.PanelBody.Controls.Add(Me.ArchieveIDLabel)

        Me.PanelBody.Controls.Add(Me.SubjectLabel)
        Me.PanelBody.Controls.Add(Me.TypeOfAttachmentLabel)
        Me.PanelBody.Controls.Add(Me.TitleLabel)
        Me.PanelBody.Controls.Add(Me.DetailsOfDocumentLabel)
        Me.PanelBody.Controls.Add(Me.SearchKeywordLabel)
        Me.PanelBody.Controls.Add(Me.TheFileNameLabel)
        Me.PanelBody.Controls.Add(Me.AttachmentFileLabel)
        Me.PanelBody.Controls.Add(Me.SharedAccessLevelLabel)
        Me.PanelBody.Controls.Add(Me.RegDateLabel)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(0, 0)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(1015, 631)
        Me.PanelBody.TabIndex = 1
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
        Me.PanelExporting.Location = New System.Drawing.Point(327, 215)
        Me.PanelExporting.Name = "PanelExporting"
        Me.PanelExporting.Size = New System.Drawing.Size(295, 134)
        Me.PanelExporting.TabIndex = 87
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
        'InputedByTextBox
        '
        Me.InputedByTextBox.Location = New System.Drawing.Point(152, 272)
        Me.InputedByTextBox.Name = "InputedByTextBox"
        Me.InputedByTextBox.ReadOnly = True
        Me.InputedByTextBox.Size = New System.Drawing.Size(166, 20)
        Me.InputedByTextBox.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Inputted By:"
        '
        'cmdDownload
        '
        Me.cmdDownload.Location = New System.Drawing.Point(510, 351)
        Me.cmdDownload.Name = "cmdDownload"
        Me.cmdDownload.Size = New System.Drawing.Size(102, 27)
        Me.cmdDownload.TabIndex = 89
        Me.cmdDownload.Text = "Download"
        '
        'SharedAccessLevelTextBox
        '
        Me.SharedAccessLevelTextBox.FormattingEnabled = True
        Me.SharedAccessLevelTextBox.Items.AddRange(New Object() {"All", "Administrator", "Doctor"})
        Me.SharedAccessLevelTextBox.Location = New System.Drawing.Point(152, 219)
        Me.SharedAccessLevelTextBox.Name = "SharedAccessLevelTextBox"
        Me.SharedAccessLevelTextBox.Size = New System.Drawing.Size(148, 21)
        Me.SharedAccessLevelTextBox.TabIndex = 88
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.lblProjectName)
        Me.PanelHeader.Controls.Add(Me.cmdClose)
        Me.PanelHeader.Controls.Add(Me.cmdMinimize)
        Me.PanelBody.Controls.Add(Me.lblInformation)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1015, 25)
        Me.PanelHeader.TabIndex = 2
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.BackColor = System.Drawing.Color.Transparent
        Me.lblProjectName.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblProjectName.Location = New System.Drawing.Point(6, 4)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(247, 17)
        Me.lblProjectName.TabIndex = 1
        Me.lblProjectName.Text = "ORLABU Electrical Installation and Equipments - Digital Archieve"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Location = New System.Drawing.Point(989, 1)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(25, 22)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "X"
        '
        'cmdMinimize
        '
        Me.cmdMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdMinimize.Location = New System.Drawing.Point(963, 0)
        Me.cmdMinimize.Name = "cmdMinimize"
        Me.cmdMinimize.Size = New System.Drawing.Size(25, 22)
        Me.cmdMinimize.TabIndex = 0
        Me.cmdMinimize.TabStop = False
        Me.cmdMinimize.Text = "_"
        '
        'lblInformation
        '
        Me.lblInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInformation.BackColor = System.Drawing.Color.Transparent
        Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblInformation.Location = New System.Drawing.Point(393, 5)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(352, 16)
        Me.lblInformation.TabIndex = 1
        '
        'lblFormName
        '
        Me.lblFormName.AutoSize = True
        Me.lblFormName.BackColor = System.Drawing.Color.Transparent
        Me.lblFormName.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormName.Location = New System.Drawing.Point(25, 61)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(122, 21)
        Me.lblFormName.TabIndex = 1
        Me.lblFormName.Text = "Digital Archieve"
        '
        'AttachmentFilePictureBox
        '
        Me.AttachmentFilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AttachmentFilePictureBox.Location = New System.Drawing.Point(634, 103)
        Me.AttachmentFilePictureBox.Name = "AttachmentFilePictureBox"
        Me.AttachmentFilePictureBox.Size = New System.Drawing.Size(353, 239)
        Me.AttachmentFilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AttachmentFilePictureBox.TabIndex = 1
        Me.AttachmentFilePictureBox.TabStop = False
        '
        'DigitalArchieveDataGridView
        '
        Me.DigitalArchieveDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DigitalArchieveDataGridView.Location = New System.Drawing.Point(22, 394)
        Me.DigitalArchieveDataGridView.Name = "DigitalArchieveDataGridView"
        Me.DigitalArchieveDataGridView.Size = New System.Drawing.Size(965, 222)
        Me.DigitalArchieveDataGridView.TabIndex = 23
        '
        'lblNoPreview
        '
        Me.lblNoPreview.BackColor = System.Drawing.Color.Transparent
        Me.lblNoPreview.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoPreview.ForeColor = System.Drawing.Color.DimGray
        Me.lblNoPreview.Location = New System.Drawing.Point(728, 215)
        Me.lblNoPreview.Name = "lblNoPreview"
        Me.lblNoPreview.Size = New System.Drawing.Size(177, 21)
        Me.lblNoPreview.TabIndex = 1
        Me.lblNoPreview.Text = "No Preview Available"
        Me.lblNoPreview.Visible = False
        '
        'frmDigitalArchieve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 631)
        Me.Controls.Add(Me.PanelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDigitalArchieve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DigitalArchieve"
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.PanelBody.ResumeLayout(False)
        Me.PanelBody.PerformLayout()
        Me.PanelExporting.ResumeLayout(False)
        Me.PanelExporting.PerformLayout()
        Me.PanelProgressbarContainer.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.AttachmentFilePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalArchieveDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ArchieveIDTextBox As DevExpress.XtraEditors.TextEdit

    Friend WithEvents SubjectTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TypeOfAttachmentTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TitleTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DetailsOfDocumentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SearchKeywordTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TheFileNameTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AttachmentFilePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents cmdBrowseAttachmentFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RegDateTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ArchieveIDLabel As DevExpress.XtraEditors.LabelControl

    Friend WithEvents SubjectLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TypeOfAttachmentLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TitleLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DetailsOfDocumentLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SearchKeywordLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TheFileNameLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AttachmentFileLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SharedAccessLevelLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RegDateLabel As DevExpress.XtraEditors.LabelControl

    Friend WithEvents PanelOrange As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelBody As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelHeader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblProjectName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblInformation As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdMinimize As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblFormName As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents MyExportBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ExportToExcellToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents SharedAccessLevelTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents cmdDownload As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents InputedByTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DigitalArchieveDataGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents lblNoPreview As DevExpress.XtraEditors.LabelControl
End Class
