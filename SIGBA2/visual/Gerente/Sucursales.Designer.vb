<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sucursales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero_Puerta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefonos = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Pais = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Esquina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Calle, Me.Numero_Puerta, Me.Telefonos, Me.Pais, Me.Departamento, Me.Esquina})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(843, 220)
        Me.DataGridView1.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Calle
        '
        Me.Calle.HeaderText = "Calle"
        Me.Calle.Name = "Calle"
        '
        'Numero_Puerta
        '
        Me.Numero_Puerta.HeaderText = "Numero de puerta"
        Me.Numero_Puerta.Name = "Numero_Puerta"
        '
        'Telefonos
        '
        Me.Telefonos.HeaderText = "Telefonos"
        Me.Telefonos.Name = "Telefonos"
        '
        'Pais
        '
        Me.Pais.HeaderText = "País"
        Me.Pais.Name = "Pais"
        '
        'Departamento
        '
        Me.Departamento.HeaderText = "Departamento"
        Me.Departamento.Name = "Departamento"
        '
        'Esquina
        '
        Me.Esquina.HeaderText = "Esquina"
        Me.Esquina.Name = "Esquina"
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(13, 13)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 1
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Sucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(843, 262)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Sucursales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sucursales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Calle As DataGridViewTextBoxColumn
    Friend WithEvents Numero_Puerta As DataGridViewTextBoxColumn
    Friend WithEvents Telefonos As DataGridViewComboBoxColumn
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents Pais As DataGridViewTextBoxColumn
    Friend WithEvents Departamento As DataGridViewTextBoxColumn
    Friend WithEvents Esquina As DataGridViewTextBoxColumn
End Class
