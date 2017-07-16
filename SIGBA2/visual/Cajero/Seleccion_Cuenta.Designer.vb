<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seleccion_Cuenta
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
        Me.dataGridViewCuentas = New System.Windows.Forms.DataGridView()
        Me.NroCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labelCuentas = New System.Windows.Forms.Label()
        CType(Me.dataGridViewCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Location = New System.Drawing.Point(12, 246)
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancelar.TabIndex = 12
        Me.buttonCancelar.Text = "Cancelar"
        Me.buttonCancelar.UseVisualStyleBackColor = True
        '
        'buttonAceptar
        '
        Me.buttonAceptar.Location = New System.Drawing.Point(472, 246)
        Me.buttonAceptar.Name = "buttonAceptar"
        Me.buttonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.buttonAceptar.TabIndex = 11
        Me.buttonAceptar.Text = "Aceptar"
        Me.buttonAceptar.UseVisualStyleBackColor = True
        '
        'dataGridViewCuentas
        '
        Me.dataGridViewCuentas.AllowUserToAddRows = False
        Me.dataGridViewCuentas.AllowUserToDeleteRows = False
        Me.dataGridViewCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroCuenta, Me.Estado, Me.Tipo, Me.Saldo, Me.UltimoMovimiento})
        Me.dataGridViewCuentas.Location = New System.Drawing.Point(12, 26)
        Me.dataGridViewCuentas.Name = "dataGridViewCuentas"
        Me.dataGridViewCuentas.ReadOnly = True
        Me.dataGridViewCuentas.Size = New System.Drawing.Size(531, 207)
        Me.dataGridViewCuentas.TabIndex = 10
        '
        'NroCuenta
        '
        Me.NroCuenta.HeaderText = "Nº Cuenta"
        Me.NroCuenta.Name = "NroCuenta"
        Me.NroCuenta.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Saldo
        '
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        '
        'UltimoMovimiento
        '
        Me.UltimoMovimiento.HeaderText = "Último Movimiento"
        Me.UltimoMovimiento.Name = "UltimoMovimiento"
        Me.UltimoMovimiento.ReadOnly = True
        '
        'labelCuentas
        '
        Me.labelCuentas.AutoSize = True
        Me.labelCuentas.Location = New System.Drawing.Point(9, 10)
        Me.labelCuentas.Name = "labelCuentas"
        Me.labelCuentas.Size = New System.Drawing.Size(97, 13)
        Me.labelCuentas.TabIndex = 9
        Me.labelCuentas.Text = "Cuentas asociadas"
        '
        'Seleccion_Cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(559, 281)
        Me.Controls.Add(Me.buttonCancelar)
        Me.Controls.Add(Me.buttonAceptar)
        Me.Controls.Add(Me.dataGridViewCuentas)
        Me.Controls.Add(Me.labelCuentas)
        Me.Name = "Seleccion_Cuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion_Cuenta"
        CType(Me.dataGridViewCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonCancelar As Button
    Private WithEvents buttonAceptar As Button
    Private WithEvents dataGridViewCuentas As DataGridView
    Private WithEvents NroCuenta As DataGridViewTextBoxColumn
    Private WithEvents Estado As DataGridViewTextBoxColumn
    Private WithEvents Tipo As DataGridViewTextBoxColumn
    Private WithEvents Saldo As DataGridViewTextBoxColumn
    Private WithEvents UltimoMovimiento As DataGridViewTextBoxColumn
    Private WithEvents labelCuentas As Label
End Class
