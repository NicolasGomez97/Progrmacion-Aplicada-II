Imports NEGOCIO
Public Class Operaciones

    Private clientes_Dummy(5) As Cliente
    Private pelicula_Dummy(5) As Pelicula
    Private VideoJuego_Dummy(5) As VideoJuego
    Private Alquiler_Dummy(0) As Alquiler
    Public opcion As Integer
    Public Sub MenuPrincipal()
        Do
            Try

            
                Console.Clear()
                Console.WriteLine(StrDup(79, "*"))
                Console.WriteLine(StrDup(29, "*") & " Sistema de Videoclub " & StrDup(28, "*"))
                Console.WriteLine(StrDup(79, "*"))
                For i As Integer = 1 To 5
                    Console.WriteLine()
                Next
                Console.WriteLine(StrDup(28, " ") & " 1) Listado de Productos")
                Console.WriteLine(StrDup(28, " ") & " 2) Añadir Productos")
                Console.WriteLine(StrDup(28, " ") & " 3) Ficha Producto")
                Console.WriteLine(StrDup(28, " ") & " 4) Listado Clientes")
                Console.WriteLine(StrDup(28, " ") & " 5) Añadir Cliente")
                Console.WriteLine(StrDup(28, " ") & " 6) Ficha Cliente")
                Console.WriteLine(StrDup(28, " ") & " 7) Alquiler de Producto")
                Console.WriteLine(StrDup(28, " ") & "99) Salir del Sistema")
                Console.WriteLine()
                Console.WriteLine()
                Console.Write(StrDup(28, " ") & "Ingrese opción: ")
                opcion = CInt(Console.ReadLine)

                Select Case opcion
                    Case 1
                        SubMenuListarProducto()
                    Case 2
                        SubMenuAltaProducto()
                    Case 3
                        SubMenuFichaProducto()
                    Case 4
                        ListarClientes()
                    Case 5
                        AltaCliente()
                    Case 6
                        FichaCliente()
                    Case 7
                        AltaAlquiler()
                End Select
            Catch ex As Exception
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine(ex.Message)
                Console.ReadLine()
            End Try
        Loop Until opcion = 99
    End Sub
    Private Sub SubMenuListarProducto()
        Dim opcion As Integer
        Do
            Try

                Console.Clear()
                Console.WriteLine(StrDup(79, "*"))
                Console.WriteLine(StrDup(29, "*") & " Listar Productos " & StrDup(28, "*"))
                Console.WriteLine(StrDup(79, "*"))
                For i As Integer = 1 To 5
                    Console.WriteLine("")
                Next
                Console.WriteLine(StrDup(28, " ") & " 1) Peliculas")
                Console.WriteLine(StrDup(28, " ") & " 2) VideoJuegos")
                Console.WriteLine(StrDup(28, " ") & " 3) Todos")
                Console.WriteLine()
                Console.WriteLine()
                Console.Write(StrDup(28, " ") & "Ingrese opción: ")
                opcion = CInt(Console.ReadLine)
                If opcion < 1 Or opcion > 3 Then
                    Throw New Exception("Se debe ingresar 1,2 ó 3 en la opción - vuelva a ingresar")
                End If
                Console.Clear()
                Select Case opcion
                    Case 1
                        Listarpeliculas()
                    Case 2
                        ListarVideojuegos()
                    Case 3
                        Listarpeliculas()
                        ListarVideojuegos()
                End Select
                Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine(ex.Message())
                Console.ReadLine()
            End Try
        Loop Until opcion >= 1 And opcion <= 3
    End Sub
    Private Sub Listarpeliculas()
        Console.WriteLine("Listado de Peliculas")
        Console.WriteLine()
        For Each peli In pelicula_Dummy
            Console.WriteLine("Código          : " & peli.Codigo)
            Console.WriteLine("Título          : " & peli.Titulo)
            Console.WriteLine("Género          : " & peli.Genero)
            Console.WriteLine("Director        : " & peli.Director)
            Console.WriteLine("Interpretes     : " & peli.Interpretes)
            Console.WriteLine("Año             : " & peli.Año)
            Console.WriteLine("Alquilado       : " & peli.Alquilado)
            Console.WriteLine("Plazo(días)     : " & peli.Plazo)
            Console.WriteLine("Precio Alquiler : " & peli.Precio_alquiler)
            Console.WriteLine()
        Next
    End Sub
    Private Sub ListarVideojuegos()
        Console.WriteLine("Listado de Videojuegos")
        Console.WriteLine()
        For Each video In VideoJuego_Dummy
            Console.WriteLine("Código          : " & video.Codigo)
            Console.WriteLine("Título          : " & video.Titulo)
            Console.WriteLine("Género          : " & video.Estilo)
            Console.WriteLine("Plataforma      : " & video.Plataforma)
            Console.WriteLine("Alquilado       : " & video.Alquilado)
            Console.WriteLine("Plazo(días)     : " & video.Plazo)
            Console.WriteLine("Precio Alquiler : " & video.Precio_alquiler)
            Console.WriteLine()
        Next

    End Sub
    Private Sub SubMenuAltaProducto()
        Dim opcion As Integer
        Do
            Try

            
                Console.Clear()
                Console.WriteLine(StrDup(79, "*"))
                Console.WriteLine(StrDup(29, "*") & " Añadir Productos " & StrDup(28, "*"))
                Console.WriteLine(StrDup(79, "*"))
                For i As Integer = 1 To 5
                    Console.WriteLine()
                Next

                Console.WriteLine(StrDup(28, " ") & " 1) Añadir Pelicula")
                Console.WriteLine(StrDup(28, " ") & " 2) Añadir VideoJuego")
                Console.WriteLine()
                Console.WriteLine()
                Console.Write(StrDup(28, " ") & "Ingrese opción: ")
                opcion = CInt(Console.ReadLine)
                If opcion < 1 Or opcion > 2 Then
                    Throw New Exception("Se debe ingresar 1 ó 2 en la opción - vuelva a ingresar")
                End If
                Console.Clear()
                If opcion = 1 Then
                    AltaPelicula()
                Else
                    AltaVideojuego()
                End If
            Catch ex As Exception
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine(ex.Message())
                Console.ReadLine()
            End Try
        Loop Until opcion = 1 Or opcion = 2
    End Sub
    Private Sub AltaPelicula()
        Dim opeli As New Pelicula
        Dim sino As String
        Try


            Console.Clear()
            Console.WriteLine(StrDup(79, "*"))
            Console.WriteLine(StrDup(29, "*") & " Alta Película " & StrDup(28, "*"))
            Console.WriteLine(StrDup(79, "*"))
            Console.WriteLine()
            Console.Write("Código          : ")
            opeli.Codigo = CInt(Console.ReadLine())
            Console.Write("Título          : ")
            opeli.Titulo = Console.ReadLine()
            Console.Write("Género          : ")
            opeli.Genero = Console.ReadLine()
            Console.Write("Director        : ")
            opeli.Director = Console.ReadLine()
            Console.Write("Interpretes     : ")
            opeli.Interpretes = Console.ReadLine()
            Console.Write("Año             : ")
            opeli.Año = CInt(Console.ReadLine())
            Console.Write("Alquilado       : ")
            opeli.Alquilado = Console.ReadLine()
            Console.Write("Plazo(días)     : ")
            opeli.Plazo = CInt(Console.ReadLine())
            Console.Write("Precio Alquiler : ")
            opeli.Precio_alquiler = CDbl(Console.ReadLine())
            Console.WriteLine()
            Console.WriteLine()
            Console.Write("Confirma S/N: ")
            sino = Console.ReadLine()
            If sino.ToUpper = "S" Then
                ReDim Preserve pelicula_Dummy(pelicula_Dummy.Length)
                'pelicula_Dummy(pelicula_Dummy.Length - 1) = opeli
                pelicula_Dummy(pelicula_Dummy.GetUpperBound(0)) = opeli
                Console.WriteLine()
                Console.WriteLine("Alta Realizada")
                Console.ReadLine()
            Else
                Console.WriteLine()
                Console.WriteLine("Alta No Realizada")
                Console.ReadLine()
            End If
        Catch ex As Exception
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine(ex.Message)
            Console.ReadLine()

        End Try
    End Sub
    Private Sub AltaVideojuego()
        Dim ojuego As New VideoJuego
        Dim sino As String
        Try

        
            Console.Clear()
            Console.WriteLine(StrDup(79, "*"))
            Console.WriteLine(StrDup(29, "*") & " Alta Película " & StrDup(28, "*"))
            Console.WriteLine(StrDup(79, "*"))
            Console.Write("Código          : ")
            ojuego.Codigo = CInt(Console.ReadLine())
            Console.Write("Título          : ")
            ojuego.Titulo = Console.ReadLine()
            Console.Write("Género          : ")
            ojuego.Estilo = Console.ReadLine()
            Console.Write("Plataforma      : ")
            ojuego.Plataforma = Console.ReadLine()
            Console.Write("Alquilado       : ")
            ojuego.Alquilado = Console.ReadLine()
            Console.Write("Plazo(días)     : ")
            ojuego.Plazo = CInt(Console.ReadLine())
            Console.Write("Precio Alquiler : ")
            ojuego.Precio_alquiler = CDbl(Console.ReadLine())
            Console.WriteLine()
            Console.WriteLine()
            Console.Write("Confirma S/N: ")
            sino = Console.ReadLine()
            If sino.ToUpper = "S" Then
                ReDim Preserve VideoJuego_Dummy(VideoJuego_Dummy.Length)
                VideoJuego_Dummy(VideoJuego_Dummy.Length - 1) = ojuego
                Console.WriteLine()
                Console.WriteLine("Alta Realizada")
                Console.ReadLine()
            Else
                Console.WriteLine()
                Console.WriteLine("Alta No Realizada")
                Console.ReadLine()
            End If
        Catch ex As Exception
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine(ex.Message)

        End Try
    End Sub
    Private Sub SubMenuFichaProducto()
        Dim opcion As Integer
        Do
            Try


                Console.Clear()
                Console.WriteLine(StrDup(79, "*"))
                Console.WriteLine(StrDup(29, "*") & " Ficha Productos " & StrDup(28, "*"))
                Console.WriteLine(StrDup(79, "*"))
                For i As Integer = 1 To 5
                    Console.WriteLine("")
                Next
                Console.WriteLine(StrDup(28, " ") & " 1) Pelicula")
                Console.WriteLine(StrDup(28, " ") & " 2) VideoJuego")
                Console.WriteLine()
                Console.WriteLine()
                Console.Write(StrDup(28, " ") & "Ingrese opción: ")
                opcion = CInt(Console.ReadLine)
                If opcion < 1 Or opcion > 2 Then
                    Throw New Exception("Se debe ingresar 1 ó 2 en la opción - vuelva a ingresar")
                End If
                Console.Clear()
                Select Case opcion
                    Case 1
                        FichaPelicula()
                    Case 2
                        FichaVideojuego()

                End Select
                Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine(ex.Message())
                Console.ReadLine()
            End Try
        Loop Until opcion >= 1 And opcion <= 3
    End Sub
    Private Sub FichaPelicula()
        Dim codpeli, indice As Integer
        Dim opeli As New Pelicula
        Try

        
            Console.Clear()
            Console.WriteLine()
            Console.Write("Ingrese Código de Película : ")
            codpeli = CInt(Console.ReadLine())
            indice = opeli.BuscarPelicula(codpeli, pelicula_Dummy)

            If indice > -1 Then

                Console.Clear()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("Código          : " & pelicula_Dummy(indice).Codigo)
                Console.WriteLine("Título          : " & pelicula_Dummy(indice).Titulo)
                Console.WriteLine("Género          : " & pelicula_Dummy(indice).Genero)
                Console.WriteLine("Director        : " & pelicula_Dummy(indice).Director)
                Console.WriteLine("Interpretes     : " & pelicula_Dummy(indice).Interpretes)
                Console.WriteLine("Año             : " & pelicula_Dummy(indice).Año)
                Console.WriteLine("Alquilado       : " & pelicula_Dummy(indice).Alquilado)
                Console.WriteLine("Plazo(días)     : " & pelicula_Dummy(indice).Plazo)
                Console.WriteLine("Precio Alquiler : " & pelicula_Dummy(indice).Precio_alquiler)
                Console.WriteLine()

            Else
                Throw New Exception("No existe el código de pélicula " & codpeli)
            End If
        Catch ex As Exception
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine(ex.Message)

        End Try
    End Sub
    Private Sub FichaVideojuego()
        Dim codvideo, indice As Integer
        Dim ovideojuego As New VideoJuego
        Try

        
            Console.Clear()
            Console.WriteLine()
            Console.Write("Ingrese Código de Videojuego : ")
            codvideo = CInt(Console.ReadLine())
            indice = ovideojuego.BuscarVideoJuego(codvideo, VideoJuego_Dummy)


            If indice > -1 Then

                Console.Clear()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("Código          : " & VideoJuego_Dummy(indice).Codigo)
                Console.WriteLine("Título          : " & VideoJuego_Dummy(indice).Titulo)
                Console.WriteLine("Género          : " & VideoJuego_Dummy(indice).Estilo)
                Console.WriteLine("Plataforma      : " & VideoJuego_Dummy(indice).Plataforma)
                Console.WriteLine("Alquilado       : " & VideoJuego_Dummy(indice).Alquilado)
                Console.WriteLine("Plazo(días)     : " & VideoJuego_Dummy(indice).Plazo)
                Console.WriteLine("Precio Alquiler : " & VideoJuego_Dummy(indice).Precio_alquiler)
                Console.WriteLine()

            Else
                Console.WriteLine()
                Console.WriteLine("El código no existe")

            End If
        Catch ex As Exception
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub ListarClientes()
        Console.Clear()
        Console.WriteLine("Listado de Clientes")
        Console.WriteLine()
        For Each clie In clientes_Dummy
            Console.WriteLine("Nro. Cliente : " & clie.Nro_Cliente)
            Console.WriteLine("Nombre       : " & clie.Nombre)
            Console.WriteLine("Dirección    : " & clie.Direccion)
            Console.WriteLine("Teléfono     : " & clie.Telefono)
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub
    Private Sub AltaCliente()
        Dim oclie As New Cliente
        Dim sino As String
        Dim salir As Boolean
        Do


            Try


                Console.Clear()
                Console.WriteLine(StrDup(79, "*"))
                Console.WriteLine(StrDup(29, "*") & " Alta Cliente " & StrDup(28, "*"))
                Console.WriteLine(StrDup(79, "*"))
                Console.Write("Nro. Cliente : ")
                oclie.Nro_Cliente = CInt(Console.ReadLine())
                Console.Write("Nombre          : ")
                oclie.Nombre = Console.ReadLine()
                Console.Write("Dirección          : ")
                oclie.Direccion = Console.ReadLine()
                Console.Write("Teléfono        : ")
                oclie.Telefono = Console.ReadLine()

                Console.WriteLine()
                Console.WriteLine()
                Console.Write("Confirma S/N: ")
                sino = Console.ReadLine()
                If sino.ToUpper = "S" Then
                    ReDim Preserve clientes_Dummy(clientes_Dummy.Length)
                    clientes_Dummy(clientes_Dummy.Length - 1) = oclie
                    Console.WriteLine()
                    Console.WriteLine("Alta Realizada")
                    Console.ReadLine()
                Else
                    Console.WriteLine()
                    Console.WriteLine("Alta No Realizada")
                    Console.ReadLine()
                End If
                salir = True
            Catch ex As Exception
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine(ex.Message)
                Console.ReadLine()
            End Try
        Loop Until salir = True
    End Sub
    Private Sub FichaCliente()
        Dim codclie, indice As Integer
        Dim oCliente As New Cliente
        Try

        
            Console.Clear()
            Console.WriteLine()
            Console.Write("Ingrese Número de Cliente : ")
            codclie = CInt(Console.ReadLine())
            indice = oCliente.BuscarCliente(codclie, clientes_Dummy)

            If indice > -1 Then

                Console.Clear()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("Nro. Cliente : " & clientes_Dummy(indice).Nro_Cliente)
                Console.WriteLine("Nombre       : " & clientes_Dummy(indice).Nombre)
                Console.WriteLine("Dirección    : " & clientes_Dummy(indice).Direccion)
                Console.WriteLine("Teléfono     : " & clientes_Dummy(indice).Telefono)
                Console.WriteLine()

            Else
                Console.WriteLine()
                Console.WriteLine("El código no existe")

            End If
        Catch ex As Exception
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine(ex.Message)

        End Try
        Console.ReadLine()
    End Sub
    Private Sub AltaAlquiler()
        Dim oAlq As New Alquiler
        Dim oCliente As New Cliente
        Dim oPeliculas As New Pelicula
        Dim oVideoJuego As New VideoJuego
        Dim alquiler As String
        Dim sino As String
        Dim indice, pro, dias As Integer
        Dim salir As Boolean
        Do


            Try

                Console.Clear()
                Console.WriteLine(StrDup(79, "*"))
                Console.WriteLine(StrDup(29, "*") & " Alquiler Producto " & StrDup(28, "*"))
                Console.WriteLine(StrDup(79, "*"))
                Console.Write("Nro. Cliente                         : ")
                oAlq.Cliente_Nro = CInt(Console.ReadLine())

                indice = oCliente.BuscarCliente(oAlq.Cliente_Nro, clientes_Dummy)

                If indice = -1 Then
                    Throw New Exception("No existe el cliente con el número " & oAlq.Cliente_Nro.ToString)
                End If
                Console.WriteLine("Nombre                               : {0}", clientes_Dummy(indice).Nombre)
                Console.Write("Producto(1 - Película - 2 Videojuego): ")
                Do
                    pro = CInt(Console.ReadLine())
                    If pro < 1 Or pro > 2 Then
                        Console.WriteLine("Producto no valido - ingrese de nuevo")
                    End If
                Loop Until pro = 1 Or pro = 2
                If pro = 1 Then
                    oAlq.Producto = "Película"
                Else
                    oAlq.Producto = "Videojuego"
                End If
                Console.WriteLine("Ud. seleccionó                       : {0}", oAlq.Producto)
                Console.Write("Código Producto                      : ")
                Do
                    oAlq.Codigo_Producto = CInt(Console.ReadLine())
                    If pro = 1 Then
                        indice = oPeliculas.BuscarPelicula(oAlq.Codigo_Producto, pelicula_Dummy)
                    Else
                        indice = oVideoJuego.BuscarVideoJuego(oAlq.Codigo_Producto, VideoJuego_Dummy)
                    End If
                    If indice = -1 Then
                        Console.WriteLine("Codigo Producto inexistente - Vuelva a ingresar")
                    End If
                Loop Until indice > -1
                If pro = 1 Then
                    Console.WriteLine("Titulo                               : {0}", pelicula_Dummy(indice).Titulo)
                    dias = pelicula_Dummy(indice).Plazo
                    oAlq.Importe = pelicula_Dummy(indice).Precio_alquiler
                    alquiler = pelicula_Dummy(indice).Alquilado
                Else
                    Console.WriteLine("Titulo                               : {0}", VideoJuego_Dummy(indice).Titulo)
                    dias = VideoJuego_Dummy(indice).Plazo
                    oAlq.Importe = VideoJuego_Dummy(indice).Precio_alquiler
                    alquiler = VideoJuego_Dummy(indice).Alquilado
                End If
                If alquiler.ToUpper = "SI" Then
                    Console.WriteLine()
                    Console.WriteLine("Este producto ya está alquilado")
                    Console.ReadLine()
                    Return
                End If
                Console.Write("Ingrese fecha de alquiler DD/MM/AAAA : ")
                oAlq.Fecha_Alquiler = CDate(Console.ReadLine())
                oAlq.Fecha_Devolucion = DateAdd(DateInterval.Day, dias, oAlq.Fecha_Alquiler)
                Console.WriteLine("Fecha de devolución                  : {0}", FormatDateTime(oAlq.Fecha_Devolucion, DateFormat.ShortDate))
                Console.Write("Importe                              : {0}", oAlq.Importe)
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("Confirma Alta S/N: ")
                sino = Console.ReadLine()
                If sino.ToUpper = "S" Then

                    ReDim Preserve Alquiler_Dummy(Alquiler_Dummy.Length)
                    Alquiler_Dummy(Alquiler_Dummy.Length - 1) = oAlq
                    If pro = 1 Then
                        pelicula_Dummy(indice).Alquilado = "Si"
                    Else
                        VideoJuego_Dummy(indice).Alquilado = "Si"
                    End If
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine("Alta Realizada")
                    salir = True
                    Console.ReadLine()
                Else
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine("Alta NO Realizada")
                    Console.ReadLine()
                    Return
                End If


            Catch ex As Exception
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine(ex.Message)
                Console.ReadLine()

            End Try
        Loop Until salir = True

    End Sub
    
   
    Public Sub New()

        clientes_Dummy(0) = New Cliente(1111, "Juan Perez", "Juan b. Justo 234", "435678")
        clientes_Dummy(1) = New Cliente(2222, "Ramón Lopez", "La rioja 1445", "490876")
        clientes_Dummy(2) = New Cliente(3333, "Pedro Martinez", "AV, Gral Paz 23", "478345")
        clientes_Dummy(3) = New Cliente(4444, "Susana Sosa", "Caseros 2021", "408765")
        clientes_Dummy(4) = New Cliente(5555, "Julieta Florez", "27 de Abril 345", "489456")
        clientes_Dummy(5) = New Cliente(6666, "Juan Gomez", "Av. Colón 234", "451234")

        pelicula_Dummy(0) = New Pelicula(1122, "Terminator I", 5, 5, "No", "Ciencia Ficción", 1985, "James Cameron", "Arnold Schwarzenegger")
        pelicula_Dummy(1) = New Pelicula(1133, "La Vida es Bella", 3, 10, "No", "Drama", 1997, "Roberto Benigni", "Roberto Benigni")
        pelicula_Dummy(2) = New Pelicula(1144, "Mulan", 3.5, 6, "No", "Infantil", 1998, "Barry Cook - Tony Bancroft", "Eddie Murphy (Mushu)")
        pelicula_Dummy(3) = New Pelicula(1155, "Avatar", 5, 2, "No", "Ciencia Ficción", 2009, "James Cameron", "Sigourney Weaver")
        pelicula_Dummy(4) = New Pelicula(1166, "Kill Bill vol 1", 4, 2, "Si", "Ciencia Ficción", 2003, "Quentin Tarantino", "Uma Thurman")
        pelicula_Dummy(5) = New Pelicula(1167, "Kill Bill vol 2", 4, 2, "No", "Ciencia Ficción", 2004, "Quentin Tarantino", "Uma Thurman")

        VideoJuego_Dummy(0) = New VideoJuego(1211, "JustCaseII ", 10, 7, "No", "Acción", "Xbox 360")
        VideoJuego_Dummy(1) = New VideoJuego(1222, "Wall E", 5, 6, "No", "Infantil", "PlayStation II")
        VideoJuego_Dummy(2) = New VideoJuego(1233, "Car 2", 10, 7, "No", "Arcade", "Wii")
        VideoJuego_Dummy(3) = New VideoJuego(1244, "NBA 2K", 10, 7, "No", "Deportes", "Wii")
        VideoJuego_Dummy(4) = New VideoJuego(1255, "FIFA 14", 15, 3, "No", "Deportes", "PlayStation III")
        VideoJuego_Dummy(5) = New VideoJuego(1266, "Monster Jam", 8, 5, "No", "Deporte", "Xbox 360")

        Alquiler_Dummy(0) = New Alquiler(1111, "Pelicula", 1166, CDate("10/07/2013"), CDate("12/08/2013"), 4)
    End Sub

   

End Class
