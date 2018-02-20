<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewMessage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnReply = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.txtReceiver = New System.Windows.Forms.TextBox()
        Me.txtSender = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 36)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "46422669 Library"
        '
        'btnBack
        '
        Me.btnBack.ForeColor = System.Drawing.Color.Teal
        Me.btnBack.Location = New System.Drawing.Point(257, 201)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(94, 32)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "B&ack"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnReply
        '
        Me.btnReply.ForeColor = System.Drawing.Color.Teal
        Me.btnReply.Location = New System.Drawing.Point(12, 201)
        Me.btnReply.Name = "btnReply"
        Me.btnReply.Size = New System.Drawing.Size(94, 32)
        Me.btnReply.TabIndex = 25
        Me.btnReply.Text = "&Reply Message"
        Me.btnReply.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(16, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Receiver:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btnReply)
        Me.Panel1.Controls.Add(Me.txtDate)
        Me.Panel1.Controls.Add(Me.txtMessage)
        Me.Panel1.Controls.Add(Me.txtReceiver)
        Me.Panel1.Controls.Add(Me.txtSender)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Location = New System.Drawing.Point(8, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 244)
        Me.Panel1.TabIndex = 38
        '
        'txtDate
        '
        Me.txtDate.ForeColor = System.Drawing.Color.Teal
        Me.txtDate.Location = New System.Drawing.Point(102, 166)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(249, 20)
        Me.txtDate.TabIndex = 15
        '
        'txtMessage
        '
        Me.txtMessage.ForeColor = System.Drawing.Color.Teal
        Me.txtMessage.Location = New System.Drawing.Point(102, 83)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.Size = New System.Drawing.Size(249, 77)
        Me.txtMessage.TabIndex = 14
        '
        'txtReceiver
        '
        Me.txtReceiver.ForeColor = System.Drawing.Color.Teal
        Me.txtReceiver.Location = New System.Drawing.Point(102, 51)
        Me.txtReceiver.Name = "txtReceiver"
        Me.txtReceiver.ReadOnly = True
        Me.txtReceiver.Size = New System.Drawing.Size(249, 20)
        Me.txtReceiver.TabIndex = 13
        '
        'txtSender
        '
        Me.txtSender.ForeColor = System.Drawing.Color.Teal
        Me.txtSender.Location = New System.Drawing.Point(102, 19)
        Me.txtSender.Name = "txtSender"
        Me.txtSender.ReadOnly = True
        Me.txtSender.Size = New System.Drawing.Size(249, 20)
        Me.txtSender.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(26, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Sender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(9, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date Sent:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Teal
        Me.lblPassword.Location = New System.Drawing.Point(15, 86)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Message:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(309, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Add Book"
        '
        'frmViewMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(387, 308)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmViewMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmViewMessage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnReply As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents txtReceiver As TextBox
    Friend WithEvents txtSender As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label2 As Label
End Class
