﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newFlota
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbox_modelo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_resetear01 = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.cbox_instructor = New System.Windows.Forms.ComboBox()
        Me.cbox_estado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbox_instructor2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_resetear02 = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.cbox_estado2 = New System.Windows.Forms.ComboBox()
        Me.cbox_matricula = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbox_mat1 = New CustomTxtBox.Custom2()
        Me.tbox_mat2 = New CustomTxtBox.Custom2()
        Me.tbox_mat3 = New CustomTxtBox.Custom2()
        Me.cbox_anios = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbox_mat3)
        Me.GroupBox1.Controls.Add(Me.tbox_mat2)
        Me.GroupBox1.Controls.Add(Me.tbox_mat1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbox_modelo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn_resetear01)
        Me.GroupBox1.Controls.Add(Me.btn_agregar)
        Me.GroupBox1.Controls.Add(Me.cbox_instructor)
        Me.GroupBox1.Controls.Add(Me.cbox_estado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 198)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Vehiculo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(272, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(195, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "."
        '
        'tbox_modelo
        '
        Me.tbox_modelo.Location = New System.Drawing.Point(135, 86)
        Me.tbox_modelo.Name = "tbox_modelo"
        Me.tbox_modelo.Size = New System.Drawing.Size(206, 20)
        Me.tbox_modelo.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Modelo:"
        '
        'btn_resetear01
        '
        Me.btn_resetear01.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON
        Me.btn_resetear01.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_resetear01.Location = New System.Drawing.Point(419, 153)
        Me.btn_resetear01.Name = "btn_resetear01"
        Me.btn_resetear01.Size = New System.Drawing.Size(87, 23)
        Me.btn_resetear01.TabIndex = 11
        Me.btn_resetear01.Text = "Resetear"
        Me.btn_resetear01.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_resetear01.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.ADD_BUTTON
        Me.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_agregar.Location = New System.Drawing.Point(321, 153)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(79, 23)
        Me.btn_agregar.TabIndex = 10
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'cbox_instructor
        '
        Me.cbox_instructor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_instructor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_instructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_instructor.FormattingEnabled = True
        Me.cbox_instructor.Location = New System.Drawing.Point(135, 116)
        Me.cbox_instructor.Name = "cbox_instructor"
        Me.cbox_instructor.Size = New System.Drawing.Size(206, 21)
        Me.cbox_instructor.TabIndex = 9
        Me.cbox_instructor.Visible = False
        '
        'cbox_estado
        '
        Me.cbox_estado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_estado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_estado.FormattingEnabled = True
        Me.cbox_estado.Location = New System.Drawing.Point(135, 59)
        Me.cbox_estado.Name = "cbox_estado"
        Me.cbox_estado.Size = New System.Drawing.Size(206, 21)
        Me.cbox_estado.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Instructor:"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matricula/Patente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbox_instructor2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btn_resetear02)
        Me.GroupBox2.Controls.Add(Me.btn_guardar)
        Me.GroupBox2.Controls.Add(Me.cbox_estado2)
        Me.GroupBox2.Controls.Add(Me.cbox_matricula)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(631, 170)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestión de Flota"
        '
        'cbox_instructor2
        '
        Me.cbox_instructor2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_instructor2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_instructor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_instructor2.FormattingEnabled = True
        Me.cbox_instructor2.Location = New System.Drawing.Point(135, 96)
        Me.cbox_instructor2.Name = "cbox_instructor2"
        Me.cbox_instructor2.Size = New System.Drawing.Size(206, 21)
        Me.cbox_instructor2.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Instructor:"
        '
        'btn_resetear02
        '
        Me.btn_resetear02.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON
        Me.btn_resetear02.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_resetear02.Location = New System.Drawing.Point(419, 132)
        Me.btn_resetear02.Name = "btn_resetear02"
        Me.btn_resetear02.Size = New System.Drawing.Size(87, 23)
        Me.btn_resetear02.TabIndex = 16
        Me.btn_resetear02.Text = "Resetear"
        Me.btn_resetear02.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_resetear02.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.SAVE
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.Location = New System.Drawing.Point(321, 132)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(79, 23)
        Me.btn_guardar.TabIndex = 15
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'cbox_estado2
        '
        Me.cbox_estado2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_estado2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_estado2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_estado2.FormattingEnabled = True
        Me.cbox_estado2.Location = New System.Drawing.Point(135, 60)
        Me.cbox_estado2.Name = "cbox_estado2"
        Me.cbox_estado2.Size = New System.Drawing.Size(206, 21)
        Me.cbox_estado2.TabIndex = 13
        '
        'cbox_matricula
        '
        Me.cbox_matricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_matricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_matricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_matricula.FormattingEnabled = True
        Me.cbox_matricula.Location = New System.Drawing.Point(135, 33)
        Me.cbox_matricula.Name = "cbox_matricula"
        Me.cbox_matricula.Size = New System.Drawing.Size(206, 21)
        Me.cbox_matricula.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Estado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Matricula:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(162, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Año Procedencia:"
        '
        'tbox_mat1
        '
        Me.tbox_mat1.Location = New System.Drawing.Point(135, 30)
        Me.tbox_mat1.MaxLength = 2
        Me.tbox_mat1.Name = "tbox_mat1"
        Me.tbox_mat1.Size = New System.Drawing.Size(51, 20)
        Me.tbox_mat1.TabIndex = 15
        Me.tbox_mat1.Tipo = CustomTxtBox.Custom2.Tipologia.LETRA
        '
        'tbox_mat2
        '
        Me.tbox_mat2.Location = New System.Drawing.Point(211, 30)
        Me.tbox_mat2.MaxLength = 2
        Me.tbox_mat2.Name = "tbox_mat2"
        Me.tbox_mat2.Size = New System.Drawing.Size(51, 20)
        Me.tbox_mat2.TabIndex = 16
        Me.tbox_mat2.Tipo = CustomTxtBox.Custom2.Tipologia.LETRA
        '
        'tbox_mat3
        '
        Me.tbox_mat3.Location = New System.Drawing.Point(288, 30)
        Me.tbox_mat3.MaxLength = 2
        Me.tbox_mat3.Name = "tbox_mat3"
        Me.tbox_mat3.Size = New System.Drawing.Size(51, 20)
        Me.tbox_mat3.TabIndex = 17
        Me.tbox_mat3.Tipo = CustomTxtBox.Custom2.Tipologia.LETRA
        '
        'cbox_anios
        '
        Me.cbox_anios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_anios.FormattingEnabled = True
        Me.cbox_anios.Location = New System.Drawing.Point(260, 9)
        Me.cbox_anios.Name = "cbox_anios"
        Me.cbox_anios.Size = New System.Drawing.Size(136, 21)
        Me.cbox_anios.TabIndex = 3
        '
        'newFlota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 417)
        Me.Controls.Add(Me.cbox_anios)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newFlota"
        Me.Text = "newFlota"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_resetear01 As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents cbox_instructor As System.Windows.Forms.ComboBox
    Friend WithEvents cbox_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_resetear02 As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents cbox_estado2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbox_matricula As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbox_modelo As System.Windows.Forms.TextBox
    Friend WithEvents cbox_instructor2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbox_anio As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_mat3 As CustomTxtBox.Custom2
    Friend WithEvents tbox_mat2 As CustomTxtBox.Custom2
    Friend WithEvents tbox_mat1 As CustomTxtBox.Custom2
    Friend WithEvents cbox_anios As System.Windows.Forms.ComboBox
    'Friend WithEvents tbox_mat2 As CustomTxtBox.Custom2
    'Friend WithEvents tbox_mat1 As CustomTxtBox.Custom2
    'Friend WithEvents tbox_mat3 As CustomTxtBox.Custom2
End Class
