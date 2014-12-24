Public Class ExamenTeorico
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
    Private Sub ExamenTeorico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        rbtn_aprobado.Checked = True
        loadCBOX("Profesor")
        loadCBOX("Matricula")
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)
        If Nombre.Equals("Profesor") Then
            cbox_funcionario.DataSource = datacbox.Profesores
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

        If tbox_calTeo.Text.Trim.Equals("") Then
            MsgBox("Ingrese Calificación")
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
    Private Sub tbox_calTeo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Herramientas.soloNumeros(e)
    End Sub
#End Region

    Private Sub btn_exTeo_Click(sender As System.Object, e As System.EventArgs) Handles btn_exTeo.Click
        Dim Documento As Integer = 0
        Dim Calificacion As Integer = CInt(tbox_calTeo.Text)
        Dim Funcionario As Integer = 0
        'Dim Funcionario As Integer = CInt(con.selectWhereQuery("idFuncionario", "Funcionario", "Nombre = '" & cbox_funcionario.Text & "'"))
        Dim Cliente As String = ""
        If validar() Then
            Dim Fecha As String = Format(date_rueda.Value, "yyyy-MM-dd")
            Dim Fun As DataTable = con.doQuery("SELECT idFuncionario " _
                                        & "FROM Funcionario" _
                                         & " WHERE Nombre = '" & cbox_funcionario.Text & "'")
            If Fun.Rows.Count > 0 Then
                Funcionario = CInt(Fun.Rows(0).Item(0).ToString)
            Else
                Funcionario = 0
            End If
            Dim Tipo As String = "Examen Teorico"
            Dim Estudiante As String = cbox_matricula.Text
            Dim Cl As DataTable = con.doQuery("SELECT cl.nombre FROM cliente cl, compra co, matricula m WHERE m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_matricula.Text & "'")
            If Cl.Rows.Count > 0 Then
                Cliente = Cl.Rows(0).Item(0).ToString
            Else
                Cliente = ""
            End If
            Try
                If rbtn_aprobado.Checked Then
                    con.regDocumento2(Tipo, Funcionario, Fecha, "Aprobado")
                    MsgBox("El estudiante : " & Cliente & " puede dar la clase practica con calificacion " & (Calificacion / 10) & "")
                ElseIf rbtn_reprobado.Checked Then
                    con.regDocumento2(Tipo, Funcionario, Fecha, "Reprobado")
                    MsgBox("El estudiante : " & Cliente & " no puede dar la clase practica con calificacion " & (Calificacion / 10) & "")
                End If
                Documento = CInt(con.last("idDOCUMENTO", "Documento"))
                con.regExTeo(Documento, Calificacion)
                con.regEstDoc(Estudiante, Documento)
                STATUS.Text = "Examen Teorico de: " & Cliente & " fue agregada exitosamente."
                cbox_matricula.Text = ""
                tbox_calTeo.Text = ""
                lbl_estudiante.Text = ""
            Catch ex As Exception
                STATUS.Text = "Examen Teorico de: " & Cliente & " no fue agregado."
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
        tbox_calTeo.Text = ""
        cbox_matricula.Text = ""
        cbox_funcionario.Text = ""
        rbtn_aprobado.Checked = False
        rbtn_reprobado.Checked = False
        STATUS.Text = "Usuario " & USER & ""
        lbl_estudiante.Text = ""
    End Sub

    
End Class