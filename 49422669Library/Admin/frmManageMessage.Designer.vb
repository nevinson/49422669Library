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
        Me.ExitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageBooks = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageBorrowedBooks = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageReservedBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBorrowedBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddReservedBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstMessages = New System.Windows.Forms.ListView()
        Me.msg_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sender_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sender_fn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rec_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rec_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.message = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToUse = New System.Windows.Forms.ToolStripMenuItem()
        Me.About = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReply = New System.Windows.Forms.Button()
        Me.btnCompose = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitMenu
        '
        Me.ExitMenu.Name = "ExitMenu"
        Me.ExitMenu.Size = New System.Drawing.Size(112, 22)
        Me.ExitMenu.Text = "&Exit"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageUsers, Me.ManageBooks, Me.ManageBorrowedBooks, Me.ManageReservedBook})
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ManageToolStripMenuItem.Text = "&Manage"
        '
        'ManageUsers
        '
        Me.ManageUsers.Enabled = False
        Me.ManageUsers.Name = "ManageUsers"
        Me.ManageUsers.Size = New System.Drawing.Size(160, 22)
        Me.ManageUsers.Text = "&Users"
        '
        'ManageBooks
        '
        Me.ManageBooks.Name = "ManageBooks"
        Me.ManageBooks.Size = New System.Drawing.Size(160, 22)
        Me.ManageBooks.Text = "&Books"
        '
        'ManageBorrowedBooks
        '
        Me.ManageBorrowedBooks.Name = "ManageBorrowedBooks"
        Me.ManageBorrowedBooks.Size = New System.Drawing.Size(160, 22)
        Me.ManageBorrowedBooks.Text = "Borro&wed Books"
        '
        'ManageReservedBook
        '
        Me.ManageReservedBook.Name = "ManageReservedBook"
        Me.ManageReservedBook.Size = New System.Drawing.Size(160, 22)
        Me.ManageReservedBook.Text = "&Reserved Books"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUser, Me.AddBook, Me.AddBorrowedBook, Me.AddReservedBook})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AddToolStripMenuItem.Text = "&Add"
        '
        'AddUser
        '
        Me.AddUser.Name = "AddUser"
        Me.AddUser.Size = New System.Drawing.Size(155, 22)
        Me.AddUser.Text = "&User"
        '
        'AddBook
        '
        Me.AddBook.Name = "AddBook"
        Me.AddBook.Size = New System.Drawing.Size(155, 22)
        Me.AddBook.Text = "&Book"
        '
        'AddBorrowedBook
        '
        Me.AddBorrowedBook.Name = "AddBorrowedBook"
        Me.AddBorrowedBook.Size = New System.Drawing.Size(155, 22)
        Me.AddBorrowedBook.Text = "Borro&wed Book"
        '
        'AddReservedBook
        '
        Me.AddReservedBook.Name = "AddReservedBook"
        Me.AddReservedBook.Size = New System.Drawing.Size(155, 22)
        Me.AddReservedBook.Text = "&Reserved Book"
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
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToUse, Me.About})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'HowToUse
        '
        Me.HowToUse.Name = "HowToUse"
        Me.HowToUse.Size = New System.Drawing.Size(134, 22)
        Me.HowToUse.Text = "How to &use"
        '
        'About
        '
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(134, 22)
        Me.About.Text = "A&bout"
        '
        'NavigateToolStripMenuItem
        '
        Me.NavigateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageToolStripMenuItem, Me.AddToolStripMenuItem})
        Me.NavigateToolStripMenuItem.Name = "NavigateToolStripMenuItem"
        Me.NavigateToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.NavigateToolStripMenuItem.Text = "&Navigate"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Logout, Me.ExitMenu})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'Logout
        '
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(112, 22)
        Me.Logout.Text = "&Logout"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.NavigateToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1019, 24)
        Me.MenuStrip1.TabIndex = 41
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.Label2.Location = New System.Drawing.Point(893, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Manage Member"
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
        'frmManageMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1019, 494)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManageMessage"
        Me.Text = "frmManageMessage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitMenu As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageUsers As ToolStripMenuItem
    Friend WithEvents ManageBooks As ToolStripMenuItem
    Friend WithEvents ManageBorrowedBooks As ToolStripMenuItem
    Friend WithEvents ManageReservedBook As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUser As ToolStripMenuItem
    Friend WithEvents AddBook As ToolStripMenuItem
    Friend WithEvents AddBorrowedBook As ToolStripMenuItem
    Friend WithEvents AddReservedBook As ToolStripMenuItem
    Friend WithEvents lstMessages As ListView
    Friend WithEvents msg_id As ColumnHeader
    Friend WithEvents sender_no As ColumnHeader
    Friend WithEvents sender_fn As ColumnHeader
    Friend WithEvents rec_no As ColumnHeader
    Friend WithEvents rec_name As ColumnHeader
    Friend WithEvents message As ColumnHeader
    Friend WithEvents status As ColumnHeader
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToUse As ToolStripMenuItem
    Friend WithEvents About As ToolStripMenuItem
    Friend WithEvents NavigateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Logout As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnReply As Button
    Friend WithEvents btnCompose As Button
    Friend WithEvents btnRead As Button
End Class
