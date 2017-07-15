<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmacionE
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
        Me.LabelContraseña = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonConfirmar
        '
        Me.ButtonConfirmar.Location = New System.Drawing.Point(197, 226)
        Me.ButtonConfirmar.Name = "ButtonConfirmar"
        Me.ButtonConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConfirmar.TabIndex = 10
        Me.ButtonConfirmar.Text = "Confirmar"
        Me.ButtonConfirmar.UseVisualStyleBackColor = True
        '
        'TextBoxContraseña
        '
        Me.TextBoxContraseña.Location = New System.Drawing.Point(127, 120)
        Me.TextBoxContraseña.Name = "TextBoxContraseña"
        Me.TextBoxContraseña.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxContraseña.TabIndex = 9
        Me.TextBoxContraseña.UseSystemPasswordChar = True
        '
        'LabelContraseña
        '
        Me.LabelContraseña.AutoSize = True
        Me.LabelContraseña.Location = New System.Drawing.Point(57, 120)
        Me.LabelContraseña.Name = "LabelContraseña"
        Me.LabelContraseña.Size = New System.Drawing.Size(64, 13)
        Me.LabelContraseña.TabIndex = 8
        Me.LabelContraseña.Text = "Contraseña:"
        '
        'ConfirmacionE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ButtonConfirmar)
        Me.Controls.Add(Me.TextBoxContraseña)
        Me.Controls.Add(Me.LabelContraseña)
        Me.Name = "ConfirmacionE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConfirmacionE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonConfirmar As Button
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents LabelContraseña As Label
End Class
