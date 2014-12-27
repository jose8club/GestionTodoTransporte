<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamenTeorico
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
        Me.btn_exTeo = New System.Windows.Forms.Button()
        Me.tbox_calTeo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbtn_reprobado = New System.Windows.Forms.RadioButton()
        Me.rbtn_aprobado = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_estudiante = New System.Windows.Forms.Label()
        Me.cbox_matricula = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbox_funcionario = New System.Windows.Forms.ComboBox()
        Me.date_rueda = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_exTeo
        '
        Me.btn_exTeo.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.SAVE
        Me.btn_exTeo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exTeo.Location = New System.Drawing.Point(367, 254)
        Me.btn_exTeo.Name = "btn_exTeo"
        Me.btn_exTeo.Size = New System.Drawing.Size(131, 34)
        Me.btn_exTeo.TabIndex = 72
        Me.btn_exTeo.Text = "Guardar"
        Me.btn_exTeo.UseVisualStyleBackColor = True
        '
        'tbox_calTeo
        '
        Me.tbox_calTeo.Location = New System.Drawing.Point(153, 162)
        Me.tbox_calTeo.Name = "tbox_calTeo"
        Me.tbox_calTeo.Size = New System.Drawing.Size(56, 20)
        Me.tbox_calTeo.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Calificación:"
        '
        'rbtn_reprobado
        '
        Me.rbtn_reprobado.AutoSize = True
        Me.rbtn_reprobado.Location = New System.Drawing.Point(288, 217)
        Me.rbtn_reprobado.Name = "rbtn_reprobado"
        Me.rbtn_reprobado.Size = New System.Drawing.Size(78, 17)
        Me.rbtn_reprobado.TabIndex = 71
        Me.rbtn_reprobado.TabStop = True
        Me.rbtn_reprobado.Text = "Reprobado"
        Me.rbtn_reprobado.UseVisualStyleBackColor = True
        '
        'rbtn_aprobado
        '
        Me.rbtn_aprobado.AutoSize = True
        Me.rbtn_aprobado.Location = New System.Drawing.Point(153, 217)
        Me.rbtn_aprobado.Name = "rbtn_aprobado"
        Me.rbtn_aprobado.Size = New System.Drawing.Size(71, 17)
        Me.rbtn_aprobado.TabIndex = 70
        Me.rbtn_aprobado.TabStop = True
        Me.rbtn_aprobado.Text = "Aprobado"
        Me.rbtn_aprobado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Estado:"
        '
        'lbl_estudiante
        '
        Me.lbl_estudiante.AutoSize = True
        Me.lbl_estudiante.Location = New System.Drawing.Point(273, 30)
        Me.lbl_estudiante.Name = "lbl_estudiante"
        Me.lbl_estudiante.Size = New System.Drawing.Size(39, 13)
        Me.lbl_estudiante.TabIndex = 66
        Me.lbl_estudiante.Text = "Label8"
        '
        'cbox_matricula
        '
        Me.cbox_matricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_matricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_matricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_matricula.FormattingEnabled = True
        Me.cbox_matricula.Location = New System.Drawing.Point(151, 27)
        Me.cbox_matricula.Name = "cbox_matricula"
        Me.cbox_matricula.Size = New System.Drawing.Size(99, 21)
        Me.cbox_matricula.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Registro de Matricula:"
        '
        'cbox_funcionario
        '
        Me.cbox_funcionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_funcionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_funcionario.FormattingEnabled = True
        Me.cbox_funcionario.Location = New System.Drawing.Point(151, 74)
        Me.cbox_funcionario.Name = "cbox_funcionario"
        Me.cbox_funcionario.Size = New System.Drawing.Size(347, 21)
        Me.cbox_funcionario.TabIndex = 67
        '
        'date_rueda
        '
        Me.date_rueda.Location = New System.Drawing.Point(151, 119)
        Me.date_rueda.Name = "date_rueda"
        Me.date_rueda.Size = New System.Drawing.Size(347, 20)
        Me.date_rueda.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Profesor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Fecha:"
        '
        'btn_reset
        '
        Me.btn_reset.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON
        Me.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reset.Location = New System.Drawing.Point(41, 254)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(137, 34)
        Me.btn_reset.TabIndex = 73
        Me.btn_reset.Text = "Resetear"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'ExamenTeorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 369)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.rbtn_reprobado)
        Me.Controls.Add(Me.rbtn_aprobado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_estudiante)
        Me.Controls.Add(Me.cbox_matricula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbox_funcionario)
        Me.Controls.Add(Me.date_rueda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbox_calTeo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_exTeo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExamenTeorico"
        Me.Text = "ExamenTeorico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_exTeo As System.Windows.Forms.Button
    Friend WithEvents tbox_calTeo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbtn_reprobado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_aprobado As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_estudiante As System.Windows.Forms.Label
    Friend WithEvents cbox_matricula As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbox_funcionario As System.Windows.Forms.ComboBox
    Friend WithEvents date_rueda As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_reset As System.Windows.Forms.Button
End Class
