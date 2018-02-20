Public Class frmManageMessage
    ''
    Dim objMessageService As New MessageService()
    Public Shared SelectedMessage As New Message
    Public Shared SenderName As String
    Public Shared ReceiverName As String

    Private Sub RefreshGrid()
        ''
        lstMessages.Items.Clear()

        ''
        Dim usersTable As DataTable = objMessageService.GetByMembershipNumber(frmLogIn.MembershipNumber)

        ''
        For i = 0 To usersTable.Rows.Count - 1
            With lstMessages
                .Items.Add(usersTable.Rows(i)("MessageId"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(usersTable.Rows(i)("Sender"))
                    .Add(usersTable.Rows(i)("SenderName"))
                    .Add(usersTable.Rows(i)("Receiver"))
                    .Add(usersTable.Rows(i)("ReceiverName"))
                    .Add(usersTable.Rows(i)("Content"))
                    .Add(usersTable.Rows(i)("Status"))
                    .Add(usersTable.Rows(i)("DateCreated"))
                End With
            End With
        Next
    End Sub

    Private Sub frmManageMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        RefreshGrid()
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        ''
        If SelectedMessage.MessageId = Nothing Then
            MessageBox.Show("Please select a message to read from the list.", "Manage Messages", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If objMessageService.UpdateStatus(SelectedMessage.MessageId) = True Then
                frmViewMessage.Show()
                Me.Hide()
            Else
                MessageBox.Show("Please select a message to read from the list.", "Manage Messages", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnCompose_Click(sender As Object, e As EventArgs) Handles btnCompose.Click
        ''
        frmAddMessage.Show()
        Me.Hide()
    End Sub

    Private Sub btnReply_Click(sender As Object, e As EventArgs) Handles btnReply.Click
        ''
        If SelectedMessage.MessageId = Nothing Then
            MessageBox.Show("Please select a message to reply from the list.", "Manage Messages", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            frmReplyMessage.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ''
        If SelectedMessage.MessageId = Nothing Then
            MessageBox.Show("Please select a message to delete from the list.", "Manage Messages", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If objMessageService.Delete(SelectedMessage.MessageId) = True Then
                MessageBox.Show("Message successfully deleted.", "Manage Messages", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshGrid()
            Else
                MessageBox.Show("Could not successfully delete message.", "Manage Messages", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ''
        frmDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub lstMessages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMessages.SelectedIndexChanged
        ''
        SelectedMessage.MessageId = lstMessages.Items(lstMessages.FocusedItem.Index).SubItems(0).Text
        SelectedMessage.Sender = lstMessages.Items(lstMessages.FocusedItem.Index).SubItems(1).Text
        SenderName = lstMessages.Items(lstMessages.FocusedItem.Index).SubItems(2).Text
        SelectedMessage.Reciever = lstMessages.Items(lstMessages.FocusedItem.Index).SubItems(3).Text
        ReceiverName = lstMessages.Items(lstMessages.FocusedItem.Index).SubItems(4).Text
        SelectedMessage.Content = lstMessages.Items(lstMessages.FocusedItem.Index).SubItems(5).Text
        SelectedMessage.Status = lstMessages.Items(lstMessages.FocusedItem.Index).SubItems(6).Text
        SelectedMessage.DateCreated = lstMessages.Items(lstMessages.FocusedItem.Index).SubItems(7).Text
    End Sub
End Class