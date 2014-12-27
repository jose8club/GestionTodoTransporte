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
        Me.sbox_hor1 = New System.Windows.Forms.NumericUpDown()
        Me.sbox_hor2 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_estudiante = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
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
        Me.date_rueda.TabIndex = 18
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
        Me.cbox_funcionario.TabIndex = 17
        '
        'btn_rueda
        '
        Me.btn_rueda.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.SAVE
        Me.btn_rueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_rueda.Location = New System.Drawing.Point(378, 249)
        Me.btn_rueda.Name = "btn_rueda"
        Me.btn_rueda.Size = New System.Drawing.Size(139, 35)
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
        'sbox_hor1
        '
        Me.sbox_hor1.Location = New System.Drawing.Point(172, 197)
        Me.sbox_hor1.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.sbox_hor1.Name = "sbox_hor1"
        Me.sbox_hor1.Size = New System.Drawing.Size(44, 20)
        Me.sbox_hor1.TabIndex = 19
        '
        'sbox_hor2
        '
        Me.sbox_hor2.Location = New System.Drawing.Point(247, 197)
        Me.sbox_hor2.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.sbox_hor2.Name = "sbox_hor2"
        Me.sbox_hor2.Size = New System.Drawing.Size(45, 20)
        Me.sbox_hor2.TabIndex = 20
        '
        'lbl_estudiante
        '
        Me.lbl_estudiante.AutoSize = True
        Me.lbl_estudiante.Location = New System.Drawing.Point(293, 54)
        Me.lbl_estudiante.Name = "lbl_estudiante"
        Me.lbl_estudiante.Size = New System.Drawing.Size(39, 13)
        Me.lbl_estudiante.TabIndex = 16
        Me.lbl_estudiante.Text = "Label8"
        '
        'btn_reset
        '
        Me.btn_reset.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON
        Me.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reset.Location = New System.Drawing.Point(51, 249)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(135, 35)
        Me.btn_reset.TabIndex = 22
        Me.btn_reset.Text = "Resetear"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'CambioRueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 399)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.lbl_estudiante)
        Me.Controls.Add(Me.sbox_hor2)
        Me.Controls.Add(Me.sbox_hor1)
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
    Friend WithEvents sbox_hor1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents sbox_hor2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_estudiante As System.Windows.Forms.Label
    Friend WithEvents btn_reset As System.Windows.Forms.Button
End Class
