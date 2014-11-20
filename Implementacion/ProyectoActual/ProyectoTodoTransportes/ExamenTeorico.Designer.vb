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
        Me.tbox_calificacionTeo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbox_examinador = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.date_examenTeo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbox_docTeo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbox_codigoTeo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_exTeo
        '
        Me.btn_exTeo.Location = New System.Drawing.Point(349, 222)
        Me.btn_exTeo.Name = "btn_exTeo"
        Me.btn_exTeo.Size = New System.Drawing.Size(111, 23)
        Me.btn_exTeo.TabIndex = 32
        Me.btn_exTeo.Text = "Guardar"
        Me.btn_exTeo.UseVisualStyleBackColor = True
        '
        'tbox_calificacionTeo
        '
        Me.tbox_calificacionTeo.Location = New System.Drawing.Point(128, 169)
        Me.tbox_calificacionTeo.Name = "tbox_calificacionTeo"
        Me.tbox_calificacionTeo.Size = New System.Drawing.Size(56, 20)
        Me.tbox_calificacionTeo.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Calificación:"
        '
        'cbox_examinador
        '
        Me.cbox_examinador.FormattingEnabled = True
        Me.cbox_examinador.Location = New System.Drawing.Point(128, 129)
        Me.cbox_examinador.Name = "cbox_examinador"
        Me.cbox_examinador.Size = New System.Drawing.Size(332, 21)
        Me.cbox_examinador.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Examinador:"
        '
        'date_examenTeo
        '
        Me.date_examenTeo.Location = New System.Drawing.Point(128, 94)
        Me.date_examenTeo.Name = "date_examenTeo"
        Me.date_examenTeo.Size = New System.Drawing.Size(332, 20)
        Me.date_examenTeo.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Fecha:"
        '
        'cbox_docTeo
        '
        Me.cbox_docTeo.FormattingEnabled = True
        Me.cbox_docTeo.Location = New System.Drawing.Point(128, 58)
        Me.cbox_docTeo.Name = "cbox_docTeo"
        Me.cbox_docTeo.Size = New System.Drawing.Size(332, 21)
        Me.cbox_docTeo.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Documento:"
        '
        'tbox_codigoTeo
        '
        Me.tbox_codigoTeo.Location = New System.Drawing.Point(128, 23)
        Me.tbox_codigoTeo.Name = "tbox_codigoTeo"
        Me.tbox_codigoTeo.Size = New System.Drawing.Size(332, 20)
        Me.tbox_codigoTeo.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Codigo:"
        '
        'ExamenTeorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 326)
        Me.Controls.Add(Me.btn_exTeo)
        Me.Controls.Add(Me.tbox_calificacionTeo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbox_examinador)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.date_examenTeo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbox_docTeo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbox_codigoTeo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExamenTeorico"
        Me.Text = "ExamenTeorico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_exTeo As System.Windows.Forms.Button
    Friend WithEvents tbox_calificacionTeo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbox_examinador As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents date_examenTeo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbox_docTeo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbox_codigoTeo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
