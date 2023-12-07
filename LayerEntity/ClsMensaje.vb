Public Class ClsMensaje
#Region "CAMPOS"

    Private _Id As Integer
    Private _Mensaje As String
    Private _BtnPrincipal As String
    Private _BtnSecundario As String

#End Region

#Region "PROPIEDADES"
    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property
    Public Property Mensaje As String
        Get
            Return _Mensaje
        End Get
        Set(value As String)
            _Mensaje = value
        End Set
    End Property
    Public Property BtnPrincipal As String
        Get
            Return _BtnPrincipal
        End Get
        Set(value As String)
            _BtnPrincipal = value
        End Set
    End Property
    Public Property BtnSecundario As String
        Get
            Return _BtnSecundario
        End Get
        Set(value As String)
            _BtnSecundario = value
        End Set
    End Property
#End Region

#Region "CONSTRUCTOR"
    Public Sub New()

    End Sub

    Public Sub New(ByVal Id As Integer, ByVal Mensaje As String, ByVal BtnPrincipal As String, ByVal BtnSecundario As String)
        _Id = Id
        _Mensaje = Mensaje
        _BtnPrincipal = BtnPrincipal
        _BtnSecundario = BtnSecundario
    End Sub
#End Region



End Class
