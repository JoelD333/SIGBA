<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ver_AuditoriasG
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
        Me.NroEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Emision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroAdvertencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantSuspensiones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroEmpleado, Me.Cargo, Me.Fecha_Emision, Me.NroAdvertencias, Me.Motivo, Me.CantSuspensiones})
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.Size = New System.Drawing.Size(571, 261)
        Me.dataGridView1.TabIndex = 1
        '
        'NroEmpleado
        '
        Me.NroEmpleado.HeaderText = "Nº Empleado"
        Me.NroEmpleado.Name = "NroEmpleado"
        Me.NroEmpleado.ReadOnly = True
        '
        'Cargo
        '
        Me.Cargo.HeaderText = "Cargo"
        Me.Cargo.Name = "Cargo"
        Me.Cargo.ReadOnly = True
        '
        'Fecha_Emision
        '
        Me.Fecha_Emision.HeaderText = "Fecha Emitida"
        Me.Fecha_Emision.Name = "Fecha_Emision"
        Me.Fecha_Emision.ReadOnly = True
        '
        'NroAdvertencias
        '
        Me.NroAdvertencias.HeaderText = "Nº Advertencias"
        Me.NroAdvertencias.Name = "NroAdvertencias"
        Me.NroAdvertencias.ReadOnly = True
        '
        'Motivo
        '
        Me.Motivo.HeaderText = "Motivo"
        Me.Motivo.Name = "Motivo"
        Me.Motivo.ReadOnly = True
        '
        'CantSuspensiones
        '
        Me.CantSuspensiones.HeaderText = "Cantidad de Suspensiones"
        Me.CantSuspensiones.Name = "CantSuspensiones"
        Me.CantSuspensiones.ReadOnly = True
        '
        'Ver_AuditoriasG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 261)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Ver_AuditoriasG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver_AuditoriasG"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents NroEmpleado As DataGridViewTextBoxColumn
    Private WithEvents Cargo As DataGridViewTextBoxColumn
    Private WithEvents Fecha_Emision As DataGridViewTextBoxColumn
    Private WithEvents NroAdvertencias As DataGridViewTextBoxColumn
    Private WithEvents Motivo As DataGridViewTextBoxColumn
    Private WithEvents CantSuspensiones As DataGridViewTextBoxColumn
End Class
