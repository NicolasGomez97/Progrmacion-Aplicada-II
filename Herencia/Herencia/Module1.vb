Module Module1

    Sub Main()
        'Instanceamos el objeto de la clase Administrativo
        Dim oAdministrativo As New Administrativo
        'Asiganamos valores a las propiedades del oBjeto oAdministrativo que heredó
        'las propiedades Nombre y Apellidos de la clases Empleado
        oAdministrativo.Apellidos = "Juarez"
        oAdministrativo.Nombre = "Pedro"
        oAdministrativo.EnviarCorreo("Este es el mensaje")

    End Sub

End Module
