<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageUsers
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnUnBlacklistUser = New System.Windows.Forms.Button()
        Me.btnBlacklistUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnUpdateUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.lstUsers = New System.Windows.Forms.ListView()
        Me.membership_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.first_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.last_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.member_type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.join_date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToUse = New System.Windows.Forms.ToolStripMenuItem()
        Me.About = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(902, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Manage Member"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btnUnBlacklistUser)
        Me.Panel1.Controls.Add(Me.btnBlacklistUser)
        Me.Panel1.Controls.Add(Me.btnDeleteUser)
        Me.Panel1.Controls.Add(Me.btnUpdateUser)
        Me.Panel1.Controls.Add(Me.btnAddUser)
        Me.Panel1.Controls.Add(Me.lstUsers)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Location = New System.Drawing.Point(13, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 398)
        Me.Panel1.TabIndex = 25
        '
        'btnBack
        '
        Me.btnBack.ForeColor = System.Drawing.Color.Teal
        Me.btnBack.Location = New System.Drawing.Point(875, 354)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(108, 36)
        Me.btnBack.TabIndex = 37
        Me.btnBack.Text = "B&ack"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnUnBlacklistUser
        '
        Me.btnUnBlacklistUser.ForeColor = System.Drawing.Color.Teal
        Me.btnUnBlacklistUser.Location = New System.Drawing.Point(875, 296)
        Me.btnUnBlacklistUser.Name = "btnUnBlacklistUser"
        Me.btnUnBlacklistUser.Size = New System.Drawing.Size(108, 36)
        Me.btnUnBlacklistUser.TabIndex = 35
        Me.btnUnBlacklistUser.Text = "U&nBlacklist User"
        Me.btnUnBlacklistUser.UseVisualStyleBackColor = True
        '
        'btnBlacklistUser
        '
        Me.btnBlacklistUser.ForeColor = System.Drawing.Color.Teal
        Me.btnBlacklistUser.Location = New System.Drawing.Point(875, 233)
        Me.btnBlacklistUser.Name = "btnBlacklistUser"
        Me.btnBlacklistUser.Size = New System.Drawing.Size(108, 36)
        Me.btnBlacklistUser.TabIndex = 34
        Me.btnBlacklistUser.Text = "&Blacklist User"
        Me.btnBlacklistUser.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.ForeColor = System.Drawing.Color.Teal
        Me.btnDeleteUser.Location = New System.Drawing.Point(875, 174)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(108, 36)
        Me.btnDeleteUser.TabIndex = 33
        Me.btnDeleteUser.Text = "&Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.ForeColor = System.Drawing.Color.Teal
        Me.btnUpdateUser.Location = New System.Drawing.Point(875, 113)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(108, 36)
        Me.btnUpdateUser.TabIndex = 32
        Me.btnUpdateUser.Text = "&Update User"
        Me.btnUpdateUser.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.ForeColor = System.Drawing.Color.Teal
        Me.btnAddUser.Location = New System.Drawing.Point(875, 52)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(108, 36)
        Me.btnAddUser.TabIndex = 31
        Me.btnAddUser.Text = "Ad&d User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'lstUsers
        '
        Me.lstUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.membership_no, Me.first_name, Me.last_name, Me.email, Me.username, Me.member_type, Me.status, Me.join_date})
        Me.lstUsers.FullRowSelect = True
        Me.lstUsers.GridLines = True
        Me.lstUsers.Location = New System.Drawing.Point(4, 52)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(846, 338)
        Me.lstUsers.TabIndex = 30
        Me.lstUsers.UseCompatibleStateImageBehavior = False
        Me.lstUsers.View = System.Windows.Forms.View.Details
        '
        'membership_no
        '
        Me.membership_no.Text = "Membership Number"
        Me.membership_no.Width = 133
        '
        'first_name
        '
        Me.first_name.Text = "First Name"
        Me.first_name.Width = 107
        '
        'last_name
        '
        Me.last_name.Text = "Last Name"
        Me.last_name.Width = 95
        '
        'email
        '
        Me.email.Text = "Email Address"
        Me.email.Width = 73
        '
        'username
        '
        Me.username.Text = "Username"
        Me.username.Width = 97
        '
        'member_type
        '
        Me.member_type.Text = "Membership Type"
        Me.member_type.Width = 101
        '
        'status
        '
        Me.status.Text = "Status"
        Me.status.Width = 83
        '
        'join_date
        '
        Me.join_date.Text = "Join Date"
        Me.join_date.Width = 141
        '
        'btnSearch
        '
        Me.btnSearch.ForeColor = System.Drawing.Color.Teal
        Me.btnSearch.Location = New System.Drawing.Point(515, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(68, 23)
        Me.btnSearch.TabIndex = 28
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.Color.Teal
        Me.txtSearch.Location = New System.Drawing.Point(286, 16)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 20)
        Me.txtSearch.TabIndex = 27
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
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "46422669 Library"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.NavigateToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'ExitMenu
        '
        Me.ExitMenu.Name = "ExitMenu"
        Me.ExitMenu.Size = New System.Drawing.Size(112, 22)
        Me.ExitMenu.Text = "&Exit"
        '
        'NavigateToolStripMenuItem
        '
        Me.NavigateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageToolStripMenuItem, Me.AddToolStripMenuItem})
        Me.NavigateToolStripMenuItem.Name = "NavigateToolStripMenuItem"
        Me.NavigateToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.NavigateToolStripMenuItem.Text = "&Navigate"
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
        'frmManageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1028, 510)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManageUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmManageUsers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lstUsers As ListView
    Friend WithEvents membership_no As ColumnHeader
    Friend WithEvents first_name As ColumnHeader
    Friend WithEvents last_name As ColumnHeader
    Friend WithEvents email As ColumnHeader
    Friend WithEvents username As ColumnHeader
    Friend WithEvents member_type As ColumnHeader
    Friend WithEvents status As ColumnHeader
    Friend WithEvents join_date As ColumnHeader
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents btnUnBlacklistUser As Button
    Friend WithEvents btnBlacklistUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnUpdateUser As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Logout As ToolStripMenuItem
    Friend WithEvents ExitMenu As ToolStripMenuItem
    Friend WithEvents NavigateToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToUse As ToolStripMenuItem
    Friend WithEvents About As ToolStripMenuItem
End Class
