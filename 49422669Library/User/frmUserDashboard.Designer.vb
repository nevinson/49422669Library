<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserDashboard
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstBooks = New System.Windows.Forms.ListView()
        Me.book_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.book_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.author_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.book_quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.category_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMessages = New System.Windows.Forms.Label()
        Me.lblBooksReserved = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBooksDue = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserRefreshPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserMessages = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserReserves = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserHowToUse = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSubmitQuery = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSubmitQuery)
        Me.Panel1.Controls.Add(Me.lstBooks)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnReserve)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Location = New System.Drawing.Point(13, 204)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 361)
        Me.Panel1.TabIndex = 1
        '
        'lstBooks
        '
        Me.lstBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.book_no, Me.book_name, Me.author_name, Me.book_quantity, Me.category_name})
        Me.lstBooks.FullRowSelect = True
        Me.lstBooks.GridLines = True
        Me.lstBooks.Location = New System.Drawing.Point(14, 65)
        Me.lstBooks.Name = "lstBooks"
        Me.lstBooks.Size = New System.Drawing.Size(547, 287)
        Me.lstBooks.TabIndex = 34
        Me.lstBooks.UseCompatibleStateImageBehavior = False
        Me.lstBooks.View = System.Windows.Forms.View.Details
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
        'book_quantity
        '
        Me.book_quantity.Text = "Book Quantity"
        Me.book_quantity.Width = 101
        '
        'category_name
        '
        Me.category_name.Text = "Category Name"
        Me.category_name.Width = 120
        '
        'btnLogout
        '
        Me.btnLogout.ForeColor = System.Drawing.Color.Teal
        Me.btnLogout.Location = New System.Drawing.Point(590, 230)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(108, 36)
        Me.btnLogout.TabIndex = 29
        Me.btnLogout.Text = "&Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnReserve
        '
        Me.btnReserve.ForeColor = System.Drawing.Color.Teal
        Me.btnReserve.Location = New System.Drawing.Point(590, 87)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(108, 36)
        Me.btnReserve.TabIndex = 28
        Me.btnReserve.Text = "&Reserve"
        Me.btnReserve.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.ForeColor = System.Drawing.Color.Teal
        Me.btnSearch.Location = New System.Drawing.Point(452, 22)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 26
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.Color.Teal
        Me.txtSearch.Location = New System.Drawing.Point(112, 26)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(294, 20)
        Me.txtSearch.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "46422669 Library"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(792, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "List of Books"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblMessages)
        Me.Panel2.Controls.Add(Me.lblBooksReserved)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblBooksDue)
        Me.Panel2.Location = New System.Drawing.Point(13, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(726, 98)
        Me.Panel2.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(603, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Messages"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(327, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Books Reserved"
        '
        'lblMessages
        '
        Me.lblMessages.AutoSize = True
        Me.lblMessages.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessages.ForeColor = System.Drawing.Color.Teal
        Me.lblMessages.Location = New System.Drawing.Point(617, 11)
        Me.lblMessages.Name = "lblMessages"
        Me.lblMessages.Size = New System.Drawing.Size(47, 51)
        Me.lblMessages.TabIndex = 2
        Me.lblMessages.Text = "0"
        '
        'lblBooksReserved
        '
        Me.lblBooksReserved.AutoSize = True
        Me.lblBooksReserved.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooksReserved.ForeColor = System.Drawing.Color.Teal
        Me.lblBooksReserved.Location = New System.Drawing.Point(361, 11)
        Me.lblBooksReserved.Name = "lblBooksReserved"
        Me.lblBooksReserved.Size = New System.Drawing.Size(47, 51)
        Me.lblBooksReserved.TabIndex = 2
        Me.lblBooksReserved.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(41, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Books Borrowed"
        '
        'lblBooksDue
        '
        Me.lblBooksDue.AutoSize = True
        Me.lblBooksDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooksDue.ForeColor = System.Drawing.Color.Teal
        Me.lblBooksDue.Location = New System.Drawing.Point(72, 11)
        Me.lblBooksDue.Name = "lblBooksDue"
        Me.lblBooksDue.Size = New System.Drawing.Size(47, 51)
        Me.lblBooksDue.TabIndex = 0
        Me.lblBooksDue.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(627, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "User Dashboard"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.NavigateToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(751, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserLogout, Me.UserRefreshPage, Me.UserExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
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
        'NavigateToolStripMenuItem
        '
        Me.NavigateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserProfile, Me.UserMessages, Me.UserReserves})
        Me.NavigateToolStripMenuItem.Name = "NavigateToolStripMenuItem"
        Me.NavigateToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.NavigateToolStripMenuItem.Text = "&Navigate"
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
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserHowToUse, Me.UserAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
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
        'btnSubmitQuery
        '
        Me.btnSubmitQuery.ForeColor = System.Drawing.Color.Teal
        Me.btnSubmitQuery.Location = New System.Drawing.Point(590, 163)
        Me.btnSubmitQuery.Name = "btnSubmitQuery"
        Me.btnSubmitQuery.Size = New System.Drawing.Size(108, 36)
        Me.btnSubmitQuery.TabIndex = 35
        Me.btnSubmitQuery.Text = "&Submit Query"
        Me.btnSubmitQuery.UseVisualStyleBackColor = True
        '
        'frmUserDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(751, 578)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUserDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUserDashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReserve As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents lstBooks As ListView
    Friend WithEvents book_no As ColumnHeader
    Friend WithEvents book_name As ColumnHeader
    Friend WithEvents author_name As ColumnHeader
    Friend WithEvents book_quantity As ColumnHeader
    Friend WithEvents category_name As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblBooksReserved As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblBooksDue As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblMessages As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserLogout As ToolStripMenuItem
    Friend WithEvents UserRefreshPage As ToolStripMenuItem
    Friend WithEvents UserExit As ToolStripMenuItem
    Friend WithEvents NavigateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserHowToUse As ToolStripMenuItem
    Friend WithEvents UserAbout As ToolStripMenuItem
    Friend WithEvents UserProfile As ToolStripMenuItem
    Friend WithEvents UserMessages As ToolStripMenuItem
    Friend WithEvents UserReserves As ToolStripMenuItem
    Friend WithEvents btnSubmitQuery As Button
End Class
