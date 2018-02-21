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
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ''
        frmLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub ResfreshPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResfreshPageToolStripMenuItem.Click
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