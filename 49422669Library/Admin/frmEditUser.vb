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
        frmAddUser.Show()
        Me.Hide()
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