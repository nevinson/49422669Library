Public Class frmReplyMessage
    ''
    Dim objMessageService As New MessageService()

    Private Sub btnReply_Click(sender As Object, e As EventArgs) Handles btnReply.Click
        ''
        Dim newMessage As New Message

        ''
        If frmLogIn.MembershipType = "Admin" Then
            newMessage.Sender = Constants.AdminId()
            If frmLogIn.MembershipNumber.Equals(frmManageMessage.SelectedMessage.Sender) Then
                newMessage.Reciever = frmManageMessage.SelectedMessage.Reciever
            ElseIf frmLogIn.MembershipNumber.Equals(frmManageMessage.SelectedMessage.Reciever) Then
                newMessage.Reciever = frmManageMessage.SelectedMessage.Sender
            End If
        ElseIf frmLogIn.MembershipType = "Member" Then
            newMessage.Sender = frmLogIn.MembershipNumber
            newMessage.Reciever = Constants.AdminId()
        End If

        If txtMessage.Text.Length > 5 Then
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