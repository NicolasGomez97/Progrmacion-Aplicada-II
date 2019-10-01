Module Module1

    Sub Main()
        Dim Nombre As String
        Nombre = "Juan"
        Console.WriteLine("Valor de la variable antes de llamar a Prueba(): {0}", Nombre)
        'llamar a un procedimiento 
        'y le pasamos una variable por referencia
        Prueba(Nombre)
        'el cambio realizado al parámetro en el procedimiento
        'ha afectado a la variable Nombre, que aqui contiene
        'el mismo valor que se asignó en el procedimiento
        Console.WriteLine("Valor de la variable al volver a Main(): {0}", Nombre)
        Console.ReadLine()

    End Sub
    Sub Prueba(ByRef ValorMostrar As String)
        'modificamos el valor del parámetro
        ValorMostrar = "Elena"
        Console.WriteLine("Valor del parámetro dentro de Prueba(): {0}", ValorMostrar)
    End Sub

End Module
