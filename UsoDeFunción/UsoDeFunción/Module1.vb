Module Module1

    Sub Main()
        Dim Resultado As Integer
        Dim NuevoValor As Integer
        ' llamada a una función sin recoger el valor de retorno,
        ' por este motivo, dicho valor se pierde
        Calcular()
        ' llamada a una función obteniendo el valor
        ' de retorno y asignando el valor a una variable
        Resultado = Calcular()
        Console.WriteLine("La variable Resultado contiene: {0}", Resultado)
        ' llamada a una función como parte de una expresión
        NuevoValor = 1500 + Calcular() * 2
        Console.WriteLine("La variable NuevoValor contiene: {0}", NuevoValor)
        Console.ReadLine()
    End Sub
    Function Calcular() As Integer
        Dim MiValor As Integer
        Console.WriteLine("Introducir un número de 1 a 100")
        MiValor = CInt(Console.ReadLine())
        Return MiValor
        ' también podemos utilizar esta
        ' sintaxis para devolver el valor
        ' de retorno de la función:
        'Calcular = MiValor 
    End Function

End Module
