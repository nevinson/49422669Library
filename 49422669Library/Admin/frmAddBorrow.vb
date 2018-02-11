Public Class frmAddBorrow
    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        '' show the user dashboard form
        frmUserDashboard.Show()
        Me.Hide()
    End Sub

End Class