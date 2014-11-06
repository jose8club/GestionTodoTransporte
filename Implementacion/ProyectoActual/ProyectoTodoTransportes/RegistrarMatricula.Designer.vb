<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarMatricula
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
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.gbox_Matricula2 = New System.Windows.Forms.GroupBox()
        Me.lbl_MedioPago = New System.Windows.Forms.Label()
        Me.lbl_ValorCurso = New System.Windows.Forms.Label()
        Me.tbox_PagoRealizado = New System.Windows.Forms.TextBox()
        Me.tbox_codigo = New System.Windows.Forms.TextBox()
        Me.cbox_MedioPago = New System.Windows.Forms.ComboBox()
        Me.lbl_ValorCurso2 = New System.Windows.Forms.Label()
        Me.check_PagoRealizado = New System.Windows.Forms.CheckBox()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.gbox_EstadoDocs2 = New System.Windows.Forms.GroupBox()
        Me.check_AntecedentesNot = New System.Windows.Forms.CheckBox()
        Me.check_AlumnoReg = New System.Windows.Forms.CheckBox()
        Me.check_CertEstudios = New System.Windows.Forms.CheckBox()
        Me.check_Foto = New System.Windows.Forms.CheckBox()
        Me.gbox_Horarios2 = New System.Windows.Forms.GroupBox()
        Me.btn_verDispPractico = New System.Windows.Forms.Button()
        Me.cbox_HorarioPractico = New System.Windows.Forms.ComboBox()
        Me.lbl_HorarioPractico = New System.Windows.Forms.Label()
        Me.Btn_verDispTeorico = New System.Windows.Forms.Button()
        Me.cbox_HorarioTeorico = New System.Windows.Forms.ComboBox()
        Me.lbl_HorarioTeorico = New System.Windows.Forms.Label()
        Me.tbox_Telefono = New System.Windows.Forms.TextBox()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.cbox_CursoRendir = New System.Windows.Forms.ComboBox()
        Me.lbl_CursoRendir = New System.Windows.Forms.Label()
        Me.date_FechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lbl_FechaNacimiento = New System.Windows.Forms.Label()
        Me.tbox_VerificadorRUT = New System.Windows.Forms.TextBox()
        Me.tbox_RUT = New System.Windows.Forms.TextBox()
        Me.lbl_RUT = New System.Windows.Forms.Label()
        Me.tbox_Nombre = New System.Windows.Forms.TextBox()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.gbox_Matricula2.SuspendLayout()
        Me.gbox_EstadoDocs2.SuspendLayout()
        Me.gbox_Horarios2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Location = New System.Drawing.Point(371, 355)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 52
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'gbox_Matricula2
        '
        Me.gbox_Matricula2.Controls.Add(Me.lbl_MedioPago)
        Me.gbox_Matricula2.Controls.Add(Me.lbl_ValorCurso)
        Me.gbox_Matricula2.Controls.Add(Me.tbox_PagoRealizado)
        Me.gbox_Matricula2.Controls.Add(Me.tbox_codigo)
        Me.gbox_Matricula2.Controls.Add(Me.cbox_MedioPago)
        Me.gbox_Matricula2.Controls.Add(Me.lbl_ValorCurso2)
        Me.gbox_Matricula2.Controls.Add(Me.check_PagoRealizado)
        Me.gbox_Matricula2.Controls.Add(Me.lbl_codigo)
        Me.gbox_Matricula2.Location = New System.Drawing.Point(229, 230)
        Me.gbox_Matricula2.Name = "gbox_Matricula2"
        Me.gbox_Matricula2.Size = New System.Drawing.Size(217, 119)
        Me.gbox_Matricula2.TabIndex = 57
        Me.gbox_Matricula2.TabStop = False
        Me.gbox_Matricula2.Text = "Matricula"
        '
        'lbl_MedioPago
        '
        Me.lbl_MedioPago.AutoSize = True
        Me.lbl_MedioPago.Location = New System.Drawing.Point(6, 89)
        Me.lbl_MedioPago.Name = "lbl_MedioPago"
        Me.lbl_MedioPago.Size = New System.Drawing.Size(82, 13)
        Me.lbl_MedioPago.TabIndex = 28
        Me.lbl_MedioPago.Text = "Medio de Pago:"
        '
        'lbl_ValorCurso
        '
        Me.lbl_ValorCurso.AutoSize = True
        Me.lbl_ValorCurso.Location = New System.Drawing.Point(6, 66)
        Me.lbl_ValorCurso.Name = "lbl_ValorCurso"
        Me.lbl_ValorCurso.Size = New System.Drawing.Size(63, 13)
        Me.lbl_ValorCurso.TabIndex = 27
        Me.lbl_ValorCurso.Text = "Valor curso:"
        '
        'tbox_PagoRealizado
        '
        Me.tbox_PagoRealizado.Location = New System.Drawing.Point(136, 40)
        Me.tbox_PagoRealizado.MaxLength = 10
        Me.tbox_PagoRealizado.Name = "tbox_PagoRealizado"
        Me.tbox_PagoRealizado.Size = New System.Drawing.Size(75, 20)
        Me.tbox_PagoRealizado.TabIndex = 17
        '
        'tbox_codigo
        '
        Me.tbox_codigo.Location = New System.Drawing.Point(136, 17)
        Me.tbox_codigo.MaxLength = 6
        Me.tbox_codigo.Name = "tbox_codigo"
        Me.tbox_codigo.Size = New System.Drawing.Size(75, 20)
        Me.tbox_codigo.TabIndex = 15
        '
        'cbox_MedioPago
        '
        Me.cbox_MedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_MedioPago.FormattingEnabled = True
        Me.cbox_MedioPago.Location = New System.Drawing.Point(134, 86)
        Me.cbox_MedioPago.Name = "cbox_MedioPago"
        Me.cbox_MedioPago.Size = New System.Drawing.Size(77, 21)
        Me.cbox_MedioPago.TabIndex = 18
        '
        'lbl_ValorCurso2
        '
        Me.lbl_ValorCurso2.AutoSize = True
        Me.lbl_ValorCurso2.Location = New System.Drawing.Point(133, 66)
        Me.lbl_ValorCurso2.Name = "lbl_ValorCurso2"
        Me.lbl_ValorCurso2.Size = New System.Drawing.Size(49, 13)
        Me.lbl_ValorCurso2.TabIndex = 23
        Me.lbl_ValorCurso2.Text = "0000000"
        '
        'check_PagoRealizado
        '
        Me.check_PagoRealizado.AutoSize = True
        Me.check_PagoRealizado.Location = New System.Drawing.Point(9, 42)
        Me.check_PagoRealizado.Name = "check_PagoRealizado"
        Me.check_PagoRealizado.Size = New System.Drawing.Size(101, 17)
        Me.check_PagoRealizado.TabIndex = 16
        Me.check_PagoRealizado.Text = "Pago Realizado"
        Me.check_PagoRealizado.UseVisualStyleBackColor = True
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Location = New System.Drawing.Point(6, 23)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_codigo.TabIndex = 0
        Me.lbl_codigo.Text = "Código:"
        '
        'gbox_EstadoDocs2
        '
        Me.gbox_EstadoDocs2.Controls.Add(Me.check_AntecedentesNot)
        Me.gbox_EstadoDocs2.Controls.Add(Me.check_AlumnoReg)
        Me.gbox_EstadoDocs2.Controls.Add(Me.check_CertEstudios)
        Me.gbox_EstadoDocs2.Controls.Add(Me.check_Foto)
        Me.gbox_EstadoDocs2.Location = New System.Drawing.Point(17, 230)
        Me.gbox_EstadoDocs2.Name = "gbox_EstadoDocs2"
        Me.gbox_EstadoDocs2.Size = New System.Drawing.Size(205, 119)
        Me.gbox_EstadoDocs2.TabIndex = 56
        Me.gbox_EstadoDocs2.TabStop = False
        Me.gbox_EstadoDocs2.Text = "Estado de Documentos"
        '
        'check_AntecedentesNot
        '
        Me.check_AntecedentesNot.AutoSize = True
        Me.check_AntecedentesNot.Location = New System.Drawing.Point(11, 88)
        Me.check_AntecedentesNot.Name = "check_AntecedentesNot"
        Me.check_AntecedentesNot.Size = New System.Drawing.Size(142, 17)
        Me.check_AntecedentesNot.TabIndex = 14
        Me.check_AntecedentesNot.Text = "Antecedentes Notariales"
        Me.check_AntecedentesNot.UseVisualStyleBackColor = True
        '
        'check_AlumnoReg
        '
        Me.check_AlumnoReg.AutoSize = True
        Me.check_AlumnoReg.Location = New System.Drawing.Point(11, 65)
        Me.check_AlumnoReg.Name = "check_AlumnoReg"
        Me.check_AlumnoReg.Size = New System.Drawing.Size(154, 17)
        Me.check_AlumnoReg.TabIndex = 13
        Me.check_AlumnoReg.Text = "Certificado Alumno Regular"
        Me.check_AlumnoReg.UseVisualStyleBackColor = True
        '
        'check_CertEstudios
        '
        Me.check_CertEstudios.AutoSize = True
        Me.check_CertEstudios.Location = New System.Drawing.Point(11, 42)
        Me.check_CertEstudios.Name = "check_CertEstudios"
        Me.check_CertEstudios.Size = New System.Drawing.Size(134, 17)
        Me.check_CertEstudios.TabIndex = 12
        Me.check_CertEstudios.Text = "Certificado de Estudios"
        Me.check_CertEstudios.UseVisualStyleBackColor = True
        '
        'check_Foto
        '
        Me.check_Foto.AutoSize = True
        Me.check_Foto.Location = New System.Drawing.Point(11, 19)
        Me.check_Foto.Name = "check_Foto"
        Me.check_Foto.Size = New System.Drawing.Size(81, 17)
        Me.check_Foto.TabIndex = 11
        Me.check_Foto.Text = "Foto Carnet"
        Me.check_Foto.UseVisualStyleBackColor = True
        '
        'gbox_Horarios2
        '
        Me.gbox_Horarios2.Controls.Add(Me.btn_verDispPractico)
        Me.gbox_Horarios2.Controls.Add(Me.cbox_HorarioPractico)
        Me.gbox_Horarios2.Controls.Add(Me.lbl_HorarioPractico)
        Me.gbox_Horarios2.Controls.Add(Me.Btn_verDispTeorico)
        Me.gbox_Horarios2.Controls.Add(Me.cbox_HorarioTeorico)
        Me.gbox_Horarios2.Controls.Add(Me.lbl_HorarioTeorico)
        Me.gbox_Horarios2.Location = New System.Drawing.Point(18, 143)
        Me.gbox_Horarios2.Name = "gbox_Horarios2"
        Me.gbox_Horarios2.Size = New System.Drawing.Size(428, 81)
        Me.gbox_Horarios2.TabIndex = 55
        Me.gbox_Horarios2.TabStop = False
        Me.gbox_Horarios2.Text = "Horarios"
        '
        'btn_verDispPractico
        '
        Me.btn_verDispPractico.Location = New System.Drawing.Point(347, 46)
        Me.btn_verDispPractico.Name = "btn_verDispPractico"
        Me.btn_verDispPractico.Size = New System.Drawing.Size(75, 21)
        Me.btn_verDispPractico.TabIndex = 10
        Me.btn_verDispPractico.Text = "Ver Disp"
        Me.btn_verDispPractico.UseVisualStyleBackColor = True
        '
        'cbox_HorarioPractico
        '
        Me.cbox_HorarioPractico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_HorarioPractico.FormattingEnabled = True
        Me.cbox_HorarioPractico.Location = New System.Drawing.Point(131, 46)
        Me.cbox_HorarioPractico.Name = "cbox_HorarioPractico"
        Me.cbox_HorarioPractico.Size = New System.Drawing.Size(210, 21)
        Me.cbox_HorarioPractico.TabIndex = 9
        '
        'lbl_HorarioPractico
        '
        Me.lbl_HorarioPractico.AutoSize = True
        Me.lbl_HorarioPractico.Location = New System.Drawing.Point(11, 51)
        Me.lbl_HorarioPractico.Name = "lbl_HorarioPractico"
        Me.lbl_HorarioPractico.Size = New System.Drawing.Size(46, 13)
        Me.lbl_HorarioPractico.TabIndex = 3
        Me.lbl_HorarioPractico.Text = "Práctico"
        '
        'Btn_verDispTeorico
        '
        Me.Btn_verDispTeorico.Location = New System.Drawing.Point(347, 19)
        Me.Btn_verDispTeorico.Name = "Btn_verDispTeorico"
        Me.Btn_verDispTeorico.Size = New System.Drawing.Size(75, 21)
        Me.Btn_verDispTeorico.TabIndex = 8
        Me.Btn_verDispTeorico.Text = "Ver Disp"
        Me.Btn_verDispTeorico.UseVisualStyleBackColor = True
        '
        'cbox_HorarioTeorico
        '
        Me.cbox_HorarioTeorico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_HorarioTeorico.FormattingEnabled = True
        Me.cbox_HorarioTeorico.Location = New System.Drawing.Point(131, 19)
        Me.cbox_HorarioTeorico.Name = "cbox_HorarioTeorico"
        Me.cbox_HorarioTeorico.Size = New System.Drawing.Size(210, 21)
        Me.cbox_HorarioTeorico.TabIndex = 7
        '
        'lbl_HorarioTeorico
        '
        Me.lbl_HorarioTeorico.AutoSize = True
        Me.lbl_HorarioTeorico.Location = New System.Drawing.Point(11, 23)
        Me.lbl_HorarioTeorico.Name = "lbl_HorarioTeorico"
        Me.lbl_HorarioTeorico.Size = New System.Drawing.Size(43, 13)
        Me.lbl_HorarioTeorico.TabIndex = 0
        Me.lbl_HorarioTeorico.Text = "Teórico"
        '
        'tbox_Telefono
        '
        Me.tbox_Telefono.Location = New System.Drawing.Point(144, 117)
        Me.tbox_Telefono.MaxLength = 20
        Me.tbox_Telefono.Name = "tbox_Telefono"
        Me.tbox_Telefono.Size = New System.Drawing.Size(302, 20)
        Me.tbox_Telefono.TabIndex = 48
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(13, 120)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(89, 13)
        Me.lbl_Telefono.TabIndex = 54
        Me.lbl_Telefono.Text = "Teléfono/Celular:"
        '
        'cbox_CursoRendir
        '
        Me.cbox_CursoRendir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_CursoRendir.FormattingEnabled = True
        Me.cbox_CursoRendir.Location = New System.Drawing.Point(142, 90)
        Me.cbox_CursoRendir.Name = "cbox_CursoRendir"
        Me.cbox_CursoRendir.Size = New System.Drawing.Size(304, 21)
        Me.cbox_CursoRendir.TabIndex = 47
        '
        'lbl_CursoRendir
        '
        Me.lbl_CursoRendir.AutoSize = True
        Me.lbl_CursoRendir.Location = New System.Drawing.Point(13, 93)
        Me.lbl_CursoRendir.Name = "lbl_CursoRendir"
        Me.lbl_CursoRendir.Size = New System.Drawing.Size(75, 13)
        Me.lbl_CursoRendir.TabIndex = 53
        Me.lbl_CursoRendir.Text = "Curso a rendir:"
        '
        'date_FechaNacimiento
        '
        Me.date_FechaNacimiento.Location = New System.Drawing.Point(144, 64)
        Me.date_FechaNacimiento.Name = "date_FechaNacimiento"
        Me.date_FechaNacimiento.Size = New System.Drawing.Size(302, 20)
        Me.date_FechaNacimiento.TabIndex = 46
        '
        'lbl_FechaNacimiento
        '
        Me.lbl_FechaNacimiento.AutoSize = True
        Me.lbl_FechaNacimiento.Location = New System.Drawing.Point(13, 68)
        Me.lbl_FechaNacimiento.Name = "lbl_FechaNacimiento"
        Me.lbl_FechaNacimiento.Size = New System.Drawing.Size(111, 13)
        Me.lbl_FechaNacimiento.TabIndex = 51
        Me.lbl_FechaNacimiento.Text = "Fecha de Nacimiento:"
        '
        'tbox_VerificadorRUT
        '
        Me.tbox_VerificadorRUT.Location = New System.Drawing.Point(398, 38)
        Me.tbox_VerificadorRUT.MaxLength = 1
        Me.tbox_VerificadorRUT.Name = "tbox_VerificadorRUT"
        Me.tbox_VerificadorRUT.Size = New System.Drawing.Size(48, 20)
        Me.tbox_VerificadorRUT.TabIndex = 45
        '
        'tbox_RUT
        '
        Me.tbox_RUT.Location = New System.Drawing.Point(142, 38)
        Me.tbox_RUT.MaxLength = 8
        Me.tbox_RUT.Name = "tbox_RUT"
        Me.tbox_RUT.Size = New System.Drawing.Size(247, 20)
        Me.tbox_RUT.TabIndex = 44
        '
        'lbl_RUT
        '
        Me.lbl_RUT.AutoSize = True
        Me.lbl_RUT.Location = New System.Drawing.Point(15, 41)
        Me.lbl_RUT.Name = "lbl_RUT"
        Me.lbl_RUT.Size = New System.Drawing.Size(42, 13)
        Me.lbl_RUT.TabIndex = 50
        Me.lbl_RUT.Text = "R.U.T.:"
        '
        'tbox_Nombre
        '
        Me.tbox_Nombre.Location = New System.Drawing.Point(142, 12)
        Me.tbox_Nombre.MaxLength = 255
        Me.tbox_Nombre.Name = "tbox_Nombre"
        Me.tbox_Nombre.Size = New System.Drawing.Size(304, 20)
        Me.tbox_Nombre.TabIndex = 43
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(13, 15)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Nombre.TabIndex = 49
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'RegistrarMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 394)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.gbox_Matricula2)
        Me.Controls.Add(Me.gbox_EstadoDocs2)
        Me.Controls.Add(Me.gbox_Horarios2)
        Me.Controls.Add(Me.tbox_Telefono)
        Me.Controls.Add(Me.lbl_Telefono)
        Me.Controls.Add(Me.cbox_CursoRendir)
        Me.Controls.Add(Me.lbl_CursoRendir)
        Me.Controls.Add(Me.date_FechaNacimiento)
        Me.Controls.Add(Me.lbl_FechaNacimiento)
        Me.Controls.Add(Me.tbox_VerificadorRUT)
        Me.Controls.Add(Me.tbox_RUT)
        Me.Controls.Add(Me.lbl_RUT)
        Me.Controls.Add(Me.tbox_Nombre)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrarMatricula"
        Me.Text = "Matrícula"
        Me.gbox_Matricula2.ResumeLayout(False)
        Me.gbox_Matricula2.PerformLayout()
        Me.gbox_EstadoDocs2.ResumeLayout(False)
        Me.gbox_EstadoDocs2.PerformLayout()
        Me.gbox_Horarios2.ResumeLayout(False)
        Me.gbox_Horarios2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents gbox_Matricula2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_MedioPago As System.Windows.Forms.Label
    Friend WithEvents lbl_ValorCurso As System.Windows.Forms.Label
    Friend WithEvents tbox_PagoRealizado As System.Windows.Forms.TextBox
    Friend WithEvents tbox_codigo As System.Windows.Forms.TextBox
    Friend WithEvents cbox_MedioPago As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_ValorCurso2 As System.Windows.Forms.Label
    Friend WithEvents check_PagoRealizado As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_codigo As System.Windows.Forms.Label
    Friend WithEvents gbox_EstadoDocs2 As System.Windows.Forms.GroupBox
    Friend WithEvents check_AntecedentesNot As System.Windows.Forms.CheckBox
    Friend WithEvents check_AlumnoReg As System.Windows.Forms.CheckBox
    Friend WithEvents check_CertEstudios As System.Windows.Forms.CheckBox
    Friend WithEvents check_Foto As System.Windows.Forms.CheckBox
    Friend WithEvents gbox_Horarios2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_verDispPractico As System.Windows.Forms.Button
    Friend WithEvents cbox_HorarioPractico As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_HorarioPractico As System.Windows.Forms.Label
    Friend WithEvents Btn_verDispTeorico As System.Windows.Forms.Button
    Friend WithEvents cbox_HorarioTeorico As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_HorarioTeorico As System.Windows.Forms.Label
    Friend WithEvents tbox_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents cbox_CursoRendir As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_CursoRendir As System.Windows.Forms.Label
    Friend WithEvents date_FechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents tbox_VerificadorRUT As System.Windows.Forms.TextBox
    Friend WithEvents tbox_RUT As System.Windows.Forms.TextBox
    Friend WithEvents lbl_RUT As System.Windows.Forms.Label
    Friend WithEvents tbox_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
End Class
