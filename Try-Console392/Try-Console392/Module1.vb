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
        End Try
        'Resto de código del procedimiento
        '......
        Console.ReadLine()
    End Sub

End Module
