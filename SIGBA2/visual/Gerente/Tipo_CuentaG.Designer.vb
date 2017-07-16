<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo_CuentaG
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
        Me.buttonCancelar = New System.Windows.Forms.Button()
        Me.buttonAceptar = New System.Windows.Forms.Button()
        Me.labelTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonSaldo = New System.Windows.Forms.RadioButton()
        Me.labelCajaAhorro = New System.Windows.Forms.Label()
        Me.RadioButtonCorriente = New System.Windows.Forms.RadioButton()
        Me.labelCuentaCorriente = New System.Windows.Forms.Label()
        Me.RadioButtonAhorro = New System.Windows.Forms.RadioButton()
        Me.labelCuentaSueldo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonJuridica = New System.Windows.Forms.RadioButton()
        Me.LabelFisica = New System.Windows.Forms.Label()
        Me.RadioButtonFisica = New System.Windows.Forms.RadioButton()
        Me.LabelJuridica = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonCliente = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNoCliente = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Location = New System.Drawing.Point(13, 284)
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancelar.TabIndex = 40
        Me.buttonCancelar.Text = "Cancelar"
        Me.buttonCancelar.UseVisualStyleBackColor = True
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Location = New System.Drawing.Point(198, 284)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.buttonAceptar.TabIndex = 39
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = True
        '
        'labelTitulo
        '
        Me.labelTitulo.AutoSize = True
        Me.labelTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitulo.Location = New System.Drawing.Point(82, 9)
        Me.labelTitulo.Name = "labelTitulo"
        Me.labelTitulo.Size = New System.Drawing.Size(114, 16)
        Me.labelTitulo.TabIndex = 38
        Me.labelTitulo.Text = "Tipo de Cuenta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonSaldo)
        Me.GroupBox1.Controls.Add(Me.labelCajaAhorro)
        Me.GroupBox1.Controls.Add(Me.RadioButtonCorriente)
        Me.GroupBox1.Controls.Add(Me.labelCuentaCorriente)
        Me.GroupBox1.Controls.Add(Me.RadioButtonAhorro)
        Me.GroupBox1.Controls.Add(Me.labelCuentaSueldo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 84)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RadioButtonSaldo
        '
        Me.RadioButtonSaldo.AutoSize = True
        Me.RadioButtonSaldo.Location = New System.Drawing.Point(106, 65)
        Me.RadioButtonSaldo.Name = "RadioButtonSaldo"
        Me.RadioButtonSaldo.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonSaldo.TabIndex = 29
        Me.RadioButtonSaldo.TabStop = True
        Me.RadioButtonSaldo.UseVisualStyleBackColor = True
        '
        'labelCajaAhorro
        '
        Me.labelCajaAhorro.AutoSize = True
        Me.labelCajaAhorro.Location = New System.Drawing.Point(6, 16)
        Me.labelCajaAhorro.Name = "labelCajaAhorro"
        Me.labelCajaAhorro.Size = New System.Drawing.Size(95, 13)
        Me.labelCajaAhorro.TabIndex = 19
        Me.labelCajaAhorro.Text = "Caja de Ahorro:"
        '
        'RadioButtonCorriente
        '
        Me.RadioButtonCorriente.AutoSize = True
        Me.RadioButtonCorriente.Location = New System.Drawing.Point(118, 41)
        Me.RadioButtonCorriente.Name = "RadioButtonCorriente"
        Me.RadioButtonCorriente.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonCorriente.TabIndex = 28
        Me.RadioButtonCorriente.TabStop = True
        Me.RadioButtonCorriente.UseVisualStyleBackColor = True
        '
        'labelCuentaCorriente
        '
        Me.labelCuentaCorriente.AutoSize = True
        Me.labelCuentaCorriente.Location = New System.Drawing.Point(6, 41)
        Me.labelCuentaCorriente.Name = "labelCuentaCorriente"
        Me.labelCuentaCorriente.Size = New System.Drawing.Size(106, 13)
        Me.labelCuentaCorriente.TabIndex = 20
        Me.labelCuentaCorriente.Text = "Cuenta Corriente:"
        '
        'RadioButtonAhorro
        '
        Me.RadioButtonAhorro.AutoSize = True
        Me.RadioButtonAhorro.Location = New System.Drawing.Point(107, 16)
        Me.RadioButtonAhorro.Name = "RadioButtonAhorro"
        Me.RadioButtonAhorro.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonAhorro.TabIndex = 27
        Me.RadioButtonAhorro.TabStop = True
        Me.RadioButtonAhorro.UseVisualStyleBackColor = True
        '
        'labelCuentaSueldo
        '
        Me.labelCuentaSueldo.AutoSize = True
        Me.labelCuentaSueldo.Location = New System.Drawing.Point(6, 65)
        Me.labelCuentaSueldo.Name = "labelCuentaSueldo"
        Me.labelCuentaSueldo.Size = New System.Drawing.Size(94, 13)
        Me.labelCuentaSueldo.TabIndex = 21
        Me.labelCuentaSueldo.Text = "Cuenta Sueldo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButtonJuridica)
        Me.GroupBox2.Controls.Add(Me.LabelFisica)
        Me.GroupBox2.Controls.Add(Me.RadioButtonFisica)
        Me.GroupBox2.Controls.Add(Me.LabelJuridica)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(144, 69)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'RadioButtonJuridica
        '
        Me.RadioButtonJuridica.AutoSize = True
        Me.RadioButtonJuridica.Location = New System.Drawing.Point(117, 50)
        Me.RadioButtonJuridica.Name = "RadioButtonJuridica"
        Me.RadioButtonJuridica.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonJuridica.TabIndex = 35
        Me.RadioButtonJuridica.TabStop = True
        Me.RadioButtonJuridica.UseVisualStyleBackColor = True
        '
        'LabelFisica
        '
        Me.LabelFisica.AutoSize = True
        Me.LabelFisica.Location = New System.Drawing.Point(6, 25)
        Me.LabelFisica.Name = "LabelFisica"
        Me.LabelFisica.Size = New System.Drawing.Size(94, 13)
        Me.LabelFisica.TabIndex = 31
        Me.LabelFisica.Text = "Persona Fisica:"
        '
        'RadioButtonFisica
        '
        Me.RadioButtonFisica.AutoSize = True
        Me.RadioButtonFisica.Location = New System.Drawing.Point(106, 25)
        Me.RadioButtonFisica.Name = "RadioButtonFisica"
        Me.RadioButtonFisica.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonFisica.TabIndex = 34
        Me.RadioButtonFisica.TabStop = True
        Me.RadioButtonFisica.UseVisualStyleBackColor = True
        '
        'LabelJuridica
        '
        Me.LabelJuridica.AutoSize = True
        Me.LabelJuridica.Location = New System.Drawing.Point(6, 50)
        Me.LabelJuridica.Name = "LabelJuridica"
        Me.LabelJuridica.Size = New System.Drawing.Size(105, 13)
        Me.LabelJuridica.TabIndex = 32
        Me.LabelJuridica.Text = "Persona Juridica:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButtonCliente)
        Me.GroupBox3.Controls.Add(Me.RadioButtonNoCliente)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 182)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(141, 96)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'RadioButtonCliente
        '
        Me.RadioButtonCliente.AutoSize = True
        Me.RadioButtonCliente.Location = New System.Drawing.Point(58, 36)
        Me.RadioButtonCliente.Name = "RadioButtonCliente"
        Me.RadioButtonCliente.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonCliente.TabIndex = 39
        Me.RadioButtonCliente.TabStop = True
        Me.RadioButtonCliente.UseVisualStyleBackColor = True
        '
        'RadioButtonNoCliente
        '
        Me.RadioButtonNoCliente.AutoSize = True
        Me.RadioButtonNoCliente.Location = New System.Drawing.Point(82, 59)
        Me.RadioButtonNoCliente.Name = "RadioButtonNoCliente"
        Me.RadioButtonNoCliente.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonNoCliente.TabIndex = 40
        Me.RadioButtonNoCliente.TabStop = True
        Me.RadioButtonNoCliente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "No Cliente:"
        '
        'Tipo_CuentaG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(284, 336)
        Me.Controls.Add(Me.buttonCancelar)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Controls.Add(Me.labelTitulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Tipo_CuentaG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo_CuentaG"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonCancelar As Button
    Private WithEvents buttonAceptar As Button
    Private WithEvents labelTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonSaldo As RadioButton
    Private WithEvents labelCajaAhorro As Label
    Friend WithEvents RadioButtonCorriente As RadioButton
    Private WithEvents labelCuentaCorriente As Label
    Friend WithEvents RadioButtonAhorro As RadioButton
    Private WithEvents labelCuentaSueldo As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButtonJuridica As RadioButton
    Private WithEvents LabelFisica As Label
    Friend WithEvents RadioButtonFisica As RadioButton
    Private WithEvents LabelJuridica As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButtonCliente As RadioButton
    Friend WithEvents RadioButtonNoCliente As RadioButton
    Private WithEvents Label2 As Label
    Private WithEvents Label1 As Label
End Class
