Public Class frmReplyMessage
    ''
    Dim objMessageService As New MessageService()

    Private Sub btnReply_Click(sender As Object, e As EventArgs) Handles btnReply.Click
        ''
        Dim strSender As String = Nothing, strReceiver As String = Nothing

        ''
        If frmManageMessage.SelectedMessage.Sender = frmLogIn.MembershipNumber Then
            strSender = frmLogIn.MembershipNumber
            strReceiver = frmManageMessage.SelectedMessage.Reciever
        ElseIf frmManageMessage.SelectedMessage.Reciever = frmLogIn.MembershipNumber Then
            strSender = frmLogIn.MembershipNumber
            strReceiver = frmManageMessage.SelectedMessage.Sender
        End If

        ''
        Dim newMessage As New Message

        If txtMessage.Text.Length > 5 Then
            newMessage.Sender = strSender
            newMessage.Reciever = strReceiver
            newMessage.Content = txtMessage.Text
            newMessage.DateCreated = DateTime.Now.ToLongDateString
            newMessage.Status = "Unread"
        End If

        ''
        If objMessageService.Create(newMessage) = True Then
            MessageBox.Show("Message successfully replied.", "Reply Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Message could not be replied.", "Reply Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ''
        frmManageMessage.Show()
        Me.Hide()
    End Sub
End Class