Public Class Alquiler

    Private _Cliente_Nro As Integer
    Public Property Cliente_Nro() As Integer
        Get
            Return _Cliente_Nro
        End Get
        Set(ByVal value As Integer)
            _Cliente_Nro = value
        End Set
    End Property


    Private _Producto As String
    Public Property Producto() As String
        Get
            Return _Producto
        End Get
        Set(ByVal value As String)
            ErrorString(value, "Producto")
            _Producto = value
        End Set
    End Property

    Private _Codigo_Producto As Integer
    Public Property Codigo_Producto() As Integer
        Get
            Return _Codigo_Producto
        End Get
        Set(ByVal value As Integer)
            _Codigo_Producto = value
        End Set

    End Property


    Private _Fecha_Alquiler As Date
    Public Property Fecha_Alquiler() As Date
        Get
            Return _Fecha_Alquiler
        End Get
        Set(ByVal value As Date)
            _Fecha_Alquiler = value
        End Set
    End Property

    Private _Fecha_Devolucion As Date
    Public Property Fecha_Devolucion() As Date
        Get
            Return _Fecha_Devolucion
        End Get
        Set(ByVal value As Date)
            _Fecha_Devolucion = value
        End Set
    End Property


    Private _Importe As Double
    Public Property Importe() As Double
        Get
            Return _Importe
        End Get
        Set(ByVal value As Double)
            _Importe = value
        End Set
    End Property
    Private Sub ErrorString(ByVal pvalue As String, ByVal pquien As String)
        If pvalue.Length = 0 Or Trim(pvalue) = "" Then
            Throw New Exception("Campo " & pquien & " vacio")
        End If
    End Sub
    Public Sub New()

    End Sub
    Public Sub New(ByVal pCliente_Nro As Integer, ByVal pProducto As String, ByVal pCodigo_Producto As Integer, ByVal pFecha_Alquiler As Date, ByVal pFecha_Devolucion As Date, ByVal pImporte As Double)

        Cliente_Nro = pCliente_Nro
        Producto = pProducto
        Codigo_Producto = pCodigo_Producto
        Fecha_Alquiler = pFecha_Alquiler
        Fecha_Devolucion = pFecha_Devolucion
        Importe = pImporte

    End Sub
End Class
