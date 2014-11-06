Public Class RegistrarMatricula

    Dim con As New Conexion
    Dim USER As String = ""

    Sub New(ByVal usuario As String, ByVal conexion As Conexion)
        con = conexion
        USER = usuario
        InitializeComponent()
    End Sub

    Private Sub RegistrarMatricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CARGAR COMBOXO cursointeres
        Dim n As Integer
        n = con.registrosEnCURSO - 1
        Dim cursos(n) As String
        cursos = con.cursosToArray(n)
        For i As Integer = 0 To n
            cbox_CursoRendir.Items.Add(cursos(i))
        Next
        cbox_CursoRendir.SelectedIndex = 0

        'CARGAR COMBOBOX teoria
        Dim m As Integer
        m = con.registrosTeorico - 1
        Dim teo(m) As String
        teo = con.teoricoToArray(m)
        For i As Integer = 0 To m
            cbox_HorarioTeorico.Items.Add(teo(i))
        Next
        cbox_HorarioTeorico.SelectedIndex = 0

        'CARGAR COMBOBOX practica
        Dim k As Integer
        k = con.registrosPractico - 1
        Dim pract(k) As String
        pract = con.practicoToArray(k)
        For i As Integer = 0 To k
            cbox_HorarioPractico.Items.Add(pract(i))
        Next
        cbox_HorarioPractico.SelectedIndex = 0

        'CARGAR COMBOBOX medio pago
        Dim f As Integer
        f = con.registrosMedio - 1
        Dim medio(k) As String
        medio = con.MedioToArray(f)
        For i As Integer = 0 To f
            cbox_MedioPago.Items.Add(medio(i))
        Next
        cbox_MedioPago.SelectedIndex = 0
    End Sub


    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        Dim FotoCarnet As Boolean = check_Foto.Checked()
        Dim CertificadoEstudios As Boolean = check_CertEstudios.Checked()
        Dim CertificadoAlumnoRegular As Boolean = check_AlumnoReg.Checked()
        Dim AntecedentesNotariales As Boolean = check_AntecedentesNot.Checked()

        If tbox_Telefono.Text.Trim.Equals("") Then
            tbox_Telefono.Text = "0"
        End If

        If tbox_Nombre.Text.Trim.Equals("") Then
            lbl_Nombre.ForeColor = Color.Red
        ElseIf tbox_RUT.Text.Trim.Equals("") Or tbox_VerificadorRUT.Text.Trim.Equals("") Then
            lbl_RUT.ForeColor = Color.Red
        Else
            Dim rut As String = ""
            Dim isreal As Boolean = Herramientas.isRut(tbox_RUT.Text, tbox_VerificadorRUT.Text)
            If isreal Then
                rut = tbox_RUT.Text + tbox_VerificadorRUT.Text
            Else
                MsgBox("RUT no concuerda")
            End If

            lbl_Nombre.ForeColor = System.Drawing.SystemColors.ControlText
            lbl_RUT.ForeColor = System.Drawing.SystemColors.ControlText

            Try
                con.RegistrarPago(CInt(tbox_PagoRealizado.Text), CInt(lbl_ValorCurso2.Text), cbox_MedioPago.Text)

                con.RegistrarMatricula(tbox_codigo.Text, tbox_Nombre.Text, rut, Herramientas.edadPorNacimiento(Format(date_FechaNacimiento.Value, "yyyy-MM-dd")),
                                Format(date_FechaNacimiento.Value, "yyyy-MM-dd"), CInt(tbox_Telefono.Text),
                                CInt(tbox_PagoRealizado.Text), cbox_CursoRendir.Text, cbox_HorarioTeorico.Text, cbox_HorarioPractico.Text)

                con.RegistrarEstudiante(tbox_codigo.Text, FotoCarnet, CertificadoEstudios, CertificadoAlumnoRegular, AntecedentesNotariales)

                MsgBox("Operación realizada con éxito")

                'Resetea valores
                tbox_Nombre.Text = ""
                tbox_RUT.Text = ""
                tbox_VerificadorRUT.Text = ""
                tbox_Telefono.Text = ""
                cbox_CursoRendir.SelectedIndex = 0
                cbox_HorarioPractico.SelectedIndex = 0
                cbox_HorarioTeorico.SelectedIndex = 0
                cbox_MedioPago.SelectedIndex = 0
                check_Foto.Checked = False
                check_CertEstudios.Checked = False
                check_AlumnoReg.Checked = False
                check_AntecedentesNot.Checked = False
                tbox_codigo.Text = ""
                lbl_ValorCurso2.Text = ""
                tbox_PagoRealizado.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub

    Private Sub date_FechaNacimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles date_FechaNacimiento.ValueChanged
        Dim precio As Integer
        precio = con.buscarPago(Herramientas.edadPorNacimiento(Format(date_FechaNacimiento.Value, "yyyy-MM-dd")), cbox_CursoRendir.Text)
        lbl_ValorCurso2.Text = CStr(precio)
    End Sub


    Private Sub tbox_RUT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_RUT.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

    Private Sub tbox_VerificadorRut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_VerificadorRUT.KeyPress
        Herramientas.textoDeseado(e, "0123456789Kk")
    End Sub

    Private Sub tbox_Fono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_Telefono.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

    Private Sub tbox_PagoRealizado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_PagoRealizado.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

    Private Sub tbox_Nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_Nombre.KeyPress
        Herramientas.soloTexto(e)
    End Sub


End Class