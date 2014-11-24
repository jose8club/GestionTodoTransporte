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
        Me.tbox_estado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbox_examinador = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.date_examen = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbox_doc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbox_codigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chbox_cert = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btn_visual
        '
        Me.btn_visual.Location = New System.Drawing.Point(406, 306)
        Me.btn_visual.Name = "btn_visual"
        Me.btn_visual.Size = New System.Drawing.Size(111, 23)
        Me.btn_visual.TabIndex = 21
        Me.btn_visual.Text = "Guardar"
        Me.btn_visual.UseVisualStyleBackColor = True
        '
        'tbox_estado
        '
        Me.tbox_estado.Location = New System.Drawing.Point(185, 217)
        Me.tbox_estado.Name = "tbox_estado"
        Me.tbox_estado.Size = New System.Drawing.Size(332, 20)
        Me.tbox_estado.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Estado:"
        '
        'cbox_examinador
        '
        Me.cbox_examinador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_examinador.FormattingEnabled = True
        Me.cbox_examinador.Location = New System.Drawing.Point(185, 171)
        Me.cbox_examinador.Name = "cbox_examinador"
        Me.cbox_examinador.Size = New System.Drawing.Size(332, 21)
        Me.cbox_examinador.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Examinador:"
        '
        'date_examen
        '
        Me.date_examen.Location = New System.Drawing.Point(185, 125)
        Me.date_examen.Name = "date_examen"
        Me.date_examen.Size = New System.Drawing.Size(332, 20)
        Me.date_examen.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Fecha:"
        '
        'cbox_doc
        '
        Me.cbox_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_doc.FormattingEnabled = True
        Me.cbox_doc.Location = New System.Drawing.Point(185, 86)
        Me.cbox_doc.Name = "cbox_doc"
        Me.cbox_doc.Size = New System.Drawing.Size(332, 21)
        Me.cbox_doc.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Documento:"
        '
        'tbox_codigo
        '
        Me.tbox_codigo.Location = New System.Drawing.Point(185, 47)
        Me.tbox_codigo.Name = "tbox_codigo"
        Me.tbox_codigo.Size = New System.Drawing.Size(332, 20)
        Me.tbox_codigo.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Codigo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Certificado:"
        '
        'chbox_cert
        '
        Me.chbox_cert.AutoSize = True
        Me.chbox_cert.Location = New System.Drawing.Point(185, 267)
        Me.chbox_cert.Name = "chbox_cert"
        Me.chbox_cert.Size = New System.Drawing.Size(75, 17)
        Me.chbox_cert.TabIndex = 23
        Me.chbox_cert.Text = "Entregado"
        Me.chbox_cert.UseVisualStyleBackColor = True
        '
        'Visual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 494)
        Me.Controls.Add(Me.chbox_cert)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_visual)
        Me.Controls.Add(Me.tbox_estado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbox_examinador)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.date_examen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbox_doc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbox_codigo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Visual"
        Me.Text = "Visual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_visual As System.Windows.Forms.Button
    Friend WithEvents tbox_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbox_examinador As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents date_examen As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbox_doc As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbox_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chbox_cert As System.Windows.Forms.CheckBox
End Class
