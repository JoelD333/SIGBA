<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Retiro
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
        Me.comboBoxDivisa = New System.Windows.Forms.ComboBox()
        Me.textBoxMonto = New System.Windows.Forms.TextBox()
        Me.labelDivisa = New System.Windows.Forms.Label()
        Me.labelMonto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Location = New System.Drawing.Point(160, 207)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(112, 23)
        Me.buttonAceptar.TabIndex = 9
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = True
        '
        'comboBoxDivisa
        '
        Me.comboBoxDivisa.FormattingEnabled = True
        Me.comboBoxDivisa.Location = New System.Drawing.Point(62, 73)
        Me.comboBoxDivisa.Name = "comboBoxDivisa"
        Me.comboBoxDivisa.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxDivisa.TabIndex = 8
        '
        'textBoxMonto
        '
        Me.textBoxMonto.Location = New System.Drawing.Point(60, 31)
        Me.textBoxMonto.Name = "textBoxMonto"
        Me.textBoxMonto.Size = New System.Drawing.Size(100, 20)
        Me.textBoxMonto.TabIndex = 7
        '
        'labelDivisa
        '
        Me.labelDivisa.AutoSize = True
        Me.labelDivisa.Location = New System.Drawing.Point(16, 73)
        Me.labelDivisa.Name = "labelDivisa"
        Me.labelDivisa.Size = New System.Drawing.Size(39, 13)
        Me.labelDivisa.TabIndex = 6
        Me.labelDivisa.Text = "Divisa:"
        '
        'labelMonto
        '
        Me.labelMonto.AutoSize = True
        Me.labelMonto.Location = New System.Drawing.Point(13, 31)
        Me.labelMonto.Name = "labelMonto"
        Me.labelMonto.Size = New System.Drawing.Size(40, 13)
        Me.labelMonto.TabIndex = 5
        Me.labelMonto.Text = "Monto:"
        '
        'Retiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Controls.Add(Me.comboBoxDivisa)
        Me.Controls.Add(Me.textBoxMonto)
        Me.Controls.Add(Me.labelDivisa)
        Me.Controls.Add(Me.labelMonto)
        Me.Name = "Retiro"
        Me.Text = "Retiro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonAceptar As Button
    Private WithEvents comboBoxDivisa As ComboBox
    Private WithEvents textBoxMonto As TextBox
    Private WithEvents labelDivisa As Label
    Private WithEvents labelMonto As Label
End Class
