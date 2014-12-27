Public Class Psicotecnico
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
    
    Private Sub Psicotecnico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        rbtn_aprobado.Checked = True
        loadCBOX("Funcionario")
        loadCBOX("Matricula")
    End Sub

#Region "Métodos"
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
        ElseIf rbtn_aprobado.Checked = False And rbtn_reprobado.Checked = False Then
            MsgBox("Seleccione una opción de examenes")
            Return False
        End If

        Return True
    End Function
#End Region



    Private Sub btn_psico_Click(sender As System.Object, e As System.EventArgs) Handles btn_psico.Click
        Dim Documento As Integer = 0
        Dim Funcionario As Integer = 0
        Dim Cliente As String = ""
        Dim Comentario As String = ""
        'Queries de registro para examen teorico'
        Dim D As Integer = 0
        Dim Ps As Integer = 0
        Dim Ed As Integer = 0

        If validar() Then
            Dim Fecha As String = Format(date_psico.Value, "yyyy-MM-dd")

            Dim Fun As DataTable = con.doQuery("SELECT idFuncionario " _
                                        & "FROM Funcionario" _
                                         & " WHERE Nombre = '" & cbox_funcionario.Text & "'")
            If Fun.Rows.Count > 0 Then
                Funcionario = CInt(Fun.Rows(0).Item(0).ToString)
            Else
                Funcionario = 0
            End If

            Dim Tipo As String = "Examen Psicotécnico"
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
            Dim ParDocRep() As String = {Tipo, Funcionario, Fecha, "Reprobado"}

            Try
                con.beginTransaction()
                If rbtn_aprobado.Checked Then
                    D = con.doInsert("Documento", ColDoc, ParDocAp)
                    MsgBox("El examen psicotecnico de : " & Cliente & " fue aprobado")
                ElseIf rbtn_reprobado.Checked Then
                    D = con.doInsert("Documento", ColDoc, ParDocRep)
                    MsgBox("El examen psicotecnico de : " & Cliente & " fue reprobado")
                End If

                Dim Doc As DataTable = con.doQuery("SELECT max(idDOCUMENTO) AS idDOCUMENTO  FROM Documento")
                If Doc.Rows.Count > 0 Then
                    Documento = CInt(Doc.Rows(0).Item(0).ToString)
                Else
                    Documento = 0
                End If

                'Practica Psicotécnico'
                'Columnas y parametros de la query Practica Psicotécnico'
                Dim ColPs() As String = {"Documento"}
                Dim ParPs() As String = {Documento}
                Ps = con.doInsert("PSICOTECNICO", ColPs, ParPs)

                'Estudiante Documento'
                'Columnas y parametros de la query estudiante documento'
                Dim ColEd() As String = {"Estudiante", "Documento"}
                Dim ParEd() As String = {Estudiante, Documento}
                Ed = con.doInsert("ESTUDIANTE_DOCUMENTO", ColEd, ParEd)

                If D <> -1 And Ps <> -1 And Ed <> -1 Then
                    con.commitTransaction()
                Else
                    STATUS.Text = "Practica Psicotécnico de: " & Cliente & " no fue agregado como debe ser."
                End If

                STATUS.Text = "Practica Psicotécnico de: " & Cliente & " fue agregada exitosamente."
                cbox_matricula.Text = ""
                lbl_estudiante.Text = ""
            Catch ex As Exception
                STATUS.Text = "Practica Psicotécnico de: " & Cliente & " no fue agregado."
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
        date_psico.Value = Now
        cbox_matricula.Text = ""
        cbox_funcionario.Text = ""
        rbtn_aprobado.Checked = False
        rbtn_reprobado.Checked = False
        STATUS.Text = "Usuario " & USER & ""
    End Sub
End Class