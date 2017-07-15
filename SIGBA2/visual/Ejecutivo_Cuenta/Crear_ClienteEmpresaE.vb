Public Class Crear_ClienteEmpresaE
    Private Sub buttonAceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        Close()
    End Sub

    Private Sub TextBoxRUT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxRUT.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


End Class