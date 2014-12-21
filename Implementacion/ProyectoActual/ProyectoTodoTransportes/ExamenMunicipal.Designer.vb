<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamenMunicipal
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
        Me.btn_Municipal = New System.Windows.Forms.Button()
        Me.rtbox_comentario = New System.Windows.Forms.RichTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbox_funcionario = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbox_estudiante = New System.Windows.Forms.ComboBox()
        Me.tbox_estado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date_examen = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btn_Municipal
        '
        Me.btn_Municipal.Location = New System.Drawing.Point(322, 287)
        Me.btn_Municipal.Name = "btn_Municipal"
        Me.btn_Municipal.Size = New System.Drawing.Size(126, 23)
        Me.btn_Municipal.TabIndex = 53
        Me.btn_Municipal.Text = "Guardar"
        Me.btn_Municipal.UseVisualStyleBackColor = True
        '
        'rtbox_comentario
        '
        Me.rtbox_comentario.Location = New System.Drawing.Point(116, 174)
        Me.rtbox_comentario.Name = "rtbox_comentario"
        Me.rtbox_comentario.Size = New System.Drawing.Size(332, 96)
        Me.rtbox_comentario.TabIndex = 52
        Me.rtbox_comentario.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 174)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Comentario:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Estado:"
        '
        'cbox_funcionario
        '
        Me.cbox_funcionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_funcionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_funcionario.FormattingEnabled = True
        Me.cbox_funcionario.Location = New System.Drawing.Point(116, 61)
        Me.cbox_funcionario.Name = "cbox_funcionario"
        Me.cbox_funcionario.Size = New System.Drawing.Size(332, 21)
        Me.cbox_funcionario.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Funcionario:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Estudiante:"
        '
        'cbox_estudiante
        '
        Me.cbox_estudiante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_estudiante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_estudiante.FormattingEnabled = True
        Me.cbox_estudiante.Location = New System.Drawing.Point(116, 21)
        Me.cbox_estudiante.Name = "cbox_estudiante"
        Me.cbox_estudiante.Size = New System.Drawing.Size(332, 21)
        Me.cbox_estudiante.TabIndex = 48
        '
        'tbox_estado
        '
        Me.tbox_estado.Location = New System.Drawing.Point(116, 135)
        Me.tbox_estado.Name = "tbox_estado"
        Me.tbox_estado.Size = New System.Drawing.Size(332, 20)
        Me.tbox_estado.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Fecha:"
        '
        'date_examen
        '
        Me.date_examen.Location = New System.Drawing.Point(116, 97)
        Me.date_examen.Name = "date_examen"
        Me.date_examen.Size = New System.Drawing.Size(332, 20)
        Me.date_examen.TabIndex = 50
        '
        'ExamenMunicipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 384)
        Me.Controls.Add(Me.date_examen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbox_estado)
        Me.Controls.Add(Me.cbox_estudiante)
        Me.Controls.Add(Me.btn_Municipal)
        Me.Controls.Add(Me.rtbox_comentario)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbox_funcionario)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExamenMunicipal"
        Me.Text = "ExamenMunicipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Municipal As System.Windows.Forms.Button
    Friend WithEvents rtbox_comentario As System.Windows.Forms.RichTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbox_funcionario As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbox_estudiante As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents date_examen As System.Windows.Forms.DateTimePicker
End Class
