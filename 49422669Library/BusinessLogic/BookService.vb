Imports System.Data.OleDb

Public Class BookService
    ''
    Dim sql As String = Nothing
    Dim blResult As Boolean = False
    Dim objConstants As New Constants()

    Public Function GetAll() As DataTable
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        Dim dbTable As New DataTable()
        sql = "GetAllBooks"
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
        sql = "GetBookByBookNumber"
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

    Public Function Create(ByVal _book As Book) As Boolean
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "CreateBook"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@bookNumber", _book.BookNumber)
        dbCmd.Parameters.AddWithValue("@bookname", _book.BookName)
        dbCmd.Parameters.AddWithValue("@authorName", _book.AuthorName)
        dbCmd.Parameters.AddWithValue("@bookCategoryId", _book.BookCategoryId)
        dbCmd.Parameters.AddWithValue("@bookQuantity", _book.BookQuantity)

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

    Public Function Update(ByVal _book As Book)
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "UpdateBook"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@bookNumber", _book.BookNumber)
        dbCmd.Parameters.AddWithValue("@bookname", _book.BookName)
        dbCmd.Parameters.AddWithValue("@authorName", _book.AuthorName)
        dbCmd.Parameters.AddWithValue("@bookCategoryId", _book.BookCategoryId)
        dbCmd.Parameters.AddWithValue("@bookQuantity", _book.BookQuantity)

        If dbCmd.ExecuteNonQuery() = 1 Then
            blResult = True
        Else
            blResult = False
        End If

        Return blResult
    End Function

    Public Function Delete(ByVal strBookNumber As String)
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "DeleteBook"
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


        If dbCmd.ExecuteNonQuery() = 1 Then
            blResult = True
        Else
            blResult = False
        End If

        Return blResult
    End Function

    Public Function UpdateQuantity(ByVal _book As Book)
        ''
        Dim dbCon As New OleDbConnection()
        Dim dbCmd As New OleDbCommand()
        sql = "UpdateBookQuantity"
        blResult = False

        ''
        dbCon.ConnectionString = objConstants.ConnectionString()
        dbCon.Open()

        ''
        dbCmd.Connection = dbCon
        dbCmd.CommandText = sql
        dbCmd.CommandType = CommandType.StoredProcedure

        ''
        dbCmd.Parameters.AddWithValue("@bookQuantity", _book.BookQuantity)
        dbCmd.Parameters.AddWithValue("@bookNumber", _book.BookNumber)

        If dbCmd.ExecuteNonQuery() = 1 Then
            blResult = True
        Else
            blResult = False
        End If

        Return blResult
    End Function
End Class
