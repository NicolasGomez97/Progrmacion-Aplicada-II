Module Module1

    Sub Main()
        Dim opersona As New Personas
        Dim opcion As Integer
        Do
            Try
                Console.Write("Ingrese Nombre: ")
                opersona.nombre = Console.ReadLine()
                Console.Write("Ingrese edad: ")
                opersona.edad = CInt(Console.ReadLine())
                Console.Write("Ingrese fecha de alta: ")
                opersona.fechalta = CDate(Console.ReadLine())
                Console.WriteLine()
                Console.WriteLine("**** Opciones de impresión ****")
                Console.WriteLine("1 - Completo")
                Console.WriteLine("2 - Nombre")
                Do
                    Console.WriteLine()
                    Console.Write("Opcion: ")
                    opcion = CInt(Console.ReadLine())
                    If opcion < 1 Or opcion > 2 Then
                        Console.WriteLine()
                        Console.WriteLine("Debe ingresar 1 ó 2")
                    End If
                Loop Until opcion = 1 Or opcion = 2
                opersona.imprimir()
                If opcion = 1 Then
                    opersona.imprimir(opersona.nombre, opersona.edad, opersona.fechalta)
                ElseIf opcion = 2 Then
                    opersona.imprimir(opersona.nombre)
                End If
                Console.ReadLine()
                Console.WriteLine()
                Console.WriteLine("**** Continua? ****")
                Console.WriteLine("1 - Si")
                Console.WriteLine("2 - Salir")
                Do
                    Console.WriteLine()
                    Console.Write("Opcion: ")
                    opcion = CInt(Console.ReadLine())
                    If opcion < 1 Or opcion > 2 Then
                        Console.WriteLine()
                        Console.WriteLine("Debe ingresar 1 ó 2")
                    End If
                Loop Until opcion = 1 Or opcion = 2
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

        Loop Until opcion = 2
    End Sub

End Module

Public Class Personas
    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Private _edad As Integer
    Public Property edad() As Integer
        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)
            If value < 22 Then
                Throw New Exception("Tiene que ser mayor de 21 años")
            Else
                _edad = value
            End If
            _edad = value
        End Set
    End Property
    Private _fechalta As Date
    Public Property fechalta() As Date
        Get
            Return _fechalta
        End Get
        Set(ByVal value As Date)
            _fechalta = value
        End Set
    End Property
    Public Sub imprimir()
        Console.WriteLine()
        Console.WriteLine("***** Impresion de datos *****")
        Console.WriteLine()
    End Sub
    Public Sub imprimir(ByVal pnombre As String, ByVal pedad As Integer, ByVal pfecha As Date)
        Console.WriteLine("Nombre: {0}", pnombre)
        Console.WriteLine("Edad: {0}", edad)
        Console.WriteLine("fecha de alta: {0}", FormatDateTime(fechalta, DateFormat.ShortDate))
    End Sub
    Public Sub imprimir(ByVal pnombre As String)
        Console.WriteLine("Nombre: {0}", pnombre)
    End Sub
End Class