Public Class Menu_auditoriasG
    Private Sub buttonCrearAudi_Click(sender As Object, e As EventArgs) Handles buttonCrearAudi.Click
        Dim Form As Menu_auditoriasG = New Menu_auditoriasG()
        AddHandler Form.FormClosing, AddressOf FormOnClosing
        Form.Show()
        Hide()
    End Sub

    Private Sub buttonVerAudi_Click(sender As Object, e As EventArgs) Handles buttonVerAudi.Click
        Dim Form As Ver_AuditoriasG = New Ver_AuditoriasG()
        AddHandler Form.FormClosing, AddressOf FormOnClosing
        Form.Show()
        Hide()
    End Sub

    Private Sub buttonVerAudiEmpleado_Click(sender As Object, e As EventArgs) Handles buttonVerAudiEmpleado.Click
        Dim Form As Ver_AuditoriasEmpleadoG = New Ver_AuditoriasEmpleadoG()
        AddHandler Form.FormClosing, AddressOf FormOnClosing
        Form.Show()
        Hide()
    End Sub

    Private Sub FormOnClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        Me.Show()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Close()
    End Sub
End Class