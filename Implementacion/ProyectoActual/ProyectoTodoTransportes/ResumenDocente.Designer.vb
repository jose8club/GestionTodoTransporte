<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenDocente
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
        Me.list_Docente = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.check_profesores = New System.Windows.Forms.CheckBox()
        Me.check_instructores = New System.Windows.Forms.CheckBox()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.list_Cursos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_patente = New System.Windows.Forms.Label()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'list_Docente
        '
        Me.list_Docente.FormattingEnabled = True
        Me.list_Docente.Location = New System.Drawing.Point(12, 38)
        Me.list_Docente.Name = "list_Docente"
        Me.list_Docente.Size = New System.Drawing.Size(240, 173)
        Me.list_Docente.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 20)
        Me.TextBox1.TabIndex = 1
        '
        'check_profesores
        '
        Me.check_profesores.AutoSize = True
        Me.check_profesores.Location = New System.Drawing.Point(12, 225)
        Me.check_profesores.Name = "check_profesores"
        Me.check_profesores.Size = New System.Drawing.Size(113, 17)
        Me.check_profesores.TabIndex = 2
        Me.check_profesores.Text = "Mostrar profesores"
        Me.check_profesores.UseVisualStyleBackColor = True
        '
        'check_instructores
        '
        Me.check_instructores.AutoSize = True
        Me.check_instructores.Location = New System.Drawing.Point(12, 248)
        Me.check_instructores.Name = "check_instructores"
        Me.check_instructores.Size = New System.Drawing.Size(118, 17)
        Me.check_instructores.TabIndex = 3
        Me.check_instructores.Text = "Mostrar instructores"
        Me.check_instructores.UseVisualStyleBackColor = True
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(358, 40)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Telefono.TabIndex = 4
        Me.lbl_Telefono.Text = "Teléfono:"
        '
        'list_Cursos
        '
        Me.list_Cursos.FormattingEnabled = True
        Me.list_Cursos.Location = New System.Drawing.Point(459, 90)
        Me.list_Cursos.Name = "list_Cursos"
        Me.list_Cursos.Size = New System.Drawing.Size(141, 121)
        Me.list_Cursos.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(360, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cursos asociados:"
        '
        'lbl_patente
        '
        Me.lbl_patente.AutoSize = True
        Me.lbl_patente.Location = New System.Drawing.Point(360, 214)
        Me.lbl_patente.Name = "lbl_patente"
        Me.lbl_patente.Size = New System.Drawing.Size(95, 13)
        Me.lbl_patente.TabIndex = 7
        Me.lbl_patente.Text = "Patente vehículo: "
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(358, 65)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(31, 13)
        Me.lbl_tipo.TabIndex = 8
        Me.lbl_tipo.Text = "Tipo:"
        '
        'ResumenDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 292)
        Me.Controls.Add(Me.lbl_tipo)
        Me.Controls.Add(Me.lbl_patente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.list_Cursos)
        Me.Controls.Add(Me.lbl_Telefono)
        Me.Controls.Add(Me.check_instructores)
        Me.Controls.Add(Me.check_profesores)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.list_Docente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ResumenDocente"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents list_Docente As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents check_profesores As System.Windows.Forms.CheckBox
    Friend WithEvents check_instructores As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents list_Cursos As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_patente As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo As System.Windows.Forms.Label
End Class
