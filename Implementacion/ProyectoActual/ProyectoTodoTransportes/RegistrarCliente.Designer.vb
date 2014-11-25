<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarCliente
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
        Me.lbl_Mensaje1 = New System.Windows.Forms.Label()
        Me.tbox_Telefono = New System.Windows.Forms.TextBox()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.date_FechaAtencion = New System.Windows.Forms.DateTimePicker()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.tbox_Observaciones = New System.Windows.Forms.RichTextBox()
        Me.tbox_Nombre = New System.Windows.Forms.TextBox()
        Me.lbl_Observaciones = New System.Windows.Forms.Label()
        Me.lbl_FechaAtencion = New System.Windows.Forms.Label()
        Me.cbox_CursoInteres = New System.Windows.Forms.ComboBox()
        Me.lbl_CursoInteres = New System.Windows.Forms.Label()
        Me.cbox_TipoLicencia = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Mensaje1
        '
        Me.lbl_Mensaje1.AutoSize = True
        Me.lbl_Mensaje1.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_Mensaje1.Location = New System.Drawing.Point(141, 272)
        Me.lbl_Mensaje1.Name = "lbl_Mensaje1"
        Me.lbl_Mensaje1.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Mensaje1.TabIndex = 45
        '
        'tbox_Telefono
        '
        Me.tbox_Telefono.Location = New System.Drawing.Point(142, 40)
        Me.tbox_Telefono.MaxLength = 20
        Me.tbox_Telefono.Name = "tbox_Telefono"
        Me.tbox_Telefono.Size = New System.Drawing.Size(278, 20)
        Me.tbox_Telefono.TabIndex = 35
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(13, 43)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Telefono.TabIndex = 44
        Me.lbl_Telefono.Text = "Telefono:"
        '
        'date_FechaAtencion
        '
        Me.date_FechaAtencion.Location = New System.Drawing.Point(141, 129)
        Me.date_FechaAtencion.Name = "date_FechaAtencion"
        Me.date_FechaAtencion.Size = New System.Drawing.Size(278, 20)
        Me.date_FechaAtencion.TabIndex = 37
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Location = New System.Drawing.Point(344, 267)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 39
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(13, 15)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Nombre.TabIndex = 40
        Me.lbl_Nombre.Text = "Nombre:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tbox_Observaciones
        '
        Me.tbox_Observaciones.Location = New System.Drawing.Point(141, 158)
        Me.tbox_Observaciones.MaxLength = 2000
        Me.tbox_Observaciones.Name = "tbox_Observaciones"
        Me.tbox_Observaciones.Size = New System.Drawing.Size(278, 103)
        Me.tbox_Observaciones.TabIndex = 38
        Me.tbox_Observaciones.Text = ""
        '
        'tbox_Nombre
        '
        Me.tbox_Nombre.Location = New System.Drawing.Point(142, 12)
        Me.tbox_Nombre.MaxLength = 255
        Me.tbox_Nombre.Name = "tbox_Nombre"
        Me.tbox_Nombre.Size = New System.Drawing.Size(278, 20)
        Me.tbox_Nombre.TabIndex = 34
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(13, 161)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(81, 13)
        Me.lbl_Observaciones.TabIndex = 43
        Me.lbl_Observaciones.Text = "Observaciones:"
        '
        'lbl_FechaAtencion
        '
        Me.lbl_FechaAtencion.AutoSize = True
        Me.lbl_FechaAtencion.Location = New System.Drawing.Point(13, 132)
        Me.lbl_FechaAtencion.Name = "lbl_FechaAtencion"
        Me.lbl_FechaAtencion.Size = New System.Drawing.Size(100, 13)
        Me.lbl_FechaAtencion.TabIndex = 41
        Me.lbl_FechaAtencion.Text = "Fecha de Atención:"
        '
        'cbox_CursoInteres
        '
        Me.cbox_CursoInteres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_CursoInteres.FormattingEnabled = True
        Me.cbox_CursoInteres.Location = New System.Drawing.Point(142, 99)
        Me.cbox_CursoInteres.Name = "cbox_CursoInteres"
        Me.cbox_CursoInteres.Size = New System.Drawing.Size(278, 21)
        Me.cbox_CursoInteres.TabIndex = 36
        '
        'lbl_CursoInteres
        '
        Me.lbl_CursoInteres.AutoSize = True
        Me.lbl_CursoInteres.Location = New System.Drawing.Point(13, 102)
        Me.lbl_CursoInteres.Name = "lbl_CursoInteres"
        Me.lbl_CursoInteres.Size = New System.Drawing.Size(87, 13)
        Me.lbl_CursoInteres.TabIndex = 42
        Me.lbl_CursoInteres.Text = "Curso de Interés:"
        '
        'cbox_TipoLicencia
        '
        Me.cbox_TipoLicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_TipoLicencia.FormattingEnabled = True
        Me.cbox_TipoLicencia.Location = New System.Drawing.Point(142, 69)
        Me.cbox_TipoLicencia.Name = "cbox_TipoLicencia"
        Me.cbox_TipoLicencia.Size = New System.Drawing.Size(278, 21)
        Me.cbox_TipoLicencia.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Tipo de Licencia:"
        '
        'RegistrarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 323)
        Me.Controls.Add(Me.cbox_TipoLicencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Mensaje1)
        Me.Controls.Add(Me.tbox_Telefono)
        Me.Controls.Add(Me.lbl_Telefono)
        Me.Controls.Add(Me.date_FechaAtencion)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.tbox_Observaciones)
        Me.Controls.Add(Me.tbox_Nombre)
        Me.Controls.Add(Me.lbl_Observaciones)
        Me.Controls.Add(Me.lbl_FechaAtencion)
        Me.Controls.Add(Me.cbox_CursoInteres)
        Me.Controls.Add(Me.lbl_CursoInteres)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrarCliente"
        Me.Text = "RegistrarCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Mensaje1 As System.Windows.Forms.Label
    Friend WithEvents tbox_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents date_FechaAtencion As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents tbox_Observaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents tbox_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaAtencion As System.Windows.Forms.Label
    Friend WithEvents cbox_CursoInteres As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_CursoInteres As System.Windows.Forms.Label
    Friend WithEvents cbox_TipoLicencia As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
