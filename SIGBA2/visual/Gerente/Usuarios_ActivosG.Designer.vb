<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios_ActivosG
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
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inicio_Sistema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroAuditorias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cargo, Me.NroEmpleado, Me.Inicio_Sistema, Me.Fecha, Me.NroAuditorias})
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataGridView1.Location = New System.Drawing.Point(0, 42)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.Size = New System.Drawing.Size(427, 219)
        Me.dataGridView1.TabIndex = 1
        '
        'Cargo
        '
        Me.Cargo.HeaderText = "Cargo"
        Me.Cargo.Name = "Cargo"
        Me.Cargo.ReadOnly = True
        '
        'NroEmpleado
        '
        Me.NroEmpleado.HeaderText = "Nº Empleado"
        Me.NroEmpleado.Name = "NroEmpleado"
        Me.NroEmpleado.ReadOnly = True
        '
        'Inicio_Sistema
        '
        Me.Inicio_Sistema.HeaderText = "Inicio en el Sistema"
        Me.Inicio_Sistema.Name = "Inicio_Sistema"
        Me.Inicio_Sistema.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'NroAuditorias
        '
        Me.NroAuditorias.HeaderText = "Nº Auditorías"
        Me.NroAuditorias.Name = "NroAuditorias"
        Me.NroAuditorias.ReadOnly = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(13, 13)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 2
        Me.ButtonSalir.Text = "<"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Usuarios_ActivosG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(427, 261)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Usuarios_ActivosG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios_ActivosG"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents Cargo As DataGridViewTextBoxColumn
    Private WithEvents NroEmpleado As DataGridViewTextBoxColumn
    Private WithEvents Inicio_Sistema As DataGridViewTextBoxColumn
    Private WithEvents Fecha As DataGridViewTextBoxColumn
    Private WithEvents NroAuditorias As DataGridViewTextBoxColumn
    Friend WithEvents ButtonSalir As Button
End Class
