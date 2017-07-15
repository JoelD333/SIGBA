Public Class Crear_Solicitud
    Private Sub buttonAceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        Close()
    End Sub

    Private Sub buttonCancelar_Click(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Close()
    End Sub

    Private Sub Crear_Solicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textBoxNroCheque.MaxLength = 30
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