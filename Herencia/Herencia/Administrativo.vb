Public Class Administrativo
    Inherits Empleado
    Public Sub EnviarCorreo(ByVal lsMensaje As String)
        Console.WriteLine("Remitente de mensaje: {0} {1}", Me.Nombre, Me.Apellidos)
        Console.WriteLine("Texto del mnesje: {0}", lsMensaje)
        Console.ReadLine()
    End Sub

End Class

