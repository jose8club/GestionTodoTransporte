<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newFlota
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbox_anios = New System.Windows.Forms.ComboBox()
        Me.btn_retract = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbox_mat3 = New CustomTxtBox.Custom2()
        Me.tbox_mat2 = New CustomTxtBox.Custom2()
        Me.tbox_mat1 = New CustomTxtBox.Custom2()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbox_modelo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.cbox_instructor = New System.Windows.Forms.ComboBox()
        Me.cbox_estado = New System.Windows.Forms.ComboBox()
        Me.lbl_encInstAgregar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_encInstActualizar = New System.Windows.Forms.Label()
        Me.lbl_instructor = New System.Windows.Forms.Label()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.cbox_estado2 = New System.Windows.Forms.ComboBox()
        Me.cbox_matricula = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_resetear02 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbox_anios)
        Me.GroupBox1.Controls.Add(Me.btn_retract)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbox_mat3)
        Me.GroupBox1.Controls.Add(Me.tbox_mat2)
        Me.GroupBox1.Controls.Add(Me.tbox_mat1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbox_modelo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn_agregar)
        Me.GroupBox1.Controls.Add(Me.cbox_instructor)
        Me.GroupBox1.Controls.Add(Me.cbox_estado)
        Me.GroupBox1.Controls.Add(Me.lbl_encInstAgregar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 217)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Vehiculo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Año Procedencia:"
        '
        'cbox_anios
        '
        Me.cbox_anios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_anios.FormattingEnabled = True
        Me.cbox_anios.Location = New System.Drawing.Point(135, 28)
        Me.cbox_anios.Name = "cbox_anios"
        Me.cbox_anios.Size = New System.Drawing.Size(136, 21)
        Me.cbox_anios.TabIndex = 3
        '
        'btn_retract
        '
        Me.btn_retract.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retract.Location = New System.Drawing.Point(362, 142)
        Me.btn_retract.Name = "btn_retract"
        Me.btn_retract.Size = New System.Drawing.Size(22, 22)
        Me.btn_retract.TabIndex = 20
        Me.btn_retract.Text = "X"
        Me.btn_retract.UseVisualStyleBackColor = True
        Me.btn_retract.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.bandera
        Me.Label8.Location = New System.Drawing.Point(268, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "."
        '
        'tbox_mat3
        '
        Me.tbox_mat3.Location = New System.Drawing.Point(288, 58)
        Me.tbox_mat3.MaxLength = 2
        Me.tbox_mat3.Name = "tbox_mat3"
        Me.tbox_mat3.Size = New System.Drawing.Size(51, 20)
        Me.tbox_mat3.TabIndex = 17
        Me.tbox_mat3.Tipo = CustomTxtBox.Custom2.Tipologia.NUMERO
        '
        'tbox_mat2
        '
        Me.tbox_mat2.Location = New System.Drawing.Point(211, 58)
        Me.tbox_mat2.MaxLength = 2
        Me.tbox_mat2.Name = "tbox_mat2"
        Me.tbox_mat2.Size = New System.Drawing.Size(51, 20)
        Me.tbox_mat2.TabIndex = 16
        Me.tbox_mat2.Tipo = CustomTxtBox.Custom2.Tipologia.NUMERO
        '
        'tbox_mat1
        '
        Me.tbox_mat1.Location = New System.Drawing.Point(135, 58)
        Me.tbox_mat1.MaxLength = 2
        Me.tbox_mat1.Name = "tbox_mat1"
        Me.tbox_mat1.Size = New System.Drawing.Size(51, 20)
        Me.tbox_mat1.TabIndex = 15
        Me.tbox_mat1.Tipo = CustomTxtBox.Custom2.Tipologia.LETRA
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.punto
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label7.Location = New System.Drawing.Point(192, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "*"
        '
        'tbox_modelo
        '
        Me.tbox_modelo.Location = New System.Drawing.Point(135, 114)
        Me.tbox_modelo.Name = "tbox_modelo"
        Me.tbox_modelo.Size = New System.Drawing.Size(206, 20)
        Me.tbox_modelo.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Modelo:"
        '
        'btn_agregar
        '
        Me.btn_agregar.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.ADD_BUTTON
        Me.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregar.Location = New System.Drawing.Point(395, 177)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(79, 23)
        Me.btn_agregar.TabIndex = 10
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'cbox_instructor
        '
        Me.cbox_instructor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_instructor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_instructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_instructor.FormattingEnabled = True
        Me.cbox_instructor.Location = New System.Drawing.Point(135, 144)
        Me.cbox_instructor.Name = "cbox_instructor"
        Me.cbox_instructor.Size = New System.Drawing.Size(206, 21)
        Me.cbox_instructor.TabIndex = 9
        Me.cbox_instructor.Visible = False
        '
        'cbox_estado
        '
        Me.cbox_estado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_estado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_estado.FormattingEnabled = True
        Me.cbox_estado.Location = New System.Drawing.Point(135, 87)
        Me.cbox_estado.Name = "cbox_estado"
        Me.cbox_estado.Size = New System.Drawing.Size(206, 21)
        Me.cbox_estado.TabIndex = 7
        '
        'lbl_encInstAgregar
        '
        Me.lbl_encInstAgregar.AutoSize = True
        Me.lbl_encInstAgregar.Location = New System.Drawing.Point(24, 146)
        Me.lbl_encInstAgregar.Name = "lbl_encInstAgregar"
        Me.lbl_encInstAgregar.Size = New System.Drawing.Size(54, 13)
        Me.lbl_encInstAgregar.TabIndex = 2
        Me.lbl_encInstAgregar.Text = "Instructor:"
        Me.lbl_encInstAgregar.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matricula/Patente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_encInstActualizar)
        Me.GroupBox2.Controls.Add(Me.lbl_instructor)
        Me.GroupBox2.Controls.Add(Me.btn_actualizar)
        Me.GroupBox2.Controls.Add(Me.cbox_estado2)
        Me.GroupBox2.Controls.Add(Me.cbox_matricula)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(631, 113)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestión de Flota"
        '
        'lbl_encInstActualizar
        '
        Me.lbl_encInstActualizar.AutoSize = True
        Me.lbl_encInstActualizar.Location = New System.Drawing.Point(359, 33)
        Me.lbl_encInstActualizar.Name = "lbl_encInstActualizar"
        Me.lbl_encInstActualizar.Size = New System.Drawing.Size(54, 13)
        Me.lbl_encInstActualizar.TabIndex = 17
        Me.lbl_encInstActualizar.Text = "Instructor:"
        Me.lbl_encInstActualizar.Visible = False
        '
        'lbl_instructor
        '
        Me.lbl_instructor.AutoSize = True
        Me.lbl_instructor.Location = New System.Drawing.Point(441, 33)
        Me.lbl_instructor.Name = "lbl_instructor"
        Me.lbl_instructor.Size = New System.Drawing.Size(54, 13)
        Me.lbl_instructor.TabIndex = 13
        Me.lbl_instructor.Text = "Instructor:"
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.SAVE
        Me.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar.Location = New System.Drawing.Point(395, 84)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(79, 23)
        Me.btn_actualizar.TabIndex = 15
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'cbox_estado2
        '
        Me.cbox_estado2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_estado2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_estado2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_estado2.FormattingEnabled = True
        Me.cbox_estado2.Location = New System.Drawing.Point(135, 60)
        Me.cbox_estado2.Name = "cbox_estado2"
        Me.cbox_estado2.Size = New System.Drawing.Size(206, 21)
        Me.cbox_estado2.TabIndex = 13
        '
        'cbox_matricula
        '
        Me.cbox_matricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_matricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_matricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_matricula.FormattingEnabled = True
        Me.cbox_matricula.Location = New System.Drawing.Point(135, 33)
        Me.cbox_matricula.Name = "cbox_matricula"
        Me.cbox_matricula.Size = New System.Drawing.Size(206, 21)
        Me.cbox_matricula.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Estado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Matricula:"
        '
        'btn_resetear02
        '
        Me.btn_resetear02.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON
        Me.btn_resetear02.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_resetear02.Location = New System.Drawing.Point(571, 354)
        Me.btn_resetear02.Name = "btn_resetear02"
        Me.btn_resetear02.Size = New System.Drawing.Size(87, 33)
        Me.btn_resetear02.TabIndex = 16
        Me.btn_resetear02.Text = "Resetear"
        Me.btn_resetear02.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_resetear02.UseVisualStyleBackColor = True
        '
        'newFlota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 417)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_resetear02)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newFlota"
        Me.Text = "newFlota"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents cbox_instructor As System.Windows.Forms.ComboBox
    Friend WithEvents cbox_estado As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_encInstAgregar As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_resetear02 As System.Windows.Forms.Button
    Friend WithEvents btn_actualizar As System.Windows.Forms.Button
    Friend WithEvents cbox_estado2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbox_matricula As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbox_modelo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_instructor As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbox_anio As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_mat3 As CustomTxtBox.Custom2
    Friend WithEvents tbox_mat2 As CustomTxtBox.Custom2
    Friend WithEvents tbox_mat1 As CustomTxtBox.Custom2
    Friend WithEvents cbox_anios As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_encInstActualizar As System.Windows.Forms.Label
    Friend WithEvents btn_retract As System.Windows.Forms.Button
    'Friend WithEvents tbox_mat2 As CustomTxtBox.Custom2
    'Friend WithEvents tbox_mat1 As CustomTxtBox.Custom2
    'Friend WithEvents tbox_mat3 As CustomTxtBox.Custom2
End Class
