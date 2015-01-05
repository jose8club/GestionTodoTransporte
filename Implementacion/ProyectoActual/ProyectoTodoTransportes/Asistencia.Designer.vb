<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asistencia
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grp_asistencia = New System.Windows.Forms.GroupBox()
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.lbl_marca = New System.Windows.Forms.Label()
        Me.lbl_vehiculo = New System.Windows.Forms.Label()
        Me.btn_resetear = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbox_clasedia = New System.Windows.Forms.ComboBox()
        Me.sbox_hor2 = New System.Windows.Forms.NumericUpDown()
        Me.sbox_hor1 = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.date_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.cbox_docente = New System.Windows.Forms.ComboBox()
        Me.lbl_docente = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lbl_estado = New System.Windows.Forms.ToolStripLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_asistencia.SuspendLayout()
        CType(Me.sbox_hor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbox_hor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 120
        Me.DataGridView1.Size = New System.Drawing.Size(209, 112)
        Me.DataGridView1.TabIndex = 38
        '
        'grp_asistencia
        '
        Me.grp_asistencia.Controls.Add(Me.lbl_matricula)
        Me.grp_asistencia.Controls.Add(Me.lbl_marca)
        Me.grp_asistencia.Controls.Add(Me.lbl_vehiculo)
        Me.grp_asistencia.Controls.Add(Me.btn_resetear)
        Me.grp_asistencia.Controls.Add(Me.btn_guardar)
        Me.grp_asistencia.Controls.Add(Me.Label2)
        Me.grp_asistencia.Controls.Add(Me.cbox_clasedia)
        Me.grp_asistencia.Controls.Add(Me.sbox_hor2)
        Me.grp_asistencia.Controls.Add(Me.sbox_hor1)
        Me.grp_asistencia.Controls.Add(Me.Label8)
        Me.grp_asistencia.Controls.Add(Me.Label9)
        Me.grp_asistencia.Controls.Add(Me.Label10)
        Me.grp_asistencia.Controls.Add(Me.lbl_Fecha)
        Me.grp_asistencia.Controls.Add(Me.date_Fecha)
        Me.grp_asistencia.Controls.Add(Me.cbox_docente)
        Me.grp_asistencia.Controls.Add(Me.lbl_docente)
        Me.grp_asistencia.Controls.Add(Me.DataGridView1)
        Me.grp_asistencia.Location = New System.Drawing.Point(56, 33)
        Me.grp_asistencia.Name = "grp_asistencia"
        Me.grp_asistencia.Size = New System.Drawing.Size(669, 312)
        Me.grp_asistencia.TabIndex = 39
        Me.grp_asistencia.TabStop = False
        Me.grp_asistencia.Text = "Asistencia"
        '
        'lbl_matricula
        '
        Me.lbl_matricula.AutoSize = True
        Me.lbl_matricula.Location = New System.Drawing.Point(418, 126)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Size = New System.Drawing.Size(39, 13)
        Me.lbl_matricula.TabIndex = 129
        Me.lbl_matricula.Text = "Label2"
        '
        'lbl_marca
        '
        Me.lbl_marca.AutoSize = True
        Me.lbl_marca.Location = New System.Drawing.Point(557, 126)
        Me.lbl_marca.Name = "lbl_marca"
        Me.lbl_marca.Size = New System.Drawing.Size(39, 13)
        Me.lbl_marca.TabIndex = 128
        Me.lbl_marca.Text = "Label8"
        '
        'lbl_vehiculo
        '
        Me.lbl_vehiculo.AutoSize = True
        Me.lbl_vehiculo.Location = New System.Drawing.Point(344, 126)
        Me.lbl_vehiculo.Name = "lbl_vehiculo"
        Me.lbl_vehiculo.Size = New System.Drawing.Size(51, 13)
        Me.lbl_vehiculo.TabIndex = 127
        Me.lbl_vehiculo.Text = "Vehiculo:"
        '
        'btn_resetear
        '
        Me.btn_resetear.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON
        Me.btn_resetear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_resetear.Location = New System.Drawing.Point(41, 267)
        Me.btn_resetear.Name = "btn_resetear"
        Me.btn_resetear.Size = New System.Drawing.Size(118, 39)
        Me.btn_resetear.TabIndex = 126
        Me.btn_resetear.Text = "Resetear"
        Me.btn_resetear.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.SAVE
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.Location = New System.Drawing.Point(517, 257)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(114, 39)
        Me.btn_guardar.TabIndex = 125
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Curso:"
        '
        'cbox_clasedia
        '
        Me.cbox_clasedia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_clasedia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_clasedia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_clasedia.FormattingEnabled = True
        Me.cbox_clasedia.Location = New System.Drawing.Point(115, 77)
        Me.cbox_clasedia.Name = "cbox_clasedia"
        Me.cbox_clasedia.Size = New System.Drawing.Size(208, 20)
        Me.cbox_clasedia.TabIndex = 123
        '
        'sbox_hor2
        '
        Me.sbox_hor2.Location = New System.Drawing.Point(542, 78)
        Me.sbox_hor2.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.sbox_hor2.Name = "sbox_hor2"
        Me.sbox_hor2.Size = New System.Drawing.Size(45, 20)
        Me.sbox_hor2.TabIndex = 122
        '
        'sbox_hor1
        '
        Me.sbox_hor1.Location = New System.Drawing.Point(422, 78)
        Me.sbox_hor1.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.sbox_hor1.Name = "sbox_hor1"
        Me.sbox_hor1.Size = New System.Drawing.Size(44, 20)
        Me.sbox_hor1.TabIndex = 121
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(608, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "hrs."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(499, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 24)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(345, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "Horario:"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(344, 39)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Fecha.TabIndex = 117
        Me.lbl_Fecha.Text = "Fecha:"
        '
        'date_Fecha
        '
        Me.date_Fecha.Location = New System.Drawing.Point(421, 36)
        Me.date_Fecha.Name = "date_Fecha"
        Me.date_Fecha.Size = New System.Drawing.Size(210, 20)
        Me.date_Fecha.TabIndex = 116
        '
        'cbox_docente
        '
        Me.cbox_docente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_docente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_docente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_docente.FormattingEnabled = True
        Me.cbox_docente.Location = New System.Drawing.Point(115, 36)
        Me.cbox_docente.Name = "cbox_docente"
        Me.cbox_docente.Size = New System.Drawing.Size(210, 20)
        Me.cbox_docente.TabIndex = 115
        '
        'lbl_docente
        '
        Me.lbl_docente.AutoSize = True
        Me.lbl_docente.Location = New System.Drawing.Point(38, 39)
        Me.lbl_docente.Name = "lbl_docente"
        Me.lbl_docente.Size = New System.Drawing.Size(51, 13)
        Me.lbl_docente.TabIndex = 114
        Me.lbl_docente.Text = "Docente:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_estado})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 380)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(751, 25)
        Me.ToolStrip1.TabIndex = 40
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lbl_estado
        '
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(89, 22)
        Me.lbl_estado.Text = "ToolStripLabel1"
        '
        'Asistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 405)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grp_asistencia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Asistencia"
        Me.Text = "Asistencia"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_asistencia.ResumeLayout(False)
        Me.grp_asistencia.PerformLayout()
        CType(Me.sbox_hor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbox_hor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents grp_asistencia As System.Windows.Forms.GroupBox
    Friend WithEvents cbox_docente As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_docente As System.Windows.Forms.Label
    Friend WithEvents sbox_hor2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents sbox_hor1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents date_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbox_clasedia As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lbl_estado As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btn_resetear As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_matricula As System.Windows.Forms.Label
    Friend WithEvents lbl_marca As System.Windows.Forms.Label
    Friend WithEvents lbl_vehiculo As System.Windows.Forms.Label
End Class
