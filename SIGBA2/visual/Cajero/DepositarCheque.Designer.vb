<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepositarCheque
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
        Me.labelNroCuenta = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.buttonAceptar = New System.Windows.Forms.Button()
        Me.comboBoxBanco = New System.Windows.Forms.ComboBox()
        Me.labelBanco = New System.Windows.Forms.Label()
        Me.comboBoxDivisa = New System.Windows.Forms.ComboBox()
        Me.textBoxMonto = New System.Windows.Forms.TextBox()
        Me.textBoxNroCheque = New System.Windows.Forms.TextBox()
        Me.labelDivisa = New System.Windows.Forms.Label()
        Me.labelMonto = New System.Windows.Forms.Label()
        Me.labelNroCheque = New System.Windows.Forms.Label()
        Me.comboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.labelTipo = New System.Windows.Forms.Label()
        Me.textBoxIdentificacion = New System.Windows.Forms.TextBox()
        Me.comboBoxIdentificacion = New System.Windows.Forms.ComboBox()
        Me.labelIdentificacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelNroCuenta
        '
        Me.labelNroCuenta.AutoSize = True
        Me.labelNroCuenta.Location = New System.Drawing.Point(233, 196)
        Me.labelNroCuenta.Name = "labelNroCuenta"
        Me.labelNroCuenta.Size = New System.Drawing.Size(74, 13)
        Me.labelNroCuenta.TabIndex = 40
        Me.labelNroCuenta.Text = "Nº de Cuenta:"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(236, 212)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(100, 20)
        Me.textBox1.TabIndex = 39
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Location = New System.Drawing.Point(123, 209)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.buttonAceptar.TabIndex = 38
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = True
        '
        'comboBoxBanco
        '
        Me.comboBoxBanco.FormattingEnabled = True
        Me.comboBoxBanco.Items.AddRange(New Object() {"C.I.", "Pasaporte", ""})
        Me.comboBoxBanco.Location = New System.Drawing.Point(56, 156)
        Me.comboBoxBanco.Name = "comboBoxBanco"
        Me.comboBoxBanco.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxBanco.TabIndex = 37
        '
        'labelBanco
        '
        Me.labelBanco.AutoSize = True
        Me.labelBanco.Location = New System.Drawing.Point(14, 156)
        Me.labelBanco.Name = "labelBanco"
        Me.labelBanco.Size = New System.Drawing.Size(38, 13)
        Me.labelBanco.TabIndex = 36
        Me.labelBanco.Text = "Banco"
        '
        'comboBoxDivisa
        '
        Me.comboBoxDivisa.FormattingEnabled = True
        Me.comboBoxDivisa.Items.AddRange(New Object() {"C.I.", "Pasaporte", ""})
        Me.comboBoxDivisa.Location = New System.Drawing.Point(54, 129)
        Me.comboBoxDivisa.Name = "comboBoxDivisa"
        Me.comboBoxDivisa.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxDivisa.TabIndex = 35
        '
        'textBoxMonto
        '
        Me.textBoxMonto.Location = New System.Drawing.Point(55, 105)
        Me.textBoxMonto.Name = "textBoxMonto"
        Me.textBoxMonto.Size = New System.Drawing.Size(100, 20)
        Me.textBoxMonto.TabIndex = 34
        '
        'textBoxNroCheque
        '
        Me.textBoxNroCheque.Location = New System.Drawing.Point(77, 79)
        Me.textBoxNroCheque.Name = "textBoxNroCheque"
        Me.textBoxNroCheque.Size = New System.Drawing.Size(100, 20)
        Me.textBoxNroCheque.TabIndex = 33
        '
        'labelDivisa
        '
        Me.labelDivisa.AutoSize = True
        Me.labelDivisa.Location = New System.Drawing.Point(12, 129)
        Me.labelDivisa.Name = "labelDivisa"
        Me.labelDivisa.Size = New System.Drawing.Size(36, 13)
        Me.labelDivisa.TabIndex = 32
        Me.labelDivisa.Text = "Divisa"
        '
        'labelMonto
        '
        Me.labelMonto.AutoSize = True
        Me.labelMonto.Location = New System.Drawing.Point(12, 106)
        Me.labelMonto.Name = "labelMonto"
        Me.labelMonto.Size = New System.Drawing.Size(37, 13)
        Me.labelMonto.TabIndex = 31
        Me.labelMonto.Text = "Monto"
        '
        'labelNroCheque
        '
        Me.labelNroCheque.AutoSize = True
        Me.labelNroCheque.Location = New System.Drawing.Point(12, 79)
        Me.labelNroCheque.Name = "labelNroCheque"
        Me.labelNroCheque.Size = New System.Drawing.Size(59, 13)
        Me.labelNroCheque.TabIndex = 30
        Me.labelNroCheque.Text = "Nº Cheque"
        '
        'comboBoxTipo
        '
        Me.comboBoxTipo.FormattingEnabled = True
        Me.comboBoxTipo.Items.AddRange(New Object() {"C.I.", "Pasaporte", ""})
        Me.comboBoxTipo.Location = New System.Drawing.Point(101, 46)
        Me.comboBoxTipo.Name = "comboBoxTipo"
        Me.comboBoxTipo.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxTipo.TabIndex = 29
        '
        'labelTipo
        '
        Me.labelTipo.AutoSize = True
        Me.labelTipo.Location = New System.Drawing.Point(12, 46)
        Me.labelTipo.Name = "labelTipo"
        Me.labelTipo.Size = New System.Drawing.Size(83, 13)
        Me.labelTipo.TabIndex = 28
        Me.labelTipo.Text = "Tipo de Cheque"
        '
        'textBoxIdentificacion
        '
        Me.textBoxIdentificacion.Location = New System.Drawing.Point(216, 10)
        Me.textBoxIdentificacion.Name = "textBoxIdentificacion"
        Me.textBoxIdentificacion.Size = New System.Drawing.Size(120, 20)
        Me.textBoxIdentificacion.TabIndex = 27
        '
        'comboBoxIdentificacion
        '
        Me.comboBoxIdentificacion.FormattingEnabled = True
        Me.comboBoxIdentificacion.Items.AddRange(New Object() {"C.I.", "Pasaporte", ""})
        Me.comboBoxIdentificacion.Location = New System.Drawing.Point(89, 9)
        Me.comboBoxIdentificacion.Name = "comboBoxIdentificacion"
        Me.comboBoxIdentificacion.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxIdentificacion.TabIndex = 26
        '
        'labelIdentificacion
        '
        Me.labelIdentificacion.AutoSize = True
        Me.labelIdentificacion.Location = New System.Drawing.Point(12, 9)
        Me.labelIdentificacion.Name = "labelIdentificacion"
        Me.labelIdentificacion.Size = New System.Drawing.Size(70, 13)
        Me.labelIdentificacion.TabIndex = 25
        Me.labelIdentificacion.Text = "Identificación"
        '
        'DepositarCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 261)
        Me.Controls.Add(Me.labelNroCuenta)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Controls.Add(Me.comboBoxBanco)
        Me.Controls.Add(Me.labelBanco)
        Me.Controls.Add(Me.comboBoxDivisa)
        Me.Controls.Add(Me.textBoxMonto)
        Me.Controls.Add(Me.textBoxNroCheque)
        Me.Controls.Add(Me.labelDivisa)
        Me.Controls.Add(Me.labelMonto)
        Me.Controls.Add(Me.labelNroCheque)
        Me.Controls.Add(Me.comboBoxTipo)
        Me.Controls.Add(Me.labelTipo)
        Me.Controls.Add(Me.textBoxIdentificacion)
        Me.Controls.Add(Me.comboBoxIdentificacion)
        Me.Controls.Add(Me.labelIdentificacion)
        Me.Name = "DepositarCheque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DepositarCheque"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents labelNroCuenta As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents buttonAceptar As Button
    Private WithEvents comboBoxBanco As ComboBox
    Private WithEvents labelBanco As Label
    Private WithEvents comboBoxDivisa As ComboBox
    Private WithEvents textBoxMonto As TextBox
    Private WithEvents textBoxNroCheque As TextBox
    Private WithEvents labelDivisa As Label
    Private WithEvents labelMonto As Label
    Private WithEvents labelNroCheque As Label
    Private WithEvents comboBoxTipo As ComboBox
    Private WithEvents labelTipo As Label
    Private WithEvents textBoxIdentificacion As TextBox
    Private WithEvents comboBoxIdentificacion As ComboBox
    Private WithEvents labelIdentificacion As Label
End Class
