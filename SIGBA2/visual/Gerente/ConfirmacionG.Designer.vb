<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmacionG
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
        Me.ButtonConfirmar = New System.Windows.Forms.Button()
        Me.TextBoxContraseña = New System.Windows.Forms.TextBox()
        Me.LabelContrasena = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonConfirmar
        '
        Me.ButtonConfirmar.Location = New System.Drawing.Point(197, 226)
        Me.ButtonConfirmar.Name = "ButtonConfirmar"
        Me.ButtonConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConfirmar.TabIndex = 9
        Me.ButtonConfirmar.Text = "Confirmar"
        Me.ButtonConfirmar.UseVisualStyleBackColor = True
        '
        'TextBoxContraseña
        '
        Me.TextBoxContraseña.Location = New System.Drawing.Point(134, 118)
        Me.TextBoxContraseña.Name = "TextBoxContraseña"
        Me.TextBoxContraseña.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxContraseña.TabIndex = 10
        Me.TextBoxContraseña.UseSystemPasswordChar = True
        '
        'LabelContrasena
        '
        Me.LabelContrasena.AutoSize = True
        Me.LabelContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContrasena.Location = New System.Drawing.Point(53, 121)
        Me.LabelContrasena.Name = "LabelContrasena"
        Me.LabelContrasena.Size = New System.Drawing.Size(75, 13)
        Me.LabelContrasena.TabIndex = 11
        Me.LabelContrasena.Text = "Contraseña:"
        '
        'ConfirmacionG
        '
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.LabelContrasena)
        Me.Controls.Add(Me.TextBoxContraseña)
        Me.Controls.Add(Me.ButtonConfirmar)
        Me.Name = "ConfirmacionG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonAceptar As Button
    Private WithEvents textBox1 As TextBox
    Private WithEvents labelContraseña As Label
    Friend WithEvents ButtonConfirmar As Button
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents LabelContrasena As Label
End Class
