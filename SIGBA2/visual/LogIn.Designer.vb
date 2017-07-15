<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.LinkLabelLenguaje = New System.Windows.Forms.LinkLabel()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.LabelContraseña = New System.Windows.Forms.Label()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.TextBoxContraseña = New System.Windows.Forms.TextBox()
        Me.ButtonIniciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LinkLabelLenguaje
        '
        Me.LinkLabelLenguaje.AutoSize = True
        Me.LinkLabelLenguaje.Location = New System.Drawing.Point(13, 13)
        Me.LinkLabelLenguaje.Name = "LinkLabelLenguaje"
        Me.LinkLabelLenguaje.Size = New System.Drawing.Size(175, 13)
        Me.LinkLabelLenguaje.TabIndex = 0
        Me.LinkLabelLenguaje.TabStop = True
        Me.LinkLabelLenguaje.Text = "Cambiar Idioma/ Change Language"
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.Location = New System.Drawing.Point(85, 66)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(46, 13)
        Me.LabelUsuario.TabIndex = 1
        Me.LabelUsuario.Text = "Usuario:"
        '
        'LabelContraseña
        '
        Me.LabelContraseña.AutoSize = True
        Me.LabelContraseña.Location = New System.Drawing.Point(85, 100)
        Me.LabelContraseña.Name = "LabelContraseña"
        Me.LabelContraseña.Size = New System.Drawing.Size(64, 13)
        Me.LabelContraseña.TabIndex = 2
        Me.LabelContraseña.Text = "Contraseña:"
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.Location = New System.Drawing.Point(138, 66)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxUsuario.TabIndex = 3
        '
        'TextBoxContraseña
        '
        Me.TextBoxContraseña.Location = New System.Drawing.Point(155, 100)
        Me.TextBoxContraseña.Name = "TextBoxContraseña"
        Me.TextBoxContraseña.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxContraseña.TabIndex = 4
        '
        'ButtonIniciar
        '
        Me.ButtonIniciar.Location = New System.Drawing.Point(313, 177)
        Me.ButtonIniciar.Name = "ButtonIniciar"
        Me.ButtonIniciar.Size = New System.Drawing.Size(78, 23)
        Me.ButtonIniciar.TabIndex = 5
        Me.ButtonIniciar.Text = "Iniciar Sesion"
        Me.ButtonIniciar.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 212)
        Me.Controls.Add(Me.ButtonIniciar)
        Me.Controls.Add(Me.TextBoxContraseña)
        Me.Controls.Add(Me.TextBoxUsuario)
        Me.Controls.Add(Me.LabelContraseña)
        Me.Controls.Add(Me.LabelUsuario)
        Me.Controls.Add(Me.LinkLabelLenguaje)
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabelLenguaje As LinkLabel
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents LabelContraseña As Label
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents ButtonIniciar As Button
End Class
