Public Class frmLogIn
    ''
    Dim objUserService As New UserService()
    Public Shared MembershipNumber As String
    Public Shared Email As String
    Public Shared UserName As String
    Public Shared FirstName As String
    Public Shared LastName As String
    Public Shared MembershipType As String
    Public Shared Status As String

    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        '' 
        Constants.ExitProgram(True)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ''
        Dim dbTable As DataTable = objUserService.Authenticate(txtUsername.Text, txtPassword.Text)

        ''
        If dbTable.Rows.Count = 1 Then
            MembershipNumber = dbTable(0)("MembershipNumber").ToString()
            Email = dbTable(0)("Email").ToString()
            UserName = dbTable(0)("Username").ToString()
            FirstName = dbTable(0)("FirstName").ToString()
            LastName = dbTable(0)("LastName").ToString()
            MembershipType = dbTable(0)("MembershipType").ToString()
            Status = dbTable(0)("Status").ToString()

            Select Case Status
                Case "Active"
                    If MembershipType = "Admin" Then
                        frmDashboard.Show()
                        Me.Hide()
                    ElseIf MembershipType = "Member" Then
                        frmUserDashboard.Show()
                        Me.Hide()
                    End If
                Case "InActive"
                    MessageBox.Show("Your account has been deactivated. Visit the library to solve this issue.", "Account DeActivated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Case "Blacklisted"
                    MessageBox.Show("You have been blacklisted. Visit the library to solve this issue.", "Account Blacklisted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Case "Banned"

            End Select
        Else
            MessageBox.Show("Username or password is incorrect.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub Showing_CheckedChanged(sender As Object, e As EventArgs) Handles Showing.CheckedChanged

    End Sub
End Class