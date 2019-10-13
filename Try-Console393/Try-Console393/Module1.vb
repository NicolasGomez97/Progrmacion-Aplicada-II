Module Module1

    Sub Main()
        Dim sValor As String
        Dim iNumero As Integer
        Try
            'Comienza el control de errores
            Console.WriteLine("Introducir un número")
            sValor = Console.ReadLine()
            'Si no hemos introducido un numero..
            iNumero = CInt(sValor)   'aqui se producira un error

            '...y  no llegaremos a esta parte del codigo
            iNumero = iNumero + 1000
            Console.WriteLine("Resultado: {0}", iNumero)

        Catch ex As Exception
            'si se produce un error, se genera una excepción
            'que capturamos en este bloque de código
            'manipulador de excepción, definido por Catch
            Console.WriteLine("Error al introducir el número" & ControlChars.CrLf & "El valor {0} es incorrecto", sValor)
        Finally
            'si se produce un error, depuesés de Catch se ejecuta este bloque;
            'si no se produce error, después de Try tambien se ejecuta
            Console.WriteLine("El controlador de errores ha finalizado")
        End Try
        'Resto de código del procedimiento
        Dim dtFecha As Date
        Console.WriteLine("Introducir una fecha")
        'si ahora se produce un error, al no disponer de una estructura para controlarlo
        'se cancelará la ejecución
        dtFecha = CDate(Console.ReadLine())
        Console.WriteLine("La Fecha es {0}", dtFecha)
        Console.ReadLine()
    End Sub

End Module