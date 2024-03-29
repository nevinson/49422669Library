﻿Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Public Class UserService
    ''
    Dim sql As String = Nothing
    Dim blResult As Boolean = False
    Dim objConstants As New Constants()

    Public Function GetAll() As DataTable
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        Dim dbTable As New DataTable()
        sql = "GetAllUsers"

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbTable.Load(dbCmd.ExecuteReader())

        ''
        Return dbTable
    End Function

    Friend Function GetByMembershipNumber(text As String) As DataTable
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        Dim dbTable As New DataTable()
        sql = "GetUsersByMembershipNumber"

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@membershipNumber", text)

        ''
        dbTable.Load(dbCmd.ExecuteReader())

        ''
        Return dbTable
    End Function

    Public Function Search(ByVal strSearchString As String) As DataTable
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        Dim dbTable As New DataTable()
        sql = "SearchUser"

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@searchString", strSearchString)

        ''
        dbTable.Load(dbCmd.ExecuteReader())

        ''
        Return dbTable
    End Function

    Public Function Authenticate(ByVal strUsername As String, ByVal strPassword As String) As DataTable
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        Dim dbTable As New DataTable()
        Dim strPwd As String = HashPassword(strPassword)
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
        dbCmd.Parameters.AddWithValue("@email", strUsername)
        dbCmd.Parameters.AddWithValue("@username", strUsername)
        dbCmd.Parameters.AddWithValue("@password", strPwd)

        ''
        dbTable.Load(dbCmd.ExecuteReader())

        ''
        Return dbTable
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
        dbCmd.Parameters.AddWithValue("@email", newUser.Email)
        dbCmd.Parameters.AddWithValue("@username", newUser.Username)
        dbCmd.Parameters.AddWithValue("@membershipNumber", newUser.MembershipNumber)

        If dbCmd.ExecuteNonQuery() = 1 Then
            blResult = True
        Else
            blResult = False
        End If

        Return blResult
    End Function

    Public Function UpdateStatus(ByVal strMembershipNumber As String, ByVal strStatus As String)
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "UpdateUserStatus"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@status", strStatus)
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

    Public Function GenerateMembershipNumber() As String
        ''
        Dim strMembershipNumber As String = Nothing

        ''
        Dim _stringBuilder As New StringBuilder()
        Dim _random As New Random()
        Dim _char As Char
        Dim i As Integer

        ''
        For i = 0 To 1
            _char = Convert.ToChar(Convert.ToInt32((26 * _random.NextDouble() + 65)))
            _stringBuilder.Append(_char)
        Next

        ''
        strMembershipNumber = _stringBuilder.ToString().ToUpper() & DateTime.Now.ToString("yy") & RandomNumber() & RandomNumber()

        ''
        Return strMembershipNumber
    End Function

    Private Function RandomNumber() As String
        ''
        Randomize()

        ''
        Dim intRandom As Integer = 0
        Dim strRandom As String = Nothing

        ''
        intRandom = CInt((999 * Rnd()) + 1)

        ''
        If intRandom.ToString().Length = 1 Then
            strRandom = String.Format("00{0}", intRandom.ToString())
        ElseIf intRandom.ToString().Length = 2 Then
            strRandom = String.Format("0{0}", intRandom.ToString())
        ElseIf intRandom.ToString().Length = 3 Then
            strRandom = intRandom.ToString()
        End If

        Return strRandom
    End Function
End Class

'' LibraryAdminPwd18
'' 744822332676293d4256c47c82a018be md5 hash