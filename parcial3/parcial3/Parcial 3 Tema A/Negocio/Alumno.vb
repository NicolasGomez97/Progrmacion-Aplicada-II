Public Class Alumno
    Inherits Datos

    Private _Fecha_Inscripcion As Date
    Private _p1 As Integer
    Private _p2 As Integer
    Private _p3 As String
    Private _p4 As String
    Private _p5 As Date
    Private _p6 As Date
    Private _p7 As Integer

    Sub New()
        ' TODO: Complete member initialization 
    End Sub



    Public Property Fecha_Inscripcion() As Date
        Get
            Return _Fecha_Inscripcion
        End Get
        Set(ByVal value As Date)
            _Fecha_Inscripcion = value
        End Set
    End Property


    Private _Nota_Ingreso As Integer
    Public Property Nota_Ingreso() As Integer
        Get
            Return _Nota_Ingreso
        End Get
        Set(ByVal value As Integer)
            _Nota_Ingreso = value
        End Set
    End Property
    Public Function BuscarAlumno(ByVal plegajo As Integer, ByVal pAlumno_Dummy() As Alumno) As Integer
        Dim i, indice As Integer
        indice = -1
        Do

            If pAlumno_Dummy(i).Legajo = plegajo Then
                indice = i
                Return indice
            End If
            i = i + 1
        Loop Until i > pAlumno_Dummy.GetUpperBound(0)
        Return indice
    End Function

    Sub New(ByVal p1 As Integer, ByVal p2 As Integer, ByVal p3 As String, ByVal p4 As String, ByVal p5 As Date, ByVal p6 As Date, ByVal p7 As Integer)
        ' TODO: Complete member initialization 
        Legajo = p1
        Nombre = p3
        DNI = p2
        Domicilio = p4
        Fecha_Nacimiento = p5
        Fecha_Inscripcion = p6
        Nota_Ingreso = p7
    End Sub
    

    
End Class
