<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoading
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
        Me.components = New System.ComponentModel.Container()
        Me.loadingProgressBar = New System.Windows.Forms.ProgressBar()
        Me.loadingStatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loadingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'loadingProgressBar
        '
        Me.loadingProgressBar.Location = New System.Drawing.Point(4, 287)
        Me.loadingProgressBar.Name = "loadingProgressBar"
        Me.loadingProgressBar.Size = New System.Drawing.Size(516, 14)
        Me.loadingProgressBar.TabIndex = 0
        '
        'loadingStatusLabel
        '
        Me.loadingStatusLabel.AutoSize = True
        Me.loadingStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.loadingStatusLabel.ForeColor = System.Drawing.Color.Teal
        Me.loadingStatusLabel.Location = New System.Drawing.Point(17, 265)
        Me.loadingStatusLabel.Name = "loadingStatusLabel"
        Me.loadingStatusLabel.Size = New System.Drawing.Size(0, 13)
        Me.loadingStatusLabel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(52, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "49422669 Library"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(109, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Management System"
        '
        'loadingTimer
        '
        '
        'frmLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._49422669Library.My.Resources.Resources.wallpaper
        Me.ClientSize = New System.Drawing.Size(524, 334)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.loadingStatusLabel)
        Me.Controls.Add(Me.loadingProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLoading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLoading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loadingProgressBar As ProgressBar
    Friend WithEvents loadingStatusLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents loadingTimer As Timer
End Class
