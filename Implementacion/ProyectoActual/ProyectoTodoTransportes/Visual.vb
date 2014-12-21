Public Class Visual
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub Visual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        rbtn_aprobado.Checked = True
        loadCBOX("Funcionario")
        loadCBOX("Matricula")
        lbl_estudiante.Text = con.selectWhereQuery("cl.nombre", "cliente cl, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_matricula.Text & "'")
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)
        Dim n As Integer
        Dim items() As String

        If Nombre.Equals("Funcionario") Then
            cbox_funcionario.Items.Clear()

            n = con.count("Funcionario") - 1
            items = con.toArray(n, "Nombre", "Funcionario")
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

        If Not cbox_matricula.Items.Contains(cbox_matricula.Text) Then
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
        ElseIf chbox_cert.Checked = False Then
            MsgBox("Debe de haber un certificado oftalmologico que almacenar")
            Return False
        End If

        Return True
    End Function
#End Region


    Private Sub btn_visual_Click(sender As System.Object, e As System.EventArgs) Handles btn_visual.Click
        Dim bool_cert As Boolean = chbox_cert.Checked()
        Dim Documento As Integer = 0
        Dim Funcionario As Integer = CInt(con.selectWhereQuery("idFuncionario", "Funcionario", "Nombre = '" & cbox_funcionario.Text & "'"))


        If validar() Then
            Dim Fecha As String = Format(date_rueda.Value, "yyyy-MM-dd")
            
            Dim Tipo As String = "Examen Visual"
            Dim Estudiante As String = cbox_matricula.Text
            Dim Cliente As String = con.selectWhereQuery("cl.nombre", "cliente cl, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_matricula.Text & "'")
            Try
                If rbtn_aprobado.Checked Then
                    con.regDocumento2(Tipo, Funcionario, Fecha, "Aprobado")
                ElseIf rbtn_reprobado.Checked Then
                    con.regDocumento2(Tipo, Funcionario, Fecha, "Reprobado")
                End If
                Documento = CInt(con.last("idDOCUMENTO", "Documento"))
                con.regVisual(Documento, bool_cert)
                con.regEstDoc(Estudiante, Documento)
                STATUS.Text = "Examen Visual de: " & Cliente & " fue agregada exitosamente."
                cbox_matricula.Text = ""
                chbox_cert.Checked = False
            Catch ex As Exception
                STATUS.Text = "Examen Visual de: " & Cliente & " no fue agregado."
            End Try
        End If
    End Sub

    Private Sub cbox_matricula_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_matricula.SelectedValueChanged
        lbl_estudiante.Text = con.selectWhereQuery("cl.nombre", "cliente cl, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_matricula.Text & "'")
    End Sub


    Private Sub btn_reset_Click(sender As System.Object, e As System.EventArgs) Handles btn_reset.Click
        date_rueda.Value = Now
        cbox_matricula.Text = ""
        cbox_funcionario.Text = ""
        rbtn_aprobado.Checked = False
        rbtn_reprobado.Checked = False
        chbox_cert.Checked = False
        STATUS.Text = "Usuario " & USER & ""
    End Sub
End Class