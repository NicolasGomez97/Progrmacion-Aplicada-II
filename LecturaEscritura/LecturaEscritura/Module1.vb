Module Module1

    Sub Main()
        Dim loEmpleado As Empleado
        loEmpleado = New Empleado()
        loEmpleado.psNombre = "Pedro"
        'a esta propiedad sólo podemos aignarle 
        'valor, si intentamos obtenerlo, se producirá
        ' un error
        loEmpleado.CuentaBancaria = "2222-56-7779995555"
        'en esta linea, la propiedad Entidad Bancario solo
        'nos permite obtener valor, si intetamos aignarlo
        'se producirá un error
        Console.WriteLine("La entidad del empleado {0} es {1}", loEmpleado.psNombre, loEmpleado.EntidadBancaria)
        Console.ReadLine()
    End Sub

End Module
Public Class Empleado
    'campo de clase
    Public psNombre As String
    'variable de propiedad
    Private _CuentaBancaria As String
    Private _EntidadBancaria As String
    'variable diversas
    Private msCodigoEntidad As String
    'esta propiedad sólo permite asignar valores,
    'por lo que no dipone de bloque Get
    Public WriteOnly Property CuentaBancaria() As String
        Set(ByVal value As String)
            Select Left(value, 4)
                Case "1111"
                    _EntidadBancaria = "Banco  Universal"
                Case "2222"
                    _EntidadBancaria = "Banco General"
                Case "3333"
                    _EntidadBancaria = "Caja Metropolitana"
                Case "4444"
                    _EntidadBancaria = "entidad sin catalogar"
            End Select
        End Set
    End Property
    'esta propiedad sólo permite obtener valores,
    'por lo que no dispone de bloque Set
    Public ReadOnly Property EntidadBancaria() As String
        Get
            Return _CuentaBancaria
        End Get
    End Property

End Class
