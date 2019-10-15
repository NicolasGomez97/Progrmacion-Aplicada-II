Public Class Administrativo
    Inherits Empleado
    'CALCULAR LOS INCETIVOS EN BASE A HORAS
    Public Overloads Sub CalcularIncentivos(ByVal liHoras As Integer)
        Me.piIncentivos = liHoras * 15
    End Sub
End Class