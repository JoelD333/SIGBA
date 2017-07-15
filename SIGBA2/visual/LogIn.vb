Public Class LogIn
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormOnClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        Me.Show()
    End Sub

    Private Sub ButtonIniciar_Click(sender As Object, e As EventArgs) Handles ButtonIniciar.Click

        If TextBoxUsuario.Text = "Cajero" Then
            Dim form1 As Fondo_Caja = New Fondo_Caja()
            AddHandler form1.FormClosing, AddressOf FormOnClosing
            form1.Show()
            Me.Hide()
        ElseIf TextBoxUsuario.Text = "Gerente" Then
            Dim form1 As Menu_Gerente = New Menu_Gerente()
            AddHandler form1.FormClosing, AddressOf FormOnClosing
            form1.Show()
            Me.Hide()
        ElseIf TextBoxUsuario.Text = "Ejecutivo" Then
            Dim form1 As Menu_EjecutivoCuentaE = New Menu_EjecutivoCuentaE()
            AddHandler form1.FormClosing, AddressOf FormOnClosing
            form1.Show()
            Me.Hide()
        ElseIf TextBoxUsuario.Text = "Clearing" Then
            Dim form1 As Menu = New Menu()
            AddHandler form1.FormClosing, AddressOf FormOnClosing
            form1.Show()
            Me.Hide()
        ElseIf TextBoxUsuario.Text = "Riesgo" Then
            Dim form1 As Aprobaciones = New Aprobaciones()
            AddHandler form1.FormClosing, AddressOf FormOnClosing
            form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario Incorrecto")
        End If





    End Sub
End Class