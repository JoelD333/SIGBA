Public Class Tipo_CuentaG
    Private Sub buttonAceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        If (RadioButtonCliente.Checked = True) And (RadioButtonFisica.Checked) = True Then
            Dim form As Crear_ClientePersonaG = New Crear_ClientePersonaG()
            AddHandler form.FormClosing, AddressOf FormOnClosing
            form.Show()
            Hide()
        ElseIf (RadioButtonNoCliente.Checked = True) And (RadioButtonFisica.Checked) = True Then
            Dim form As Crear_NoClientePersonaG = New Crear_NoClientePersonaG()
            AddHandler form.FormClosing, AddressOf FormOnClosing
            form.Show()
            Hide()

        ElseIf (RadioButtonCliente.Checked = True) And (RadioButtonJuridica.Checked) = True Then
            Dim form As Crear_ClienteEmpresaG = New Crear_ClienteEmpresaG()
            AddHandler form.FormClosing, AddressOf FormOnClosing
            form.Show()
            Hide()
        ElseIf (RadioButtonNoCliente.Checked = True) And (RadioButtonJuridica.Checked) = True Then
            Dim form As Crear_NoClienteEmpresaG = New Crear_NoClienteEmpresaG()
            AddHandler form.FormClosing, AddressOf FormOnClosing
            form.Show()
            Hide()
        End If
    End Sub

    Private Sub buttonCancelar_Click(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Close()
    End Sub

    Private Sub FormOnClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        Me.Show()
    End Sub

End Class