<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visual
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
        Me.btn_visual = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbox_funcionario = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.date_examen = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chbox_cert = New System.Windows.Forms.CheckBox()
        Me.cbox_estudiante = New System.Windows.Forms.ComboBox()
        Me.tbox_estado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_visual
        '
        Me.btn_visual.Location = New System.Drawing.Point(406, 270)
        Me.btn_visual.Name = "btn_visual"
        Me.btn_visual.Size = New System.Drawing.Size(111, 23)
        Me.btn_visual.TabIndex = 30
        Me.btn_visual.Text = "Guardar"
        Me.btn_visual.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Estado:"
        '
        'cbox_funcionario
        '
        Me.cbox_funcionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_funcionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_funcionario.FormattingEnabled = True
        Me.cbox_funcionario.Location = New System.Drawing.Point(185, 135)
        Me.cbox_funcionario.Name = "cbox_funcionario"
        Me.cbox_funcionario.Size = New System.Drawing.Size(332, 21)
        Me.cbox_funcionario.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Funcionario:"
        '
        'date_examen
        '
        Me.date_examen.Location = New System.Drawing.Point(185, 89)
        Me.date_examen.Name = "date_examen"
        Me.date_examen.Size = New System.Drawing.Size(332, 20)
        Me.date_examen.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Estudiante:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Certificado:"
        '
        'chbox_cert
        '
        Me.chbox_cert.AutoSize = True
        Me.chbox_cert.Location = New System.Drawing.Point(185, 231)
        Me.chbox_cert.Name = "chbox_cert"
        Me.chbox_cert.Size = New System.Drawing.Size(75, 17)
        Me.chbox_cert.TabIndex = 29
        Me.chbox_cert.Text = "Entregado"
        Me.chbox_cert.UseVisualStyleBackColor = True
        '
        'cbox_estudiante
        '
        Me.cbox_estudiante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_estudiante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_estudiante.FormattingEnabled = True
        Me.cbox_estudiante.Location = New System.Drawing.Point(185, 47)
        Me.cbox_estudiante.Name = "cbox_estudiante"
        Me.cbox_estudiante.Size = New System.Drawing.Size(332, 21)
        Me.cbox_estudiante.TabIndex = 25
        '
        'tbox_estado
        '
        Me.tbox_estado.Location = New System.Drawing.Point(185, 181)
        Me.tbox_estado.Name = "tbox_estado"
        Me.tbox_estado.Size = New System.Drawing.Size(332, 20)
        Me.tbox_estado.TabIndex = 28
        '
        'Visual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 494)
        Me.Controls.Add(Me.tbox_estado)
        Me.Controls.Add(Me.cbox_estudiante)
        Me.Controls.Add(Me.chbox_cert)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_visual)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbox_funcionario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.date_examen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Visual"
        Me.Text = "Visual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_visual As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbox_funcionario As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents date_examen As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chbox_cert As System.Windows.Forms.CheckBox
    Friend WithEvents cbox_estudiante As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_estado As System.Windows.Forms.TextBox
End Class
