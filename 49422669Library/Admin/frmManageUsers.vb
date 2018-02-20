Public Class frmManageUsers
    ''
    Dim objUserService As New UserService()
    Public Shared SelectedUser As New User

    Private Sub RefreshGrid()
        ''
        lstUsers.Items.Clear()

        ''
        Dim usersTable As DataTable = objUserService.GetAll()

        ''
        For i = 0 To usersTable.Rows.Count - 1
            With lstUsers
                .Items.Add(usersTable.Rows(i)("MembershipNumber"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(usersTable.Rows(i)("FirstName"))
                    .Add(usersTable.Rows(i)("LastName"))
                    .Add(usersTable.Rows(i)("Email"))
                    .Add(usersTable.Rows(i)("Username"))
                    .Add(usersTable.Rows(i)("MembershipType"))
                    .Add(usersTable.Rows(i)("Status"))
                    .Add(usersTable.Rows(i)("JoinDate"))
                End With
            End With
        Next
    End Sub

    Private Sub frmManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        RefreshGrid()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ''
        lstUsers.Items.Clear()

        ''
        If txtSearch.Text.Length >= 1 Then
            Dim searchTable As DataTable = objUserService.Search("%" & txtSearch.Text & "%")

            If searchTable.Rows.Count >= 1 Then
                ''
                For i = 0 To searchTable.Rows.Count - 1
                    With lstUsers
                        .Items.Add(searchTable.Rows(i)("MembershipNumber"))
                        With .Items(.Items.Count - 1).SubItems
                            .Add(searchTable.Rows(i)("FirstName"))
                            .Add(searchTable.Rows(i)("LastName"))
                            .Add(searchTable.Rows(i)("Email"))
                            .Add(searchTable.Rows(i)("Username"))
                            .Add(searchTable.Rows(i)("MembershipType"))
                            .Add(searchTable.Rows(i)("Status"))
                            .Add(searchTable.Rows(i)("JoinDate"))
                        End With
                    End With
                Next
            Else
                MessageBox.Show("Book #" & txtSearch.Text & " could not be found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSearch.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        ''
        frmAddUser.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        ''
        If SelectedUser.MembershipNumber.Length >= 5 Then
            frmEditUser.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please select a user to update from the list.", "Manage User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub btnDeleteUser_Click_1(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        ''
        If SelectedUser.MembershipNumber.Length >= 5 Then
            If objUserService.UpdateStatus(SelectedUser.MembershipNumber, "InActive") = True Then
                MessageBox.Show("User successfully deleted.", "Manage User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshGrid()
            Else
                MessageBox.Show("Could not successfully delete user.", "Manage User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            MessageBox.Show("Please select a user to delete from the list.", "Manage User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub btnBlacklistUser_Click_1(sender As Object, e As EventArgs) Handles btnBlacklistUser.Click
        ''
        If SelectedUser.MembershipNumber.Length >= 5 Then
            If objUserService.UpdateStatus(SelectedUser.MembershipNumber, "Blacklisted") = True Then
                MessageBox.Show("User successfully blacklisted.", "Manage User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshGrid()
            Else
                MessageBox.Show("Could not successfully blacklist user.", "Manage User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            MessageBox.Show("Please select a user to blacklist from the list.", "Manage User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub btnUnBlacklistUser_Click(sender As Object, e As EventArgs) Handles btnUnBlacklistUser.Click
        ''
        If SelectedUser.MembershipNumber.Length >= 5 Then
            If objUserService.UpdateStatus(SelectedUser.MembershipNumber, "Active") = True Then
                MessageBox.Show("User successfully unblacklisted.", "Manage User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshGrid()
            Else
                MessageBox.Show("Could not successfully unblacklist user.", "Manage User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            MessageBox.Show("Please select a user to unblacklist from the list.", "Manage User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        ''
        frmDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub lstUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsers.SelectedIndexChanged
        ''
        SelectedUser.MembershipNumber = lstUsers.Items(lstUsers.FocusedItem.Index).SubItems(0).Text
        SelectedUser.FirstName = lstUsers.Items(lstUsers.FocusedItem.Index).SubItems(1).Text
        SelectedUser.LastName = lstUsers.Items(lstUsers.FocusedItem.Index).SubItems(2).Text
        SelectedUser.Email = lstUsers.Items(lstUsers.FocusedItem.Index).SubItems(3).Text
        SelectedUser.Username = lstUsers.Items(lstUsers.FocusedItem.Index).SubItems(4).Text
        SelectedUser.MembershipType = lstUsers.Items(lstUsers.FocusedItem.Index).SubItems(5).Text
        SelectedUser.Status = lstUsers.Items(lstUsers.FocusedItem.Index).SubItems(6).Text
        SelectedUser.JoinDate = Convert.ToDateTime(lstUsers.Items(lstUsers.FocusedItem.Index).SubItems(7).Text)
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
        'frmManageUsers.Show()
        'Me.Hide()
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