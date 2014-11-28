<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Horarios
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbox_docente = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.date_inicio = New System.Windows.Forms.DateTimePicker()
        Me.cbox_cursos = New System.Windows.Forms.ComboBox()
        Me.date_final = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.list_clases = New System.Windows.Forms.ListBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Curso:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Docente:"
        '
        'cbox_docente
        '
        Me.cbox_docente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_docente.FormattingEnabled = True
        Me.cbox_docente.Location = New System.Drawing.Point(172, 49)
        Me.cbox_docente.Name = "cbox_docente"
        Me.cbox_docente.Size = New System.Drawing.Size(338, 21)
        Me.cbox_docente.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha de Inicio:"
        '
        'date_inicio
        '
        Me.date_inicio.Location = New System.Drawing.Point(172, 89)
        Me.date_inicio.Name = "date_inicio"
        Me.date_inicio.Size = New System.Drawing.Size(338, 20)
        Me.date_inicio.TabIndex = 5
        '
        'cbox_cursos
        '
        Me.cbox_cursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_cursos.FormattingEnabled = True
        Me.cbox_cursos.Location = New System.Drawing.Point(172, 12)
        Me.cbox_cursos.Name = "cbox_cursos"
        Me.cbox_cursos.Size = New System.Drawing.Size(338, 21)
        Me.cbox_cursos.TabIndex = 6
        '
        'date_final
        '
        Me.date_final.Location = New System.Drawing.Point(172, 125)
        Me.date_final.Name = "date_final"
        Me.date_final.Size = New System.Drawing.Size(338, 20)
        Me.date_final.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de Termino:"
        '
        'list_clases
        '
        Me.list_clases.FormattingEnabled = True
        Me.list_clases.Location = New System.Drawing.Point(44, 164)
        Me.list_clases.Name = "list_clases"
        Me.list_clases.Size = New System.Drawing.Size(466, 121)
        Me.list_clases.TabIndex = 9
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(435, 291)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 10
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Horarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 333)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.list_clases)
        Me.Controls.Add(Me.date_final)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbox_cursos)
        Me.Controls.Add(Me.date_inicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbox_docente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Horarios"
        Me.Text = "Creación de Horarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbox_docente As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents date_inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbox_cursos As System.Windows.Forms.ComboBox
    Friend WithEvents date_final As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents list_clases As System.Windows.Forms.ListBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
End Class
