Public Class Producto
    Private _CODIGO_PRODUCTO As Integer
    Public Property CODIGO_PRODUCTO() As Integer
        Get
            Return _CODIGO_PRODUCTO
        End Get
        Set(ByVal value As Integer)
            If value.ToString.Length() <> 6 Then
                Throw New Exception("El codigo del producto tiene que tener 6 caracteres exactos")
            Else
                _CODIGO_PRODUCTO = value
            End If
        End Set
    End Property

    Private _DENOMINACION As String
    Public Property DENOMINACION() As String
        Get
            Return _DENOMINACION
        End Get
        Set(ByVal value As String)
            If value.Length = 0 Then
                Throw New Exception("Tiene que tener Descripcion, no puede estar vacio")
            Else
                _DENOMINACION = value
            End If
        End Set
    End Property

    Private _VALOR_CONTADO As Double
    Public Property VALOR_CONTADO() As Double
        Get
            Return _VALOR_CONTADO
        End Get
        Set(ByVal value As Double)
            If value.ToString.Length < 0 Then
                Throw New Exception("No puede ser negativo.")
            Else
                _VALOR_CONTADO = value
            End If
        End Set
    End Property

    Private _VALOR_CREDITO As Double
    Public Property VALOR_CREDITO() As Double
        Get
            Return _VALOR_CREDITO
        End Get
        Set(ByVal value As Double)
            If value.ToString.Length < 0 Then
                Throw New Exception("No puede ser negativo.")
            Else
                _VALOR_CREDITO = value
            End If
        End Set
    End Property
    Private _TIPO_VENTA As Integer
    Public Property TIPO_VENTA As Integer
        Get
            Return _TIPO_VENTA
        End Get
        Set(ByVal value As Integer)
            If value < 0 Or value > 3 Then
                Throw New Exception("Tiene que ser 1 o 2")
            Else
                Select Case value
                    Case 1
                        Console.WriteLine("1 - Contado")
                    Case 2
                        Console.WriteLine("2 - Credito")
                End Select
                _TIPO_VENTA = value
            End If
        End Set
    End Property

    Private _DESCUENTO As Double
    Public Property DESCUENTO As Double
        Get
            Return _DESCUENTO
        End Get
        Set(ByVal value As Double)
            If value < 0 Or value > 3 Then
                Throw New Exception("Esa opcion no esta disponible")
            Else
                If value = 0 Then
                    Console.WriteLine("Sin descuento")
                ElseIf value = 1 Then
                    value = 5
                    Console.WriteLine(" Descuento del 5%")
                ElseIf value = 2 Then
                    Console.WriteLine(" Descuento del 7%")
                    value = 7
                End If
                _DESCUENTO = value * 1
            End If
        End Set
    End Property
    Public Sub calculoydev(ByVal tipoventa As Integer, ByVal descuento As Double, ByVal contado As Double, ByVal credito As Double)
        Dim preciofinal As Double
        If tipoventa = 1 Then
            preciofinal = contado * descuento / 100
        Else
            preciofinal = credito * descuento / 100
        End If
        Console.WriteLine()
        Console.WriteLine()

        Console.WriteLine("Precio Final: {0}", preciofinal)
    End Sub

    Public Sub datossimple()
        Console.WriteLine()
        Console.WriteLine("El codigo de producto es: {0}", CODIGO_PRODUCTO)
        Console.WriteLine("La denominacion es: {0}", DENOMINACION)
        Console.WriteLine()
    End Sub
    Public Sub datoscompletos()
        Console.WriteLine()
        Console.WriteLine("El codigo de producto es: {0}", CODIGO_PRODUCTO)
        Console.WriteLine("La denominacion es: {0}", DENOMINACION)
        Console.WriteLine("El tipo de venta es: {0}", TIPO_VENTA)
        Console.WriteLine("El Descuento es: {0}", DESCUENTO)
        Console.WriteLine()
    End Sub
End Class
