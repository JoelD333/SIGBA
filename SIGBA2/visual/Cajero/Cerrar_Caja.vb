Public Class Cerrar_Caja
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelEsperado.Click

    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Close()
    End Sub

    Private Sub TextBoxSaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSaldo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxSaldo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSaldo.TextChanged

    End Sub
End Class