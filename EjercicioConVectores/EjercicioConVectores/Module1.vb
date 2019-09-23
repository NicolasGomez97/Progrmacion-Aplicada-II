Module Module1

    Sub Main()
        'Utilizando metodo de la burbuja'
        Dim vec(9), aux As Integer
        Console.WriteLine("Cargar del Vector")
        For i = 0 To UBound(vec)
            Console.Write("Ingrese en el elemento {0} un numero:", i)
            vec(i) = CInt(Console.ReadLine)
        Next
        'ordenando utilizando un metodo de busqueda'
        For i = 0 To 8
            For j = 0 To 8 - i
                If vec(j) > vec(j + 1) Then
                    aux = vec(j)
                    vec(j) = vec(j + 1)
                    vec(j + 1) = aux
                End If
            Next
        Next
        Console.WriteLine()
        Console.WriteLine("Mostrar Vector")
        Console.WriteLine()
        For i = 0 To 9
            Console.WriteLine("Elemento {0} valor:{1}", i, vec(i))
        Next
        Console.ReadLine()
    End Sub

End Module
