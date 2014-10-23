Public Class Principal

    Dim con As Conexion = New Conexion
    Dim USER As String = ""

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'CARGAR COMBOBOX cursos
        Dim n As Integer
        n = con.registrosEnCURSO - 1
        Dim cursos(n) As String
        cursos = con.cursosToArray(n)
        For i As Integer = 0 To n
            cbox_CursoInteres1.Items.Add(cursos(i))
            cbox_CursoRendir2.Items.Add(cursos(i))
        Next
        cbox_CursoInteres1.SelectedIndex = 0
        cbox_CursoRendir2.SelectedIndex = 0

        'Carga el tamaño de la primera pestaña que se muestra
        TabControl.Size = New System.Drawing.Size(451, 294)
        Me.Size = New System.Drawing.Size(485, 351)

        'CARGAR COMBOBOX teoria'
        Dim m As Integer
        m = con.registrosTeorico - 1
        Dim teo(m) As String
        teo = con.teoricoToArray(m)
        For i As Integer = 0 To m
            cbox_Teorico2.Items.Add(teo(i))
        Next
        cbox_Teorico2.SelectedIndex = 0

        'CARGAR COMBOBOX practica'
        Dim k As Integer
        k = con.registrosPractico - 1
        Dim pract(k) As String
        pract = con.practicoToArray(k)
        For i As Integer = 0 To k
            cbox_Practico2.Items.Add(pract(i))
        Next
        cbox_Practico2.SelectedIndex = 0

        'CARGAR COMBOBOX medio pago
        Dim f As Integer
        f = con.registrosMedio - 1
        Dim medio(k) As String
        medio = con.MedioToArray(f)
        For i As Integer = 0 To f
            cbox_MedioPago2.Items.Add(medio(i))
        Next
        cbox_MedioPago2.SelectedIndex = 0

    End Sub

    Sub New(ByVal Usuario As String)
        USER = Usuario
        InitializeComponent()
    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged

        Dim tab As Integer = TabControl.SelectedIndex
        Me.CambiaTamaño(tab)    

    End Sub

    Sub CambiaTamaño(ByVal tab)

        'Al cambiar de pestaña ajusta el tamaño de la ventana

        If tab = 0 Then
            TabControl.Size = New System.Drawing.Size(451, 294)
            Me.Size = New System.Drawing.Size(485, 351)
        ElseIf tab = 1 Then
            TabControl.Size = New System.Drawing.Size(482, 444)
            Me.Size = New System.Drawing.Size(516, 501)
        ElseIf tab = 2 Then
            TabControl.Size = New System.Drawing.Size(416, 485)
            Me.Size = New System.Drawing.Size(449, 541)
        ElseIf tab = 3 Then
            TabControl.Size = New System.Drawing.Size(420, 213)
            Me.Size = New System.Drawing.Size(455, 270)
        End If
    End Sub

    Private Sub btn_Guardar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar1.Click

        'MANEJA EL BOTÓN GUARDAR

        If tbox_Telefono1.Text.Trim.Equals("") Then tbox_Telefono1.Text = "0"
        If tbox_Nombre1.Text.Trim.Equals("") Then
            lbl_Nombre1.ForeColor = Color.Red
        Else
            lbl_Nombre1.ForeColor = Color.DimGray
            Try

                con.registrarCliente(tbox_Nombre1.Text, CInt(tbox_Telefono1.Text), cbox_CursoInteres1.Text,
                                 Format(date_Fecha1.Value, "yyyy-MM-dd"), tbox_Observaciones1.Text, USER)

            Catch ex As Exception

                'MOMENTANEO
                lbl_Mensaje1.ForeColor = Color.Red
                lbl_Mensaje1.Text = "ERROR!"

            Finally

                lbl_Mensaje1.ForeColor = Color.Blue
                lbl_Mensaje1.Text = "Operación realizada con éxito"

                'Resetea valores
                tbox_Nombre1.Text = ""
                tbox_Observaciones1.Text = ""
                tbox_Telefono1.Text = ""
                cbox_CursoInteres1.SelectedIndex = 0

            End Try

        End If

    End Sub
    
    Private Sub Tab3_Click(sender As System.Object, e As System.EventArgs) Handles Tab3.Click
        
        'Cargar combobox estudiantes'
        Dim n As Integer
        n = con.registrosMatricula - 1
        Dim est(n) As String
        est = con.estudiantesToArray(n)
        For i As Integer = 0 To n
            cbox_estvisual.Items.Add(est(i))
        Next
        cbox_estvisual.SelectedIndex = 0

        'Cargar combobox rut'
        Dim m As Integer
        m = con.registrosMatricula - 1
        Dim r(m) As String
        r = con.estudiantesToArray(m)
        For i As Integer = 0 To m
            cbox_estvisual.Items.Add(r(i))
        Next
        cbox_estvisual.SelectedIndex = 0
    End Sub

    Private Sub btn_Guardar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar2.Click

        Dim FotoCarnet As Boolean = check_Foto2.Checked()
        Dim CertificadoEstudios As Boolean = check_CertEstudios2.Checked()
        Dim CertificadoAlumnoRegular As Boolean = check_AlumnoReg2.Checked()
        Dim AntecedentesNotariales As Boolean = check_AntecedentesNot2.Checked()

        If tbox_Fono2.Text.Trim.Equals("") Then
            tbox_Fono2.Text = "0"
        End If

        If tbox_Nombres2.Text.Trim.Equals("") Then
            lbl_Nombres2.ForeColor = Color.Red
        ElseIf tbox_Apellidos2.Text.Trim.Equals("") Then
            lbl_Apellidos2.ForeColor = Color.Red
        ElseIf tbox_RUT2.Text.Trim.Equals("") Or tbox_VerificadorRut2.Text.Trim.Equals("") Then
            lbl_RUT2.ForeColor = Color.Red
        Else
            Dim rut As String = ""
            Dim real As Boolean = Herramientas.isRut(tbox_RUT2.Text, tbox_VerificadorRut2.Text)
            If real Then
                rut = tbox_RUT2.Text + tbox_VerificadorRut2.Text()
            Else
                MsgBox("RUT no concuerda")
            End If

            lbl_Nombres2.ForeColor = Color.DimGray
            lbl_Apellidos2.ForeColor = Color.DimGray
            lbl_RUT2.ForeColor = Color.DimGray

            Try
                con.RegistrarPago(CInt(tbox_PagoRealizado.Text), CInt(lbl_ValorCurso2.Text), cbox_MedioPago2.Text)

                con.RegistrarMatricula(tbox_Numero2.Text, tbox_Nombres2.Text, rut, CInt("25"),
                                Format(date_FechaAtencion2.Value, "yyyy-MM-dd"), CInt(tbox_Fono2.Text),
                                CInt(tbox_PagoRealizado.Text), cbox_CursoRendir2.Text, cbox_Teorico2.Text, cbox_Practico2.Text)
                'MOMENTANEO EDAD: FALTA METODO PARA CALCULARLA A PARTIR DE LA FECHA DE NACIMIENTO

                con.RegistrarEstudiante(tbox_Numero2.Text, FotoCarnet, CertificadoEstudios, CertificadoAlumnoRegular, AntecedentesNotariales)

            Catch ex As Exception

                MsgBox(ex.ToString)

            Finally

                MsgBox("Operación realizada con éxito")

                'Resetea valores
                tbox_Nombres2.Text = ""
                tbox_Apellidos2.Text = ""
                tbox_RUT2.Text = ""
                tbox_VerificadorRut2.Text = ""
                tbox_Fono2.Text = ""
                cbox_CursoRendir2.SelectedIndex = 0
                cbox_Practico2.SelectedIndex = 0
                cbox_Teorico2.SelectedIndex = 0
                cbox_MedioPago2.SelectedIndex = 0
                check_Foto2.Checked = False
                check_CertEstudios2.Checked = False
                check_AlumnoReg2.Checked = False
                check_AntecedentesNot2.Checked = False
                tbox_Numero2.Text = ""
                lbl_ValorCurso2.Text = ""
                tbox_PagoRealizado.Text = ""
            End Try
        End If
    End Sub

    Private Sub date_FechaAtencion2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles date_FechaAtencion2.ValueChanged
        Dim precio As Integer
        precio = con.buscarPago("25", cbox_CursoRendir2.Text)
        lbl_ValorCurso2.Text = CStr(precio)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

    End Sub

    Private Sub cbox_CursoRendir2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbox_CursoRendir2.SelectedIndexChanged

    End Sub
End Class