Public Class frmLoading
    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''start the loading timer
        loadingTimer.Start()
    End Sub

    Private Sub loadingTimer_Tick(sender As Object, e As EventArgs) Handles loadingTimer.Tick
        ''
        loadingProgressBar.Visible = True
        loadingProgressBar.Value = loadingProgressBar.Value + 2

        Select Case (loadingProgressBar.Value)
            Case 10
                loadingStatusLabel.Text = "Reading modules..."
            Case 20
                loadingStatusLabel.Text = "Loading modules..."
            Case 40
                loadingStatusLabel.Text = "Starting modules..."
            Case 60
                loadingStatusLabel.Text = "Checking database..."
            Case 80
                loadingStatusLabel.Text = "Finalising..."
            Case 90
                loadingStatusLabel.Text = "Modules running..."
            Case 100
                loadingTimer.Enabled = False
                frmHome.Show()
                Me.Hide()
            Case Else

        End Select
    End Sub
End Class