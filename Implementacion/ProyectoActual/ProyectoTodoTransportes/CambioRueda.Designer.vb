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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbox_codigoRueda = New System.Windows.Forms.TextBox()
        Me.date_rueda = New System.Windows.Forms.DateTimePicker()
        Me.tbox_hor1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbox_hor2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbox_instRueda = New System.Windows.Forms.ComboBox()
        Me.btn_rueda = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Horario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Instructor"
        '
        'tbox_codigoRueda
        '
        Me.tbox_codigoRueda.Location = New System.Drawing.Point(150, 30)
        Me.tbox_codigoRueda.Name = "tbox_codigoRueda"
        Me.tbox_codigoRueda.Size = New System.Drawing.Size(343, 20)
        Me.tbox_codigoRueda.TabIndex = 5
        '
        'date_rueda
        '
        Me.date_rueda.Location = New System.Drawing.Point(150, 68)
        Me.date_rueda.Name = "date_rueda"
        Me.date_rueda.Size = New System.Drawing.Size(343, 20)
        Me.date_rueda.TabIndex = 7
        '
        'tbox_hor1
        '
        Me.tbox_hor1.Location = New System.Drawing.Point(150, 106)
        Me.tbox_hor1.Name = "tbox_hor1"
        Me.tbox_hor1.Size = New System.Drawing.Size(129, 20)
        Me.tbox_hor1.TabIndex = 8
        Me.tbox_hor1.Text = "00"
        Me.tbox_hor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(285, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = ":"
        '
        'tbox_hor2
        '
        Me.tbox_hor2.Location = New System.Drawing.Point(306, 107)
        Me.tbox_hor2.Name = "tbox_hor2"
        Me.tbox_hor2.Size = New System.Drawing.Size(129, 20)
        Me.tbox_hor2.TabIndex = 10
        Me.tbox_hor2.Text = "00"
        Me.tbox_hor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(470, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "hrs."
        '
        'cbox_instRueda
        '
        Me.cbox_instRueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_instRueda.FormattingEnabled = True
        Me.cbox_instRueda.Location = New System.Drawing.Point(150, 140)
        Me.cbox_instRueda.Name = "cbox_instRueda"
        Me.cbox_instRueda.Size = New System.Drawing.Size(343, 21)
        Me.cbox_instRueda.TabIndex = 12
        '
        'btn_rueda
        '
        Me.btn_rueda.Location = New System.Drawing.Point(375, 194)
        Me.btn_rueda.Name = "btn_rueda"
        Me.btn_rueda.Size = New System.Drawing.Size(118, 23)
        Me.btn_rueda.TabIndex = 13
        Me.btn_rueda.Text = "Guardar"
        Me.btn_rueda.UseVisualStyleBackColor = True
        '
        'CambioRueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 399)
        Me.Controls.Add(Me.btn_rueda)
        Me.Controls.Add(Me.cbox_instRueda)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbox_hor2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbox_hor1)
        Me.Controls.Add(Me.date_rueda)
        Me.Controls.Add(Me.tbox_codigoRueda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CambioRueda"
        Me.Text = "CambioRueda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbox_codigoRueda As System.Windows.Forms.TextBox
    Friend WithEvents date_rueda As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbox_hor1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbox_hor2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbox_instRueda As System.Windows.Forms.ComboBox
    Friend WithEvents btn_rueda As System.Windows.Forms.Button
End Class
