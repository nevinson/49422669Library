Public Class frmLogIn
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        '' terminate the application
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        '' show the index form
        frmUserDashboard.Show()
        Me.Hide()
    End Sub
End Class