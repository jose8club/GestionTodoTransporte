Public Class CambioRueda
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub CambioRueda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Funcionario")
        loadCBOX("Matricula")
        lbl_estudiante.Text = con.selectWhereQuery("cl.nombre", "cliente cl, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_matricula.Text & "'")

    End Sub

#Region "Metodos"
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

    Function validar(ByVal Horario As String) As Boolean
        'Futura validación
        Return True
    End Function

#End Region

    Private Sub btn_rueda_Click(sender As System.Object, e As System.EventArgs) Handles btn_rueda.Click

        Dim Documento As Integer = 0
        Dim Funcionario As Integer = CInt(con.selectWhereQuery("idFuncionario", "Funcionario", "Nombre = '" & cbox_funcionario.Text & "'"))
        Dim Horario As String

        If validar() Then
            Dim Fecha As String = Format(date_rueda.Value, "yyyy-MM-dd")
            If (CInt(sbox_hor2.Text) <= 9) Then
                Horario = sbox_hor1.Text & ":" & "0" & sbox_hor2.Text & ":00"
            Else
                Horario = sbox_hor1.Text & ":" & sbox_hor2.Text & ":00"
            End If
            Dim Val As Boolean = validar(Horario)
            Dim Tipo As String = "Cambio Rueda"
            Dim Estudiante As String = cbox_matricula.Text
            Dim Cliente As String = con.selectWhereQuery("cl.nombre", "cliente cl, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_matricula.Text & "'")
            Try
                con.regDocumento2(Tipo, Funcionario, Fecha, "Aprobado")
                Documento = CInt(con.last("idDOCUMENTO", "Documento"))
                con.regRueda(Documento, Horario)
                con.regEstDoc(Estudiante, Documento)
                STATUS.Text = "Clase Cambio Rueda de: " & Cliente & " fue agregada exitosamente."
                cbox_matricula.Text = ""
            Catch ex As Exception
            STATUS.Text = "Clase Cambio Rueda de: " & Cliente & " no fue agregado."
        End Try
        End If
    End Sub

    Private Sub cbox_matricula_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_matricula.SelectedValueChanged
        lbl_estudiante.Text = con.selectWhereQuery("cl.nombre", "cliente cl, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_matricula.Text & "'")
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