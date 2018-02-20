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

    Private Sub ManageMessages_Click(sender As Object, e As EventArgs) Handles ManageMessages.Click
        ''
        frmManageMessage.Show()
        Me.Hide()
    End Sub
#End Region
End Class