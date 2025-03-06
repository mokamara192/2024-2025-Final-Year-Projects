<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageFileLoaderPagesDialog
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
        Me._tbFirstPage = New System.Windows.Forms.TextBox()
        Me._lblInfo = New System.Windows.Forms.Label()
        Me._gbPages = New System.Windows.Forms.GroupBox()
        Me._tbPageNumber = New System.Windows.Forms.TextBox()
        Me._lblPageNumber = New System.Windows.Forms.Label()
        Me._rbLoadMultiPages = New System.Windows.Forms.RadioButton()
        Me._rbLoadSinglePage = New System.Windows.Forms.RadioButton()
        Me._tbLastPage = New System.Windows.Forms.TextBox()
        Me._lblLastPage = New System.Windows.Forms.Label()
        Me._lblFirstPage = New System.Windows.Forms.Label()
        Me._btnCancel = New System.Windows.Forms.Button()
        Me._btnOk = New System.Windows.Forms.Button()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me._gbPages.SuspendLayout
        Me.SuspendLayout
        '
        '_tbFirstPage
        '
        Me._tbFirstPage.Location = New System.Drawing.Point(115, 149)
        Me._tbFirstPage.Margin = New System.Windows.Forms.Padding(2)
        Me._tbFirstPage.Name = "_tbFirstPage"
        Me._tbFirstPage.Size = New System.Drawing.Size(91, 20)
        Me._tbFirstPage.TabIndex = 2
        '
        '_lblInfo
        '
        Me._lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._lblInfo.Location = New System.Drawing.Point(14, 23)
        Me._lblInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me._lblInfo.Name = "_lblInfo"
        Me._lblInfo.Size = New System.Drawing.Size(216, 30)
        Me._lblInfo.TabIndex = 0
        Me._lblInfo.Text = "This file has ### total pages.  Select the $$$ you want to load:"
        '
        '_gbPages
        '
        Me._gbPages.Controls.Add(Me._tbPageNumber)
        Me._gbPages.Controls.Add(Me._lblPageNumber)
        Me._gbPages.Controls.Add(Me._rbLoadMultiPages)
        Me._gbPages.Controls.Add(Me._rbLoadSinglePage)
        Me._gbPages.Controls.Add(Me._tbLastPage)
        Me._gbPages.Controls.Add(Me._lblLastPage)
        Me._gbPages.Controls.Add(Me._tbFirstPage)
        Me._gbPages.Controls.Add(Me._lblInfo)
        Me._gbPages.Controls.Add(Me._lblFirstPage)
        Me._gbPages.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._gbPages.Location = New System.Drawing.Point(11, 6)
        Me._gbPages.Margin = New System.Windows.Forms.Padding(2)
        Me._gbPages.Name = "_gbPages"
        Me._gbPages.Padding = New System.Windows.Forms.Padding(2)
        Me._gbPages.Size = New System.Drawing.Size(244, 208)
        Me._gbPages.TabIndex = 6
        Me._gbPages.TabStop = false
        '
        '_tbPageNumber
        '
        Me._tbPageNumber.Location = New System.Drawing.Point(115, 89)
        Me._tbPageNumber.Margin = New System.Windows.Forms.Padding(2)
        Me._tbPageNumber.Name = "_tbPageNumber"
        Me._tbPageNumber.Size = New System.Drawing.Size(91, 20)
        Me._tbPageNumber.TabIndex = 9
        '
        '_lblPageNumber
        '
        Me._lblPageNumber.AutoSize = true
        Me._lblPageNumber.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._lblPageNumber.Location = New System.Drawing.Point(36, 92)
        Me._lblPageNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me._lblPageNumber.Name = "_lblPageNumber"
        Me._lblPageNumber.Size = New System.Drawing.Size(75, 13)
        Me._lblPageNumber.TabIndex = 8
        Me._lblPageNumber.Text = "Page Number:"
        Me._lblPageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_rbLoadMultiPages
        '
        Me._rbLoadMultiPages.AutoSize = true
        Me._rbLoadMultiPages.Location = New System.Drawing.Point(14, 123)
        Me._rbLoadMultiPages.Name = "_rbLoadMultiPages"
        Me._rbLoadMultiPages.Size = New System.Drawing.Size(105, 17)
        Me._rbLoadMultiPages.TabIndex = 7
        Me._rbLoadMultiPages.Text = "Load &multi-pages"
        Me._rbLoadMultiPages.UseVisualStyleBackColor = true
        '
        '_rbLoadSinglePage
        '
        Me._rbLoadSinglePage.AutoSize = true
        Me._rbLoadSinglePage.Location = New System.Drawing.Point(14, 65)
        Me._rbLoadSinglePage.Name = "_rbLoadSinglePage"
        Me._rbLoadSinglePage.Size = New System.Drawing.Size(106, 17)
        Me._rbLoadSinglePage.TabIndex = 6
        Me._rbLoadSinglePage.Text = "Load &single page"
        Me._rbLoadSinglePage.UseVisualStyleBackColor = true
        '
        '_tbLastPage
        '
        Me._tbLastPage.Location = New System.Drawing.Point(115, 176)
        Me._tbLastPage.Margin = New System.Windows.Forms.Padding(2)
        Me._tbLastPage.Name = "_tbLastPage"
        Me._tbLastPage.Size = New System.Drawing.Size(91, 20)
        Me._tbLastPage.TabIndex = 4
        '
        '_lblLastPage
        '
        Me._lblLastPage.AutoSize = true
        Me._lblLastPage.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._lblLastPage.Location = New System.Drawing.Point(36, 179)
        Me._lblLastPage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me._lblLastPage.Name = "_lblLastPage"
        Me._lblLastPage.Size = New System.Drawing.Size(58, 13)
        Me._lblLastPage.TabIndex = 3
        Me._lblLastPage.Text = "Last Page:"
        Me._lblLastPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_lblFirstPage
        '
        Me._lblFirstPage.AutoSize = true
        Me._lblFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._lblFirstPage.Location = New System.Drawing.Point(36, 152)
        Me._lblFirstPage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me._lblFirstPage.Name = "_lblFirstPage"
        Me._lblFirstPage.Size = New System.Drawing.Size(57, 13)
        Me._lblFirstPage.TabIndex = 1
        Me._lblFirstPage.Text = "First Page:"
        Me._lblFirstPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_btnCancel
        '
        Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._btnCancel.Location = New System.Drawing.Point(264, 43)
        Me._btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me._btnCancel.Name = "_btnCancel"
        Me._btnCancel.Size = New System.Drawing.Size(77, 26)
        Me._btnCancel.TabIndex = 8
        Me._btnCancel.Text = "Cancel"
        '
        '_btnOk
        '
        Me._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._btnOk.Location = New System.Drawing.Point(264, 13)
        Me._btnOk.Margin = New System.Windows.Forms.Padding(2)
        Me._btnOk.Name = "_btnOk"
        Me._btnOk.Size = New System.Drawing.Size(77, 26)
        Me._btnOk.TabIndex = 7
        Me._btnOk.Text = "OK"
        '
        'ImageFileLoaderPagesDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 230)
        Me.Controls.Add(Me._gbPages)
        Me.Controls.Add(Me._btnCancel)
        Me.Controls.Add(Me._btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "ImageFileLoaderPagesDialog"
        Me.Text = "Image File Loader Pages"
        Me._gbPages.ResumeLayout(false)
        Me._gbPages.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Private WithEvents _tbFirstPage As TextBox
    Private WithEvents _lblInfo As Label
    Private WithEvents _gbPages As GroupBox
    Private WithEvents _tbPageNumber As TextBox
    Private WithEvents _lblPageNumber As Label
    Private WithEvents _rbLoadMultiPages As RadioButton
    Private WithEvents _rbLoadSinglePage As RadioButton
    Private WithEvents _tbLastPage As TextBox
    Private WithEvents _lblLastPage As Label
    Private WithEvents _lblFirstPage As Label
    Private WithEvents _btnCancel As Button
    Private WithEvents _btnOk As Button
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
End Class
