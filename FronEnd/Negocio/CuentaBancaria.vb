Public Class CuentaBancaria
    Private _numero As Integer
    Public Property Numero() As Integer
        Get
            Return _numero
        End Get
        Set(ByVal value As Integer)
            _numero = value
        End Set
    End Property
    Protected _saldo As Double
    Public ReadOnly Property Saldo() As Double
        Get
            Return _saldo
        End Get
    End Property
    Public Sub New(ByVal saldoInicial As Double)
        _saldo = saldoInicial
    End Sub
    Public Sub New(ByVal numeroCuenta As Integer, ByVal saldoInicial As Double)
        _saldo = saldoInicial
        _numero = numeroCuenta
    End Sub
    Public Sub DepositarDinero(ByVal monto As Double)
        _saldo = _saldo + monto
    End Sub
    Public Overridable Sub ExtraerDinero(ByVal monto As Double)
        If monto > Saldo Then
            Throw New Exception("No tiene suficiente saldo para extraer el monto deseado.")
        End If
        _saldo = Saldo - monto
    End Sub
End Class
