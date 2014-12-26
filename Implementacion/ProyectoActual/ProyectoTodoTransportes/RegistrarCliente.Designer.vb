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
        Me.tbox_Telefono = New System.Windows.Forms.TextBox()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.date_FechaAtencion = New System.Windows.Forms.DateTimePicker()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.tbox_Consultas = New System.Windows.Forms.RichTextBox()
        Me.tbox_Nombre = New System.Windows.Forms.TextBox()
        Me.lbl_Consultas = New System.Windows.Forms.Label()
        Me.lbl_FechaAtencion = New System.Windows.Forms.Label()
        Me.cbox_CursoInteres = New System.Windows.Forms.ComboBox()
        Me.lbl_CursoInteres = New System.Windows.Forms.Label()
        Me.cbox_Area = New System.Windows.Forms.ComboBox()
        Me.lbl_Area = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.tbox_CodigoCurso = New System.Windows.Forms.TextBox()
        Me.lbl_TipoAtencion = New System.Windows.Forms.Label()
        Me.cbox_TipoAtencion = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbox_Telefono
        '
        Me.tbox_Telefono.Location = New System.Drawing.Point(170, 78)
        Me.tbox_Telefono.MaxLength = 20
        Me.tbox_Telefono.Name = "tbox_Telefono"
        Me.tbox_Telefono.Size = New System.Drawing.Size(248, 20)
        Me.tbox_Telefono.TabIndex = 35
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(41, 81)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Telefono.TabIndex = 44
        Me.lbl_Telefono.Text = "Telefono:"
        '
        'date_FechaAtencion
        '
        Me.date_FechaAtencion.Location = New System.Drawing.Point(170, 302)
        Me.date_FechaAtencion.Name = "date_FechaAtencion"
        Me.date_FechaAtencion.Size = New System.Drawing.Size(249, 20)
        Me.date_FechaAtencion.TabIndex = 41
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.SAVE
        Me.btn_Guardar.Location = New System.Drawing.Point(515, 318)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(160, 40)
        Me.btn_Guardar.TabIndex = 43
        Me.btn_Guardar.Text = " Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(41, 46)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Nombre.TabIndex = 40
        Me.lbl_Nombre.Text = "Nombre:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tbox_Consultas
        '
        Me.tbox_Consultas.Location = New System.Drawing.Point(170, 184)
        Me.tbox_Consultas.MaxLength = 2000
        Me.tbox_Consultas.Name = "tbox_Consultas"
        Me.tbox_Consultas.Size = New System.Drawing.Size(249, 103)
        Me.tbox_Consultas.TabIndex = 40
        Me.tbox_Consultas.Text = ""
        '
        'tbox_Nombre
        '
        Me.tbox_Nombre.Location = New System.Drawing.Point(170, 43)
        Me.tbox_Nombre.MaxLength = 255
        Me.tbox_Nombre.Name = "tbox_Nombre"
        Me.tbox_Nombre.Size = New System.Drawing.Size(248, 20)
        Me.tbox_Nombre.TabIndex = 34
        '
        'lbl_Consultas
        '
        Me.lbl_Consultas.AutoSize = True
        Me.lbl_Consultas.Location = New System.Drawing.Point(41, 187)
        Me.lbl_Consultas.Name = "lbl_Consultas"
        Me.lbl_Consultas.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Consultas.TabIndex = 43
        Me.lbl_Consultas.Text = "Consultas:"
        '
        'lbl_FechaAtencion
        '
        Me.lbl_FechaAtencion.AutoSize = True
        Me.lbl_FechaAtencion.Location = New System.Drawing.Point(41, 308)
        Me.lbl_FechaAtencion.Name = "lbl_FechaAtencion"
        Me.lbl_FechaAtencion.Size = New System.Drawing.Size(100, 13)
        Me.lbl_FechaAtencion.TabIndex = 41
        Me.lbl_FechaAtencion.Text = "Fecha de Atención:"
        '
        'cbox_CursoInteres
        '
        Me.cbox_CursoInteres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_CursoInteres.FormattingEnabled = True
        Me.cbox_CursoInteres.Location = New System.Drawing.Point(170, 149)
        Me.cbox_CursoInteres.Name = "cbox_CursoInteres"
        Me.cbox_CursoInteres.Size = New System.Drawing.Size(147, 21)
        Me.cbox_CursoInteres.TabIndex = 37
        '
        'lbl_CursoInteres
        '
        Me.lbl_CursoInteres.AutoSize = True
        Me.lbl_CursoInteres.Location = New System.Drawing.Point(41, 152)
        Me.lbl_CursoInteres.Name = "lbl_CursoInteres"
        Me.lbl_CursoInteres.Size = New System.Drawing.Size(87, 13)
        Me.lbl_CursoInteres.TabIndex = 42
        Me.lbl_CursoInteres.Text = "Curso de Interés:"
        '
        'cbox_Area
        '
        Me.cbox_Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Area.FormattingEnabled = True
        Me.cbox_Area.Location = New System.Drawing.Point(170, 113)
        Me.cbox_Area.Name = "cbox_Area"
        Me.cbox_Area.Size = New System.Drawing.Size(248, 21)
        Me.cbox_Area.TabIndex = 36
        '
        'lbl_Area
        '
        Me.lbl_Area.AutoSize = True
        Me.lbl_Area.Location = New System.Drawing.Point(41, 116)
        Me.lbl_Area.Name = "lbl_Area"
        Me.lbl_Area.Size = New System.Drawing.Size(89, 13)
        Me.lbl_Area.TabIndex = 47
        Me.lbl_Area.Text = "Tipo de Licencia:"
        '
        'PictureBox
        '
        Me.PictureBox.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.b
        Me.PictureBox.Location = New System.Drawing.Point(470, 43)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox.TabIndex = 48
        Me.PictureBox.TabStop = False
        '
        'tbox_CodigoCurso
        '
        Me.tbox_CodigoCurso.Location = New System.Drawing.Point(323, 149)
        Me.tbox_CodigoCurso.MaxLength = 20
        Me.tbox_CodigoCurso.Name = "tbox_CodigoCurso"
        Me.tbox_CodigoCurso.Size = New System.Drawing.Size(95, 20)
        Me.tbox_CodigoCurso.TabIndex = 38
        Me.tbox_CodigoCurso.Text = "Código"
        Me.tbox_CodigoCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_TipoAtencion
        '
        Me.lbl_TipoAtencion.AutoSize = True
        Me.lbl_TipoAtencion.Location = New System.Drawing.Point(41, 340)
        Me.lbl_TipoAtencion.Name = "lbl_TipoAtencion"
        Me.lbl_TipoAtencion.Size = New System.Drawing.Size(91, 13)
        Me.lbl_TipoAtencion.TabIndex = 50
        Me.lbl_TipoAtencion.Text = "Tipo de Atención:"
        '
        'cbox_TipoAtencion
        '
        Me.cbox_TipoAtencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_TipoAtencion.FormattingEnabled = True
        Me.cbox_TipoAtencion.Items.AddRange(New Object() {"Oficina", "Teléfono"})
        Me.cbox_TipoAtencion.Location = New System.Drawing.Point(170, 337)
        Me.cbox_TipoAtencion.Name = "cbox_TipoAtencion"
        Me.cbox_TipoAtencion.Size = New System.Drawing.Size(249, 21)
        Me.cbox_TipoAtencion.TabIndex = 42
        '
        'RegistrarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 400)
        Me.Controls.Add(Me.cbox_TipoAtencion)
        Me.Controls.Add(Me.lbl_TipoAtencion)
        Me.Controls.Add(Me.tbox_CodigoCurso)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.cbox_Area)
        Me.Controls.Add(Me.lbl_Area)
        Me.Controls.Add(Me.tbox_Telefono)
        Me.Controls.Add(Me.lbl_Telefono)
        Me.Controls.Add(Me.date_FechaAtencion)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.tbox_Consultas)
        Me.Controls.Add(Me.tbox_Nombre)
        Me.Controls.Add(Me.lbl_Consultas)
        Me.Controls.Add(Me.lbl_FechaAtencion)
        Me.Controls.Add(Me.cbox_CursoInteres)
        Me.Controls.Add(Me.lbl_CursoInteres)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrarCliente"
        Me.Text = "s"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbox_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents date_FechaAtencion As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents tbox_Consultas As System.Windows.Forms.RichTextBox
    Friend WithEvents tbox_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Consultas As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaAtencion As System.Windows.Forms.Label
    Friend WithEvents cbox_CursoInteres As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_CursoInteres As System.Windows.Forms.Label
    Friend WithEvents cbox_Area As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Area As System.Windows.Forms.Label
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents tbox_CodigoCurso As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TipoAtencion As System.Windows.Forms.Label
    Friend WithEvents cbox_TipoAtencion As System.Windows.Forms.ComboBox
End Class
