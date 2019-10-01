Module Module1
    Sub Main()
        Dim Valor As Integer
        Dim Ciudad As String
        Dim Nombre As String
        Valor = 7954
        Ciudad = "San Luis"
        Nombre = "Jorge"
        ' en la llamada al procedimiento Prueba()
        ' todos los valores que pasemos a continuación
        ' del primer parámetro, serán depositados
        ' en el array de parámetros
        Prueba(Valor, Ciudad, "mesa", Nombre)
        Console.ReadLine()
    End Sub
    ' el parámetro MasDatos del procedimiento es un array
    ' de parámetros variables
    Sub Prueba(ByVal Importe As Integer, ByVal ParamArray MasDatos() As String)
        Dim Contador As Integer
        ' mostrar el primer parámetro
        Console.WriteLine("Parámetro Importe: {0}", Importe)
        Console.WriteLine()
        ' el resto de parámetros del procedimiento
        ' están en el array, los obtenemos recorriendolo
        ' con(una) estructura For...Next
        Console.WriteLine("Contenido del array de parámetros MasDatos():")
        For Contador = 0 To UBound(MasDatos)
            Console.WriteLine("Elemento: {0} - Valor: {1}", _
            Contador, MasDatos(Contador))
        Next
    End Sub
End Module