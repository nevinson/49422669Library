Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Public Class UserService
    ''
    Dim sql As String = Nothing
    Dim blResult As Boolean = False
    Dim objConstants As New Constants()

    Public Function Login() As User
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        Dim dbTable As New DataTable()
        Dim loggedUser As New User
        sql = "UserLogin"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@email", "")
        dbCmd.Parameters.AddWithValue("@username", "")
        dbCmd.Parameters.AddWithValue("@password", "")

        ''
        dbTable.Load(dbCmd.ExecuteReader())

        ''
        If dbTable.Rows.Count = 1 Then
            loggedUser.MembershipNumber = dbTable(0)("").ToString()
            loggedUser.Email = dbTable(0)("").ToString()
            loggedUser.Username = dbTable(0)("").ToString()
            loggedUser.FirstName = dbTable(0)("").ToString()
            loggedUser.LastName = dbTable(0)("").ToString()
            loggedUser.MembershipType = dbTable(0)("").ToString()
            loggedUser.Status = dbTable(0)("").ToString()

            Return loggedUser
        Else
            MessageBox.Show("Username or password is incorrect.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End If
    End Function

    Public Function Create(ByVal newUser As User) As Boolean
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "CreateUser"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@membershipNumber", newUser.MembershipNumber)
        dbCmd.Parameters.AddWithValue("@firstName", newUser.FirstName)
        dbCmd.Parameters.AddWithValue("@lastName", newUser.LastName)
        dbCmd.Parameters.AddWithValue("@email", newUser.Email)
        dbCmd.Parameters.AddWithValue("@username", newUser.Username)
        dbCmd.Parameters.AddWithValue("@password", HashPassword(newUser.Password))
        dbCmd.Parameters.AddWithValue("@membershipType", newUser.MembershipType)
        dbCmd.Parameters.AddWithValue("@status", newUser.Status)
        dbCmd.Parameters.AddWithValue("@joinDate", newUser.JoinDate)

        Try
            If dbCmd.ExecuteNonQuery() = 1 Then
                blResult = True
            Else
                blResult = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Create User", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return blResult
    End Function

    Public Function Update(ByVal newUser As User)
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "UpdateUser"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@firstName", newUser.FirstName)
        dbCmd.Parameters.AddWithValue("@lastName", newUser.LastName)
        dbCmd.Parameters.AddWithValue("@email", newUser.Email)
        dbCmd.Parameters.AddWithValue("@username", newUser.Username)
        dbCmd.Parameters.AddWithValue("@password", HashPassword(newUser.Password))
        dbCmd.Parameters.AddWithValue("@membershipType", newUser.MembershipType)
        dbCmd.Parameters.AddWithValue("@status", newUser.Status)
        dbCmd.Parameters.AddWithValue("@joinDate", newUser.JoinDate)
        dbCmd.Parameters.AddWithValue("@membershipNumber", newUser.MembershipNumber)

        If dbCmd.ExecuteNonQuery() = 1 Then
            blResult = True
        Else
            blResult = False
        End If

        Return blResult
    End Function

    Public Function Delete(ByVal strMembershipNumber As String)
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "DeleteUser"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@membershipNumber", strMembershipNumber)


        If dbCmd.ExecuteNonQuery() = 1 Then
            blResult = True
        Else
            blResult = False
        End If

        Return blResult
    End Function

    Public Function Blacklist(ByVal strMembershipNumber As String) As Boolean
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "BlacklistUser"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@status", "Blacklisted")
        dbCmd.Parameters.AddWithValue("@membershipNumber", strMembershipNumber)

        If dbCmd.ExecuteNonQuery() = 1 Then
            blResult = True
        Else
            blResult = False
        End If

        Return blResult
    End Function

    Public Function ResetPassword(ByVal strMembershipNumber As String, ByVal strUsername As String, ByVal strPassword As String) As Boolean
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "ResetPassword"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@username", strUsername)
        dbCmd.Parameters.AddWithValue("@password", HashPassword(strPassword))
        dbCmd.Parameters.AddWithValue("@membershipNumber", strMembershipNumber)

        If dbCmd.ExecuteNonQuery() = 1 Then
            blResult = True
        Else
            blResult = False
        End If

        Return blResult
    End Function

    Public Function HashPassword(ByVal strPassword As String)
        ''
        Dim md5Service As New MD5CryptoServiceProvider()
        Dim byteString() As Byte = Encoding.ASCII.GetBytes(strPassword)

        byteString = md5Service.ComputeHash(byteString)

        Dim hashedPassword As String = Nothing

        For Each bt As Byte In byteString
            hashedPassword &= bt.ToString("x2")
        Next

        Return hashedPassword
    End Function
End Class

'' LibraryAdminPwd18
'' 744822332676293d4256c47c82a018be md5 hash