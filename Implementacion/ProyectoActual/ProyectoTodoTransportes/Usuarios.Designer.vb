<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.cbox_TipoUsuario = New System.Windows.Forms.ComboBox()
        Me.cbox_Funcionario = New System.Windows.Forms.ComboBox()
        Me.lbl_TipoUsuario = New System.Windows.Forms.Label()
        Me.lbl_Funcionario = New System.Windows.Forms.Label()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.tbox_NombreUsuario = New System.Windows.Forms.TextBox()
        Me.tbox_Contrasena = New System.Windows.Forms.TextBox()
        Me.lbl_NombreUsuario = New System.Windows.Forms.Label()
        Me.lbl_Contrasena = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbox_TipoUsuario
        '
        Me.cbox_TipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_TipoUsuario.FormattingEnabled = True
        Me.cbox_TipoUsuario.Location = New System.Drawing.Point(158, 33)
        Me.cbox_TipoUsuario.Name = "cbox_TipoUsuario"
        Me.cbox_TipoUsuario.Size = New System.Drawing.Size(288, 21)
        Me.cbox_TipoUsuario.TabIndex = 1
        '
        'cbox_Funcionario
        '
        Me.cbox_Funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Funcionario.FormattingEnabled = True
        Me.cbox_Funcionario.Location = New System.Drawing.Point(158, 6)
        Me.cbox_Funcionario.Name = "cbox_Funcionario"
        Me.cbox_Funcionario.Size = New System.Drawing.Size(288, 21)
        Me.cbox_Funcionario.TabIndex = 0
        '
        'lbl_TipoUsuario
        '
        Me.lbl_TipoUsuario.AutoSize = True
        Me.lbl_TipoUsuario.Location = New System.Drawing.Point(12, 36)
        Me.lbl_TipoUsuario.Name = "lbl_TipoUsuario"
        Me.lbl_TipoUsuario.Size = New System.Drawing.Size(85, 13)
        Me.lbl_TipoUsuario.TabIndex = 6
        Me.lbl_TipoUsuario.Text = "Tipo de Usuario:"
        '
        'lbl_Funcionario
        '
        Me.lbl_Funcionario.AutoSize = True
        Me.lbl_Funcionario.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Funcionario.Name = "lbl_Funcionario"
        Me.lbl_Funcionario.Size = New System.Drawing.Size(65, 13)
        Me.lbl_Funcionario.TabIndex = 7
        Me.lbl_Funcionario.Text = "Funcionario:"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Location = New System.Drawing.Point(371, 183)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 4
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'tbox_NombreUsuario
        '
        Me.tbox_NombreUsuario.Location = New System.Drawing.Point(158, 61)
        Me.tbox_NombreUsuario.MaxLength = 45
        Me.tbox_NombreUsuario.Name = "tbox_NombreUsuario"
        Me.tbox_NombreUsuario.Size = New System.Drawing.Size(288, 20)
        Me.tbox_NombreUsuario.TabIndex = 2
        '
        'tbox_Contrasena
        '
        Me.tbox_Contrasena.Location = New System.Drawing.Point(158, 87)
        Me.tbox_Contrasena.MaxLength = 45
        Me.tbox_Contrasena.Name = "tbox_Contrasena"
        Me.tbox_Contrasena.Size = New System.Drawing.Size(288, 20)
        Me.tbox_Contrasena.TabIndex = 3
        '
        'lbl_NombreUsuario
        '
        Me.lbl_NombreUsuario.AutoSize = True
        Me.lbl_NombreUsuario.Location = New System.Drawing.Point(12, 64)
        Me.lbl_NombreUsuario.Name = "lbl_NombreUsuario"
        Me.lbl_NombreUsuario.Size = New System.Drawing.Size(101, 13)
        Me.lbl_NombreUsuario.TabIndex = 4
        Me.lbl_NombreUsuario.Text = "Nombre de Usuario:"
        '
        'lbl_Contrasena
        '
        Me.lbl_Contrasena.AutoSize = True
        Me.lbl_Contrasena.Location = New System.Drawing.Point(12, 90)
        Me.lbl_Contrasena.Name = "lbl_Contrasena"
        Me.lbl_Contrasena.Size = New System.Drawing.Size(64, 13)
        Me.lbl_Contrasena.TabIndex = 5
        Me.lbl_Contrasena.Text = "Contraseña:"
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 217)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.lbl_Funcionario)
        Me.Controls.Add(Me.lbl_TipoUsuario)
        Me.Controls.Add(Me.lbl_Contrasena)
        Me.Controls.Add(Me.lbl_NombreUsuario)
        Me.Controls.Add(Me.cbox_Funcionario)
        Me.Controls.Add(Me.tbox_Contrasena)
        Me.Controls.Add(Me.tbox_NombreUsuario)
        Me.Controls.Add(Me.cbox_TipoUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Usuarios"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbox_TipoUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents cbox_Funcionario As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_TipoUsuario As System.Windows.Forms.Label
    Friend WithEvents lbl_Funcionario As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbox_NombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents tbox_Contrasena As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NombreUsuario As System.Windows.Forms.Label
    Friend WithEvents lbl_Contrasena As System.Windows.Forms.Label
End Class
