<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Gerente
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
        Me.buttonCuentas_Clientes = New System.Windows.Forms.Button()
        Me.buttonUsuariosActivos = New System.Windows.Forms.Button()
        Me.buttonEstadoCuenta = New System.Windows.Forms.Button()
        Me.buttonChequeras = New System.Windows.Forms.Button()
        Me.buttonCrearCuenta = New System.Windows.Forms.Button()
        Me.buttonAuditorias = New System.Windows.Forms.Button()
        Me.buttonNOTIFICACIONES = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonCuentas_Clientes
        '
        Me.buttonCuentas_Clientes.Location = New System.Drawing.Point(144, 155)
        Me.buttonCuentas_Clientes.Name = "buttonCuentas_Clientes"
        Me.buttonCuentas_Clientes.Size = New System.Drawing.Size(110, 23)
        Me.buttonCuentas_Clientes.TabIndex = 13
        Me.buttonCuentas_Clientes.Text = "Cuentas/Clientes"
        Me.buttonCuentas_Clientes.UseVisualStyleBackColor = True
        '
        'buttonUsuariosActivos
        '
        Me.buttonUsuariosActivos.Location = New System.Drawing.Point(144, 126)
        Me.buttonUsuariosActivos.Name = "buttonUsuariosActivos"
        Me.buttonUsuariosActivos.Size = New System.Drawing.Size(110, 23)
        Me.buttonUsuariosActivos.TabIndex = 12
        Me.buttonUsuariosActivos.Text = "Usuarios Activos"
        Me.buttonUsuariosActivos.UseVisualStyleBackColor = True
        '
        'buttonEstadoCuenta
        '
        Me.buttonEstadoCuenta.Location = New System.Drawing.Point(144, 97)
        Me.buttonEstadoCuenta.Name = "buttonEstadoCuenta"
        Me.buttonEstadoCuenta.Size = New System.Drawing.Size(110, 23)
        Me.buttonEstadoCuenta.TabIndex = 11
        Me.buttonEstadoCuenta.Text = "Estado cuenta"
        Me.buttonEstadoCuenta.UseVisualStyleBackColor = True
        '
        'buttonChequeras
        '
        Me.buttonChequeras.Location = New System.Drawing.Point(35, 155)
        Me.buttonChequeras.Name = "buttonChequeras"
        Me.buttonChequeras.Size = New System.Drawing.Size(103, 23)
        Me.buttonChequeras.TabIndex = 10
        Me.buttonChequeras.Text = "Chequeras"
        Me.buttonChequeras.UseVisualStyleBackColor = True
        '
        'buttonCrearCuenta
        '
        Me.buttonCrearCuenta.Location = New System.Drawing.Point(35, 126)
        Me.buttonCrearCuenta.Name = "buttonCrearCuenta"
        Me.buttonCrearCuenta.Size = New System.Drawing.Size(103, 23)
        Me.buttonCrearCuenta.TabIndex = 9
        Me.buttonCrearCuenta.Text = "Crear Cuenta"
        Me.buttonCrearCuenta.UseVisualStyleBackColor = True
        '
        'buttonAuditorias
        '
        Me.buttonAuditorias.Location = New System.Drawing.Point(35, 97)
        Me.buttonAuditorias.Name = "buttonAuditorias"
        Me.buttonAuditorias.Size = New System.Drawing.Size(103, 23)
        Me.buttonAuditorias.TabIndex = 8
        Me.buttonAuditorias.Text = "Auditorías"
        Me.buttonAuditorias.UseVisualStyleBackColor = True
        '
        'buttonNOTIFICACIONES
        '
        Me.buttonNOTIFICACIONES.Location = New System.Drawing.Point(162, 12)
        Me.buttonNOTIFICACIONES.Name = "buttonNOTIFICACIONES"
        Me.buttonNOTIFICACIONES.Size = New System.Drawing.Size(110, 23)
        Me.buttonNOTIFICACIONES.TabIndex = 7
        Me.buttonNOTIFICACIONES.Text = "NOTIFICACIONES"
        Me.buttonNOTIFICACIONES.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(13, 13)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(60, 23)
        Me.ButtonSalir.TabIndex = 14
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Menu_Gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 226)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.buttonCuentas_Clientes)
        Me.Controls.Add(Me.buttonUsuariosActivos)
        Me.Controls.Add(Me.buttonEstadoCuenta)
        Me.Controls.Add(Me.buttonChequeras)
        Me.Controls.Add(Me.buttonCrearCuenta)
        Me.Controls.Add(Me.buttonAuditorias)
        Me.Controls.Add(Me.buttonNOTIFICACIONES)
        Me.Name = "Menu_Gerente"
        Me.Text = "Menu_Gerente"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents buttonCuentas_Clientes As Button
    Private WithEvents buttonUsuariosActivos As Button
    Private WithEvents buttonEstadoCuenta As Button
    Private WithEvents buttonChequeras As Button
    Private WithEvents buttonCrearCuenta As Button
    Private WithEvents buttonAuditorias As Button
    Private WithEvents buttonNOTIFICACIONES As Button
    Friend WithEvents ButtonSalir As Button
End Class
