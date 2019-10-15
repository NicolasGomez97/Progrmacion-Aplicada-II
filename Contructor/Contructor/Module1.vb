Module Module1

    Sub Main()
        Dim oEmp As Empleado
        oEmp = New Empleado()
        Console.WriteLine("El objeto se ha creado el dia {0}", oEmp.FechaCrea)
        Console.ReadLine()
    End Sub
End Module
