<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cliente_NoClient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.buttonNoCliente = New System.Windows.Forms.Button()
        Me.buttonCliente = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonNoCliente
        '
        Me.buttonNoCliente.Location = New System.Drawing.Point(12, 133)
        Me.buttonNoCliente.Name = "buttonNoCliente"
        Me.buttonNoCliente.Size = New System.Drawing.Size(260, 23)
        Me.buttonNoCliente.TabIndex = 3
        Me.buttonNoCliente.Text = "No Cliente"
        Me.buttonNoCliente.UseVisualStyleBackColor = True
        '
        'buttonCliente
        '
        Me.buttonCliente.Location = New System.Drawing.Point(12, 104)
        Me.buttonCliente.Name = "buttonCliente"
        Me.buttonCliente.Size = New System.Drawing.Size(260, 23)
        Me.buttonCliente.TabIndex = 2
        Me.buttonCliente.Text = "Cliente"
        Me.buttonCliente.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(13, 13)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 4
        Me.ButtonSalir.Text = "Cerrar Caja"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Cliente_NoClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.buttonNoCliente)
        Me.Controls.Add(Me.buttonCliente)
        Me.Name = "Cliente_NoClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente_NoCliente"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents buttonNoCliente As Button
    Private WithEvents buttonCliente As Button
    Friend WithEvents ButtonSalir As Button
End Class
