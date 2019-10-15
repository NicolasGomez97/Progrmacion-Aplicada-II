Module Module1

    Sub Main()
        Dim oEmp As Empleado
        oEmp = New Empleado()
        Console.WriteLine("El objeto se ha creado el dia {0}", oEmp.FechaCrea)
        Console.ReadLine()
        'este es otro modo de instanciar
        'un objeto con un constructor sobrecargado y parametrizado
        Dim oEmp2 As New Empleado("Juan", "Perez", "Bell Ville", CDate("04/04/1999"))
        Console.WriteLine("Nombre: {0}" & ControlChars.CrLf & oEmp2.Apellidos, oEmp2.Ciudad, FormatDateTime(oEmp2.FechaIngreso, DateFormat.ShortDate))
        Console.ReadLine()
    End Sub

End Module
