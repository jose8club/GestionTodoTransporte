Public Class newExamen
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim dc As DataCBOX

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        dc = New DataCBOX(con)
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub newExamen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        loadCBOX("Examenes")
        loadCBOX("RegistroMatricula")
        loadCBOX("Funcionario")
        rbtn_Reprobado.Checked = True

        Label.Text = "Calificación"
        tbox_Calificacion.Visible = True
    End Sub

    Sub loadCBOX(ByVal s As String)
        If s.Equals("RegistroMatricula") Then
            cbox_RegistroMatricula.DataSource = dc.Estudiantes
            cbox_RegistroMatricula.DisplayMember = "idEstudiante"
            cbox_RegistroMatricula.ValueMember = "idEstudiante"
            cbox_RegistroMatricula.SelectedIndex = -1

        ElseIf s.Equals("Examenes") Then

            Dim examenes As DataTable = New DataTable
            examenes.Columns.Add("Nombre")
            examenes.Rows.Add("Examen Teórico")
            examenes.Rows.Add("Examen Práctico")
            examenes.Rows.Add("Examen Municipal")
            examenes.Rows.Add("Examen Visual")
            examenes.Rows.Add("Examen Psicotécnico")
            examenes.Rows.Add("Cambio Rueda")

            cbox_TipoExamen.DataSource = examenes
            cbox_TipoExamen.DisplayMember = "Nombre"
            cbox_TipoExamen.ValueMember = "Nombre"

        ElseIf s.Equals("Funcionario") Then
            cbox_funcionario.DataSource = dc.Funcionarios
            cbox_funcionario.DisplayMember = "Nombre"
            cbox_funcionario.ValueMember = "Nombre"
            cbox_funcionario.SelectedIndex = -1
        End If
    End Sub

    Function validar() As Boolean
        STATUS.Text = ""
        STATUS.ForeColor = System.Drawing.SystemColors.ControlText

        Return True
        If cbox_RegistroMatricula.Text.Trim = "" Then
            STATUS.Text = "ERROR: Ingrese el campo 'Registro de Matrícula'"
            STATUS.ForeColor = Color.Red
            Return False
        End If

        Return True
    End Function

    Private Sub cbox_TipoExamen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbox_TipoExamen.SelectedIndexChanged
        tbox_Comentario.Visible = False
        tbox_Calificacion.Visible = False
        check_Certificado.Visible = False
        sbox_Hora.Visible = False
        sbox_Minutos.Visible = False
        lbl_dospuntos.Visible = False
        lbl_hrs.Visible = False
        Label.Text = ""

        If cbox_TipoExamen.SelectedValue.Equals("Examen Teórico") Then
            Label.Text = "Calificación:"
            tbox_Calificacion.Visible = True

        ElseIf cbox_TipoExamen.SelectedValue.Equals("Examen Práctico") Then
            Label.Text = "Calificación:"
            tbox_Calificacion.Visible = True

        ElseIf cbox_TipoExamen.SelectedValue.Equals("Examen Municipal") Then
            Label.Text = "Comentario:"
            tbox_Comentario.Visible = True

        ElseIf cbox_TipoExamen.SelectedValue.Equals("Examen Visual") Then
            Label.Text = "Certificado:"
            check_Certificado.Visible = True

        ElseIf cbox_TipoExamen.SelectedValue.Equals("Examen Psicotécnico") Then
            Label.Text = ""
        ElseIf cbox_TipoExamen.SelectedValue.Equals("Cambio Rueda") Then
            Label.Text = "Horario:"
            sbox_Hora.Visible = True
            sbox_Minutos.Visible = True
            lbl_dospuntos.Visible = True
            lbl_hrs.Visible = True
        End If
    End Sub

    Private Sub cbox_RegistroMatricula_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbox_RegistroMatricula.SelectedIndexChanged
        Dim label As DataTable = con.doQuery("SELECT cl.nombre " _
                                        & "FROM cliente cl, compra co, matricula m" _
                                         & " WHERE m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_RegistroMatricula.Text & "'")

        If label.Rows.Count > 0 Then
            lbl_NombreEstudiante.Text = label.Rows(0).Item(0).ToString
        Else
            lbl_NombreEstudiante.Text = ""
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If validar() Then
            Dim Codigo As String = cbox_RegistroMatricula.Text
            Dim Fecha As String = Format(date_Fecha.Value, "yyyy-MM-dd")

        End If
    End Sub

End Class