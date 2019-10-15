Public Class Empleado
    Private _FechaCrea As Date
    Public Property FechaCrea() As Date
        Get
            Return _FechaCrea
        End Get
        Set(ByVal value As Date)
            _FechaCrea = value
        End Set
    End Property
    'método constructor
    Public Sub New()
        'asignamos un valor inicial
        'a una variable de propiedad
        Me.FechaCrea = Now
    End Sub
End Class
