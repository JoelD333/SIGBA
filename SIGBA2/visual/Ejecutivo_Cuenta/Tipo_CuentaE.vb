Public Class Tipo_CuentaE
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAhorro.CheckedChanged

    End Sub

    Private Sub buttonAceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        If (RadioButtonCliente.Checked = True) And (RadioButtonFisica.Checked) = True Then
            Dim form As Crear_ClientePersonaE = New Crear_ClientePersonaE()
            AddHandler form.FormClosing, AddressOf FormOnClosing
            form.Show()
            Hide()
        ElseIf (RadioButtonNoCliente.Checked = True) And (RadioButtonFisica.Checked) = True Then
            Dim form As Crear_NoClientePersonaE = New Crear_NoClientePersonaE()
            AddHandler form.FormClosing, AddressOf FormOnClosing
            form.Show()
            Hide()

        ElseIf (RadioButtonCliente.Checked = True) And (RadioButtonJuridica.Checked) = True Then
            Dim form As Crear_ClienteEmpresaE = New Crear_ClienteEmpresaE()
            AddHandler form.FormClosing, AddressOf FormOnClosing
            form.Show()
            Hide()
        ElseIf (RadioButtonNoCliente.Checked = True) And (RadioButtonJuridica.Checked) = True Then
            Dim form As Crear_NoClienteEmpresaE = New Crear_NoClienteEmpresaE()
            AddHandler form.FormClosing, AddressOf FormOnClosing
            form.Show()
            Hide()
        End If
    End Sub

    Private Sub FormOnClosing(ByVal sender As Object,
                    ByVal e As FormClosingEventArgs)
        Me.Close()
    End Sub
End Class