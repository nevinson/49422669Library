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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReserveBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToUseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblBooksReserved = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBooksDue = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(751, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.RefreshPageToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.LogoutToolStripMenuItem.Text = "&Logout"
        '
        'RefreshPageToolStripMenuItem
        '
        Me.RefreshPageToolStripMenuItem.Name = "RefreshPageToolStripMenuItem"
        Me.RefreshPageToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.RefreshPageToolStripMenuItem.Text = "Refresh Page"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem, Me.ReserveBookToolStripMenuItem, Me.BorrowBookToolStripMenuItem, Me.BackToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ProfileToolStripMenuItem.Text = "&Profile"
        '
        'ReserveBookToolStripMenuItem
        '
        Me.ReserveBookToolStripMenuItem.Name = "ReserveBookToolStripMenuItem"
        Me.ReserveBookToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ReserveBookToolStripMenuItem.Text = "&Reserve Book"
        '
        'BorrowBookToolStripMenuItem
        '
        Me.BorrowBookToolStripMenuItem.Name = "BorrowBookToolStripMenuItem"
        Me.BorrowBookToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.BorrowBookToolStripMenuItem.Text = "&Borrow Book"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Enabled = False
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.BackToolStripMenuItem.Text = "B&ack"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToUseToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'HowToUseToolStripMenuItem
        '
        Me.HowToUseToolStripMenuItem.Name = "HowToUseToolStripMenuItem"
        Me.HowToUseToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.HowToUseToolStripMenuItem.Text = "How To &Use"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblBooksReserved)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblBooksDue)
        Me.Panel2.Location = New System.Drawing.Point(13, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(726, 98)
        Me.Panel2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(578, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Books Reserved"
        '
        'lblBooksReserved
        '
        Me.lblBooksReserved.AutoSize = True
        Me.lblBooksReserved.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooksReserved.ForeColor = System.Drawing.Color.Teal
        Me.lblBooksReserved.Location = New System.Drawing.Point(612, 11)
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
        Me.Name = "frmUserDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUserDashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReserveBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToUseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
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
End Class
