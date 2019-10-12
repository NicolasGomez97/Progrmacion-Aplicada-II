Module Module1

    Sub Main()
        Dim mat(,), m, n, k As Integer

        'ingreso los valores de la fila y columna utilizado para ello la función igresar numeros'
        m = ingresarnumero("fila")
        n = ingresarnumero("columna")
        Console.WriteLine()

        'Redefino la matriz para poder utilizarla'
        ReDim mat(m, n)

        'Defino los vectores que se necesitarán
        Dim VecSumaFila(m), VecSumaColumna(n), VecMayorFila(n), VecMenColumna(n), VectorFilaK(n), VectorValorAb() As Integer
        Dim VecPromedioFila(m), VecPromedioColumna(n) As Double

        'ingreso el valor de la variable K
        k = IngresarValork(m)
        Console.WriteLine()
        'llamo al procedimiento para cargar los elementos de la matriz y paso como parámetro a la matriz 
        cargarmatriz(mat)

        'muetro matriz
        Console.WriteLine()
        Console.WriteLine("Valores cargaddos en la matriz")
        Console.WriteLine()
        mostrarmatriz(mat)
        Console.ReadLine()
        'llamamos el procedimiento que va sumar a cada fila de la matriz pasando como parámetro la matriz y el vector
        ' donde se guardarán los resultado
        SumaFila(mat, VecSumaFila)

        'llamo al procedimiento que me mostrara el vector
        MostraVector(VecSumaFila, "La posición del mayor", "fila")

        'llamo al procedimiento que me mostrara el vector'
        SumaColumna(mat, VecSumaColumna)

        'llamo a la procedimiento que me mostrará el vector
        MostraVector(VecSumaColumna, "La suma", "Columna")

        ' llamo al procedimiento que va a determinar la posición del mayor de cada fila de la matriz pasando como
        ' parámetro la matriz y el vector donde se guardarán los resultados
        MayorFila(mat, VecMayorFila)
        ' llamo al procedimiento que me mostrará el vector
        MostraVector(VecMayorFila, "La posición del mayor", "Fila")
        ' llamo al procedimiento que va a determinar la posición del menor de cada columna de la matriz pasando como
        ' parámetro la matriz y el vector donde se guardarán los resultados
        MenorColumna(mat, VecMenColumna)
        ' llamo al procedimiento que me mostrará el vector
        MostraVector(VecMenColumna, "La posición del menor", "Columna")
        ' llamo al procedimiento que va a determinar el promedio de cada fila de la matriz pasando como
        ' parámetro el vector donde se sumo cada fila, la cantidad de elementos y el vector donde
        'se guardarán los resultados
        promedios(VecSumaFila, mat.GetLength(1), VecPromedioFila)
        ' llamo al procedimiento que me mostrará el vector
        MostraVector2(VecPromedioFila, "promedio", "fila")
        ' llamo al procedimiento que va a determinar el promedio de cada columna de la matriz pasando como
        ' parámetro el vector donde se sumo cada columna, la cantidad de elementos y el vector donde
        'se guardarán los resultados
        promedios(VecSumaColumna, mat.GetLength(0), VecPromedioColumna)
        ' llamo al procedimiento que me mostrará el vector
        MostraVector2(VecPromedioColumna, "promedio", "columna")
        ' llamo al procedimiento para cargar el vector con la fila K de la matriz
        GenerarVectorFilaK(mat, k, VectorFilaK)
        ' llamo al procedimiento que me mostrará el vector
        MostraVector(VectorFilaK, "los elementos", "de la fila ingresada(k)")
        ' llamo al procedimiento para generar el vector con los valores mayores en valor absoluto
        ' del promedio general de la matriz
        GenerarVectorValorAb(mat, VectorValorAb, VecSumaFila)
        ' llamo al procedimiento que me mostrará el vector
        MostraVector(VectorValorAb, "de los elementos", "valor absoluto")
        Console.ReadLine()
    End Sub
    Sub cargarmatriz(ByRef ma(,) As Integer)
        For i = 0 To ma.GetUpperBound(0)
            For j = 0 To ma.GetUpperBound(1)
                Console.Write("Ingrese fila {0} columna {1}: ", i, j)
                ma(i, j) = CInt(Console.ReadLine())
            Next
        Next
    End Sub
    Sub mostrarmatriz(ByVal ma(,) As Integer)
        For i = 0 To ma.GetUpperBound(0)
            For j = 0 To ma.GetUpperBound(1)
                Console.WriteLine("fila {0} columna {1} valor {2}", i, j, ma(i, j))
            Next
        Next
        Console.WriteLine()
    End Sub
    Function ingresarnumero(ByVal que As String) As Integer
        Do
            Console.Write("Ingrese cantidad de elementos para la {0}: ", que)
            ingresarnumero = CInt(Console.ReadLine)
        Loop Until ingresarnumero > 0
    End Function
    Function IngresarValork(ByVal fila As Integer) As Integer
        Do
            Console.Write("Ingrese la fila para generar el vector: ")
            IngresarValork = CInt(Console.ReadLine)
        Loop Until IngresarValork >= 0 And IngresarValork <= fila
    End Function
    Sub SumaFila(ByVal ma(,) As Integer, ByRef ve() As Integer)
        For i = 0 To ma.GetUpperBound(0)
            ve(i) = 0
            For j = 0 To ma.GetUpperBound(1)
                ve(i) += ma(i, j)
            Next
        Next
    End Sub
    Sub SumaColumna(ByVal ma(,) As Integer, ByRef ve() As Integer)
        For j = 0 To ma.GetUpperBound(1)
            ve(j) = 0
            For i = 0 To ma.GetUpperBound(0)
                ve(j) += ma(i, j)
            Next
        Next
    End Sub
    Sub MayorFila(ByVal ma(,) As Integer, ByRef ve() As Integer)
        Dim aux As Integer
        For i = 0 To ma.GetUpperBound(0)
            aux = Integer.MinValue
            For j = 0 To ma.GetUpperBound(1)
                If ma(i, j) >= aux Then
                    aux = ma(i, j)
                    ve(i) = j
                End If
            Next
        Next
    End Sub
    Sub MenorColumna(ByVal ma(,) As Integer, ByRef ve() As Integer)
        Dim aux As Integer
        For j = 0 To ma.GetUpperBound(1)
            aux = Integer.MaxValue
            For i = 0 To ma.GetUpperBound(0)
                If ma(i, j) < aux Then
                    aux = ma(i, j)
                    ve(j) = i
                End If
            Next
        Next
    End Sub
    Sub promedios(ByVal ve() As Integer, ByVal cuantos As Integer, ByRef pro() As Double)
        For i = 0 To ve.GetUpperBound(0)
            pro(i) = ve(i) / cuantos
        Next
    End Sub
    Sub GenerarVectorFilaK(ByVal ma(,) As Integer, ByVal quefila As Integer, ByRef ve() As Integer)
        For j = 0 To ma.GetUpperBound(1)
            ve(j) = ma(quefila, j)
        Next
    End Sub
    Sub GenerarVectorValorAb(ByVal ma(,) As Integer, ByRef ve() As Integer, ByVal ve1() As Integer)
        Dim pro As Double
        Dim ind, aux As Integer
        For i = 0 To ve1.GetUpperBound(0)
            pro += ve1(i)
        Next
        pro = pro / ve1.GetLength(0)
        For i = 0 To ma.GetUpperBound(0)
            For j = 0 To ma.GetUpperBound(1)
                aux = ma(i, j)
                If aux < 0 Then
                    aux = -aux
                End If
                If aux > pro Then
                    ReDim Preserve ve(ind)
                    ve(ind) = ma(i, j)
                    ind += 1
                End If
            Next
        Next
    End Sub
    Sub MostraVector(ByVal ve() As Integer, ByVal OPE As String, ByVal que As String)
        Console.WriteLine()
        Console.WriteLine("Vector de {0} {1}", OPE, que)
        Console.WriteLine()
        If IsNothing(ve) Then
            Console.WriteLine()
            Console.WriteLine("No hay ningún valor que lo supere")
            Return
        End If
        For I = 0 To ve.GetUpperBound(0)
            Console.WriteLine(" {0} {1} {2} es {3}", OPE, que, I, ve(I))
        Next
        Console.ReadLine()
    End Sub
    Sub MostraVector2(ByVal ve() As Double, ByVal OPE As String, ByVal que As String)
        Console.WriteLine()
        Console.WriteLine("Vector de {0} {1}", OPE, que)
        Console.WriteLine()
        For I = 0 To ve.GetUpperBound(0)
            Console.WriteLine("{0} de la {1} {2} es {3}", OPE, que, I, ve(I))
        Next
        Console.ReadLine()
    End Sub


End Module
