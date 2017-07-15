<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cerrar_Caja
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
        Me.LabelEsperado = New System.Windows.Forms.Label()
        Me.LabelSaldo = New System.Windows.Forms.Label()
        Me.TextBoxSaldo = New System.Windows.Forms.TextBox()
        Me.LabelSaldoEsperadoX = New System.Windows.Forms.Label()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelEsperado
        '
        Me.LabelEsperado.AutoSize = True
        Me.LabelEsperado.Location = New System.Drawing.Point(30, 68)
        Me.LabelEsperado.Name = "LabelEsperado"
        Me.LabelEsperado.Size = New System.Drawing.Size(84, 13)
        Me.LabelEsperado.TabIndex = 0
        Me.LabelEsperado.Text = "Saldo esperado:"
        '
        'LabelSaldo
        '
        Me.LabelSaldo.AutoSize = True
        Me.LabelSaldo.Location = New System.Drawing.Point(30, 95)
        Me.LabelSaldo.Name = "LabelSaldo"
        Me.LabelSaldo.Size = New System.Drawing.Size(76, 13)
        Me.LabelSaldo.TabIndex = 1
        Me.LabelSaldo.Text = "Saldo en Caja:"
        '
        'TextBoxSaldo
        '
        Me.TextBoxSaldo.Location = New System.Drawing.Point(113, 95)
        Me.TextBoxSaldo.Name = "TextBoxSaldo"
        Me.TextBoxSaldo.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSaldo.TabIndex = 2
        '
        'LabelSaldoEsperadoX
        '
        Me.LabelSaldoEsperadoX.AutoSize = True
        Me.LabelSaldoEsperadoX.Location = New System.Drawing.Point(120, 68)
        Me.LabelSaldoEsperadoX.Name = "LabelSaldoEsperadoX"
        Me.LabelSaldoEsperadoX.Size = New System.Drawing.Size(20, 13)
        Me.LabelSaldoEsperadoX.TabIndex = 3
        Me.LabelSaldoEsperadoX.Text = "-X-"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(101, 226)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 4
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'Cerrar_Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.LabelSaldoEsperadoX)
        Me.Controls.Add(Me.TextBoxSaldo)
        Me.Controls.Add(Me.LabelSaldo)
        Me.Controls.Add(Me.LabelEsperado)
        Me.Name = "Cerrar_Caja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cerrar_Caja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEsperado As Label
    Friend WithEvents LabelSaldo As Label
    Friend WithEvents TextBoxSaldo As TextBox
    Friend WithEvents LabelSaldoEsperadoX As Label
    Friend WithEvents ButtonAceptar As Button
End Class
