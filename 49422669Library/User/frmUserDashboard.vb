Public Class frmUserDashboard

    Private Sub frmUserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        '' show the borrow book form
        frmBorrow.Show()
        Me.Hide()
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        '' show the reserve book form
        frmReserve.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        '' logout and show the login form
        frmLogIn.Show()
        Me.Hide()
    End Sub
End Class
