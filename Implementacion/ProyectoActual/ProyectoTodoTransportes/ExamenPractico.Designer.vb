<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamenPractico
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
        Me.btn_exPract = New System.Windows.Forms.Button()
        Me.rbtn_reprobado = New System.Windows.Forms.RadioButton()
        Me.rbtn_aprobado = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_estudiante = New System.Windows.Forms.Label()
        Me.cbox_matricula = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbox_funcionario = New System.Windows.Forms.ComboBox()
        Me.date_practico = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbox_calPract = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_exPract
        '
        Me.btn_exPract.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.SAVE
        Me.btn_exPract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exPract.Location = New System.Drawing.Point(387, 271)
        Me.btn_exPract.Name = "btn_exPract"
        Me.btn_exPract.Size = New System.Drawing.Size(133, 32)
        Me.btn_exPract.TabIndex = 84
        Me.btn_exPract.Text = "Guardar"
        Me.btn_exPract.UseVisualStyleBackColor = True
        '
        'rbtn_reprobado
        '
        Me.rbtn_reprobado.AutoSize = True
        Me.rbtn_reprobado.Location = New System.Drawing.Point(291, 227)
        Me.rbtn_reprobado.Name = "rbtn_reprobado"
        Me.rbtn_reprobado.Size = New System.Drawing.Size(78, 17)
        Me.rbtn_reprobado.TabIndex = 82
        Me.rbtn_reprobado.TabStop = True
        Me.rbtn_reprobado.Text = "Reprobado"
        Me.rbtn_reprobado.UseVisualStyleBackColor = True
        '
        'rbtn_aprobado
        '
        Me.rbtn_aprobado.AutoSize = True
        Me.rbtn_aprobado.Location = New System.Drawing.Point(156, 227)
        Me.rbtn_aprobado.Name = "rbtn_aprobado"
        Me.rbtn_aprobado.Size = New System.Drawing.Size(71, 17)
        Me.rbtn_aprobado.TabIndex = 81
        Me.rbtn_aprobado.TabStop = True
        Me.rbtn_aprobado.Text = "Aprobado"
        Me.rbtn_aprobado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Estado:"
        '
        'lbl_estudiante
        '
        Me.lbl_estudiante.AutoSize = True
        Me.lbl_estudiante.Location = New System.Drawing.Point(276, 40)
        Me.lbl_estudiante.Name = "lbl_estudiante"
        Me.lbl_estudiante.Size = New System.Drawing.Size(39, 13)
        Me.lbl_estudiante.TabIndex = 77
        Me.lbl_estudiante.Text = "Label8"
        '
        'cbox_matricula
        '
        Me.cbox_matricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_matricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_matricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_matricula.FormattingEnabled = True
        Me.cbox_matricula.Location = New System.Drawing.Point(154, 37)
        Me.cbox_matricula.Name = "cbox_matricula"
        Me.cbox_matricula.Size = New System.Drawing.Size(99, 21)
        Me.cbox_matricula.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Registro de Matricula:"
        '
        'cbox_funcionario
        '
        Me.cbox_funcionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_funcionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_funcionario.FormattingEnabled = True
        Me.cbox_funcionario.Location = New System.Drawing.Point(154, 84)
        Me.cbox_funcionario.Name = "cbox_funcionario"
        Me.cbox_funcionario.Size = New System.Drawing.Size(347, 21)
        Me.cbox_funcionario.TabIndex = 78
        '
        'date_practico
        '
        Me.date_practico.Location = New System.Drawing.Point(154, 129)
        Me.date_practico.Name = "date_practico"
        Me.date_practico.Size = New System.Drawing.Size(347, 20)
        Me.date_practico.TabIndex = 79
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Instructor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Fecha:"
        '
        'tbox_calPract
        '
        Me.tbox_calPract.Location = New System.Drawing.Point(154, 175)
        Me.tbox_calPract.Name = "tbox_calPract"
        Me.tbox_calPract.Size = New System.Drawing.Size(56, 20)
        Me.tbox_calPract.TabIndex = 80
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Calificación:"
        '
        'btn_reset
        '
        Me.btn_reset.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON
        Me.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reset.Location = New System.Drawing.Point(44, 271)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(137, 32)
        Me.btn_reset.TabIndex = 85
        Me.btn_reset.Text = "Resetear"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'ExamenPractico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 353)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.tbox_calPract)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbtn_reprobado)
        Me.Controls.Add(Me.rbtn_aprobado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_estudiante)
        Me.Controls.Add(Me.cbox_matricula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbox_funcionario)
        Me.Controls.Add(Me.date_practico)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_exPract)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExamenPractico"
        Me.Text = "ExamenPractico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_exPract As System.Windows.Forms.Button
    Friend WithEvents rbtn_reprobado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_aprobado As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_estudiante As System.Windows.Forms.Label
    Friend WithEvents cbox_matricula As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbox_funcionario As System.Windows.Forms.ComboBox
    Friend WithEvents date_practico As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbox_calPract As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_reset As System.Windows.Forms.Button
End Class
