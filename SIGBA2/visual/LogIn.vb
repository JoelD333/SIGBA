Public Class LogIn
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormOnClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        Me.Show()
    End Sub

    Private Sub ButtonIniciar_Click(sender As Object, e As EventArgs) Handles ButtonIniciar.Click

        If ComboBoxRol.SelectedItem = "Cajero" Then
            Dim form1 As Fondo_Caja = New Fondo_Caja()
            AddHandler form1.FormClosing, AddressOf FormOnClosing
            form1.Show()
            Me.Hide()
        ElseIf ComboBoxRol.SelectedItem = "Gerente" Then
            Dim form1 As Menu_Gerente = New Menu_Gerente()
            AddHandler form1.FormClosing, AddressOf FormOnClosing
            form1.Show()
            Me.Hide()
        ElseIf ComboBoxRol.SelectedItem = "Ejecutivo de Cuenta" Then
            Dim form1 As Menu_EjecutivoCuentaE = New Menu_EjecutivoCuentaE()
            AddHandler form1.FormClosing, AddressOf FormOnClosing
            form1.Show()
            Me.Hide()
        ElseIf ComboBoxRol.SelectedItem = "Clearing" Then
            Dim form1 As Menu = New Menu()
            AddHandler form1.FormClosing, AddressOf FormOnClosing
            form1.Show()
            Me.Hide()
        ElseIf ComboBoxRol.SelectedItem = "Analisis de Riesgo" Then
            Dim form1 As Aprobaciones = New Aprobaciones()
            AddHandler form1.FormClosing, AddressOf FormOnClosing
            form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("No ha seleccionado nigun Rol")
        End If





    End Sub

    Private Sub TextBoxUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuario.TextChanged
        If TextBoxUsuario.Text = "" Then
            ComboBoxRol.Items.Clear()
        Else
            ComboBoxRol.Items.Clear()
            Dim Roles = New String() {"Cajero", "Gerente", "Clearing", "Ejecutivo de Cuenta", "Analisis de Riesgo"}
            For Each item As String In Roles
                ComboBoxRol.Items.Add(item)
            Next
        End If
    End Sub
End Class