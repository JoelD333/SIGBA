<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ver_AuditoriasEmpleadoG
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
        Me.textBoxNroEmpleado = New System.Windows.Forms.TextBox()
        Me.labelNroEmpleado = New System.Windows.Forms.Label()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NroAuditoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Emision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Advertencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Suspension = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textBoxNroEmpleado
        '
        Me.textBoxNroEmpleado.Location = New System.Drawing.Point(90, 6)
        Me.textBoxNroEmpleado.Name = "textBoxNroEmpleado"
        Me.textBoxNroEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.textBoxNroEmpleado.TabIndex = 6
        '
        'labelNroEmpleado
        '
        Me.labelNroEmpleado.AutoSize = True
        Me.labelNroEmpleado.Location = New System.Drawing.Point(12, 9)
        Me.labelNroEmpleado.Name = "labelNroEmpleado"
        Me.labelNroEmpleado.Size = New System.Drawing.Size(72, 13)
        Me.labelNroEmpleado.TabIndex = 5
        Me.labelNroEmpleado.Text = "Nº Empleado:"
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroAuditoria, Me.Motivo, Me.Fecha_Emision, Me.Advertencia, Me.Suspension})
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataGridView1.Location = New System.Drawing.Point(0, 35)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.Size = New System.Drawing.Size(552, 226)
        Me.dataGridView1.TabIndex = 4
        '
        'NroAuditoria
        '
        Me.NroAuditoria.HeaderText = "Nº Auditoría"
        Me.NroAuditoria.Name = "NroAuditoria"
        Me.NroAuditoria.ReadOnly = True
        '
        'Motivo
        '
        Me.Motivo.HeaderText = "Motivo"
        Me.Motivo.Name = "Motivo"
        Me.Motivo.ReadOnly = True
        '
        'Fecha_Emision
        '
        Me.Fecha_Emision.HeaderText = "Fecha Emision"
        Me.Fecha_Emision.Name = "Fecha_Emision"
        Me.Fecha_Emision.ReadOnly = True
        '
        'Advertencia
        '
        Me.Advertencia.HeaderText = "Advertencia"
        Me.Advertencia.Name = "Advertencia"
        Me.Advertencia.ReadOnly = True
        '
        'Suspension
        '
        Me.Suspension.HeaderText = "Suspensiones"
        Me.Suspension.Name = "Suspension"
        Me.Suspension.ReadOnly = True
        '
        'Ver_AuditoriasEmpleadoG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 261)
        Me.Controls.Add(Me.textBoxNroEmpleado)
        Me.Controls.Add(Me.labelNroEmpleado)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Ver_AuditoriasEmpleadoG"
        Me.Text = "Ver_AuditoriasEmpleadoG"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBoxNroEmpleado As TextBox
    Private WithEvents labelNroEmpleado As Label
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents NroAuditoria As DataGridViewTextBoxColumn
    Private WithEvents Motivo As DataGridViewTextBoxColumn
    Private WithEvents Fecha_Emision As DataGridViewTextBoxColumn
    Private WithEvents Advertencia As DataGridViewTextBoxColumn
    Private WithEvents Suspension As DataGridViewTextBoxColumn
End Class
