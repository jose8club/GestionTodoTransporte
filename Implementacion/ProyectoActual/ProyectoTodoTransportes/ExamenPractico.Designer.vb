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
        Me.cbox_instructor = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.date_fechaPract = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbox_codigoPract = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_exPract
        '
        Me.btn_exPract.Location = New System.Drawing.Point(352, 197)
        Me.btn_exPract.Name = "btn_exPract"
        Me.btn_exPract.Size = New System.Drawing.Size(111, 23)
        Me.btn_exPract.TabIndex = 43
        Me.btn_exPract.Text = "Guardar"
        Me.btn_exPract.UseVisualStyleBackColor = True
        '
        'tbox_calPract
        '
        Me.tbox_calPract.Location = New System.Drawing.Point(131, 144)
        Me.tbox_calPract.Name = "tbox_calPract"
        Me.tbox_calPract.Size = New System.Drawing.Size(56, 20)
        Me.tbox_calPract.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Calificación:"
        '
        'cbox_instructor
        '
        Me.cbox_instructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_instructor.FormattingEnabled = True
        Me.cbox_instructor.Location = New System.Drawing.Point(131, 104)
        Me.cbox_instructor.Name = "cbox_instructor"
        Me.cbox_instructor.Size = New System.Drawing.Size(332, 21)
        Me.cbox_instructor.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Instructor:"
        '
        'date_fechaPract
        '
        Me.date_fechaPract.Location = New System.Drawing.Point(131, 69)
        Me.date_fechaPract.Name = "date_fechaPract"
        Me.date_fechaPract.Size = New System.Drawing.Size(332, 20)
        Me.date_fechaPract.TabIndex = 38
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
        'tbox_codigoPract
        '
        Me.tbox_codigoPract.Location = New System.Drawing.Point(131, 33)
        Me.tbox_codigoPract.Name = "tbox_codigoPract"
        Me.tbox_codigoPract.Size = New System.Drawing.Size(332, 20)
        Me.tbox_codigoPract.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Codigo:"
        '
        'ExamenPractico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 279)
        Me.Controls.Add(Me.btn_exPract)
        Me.Controls.Add(Me.tbox_calPract)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbox_instructor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.date_fechaPract)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbox_codigoPract)
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
    Friend WithEvents cbox_instructor As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents date_fechaPract As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbox_codigoPract As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
