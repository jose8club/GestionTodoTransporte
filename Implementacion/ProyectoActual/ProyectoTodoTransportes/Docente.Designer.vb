<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Docente
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
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.tbox_Nombre = New System.Windows.Forms.TextBox()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.tbox_Telefono = New System.Windows.Forms.TextBox()
        Me.rad_Profesor = New System.Windows.Forms.RadioButton()
        Me.rad_Instructor = New System.Windows.Forms.RadioButton()
        Me.lbl_Tipo = New System.Windows.Forms.Label()
        Me.cbox_Vehiculo = New System.Windows.Forms.ComboBox()
        Me.lbl_Vehiculo = New System.Windows.Forms.Label()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(9, 15)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Nombre.TabIndex = 10
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'tbox_Nombre
        '
        Me.tbox_Nombre.Location = New System.Drawing.Point(128, 12)
        Me.tbox_Nombre.MaxLength = 45
        Me.tbox_Nombre.Name = "tbox_Nombre"
        Me.tbox_Nombre.Size = New System.Drawing.Size(288, 20)
        Me.tbox_Nombre.TabIndex = 9
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(9, 42)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Telefono.TabIndex = 11
        Me.lbl_Telefono.Text = "Teléfono:"
        '
        'tbox_Telefono
        '
        Me.tbox_Telefono.Location = New System.Drawing.Point(128, 38)
        Me.tbox_Telefono.MaxLength = 45
        Me.tbox_Telefono.Name = "tbox_Telefono"
        Me.tbox_Telefono.Size = New System.Drawing.Size(288, 20)
        Me.tbox_Telefono.TabIndex = 12
        '
        'rad_Profesor
        '
        Me.rad_Profesor.AutoSize = True
        Me.rad_Profesor.Location = New System.Drawing.Point(133, 78)
        Me.rad_Profesor.Name = "rad_Profesor"
        Me.rad_Profesor.Size = New System.Drawing.Size(64, 17)
        Me.rad_Profesor.TabIndex = 13
        Me.rad_Profesor.TabStop = True
        Me.rad_Profesor.Text = "Profesor"
        Me.rad_Profesor.UseVisualStyleBackColor = True
        '
        'rad_Instructor
        '
        Me.rad_Instructor.AutoSize = True
        Me.rad_Instructor.Location = New System.Drawing.Point(263, 78)
        Me.rad_Instructor.Name = "rad_Instructor"
        Me.rad_Instructor.Size = New System.Drawing.Size(69, 17)
        Me.rad_Instructor.TabIndex = 14
        Me.rad_Instructor.TabStop = True
        Me.rad_Instructor.Text = "Instructor"
        Me.rad_Instructor.UseVisualStyleBackColor = True
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Location = New System.Drawing.Point(9, 80)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Tipo.TabIndex = 15
        Me.lbl_Tipo.Text = "Función:"
        '
        'cbox_Vehiculo
        '
        Me.cbox_Vehiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_Vehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Vehiculo.FormattingEnabled = True
        Me.cbox_Vehiculo.Location = New System.Drawing.Point(128, 110)
        Me.cbox_Vehiculo.Name = "cbox_Vehiculo"
        Me.cbox_Vehiculo.Size = New System.Drawing.Size(288, 21)
        Me.cbox_Vehiculo.TabIndex = 16
        '
        'lbl_Vehiculo
        '
        Me.lbl_Vehiculo.AutoSize = True
        Me.lbl_Vehiculo.Location = New System.Drawing.Point(9, 113)
        Me.lbl_Vehiculo.Name = "lbl_Vehiculo"
        Me.lbl_Vehiculo.Size = New System.Drawing.Size(99, 13)
        Me.lbl_Vehiculo.TabIndex = 17
        Me.lbl_Vehiculo.Text = "Vehículo asignado:"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Location = New System.Drawing.Point(341, 147)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 18
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Docente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 193)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.lbl_Vehiculo)
        Me.Controls.Add(Me.cbox_Vehiculo)
        Me.Controls.Add(Me.lbl_Tipo)
        Me.Controls.Add(Me.rad_Instructor)
        Me.Controls.Add(Me.rad_Profesor)
        Me.Controls.Add(Me.tbox_Telefono)
        Me.Controls.Add(Me.lbl_Telefono)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.tbox_Nombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Docente"
        Me.Text = "Docente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents tbox_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents tbox_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents rad_Profesor As System.Windows.Forms.RadioButton
    Friend WithEvents rad_Instructor As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents cbox_Vehiculo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Vehiculo As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
End Class
