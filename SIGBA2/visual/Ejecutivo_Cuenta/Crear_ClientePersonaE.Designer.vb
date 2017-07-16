<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_ClientePersonaE
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
        Me.comboBoxIdentificacion = New System.Windows.Forms.ComboBox()
        Me.buttonAceptar = New System.Windows.Forms.Button()
        Me.buttonDireccion = New System.Windows.Forms.Button()
        Me.ButtonRecibo = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.labelDireccion = New System.Windows.Forms.Label()
        Me.labelReciboSueldo = New System.Windows.Forms.Label()
        Me.labelIdentificacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'comboBoxIdentificacion
        '
        Me.comboBoxIdentificacion.FormattingEnabled = True
        Me.comboBoxIdentificacion.Location = New System.Drawing.Point(90, 38)
        Me.comboBoxIdentificacion.Name = "comboBoxIdentificacion"
        Me.comboBoxIdentificacion.Size = New System.Drawing.Size(76, 21)
        Me.comboBoxIdentificacion.TabIndex = 30
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Location = New System.Drawing.Point(197, 226)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.buttonAceptar.TabIndex = 29
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = True
        '
        'buttonDireccion
        '
        Me.buttonDireccion.Location = New System.Drawing.Point(150, 93)
        Me.buttonDireccion.Name = "buttonDireccion"
        Me.buttonDireccion.Size = New System.Drawing.Size(75, 23)
        Me.buttonDireccion.TabIndex = 28
        Me.buttonDireccion.Text = "Adjuntar"
        Me.buttonDireccion.UseVisualStyleBackColor = True
        '
        'ButtonRecibo
        '
        Me.ButtonRecibo.Location = New System.Drawing.Point(150, 67)
        Me.ButtonRecibo.Name = "ButtonRecibo"
        Me.ButtonRecibo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRecibo.TabIndex = 27
        Me.ButtonRecibo.Text = "Adjuntar"
        Me.ButtonRecibo.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(172, 38)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(100, 20)
        Me.textBox1.TabIndex = 26
        '
        'labelDireccion
        '
        Me.labelDireccion.AutoSize = True
        Me.labelDireccion.Location = New System.Drawing.Point(13, 98)
        Me.labelDireccion.Name = "labelDireccion"
        Me.labelDireccion.Size = New System.Drawing.Size(115, 13)
        Me.labelDireccion.TabIndex = 25
        Me.labelDireccion.Text = "Comprobante Domicilio"
        '
        'labelReciboSueldo
        '
        Me.labelReciboSueldo.AutoSize = True
        Me.labelReciboSueldo.Location = New System.Drawing.Point(13, 67)
        Me.labelReciboSueldo.Name = "labelReciboSueldo"
        Me.labelReciboSueldo.Size = New System.Drawing.Size(95, 13)
        Me.labelReciboSueldo.TabIndex = 24
        Me.labelReciboSueldo.Text = "Recibo de Sueldo:"
        '
        'labelIdentificacion
        '
        Me.labelIdentificacion.AutoSize = True
        Me.labelIdentificacion.Location = New System.Drawing.Point(13, 38)
        Me.labelIdentificacion.Name = "labelIdentificacion"
        Me.labelIdentificacion.Size = New System.Drawing.Size(70, 13)
        Me.labelIdentificacion.TabIndex = 23
        Me.labelIdentificacion.Text = "Identificación"
        '
        'Crear_ClientePersonaE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.comboBoxIdentificacion)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Controls.Add(Me.buttonDireccion)
        Me.Controls.Add(Me.ButtonRecibo)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.labelDireccion)
        Me.Controls.Add(Me.labelReciboSueldo)
        Me.Controls.Add(Me.labelIdentificacion)
        Me.Name = "Crear_ClientePersonaE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear_ClientePersona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents comboBoxIdentificacion As ComboBox
    Private WithEvents buttonAceptar As Button
    Private WithEvents buttonDireccion As Button
    Private WithEvents ButtonRecibo As Button
    Private WithEvents textBox1 As TextBox
    Private WithEvents labelDireccion As Label
    Private WithEvents labelReciboSueldo As Label
    Private WithEvents labelIdentificacion As Label
End Class
