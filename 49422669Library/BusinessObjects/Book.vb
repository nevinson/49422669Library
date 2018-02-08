Public Class Book
#Region "Propery Methods"
    Private intBookId As Integer
    Public Property BookId() As Integer
        Get
            Return intBookId
        End Get
        Set(ByVal value As Integer)
            intBookId = value
        End Set
    End Property

    Private strBookNumber As String
    Public Property BookNumber() As String
        Get
            Return strBookNumber
        End Get
        Set(ByVal value As String)
            strBookNumber = value
        End Set
    End Property

    Private strBookName As String
    Public Property BookName() As String
        Get
            Return strBookName
        End Get
        Set(ByVal value As String)
            strBookName = value
        End Set
    End Property

    Private strAuthorName As String
    Public Property AuthorName() As String
        Get
            Return strAuthorName
        End Get
        Set(ByVal value As String)
            strAuthorName = value
        End Set
    End Property

    Private strBookCategoryId As Integer
    Public Property BookCategoryId() As Integer
        Get
            Return strBookCategoryId
        End Get
        Set(ByVal value As Integer)
            strBookCategoryId = value
        End Set
    End Property

    Private intBookQuantity As Integer
    Public Property BookQuantity() As Integer
        Get
            Return intBookQuantity
        End Get
        Set(ByVal value As Integer)
            intBookQuantity = value
        End Set
    End Property

#End Region
End Class
