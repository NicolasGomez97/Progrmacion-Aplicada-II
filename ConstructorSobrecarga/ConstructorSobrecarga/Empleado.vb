Public Class Empleado
    Private _Nombre As String

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Private _Apellidos As String
    Public Property Apellidos() As String
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
    Public Property FechaIngreso As Date
        Get
            Return _FechaIngreso
        End Get
        Set(ByVal value As Date)
            _FechaIngreso = value
        End Set
    End Property
    'en este contructor sin párametros,
    'a todos las propiedades de la clase menos a FechaCrea
    Public Sub New(ByVal pNombre As String, ByVal pApellido As String, ByVal pCiudad As String, ByVal pFechaIng As Date)
        Nombre = pNombre
        Apellidos = pApellido
        Ciudad = pCiudad
        FechaIngreso = pFechaIng
    End Sub
End Class