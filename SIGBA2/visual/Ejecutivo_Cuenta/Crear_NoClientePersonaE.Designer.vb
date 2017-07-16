<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_NoClientePersonaE
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
        Me.buttonAceptar = New System.Windows.Forms.Button()
        Me.buttonMenos = New System.Windows.Forms.Button()
        Me.buttonMas = New System.Windows.Forms.Button()
        Me.textBoxTelefono = New System.Windows.Forms.TextBox()
        Me.textBoxDomicilio = New System.Windows.Forms.TextBox()
        Me.textBox2Nombre = New System.Windows.Forms.TextBox()
        Me.textBox1Nombre = New System.Windows.Forms.TextBox()
        Me.listBoxTelefonos = New System.Windows.Forms.ListBox()
        Me.labelTelefono = New System.Windows.Forms.Label()
        Me.labelDomicilio = New System.Windows.Forms.Label()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.labelSegundoNombre = New System.Windows.Forms.Label()
        Me.labelPrimerNombre = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2Apellido = New System.Windows.Forms.TextBox()
        Me.TextBox1Apellido = New System.Windows.Forms.TextBox()
        Me.LabelSegundoApellido = New System.Windows.Forms.Label()
        Me.LabelPrimerApellido = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxId = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Location = New System.Drawing.Point(197, 356)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.buttonAceptar.TabIndex = 65
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = True
        '
        'buttonMenos
        '
        Me.buttonMenos.Location = New System.Drawing.Point(204, 200)
        Me.buttonMenos.Name = "buttonMenos"
        Me.buttonMenos.Size = New System.Drawing.Size(23, 23)
        Me.buttonMenos.TabIndex = 61
        Me.buttonMenos.Text = "-"
        Me.buttonMenos.UseVisualStyleBackColor = True
        '
        'buttonMas
        '
        Me.buttonMas.Location = New System.Drawing.Point(180, 200)
        Me.buttonMas.Name = "buttonMas"
        Me.buttonMas.Size = New System.Drawing.Size(23, 23)
        Me.buttonMas.TabIndex = 60
        Me.buttonMas.Text = "+"
        Me.buttonMas.UseVisualStyleBackColor = True
        '
        'textBoxTelefono
        '
        Me.textBoxTelefono.Location = New System.Drawing.Point(74, 200)
        Me.textBoxTelefono.Name = "textBoxTelefono"
        Me.textBoxTelefono.Size = New System.Drawing.Size(100, 20)
        Me.textBoxTelefono.TabIndex = 59
        '
        'textBoxDomicilio
        '
        Me.textBoxDomicilio.Location = New System.Drawing.Point(135, 158)
        Me.textBoxDomicilio.Name = "textBoxDomicilio"
        Me.textBoxDomicilio.Size = New System.Drawing.Size(100, 20)
        Me.textBoxDomicilio.TabIndex = 57
        '
        'textBox2Nombre
        '
        Me.textBox2Nombre.Location = New System.Drawing.Point(135, 54)
        Me.textBox2Nombre.Name = "textBox2Nombre"
        Me.textBox2Nombre.Size = New System.Drawing.Size(100, 20)
        Me.textBox2Nombre.TabIndex = 55
        '
        'textBox1Nombre
        '
        Me.textBox1Nombre.Location = New System.Drawing.Point(135, 28)
        Me.textBox1Nombre.Name = "textBox1Nombre"
        Me.textBox1Nombre.Size = New System.Drawing.Size(100, 20)
        Me.textBox1Nombre.TabIndex = 54
        '
        'listBoxTelefonos
        '
        Me.listBoxTelefonos.FormattingEnabled = True
        Me.listBoxTelefonos.Location = New System.Drawing.Point(74, 226)
        Me.listBoxTelefonos.Name = "listBoxTelefonos"
        Me.listBoxTelefonos.Size = New System.Drawing.Size(153, 56)
        Me.listBoxTelefonos.TabIndex = 53
        '
        'labelTelefono
        '
        Me.labelTelefono.AutoSize = True
        Me.labelTelefono.Location = New System.Drawing.Point(16, 200)
        Me.labelTelefono.Name = "labelTelefono"
        Me.labelTelefono.Size = New System.Drawing.Size(52, 13)
        Me.labelTelefono.TabIndex = 49
        Me.labelTelefono.Text = "Teléfono:"
        '
        'labelDomicilio
        '
        Me.labelDomicilio.AutoSize = True
        Me.labelDomicilio.Location = New System.Drawing.Point(50, 158)
        Me.labelDomicilio.Name = "labelDomicilio"
        Me.labelDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.labelDomicilio.TabIndex = 47
        Me.labelDomicilio.Text = "Domicilio"
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(40, 132)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(93, 13)
        Me.labelFecha.TabIndex = 46
        Me.labelFecha.Text = "Fecha Nacimiento"
        '
        'labelSegundoNombre
        '
        Me.labelSegundoNombre.AutoSize = True
        Me.labelSegundoNombre.Location = New System.Drawing.Point(39, 54)
        Me.labelSegundoNombre.Name = "labelSegundoNombre"
        Me.labelSegundoNombre.Size = New System.Drawing.Size(90, 13)
        Me.labelSegundoNombre.TabIndex = 45
        Me.labelSegundoNombre.Text = "Segundo Nombre"
        '
        'labelPrimerNombre
        '
        Me.labelPrimerNombre.AutoSize = True
        Me.labelPrimerNombre.Location = New System.Drawing.Point(53, 28)
        Me.labelPrimerNombre.Name = "labelPrimerNombre"
        Me.labelPrimerNombre.Size = New System.Drawing.Size(76, 13)
        Me.labelPrimerNombre.TabIndex = 44
        Me.labelPrimerNombre.Text = "Primer Nombre"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(135, 132)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 66
        '
        'TextBox2Apellido
        '
        Me.TextBox2Apellido.Location = New System.Drawing.Point(135, 106)
        Me.TextBox2Apellido.Name = "TextBox2Apellido"
        Me.TextBox2Apellido.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2Apellido.TabIndex = 70
        '
        'TextBox1Apellido
        '
        Me.TextBox1Apellido.Location = New System.Drawing.Point(135, 80)
        Me.TextBox1Apellido.Name = "TextBox1Apellido"
        Me.TextBox1Apellido.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1Apellido.TabIndex = 69
        '
        'LabelSegundoApellido
        '
        Me.LabelSegundoApellido.AutoSize = True
        Me.LabelSegundoApellido.Location = New System.Drawing.Point(39, 106)
        Me.LabelSegundoApellido.Name = "LabelSegundoApellido"
        Me.LabelSegundoApellido.Size = New System.Drawing.Size(90, 13)
        Me.LabelSegundoApellido.TabIndex = 68
        Me.LabelSegundoApellido.Text = "Segundo Apellido"
        '
        'LabelPrimerApellido
        '
        Me.LabelPrimerApellido.AutoSize = True
        Me.LabelPrimerApellido.Location = New System.Drawing.Point(53, 80)
        Me.LabelPrimerApellido.Name = "LabelPrimerApellido"
        Me.LabelPrimerApellido.Size = New System.Drawing.Size(76, 13)
        Me.LabelPrimerApellido.TabIndex = 67
        Me.LabelPrimerApellido.Text = "Primer Apellido"
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(171, 292)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxId.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Identificacion"
        '
        'ComboBoxId
        '
        Me.ComboBoxId.FormattingEnabled = True
        Me.ComboBoxId.Location = New System.Drawing.Point(88, 291)
        Me.ComboBoxId.Name = "ComboBoxId"
        Me.ComboBoxId.Size = New System.Drawing.Size(77, 21)
        Me.ComboBoxId.TabIndex = 73
        '
        'Crear_NoClientePersonaE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(284, 391)
        Me.Controls.Add(Me.ComboBoxId)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2Apellido)
        Me.Controls.Add(Me.TextBox1Apellido)
        Me.Controls.Add(Me.LabelSegundoApellido)
        Me.Controls.Add(Me.LabelPrimerApellido)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Controls.Add(Me.buttonMenos)
        Me.Controls.Add(Me.buttonMas)
        Me.Controls.Add(Me.textBoxTelefono)
        Me.Controls.Add(Me.textBoxDomicilio)
        Me.Controls.Add(Me.textBox2Nombre)
        Me.Controls.Add(Me.textBox1Nombre)
        Me.Controls.Add(Me.listBoxTelefonos)
        Me.Controls.Add(Me.labelTelefono)
        Me.Controls.Add(Me.labelDomicilio)
        Me.Controls.Add(Me.labelFecha)
        Me.Controls.Add(Me.labelSegundoNombre)
        Me.Controls.Add(Me.labelPrimerNombre)
        Me.Name = "Crear_NoClientePersonaE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear_NoClientePersona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonAceptar As Button
    Private WithEvents buttonMenos As Button
    Private WithEvents buttonMas As Button
    Private WithEvents textBoxTelefono As TextBox
    Private WithEvents textBoxDomicilio As TextBox
    Private WithEvents textBox2Nombre As TextBox
    Private WithEvents textBox1Nombre As TextBox
    Private WithEvents listBoxTelefonos As ListBox
    Private WithEvents labelTelefono As Label
    Private WithEvents labelDomicilio As Label
    Private WithEvents labelFecha As Label
    Private WithEvents labelSegundoNombre As Label
    Private WithEvents labelPrimerNombre As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Private WithEvents TextBox2Apellido As TextBox
    Private WithEvents TextBox1Apellido As TextBox
    Private WithEvents LabelSegundoApellido As Label
    Private WithEvents LabelPrimerApellido As Label
    Private WithEvents TextBoxId As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents ComboBoxId As ComboBox
End Class
