Imports NEGOCIO
Public Class Pelicula
    Inherits Referencia

    Private _genero As String
    Private _Año As Integer
    Private _director As String
    Private _Interpretes As String

    Public Property Genero() As String
        Get
            Return _genero
        End Get
        Set(ByVal value As String)
            ErrorString(value, "Genero")
            _genero = value
        End Set
    End Property

    Public Property Año() As Integer
        Get
            Return _Año
        End Get
        Set(ByVal value As Integer)
            _Año = value
        End Set
    End Property



    Public Property Director() As String
        Get
            Return _director
        End Get
        Set(ByVal value As String)
            ErrorString(value, "Director")
            _director = value
        End Set
    End Property



    Public Property Interpretes() As String
        Get
            Return _Interpretes
        End Get
        Set(ByVal value As String)
            ErrorString(value, "Interpretes")
            _Interpretes = value
        End Set
    End Property
    Public Function BuscarPelicula(ByVal pcodpeli As Integer, ByVal ppelicula_Dummy() As Pelicula) As Integer
        Dim i, indice As Integer
        indice = -1
        Do

            If ppelicula_Dummy(i).Codigo = pcodpeli Then
                indice = i
            End If
            i = i + 1
        Loop Until indice > -1 Or i > ppelicula_Dummy.GetUpperBound(0)
        Return indice
    End Function
    Private Sub ErrorString(ByVal pvalue As String, ByVal pquien As String)
        If pvalue.Length = 0 Or Trim(pvalue) = "" Then
            Throw New Exception("Campo " & pquien & " vacio")
        End If
    End Sub
    Public Sub New()

    End Sub
    Public Sub New(ByVal pCodigo As Integer, ByVal ptitulo As String, ByVal pPrecio_alquiler As Double, ByVal pPlazo As Integer, ByVal pAlquilado As String, ByVal pGenero As String, ByVal pAño As Integer, ByVal pDirector As String, ByVal pInterpretes As String)

        Me.Codigo = pCodigo
        Me.Titulo = ptitulo
        Me.Precio_alquiler = pPrecio_alquiler
        Me.Plazo = pPlazo
        Me.Alquilado = pAlquilado
        _genero = pGenero
        _Año = pAño
        _director = pDirector
        _Interpretes = pInterpretes

    End Sub



End Class
