Public Class Fondo_Caja
    Private Sub Fondo_Caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Dim form As Confirmacion = New Confirmacion()
        AddHandler form.FormClosing, AddressOf FormOnClosing
        form.Show()
        Hide()
    End Sub
    Private Sub FormOnClosing(ByVal sender As Object,
                      ByVal e As FormClosingEventArgs)
        Me.Close()
    End Sub

    Private Sub TextBoxFondo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxFondo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class