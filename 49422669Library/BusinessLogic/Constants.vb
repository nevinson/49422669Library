Public Class Constants

    Public Function ConnectionString() As String
        ''
        Return "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "/Data/49422669Library.accdb"
    End Function

    Public Shared Sub ExitProgram(ByRef exitProgram As String)
        ''A messagebox will be displayed, before the program closes
        exitProgram = CStr(MessageBox.Show("Are you sure you want to terminate the program?", "Terminate Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question))

        If CDbl(exitProgram) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
