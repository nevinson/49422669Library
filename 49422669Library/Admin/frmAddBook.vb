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
            MessageBox.Show("book could not be created.", "Create Book", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class