<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matricula
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
        Me.components = New System.ComponentModel.Container()
        Me.DatosPersonalesGbx = New System.Windows.Forms.GroupBox()
        Me.NombreCTxBx = New ProyectoTodoTransportes.CustomTextBoxClass(Me.components)
        Me.EmailCTxBx = New ProyectoTodoTransportes.CustomTextBoxClass(Me.components)
        Me.EmailLbl = New System.Windows.Forms.Label()
        Me.ClienteCbBx = New System.Windows.Forms.ComboBox()
        Me.ClienteLbl = New System.Windows.Forms.Label()
        Me.DVCTxBx = New ProyectoTodoTransportes.CustomTextBoxClass(Me.components)
        Me.RutCTxBx = New ProyectoTodoTransportes.CustomTextBoxClass(Me.components)
        Me.TelCTxBx = New ProyectoTodoTransportes.CustomTextBoxClass(Me.components)
        Me.TelefonoLbl = New System.Windows.Forms.Label()
        Me.FNacDTiPckr = New System.Windows.Forms.DateTimePicker()
        Me.FNacLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RutLbl = New System.Windows.Forms.Label()
        Me.NombreLbl = New System.Windows.Forms.Label()
        Me.DatosCursoGBx = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CuposTxtLbl = New System.Windows.Forms.Label()
        Me.CuposLbl = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.DiasGBx = New System.Windows.Forms.GroupBox()
        Me.LuSaRaBtn = New System.Windows.Forms.RadioButton()
        Me.LuViRaBtn = New System.Windows.Forms.RadioButton()
        Me.HraPracticaCbBx = New System.Windows.Forms.ComboBox()
        Me.HraPractica = New System.Windows.Forms.Label()
        Me.HraTeoriaCbBx = New System.Windows.Forms.ComboBox()
        Me.HraTeoria = New System.Windows.Forms.Label()
        Me.CursoCbBx = New System.Windows.Forms.ComboBox()
        Me.CursoLbl = New System.Windows.Forms.Label()
        Me.ProductoCbBx = New System.Windows.Forms.ComboBox()
        Me.ProductoLbl = New System.Windows.Forms.Label()
        Me.DatosPagoGBx = New System.Windows.Forms.GroupBox()
        Me.CodPagoLbl = New System.Windows.Forms.Label()
        Me.CodPagoTxBx = New System.Windows.Forms.TextBox()
        Me.PagoRealizChBx = New System.Windows.Forms.CheckBox()
        Me.MedioPagoChBx = New System.Windows.Forms.ComboBox()
        Me.DocPagoCbBx = New System.Windows.Forms.ComboBox()
        Me.APagarTxtLbl = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.DctoSpinBx = New System.Windows.Forms.NumericUpDown()
        Me.ValorTxtLbl = New System.Windows.Forms.Label()
        Me.DctoLbl = New System.Windows.Forms.Label()
        Me.MedioPagoLbl = New System.Windows.Forms.Label()
        Me.DocPagoLbl = New System.Windows.Forms.Label()
        Me.APagarLbl = New System.Windows.Forms.Label()
        Me.ValorLbl = New System.Windows.Forms.Label()
        Me.GuardarBtn = New System.Windows.Forms.Button()
        Me.DocumentosGbx = New System.Windows.Forms.GroupBox()
        Me.FotosChBx = New System.Windows.Forms.CheckBox()
        Me.CertNotarialChBx = New System.Windows.Forms.CheckBox()
        Me.CertEstudiosChBx = New System.Windows.Forms.CheckBox()
        Me.FotocopiaLicenciaChBx = New System.Windows.Forms.CheckBox()
        Me.FotocopiaCIChBx = New System.Windows.Forms.CheckBox()
        Me.NRegLbl = New System.Windows.Forms.Label()
        Me.LimpiarBtn = New System.Windows.Forms.Button()
        Me.NRegCTxBx = New ProyectoTodoTransportes.CustomTextBoxClass(Me.components)
        Me.QueryTb = New System.Windows.Forms.TextBox()
        Me.DatosPersonalesGbx.SuspendLayout()
        Me.DatosCursoGBx.SuspendLayout()
        Me.DiasGBx.SuspendLayout()
        Me.DatosPagoGBx.SuspendLayout()
        CType(Me.DctoSpinBx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentosGbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatosPersonalesGbx
        '
        Me.DatosPersonalesGbx.Controls.Add(Me.NombreCTxBx)
        Me.DatosPersonalesGbx.Controls.Add(Me.EmailCTxBx)
        Me.DatosPersonalesGbx.Controls.Add(Me.EmailLbl)
        Me.DatosPersonalesGbx.Controls.Add(Me.ClienteCbBx)
        Me.DatosPersonalesGbx.Controls.Add(Me.ClienteLbl)
        Me.DatosPersonalesGbx.Controls.Add(Me.DVCTxBx)
        Me.DatosPersonalesGbx.Controls.Add(Me.RutCTxBx)
        Me.DatosPersonalesGbx.Controls.Add(Me.TelCTxBx)
        Me.DatosPersonalesGbx.Controls.Add(Me.TelefonoLbl)
        Me.DatosPersonalesGbx.Controls.Add(Me.FNacDTiPckr)
        Me.DatosPersonalesGbx.Controls.Add(Me.FNacLbl)
        Me.DatosPersonalesGbx.Controls.Add(Me.Label3)
        Me.DatosPersonalesGbx.Controls.Add(Me.RutLbl)
        Me.DatosPersonalesGbx.Controls.Add(Me.NombreLbl)
        Me.DatosPersonalesGbx.Location = New System.Drawing.Point(12, 38)
        Me.DatosPersonalesGbx.Name = "DatosPersonalesGbx"
        Me.DatosPersonalesGbx.Size = New System.Drawing.Size(408, 198)
        Me.DatosPersonalesGbx.TabIndex = 1
        Me.DatosPersonalesGbx.TabStop = False
        Me.DatosPersonalesGbx.Text = "Datos Personales"
        '
        'NombreCTxBx
        '
        Me.NombreCTxBx.Location = New System.Drawing.Point(125, 27)
        Me.NombreCTxBx.MaxLength = 255
        Me.NombreCTxBx.Name = "NombreCTxBx"
        Me.NombreCTxBx.Size = New System.Drawing.Size(277, 20)
        Me.NombreCTxBx.TabIndex = 0
        Me.NombreCTxBx.Tipo = ProyectoTodoTransportes.CustomTextBoxClass.TipoClase.ALPHA
        '
        'EmailCTxBx
        '
        Me.EmailCTxBx.Location = New System.Drawing.Point(124, 131)
        Me.EmailCTxBx.MaxLength = 255
        Me.EmailCTxBx.Name = "EmailCTxBx"
        Me.EmailCTxBx.Size = New System.Drawing.Size(278, 20)
        Me.EmailCTxBx.TabIndex = 5
        Me.EmailCTxBx.Tipo = ProyectoTodoTransportes.CustomTextBoxClass.TipoClase.TEXT
        '
        'EmailLbl
        '
        Me.EmailLbl.AutoSize = True
        Me.EmailLbl.Location = New System.Drawing.Point(6, 134)
        Me.EmailLbl.Name = "EmailLbl"
        Me.EmailLbl.Size = New System.Drawing.Size(38, 13)
        Me.EmailLbl.TabIndex = 15
        Me.EmailLbl.Text = "E-mail:"
        '
        'ClienteCbBx
        '
        Me.ClienteCbBx.FormattingEnabled = True
        Me.ClienteCbBx.Location = New System.Drawing.Point(124, 157)
        Me.ClienteCbBx.Name = "ClienteCbBx"
        Me.ClienteCbBx.Size = New System.Drawing.Size(200, 21)
        Me.ClienteCbBx.TabIndex = 6
        '
        'ClienteLbl
        '
        Me.ClienteLbl.AutoSize = True
        Me.ClienteLbl.Location = New System.Drawing.Point(6, 160)
        Me.ClienteLbl.Name = "ClienteLbl"
        Me.ClienteLbl.Size = New System.Drawing.Size(106, 13)
        Me.ClienteLbl.TabIndex = 13
        Me.ClienteLbl.Text = "Franquicia Tributaria:"
        '
        'DVCTxBx
        '
        Me.DVCTxBx.Location = New System.Drawing.Point(247, 53)
        Me.DVCTxBx.MaxLength = 1
        Me.DVCTxBx.Name = "DVCTxBx"
        Me.DVCTxBx.Size = New System.Drawing.Size(20, 20)
        Me.DVCTxBx.TabIndex = 2
        Me.DVCTxBx.Tipo = ProyectoTodoTransportes.CustomTextBoxClass.TipoClase.ALPHA_NUMERIC
        '
        'RutCTxBx
        '
        Me.RutCTxBx.Location = New System.Drawing.Point(124, 53)
        Me.RutCTxBx.MaxLength = 9
        Me.RutCTxBx.Name = "RutCTxBx"
        Me.RutCTxBx.Size = New System.Drawing.Size(100, 20)
        Me.RutCTxBx.TabIndex = 1
        Me.RutCTxBx.Tipo = ProyectoTodoTransportes.CustomTextBoxClass.TipoClase.NUMERIC
        '
        'TelCTxBx
        '
        Me.TelCTxBx.Location = New System.Drawing.Point(124, 105)
        Me.TelCTxBx.MaxLength = 15
        Me.TelCTxBx.Name = "TelCTxBx"
        Me.TelCTxBx.Size = New System.Drawing.Size(100, 20)
        Me.TelCTxBx.TabIndex = 4
        Me.TelCTxBx.Tipo = ProyectoTodoTransportes.CustomTextBoxClass.TipoClase.NUMERIC
        '
        'TelefonoLbl
        '
        Me.TelefonoLbl.AutoSize = True
        Me.TelefonoLbl.Location = New System.Drawing.Point(6, 108)
        Me.TelefonoLbl.Name = "TelefonoLbl"
        Me.TelefonoLbl.Size = New System.Drawing.Size(52, 13)
        Me.TelefonoLbl.TabIndex = 8
        Me.TelefonoLbl.Text = "Teléfono:"
        '
        'FNacDTiPckr
        '
        Me.FNacDTiPckr.Location = New System.Drawing.Point(124, 79)
        Me.FNacDTiPckr.Name = "FNacDTiPckr"
        Me.FNacDTiPckr.Size = New System.Drawing.Size(200, 20)
        Me.FNacDTiPckr.TabIndex = 3
        Me.FNacDTiPckr.Value = New Date(2014, 12, 1, 4, 28, 27, 0)
        '
        'FNacLbl
        '
        Me.FNacLbl.AutoSize = True
        Me.FNacLbl.Location = New System.Drawing.Point(6, 82)
        Me.FNacLbl.Name = "FNacLbl"
        Me.FNacLbl.Size = New System.Drawing.Size(111, 13)
        Me.FNacLbl.TabIndex = 1002
        Me.FNacLbl.Text = "Fecha de Nacimiento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(230, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "-"
        '
        'RutLbl
        '
        Me.RutLbl.AutoSize = True
        Me.RutLbl.Location = New System.Drawing.Point(6, 56)
        Me.RutLbl.Name = "RutLbl"
        Me.RutLbl.Size = New System.Drawing.Size(42, 13)
        Me.RutLbl.TabIndex = 1001
        Me.RutLbl.Text = "R.U.T.:"
        '
        'NombreLbl
        '
        Me.NombreLbl.AutoSize = True
        Me.NombreLbl.Location = New System.Drawing.Point(6, 30)
        Me.NombreLbl.Name = "NombreLbl"
        Me.NombreLbl.Size = New System.Drawing.Size(47, 13)
        Me.NombreLbl.TabIndex = 1000
        Me.NombreLbl.Text = "Nombre:"
        '
        'DatosCursoGBx
        '
        Me.DatosCursoGBx.Controls.Add(Me.Label1)
        Me.DatosCursoGBx.Controls.Add(Me.CuposTxtLbl)
        Me.DatosCursoGBx.Controls.Add(Me.CuposLbl)
        Me.DatosCursoGBx.Controls.Add(Me.Label)
        Me.DatosCursoGBx.Controls.Add(Me.DiasGBx)
        Me.DatosCursoGBx.Controls.Add(Me.HraPracticaCbBx)
        Me.DatosCursoGBx.Controls.Add(Me.HraPractica)
        Me.DatosCursoGBx.Controls.Add(Me.HraTeoriaCbBx)
        Me.DatosCursoGBx.Controls.Add(Me.HraTeoria)
        Me.DatosCursoGBx.Controls.Add(Me.CursoCbBx)
        Me.DatosCursoGBx.Controls.Add(Me.CursoLbl)
        Me.DatosCursoGBx.Controls.Add(Me.ProductoCbBx)
        Me.DatosCursoGBx.Controls.Add(Me.ProductoLbl)
        Me.DatosCursoGBx.Location = New System.Drawing.Point(12, 242)
        Me.DatosCursoGBx.Name = "DatosCursoGBx"
        Me.DatosCursoGBx.Size = New System.Drawing.Size(408, 173)
        Me.DatosCursoGBx.TabIndex = 2
        Me.DatosCursoGBx.TabStop = False
        Me.DatosCursoGBx.Text = "Datos del Curso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Hrs."
        '
        'CuposTxtLbl
        '
        Me.CuposTxtLbl.AutoSize = True
        Me.CuposTxtLbl.Location = New System.Drawing.Point(370, 30)
        Me.CuposTxtLbl.Name = "CuposTxtLbl"
        Me.CuposTxtLbl.Size = New System.Drawing.Size(23, 13)
        Me.CuposTxtLbl.TabIndex = 28
        Me.CuposTxtLbl.Text = "NN"
        '
        'CuposLbl
        '
        Me.CuposLbl.AutoSize = True
        Me.CuposLbl.Location = New System.Drawing.Point(329, 30)
        Me.CuposLbl.Name = "CuposLbl"
        Me.CuposLbl.Size = New System.Drawing.Size(40, 13)
        Me.CuposLbl.TabIndex = 27
        Me.CuposLbl.Text = "Cupos:"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(218, 84)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(26, 13)
        Me.Label.TabIndex = 26
        Me.Label.Text = "Hrs."
        '
        'DiasGBx
        '
        Me.DiasGBx.Controls.Add(Me.LuSaRaBtn)
        Me.DiasGBx.Controls.Add(Me.LuViRaBtn)
        Me.DiasGBx.Enabled = False
        Me.DiasGBx.Location = New System.Drawing.Point(9, 108)
        Me.DiasGBx.Name = "DiasGBx"
        Me.DiasGBx.Size = New System.Drawing.Size(393, 51)
        Me.DiasGBx.TabIndex = 4
        Me.DiasGBx.TabStop = False
        Me.DiasGBx.Text = "Días"
        '
        'LuSaRaBtn
        '
        Me.LuSaRaBtn.AutoSize = True
        Me.LuSaRaBtn.Location = New System.Drawing.Point(232, 21)
        Me.LuSaRaBtn.Name = "LuSaRaBtn"
        Me.LuSaRaBtn.Size = New System.Drawing.Size(100, 17)
        Me.LuSaRaBtn.TabIndex = 1
        Me.LuSaRaBtn.TabStop = True
        Me.LuSaRaBtn.Text = "Lunes - Sábado"
        Me.LuSaRaBtn.UseVisualStyleBackColor = True
        '
        'LuViRaBtn
        '
        Me.LuViRaBtn.AutoSize = True
        Me.LuViRaBtn.Location = New System.Drawing.Point(48, 21)
        Me.LuViRaBtn.Name = "LuViRaBtn"
        Me.LuViRaBtn.Size = New System.Drawing.Size(101, 17)
        Me.LuViRaBtn.TabIndex = 0
        Me.LuViRaBtn.TabStop = True
        Me.LuViRaBtn.Text = "Lunes  - Viernes"
        Me.LuViRaBtn.UseVisualStyleBackColor = True
        '
        'HraPracticaCbBx
        '
        Me.HraPracticaCbBx.AutoCompleteCustomSource.AddRange(New String() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado"})
        Me.HraPracticaCbBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.HraPracticaCbBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.HraPracticaCbBx.Enabled = False
        Me.HraPracticaCbBx.FormattingEnabled = True
        Me.HraPracticaCbBx.Items.AddRange(New Object() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado"})
        Me.HraPracticaCbBx.Location = New System.Drawing.Point(124, 81)
        Me.HraPracticaCbBx.Name = "HraPracticaCbBx"
        Me.HraPracticaCbBx.Size = New System.Drawing.Size(88, 21)
        Me.HraPracticaCbBx.TabIndex = 3
        '
        'HraPractica
        '
        Me.HraPractica.AutoSize = True
        Me.HraPractica.Location = New System.Drawing.Point(6, 84)
        Me.HraPractica.Name = "HraPractica"
        Me.HraPractica.Size = New System.Drawing.Size(86, 13)
        Me.HraPractica.TabIndex = 21
        Me.HraPractica.Text = "Horario Práctica:"
        '
        'HraTeoriaCbBx
        '
        Me.HraTeoriaCbBx.Enabled = False
        Me.HraTeoriaCbBx.FormattingEnabled = True
        Me.HraTeoriaCbBx.Location = New System.Drawing.Point(124, 54)
        Me.HraTeoriaCbBx.Name = "HraTeoriaCbBx"
        Me.HraTeoriaCbBx.Size = New System.Drawing.Size(88, 21)
        Me.HraTeoriaCbBx.TabIndex = 2
        '
        'HraTeoria
        '
        Me.HraTeoria.AutoSize = True
        Me.HraTeoria.Location = New System.Drawing.Point(6, 57)
        Me.HraTeoria.Name = "HraTeoria"
        Me.HraTeoria.Size = New System.Drawing.Size(79, 13)
        Me.HraTeoria.TabIndex = 19
        Me.HraTeoria.Text = "Horario Teoría:"
        '
        'CursoCbBx
        '
        Me.CursoCbBx.Enabled = False
        Me.CursoCbBx.FormattingEnabled = True
        Me.CursoCbBx.Location = New System.Drawing.Point(261, 27)
        Me.CursoCbBx.Name = "CursoCbBx"
        Me.CursoCbBx.Size = New System.Drawing.Size(62, 21)
        Me.CursoCbBx.TabIndex = 1
        '
        'CursoLbl
        '
        Me.CursoLbl.AutoSize = True
        Me.CursoLbl.Location = New System.Drawing.Point(218, 30)
        Me.CursoLbl.Name = "CursoLbl"
        Me.CursoLbl.Size = New System.Drawing.Size(37, 13)
        Me.CursoLbl.TabIndex = 17
        Me.CursoLbl.Text = "Curso:"
        '
        'ProductoCbBx
        '
        Me.ProductoCbBx.FormattingEnabled = True
        Me.ProductoCbBx.Location = New System.Drawing.Point(124, 27)
        Me.ProductoCbBx.Name = "ProductoCbBx"
        Me.ProductoCbBx.Size = New System.Drawing.Size(88, 21)
        Me.ProductoCbBx.TabIndex = 0
        '
        'ProductoLbl
        '
        Me.ProductoLbl.AutoSize = True
        Me.ProductoLbl.Location = New System.Drawing.Point(6, 30)
        Me.ProductoLbl.Name = "ProductoLbl"
        Me.ProductoLbl.Size = New System.Drawing.Size(50, 13)
        Me.ProductoLbl.TabIndex = 15
        Me.ProductoLbl.Text = "Licencia:"
        '
        'DatosPagoGBx
        '
        Me.DatosPagoGBx.Controls.Add(Me.CodPagoLbl)
        Me.DatosPagoGBx.Controls.Add(Me.CodPagoTxBx)
        Me.DatosPagoGBx.Controls.Add(Me.PagoRealizChBx)
        Me.DatosPagoGBx.Controls.Add(Me.MedioPagoChBx)
        Me.DatosPagoGBx.Controls.Add(Me.DocPagoCbBx)
        Me.DatosPagoGBx.Controls.Add(Me.APagarTxtLbl)
        Me.DatosPagoGBx.Controls.Add(Me.Label25)
        Me.DatosPagoGBx.Controls.Add(Me.DctoSpinBx)
        Me.DatosPagoGBx.Controls.Add(Me.ValorTxtLbl)
        Me.DatosPagoGBx.Controls.Add(Me.DctoLbl)
        Me.DatosPagoGBx.Controls.Add(Me.MedioPagoLbl)
        Me.DatosPagoGBx.Controls.Add(Me.DocPagoLbl)
        Me.DatosPagoGBx.Controls.Add(Me.APagarLbl)
        Me.DatosPagoGBx.Controls.Add(Me.ValorLbl)
        Me.DatosPagoGBx.Location = New System.Drawing.Point(427, 206)
        Me.DatosPagoGBx.Name = "DatosPagoGBx"
        Me.DatosPagoGBx.Size = New System.Drawing.Size(259, 209)
        Me.DatosPagoGBx.TabIndex = 4
        Me.DatosPagoGBx.TabStop = False
        Me.DatosPagoGBx.Text = "Pago"
        '
        'CodPagoLbl
        '
        Me.CodPagoLbl.AutoSize = True
        Me.CodPagoLbl.Location = New System.Drawing.Point(7, 186)
        Me.CodPagoLbl.Name = "CodPagoLbl"
        Me.CodPagoLbl.Size = New System.Drawing.Size(86, 13)
        Me.CodPagoLbl.TabIndex = 14
        Me.CodPagoLbl.Text = "Código de Pago:"
        '
        'CodPagoTxBx
        '
        Me.CodPagoTxBx.Enabled = False
        Me.CodPagoTxBx.Location = New System.Drawing.Point(128, 183)
        Me.CodPagoTxBx.MaxLength = 6
        Me.CodPagoTxBx.Name = "CodPagoTxBx"
        Me.CodPagoTxBx.Size = New System.Drawing.Size(125, 20)
        Me.CodPagoTxBx.TabIndex = 4
        '
        'PagoRealizChBx
        '
        Me.PagoRealizChBx.AutoSize = True
        Me.PagoRealizChBx.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PagoRealizChBx.Location = New System.Drawing.Point(6, 160)
        Me.PagoRealizChBx.Name = "PagoRealizChBx"
        Me.PagoRealizChBx.Size = New System.Drawing.Size(189, 17)
        Me.PagoRealizChBx.TabIndex = 3
        Me.PagoRealizChBx.Text = "Pago realizado:                              "
        Me.PagoRealizChBx.UseVisualStyleBackColor = True
        '
        'MedioPagoChBx
        '
        Me.MedioPagoChBx.FormattingEnabled = True
        Me.MedioPagoChBx.Location = New System.Drawing.Point(128, 134)
        Me.MedioPagoChBx.Name = "MedioPagoChBx"
        Me.MedioPagoChBx.Size = New System.Drawing.Size(125, 21)
        Me.MedioPagoChBx.TabIndex = 2
        '
        'DocPagoCbBx
        '
        Me.DocPagoCbBx.AutoCompleteCustomSource.AddRange(New String() {"Boleta", "Factura"})
        Me.DocPagoCbBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DocPagoCbBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.DocPagoCbBx.FormattingEnabled = True
        Me.DocPagoCbBx.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.DocPagoCbBx.Location = New System.Drawing.Point(128, 105)
        Me.DocPagoCbBx.Name = "DocPagoCbBx"
        Me.DocPagoCbBx.Size = New System.Drawing.Size(125, 21)
        Me.DocPagoCbBx.TabIndex = 1
        '
        'APagarTxtLbl
        '
        Me.APagarTxtLbl.AutoSize = True
        Me.APagarTxtLbl.Location = New System.Drawing.Point(155, 84)
        Me.APagarTxtLbl.Name = "APagarTxtLbl"
        Me.APagarTxtLbl.Size = New System.Drawing.Size(45, 13)
        Me.APagarTxtLbl.TabIndex = 9
        Me.APagarTxtLbl.Text = "Label26"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(206, 58)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(15, 13)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "%"
        '
        'DctoSpinBx
        '
        Me.DctoSpinBx.Location = New System.Drawing.Point(158, 56)
        Me.DctoSpinBx.Name = "DctoSpinBx"
        Me.DctoSpinBx.Size = New System.Drawing.Size(42, 20)
        Me.DctoSpinBx.TabIndex = 0
        '
        'ValorTxtLbl
        '
        Me.ValorTxtLbl.AutoSize = True
        Me.ValorTxtLbl.Location = New System.Drawing.Point(156, 30)
        Me.ValorTxtLbl.Name = "ValorTxtLbl"
        Me.ValorTxtLbl.Size = New System.Drawing.Size(31, 13)
        Me.ValorTxtLbl.TabIndex = 6
        Me.ValorTxtLbl.Text = "$$$$"
        '
        'DctoLbl
        '
        Me.DctoLbl.AutoSize = True
        Me.DctoLbl.Location = New System.Drawing.Point(6, 56)
        Me.DctoLbl.Name = "DctoLbl"
        Me.DctoLbl.Size = New System.Drawing.Size(62, 13)
        Me.DctoLbl.TabIndex = 4
        Me.DctoLbl.Text = "Descuento:"
        '
        'MedioPagoLbl
        '
        Me.MedioPagoLbl.AutoSize = True
        Me.MedioPagoLbl.Location = New System.Drawing.Point(7, 134)
        Me.MedioPagoLbl.Name = "MedioPagoLbl"
        Me.MedioPagoLbl.Size = New System.Drawing.Size(82, 13)
        Me.MedioPagoLbl.TabIndex = 3
        Me.MedioPagoLbl.Text = "Medio de Pago:"
        '
        'DocPagoLbl
        '
        Me.DocPagoLbl.AutoSize = True
        Me.DocPagoLbl.Location = New System.Drawing.Point(6, 108)
        Me.DocPagoLbl.Name = "DocPagoLbl"
        Me.DocPagoLbl.Size = New System.Drawing.Size(108, 13)
        Me.DocPagoLbl.TabIndex = 2
        Me.DocPagoLbl.Text = "Documento de Pago:"
        '
        'APagarLbl
        '
        Me.APagarLbl.AutoSize = True
        Me.APagarLbl.Location = New System.Drawing.Point(6, 82)
        Me.APagarLbl.Name = "APagarLbl"
        Me.APagarLbl.Size = New System.Drawing.Size(80, 13)
        Me.APagarLbl.TabIndex = 1
        Me.APagarLbl.Text = "Monto a Pagar:"
        '
        'ValorLbl
        '
        Me.ValorLbl.AutoSize = True
        Me.ValorLbl.Location = New System.Drawing.Point(6, 30)
        Me.ValorLbl.Name = "ValorLbl"
        Me.ValorLbl.Size = New System.Drawing.Size(81, 13)
        Me.ValorLbl.TabIndex = 0
        Me.ValorLbl.Text = "Valor del Curso:"
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Location = New System.Drawing.Point(611, 421)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(75, 23)
        Me.GuardarBtn.TabIndex = 5
        Me.GuardarBtn.Text = "Guardar"
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'DocumentosGbx
        '
        Me.DocumentosGbx.Controls.Add(Me.FotosChBx)
        Me.DocumentosGbx.Controls.Add(Me.CertNotarialChBx)
        Me.DocumentosGbx.Controls.Add(Me.CertEstudiosChBx)
        Me.DocumentosGbx.Controls.Add(Me.FotocopiaLicenciaChBx)
        Me.DocumentosGbx.Controls.Add(Me.FotocopiaCIChBx)
        Me.DocumentosGbx.Location = New System.Drawing.Point(427, 38)
        Me.DocumentosGbx.Name = "DocumentosGbx"
        Me.DocumentosGbx.Size = New System.Drawing.Size(253, 162)
        Me.DocumentosGbx.TabIndex = 3
        Me.DocumentosGbx.TabStop = False
        Me.DocumentosGbx.Text = "Documentos"
        '
        'FotosChBx
        '
        Me.FotosChBx.AutoSize = True
        Me.FotosChBx.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FotosChBx.Location = New System.Drawing.Point(10, 28)
        Me.FotosChBx.Name = "FotosChBx"
        Me.FotosChBx.Size = New System.Drawing.Size(184, 17)
        Me.FotosChBx.TabIndex = 0
        Me.FotosChBx.Text = "Fotos:                                           "
        Me.FotosChBx.UseVisualStyleBackColor = True
        '
        'CertNotarialChBx
        '
        Me.CertNotarialChBx.AutoSize = True
        Me.CertNotarialChBx.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CertNotarialChBx.Location = New System.Drawing.Point(6, 120)
        Me.CertNotarialChBx.Name = "CertNotarialChBx"
        Me.CertNotarialChBx.Size = New System.Drawing.Size(190, 17)
        Me.CertNotarialChBx.TabIndex = 4
        Me.CertNotarialChBx.Text = "Certificado Notarial:                        "
        Me.CertNotarialChBx.UseVisualStyleBackColor = True
        '
        'CertEstudiosChBx
        '
        Me.CertEstudiosChBx.AutoSize = True
        Me.CertEstudiosChBx.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CertEstudiosChBx.Location = New System.Drawing.Point(10, 97)
        Me.CertEstudiosChBx.Name = "CertEstudiosChBx"
        Me.CertEstudiosChBx.Size = New System.Drawing.Size(185, 17)
        Me.CertEstudiosChBx.TabIndex = 3
        Me.CertEstudiosChBx.Text = "Certificado Estudios:                     "
        Me.CertEstudiosChBx.UseVisualStyleBackColor = True
        '
        'FotocopiaLicenciaChBx
        '
        Me.FotocopiaLicenciaChBx.AutoSize = True
        Me.FotocopiaLicenciaChBx.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FotocopiaLicenciaChBx.Location = New System.Drawing.Point(10, 74)
        Me.FotocopiaLicenciaChBx.Name = "FotocopiaLicenciaChBx"
        Me.FotocopiaLicenciaChBx.Size = New System.Drawing.Size(185, 17)
        Me.FotocopiaLicenciaChBx.TabIndex = 2
        Me.FotocopiaLicenciaChBx.Text = "Fotocopia Licencia:                      "
        Me.FotocopiaLicenciaChBx.UseVisualStyleBackColor = True
        '
        'FotocopiaCIChBx
        '
        Me.FotocopiaCIChBx.AutoSize = True
        Me.FotocopiaCIChBx.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FotocopiaCIChBx.Location = New System.Drawing.Point(10, 51)
        Me.FotocopiaCIChBx.Name = "FotocopiaCIChBx"
        Me.FotocopiaCIChBx.Size = New System.Drawing.Size(185, 17)
        Me.FotocopiaCIChBx.TabIndex = 1
        Me.FotocopiaCIChBx.Text = "Fotocopia C.I.:                              "
        Me.FotocopiaCIChBx.UseVisualStyleBackColor = True
        '
        'NRegLbl
        '
        Me.NRegLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NRegLbl.AutoSize = True
        Me.NRegLbl.Location = New System.Drawing.Point(516, 15)
        Me.NRegLbl.Name = "NRegLbl"
        Me.NRegLbl.Size = New System.Drawing.Size(64, 13)
        Me.NRegLbl.TabIndex = 5
        Me.NRegLbl.Text = "N° Registro:"
        '
        'LimpiarBtn
        '
        Me.LimpiarBtn.Location = New System.Drawing.Point(12, 421)
        Me.LimpiarBtn.Name = "LimpiarBtn"
        Me.LimpiarBtn.Size = New System.Drawing.Size(75, 23)
        Me.LimpiarBtn.TabIndex = 6
        Me.LimpiarBtn.Text = "Limpiar"
        Me.LimpiarBtn.UseVisualStyleBackColor = True
        '
        'NRegCTxBx
        '
        Me.NRegCTxBx.Location = New System.Drawing.Point(580, 12)
        Me.NRegCTxBx.MaxLength = 6
        Me.NRegCTxBx.Name = "NRegCTxBx"
        Me.NRegCTxBx.Size = New System.Drawing.Size(100, 20)
        Me.NRegCTxBx.TabIndex = 0
        Me.NRegCTxBx.Tipo = ProyectoTodoTransportes.CustomTextBoxClass.TipoClase.ALPHA_NUMERIC
        '
        'QueryTb
        '
        Me.QueryTb.Location = New System.Drawing.Point(93, 429)
        Me.QueryTb.Name = "QueryTb"
        Me.QueryTb.Size = New System.Drawing.Size(512, 20)
        Me.QueryTb.TabIndex = 7
        '
        'Matricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 456)
        Me.Controls.Add(Me.QueryTb)
        Me.Controls.Add(Me.NRegCTxBx)
        Me.Controls.Add(Me.LimpiarBtn)
        Me.Controls.Add(Me.NRegLbl)
        Me.Controls.Add(Me.GuardarBtn)
        Me.Controls.Add(Me.DatosPagoGBx)
        Me.Controls.Add(Me.DatosCursoGBx)
        Me.Controls.Add(Me.DocumentosGbx)
        Me.Controls.Add(Me.DatosPersonalesGbx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Matricula"
        Me.Text = "Matricula"
        Me.DatosPersonalesGbx.ResumeLayout(False)
        Me.DatosPersonalesGbx.PerformLayout()
        Me.DatosCursoGBx.ResumeLayout(False)
        Me.DatosCursoGBx.PerformLayout()
        Me.DiasGBx.ResumeLayout(False)
        Me.DiasGBx.PerformLayout()
        Me.DatosPagoGBx.ResumeLayout(False)
        Me.DatosPagoGBx.PerformLayout()
        CType(Me.DctoSpinBx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentosGbx.ResumeLayout(False)
        Me.DocumentosGbx.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatosPersonalesGbx As System.Windows.Forms.GroupBox
    Friend WithEvents FNacLbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RutLbl As System.Windows.Forms.Label
    Friend WithEvents NombreLbl As System.Windows.Forms.Label
    Friend WithEvents DatosCursoGBx As System.Windows.Forms.GroupBox
    Friend WithEvents DatosPagoGBx As System.Windows.Forms.GroupBox
    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
    Friend WithEvents ClienteCbBx As System.Windows.Forms.ComboBox
    Friend WithEvents ClienteLbl As System.Windows.Forms.Label
    Friend WithEvents DVCTxBx As ProyectoTodoTransportes.CustomTextBoxClass
    Friend WithEvents RutCTxBx As ProyectoTodoTransportes.CustomTextBoxClass
    Friend WithEvents TelCTxBx As ProyectoTodoTransportes.CustomTextBoxClass
    Friend WithEvents TelefonoLbl As System.Windows.Forms.Label
    Friend WithEvents FNacDTiPckr As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProductoCbBx As System.Windows.Forms.ComboBox
    Friend WithEvents ProductoLbl As System.Windows.Forms.Label
    Friend WithEvents CursoCbBx As System.Windows.Forms.ComboBox
    Friend WithEvents CursoLbl As System.Windows.Forms.Label
    Friend WithEvents EmailCTxBx As ProyectoTodoTransportes.CustomTextBoxClass
    Friend WithEvents EmailLbl As System.Windows.Forms.Label
    Friend WithEvents HraTeoriaCbBx As System.Windows.Forms.ComboBox
    Friend WithEvents HraTeoria As System.Windows.Forms.Label
    Friend WithEvents DiasGBx As System.Windows.Forms.GroupBox
    Friend WithEvents LuSaRaBtn As System.Windows.Forms.RadioButton
    Friend WithEvents LuViRaBtn As System.Windows.Forms.RadioButton
    Friend WithEvents HraPracticaCbBx As System.Windows.Forms.ComboBox
    Friend WithEvents HraPractica As System.Windows.Forms.Label
    Friend WithEvents DocumentosGbx As System.Windows.Forms.GroupBox
    Friend WithEvents DctoLbl As System.Windows.Forms.Label
    Friend WithEvents MedioPagoLbl As System.Windows.Forms.Label
    Friend WithEvents DocPagoLbl As System.Windows.Forms.Label
    Friend WithEvents APagarLbl As System.Windows.Forms.Label
    Friend WithEvents ValorLbl As System.Windows.Forms.Label
    Friend WithEvents FotosChBx As System.Windows.Forms.CheckBox
    Friend WithEvents CertNotarialChBx As System.Windows.Forms.CheckBox
    Friend WithEvents CertEstudiosChBx As System.Windows.Forms.CheckBox
    Friend WithEvents FotocopiaLicenciaChBx As System.Windows.Forms.CheckBox
    Friend WithEvents FotocopiaCIChBx As System.Windows.Forms.CheckBox
    Friend WithEvents NRegLbl As System.Windows.Forms.Label
    Friend WithEvents ValorTxtLbl As System.Windows.Forms.Label
    Friend WithEvents CodPagoLbl As System.Windows.Forms.Label
    Friend WithEvents CodPagoTxBx As System.Windows.Forms.TextBox
    Friend WithEvents PagoRealizChBx As System.Windows.Forms.CheckBox
    Friend WithEvents MedioPagoChBx As System.Windows.Forms.ComboBox
    Friend WithEvents DocPagoCbBx As System.Windows.Forms.ComboBox
    Friend WithEvents APagarTxtLbl As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents DctoSpinBx As System.Windows.Forms.NumericUpDown
    Friend WithEvents LimpiarBtn As System.Windows.Forms.Button
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents CuposTxtLbl As System.Windows.Forms.Label
    Friend WithEvents CuposLbl As System.Windows.Forms.Label
    Friend WithEvents NombreCTxBx As ProyectoTodoTransportes.CustomTextBoxClass
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NRegCTxBx As ProyectoTodoTransportes.CustomTextBoxClass
    Friend WithEvents QueryTb As System.Windows.Forms.TextBox
End Class
