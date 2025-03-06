<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSynchronize
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSynchronize))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TablesComboBox = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.radPull = New System.Windows.Forms.RadioButton()
        Me.radPush = New System.Windows.Forms.RadioButton()
        Me.cmdStart = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SyncDataGridView = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SyncBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.ProgressPanelSync = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.SearchDateFieldComboBox = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.EndDateTimePicker = New DevExpress.XtraEditors.DateEdit()
        Me.lblEndDate = New DevExpress.XtraEditors.LabelControl()
        Me.StartDateTimePicker = New DevExpress.XtraEditors.DateEdit()
        Me.lblStartDate = New DevExpress.XtraEditors.LabelControl()
        Me.lblDateField = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.lblNoofRecords = New System.Windows.Forms.Label()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.radDelete = New System.Windows.Forms.RadioButton()
        Me.radUpdate = New System.Windows.Forms.RadioButton()
        Me.radIgnore = New System.Windows.Forms.RadioButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.radEntireDatabase = New System.Windows.Forms.RadioButton()
        Me.radSpecificTable = New System.Windows.Forms.RadioButton()
        Me.chkDateFilter = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl1.SuspendLayout
        CType(Me.TablesComboBox.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl2.SuspendLayout
        CType(Me.SyncDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl3.SuspendLayout
        CType(Me.SearchDateFieldComboBox.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EndDateTimePicker.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EndDateTimePicker.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.StartDateTimePicker.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.StartDateTimePicker.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl4,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl4.SuspendLayout
        CType(Me.PictureEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chkDateFilter.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.radEntireDatabase)
        Me.GroupControl1.Controls.Add(Me.radSpecificTable)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.TablesComboBox)
        Me.GroupControl1.Location = New System.Drawing.Point(19, 54)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(295, 79)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Select the table you wish to use"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(21, 53)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Table:"
        '
        'TablesComboBox
        '
        Me.TablesComboBox.Location = New System.Drawing.Point(57, 50)
        Me.TablesComboBox.Name = "TablesComboBox"
        Me.TablesComboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TablesComboBox.Size = New System.Drawing.Size(212, 20)
        Me.TablesComboBox.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.radPull)
        Me.GroupControl2.Controls.Add(Me.radPush)
        Me.GroupControl2.Location = New System.Drawing.Point(19, 138)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(295, 52)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "How to handle data to REMOTE Server"
        '
        'radPull
        '
        Me.radPull.AutoSize = true
        Me.radPull.Location = New System.Drawing.Point(156, 27)
        Me.radPull.Name = "radPull"
        Me.radPull.Size = New System.Drawing.Size(127, 17)
        Me.radPull.TabIndex = 0
        Me.radPull.Text = "Pull Data from Server"
        Me.radPull.UseVisualStyleBackColor = true
        '
        'radPush
        '
        Me.radPush.AutoSize = true
        Me.radPush.Checked = true
        Me.radPush.Location = New System.Drawing.Point(20, 27)
        Me.radPush.Name = "radPush"
        Me.radPush.Size = New System.Drawing.Size(122, 17)
        Me.radPush.TabIndex = 0
        Me.radPush.TabStop = true
        Me.radPush.Text = "Push Data to Server"
        Me.radPush.UseVisualStyleBackColor = true
        '
        'cmdStart
        '
        Me.cmdStart.Enabled = false
        Me.cmdStart.ImageOptions.Image = CType(resources.GetObject("cmdStart.ImageOptions.Image"),System.Drawing.Image)
        Me.cmdStart.Location = New System.Drawing.Point(19, 195)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(295, 28)
        Me.cmdStart.TabIndex = 1
        Me.cmdStart.Text = "Start Synchronization"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl1.Appearance.Options.UseFont = true
        Me.LabelControl1.Location = New System.Drawing.Point(72, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(223, 21)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Data Synchronization Wizard"
        '
        'SyncDataGridView
        '
        Me.SyncDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SyncDataGridView.Location = New System.Drawing.Point(19, 229)
        Me.SyncDataGridView.MainView = Me.GridView1
        Me.SyncDataGridView.Name = "SyncDataGridView"
        Me.SyncDataGridView.Size = New System.Drawing.Size(775, 299)
        Me.SyncDataGridView.TabIndex = 3
        Me.SyncDataGridView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.SyncDataGridView
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = false
        Me.GridView1.OptionsView.ShowFooter = true
        '
        'SyncBackgroundWorker
        '
        Me.SyncBackgroundWorker.WorkerReportsProgress = true
        Me.SyncBackgroundWorker.WorkerSupportsCancellation = true
        '
        'ProgressPanelSync
        '
        Me.ProgressPanelSync.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanelSync.Appearance.Options.UseBackColor = true
        Me.ProgressPanelSync.BarAnimationElementThickness = 2
        Me.ProgressPanelSync.Location = New System.Drawing.Point(189, 267)
        Me.ProgressPanelSync.Name = "ProgressPanelSync"
        Me.ProgressPanelSync.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ProgressPanelSync.Size = New System.Drawing.Size(457, 71)
        Me.ProgressPanelSync.TabIndex = 4
        Me.ProgressPanelSync.Text = "ProgressPanel1"
        Me.ProgressPanelSync.Visible = false
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.chkDateFilter)
        Me.GroupControl3.Controls.Add(Me.SearchDateFieldComboBox)
        Me.GroupControl3.Controls.Add(Me.EndDateTimePicker)
        Me.GroupControl3.Controls.Add(Me.lblEndDate)
        Me.GroupControl3.Controls.Add(Me.StartDateTimePicker)
        Me.GroupControl3.Controls.Add(Me.lblStartDate)
        Me.GroupControl3.Controls.Add(Me.lblDateField)
        Me.GroupControl3.Location = New System.Drawing.Point(526, 54)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(250, 136)
        Me.GroupControl3.TabIndex = 5
        Me.GroupControl3.Text = "Limit Search by Date"
        '
        'SearchDateFieldComboBox
        '
        Me.SearchDateFieldComboBox.Enabled = false
        Me.SearchDateFieldComboBox.Location = New System.Drawing.Point(85, 52)
        Me.SearchDateFieldComboBox.Name = "SearchDateFieldComboBox"
        Me.SearchDateFieldComboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchDateFieldComboBox.Size = New System.Drawing.Size(137, 20)
        Me.SearchDateFieldComboBox.TabIndex = 6
        '
        'EndDateTimePicker
        '
        Me.EndDateTimePicker.EditValue = Nothing
        Me.EndDateTimePicker.Enabled = false
        Me.EndDateTimePicker.Location = New System.Drawing.Point(85, 103)
        Me.EndDateTimePicker.Name = "EndDateTimePicker"
        Me.EndDateTimePicker.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EndDateTimePicker.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EndDateTimePicker.Size = New System.Drawing.Size(137, 20)
        Me.EndDateTimePicker.TabIndex = 58
        '
        'lblEndDate
        '
        Me.lblEndDate.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblEndDate.Appearance.Options.UseFont = true
        Me.lblEndDate.Location = New System.Drawing.Point(17, 103)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(51, 15)
        Me.lblEndDate.TabIndex = 54
        Me.lblEndDate.Text = "End Date:"
        '
        'StartDateTimePicker
        '
        Me.StartDateTimePicker.EditValue = Nothing
        Me.StartDateTimePicker.Enabled = false
        Me.StartDateTimePicker.Location = New System.Drawing.Point(85, 78)
        Me.StartDateTimePicker.Name = "StartDateTimePicker"
        Me.StartDateTimePicker.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StartDateTimePicker.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StartDateTimePicker.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.StartDateTimePicker.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDateTimePicker.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.StartDateTimePicker.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDateTimePicker.Size = New System.Drawing.Size(137, 20)
        Me.StartDateTimePicker.TabIndex = 59
        '
        'lblStartDate
        '
        Me.lblStartDate.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblStartDate.Appearance.Options.UseFont = true
        Me.lblStartDate.Location = New System.Drawing.Point(17, 78)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(57, 15)
        Me.lblStartDate.TabIndex = 55
        Me.lblStartDate.Text = "Start Date:"
        '
        'lblDateField
        '
        Me.lblDateField.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblDateField.Appearance.Options.UseFont = true
        Me.lblDateField.Location = New System.Drawing.Point(17, 55)
        Me.lblDateField.Name = "lblDateField"
        Me.lblDateField.Size = New System.Drawing.Size(58, 15)
        Me.lblDateField.TabIndex = 56
        Me.lblDateField.Text = "Date Field:"
        '
        'cmdSearch
        '
        Me.cmdSearch.ImageOptions.Image = CType(resources.GetObject("cmdSearch.ImageOptions.Image"),System.Drawing.Image)
        Me.cmdSearch.Location = New System.Drawing.Point(320, 195)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(200, 28)
        Me.cmdSearch.TabIndex = 6
        Me.cmdSearch.Text = "Search"
        '
        'lblNoofRecords
        '
        Me.lblNoofRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblNoofRecords.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblNoofRecords.Location = New System.Drawing.Point(589, 197)
        Me.lblNoofRecords.Name = "lblNoofRecords"
        Me.lblNoofRecords.Size = New System.Drawing.Size(205, 23)
        Me.lblNoofRecords.TabIndex = 7
        Me.lblNoofRecords.Text = "No Records Found"
        Me.lblNoofRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.radDelete)
        Me.GroupControl4.Controls.Add(Me.radUpdate)
        Me.GroupControl4.Controls.Add(Me.radIgnore)
        Me.GroupControl4.Location = New System.Drawing.Point(320, 54)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(200, 136)
        Me.GroupControl4.TabIndex = 8
        Me.GroupControl4.Text = "What to do with duplicate records"
        '
        'radDelete
        '
        Me.radDelete.AutoSize = true
        Me.radDelete.Location = New System.Drawing.Point(16, 77)
        Me.radDelete.Name = "radDelete"
        Me.radDelete.Size = New System.Drawing.Size(95, 17)
        Me.radDelete.TabIndex = 0
        Me.radDelete.Text = "Delete records"
        Me.radDelete.UseVisualStyleBackColor = true
        '
        'radUpdate
        '
        Me.radUpdate.AutoSize = true
        Me.radUpdate.Location = New System.Drawing.Point(16, 54)
        Me.radUpdate.Name = "radUpdate"
        Me.radUpdate.Size = New System.Drawing.Size(99, 17)
        Me.radUpdate.TabIndex = 0
        Me.radUpdate.Text = "Update records"
        Me.radUpdate.UseVisualStyleBackColor = true
        '
        'radIgnore
        '
        Me.radIgnore.AutoSize = true
        Me.radIgnore.Checked = true
        Me.radIgnore.Location = New System.Drawing.Point(16, 32)
        Me.radIgnore.Name = "radIgnore"
        Me.radIgnore.Size = New System.Drawing.Size(57, 17)
        Me.radIgnore.TabIndex = 0
        Me.radIgnore.TabStop = true
        Me.radIgnore.Text = "Ignore"
        Me.radIgnore.UseVisualStyleBackColor = true
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"),Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(19, 10)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = true
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(52, 42)
        Me.PictureEdit1.TabIndex = 9
        '
        'radEntireDatabase
        '
        Me.radEntireDatabase.AutoSize = true
        Me.radEntireDatabase.Location = New System.Drawing.Point(156, 28)
        Me.radEntireDatabase.Name = "radEntireDatabase"
        Me.radEntireDatabase.Size = New System.Drawing.Size(102, 17)
        Me.radEntireDatabase.TabIndex = 2
        Me.radEntireDatabase.Text = "Entire Database"
        Me.radEntireDatabase.UseVisualStyleBackColor = true
        '
        'radSpecificTable
        '
        Me.radSpecificTable.AutoSize = true
        Me.radSpecificTable.Checked = true
        Me.radSpecificTable.Location = New System.Drawing.Point(20, 28)
        Me.radSpecificTable.Name = "radSpecificTable"
        Me.radSpecificTable.Size = New System.Drawing.Size(119, 17)
        Me.radSpecificTable.TabIndex = 3
        Me.radSpecificTable.TabStop = true
        Me.radSpecificTable.Text = "Specific table below"
        Me.radSpecificTable.UseVisualStyleBackColor = true
        '
        'chkDateFilter
        '
        Me.chkDateFilter.Location = New System.Drawing.Point(85, 26)
        Me.chkDateFilter.Name = "chkDateFilter"
        Me.chkDateFilter.Properties.Caption = "Limit Records by Date"
        Me.chkDateFilter.Size = New System.Drawing.Size(126, 19)
        Me.chkDateFilter.TabIndex = 60
        '
        'frmSynchronize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 542)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.lblNoofRecords)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.ProgressPanelSync)
        Me.Controls.Add(Me.SyncDataGridView)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmSynchronize"
        Me.Text = "Synchronization Wizard"
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        Me.GroupControl1.PerformLayout
        CType(Me.TablesComboBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl2.ResumeLayout(false)
        Me.GroupControl2.PerformLayout
        CType(Me.SyncDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl3,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl3.ResumeLayout(false)
        Me.GroupControl3.PerformLayout
        CType(Me.SearchDateFieldComboBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EndDateTimePicker.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EndDateTimePicker.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.StartDateTimePicker.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.StartDateTimePicker.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl4,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl4.ResumeLayout(false)
        Me.GroupControl4.PerformLayout
        CType(Me.PictureEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chkDateFilter.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout


End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdStart As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SyncDataGridView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TablesComboBox As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents radPull As RadioButton
    Friend WithEvents radPush As RadioButton
    Friend WithEvents SyncBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressPanelSync As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SearchDateFieldComboBox As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents EndDateTimePicker As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblEndDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents StartDateTimePicker As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblStartDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateField As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblNoofRecords As Label
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents radDelete As RadioButton
    Friend WithEvents radUpdate As RadioButton
    Friend WithEvents radIgnore As RadioButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents radEntireDatabase As RadioButton
    Friend WithEvents radSpecificTable As RadioButton
    Friend WithEvents chkDateFilter As DevExpress.XtraEditors.CheckEdit
End Class
