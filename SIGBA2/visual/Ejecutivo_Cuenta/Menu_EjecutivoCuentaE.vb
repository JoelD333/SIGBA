Public Class Menu_EjecutivoCuentaE
    Private Sub buttonCrearCuenta_Click(sender As Object, e As EventArgs) Handles buttonCrearCuenta.Click
        Dim form As Tipo_CuentaE = New Tipo_CuentaE()
        AddHandler form.FormClosing, AddressOf FormOnClosing
        Hide()
        form.Show()
    End Sub

    Private Sub FormOnClosing(ByVal sender As Object,
                     ByVal e As FormClosingEventArgs)
        Me.Show()
    End Sub

    Private Sub buttonCerrarCuenta_Click(sender As Object, e As EventArgs) Handles buttonCerrarCuenta.Click
        Dim form As Cerrar_CuentaE = New Cerrar_CuentaE()
        AddHandler form.FormClosing, AddressOf FormOnClosing
        Hide()
        form.Show()
    End Sub

    Private Sub buttonConsultarCuenta_Click(sender As Object, e As EventArgs) Handles buttonConsultarCuenta.Click
        Dim form As Consultar_CuentaE = New Consultar_CuentaE()
        AddHandler form.FormClosing, AddressOf FormOnClosing
        Hide()
        form.Show()
    End Sub

    Private Sub buttonChequera_Click(sender As Object, e As EventArgs) Handles buttonChequera.Click
        Dim form As Solicitud_ChequeraE = New Solicitud_ChequeraE()
        AddHandler form.FormClosing, AddressOf FormOnClosing
        Hide()
        form.Show()
    End Sub

    Private Sub ButtonEstadoCuenta_Click(sender As Object, e As EventArgs) Handles ButtonEstadoCuenta.Click
        Dim form As Estado_CuentaE = New Estado_CuentaE()
        AddHandler form.FormClosing, AddressOf FormOnClosing
        Hide()
        form.Show()
    End Sub

    Private Sub ButtonCuentasCliente_Click(sender As Object, e As EventArgs) Handles ButtonCuentasCliente.Click
        Dim form As Cuentas_ClienteE = New Cuentas_ClienteE()
        AddHandler form.FormClosing, AddressOf FormOnClosing
        Hide()
        form.Show()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Close()
    End Sub
End Class