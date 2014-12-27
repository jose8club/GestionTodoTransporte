Public Class ExamenPractico
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

    Private Sub ExamenPractico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        rbtn_aprobado.Checked = True
        loadCBOX("Profesor")
        loadCBOX("Matricula")
        'lbl_estudiante.Text = con.selectWhereQuery("cl.nombre", "cliente cl, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_matricula.Text & "'")
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)

        If Nombre.Equals("Profesor") Then
            cbox_funcionario.DataSource = datacbox.Instructores
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

        If tbox_calPract.Text.Trim.Equals("") Then
            MsgBox("Ingrese Calificación")
            Return False
        ElseIf cbox_matricula.Text = "" Then
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

#Region "VALIDACION DE ENTRADA"
    Private Sub tbox_calPract_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Herramientas.soloNumeros(e)
    End Sub
#End Region

    Private Sub btn_exPract_Click(sender As System.Object, e As System.EventArgs) Handles btn_exPract.Click
        Dim Documento As Integer = 0
        Dim Funcionario As Integer = 0
        Dim Cliente As String = ""
        'Queries de registro para examen teorico'
        Dim D As Integer = 0
        Dim Ep As Integer = 0
        Dim Ed As Integer = 0

        If validar() Then
            Dim Calificacion As Integer = CInt(tbox_calPract.Text)
            Dim Fecha As String = Format(date_practico.Value, "yyyy-MM-dd")
            Dim Fun As DataTable = con.doQuery("SELECT idFuncionario " _
                                        & "FROM Funcionario" _
                                         & " WHERE Nombre = '" & cbox_funcionario.Text & "'")
            If Fun.Rows.Count > 0 Then
                Funcionario = CInt(Fun.Rows(0).Item(0).ToString)
            Else
                Funcionario = 0
            End If
            Dim Tipo As String = "Examen Practico"
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
                    MsgBox("El estudiante : " & Cliente & " puede dar el examen municipal con calificacion " & (Calificacion / 10) & "")
                ElseIf rbtn_reprobado.Checked Then
                    D = con.doInsert("Documento", ColDoc, ParDocRep)
                    MsgBox("El estudiante : " & Cliente & " no puede dar el examen municipal con calificacion " & (Calificacion / 10) & "")
                End If


                Dim Doc As DataTable = con.doQuery("SELECT max(idDOCUMENTO) AS idDOCUMENTO  FROM Documento")
                If Doc.Rows.Count > 0 Then
                    Documento = CInt(Doc.Rows(0).Item(0).ToString)
                Else
                    Documento = 0
                End If

                'Examen Practico'
                'Columnas y parametros de la query examen practico'

                Dim ColEp() As String = {"Documento", "Calificacion"}
                Dim ParEp() As String = {Documento, Calificacion}
                Ep = con.doInsert("EXAMEN_PRACTICO", ColEp, ParEp)

                'Estudiante Documento'
                'Columnas y parametros de la query estudiante documento'
                Dim ColEd() As String = {"Estudiante", "Documento"}
                Dim ParEd() As String = {Estudiante, Documento}
                Ed = con.doInsert("ESTUDIANTE_DOCUMENTO", ColEd, ParEd)

                If D <> -1 And Ep <> -1 And Ed <> -1 Then
                    con.commitTransaction()
                Else
                    STATUS.Text = "Documento de Examen Practico de: " & Cliente & " no fue agregado."
                End If

                STATUS.Text = "Examen Practico de: " & Cliente & " fue agregada exitosamente."
                cbox_matricula.Text = ""
                tbox_calPract.Text = ""
                lbl_estudiante.Text = ""
            Catch ex As Exception
                STATUS.Text = "Examen Practico de: " & Cliente & " no fue agregado."
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
        date_practico.Value = Now
        tbox_calPract.Text = ""
        lbl_estudiante.Text = ""
        cbox_matricula.Text = ""
        cbox_funcionario.Text = ""
        rbtn_aprobado.Checked = False
        rbtn_reprobado.Checked = False
        STATUS.Text = "Usuario " & USER & ""

    End Sub
End Class