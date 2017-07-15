Public Class Confirmacion
    Private Sub ButtonConfirmar_Click(sender As Object, e As EventArgs) Handles ButtonConfirmar.Click
        Dim form As Cliente_NoClient = New Cliente_NoClient()
        AddHandler form.FormClosing, AddressOf FormOnClosing
        form.Show()
        Hide()
    End Sub
    Private Sub FormOnClosing(ByVal sender As Object,
                      ByVal e As FormClosingEventArgs)
        Me.Close()
    End Sub
End Class