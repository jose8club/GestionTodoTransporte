﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Practico = New System.Windows.Forms.TabPage()
        Me.btn_exTeo = New System.Windows.Forms.Button()
        Me.tbox_calificacionPract = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbox_instructor = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.date_examenPract = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbox_docPract = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbox_codigoPract = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_exPract = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.Teorico.SuspendLayout()
        Me.Practico.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Teorico)
        Me.TabControl1.Controls.Add(Me.Practico)
        Me.TabControl1.Location = New System.Drawing.Point(32, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(683, 373)
        Me.TabControl1.TabIndex = 0
        '
        'Teorico
        '
        Me.Teorico.Controls.Add(Me.btn_exTeo)
        Me.Teorico.Controls.Add(Me.tbox_calificacionPract)
        Me.Teorico.Controls.Add(Me.Label5)
        Me.Teorico.Controls.Add(Me.cbox_instructor)
        Me.Teorico.Controls.Add(Me.Label4)
        Me.Teorico.Controls.Add(Me.date_examenPract)
        Me.Teorico.Controls.Add(Me.Label3)
        Me.Teorico.Controls.Add(Me.cbox_docPract)
        Me.Teorico.Controls.Add(Me.Label2)
        Me.Teorico.Controls.Add(Me.tbox_codigoPract)
        Me.Teorico.Controls.Add(Me.Label1)
        Me.Teorico.Location = New System.Drawing.Point(4, 22)
        Me.Teorico.Name = "Teorico"
        Me.Teorico.Padding = New System.Windows.Forms.Padding(3)
        Me.Teorico.Size = New System.Drawing.Size(675, 421)
        Me.Teorico.TabIndex = 0
        Me.Teorico.Text = "Examen Teorico"
        Me.Teorico.UseVisualStyleBackColor = True
        '
        'Practico
        '
        Me.Practico.Controls.Add(Me.btn_exPract)
        Me.Practico.Controls.Add(Me.TextBox1)
        Me.Practico.Controls.Add(Me.Label6)
        Me.Practico.Controls.Add(Me.ComboBox1)
        Me.Practico.Controls.Add(Me.Label7)
        Me.Practico.Controls.Add(Me.DateTimePicker1)
        Me.Practico.Controls.Add(Me.Label8)
        Me.Practico.Controls.Add(Me.ComboBox2)
        Me.Practico.Controls.Add(Me.Label9)
        Me.Practico.Controls.Add(Me.TextBox2)
        Me.Practico.Controls.Add(Me.Label10)
        Me.Practico.Location = New System.Drawing.Point(4, 22)
        Me.Practico.Name = "Practico"
        Me.Practico.Padding = New System.Windows.Forms.Padding(3)
        Me.Practico.Size = New System.Drawing.Size(675, 347)
        Me.Practico.TabIndex = 1
        Me.Practico.Text = "Examen Practico"
        Me.Practico.UseVisualStyleBackColor = True
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
        'tbox_calificacionPract
        '
        Me.tbox_calificacionPract.Location = New System.Drawing.Point(132, 181)
        Me.tbox_calificacionPract.Name = "tbox_calificacionPract"
        Me.tbox_calificacionPract.Size = New System.Drawing.Size(56, 20)
        Me.tbox_calificacionPract.TabIndex = 20
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
        'cbox_instructor
        '
        Me.cbox_instructor.FormattingEnabled = True
        Me.cbox_instructor.Location = New System.Drawing.Point(132, 141)
        Me.cbox_instructor.Name = "cbox_instructor"
        Me.cbox_instructor.Size = New System.Drawing.Size(332, 21)
        Me.cbox_instructor.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Instructor:"
        '
        'date_examenPract
        '
        Me.date_examenPract.Location = New System.Drawing.Point(132, 106)
        Me.date_examenPract.Name = "date_examenPract"
        Me.date_examenPract.Size = New System.Drawing.Size(332, 20)
        Me.date_examenPract.TabIndex = 16
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
        'cbox_docPract
        '
        Me.cbox_docPract.FormattingEnabled = True
        Me.cbox_docPract.Location = New System.Drawing.Point(132, 70)
        Me.cbox_docPract.Name = "cbox_docPract"
        Me.cbox_docPract.Size = New System.Drawing.Size(332, 21)
        Me.cbox_docPract.TabIndex = 14
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
        'tbox_codigoPract
        '
        Me.tbox_codigoPract.Location = New System.Drawing.Point(132, 35)
        Me.tbox_codigoPract.Name = "tbox_codigoPract"
        Me.tbox_codigoPract.Size = New System.Drawing.Size(332, 20)
        Me.tbox_codigoPract.TabIndex = 12
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
        'btn_exPract
        '
        Me.btn_exPract.Location = New System.Drawing.Point(360, 234)
        Me.btn_exPract.Name = "btn_exPract"
        Me.btn_exPract.Size = New System.Drawing.Size(111, 23)
        Me.btn_exPract.TabIndex = 32
        Me.btn_exPract.Text = "Guardar"
        Me.btn_exPract.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(139, 181)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 31
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(139, 141)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(332, 21)
        Me.ComboBox1.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Examinador:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(139, 106)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(332, 20)
        Me.DateTimePicker1.TabIndex = 27
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
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(139, 70)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(332, 21)
        Me.ComboBox2.TabIndex = 25
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(139, 35)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(332, 20)
        Me.TextBox2.TabIndex = 23
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Teorico As System.Windows.Forms.TabPage
    Friend WithEvents Practico As System.Windows.Forms.TabPage
    Friend WithEvents btn_exTeo As System.Windows.Forms.Button
    Friend WithEvents tbox_calificacionPract As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbox_instructor As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents date_examenPract As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbox_docPract As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbox_codigoPract As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_exPract As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class