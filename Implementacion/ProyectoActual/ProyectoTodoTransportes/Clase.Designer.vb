<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clase
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tbox_idTeorica = New System.Windows.Forms.TextBox()
        Me.cbox_cursoTeo = New System.Windows.Forms.ComboBox()
        Me.date_horarioTeo = New System.Windows.Forms.DateTimePicker()
        Me.tbox_duracion = New System.Windows.Forms.TextBox()
        Me.cbox_profesor = New System.Windows.Forms.ComboBox()
        Me.btn_teorica = New System.Windows.Forms.Button()
        Me.cbox_cursoPract = New System.Windows.Forms.ComboBox()
        Me.tbox_idPractica = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbox_instructor = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.date_horarioPract = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(47, 35)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(676, 362)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_teorica)
        Me.TabPage1.Controls.Add(Me.cbox_profesor)
        Me.TabPage1.Controls.Add(Me.tbox_duracion)
        Me.TabPage1.Controls.Add(Me.date_horarioTeo)
        Me.TabPage1.Controls.Add(Me.cbox_cursoTeo)
        Me.TabPage1.Controls.Add(Me.tbox_idTeorica)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(595, 336)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Teorica"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Profesor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Duracion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Horario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Curso:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identificador:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.date_horarioPract)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.cbox_instructor)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.cbox_cursoPract)
        Me.TabPage2.Controls.Add(Me.tbox_idPractica)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(668, 336)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Practica"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tbox_idTeorica
        '
        Me.tbox_idTeorica.Location = New System.Drawing.Point(200, 30)
        Me.tbox_idTeorica.Name = "tbox_idTeorica"
        Me.tbox_idTeorica.Size = New System.Drawing.Size(256, 20)
        Me.tbox_idTeorica.TabIndex = 5
        '
        'cbox_cursoTeo
        '
        Me.cbox_cursoTeo.FormattingEnabled = True
        Me.cbox_cursoTeo.Location = New System.Drawing.Point(200, 65)
        Me.cbox_cursoTeo.Name = "cbox_cursoTeo"
        Me.cbox_cursoTeo.Size = New System.Drawing.Size(256, 21)
        Me.cbox_cursoTeo.TabIndex = 6
        '
        'date_horarioTeo
        '
        Me.date_horarioTeo.Location = New System.Drawing.Point(200, 103)
        Me.date_horarioTeo.Name = "date_horarioTeo"
        Me.date_horarioTeo.Size = New System.Drawing.Size(256, 20)
        Me.date_horarioTeo.TabIndex = 7
        '
        'tbox_duracion
        '
        Me.tbox_duracion.Location = New System.Drawing.Point(200, 140)
        Me.tbox_duracion.Name = "tbox_duracion"
        Me.tbox_duracion.Size = New System.Drawing.Size(256, 20)
        Me.tbox_duracion.TabIndex = 8
        '
        'cbox_profesor
        '
        Me.cbox_profesor.FormattingEnabled = True
        Me.cbox_profesor.Location = New System.Drawing.Point(200, 175)
        Me.cbox_profesor.Name = "cbox_profesor"
        Me.cbox_profesor.Size = New System.Drawing.Size(256, 21)
        Me.cbox_profesor.TabIndex = 9
        '
        'btn_teorica
        '
        Me.btn_teorica.Location = New System.Drawing.Point(355, 235)
        Me.btn_teorica.Name = "btn_teorica"
        Me.btn_teorica.Size = New System.Drawing.Size(101, 23)
        Me.btn_teorica.TabIndex = 10
        Me.btn_teorica.Text = "Guardar"
        Me.btn_teorica.UseVisualStyleBackColor = True
        '
        'cbox_cursoPract
        '
        Me.cbox_cursoPract.FormattingEnabled = True
        Me.cbox_cursoPract.Location = New System.Drawing.Point(205, 68)
        Me.cbox_cursoPract.Name = "cbox_cursoPract"
        Me.cbox_cursoPract.Size = New System.Drawing.Size(256, 21)
        Me.cbox_cursoPract.TabIndex = 10
        '
        'tbox_idPractica
        '
        Me.tbox_idPractica.Location = New System.Drawing.Point(205, 33)
        Me.tbox_idPractica.Name = "tbox_idPractica"
        Me.tbox_idPractica.Size = New System.Drawing.Size(256, 20)
        Me.tbox_idPractica.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Curso:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(72, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Identificador:"
        '
        'cbox_instructor
        '
        Me.cbox_instructor.FormattingEnabled = True
        Me.cbox_instructor.Location = New System.Drawing.Point(205, 105)
        Me.cbox_instructor.Name = "cbox_instructor"
        Me.cbox_instructor.Size = New System.Drawing.Size(256, 21)
        Me.cbox_instructor.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Instructor:"
        '
        'date_horarioPract
        '
        Me.date_horarioPract.Location = New System.Drawing.Point(205, 145)
        Me.date_horarioPract.Name = "date_horarioPract"
        Me.date_horarioPract.Size = New System.Drawing.Size(256, 20)
        Me.date_horarioPract.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Horario:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(360, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Clase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 432)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clase"
        Me.Text = "Clase"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btn_teorica As System.Windows.Forms.Button
    Friend WithEvents cbox_profesor As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_duracion As System.Windows.Forms.TextBox
    Friend WithEvents date_horarioTeo As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbox_cursoTeo As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_idTeorica As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents date_horarioPract As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbox_instructor As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbox_cursoPract As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_idPractica As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
