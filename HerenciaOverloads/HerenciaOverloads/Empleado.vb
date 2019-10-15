Public Class Empleado
    Public piId As Integer
    Public psNombre As String
    Public piSalario As Integer
    Public piIncentivos As Double

    'calcular los incetivos en base al salario
    Public Sub CalcularIncentivos()
        Me.piIncentivos = Me.piSalario / 10
    End Sub
    Public Sub VerIncentivos()
        Console.WriteLine("Los incetivos de {0} son {1}", Me.psNombre, Me.piIncentivos)
    End Sub
End Class