<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_auditoriasG
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
        Me.buttonVerAudiEmpleado = New System.Windows.Forms.Button()
        Me.buttonVerAudi = New System.Windows.Forms.Button()
        Me.buttonCrearAudi = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonVerAudiEmpleado
        '
        Me.buttonVerAudiEmpleado.Location = New System.Drawing.Point(12, 148)
        Me.buttonVerAudiEmpleado.Name = "buttonVerAudiEmpleado"
        Me.buttonVerAudiEmpleado.Size = New System.Drawing.Size(260, 23)
        Me.buttonVerAudiEmpleado.TabIndex = 5
        Me.buttonVerAudiEmpleado.Text = "Ver Auditorías por empleado"
        Me.buttonVerAudiEmpleado.UseVisualStyleBackColor = True
        '
        'buttonVerAudi
        '
        Me.buttonVerAudi.Location = New System.Drawing.Point(12, 119)
        Me.buttonVerAudi.Name = "buttonVerAudi"
        Me.buttonVerAudi.Size = New System.Drawing.Size(260, 23)
        Me.buttonVerAudi.TabIndex = 4
        Me.buttonVerAudi.Text = "Ver Auditorías"
        Me.buttonVerAudi.UseVisualStyleBackColor = True
        '
        'buttonCrearAudi
        '
        Me.buttonCrearAudi.Location = New System.Drawing.Point(12, 90)
        Me.buttonCrearAudi.Name = "buttonCrearAudi"
        Me.buttonCrearAudi.Size = New System.Drawing.Size(260, 23)
        Me.buttonCrearAudi.TabIndex = 3
        Me.buttonCrearAudi.Text = "Crear Auditoría"
        Me.buttonCrearAudi.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(13, 13)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 6
        Me.ButtonSalir.Text = "<"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Menu_auditoriasG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.buttonVerAudiEmpleado)
        Me.Controls.Add(Me.buttonVerAudi)
        Me.Controls.Add(Me.buttonCrearAudi)
        Me.Name = "Menu_auditoriasG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_auditoriasG"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents buttonVerAudiEmpleado As Button
    Private WithEvents buttonVerAudi As Button
    Private WithEvents buttonCrearAudi As Button
    Friend WithEvents ButtonSalir As Button
End Class
