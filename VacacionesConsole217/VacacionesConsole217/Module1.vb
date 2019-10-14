Module Module1

    Sub Main()
        'instanciar objeto Empleado
        Dim loEmpleado As Empleado
        loEmpleado = New Empleado()

        'asignar valores a propiedades
        loEmpleado.Identificador = 78
        loEmpleado.Nombre = "Antonio"
        loEmpleado.Apellido = "Iglesias"

        ' llamar a método
        loEmpleado.CalcularVacaciones(CDate("31/10/1997"), 21)
    End Sub

End Module
Public Class Empleado
    'variable de propiedad
    Private _Identificador As Integer
    Private _Nombre As String
    Private _Apellido As String

    'procedimiento de propiedad
    Public Property Identificador() As Integer
        Get
            Return _Identificador
        End Get
        Set(ByVal value As Integer)
            _Identificador = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Apellido() As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
        End Set
    End Property
    'métodos
    Public Sub CalcularVacaciones(ByVal idtInicio As Date, ByVal liDias As Integer)
        'en este método calculamos el periodo
        'de vacaciones del empleado,
        'mostrando los resultados en consola
        Dim idtFinal As Date
        idtFinal = DateAdd(DateInterval.Day, liDias, idtInicio)
        Console.WriteLine("Empleado {0} -{1} {2}", Identificador, Nombre, Apellido)
        Console.WriteLine("Vacacion desde {0} hatsa {1}", FormatDateTime(idtInicio, DateFormat.ShortDate), FormatDateTime(idtFinal, DateFormat.ShortDate))
        Console.ReadLine()
    End Sub
End Class

