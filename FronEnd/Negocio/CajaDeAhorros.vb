Public Class CajaDeAhorros
    Inherits CuentaBancaria
    Private _TotalExtraido As Double
    Private _limiteExtraccion As Double
    Public Property LimiteExtraccion() As Double
        Get
            Return _limiteExtraccion
        End Get
        Set(ByVal value As Double)
            _limiteExtraccion = value
        End Set
    End Property
    Private _gastoPorExtraccion As Double
    Public Property GastoPorExtraccion() As Double
        Get
            Return _gastoPorExtraccion
        End Get
        Set(ByVal value As Double)
            _gastoPorExtraccion = value
        End Set
    End Property
    Public Sub New(ByVal saldoInicial As Double)
        MyBase.New(saldoInicial)
        _TotalExtraido = 0.0
        _limiteExtraccion = 1000
        _gastoPorExtraccion = 5
    End Sub
    Public Sub New(ByVal numeroDeCuenta As Integer, ByVal saldoInicial As Double)
        MyBase.New(numeroDeCuenta, saldoInicial)
        _TotalExtraido = 0.0
        _limiteExtraccion = 1000
        _gastoPorExtraccion = 5
    End Sub
    Public Overrides Sub ExtraerDinero(ByVal monto As Double)
        If (monto + _TotalExtraido) > _limiteExtraccion Then
            'If (monto + _gastoPorExtraccion) > _limiteExtraccion
            Throw New Exception("El monto solicitado supera el Límite de Extracción diario")
        End If
        MyBase.ExtraerDinero(monto - _gastoPorExtraccion)
    End Sub
End Class
