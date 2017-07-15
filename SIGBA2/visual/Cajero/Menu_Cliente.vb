Public Class Menu_Cliente
    Private Sub ButtonAtras_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click
        Close()
    End Sub

    Private Sub buttonCalendarioPagos_Click(sender As Object, e As EventArgs) Handles buttonCalendarioPagos.Click
        Dim ventana1 As ConsultarCuenta = New ConsultarCuenta()
        AddHandler ventana1.FormClosing, AddressOf FormOnClosing
        ventana1.Show()
        Hide()
    End Sub

    Private Sub buttonCobrarCheque_Click(sender As Object, e As EventArgs) Handles buttonCobrarCheque.Click
        Dim ventana2 As Cobrar_Cheque = New Cobrar_Cheque()
        AddHandler ventana2.FormClosing, AddressOf FormOnClosing
        ventana2.Show()
        Hide()
    End Sub

    Private Sub buttonDepositarCheque_Click(sender As Object, e As EventArgs) Handles buttonDepositarCheque.Click
        Dim ventana3 As DepositarCheque = New DepositarCheque()
        AddHandler ventana3.FormClosing, AddressOf FormOnClosing
        ventana3.Show()
        Hide()
    End Sub

    Private Sub buttonDeposito_Click(sender As Object, e As EventArgs) Handles buttonDeposito.Click
        Dim ventana4 As Deposito = New Deposito()
        AddHandler ventana4.FormClosing, AddressOf FormOnClosing
        ventana4.Show()
        Hide()
    End Sub

    Private Sub buttonRetiro_Click(sender As Object, e As EventArgs) Handles buttonRetiro.Click
        Dim ventana5 As Retiro = New Retiro()
        AddHandler ventana5.FormClosing, AddressOf FormOnClosing
        ventana5.Show()
        Hide()
    End Sub

    Private Sub buttonTransferencia_Click(sender As Object, e As EventArgs) Handles buttonTransferencia.Click
        Dim ventana6 As Transferencia = New Transferencia()
        AddHandler ventana6.FormClosing, AddressOf FormOnClosing
        ventana6.Show()
        Hide()
    End Sub

    Private Sub buttonVerSaldo_Click(sender As Object, e As EventArgs) Handles buttonVerSaldo.Click
        Dim ventana7 As Ver_Saldo = New Ver_Saldo()
        AddHandler ventana7.FormClosing, AddressOf FormOnClosing
        ventana7.Show()
        Hide()
    End Sub

    Private Sub buttonConsultaCliente_Click(sender As Object, e As EventArgs) Handles buttonConsultaCliente.Click
        Dim ventana8 As ConsultarCuenta = New ConsultarCuenta()
        AddHandler ventana8.FormClosing, AddressOf FormOnClosing
        Hide()
        ventana8.Show()
    End Sub

    Private Sub Menu_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormOnClosing(ByVal sender As Object,
                      ByVal e As FormClosingEventArgs)
        Me.Show()
    End Sub
End Class