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

        cargaCBOX("Licencia")
        cargaCBOX("Producto")
        cargaCBOX("Curso")
        cargaCBOX("Horario Práctico")
        cargaCBOX("Horario Teórico")
        cargaCBOX("Medio Pago")

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        
        If validar() Then

            Dim fechaActual As String = Format(Date.Now, "yyyy-MM-dd")
            Dim bool_fotos As Boolean = check_Foto.Checked()
            Dim bool_certEst As Boolean = check_CertEstudios.Checked()
            Dim bool_certAlreg As Boolean = check_AlumnoReg.Checked()
            Dim bool_antNot As Boolean = check_AntecedentesNot.Checked()
            Dim RUT As String = tbox_RUT.Text + tbox_VerificadorRUT.Text
            Dim Nombre As String = tbox_Nombre.Text
            Dim fechaNac As String = Format(date_FechaNacimiento.Value, "yyyy-MM-dd")
            Dim Telefono As Integer = CInt(tbox_Telefono.Text)
            Dim Email As String = tbox_Email.Text
            Dim Curso As String = cbox_Curso.Text
            Dim cant_Fotos As Integer
            If bool_fotos Then cant_Fotos = CInt(tbox_cant.Text) Else cant_Fotos = 0
            Dim MedioPago As String = cbox_MedioPago.Text
            Dim codigoPago As String = tbox_PagoRealizado.Text
            Dim codigo As String = tbox_codigo.Text
            Dim edad As Integer = Herramientas.edadPorNacimiento(fechaNac)
            Dim H_teorico As String = cbox_HorarioTeorico.Text
            Dim H_practico As String = cbox_HorarioPractico.Text

            Dim aux_str1, aux_str2, aux_str3 As String

            Try
                con.regCliente(Nombre, RUT, fechaNac, Telefono, Email)

                aux_str1 = con.last("idCliente", "Cliente")
                con.regCompra(aux_str1, Curso, fechaActual)

                aux_str1 = con.last("Cliente", "Compra")
                con.regPago(codigoPago, 0, MedioPago, aux_str1, fechaActual)
                'Monto de pago es 0 mientras tanto

                con.regEstudiante(cant_Fotos, bool_certEst, bool_certAlreg, bool_antNot)
                
                aux_str1 = con.last("idEstudiante", "Estudiante")
                'con.regDocumento(aux_str1)

                aux_str2 = con.last("idCompra", "Compra")
                aux_str3 = con.last("idDocumento", "Documento")

                con.regMatricula(codigo, Nombre, RUT, edad, fechaActual, Telefono, aux_str2, Curso, H_teorico, H_practico, aux_str3, aux_str1)

                STATUS.Text = "Operación realizada con éxito"
                reset()

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
                STATUS.Text = "Operación fallida."
            End Try

        End If
    End Sub

#Region "Metodos"

    Sub cargaCBOX(ByVal Nombre As String)
        Dim items() As String
        Dim n As Integer

        If Nombre.Equals("Curso") Then

            cbox_Curso.Items.Clear()
            n = con.countWhere("Curso", "Producto = '" & cbox_Producto.Text & "'") - 1
            items = con.toArrayWhere(n, "Codigo", "Curso", "Producto = '" & cbox_Producto.Text & "'")
            For i As Integer = 0 To n
                cbox_Curso.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_Curso.SelectedIndex = 0

        ElseIf Nombre.Equals("Licencia") Then

            cbox_Licencia.Items.Clear()
            n = con.count("Area") - 1
            items = con.toArray(n, "Nombre", "Area")
            For i As Integer = 0 To n
                cbox_Licencia.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_Licencia.SelectedIndex = 0
            If con.countWhere("Producto", "Area = 'Otros'") = 0 Then cbox_Licencia.Items.Remove("Otros")

        ElseIf Nombre.Equals("Horario Práctico") Then

            cbox_HorarioPractico.Items.Clear()
            n = con.countWhere("Practica", "Clase = '" & cbox_Curso.Text & "'") - 1
            items = con.toArrayWhere(n, "Horario", "Practica", "Clase = '" & cbox_Curso.Text & "'")
            For i As Integer = 0 To n
                cbox_HorarioPractico.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_HorarioPractico.SelectedIndex = 0

        ElseIf Nombre.Equals("Horario Teórico") Then

            cbox_HorarioTeorico.Items.Clear()
            n = con.countWhere("Teoria", "Clase = '" & cbox_Curso.Text & "'") - 1
            items = con.toArrayWhere(n, "Horario", "Teoria", "Clase = '" & cbox_Curso.Text & "'")
            For i As Integer = 0 To n
                cbox_HorarioTeorico.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_HorarioTeorico.SelectedIndex = 0

        ElseIf Nombre.Equals("Medio Pago") Then

            cbox_MedioPago.Items.Clear()
            n = con.count("Medio_pago") - 1
            items = con.toArray(n, "Nombre", "Medio_pago")
            For i As Integer = 0 To n
                cbox_MedioPago.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_MedioPago.SelectedIndex = 0

        ElseIf Nombre.Equals("Producto") Then

            cbox_Producto.Items.Clear()
            n = con.countWhere("Producto", "Area = '" & cbox_Licencia.Text & "'") - 1
            items = con.toArrayWhere(n, "Nombre", "Producto", "Area = '" & cbox_Licencia.Text & "'")
            For i As Integer = 0 To n
                cbox_Producto.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_Producto.SelectedIndex = 0

        End If
    End Sub

    Sub reset()
        tbox_Nombre.Text = ""
        tbox_RUT.Text = ""
        tbox_VerificadorRUT.Text = ""
        tbox_Telefono.Text = ""
        cbox_Licencia.SelectedIndex = 0
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
    End Sub

    Function validar() As Boolean

        If tbox_Telefono.Text.Trim.Equals("") Then tbox_Telefono.Text = "0"

        If tbox_Nombre.Text.Trim.Equals("") Then
            STATUS.Text = "Ingrese los datos para continuar."
            Return False
        ElseIf tbox_RUT.Text.Trim.Equals("") Or tbox_VerificadorRUT.Text.Trim.Equals("") Then
            STATUS.Text = "Ingrese los datos para continuar."
            Return False
        Else
            Dim rut As String = ""
            Dim rut_valido As Boolean = Herramientas.isRut(tbox_RUT.Text, tbox_VerificadorRUT.Text)
            If rut_valido = False Then
                STATUS.Text = "RUT ingresado no es valido."
                Return False
            End If
        End If

        Return True
    End Function

#End Region

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

    Private Sub cbox_Licencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbox_Licencia.SelectedIndexChanged
        cargaCBOX("Producto")
        cargaCBOX("Curso")
        cargaCBOX("Horario Práctico")
        cargaCBOX("Horario Teórico")

    End Sub

    Private Sub cbox_Curso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbox_Curso.SelectedIndexChanged

        cargaCBOX("Horario Práctico")
        cargaCBOX("Horario Teórico")

    End Sub

    Private Sub check_Foto_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_Foto.CheckedChanged
        If check_Foto.Checked Then tbox_cant.Enabled = True Else tbox_cant.Enabled = False
    End Sub

    Private Sub cbox_Producto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbox_Producto.SelectedIndexChanged
        cargaCBOX("Curso")
        cargaCBOX("Horario Práctico")
        cargaCBOX("Horario Teórico")
    End Sub
End Class