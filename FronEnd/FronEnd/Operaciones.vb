Imports Negocio
Public Class Operaciones

    Public CuentaCorriente_Seleccionada As Integer
    'Mantiene en memoria el índice de la cuenta
    'Corriente Seleccionada
    Public CajaDeAhorros_Seleccionada As Integer
    'Mantiene en memoria el índice de la cuenta caja
    'Ahorros Seleccionada
    Public TipoDeCuenta_Seleccionada As Integer
    'Mantiene en memoria el índice de la cuenta
    'Seleccionada

    'Array de Prueba que contiene los clientes disponibles en memoria
    'Este array representa la tabla de una base de datos de millones de clientes


    Private clientes_Dummy(5) As Cliente

    'Matengo en memoria el cliente seleccionado

    Private Cliente_Seleccionado As Cliente
    Public Sub Inicio()
        Console.Clear()
        Console.WriteLine("*************** Sistema de Cuentas Bancarias *******************")

        Dim validoOK = False

        While Not validoOK
            Dim dni As Integer
            Dim pin As Integer

            Try
                Console.WriteLine("Por favor ingrese su DNI: ")
                dni = CInt(Console.ReadLine())
                Console.WriteLine("Ingrese el PIN: ")
                pin = CInt(Console.ReadLine())
            Catch ex As Exception
                MostrarError(ex)
            End Try
        End While
    End Sub

    Private Sub ValidarCliente(ByVal dni As String, ByVal pin As Integer)
        For Each cli In clientes_Dummy
            If cli.ValidarCliente(dni, pin) Then
                Cliente_Seleccionado = cli
                Console.Clear()
                Console.WriteLine("*************************************************")
                Console.WriteLine("Bienvenido{0}", Cliente_Seleccionado.Nombre)
                Console.WriteLine("************************************************")
                Return
            End If
        Next
        Throw New Exception("Error de DNI y/o PIN. No se encontaron clientes con esa combinanción.")

    End Sub

    Public Sub MostrarMenu_cuentas()
        Dim continua = False

        While Not continua
            Try
                Console.WriteLine("___________________________________________________")
                Console.WriteLine("Seleccione el tipo de Cuenta con El que desea operar: ")
                Console.WriteLine("1- Caja de Ahorros")
                Console.WriteLine("2- Cuenta Corriente")
                Console.WriteLine("99- Cambiar PIN")

                Dim tipoCuenta = CInt(Console.ReadLine())

                If tipoCuenta <> 1 And tipoCuenta <> 2 And tipoCuenta <> 99 Then
                    Throw Exception("Elija una opción Valida")
                End If

                If tipoCuenta = 99 Then
                    'Realizo todos los pasos para cambiar el PIN
                    CambioDePIN()
                End If

                Console.WriteLine("______________________________________________________________________")
                Console.WriteLine("")
                If tipoCuenta = 1 Then
                    Console.WriteLine(" CAJAS DE AHORROS: ")
                    If (Cliente_Seleccionado.CajasDeAhorros.Length = 0) Then
                        Throw New Exception("No posee ninguna cuenta caja de Ahorros.Vuelva A intentarlo")
                    Else

                        For i As Integer = 0 To Cliente_Seleccionado.CajasDeAhorros.Length - 1
                            Console.WriteLine(i & "-Cuenta Número" & Cliente_Seleccionado.CajasDeAhorros(i).Numero)
                        Next
                        TipoDeCuenta_Seleccionada = tipoCuenta
                        CajaDeAhorros_Seleccionada = CInt(Console.ReadLine)
                        If CajaDeAhorros_Seleccionada < 0 Or CajaDeAhorros_Seleccionada > Cliente_Seleccionado.CajasDeAhorros.Length - 1 Then
                            Throw New
                            Exception("La Opción seleccionada no es correcta.")
                        End If
                        continua = True
                        End If
                    If tipoCuenta = 2 Then
                        Console.WriteLine("CUENTAS CORRIENTES: ")
                        If (Cliente_Seleccionado.CuentaCorriente.Lenght = 0) Then
                            Throw New Exception("No posee ninguna Cuenta Corrriente. Vuelva A interntarlo")
                        Else
                            For i As Integer = To Cliente_Seleccionado.CuentaCorriente.Length -1 
                                Console.WriteLine(i & "-Cuenta Número" & Cliente_Seleccionado.CuentaCorriente(i).Numero)
                            Next
                            TipoDeCuenta_Seleccionada = tipoCuenta
                            CuentaCorriente_Seleccionada = CInt(Console.ReadLine())
                            If CuentaCorriente_Seleccionada < 0 Or CuentaCorriente_Seleccionada > Cliente_Seleccionado.CuentaCorriente.Length - 1 Then
                                Throw New
                                Exception("La opción seleccionada no es correcta.")
                            End If
                            continua = True
                        End If
                    End If
                End If

            Catch ex As Exception
                MostrarError(ex)
            End Try
        End While
    End Sub

    Public Sub MostrarOperacionesDisponibles()
        If TipoDeCuenta_Seleccionada = 1 Then
            OperacionesDeCajaDeAhorro()
        Else
            OperacionesDeCuentaCorriente()
        End If
    End Sub
    Private Sub OperacinesDeCajaDeAhorro()
        Dim opcion = 0
        While opcion <> 99
            Try
                Console.Clear()
                Console.WriteLine("============================================================")
                Console.WriteLine("************************************************************")
                Console.WriteLine("Usted ha seleccionado la cuenta caja de ahorros N°: " & Cliente_Seleccionado.CajasDeAhorros(CuentaCorriente_Seleccionada).Numero)
                Console.WriteLine("*************************************************************")
                Console.WriteLine("======================Elija una operación====================")
                Console.WriteLine("1- Ver Saldo")
                Console.WriteLine("2- Depósito en Efectivo")
                Console.WriteLine("3- Extracción de Efectivo")
                Console.WriteLine("99- Salir")
                opcion = CInt(Console.ReadLine())
                Select Case opcion
                    Case 1
                        MostrarSaldo(Cliente_Seleccionado.CajasDeAhorros(CajaDeAhorros_Seleccionada))
                    Case 2
                        RealizarDeposito(Cliente_Seleccionado.CajasDeAhorros(CajaDeAhorros_Seleccionada))
                    Case 3
                        RealizarExtraccion(Cliente_Seleccionado.CajasDeAhorros(CajaDeAhorros_Seleccionada))
                    Case 99
                        Console.WriteLine("************ Gracias por usar el sistema ********************")
                    Case Else
                        Throw New Exception("No es  una opción Valida. Inténtelo nuevamente")
                End Select

                Console.WriteLine("..................Precione Una Tecla Para Continuar..............")
                Console.ReadKey()
            Catch ex As Exception
                MostrarError(ex)

                Console.WriteLine("..................Precione Una Tecla Para Continuar..............")
                Console.ReadKey()
            End Try
        End While
    End Sub

    Private Sub OperacionesDeCuentaCorriente()
        Dim opcion = 0
        While opcion <> 99
            Try
                Console.Clear()

