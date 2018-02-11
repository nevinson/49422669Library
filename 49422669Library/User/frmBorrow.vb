Public Class frmBorrow
    ''
    Dim objBorrowService As New BorrowService
    Dim objBookService As New BookService

    Private Sub frmBorrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        txtMembershipNumber.Text = frmLogIn.MembershipNumber
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ''
        frmUserDashboard.Show()
        Me.Hide()
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

#Region "MenuStrip"
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ''
        frmLogIn.Show()
        Me.Hide()
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

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ''
        frmUserDashboard.Show()
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