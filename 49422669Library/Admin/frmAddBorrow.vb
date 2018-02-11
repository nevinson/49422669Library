Public Class frmAddBorrow
    ''
    Dim objBorrowService As New BorrowService
    Dim objBookService As New BookService

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        ''
        Dim newBorrow As New BookBorrow

        ''
        If txtBookNumber.Text.Length > 5 And txtBookNumber.Text.Length > 5 Then
            newBorrow.BookNumber = txtBookNumber.Text
            newBorrow.MembershipNumber = txtMembershipNumber.Text
            newBorrow.PickupDate = DateTime.Now.ToLongDateString()
            newBorrow.ReturnDate = dteReturnDate.Value.ToLongDateString()

            ''
            Dim book As DataTable = objBookService.GetByBookNumber(txtBookNumber.Text)
            Dim updateBook As New Book

            ''
            If book.Rows.Count = 1 Then
                updateBook.BookNumber = book.Rows(0)("BookNumber")
                updateBook.BookQuantity = Integer.Parse(book.Rows(0)("BookQuantity").ToString()) - 1

                If objBorrowService.Create(newBorrow) Then
                    If objBookService.UpdateQuantity(updateBook) = True Then
                        MessageBox.Show("Book successfully lent to member.", "Borrow Book", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Book could not be lent to member.", "Borrow Book", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Book could not be lent to member.", "Borrow Book", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        '' show the user dashboard form
        frmUserDashboard.Show()
        Me.Hide()
    End Sub

End Class