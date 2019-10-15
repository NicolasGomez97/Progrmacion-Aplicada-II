Public Class Empleado
    Private _fechaCrea As Date
    Public Property FechaCrea() As Date
        Get
            Return _fechaCrea
        End Get
        Set(ByVal value As Date)
            _fechaCrea = value
        End Set
    End Property
    'método constructor
    Public Sub New(ByRef pFecha As Date)
        'asignamos un valore inicila
        ' a una variable de propiedad
        Me.FechaCrea = pFecha
    End Sub
End Class