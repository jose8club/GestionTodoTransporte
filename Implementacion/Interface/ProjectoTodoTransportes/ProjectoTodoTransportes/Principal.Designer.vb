<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.lbl_Mensaje1 = New System.Windows.Forms.Label()
        Me.tbox_Telefono1 = New System.Windows.Forms.TextBox()
        Me.lbl_Telefono1 = New System.Windows.Forms.Label()
        Me.date_Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.btn_Guardar1 = New System.Windows.Forms.Button()
        Me.lbl_Nombre1 = New System.Windows.Forms.Label()
        Me.tbox_Observaciones1 = New System.Windows.Forms.RichTextBox()
        Me.tbox_Nombre1 = New System.Windows.Forms.TextBox()
        Me.lbl_Observaciones1 = New System.Windows.Forms.Label()
        Me.lbl_Fecha1 = New System.Windows.Forms.Label()
        Me.cbox_CursoInteres1 = New System.Windows.Forms.ComboBox()
        Me.lbl_CursoInteres1 = New System.Windows.Forms.Label()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tab3 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.doctor = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.folio = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.sitEx = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.fex = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.examengroup = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.situacion = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbox_rutvisual = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbox_estvisual = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Tab4 = New System.Windows.Forms.TabPage()
        Me.guardarPsico = New System.Windows.Forms.Button()
        Me.estadoPsico = New System.Windows.Forms.ComboBox()
        Me.horarioPsico = New System.Windows.Forms.TextBox()
        Me.fechaPsico = New System.Windows.Forms.DateTimePicker()
        Me.rutPsico = New System.Windows.Forms.ComboBox()
        Me.nombrePsico = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Tab5 = New System.Windows.Forms.TabPage()
        Me.TabControl.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.Tab2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Tab3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.examengroup.SuspendLayout()
        Me.Tab4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.Tab1)
        Me.TabControl.Controls.Add(Me.Tab2)
        Me.TabControl.Controls.Add(Me.Tab3)
        Me.TabControl.Controls.Add(Me.Tab4)
        Me.TabControl.Controls.Add(Me.Tab5)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(448, 485)
        Me.TabControl.TabIndex = 0
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.lbl_Mensaje1)
        Me.Tab1.Controls.Add(Me.tbox_Telefono1)
        Me.Tab1.Controls.Add(Me.lbl_Telefono1)
        Me.Tab1.Controls.Add(Me.date_Fecha1)
        Me.Tab1.Controls.Add(Me.btn_Guardar1)
        Me.Tab1.Controls.Add(Me.lbl_Nombre1)
        Me.Tab1.Controls.Add(Me.tbox_Observaciones1)
        Me.Tab1.Controls.Add(Me.tbox_Nombre1)
        Me.Tab1.Controls.Add(Me.lbl_Observaciones1)
        Me.Tab1.Controls.Add(Me.lbl_Fecha1)
        Me.Tab1.Controls.Add(Me.cbox_CursoInteres1)
        Me.Tab1.Controls.Add(Me.lbl_CursoInteres1)
        Me.Tab1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(440, 459)
        Me.Tab1.TabIndex = 0
        Me.Tab1.Text = "Registrar Cliente"
        Me.Tab1.UseVisualStyleBackColor = True
        '
        'lbl_Mensaje1
        '
        Me.lbl_Mensaje1.AutoSize = True
        Me.lbl_Mensaje1.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_Mensaje1.Location = New System.Drawing.Point(145, 242)
        Me.lbl_Mensaje1.Name = "lbl_Mensaje1"
        Me.lbl_Mensaje1.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Mensaje1.TabIndex = 21
        '
        'tbox_Telefono1
        '
        Me.tbox_Telefono1.Location = New System.Drawing.Point(145, 37)
        Me.tbox_Telefono1.Name = "tbox_Telefono1"
        Me.tbox_Telefono1.Size = New System.Drawing.Size(278, 20)
        Me.tbox_Telefono1.TabIndex = 20
        '
        'lbl_Telefono1
        '
        Me.lbl_Telefono1.AutoSize = True
        Me.lbl_Telefono1.Location = New System.Drawing.Point(16, 40)
        Me.lbl_Telefono1.Name = "lbl_Telefono1"
        Me.lbl_Telefono1.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Telefono1.TabIndex = 19
        Me.lbl_Telefono1.Text = "Telefono:"
        '
        'date_Fecha1
        '
        Me.date_Fecha1.Location = New System.Drawing.Point(145, 96)
        Me.date_Fecha1.Name = "date_Fecha1"
        Me.date_Fecha1.Size = New System.Drawing.Size(278, 20)
        Me.date_Fecha1.TabIndex = 11
        '
        'btn_Guardar1
        '
        Me.btn_Guardar1.Location = New System.Drawing.Point(348, 237)
        Me.btn_Guardar1.Name = "btn_Guardar1"
        Me.btn_Guardar1.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar1.TabIndex = 15
        Me.btn_Guardar1.Text = "Guardar"
        Me.btn_Guardar1.UseVisualStyleBackColor = True
        '
        'lbl_Nombre1
        '
        Me.lbl_Nombre1.AutoSize = True
        Me.lbl_Nombre1.Location = New System.Drawing.Point(16, 12)
        Me.lbl_Nombre1.Name = "lbl_Nombre1"
        Me.lbl_Nombre1.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Nombre1.TabIndex = 9
        Me.lbl_Nombre1.Text = "Nombre:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tbox_Observaciones1
        '
        Me.tbox_Observaciones1.Location = New System.Drawing.Point(145, 128)
        Me.tbox_Observaciones1.Name = "tbox_Observaciones1"
        Me.tbox_Observaciones1.Size = New System.Drawing.Size(278, 103)
        Me.tbox_Observaciones1.TabIndex = 14
        Me.tbox_Observaciones1.Text = ""
        '
        'tbox_Nombre1
        '
        Me.tbox_Nombre1.Location = New System.Drawing.Point(145, 9)
        Me.tbox_Nombre1.Name = "tbox_Nombre1"
        Me.tbox_Nombre1.Size = New System.Drawing.Size(278, 20)
        Me.tbox_Nombre1.TabIndex = 10
        '
        'lbl_Observaciones1
        '
        Me.lbl_Observaciones1.AutoSize = True
        Me.lbl_Observaciones1.Location = New System.Drawing.Point(16, 131)
        Me.lbl_Observaciones1.Name = "lbl_Observaciones1"
        Me.lbl_Observaciones1.Size = New System.Drawing.Size(81, 13)
        Me.lbl_Observaciones1.TabIndex = 17
        Me.lbl_Observaciones1.Text = "Observaciones:"
        '
        'lbl_Fecha1
        '
        Me.lbl_Fecha1.AutoSize = True
        Me.lbl_Fecha1.Location = New System.Drawing.Point(16, 99)
        Me.lbl_Fecha1.Name = "lbl_Fecha1"
        Me.lbl_Fecha1.Size = New System.Drawing.Size(100, 13)
        Me.lbl_Fecha1.TabIndex = 12
        Me.lbl_Fecha1.Text = "Fecha de Atención:"
        '
        'cbox_CursoInteres1
        '
        Me.cbox_CursoInteres1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_CursoInteres1.FormattingEnabled = True
        Me.cbox_CursoInteres1.Location = New System.Drawing.Point(145, 66)
        Me.cbox_CursoInteres1.Name = "cbox_CursoInteres1"
        Me.cbox_CursoInteres1.Size = New System.Drawing.Size(278, 21)
        Me.cbox_CursoInteres1.TabIndex = 13
        '
        'lbl_CursoInteres1
        '
        Me.lbl_CursoInteres1.AutoSize = True
        Me.lbl_CursoInteres1.Location = New System.Drawing.Point(16, 69)
        Me.lbl_CursoInteres1.Name = "lbl_CursoInteres1"
        Me.lbl_CursoInteres1.Size = New System.Drawing.Size(87, 13)
        Me.lbl_CursoInteres1.TabIndex = 16
        Me.lbl_CursoInteres1.Text = "Curso de Interés:"
        '
        'Tab2
        '
        Me.Tab2.Controls.Add(Me.Button3)
        Me.Tab2.Controls.Add(Me.GroupBox3)
        Me.Tab2.Controls.Add(Me.GroupBox2)
        Me.Tab2.Controls.Add(Me.GroupBox1)
        Me.Tab2.Controls.Add(Me.TextBox6)
        Me.Tab2.Controls.Add(Me.Label10)
        Me.Tab2.Controls.Add(Me.ComboBox3)
        Me.Tab2.Controls.Add(Me.Label9)
        Me.Tab2.Controls.Add(Me.DateTimePicker1)
        Me.Tab2.Controls.Add(Me.Label2)
        Me.Tab2.Controls.Add(Me.TextBox5)
        Me.Tab2.Controls.Add(Me.TextBox4)
        Me.Tab2.Controls.Add(Me.Label4)
        Me.Tab2.Controls.Add(Me.TextBox3)
        Me.Tab2.Controls.Add(Me.Label3)
        Me.Tab2.Controls.Add(Me.TextBox1)
        Me.Tab2.Controls.Add(Me.Label1)
        Me.Tab2.Location = New System.Drawing.Point(4, 22)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2.Size = New System.Drawing.Size(440, 459)
        Me.Tab2.TabIndex = 1
        Me.Tab2.Text = "Matrícula"
        Me.Tab2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(328, 355)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox4)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(232, 251)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(173, 98)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Matricula"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(9, 42)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox4.TabIndex = 15
        Me.CheckBox4.Text = "Pago Realizado"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(102, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "0000000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Número"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(205, 98)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado de Documentos"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(11, 65)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(152, 17)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = "Antecedentes académicos"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(11, 42)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(133, 17)
        Me.CheckBox2.TabIndex = 13
        Me.CheckBox2.Text = "Situación oftamológica"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(11, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Foto Carnet"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 81)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horarios"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(296, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 21)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Ver Disp"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(131, 46)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox2.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Practico"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 21)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Ver Disp"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(131, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Teorico"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(147, 138)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(256, 20)
        Me.TextBox6.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Telefono/Celular:"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(145, 111)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(258, 21)
        Me.ComboBox3.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Curso a rendir:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(147, 85)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(258, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Fecha de Atención:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(355, 59)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(48, 20)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(145, 59)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(204, 20)
        Me.TextBox4.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "R.U.T.:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(145, 35)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(258, 20)
        Me.TextBox3.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Apellidos:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(145, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombres:"
        '
        'Tab3
        '
        Me.Tab3.Controls.Add(Me.GroupBox5)
        Me.Tab3.Controls.Add(Me.GroupBox4)
        Me.Tab3.Controls.Add(Me.examengroup)
        Me.Tab3.Controls.Add(Me.cbox_rutvisual)
        Me.Tab3.Controls.Add(Me.Label12)
        Me.Tab3.Controls.Add(Me.cbox_estvisual)
        Me.Tab3.Controls.Add(Me.Label11)
        Me.Tab3.Location = New System.Drawing.Point(4, 22)
        Me.Tab3.Name = "Tab3"
        Me.Tab3.Size = New System.Drawing.Size(440, 459)
        Me.Tab3.TabIndex = 2
        Me.Tab3.Text = "Exámen Oftalmológico"
        Me.Tab3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Guardar)
        Me.GroupBox5.Controls.Add(Me.doctor)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.folio)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Location = New System.Drawing.Point(19, 299)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(375, 139)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ingresar Autorización"
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(281, 100)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Guardar.TabIndex = 21
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'doctor
        '
        Me.doctor.Location = New System.Drawing.Point(99, 74)
        Me.doctor.Name = "doctor"
        Me.doctor.Size = New System.Drawing.Size(257, 20)
        Me.doctor.TabIndex = 20
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(21, 77)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Doctor"
        '
        'folio
        '
        Me.folio.Location = New System.Drawing.Point(99, 48)
        Me.folio.Name = "folio"
        Me.folio.Size = New System.Drawing.Size(257, 20)
        Me.folio.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(21, 51)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "N° Folio"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(99, 22)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(257, 20)
        Me.DateTimePicker2.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(21, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Fecha:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.sitEx)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.fex)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 179)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(375, 114)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Nuevo Exámen"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(281, 75)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'sitEx
        '
        Me.sitEx.FormattingEnabled = True
        Me.sitEx.Location = New System.Drawing.Point(99, 48)
        Me.sitEx.Name = "sitEx"
        Me.sitEx.Size = New System.Drawing.Size(257, 21)
        Me.sitEx.TabIndex = 5
        Me.sitEx.Text = "PENDIENTE"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Situación:"
        '
        'fex
        '
        Me.fex.Location = New System.Drawing.Point(99, 22)
        Me.fex.Name = "fex"
        Me.fex.Size = New System.Drawing.Size(257, 20)
        Me.fex.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(21, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Fecha:"
        '
        'examengroup
        '
        Me.examengroup.Controls.Add(Me.Label13)
        Me.examengroup.Controls.Add(Me.Label14)
        Me.examengroup.Controls.Add(Me.situacion)
        Me.examengroup.Controls.Add(Me.Label15)
        Me.examengroup.Location = New System.Drawing.Point(19, 77)
        Me.examengroup.Name = "examengroup"
        Me.examengroup.Size = New System.Drawing.Size(375, 79)
        Me.examengroup.TabIndex = 14
        Me.examengroup.TabStop = False
        Me.examengroup.Text = "Examen Oftalmologico"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(135, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "21/Julio/2015"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Fecha:"
        '
        'situacion
        '
        Me.situacion.AutoSize = True
        Me.situacion.Location = New System.Drawing.Point(140, 27)
        Me.situacion.Name = "situacion"
        Me.situacion.Size = New System.Drawing.Size(69, 13)
        Me.situacion.TabIndex = 1
        Me.situacion.Text = "PENDIENTE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Situación:"
        '
        'cbox_rutvisual
        '
        Me.cbox_rutvisual.FormattingEnabled = True
        Me.cbox_rutvisual.Location = New System.Drawing.Point(118, 36)
        Me.cbox_rutvisual.Name = "cbox_rutvisual"
        Me.cbox_rutvisual.Size = New System.Drawing.Size(276, 21)
        Me.cbox_rutvisual.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "R.U.T.:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cbox_estvisual
        '
        Me.cbox_estvisual.FormattingEnabled = True
        Me.cbox_estvisual.Location = New System.Drawing.Point(118, 9)
        Me.cbox_estvisual.Name = "cbox_estvisual"
        Me.cbox_estvisual.Size = New System.Drawing.Size(276, 21)
        Me.cbox_estvisual.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Nombre:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Tab4
        '
        Me.Tab4.Controls.Add(Me.guardarPsico)
        Me.Tab4.Controls.Add(Me.estadoPsico)
        Me.Tab4.Controls.Add(Me.horarioPsico)
        Me.Tab4.Controls.Add(Me.fechaPsico)
        Me.Tab4.Controls.Add(Me.rutPsico)
        Me.Tab4.Controls.Add(Me.nombrePsico)
        Me.Tab4.Controls.Add(Me.Label21)
        Me.Tab4.Controls.Add(Me.Label22)
        Me.Tab4.Controls.Add(Me.Label23)
        Me.Tab4.Controls.Add(Me.Label24)
        Me.Tab4.Controls.Add(Me.Label25)
        Me.Tab4.Location = New System.Drawing.Point(4, 22)
        Me.Tab4.Name = "Tab4"
        Me.Tab4.Size = New System.Drawing.Size(440, 459)
        Me.Tab4.TabIndex = 3
        Me.Tab4.Text = "Practica Psicótecnico"
        Me.Tab4.UseVisualStyleBackColor = True
        '
        'guardarPsico
        '
        Me.guardarPsico.Location = New System.Drawing.Point(316, 237)
        Me.guardarPsico.Name = "guardarPsico"
        Me.guardarPsico.Size = New System.Drawing.Size(101, 28)
        Me.guardarPsico.TabIndex = 21
        Me.guardarPsico.Text = "Guardar"
        Me.guardarPsico.UseVisualStyleBackColor = True
        '
        'estadoPsico
        '
        Me.estadoPsico.FormattingEnabled = True
        Me.estadoPsico.Location = New System.Drawing.Point(87, 198)
        Me.estadoPsico.Name = "estadoPsico"
        Me.estadoPsico.Size = New System.Drawing.Size(330, 21)
        Me.estadoPsico.TabIndex = 20
        '
        'horarioPsico
        '
        Me.horarioPsico.Location = New System.Drawing.Point(86, 153)
        Me.horarioPsico.Name = "horarioPsico"
        Me.horarioPsico.Size = New System.Drawing.Size(331, 20)
        Me.horarioPsico.TabIndex = 19
        '
        'fechaPsico
        '
        Me.fechaPsico.Location = New System.Drawing.Point(83, 109)
        Me.fechaPsico.Name = "fechaPsico"
        Me.fechaPsico.Size = New System.Drawing.Size(334, 20)
        Me.fechaPsico.TabIndex = 18
        '
        'rutPsico
        '
        Me.rutPsico.FormattingEnabled = True
        Me.rutPsico.Location = New System.Drawing.Point(82, 65)
        Me.rutPsico.Name = "rutPsico"
        Me.rutPsico.Size = New System.Drawing.Size(334, 21)
        Me.rutPsico.TabIndex = 17
        '
        'nombrePsico
        '
        Me.nombrePsico.FormattingEnabled = True
        Me.nombrePsico.Location = New System.Drawing.Point(82, 27)
        Me.nombrePsico.Name = "nombrePsico"
        Me.nombrePsico.Size = New System.Drawing.Size(334, 21)
        Me.nombrePsico.TabIndex = 16
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(11, 201)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Estado"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(11, 156)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 13)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Horario"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(11, 115)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 13)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "Fecha"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(11, 68)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 13)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "R.U.T."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(11, 30)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 13)
        Me.Label25.TabIndex = 11
        Me.Label25.Text = "Nombre"
        '
        'Tab5
        '
        Me.Tab5.Location = New System.Drawing.Point(4, 22)
        Me.Tab5.Name = "Tab5"
        Me.Tab5.Size = New System.Drawing.Size(440, 459)
        Me.Tab5.TabIndex = 4
        Me.Tab5.Text = "TabPage3"
        Me.Tab5.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 509)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "Principal"
        Me.Text = "Sistema de Gestión TodoTransporte"
        Me.TabControl.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.Tab2.ResumeLayout(False)
        Me.Tab2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Tab3.ResumeLayout(False)
        Me.Tab3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.examengroup.ResumeLayout(False)
        Me.examengroup.PerformLayout()
        Me.Tab4.ResumeLayout(False)
        Me.Tab4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents Tab1 As System.Windows.Forms.TabPage
    Friend WithEvents Tab2 As System.Windows.Forms.TabPage
    Friend WithEvents tbox_Telefono1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Telefono1 As System.Windows.Forms.Label
    Friend WithEvents date_Fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Guardar1 As System.Windows.Forms.Button
    Friend WithEvents lbl_Nombre1 As System.Windows.Forms.Label
    Friend WithEvents tbox_Observaciones1 As System.Windows.Forms.RichTextBox
    Friend WithEvents tbox_Nombre1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Observaciones1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha1 As System.Windows.Forms.Label
    Friend WithEvents cbox_CursoInteres1 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_CursoInteres1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Mensaje1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Tab3 As System.Windows.Forms.TabPage
    Friend WithEvents Tab4 As System.Windows.Forms.TabPage
    Friend WithEvents Tab5 As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbox_rutvisual As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbox_estvisual As System.Windows.Forms.ComboBox
    Friend WithEvents examengroup As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents situacion As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents fex As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents sitEx As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents folio As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents doctor As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents guardarPsico As System.Windows.Forms.Button
    Friend WithEvents estadoPsico As System.Windows.Forms.ComboBox
    Friend WithEvents horarioPsico As System.Windows.Forms.TextBox
    Friend WithEvents fechaPsico As System.Windows.Forms.DateTimePicker
    Friend WithEvents rutPsico As System.Windows.Forms.ComboBox
    Friend WithEvents nombrePsico As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Guardar As System.Windows.Forms.Button
End Class
