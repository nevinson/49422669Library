Public Class frmAddMessage
    ''
    Dim objMessageService As New MessageService()
    Dim objUserService As New UserService()

    Private Sub frmAddMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        Try
            If frmLogIn.MembershipType = "Admin" Then

                txtSender.Text = frmLogIn.MembershipNumber
            Else
                txtSender.Text = frmLogIn.MembershipNumber
                txtReceiver.Text = Constants.AdminId()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        ''
        frmManageMessage.Show()
        Me.Hide()
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        ''
        Dim newMessage As New Message

        ''
        If objUserService.GetByMembershipNumber(txtReceiver.Text).Rows.Count = 1 Then
            If txtMessage.Text.Length > 5 Then
                newMessage.Sender = txtSender.Text
                newMessage.Reciever = txtReceiver.Text
                newMessage.Content = txtMessage.Text
                newMessage.DateCreated = DateTime.Now.ToLongDateString
                newMessage.Status = "Unread"
            End If

            If objMessageService.Create(newMessage) = True Then
                MessageBox.Show("Message successfully replied.", "Reply Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Message could not be replied.", "Reply Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Message could not be sent.", "Reply Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class