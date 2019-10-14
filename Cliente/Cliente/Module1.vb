Module Module1

    Sub Main()
        Dim loEmpleado As Empleado
        loEmpleado = New Empleado()
        Try
            loEmpleado.psNombre = "Pedro"
            loEmpleado.Categoria = 2
            loEmpleado.Sueldo = 150
            Console.WriteLine("Empleado {0}-Categoria{1}-Sueldo{2}", loEmpleado.psNombre, loEmpleado.Categoria, loEmpleado.Sueldo)

            loEmpleado.Sueldo = 175
            Console.WriteLine("Empleado {0}-Categoria{1}-Sueldo{2}", loEmpleado.psNombre, loEmpleado.Categoria, loEmpleado.Sueldo)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadLine()
    End Sub

End Module
Public Class Empleado
    Public psNombre As String
    'variable de propiedad
    Private _Categoria As String
    Private _bSueldo As Double
    ' procedimientos de propiedad
    Public Property Categoria() As Integer
        Get
            Return _Categoria
        End Get
        Set(ByVal value As Integer)
            _Categoria = value
        End Set
    End Property
    Public Property Sueldo() As Double
        Get
            Return _bSueldo
        End Get
        'cuando asignamos el valor a esta propiedad,
        'ejecutamos código de validación en el bloque Set
        Set(ByVal value As Double)
            If _Categoria < 1 Or _Categoria > 2 Then 'si la categoria del empleado es distinta a 1 o 2
                Throw New Exception("La categoria no corresponde con el sueldo")
                _bSueldo = 0
            ElseIf _Categoria = 1 And value >= 200 Or _Categoria = 2 And value > 300 Then
                'si la categoria del empleado es 2 pero el sueldo es menor o igual de 200 y mayor 300
                'generando una excepción y asignar un cero
                Throw New Exception("La categoria no corresponde con el sueldo")
            Else
                'si todo va bien, asignar el sueldo
                _bSueldo = value

            End If

        End Set
    End Property
End Class