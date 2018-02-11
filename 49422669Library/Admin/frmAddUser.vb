﻿Public Class frmAddUser
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


#Region "MenuStrip"
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ''
        Constants.ExitProgram(True)
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click

    End Sub

    Private Sub ManageUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUserToolStripMenuItem.Click
        ''
        frmManageUsers.Show()
        Me.Hide()
    End Sub

    Private Sub AddBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddBookToolStripMenuItem.Click
        ''
        frmAddBook.Show()
        Me.Hide()
    End Sub

    Private Sub ManageBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBookToolStripMenuItem.Click

    End Sub

    Private Sub AddBorrowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddBorrowsToolStripMenuItem.Click
        ''
        frmAddBorrow.Show()
        Me.Hide()
    End Sub

    Private Sub ManageBorrowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBorrowsToolStripMenuItem.Click
        ''
        frmManageBorrows.Show()
        Me.Hide()
    End Sub

    Private Sub AddReservesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddReservesToolStripMenuItem.Click
        ''
        frmAddReserves.Show()
        Me.Hide()
    End Sub

    Private Sub ManageReservesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageReservesToolStripMenuItem.Click
        ''
        frmManageReserves.Show()
        Me.Hide()
    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ''
        MessageBox.Show("Please refer to the user manual supplied with the product.", "How To Use", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ''
        MessageBox.Show("49422669 Library is a VB.Net project created for the UNISA Module ICT3714 Assessment Project.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
End Class