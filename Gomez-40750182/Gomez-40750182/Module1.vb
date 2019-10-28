Module Module1

    Sub Main()
        Dim ocli As New Producto
        Dim opcion As Integer
        Dim salir As String = "S"
        Do
            Try
                Console.WriteLine("Ingrese el codigo producto:")
                ocli.CODIGO_PRODUCTO = CInt(Console.ReadLine())
                Console.WriteLine("Ingrese la descripcion:")
                ocli.DENOMINACION = (Console.ReadLine)
                Console.WriteLine("Ingrese el valor en contado:")
                ocli.VALOR_CONTADO = CDbl(Console.ReadLine())
                Console.WriteLine("Ingrese el valor en credito:")
                ocli.VALOR_CREDITO = CDbl(Console.ReadLine())
                Console.WriteLine("Elija la opcion:")
                Console.WriteLine("1 - Contado")
                Console.WriteLine("2 - Credito")
                ocli.TIPO_VENTA = CInt(Console.ReadLine())
                Console.WriteLine("Descuento:")
                Console.WriteLine("0 - No hay descuento")
                Console.WriteLine("1 - 5%")
                Console.WriteLine("2 - 7%")
                ocli.DESCUENTO = CInt(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Console.ReadLine()
            End Try
            Console.WriteLine()
            ocli.calculoydev(ocli.TIPO_VENTA, ocli.DESCUENTO, ocli.VALOR_CONTADO, ocli.VALOR_CREDITO)
            Console.WriteLine()
            Console.WriteLine("1 - Datos simples ")
            Console.Write("2 - Datos completos ")
            Console.WriteLine()

            Console.WriteLine("Ingrese el metodo de datos")
            opcion = CInt(Console.ReadLine())
            If opcion = 1 Then
                ocli.datossimple()
            Else
                ocli.datoscompletos()
                ocli.calculoydev(ocli.TIPO_VENTA, ocli.DESCUENTO, ocli.VALOR_CONTADO, ocli.VALOR_CREDITO)
            End If

            Console.WriteLine("Desea salir SI/NO")
            salir = Console.ReadLine().ToUpper
        Loop Until salir.ToUpper = "SI"
        Console.ReadLine()
    End Sub
End Module
'Catch ex As Exception
