<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Examen
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Teorico = New System.Windows.Forms.TabPage()
        Me.btn_exTeo = New System.Windows.Forms.Button()
        Me.tbox_calificacionTeo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbox_examinador = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.date_examenTeo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbox_docTeo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbox_codigoTeo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Practico = New System.Windows.Forms.TabPage()
        Me.btn_exPract = New System.Windows.Forms.Button()
        Me.tbox_calPract = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbox_instructor = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.date_fechaPract = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbox_docPractico = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbox_codigoPract = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Municipal = New System.Windows.Forms.TabPage()
        Me.cbox_docMunicipal = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbox_codMunicipal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbox_instMun = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbox_estMun = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.rtbox_comentario = New System.Windows.Forms.RichTextBox()
        Me.btn_Municipal = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Teorico.SuspendLayout()
        Me.Practico.SuspendLayout()
        Me.Municipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Teorico)
        Me.TabControl1.Controls.Add(Me.Practico)
        Me.TabControl1.Controls.Add(Me.Municipal)
        Me.TabControl1.Location = New System.Drawing.Point(32, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(683, 373)
        Me.TabControl1.TabIndex = 0
        '
        'Teorico
        '
        Me.Teorico.Controls.Add(Me.btn_exTeo)
        Me.Teorico.Controls.Add(Me.tbox_calificacionTeo)
        Me.Teorico.Controls.Add(Me.Label5)
        Me.Teorico.Controls.Add(Me.cbox_examinador)
        Me.Teorico.Controls.Add(Me.Label4)
        Me.Teorico.Controls.Add(Me.date_examenTeo)
        Me.Teorico.Controls.Add(Me.Label3)
        Me.Teorico.Controls.Add(Me.cbox_docTeo)
        Me.Teorico.Controls.Add(Me.Label2)
        Me.Teorico.Controls.Add(Me.tbox_codigoTeo)
        Me.Teorico.Controls.Add(Me.Label1)
        Me.Teorico.Location = New System.Drawing.Point(4, 22)
        Me.Teorico.Name = "Teorico"
        Me.Teorico.Padding = New System.Windows.Forms.Padding(3)
        Me.Teorico.Size = New System.Drawing.Size(675, 347)
        Me.Teorico.TabIndex = 0
        Me.Teorico.Text = "Examen Teorico"
        Me.Teorico.UseVisualStyleBackColor = True
        '
        'btn_exTeo
        '
        Me.btn_exTeo.Location = New System.Drawing.Point(353, 234)
        Me.btn_exTeo.Name = "btn_exTeo"
        Me.btn_exTeo.Size = New System.Drawing.Size(111, 23)
        Me.btn_exTeo.TabIndex = 21
        Me.btn_exTeo.Text = "Guardar"
        Me.btn_exTeo.UseVisualStyleBackColor = True
        '
        'tbox_calificacionTeo
        '
        Me.tbox_calificacionTeo.Location = New System.Drawing.Point(132, 181)
        Me.tbox_calificacionTeo.Name = "tbox_calificacionTeo"
        Me.tbox_calificacionTeo.Size = New System.Drawing.Size(56, 20)
        Me.tbox_calificacionTeo.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Calificación:"
        '
        'cbox_examinador
        '
        Me.cbox_examinador.FormattingEnabled = True
        Me.cbox_examinador.Location = New System.Drawing.Point(132, 141)
        Me.cbox_examinador.Name = "cbox_examinador"
        Me.cbox_examinador.Size = New System.Drawing.Size(332, 21)
        Me.cbox_examinador.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Examinador:"
        '
        'date_examenTeo
        '
        Me.date_examenTeo.Location = New System.Drawing.Point(132, 106)
        Me.date_examenTeo.Name = "date_examenTeo"
        Me.date_examenTeo.Size = New System.Drawing.Size(332, 20)
        Me.date_examenTeo.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Fecha:"
        '
        'cbox_docTeo
        '
        Me.cbox_docTeo.FormattingEnabled = True
        Me.cbox_docTeo.Location = New System.Drawing.Point(132, 70)
        Me.cbox_docTeo.Name = "cbox_docTeo"
        Me.cbox_docTeo.Size = New System.Drawing.Size(332, 21)
        Me.cbox_docTeo.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Documento:"
        '
        'tbox_codigoTeo
        '
        Me.tbox_codigoTeo.Location = New System.Drawing.Point(132, 35)
        Me.tbox_codigoTeo.Name = "tbox_codigoTeo"
        Me.tbox_codigoTeo.Size = New System.Drawing.Size(332, 20)
        Me.tbox_codigoTeo.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Codigo:"
        '
        'Practico
        '
        Me.Practico.Controls.Add(Me.btn_exPract)
        Me.Practico.Controls.Add(Me.tbox_calPract)
        Me.Practico.Controls.Add(Me.Label6)
        Me.Practico.Controls.Add(Me.cbox_instructor)
        Me.Practico.Controls.Add(Me.Label7)
        Me.Practico.Controls.Add(Me.date_fechaPract)
        Me.Practico.Controls.Add(Me.Label8)
        Me.Practico.Controls.Add(Me.cbox_docPractico)
        Me.Practico.Controls.Add(Me.Label9)
        Me.Practico.Controls.Add(Me.tbox_codigoPract)
        Me.Practico.Controls.Add(Me.Label10)
        Me.Practico.Location = New System.Drawing.Point(4, 22)
        Me.Practico.Name = "Practico"
        Me.Practico.Padding = New System.Windows.Forms.Padding(3)
        Me.Practico.Size = New System.Drawing.Size(675, 347)
        Me.Practico.TabIndex = 1
        Me.Practico.Text = "Examen Practico"
        Me.Practico.UseVisualStyleBackColor = True
        '
        'btn_exPract
        '
        Me.btn_exPract.Location = New System.Drawing.Point(360, 234)
        Me.btn_exPract.Name = "btn_exPract"
        Me.btn_exPract.Size = New System.Drawing.Size(111, 23)
        Me.btn_exPract.TabIndex = 32
        Me.btn_exPract.Text = "Guardar"
        Me.btn_exPract.UseVisualStyleBackColor = True
        '
        'tbox_calPract
        '
        Me.tbox_calPract.Location = New System.Drawing.Point(139, 181)
        Me.tbox_calPract.Name = "tbox_calPract"
        Me.tbox_calPract.Size = New System.Drawing.Size(56, 20)
        Me.tbox_calPract.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Calificación:"
        '
        'cbox_instructor
        '
        Me.cbox_instructor.FormattingEnabled = True
        Me.cbox_instructor.Location = New System.Drawing.Point(139, 141)
        Me.cbox_instructor.Name = "cbox_instructor"
        Me.cbox_instructor.Size = New System.Drawing.Size(332, 21)
        Me.cbox_instructor.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Instructor:"
        '
        'date_fechaPract
        '
        Me.date_fechaPract.Location = New System.Drawing.Point(139, 106)
        Me.date_fechaPract.Name = "date_fechaPract"
        Me.date_fechaPract.Size = New System.Drawing.Size(332, 20)
        Me.date_fechaPract.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Fecha:"
        '
        'cbox_docPractico
        '
        Me.cbox_docPractico.FormattingEnabled = True
        Me.cbox_docPractico.Location = New System.Drawing.Point(139, 70)
        Me.cbox_docPractico.Name = "cbox_docPractico"
        Me.cbox_docPractico.Size = New System.Drawing.Size(332, 21)
        Me.cbox_docPractico.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Documento:"
        '
        'tbox_codigoPract
        '
        Me.tbox_codigoPract.Location = New System.Drawing.Point(139, 35)
        Me.tbox_codigoPract.Name = "tbox_codigoPract"
        Me.tbox_codigoPract.Size = New System.Drawing.Size(332, 20)
        Me.tbox_codigoPract.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Codigo:"
        '
        'Municipal
        '
        Me.Municipal.Controls.Add(Me.btn_Municipal)
        Me.Municipal.Controls.Add(Me.rtbox_comentario)
        Me.Municipal.Controls.Add(Me.Label15)
        Me.Municipal.Controls.Add(Me.cbox_estMun)
        Me.Municipal.Controls.Add(Me.Label14)
        Me.Municipal.Controls.Add(Me.cbox_instMun)
        Me.Municipal.Controls.Add(Me.Label13)
        Me.Municipal.Controls.Add(Me.cbox_docMunicipal)
        Me.Municipal.Controls.Add(Me.Label12)
        Me.Municipal.Controls.Add(Me.tbox_codMunicipal)
        Me.Municipal.Controls.Add(Me.Label11)
        Me.Municipal.Location = New System.Drawing.Point(4, 22)
        Me.Municipal.Name = "Municipal"
        Me.Municipal.Size = New System.Drawing.Size(675, 347)
        Me.Municipal.TabIndex = 2
        Me.Municipal.Text = "Examen Municipal"
        Me.Municipal.UseVisualStyleBackColor = True
        '
        'cbox_docMunicipal
        '
        Me.cbox_docMunicipal.FormattingEnabled = True
        Me.cbox_docMunicipal.Location = New System.Drawing.Point(156, 68)
        Me.cbox_docMunicipal.Name = "cbox_docMunicipal"
        Me.cbox_docMunicipal.Size = New System.Drawing.Size(332, 21)
        Me.cbox_docMunicipal.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(51, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Documento:"
        '
        'tbox_codMunicipal
        '
        Me.tbox_codMunicipal.Location = New System.Drawing.Point(156, 30)
        Me.tbox_codMunicipal.Name = "tbox_codMunicipal"
        Me.tbox_codMunicipal.Size = New System.Drawing.Size(332, 20)
        Me.tbox_codMunicipal.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(51, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Codigo:"
        '
        'cbox_instMun
        '
        Me.cbox_instMun.FormattingEnabled = True
        Me.cbox_instMun.Location = New System.Drawing.Point(156, 107)
        Me.cbox_instMun.Name = "cbox_instMun"
        Me.cbox_instMun.Size = New System.Drawing.Size(332, 21)
        Me.cbox_instMun.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(51, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Instructor:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(51, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Estado:"
        '
        'cbox_estMun
        '
        Me.cbox_estMun.FormattingEnabled = True
        Me.cbox_estMun.Location = New System.Drawing.Point(156, 145)
        Me.cbox_estMun.Name = "cbox_estMun"
        Me.cbox_estMun.Size = New System.Drawing.Size(332, 21)
        Me.cbox_estMun.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(51, 186)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Comentario:"
        '
        'rtbox_comentario
        '
        Me.rtbox_comentario.Location = New System.Drawing.Point(156, 186)
        Me.rtbox_comentario.Name = "rtbox_comentario"
        Me.rtbox_comentario.Size = New System.Drawing.Size(332, 96)
        Me.rtbox_comentario.TabIndex = 35
        Me.rtbox_comentario.Text = ""
        '
        'btn_Municipal
        '
        Me.btn_Municipal.Location = New System.Drawing.Point(362, 299)
        Me.btn_Municipal.Name = "btn_Municipal"
        Me.btn_Municipal.Size = New System.Drawing.Size(126, 23)
        Me.btn_Municipal.TabIndex = 36
        Me.btn_Municipal.Text = "Guardar"
        Me.btn_Municipal.UseVisualStyleBackColor = True
        '
        'Examen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Examen"
        Me.Text = "Examen"
        Me.TabControl1.ResumeLayout(False)
        Me.Teorico.ResumeLayout(False)
        Me.Teorico.PerformLayout()
        Me.Practico.ResumeLayout(False)
        Me.Practico.PerformLayout()
        Me.Municipal.ResumeLayout(False)
        Me.Municipal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Teorico As System.Windows.Forms.TabPage
    Friend WithEvents Practico As System.Windows.Forms.TabPage
    Friend WithEvents btn_exTeo As System.Windows.Forms.Button
    Friend WithEvents tbox_calificacionTeo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbox_examinador As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents date_examenTeo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbox_docTeo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbox_codigoTeo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_exPract As System.Windows.Forms.Button
    Friend WithEvents tbox_calPract As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbox_instructor As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents date_fechaPract As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbox_docPractico As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbox_codigoPract As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Municipal As System.Windows.Forms.TabPage
    Friend WithEvents cbox_docMunicipal As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbox_codMunicipal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_Municipal As System.Windows.Forms.Button
    Friend WithEvents rtbox_comentario As System.Windows.Forms.RichTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbox_estMun As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbox_instMun As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
