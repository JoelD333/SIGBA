<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aprobaciones
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
        Me.Urgencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Persona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroSolicitud, Me.Urgencia, Me.Nivel, Me.Tipo_Persona, Me.Rubro, Me.Estado, Me.Aceptar, Me.Declinar})
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataGridView1.Location = New System.Drawing.Point(0, 44)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.Size = New System.Drawing.Size(605, 217)
        Me.dataGridView1.TabIndex = 1
        '
        'NroSolicitud
        '
        Me.NroSolicitud.HeaderText = "Nº Solicitud"
        Me.NroSolicitud.Name = "NroSolicitud"
        Me.NroSolicitud.ReadOnly = True
        '
        'Urgencia
        '
        Me.Urgencia.HeaderText = "Urgencia"
        Me.Urgencia.Name = "Urgencia"
        Me.Urgencia.ReadOnly = True
        '
        'Nivel
        '
        Me.Nivel.HeaderText = "Nivel"
        Me.Nivel.Name = "Nivel"
        Me.Nivel.ReadOnly = True
        '
        'Tipo_Persona
        '
        Me.Tipo_Persona.HeaderText = "Tipo_Persona"
        Me.Tipo_Persona.Name = "Tipo_Persona"
        Me.Tipo_Persona.ReadOnly = True
        '
        'Rubro
        '
        Me.Rubro.HeaderText = "Rubro"
        Me.Rubro.Name = "Rubro"
        Me.Rubro.ReadOnly = True
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
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 7
        Me.ButtonSalir.Text = "<"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Aprobaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(605, 261)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Aprobaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aprobaciones"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents NroSolicitud As DataGridViewTextBoxColumn
    Private WithEvents Urgencia As DataGridViewTextBoxColumn
    Private WithEvents Nivel As DataGridViewTextBoxColumn
    Private WithEvents Tipo_Persona As DataGridViewTextBoxColumn
    Private WithEvents Rubro As DataGridViewTextBoxColumn
    Private WithEvents Estado As DataGridViewTextBoxColumn
    Private WithEvents Aceptar As DataGridViewButtonColumn
    Private WithEvents Declinar As DataGridViewButtonColumn
    Friend WithEvents ButtonSalir As Button
End Class
