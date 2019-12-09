Imports Negocio

Public Class Operaciones
    Dim Alumnos_dummy(5) As Alumno
    Dim alum As New Alumno

    Public Sub menu()
        Dim opcion As Integer
        While True
            Try
                Do
                    Encabezado(" Menu Principal ")
                    For i As Integer = 1 To 5
                        Console.WriteLine()
                    Next
                    Console.WriteLine(StrDup(31, " ") & " 1) Alta Alumno")
                    Console.WriteLine(StrDup(31, " ") & " 2) Listado Alumnos")
                    Console.WriteLine(StrDup(31, " ") & " 3) Ficha Alumno")
                    Console.WriteLine(StrDup(31, " ") & "99) Salir")
                    Console.WriteLine()
                    Console.Write(StrDup(31, " ") & "Digite opcion: ")
                    opcion = CInt(Console.ReadLine())
                    If opcion = 99 Then
                        Return
                    End If
                Loop Until opcion > 0 And opcion < 4
                Select Case opcion
                    Case 1
                        AltaAlumno()
                    Case 2
                        ListadoAlumnos()
                    Case 3
                        FichaAlumnos()


                End Select

                Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine(ex.Message)
                Console.ReadLine()
            End Try
        End While
    End Sub
    Private Sub Encabezado(ByVal pencabezado As String)
        Dim longitud As Integer
        longitud = (79 - pencabezado.Length) \ 2
        Console.Clear()
        Console.WriteLine(StrDup(79, "*"))
        Console.WriteLine(StrDup(longitud, "*") & pencabezado & StrDup(longitud, "*"))
        Console.WriteLine(StrDup(79, "*"))
        Console.WriteLine()
    End Sub
    Private Sub AltaAlumno()

        Dim confirmar As String
        Encabezado("Alta Alumno")
            Try
                Console.Write("Legajo: ")
                alum.Legajo = CInt(Console.ReadLine())
                Console.Write("Nombre: ")
                alum.Nombre = CStr(Console.ReadLine())
                Console.Write("Nª DNI : ")
                alum.DNI = CInt(Console.ReadLine())
                Console.Write("Domicilio: ")
                alum.Domicilio = CStr(Console.ReadLine())
                Console.Write("Fecha de Nacimiento (DD/AAAA): ")
                alum.Fecha_Nacimiento = CDate(Console.ReadLine())
                Console.Write("Fecha de Inscripcion (DD/AAAA): ")
                alum.Fecha_Inscripcion = CDate(Console.ReadLine())
                Console.Write("Nota de Ingreso : ")
                alum.Nota_Ingreso = CInt(Console.ReadLine())
                ' agregar codigo


                Console.Write("Confirma Alta S/N")
                confirmar = CStr(Console.ReadLine())
                If confirmar.ToUpper = "S" Then
                    Console.WriteLine("Alta Realizada")
                Else
                    Console.WriteLine("Alta no Realizada")
                End If
            Catch ex As Exception

                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine(ex.Message)
                Console.ReadLine()
            End Try

    End Sub
    Private Sub ListadoAlumnos()
        Encabezado("Listado de Alumnos")
        Dim alum As New Alumno
        Try
            For Each alum In Alumnos_dummy
                Console.WriteLine()
                Console.WriteLine("Legajo:                       {0}", alum.Legajo)
                Console.WriteLine("Nombre:                       {0}", alum.Nombre)
                Console.WriteLine("Nª DNI:                       {0}", alum.DNI)
                Console.WriteLine("Domicilio:                    {0}", alum.Domicilio)
                Console.WriteLine("Fecha de Nacimiento:          {0}", FormatDateTime(alum.Fecha_Nacimiento, DateFormat.ShortDate))
                Console.WriteLine("Fecha de inscripcion:         {0}", FormatDateTime(alum.Fecha_Inscripcion, DateFormat.ShortDate))
                Console.WriteLine("Nota de Ingreso:              {0}", alum.Nota_Ingreso)

            Next
            ' Agregar código

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub FichaAlumnos()
        Dim indice, legajo As Integer
        Encabezado("Fichaje de Alumno")
        Console.Write("Ingrese Legajo de Alumno: ")
        legajo = CInt(Console.ReadLine())
        indice = alum.BuscarAlumno(legajo, Alumnos_dummy)
        Try

            ' Agregar código

            If indice > -1 Then
                Console.WriteLine()
                Console.WriteLine("Legajo:                        {0} ", Alumnos_dummy(indice).Legajo)
                Console.WriteLine("Nombre:                        {0} ", Alumnos_dummy(indice).Nombre)
                Console.WriteLine("DNI:                           {0} ", Alumnos_dummy(indice).DNI)
                Console.WriteLine("Domiciolio:                    {0} ", Alumnos_dummy(indice).Domicilio)
                Console.WriteLine("Fecha de Nacimiento:           {0} ", FormatDateTime(Alumnos_dummy(indice).Fecha_Nacimiento, DateFormat.ShortDate))
                Console.WriteLine("Fecha de Inscripcion:          {0} ", FormatDateTime(Alumnos_dummy(indice).Fecha_Inscripcion, DateFormat.ShortDate))
                Console.WriteLine("Nota de Ingreso:               {0} ", Alumnos_dummy(indice).Nota_Ingreso)

            Else
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine("No existe el Legajo del Alumno {0} ", legajo)
            End If

        Catch ex As Exception
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine(ex.Message)

        End Try
    End Sub

    Public Sub New()
        Alumnos_dummy(0) = New Alumno(1111, 12345678, "Nitri Emiliano", "la Rioja 1450", CDate("01/02/1989"), CDate("12/02/2012"), 9)
        Alumnos_dummy(1) = New Alumno(2222, 87654321, "Romero Paola", "Av Colon 2345", CDate("01/02/1978"), CDate("22/02/2011"), 5)
        Alumnos_dummy(2) = New Alumno(3333, 14589622, "Reyes Patricia", "Urquiza 75", CDate("28/07/1936"), CDate("24/02/2010"), 6)
        Alumnos_dummy(3) = New Alumno(4444, 17568974, "Ibarra Cesar", "San Martin 1254", CDate("25/05/1980"), CDate("13/02/2009"), 10)
        Alumnos_dummy(4) = New Alumno(5555, 32156425, "Luciano Brillaud", "Av Carcano 750", CDate("30/10/1985"), CDate("26/02/2012"), 4)
        Alumnos_dummy(5) = New Alumno(6666, 38123456, "Fernandez Laura", "Av Colon 2345", CDate("01/02/1978"), CDate("22/02/2011"), 7)





    End Sub

End Class
