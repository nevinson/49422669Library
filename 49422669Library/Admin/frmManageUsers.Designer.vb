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
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnUnBlackListUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnBlacklistUser = New System.Windows.Forms.Button()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMembershipNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.HowToUseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReserveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1008, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Manage Member"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dgvUsers)
        Me.Panel1.Controls.Add(Me.txtNewPassword)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btnUnBlackListUser)
        Me.Panel1.Controls.Add(Me.btnDeleteUser)
        Me.Panel1.Controls.Add(Me.btnBlacklistUser)
        Me.Panel1.Controls.Add(Me.txtEmailAddress)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtFullName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtMembershipNumber)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Location = New System.Drawing.Point(13, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1109, 398)
        Me.Panel1.TabIndex = 25
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.Teal
        Me.txtNewPassword.Location = New System.Drawing.Point(66, 215)
        Me.txtNewPassword.Multiline = True
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.ReadOnly = True
        Me.txtNewPassword.Size = New System.Drawing.Size(309, 58)
        Me.txtNewPassword.TabIndex = 41
        Me.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBack
        '
        Me.btnBack.ForeColor = System.Drawing.Color.Teal
        Me.btnBack.Location = New System.Drawing.Point(252, 339)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(137, 46)
        Me.btnBack.TabIndex = 40
        Me.btnBack.Text = "B&ack"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnUnBlackListUser
        '
        Me.btnUnBlackListUser.ForeColor = System.Drawing.Color.Teal
        Me.btnUnBlackListUser.Location = New System.Drawing.Point(36, 339)
        Me.btnUnBlackListUser.Name = "btnUnBlackListUser"
        Me.btnUnBlackListUser.Size = New System.Drawing.Size(137, 46)
        Me.btnUnBlackListUser.TabIndex = 39
        Me.btnUnBlackListUser.Text = "&UnBlacklist User"
        Me.btnUnBlackListUser.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.ForeColor = System.Drawing.Color.Teal
        Me.btnDeleteUser.Location = New System.Drawing.Point(252, 284)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(137, 46)
        Me.btnDeleteUser.TabIndex = 38
        Me.btnDeleteUser.Text = "&Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnBlacklistUser
        '
        Me.btnBlacklistUser.ForeColor = System.Drawing.Color.Teal
        Me.btnBlacklistUser.Location = New System.Drawing.Point(36, 284)
        Me.btnBlacklistUser.Name = "btnBlacklistUser"
        Me.btnBlacklistUser.Size = New System.Drawing.Size(137, 46)
        Me.btnBlacklistUser.TabIndex = 37
        Me.btnBlacklistUser.Text = "&Blacklist User"
        Me.btnBlacklistUser.UseVisualStyleBackColor = True
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.ForeColor = System.Drawing.Color.Teal
        Me.txtEmailAddress.Location = New System.Drawing.Point(181, 174)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.ReadOnly = True
        Me.txtEmailAddress.Size = New System.Drawing.Size(220, 20)
        Me.txtEmailAddress.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(16, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Membership Number:"
        '
        'txtFullName
        '
        Me.txtFullName.ForeColor = System.Drawing.Color.Teal
        Me.txtFullName.Location = New System.Drawing.Point(181, 138)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.ReadOnly = True
        Me.txtFullName.Size = New System.Drawing.Size(220, 20)
        Me.txtFullName.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(57, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Email Address:"
        '
        'txtUsername
        '
        Me.txtUsername.ForeColor = System.Drawing.Color.Teal
        Me.txtUsername.Location = New System.Drawing.Point(181, 102)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(220, 20)
        Me.txtUsername.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(84, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Full Name:"
        '
        'txtMembershipNumber
        '
        Me.txtMembershipNumber.ForeColor = System.Drawing.Color.Teal
        Me.txtMembershipNumber.Location = New System.Drawing.Point(181, 66)
        Me.txtMembershipNumber.Name = "txtMembershipNumber"
        Me.txtMembershipNumber.ReadOnly = True
        Me.txtMembershipNumber.Size = New System.Drawing.Size(220, 20)
        Me.txtMembershipNumber.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(82, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Username:"
        '
        'btnSearch
        '
        Me.btnSearch.ForeColor = System.Drawing.Color.Teal
        Me.btnSearch.Location = New System.Drawing.Point(291, 14)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(68, 23)
        Me.btnSearch.TabIndex = 28
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.Color.Teal
        Me.txtSearch.Location = New System.Drawing.Point(62, 17)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 20)
        Me.txtSearch.TabIndex = 27
        '
        'HowToUseToolStripMenuItem
        '
        Me.HowToUseToolStripMenuItem.Name = "HowToUseToolStripMenuItem"
        Me.HowToUseToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.HowToUseToolStripMenuItem.Text = "&How To Use"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HowToUseToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.AboutToolStripMenuItem.Text = "Abo&ut"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1134, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadPageToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ReloadPageToolStripMenuItem
        '
        Me.ReloadPageToolStripMenuItem.Name = "ReloadPageToolStripMenuItem"
        Me.ReloadPageToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ReloadPageToolStripMenuItem.Text = "&Reload Page"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
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
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowToolStripMenuItem, Me.ReserveToolStripMenuItem, Me.BackToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'BorrowToolStripMenuItem
        '
        Me.BorrowToolStripMenuItem.Name = "BorrowToolStripMenuItem"
        Me.BorrowToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.BorrowToolStripMenuItem.Text = "&Borrow"
        '
        'ReserveToolStripMenuItem
        '
        Me.ReserveToolStripMenuItem.Name = "ReserveToolStripMenuItem"
        Me.ReserveToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ReserveToolStripMenuItem.Text = "&Reserve"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.BackToolStripMenuItem.Text = "B&ack"
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
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(437, 66)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.Size = New System.Drawing.Size(667, 297)
        Me.dgvUsers.TabIndex = 42
        '
        'frmManageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1134, 510)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManageUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmManageUsers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents HowToUseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReserveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtMembershipNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnUnBlackListUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnBlacklistUser As Button
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents dgvUsers As DataGridView
End Class