Console.WriteLine("=========================================================")

Console.WriteLine("*********************************************************")
 Console.WriteLine("Usted haseleccionado la Cuenta Corriente N°: " & Cliente_Seleccionado.CuentasCorrientes(CuentaCorriente_Seleccionada).Numero)

Console.WriteLine("*********************************************************")

                Console.WriteLine("=================== Elija una peración =================")
                Console.WriteLine("1- Ver Saldo")
                Console.WriteLine("2- Depósito en Efectivo(")")
                Console.WriteLine("3- Extracción de Efectivo")
                Console.WriteLine("99- Salir")
                opcion = CInt(Console.ReadLine())
                Select Case opcion
                    Case 1

                        MostrarSaldo(Cliente_Seleccionado.CuentasCorrientes(CuentaCorriente_Seleccionada))
                    Case 2

                        RealizarDeposito(Cliente_Seleccionado.CuentasCorrientes(CuentaCorriente_Seleccionada))
                    Case 3

                        RealizarExtraccion(Cliente_Seleccionado.CuentasCorrientes(CuentaCorriente_Seleccionada))
                    Case 99

                        Console.WriteLine("************ Gracias por usar el sistema ********************")
                    Case Else
                        Throw New Exception("No es una opción Valida. Inténtelo nuevamente")
                End Select

                Console.WriteLine("..................Precione Una Tecla Para Continuar..............")
                Console.ReadKey()
            Catch ex As Exception
                MostrarError(ex)

                Console.WriteLine("..................Precione Una Tecla Para Continuar..............")
                Console.ReadKey()
            End Try
        End While
    End Sub
    Private Sub MostrarError(ByVal _exception As Exception)

        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!")
        Console.WriteLine("Error: " & Exception.Message)

        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!")
    End Sub
    Private Sub MostrarSaldo(ByVal cuentaCorriente As CuentaCorriente)

        Console.WriteLine("..............................................")
        Console.WriteLine("Su saldo actual es: $" & CuentaCorriente.Saldo)

        Console.WriteLine("..............................................")
    End Sub
    Private Sub MostrarSaldo(ByVal cajaDeAhorro As CajaDeAhorro)

        Console.WriteLine("..............................................")
        Console.WriteLine("Su saldo actual es: $" & cajaDeAhorro.Saldo)

        Console.WriteLine("..............................................")
    End Sub
    Private Sub RealizarExtraccion(ByVal cuentaCorriente As CuentaCorriente)

        Console.WriteLine("............EXTRACCIÓN......................")
        Console.WriteLine("Ingrese el monto quedesea extraer: ")
        Dim monto = CDbl(Console.ReadLine())
        CuentaCorriente.ExtraerDinero(monto)
        Console.WriteLine("EXTRACCIÓN EXITOSA.Retire el dinero.")

        Console.WriteLine("...........................................")
    End Sub
    Private Sub RealizarExtraccion(ByVal cajaDeAhorro As CajaDeAhorro)

        Console.WriteLine("............EXTRACCIÓN......................")
        Console.WriteLine("Ingrese el monto quedesea extraer: ")
        Dim monto = CDbl(Console.ReadLine())
        cajaDeAhorro.ExtraerDinero(monto)
        Console.WriteLine("EXTRACCIÓN EXITOSA.Retire el dinero.")

        Console.WriteLine("...........................................")
    End Sub
    Private Sub RealizarDeposito(ByVal cuentaCorriente As CuentaCorriente)

        Console.WriteLine("............DEPÓSITO.....................")
        Console.WriteLine("Ingrese el monto quedesea depositar: ")
        Dim monto = CDbl(Console.ReadLine())
        CuentaCorriente.DepositarDinero(monto)
        Console.WriteLine("TRANSACCIÓN EXITOSA.Compruebe su saldo.")

        Console.WriteLine("...........................................")
    End Sub
    Private Sub RealizarDeposito(ByVal cajaDeAhorro As CajaDeAhorro)

        Console.WriteLine("............DEPÓSITO.....................")
        Console.WriteLine("Ingrese el monto quedesea depositar: ")
        Dim monto = CDbl(Console.ReadLine())
        cajaDeAhorro.DepositarDinero(monto)
        Console.WriteLine("TRANSACCIÓN EXITOSA.Compruebe su saldo.")

        Console.WriteLine("...........................................")
    End Sub

    Public Sub New()

        clientes_Dummy(0) = New Cliente(1111, "Juan Perez", "11111111", 1234)
        clientes_Dummy(1) = New Cliente(2222, "Ramón Lopez", "22222222", 1234)
        clientes_Dummy(2) = New Cliente(3333, "Pedro Martinez", "33333333", 1234)
        clientes_Dummy(3) = New Cliente(4444, "Susana Sosa", "44444444", 1234)
        clientes_Dummy(4) = New Cliente(5555, "Julieta Florez", "55555555", 1234)
        clientes_Dummy(5) = New Cliente(6666, "Juan Gomez", "66666666", 1234)

        clientes_Dummy(0).CajasDeAhorros = New CajaDeAhorro() {New CajaDeAhorro(3234, 6500), New CajaDeAhorro(5367, 452)}
        clientes_Dummy(0).CuentasCorrientes = New CuentaCorriente() {New CuentaCorriente(6675, 18023)}

        clientes_Dummy(1).CajasDeAhorros = New CajaDeAhorro() {New CajaDeAhorro(4256, 7800), New CajaDeAhorro(9862, 98)}
        clientes_Dummy(1).CuentasCorrientes = New CuentaCorriente() {New CuentaCorriente(10411, 45), New CuentaCorriente(14142, 1050)}

        clientes_Dummy(2).CajasDeAhorros = New CajaDeAhorro() {New CajaDeAhorro(4256, 7800), New CajaDeAhorro(12400, 55232), New CajaDeAhorro(12402, 0), New CajaDeAhorro(12403, 0)}
        clientes_Dummy(2).CuentasCorrientes = New CuentaCorriente() {New CuentaCorriente(12409, 140520)}

        clientes_Dummy(3).CajasDeAhorros = New CajaDeAhorro() {New CajaDeAhorro(67213, 5800)}
        clientes_Dummy(3).CuentasCorrientes = New CuentaCorriente() {}

        clientes_Dummy(4).CajasDeAhorros = New CajaDeAhorro() {}
        clientes_Dummy(4).CuentasCorrientes = New CuentaCorriente() {New CuentaCorriente(8532, 105)}

        clientes_Dummy(5).CajasDeAhorros = New CajaDeAhorro() {}
        clientes_Dummy(5).CuentasCorrientes = New CuentaCorriente() {New CuentaCorriente(15732, 15850)}


    End Sub

    Sub Inico()
        Throw New NotImplementedException
    End Sub

End Class
