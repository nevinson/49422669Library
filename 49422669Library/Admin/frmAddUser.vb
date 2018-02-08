Public Class frmAddUser
    ''
    Dim objUserService As New UserService()

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        ''
        Dim newUser As New User

        ''
        newUser.MembershipNumber = txtMembershipNumber.Text
        newUser.FirstName = txtFirstName.Text
        newUser.LastName = txtLastName.Text
        newUser.Email = txtEmailAddress.Text
        newUser.Username = txtUsername.Text
        newUser.Password = txtPassword.Text

        If cmbUserType.SelectedIndex = 0 Then
            newUser.MembershipType = "Admin"
        ElseIf cmbUserType.SelectedIndex = 1 Then
            newUser.MembershipType = "Member"
        End If

        newUser.Status = "Active"
        newUser.JoinDate = DateTime.Now.ToShortDateString

        ''
        If objUserService.Create(newUser) = True Then
            MessageBox.Show("User profile successfully created.", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("User profile could not be created.", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ''

    End Sub
End Class