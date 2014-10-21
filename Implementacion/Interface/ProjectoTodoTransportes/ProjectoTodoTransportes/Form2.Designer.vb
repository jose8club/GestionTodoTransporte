<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.datetp_atencion = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbox_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.tbox_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.tbox_rut1 = New System.Windows.Forms.TextBox()
        Me.lbl_rut = New System.Windows.Forms.Label()
        Me.tbox_rut2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_practicodisp = New System.Windows.Forms.Button()
        Me.cbox_practico = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_dispteorico = New System.Windows.Forms.Button()
        Me.cbox_teorico = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chbox_notarial = New System.Windows.Forms.CheckBox()
        Me.chbox_regular = New System.Windows.Forms.CheckBox()
        Me.chbox_estudios = New System.Windows.Forms.CheckBox()
        Me.chbox_foto = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbox_codigo_pago = New System.Windows.Forms.TextBox()
        Me.tbox_nmatricula = New System.Windows.Forms.TextBox()
        Me.cbox_medio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_valor_curso = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chbox_pago = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_estudiante = New System.Windows.Forms.Button()
        Me.lbl_curso = New System.Windows.Forms.Label()
        Me.cbox_curso = New System.Windows.Forms.ComboBox()
        Me.tbox_telefono = New System.Windows.Forms.TextBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_mensaje_conf = New System.Windows.Forms.Label()
        Me.lbl_edad = New System.Windows.Forms.Label()
        Me.tbox_edad = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'datetp_atencion
        '
        Me.datetp_atencion.Location = New System.Drawing.Point(172, 195)
        Me.datetp_atencion.Name = "datetp_atencion"
        Me.datetp_atencion.Size = New System.Drawing.Size(285, 20)
        Me.datetp_atencion.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha de Atención"
        '
        'tbox_nombre
        '
        Me.tbox_nombre.Location = New System.Drawing.Point(172, 23)
        Me.tbox_nombre.Name = "tbox_nombre"
        Me.tbox_nombre.Size = New System.Drawing.Size(286, 20)
        Me.tbox_nombre.TabIndex = 1
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(43, 26)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(49, 13)
        Me.lbl_nombre.TabIndex = 5
        Me.lbl_nombre.Text = "Nombres" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tbox_apellido
        '
        Me.tbox_apellido.Location = New System.Drawing.Point(172, 74)
        Me.tbox_apellido.Name = "tbox_apellido"
        Me.tbox_apellido.Size = New System.Drawing.Size(285, 20)
        Me.tbox_apellido.TabIndex = 2
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(43, 77)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(49, 13)
        Me.lbl_apellido.TabIndex = 10
        Me.lbl_apellido.Text = "Apellidos"
        '
        'tbox_rut1
        '
        Me.tbox_rut1.Location = New System.Drawing.Point(172, 121)
        Me.tbox_rut1.Name = "tbox_rut1"
        Me.tbox_rut1.Size = New System.Drawing.Size(217, 20)
        Me.tbox_rut1.TabIndex = 3
        '
        'lbl_rut
        '
        Me.lbl_rut.AutoSize = True
        Me.lbl_rut.Location = New System.Drawing.Point(43, 123)
        Me.lbl_rut.Name = "lbl_rut"
        Me.lbl_rut.Size = New System.Drawing.Size(36, 13)
        Me.lbl_rut.TabIndex = 12
        Me.lbl_rut.Text = "R.U.T"
        '
        'tbox_rut2
        '
        Me.tbox_rut2.Location = New System.Drawing.Point(410, 120)
        Me.tbox_rut2.Name = "tbox_rut2"
        Me.tbox_rut2.Size = New System.Drawing.Size(48, 20)
        Me.tbox_rut2.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_practicodisp)
        Me.GroupBox1.Controls.Add(Me.cbox_practico)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn_dispteorico)
        Me.GroupBox1.Controls.Add(Me.cbox_teorico)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 337)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(418, 128)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horarios"
        '
        'btn_practicodisp
        '
        Me.btn_practicodisp.Location = New System.Drawing.Point(327, 77)
        Me.btn_practicodisp.Name = "btn_practicodisp"
        Me.btn_practicodisp.Size = New System.Drawing.Size(75, 23)
        Me.btn_practicodisp.TabIndex = 11
        Me.btn_practicodisp.Text = "Ver Disp"
        Me.btn_practicodisp.UseVisualStyleBackColor = True
        '
        'cbox_practico
        '
        Me.cbox_practico.FormattingEnabled = True
        Me.cbox_practico.Location = New System.Drawing.Point(131, 77)
        Me.cbox_practico.Name = "cbox_practico"
        Me.cbox_practico.Size = New System.Drawing.Size(155, 21)
        Me.cbox_practico.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Practico"
        '
        'btn_dispteorico
        '
        Me.btn_dispteorico.Location = New System.Drawing.Point(327, 31)
        Me.btn_dispteorico.Name = "btn_dispteorico"
        Me.btn_dispteorico.Size = New System.Drawing.Size(75, 23)
        Me.btn_dispteorico.TabIndex = 9
        Me.btn_dispteorico.Text = "Ver Disp"
        Me.btn_dispteorico.UseVisualStyleBackColor = True
        '
        'cbox_teorico
        '
        Me.cbox_teorico.FormattingEnabled = True
        Me.cbox_teorico.Location = New System.Drawing.Point(131, 33)
        Me.cbox_teorico.Name = "cbox_teorico"
        Me.cbox_teorico.Size = New System.Drawing.Size(155, 21)
        Me.cbox_teorico.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Teorico"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chbox_notarial)
        Me.GroupBox2.Controls.Add(Me.chbox_regular)
        Me.GroupBox2.Controls.Add(Me.chbox_estudios)
        Me.GroupBox2.Controls.Add(Me.chbox_foto)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 494)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(205, 175)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado de Documentos"
        '
        'chbox_notarial
        '
        Me.chbox_notarial.AutoSize = True
        Me.chbox_notarial.Location = New System.Drawing.Point(11, 135)
        Me.chbox_notarial.Name = "chbox_notarial"
        Me.chbox_notarial.Size = New System.Drawing.Size(142, 17)
        Me.chbox_notarial.TabIndex = 15
        Me.chbox_notarial.Text = "Antecedentes Notariales"
        Me.chbox_notarial.UseVisualStyleBackColor = True
        '
        'chbox_regular
        '
        Me.chbox_regular.AutoSize = True
        Me.chbox_regular.Location = New System.Drawing.Point(11, 99)
        Me.chbox_regular.Name = "chbox_regular"
        Me.chbox_regular.Size = New System.Drawing.Size(154, 17)
        Me.chbox_regular.TabIndex = 14
        Me.chbox_regular.Text = "Certificado Alumno Regular"
        Me.chbox_regular.UseVisualStyleBackColor = True
        '
        'chbox_estudios
        '
        Me.chbox_estudios.AutoSize = True
        Me.chbox_estudios.Location = New System.Drawing.Point(11, 65)
        Me.chbox_estudios.Name = "chbox_estudios"
        Me.chbox_estudios.Size = New System.Drawing.Size(134, 17)
        Me.chbox_estudios.TabIndex = 13
        Me.chbox_estudios.Text = "Certificado de Esutdios"
        Me.chbox_estudios.UseVisualStyleBackColor = True
        '
        'chbox_foto
        '
        Me.chbox_foto.AutoSize = True
        Me.chbox_foto.Location = New System.Drawing.Point(11, 33)
        Me.chbox_foto.Name = "chbox_foto"
        Me.chbox_foto.Size = New System.Drawing.Size(81, 17)
        Me.chbox_foto.TabIndex = 12
        Me.chbox_foto.Text = "Foto Carnet"
        Me.chbox_foto.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbox_codigo_pago)
        Me.GroupBox3.Controls.Add(Me.tbox_nmatricula)
        Me.GroupBox3.Controls.Add(Me.cbox_medio)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.lbl_valor_curso)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.chbox_pago)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(249, 494)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 175)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Matricula"
        '
        'tbox_codigo_pago
        '
        Me.tbox_codigo_pago.Location = New System.Drawing.Point(117, 65)
        Me.tbox_codigo_pago.Name = "tbox_codigo_pago"
        Me.tbox_codigo_pago.Size = New System.Drawing.Size(73, 20)
        Me.tbox_codigo_pago.TabIndex = 22
        '
        'tbox_nmatricula
        '
        Me.tbox_nmatricula.Location = New System.Drawing.Point(115, 30)
        Me.tbox_nmatricula.Name = "tbox_nmatricula"
        Me.tbox_nmatricula.Size = New System.Drawing.Size(75, 20)
        Me.tbox_nmatricula.TabIndex = 21
        '
        'cbox_medio
        '
        Me.cbox_medio.FormattingEnabled = True
        Me.cbox_medio.Location = New System.Drawing.Point(115, 128)
        Me.cbox_medio.Name = "cbox_medio"
        Me.cbox_medio.Size = New System.Drawing.Size(77, 21)
        Me.cbox_medio.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Medio de Pago:"
        '
        'lbl_valor_curso
        '
        Me.lbl_valor_curso.AutoSize = True
        Me.lbl_valor_curso.Location = New System.Drawing.Point(112, 100)
        Me.lbl_valor_curso.Name = "lbl_valor_curso"
        Me.lbl_valor_curso.Size = New System.Drawing.Size(49, 13)
        Me.lbl_valor_curso.TabIndex = 17
        Me.lbl_valor_curso.Text = "0000000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Valor curso:"
        '
        'chbox_pago
        '
        Me.chbox_pago.AutoSize = True
        Me.chbox_pago.Location = New System.Drawing.Point(9, 65)
        Me.chbox_pago.Name = "chbox_pago"
        Me.chbox_pago.Size = New System.Drawing.Size(101, 17)
        Me.chbox_pago.TabIndex = 15
        Me.chbox_pago.Text = "Pago Realizado"
        Me.chbox_pago.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Número"
        '
        'btn_estudiante
        '
        Me.btn_estudiante.Location = New System.Drawing.Point(382, 690)
        Me.btn_estudiante.Name = "btn_estudiante"
        Me.btn_estudiante.Size = New System.Drawing.Size(75, 23)
        Me.btn_estudiante.TabIndex = 16
        Me.btn_estudiante.Text = "Guardar"
        Me.btn_estudiante.UseVisualStyleBackColor = True
        '
        'lbl_curso
        '
        Me.lbl_curso.AutoSize = True
        Me.lbl_curso.Location = New System.Drawing.Point(43, 247)
        Me.lbl_curso.Name = "lbl_curso"
        Me.lbl_curso.Size = New System.Drawing.Size(72, 13)
        Me.lbl_curso.TabIndex = 19
        Me.lbl_curso.Text = "Curso a rendir"
        '
        'cbox_curso
        '
        Me.cbox_curso.FormattingEnabled = True
        Me.cbox_curso.Location = New System.Drawing.Point(172, 244)
        Me.cbox_curso.Name = "cbox_curso"
        Me.cbox_curso.Size = New System.Drawing.Size(285, 21)
        Me.cbox_curso.TabIndex = 6
        '
        'tbox_telefono
        '
        Me.tbox_telefono.Location = New System.Drawing.Point(172, 292)
        Me.tbox_telefono.Name = "tbox_telefono"
        Me.tbox_telefono.Size = New System.Drawing.Size(285, 20)
        Me.tbox_telefono.TabIndex = 7
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(43, 295)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(86, 13)
        Me.lbl_telefono.TabIndex = 21
        Me.lbl_telefono.Text = "Telefono/Celular"
        '
        'lbl_mensaje_conf
        '
        Me.lbl_mensaje_conf.AutoSize = True
        Me.lbl_mensaje_conf.Location = New System.Drawing.Point(25, 721)
        Me.lbl_mensaje_conf.Name = "lbl_mensaje_conf"
        Me.lbl_mensaje_conf.Size = New System.Drawing.Size(0, 13)
        Me.lbl_mensaje_conf.TabIndex = 22
        '
        'lbl_edad
        '
        Me.lbl_edad.AutoSize = True
        Me.lbl_edad.Location = New System.Drawing.Point(43, 159)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(32, 13)
        Me.lbl_edad.TabIndex = 23
        Me.lbl_edad.Text = "Edad"
        '
        'tbox_edad
        '
        Me.tbox_edad.Location = New System.Drawing.Point(172, 156)
        Me.tbox_edad.Name = "tbox_edad"
        Me.tbox_edad.Size = New System.Drawing.Size(100, 20)
        Me.tbox_edad.TabIndex = 24
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(506, 481)
        Me.Controls.Add(Me.tbox_edad)
        Me.Controls.Add(Me.lbl_edad)
        Me.Controls.Add(Me.lbl_mensaje_conf)
        Me.Controls.Add(Me.tbox_telefono)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.cbox_curso)
        Me.Controls.Add(Me.lbl_curso)
        Me.Controls.Add(Me.btn_estudiante)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbox_rut2)
        Me.Controls.Add(Me.tbox_rut1)
        Me.Controls.Add(Me.lbl_rut)
        Me.Controls.Add(Me.tbox_apellido)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.datetp_atencion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbox_nombre)
        Me.Controls.Add(Me.lbl_nombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Registrar Estudiantes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datetp_atencion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbox_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents tbox_apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents tbox_rut1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_rut As System.Windows.Forms.Label
    Friend WithEvents tbox_rut2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_practicodisp As System.Windows.Forms.Button
    Friend WithEvents cbox_practico As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_dispteorico As System.Windows.Forms.Button
    Friend WithEvents cbox_teorico As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chbox_regular As System.Windows.Forms.CheckBox
    Friend WithEvents chbox_estudios As System.Windows.Forms.CheckBox
    Friend WithEvents chbox_foto As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chbox_pago As System.Windows.Forms.CheckBox
    Friend WithEvents btn_estudiante As System.Windows.Forms.Button
    Friend WithEvents lbl_curso As System.Windows.Forms.Label
    Friend WithEvents cbox_curso As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_telefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_valor_curso As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_mensaje_conf As System.Windows.Forms.Label
    Friend WithEvents chbox_notarial As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_edad As System.Windows.Forms.Label
    Friend WithEvents tbox_edad As System.Windows.Forms.TextBox
    Friend WithEvents cbox_medio As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_nmatricula As System.Windows.Forms.TextBox
    Friend WithEvents tbox_codigo_pago As System.Windows.Forms.TextBox
End Class
