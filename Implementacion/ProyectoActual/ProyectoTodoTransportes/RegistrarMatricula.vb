Public Class RegistrarMatricula

    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub RegistrarMatricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CARGAR COMBOBOX cursointeres

        Dim items() As String
        Dim n As Integer

        n = con.count("Producto") - 1
        items = con.toArray(n, "Nombre", "Producto")
        For i As Integer = 0 To n
            cbox_CursoRendir.Items.Add(items(i))
        Next
        If n >= 0 Then cbox_CursoRendir.SelectedIndex = 0

        'CARGAR COMBOBOX teoria

        n = con.count("Teoria") - 1
        items = con.toArray(n, "Horario", "Teoria")
        For i As Integer = 0 To n
            cbox_HorarioTeorico.Items.Add(items(i))
        Next
        If n >= 0 Then cbox_HorarioTeorico.SelectedIndex = 0

        'CARGAR COMBOBOX practica

        'n = con.count("Teoria") - 1
        'pract = con.practicoToArray(k)
        'For i As Integer = 0 To k
        ' cbox_HorarioPractico.Items.Add(pract(i))
        ' Next
        'If n >= 0 Then cbox_HorarioPractico.SelectedIndex = 0

        'CARGAR COMBOBOX medio pago

        n = con.count("Medio_pago") - 1
        items = con.toArray(n, "Nombre", "Medio_pago")
        For i As Integer = 0 To n
            cbox_MedioPago.Items.Add(items(i))
        Next
        If n >= 0 Then cbox_MedioPago.SelectedIndex = 0

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

                'con.registrarpago'
                'con.registrarmatricula'
                'con.registrarestudiante'


                STATUS.Text = "Operación realizada con éxito"

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


#Region "Validacion de entrada"

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

#End Region

End Class