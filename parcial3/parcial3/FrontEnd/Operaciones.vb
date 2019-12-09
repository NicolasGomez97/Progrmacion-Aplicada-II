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
        Dim oalumno As New Alumno
        Dim sino As String = "S"
        Do

            Try
                Console.Clear()
                Encabezado(" Alta Alumno ")
                Console.WriteLine()
                Console.Write("Legajo: ")
                oalumno.Legajo = CInt(Console.ReadLine())
                Console.Write("Nombre: ")
                oalumno.Nombre = CStr(Console.ReadLine())
                Console.Write("N° dni: ")
                oalumno.DNI = CInt(Console.ReadLine())
                Console.Write("Domcilio: ")
                oalumno.Domicilio = CStr(Console.ReadLine())
                Console.Write("Fecha de Nacimiento: ")
                oalumno.Fecha_Nacimiento = CDate(Console.ReadLine())
                Console.Write("Fecha Inscripcion: ")
                oalumno.Fecha_Inscripcion = CDate(Console.ReadLine())
                Console.Write("Nota de Ingreso: ")
                oalumno.Nota_Ingreso = CInt(Console.ReadLine())

                Console.Write("Confirma Alta S/N: ")
                sino = CStr(Console.ReadLine())
                If sino.ToUpper = "S" Then
                    ReDim Preserve Alumnos_dummy(Alumnos_dummy.Length)
                    Alumnos_dummy(Alumnos_dummy.Length - 1) = oalumno
                    Console.WriteLine("Alta Realizada")
                    Console.Write("")
                Else
                    Console.WriteLine("Alta No Realizada")
                    Console.Write("")
                End If

            Catch ex As Exception
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine(ex.Message)
                Console.ReadLine()
            End Try
        Loop Until sino.ToUpper = "S" Or sino.ToUpper = "N"
    End Sub
    Private Sub ListadoAlumnos()
        Try
            Console.Clear()
            Encabezado(" Listado Alumnos ")
            For Each alum In Alumnos_dummy
                Console.WriteLine()
                Console.WriteLine("Legajo: {0}", alum.Legajo)
                Console.WriteLine("Nombre: {0}", alum.Nombre)
                Console.WriteLine("N° dni: {0}", alum.DNI)
                Console.WriteLine("Domcilio: {0}", alum.Domicilio)
                Console.WriteLine("Fecha de Nacimiento: {0}", DateFormat.ShortDate & (alum.Fecha_Nacimiento))
                Console.WriteLine("Fecha Inscripcion: {0}", DateFormat.ShortDate & (alum.Fecha_Inscripcion))
                Console.WriteLine("Nota de Ingreso: {0}", alum.Nota_Ingreso)




            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub FichaAlumnos()
        Dim calumno, indice As Integer
        Dim oalumno As New Alumno
        Try
            Console.Clear()
            Encabezado(" Ficha de Alumnos ")
            Console.Write("Ingrese legajo del Alumno: ")
            calumno = CInt(Console.ReadLine())

            indice = oalumno.BuscarAlumno(calumno, Alumnos_dummy)

            If indice > -1 Then
                Console.WriteLine()
                Console.WriteLine("Legajo: {0}", Alumnos_dummy(indice).Legajo)
                Console.WriteLine("Nombre: {0}", Alumnos_dummy(indice).Nombre)
                Console.WriteLine("N° dni: {0}", Alumnos_dummy(indice).DNI)
                Console.WriteLine("Domcilio: {0}", Alumnos_dummy(indice).Domicilio)
                Console.WriteLine("Fecha de Nacimiento: {0}", DateFormat.ShortDate & (Alumnos_dummy(indice).Fecha_Nacimiento))
                Console.WriteLine("Fecha Inscripcion: {0}", DateFormat.ShortDate & (Alumnos_dummy(indice).Fecha_Inscripcion))
                Console.WriteLine("Nota de Ingreso: {0}", Alumnos_dummy(indice).Nota_Ingreso)
            Else
                Console.WriteLine("No existe el Legajo del alumno {0}", calumno)
                Console.Write("")
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
