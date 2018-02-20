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
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        ''
        frmLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub ExitMenu_Click(sender As Object, e As EventArgs) Handles ExitMenu.Click
        ''
        Constants.ExitProgram(True)
    End Sub

    Private Sub ManageUsers_Click(sender As Object, e As EventArgs) Handles ManageUsers.Click
        ''
        frmManageUsers.Show()
        Me.Hide()
    End Sub

    Private Sub ManageBooks_Click(sender As Object, e As EventArgs) Handles ManageBooks.Click
        ''
        frmManageBooks.Show()
        Me.Hide()
    End Sub

    Private Sub ManageBorrowedBooks_Click(sender As Object, e As EventArgs) Handles ManageBorrowedBooks.Click
        ''
        frmManageBorrows.Show()
        Me.Hide()
    End Sub

    Private Sub ManageReservedBook_Click(sender As Object, e As EventArgs) Handles ManageReservedBook.Click
        ''
        frmManageReserves.Show()
        Me.Hide()
    End Sub

    Private Sub AddUser_Click(sender As Object, e As EventArgs) Handles AddUser.Click
        ''
        'frmAddUser.Show()
        'Me.Hide()
    End Sub

    Private Sub AddBook_Click(sender As Object, e As EventArgs) Handles AddBook.Click
        ''
        frmAddBook.Show()
        Me.Hide()
    End Sub

    Private Sub AddBorrowedBook_Click(sender As Object, e As EventArgs) Handles AddBorrowedBook.Click
        ''
        frmAddBorrow.Show()
        Me.Hide()
    End Sub

    Private Sub AddReservedBook_Click(sender As Object, e As EventArgs) Handles AddReservedBook.Click
        ''
        frmAddReserves.Show()
        Me.Hide()
    End Sub

    Private Sub HowToUse_Click(sender As Object, e As EventArgs) Handles HowToUse.Click
        ''
        MessageBox.Show("Please refer to the user manual supplied with the product.", "How To Use", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        ''
        MessageBox.Show("49422669 Library is a VB.Net project created for the UNISA Module ICT3714 Assessment Project.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
End Class