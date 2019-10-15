Module Module1

    Sub Main()
        Dim oEmp As Empleado
        oEmp = New Empleado(CDate("05/06/2013 05:14:00"))
        Console.WriteLine("EL OBJETO SE HA CREADO EL DIA {0}", oEmp.FechaCrea)
        Console.ReadLine()
    End Sub
End Module
