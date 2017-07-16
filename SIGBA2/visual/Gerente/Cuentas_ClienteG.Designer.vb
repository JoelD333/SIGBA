<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuentas_ClienteG
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
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NroCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ultimo_Movimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labelCuentas = New System.Windows.Forms.Label()
        Me.textBoxIdentificaion = New System.Windows.Forms.TextBox()
        Me.comboBoxIdentificacion = New System.Windows.Forms.ComboBox()
        Me.labelIdentificacion = New System.Windows.Forms.Label()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroCuenta, Me.Estado, Me.Tipo, Me.Saldo, Me.Ultimo_Movimiento})
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataGridView1.Location = New System.Drawing.Point(0, 92)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.Size = New System.Drawing.Size(543, 182)
        Me.dataGridView1.TabIndex = 14
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
        'Ultimo_Movimiento
        '
        Me.Ultimo_Movimiento.HeaderText = "Último Movimiento"
        Me.Ultimo_Movimiento.Name = "Ultimo_Movimiento"
        Me.Ultimo_Movimiento.ReadOnly = True
        '
        'labelCuentas
        '
        Me.labelCuentas.AutoSize = True
        Me.labelCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCuentas.Location = New System.Drawing.Point(12, 76)
        Me.labelCuentas.Name = "labelCuentas"
        Me.labelCuentas.Size = New System.Drawing.Size(115, 13)
        Me.labelCuentas.TabIndex = 13
        Me.labelCuentas.Text = "Cuentas Asociadas"
        '
        'textBoxIdentificaion
        '
        Me.textBoxIdentificaion.Location = New System.Drawing.Point(230, 42)
        Me.textBoxIdentificaion.Name = "textBoxIdentificaion"
        Me.textBoxIdentificaion.Size = New System.Drawing.Size(121, 20)
        Me.textBoxIdentificaion.TabIndex = 12
        '
        'comboBoxIdentificacion
        '
        Me.comboBoxIdentificacion.FormattingEnabled = True
        Me.comboBoxIdentificacion.Location = New System.Drawing.Point(102, 42)
        Me.comboBoxIdentificacion.Name = "comboBoxIdentificacion"
        Me.comboBoxIdentificacion.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxIdentificacion.TabIndex = 11
        '
        'labelIdentificacion
        '
        Me.labelIdentificacion.AutoSize = True
        Me.labelIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIdentificacion.Location = New System.Drawing.Point(12, 45)
        Me.labelIdentificacion.Name = "labelIdentificacion"
        Me.labelIdentificacion.Size = New System.Drawing.Size(84, 13)
        Me.labelIdentificacion.TabIndex = 10
        Me.labelIdentificacion.Text = "Identificación"
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(12, 12)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 15
        Me.ButtonSalir.Text = "<"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Cuentas_ClienteG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(543, 274)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.labelCuentas)
        Me.Controls.Add(Me.textBoxIdentificaion)
        Me.Controls.Add(Me.comboBoxIdentificacion)
        Me.Controls.Add(Me.labelIdentificacion)
        Me.Name = "Cuentas_ClienteG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas_ClienteG"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents NroCuenta As DataGridViewTextBoxColumn
    Private WithEvents Estado As DataGridViewTextBoxColumn
    Private WithEvents Tipo As DataGridViewTextBoxColumn
    Private WithEvents Saldo As DataGridViewTextBoxColumn
    Private WithEvents Ultimo_Movimiento As DataGridViewTextBoxColumn
    Private WithEvents labelCuentas As Label
    Private WithEvents textBoxIdentificaion As TextBox
    Private WithEvents comboBoxIdentificacion As ComboBox
    Private WithEvents labelIdentificacion As Label
    Friend WithEvents ButtonSalir As Button
End Class
