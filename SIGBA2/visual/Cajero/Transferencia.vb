Public Class Transferencia
    Private Sub buttonAceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        Me.Close()
    End Sub

    Private Sub buttonCancelar_Click(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub TextBoxNroCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxNroCuenta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub Transferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textBoxNroCuenta.MaxLength = 10
    End Sub
End Class