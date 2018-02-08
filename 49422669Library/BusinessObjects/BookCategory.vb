Public Class BookCategory
#Region "Propery Methods"
    Private intCategoryId As Integer
    Public Property CategoryId() As Integer
        Get
            Return intCategoryId
        End Get
        Set(ByVal value As Integer)
            intCategoryId = value
        End Set
    End Property

    Private strCategoryName As String
    Public Property CategoryName() As String
        Get
            Return strCategoryName
        End Get
        Set(ByVal value As String)
            strCategoryName = value
        End Set
    End Property

    Private strDescription As String
    Public Property Description() As String
        Get
            Return strDescription
        End Get
        Set(ByVal value As String)
            strDescription = value
        End Set
    End Property

#End Region
End Class
