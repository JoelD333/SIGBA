Public Class Crear_ClienteEmpresaG
    Private Sub TextBoxRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxRut.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class