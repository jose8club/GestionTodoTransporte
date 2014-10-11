<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bienvenido
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
        Me.tbox_Bienvenido = New System.Windows.Forms.TextBox()
        Me.tbox_Usuario = New System.Windows.Forms.TextBox()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_Contra = New System.Windows.Forms.Label()
        Me.tbox_Contra = New System.Windows.Forms.TextBox()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.tbox_Mensaje = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbox_Bienvenido
        '
        Me.tbox_Bienvenido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbox_Bienvenido.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbox_Bienvenido.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbox_Bienvenido.Location = New System.Drawing.Point(12, 12)
        Me.tbox_Bienvenido.Multiline = True
        Me.tbox_Bienvenido.Name = "tbox_Bienvenido"
        Me.tbox_Bienvenido.ReadOnly = True
        Me.tbox_Bienvenido.Size = New System.Drawing.Size(326, 48)
        Me.tbox_Bienvenido.TabIndex = 3
        Me.tbox_Bienvenido.Text = "Bienvenido al Sistema de Gestión TodoTransportes. Para comenzar ingrese su nombre" & _
            " de usuario y contraseña."
        Me.tbox_Bienvenido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbox_Usuario
        '
        Me.tbox_Usuario.Location = New System.Drawing.Point(135, 66)
        Me.tbox_Usuario.Name = "tbox_Usuario"
        Me.tbox_Usuario.Size = New System.Drawing.Size(151, 20)
        Me.tbox_Usuario.TabIndex = 1
        Me.tbox_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(65, 69)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Usuario.TabIndex = 3
        Me.lbl_Usuario.Text = "Usuario:"
        '
        'lbl_Contra
        '
        Me.lbl_Contra.AutoSize = True
        Me.lbl_Contra.Location = New System.Drawing.Point(65, 95)
        Me.lbl_Contra.Name = "lbl_Contra"
        Me.lbl_Contra.Size = New System.Drawing.Size(64, 13)
        Me.lbl_Contra.TabIndex = 5
        Me.lbl_Contra.Text = "Contraseña:"
        '
        'tbox_Contra
        '
        Me.tbox_Contra.Location = New System.Drawing.Point(135, 92)
        Me.tbox_Contra.Name = "tbox_Contra"
        Me.tbox_Contra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tbox_Contra.Size = New System.Drawing.Size(151, 20)
        Me.tbox_Contra.TabIndex = 2
        Me.tbox_Contra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Login
        '
        Me.btn_Login.Location = New System.Drawing.Point(124, 157)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(102, 23)
        Me.btn_Login.TabIndex = 6
        Me.btn_Login.Text = "Iniciar Sesión"
        Me.btn_Login.UseVisualStyleBackColor = True
        '
        'tbox_Mensaje
        '
        Me.tbox_Mensaje.BackColor = System.Drawing.SystemColors.Control
        Me.tbox_Mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbox_Mensaje.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbox_Mensaje.ForeColor = System.Drawing.Color.Red
        Me.tbox_Mensaje.Location = New System.Drawing.Point(12, 131)
        Me.tbox_Mensaje.Name = "tbox_Mensaje"
        Me.tbox_Mensaje.ReadOnly = True
        Me.tbox_Mensaje.Size = New System.Drawing.Size(326, 13)
        Me.tbox_Mensaje.TabIndex = 7
        Me.tbox_Mensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bienvenido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 192)
        Me.Controls.Add(Me.tbox_Mensaje)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.lbl_Contra)
        Me.Controls.Add(Me.tbox_Contra)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.tbox_Usuario)
        Me.Controls.Add(Me.tbox_Bienvenido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Bienvenido"
        Me.Text = "Iniciar Sesión..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbox_Bienvenido As System.Windows.Forms.TextBox
    Friend WithEvents tbox_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_Contra As System.Windows.Forms.Label
    Friend WithEvents tbox_Contra As System.Windows.Forms.TextBox
    Friend WithEvents btn_Login As System.Windows.Forms.Button
    Friend WithEvents tbox_Mensaje As System.Windows.Forms.TextBox
End Class
