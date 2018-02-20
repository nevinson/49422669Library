Public Class frmAddReserves
    ''
    Dim objReserveService As New ReserveService()

    Private Sub frmAddReserves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        If frmManageBooks.SelectedBook.BookNumber = Nothing Then
            txtBookNumber.Text = Nothing
        Else
            txtBookNumber.Text = frmManageBooks.SelectedBook.BookNumber
        End If
    End Sub

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
        'frmAddReserves.Show()
        'Me.Hide()
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