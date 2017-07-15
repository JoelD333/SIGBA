Public Class Cliente_NoClienteE
    Private Sub buttonNoCliente_Click(sender As Object, e As EventArgs) Handles buttonNoCliente.Click
        Dim form As PersonaFisica_JuridicaE = New PersonaFisica_JuridicaE()
        form.Show()
        Me.Close()
    End Sub


End Class