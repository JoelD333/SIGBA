<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transferencia
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
        Me.textBoxNroCuenta = New System.Windows.Forms.TextBox()
        Me.comboBoxPais = New System.Windows.Forms.ComboBox()
        Me.comboBoxSucursal = New System.Windows.Forms.ComboBox()
        Me.comboBoxDivisa = New System.Windows.Forms.ComboBox()
        Me.comboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.textBoxMonto = New System.Windows.Forms.TextBox()
        Me.labelNroCuenta = New System.Windows.Forms.Label()
        Me.labelPais = New System.Windows.Forms.Label()
        Me.labelSucursal = New System.Windows.Forms.Label()
        Me.labelDivisa = New System.Windows.Forms.Label()
        Me.labelMonto = New System.Windows.Forms.Label()
        Me.labelTipo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Location = New System.Drawing.Point(12, 226)
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancelar.TabIndex = 27
        Me.buttonCancelar.Text = "Cancelar"
        Me.buttonCancelar.UseVisualStyleBackColor = True
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Location = New System.Drawing.Point(197, 226)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.buttonAceptar.TabIndex = 26
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = True
        '
        'textBoxNroCuenta
        '
        Me.textBoxNroCuenta.Location = New System.Drawing.Point(151, 174)
        Me.textBoxNroCuenta.Name = "textBoxNroCuenta"
        Me.textBoxNroCuenta.Size = New System.Drawing.Size(131, 20)
        Me.textBoxNroCuenta.TabIndex = 25
        '
        'comboBoxPais
        '
        Me.comboBoxPais.FormattingEnabled = True
        Me.comboBoxPais.Location = New System.Drawing.Point(48, 146)
        Me.comboBoxPais.Name = "comboBoxPais"
        Me.comboBoxPais.Size = New System.Drawing.Size(140, 21)
        Me.comboBoxPais.TabIndex = 24
        '
        'comboBoxSucursal
        '
        Me.comboBoxSucursal.FormattingEnabled = True
        Me.comboBoxSucursal.Location = New System.Drawing.Point(67, 114)
        Me.comboBoxSucursal.Name = "comboBoxSucursal"
        Me.comboBoxSucursal.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxSucursal.TabIndex = 23
        '
        'comboBoxDivisa
        '
        Me.comboBoxDivisa.FormattingEnabled = True
        Me.comboBoxDivisa.Location = New System.Drawing.Point(55, 87)
        Me.comboBoxDivisa.Name = "comboBoxDivisa"
        Me.comboBoxDivisa.Size = New System.Drawing.Size(133, 21)
        Me.comboBoxDivisa.TabIndex = 22
        '
        'comboBoxTipo
        '
        Me.comboBoxTipo.FormattingEnabled = True
        Me.comboBoxTipo.Location = New System.Drawing.Point(48, 31)
        Me.comboBoxTipo.Name = "comboBoxTipo"
        Me.comboBoxTipo.Size = New System.Drawing.Size(140, 21)
        Me.comboBoxTipo.TabIndex = 21
        '
        'textBoxMonto
        '
        Me.textBoxMonto.Location = New System.Drawing.Point(57, 60)
        Me.textBoxMonto.Name = "textBoxMonto"
        Me.textBoxMonto.Size = New System.Drawing.Size(131, 20)
        Me.textBoxMonto.TabIndex = 20
        '
        'labelNroCuenta
        '
        Me.labelNroCuenta.AutoSize = True
        Me.labelNroCuenta.Location = New System.Drawing.Point(13, 174)
        Me.labelNroCuenta.Name = "labelNroCuenta"
        Me.labelNroCuenta.Size = New System.Drawing.Size(135, 13)
        Me.labelNroCuenta.TabIndex = 19
        Me.labelNroCuenta.Text = "Número cuenta a transferir:"
        '
        'labelPais
        '
        Me.labelPais.AutoSize = True
        Me.labelPais.Location = New System.Drawing.Point(13, 146)
        Me.labelPais.Name = "labelPais"
        Me.labelPais.Size = New System.Drawing.Size(29, 13)
        Me.labelPais.TabIndex = 18
        Me.labelPais.Text = "País"
        '
        'labelSucursal
        '
        Me.labelSucursal.AutoSize = True
        Me.labelSucursal.Location = New System.Drawing.Point(13, 114)
        Me.labelSucursal.Name = "labelSucursal"
        Me.labelSucursal.Size = New System.Drawing.Size(48, 13)
        Me.labelSucursal.TabIndex = 17
        Me.labelSucursal.Text = "Sucursal"
        '
        'labelDivisa
        '
        Me.labelDivisa.AutoSize = True
        Me.labelDivisa.Location = New System.Drawing.Point(13, 87)
        Me.labelDivisa.Name = "labelDivisa"
        Me.labelDivisa.Size = New System.Drawing.Size(36, 13)
        Me.labelDivisa.TabIndex = 16
        Me.labelDivisa.Text = "Divisa"
        '
        'labelMonto
        '
        Me.labelMonto.AutoSize = True
        Me.labelMonto.Location = New System.Drawing.Point(13, 60)
        Me.labelMonto.Name = "labelMonto"
        Me.labelMonto.Size = New System.Drawing.Size(37, 13)
        Me.labelMonto.TabIndex = 15
        Me.labelMonto.Text = "Monto"
        '
        'labelTipo
        '
        Me.labelTipo.AutoSize = True
        Me.labelTipo.Location = New System.Drawing.Point(13, 31)
        Me.labelTipo.Name = "labelTipo"
        Me.labelTipo.Size = New System.Drawing.Size(28, 13)
        Me.labelTipo.TabIndex = 14
        Me.labelTipo.Text = "Tipo"
        '
        'Transferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.buttonCancelar)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Controls.Add(Me.textBoxNroCuenta)
        Me.Controls.Add(Me.comboBoxPais)
        Me.Controls.Add(Me.comboBoxSucursal)
        Me.Controls.Add(Me.comboBoxDivisa)
        Me.Controls.Add(Me.comboBoxTipo)
        Me.Controls.Add(Me.textBoxMonto)
        Me.Controls.Add(Me.labelNroCuenta)
        Me.Controls.Add(Me.labelPais)
        Me.Controls.Add(Me.labelSucursal)
        Me.Controls.Add(Me.labelDivisa)
        Me.Controls.Add(Me.labelMonto)
        Me.Controls.Add(Me.labelTipo)
        Me.Name = "Transferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonCancelar As Button
    Private WithEvents buttonAceptar As Button
    Private WithEvents textBoxNroCuenta As TextBox
    Private WithEvents comboBoxPais As ComboBox
    Private WithEvents comboBoxSucursal As ComboBox
    Private WithEvents comboBoxDivisa As ComboBox
    Private WithEvents comboBoxTipo As ComboBox
    Private WithEvents textBoxMonto As TextBox
    Private WithEvents labelNroCuenta As Label
    Private WithEvents labelPais As Label
    Private WithEvents labelSucursal As Label
    Private WithEvents labelDivisa As Label
    Private WithEvents labelMonto As Label
    Private WithEvents labelTipo As Label
End Class
