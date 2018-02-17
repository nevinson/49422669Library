Public Class frmManageReserves
    ''
    Dim objReserveService As New ReserveService
    Public Shared ReservedBook As New BookReserve

    Private Sub RefreshGrid()
        ''
        lstReserves.Items.Clear()

        ''
        Dim borrowsTable As DataTable = objReserveService.GetAll()

        ''
        For i = 0 To borrowsTable.Rows.Count - 1
            With lstReserves
                .Items.Add(borrowsTable.Rows(i)("ReserveId"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(borrowsTable.Rows(i)("ReserveDate"))
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

    Private Sub frmManageReserves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        RefreshGrid()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ''
        If txtSearch.Text.Length > 5 Then
            ''
            lstReserves.Items.Clear()

            ''
            Dim borrowsTable As DataTable = objReserveService.GetByBookNumber("%" & txtSearch.Text & "%")

            ''
            If borrowsTable.Rows.Count > 0 Then
                ''
                For i = 0 To borrowsTable.Rows.Count - 1
                    With lstReserves
                        .Items.Add(borrowsTable.Rows(i)("ReserveId"))
                        With .Items(.Items.Count - 1).SubItems
                            .Add(borrowsTable.Rows(i)("ReserveDate"))
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

    Private Sub btnAddReserve_Click(sender As Object, e As EventArgs) Handles btnAddReserve.Click
        ''
        frmAddReserves.Show()
        Me.Hide()
    End Sub

    Private Sub btnDeleteReserve_Click(sender As Object, e As EventArgs) Handles btnDeleteReserve.Click
        ''
        Try
            If ReservedBook.BookNumber = "" And ReservedBook.MembershipNumber = "" Then
                MessageBox.Show("Please select an item from the list.", "Manage Reserves", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If MessageBox.Show("Are you sure you want to delete book #" & ReservedBook.BookNumber, "Delete Reserve", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If objReserveService.Delete(ReservedBook.ReserveId) = True Then
                        MessageBox.Show("Book reservation successfully deleted.", "Delete Reserve", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        RefreshGrid()
                    Else
                        MessageBox.Show("Book reservation could not be deleted.", "Delete Reserve", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Please select an item from the list.", "Manage Reserves", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ''
        frmDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub lstReserves_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstReserves.SelectedIndexChanged
        ''
        ReservedBook.ReserveId = lstReserves.Items(lstReserves.FocusedItem.Index).SubItems(0).Text
        ReservedBook.ReserveDate = Convert.ToDateTime(lstReserves.Items(lstReserves.FocusedItem.Index).SubItems(1).Text)
        ReservedBook.BookNumber = lstReserves.Items(lstReserves.FocusedItem.Index).SubItems(2).Text
        ReservedBook.MembershipNumber = lstReserves.Items(lstReserves.FocusedItem.Index).SubItems(3).Text
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