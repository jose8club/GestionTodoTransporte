<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asistencias
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_estudiante = New System.Windows.Forms.Label()
        Me.cbox_estudiante = New System.Windows.Forms.ComboBox()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.date_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.sbox_hor2 = New System.Windows.Forms.NumericUpDown()
        Me.sbox_hor1 = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_vehiculo = New System.Windows.Forms.Label()
        Me.lbl_marca = New System.Windows.Forms.Label()
        Me.cbox_docente = New System.Windows.Forms.ComboBox()
        Me.lbl_docente = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_resetear = New System.Windows.Forms.Button()
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.lbl_estado = New System.Windows.Forms.ToolStrip()
        Me.lbl_estatus = New System.Windows.Forms.ToolStripLabel()
        Me.cbox_clasedia = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbox_numero = New System.Windows.Forms.TextBox()
        CType(Me.sbox_hor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbox_hor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lbl_estado.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estudiante:"
        '
        'lbl_estudiante
        '
        Me.lbl_estudiante.AutoSize = True
        Me.lbl_estudiante.Location = New System.Drawing.Point(240, 39)
        Me.lbl_estudiante.Name = "lbl_estudiante"
        Me.lbl_estudiante.Size = New System.Drawing.Size(39, 13)
        Me.lbl_estudiante.TabIndex = 43
        Me.lbl_estudiante.Text = "Label8"
        '
        'cbox_estudiante
        '
        Me.cbox_estudiante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_estudiante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_estudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_estudiante.FormattingEnabled = True
        Me.cbox_estudiante.Location = New System.Drawing.Point(104, 36)
        Me.cbox_estudiante.Name = "cbox_estudiante"
        Me.cbox_estudiante.Size = New System.Drawing.Size(106, 21)
        Me.cbox_estudiante.TabIndex = 42
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(27, 117)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Fecha.TabIndex = 63
        Me.lbl_Fecha.Text = "Fecha:"
        '
        'date_Fecha
        '
        Me.date_Fecha.Location = New System.Drawing.Point(104, 110)
        Me.date_Fecha.Name = "date_Fecha"
        Me.date_Fecha.Size = New System.Drawing.Size(210, 20)
        Me.date_Fecha.TabIndex = 62
        '
        'sbox_hor2
        '
        Me.sbox_hor2.Location = New System.Drawing.Point(224, 154)
        Me.sbox_hor2.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.sbox_hor2.Name = "sbox_hor2"
        Me.sbox_hor2.Size = New System.Drawing.Size(45, 20)
        Me.sbox_hor2.TabIndex = 108
        '
        'sbox_hor1
        '
        Me.sbox_hor1.Location = New System.Drawing.Point(104, 154)
        Me.sbox_hor1.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.sbox_hor1.Name = "sbox_hor1"
        Me.sbox_hor1.Size = New System.Drawing.Size(44, 20)
        Me.sbox_hor1.TabIndex = 107
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(290, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "hrs."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(181, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 24)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "Horario:"
        '
        'lbl_vehiculo
        '
        Me.lbl_vehiculo.AutoSize = True
        Me.lbl_vehiculo.Location = New System.Drawing.Point(27, 299)
        Me.lbl_vehiculo.Name = "lbl_vehiculo"
        Me.lbl_vehiculo.Size = New System.Drawing.Size(51, 13)
        Me.lbl_vehiculo.TabIndex = 109
        Me.lbl_vehiculo.Text = "Vehiculo:"
        '
        'lbl_marca
        '
        Me.lbl_marca.AutoSize = True
        Me.lbl_marca.Location = New System.Drawing.Point(240, 299)
        Me.lbl_marca.Name = "lbl_marca"
        Me.lbl_marca.Size = New System.Drawing.Size(39, 13)
        Me.lbl_marca.TabIndex = 111
        Me.lbl_marca.Text = "Label8"
        '
        'cbox_docente
        '
        Me.cbox_docente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_docente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_docente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_docente.FormattingEnabled = True
        Me.cbox_docente.Location = New System.Drawing.Point(104, 199)
        Me.cbox_docente.Name = "cbox_docente"
        Me.cbox_docente.Size = New System.Drawing.Size(210, 20)
        Me.cbox_docente.TabIndex = 113
        '
        'lbl_docente
        '
        Me.lbl_docente.AutoSize = True
        Me.lbl_docente.Location = New System.Drawing.Point(27, 202)
        Me.lbl_docente.Name = "lbl_docente"
        Me.lbl_docente.Size = New System.Drawing.Size(51, 13)
        Me.lbl_docente.TabIndex = 112
        Me.lbl_docente.Text = "Docente:"
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.SAVE
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.Location = New System.Drawing.Point(200, 333)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(114, 39)
        Me.btn_guardar.TabIndex = 114
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_resetear
        '
        Me.btn_resetear.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON
        Me.btn_resetear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_resetear.Location = New System.Drawing.Point(30, 333)
        Me.btn_resetear.Name = "btn_resetear"
        Me.btn_resetear.Size = New System.Drawing.Size(118, 39)
        Me.btn_resetear.TabIndex = 115
        Me.btn_resetear.Text = "Resetear"
        Me.btn_resetear.UseVisualStyleBackColor = True
        '
        'lbl_matricula
        '
        Me.lbl_matricula.AutoSize = True
        Me.lbl_matricula.Location = New System.Drawing.Point(101, 299)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Size = New System.Drawing.Size(39, 13)
        Me.lbl_matricula.TabIndex = 116
        Me.lbl_matricula.Text = "Label2"
        '
        'lbl_estado
        '
        Me.lbl_estado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_estado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_estatus})
        Me.lbl_estado.Location = New System.Drawing.Point(0, 375)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(391, 25)
        Me.lbl_estado.TabIndex = 117
        Me.lbl_estado.Text = "estado"
        '
        'lbl_estatus
        '
        Me.lbl_estatus.Name = "lbl_estatus"
        Me.lbl_estatus.Size = New System.Drawing.Size(89, 22)
        Me.lbl_estatus.Text = "ToolStripLabel1"
        '
        'cbox_clasedia
        '
        Me.cbox_clasedia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_clasedia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_clasedia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_clasedia.FormattingEnabled = True
        Me.cbox_clasedia.Location = New System.Drawing.Point(106, 246)
        Me.cbox_clasedia.Name = "cbox_clasedia"
        Me.cbox_clasedia.Size = New System.Drawing.Size(208, 20)
        Me.cbox_clasedia.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Curso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Numero:"
        '
        'tbox_numero
        '
        Me.tbox_numero.Location = New System.Drawing.Point(106, 76)
        Me.tbox_numero.Name = "tbox_numero"
        Me.tbox_numero.Size = New System.Drawing.Size(100, 20)
        Me.tbox_numero.TabIndex = 122
        '
        'Asistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 400)
        Me.Controls.Add(Me.tbox_numero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbox_clasedia)
        Me.Controls.Add(Me.lbl_estado)
        Me.Controls.Add(Me.lbl_matricula)
        Me.Controls.Add(Me.btn_resetear)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.cbox_docente)
        Me.Controls.Add(Me.lbl_docente)
        Me.Controls.Add(Me.lbl_marca)
        Me.Controls.Add(Me.lbl_vehiculo)
        Me.Controls.Add(Me.sbox_hor2)
        Me.Controls.Add(Me.sbox_hor1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.date_Fecha)
        Me.Controls.Add(Me.lbl_estudiante)
        Me.Controls.Add(Me.cbox_estudiante)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Asistencias"
        Me.Text = "Asistencias"
        CType(Me.sbox_hor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbox_hor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lbl_estado.ResumeLayout(False)
        Me.lbl_estado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_estudiante As System.Windows.Forms.Label
    Friend WithEvents cbox_estudiante As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents date_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents sbox_hor2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents sbox_hor1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_vehiculo As System.Windows.Forms.Label
    Friend WithEvents lbl_marca As System.Windows.Forms.Label
    Friend WithEvents cbox_docente As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_docente As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_resetear As System.Windows.Forms.Button
    Friend WithEvents lbl_matricula As System.Windows.Forms.Label
    Friend WithEvents lbl_estado As System.Windows.Forms.ToolStrip
    Friend WithEvents lbl_estatus As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cbox_clasedia As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbox_numero As System.Windows.Forms.TextBox
End Class
