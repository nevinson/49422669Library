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

    Private Sub RefreshPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshPageToolStripMenuItem.Click

    End Sub

#Region "MenuStrip"
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ''
        Constants.ExitProgram(True)
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        ''
        frmAddUser.Show()
        Me.Hide()
    End Sub

    Private Sub ManageUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUserToolStripMenuItem.Click
        ''
        frmManageUsers.Show()
        Me.Hide()
    End Sub

    Private Sub AddBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddBookToolStripMenuItem.Click
        ''

    End Sub

    Private Sub ManageBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBookToolStripMenuItem.Click
        ''
        frmAddUser.Show()
        Me.Hide()
    End Sub

    Private Sub AddBorrowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddBorrowsToolStripMenuItem.Click
        ''
        frmAddBorrow.Show()
        Me.Hide()
    End Sub

    Private Sub ManageBorrowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBorrowsToolStripMenuItem.Click
        ''
        frmManageBorrows.Show()
        Me.Hide()
    End Sub

    Private Sub AddReservesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddReservesToolStripMenuItem.Click
        ''
        frmAddReserves.Show()
        Me.Hide()
    End Sub

    Private Sub ManageReservesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageReservesToolStripMenuItem.Click
        ''
        frmManageReserves.Show()
        Me.Hide()
    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToUseToolStripMenuItem.Click
        ''
        MessageBox.Show("Please refer to the user manual supplied with the product.", "How To Use", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ''
        MessageBox.Show("49422669 Library is a VB.Net project created for the UNISA Module ICT3714 Assessment Project.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
End Class