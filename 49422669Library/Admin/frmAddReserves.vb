﻿Public Class frmAddReserves
    ''
    Dim objReserveService As New ReserveService()

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ''
        frmDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        ''
        Dim newReserve As New BookReserve

        ''
        If txtMembershipNumber.Text.Length > 5 And txtBookNumber.Text.Length > 5 Then
            newReserve.BookNumber = txtBookNumber.Text
            newReserve.MembershipNumber = txtMembershipNumber.Text
            newReserve.ReserveDate = DateTime.Now.ToLongDateString()
            If objReserveService.Create(newReserve) Then
                MessageBox.Show("Book successfully reserved.", "Reserve Book", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Book could not be reserved.", "Reserve Book", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#Region "MenuStrip"
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ''
        Constants.ExitProgram(True)
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        ''
        frmAddUser.Show()
        Me.Hide()
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
        ''
        frmAddUser.Show()
        Me.Hide()
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

    End Sub

    Private Sub ManageReservesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageReservesToolStripMenuItem.Click
        ''
        frmManageReserves.Show()
        Me.Hide()
    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToUseToolStripMenuItem.Click
        ''
        MessageBox.Show("Please refer to the user manual supplied with the product.", "How To Use", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ''
        MessageBox.Show("49422669 Library is a VB.Net project created for the UNISA Module ICT3714 Assessment Project.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
End Class