Public Class frmAddBook
    ''
    Dim objBookService As New BookService()
    Dim intCategoryId As Integer = 0

    Private Sub frmAddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBookNumber.Text = objBookService.GenerateBookNumber()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ''
        frmDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub cmbBookCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBookCategory.SelectedIndexChanged
        ''
        If cmbBookCategory.SelectedIndex = 0 Then
            intCategoryId = 1
        ElseIf cmbBookCategory.SelectedIndex = 1 Then
            intCategoryId = 2
        ElseIf cmbBookCategory.SelectedIndex = 2 Then
            intCategoryId = 3
        ElseIf cmbBookCategory.SelectedIndex = 3 Then
            intCategoryId = 4
        ElseIf cmbBookCategory.SelectedIndex = 4 Then
            intCategoryId = 5
        End If
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        ''
        Dim newBook As New Book

        ''
        newBook.BookNumber = txtBookNumber.Text
        newBook.BookName = txtBookName.Text
        newBook.AuthorName = txtAuthorName.Text
        newBook.BookQuantity = txtBookQuantity.Text
        newBook.BookCategoryId = intCategoryId

        ''
        If objBookService.Create(newBook) = True Then
            MessageBox.Show("Book successfully created.", "Create Book", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Book could not be created.", "Create Book", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        'frmAddBook.Show()
        'Me.Hide()
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