Public Class frmAddUser
    ''
    Dim objUserService As New UserService()

    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        txtMembershipNumber.Text = objUserService.GenerateMembershipNumber()
    End Sub

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        ''
        Dim newUser As New User

        ''
        If txtMembershipNumber.Text.Length = 10 Then
            newUser.MembershipNumber = txtMembershipNumber.Text
        Else
            txtMembershipNumber.Text = objUserService.GenerateMembershipNumber()
            Exit Sub
        End If
        If txtFirstName.Text = "" Or IsNumeric(txtFirstName.Text) Then
            MessageBox.Show("Enter a valid first name.", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFirstName.Clear()
            txtFirstName.Focus()
            Exit Sub
        Else
            newUser.FirstName = txtFirstName.Text
        End If
        If txtLastName.Text = "" Or IsNumeric(txtLastName.Text) Then
            MessageBox.Show("Enter a valid last name.", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLastName.Clear()
            txtLastName.Focus()
            Exit Sub
        Else
            newUser.LastName = txtLastName.Text
        End If
        If txtEmailAddress.Text.Length < 10 Then
            MessageBox.Show("Enter a valid email address.", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmailAddress.Clear()
            txtEmailAddress.Focus()
            Exit Sub
        Else
            newUser.Email = txtEmailAddress.Text
        End If
        If txtLastName.Text.Length < 3 Then
            MessageBox.Show("Enter a valid username.", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Clear()
            txtUsername.Focus()
            Exit Sub
        Else
            newUser.Username = txtUsername.Text
        End If
        If txtPassword.Text.Length < 6 Then
            MessageBox.Show("Enter a valid password.", "Create User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
            Exit Sub
        Else
            newUser.Password = txtPassword.Text
        End If

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
        txtMembershipNumber.Text = objUserService.GenerateMembershipNumber()
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