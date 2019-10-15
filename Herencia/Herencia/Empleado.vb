Public Class Empleado
    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Private _Apellidos As String
    Public Property Apellidos As String
        Get
            Return _Apellidos
        End Get
        Set(ByVal value As String)
            _Apellidos = value
        End Set
    End Property
    Private _Ciudad As String
    Public Property Ciudad() As String
        Get
            Return _Ciudad
        End Get
        Set(ByVal value As String)
            _Ciudad = value
        End Set
    End Property
    Private _FechaCrea As Date
    Public Property FechaCrea() As Date
        Get
            Return _FechaCrea
        End Get
        Set(ByVal value As Date)
            _FechaCrea = value
        End Set
    End Property
    Private _FechaIngreso As Date
    Public Property FechaIngreso() As Date
        Get
            Return _FechaIngreso
        End Get
        Set(ByVal value As Date)
            _FechaIngreso = value
        End Set
    End Property
    'en este constructor sin paárametros,
    'asignamos la fecha actual a la propiedad FechaCrea
    Public Sub New()
        FechaCrea = Now()
    End Sub
    'en este constructor, asignamos valores
    'a todos las propiedades de la clase menos a FechaCrea
    Public Sub New(ByVal pNombre As String, ByVal pApellidos As String, ByVal pCiudad As String, ByVal pFechaIng As Date)
        Nombre = pNombre
        Apellidos = pApellidos
        Ciudad = pCiudad
        FechaIngreso = pFechaIng

    End Sub
End Class