Public Class DepositarCheque
    Private Sub buttonAceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        Me.Close()
    End Sub

    Private Sub TextBoxNroCheque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxNroCheque.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class