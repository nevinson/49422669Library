Public Class frmEditUser
    ''
    Dim objUserService As New UserService()

    Private Sub frmEditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        If frmManageUsers.SelectedUser.MembershipNumber = Nothing Then
            frmManageUsers.Show()
            Me.Hide()
        Else
            txtMembershipNumber.Text = frmManageUsers.SelectedUser.MembershipNumber
            txtFirstName.Text = frmManageUsers.SelectedUser.FirstName
            txtLastName.Text = frmManageUsers.SelectedUser.LastName
            txtEmailAddress.Text = frmManageUsers.SelectedUser.Email
            txtUsername.Text = frmManageUsers.SelectedUser.Username
        End If
    End Sub

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        ''
        Dim updateUser As New User

        ''
        If txtMembershipNumber.Text = "" Then
            frmManageUsers.Show()
            Me.Hide()
        Else
            updateUser.MembershipNumber = txtMembershipNumber.Text
            updateUser.Email = txtEmailAddress.Text
            updateUser.Username = txtUsername.Text

            If objuserservice.Update(updateUser) = True Then
                MessageBox.Show("User successfully updated.", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Could not successfully update User.", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ''
        frmDashboard.Show()
        Me.Hide()
    End Sub

#Region "Menu Items"
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ''
        frmLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub ResfreshPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResfreshPageToolStripMenuItem.Click
        ''
        If frmManageUsers.SelectedUser.MembershipNumber = Nothing Then
            frmManageUsers.Show()
            Me.Hide()
        Else
            txtMembershipNumber.Text = frmManageUsers.SelectedUser.MembershipNumber
            txtFirstName.Text = frmManageUsers.SelectedUser.FirstName
            txtLastName.Text = frmManageUsers.SelectedUser.LastName
            txtEmailAddress.Text = frmManageUsers.SelectedUser.Email
            txtUsername.Text = frmManageUsers.SelectedUser.Username
        End If
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
        frmManageMessage.Show()
        Me.Hide()
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
End Class