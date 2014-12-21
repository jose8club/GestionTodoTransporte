Public Class ExamenPractico
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim Instructores(,) As String
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub ExamenPractico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        rbtn_aprobado.Checked = True
        loadCBOX("Profesor")
        loadCBOX("Matricula")
        lbl_estudiante.Text = con.selectWhereQuery("cl.nombre", "cliente cl, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_matricula.Text & "'")
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)

        Dim n As Integer
        Dim items() As String

        If Nombre.Equals("Profesor") Then
            cbox_funcionario.Items.Clear()

            n = con.count("Profesor") - 1
            items = con.toArrayWhere(n, "a.Nombre", "funcionario a, docente b", "a.idFuncionario=b.idDocente and b.tipo='INS'")
            cbox_funcionario.Items.Add("")
            For i As Integer = 0 To n
                cbox_funcionario.Items.Add(items(i))
            Next

            If n >= 0 Then cbox_funcionario.SelectedIndex = 0

        ElseIf Nombre.Equals("Matricula") Then
            cbox_matricula.Items.Clear()

            n = con.count("Estudiante") - 1
            items = con.toArray(n, "idEstudiante", "Estudiante")

            cbox_matricula.Items.Add("")
            For i As Integer = 0 To n
                cbox_matricula.Items.Add(items(i))
            Next

            If n >= 0 Then cbox_matricula.SelectedIndex = 0

        End If
    End Sub

    Function validar() As Boolean

        If tbox_calPract.Text.Trim.Equals("") Then
            MsgBox("Ingrese Calificación")
            Return False
        ElseIf Not cbox_matricula.Items.Contains(cbox_matricula.Text) Then
            MsgBox("La matricula '" & cbox_matricula.Text & "' no existe")
            cbox_matricula.Text = ""
            Return False
        ElseIf Not cbox_funcionario.Items.Contains(cbox_funcionario.Text) Then
            MsgBox("El funcionario: '" & cbox_funcionario.Text & "' no existe")
            cbox_funcionario.Text = ""
            Return False
        ElseIf cbox_matricula.Text = "" Then
            MsgBox("Ingrese datos de matricula")
            Return False
        ElseIf cbox_funcionario.Text = "" Then
            MsgBox("Ingrese datos de funcionario")
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
        Dim Calificacion As Integer = CInt(tbox_calPract.Text)
        Dim Funcionario As Integer = CInt(con.selectWhereQuery("idFuncionario", "Funcionario", "Nombre = '" & cbox_funcionario.Text & "'"))

        If validar() Then
            Dim Fecha As String = Format(date_rueda.Value, "yyyy-MM-dd")

            Dim Tipo As String = "Examen Practico"
            Dim Estudiante As String = cbox_matricula.Text
            Dim Cliente As String = con.selectWhereQuery("cl.nombre", "cliente cl, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_matricula.Text & "'")
            Try
                If rbtn_aprobado.Checked Then
                    con.regDocumento2(Tipo, Funcionario, Fecha, "Aprobado")
                    MsgBox("El estudiante : " & Cliente & " puede dar el examen municipal")
                ElseIf rbtn_reprobado.Checked Then
                    con.regDocumento2(Tipo, Funcionario, Fecha, "Reprobado")
                    MsgBox("El estudiante : " & Cliente & " no puede dar el examen municipal")
                End If
                Documento = CInt(con.last("idDOCUMENTO", "Documento"))
                con.regExPract(Documento, Calificacion)
                con.regEstDoc(Estudiante, Documento)
                STATUS.Text = "Examen Práctico de: " & Cliente & " fue agregada exitosamente."
                cbox_matricula.Text = ""
                tbox_calPract.Text = ""
            Catch ex As Exception
                STATUS.Text = "Examen Práctico de: " & Cliente & " no fue agregado."
            End Try
        End If
    End Sub

    Private Sub cbox_matricula_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_matricula.SelectedValueChanged
        lbl_estudiante.Text = con.selectWhereQuery("cl.nombre", "cliente cl, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_matricula.Text & "'")
    End Sub

    Private Sub btn_reset_Click(sender As System.Object, e As System.EventArgs) Handles btn_reset.Click
        date_rueda.Value = Now
        tbox_calPract.Text = ""
        cbox_matricula.Text = ""
        cbox_funcionario.Text = ""
        rbtn_aprobado.Checked = False
        rbtn_reprobado.Checked = False
        STATUS.Text = "Usuario " & USER & ""
    End Sub
End Class