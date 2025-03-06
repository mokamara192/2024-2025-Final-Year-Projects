<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessages
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelBody = New DevExpress.XtraEditors.PanelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelNewMessage = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCloseNewMessage = New DevExpress.XtraEditors.LabelControl()
        Me.cmdAttachFile = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAttachment = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMessage = New System.Windows.Forms.RichTextBox()
        Me.chkUrgency = New System.Windows.Forms.CheckBox()

        Me.txtSubject = New DevExpress.XtraEditors.TextEdit()
        Me.cmdReceipient2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSend = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelReceipients = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCloseReceipient = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox3 = New DevExpress.XtraEditors.GroupControl()
        Me.lstDepartments = New System.Windows.Forms.ListBox()
        Me.chkCheckAll = New System.Windows.Forms.CheckBox()
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.lvReceipientsEmployees = New System.Windows.Forms.ListView()
        Me.ReceipientImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdReceipients = New DevExpress.XtraEditors.SimpleButton()
        Me.lblView = New DevExpress.XtraEditors.LabelControl()
        Me.pbStatus = New System.Windows.Forms.PictureBox()
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl()
        Me.lvNewMessages = New System.Windows.Forms.ListView()
        Me.Sender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)

        Me.MessageSubject = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MessageUrgency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MessageDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelMessageSummary = New DevExpress.XtraEditors.PanelControl()
        Me.Label20 = New DevExpress.XtraEditors.LabelControl()
        Me.lblOutbox = New DevExpress.XtraEditors.LabelControl()
        Me.Label19 = New DevExpress.XtraEditors.LabelControl()
        Me.Label18 = New DevExpress.XtraEditors.LabelControl()
        Me.lblRead = New DevExpress.XtraEditors.LabelControl()
        Me.Label16 = New DevExpress.XtraEditors.LabelControl()
        Me.lblNormalInbox = New DevExpress.XtraEditors.LabelControl()
        Me.Label15 = New DevExpress.XtraEditors.LabelControl()
        Me.lblUrgentInbox = New DevExpress.XtraEditors.LabelControl()
        Me.Label14 = New DevExpress.XtraEditors.LabelControl()
        Me.lblUserName = New DevExpress.XtraEditors.LabelControl()
        Me.Label13 = New DevExpress.XtraEditors.LabelControl()
        Me.lvSent = New System.Windows.Forms.ListView()
        Me.ReceipientName2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)

        Me.Subject2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Urgency2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InputDate2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MessageID2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvRead = New System.Windows.Forms.ListView()
        Me.SenderName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)

        Me.Subject = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Urgency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InputDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MessageID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelMain = New DevExpress.XtraEditors.PanelControl()
        Me.cmdSummary = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdRead = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOutbox = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNewMessages = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdInbox = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNewMessage = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New DevExpress.XtraEditors.LabelControl()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelViewMessage = New DevExpress.XtraEditors.PanelControl()
        Me.MyListView = New System.Windows.Forms.ListView()
        Me.MyImageListAttachment = New System.Windows.Forms.ImageList(Me.components)
        Me.txtViewMessage = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopySelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdMainMenu = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbSender = New System.Windows.Forms.PictureBox()
        Me.lblDate = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()

        Me.lblSubject = New DevExpress.XtraEditors.LabelControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.lblSender = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.MyImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.tmrUnlockReceipients = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLockReceipients = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelBody.SuspendLayout()
        Me.PanelNewMessage.SuspendLayout()
        Me.PanelReceipients.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pbStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMessageSummary.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelViewMessage.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBody
        '
        Me.PanelBody.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelBody.Controls.Add(Me.Label6)
        Me.PanelBody.Controls.Add(Me.PanelNewMessage)
        Me.PanelBody.Controls.Add(Me.PanelReceipients)
        Me.PanelBody.Controls.Add(Me.cmdReceipients)
        Me.PanelBody.Controls.Add(Me.lblView)
        Me.PanelBody.Controls.Add(Me.pbStatus)
        Me.PanelBody.Controls.Add(Me.lblStatus)
        Me.PanelBody.Controls.Add(Me.lvNewMessages)
        Me.PanelBody.Controls.Add(Me.PanelMessageSummary)
        Me.PanelBody.Controls.Add(Me.lvSent)
        Me.PanelBody.Controls.Add(Me.lvRead)
        Me.PanelBody.Controls.Add(Me.PanelMain)
        Me.PanelBody.Controls.Add(Me.PanelViewMessage)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(0, 0)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(785, 512)
        Me.PanelBody.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(9, 487)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(244, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Developed by: Amsoft Enterprise (SL) Ltd"
        '
        'PanelNewMessage
        '
        Me.PanelNewMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelNewMessage.Controls.Add(Me.cmdCloseNewMessage)
        Me.PanelNewMessage.Controls.Add(Me.cmdAttachFile)
        Me.PanelNewMessage.Controls.Add(Me.txtAttachment)
        Me.PanelNewMessage.Controls.Add(Me.Label1)
        Me.PanelNewMessage.Controls.Add(Me.txtMessage)
        Me.PanelNewMessage.Controls.Add(Me.chkUrgency)

        Me.PanelNewMessage.Controls.Add(Me.txtSubject)
        Me.PanelNewMessage.Controls.Add(Me.cmdReceipient2)
        Me.PanelNewMessage.Controls.Add(Me.Label4)
        Me.PanelNewMessage.Controls.Add(Me.Label8)
        Me.PanelNewMessage.Controls.Add(Me.Label2)
        Me.PanelNewMessage.Controls.Add(Me.cmdSend)
        Me.PanelNewMessage.Location = New System.Drawing.Point(-333, 21)
        Me.PanelNewMessage.Name = "PanelNewMessage"
        Me.PanelNewMessage.Size = New System.Drawing.Size(505, 390)
        Me.PanelNewMessage.TabIndex = 8
        Me.PanelNewMessage.Visible = False
        '
        'cmdCloseNewMessage
        '
        Me.cmdCloseNewMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCloseNewMessage.AutoSize = True
        Me.cmdCloseNewMessage.ForeColor = System.Drawing.Color.Black
        Me.cmdCloseNewMessage.Location = New System.Drawing.Point(484, 6)
        Me.cmdCloseNewMessage.Name = "cmdCloseNewMessage"
        Me.cmdCloseNewMessage.Size = New System.Drawing.Size(14, 13)
        Me.cmdCloseNewMessage.TabIndex = 0
        Me.cmdCloseNewMessage.Text = "X"
        '
        'cmdAttachFile
        '
        Me.cmdAttachFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdAttachFile.Location = New System.Drawing.Point(413, 72)
        Me.cmdAttachFile.Name = "cmdAttachFile"
        Me.cmdAttachFile.Size = New System.Drawing.Size(78, 26)
        Me.cmdAttachFile.TabIndex = 22
        Me.cmdAttachFile.Text = "Attach File"
        '
        'txtAttachment
        '
        Me.txtAttachment.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttachment.Location = New System.Drawing.Point(81, 73)
        Me.txtAttachment.Name = "txtAttachment"
        Me.txtAttachment.ReadOnly = True
        Me.txtAttachment.Size = New System.Drawing.Size(326, 23)
        Me.txtAttachment.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Attachment:"
        '
        'txtMessage
        '
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMessage.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.Location = New System.Drawing.Point(13, 138)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(478, 207)
        Me.txtMessage.TabIndex = 24
        Me.txtMessage.Text = ""
        '
        'chkUrgency
        '
        Me.chkUrgency.AutoSize = True
        Me.chkUrgency.Location = New System.Drawing.Point(111, 105)
        Me.chkUrgency.Name = "chkUrgency"
        Me.chkUrgency.Size = New System.Drawing.Size(58, 17)
        Me.chkUrgency.TabIndex = 23
        Me.chkUrgency.Text = "Urgent"
        Me.chkUrgency.UseVisualStyleBackColor = True
        '

        'txtSubject
        '

        Me.txtSubject.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.txtSubject.Location = New System.Drawing.Point(80, 43)

        Me.txtSubject.Name = "txtSubject"

        Me.txtSubject.Size = New System.Drawing.Size(327, 23)

        Me.txtSubject.TabIndex = 20
        '
        'cmdReceipient2
        '
        Me.cmdReceipient2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdReceipient2.Location = New System.Drawing.Point(413, 42)
        Me.cmdReceipient2.Name = "cmdReceipient2"
        Me.cmdReceipient2.Size = New System.Drawing.Size(78, 26)
        Me.cmdReceipient2.TabIndex = 21
        Me.cmdReceipient2.Text = "Receipients"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "New Message"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Message Urgency:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1

        Me.Label2.Text = "Subject"
        '
        'cmdSend
        '
        Me.cmdSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSend.Location = New System.Drawing.Point(413, 351)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(78, 25)
        Me.cmdSend.TabIndex = 25
        Me.cmdSend.Text = "&Send"
        '
        'PanelReceipients
        '
        Me.PanelReceipients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelReceipients.Controls.Add(Me.cmdCloseReceipient)
        Me.PanelReceipients.Controls.Add(Me.GroupBox3)
        Me.PanelReceipients.Controls.Add(Me.chkCheckAll)
        Me.PanelReceipients.Controls.Add(Me.cmdRefresh)
        Me.PanelReceipients.Controls.Add(Me.lvReceipientsEmployees)
        Me.PanelReceipients.Location = New System.Drawing.Point(198, 46)
        Me.PanelReceipients.Name = "PanelReceipients"
        Me.PanelReceipients.Size = New System.Drawing.Size(557, 24)
        Me.PanelReceipients.TabIndex = 6
        Me.PanelReceipients.Visible = False
        '
        'cmdCloseReceipient
        '
        Me.cmdCloseReceipient.BackColor = System.Drawing.Color.SlateGray
        Me.cmdCloseReceipient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseReceipient.ForeColor = System.Drawing.Color.White
        Me.cmdCloseReceipient.Location = New System.Drawing.Point(538, -1)
        Me.cmdCloseReceipient.Name = "cmdCloseReceipient"
        Me.cmdCloseReceipient.Size = New System.Drawing.Size(18, 17)
        Me.cmdCloseReceipient.TabIndex = 6
        Me.cmdCloseReceipient.Text = "x"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstDepartments)
        Me.GroupBox3.Location = New System.Drawing.Point(352, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(195, 167)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Show"
        '
        'lstDepartments
        '
        Me.lstDepartments.FormattingEnabled = True
        Me.lstDepartments.Location = New System.Drawing.Point(6, 14)
        Me.lstDepartments.Name = "lstDepartments"
        Me.lstDepartments.Size = New System.Drawing.Size(183, 147)
        Me.lstDepartments.TabIndex = 0
        '
        'chkCheckAll
        '
        Me.chkCheckAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkCheckAll.AutoSize = True
        Me.chkCheckAll.Location = New System.Drawing.Point(354, 0)
        Me.chkCheckAll.Name = "chkCheckAll"
        Me.chkCheckAll.Size = New System.Drawing.Size(71, 17)
        Me.chkCheckAll.TabIndex = 2
        Me.chkCheckAll.Text = "Check All"
        Me.chkCheckAll.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRefresh.Location = New System.Drawing.Point(354, 16)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(83, 29)
        Me.cmdRefresh.TabIndex = 1
        Me.cmdRefresh.Text = "R&efresh"
        '
        'lvReceipientsEmployees
        '
        Me.lvReceipientsEmployees.CheckBoxes = True
        Me.lvReceipientsEmployees.LargeImageList = Me.ReceipientImageList
        Me.lvReceipientsEmployees.Location = New System.Drawing.Point(0, -1)
        Me.lvReceipientsEmployees.Name = "lvReceipientsEmployees"
        Me.lvReceipientsEmployees.Size = New System.Drawing.Size(346, 314)
        Me.lvReceipientsEmployees.SmallImageList = Me.ReceipientImageList
        Me.lvReceipientsEmployees.TabIndex = 0
        Me.lvReceipientsEmployees.UseCompatibleStateImageBehavior = False
        '
        'ReceipientImageList
        '
        Me.ReceipientImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ReceipientImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ReceipientImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'cmdReceipients
        '
        Me.cmdReceipients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdReceipients.ForeColor = System.Drawing.Color.Black
        Me.cmdReceipients.Location = New System.Drawing.Point(665, 21)
        Me.cmdReceipients.Name = "cmdReceipients"
        Me.cmdReceipients.Size = New System.Drawing.Size(89, 26)
        Me.cmdReceipients.TabIndex = 5
        Me.cmdReceipients.Text = "Receipients"
        '
        'lblView
        '
        Me.lblView.AutoSize = True
        Me.lblView.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblView.Location = New System.Drawing.Point(11, 30)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(145, 21)
        Me.lblView.TabIndex = 4
        Me.lblView.Text = "Messaging System"
        '
        'pbStatus
        '
        Me.pbStatus.BackColor = System.Drawing.Color.White
        Me.pbStatus.Location = New System.Drawing.Point(91, 207)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(80, 93)
        Me.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbStatus.TabIndex = 16
        Me.pbStatus.TabStop = False
        Me.pbStatus.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.DimGray
        Me.lblStatus.Location = New System.Drawing.Point(86, 299)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(95, 19)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.Text = "Inbox Empty"
        Me.lblStatus.Visible = False
        '
        'lvNewMessages
        '
        Me.lvNewMessages.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)

        Me.lvNewMessages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Sender, Me.MessageSubject, Me.MessageUrgency, Me.MessageDate})
        Me.lvNewMessages.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvNewMessages.LargeImageList = Me.ReceipientImageList
        Me.lvNewMessages.Location = New System.Drawing.Point(10, 60)
        Me.lvNewMessages.MultiSelect = False
        Me.lvNewMessages.Name = "lvNewMessages"
        Me.lvNewMessages.Size = New System.Drawing.Size(248, 395)
        Me.lvNewMessages.SmallImageList = Me.ReceipientImageList
        Me.lvNewMessages.TabIndex = 1
        Me.lvNewMessages.UseCompatibleStateImageBehavior = False
        Me.lvNewMessages.View = System.Windows.Forms.View.Details
        '
        'Sender
        '
        Me.Sender.Text = "Sender"
        '

        'MessageSubject
        '

        Me.MessageSubject.Text = "Subject"
        '
        'MessageUrgency
        '
        Me.MessageUrgency.Text = "Urgency"
        '
        'MessageDate
        '
        Me.MessageDate.Text = "Date Sent"
        '
        'PanelMessageSummary
        '
        Me.PanelMessageSummary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMessageSummary.BackColor = System.Drawing.Color.White
        Me.PanelMessageSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMessageSummary.Controls.Add(Me.Label20)
        Me.PanelMessageSummary.Controls.Add(Me.lblOutbox)
        Me.PanelMessageSummary.Controls.Add(Me.Label19)
        Me.PanelMessageSummary.Controls.Add(Me.Label18)
        Me.PanelMessageSummary.Controls.Add(Me.lblRead)
        Me.PanelMessageSummary.Controls.Add(Me.Label16)
        Me.PanelMessageSummary.Controls.Add(Me.lblNormalInbox)
        Me.PanelMessageSummary.Controls.Add(Me.Label15)
        Me.PanelMessageSummary.Controls.Add(Me.lblUrgentInbox)
        Me.PanelMessageSummary.Controls.Add(Me.Label14)
        Me.PanelMessageSummary.Controls.Add(Me.lblUserName)
        Me.PanelMessageSummary.Controls.Add(Me.Label13)
        Me.PanelMessageSummary.Location = New System.Drawing.Point(11, 60)
        Me.PanelMessageSummary.Name = "PanelMessageSummary"
        Me.PanelMessageSummary.Size = New System.Drawing.Size(247, 395)
        Me.PanelMessageSummary.TabIndex = 14
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(33, 196)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 18)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Outbox:"
        '
        'lblOutbox
        '
        Me.lblOutbox.AutoSize = True
        Me.lblOutbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOutbox.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutbox.ForeColor = System.Drawing.Color.DimGray
        Me.lblOutbox.Location = New System.Drawing.Point(107, 196)
        Me.lblOutbox.Name = "lblOutbox"
        Me.lblOutbox.Size = New System.Drawing.Size(15, 18)
        Me.lblOutbox.TabIndex = 0
        Me.lblOutbox.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(33, 217)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 18)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Read:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(46, 170)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 18)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Normal:"
        '
        'lblRead
        '
        Me.lblRead.AutoSize = True
        Me.lblRead.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRead.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRead.ForeColor = System.Drawing.Color.DimGray
        Me.lblRead.Location = New System.Drawing.Point(107, 217)
        Me.lblRead.Name = "lblRead"
        Me.lblRead.Size = New System.Drawing.Size(15, 18)
        Me.lblRead.TabIndex = 0
        Me.lblRead.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(46, 146)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 18)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Urgent:"
        '
        'lblNormalInbox
        '
        Me.lblNormalInbox.AutoSize = True
        Me.lblNormalInbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNormalInbox.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNormalInbox.ForeColor = System.Drawing.Color.DimGray
        Me.lblNormalInbox.Location = New System.Drawing.Point(107, 170)
        Me.lblNormalInbox.Name = "lblNormalInbox"
        Me.lblNormalInbox.Size = New System.Drawing.Size(15, 18)
        Me.lblNormalInbox.TabIndex = 0
        Me.lblNormalInbox.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(32, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 18)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Inbox"
        '
        'lblUrgentInbox
        '
        Me.lblUrgentInbox.AutoSize = True
        Me.lblUrgentInbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUrgentInbox.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUrgentInbox.ForeColor = System.Drawing.Color.DimGray
        Me.lblUrgentInbox.Location = New System.Drawing.Point(107, 146)
        Me.lblUrgentInbox.Name = "lblUrgentInbox"
        Me.lblUrgentInbox.Size = New System.Drawing.Size(15, 18)
        Me.lblUrgentInbox.TabIndex = 0
        Me.lblUrgentInbox.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label14.Location = New System.Drawing.Point(17, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Message Summary"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.Black
        Me.lblUserName.Location = New System.Drawing.Point(41, 41)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(139, 19)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "Alhaji Jamiru Sesay"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label13.Location = New System.Drawing.Point(17, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 23)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Welcome"
        '
        'lvSent
        '
        Me.lvSent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)

        Me.lvSent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ReceipientName2, Me.Status, Me.Subject2, Me.Urgency2, Me.InputDate2, Me.MessageID2})
        Me.lvSent.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSent.LargeImageList = Me.ReceipientImageList
        Me.lvSent.Location = New System.Drawing.Point(10, 60)
        Me.lvSent.Name = "lvSent"
        Me.lvSent.Size = New System.Drawing.Size(248, 395)
        Me.lvSent.SmallImageList = Me.ReceipientImageList
        Me.lvSent.TabIndex = 1
        Me.lvSent.UseCompatibleStateImageBehavior = False
        Me.lvSent.View = System.Windows.Forms.View.Details
        '
        'ReceipientName2
        '
        Me.ReceipientName2.Text = "Receipient"
        Me.ReceipientName2.Width = 108
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 70
        '

        'Subject2
        '

        Me.Subject2.Text = "Subject"

        Me.Subject2.Width = 71
        '
        'Urgency2
        '
        Me.Urgency2.Text = "Urgency"
        '
        'InputDate2
        '
        Me.InputDate2.Text = "Date"
        '
        'MessageID2
        '
        Me.MessageID2.Text = "Message ID"
        '
        'lvRead
        '
        Me.lvRead.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)

        Me.lvRead.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SenderName, Me.Subject, Me.Urgency, Me.InputDate, Me.MessageID})
        Me.lvRead.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRead.LargeImageList = Me.ReceipientImageList
        Me.lvRead.Location = New System.Drawing.Point(10, 60)
        Me.lvRead.Name = "lvRead"
        Me.lvRead.Size = New System.Drawing.Size(248, 395)
        Me.lvRead.SmallImageList = Me.ReceipientImageList
        Me.lvRead.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvRead.TabIndex = 0
        Me.lvRead.UseCompatibleStateImageBehavior = False
        Me.lvRead.View = System.Windows.Forms.View.Details
        '
        'SenderName
        '
        Me.SenderName.Text = "Sender"
        Me.SenderName.Width = 80
        '

        'Subject
        '

        Me.Subject.Text = "Subject"

        Me.Subject.Width = 73
        '
        'Urgency
        '
        Me.Urgency.Text = "Urgency"
        Me.Urgency.Width = 70
        '
        'InputDate
        '
        Me.InputDate.Text = "Date"
        '
        'MessageID
        '
        Me.MessageID.Text = "MessageID"
        '
        'PanelMain
        '
        Me.PanelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMain.BackColor = System.Drawing.Color.White
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Controls.Add(Me.cmdSummary)
        Me.PanelMain.Controls.Add(Me.cmdRead)
        Me.PanelMain.Controls.Add(Me.cmdOutbox)
        Me.PanelMain.Controls.Add(Me.cmdNewMessages)
        Me.PanelMain.Controls.Add(Me.cmdInbox)
        Me.PanelMain.Controls.Add(Me.cmdNewMessage)
        Me.PanelMain.Controls.Add(Me.PictureBox2)
        Me.PanelMain.Controls.Add(Me.Label12)
        Me.PanelMain.Controls.Add(Me.Label9)
        Me.PanelMain.Location = New System.Drawing.Point(257, 60)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(513, 395)
        Me.PanelMain.TabIndex = 13
        '
        'cmdSummary
        '
        Me.cmdSummary.Location = New System.Drawing.Point(34, 243)
        Me.cmdSummary.Name = "cmdSummary"
        Me.cmdSummary.Size = New System.Drawing.Size(114, 28)
        Me.cmdSummary.TabIndex = 19
        Me.cmdSummary.Text = "V&iew Summary"
        '
        'cmdRead
        '
        Me.cmdRead.Location = New System.Drawing.Point(34, 207)
        Me.cmdRead.Name = "cmdRead"
        Me.cmdRead.Size = New System.Drawing.Size(114, 28)
        Me.cmdRead.TabIndex = 18
        Me.cmdRead.Text = "&Read"
        '
        'cmdOutbox
        '
        Me.cmdOutbox.Location = New System.Drawing.Point(34, 173)
        Me.cmdOutbox.Name = "cmdOutbox"
        Me.cmdOutbox.Size = New System.Drawing.Size(114, 28)
        Me.cmdOutbox.TabIndex = 18
        Me.cmdOutbox.Text = "O&utbox"
        '
        'cmdNewMessages
        '
        Me.cmdNewMessages.Location = New System.Drawing.Point(34, 105)
        Me.cmdNewMessages.Name = "cmdNewMessages"
        Me.cmdNewMessages.Size = New System.Drawing.Size(114, 28)
        Me.cmdNewMessages.TabIndex = 18
        Me.cmdNewMessages.Text = "&New Message"
        '
        'cmdInbox
        '
        Me.cmdInbox.Location = New System.Drawing.Point(34, 139)
        Me.cmdInbox.Name = "cmdInbox"
        Me.cmdInbox.Size = New System.Drawing.Size(114, 28)
        Me.cmdInbox.TabIndex = 18
        Me.cmdInbox.Text = "&Inbox"
        '
        'cmdNewMessage
        '
        Me.cmdNewMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNewMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdNewMessage.Location = New System.Drawing.Point(451, 15)
        Me.cmdNewMessage.Name = "cmdNewMessage"
        Me.cmdNewMessage.Size = New System.Drawing.Size(46, 45)
        Me.cmdNewMessage.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.MoCTIMIS.My.Resources.edit_paste_9
        Me.PictureBox2.Location = New System.Drawing.Point(424, 312)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGray
        Me.Label12.Location = New System.Drawing.Point(23, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(229, 19)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Internal Messaging System"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Chocolate
        Me.Label9.Location = New System.Drawing.Point(22, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 26)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ORLABU Electrical Installation and Equipments"
        '
        'PanelViewMessage
        '
        Me.PanelViewMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelViewMessage.BackColor = System.Drawing.Color.White
        Me.PanelViewMessage.Controls.Add(Me.MyListView)
        Me.PanelViewMessage.Controls.Add(Me.txtViewMessage)
        Me.PanelViewMessage.Controls.Add(Me.cmdMainMenu)
        Me.PanelViewMessage.Controls.Add(Me.PictureBox1)
        Me.PanelViewMessage.Controls.Add(Me.pbSender)
        Me.PanelViewMessage.Controls.Add(Me.lblDate)
        Me.PanelViewMessage.Controls.Add(Me.Label7)

        Me.PanelViewMessage.Controls.Add(Me.lblSubject)
        Me.PanelViewMessage.Controls.Add(Me.Label5)
        Me.PanelViewMessage.Controls.Add(Me.lblSender)
        Me.PanelViewMessage.Controls.Add(Me.Label3)
        Me.PanelViewMessage.Location = New System.Drawing.Point(260, 62)
        Me.PanelViewMessage.Name = "PanelViewMessage"
        Me.PanelViewMessage.Size = New System.Drawing.Size(510, 394)
        Me.PanelViewMessage.TabIndex = 12
        '
        'MyListView
        '
        Me.MyListView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MyListView.LargeImageList = Me.MyImageListAttachment
        Me.MyListView.Location = New System.Drawing.Point(11, 319)
        Me.MyListView.Name = "MyListView"
        Me.MyListView.Size = New System.Drawing.Size(490, 72)
        Me.MyListView.SmallImageList = Me.MyImageListAttachment
        Me.MyListView.TabIndex = 14
        Me.MyListView.UseCompatibleStateImageBehavior = False
        '
        'MyImageListAttachment
        '
        Me.MyImageListAttachment.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.MyImageListAttachment.ImageSize = New System.Drawing.Size(16, 16)
        Me.MyImageListAttachment.TransparentColor = System.Drawing.Color.Transparent
        '
        'txtViewMessage
        '
        Me.txtViewMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtViewMessage.BackColor = System.Drawing.Color.White
        Me.txtViewMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtViewMessage.ContextMenuStrip = Me.ContextMenuStrip2
        Me.txtViewMessage.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViewMessage.Location = New System.Drawing.Point(12, 102)
        Me.txtViewMessage.Name = "txtViewMessage"
        Me.txtViewMessage.ReadOnly = True
        Me.txtViewMessage.Size = New System.Drawing.Size(489, 211)
        Me.txtViewMessage.TabIndex = 13
        Me.txtViewMessage.Text = ""
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopySelectionToolStripMenuItem, Me.HideToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(154, 48)
        '
        'CopySelectionToolStripMenuItem
        '
        Me.CopySelectionToolStripMenuItem.Name = "CopySelectionToolStripMenuItem"
        Me.CopySelectionToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CopySelectionToolStripMenuItem.Text = "Copy Selection"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'cmdMainMenu
        '
        Me.cmdMainMenu.Location = New System.Drawing.Point(418, 4)
        Me.cmdMainMenu.Name = "cmdMainMenu"
        Me.cmdMainMenu.Size = New System.Drawing.Size(76, 26)
        Me.cmdMainMenu.TabIndex = 12
        Me.cmdMainMenu.Text = "Main Menu"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(422, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'pbSender
        '
        Me.pbSender.Location = New System.Drawing.Point(11, 10)
        Me.pbSender.Name = "pbSender"
        Me.pbSender.Size = New System.Drawing.Size(89, 82)
        Me.pbSender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSender.TabIndex = 11
        Me.pbSender.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(171, 61)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(35, 15)
        Me.lblDate.TabIndex = 9
        Me.lblDate.Text = "Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(116, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 14)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Date:"
        '

        'lblSubject
        '

        Me.lblSubject.AutoSize = True

        Me.lblSubject.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.lblSubject.Location = New System.Drawing.Point(171, 36)

        Me.lblSubject.Name = "lblSubject"

        Me.lblSubject.Size = New System.Drawing.Size(50, 15)

        Me.lblSubject.TabIndex = 9

        Me.lblSubject.Text = "Subject:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(116, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 14)
        Me.Label5.TabIndex = 9

        Me.Label5.Text = "Subject:"
        '
        'lblSender
        '
        Me.lblSender.AutoSize = True
        Me.lblSender.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSender.Location = New System.Drawing.Point(171, 10)
        Me.lblSender.Name = "lblSender"
        Me.lblSender.Size = New System.Drawing.Size(40, 15)
        Me.lblSender.TabIndex = 9
        Me.lblSender.Text = "From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 14)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "From:"
        '
        'MyImageList
        '
        Me.MyImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.MyImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.MyImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'tmrUnlockReceipients
        '
        Me.tmrUnlockReceipients.Interval = 10
        '
        'tmrLockReceipients
        '
        Me.tmrLockReceipients.Interval = 10
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 20000
        Me.ToolTip1.AutoPopDelay = 20000
        Me.ToolTip1.InitialDelay = 0
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReplyToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(157, 70)
        '
        'ReplyToolStripMenuItem
        '
        Me.ReplyToolStripMenuItem.Name = "ReplyToolStripMenuItem"
        Me.ReplyToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ReplyToolStripMenuItem.Text = "Reply Sender"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete Message"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'frmMessages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(785, 512)
        Me.Controls.Add(Me.PanelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMessages"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Messages"
        Me.PanelBody.ResumeLayout(False)
        Me.PanelBody.PerformLayout()
        Me.PanelNewMessage.ResumeLayout(False)
        Me.PanelNewMessage.PerformLayout()
        Me.PanelReceipients.ResumeLayout(False)
        Me.PanelReceipients.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.pbStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMessageSummary.ResumeLayout(False)
        Me.PanelMessageSummary.PerformLayout()
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelViewMessage.ResumeLayout(False)
        Me.PanelViewMessage.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSender, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents PanelBody As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdSend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents lblView As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lvRead As System.Windows.Forms.ListView
    Friend WithEvents lvSent As System.Windows.Forms.ListView
    Friend WithEvents cmdReceipients As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelReceipients As DevExpress.XtraEditors.PanelControl
    Friend WithEvents chkCheckAll As System.Windows.Forms.CheckBox
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lvReceipientsEmployees As System.Windows.Forms.ListView
    Friend WithEvents MyImageList As System.Windows.Forms.ImageList
    Friend WithEvents tmrUnlockReceipients As System.Windows.Forms.Timer
    Friend WithEvents tmrLockReceipients As System.Windows.Forms.Timer
    Friend WithEvents lvNewMessages As System.Windows.Forms.ListView
    Friend WithEvents GroupBox3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ReceipientImageList As System.Windows.Forms.ImageList
    Friend WithEvents chkUrgency As System.Windows.Forms.CheckBox
    Friend WithEvents PanelNewMessage As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCloseNewMessage As DevExpress.XtraEditors.LabelControl



    Friend WithEvents txtSubject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdReceipient2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNewMessage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SenderName As System.Windows.Forms.ColumnHeader



    Friend WithEvents Subject As System.Windows.Forms.ColumnHeader
    Friend WithEvents Urgency As System.Windows.Forms.ColumnHeader
    Friend WithEvents InputDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents MessageID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ReceipientName2 As System.Windows.Forms.ColumnHeader



    Friend WithEvents Subject2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Urgency2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents InputDate2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MessageID2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdCloseReceipient As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl



    Friend WithEvents lblSubject As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSender As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pbSender As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelViewMessage As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelMain As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelMessageSummary As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblOutbox As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRead As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNormalInbox As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUrgentInbox As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUserName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdRead As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOutbox As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdInbox As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNewMessages As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdMainMenu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pbStatus As System.Windows.Forms.PictureBox
    Friend WithEvents cmdSummary As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtViewMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopySelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdAttachFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAttachment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MyListView As System.Windows.Forms.ListView
    Friend WithEvents MyImageListAttachment As System.Windows.Forms.ImageList
    Friend WithEvents lstDepartments As System.Windows.Forms.ListBox
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Sender As System.Windows.Forms.ColumnHeader


    Friend WithEvents MessageSubject As System.Windows.Forms.ColumnHeader
    Friend WithEvents MessageUrgency As System.Windows.Forms.ColumnHeader
    Friend WithEvents MessageDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
End Class
