Module Module1

    Sub Main()
        ' mostrar datos del empleado según nombre
        VerEmpleNombre("Pedro")
        ' mostrar datos del empleado según edad
        VerEmpleNum(28)
        Console.ReadLine()
    End Sub
    Public Sub VerEmpleNombre(ByVal Nombre As String)
        Console.WriteLine("Datos empleado por nombre")
        Console.WriteLine("Nombre del empleado: {0}", Nombre)
        Console.WriteLine("Domicilio: La Rioja 1450")
        Console.WriteLine("Localidad: Córdoba")
        Console.WriteLine()
    End Sub
    Public Sub VerEmpleNum(ByVal Edad As Integer)
        Console.WriteLine("Datos empleado por edad")
        Console.WriteLine("Edad del empleado: {0}", Edad)
        Console.WriteLine("DNI:21555666")
        Console.WriteLine("Fecha de alta en la empresa: 10/4/1997")
        Console.WriteLine()
    End Sub

End Module
