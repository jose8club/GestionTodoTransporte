<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClasePractica
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_guardarPract = New System.Windows.Forms.Button()
        Me.cbox_instructor = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbox_cursoPract = New System.Windows.Forms.ComboBox()
        Me.tbox_idPractica = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_Horario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_guardarPract
        '
        Me.btn_guardarPract.Enabled = False
        Me.btn_guardarPract.Location = New System.Drawing.Point(298, 190)
        Me.btn_guardarPract.Name = "btn_guardarPract"
        Me.btn_guardarPract.Size = New System.Drawing.Size(101, 23)
        Me.btn_guardarPract.TabIndex = 24
        Me.btn_guardarPract.Text = "Guardar"
        Me.btn_guardarPract.UseVisualStyleBackColor = True
        '
        'cbox_instructor
        '
        Me.cbox_instructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_instructor.FormattingEnabled = True
        Me.cbox_instructor.Location = New System.Drawing.Point(143, 84)
        Me.cbox_instructor.Name = "cbox_instructor"
        Me.cbox_instructor.Size = New System.Drawing.Size(256, 21)
        Me.cbox_instructor.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Instructor:"
        '
        'cbox_cursoPract
        '
        Me.cbox_cursoPract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_cursoPract.FormattingEnabled = True
        Me.cbox_cursoPract.Location = New System.Drawing.Point(143, 47)
        Me.cbox_cursoPract.Name = "cbox_cursoPract"
        Me.cbox_cursoPract.Size = New System.Drawing.Size(256, 21)
        Me.cbox_cursoPract.TabIndex = 19
        '
        'tbox_idPractica
        '
        Me.tbox_idPractica.Location = New System.Drawing.Point(143, 12)
        Me.tbox_idPractica.Name = "tbox_idPractica"
        Me.tbox_idPractica.Size = New System.Drawing.Size(256, 20)
        Me.tbox_idPractica.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Curso:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Identificador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(375, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Hrs."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(245, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = ":"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(261, 121)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(94, 20)
        Me.TextBox2.TabIndex = 28
        Me.TextBox2.Text = "00"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(145, 121)
        Me.TextBox1.MaxLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(94, 20)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.Text = "00"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Horario
        '
        Me.lbl_Horario.AutoSize = True
        Me.lbl_Horario.Location = New System.Drawing.Point(12, 124)
        Me.lbl_Horario.Name = "lbl_Horario"
        Me.lbl_Horario.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Horario.TabIndex = 26
        Me.lbl_Horario.Text = "Horario:"
        '
        'ClasePractica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 254)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_Horario)
        Me.Controls.Add(Me.btn_guardarPract)
        Me.Controls.Add(Me.cbox_instructor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbox_cursoPract)
        Me.Controls.Add(Me.tbox_idPractica)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClasePractica"
        Me.Text = "ClasePractica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_guardarPract As System.Windows.Forms.Button
    Friend WithEvents cbox_instructor As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbox_cursoPract As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_idPractica As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Horario As System.Windows.Forms.Label
End Class
