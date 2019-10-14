Module Module1

    Sub Main()
        Dim sValor As String
        Dim iNumero As Integer
        Try
            'comienzo el control de errores
            Console.WriteLine("Introducir un número")
            sValor = Console.ReadLine()
            'si no hemos introducido un numero...
            iNumero = CInt(sValor)

            '....y no llegaremos a esta parte del código
            iNumero = iNumero + 1000
            Console.WriteLine("Resultado : {0}", iNumero)

            'Catch
            '       ' Si se produce un error, se genera una excepción
            '       'que capturamos en este bloque de código
            '       'manipulador de excepción, definido por Catch
            '       Console.WriteLine("Error al introducir el numero" & ControlChars.CrLf & "El valor {0} es incorrecto", sValor)

        Catch oExcep As Exception
            ' si se produce un error, se crea un obajeto excepción
            'que capturamos volvándolo a un dentificador
            'de tipo Exception
            Console.WriteLine("Se produjo un error. Información de la excepcion")
            Console.WriteLine("================================================")
            Console.WriteLine("Message {0}", oExcep.Message)
            Console.WriteLine()
            Console.WriteLine("Source: {0}", oExcep.Source)
            Console.WriteLine()
            Console.WriteLine("oExcep: {0}", oExcep.ToString())

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
