Public Class Crear_NoClientePersonaG
    Private Sub TextBoxNombrePrimero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxNombrePrimero.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxNombreSegundo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxNombreSegundo.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxApellidoPrimero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxApellidoPrimero.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxApellidoSegundo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxApellidoSegundo.KeyPress
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

    Private Sub buttonAceptar_Click(sender As Object, e As EventArgs) Handles buttonAceptar.Click
        Close()
    End Sub
End Class