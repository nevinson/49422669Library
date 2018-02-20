Public Class frmEditBook
    ''
    Dim objBookService As New BookService()

    Private Sub frmEditBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        If frmManageBooks.SelectedBook.BookNumber = Nothing Then
            frmManageBooks.Show()
            Me.Hide()
        Else
            txtBookNumber.Text = frmManageBooks.SelectedBook.BookNumber
            txtBookName.Text = frmManageBooks.SelectedBook.BookName
            txtAuthorName.Text = frmManageBooks.SelectedBook.AuthorName
            txtBookQuantity.Text = frmManageBooks.SelectedBook.BookQuantity.ToString()
        End If
    End Sub

    Private Sub btnUpdateBook_Click(sender As Object, e As EventArgs) Handles btnUpdateBook.Click
        ''
        Dim updateBook As New Book

        ''
        If txtBookNumber.Text = "" Then
            frmManageBooks.Show()
            Me.Hide()
        Else
            updateBook.BookNumber = txtBookNumber.Text
            updateBook.BookName = txtBookName.Text
            updateBook.AuthorName = txtAuthorName.Text
            updateBook.BookQuantity = Integer.Parse(txtBookQuantity.Text)

            If objBookService.Update(updateBook) = True Then
                MessageBox.Show("Book successfully updated.", "Edit Book", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Could not successfully update book.", "Edit Book", MessageBoxButtons.OK, MessageBoxIcon.Error)
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