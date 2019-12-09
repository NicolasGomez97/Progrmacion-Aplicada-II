Public Class VideoJuego
    Inherits Referencia

    Private _Estilo As String
    Private _Plataforma As String
    Public Property Estilo() As String
        Get
            Return _Estilo
        End Get
        Set(ByVal value As String)
            ErrorString(value, "Genero")
            _Estilo = value
        End Set
    End Property

    Public Property Plataforma() As String
        Get
            Return _Plataforma
        End Get
        Set(ByVal value As String)
            ErrorString(value, "Plataforma")
            _Plataforma = value
        End Set
    End Property
    Public Function BuscarVideoJuego(ByVal pcodvideo As Integer, ByVal pVideoJuego_Dummy() As VideoJuego) As Integer
        Dim i, indice As Integer
        indice = -1
        Do

            If pVideoJuego_Dummy(i).Codigo = pcodvideo Then
                indice = i
            End If
            i = i + 1
        Loop Until indice > -1 Or i > pVideoJuego_Dummy.GetUpperBound(0)
        Return indice
    End Function
    Private Sub ErrorString(ByVal pvalue As String, ByVal pquien As String)
        If pvalue.Length = 0 Or Trim(pvalue) = "" Then
            Throw New Exception("Campo " & pquien & " vacio")
        End If
    End Sub
    Public Sub New()

    End Sub
    Public Sub New(ByVal pCodigo As Integer, ByVal ptitulo As String, ByVal pPrecio_alquiler As Double, ByVal pPlazo As Integer, ByVal pAlquilado As String, ByVal pestilo As String, ByVal pplataforma As String)

        Me.Codigo = pCodigo
        Me.Titulo = ptitulo
        Me.Precio_alquiler = pPrecio_alquiler
        Me.Plazo = pPlazo
        Me.Alquilado = pAlquilado
        _Estilo = pestilo
        _Plataforma = pplataforma

    End Sub
End Class
