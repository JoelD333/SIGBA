<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonaFisica_JuridicaG
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
        Me.buttonPersonaJuridica = New System.Windows.Forms.Button()
        Me.buttonPersonaFisica = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonPersonaJuridica
        '
        Me.buttonPersonaJuridica.Location = New System.Drawing.Point(12, 133)
        Me.buttonPersonaJuridica.Name = "buttonPersonaJuridica"
        Me.buttonPersonaJuridica.Size = New System.Drawing.Size(260, 23)
        Me.buttonPersonaJuridica.TabIndex = 7
        Me.buttonPersonaJuridica.Text = "Persona Juridica"
        Me.buttonPersonaJuridica.UseVisualStyleBackColor = True
        '
        'buttonPersonaFisica
        '
        Me.buttonPersonaFisica.Location = New System.Drawing.Point(12, 104)
        Me.buttonPersonaFisica.Name = "buttonPersonaFisica"
        Me.buttonPersonaFisica.Size = New System.Drawing.Size(260, 23)
        Me.buttonPersonaFisica.TabIndex = 6
        Me.buttonPersonaFisica.Text = "Persona Fisica"
        Me.buttonPersonaFisica.UseVisualStyleBackColor = True
        '
        'PersonaFisica_JuridicaG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.buttonPersonaJuridica)
        Me.Controls.Add(Me.buttonPersonaFisica)
        Me.Name = "PersonaFisica_JuridicaG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PersonaFisica_JuridicaG"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents buttonPersonaJuridica As Button
    Private WithEvents buttonPersonaFisica As Button
End Class
