Public Class Oficio
    Private _NumOficio As String = Nothing
    Private _FechaRecepcion As Date = Nothing
    Private _FechaOficio As Date = Nothing
    Private _IdOficio As Integer
    Private _IdRemitente As Integer
    Private _Remitente As String
    Private _IdDestinatario As Integer
    Private _Destinatario As String
    Private _Asunto As String = Nothing
    Private _Observaciones As String = Nothing
    Private _Pdf As Byte
    Private _Path As String = Nothing

    Property NumOficio As String
        Set(value As String)
            _NumOficio = value
        End Set
        Get
            Return _NumOficio
        End Get
    End Property
    Property FechaRecepcion As Date
        Set(value As Date)
            _FechaRecepcion = value
        End Set
        Get
            Return _FechaRecepcion 
        End Get
    End Property
    Property FechaOficio As Date
        Set(value As Date)
            _FechaOficio = value
        End Set
        Get
            Return _FechaOficio
        End Get
    End Property
    Property IdOficio As Integer
        Set(value As Integer)
            _IdOficio = value
        End Set
        Get
            Return _IdOficio
        End Get
    End Property
    Property IdRemitente As Integer
        Set(value As Integer)
            _IdRemitente = value
        End Set
        Get
            Return IdRemitente
        End Get
    End Property
    Property Remitente As String
        Set(value As String)
            _Remitente = value
        End Set
        Get
            Return _Remitente
        End Get
    End Property
    Property IdDestinatario As Integer
        Set(value As Integer)
            _IdDestinatario = value
        End Set
        Get
            Return _IdDestinatario
        End Get
    End Property
    Property Destinatario As String
        Set(value As String)
            _Destinatario = value
        End Set
        Get
            Return _Destinatario
        End Get
    End Property
    Property Asunto As String
        Set(value As String)
            _Asunto = value
        End Set
        Get
            Return _Asunto
        End Get
    End Property
    Property Observaciones As String
        Set(value As String)
            _Observaciones = value
        End Set
        Get
            Return _Observaciones
        End Get
    End Property
    Property Pdf As Byte
        Set(value As Byte)
            _Pdf = value
        End Set
        Get
            Return _Pdf
        End Get
    End Property
    Property Path As String
        Set(value As String)
            _Path = value
        End Set
        Get
            Return _Path
        End Get
    End Property


End Class
