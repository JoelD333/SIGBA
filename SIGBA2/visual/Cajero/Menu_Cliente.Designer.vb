<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Cliente
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
        Me.buttonVerSaldo = New System.Windows.Forms.Button()
        Me.buttonConsultaCliente = New System.Windows.Forms.Button()
        Me.buttonCobrarCheque = New System.Windows.Forms.Button()
        Me.buttonDepositarCheque = New System.Windows.Forms.Button()
        Me.buttonRetiro = New System.Windows.Forms.Button()
        Me.buttonDeposito = New System.Windows.Forms.Button()
        Me.buttonTransferencia = New System.Windows.Forms.Button()
        Me.buttonCalendarioPagos = New System.Windows.Forms.Button()
        Me.ButtonAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonVerSaldo
        '
        Me.buttonVerSaldo.Location = New System.Drawing.Point(142, 162)
        Me.buttonVerSaldo.Name = "buttonVerSaldo"
        Me.buttonVerSaldo.Size = New System.Drawing.Size(130, 23)
        Me.buttonVerSaldo.TabIndex = 15
        Me.buttonVerSaldo.Text = "Ver Saldo"
        Me.buttonVerSaldo.UseVisualStyleBackColor = True
        '
        'buttonConsultaCliente
        '
        Me.buttonConsultaCliente.Location = New System.Drawing.Point(13, 162)
        Me.buttonConsultaCliente.Name = "buttonConsultaCliente"
        Me.buttonConsultaCliente.Size = New System.Drawing.Size(123, 23)
        Me.buttonConsultaCliente.TabIndex = 14
        Me.buttonConsultaCliente.Text = "Consulta Cliente"
        Me.buttonConsultaCliente.UseVisualStyleBackColor = True
        '
        'buttonCobrarCheque
        '
        Me.buttonCobrarCheque.Location = New System.Drawing.Point(142, 133)
        Me.buttonCobrarCheque.Name = "buttonCobrarCheque"
        Me.buttonCobrarCheque.Size = New System.Drawing.Size(130, 23)
        Me.buttonCobrarCheque.TabIndex = 13
        Me.buttonCobrarCheque.Text = "Cobrar Cheque"
        Me.buttonCobrarCheque.UseVisualStyleBackColor = True
        '
        'buttonDepositarCheque
        '
        Me.buttonDepositarCheque.Location = New System.Drawing.Point(13, 133)
        Me.buttonDepositarCheque.Name = "buttonDepositarCheque"
        Me.buttonDepositarCheque.Size = New System.Drawing.Size(123, 23)
        Me.buttonDepositarCheque.TabIndex = 12
        Me.buttonDepositarCheque.Text = "Depositar Cheque"
        Me.buttonDepositarCheque.UseVisualStyleBackColor = True
        '
        'buttonRetiro
        '
        Me.buttonRetiro.Location = New System.Drawing.Point(142, 104)
        Me.buttonRetiro.Name = "buttonRetiro"
        Me.buttonRetiro.Size = New System.Drawing.Size(130, 23)
        Me.buttonRetiro.TabIndex = 11
        Me.buttonRetiro.Text = "Retiro"
        Me.buttonRetiro.UseVisualStyleBackColor = True
        '
        'buttonDeposito
        '
        Me.buttonDeposito.Location = New System.Drawing.Point(13, 104)
        Me.buttonDeposito.Name = "buttonDeposito"
        Me.buttonDeposito.Size = New System.Drawing.Size(123, 23)
        Me.buttonDeposito.TabIndex = 10
        Me.buttonDeposito.Text = "Deposito"
        Me.buttonDeposito.UseVisualStyleBackColor = True
        '
        'buttonTransferencia
        '
        Me.buttonTransferencia.Location = New System.Drawing.Point(142, 75)
        Me.buttonTransferencia.Name = "buttonTransferencia"
        Me.buttonTransferencia.Size = New System.Drawing.Size(130, 23)
        Me.buttonTransferencia.TabIndex = 9
        Me.buttonTransferencia.Text = "Transferencia"
        Me.buttonTransferencia.UseVisualStyleBackColor = True
        '
        'buttonCalendarioPagos
        '
        Me.buttonCalendarioPagos.Location = New System.Drawing.Point(13, 75)
        Me.buttonCalendarioPagos.Name = "buttonCalendarioPagos"
        Me.buttonCalendarioPagos.Size = New System.Drawing.Size(123, 23)
        Me.buttonCalendarioPagos.TabIndex = 8
        Me.buttonCalendarioPagos.Text = "Calendario Pagos"
        Me.buttonCalendarioPagos.UseVisualStyleBackColor = True
        '
        'ButtonAtras
        '
        Me.ButtonAtras.Location = New System.Drawing.Point(13, 13)
        Me.ButtonAtras.Name = "ButtonAtras"
        Me.ButtonAtras.Size = New System.Drawing.Size(23, 23)
        Me.ButtonAtras.TabIndex = 16
        Me.ButtonAtras.Text = "<"
        Me.ButtonAtras.UseVisualStyleBackColor = True
        '
        'Menu_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ButtonAtras)
        Me.Controls.Add(Me.buttonVerSaldo)
        Me.Controls.Add(Me.buttonConsultaCliente)
        Me.Controls.Add(Me.buttonCobrarCheque)
        Me.Controls.Add(Me.buttonDepositarCheque)
        Me.Controls.Add(Me.buttonRetiro)
        Me.Controls.Add(Me.buttonDeposito)
        Me.Controls.Add(Me.buttonTransferencia)
        Me.Controls.Add(Me.buttonCalendarioPagos)
        Me.Name = "Menu_Cliente"
        Me.Text = "Menu_Cliente"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents buttonVerSaldo As Button
    Private WithEvents buttonConsultaCliente As Button
    Private WithEvents buttonCobrarCheque As Button
    Private WithEvents buttonDepositarCheque As Button
    Private WithEvents buttonRetiro As Button
    Private WithEvents buttonDeposito As Button
    Private WithEvents buttonTransferencia As Button
    Private WithEvents buttonCalendarioPagos As Button
    Friend WithEvents ButtonAtras As Button
End Class
