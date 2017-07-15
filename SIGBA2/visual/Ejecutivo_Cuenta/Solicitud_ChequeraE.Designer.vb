<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Solicitud_ChequeraE
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
        Me.buttonImprimir = New System.Windows.Forms.Button()
        Me.buttonAceptar = New System.Windows.Forms.Button()
        Me.textBoxCanal = New System.Windows.Forms.TextBox()
        Me.comboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.comboBoxDivisa = New System.Windows.Forms.ComboBox()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.labelFormulario = New System.Windows.Forms.Label()
        Me.labelCanal = New System.Windows.Forms.Label()
        Me.labelTipo = New System.Windows.Forms.Label()
        Me.labelDivisa = New System.Windows.Forms.Label()
        Me.labelSucursal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Location = New System.Drawing.Point(12, 226)
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancelar.TabIndex = 35
        Me.buttonCancelar.Text = "Cancelar"
        Me.buttonCancelar.UseVisualStyleBackColor = True
        '
        'buttonImprimir
        '
        Me.buttonImprimir.Location = New System.Drawing.Point(114, 149)
        Me.buttonImprimir.Name = "buttonImprimir"
        Me.buttonImprimir.Size = New System.Drawing.Size(121, 23)
        Me.buttonImprimir.TabIndex = 34
        Me.buttonImprimir.Text = "Imprimir"
        Me.buttonImprimir.UseVisualStyleBackColor = True
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Location = New System.Drawing.Point(197, 226)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.buttonAceptar.TabIndex = 33
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = True
        '
        'textBoxCanal
        '
        Me.textBoxCanal.Location = New System.Drawing.Point(114, 123)
        Me.textBoxCanal.Name = "textBoxCanal"
        Me.textBoxCanal.Size = New System.Drawing.Size(121, 20)
        Me.textBoxCanal.TabIndex = 32
        '
        'comboBoxTipo
        '
        Me.comboBoxTipo.FormattingEnabled = True
        Me.comboBoxTipo.Location = New System.Drawing.Point(114, 96)
        Me.comboBoxTipo.Name = "comboBoxTipo"
        Me.comboBoxTipo.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxTipo.TabIndex = 31
        '
        'comboBoxDivisa
        '
        Me.comboBoxDivisa.FormattingEnabled = True
        Me.comboBoxDivisa.Location = New System.Drawing.Point(114, 69)
        Me.comboBoxDivisa.Name = "comboBoxDivisa"
        Me.comboBoxDivisa.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxDivisa.TabIndex = 30
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(114, 42)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 21)
        Me.comboBox1.TabIndex = 29
        '
        'labelFormulario
        '
        Me.labelFormulario.AutoSize = True
        Me.labelFormulario.Location = New System.Drawing.Point(53, 149)
        Me.labelFormulario.Name = "labelFormulario"
        Me.labelFormulario.Size = New System.Drawing.Size(55, 13)
        Me.labelFormulario.TabIndex = 28
        Me.labelFormulario.Text = "Formulario"
        '
        'labelCanal
        '
        Me.labelCanal.AutoSize = True
        Me.labelCanal.Location = New System.Drawing.Point(74, 123)
        Me.labelCanal.Name = "labelCanal"
        Me.labelCanal.Size = New System.Drawing.Size(34, 13)
        Me.labelCanal.TabIndex = 27
        Me.labelCanal.Text = "Canal"
        '
        'labelTipo
        '
        Me.labelTipo.AutoSize = True
        Me.labelTipo.Location = New System.Drawing.Point(80, 96)
        Me.labelTipo.Name = "labelTipo"
        Me.labelTipo.Size = New System.Drawing.Size(28, 13)
        Me.labelTipo.TabIndex = 26
        Me.labelTipo.Text = "Tipo"
        '
        'labelDivisa
        '
        Me.labelDivisa.AutoSize = True
        Me.labelDivisa.Location = New System.Drawing.Point(71, 69)
        Me.labelDivisa.Name = "labelDivisa"
        Me.labelDivisa.Size = New System.Drawing.Size(36, 13)
        Me.labelDivisa.TabIndex = 25
        Me.labelDivisa.Text = "Divisa"
        '
        'labelSucursal
        '
        Me.labelSucursal.AutoSize = True
        Me.labelSucursal.Location = New System.Drawing.Point(14, 42)
        Me.labelSucursal.Name = "labelSucursal"
        Me.labelSucursal.Size = New System.Drawing.Size(94, 13)
        Me.labelSucursal.TabIndex = 24
        Me.labelSucursal.Text = "Sucursal de Retiro"
        '
        'Solicitud_ChequeraE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.buttonCancelar)
        Me.Controls.Add(Me.buttonImprimir)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Controls.Add(Me.textBoxCanal)
        Me.Controls.Add(Me.comboBoxTipo)
        Me.Controls.Add(Me.comboBoxDivisa)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.labelFormulario)
        Me.Controls.Add(Me.labelCanal)
        Me.Controls.Add(Me.labelTipo)
        Me.Controls.Add(Me.labelDivisa)
        Me.Controls.Add(Me.labelSucursal)
        Me.Name = "Solicitud_ChequeraE"
        Me.Text = "Solicitud_Chequera"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonCancelar As Button
    Private WithEvents buttonImprimir As Button
    Private WithEvents buttonAceptar As Button
    Private WithEvents textBoxCanal As TextBox
    Private WithEvents comboBoxTipo As ComboBox
    Private WithEvents comboBoxDivisa As ComboBox
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents labelFormulario As Label
    Private WithEvents labelCanal As Label
    Private WithEvents labelTipo As Label
    Private WithEvents labelDivisa As Label
    Private WithEvents labelSucursal As Label
End Class
