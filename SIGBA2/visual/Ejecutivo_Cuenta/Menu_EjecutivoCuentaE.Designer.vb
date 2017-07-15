<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_EjecutivoCuentaE
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
        Me.ButtonCuentasCliente = New System.Windows.Forms.Button()
        Me.ButtonEstadoCuenta = New System.Windows.Forms.Button()
        Me.buttonChequera = New System.Windows.Forms.Button()
        Me.buttonConsultarCuenta = New System.Windows.Forms.Button()
        Me.buttonCerrarCuenta = New System.Windows.Forms.Button()
        Me.buttonCrearCuenta = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonCuentasCliente
        '
        Me.ButtonCuentasCliente.Location = New System.Drawing.Point(146, 160)
        Me.ButtonCuentasCliente.Name = "ButtonCuentasCliente"
        Me.ButtonCuentasCliente.Size = New System.Drawing.Size(126, 23)
        Me.ButtonCuentasCliente.TabIndex = 11
        Me.ButtonCuentasCliente.Text = "Cuentas Cliente"
        Me.ButtonCuentasCliente.UseVisualStyleBackColor = True
        '
        'ButtonEstadoCuenta
        '
        Me.ButtonEstadoCuenta.Location = New System.Drawing.Point(13, 160)
        Me.ButtonEstadoCuenta.Name = "ButtonEstadoCuenta"
        Me.ButtonEstadoCuenta.Size = New System.Drawing.Size(126, 23)
        Me.ButtonEstadoCuenta.TabIndex = 10
        Me.ButtonEstadoCuenta.Text = "Estado Cuenta"
        Me.ButtonEstadoCuenta.UseVisualStyleBackColor = True
        '
        'buttonChequera
        '
        Me.buttonChequera.Location = New System.Drawing.Point(146, 120)
        Me.buttonChequera.Name = "buttonChequera"
        Me.buttonChequera.Size = New System.Drawing.Size(126, 23)
        Me.buttonChequera.TabIndex = 9
        Me.buttonChequera.Text = "Chequera"
        Me.buttonChequera.UseVisualStyleBackColor = True
        '
        'buttonConsultarCuenta
        '
        Me.buttonConsultarCuenta.Location = New System.Drawing.Point(14, 120)
        Me.buttonConsultarCuenta.Name = "buttonConsultarCuenta"
        Me.buttonConsultarCuenta.Size = New System.Drawing.Size(126, 23)
        Me.buttonConsultarCuenta.TabIndex = 8
        Me.buttonConsultarCuenta.Text = "Consultar Cuenta"
        Me.buttonConsultarCuenta.UseVisualStyleBackColor = True
        '
        'buttonCerrarCuenta
        '
        Me.buttonCerrarCuenta.Location = New System.Drawing.Point(146, 77)
        Me.buttonCerrarCuenta.Name = "buttonCerrarCuenta"
        Me.buttonCerrarCuenta.Size = New System.Drawing.Size(126, 23)
        Me.buttonCerrarCuenta.TabIndex = 7
        Me.buttonCerrarCuenta.Text = "Cerrar Cuenta"
        Me.buttonCerrarCuenta.UseVisualStyleBackColor = True
        '
        'buttonCrearCuenta
        '
        Me.buttonCrearCuenta.Location = New System.Drawing.Point(13, 77)
        Me.buttonCrearCuenta.Name = "buttonCrearCuenta"
        Me.buttonCrearCuenta.Size = New System.Drawing.Size(126, 23)
        Me.buttonCrearCuenta.TabIndex = 6
        Me.buttonCrearCuenta.Text = "Crear Cuenta"
        Me.buttonCrearCuenta.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(12, 12)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(60, 23)
        Me.ButtonSalir.TabIndex = 15
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Menu_EjecutivoCuentaE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonCuentasCliente)
        Me.Controls.Add(Me.ButtonEstadoCuenta)
        Me.Controls.Add(Me.buttonChequera)
        Me.Controls.Add(Me.buttonConsultarCuenta)
        Me.Controls.Add(Me.buttonCerrarCuenta)
        Me.Controls.Add(Me.buttonCrearCuenta)
        Me.Name = "Menu_EjecutivoCuentaE"
        Me.Text = "Menu_EjecutivoCuenta"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ButtonCuentasCliente As Button
    Private WithEvents ButtonEstadoCuenta As Button
    Private WithEvents buttonChequera As Button
    Private WithEvents buttonConsultarCuenta As Button
    Private WithEvents buttonCerrarCuenta As Button
    Private WithEvents buttonCrearCuenta As Button
    Friend WithEvents ButtonSalir As Button
End Class
