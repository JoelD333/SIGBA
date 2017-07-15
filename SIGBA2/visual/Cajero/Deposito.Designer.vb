<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deposito
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
        Me.textBoxIdentificacion = New System.Windows.Forms.TextBox()
        Me.textBoxMonto = New System.Windows.Forms.TextBox()
        Me.textBoxNroCuenta = New System.Windows.Forms.TextBox()
        Me.comboBoxDivisa = New System.Windows.Forms.ComboBox()
        Me.comboBoxIdentificacion = New System.Windows.Forms.ComboBox()
        Me.labelDivisa = New System.Windows.Forms.Label()
        Me.labelMonto = New System.Windows.Forms.Label()
        Me.labelNroCuenta = New System.Windows.Forms.Label()
        Me.labelIdentificacion = New System.Windows.Forms.Label()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBoxIdentificacion
        '
        Me.textBoxIdentificacion.Location = New System.Drawing.Point(216, 30)
        Me.textBoxIdentificacion.Name = "textBoxIdentificacion"
        Me.textBoxIdentificacion.Size = New System.Drawing.Size(100, 20)
        Me.textBoxIdentificacion.TabIndex = 17
        '
        'textBoxMonto
        '
        Me.textBoxMonto.Location = New System.Drawing.Point(58, 116)
        Me.textBoxMonto.Name = "textBoxMonto"
        Me.textBoxMonto.Size = New System.Drawing.Size(100, 20)
        Me.textBoxMonto.TabIndex = 16
        '
        'textBoxNroCuenta
        '
        Me.textBoxNroCuenta.Location = New System.Drawing.Point(91, 73)
        Me.textBoxNroCuenta.Name = "textBoxNroCuenta"
        Me.textBoxNroCuenta.Size = New System.Drawing.Size(100, 20)
        Me.textBoxNroCuenta.TabIndex = 15
        '
        'comboBoxDivisa
        '
        Me.comboBoxDivisa.FormattingEnabled = True
        Me.comboBoxDivisa.Location = New System.Drawing.Point(57, 163)
        Me.comboBoxDivisa.Name = "comboBoxDivisa"
        Me.comboBoxDivisa.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxDivisa.TabIndex = 14
        '
        'comboBoxIdentificacion
        '
        Me.comboBoxIdentificacion.FormattingEnabled = True
        Me.comboBoxIdentificacion.Items.AddRange(New Object() {"C.I.", "Pasaporte", ""})
        Me.comboBoxIdentificacion.Location = New System.Drawing.Point(89, 29)
        Me.comboBoxIdentificacion.Name = "comboBoxIdentificacion"
        Me.comboBoxIdentificacion.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxIdentificacion.TabIndex = 13
        '
        'labelDivisa
        '
        Me.labelDivisa.AutoSize = True
        Me.labelDivisa.Location = New System.Drawing.Point(12, 163)
        Me.labelDivisa.Name = "labelDivisa"
        Me.labelDivisa.Size = New System.Drawing.Size(39, 13)
        Me.labelDivisa.TabIndex = 12
        Me.labelDivisa.Text = "Divisa:"
        '
        'labelMonto
        '
        Me.labelMonto.AutoSize = True
        Me.labelMonto.Location = New System.Drawing.Point(12, 116)
        Me.labelMonto.Name = "labelMonto"
        Me.labelMonto.Size = New System.Drawing.Size(40, 13)
        Me.labelMonto.TabIndex = 11
        Me.labelMonto.Text = "Monto:"
        '
        'labelNroCuenta
        '
        Me.labelNroCuenta.AutoSize = True
        Me.labelNroCuenta.Location = New System.Drawing.Point(12, 73)
        Me.labelNroCuenta.Name = "labelNroCuenta"
        Me.labelNroCuenta.Size = New System.Drawing.Size(73, 13)
        Me.labelNroCuenta.TabIndex = 10
        Me.labelNroCuenta.Text = "Nº de cuenta:"
        '
        'labelIdentificacion
        '
        Me.labelIdentificacion.AutoSize = True
        Me.labelIdentificacion.Location = New System.Drawing.Point(12, 29)
        Me.labelIdentificacion.Name = "labelIdentificacion"
        Me.labelIdentificacion.Size = New System.Drawing.Size(70, 13)
        Me.labelIdentificacion.TabIndex = 9
        Me.labelIdentificacion.Text = "Identificación"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(117, 226)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 18
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'Deposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 261)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.textBoxIdentificacion)
        Me.Controls.Add(Me.textBoxMonto)
        Me.Controls.Add(Me.textBoxNroCuenta)
        Me.Controls.Add(Me.comboBoxDivisa)
        Me.Controls.Add(Me.comboBoxIdentificacion)
        Me.Controls.Add(Me.labelDivisa)
        Me.Controls.Add(Me.labelMonto)
        Me.Controls.Add(Me.labelNroCuenta)
        Me.Controls.Add(Me.labelIdentificacion)
        Me.Name = "Deposito"
        Me.Text = "Deposito"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBoxIdentificacion As TextBox
    Private WithEvents textBoxMonto As TextBox
    Private WithEvents textBoxNroCuenta As TextBox
    Private WithEvents comboBoxDivisa As ComboBox
    Private WithEvents comboBoxIdentificacion As ComboBox
    Private WithEvents labelDivisa As Label
    Private WithEvents labelMonto As Label
    Private WithEvents labelNroCuenta As Label
    Private WithEvents labelIdentificacion As Label
    Friend WithEvents ButtonAceptar As Button
End Class
