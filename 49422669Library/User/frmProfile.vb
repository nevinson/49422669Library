Public Class frmProfile

    Private Sub frmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        If frmLogIn.MembershipNumber = Nothing Then
            frmLogIn.Show()
            Me.Hide()
        Else
            txtMembershipNumber.Text = frmLogIn.MembershipNumber
            txtLastName.Text = frmLogIn.LastName
            txtFirstName.Text = frmLogIn.FirstName
            txtMemberType.Text = frmLogIn.MembershipType
            txtStatus.Text = frmLogIn.Status
            txtUsername.Text = frmLogIn.UserName

            btnBack.Focus()
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
        If frmLogIn.MembershipNumber = Nothing Then
            frmLogIn.Show()
            Me.Hide()
        Else
            txtMembershipNumber.Text = frmLogIn.MembershipNumber
            txtLastName.Text = frmLogIn.LastName
            txtFirstName.Text = frmLogIn.FirstName
            txtMemberType.Text = frmLogIn.MembershipType
            txtStatus.Text = frmLogIn.Status
            txtUsername.Text = frmLogIn.UserName

            btnBack.Focus()
        End If
    End Sub

    Private Sub UserExit_Click(sender As Object, e As EventArgs) Handles UserExit.Click
        ''
        Constants.ExitProgram(True)
    End Sub

    Private Sub UserProfile_Click(sender As Object, e As EventArgs) Handles UserProfile.Click
        ''
        'frmProfile.Show()
        'Me.Hide()
    End Sub

    Private Sub UserMessages_Click(sender As Object, e As EventArgs) Handles UserMessages.Click
        ''
        frmManageMessage.Show()
        Me.Hide()
    End Sub

    Private Sub UserReserves_Click(sender As Object, e As EventArgs) Handles UserReserves.Click
        frmReserve.Show()
        Me.Show()
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