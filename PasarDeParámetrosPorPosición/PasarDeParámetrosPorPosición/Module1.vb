Module Module1
    Sub Main()
        Dim Localidad As String
        Dim Importe As Integer
        Dim DiaHoy As Date
        ' ---------------------
        Localidad = "Bell Ville"
        Importe = 15044
        DiaHoy = #2/10/2011#
        Console.WriteLine("Paso de los parámetros por posición")
        ' paso de parámetros por posición
        Prueba(Localidad, Importe, DiaHoy)
        ' ---------------------
        Localidad = "Villa María"
        Importe = 1250
        DiaHoy = #5/8/2011#
        Console.WriteLine("Paso de los parámetros por nombre")
        ' paso de parámetros por nombre
        Prueba(Cantidad:=Importe, Fecha:=DiaHoy, Ciudad:=Localidad)
        Console.ReadLine()
    End Sub
    Sub Prueba(ByVal Ciudad As String, ByVal Cantidad As Integer, ByVal Fecha As Date)
        Console.WriteLine("Valores de los parámetros")
        Console.WriteLine("Ciudad: {0} - Cantidad: {1} - Fecha: {2}", Ciudad, Cantidad,
       FormatDateTime(Fecha, DateFormat.ShortDate))
        Console.WriteLine()
    End Sub
End Module