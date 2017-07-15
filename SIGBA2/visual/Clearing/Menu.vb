Public Class Menu
    Private Sub FormOnClosing(ByVal sender As Object,
                     ByVal e As FormClosingEventArgs)
        Me.Show()
    End Sub

    Private Sub buttonAprobaciones_Click(sender As Object, e As EventArgs) Handles buttonAprobaciones.Click
        Dim form As Aprobar = New Aprobar()
        AddHandler form.FormClosing, AddressOf FormOnClosing
        Hide()
        form.Show()
    End Sub

    Private Sub buttonSolicitud_Click(sender As Object, e As EventArgs) Handles buttonSolicitud.Click
        Dim form As Crear_Solicitud = New Crear_Solicitud()
        AddHandler form.FormClosing, AddressOf FormOnClosing
        Hide()
        form.Show()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Close()
    End Sub
End Class