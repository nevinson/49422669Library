Public Class BookBorrow
#Region "Propery Methods"
    Private intBorrowId As String
    Public Property BorrowId() As Integer
        Get
            Return intBorrowId
        End Get
        Set(ByVal value As Integer)
            intBorrowId = value
        End Set
    End Property

    Private dtePickupDate As DateTime
    Public Property PickupDate() As DateTime
        Get
            Return dtePickupDate
        End Get
        Set(ByVal value As DateTime)
            dtePickupDate = value
        End Set
    End Property

    Private dteReturnDate As DateTime
    Public Property ReturnDate() As DateTime
        Get
            Return dteReturnDate
        End Get
        Set(ByVal value As DateTime)
            dteReturnDate = value
        End Set
    End Property

    Private strMembershipNumber As String
    Public Property MembershipNumber() As String
        Get
            Return strMembershipNumber
        End Get
        Set(ByVal value As String)
            strMembershipNumber = value
        End Set
    End Property
#End Region
End Class
