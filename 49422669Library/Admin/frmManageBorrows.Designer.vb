<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManageBorrows
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnLend = New System.Windows.Forms.Button()
        Me.lstBorrows = New System.Windows.Forms.ListView()
        Me.brw_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pickup_date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.return_date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.book_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.book_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.author_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.membership_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.first_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.last_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 36)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "46422669 Library"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(939, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 17)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Manage Borrowed Books"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btnReturn)
        Me.Panel1.Controls.Add(Me.btnLend)
        Me.Panel1.Controls.Add(Me.lstBorrows)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Location = New System.Drawing.Point(4, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1101, 407)
        Me.Panel1.TabIndex = 32
        '
        'btnBack
        '
        Me.btnBack.ForeColor = System.Drawing.Color.Teal
        Me.btnBack.Location = New System.Drawing.Point(987, 316)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(94, 32)
        Me.btnBack.TabIndex = 32
        Me.btnBack.Text = "B&ack"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.ForeColor = System.Drawing.Color.Teal
        Me.btnReturn.Location = New System.Drawing.Point(987, 210)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(94, 32)
        Me.btnReturn.TabIndex = 31
        Me.btnReturn.Text = "Mark &Returned"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnLend
        '
        Me.btnLend.ForeColor = System.Drawing.Color.Teal
        Me.btnLend.Location = New System.Drawing.Point(987, 98)
        Me.btnLend.Name = "btnLend"
        Me.btnLend.Size = New System.Drawing.Size(94, 32)
        Me.btnLend.TabIndex = 30
        Me.btnLend.Text = "&Lend Book"
        Me.btnLend.UseVisualStyleBackColor = True
        '
        'lstBorrows
        '
        Me.lstBorrows.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.brw_id, Me.pickup_date, Me.return_date, Me.book_no, Me.book_name, Me.author_name, Me.membership_no, Me.first_name, Me.last_name})
        Me.lstBorrows.FullRowSelect = True
        Me.lstBorrows.GridLines = True
        Me.lstBorrows.Location = New System.Drawing.Point(16, 56)
        Me.lstBorrows.Name = "lstBorrows"
        Me.lstBorrows.Size = New System.Drawing.Size(954, 338)
        Me.lstBorrows.TabIndex = 29
        Me.lstBorrows.UseCompatibleStateImageBehavior = False
        Me.lstBorrows.View = System.Windows.Forms.View.Details
        '
        'brw_id
        '
        Me.brw_id.Text = "Borrow ID "
        Me.brw_id.Width = 73
        '
        'pickup_date
        '
        Me.pickup_date.Text = "Pickup Date"
        Me.pickup_date.Width = 101
        '
        'return_date
        '
        Me.return_date.Text = "Return Date"
        Me.return_date.Width = 120
        '
        'book_no
        '
        Me.book_no.Text = "Book Number"
        Me.book_no.Width = 97
        '
        'book_name
        '
        Me.book_name.Text = "Book Name"
        Me.book_name.Width = 83
        '
        'author_name
        '
        Me.author_name.Text = "Author Name"
        Me.author_name.Width = 141
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
        'btnSearch
        '
        Me.btnSearch.ForeColor = System.Drawing.Color.Teal
        Me.btnSearch.Location = New System.Drawing.Point(552, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(68, 23)
        Me.btnSearch.TabIndex = 28
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.Color.Teal
        Me.txtSearch.Location = New System.Drawing.Point(318, 15)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 20)
        Me.txtSearch.TabIndex = 27
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.NavigateToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1117, 24)
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
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ManageToolStripMenuItem.Text = "&Manage"
        '
        'ManageUsers
        '
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
        Me.ManageBorrowedBooks.Enabled = False
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
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        'frmManageBorrows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1117, 516)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManageBorrows"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmManageBorrows"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lstBorrows As ListView
    Friend WithEvents brw_id As ColumnHeader
    Friend WithEvents pickup_date As ColumnHeader
    Friend WithEvents return_date As ColumnHeader
    Friend WithEvents book_no As ColumnHeader
    Friend WithEvents book_name As ColumnHeader
    Friend WithEvents author_name As ColumnHeader
    Friend WithEvents membership_no As ColumnHeader
    Friend WithEvents first_name As ColumnHeader
    Friend WithEvents last_name As ColumnHeader
    Friend WithEvents btnLend As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnReturn As Button
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
