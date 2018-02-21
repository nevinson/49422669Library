Imports System.Data.OleDb
Imports _49422669Library

Public Class MessageService
    ''
    Dim sql As String = Nothing
    Dim blResult As Boolean = False
    Dim objConstants As New Constants()

    Public Function GetByMembershipNumber(ByVal strMembershipNumber As String) As DataTable
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        Dim dbTable As New DataTable()
        sql = "GetMessagesByMembershipNumber"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@membershipnumber", strMembershipNumber)

        ''
        dbTable.Load(dbCmd.ExecuteReader())

        ''
        Return dbTable
    End Function

    Public Function GetUnreadByMembershipNumber(ByVal strMembershipNumber As String) As DataTable
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        Dim dbTable As New DataTable()
        sql = "GetUnreadMessagesByMembershipNumber"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@membershipnumber", strMembershipNumber)

        ''
        dbTable.Load(dbCmd.ExecuteReader())

        ''
        Return dbTable
    End Function

    Friend Function Create(newMessage As Message) As Boolean
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "AddMessage"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@sender", newMessage.Sender)
        dbCmd.Parameters.AddWithValue("@receiver", newMessage.Reciever)
        dbCmd.Parameters.AddWithValue("@content", newMessage.Content)
        dbCmd.Parameters.AddWithValue("@dateCreated", newMessage.DateCreated)
        dbCmd.Parameters.AddWithValue("@status", "Unread")

        If dbCmd.ExecuteNonQuery() = 1 Then
            blResult = True
        Else
            blResult = False
        End If

        Return blResult
    End Function

    Public Function UpdateStatus(ByVal messageId As Integer)
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "UpdateMessageStatus"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@status", "Read")
        dbCmd.Parameters.AddWithValue("@messageId", messageId)

        If dbCmd.ExecuteNonQuery() = 1 Then
            blResult = True
        Else
            blResult = False
        End If

        Return blResult
    End Function

    Public Function Delete(ByVal messageId As Integer)
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "DeleteMessage"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@messageId", messageId)

        If dbCmd.ExecuteNonQuery() = 1 Then
            blResult = True
        Else
            blResult = False
        End If

        Return blResult
    End Function
End Class
