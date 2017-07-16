<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.buttonSolicitud = New System.Windows.Forms.Button()
        Me.buttonAprobaciones = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonSolicitud
        '
        Me.buttonSolicitud.Location = New System.Drawing.Point(12, 133)
        Me.buttonSolicitud.Name = "buttonSolicitud"
        Me.buttonSolicitud.Size = New System.Drawing.Size(260, 23)
        Me.buttonSolicitud.TabIndex = 3
        Me.buttonSolicitud.Text = "Solicitud"
        Me.buttonSolicitud.UseVisualStyleBackColor = True
        '
        'buttonAprobaciones
        '
        Me.buttonAprobaciones.Location = New System.Drawing.Point(12, 104)
        Me.buttonAprobaciones.Name = "buttonAprobaciones"
        Me.buttonAprobaciones.Size = New System.Drawing.Size(260, 23)
        Me.buttonAprobaciones.TabIndex = 2
        Me.buttonAprobaciones.Text = "Aprobaciones"
        Me.buttonAprobaciones.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(13, 13)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 4
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.buttonSolicitud)
        Me.Controls.Add(Me.buttonAprobaciones)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents buttonSolicitud As Button
    Private WithEvents buttonAprobaciones As Button
    Friend WithEvents ButtonSalir As Button
End Class
