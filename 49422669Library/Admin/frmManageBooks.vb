Public Class frmManageBooks
    ''
    Dim objBookService As New BookService()
    Public Shared SelectedBook As New Book

    Private Sub RefreshGrid()
        ''
        lstBooks.Items.Clear()

        ''
        Dim borrowsTable As DataTable = objBookService.GetAll()

        ''
        For i = 0 To borrowsTable.Rows.Count - 1
            With lstBooks
                .Items.Add(borrowsTable.Rows(i)("BookNumber"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(borrowsTable.Rows(i)("BookName"))
                    .Add(borrowsTable.Rows(i)("AuthorName"))
                    .Add(borrowsTable.Rows(i)("BookQuantity"))
                    .Add(borrowsTable.Rows(i)("CategoryName"))
                End With
            End With
        Next
    End Sub

    Private Sub frmManageBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        RefreshGrid()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ''
        If txtSearch.Text.Length > 3 Then
            Dim searchTable As DataTable = objBookService.Search("%" & txtSearch.Text & "%")

            If searchTable.Rows.Count >= 1 Then
                ''
                For i = 0 To searchTable.Rows.Count - 1
                    With lstBooks
                        .Items.Add(searchTable.Rows(i)("BookNumber"))
                        With .Items(.Items.Count - 1).SubItems
                            .Add(searchTable.Rows(i)("BookName"))
                            .Add(searchTable.Rows(i)("AuthorName"))
                            .Add(searchTable.Rows(i)("BookQuantity"))
                            .Add(searchTable.Rows(i)("CategoryName"))
                        End With
                    End With
                Next
            Else
                MessageBox.Show("Book #" & txtSearch.Text & " could not be found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSearch.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ''
        frmAddBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ''
        Try
            If SelectedBook.BookNumber.Length >= 5 And SelectedBook.BookName.Length >= 1 Then
                frmEditBook.Show()
                Me.Hide()
            Else
                MessageBox.Show("Please select a book to update from the list.", "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Please select a book to update from the list.", "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ''
        Try
            If SelectedBook.BookNumber.Length >= 5 And SelectedBook.BookName.Length >= 1 Then
                If objBookService.Delete(SelectedBook.BookNumber) = True Then
                    MessageBox.Show("Book successfully deleted.", "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshGrid()
                Else
                    MessageBox.Show("Could not successfully delete book.", "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Please select a book to delete from the list.", "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Please select a book to update from the list.", "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLend_Click(sender As Object, e As EventArgs) Handles btnLend.Click
        ''
        Try
            If SelectedBook.BookNumber.Length >= 5 And SelectedBook.BookName.Length >= 1 Then
                frmAddBorrow.Show()
                Me.Hide()
            Else
                MessageBox.Show("Please select a book to lend from the list.", "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Please select a book to update from the list.", "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        ''
        Try
            If SelectedBook.BookNumber.Length >= 5 And SelectedBook.BookName.Length >= 1 Then
                frmAddReserves.Show()
                Me.Hide()
            Else
                MessageBox.Show("Please select a book to reserve from the list.", "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Please select a book to update from the list.", "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ''
        frmDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub lstBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBooks.SelectedIndexChanged
        ''
        SelectedBook.BookNumber = lstBooks.Items(lstBooks.FocusedItem.Index).SubItems(0).Text
        SelectedBook.BookName = lstBooks.Items(lstBooks.FocusedItem.Index).SubItems(1).Text
        SelectedBook.AuthorName = lstBooks.Items(lstBooks.FocusedItem.Index).SubItems(2).Text
        SelectedBook.BookQuantity = Integer.Parse(lstBooks.Items(lstBooks.FocusedItem.Index).SubItems(3).Text)
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
        'frmManageBooks.Show()
        'Me.Hide()
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