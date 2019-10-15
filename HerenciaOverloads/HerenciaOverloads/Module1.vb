Module Module1

    Sub Main()
        Dim loEmp As New Empleado
        With loEmp
            .psNombre = "Juan Carlos"
            .piSalario = 2000
            .CalcularIncentivos()
            .VerIncentivos()
        End With
        Console.ReadLine()

        Dim loAdmin As New Administrativo
        With loAdmin
            .psNombre = "María Inés"
            .piSalario = 5000
            loAdmin.CalcularIncentivos(10)
            .VerIncentivos()
        End With
    End Sub
End Module
