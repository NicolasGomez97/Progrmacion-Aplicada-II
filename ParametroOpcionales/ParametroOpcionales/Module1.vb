Module Module1
    Sub Main()
        Dim Localidad As String
        Dim Importe As Integer
        Dim Resultado As Integer
        ' ---------------------
        Localidad = "Bell Ville"
        Importe = 15044
        Console.WriteLine("Pasando todos los parámetros")
        ' paso de todos los parámetros al procedimiento
        Resultado = Calcular(Localidad, Importe)
        Console.WriteLine("Primera llamada, valor devuelto: {0}", Resultado)
        Console.WriteLine()
        ' ---------------------
        Localidad = "Córdoba"
        ' paso sólo del primer parámetro al procedimiento,
        ' esto hará que se utilice el valor por defecto
        ' del parámetro opcional
        Console.WriteLine("Pasando sólo el parámetro Ciudad")
        Resultado = Calcular(Localidad)
        Console.WriteLine("Segunda llamada, valor devuelto: {0}", Resultado)
        Console.ReadLine()
    End Sub
    Function Calcular(ByVal Ciudad As String, Optional ByVal Cantidad As Integer = 5500) As Integer
        Console.WriteLine("Valores de los parámetros")
        Console.WriteLine("Ciudad: {0} - Cantidad: {1}", Ciudad, Cantidad)
        Return Cantidad + 100
    End Function
End Module
