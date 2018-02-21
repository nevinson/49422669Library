Public Class frmReserve
    ''
    Dim objReserveService As New ReserveService()

    Private Sub frmReserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        If frmUserDashboard.SelectedBook.BookNumber = Nothing Or frmLogIn.MembershipNumber = Nothing Then
            txtBookNumber.Text = Nothing
            txtMembershipNumber.Text = frmLogIn.MembershipNumber
        Else
            txtBookNumber.Text = frmUserDashboard.SelectedBook.BookNumber
            txtMembershipNumber.Text = frmLogIn.MembershipNumber
        End If
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

#Region "Menu Strip"
    Private Sub UserLogout_Click(sender As Object, e As EventArgs) Handles UserLogout.Click
        ''
        frmLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub UserRefreshPage_Click(sender As Object, e As EventArgs) Handles UserRefreshPage.Click
        ''
        If frmUserDashboard.SelectedBook.BookNumber = Nothing Or frmLogIn.MembershipNumber = Nothing Then
            txtBookNumber.Text = Nothing
        Else
            txtBookNumber.Text = frmUserDashboard.SelectedBook.BookNumber
            txtMembershipNumber.Text = frmLogIn.MembershipNumber
        End If

    End Sub

    Private Sub UserExit_Click(sender As Object, e As EventArgs) Handles UserExit.Click
        ''
        Constants.ExitProgram(True)
    End Sub

    Private Sub UserProfile_Click(sender As Object, e As EventArgs) Handles UserProfile.Click
        ''
        frmProfile.Show()
        Me.Hide()
    End Sub

    Private Sub UserMessages_Click(sender As Object, e As EventArgs) Handles UserMessages.Click
        ''
        frmManageMessage.Show()
        Me.Hide()
    End Sub

    Private Sub UserReserves_Click(sender As Object, e As EventArgs) Handles UserReserves.Click
        'frmReserve.Show()
        'Me.Show()
    End Sub

    Private Sub UserHowToUse_Click(sender As Object, e As EventArgs) Handles UserHowToUse.Click
        ''
        MessageBox.Show("Please refer to the user manual supplied with the product.", "How To Use", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UserAbout_Click(sender As Object, e As EventArgs) Handles UserAbout.Click
        ''
        MessageBox.Show("49422669 Library is a VB.Net project created for the UNISA Module ICT3714 Assessment Project.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
End Class