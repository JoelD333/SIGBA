Public Class Solicitud_ChequeraE
    Private Sub buttonAceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        Close()
    End Sub

    Private Sub buttonCancelar_Click(sender As Object, e As EventArgs) Handles buttonCancelar.Click
        Close()
    End Sub

    Private Sub textBoxCanal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxCanal.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Solicitud_ChequeraE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textBoxCanal.MaxLength = 3

    End Sub
End Class