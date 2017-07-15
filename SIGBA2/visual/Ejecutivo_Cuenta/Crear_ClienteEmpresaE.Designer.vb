<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_ClienteEmpresaE
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
        Me.buttonDireccion = New System.Windows.Forms.Button()
        Me.ButtonComprobante = New System.Windows.Forms.Button()
        Me.textBoxRUT = New System.Windows.Forms.TextBox()
        Me.labelDireccion = New System.Windows.Forms.Label()
        Me.labelComprobanteIngresos = New System.Windows.Forms.Label()
        Me.labelRut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Location = New System.Drawing.Point(197, 226)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.buttonAceptar.TabIndex = 20
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = True
        '
        'buttonDireccion
        '
        Me.buttonDireccion.Location = New System.Drawing.Point(107, 123)
        Me.buttonDireccion.Name = "buttonDireccion"
        Me.buttonDireccion.Size = New System.Drawing.Size(75, 23)
        Me.buttonDireccion.TabIndex = 19
        Me.buttonDireccion.Text = "Adjuntar"
        Me.buttonDireccion.UseVisualStyleBackColor = True
        '
        'ButtonComprobante
        '
        Me.ButtonComprobante.Location = New System.Drawing.Point(150, 94)
        Me.ButtonComprobante.Name = "ButtonComprobante"
        Me.ButtonComprobante.Size = New System.Drawing.Size(75, 23)
        Me.ButtonComprobante.TabIndex = 18
        Me.ButtonComprobante.Text = "Adjuntar"
        Me.ButtonComprobante.UseVisualStyleBackColor = True
        '
        'textBoxRUT
        '
        Me.textBoxRUT.Location = New System.Drawing.Point(65, 65)
        Me.textBoxRUT.MaxLength = 12
        Me.textBoxRUT.Name = "textBoxRUT"
        Me.textBoxRUT.Size = New System.Drawing.Size(100, 20)
        Me.textBoxRUT.TabIndex = 17
        '
        'labelDireccion
        '
        Me.labelDireccion.AutoSize = True
        Me.labelDireccion.Location = New System.Drawing.Point(13, 125)
        Me.labelDireccion.Name = "labelDireccion"
        Me.labelDireccion.Size = New System.Drawing.Size(88, 13)
        Me.labelDireccion.TabIndex = 16
        Me.labelDireccion.Text = "Dirección Central"
        '
        'labelComprobanteIngresos
        '
        Me.labelComprobanteIngresos.AutoSize = True
        Me.labelComprobanteIngresos.Location = New System.Drawing.Point(13, 94)
        Me.labelComprobanteIngresos.Name = "labelComprobanteIngresos"
        Me.labelComprobanteIngresos.Size = New System.Drawing.Size(130, 13)
        Me.labelComprobanteIngresos.TabIndex = 15
        Me.labelComprobanteIngresos.Text = "Comprobante de ingresos:"
        '
        'labelRut
        '
        Me.labelRut.AutoSize = True
        Me.labelRut.Location = New System.Drawing.Point(13, 65)
        Me.labelRut.Name = "labelRut"
        Me.labelRut.Size = New System.Drawing.Size(45, 13)
        Me.labelRut.TabIndex = 14
        Me.labelRut.Text = "R. U. T."
        '
        'Crear_ClienteEmpresaE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Controls.Add(Me.buttonDireccion)
        Me.Controls.Add(Me.ButtonComprobante)
        Me.Controls.Add(Me.textBoxRUT)
        Me.Controls.Add(Me.labelDireccion)
        Me.Controls.Add(Me.labelComprobanteIngresos)
        Me.Controls.Add(Me.labelRut)
        Me.Name = "Crear_ClienteEmpresaE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear_ClienteEmpresa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonAceptar As Button
    Private WithEvents buttonDireccion As Button
    Private WithEvents ButtonComprobante As Button
    Private WithEvents textBoxRUT As TextBox
    Private WithEvents labelDireccion As Label
    Private WithEvents labelComprobanteIngresos As Label
    Private WithEvents labelRut As Label
End Class
