<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_Solicitud
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
        Me.textBoxIdentificacion = New System.Windows.Forms.TextBox()
        Me.textBoxMonto = New System.Windows.Forms.TextBox()
        Me.comboBoxIdentificacion = New System.Windows.Forms.ComboBox()
        Me.textBoxNroCheque = New System.Windows.Forms.TextBox()
        Me.comboBoxBanco = New System.Windows.Forms.ComboBox()
        Me.comboBoxDivisa = New System.Windows.Forms.ComboBox()
        Me.comboBoxSucursal = New System.Windows.Forms.ComboBox()
        Me.labelIdentificacion = New System.Windows.Forms.Label()
        Me.labelBanco = New System.Windows.Forms.Label()
        Me.labelDivisa = New System.Windows.Forms.Label()
        Me.labelMonto = New System.Windows.Forms.Label()
        Me.labelNroCheque = New System.Windows.Forms.Label()
        Me.labelSucursal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Location = New System.Drawing.Point(12, 226)
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancelar.TabIndex = 29
        Me.buttonCancelar.Text = "Cancelar"
        Me.buttonCancelar.UseVisualStyleBackColor = True
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Location = New System.Drawing.Point(197, 226)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.buttonAceptar.TabIndex = 28
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = True
        '
        'textBoxIdentificacion
        '
        Me.textBoxIdentificacion.Location = New System.Drawing.Point(88, 198)
        Me.textBoxIdentificacion.Name = "textBoxIdentificacion"
        Me.textBoxIdentificacion.Size = New System.Drawing.Size(121, 20)
        Me.textBoxIdentificacion.TabIndex = 27
        '
        'textBoxMonto
        '
        Me.textBoxMonto.Location = New System.Drawing.Point(57, 73)
        Me.textBoxMonto.Name = "textBoxMonto"
        Me.textBoxMonto.Size = New System.Drawing.Size(168, 20)
        Me.textBoxMonto.TabIndex = 26
        '
        'comboBoxIdentificacion
        '
        Me.comboBoxIdentificacion.FormattingEnabled = True
        Me.comboBoxIdentificacion.Location = New System.Drawing.Point(88, 171)
        Me.comboBoxIdentificacion.Name = "comboBoxIdentificacion"
        Me.comboBoxIdentificacion.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxIdentificacion.TabIndex = 25
        '
        'textBoxNroCheque
        '
        Me.textBoxNroCheque.Location = New System.Drawing.Point(78, 46)
        Me.textBoxNroCheque.Name = "textBoxNroCheque"
        Me.textBoxNroCheque.Size = New System.Drawing.Size(147, 20)
        Me.textBoxNroCheque.TabIndex = 24
        '
        'comboBoxBanco
        '
        Me.comboBoxBanco.FormattingEnabled = True
        Me.comboBoxBanco.Location = New System.Drawing.Point(55, 125)
        Me.comboBoxBanco.Name = "comboBoxBanco"
        Me.comboBoxBanco.Size = New System.Drawing.Size(170, 21)
        Me.comboBoxBanco.TabIndex = 23
        '
        'comboBoxDivisa
        '
        Me.comboBoxDivisa.FormattingEnabled = True
        Me.comboBoxDivisa.Location = New System.Drawing.Point(55, 98)
        Me.comboBoxDivisa.Name = "comboBoxDivisa"
        Me.comboBoxDivisa.Size = New System.Drawing.Size(170, 21)
        Me.comboBoxDivisa.TabIndex = 22
        '
        'comboBoxSucursal
        '
        Me.comboBoxSucursal.FormattingEnabled = True
        Me.comboBoxSucursal.Location = New System.Drawing.Point(104, 19)
        Me.comboBoxSucursal.Name = "comboBoxSucursal"
        Me.comboBoxSucursal.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxSucursal.TabIndex = 21
        '
        'labelIdentificacion
        '
        Me.labelIdentificacion.AutoSize = True
        Me.labelIdentificacion.Location = New System.Drawing.Point(12, 171)
        Me.labelIdentificacion.Name = "labelIdentificacion"
        Me.labelIdentificacion.Size = New System.Drawing.Size(70, 13)
        Me.labelIdentificacion.TabIndex = 20
        Me.labelIdentificacion.Text = "Identificación"
        '
        'labelBanco
        '
        Me.labelBanco.AutoSize = True
        Me.labelBanco.Location = New System.Drawing.Point(14, 125)
        Me.labelBanco.Name = "labelBanco"
        Me.labelBanco.Size = New System.Drawing.Size(38, 13)
        Me.labelBanco.TabIndex = 19
        Me.labelBanco.Text = "Banco"
        '
        'labelDivisa
        '
        Me.labelDivisa.AutoSize = True
        Me.labelDivisa.Location = New System.Drawing.Point(15, 98)
        Me.labelDivisa.Name = "labelDivisa"
        Me.labelDivisa.Size = New System.Drawing.Size(36, 13)
        Me.labelDivisa.TabIndex = 18
        Me.labelDivisa.Text = "Divisa"
        '
        'labelMonto
        '
        Me.labelMonto.AutoSize = True
        Me.labelMonto.Location = New System.Drawing.Point(14, 73)
        Me.labelMonto.Name = "labelMonto"
        Me.labelMonto.Size = New System.Drawing.Size(37, 13)
        Me.labelMonto.TabIndex = 17
        Me.labelMonto.Text = "Monto"
        '
        'labelNroCheque
        '
        Me.labelNroCheque.AutoSize = True
        Me.labelNroCheque.Location = New System.Drawing.Point(13, 46)
        Me.labelNroCheque.Name = "labelNroCheque"
        Me.labelNroCheque.Size = New System.Drawing.Size(59, 13)
        Me.labelNroCheque.TabIndex = 16
        Me.labelNroCheque.Text = "Nº Cheque"
        '
        'labelSucursal
        '
        Me.labelSucursal.AutoSize = True
        Me.labelSucursal.Location = New System.Drawing.Point(12, 19)
        Me.labelSucursal.Name = "labelSucursal"
        Me.labelSucursal.Size = New System.Drawing.Size(84, 13)
        Me.labelSucursal.TabIndex = 15
        Me.labelSucursal.Text = "Sucursal Actual:"
        '
        'Crear_Solicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.buttonCancelar)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Controls.Add(Me.textBoxIdentificacion)
        Me.Controls.Add(Me.textBoxMonto)
        Me.Controls.Add(Me.comboBoxIdentificacion)
        Me.Controls.Add(Me.textBoxNroCheque)
        Me.Controls.Add(Me.comboBoxBanco)
        Me.Controls.Add(Me.comboBoxDivisa)
        Me.Controls.Add(Me.comboBoxSucursal)
        Me.Controls.Add(Me.labelIdentificacion)
        Me.Controls.Add(Me.labelBanco)
        Me.Controls.Add(Me.labelDivisa)
        Me.Controls.Add(Me.labelMonto)
        Me.Controls.Add(Me.labelNroCheque)
        Me.Controls.Add(Me.labelSucursal)
        Me.Name = "Crear_Solicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear_Solicitud"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonCancelar As Button
    Private WithEvents buttonAceptar As Button
    Private WithEvents textBoxIdentificacion As TextBox
    Private WithEvents textBoxMonto As TextBox
    Private WithEvents comboBoxIdentificacion As ComboBox
    Private WithEvents textBoxNroCheque As TextBox
    Private WithEvents comboBoxBanco As ComboBox
    Private WithEvents comboBoxDivisa As ComboBox
    Private WithEvents comboBoxSucursal As ComboBox
    Private WithEvents labelIdentificacion As Label
    Private WithEvents labelBanco As Label
    Private WithEvents labelDivisa As Label
    Private WithEvents labelMonto As Label
    Private WithEvents labelNroCheque As Label
    Private WithEvents labelSucursal As Label
End Class
