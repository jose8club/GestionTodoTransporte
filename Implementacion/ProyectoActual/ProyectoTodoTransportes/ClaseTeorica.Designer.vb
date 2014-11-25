<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaseTeorica
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
        Me.btn_teorica = New System.Windows.Forms.Button()
        Me.cbox_Profesor = New System.Windows.Forms.ComboBox()
        Me.tbox_Duracion = New System.Windows.Forms.TextBox()
        Me.cbox_Curso = New System.Windows.Forms.ComboBox()
        Me.tbox_Codigo = New System.Windows.Forms.TextBox()
        Me.lbl_Profesor = New System.Windows.Forms.Label()
        Me.lbl_Duracion = New System.Windows.Forms.Label()
        Me.lbl_Horario = New System.Windows.Forms.Label()
        Me.lbl_Curso = New System.Windows.Forms.Label()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_teorica
        '
        Me.btn_teorica.Enabled = False
        Me.btn_teorica.Location = New System.Drawing.Point(300, 217)
        Me.btn_teorica.Name = "btn_teorica"
        Me.btn_teorica.Size = New System.Drawing.Size(101, 23)
        Me.btn_teorica.TabIndex = 21
        Me.btn_teorica.Text = "Guardar"
        Me.btn_teorica.UseVisualStyleBackColor = True
        '
        'cbox_Profesor
        '
        Me.cbox_Profesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Profesor.FormattingEnabled = True
        Me.cbox_Profesor.Location = New System.Drawing.Point(145, 157)
        Me.cbox_Profesor.Name = "cbox_Profesor"
        Me.cbox_Profesor.Size = New System.Drawing.Size(256, 21)
        Me.cbox_Profesor.TabIndex = 20
        '
        'tbox_Duracion
        '
        Me.tbox_Duracion.Location = New System.Drawing.Point(145, 122)
        Me.tbox_Duracion.MaxLength = 3
        Me.tbox_Duracion.Name = "tbox_Duracion"
        Me.tbox_Duracion.Size = New System.Drawing.Size(210, 20)
        Me.tbox_Duracion.TabIndex = 19
        Me.tbox_Duracion.Text = "00"
        Me.tbox_Duracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbox_Curso
        '
        Me.cbox_Curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Curso.FormattingEnabled = True
        Me.cbox_Curso.Location = New System.Drawing.Point(145, 47)
        Me.cbox_Curso.Name = "cbox_Curso"
        Me.cbox_Curso.Size = New System.Drawing.Size(256, 21)
        Me.cbox_Curso.TabIndex = 17
        '
        'tbox_Codigo
        '
        Me.tbox_Codigo.Location = New System.Drawing.Point(145, 12)
        Me.tbox_Codigo.MaxLength = 10
        Me.tbox_Codigo.Name = "tbox_Codigo"
        Me.tbox_Codigo.Size = New System.Drawing.Size(256, 20)
        Me.tbox_Codigo.TabIndex = 16
        '
        'lbl_Profesor
        '
        Me.lbl_Profesor.AutoSize = True
        Me.lbl_Profesor.Location = New System.Drawing.Point(12, 160)
        Me.lbl_Profesor.Name = "lbl_Profesor"
        Me.lbl_Profesor.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Profesor.TabIndex = 15
        Me.lbl_Profesor.Text = "Profesor:"
        '
        'lbl_Duracion
        '
        Me.lbl_Duracion.AutoSize = True
        Me.lbl_Duracion.Location = New System.Drawing.Point(12, 125)
        Me.lbl_Duracion.Name = "lbl_Duracion"
        Me.lbl_Duracion.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Duracion.TabIndex = 14
        Me.lbl_Duracion.Text = "Duracion:"
        '
        'lbl_Horario
        '
        Me.lbl_Horario.AutoSize = True
        Me.lbl_Horario.Location = New System.Drawing.Point(12, 91)
        Me.lbl_Horario.Name = "lbl_Horario"
        Me.lbl_Horario.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Horario.TabIndex = 13
        Me.lbl_Horario.Text = "Horario:"
        '
        'lbl_Curso
        '
        Me.lbl_Curso.AutoSize = True
        Me.lbl_Curso.Location = New System.Drawing.Point(12, 50)
        Me.lbl_Curso.Name = "lbl_Curso"
        Me.lbl_Curso.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Curso.TabIndex = 12
        Me.lbl_Curso.Text = "Curso:"
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(12, 12)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Codigo.TabIndex = 11
        Me.lbl_Codigo.Text = "Código:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(145, 88)
        Me.TextBox1.MaxLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(94, 20)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = "00"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(261, 88)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(94, 20)
        Me.TextBox2.TabIndex = 23
        Me.TextBox2.Text = "00"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(245, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(375, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Hrs."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(375, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Mins."
        '
        'ClaseTeorica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 380)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_teorica)
        Me.Controls.Add(Me.cbox_Profesor)
        Me.Controls.Add(Me.tbox_Duracion)
        Me.Controls.Add(Me.cbox_Curso)
        Me.Controls.Add(Me.tbox_Codigo)
        Me.Controls.Add(Me.lbl_Profesor)
        Me.Controls.Add(Me.lbl_Duracion)
        Me.Controls.Add(Me.lbl_Horario)
        Me.Controls.Add(Me.lbl_Curso)
        Me.Controls.Add(Me.lbl_Codigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClaseTeorica"
        Me.Text = "ClaseTeorica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_teorica As System.Windows.Forms.Button
    Friend WithEvents cbox_Profesor As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_Duracion As System.Windows.Forms.TextBox
    Friend WithEvents cbox_Curso As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Profesor As System.Windows.Forms.Label
    Friend WithEvents lbl_Duracion As System.Windows.Forms.Label
    Friend WithEvents lbl_Horario As System.Windows.Forms.Label
    Friend WithEvents lbl_Curso As System.Windows.Forms.Label
    Friend WithEvents lbl_Codigo As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
