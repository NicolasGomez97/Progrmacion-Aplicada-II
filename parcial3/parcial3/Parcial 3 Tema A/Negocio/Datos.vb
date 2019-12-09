Public Class Datos

    Private _Legajo As Integer
    Public Property Legajo() As Integer
        Get
            Return _Legajo
        End Get
        Set(ByVal value As Integer)
            _Legajo = value
        End Set
    End Property


    Private _DNI As Integer
    Public Property DNI() As Integer
        Get
            Return _DNI
        End Get
        Set(ByVal value As Integer)
            _DNI = value
        End Set
    End Property


    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            ErrorString(value, "Nombre")
            _Nombre = value
        End Set
    End Property


    Private _Domicilio As String
    Public Property Domicilio() As String
        Get
            Return _Domicilio
        End Get
        Set(ByVal value As String)
            ErrorString(value, "Domicilio")
            _Domicilio = value
        End Set
    End Property


    Private _Fecha_Nacimiento As Date
    Public Property Fecha_Nacimiento() As Date
        Get
            Return _Fecha_Nacimiento
        End Get
        Set(ByVal value As Date)
            _Fecha_Nacimiento = value
        End Set
    End Property
    Private Sub ErrorString(ByVal pvalue As String, ByVal pquien As String)
        If pvalue.Length = 0 Or Trim(pvalue) = "" Then
            Throw New Exception("Campo " & pquien & " vacio")
        End If
    End Sub
End Class
