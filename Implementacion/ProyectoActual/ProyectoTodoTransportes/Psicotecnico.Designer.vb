<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Psicotecnico
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
        Me.btn_psico = New System.Windows.Forms.Button()
        Me.rbtn_reprobado = New System.Windows.Forms.RadioButton()
        Me.rbtn_aprobado = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_estudiante = New System.Windows.Forms.Label()
        Me.cbox_matricula = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbox_funcionario = New System.Windows.Forms.ComboBox()
        Me.date_psico = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_psico
        '
        Me.btn_psico.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.SAVE
        Me.btn_psico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_psico.Location = New System.Drawing.Point(420, 260)
        Me.btn_psico.Name = "btn_psico"
        Me.btn_psico.Size = New System.Drawing.Size(131, 33)
        Me.btn_psico.TabIndex = 50
        Me.btn_psico.Text = "Guardar"
        Me.btn_psico.UseVisualStyleBackColor = True
        '
        'rbtn_reprobado
        '
        Me.rbtn_reprobado.AutoSize = True
        Me.rbtn_reprobado.Location = New System.Drawing.Point(328, 193)
        Me.rbtn_reprobado.Name = "rbtn_reprobado"
        Me.rbtn_reprobado.Size = New System.Drawing.Size(78, 17)
        Me.rbtn_reprobado.TabIndex = 49
        Me.rbtn_reprobado.TabStop = True
        Me.rbtn_reprobado.Text = "Reprobado"
        Me.rbtn_reprobado.UseVisualStyleBackColor = True
        '
        'rbtn_aprobado
        '
        Me.rbtn_aprobado.AutoSize = True
        Me.rbtn_aprobado.Location = New System.Drawing.Point(204, 193)
        Me.rbtn_aprobado.Name = "rbtn_aprobado"
        Me.rbtn_aprobado.Size = New System.Drawing.Size(71, 17)
        Me.rbtn_aprobado.TabIndex = 48
        Me.rbtn_aprobado.TabStop = True
        Me.rbtn_aprobado.Text = "Aprobado"
        Me.rbtn_aprobado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Estado:"
        '
        'lbl_estudiante
        '
        Me.lbl_estudiante.AutoSize = True
        Me.lbl_estudiante.Location = New System.Drawing.Point(327, 47)
        Me.lbl_estudiante.Name = "lbl_estudiante"
        Me.lbl_estudiante.Size = New System.Drawing.Size(39, 13)
        Me.lbl_estudiante.TabIndex = 45
        Me.lbl_estudiante.Text = "Label8"
        '
        'cbox_matricula
        '
        Me.cbox_matricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_matricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_matricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_matricula.FormattingEnabled = True
        Me.cbox_matricula.Location = New System.Drawing.Point(204, 44)
        Me.cbox_matricula.Name = "cbox_matricula"
        Me.cbox_matricula.Size = New System.Drawing.Size(99, 21)
        Me.cbox_matricula.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Registro de Matricula:"
        '
        'cbox_funcionario
        '
        Me.cbox_funcionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_funcionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_funcionario.FormattingEnabled = True
        Me.cbox_funcionario.Location = New System.Drawing.Point(204, 94)
        Me.cbox_funcionario.Name = "cbox_funcionario"
        Me.cbox_funcionario.Size = New System.Drawing.Size(347, 21)
        Me.cbox_funcionario.TabIndex = 46
        '
        'date_psico
        '
        Me.date_psico.Location = New System.Drawing.Point(204, 145)
        Me.date_psico.Name = "date_psico"
        Me.date_psico.Size = New System.Drawing.Size(347, 20)
        Me.date_psico.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Funcionario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Fecha:"
        '
        'btn_reset
        '
        Me.btn_reset.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON
        Me.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reset.Location = New System.Drawing.Point(83, 260)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(133, 33)
        Me.btn_reset.TabIndex = 51
        Me.btn_reset.Text = "Resetear"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'Psicotecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 394)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.rbtn_reprobado)
        Me.Controls.Add(Me.rbtn_aprobado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_estudiante)
        Me.Controls.Add(Me.cbox_matricula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbox_funcionario)
        Me.Controls.Add(Me.date_psico)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_psico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Psicotecnico"
        Me.Text = "Psicotecnico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_psico As System.Windows.Forms.Button
    Friend WithEvents rbtn_reprobado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_aprobado As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_estudiante As System.Windows.Forms.Label
    Friend WithEvents cbox_matricula As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbox_funcionario As System.Windows.Forms.ComboBox
    Friend WithEvents date_psico As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_reset As System.Windows.Forms.Button
End Class
