<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAsistencia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbox_curso = New System.Windows.Forms.ComboBox()
        Me.lbl_docente = New System.Windows.Forms.Label()
        Me.cbox_docente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbox_dia = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbox_horario = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.rbtn_teorica = New System.Windows.Forms.RadioButton()
        Me.rbtn_practica = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbox_estudiante = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo Clase:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Curso:"
        '
        'cbox_curso
        '
        Me.cbox_curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_curso.FormattingEnabled = True
        Me.cbox_curso.Location = New System.Drawing.Point(66, 78)
        Me.cbox_curso.Name = "cbox_curso"
        Me.cbox_curso.Size = New System.Drawing.Size(86, 21)
        Me.cbox_curso.TabIndex = 2
        '
        'lbl_docente
        '
        Me.lbl_docente.AutoSize = True
        Me.lbl_docente.Location = New System.Drawing.Point(158, 81)
        Me.lbl_docente.Name = "lbl_docente"
        Me.lbl_docente.Size = New System.Drawing.Size(51, 13)
        Me.lbl_docente.TabIndex = 5
        Me.lbl_docente.Text = "Docente:"
        '
        'cbox_docente
        '
        Me.cbox_docente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_docente.FormattingEnabled = True
        Me.cbox_docente.Location = New System.Drawing.Point(213, 78)
        Me.cbox_docente.Name = "cbox_docente"
        Me.cbox_docente.Size = New System.Drawing.Size(168, 21)
        Me.cbox_docente.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(387, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dia:"
        '
        'cbox_dia
        '
        Me.cbox_dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_dia.FormattingEnabled = True
        Me.cbox_dia.Location = New System.Drawing.Point(419, 78)
        Me.cbox_dia.Name = "cbox_dia"
        Me.cbox_dia.Size = New System.Drawing.Size(86, 21)
        Me.cbox_dia.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(538, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Horario:"
        '
        'cbox_horario
        '
        Me.cbox_horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_horario.FormattingEnabled = True
        Me.cbox_horario.Location = New System.Drawing.Point(581, 78)
        Me.cbox_horario.Name = "cbox_horario"
        Me.cbox_horario.Size = New System.Drawing.Size(112, 21)
        Me.cbox_horario.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 142)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(720, 172)
        Me.DataGridView1.TabIndex = 46
        '
        'btn_reset
        '
        Me.btn_reset.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON
        Me.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reset.Location = New System.Drawing.Point(26, 341)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(152, 40)
        Me.btn_reset.TabIndex = 111
        Me.btn_reset.Text = "Resetear"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.SAVE
        Me.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.Location = New System.Drawing.Point(586, 341)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(160, 40)
        Me.btn_Guardar.TabIndex = 110
        Me.btn_Guardar.Text = "  Guardar"
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'rbtn_teorica
        '
        Me.rbtn_teorica.AutoSize = True
        Me.rbtn_teorica.Location = New System.Drawing.Point(100, 36)
        Me.rbtn_teorica.Name = "rbtn_teorica"
        Me.rbtn_teorica.Size = New System.Drawing.Size(61, 17)
        Me.rbtn_teorica.TabIndex = 112
        Me.rbtn_teorica.TabStop = True
        Me.rbtn_teorica.Text = "Teorica"
        Me.rbtn_teorica.UseVisualStyleBackColor = True
        '
        'rbtn_practica
        '
        Me.rbtn_practica.AutoSize = True
        Me.rbtn_practica.Location = New System.Drawing.Point(213, 36)
        Me.rbtn_practica.Name = "rbtn_practica"
        Me.rbtn_practica.Size = New System.Drawing.Size(64, 17)
        Me.rbtn_practica.TabIndex = 113
        Me.rbtn_practica.TabStop = True
        Me.rbtn_practica.Text = "Practica"
        Me.rbtn_practica.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(387, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Estudiante:"
        '
        'tbox_estudiante
        '
        Me.tbox_estudiante.Location = New System.Drawing.Point(469, 35)
        Me.tbox_estudiante.Name = "tbox_estudiante"
        Me.tbox_estudiante.Size = New System.Drawing.Size(100, 20)
        Me.tbox_estudiante.TabIndex = 115
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(618, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 116
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NewAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 449)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbox_estudiante)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbtn_practica)
        Me.Controls.Add(Me.rbtn_teorica)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbox_horario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbox_dia)
        Me.Controls.Add(Me.lbl_docente)
        Me.Controls.Add(Me.cbox_docente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbox_curso)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewAsistencia"
        Me.Text = "NewAsistencia"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbox_curso As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_docente As System.Windows.Forms.Label
    Friend WithEvents cbox_docente As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbox_dia As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbox_horario As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_reset As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents rbtn_teorica As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_practica As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbox_estudiante As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
