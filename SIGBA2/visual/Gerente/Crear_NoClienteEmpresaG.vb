Public Class Crear_NoClienteEmpresaG
    Private Sub TextBoxNombreReal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxNombreReal.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxNombreComercial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxNombreComercial.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxCodigoPostal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxCodigoPostal.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBoxRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxRut.KeyPress
        If Char.IsNumber(e.KeyChar) Then
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
    Private Sub TextBoxFax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxFax.KeyPress
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