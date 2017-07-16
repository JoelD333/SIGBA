<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingreso_Cliente
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
        Me.dataGridViewCuentas = New System.Windows.Forms.DataGridView()
        Me.NroCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labelCuentas = New System.Windows.Forms.Label()
        Me.textBoxIdentificacion = New System.Windows.Forms.TextBox()
        Me.comboBoxIdentificacion = New System.Windows.Forms.ComboBox()
        Me.labelIdentificacion = New System.Windows.Forms.Label()
        CType(Me.dataGridViewCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridViewCuentas
        '
        Me.dataGridViewCuentas.AllowUserToAddRows = False
        Me.dataGridViewCuentas.AllowUserToDeleteRows = False
        Me.dataGridViewCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroCuenta, Me.Estado, Me.Tipo, Me.Saldo, Me.UltimoMovimiento})
        Me.dataGridViewCuentas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataGridViewCuentas.Location = New System.Drawing.Point(0, 83)
        Me.dataGridViewCuentas.Name = "dataGridViewCuentas"
        Me.dataGridViewCuentas.ReadOnly = True
        Me.dataGridViewCuentas.Size = New System.Drawing.Size(463, 207)
        Me.dataGridViewCuentas.TabIndex = 9
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
        Me.labelCuentas.Location = New System.Drawing.Point(12, 56)
        Me.labelCuentas.Name = "labelCuentas"
        Me.labelCuentas.Size = New System.Drawing.Size(97, 13)
        Me.labelCuentas.TabIndex = 8
        Me.labelCuentas.Text = "Cuentas asociadas"
        '
        'textBoxIdentificacion
        '
        Me.textBoxIdentificacion.Location = New System.Drawing.Point(217, 9)
        Me.textBoxIdentificacion.Name = "textBoxIdentificacion"
        Me.textBoxIdentificacion.Size = New System.Drawing.Size(122, 20)
        Me.textBoxIdentificacion.TabIndex = 7
        '
        'comboBoxIdentificacion
        '
        Me.comboBoxIdentificacion.FormattingEnabled = True
        Me.comboBoxIdentificacion.Location = New System.Drawing.Point(89, 9)
        Me.comboBoxIdentificacion.Name = "comboBoxIdentificacion"
        Me.comboBoxIdentificacion.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxIdentificacion.TabIndex = 6
        '
        'labelIdentificacion
        '
        Me.labelIdentificacion.AutoSize = True
        Me.labelIdentificacion.Location = New System.Drawing.Point(12, 9)
        Me.labelIdentificacion.Name = "labelIdentificacion"
        Me.labelIdentificacion.Size = New System.Drawing.Size(70, 13)
        Me.labelIdentificacion.TabIndex = 5
        Me.labelIdentificacion.Text = "Identificación"
        '
        'Ingreso_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(463, 290)
        Me.Controls.Add(Me.dataGridViewCuentas)
        Me.Controls.Add(Me.labelCuentas)
        Me.Controls.Add(Me.textBoxIdentificacion)
        Me.Controls.Add(Me.comboBoxIdentificacion)
        Me.Controls.Add(Me.labelIdentificacion)
        Me.Name = "Ingreso_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso_Cliente"
        CType(Me.dataGridViewCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dataGridViewCuentas As DataGridView
    Private WithEvents NroCuenta As DataGridViewTextBoxColumn
    Private WithEvents Estado As DataGridViewTextBoxColumn
    Private WithEvents Tipo As DataGridViewTextBoxColumn
    Private WithEvents Saldo As DataGridViewTextBoxColumn
    Private WithEvents UltimoMovimiento As DataGridViewTextBoxColumn
    Private WithEvents labelCuentas As Label
    Private WithEvents textBoxIdentificacion As TextBox
    Private WithEvents comboBoxIdentificacion As ComboBox
    Private WithEvents labelIdentificacion As Label
End Class
