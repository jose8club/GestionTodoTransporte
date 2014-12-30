Public Class CambioRueda
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim datacbox As DataCBOX
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        datacbox = New DataCBOX(con)
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub CambioRueda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Funcionario")
        loadCBOX("Matricula")


    End Sub

#Region "Metodos"
    Sub loadCBOX(ByVal Nombre As String)
        If Nombre.Equals("Funcionario") Then
            cbox_funcionario.DataSource = datacbox.Funcionarios
            cbox_funcionario.DisplayMember = "Nombre"
            cbox_funcionario.ValueMember = "Nombre"
            cbox_funcionario.SelectedIndex = -1
        ElseIf Nombre.Equals("Matricula") Then
            cbox_matricula.DataSource = datacbox.Estudiantes
            cbox_matricula.DisplayMember = "idEstudiante"
            cbox_matricula.ValueMember = "idEstudiante"
            cbox_matricula.SelectedIndex = -1
        End If

    End Sub
    Function validar() As Boolean

        If cbox_matricula.Text = "" Then
            MsgBox("Ingrese datos de matricula")
            Return False
        ElseIf cbox_funcionario.Text = "" Then
            MsgBox("Ingrese datos de funcionario")
            Return False
        ElseIf CInt(sbox_hor1.Text) <> 10 And CInt(sbox_hor1.Text) <> 12 And CInt(sbox_hor1.Text) <> 17 Then
            MsgBox("La hora: " & sbox_hor1.Text & ":00 no es una hora dentro de las posibilidades de horarios de clases")
            Return False
        ElseIf CInt(sbox_hor2.Text) <> 0 Then
            MsgBox("La hora debe ser exacta")
            Return False
        End If

        Return True
    End Function


#End Region

#Region "VALIDACION DE ENTRADA"

    Private Sub sbox_hor1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sbox_hor1.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

    Private Sub sbox_hor2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sbox_hor2.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

#End Region

    Private Sub btn_rueda_Click(sender As System.Object, e As System.EventArgs) Handles btn_rueda.Click
        Dim Horario As String = ""
        Dim Documento As Integer = 0
        Dim Funcionario As Integer = 0
        Dim Cliente As String = ""
        Dim Comentario As String = ""
        'Queries de registro para examen teorico'
        Dim D As Integer = 0
        Dim Cr As Integer = 0
        Dim Ed As Integer = 0

        If validar() Then
            Dim Fecha As String = Format(date_rueda.Value, "yyyy-MM-dd")
            Dim Fun As DataTable = con.doQuery("SELECT idFuncionario " _
                                        & "FROM Funcionario" _
                                         & " WHERE Nombre = '" & cbox_funcionario.Text & "'")
            If (CInt(sbox_hor2.Text) <= 9) Then
                Horario = sbox_hor1.Text & ":" & "0" & sbox_hor2.Text & ":00"
            Else
                Horario = sbox_hor1.Text & ":" & sbox_hor2.Text & ":00"
            End If
            If Fun.Rows.Count > 0 Then
                Funcionario = CInt(Fun.Rows(0).Item(0).ToString)
            Else
                Funcionario = 0
            End If
            Dim Tipo As String = "Cambio Rueda"
            Dim Estudiante As String = cbox_matricula.Text
            Dim Cl As DataTable = con.doQuery("SELECT cl.nombre FROM cliente cl, compra co, matricula m WHERE m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_matricula.Text & "'")
            If Cl.Rows.Count > 0 Then
                Cliente = Cl.Rows(0).Item(0).ToString
            Else
                Cliente = ""
            End If
            'Columnas y parametros de la query documento'
            Dim ColDoc() As String = {"Tipo", "Funcionario", "Fecha", "Estado"}
            Dim ParDocAp() As String = {Tipo, Funcionario, Fecha, "Aprobado"}
            Try
                con.beginTransaction()

                D = con.doInsert("Documento", ColDoc, ParDocAp)
                

                Dim Doc As DataTable = con.doQuery("SELECT max(idDOCUMENTO) AS idDOCUMENTO  FROM Documento")
                If Doc.Rows.Count > 0 Then
                    Documento = CInt(Doc.Rows(0).Item(0).ToString)
                Else
                    Documento = 0
                End If

                'Examen Municipal'
                'Columnas y parametros de la query examen municipal'

                Dim ColCr() As String = {"Documento", "Horario"}
                Dim ParCr() As String = {Documento, Horario}
                Cr = con.doInsert("CAMBIO_RUEDA", ColCr, ParCr)

                'Estudiante Documento'
                'Columnas y parametros de la query estudiante documento'
                Dim ColEd() As String = {"Estudiante", "Documento"}
                Dim ParEd() As String = {Estudiante, Documento}
                Ed = con.doInsert("ESTUDIANTE_DOCUMENTO", ColEd, ParEd)

                If D <> -1 And Cr <> -1 And Ed <> -1 Then
                    con.commitTransaction()
                Else
                    STATUS.Text = "Documento de Clase Cambio Rueda de: " & Cliente & " no fue agregado."
                End If

                STATUS.Text = "Clase Cambio Rueda de: " & Cliente & " fue agregada exitosamente."
                cbox_matricula.Text = ""
                lbl_estudiante.Text = ""
            Catch ex As Exception
                STATUS.Text = "Clase Cambio Rueda de: " & Cliente & " no fue agregado."
            End Try
        End If
    End Sub

    Private Sub cbox_matricula_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_matricula.SelectedValueChanged
        Dim label As DataTable = con.doQuery("SELECT cl.nombre " _
                                        & "FROM cliente cl, compra co, matricula m" _
                                         & " WHERE m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_matricula.Text & "'")

        If label.Rows.Count > 0 Then
            lbl_estudiante.Text = label.Rows(0).Item(0).ToString
        Else
            lbl_estudiante.Text = ""
        End If
    End Sub

    Private Sub btn_reset_Click(sender As System.Object, e As System.EventArgs) Handles btn_reset.Click
        date_rueda.Value = Now
        sbox_hor1.Value = "0"
        sbox_hor2.Value = "0"
        cbox_matricula.Text = ""
        cbox_funcionario.Text = ""
        STATUS.Text = "Usuario " & USER & ""
    End Sub


End Class