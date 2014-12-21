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
        Me.tbox_calPract = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbox_funcionario = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.date_fechaPract = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbox_estado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbox_estudiante = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btn_exPract
        '
        Me.btn_exPract.Location = New System.Drawing.Point(352, 226)
        Me.btn_exPract.Name = "btn_exPract"
        Me.btn_exPract.Size = New System.Drawing.Size(111, 23)
        Me.btn_exPract.TabIndex = 51
        Me.btn_exPract.Text = "Guardar"
        Me.btn_exPract.UseVisualStyleBackColor = True
        '
        'tbox_calPract
        '
        Me.tbox_calPract.Location = New System.Drawing.Point(131, 143)
        Me.tbox_calPract.Name = "tbox_calPract"
        Me.tbox_calPract.Size = New System.Drawing.Size(56, 20)
        Me.tbox_calPract.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Calificación:"
        '
        'cbox_funcionario
        '
        Me.cbox_funcionario.FormattingEnabled = True
        Me.cbox_funcionario.Location = New System.Drawing.Point(131, 104)
        Me.cbox_funcionario.Name = "cbox_funcionario"
        Me.cbox_funcionario.Size = New System.Drawing.Size(332, 21)
        Me.cbox_funcionario.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Funcionario:"
        '
        'date_fechaPract
        '
        Me.date_fechaPract.Location = New System.Drawing.Point(131, 69)
        Me.date_fechaPract.Name = "date_fechaPract"
        Me.date_fechaPract.Size = New System.Drawing.Size(332, 20)
        Me.date_fechaPract.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Fecha:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Estudiante:"
        '
        'tbox_estado
        '
        Me.tbox_estado.Location = New System.Drawing.Point(131, 178)
        Me.tbox_estado.Name = "tbox_estado"
        Me.tbox_estado.Size = New System.Drawing.Size(332, 20)
        Me.tbox_estado.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Estado:"
        '
        'cbox_estudiante
        '
        Me.cbox_estudiante.FormattingEnabled = True
        Me.cbox_estudiante.Location = New System.Drawing.Point(131, 33)
        Me.cbox_estudiante.Name = "cbox_estudiante"
        Me.cbox_estudiante.Size = New System.Drawing.Size(332, 21)
        Me.cbox_estudiante.TabIndex = 46
        '
        'ExamenPractico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 279)
        Me.Controls.Add(Me.cbox_estudiante)
        Me.Controls.Add(Me.tbox_estado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_exPract)
        Me.Controls.Add(Me.tbox_calPract)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbox_funcionario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.date_fechaPract)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExamenPractico"
        Me.Text = "ExamenPractico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_exPract As System.Windows.Forms.Button
    Friend WithEvents tbox_calPract As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbox_funcionario As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents date_fechaPract As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbox_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbox_estudiante As System.Windows.Forms.ComboBox
End Class
