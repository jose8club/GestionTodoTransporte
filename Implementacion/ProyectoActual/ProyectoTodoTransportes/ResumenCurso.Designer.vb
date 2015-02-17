<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenCurso
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
        Me.tbox_search = New System.Windows.Forms.TextBox()
        Me.list_Curso = New System.Windows.Forms.ListBox()
        Me.check_Otros = New System.Windows.Forms.CheckBox()
        Me.check_Maquinaria = New System.Windows.Forms.CheckBox()
        Me.check_Profesional = New System.Windows.Forms.CheckBox()
        Me.check_Particular = New System.Windows.Forms.CheckBox()
        Me.lbl_Area = New System.Windows.Forms.Label()
        Me.lbl_Producto = New System.Windows.Forms.Label()
        Me.list_Profesores = New System.Windows.Forms.ListBox()
        Me.lbl_Profesores = New System.Windows.Forms.Label()
        Me.lbl_Alumnos = New System.Windows.Forms.Label()
        Me.list_Alumnos = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'tbox_search
        '
        Me.tbox_search.Location = New System.Drawing.Point(12, 16)
        Me.tbox_search.Name = "tbox_search"
        Me.tbox_search.Size = New System.Drawing.Size(214, 20)
        Me.tbox_search.TabIndex = 3
        '
        'list_Curso
        '
        Me.list_Curso.FormattingEnabled = True
        Me.list_Curso.Location = New System.Drawing.Point(12, 42)
        Me.list_Curso.Name = "list_Curso"
        Me.list_Curso.Size = New System.Drawing.Size(214, 173)
        Me.list_Curso.TabIndex = 2
        '
        'check_Otros
        '
        Me.check_Otros.AutoSize = True
        Me.check_Otros.Location = New System.Drawing.Point(12, 291)
        Me.check_Otros.Name = "check_Otros"
        Me.check_Otros.Size = New System.Drawing.Size(86, 17)
        Me.check_Otros.TabIndex = 4
        Me.check_Otros.Text = "Otros Cursos"
        Me.check_Otros.UseVisualStyleBackColor = True
        '
        'check_Maquinaria
        '
        Me.check_Maquinaria.AutoSize = True
        Me.check_Maquinaria.Location = New System.Drawing.Point(12, 268)
        Me.check_Maquinaria.Name = "check_Maquinaria"
        Me.check_Maquinaria.Size = New System.Drawing.Size(152, 17)
        Me.check_Maquinaria.TabIndex = 5
        Me.check_Maquinaria.Text = "Cursos Maquinaria Pesada"
        Me.check_Maquinaria.UseVisualStyleBackColor = True
        '
        'check_Profesional
        '
        Me.check_Profesional.AutoSize = True
        Me.check_Profesional.Location = New System.Drawing.Point(12, 245)
        Me.check_Profesional.Name = "check_Profesional"
        Me.check_Profesional.Size = New System.Drawing.Size(124, 17)
        Me.check_Profesional.TabIndex = 6
        Me.check_Profesional.Text = "Cursos Profesionales"
        Me.check_Profesional.UseVisualStyleBackColor = True
        '
        'check_Particular
        '
        Me.check_Particular.AutoSize = True
        Me.check_Particular.Location = New System.Drawing.Point(12, 222)
        Me.check_Particular.Name = "check_Particular"
        Me.check_Particular.Size = New System.Drawing.Size(116, 17)
        Me.check_Particular.TabIndex = 7
        Me.check_Particular.Text = "Cursos Particulares"
        Me.check_Particular.UseVisualStyleBackColor = True
        '
        'lbl_Area
        '
        Me.lbl_Area.AutoSize = True
        Me.lbl_Area.Location = New System.Drawing.Point(314, 42)
        Me.lbl_Area.Name = "lbl_Area"
        Me.lbl_Area.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Area.TabIndex = 8
        Me.lbl_Area.Text = "Label1"
        '
        'lbl_Producto
        '
        Me.lbl_Producto.AutoSize = True
        Me.lbl_Producto.Location = New System.Drawing.Point(314, 75)
        Me.lbl_Producto.Name = "lbl_Producto"
        Me.lbl_Producto.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Producto.TabIndex = 9
        Me.lbl_Producto.Text = "Label1"
        '
        'list_Profesores
        '
        Me.list_Profesores.FormattingEnabled = True
        Me.list_Profesores.Location = New System.Drawing.Point(432, 107)
        Me.list_Profesores.Name = "list_Profesores"
        Me.list_Profesores.Size = New System.Drawing.Size(148, 82)
        Me.list_Profesores.TabIndex = 10
        '
        'lbl_Profesores
        '
        Me.lbl_Profesores.AutoSize = True
        Me.lbl_Profesores.Location = New System.Drawing.Point(314, 107)
        Me.lbl_Profesores.Name = "lbl_Profesores"
        Me.lbl_Profesores.Size = New System.Drawing.Size(112, 13)
        Me.lbl_Profesores.TabIndex = 11
        Me.lbl_Profesores.Text = "Profesores Asociados:"
        '
        'lbl_Alumnos
        '
        Me.lbl_Alumnos.AutoSize = True
        Me.lbl_Alumnos.Location = New System.Drawing.Point(314, 200)
        Me.lbl_Alumnos.Name = "lbl_Alumnos"
        Me.lbl_Alumnos.Size = New System.Drawing.Size(102, 13)
        Me.lbl_Alumnos.TabIndex = 13
        Me.lbl_Alumnos.Text = "Alumnos Asociados:"
        '
        'list_Alumnos
        '
        Me.list_Alumnos.FormattingEnabled = True
        Me.list_Alumnos.Location = New System.Drawing.Point(432, 200)
        Me.list_Alumnos.Name = "list_Alumnos"
        Me.list_Alumnos.Size = New System.Drawing.Size(148, 108)
        Me.list_Alumnos.TabIndex = 12
        '
        'ResumenCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 368)
        Me.Controls.Add(Me.lbl_Alumnos)
        Me.Controls.Add(Me.list_Alumnos)
        Me.Controls.Add(Me.lbl_Profesores)
        Me.Controls.Add(Me.list_Profesores)
        Me.Controls.Add(Me.lbl_Producto)
        Me.Controls.Add(Me.lbl_Area)
        Me.Controls.Add(Me.check_Particular)
        Me.Controls.Add(Me.check_Profesional)
        Me.Controls.Add(Me.check_Maquinaria)
        Me.Controls.Add(Me.check_Otros)
        Me.Controls.Add(Me.tbox_search)
        Me.Controls.Add(Me.list_Curso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ResumenCurso"
        Me.Text = "ResumenCurso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbox_search As System.Windows.Forms.TextBox
    Friend WithEvents list_Curso As System.Windows.Forms.ListBox
    Friend WithEvents check_Otros As System.Windows.Forms.CheckBox
    Friend WithEvents check_Maquinaria As System.Windows.Forms.CheckBox
    Friend WithEvents check_Profesional As System.Windows.Forms.CheckBox
    Friend WithEvents check_Particular As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Area As System.Windows.Forms.Label
    Friend WithEvents lbl_Producto As System.Windows.Forms.Label
    Friend WithEvents list_Profesores As System.Windows.Forms.ListBox
    Friend WithEvents lbl_Profesores As System.Windows.Forms.Label
    Friend WithEvents lbl_Alumnos As System.Windows.Forms.Label
    Friend WithEvents list_Alumnos As System.Windows.Forms.ListBox
End Class
