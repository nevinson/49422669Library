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

        ''
        If frmLogIn.MembershipType = "Admin" Then
            AdminMenu.Visible = True
        ElseIf frmLogIn.MembershipType = "Member" Then
            MemberMenu.Visible = True
        End If
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

#Region "Admin Menu Items"
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ''
        frmLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub ResfreshPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResfreshPageToolStripMenuItem.Click
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

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ''
        Constants.ExitProgram(True)
    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click
        ''
        frmManageUsers.Show()
        Me.Hide()
    End Sub

    Private Sub ManageMessagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageMessagesToolStripMenuItem.Click
        ''
        'frmManageMessage.Show()
        'Me.Hide()
    End Sub

    Private Sub ManageBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBooksToolStripMenuItem.Click
        ''
        frmManageBooks.Show()
        Me.Hide()
    End Sub

    Private Sub ManageBorrowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBorrowsToolStripMenuItem.Click
        ''
        frmManageBorrows.Show()
        Me.Hide()
    End Sub

    Private Sub ManageReservesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageReservesToolStripMenuItem.Click
        ''
        frmManageReserves.Show()
        Me.Hide()
    End Sub

    Private Sub HowTouseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowTouseToolStripMenuItem.Click
        ''
        MessageBox.Show("Please refer to the user manual supplied with the product.", "How To Use", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ''
        MessageBox.Show("49422669 Library is a VB.Net project created for the UNISA Module ICT3714 Assessment Project.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region

#Region "Member Menu Strip"
    Private Sub UserLogout_Click(sender As Object, e As EventArgs) Handles UserLogout.Click
        ''
        frmLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub UserRefreshPage_Click(sender As Object, e As EventArgs) Handles UserRefreshPage.Click
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

    Private Sub UserExit_Click(sender As Object, e As EventArgs) Handles UserExit.Click
        ''
        Constants.ExitProgram(True)
    End Sub

    Private Sub UserProfile_Click(sender As Object, e As EventArgs) Handles UserProfile.Click
        ''
        frmProfile.Show()
        Me.Hide()
    End Sub

    Private Sub UserMessages_Click(sender As Object, e As EventArgs) Handles UserMessages.Click
        ''
        'frmManageMessage.Show()
        'Me.Hide()
    End Sub

    Private Sub UserReserves_Click(sender As Object, e As EventArgs) Handles UserReserves.Click
        frmReserve.Show()
        Me.Show()
    End Sub

    Private Sub UserHowToUse_Click(sender As Object, e As EventArgs) Handles UserHowToUse.Click
        ''
        MessageBox.Show("Please refer to the user manual supplied with the product.", "How To Use", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UserAbout_Click(sender As Object, e As EventArgs) Handles UserAbout.Click
        ''
        MessageBox.Show("49422669 Library is a VB.Net project created for the UNISA Module ICT3714 Assessment Project.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
End Class