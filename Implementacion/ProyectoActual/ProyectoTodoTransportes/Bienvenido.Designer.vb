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
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.Estado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STATUS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.StatusBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbox_Bienvenido
        '
        Me.tbox_Bienvenido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbox_Bienvenido.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbox_Bienvenido.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbox_Bienvenido.Location = New System.Drawing.Point(36, 185)
        Me.tbox_Bienvenido.Multiline = True
        Me.tbox_Bienvenido.Name = "tbox_Bienvenido"
        Me.tbox_Bienvenido.ReadOnly = True
        Me.tbox_Bienvenido.Size = New System.Drawing.Size(326, 48)
        Me.tbox_Bienvenido.TabIndex = 4
        Me.tbox_Bienvenido.Text = "Bienvenido al Sistema de Gestión Académica de Todo Transporte. Para comenzar ingr" & _
            "ese sus datos de inicio de sesión."
        Me.tbox_Bienvenido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbox_Usuario
        '
        Me.tbox_Usuario.Location = New System.Drawing.Point(124, 241)
        Me.tbox_Usuario.MaxLength = 45
        Me.tbox_Usuario.Name = "tbox_Usuario"
        Me.tbox_Usuario.Size = New System.Drawing.Size(151, 20)
        Me.tbox_Usuario.TabIndex = 1
        Me.tbox_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(176, 225)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Usuario.TabIndex = 3
        Me.lbl_Usuario.Text = "Usuario:"
        '
        'lbl_Contra
        '
        Me.lbl_Contra.AutoSize = True
        Me.lbl_Contra.Location = New System.Drawing.Point(167, 264)
        Me.lbl_Contra.Name = "lbl_Contra"
        Me.lbl_Contra.Size = New System.Drawing.Size(64, 13)
        Me.lbl_Contra.TabIndex = 5
        Me.lbl_Contra.Text = "Contraseña:"
        '
        'tbox_Contra
        '
        Me.tbox_Contra.Location = New System.Drawing.Point(124, 280)
        Me.tbox_Contra.MaxLength = 45
        Me.tbox_Contra.Name = "tbox_Contra"
        Me.tbox_Contra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tbox_Contra.Size = New System.Drawing.Size(151, 20)
        Me.tbox_Contra.TabIndex = 2
        Me.tbox_Contra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Estado})
        Me.StatusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.StatusBar.Location = New System.Drawing.Point(0, 376)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(399, 22)
        Me.StatusBar.TabIndex = 6
        Me.StatusBar.Text = "StatusStrip1"
        '
        'Estado
        '
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(0, 17)
        '
        'STATUS
        '
        Me.STATUS.Name = "STATUS"
        Me.STATUS.Size = New System.Drawing.Size(0, 17)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(2, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(395, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btn_Login
        '
        Me.btn_Login.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.USER
        Me.btn_Login.Location = New System.Drawing.Point(109, 323)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(180, 40)
        Me.btn_Login.TabIndex = 3
        Me.btn_Login.Text = "Iniciar Sesión"
        Me.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Login.UseVisualStyleBackColor = True
        '
        'Bienvenido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 398)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusBar)
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
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbox_Bienvenido As System.Windows.Forms.TextBox
    Friend WithEvents tbox_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_Contra As System.Windows.Forms.Label
    Friend WithEvents tbox_Contra As System.Windows.Forms.TextBox
    Friend WithEvents btn_Login As System.Windows.Forms.Button
    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents STATUS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Estado As System.Windows.Forms.ToolStripStatusLabel
End Class
