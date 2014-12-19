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
        Me.cbox_estudiante = New System.Windows.Forms.ComboBox()
        Me.tbox_estado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbox_calTeo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbox_funcionario = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.date_fechaTeo = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_exTeo
        '
        Me.btn_exTeo.Location = New System.Drawing.Point(356, 245)
        Me.btn_exTeo.Name = "btn_exTeo"
        Me.btn_exTeo.Size = New System.Drawing.Size(111, 23)
        Me.btn_exTeo.TabIndex = 32
        Me.btn_exTeo.Text = "Guardar"
        Me.btn_exTeo.UseVisualStyleBackColor = True
        '
        'cbox_estudiante
        '
        Me.cbox_estudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_estudiante.FormattingEnabled = True
        Me.cbox_estudiante.Location = New System.Drawing.Point(135, 37)
        Me.cbox_estudiante.Name = "cbox_estudiante"
        Me.cbox_estudiante.Size = New System.Drawing.Size(332, 21)
        Me.cbox_estudiante.TabIndex = 56
        '
        'tbox_estado
        '
        Me.tbox_estado.Location = New System.Drawing.Point(135, 182)
        Me.tbox_estado.Name = "tbox_estado"
        Me.tbox_estado.Size = New System.Drawing.Size(332, 20)
        Me.tbox_estado.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Estado:"
        '
        'tbox_calTeo
        '
        Me.tbox_calTeo.Location = New System.Drawing.Point(135, 147)
        Me.tbox_calTeo.Name = "tbox_calTeo"
        Me.tbox_calTeo.Size = New System.Drawing.Size(56, 20)
        Me.tbox_calTeo.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Calificación:"
        '
        'cbox_funcionario
        '
        Me.cbox_funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_funcionario.FormattingEnabled = True
        Me.cbox_funcionario.Location = New System.Drawing.Point(135, 108)
        Me.cbox_funcionario.Name = "cbox_funcionario"
        Me.cbox_funcionario.Size = New System.Drawing.Size(332, 21)
        Me.cbox_funcionario.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Funcionario:"
        '
        'date_fechaTeo
        '
        Me.date_fechaTeo.Location = New System.Drawing.Point(135, 73)
        Me.date_fechaTeo.Name = "date_fechaTeo"
        Me.date_fechaTeo.Size = New System.Drawing.Size(332, 20)
        Me.date_fechaTeo.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Fecha:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Estudiante:"
        '
        'ExamenTeorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 326)
        Me.Controls.Add(Me.cbox_estudiante)
        Me.Controls.Add(Me.tbox_estado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbox_calTeo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbox_funcionario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.date_fechaTeo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_exTeo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExamenTeorico"
        Me.Text = "ExamenTeorico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_exTeo As System.Windows.Forms.Button
    Friend WithEvents cbox_estudiante As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbox_calTeo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbox_funcionario As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents date_fechaTeo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
