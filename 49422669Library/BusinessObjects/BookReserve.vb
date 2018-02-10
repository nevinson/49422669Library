Public Class BookReserve
#Region "Propery Methods"
    Private intReserveId As String
    Public Property ReserveId() As Integer
        Get
            Return intReserveId
        End Get
        Set(ByVal value As Integer)
            intReserveId = value
        End Set
    End Property

    Private dteReserveDate As DateTime
    Public Property ReserveDate() As DateTime
        Get
            Return dteReserveDate
        End Get
        Set(ByVal value As DateTime)
            dteReserveDate = value
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

    Private strBookNumber As String
    Public Property BookNumber() As String
        Get
            Return strBookNumber
        End Get
        Set(ByVal value As String)
            strBookNumber = value
        End Set
    End Property
#End Region
End Class
