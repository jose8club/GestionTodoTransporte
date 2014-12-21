<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioRueda
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.date_rueda = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbox_funcionario = New System.Windows.Forms.ComboBox()
        Me.btn_rueda = New System.Windows.Forms.Button()
        Me.cbox_matricula = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sbox_hor1 = New System.Windows.Forms.NumericUpDown()
        Me.sbox_hor2 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_estudiante = New System.Windows.Forms.Label()
        Me.rbtn_aprobado = New System.Windows.Forms.RadioButton()
        Me.rbtn_reprobado = New System.Windows.Forms.RadioButton()
        CType(Me.sbox_hor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbox_hor2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Horario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Funcionario:"
        '
        'date_rueda
        '
        Me.date_rueda.Location = New System.Drawing.Point(170, 152)
        Me.date_rueda.Name = "date_rueda"
        Me.date_rueda.Size = New System.Drawing.Size(347, 20)
        Me.date_rueda.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(226, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(308, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "hrs."
        '
        'cbox_funcionario
        '
        Me.cbox_funcionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_funcionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_funcionario.FormattingEnabled = True
        Me.cbox_funcionario.Location = New System.Drawing.Point(170, 101)
        Me.cbox_funcionario.Name = "cbox_funcionario"
        Me.cbox_funcionario.Size = New System.Drawing.Size(343, 21)
        Me.cbox_funcionario.TabIndex = 16
        '
        'btn_rueda
        '
        Me.btn_rueda.Location = New System.Drawing.Point(399, 307)
        Me.btn_rueda.Name = "btn_rueda"
        Me.btn_rueda.Size = New System.Drawing.Size(118, 23)
        Me.btn_rueda.TabIndex = 21
        Me.btn_rueda.Text = "Guardar"
        Me.btn_rueda.UseVisualStyleBackColor = True
        '
        'cbox_matricula
        '
        Me.cbox_matricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_matricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_matricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_matricula.FormattingEnabled = True
        Me.cbox_matricula.Location = New System.Drawing.Point(172, 51)
        Me.cbox_matricula.Name = "cbox_matricula"
        Me.cbox_matricula.Size = New System.Drawing.Size(99, 21)
        Me.cbox_matricula.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Registro de Matricula:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Estado:"
        '
        'sbox_hor1
        '
        Me.sbox_hor1.Location = New System.Drawing.Point(172, 197)
        Me.sbox_hor1.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.sbox_hor1.Name = "sbox_hor1"
        Me.sbox_hor1.Size = New System.Drawing.Size(44, 20)
        Me.sbox_hor1.TabIndex = 22
        '
        'sbox_hor2
        '
        Me.sbox_hor2.Location = New System.Drawing.Point(247, 197)
        Me.sbox_hor2.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.sbox_hor2.Name = "sbox_hor2"
        Me.sbox_hor2.Size = New System.Drawing.Size(45, 20)
        Me.sbox_hor2.TabIndex = 23
        '
        'lbl_estudiante
        '
        Me.lbl_estudiante.AutoSize = True
        Me.lbl_estudiante.Location = New System.Drawing.Point(293, 54)
        Me.lbl_estudiante.Name = "lbl_estudiante"
        Me.lbl_estudiante.Size = New System.Drawing.Size(39, 13)
        Me.lbl_estudiante.TabIndex = 24
        Me.lbl_estudiante.Text = "Label8"
        '
        'rbtn_aprobado
        '
        Me.rbtn_aprobado.AutoSize = True
        Me.rbtn_aprobado.Location = New System.Drawing.Point(170, 245)
        Me.rbtn_aprobado.Name = "rbtn_aprobado"
        Me.rbtn_aprobado.Size = New System.Drawing.Size(71, 17)
        Me.rbtn_aprobado.TabIndex = 25
        Me.rbtn_aprobado.TabStop = True
        Me.rbtn_aprobado.Text = "Aprobado"
        Me.rbtn_aprobado.UseVisualStyleBackColor = True
        '
        'rbtn_reprobado
        '
        Me.rbtn_reprobado.AutoSize = True
        Me.rbtn_reprobado.Location = New System.Drawing.Point(296, 245)
        Me.rbtn_reprobado.Name = "rbtn_reprobado"
        Me.rbtn_reprobado.Size = New System.Drawing.Size(78, 17)
        Me.rbtn_reprobado.TabIndex = 26
        Me.rbtn_reprobado.TabStop = True
        Me.rbtn_reprobado.Text = "Reprobado"
        Me.rbtn_reprobado.UseVisualStyleBackColor = True
        '
        'CambioRueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 399)
        Me.Controls.Add(Me.rbtn_reprobado)
        Me.Controls.Add(Me.rbtn_aprobado)
        Me.Controls.Add(Me.lbl_estudiante)
        Me.Controls.Add(Me.sbox_hor2)
        Me.Controls.Add(Me.sbox_hor1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbox_matricula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_rueda)
        Me.Controls.Add(Me.cbox_funcionario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.date_rueda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CambioRueda"
        Me.Text = "CambioRueda"
        CType(Me.sbox_hor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbox_hor2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents date_rueda As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbox_funcionario As System.Windows.Forms.ComboBox
    Friend WithEvents btn_rueda As System.Windows.Forms.Button
    Friend WithEvents cbox_matricula As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sbox_hor1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents sbox_hor2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_estudiante As System.Windows.Forms.Label
    Friend WithEvents rbtn_aprobado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_reprobado As System.Windows.Forms.RadioButton
End Class
