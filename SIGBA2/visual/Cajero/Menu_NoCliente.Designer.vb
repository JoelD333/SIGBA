<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_NoCliente
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
        Me.buttonDepositarC = New System.Windows.Forms.Button()
        Me.buttonCobrarC = New System.Windows.Forms.Button()
        Me.buttonDeposito = New System.Windows.Forms.Button()
        Me.ButtonAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonDepositarC
        '
        Me.buttonDepositarC.Location = New System.Drawing.Point(8, 119)
        Me.buttonDepositarC.Name = "buttonDepositarC"
        Me.buttonDepositarC.Size = New System.Drawing.Size(295, 23)
        Me.buttonDepositarC.TabIndex = 5
        Me.buttonDepositarC.Text = "Depositar Cheque"
        Me.buttonDepositarC.UseVisualStyleBackColor = True
        '
        'buttonCobrarC
        '
        Me.buttonCobrarC.Location = New System.Drawing.Point(12, 148)
        Me.buttonCobrarC.Name = "buttonCobrarC"
        Me.buttonCobrarC.Size = New System.Drawing.Size(295, 23)
        Me.buttonCobrarC.TabIndex = 4
        Me.buttonCobrarC.Text = "Cobrar Cheque"
        Me.buttonCobrarC.UseVisualStyleBackColor = True
        '
        'buttonDeposito
        '
        Me.buttonDeposito.Location = New System.Drawing.Point(12, 90)
        Me.buttonDeposito.Name = "buttonDeposito"
        Me.buttonDeposito.Size = New System.Drawing.Size(295, 23)
        Me.buttonDeposito.TabIndex = 3
        Me.buttonDeposito.Text = "Deposito"
        Me.buttonDeposito.UseVisualStyleBackColor = True
        '
        'ButtonAtras
        '
        Me.ButtonAtras.Location = New System.Drawing.Point(12, 12)
        Me.ButtonAtras.Name = "ButtonAtras"
        Me.ButtonAtras.Size = New System.Drawing.Size(23, 23)
        Me.ButtonAtras.TabIndex = 17
        Me.ButtonAtras.Text = "<"
        Me.ButtonAtras.UseVisualStyleBackColor = True
        '
        'Menu_NoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(315, 261)
        Me.Controls.Add(Me.ButtonAtras)
        Me.Controls.Add(Me.buttonDepositarC)
        Me.Controls.Add(Me.buttonCobrarC)
        Me.Controls.Add(Me.buttonDeposito)
        Me.Name = "Menu_NoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_NoCliente"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents buttonDepositarC As Button
    Private WithEvents buttonCobrarC As Button
    Private WithEvents buttonDeposito As Button
    Friend WithEvents ButtonAtras As Button
End Class
