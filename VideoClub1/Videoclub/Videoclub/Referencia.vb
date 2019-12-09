Public Class Referencia
    Private _Codigo As Integer
    Private _Titulo As String
    Private _Precio_alquiler As Double
    Private _Plazo As Integer
    Private _Alquilado As String



    Public Property Codigo() As Integer
        Get
            Return _Codigo
        End Get
        Set(ByVal value As Integer)
            _Codigo = value
        End Set
    End Property

    
    Public Property Titulo() As String
        Get
            Return _Titulo
        End Get
        Set(ByVal value As String)
            ErrorString(value, "Titulo")
            _Titulo = value
        End Set
    End Property

    Public Property Precio_alquiler() As Double
        Get
            Return _Precio_alquiler
        End Get
        Set(ByVal value As Double)
            _Precio_alquiler = value
        End Set
    End Property

    Public Property Plazo() As Integer
        Get
            Return _Plazo
        End Get
        Set(ByVal value As Integer)
            _Plazo = value
        End Set
    End Property

    Public Property Alquilado() As String
        Get
            Return _Alquilado
        End Get
        Set(ByVal value As String)
            If value.ToUpper = "SI" Or value.ToUpper = "NO" Then
                _Alquilado = value
            Else
                ErrorString(value, "Alquilado")
            End If
        End Set
    End Property
    Private Sub ErrorString(ByVal pvalue As String, ByVal pquien As String)
        If pvalue.Length = 0 Or Trim(pvalue) = "" Then
            Throw New Exception("Campo " & pquien & " vacio")
        End If
    End Sub
End Class
