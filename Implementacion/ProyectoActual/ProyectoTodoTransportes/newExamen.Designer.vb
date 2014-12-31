<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newExamen
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
        Me.lbl_TipoExamen = New System.Windows.Forms.Label()
        Me.cbox_TipoExamen = New System.Windows.Forms.ComboBox()
        Me.lbl_RegistroMatricula = New System.Windows.Forms.Label()
        Me.cbox_RegistroMatricula = New System.Windows.Forms.ComboBox()
        Me.lbl_NombreEstudiante = New System.Windows.Forms.Label()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.date_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.cbox_funcionario = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbtn_Aprobado = New System.Windows.Forms.RadioButton()
        Me.rbtn_Reprobado = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.tbox_Comentario = New System.Windows.Forms.RichTextBox()
        Me.tbox_Calificacion = New System.Windows.Forms.TextBox()
        Me.check_Certificado = New System.Windows.Forms.CheckBox()
        Me.sbox_Minutos = New System.Windows.Forms.NumericUpDown()
        Me.sbox_Hora = New System.Windows.Forms.NumericUpDown()
        Me.lbl_hrs = New System.Windows.Forms.Label()
        Me.lbl_dospuntos = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        CType(Me.sbox_Minutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbox_Hora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_TipoExamen
        '
        Me.lbl_TipoExamen.AutoSize = True
        Me.lbl_TipoExamen.Location = New System.Drawing.Point(67, 35)
        Me.lbl_TipoExamen.Name = "lbl_TipoExamen"
        Me.lbl_TipoExamen.Size = New System.Drawing.Size(87, 13)
        Me.lbl_TipoExamen.TabIndex = 0
        Me.lbl_TipoExamen.Text = "Tipo de Examen:"
        '
        'cbox_TipoExamen
        '
        Me.cbox_TipoExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_TipoExamen.FormattingEnabled = True
        Me.cbox_TipoExamen.Location = New System.Drawing.Point(208, 32)
        Me.cbox_TipoExamen.Name = "cbox_TipoExamen"
        Me.cbox_TipoExamen.Size = New System.Drawing.Size(263, 21)
        Me.cbox_TipoExamen.TabIndex = 1
        '
        'lbl_RegistroMatricula
        '
        Me.lbl_RegistroMatricula.AutoSize = True
        Me.lbl_RegistroMatricula.Location = New System.Drawing.Point(67, 80)
        Me.lbl_RegistroMatricula.Name = "lbl_RegistroMatricula"
        Me.lbl_RegistroMatricula.Size = New System.Drawing.Size(112, 13)
        Me.lbl_RegistroMatricula.TabIndex = 2
        Me.lbl_RegistroMatricula.Text = "Registro de Matrícula:"
        '
        'cbox_RegistroMatricula
        '
        Me.cbox_RegistroMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_RegistroMatricula.FormattingEnabled = True
        Me.cbox_RegistroMatricula.Location = New System.Drawing.Point(208, 77)
        Me.cbox_RegistroMatricula.Name = "cbox_RegistroMatricula"
        Me.cbox_RegistroMatricula.Size = New System.Drawing.Size(76, 20)
        Me.cbox_RegistroMatricula.TabIndex = 3
        '
        'lbl_NombreEstudiante
        '
        Me.lbl_NombreEstudiante.AutoSize = True
        Me.lbl_NombreEstudiante.Location = New System.Drawing.Point(305, 80)
        Me.lbl_NombreEstudiante.Name = "lbl_NombreEstudiante"
        Me.lbl_NombreEstudiante.Size = New System.Drawing.Size(0, 13)
        Me.lbl_NombreEstudiante.TabIndex = 4
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.SAVE
        Me.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.Location = New System.Drawing.Point(575, 333)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(160, 40)
        Me.btn_Guardar.TabIndex = 59
        Me.btn_Guardar.Text = "  Guardar"
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'date_Fecha
        '
        Me.date_Fecha.Location = New System.Drawing.Point(208, 142)
        Me.date_Fecha.Name = "date_Fecha"
        Me.date_Fecha.Size = New System.Drawing.Size(263, 20)
        Me.date_Fecha.TabIndex = 60
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(67, 148)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Fecha.TabIndex = 61
        Me.lbl_Fecha.Text = "Fecha:"
        '
        'cbox_funcionario
        '
        Me.cbox_funcionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_funcionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_funcionario.FormattingEnabled = True
        Me.cbox_funcionario.Location = New System.Drawing.Point(208, 106)
        Me.cbox_funcionario.Name = "cbox_funcionario"
        Me.cbox_funcionario.Size = New System.Drawing.Size(263, 21)
        Me.cbox_funcionario.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Funcionario:"
        '
        'rbtn_Aprobado
        '
        Me.rbtn_Aprobado.AutoSize = True
        Me.rbtn_Aprobado.Location = New System.Drawing.Point(208, 184)
        Me.rbtn_Aprobado.Name = "rbtn_Aprobado"
        Me.rbtn_Aprobado.Size = New System.Drawing.Size(71, 17)
        Me.rbtn_Aprobado.TabIndex = 64
        Me.rbtn_Aprobado.TabStop = True
        Me.rbtn_Aprobado.Text = "Aprobado"
        Me.rbtn_Aprobado.UseVisualStyleBackColor = True
        '
        'rbtn_Reprobado
        '
        Me.rbtn_Reprobado.AutoSize = True
        Me.rbtn_Reprobado.Location = New System.Drawing.Point(335, 184)
        Me.rbtn_Reprobado.Name = "rbtn_Reprobado"
        Me.rbtn_Reprobado.Size = New System.Drawing.Size(78, 17)
        Me.rbtn_Reprobado.TabIndex = 65
        Me.rbtn_Reprobado.TabStop = True
        Me.rbtn_Reprobado.Text = "Reprobado"
        Me.rbtn_Reprobado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Estado:"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(67, 221)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(54, 13)
        Me.Label.TabIndex = 67
        Me.Label.Text = "Multilabel:"
        '
        'tbox_Comentario
        '
        Me.tbox_Comentario.Location = New System.Drawing.Point(208, 218)
        Me.tbox_Comentario.Name = "tbox_Comentario"
        Me.tbox_Comentario.Size = New System.Drawing.Size(263, 69)
        Me.tbox_Comentario.TabIndex = 68
        Me.tbox_Comentario.Text = ""
        '
        'tbox_Calificacion
        '
        Me.tbox_Calificacion.Location = New System.Drawing.Point(208, 218)
        Me.tbox_Calificacion.Name = "tbox_Calificacion"
        Me.tbox_Calificacion.Size = New System.Drawing.Size(56, 20)
        Me.tbox_Calificacion.TabIndex = 81
        '
        'check_Certificado
        '
        Me.check_Certificado.AutoSize = True
        Me.check_Certificado.Location = New System.Drawing.Point(208, 216)
        Me.check_Certificado.Name = "check_Certificado"
        Me.check_Certificado.Size = New System.Drawing.Size(75, 17)
        Me.check_Certificado.TabIndex = 82
        Me.check_Certificado.Text = "Entregado"
        Me.check_Certificado.UseVisualStyleBackColor = True
        '
        'sbox_Minutos
        '
        Me.sbox_Minutos.Location = New System.Drawing.Point(283, 215)
        Me.sbox_Minutos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.sbox_Minutos.Name = "sbox_Minutos"
        Me.sbox_Minutos.Size = New System.Drawing.Size(45, 20)
        Me.sbox_Minutos.TabIndex = 86
        '
        'sbox_Hora
        '
        Me.sbox_Hora.Location = New System.Drawing.Point(208, 215)
        Me.sbox_Hora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.sbox_Hora.Name = "sbox_Hora"
        Me.sbox_Hora.Size = New System.Drawing.Size(44, 20)
        Me.sbox_Hora.TabIndex = 85
        '
        'lbl_hrs
        '
        Me.lbl_hrs.AutoSize = True
        Me.lbl_hrs.Location = New System.Drawing.Point(344, 219)
        Me.lbl_hrs.Name = "lbl_hrs"
        Me.lbl_hrs.Size = New System.Drawing.Size(24, 13)
        Me.lbl_hrs.TabIndex = 84
        Me.lbl_hrs.Text = "hrs."
        '
        'lbl_dospuntos
        '
        Me.lbl_dospuntos.AutoSize = True
        Me.lbl_dospuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dospuntos.Location = New System.Drawing.Point(262, 211)
        Me.lbl_dospuntos.Name = "lbl_dospuntos"
        Me.lbl_dospuntos.Size = New System.Drawing.Size(15, 24)
        Me.lbl_dospuntos.TabIndex = 83
        Me.lbl_dospuntos.Text = ":"
        '
        'btn_reset
        '
        Me.btn_reset.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON
        Me.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reset.Location = New System.Drawing.Point(70, 333)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(152, 40)
        Me.btn_reset.TabIndex = 109
        Me.btn_reset.Text = "Resetear"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'newExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 400)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.sbox_Minutos)
        Me.Controls.Add(Me.sbox_Hora)
        Me.Controls.Add(Me.lbl_hrs)
        Me.Controls.Add(Me.lbl_dospuntos)
        Me.Controls.Add(Me.check_Certificado)
        Me.Controls.Add(Me.tbox_Calificacion)
        Me.Controls.Add(Me.tbox_Comentario)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbtn_Reprobado)
        Me.Controls.Add(Me.rbtn_Aprobado)
        Me.Controls.Add(Me.cbox_funcionario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.date_Fecha)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.lbl_NombreEstudiante)
        Me.Controls.Add(Me.cbox_RegistroMatricula)
        Me.Controls.Add(Me.lbl_RegistroMatricula)
        Me.Controls.Add(Me.cbox_TipoExamen)
        Me.Controls.Add(Me.lbl_TipoExamen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newExamen"
        Me.Text = "newExamen"
        CType(Me.sbox_Minutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbox_Hora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_TipoExamen As System.Windows.Forms.Label
    Friend WithEvents cbox_TipoExamen As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_RegistroMatricula As System.Windows.Forms.Label
    Friend WithEvents cbox_RegistroMatricula As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_NombreEstudiante As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents date_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents cbox_funcionario As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbtn_Aprobado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_Reprobado As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents tbox_Comentario As System.Windows.Forms.RichTextBox
    Friend WithEvents tbox_Calificacion As System.Windows.Forms.TextBox
    Friend WithEvents check_Certificado As System.Windows.Forms.CheckBox
    Friend WithEvents sbox_Minutos As System.Windows.Forms.NumericUpDown
    Friend WithEvents sbox_Hora As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_hrs As System.Windows.Forms.Label
    Friend WithEvents lbl_dospuntos As System.Windows.Forms.Label
    Friend WithEvents btn_reset As System.Windows.Forms.Button
End Class
