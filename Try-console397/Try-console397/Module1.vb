Module Module1

    Sub Main()
        Dim byMiNum As Byte
        Dim dtFHActual As Date
        'obtner la fecha actual
        dtFHActual = System.DateTime.Today()

        Try
            'comienza el control de errores
            Console.WriteLine("Introducir un número")
            'si introducimos un número no incluido
            'en el rango de Byte...
            byMiNum = CByte(Console.ReadLine())
            Console.WriteLine("Número dentro del rango: {0}", byMiNum)

        Catch oExcep As OverflowException When (dtFHActual.Month = 3)
            '...saltará este manipulador de excepciones, pero sólo
            ' cuando las excepciones de desbordamiento
            'se produzcan en el mes de Marzo
            Console.WriteLine("El número introducido no es encuentra en el rango adecuando")
        Catch oExcep As OverflowException
            Console.WriteLine("Error de dosbordamiento")
        Finally
            Console.WriteLine("El controlador de errores ha finalizado")
        End Try
        Console.ReadLine()
    End Sub

End Module
