<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fondo_Caja
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
        Me.textBoxContraseña = New System.Windows.Forms.TextBox()
        Me.textBoxFondo = New System.Windows.Forms.TextBox()
        Me.labelContraseña = New System.Windows.Forms.Label()
        Me.labelFondo = New System.Windows.Forms.Label()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBoxContraseña
        '
        Me.textBoxContraseña.Location = New System.Drawing.Point(82, 103)
        Me.textBoxContraseña.Name = "textBoxContraseña"
        Me.textBoxContraseña.Size = New System.Drawing.Size(100, 20)
        Me.textBoxContraseña.TabIndex = 7
        '
        'textBoxFondo
        '
        Me.textBoxFondo.Location = New System.Drawing.Point(131, 54)
        Me.textBoxFondo.Name = "textBoxFondo"
        Me.textBoxFondo.Size = New System.Drawing.Size(100, 20)
        Me.textBoxFondo.TabIndex = 6
        '
        'labelContraseña
        '
        Me.labelContraseña.AutoSize = True
        Me.labelContraseña.Location = New System.Drawing.Point(12, 103)
        Me.labelContraseña.Name = "labelContraseña"
        Me.labelContraseña.Size = New System.Drawing.Size(64, 13)
        Me.labelContraseña.TabIndex = 5
        Me.labelContraseña.Text = "Contraseña:"
        '
        'labelFondo
        '
        Me.labelFondo.AutoSize = True
        Me.labelFondo.Location = New System.Drawing.Point(12, 54)
        Me.labelFondo.Name = "labelFondo"
        Me.labelFondo.Size = New System.Drawing.Size(113, 13)
        Me.labelFondo.TabIndex = 4
        Me.labelFondo.Text = "Ingrese fondo de caja:"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(197, 226)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 8
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'Fondo_Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.textBoxContraseña)
        Me.Controls.Add(Me.textBoxFondo)
        Me.Controls.Add(Me.labelContraseña)
        Me.Controls.Add(Me.labelFondo)
        Me.Name = "Fondo_Caja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fondo_Caja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBoxContraseña As TextBox
    Private WithEvents textBoxFondo As TextBox
    Private WithEvents labelContraseña As Label
    Private WithEvents labelFondo As Label
    Friend WithEvents ButtonAceptar As Button
End Class
