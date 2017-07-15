Public Class Menu_Gerente
    Private Sub buttonAuditorias_Click(sender As Object, e As EventArgs) Handles buttonAuditorias.Click
        Dim Form As Menu_auditoriasG = New Menu_auditoriasG()
        AddHandler Form.FormClosing, AddressOf FormOnClosing
        Form.Show()
        Hide()
    End Sub

    Private Sub FormOnClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        Me.Show()
    End Sub

    Private Sub buttonEstadoCuenta_Click(sender As Object, e As EventArgs) Handles buttonEstadoCuenta.Click
        Dim Form As Estado_CuentaG = New Estado_CuentaG()
        AddHandler Form.FormClosing, AddressOf FormOnClosing
        Form.Show()
        Hide()
    End Sub

    Private Sub buttonCrearCuenta_Click(sender As Object, e As EventArgs) Handles buttonCrearCuenta.Click
        Dim Form As Tipo_CuentaG = New Tipo_CuentaG()
        AddHandler Form.FormClosing, AddressOf FormOnClosing
        Form.Show()
        Hide()
    End Sub

    Private Sub buttonUsuariosActivos_Click(sender As Object, e As EventArgs) Handles buttonUsuariosActivos.Click
        Dim Form As Usuarios_ActivosG = New Usuarios_ActivosG()
        AddHandler Form.FormClosing, AddressOf FormOnClosing
        Form.Show()
        Hide()
    End Sub

    Private Sub buttonChequeras_Click(sender As Object, e As EventArgs) Handles buttonChequeras.Click
        Dim Form As Solicitud_ChequeraG = New Solicitud_ChequeraG()
        AddHandler Form.FormClosing, AddressOf FormOnClosing
        Form.Show()
        Hide()
    End Sub

    Private Sub buttonCuentas_Clientes_Click(sender As Object, e As EventArgs) Handles buttonCuentas_Clientes.Click
        Dim Form As Cuentas_ClienteG = New Cuentas_ClienteG()
        AddHandler Form.FormClosing, AddressOf FormOnClosing
        Form.Show()
        Hide()
    End Sub

    Private Sub Menu_Gerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Close()
    End Sub
End Class