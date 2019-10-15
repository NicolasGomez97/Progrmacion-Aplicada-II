Public Class CuentaCorriente
    Inherits CuentaBancaria
    Private _LimiteEnDescubierto As Double
    Public Property LimiteEnDescubierto() As Double
        Get
            Return _LimiteEnDescubierto
        End Get
        Set(ByVal value As Double)
            _LimiteEnDescubierto = value
        End Set
    End Property
    Public Sub New(ByVal saldoInicial As Double)
        MyBase.New(saldoInicial)
        _LimiteEnDescubierto = 1500
    End Sub
    Public Sub New(ByVal numeroDeCuenta As Integer, ByVal saldoInicial As Double)
        MyBase.New(numeroDeCuenta, saldoInicial)
        _LimiteEnDescubierto = 1500
    End Sub
    Public Overrides Sub ExtraerDinero(ByVal monto As Double)
        If monto > (Saldo + _LimiteEnDescubierto) Then
            Throw New Exception("El monto solicitado supera el Límite Descubierto que posee()")
        End If
        _saldo = Saldo - monto
    End Sub
End Class
