Public Class frmManageBooks
    ''
    Dim objBookService As New BookService()

    Private Sub frmManageBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        dgvBooks.DataSource = objBookService.GetAll()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ''
        If txtSearch.Text.Length > 3 Then
            Dim searchTable As DataTable = objBookService.GetByBookNumber(txtSearch.Text)

            If searchTable.Rows.Count = 1 Then
                dgvBooks.DataSource = searchTable
                txtBookNumber.Text = searchTable.Rows(0)("BookNumber").ToString()
                txtBookName.Text = searchTable.Rows(0)("BookName").ToString()
                txtAuthorName.Text = searchTable.Rows(0)("AuthorName").ToString()
                txtBookQuantity.Text = searchTable.Rows(0)("BookQuantity").ToString()
                txtBookCategory.Text = searchTable.Rows(0)("CategoryName").ToString()
            Else
                MessageBox.Show("Book #" & txtSearch.Text & " could not be found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSearch.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnUpdateBook_Click(sender As Object, e As EventArgs) Handles btnUpdateBook.Click
        ''
        Dim newBook As New Book

        ''
        newBook.BookNumber = txtBookNumber.Text
        newBook.BookName = txtBookName.Text
        newBook.AuthorName = txtAuthorName.Text
        newBook.BookQuantity = txtBookQuantity.Text

        ''
        If objBookService.Update(newBook) = True Then
            MessageBox.Show("Book successfully modified.", "Update Book", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Book could not be modified.", "Update Book", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDeleteBook_Click(sender As Object, e As EventArgs) Handles btnDeleteBook.Click
        ''
        If txtBookNumber.Text.Length > 5 Then
            If objBookService.Delete(txtBookNumber.Text) = True Then
                MessageBox.Show("Book successfully deleted.", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Book could not be deleted.", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Book number is invalid.", "input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBookNumber.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btnResetBook_Click(sender As Object, e As EventArgs) Handles btnResetBook.Click
        ''
        txtBookNumber.Clear()
        txtBookName.Clear()
        txtAuthorName.Clear()
        txtBookQuantity.Clear()
        txtBookCategory.Clear()
        txtSearch.Clear()

        dgvBooks.DataSource = objBookService.GetAll()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ''
        frmDashboard.Show()
        Me.Hide()
    End Sub
End Class