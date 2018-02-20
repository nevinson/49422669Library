Public Class frmManageBorrows
    ''
    Dim objBorrowService As New BorrowService
    Dim objBookService As New BookService
    Public Shared BorrowedBook As New BookBorrow

    Private Sub RefreshGrid()
        ''
        lstBorrows.Items.Clear()

        ''
        Dim borrowsTable As DataTable = objBorrowService.GetAll()

        ''
        For i = 0 To borrowsTable.Rows.Count - 1
            With lstBorrows
                .Items.Add(borrowsTable.Rows(i)("BorrowId"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(borrowsTable.Rows(i)("PickupDate"))
                    .Add(borrowsTable.Rows(i)("ReturnDate"))
                    .Add(borrowsTable.Rows(i)("BookNumber"))
                    .Add(borrowsTable.Rows(i)("BookName"))
                    .Add(borrowsTable.Rows(i)("AuthorName"))
                    .Add(borrowsTable.Rows(i)("MembershipNumber"))
                    .Add(borrowsTable.Rows(i)("FirstName"))
                    .Add(borrowsTable.Rows(i)("LastName"))
                End With
            End With
        Next
    End Sub

    Private Sub frmManageBorrows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        RefreshGrid()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ''
        If txtSearch.Text.Length > 5 Then
            ''
            lstBorrows.Items.Clear()

            ''
            Dim borrowsTable As DataTable = objBorrowService.GetByBookNumber("%" & txtSearch.Text & "%")

            ''
            If borrowsTable.Rows.Count > 0 Then
                ''
                For i = 0 To borrowsTable.Rows.Count - 1
                    With lstBorrows
                        .Items.Add(borrowsTable.Rows(i)("BorrowId"))
                        With .Items(.Items.Count - 1).SubItems
                            .Add(borrowsTable.Rows(i)("PickupDate"))
                            .Add(borrowsTable.Rows(i)("ReturnDate"))
                            .Add(borrowsTable.Rows(i)("BookNumber"))
                            .Add(borrowsTable.Rows(i)("BookName"))
                            .Add(borrowsTable.Rows(i)("AuthorName"))
                            .Add(borrowsTable.Rows(i)("MembershipNumber"))
                            .Add(borrowsTable.Rows(i)("FirstName"))
                            .Add(borrowsTable.Rows(i)("LastName"))
                        End With
                    End With
                Next
            Else
                MessageBox.Show("No record found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No record found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSearch.Clear()
            txtSearch.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btnLend_Click(sender As Object, e As EventArgs) Handles btnLend.Click
        ''
        frmAddBorrow.Show()
        Me.Hide()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ''
        Try
            If BorrowedBook.BookNumber = "" And BorrowedBook.MembershipNumber = "" Then
                ''
                MessageBox.Show("Please select an item from the list.", "Manage Borrow", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                ''
                If MessageBox.Show("Are you sure you want to return book #" & BorrowedBook.BookNumber, "Return Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If objBorrowService.Delete(BorrowedBook.BorrowId) = True Then
                        Dim _book As New Book
                        Dim bookTable As DataTable = objBookService.Search(BorrowedBook.BookNumber)

                        If bookTable.Rows.Count = 1 Then
                            _book.BookNumber = bookTable.Rows(0)("BookNumber")
                            _book.BookQuantity = Integer.Parse(bookTable.Rows(0)("BookQuantity").ToString()) + 1

                            If objBookService.UpdateQuantity(_book) Then
                                MessageBox.Show("Book reservation successfully returned.", "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                RefreshGrid()
                            Else
                                MessageBox.Show("Book reservation could not be marked as returned.", "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("Book reservation could not be marked as returned.", "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If

                    Else
                        MessageBox.Show("Book reservation could not be marked as returned.", "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lstBorrows_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBorrows.SelectedIndexChanged
        ''
        BorrowedBook.BorrowId = lstBorrows.Items(lstBorrows.FocusedItem.Index).SubItems(0).Text
        BorrowedBook.PickupDate = Convert.ToDateTime(lstBorrows.Items(lstBorrows.FocusedItem.Index).SubItems(1).Text)
        BorrowedBook.ReturnDate = Convert.ToDateTime(lstBorrows.Items(lstBorrows.FocusedItem.Index).SubItems(2).Text)
        BorrowedBook.BookNumber = lstBorrows.Items(lstBorrows.FocusedItem.Index).SubItems(3).Text
        BorrowedBook.MembershipNumber = lstBorrows.Items(lstBorrows.FocusedItem.Index).SubItems(6).Text
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
        'frmManageBorrows.Show()
        'Me.Hide()
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