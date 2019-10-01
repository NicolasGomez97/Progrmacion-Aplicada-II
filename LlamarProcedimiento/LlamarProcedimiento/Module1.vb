Module Module1
    Sub Main()
        Dim Nombre As String
        Nombre = "Juan"
        ' llamamos a un procedimiento
        ' y le pasamos una variable por valor
        Prueba(Nombre)
        ' la variable que hemos pasado al procedimiento,
        ' al volver aquí no ha sido cambiada, debido a que
        ' ha sido pasada por valor, sigue conteniendo
        ' la cadena "Juan"
        Console.WriteLine("Valor de la variable dentro de Main(): {0}", Nombre)
        Console.ReadLine()
    End Sub
    Sub Prueba(ByVal ValorMostrar As String)
        ' modificamos el valor del parámetro,
        ' este cambio no afecta a la variable Nombre
        ValorMostrar = "Elena"
        Console.WriteLine("Valor del parámetro dentro de Prueba(): {0}",
       ValorMostrar)
    End Sub
End Module