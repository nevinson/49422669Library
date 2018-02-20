Public Class frmUserDashboard
    ''
    Dim objBookService As New BookService()
    Dim objReservesService As New ReserveService()
    Dim objBorrowService As New BorrowService()
    Dim objMessageService As New MessageService()
    Public Shared SelectedBook As New Book

    Private Sub frmUserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmLogIn.MembershipNumber = Nothing Then
            frmLogIn.Show()
            Me.Hide()
        Else
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

            ''
            lblBooksDue.Text = objBorrowService.GetByMembershipNumber(frmLogIn.MembershipNumber).Rows.Count.ToString()
            lblBooksReserved.Text = objReservesService.GetByMembershipNumber(frmLogIn.MembershipNumber).Rows.Count.ToString()
            lblMessages.Text = objMessageService.GetUnreadByMembershipNumber(frmLogIn.MembershipNumber).Rows.Count.ToString()
        End If
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

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        ''
        Try
            If SelectedBook.BookNumber.Length >= 5 And SelectedBook.BookName.Length >= 1 Then
                frmReserve.Show()
                Me.Hide()
            Else
                MessageBox.Show("Please select a book to reserve from the list.", "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Please select a book to update from the list.", "Manage Books", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        '' logout and show the login form
        frmLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub lstBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBooks.SelectedIndexChanged
        ''
        SelectedBook.BookNumber = lstBooks.Items(lstBooks.FocusedItem.Index).SubItems(0).Text
        SelectedBook.BookName = lstBooks.Items(lstBooks.FocusedItem.Index).SubItems(1).Text
        SelectedBook.AuthorName = lstBooks.Items(lstBooks.FocusedItem.Index).SubItems(2).Text
        SelectedBook.BookQuantity = Integer.Parse(lstBooks.Items(lstBooks.FocusedItem.Index).SubItems(3).Text)
    End Sub

#Region "MenuStrip"
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ''
        frmLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub RefreshPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshPageToolStripMenuItem.Click
        ''

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ''
        Constants.ExitProgram(True)
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        ''
        frmProfile.Show()
        Me.Hide()
    End Sub

    Private Sub ReserveBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReserveBookToolStripMenuItem.Click
        ''
        frmReserve.Show()
        Me.Hide()
    End Sub

    Private Sub BorrowBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowBookToolStripMenuItem.Click
        ''
        frmBorrow.Show()
        Me.Hide()
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click

    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToUseToolStripMenuItem.Click
        ''
        MessageBox.Show("Please refer to the user manual supplied with the product.", "How To Use", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ''
        MessageBox.Show("49422669 Library is a VB.Net project created for the UNISA Module ICT3714 Assessment Project.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MessagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessagesToolStripMenuItem.Click
        ''
        frmManageMessage.Show()
        Me.Hide()
    End Sub
#End Region
End Class
