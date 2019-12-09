Public Class Cliente

    Private _Nro_Cliente As Integer
    Public Property Nro_Cliente() As Integer
        Get
            Return _Nro_Cliente
        End Get
        Set(ByVal value As Integer)
            _Nro_Cliente = value
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


    Private _Direccion As String
    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            ErrorString(value, "Dirección")
            _Direccion = value
        End Set
    End Property


    Private _Telefono As String
    Public Property Telefono() As String
        Get
            Return _Telefono
        End Get
        Set(ByVal value As String)
            ErrorString(value, "Teléfono")
            _Telefono = value
        End Set
    End Property
    Public Function BuscarCliente(ByVal pcodcliente As Integer, ByVal pCliente_Dummy() As Cliente) As Integer
        Dim i, indice As Integer
        indice = -1
        Do

            If pCliente_Dummy(i).Nro_Cliente = pcodcliente Then
                indice = i
            End If
            i = i + 1
        Loop Until indice > -1 Or i > pCliente_Dummy.GetUpperBound(0)
        Return indice
    End Function
    Private Sub ErrorString(ByVal pvalue As String, ByVal pquien As String)
        If pvalue.Length = 0 Or Trim(pvalue) = "" Then
            Throw New Exception("Campo " & pquien & " vacio")
        End If
    End Sub
    Public Sub New()

    End Sub
    Public Sub New(ByVal pCliente As Integer, ByVal pNombre As String, ByVal pDireccion As String, ByVal pTelefono As String)
        _Nro_Cliente = pCliente
        _Nombre = pNombre
        _Direccion = pDireccion
        _Telefono = pTelefono

    End Sub
End Class
