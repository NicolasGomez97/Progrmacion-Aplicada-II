Module Module1

    Sub Main()
        Dim comando As New Operaciones()
        While True
            comando.Inico()
            comando.MostrarMenu_Cuentas()
            comando.MostrarOperacionesDisponibles()
        End While

    End Sub

End Module
