<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamenEscuela
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
        Me.lbl_estudiante = New System.Windows.Forms.Label()
        Me.cbox_matricula = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbox_funcionario = New System.Windows.Forms.ComboBox()
        Me.date_prueba = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_guradar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbox_tipo = New System.Windows.Forms.ComboBox()
        Me.rbtn_reprobado = New System.Windows.Forms.RadioButton()
        Me.rbtn_aprobado = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtbox_comentario = New System.Windows.Forms.RichTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbox_calTeo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbox_calPract = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.sbox_hor2 = New System.Windows.Forms.NumericUpDown()
        Me.sbox_hor1 = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chbox_cert = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.sbox_hor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbox_hor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_estudiante
        '
        Me.lbl_estudiante.AutoSize = True
        Me.lbl_estudiante.Location = New System.Drawing.Point(268, 52)
        Me.lbl_estudiante.Name = "lbl_estudiante"
        Me.lbl_estudiante.Size = New System.Drawing.Size(39, 13)
        Me.lbl_estudiante.TabIndex = 42
        Me.lbl_estudiante.Text = "Label8"
        '
        'cbox_matricula
        '
        Me.cbox_matricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_matricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_matricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_matricula.FormattingEnabled = True
        Me.cbox_matricula.Location = New System.Drawing.Point(148, 49)
        Me.cbox_matricula.Name = "cbox_matricula"
        Me.cbox_matricula.Size = New System.Drawing.Size(99, 21)
        Me.cbox_matricula.TabIndex = 94
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Registro de Matricula:"
        '
        'cbox_funcionario
        '
        Me.cbox_funcionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_funcionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_funcionario.FormattingEnabled = True
        Me.cbox_funcionario.Location = New System.Drawing.Point(148, 91)
        Me.cbox_funcionario.Name = "cbox_funcionario"
        Me.cbox_funcionario.Size = New System.Drawing.Size(219, 21)
        Me.cbox_funcionario.TabIndex = 95
        '
        'date_prueba
        '
        Me.date_prueba.Location = New System.Drawing.Point(535, 46)
        Me.date_prueba.Name = "date_prueba"
        Me.date_prueba.Size = New System.Drawing.Size(219, 20)
        Me.date_prueba.TabIndex = 96
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Funcionario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(426, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Fecha:"
        '
        'btn_reset
        '
        Me.btn_reset.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON
        Me.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reset.Location = New System.Drawing.Point(429, 311)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(135, 35)
        Me.btn_reset.TabIndex = 108
        Me.btn_reset.Text = "Resetear"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_guradar
        '
        Me.btn_guradar.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.SAVE
        Me.btn_guradar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guradar.Location = New System.Drawing.Point(615, 311)
        Me.btn_guradar.Name = "btn_guradar"
        Me.btn_guradar.Size = New System.Drawing.Size(139, 35)
        Me.btn_guradar.TabIndex = 107
        Me.btn_guradar.Text = "Guardar"
        Me.btn_guradar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Tipo Examen:"
        '
        'cbox_tipo
        '
        Me.cbox_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_tipo.FormattingEnabled = True
        Me.cbox_tipo.Location = New System.Drawing.Point(148, 13)
        Me.cbox_tipo.Name = "cbox_tipo"
        Me.cbox_tipo.Size = New System.Drawing.Size(219, 21)
        Me.cbox_tipo.TabIndex = 93
        '
        'rbtn_reprobado
        '
        Me.rbtn_reprobado.AutoSize = True
        Me.rbtn_reprobado.Location = New System.Drawing.Point(676, 90)
        Me.rbtn_reprobado.Name = "rbtn_reprobado"
        Me.rbtn_reprobado.Size = New System.Drawing.Size(78, 17)
        Me.rbtn_reprobado.TabIndex = 98
        Me.rbtn_reprobado.Text = "Reprobado"
        Me.rbtn_reprobado.UseVisualStyleBackColor = True
        '
        'rbtn_aprobado
        '
        Me.rbtn_aprobado.AutoSize = True
        Me.rbtn_aprobado.Checked = True
        Me.rbtn_aprobado.Location = New System.Drawing.Point(535, 91)
        Me.rbtn_aprobado.Name = "rbtn_aprobado"
        Me.rbtn_aprobado.Size = New System.Drawing.Size(71, 17)
        Me.rbtn_aprobado.TabIndex = 97
        Me.rbtn_aprobado.TabStop = True
        Me.rbtn_aprobado.Text = "Aprobado"
        Me.rbtn_aprobado.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(426, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Estado:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rtbox_comentario)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.tbox_calTeo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbox_calPract)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 202)
        Me.GroupBox1.TabIndex = 98
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Examenes Escuela"
        '
        'rtbox_comentario
        '
        Me.rtbox_comentario.Location = New System.Drawing.Point(183, 103)
        Me.rtbox_comentario.Name = "rtbox_comentario"
        Me.rtbox_comentario.Size = New System.Drawing.Size(200, 93)
        Me.rtbox_comentario.TabIndex = 101
        Me.rtbox_comentario.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 103)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(152, 13)
        Me.Label15.TabIndex = 99
        Me.Label15.Text = "Comentario Examen Municipal:"
        '
        'tbox_calTeo
        '
        Me.tbox_calTeo.Location = New System.Drawing.Point(183, 32)
        Me.tbox_calTeo.Name = "tbox_calTeo"
        Me.tbox_calTeo.Size = New System.Drawing.Size(56, 20)
        Me.tbox_calTeo.TabIndex = 99
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Calificación Examen Teorico:"
        '
        'tbox_calPract
        '
        Me.tbox_calPract.Location = New System.Drawing.Point(183, 64)
        Me.tbox_calPract.Name = "tbox_calPract"
        Me.tbox_calPract.Size = New System.Drawing.Size(56, 20)
        Me.tbox_calPract.TabIndex = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Calificación Examen Práctico:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sbox_hor2)
        Me.GroupBox2.Controls.Add(Me.sbox_hor1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(429, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 72)
        Me.GroupBox2.TabIndex = 99
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cambio Rueda"
        '
        'sbox_hor2
        '
        Me.sbox_hor2.Location = New System.Drawing.Point(211, 31)
        Me.sbox_hor2.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.sbox_hor2.Name = "sbox_hor2"
        Me.sbox_hor2.Size = New System.Drawing.Size(45, 20)
        Me.sbox_hor2.TabIndex = 103
        '
        'sbox_hor1
        '
        Me.sbox_hor1.Location = New System.Drawing.Point(136, 31)
        Me.sbox_hor1.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.sbox_hor1.Name = "sbox_hor1"
        Me.sbox_hor1.Size = New System.Drawing.Size(44, 20)
        Me.sbox_hor1.TabIndex = 102
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(272, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "hrs."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(190, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 24)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Horario:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chbox_cert)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(429, 224)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(325, 67)
        Me.GroupBox3.TabIndex = 100
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Examen Visual"
        '
        'chbox_cert
        '
        Me.chbox_cert.AutoSize = True
        Me.chbox_cert.Location = New System.Drawing.Point(136, 31)
        Me.chbox_cert.Name = "chbox_cert"
        Me.chbox_cert.Size = New System.Drawing.Size(75, 17)
        Me.chbox_cert.TabIndex = 104
        Me.chbox_cert.Text = "Entregado"
        Me.chbox_cert.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Certificado:"
        '
        'ExamenEscuela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 473)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rbtn_reprobado)
        Me.Controls.Add(Me.rbtn_aprobado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbox_tipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_guradar)
        Me.Controls.Add(Me.lbl_estudiante)
        Me.Controls.Add(Me.cbox_matricula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbox_funcionario)
        Me.Controls.Add(Me.date_prueba)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExamenEscuela"
        Me.Text = "ExamenEscuela"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.sbox_hor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbox_hor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_estudiante As System.Windows.Forms.Label
    Friend WithEvents cbox_matricula As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbox_funcionario As System.Windows.Forms.ComboBox
    Friend WithEvents date_prueba As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_reset As System.Windows.Forms.Button
    Friend WithEvents btn_guradar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbox_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents rbtn_reprobado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_aprobado As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbox_calPract As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbox_calTeo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rtbox_comentario As System.Windows.Forms.RichTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents sbox_hor2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents sbox_hor1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chbox_cert As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
