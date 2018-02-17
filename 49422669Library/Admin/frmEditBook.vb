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
End Class