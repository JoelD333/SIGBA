<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cerrar_CuentaE
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
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.labelMotivo = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.labelIdentificacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Location = New System.Drawing.Point(12, 226)
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancelar.TabIndex = 13
        Me.buttonCancelar.Text = "Cancelar"
        Me.buttonCancelar.UseVisualStyleBackColor = True
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Location = New System.Drawing.Point(320, 226)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.buttonAceptar.TabIndex = 12
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = True
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(58, 84)
        Me.textBox2.Multiline = True
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(277, 69)
        Me.textBox2.TabIndex = 11
        '
        'labelMotivo
        '
        Me.labelMotivo.AutoSize = True
        Me.labelMotivo.Location = New System.Drawing.Point(13, 84)
        Me.labelMotivo.Name = "labelMotivo"
        Me.labelMotivo.Size = New System.Drawing.Size(39, 13)
        Me.labelMotivo.TabIndex = 10
        Me.labelMotivo.Text = "Motivo"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(223, 13)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(112, 20)
        Me.textBox1.TabIndex = 9
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(108, 13)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(109, 21)
        Me.comboBox1.TabIndex = 8
        '
        'labelIdentificacion
        '
        Me.labelIdentificacion.AutoSize = True
        Me.labelIdentificacion.Location = New System.Drawing.Point(32, 13)
        Me.labelIdentificacion.Name = "labelIdentificacion"
        Me.labelIdentificacion.Size = New System.Drawing.Size(70, 13)
        Me.labelIdentificacion.TabIndex = 7
        Me.labelIdentificacion.Text = "Identificacion"
        '
        'Cerrar_CuentaE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 261)
        Me.Controls.Add(Me.buttonCancelar)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.labelMotivo)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.labelIdentificacion)
        Me.Name = "Cerrar_CuentaE"
        Me.Text = "Cerrar_Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonCancelar As Button
    Private WithEvents buttonAceptar As Button
    Private WithEvents textBox2 As TextBox
    Private WithEvents labelMotivo As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents labelIdentificacion As Label
End Class
