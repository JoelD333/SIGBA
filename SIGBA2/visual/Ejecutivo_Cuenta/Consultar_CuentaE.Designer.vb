<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_CuentaE
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
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabPageDeuda = New System.Windows.Forms.TabPage()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Vencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Divisa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Minimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabPageCalendario = New System.Windows.Forms.TabPage()
        Me.tabPageUltimosMovimientos = New System.Windows.Forms.TabPage()
        Me.dataGridView2 = New System.Windows.Forms.DataGridView()
        Me.dataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correspondiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.tabControl.SuspendLayout()
        Me.tabPageDeuda.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageUltimosMovimientos.SuspendLayout()
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabPageDeuda)
        Me.tabControl.Controls.Add(Me.tabPageCalendario)
        Me.tabControl.Controls.Add(Me.tabPageUltimosMovimientos)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabControl.Location = New System.Drawing.Point(0, 29)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(532, 232)
        Me.tabControl.TabIndex = 2
        '
        'tabPageDeuda
        '
        Me.tabPageDeuda.Controls.Add(Me.dataGridView1)
        Me.tabPageDeuda.Location = New System.Drawing.Point(4, 22)
        Me.tabPageDeuda.Name = "tabPageDeuda"
        Me.tabPageDeuda.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageDeuda.Size = New System.Drawing.Size(524, 206)
        Me.tabPageDeuda.TabIndex = 0
        Me.tabPageDeuda.Text = "Deudas"
        Me.tabPageDeuda.UseVisualStyleBackColor = True
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Empresa, Me.Rubro, Me.Monto, Me.Fecha_Vencimiento, Me.Divisa, Me.Minimo})
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.Size = New System.Drawing.Size(518, 200)
        Me.dataGridView1.TabIndex = 0
        '
        'Empresa
        '
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.Name = "Empresa"
        Me.Empresa.ReadOnly = True
        '
        'Rubro
        '
        Me.Rubro.HeaderText = "Rubro"
        Me.Rubro.Name = "Rubro"
        Me.Rubro.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Fecha_Vencimiento
        '
        Me.Fecha_Vencimiento.HeaderText = "Fecha Vencimiento"
        Me.Fecha_Vencimiento.Name = "Fecha_Vencimiento"
        Me.Fecha_Vencimiento.ReadOnly = True
        '
        'Divisa
        '
        Me.Divisa.HeaderText = "Divisa"
        Me.Divisa.Name = "Divisa"
        Me.Divisa.ReadOnly = True
        '
        'Minimo
        '
        Me.Minimo.HeaderText = "Mínimo"
        Me.Minimo.Name = "Minimo"
        Me.Minimo.ReadOnly = True
        '
        'tabPageCalendario
        '
        Me.tabPageCalendario.Location = New System.Drawing.Point(4, 22)
        Me.tabPageCalendario.Name = "tabPageCalendario"
        Me.tabPageCalendario.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageCalendario.Size = New System.Drawing.Size(524, 235)
        Me.tabPageCalendario.TabIndex = 1
        Me.tabPageCalendario.Text = "Calendario de Pagos"
        Me.tabPageCalendario.UseVisualStyleBackColor = True
        '
        'tabPageUltimosMovimientos
        '
        Me.tabPageUltimosMovimientos.Controls.Add(Me.dataGridView2)
        Me.tabPageUltimosMovimientos.Location = New System.Drawing.Point(4, 22)
        Me.tabPageUltimosMovimientos.Name = "tabPageUltimosMovimientos"
        Me.tabPageUltimosMovimientos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageUltimosMovimientos.Size = New System.Drawing.Size(524, 235)
        Me.tabPageUltimosMovimientos.TabIndex = 2
        Me.tabPageUltimosMovimientos.Text = "Últimos veinte movimientos"
        Me.tabPageUltimosMovimientos.UseVisualStyleBackColor = True
        '
        'dataGridView2
        '
        Me.dataGridView2.AllowUserToAddRows = False
        Me.dataGridView2.AllowUserToDeleteRows = False
        Me.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataGridViewTextBoxColumn3, Me.dataGridViewTextBoxColumn5, Me.Correspondiente, Me.Fecha})
        Me.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.dataGridView2.Name = "dataGridView2"
        Me.dataGridView2.ReadOnly = True
        Me.dataGridView2.Size = New System.Drawing.Size(518, 229)
        Me.dataGridView2.TabIndex = 1
        '
        'dataGridViewTextBoxColumn3
        '
        Me.dataGridViewTextBoxColumn3.HeaderText = "Monto"
        Me.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3"
        Me.dataGridViewTextBoxColumn3.ReadOnly = True
        '
        'dataGridViewTextBoxColumn5
        '
        Me.dataGridViewTextBoxColumn5.HeaderText = "Divisa"
        Me.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5"
        Me.dataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Correspondiente
        '
        Me.Correspondiente.HeaderText = "Correspondiente"
        Me.Correspondiente.Name = "Correspondiente"
        Me.Correspondiente.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(13, 0)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(23, 23)
        Me.ButtonSalir.TabIndex = 3
        Me.ButtonSalir.Text = "<"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Consultar_CuentaE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 261)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.tabControl)
        Me.Name = "Consultar_CuentaE"
        Me.Text = "Consultar_Cuenta"
        Me.tabControl.ResumeLayout(False)
        Me.tabPageDeuda.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageUltimosMovimientos.ResumeLayout(False)
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tabControl As TabControl
    Private WithEvents tabPageDeuda As TabPage
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents Empresa As DataGridViewTextBoxColumn
    Private WithEvents Rubro As DataGridViewTextBoxColumn
    Private WithEvents Monto As DataGridViewTextBoxColumn
    Private WithEvents Fecha_Vencimiento As DataGridViewTextBoxColumn
    Private WithEvents Divisa As DataGridViewTextBoxColumn
    Private WithEvents Minimo As DataGridViewTextBoxColumn
    Private WithEvents tabPageCalendario As TabPage
    Private WithEvents tabPageUltimosMovimientos As TabPage
    Private WithEvents dataGridView2 As DataGridView
    Private WithEvents dataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Private WithEvents dataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Private WithEvents Correspondiente As DataGridViewTextBoxColumn
    Private WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents ButtonSalir As Button
End Class
