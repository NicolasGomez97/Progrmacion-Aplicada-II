Public Class Cliente
    Private _CodigoCliente As Integer
    Public Property CodigoCliente As Integer
        Get
            Return _CodigoCliente
        End Get
        Set(ByVal value As Integer)
            _CodigoCliente = value
        End Set
    End Property

    Private _Nombre As String
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Private _DNI As Integer
    Public Property DNI As Integer
        Get
            Return _DNI
        End Get
        Set(ByVal value As Integer)
            _DNI = value
        End Set
    End Property

    Private _PIN As Integer
    Public Property PIN As Integer
        Get
            Return _PIN
        End Get
        Set(ByVal value As Integer)
            _PIN = value
        End Set
    End Property

    Private _CuentaCorriente As CuentaCorriente
    Public Property CuentaCorriente As CuentaCorriente
        Get
            Return _CuentaCorriente
        End Get
        Set(ByVal value As CuentaCorriente)
            _CuentaCorriente = value
        End Set
    End Property

    Private _CajasDeAhorros As CajaDeAhorros
    Public Property CajasDeAhorros As CajaDeAhorros
        Get
            Return _CajasDeAhorros
        End Get
        Set(ByVal value As CajaDeAhorros)
            _CajasDeAhorros = value
        End Set
    End Property
    Public Sub New(ByVal codigo_ As Integer, ByVal nombre_ As String, ByVal dni_ As String, ByVal pin_ As Integer)
        _CodigoCliente = codigo_
        _Nombre = nombre_
        _DNI = dni_
        _PIN = pin_
        _CuentaCorriente = New CuentaCorriente() {New CuentaCorriente(32), New CuentaCorriente(42)}
    End Sub
    Public Sub CambiarPIN(ByVal nuevoPin As Integer)
        _PIN = nuevoPin
    End Sub

    Function ValidarCliente(ByVal dni As String, ByVal pin As Integer) As Boolean
        Throw New NotImplementedException
    End Function

End Class
