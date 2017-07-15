Public Class Crear_AuditoriaG
    Private Sub TextBoxNroEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxNroEmpleado.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class