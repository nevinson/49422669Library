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
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(895, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Manage Members"
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
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ResfreshPageToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
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
End Class
