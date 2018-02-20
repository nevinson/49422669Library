Public Class frmViewMessage
    Private Sub frmViewMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        If frmManageMessage.SelectedMessage.MessageId = Nothing Then
            frmManageMessage.Show()
            Me.Hide()
        Else
            If frmManageMessage.SelectedMessage.Sender.Equals(frmLogIn.MembershipNumber) Then
                btnReply.Visible = False
            Else
                btnReply.Visible = True
            End If

            txtSender.Text = frmManageMessage.SenderName
            txtReceiver.Text = frmManageMessage.ReceiverName
            txtMessage.Text = frmManageMessage.SelectedMessage.Content
            txtDate.Text = frmManageMessage.SelectedMessage.DateCreated
        End If
    End Sub

    Private Sub btnReply_Click(sender As Object, e As EventArgs) Handles btnReply.Click
        ''
        If frmManageMessage.SelectedMessage.MessageId = Nothing Then
            frmManageMessage.Show()
            Me.Hide()
        Else
            frmReplyMessage.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ''
        frmManageMessage.Show()
        Me.Hide()
    End Sub
End Class