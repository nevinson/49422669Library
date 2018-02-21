<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReserve
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMembershipNumber = New System.Windows.Forms.TextBox()
        Me.txtBookNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Teal
        Me.btnBack.Location = New System.Drawing.Point(320, 151)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(94, 32)
        Me.btnBack.TabIndex = 37
        Me.btnBack.Text = "B&ack"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnReserve
        '
        Me.btnReserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserve.ForeColor = System.Drawing.Color.Teal
        Me.btnReserve.Location = New System.Drawing.Point(20, 151)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(94, 32)
        Me.btnReserve.TabIndex = 36
        Me.btnReserve.Text = "&Reserve Book"
        Me.btnReserve.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(335, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Reserve a Book"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btnReserve)
        Me.Panel1.Controls.Add(Me.txtMembershipNumber)
        Me.Panel1.Controls.Add(Me.txtBookNumber)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Location = New System.Drawing.Point(13, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 209)
        Me.Panel1.TabIndex = 33
        '
        'txtMembershipNumber
        '
        Me.txtMembershipNumber.ForeColor = System.Drawing.Color.Teal
        Me.txtMembershipNumber.Location = New System.Drawing.Point(166, 98)
        Me.txtMembershipNumber.Name = "txtMembershipNumber"
        Me.txtMembershipNumber.ReadOnly = True
        Me.txtMembershipNumber.Size = New System.Drawing.Size(249, 20)
        Me.txtMembershipNumber.TabIndex = 15
        '
        'txtBookNumber
        '
        Me.txtBookNumber.ForeColor = System.Drawing.Color.Teal
        Me.txtBookNumber.Location = New System.Drawing.Point(165, 31)
        Me.txtBookNumber.Name = "txtBookNumber"
        Me.txtBookNumber.Size = New System.Drawing.Size(249, 20)
        Me.txtBookNumber.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(3, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Membership Number:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Teal
        Me.lblPassword.Location = New System.Drawing.Point(48, 34)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(98, 17)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Book Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 36)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "46422669 Library"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.NavigateToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(456, 24)
        Me.MenuStrip1.TabIndex = 36
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
        Me.UserProfile.Size = New System.Drawing.Size(152, 22)
        Me.UserProfile.Text = "&Profile"
        '
        'UserMessages
        '
        Me.UserMessages.Name = "UserMessages"
        Me.UserMessages.Size = New System.Drawing.Size(152, 22)
        Me.UserMessages.Text = "&Messages"
        '
        'UserReserves
        '
        Me.UserReserves.Enabled = False
        Me.UserReserves.Name = "UserReserves"
        Me.UserReserves.Size = New System.Drawing.Size(152, 22)
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
        'frmReserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(456, 337)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReserve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReserve"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnReserve As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtMembershipNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBookNumber As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserLogout As ToolStripMenuItem
    Friend WithEvents UserRefreshPage As ToolStripMenuItem
    Friend WithEvents UserExit As ToolStripMenuItem
    Friend WithEvents NavigateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserProfile As ToolStripMenuItem
    Friend WithEvents UserMessages As ToolStripMenuItem
    Friend WithEvents UserReserves As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserHowToUse As ToolStripMenuItem
    Friend WithEvents UserAbout As ToolStripMenuItem
End Class
