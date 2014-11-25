<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Funcionario
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
        Me.lbl_Contrasena = New System.Windows.Forms.Label()
        Me.lbl_NombreUsuario = New System.Windows.Forms.Label()
        Me.tbox_Tipo = New System.Windows.Forms.TextBox()
        Me.tbox_NombreFuncionario = New System.Windows.Forms.TextBox()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Contrasena
        '
        Me.lbl_Contrasena.AutoSize = True
        Me.lbl_Contrasena.Location = New System.Drawing.Point(7, 41)
        Me.lbl_Contrasena.Name = "lbl_Contrasena"
        Me.lbl_Contrasena.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Contrasena.TabIndex = 9
        Me.lbl_Contrasena.Text = "Tipo:"
        '
        'lbl_NombreUsuario
        '
        Me.lbl_NombreUsuario.AutoSize = True
        Me.lbl_NombreUsuario.Location = New System.Drawing.Point(7, 15)
        Me.lbl_NombreUsuario.Name = "lbl_NombreUsuario"
        Me.lbl_NombreUsuario.Size = New System.Drawing.Size(120, 13)
        Me.lbl_NombreUsuario.TabIndex = 8
        Me.lbl_NombreUsuario.Text = "Nombre de Funcionario:"
        '
        'tbox_Tipo
        '
        Me.tbox_Tipo.Location = New System.Drawing.Point(153, 38)
        Me.tbox_Tipo.Name = "tbox_Tipo"
        Me.tbox_Tipo.Size = New System.Drawing.Size(288, 20)
        Me.tbox_Tipo.TabIndex = 7
        '
        'tbox_NombreFuncionario
        '
        Me.tbox_NombreFuncionario.Location = New System.Drawing.Point(153, 12)
        Me.tbox_NombreFuncionario.Name = "tbox_NombreFuncionario"
        Me.tbox_NombreFuncionario.Size = New System.Drawing.Size(288, 20)
        Me.tbox_NombreFuncionario.TabIndex = 6
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Location = New System.Drawing.Point(366, 161)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 10
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Funcionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 196)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.lbl_Contrasena)
        Me.Controls.Add(Me.lbl_NombreUsuario)
        Me.Controls.Add(Me.tbox_Tipo)
        Me.Controls.Add(Me.tbox_NombreFuncionario)
        Me.Name = "Funcionario"
        Me.Text = "Funcionario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Contrasena As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreUsuario As System.Windows.Forms.Label
    Friend WithEvents tbox_Tipo As System.Windows.Forms.TextBox
    Friend WithEvents tbox_NombreFuncionario As System.Windows.Forms.TextBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
End Class
