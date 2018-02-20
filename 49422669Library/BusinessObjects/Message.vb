Public Class Message
    Private strMessageId As Integer
    Public Property MessageId() As Integer
        Get
            Return strMessageId
        End Get
        Set(ByVal value As Integer)
            strMessageId = value
        End Set
    End Property

    Private strSender As String
    Public Property Sender() As String
        Get
            Return strSender
        End Get
        Set(ByVal value As String)
            strSender = value
        End Set
    End Property

    Private strReciever As String
    Public Property Reciever() As String
        Get
            Return strReciever
        End Get
        Set(ByVal value As String)
            strReciever = value
        End Set
    End Property

    Private strContent As String
    Public Property Content() As String
        Get
            Return strContent
        End Get
        Set(ByVal value As String)
            strContent = value
        End Set
    End Property

    Private dteDateCreated As DateTime
    Public Property DateCreated() As DateTime
        Get
            Return dteDateCreated
        End Get
        Set(ByVal value As DateTime)
            dteDateCreated = value
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
End Class
