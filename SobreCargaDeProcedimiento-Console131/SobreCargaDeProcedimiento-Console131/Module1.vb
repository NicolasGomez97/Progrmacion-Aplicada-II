Module Module1

    Sub Main()
        ' mostrar datos del empleado
        ' en función del nombre
        VerDatosEmpleado("Pedro")
        ' mostrar datos del empleado
        ' en función de la edad
        VerDatosEmpleado(, 28)
        Console.ReadLine()
    End Sub
    Sub VerDatosEmpleado(Optional ByVal Nombre As String = "X", Optional ByVal Edad As Integer = 999)
        If Nombre <> "X" Then
            Console.WriteLine("Nombre del empleado: {0}", Nombre)
            Console.WriteLine("Domicilio: La Rioja 1450")
            Console.WriteLine("Localidad: Córdoba")
        End If
        If Edad <> 999 Then
            Console.WriteLine("Edad del empleado: {0}", Edad)
            Console.WriteLine("DNI:21555666")
            Console.WriteLine("Fecha de alta en la empresa: 10/4/1997")
        End If
        Console.WriteLine()
    End Sub

End Module
