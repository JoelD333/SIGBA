Public Class Crear_NoClientePersonaE
    Private Sub buttonAceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        Close()
    End Sub

    Private Sub TextBox1Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox1Nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox2Nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox1Apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1Apellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2Apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2Apellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxTelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub buttonMas_Click(sender As Object, e As EventArgs) Handles buttonMas.Click
        listBoxTelefonos.Items.Add(textBoxTelefono.Text)
        textBoxTelefono.Clear()
    End Sub

    Private Sub buttonMenos_Click(sender As Object, e As EventArgs) Handles buttonMenos.Click
        listBoxTelefonos.Items.Remove(listBoxTelefonos.SelectedItem)
    End Sub
End Class