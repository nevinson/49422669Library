Public Class frmDashboard
    ''
    Dim objUserService As New UserService()
    Dim objBookService As New BookService()
    Dim objBorrowService As New BorrowService()
    Dim objReserveService As New ReserveService()
    Dim objMessageService As New MessageService()

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        lblUsers.Text = objUserService.GetAll().Rows.Count().ToString()
        lblBooks.Text = objBookService.GetAll().Rows.Count().ToString()
        lblBorrows.Text = objBorrowService.GetAll().Rows.Count().ToString()
        lblReserves.Text = objReserveService.GetAll().Rows.Count().ToString()
        lblMessages.Text = objMessageService.GetUnreadByMembershipNumber(frmLogIn.MembershipNumber).Rows.Count.ToString()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ''
        frmLogIn.Show()
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
        lblUsers.Text = objUserService.GetAll().Rows.Count().ToString()
        lblBooks.Text = objBookService.GetAll().Rows.Count().ToString()
        lblBorrows.Text = objBorrowService.GetAll().Rows.Count().ToString()
        lblReserves.Text = objReserveService.GetAll().Rows.Count().ToString()
        lblMessages.Text = objMessageService.GetUnreadByMembershipNumber(frmLogIn.MembershipNumber).Rows.Count.ToString()
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