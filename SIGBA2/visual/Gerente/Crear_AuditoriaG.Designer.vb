<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_AuditoriaG
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
        Me.textBoxNroEmpleado = New System.Windows.Forms.TextBox()
        Me.textBoxMotivo = New System.Windows.Forms.TextBox()
        Me.labelFECHAX = New System.Windows.Forms.Label()
        Me.checkBoxAdvertencia = New System.Windows.Forms.CheckBox()
        Me.checkBoxSuspension = New System.Windows.Forms.CheckBox()
        Me.labelAdvertencia = New System.Windows.Forms.Label()
        Me.labelSuspension = New System.Windows.Forms.Label()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.labelMotivo = New System.Windows.Forms.Label()
        Me.labelNroEmpleado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Location = New System.Drawing.Point(12, 226)
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancelar.TabIndex = 23
        Me.buttonCancelar.Text = "Cancelar"
        Me.buttonCancelar.UseVisualStyleBackColor = True
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Location = New System.Drawing.Point(197, 226)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.buttonAceptar.TabIndex = 22
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = True
        '
        'textBoxNroEmpleado
        '
        Me.textBoxNroEmpleado.Location = New System.Drawing.Point(89, 30)
        Me.textBoxNroEmpleado.Name = "textBoxNroEmpleado"
        Me.textBoxNroEmpleado.Size = New System.Drawing.Size(134, 20)
        Me.textBoxNroEmpleado.TabIndex = 21
        '
        'textBoxMotivo
        '
        Me.textBoxMotivo.Location = New System.Drawing.Point(58, 56)
        Me.textBoxMotivo.Multiline = True
        Me.textBoxMotivo.Name = "textBoxMotivo"
        Me.textBoxMotivo.Size = New System.Drawing.Size(165, 55)
        Me.textBoxMotivo.TabIndex = 20
        '
        'labelFECHAX
        '
        Me.labelFECHAX.AutoSize = True
        Me.labelFECHAX.Location = New System.Drawing.Point(57, 114)
        Me.labelFECHAX.Name = "labelFECHAX"
        Me.labelFECHAX.Size = New System.Drawing.Size(42, 13)
        Me.labelFECHAX.TabIndex = 19
        Me.labelFECHAX.Text = "FECHA"
        '
        'checkBoxAdvertencia
        '
        Me.checkBoxAdvertencia.AutoSize = True
        Me.checkBoxAdvertencia.Location = New System.Drawing.Point(83, 170)
        Me.checkBoxAdvertencia.Name = "checkBoxAdvertencia"
        Me.checkBoxAdvertencia.Size = New System.Drawing.Size(15, 14)
        Me.checkBoxAdvertencia.TabIndex = 18
        Me.checkBoxAdvertencia.UseVisualStyleBackColor = True
        '
        'checkBoxSuspension
        '
        Me.checkBoxSuspension.AutoSize = True
        Me.checkBoxSuspension.Location = New System.Drawing.Point(82, 142)
        Me.checkBoxSuspension.Name = "checkBoxSuspension"
        Me.checkBoxSuspension.Size = New System.Drawing.Size(15, 14)
        Me.checkBoxSuspension.TabIndex = 17
        Me.checkBoxSuspension.UseVisualStyleBackColor = True
        '
        'labelAdvertencia
        '
        Me.labelAdvertencia.AutoSize = True
        Me.labelAdvertencia.Location = New System.Drawing.Point(13, 170)
        Me.labelAdvertencia.Name = "labelAdvertencia"
        Me.labelAdvertencia.Size = New System.Drawing.Size(64, 13)
        Me.labelAdvertencia.TabIndex = 16
        Me.labelAdvertencia.Text = "Advertencia"
        '
        'labelSuspension
        '
        Me.labelSuspension.AutoSize = True
        Me.labelSuspension.Location = New System.Drawing.Point(13, 142)
        Me.labelSuspension.Name = "labelSuspension"
        Me.labelSuspension.Size = New System.Drawing.Size(62, 13)
        Me.labelSuspension.TabIndex = 15
        Me.labelSuspension.Text = "Suspensión"
        '
        'labelFecha
        '
        Me.labelFecha.AutoSize = True
        Me.labelFecha.Location = New System.Drawing.Point(13, 114)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(37, 13)
        Me.labelFecha.TabIndex = 14
        Me.labelFecha.Text = "Fecha"
        '
        'labelMotivo
        '
        Me.labelMotivo.AutoSize = True
        Me.labelMotivo.Location = New System.Drawing.Point(13, 56)
        Me.labelMotivo.Name = "labelMotivo"
        Me.labelMotivo.Size = New System.Drawing.Size(39, 13)
        Me.labelMotivo.TabIndex = 13
        Me.labelMotivo.Text = "Motivo"
        '
        'labelNroEmpleado
        '
        Me.labelNroEmpleado.AutoSize = True
        Me.labelNroEmpleado.Location = New System.Drawing.Point(13, 30)
        Me.labelNroEmpleado.Name = "labelNroEmpleado"
        Me.labelNroEmpleado.Size = New System.Drawing.Size(69, 13)
        Me.labelNroEmpleado.TabIndex = 12
        Me.labelNroEmpleado.Text = "Nº Empleado"
        '
        'Crear_AuditoriaG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.buttonCancelar)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Controls.Add(Me.textBoxNroEmpleado)
        Me.Controls.Add(Me.textBoxMotivo)
        Me.Controls.Add(Me.labelFECHAX)
        Me.Controls.Add(Me.checkBoxAdvertencia)
        Me.Controls.Add(Me.checkBoxSuspension)
        Me.Controls.Add(Me.labelAdvertencia)
        Me.Controls.Add(Me.labelSuspension)
        Me.Controls.Add(Me.labelFecha)
        Me.Controls.Add(Me.labelMotivo)
        Me.Controls.Add(Me.labelNroEmpleado)
        Me.Name = "Crear_AuditoriaG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear_Auditoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonCancelar As Button
    Private WithEvents buttonAceptar As Button
    Private WithEvents textBoxNroEmpleado As TextBox
    Private WithEvents textBoxMotivo As TextBox
    Private WithEvents labelFECHAX As Label
    Private WithEvents checkBoxAdvertencia As CheckBox
    Private WithEvents checkBoxSuspension As CheckBox
    Private WithEvents labelAdvertencia As Label
    Private WithEvents labelSuspension As Label
    Private WithEvents labelFecha As Label
    Private WithEvents labelMotivo As Label
    Private WithEvents labelNroEmpleado As Label
End Class
