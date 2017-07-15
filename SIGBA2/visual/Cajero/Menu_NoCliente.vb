Public Class Menu_NoCliente
    Private Sub ButtonAtras_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click
        Dim form As Cliente_NoClient = New Cliente_NoClient()
        form.Show()
        Close()
    End Sub

    Private Sub FormOnClosing(ByVal sender As Object,
                     ByVal e As FormClosingEventArgs)
        Me.Show()
    End Sub

    Private Sub buttonDeposito_Click(sender As Object, e As EventArgs) Handles buttonDeposito.Click
        Dim ventana1 As Deposito = New Deposito()
        AddHandler ventana1.FormClosing, AddressOf FormOnClosing
        ventana1.Show()
        Hide()
    End Sub

    Private Sub buttonDepositarC_Click(sender As Object, e As EventArgs) Handles buttonDepositarC.Click
        Dim ventana1 As DepositarCheque = New DepositarCheque()
        AddHandler ventana1.FormClosing, AddressOf FormOnClosing
        ventana1.Show()
        Hide()
    End Sub

    Private Sub buttonCobrarC_Click(sender As Object, e As EventArgs) Handles buttonCobrarC.Click
        Dim ventana1 As Cobrar_Cheque = New Cobrar_Cheque()
        AddHandler ventana1.FormClosing, AddressOf FormOnClosing
        ventana1.Show()
        Hide()
    End Sub
End Class