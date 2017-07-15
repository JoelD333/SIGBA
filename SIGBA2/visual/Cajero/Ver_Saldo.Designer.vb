<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ver_Saldo
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
        Me.labelSALDOX = New System.Windows.Forms.Label()
        Me.labelSaldo = New System.Windows.Forms.Label()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelSALDOX
        '
        Me.labelSALDOX.AutoSize = True
        Me.labelSALDOX.BackColor = System.Drawing.SystemColors.Control
        Me.labelSALDOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelSALDOX.Location = New System.Drawing.Point(103, 108)
        Me.labelSALDOX.Name = "labelSALDOX"
        Me.labelSALDOX.Size = New System.Drawing.Size(45, 15)
        Me.labelSALDOX.TabIndex = 3
        Me.labelSALDOX.Text = "SALDO"
        '
        'labelSaldo
        '
        Me.labelSaldo.AutoSize = True
        Me.labelSaldo.Location = New System.Drawing.Point(59, 108)
        Me.labelSaldo.Name = "labelSaldo"
        Me.labelSaldo.Size = New System.Drawing.Size(37, 13)
        Me.labelSaldo.TabIndex = 2
        Me.labelSaldo.Text = "Saldo:"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(103, 226)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 4
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'Ver_Saldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.labelSALDOX)
        Me.Controls.Add(Me.labelSaldo)
        Me.Name = "Ver_Saldo"
        Me.Text = "Ver_Saldo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents labelSALDOX As Label
    Private WithEvents labelSaldo As Label
    Friend WithEvents ButtonAceptar As Button
End Class
