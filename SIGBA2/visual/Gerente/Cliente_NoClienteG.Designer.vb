<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente_NoClienteG
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
        Me.buttonNoCliente = New System.Windows.Forms.Button()
        Me.buttonCliente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonNoCliente
        '
        Me.buttonNoCliente.Location = New System.Drawing.Point(12, 133)
        Me.buttonNoCliente.Name = "buttonNoCliente"
        Me.buttonNoCliente.Size = New System.Drawing.Size(260, 23)
        Me.buttonNoCliente.TabIndex = 5
        Me.buttonNoCliente.Text = "No Cliente"
        Me.buttonNoCliente.UseVisualStyleBackColor = True
        '
        'buttonCliente
        '
        Me.buttonCliente.Location = New System.Drawing.Point(12, 104)
        Me.buttonCliente.Name = "buttonCliente"
        Me.buttonCliente.Size = New System.Drawing.Size(260, 23)
        Me.buttonCliente.TabIndex = 4
        Me.buttonCliente.Text = "Cliente"
        Me.buttonCliente.UseVisualStyleBackColor = True
        '
        'Cliente_NoClienteG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.buttonNoCliente)
        Me.Controls.Add(Me.buttonCliente)
        Me.Name = "Cliente_NoClienteG"
        Me.Text = "Cliente_NoClienteG"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents buttonNoCliente As Button
    Private WithEvents buttonCliente As Button
End Class
