Public Class frmManageBorrows
    ''
    Dim objBorrowService As New BorrowService
    Public Shared BorrowedBook As New BookBorrow

    Private Sub frmManageBorrows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ''
        If txtSearch.Text.Length > 5 Then
            ''
            lstBorrows.Items.Clear()

            ''
            Dim borrowsTable As DataTable = objBorrowService.GetByBookNumber(txtSearch.Text)

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
            BorrowedBook.BorrowId = lstBorrows.Items(lstBorrows.FocusedItem.Index).SubItems(0).Text
            BorrowedBook.PickupDate = lstBorrows.Items(lstBorrows.FocusedItem.Index).SubItems(0).Text
            BorrowedBook.ReturnDate = lstBorrows.Items(lstBorrows.FocusedItem.Index).SubItems(0).Text
            BorrowedBook.BookNumber = lstBorrows.Items(lstBorrows.FocusedItem.Index).SubItems(0).Text
            BorrowedBook.MembershipNumber = lstBorrows.Items(lstBorrows.FocusedItem.Index).SubItems(0).Text
        Catch ex As Exception
            MessageBox.Show("Please select an item from the list.", "Manage Borrow", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ''
        frmDashboard.Show()
        Me.Hide()
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
        frmAddBook.Show()
        Me.Hide()
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