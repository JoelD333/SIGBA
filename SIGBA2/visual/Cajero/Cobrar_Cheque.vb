Public Class Cobrar_Cheque
    Private Sub buttonAceptar_Click(ByVal sender As System.Object, e As System.EventArgs) Handles buttonAceptar.Click
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

    Private Sub Cobrar_Cheque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textBoxNroCheque.MaxLength = 30
    End Sub


End Class