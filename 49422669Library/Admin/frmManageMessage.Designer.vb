<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageMessage
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
        Me.lstMessages = New System.Windows.Forms.ListView()
        Me.msg_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sender_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sender_fn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rec_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rec_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.message = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReply = New System.Windows.Forms.Button()
        Me.btnCompose = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.AdminMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResfreshPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageMessagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageBorrowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageReservesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowTouseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberMenu = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserRefreshPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserMessages = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserReserves = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserHowToUse = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.AdminMenu.SuspendLayout()
        Me.MemberMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstMessages
        '
        Me.lstMessages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.msg_id, Me.sender_no, Me.sender_fn, Me.rec_no, Me.rec_name, Me.message, Me.status})
        Me.lstMessages.FullRowSelect = True
        Me.lstMessages.GridLines = True
        Me.lstMessages.Location = New System.Drawing.Point(4, 14)
        Me.lstMessages.Name = "lstMessages"
        Me.lstMessages.Size = New System.Drawing.Size(842, 356)
        Me.lstMessages.TabIndex = 30
        Me.lstMessages.UseCompatibleStateImageBehavior = False
        Me.lstMessages.View = System.Windows.Forms.View.Details
        '
        'msg_id
        '
        Me.msg_id.Text = "Message Id"
        Me.msg_id.Width = 80
        '
        'sender_no
        '
        Me.sender_no.Text = "Sender Membership Number"
        Me.sender_no.Width = 107
        '
        'sender_fn
        '
        Me.sender_fn.Text = "Sender Name"
        Me.sender_fn.Width = 95
        '
        'rec_no
        '
        Me.rec_no.Text = "Receiver Membership Number"
        Me.rec_no.Width = 110
        '
        'rec_name
        '
        Me.rec_name.Text = "Receiver Name"
        Me.rec_name.Width = 97
        '
        'message
        '
        Me.message.Text = "Message"
        Me.message.Width = 260
        '
        'status
        '
        Me.status.Text = "Status"
        Me.status.Width = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 36)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "46422669 Library"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(880, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Manage Messages"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnReply)
        Me.Panel1.Controls.Add(Me.btnCompose)
        Me.Panel1.Controls.Add(Me.btnRead)
        Me.Panel1.Controls.Add(Me.lstMessages)
        Me.Panel1.Location = New System.Drawing.Point(13, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(994, 382)
        Me.Panel1.TabIndex = 38
        '
        'btnBack
        '
        Me.btnBack.ForeColor = System.Drawing.Color.Teal
        Me.btnBack.Location = New System.Drawing.Point(866, 316)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(108, 36)
        Me.btnBack.TabIndex = 43
        Me.btnBack.Text = "B&ack"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.ForeColor = System.Drawing.Color.Teal
        Me.btnDelete.Location = New System.Drawing.Point(866, 195)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(108, 36)
        Me.btnDelete.TabIndex = 41
        Me.btnDelete.Text = "&Delete Message"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReply
        '
        Me.btnReply.ForeColor = System.Drawing.Color.Teal
        Me.btnReply.Location = New System.Drawing.Point(866, 136)
        Me.btnReply.Name = "btnReply"
        Me.btnReply.Size = New System.Drawing.Size(108, 36)
        Me.btnReply.TabIndex = 40
        Me.btnReply.Text = "Reply Message"
        Me.btnReply.UseVisualStyleBackColor = True
        '
        'btnCompose
        '
        Me.btnCompose.ForeColor = System.Drawing.Color.Teal
        Me.btnCompose.Location = New System.Drawing.Point(866, 75)
        Me.btnCompose.Name = "btnCompose"
        Me.btnCompose.Size = New System.Drawing.Size(108, 36)
        Me.btnCompose.TabIndex = 39
        Me.btnCompose.Text = "&Compose Message"
        Me.btnCompose.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.ForeColor = System.Drawing.Color.Teal
        Me.btnRead.Location = New System.Drawing.Point(866, 14)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(108, 36)
        Me.btnRead.TabIndex = 38
        Me.btnRead.Text = "Read &Message"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'AdminMenu
        '
        Me.AdminMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.NavigateToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.AdminMenu.Location = New System.Drawing.Point(0, 0)
        Me.AdminMenu.Name = "AdminMenu"
        Me.AdminMenu.Size = New System.Drawing.Size(1019, 24)
        Me.AdminMenu.TabIndex = 41
        Me.AdminMenu.Text = "MenuStrip1"
        Me.AdminMenu.Visible = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ResfreshPageToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "&Logout"
        '
        'ResfreshPageToolStripMenuItem
        '
        Me.ResfreshPageToolStripMenuItem.Name = "ResfreshPageToolStripMenuItem"
        Me.ResfreshPageToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ResfreshPageToolStripMenuItem.Text = "&Refresh Page"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'NavigateToolStripMenuItem
        '
        Me.NavigateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageUsersToolStripMenuItem, Me.ManageMessagesToolStripMenuItem, Me.ManageBooksToolStripMenuItem, Me.ManageBorrowsToolStripMenuItem, Me.ManageReservesToolStripMenuItem})
        Me.NavigateToolStripMenuItem.Name = "NavigateToolStripMenuItem"
        Me.NavigateToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.NavigateToolStripMenuItem.Text = "&Navigate"
        '
        'ManageUsersToolStripMenuItem
        '
        Me.ManageUsersToolStripMenuItem.Name = "ManageUsersToolStripMenuItem"
        Me.ManageUsersToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ManageUsersToolStripMenuItem.Text = "Manage &Users"
        '
        'ManageMessagesToolStripMenuItem
        '
        Me.ManageMessagesToolStripMenuItem.Name = "ManageMessagesToolStripMenuItem"
        Me.ManageMessagesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ManageMessagesToolStripMenuItem.Text = "Manage &Messages"
        '
        'ManageBooksToolStripMenuItem
        '
        Me.ManageBooksToolStripMenuItem.Name = "ManageBooksToolStripMenuItem"
        Me.ManageBooksToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ManageBooksToolStripMenuItem.Text = "Manage &Books"
        '
        'ManageBorrowsToolStripMenuItem
        '
        Me.ManageBorrowsToolStripMenuItem.Name = "ManageBorrowsToolStripMenuItem"
        Me.ManageBorrowsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ManageBorrowsToolStripMenuItem.Text = "Manage Borro&ws"
        '
        'ManageReservesToolStripMenuItem
        '
        Me.ManageReservesToolStripMenuItem.Name = "ManageReservesToolStripMenuItem"
        Me.ManageReservesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ManageReservesToolStripMenuItem.Text = "Manage &Reserves"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowTouseToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'HowTouseToolStripMenuItem
        '
        Me.HowTouseToolStripMenuItem.Name = "HowTouseToolStripMenuItem"
        Me.HowTouseToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.HowTouseToolStripMenuItem.Text = "How to &use"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AboutToolStripMenuItem.Text = "A&bout"
        '
        'MemberMenu
        '
        Me.MemberMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.MemberMenu.Location = New System.Drawing.Point(0, 0)
        Me.MemberMenu.Name = "MemberMenu"
        Me.MemberMenu.Size = New System.Drawing.Size(1019, 24)
        Me.MemberMenu.TabIndex = 42
        Me.MemberMenu.Text = "MenuStrip1"
        Me.MemberMenu.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserLogout, Me.UserRefreshPage, Me.UserExit})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "&File"
        '
        'UserLogout
        '
        Me.UserLogout.Name = "UserLogout"
        Me.UserLogout.Size = New System.Drawing.Size(142, 22)
        Me.UserLogout.Text = "&Logout"
        '
        'UserRefreshPage
        '
        Me.UserRefreshPage.Name = "UserRefreshPage"
        Me.UserRefreshPage.Size = New System.Drawing.Size(142, 22)
        Me.UserRefreshPage.Text = "Refresh &Page"
        '
        'UserExit
        '
        Me.UserExit.Name = "UserExit"
        Me.UserExit.Size = New System.Drawing.Size(142, 22)
        Me.UserExit.Text = "&Exit"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserProfile, Me.UserMessages, Me.UserReserves})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(66, 20)
        Me.ToolStripMenuItem2.Text = "&Navigate"
        '
        'UserProfile
        '
        Me.UserProfile.Name = "UserProfile"
        Me.UserProfile.Size = New System.Drawing.Size(144, 22)
        Me.UserProfile.Text = "&Profile"
        '
        'UserMessages
        '
        Me.UserMessages.Name = "UserMessages"
        Me.UserMessages.Size = New System.Drawing.Size(144, 22)
        Me.UserMessages.Text = "&Messages"
        '
        'UserReserves
        '
        Me.UserReserves.Name = "UserReserves"
        Me.UserReserves.Size = New System.Drawing.Size(144, 22)
        Me.UserReserves.Text = "&Reserve Book"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserHowToUse, Me.UserAbout})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItem3.Text = "&Help"
        '
        'UserHowToUse
        '
        Me.UserHowToUse.Name = "UserHowToUse"
        Me.UserHowToUse.Size = New System.Drawing.Size(134, 22)
        Me.UserHowToUse.Text = "How &to use"
        '
        'UserAbout
        '
        Me.UserAbout.Name = "UserAbout"
        Me.UserAbout.Size = New System.Drawing.Size(134, 22)
        Me.UserAbout.Text = "&About"
        '
        'frmManageMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1019, 494)
        Me.Controls.Add(Me.AdminMenu)
        Me.Controls.Add(Me.MemberMenu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManageMessage"
        Me.Text = "frmManageMessage"
        Me.Panel1.ResumeLayout(False)
        Me.AdminMenu.ResumeLayout(False)
        Me.AdminMenu.PerformLayout()
        Me.MemberMenu.ResumeLayout(False)
        Me.MemberMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstMessages As ListView
    Friend WithEvents msg_id As ColumnHeader
    Friend WithEvents sender_no As ColumnHeader
    Friend WithEvents sender_fn As ColumnHeader
    Friend WithEvents rec_no As ColumnHeader
    Friend WithEvents rec_name As ColumnHeader
    Friend WithEvents message As ColumnHeader
    Friend WithEvents status As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnReply As Button
    Friend WithEvents btnCompose As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents AdminMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResfreshPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NavigateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageMessagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageBorrowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageReservesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowTouseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MemberMenu As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UserLogout As ToolStripMenuItem
    Friend WithEvents UserRefreshPage As ToolStripMenuItem
    Friend WithEvents UserExit As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents UserProfile As ToolStripMenuItem
    Friend WithEvents UserMessages As ToolStripMenuItem
    Friend WithEvents UserReserves As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents UserHowToUse As ToolStripMenuItem
    Friend WithEvents UserAbout As ToolStripMenuItem
End Class
