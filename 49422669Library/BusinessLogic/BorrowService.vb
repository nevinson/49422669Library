Imports System.Data.OleDb

Public Class BorrowService
    ''
    Dim sql As String = Nothing
    Dim blResult As Boolean = False
    Dim objConstants As New Constants()

    Public Function GetAll() As DataTable
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        Dim dbTable As New DataTable()
        sql = "GetAllBorrows"
        blResult = False

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

    Public Function GetByBookNumber(ByVal strBookNumber As String) As DataTable
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        Dim dbTable As New DataTable()
        sql = "GetBorrowByBookNumber"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@bookNumber", strBookNumber)

        ''
        dbTable.Load(dbCmd.ExecuteReader())

        ''
        Return dbTable
    End Function

    Public Function GetByMembershipNumber(ByVal strMembershipNumber As String) As DataTable
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        Dim dbTable As New DataTable()
        sql = "GetBorrowByMembershipNumber"
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

        ''
        dbTable.Load(dbCmd.ExecuteReader())

        ''
        Return dbTable
    End Function

    Public Function Create(ByVal _bookBorrow As BookBorrow) As Boolean
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "CreateBookBorrow"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@pickupDate", _bookBorrow.PickupDate)
        dbCmd.Parameters.AddWithValue("@returnDate", _bookBorrow.ReturnDate)
        dbCmd.Parameters.AddWithValue("@membershipNumber", _bookBorrow.MembershipNumber)
        dbCmd.Parameters.AddWithValue("@bookNumber", _bookBorrow.BookNumber)

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

    Public Function Update(ByVal _bookBorrow As BookBorrow)
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "UpdateBookBorrow"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@pickupDate", _bookBorrow.PickupDate)
        dbCmd.Parameters.AddWithValue("@returnDate", _bookBorrow.ReturnDate)
        dbCmd.Parameters.AddWithValue("@membershipNumber", _bookBorrow.MembershipNumber)
        dbCmd.Parameters.AddWithValue("@bookNumber", _bookBorrow.BookNumber)
        dbCmd.Parameters.AddWithValue("@borrowId", _bookBorrow.BorrowId)

        If dbCmd.ExecuteNonQuery() = 1 Then
            blResult = True
        Else
            blResult = False
        End If

        Return blResult
    End Function

    Public Function Delete(ByVal intBorrowId As Integer)
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "DeleteBookBorrow"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@borrowId", intBorrowId)

        If dbCmd.ExecuteNonQuery() = 1 Then
            blResult = True
        Else
            blResult = False
        End If

        Return blResult
    End Function

    Public Function GetOverdue(ByVal _bookBorrow As BookBorrow)
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "GetBorrowOverdue"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@bookNumber", _bookBorrow.ReturnDate)

        If dbCmd.ExecuteNonQuery() = 1 Then
            blResult = True
        Else
            blResult = False
        End If

        Return blResult
    End Function

    Public Function GetDueToday(ByVal dteReturnDate As DateTime)
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "GetBorrowDueToday"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@bookNumber", dteReturnDate)

        If dbCmd.ExecuteNonQuery() = 1 Then
            blResult = True
        Else
            blResult = False
        End If

        Return blResult
    End Function
End Class



'For i = 0 To lv.Rows.Count - 1
'With ListView
'.Items.Add(lv.Rows(i)("brw_id"))
'With .Items(.Items.Count - 1).SubItems
'.Add(lv.Rows(i)("contact_no"))
'.Add(lv.Rows(i)("brw_name"))
'.Add(lv.Rows(i)("bookid"))
'.Add(lv.Rows(i)("booktle"))
'.Add(lv.Rows(i)("author_name"))
'.Add(lv.Rows(i)("no_copies"))
'End With
'End With
'Next