<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aprobar
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
        Me.NroSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Divisa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Propietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aceptar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Declinar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroSolicitud, Me.Monto, Me.Divisa, Me.Propietario, Me.Banco, Me.Estado, Me.Aceptar, Me.Declinar})
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataGridView1.Location = New System.Drawing.Point(0, 46)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.Size = New System.Drawing.Size(453, 215)
        Me.dataGridView1.TabIndex = 1
        '
        'NroSolicitud
        '
        Me.NroSolicitud.HeaderText = "Nº Solicitud"
        Me.NroSolicitud.Name = "NroSolicitud"
        Me.NroSolicitud.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Divisa
        '
        Me.Divisa.HeaderText = "Divisa"
        Me.Divisa.Name = "Divisa"
        Me.Divisa.ReadOnly = True
        '
        'Propietario
        '
        Me.Propietario.HeaderText = "Propietario"
        Me.Propietario.Name = "Propietario"
        Me.Propietario.ReadOnly = True
        '
        'Banco
        '
        Me.Banco.HeaderText = "Banco"
        Me.Banco.Name = "Banco"
        Me.Banco.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'Aceptar
        '
        Me.Aceptar.HeaderText = "Aceptar"
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.ReadOnly = True
        '
        'Declinar
        '
        Me.Declinar.HeaderText = "Declinar"
        Me.Declinar.Name = "Declinar"
        Me.Declinar.ReadOnly = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(12, 12)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(23, 23)
        Me.ButtonSalir.TabIndex = 5
        Me.ButtonSalir.Text = "<"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Aprobar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(453, 261)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Aprobar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aprobar"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents NroSolicitud As DataGridViewTextBoxColumn
    Private WithEvents Monto As DataGridViewTextBoxColumn
    Private WithEvents Divisa As DataGridViewTextBoxColumn
    Private WithEvents Propietario As DataGridViewTextBoxColumn
    Private WithEvents Banco As DataGridViewTextBoxColumn
    Private WithEvents Estado As DataGridViewTextBoxColumn
    Private WithEvents Aceptar As DataGridViewButtonColumn
    Private WithEvents Declinar As DataGridViewButtonColumn
    Friend WithEvents ButtonSalir As Button
End Class
