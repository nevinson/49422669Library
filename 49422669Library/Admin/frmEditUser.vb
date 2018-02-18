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
End Class