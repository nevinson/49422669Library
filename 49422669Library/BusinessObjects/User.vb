Public Class User
#Region "Propery Methods"
    Private intUserId As Integer
    Public Property UserId() As Integer
        Get
            Return intUserId
        End Get
        Set(ByVal value As Integer)
            intUserId = value
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

    Private strFirstName As String
    Public Property FirstName() As String
        Get
            Return strFirstName
        End Get
        Set(ByVal value As String)
            strFirstName = value
        End Set
    End Property

    Private strLastName As String
    Public Property LastName() As String
        Get
            Return strLastName
        End Get
        Set(ByVal value As String)
            strLastName = value
        End Set
    End Property

    Private strEmail As String
    Public Property Email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property

    Private strUsername As String
    Public Property Username() As String
        Get
            Return strUsername
        End Get
        Set(ByVal value As String)
            strUsername = value
        End Set
    End Property

    Private strPassword As String
    Public Property Password() As String
        Get
            Return strPassword
        End Get
        Set(ByVal value As String)
            strPassword = value
        End Set
    End Property

    Private strMembershipType As String
    Public Property MembershipType() As String
        Get
            Return strMembershipType
        End Get
        Set(ByVal value As String)
            strMembershipType = value
        End Set
    End Property

    Private strStatus As String
    Public Property Status() As String
        Get
            Return strStatus
        End Get
        Set(ByVal value As String)
            strStatus = value
        End Set
    End Property

    Private dteJoinDate As DateTime
    Public Property JoinDate() As DateTime
        Get
            Return dteJoinDate
        End Get
        Set(ByVal value As DateTime)
            dteJoinDate = value
        End Set
    End Property
#End Region
End Class
