Public Class frmManageUsers
    ''
    Dim objUserService As New UserService()

    Private Sub frmManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''''
        dgvUsers.DataSource = objUserService.GetAll()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ''
        If txtSearch.Text.Length > 3 Then
            Dim searchTable As DataTable = objUserService.GetUserByMembershipNumber(txtSearch.Text)

            If searchTable.Rows.Count = 1 Then
                dgvUsers.DataSource = searchTable
                txtMembershipNumber.Text = searchTable.Rows(0)("MembershipNumber").ToString()
                txtUsername.Text = searchTable.Rows(0)("Username").ToString()
                txtEmailAddress.Text = searchTable.Rows(0)("Email").ToString()
                txtFullName.Text = searchTable.Rows(0)("FirstName").ToString() & " " & searchTable.Rows(0)("LastName").ToString()
            Else
                MessageBox.Show("Book #" & txtSearch.Text & " could not be found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSearch.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnBlacklistUser_Click(sender As Object, e As EventArgs) Handles btnBlacklistUser.Click
        ''
        If txtMembershipNumber.Text.Length > 5 Then
            If objUserService.Blacklist(txtMembershipNumber.Text) = True Then
                MessageBox.Show("User successfully balcklisted.", "Blacklist User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("User cannot be blacklisted.", "Blacklist User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        ''
        If txtMembershipNumber.Text.Length > 5 Then
            If objUserService.Delete(txtMembershipNumber.Text) = True Then
                MessageBox.Show("User successfully deleted.", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("User cannot be deleted.", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error)
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