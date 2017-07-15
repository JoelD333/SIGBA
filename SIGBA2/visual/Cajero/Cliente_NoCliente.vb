Public Class Cliente_NoClient
    Private Sub Cliente_NoClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buttonCliente_Click(sender As Object, e As EventArgs) Handles buttonCliente.Click
        Dim form As Seleccion_Cuenta = New Seleccion_Cuenta()
        AddHandler form.FormClosing, AddressOf FormOnClosing
        form.Show()
        Hide()
    End Sub

    Private Sub buttonNoCliente_Click(sender As Object, e As EventArgs) Handles buttonNoCliente.Click
        Dim form As Menu_NoCliente = New Menu_NoCliente()
        AddHandler form.FormClosing, AddressOf FormOnClosing
        form.Show()
        Hide()
    End Sub
    Private Sub FormOnClosing(ByVal sender As Object,
                      ByVal e As FormClosingEventArgs)
        Me.Show()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Close()
    End Sub
End Class