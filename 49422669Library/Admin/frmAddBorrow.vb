Public Class frmAddBorrow
    ''
    Dim objBorrowService As New BorrowService
    Dim objBookService As New BookService

    Private Sub frmAddBorrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        If frmManageBooks.SelectedBook.BookNumber = Nothing Then
            txtBookNumber.Text = Nothing
        Else
            txtBookNumber.Text = frmManageBooks.SelectedBook.BookNumber
        End If
    End Sub

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
            Dim book As DataTable = objBookService.SearchByBookNumber(txtBookNumber.Text)
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
        frmDashboard.Show()
        Me.Hide()
    End Sub

#Region "Menu Items"
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ''
        frmLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub ResfreshPageToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ''

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