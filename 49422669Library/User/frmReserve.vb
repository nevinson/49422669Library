Public Class frmReserve
    ''
    Dim objReserveService As New ReserveService()

    Private Sub frmReserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        txtMembershipNumber.Text = frmLogIn.MembershipNumber
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        ''
        Dim newReserve As New BookReserve

        ''
        If txtMembershipNumber.Text.Length > 5 And txtBookNumber.Text.Length > 5 Then
            newReserve.BookNumber = txtBookNumber.Text
            newReserve.MembershipNumber = txtMembershipNumber.Text
            newReserve.ReserveDate = DateTime.Now.ToLongDateString()
            If objReserveService.Create(newReserve) Then
                MessageBox.Show("Book successfully reserved.", "Reserve Book", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Book could not be reserved.", "Reserve Book", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        '' show the user dashboard form
        frmUserDashboard.Show()
        Me.Hide()
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

    End Sub

    Private Sub BorrowBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowBookToolStripMenuItem.Click
        ''
        frmBorrow.Show()
        Me.Hide()
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