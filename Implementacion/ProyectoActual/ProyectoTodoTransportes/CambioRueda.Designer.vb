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
        Me.tbox_hor1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbox_hor2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbox_funcionario = New System.Windows.Forms.ComboBox()
        Me.btn_rueda = New System.Windows.Forms.Button()
        Me.cbox_estudiante = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbox_estado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Horario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Funcionario:"
        '
        'date_rueda
        '
        Me.date_rueda.Location = New System.Drawing.Point(150, 143)
        Me.date_rueda.Name = "date_rueda"
        Me.date_rueda.Size = New System.Drawing.Size(347, 20)
        Me.date_rueda.TabIndex = 17
        '
        'tbox_hor1
        '
        Me.tbox_hor1.Location = New System.Drawing.Point(153, 192)
        Me.tbox_hor1.Name = "tbox_hor1"
        Me.tbox_hor1.Size = New System.Drawing.Size(129, 20)
        Me.tbox_hor1.TabIndex = 18
        Me.tbox_hor1.Text = "00"
        Me.tbox_hor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(288, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = ":"
        '
        'tbox_hor2
        '
        Me.tbox_hor2.Location = New System.Drawing.Point(309, 193)
        Me.tbox_hor2.Name = "tbox_hor2"
        Me.tbox_hor2.Size = New System.Drawing.Size(129, 20)
        Me.tbox_hor2.TabIndex = 19
        Me.tbox_hor2.Text = "00"
        Me.tbox_hor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(470, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "hrs."
        '
        'cbox_funcionario
        '
        Me.cbox_funcionario.FormattingEnabled = True
        Me.cbox_funcionario.Location = New System.Drawing.Point(152, 93)
        Me.cbox_funcionario.Name = "cbox_funcionario"
        Me.cbox_funcionario.Size = New System.Drawing.Size(343, 21)
        Me.cbox_funcionario.TabIndex = 16
        '
        'btn_rueda
        '
        Me.btn_rueda.Location = New System.Drawing.Point(377, 298)
        Me.btn_rueda.Name = "btn_rueda"
        Me.btn_rueda.Size = New System.Drawing.Size(118, 23)
        Me.btn_rueda.TabIndex = 21
        Me.btn_rueda.Text = "Guardar"
        Me.btn_rueda.UseVisualStyleBackColor = True
        '
        'cbox_estudiante
        '
        Me.cbox_estudiante.FormattingEnabled = True
        Me.cbox_estudiante.Location = New System.Drawing.Point(154, 46)
        Me.cbox_estudiante.Name = "cbox_estudiante"
        Me.cbox_estudiante.Size = New System.Drawing.Size(343, 21)
        Me.cbox_estudiante.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Estudiante:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Estado:"
        '
        'tbox_estado
        '
        Me.tbox_estado.Location = New System.Drawing.Point(152, 241)
        Me.tbox_estado.Name = "tbox_estado"
        Me.tbox_estado.Size = New System.Drawing.Size(345, 20)
        Me.tbox_estado.TabIndex = 20
        '
        'CambioRueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 399)
        Me.Controls.Add(Me.tbox_estado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbox_estudiante)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_rueda)
        Me.Controls.Add(Me.cbox_funcionario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbox_hor2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbox_hor1)
        Me.Controls.Add(Me.date_rueda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CambioRueda"
        Me.Text = "CambioRueda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents date_rueda As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbox_hor1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbox_hor2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbox_funcionario As System.Windows.Forms.ComboBox
    Friend WithEvents btn_rueda As System.Windows.Forms.Button
    Friend WithEvents cbox_estudiante As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbox_estado As System.Windows.Forms.TextBox
End Class
