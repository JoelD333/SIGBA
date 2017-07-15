Public Class Seleccion_Cuenta
    Private Sub Seleccion_CuentaE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buttonCancelar_Click(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Dim form As Cliente_NoClient = New Cliente_NoClient()
        form.Show()
        Close()
    End Sub

    Private Sub buttonAceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        Dim form As Menu_Cliente = New Menu_Cliente()
        AddHandler form.FormClosing, AddressOf FormOnClosing
        form.Show()
        Hide()
    End Sub
    Private Sub FormOnClosing(ByVal sender As Object,
                      ByVal e As FormClosingEventArgs)
        Me.Close()
    End Sub
End Class