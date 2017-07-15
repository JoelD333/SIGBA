Public Class Fondo_Caja
    Private Sub Fondo_Caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Dim form As Confirmacion = New Confirmacion()
        AddHandler form.FormClosing, AddressOf FormOnClosing
        form.Show()
        Hide()
    End Sub
    Private Sub FormOnClosing(ByVal sender As Object,
                      ByVal e As FormClosingEventArgs)
        Me.Close()
    End Sub

End Class