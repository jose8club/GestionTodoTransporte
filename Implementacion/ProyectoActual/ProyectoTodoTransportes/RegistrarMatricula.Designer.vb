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
        Me.btn_Guardar2 = New System.Windows.Forms.Button()
        Me.gbox_Matricula2 = New System.Windows.Forms.GroupBox()
        Me.lbl_MedioPago = New System.Windows.Forms.Label()
        Me.lbl_ValorCurso = New System.Windows.Forms.Label()
        Me.tbox_PagoRealizado = New System.Windows.Forms.TextBox()
        Me.tbox_Numero2 = New System.Windows.Forms.TextBox()
        Me.cbox_MedioPago2 = New System.Windows.Forms.ComboBox()
        Me.lbl_ValorCurso2 = New System.Windows.Forms.Label()
        Me.check_PagoRealizado2 = New System.Windows.Forms.CheckBox()
        Me.lbl_numero = New System.Windows.Forms.Label()
        Me.gbox_EstadoDocs2 = New System.Windows.Forms.GroupBox()
        Me.check_AntecedentesNot2 = New System.Windows.Forms.CheckBox()
        Me.check_AlumnoReg2 = New System.Windows.Forms.CheckBox()
        Me.check_CertEstudios2 = New System.Windows.Forms.CheckBox()
        Me.check_Foto2 = New System.Windows.Forms.CheckBox()
        Me.gbox_Horarios2 = New System.Windows.Forms.GroupBox()
        Me.btn_verDispPractico = New System.Windows.Forms.Button()
        Me.cbox_Practico2 = New System.Windows.Forms.ComboBox()
        Me.lbl_Practico = New System.Windows.Forms.Label()
        Me.Btn_verDispTeorico2 = New System.Windows.Forms.Button()
        Me.cbox_Teorico2 = New System.Windows.Forms.ComboBox()
        Me.lbl_Teorico2 = New System.Windows.Forms.Label()
        Me.tbox_Fono2 = New System.Windows.Forms.TextBox()
        Me.lbl_Fono2 = New System.Windows.Forms.Label()
        Me.cbox_CursoRendir2 = New System.Windows.Forms.ComboBox()
        Me.lbl_CursoRendir2 = New System.Windows.Forms.Label()
        Me.date_FechaAtencion2 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_FechaAtencion2 = New System.Windows.Forms.Label()
        Me.tbox_VerificadorRut2 = New System.Windows.Forms.TextBox()
        Me.tbox_RUT2 = New System.Windows.Forms.TextBox()
        Me.lbl_RUT2 = New System.Windows.Forms.Label()
        Me.tbox_Nombres2 = New System.Windows.Forms.TextBox()
        Me.lbl_Nombres2 = New System.Windows.Forms.Label()
        Me.gbox_Matricula2.SuspendLayout()
        Me.gbox_EstadoDocs2.SuspendLayout()
        Me.gbox_Horarios2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Guardar2
        '
        Me.btn_Guardar2.Location = New System.Drawing.Point(371, 355)
        Me.btn_Guardar2.Name = "btn_Guardar2"
        Me.btn_Guardar2.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar2.TabIndex = 52
        Me.btn_Guardar2.Text = "Guardar"
        Me.btn_Guardar2.UseVisualStyleBackColor = True
        '
        'gbox_Matricula2
        '
        Me.gbox_Matricula2.Controls.Add(Me.lbl_MedioPago)
        Me.gbox_Matricula2.Controls.Add(Me.lbl_ValorCurso)
        Me.gbox_Matricula2.Controls.Add(Me.tbox_PagoRealizado)
        Me.gbox_Matricula2.Controls.Add(Me.tbox_Numero2)
        Me.gbox_Matricula2.Controls.Add(Me.cbox_MedioPago2)
        Me.gbox_Matricula2.Controls.Add(Me.lbl_ValorCurso2)
        Me.gbox_Matricula2.Controls.Add(Me.check_PagoRealizado2)
        Me.gbox_Matricula2.Controls.Add(Me.lbl_numero)
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
        'tbox_Numero2
        '
        Me.tbox_Numero2.Location = New System.Drawing.Point(136, 17)
        Me.tbox_Numero2.MaxLength = 6
        Me.tbox_Numero2.Name = "tbox_Numero2"
        Me.tbox_Numero2.Size = New System.Drawing.Size(75, 20)
        Me.tbox_Numero2.TabIndex = 15
        '
        'cbox_MedioPago2
        '
        Me.cbox_MedioPago2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_MedioPago2.FormattingEnabled = True
        Me.cbox_MedioPago2.Location = New System.Drawing.Point(134, 86)
        Me.cbox_MedioPago2.Name = "cbox_MedioPago2"
        Me.cbox_MedioPago2.Size = New System.Drawing.Size(77, 21)
        Me.cbox_MedioPago2.TabIndex = 18
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
        'check_PagoRealizado2
        '
        Me.check_PagoRealizado2.AutoSize = True
        Me.check_PagoRealizado2.Location = New System.Drawing.Point(9, 42)
        Me.check_PagoRealizado2.Name = "check_PagoRealizado2"
        Me.check_PagoRealizado2.Size = New System.Drawing.Size(101, 17)
        Me.check_PagoRealizado2.TabIndex = 16
        Me.check_PagoRealizado2.Text = "Pago Realizado"
        Me.check_PagoRealizado2.UseVisualStyleBackColor = True
        '
        'lbl_numero
        '
        Me.lbl_numero.AutoSize = True
        Me.lbl_numero.Location = New System.Drawing.Point(6, 23)
        Me.lbl_numero.Name = "lbl_numero"
        Me.lbl_numero.Size = New System.Drawing.Size(43, 13)
        Me.lbl_numero.TabIndex = 0
        Me.lbl_numero.Text = "Código:"
        '
        'gbox_EstadoDocs2
        '
        Me.gbox_EstadoDocs2.Controls.Add(Me.check_AntecedentesNot2)
        Me.gbox_EstadoDocs2.Controls.Add(Me.check_AlumnoReg2)
        Me.gbox_EstadoDocs2.Controls.Add(Me.check_CertEstudios2)
        Me.gbox_EstadoDocs2.Controls.Add(Me.check_Foto2)
        Me.gbox_EstadoDocs2.Location = New System.Drawing.Point(17, 230)
        Me.gbox_EstadoDocs2.Name = "gbox_EstadoDocs2"
        Me.gbox_EstadoDocs2.Size = New System.Drawing.Size(205, 119)
        Me.gbox_EstadoDocs2.TabIndex = 56
        Me.gbox_EstadoDocs2.TabStop = False
        Me.gbox_EstadoDocs2.Text = "Estado de Documentos"
        '
        'check_AntecedentesNot2
        '
        Me.check_AntecedentesNot2.AutoSize = True
        Me.check_AntecedentesNot2.Location = New System.Drawing.Point(11, 88)
        Me.check_AntecedentesNot2.Name = "check_AntecedentesNot2"
        Me.check_AntecedentesNot2.Size = New System.Drawing.Size(142, 17)
        Me.check_AntecedentesNot2.TabIndex = 14
        Me.check_AntecedentesNot2.Text = "Antecedentes Notariales"
        Me.check_AntecedentesNot2.UseVisualStyleBackColor = True
        '
        'check_AlumnoReg2
        '
        Me.check_AlumnoReg2.AutoSize = True
        Me.check_AlumnoReg2.Location = New System.Drawing.Point(11, 65)
        Me.check_AlumnoReg2.Name = "check_AlumnoReg2"
        Me.check_AlumnoReg2.Size = New System.Drawing.Size(154, 17)
        Me.check_AlumnoReg2.TabIndex = 13
        Me.check_AlumnoReg2.Text = "Certificado Alumno Regular"
        Me.check_AlumnoReg2.UseVisualStyleBackColor = True
        '
        'check_CertEstudios2
        '
        Me.check_CertEstudios2.AutoSize = True
        Me.check_CertEstudios2.Location = New System.Drawing.Point(11, 42)
        Me.check_CertEstudios2.Name = "check_CertEstudios2"
        Me.check_CertEstudios2.Size = New System.Drawing.Size(134, 17)
        Me.check_CertEstudios2.TabIndex = 12
        Me.check_CertEstudios2.Text = "Certificado de Estudios"
        Me.check_CertEstudios2.UseVisualStyleBackColor = True
        '
        'check_Foto2
        '
        Me.check_Foto2.AutoSize = True
        Me.check_Foto2.Location = New System.Drawing.Point(11, 19)
        Me.check_Foto2.Name = "check_Foto2"
        Me.check_Foto2.Size = New System.Drawing.Size(81, 17)
        Me.check_Foto2.TabIndex = 11
        Me.check_Foto2.Text = "Foto Carnet"
        Me.check_Foto2.UseVisualStyleBackColor = True
        '
        'gbox_Horarios2
        '
        Me.gbox_Horarios2.Controls.Add(Me.btn_verDispPractico)
        Me.gbox_Horarios2.Controls.Add(Me.cbox_Practico2)
        Me.gbox_Horarios2.Controls.Add(Me.lbl_Practico)
        Me.gbox_Horarios2.Controls.Add(Me.Btn_verDispTeorico2)
        Me.gbox_Horarios2.Controls.Add(Me.cbox_Teorico2)
        Me.gbox_Horarios2.Controls.Add(Me.lbl_Teorico2)
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
        'cbox_Practico2
        '
        Me.cbox_Practico2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Practico2.FormattingEnabled = True
        Me.cbox_Practico2.Location = New System.Drawing.Point(131, 46)
        Me.cbox_Practico2.Name = "cbox_Practico2"
        Me.cbox_Practico2.Size = New System.Drawing.Size(210, 21)
        Me.cbox_Practico2.TabIndex = 9
        '
        'lbl_Practico
        '
        Me.lbl_Practico.AutoSize = True
        Me.lbl_Practico.Location = New System.Drawing.Point(11, 51)
        Me.lbl_Practico.Name = "lbl_Practico"
        Me.lbl_Practico.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Practico.TabIndex = 3
        Me.lbl_Practico.Text = "Práctico"
        '
        'Btn_verDispTeorico2
        '
        Me.Btn_verDispTeorico2.Location = New System.Drawing.Point(347, 19)
        Me.Btn_verDispTeorico2.Name = "Btn_verDispTeorico2"
        Me.Btn_verDispTeorico2.Size = New System.Drawing.Size(75, 21)
        Me.Btn_verDispTeorico2.TabIndex = 8
        Me.Btn_verDispTeorico2.Text = "Ver Disp"
        Me.Btn_verDispTeorico2.UseVisualStyleBackColor = True
        '
        'cbox_Teorico2
        '
        Me.cbox_Teorico2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Teorico2.FormattingEnabled = True
        Me.cbox_Teorico2.Location = New System.Drawing.Point(131, 19)
        Me.cbox_Teorico2.Name = "cbox_Teorico2"
        Me.cbox_Teorico2.Size = New System.Drawing.Size(210, 21)
        Me.cbox_Teorico2.TabIndex = 7
        '
        'lbl_Teorico2
        '
        Me.lbl_Teorico2.AutoSize = True
        Me.lbl_Teorico2.Location = New System.Drawing.Point(11, 23)
        Me.lbl_Teorico2.Name = "lbl_Teorico2"
        Me.lbl_Teorico2.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Teorico2.TabIndex = 0
        Me.lbl_Teorico2.Text = "Teórico"
        '
        'tbox_Fono2
        '
        Me.tbox_Fono2.Location = New System.Drawing.Point(144, 117)
        Me.tbox_Fono2.MaxLength = 20
        Me.tbox_Fono2.Name = "tbox_Fono2"
        Me.tbox_Fono2.Size = New System.Drawing.Size(302, 20)
        Me.tbox_Fono2.TabIndex = 48
        '
        'lbl_Fono2
        '
        Me.lbl_Fono2.AutoSize = True
        Me.lbl_Fono2.Location = New System.Drawing.Point(13, 120)
        Me.lbl_Fono2.Name = "lbl_Fono2"
        Me.lbl_Fono2.Size = New System.Drawing.Size(89, 13)
        Me.lbl_Fono2.TabIndex = 54
        Me.lbl_Fono2.Text = "Teléfono/Celular:"
        '
        'cbox_CursoRendir2
        '
        Me.cbox_CursoRendir2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_CursoRendir2.FormattingEnabled = True
        Me.cbox_CursoRendir2.Location = New System.Drawing.Point(142, 90)
        Me.cbox_CursoRendir2.Name = "cbox_CursoRendir2"
        Me.cbox_CursoRendir2.Size = New System.Drawing.Size(304, 21)
        Me.cbox_CursoRendir2.TabIndex = 47
        '
        'lbl_CursoRendir2
        '
        Me.lbl_CursoRendir2.AutoSize = True
        Me.lbl_CursoRendir2.Location = New System.Drawing.Point(13, 93)
        Me.lbl_CursoRendir2.Name = "lbl_CursoRendir2"
        Me.lbl_CursoRendir2.Size = New System.Drawing.Size(75, 13)
        Me.lbl_CursoRendir2.TabIndex = 53
        Me.lbl_CursoRendir2.Text = "Curso a rendir:"
        '
        'date_FechaAtencion2
        '
        Me.date_FechaAtencion2.Location = New System.Drawing.Point(144, 64)
        Me.date_FechaAtencion2.Name = "date_FechaAtencion2"
        Me.date_FechaAtencion2.Size = New System.Drawing.Size(302, 20)
        Me.date_FechaAtencion2.TabIndex = 46
        '
        'lbl_FechaAtencion2
        '
        Me.lbl_FechaAtencion2.AutoSize = True
        Me.lbl_FechaAtencion2.Location = New System.Drawing.Point(13, 68)
        Me.lbl_FechaAtencion2.Name = "lbl_FechaAtencion2"
        Me.lbl_FechaAtencion2.Size = New System.Drawing.Size(111, 13)
        Me.lbl_FechaAtencion2.TabIndex = 51
        Me.lbl_FechaAtencion2.Text = "Fecha de Nacimiento:"
        '
        'tbox_VerificadorRut2
        '
        Me.tbox_VerificadorRut2.Location = New System.Drawing.Point(398, 38)
        Me.tbox_VerificadorRut2.MaxLength = 1
        Me.tbox_VerificadorRut2.Name = "tbox_VerificadorRut2"
        Me.tbox_VerificadorRut2.Size = New System.Drawing.Size(48, 20)
        Me.tbox_VerificadorRut2.TabIndex = 45
        '
        'tbox_RUT2
        '
        Me.tbox_RUT2.Location = New System.Drawing.Point(142, 38)
        Me.tbox_RUT2.MaxLength = 8
        Me.tbox_RUT2.Name = "tbox_RUT2"
        Me.tbox_RUT2.Size = New System.Drawing.Size(247, 20)
        Me.tbox_RUT2.TabIndex = 44
        '
        'lbl_RUT2
        '
        Me.lbl_RUT2.AutoSize = True
        Me.lbl_RUT2.Location = New System.Drawing.Point(15, 41)
        Me.lbl_RUT2.Name = "lbl_RUT2"
        Me.lbl_RUT2.Size = New System.Drawing.Size(42, 13)
        Me.lbl_RUT2.TabIndex = 50
        Me.lbl_RUT2.Text = "R.U.T.:"
        '
        'tbox_Nombres2
        '
        Me.tbox_Nombres2.Location = New System.Drawing.Point(142, 12)
        Me.tbox_Nombres2.MaxLength = 255
        Me.tbox_Nombres2.Name = "tbox_Nombres2"
        Me.tbox_Nombres2.Size = New System.Drawing.Size(304, 20)
        Me.tbox_Nombres2.TabIndex = 43
        '
        'lbl_Nombres2
        '
        Me.lbl_Nombres2.AutoSize = True
        Me.lbl_Nombres2.Location = New System.Drawing.Point(13, 15)
        Me.lbl_Nombres2.Name = "lbl_Nombres2"
        Me.lbl_Nombres2.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Nombres2.TabIndex = 49
        Me.lbl_Nombres2.Text = "Nombres:"
        '
        'RegistrarMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 394)
        Me.Controls.Add(Me.btn_Guardar2)
        Me.Controls.Add(Me.gbox_Matricula2)
        Me.Controls.Add(Me.gbox_EstadoDocs2)
        Me.Controls.Add(Me.gbox_Horarios2)
        Me.Controls.Add(Me.tbox_Fono2)
        Me.Controls.Add(Me.lbl_Fono2)
        Me.Controls.Add(Me.cbox_CursoRendir2)
        Me.Controls.Add(Me.lbl_CursoRendir2)
        Me.Controls.Add(Me.date_FechaAtencion2)
        Me.Controls.Add(Me.lbl_FechaAtencion2)
        Me.Controls.Add(Me.tbox_VerificadorRut2)
        Me.Controls.Add(Me.tbox_RUT2)
        Me.Controls.Add(Me.lbl_RUT2)
        Me.Controls.Add(Me.tbox_Nombres2)
        Me.Controls.Add(Me.lbl_Nombres2)
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
    Friend WithEvents btn_Guardar2 As System.Windows.Forms.Button
    Friend WithEvents gbox_Matricula2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_MedioPago As System.Windows.Forms.Label
    Friend WithEvents lbl_ValorCurso As System.Windows.Forms.Label
    Friend WithEvents tbox_PagoRealizado As System.Windows.Forms.TextBox
    Friend WithEvents tbox_Numero2 As System.Windows.Forms.TextBox
    Friend WithEvents cbox_MedioPago2 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_ValorCurso2 As System.Windows.Forms.Label
    Friend WithEvents check_PagoRealizado2 As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_numero As System.Windows.Forms.Label
    Friend WithEvents gbox_EstadoDocs2 As System.Windows.Forms.GroupBox
    Friend WithEvents check_AntecedentesNot2 As System.Windows.Forms.CheckBox
    Friend WithEvents check_AlumnoReg2 As System.Windows.Forms.CheckBox
    Friend WithEvents check_CertEstudios2 As System.Windows.Forms.CheckBox
    Friend WithEvents check_Foto2 As System.Windows.Forms.CheckBox
    Friend WithEvents gbox_Horarios2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_verDispPractico As System.Windows.Forms.Button
    Friend WithEvents cbox_Practico2 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Practico As System.Windows.Forms.Label
    Friend WithEvents Btn_verDispTeorico2 As System.Windows.Forms.Button
    Friend WithEvents cbox_Teorico2 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Teorico2 As System.Windows.Forms.Label
    Friend WithEvents tbox_Fono2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Fono2 As System.Windows.Forms.Label
    Friend WithEvents cbox_CursoRendir2 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_CursoRendir2 As System.Windows.Forms.Label
    Friend WithEvents date_FechaAtencion2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaAtencion2 As System.Windows.Forms.Label
    Friend WithEvents tbox_VerificadorRut2 As System.Windows.Forms.TextBox
    Friend WithEvents tbox_RUT2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_RUT2 As System.Windows.Forms.Label
    Friend WithEvents tbox_Nombres2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Nombres2 As System.Windows.Forms.Label
End Class
