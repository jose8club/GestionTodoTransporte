﻿Public Class newExamen
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
            If cbox_TipoExamen.SelectedValue.Equals("Examen Teórico") Then
                cbox_funcionario.DataSource = dc.Profesores
                cbox_funcionario.DisplayMember = "Nombre"
                cbox_funcionario.ValueMember = "idFuncionario"
                cbox_funcionario.SelectedIndex = -1
            ElseIf cbox_TipoExamen.SelectedValue.Equals("Examen Práctico") Then
                cbox_funcionario.DataSource = dc.Instructores
                cbox_funcionario.DisplayMember = "Nombre"
                cbox_funcionario.ValueMember = "idFuncionario"
                cbox_funcionario.SelectedIndex = -1
            Else
                cbox_funcionario.DataSource = dc.Funcionarios
                cbox_funcionario.DisplayMember = "Nombre"
                cbox_funcionario.ValueMember = "idFuncionario"
                cbox_funcionario.SelectedIndex = -1
            End If
            
        End If
    End Sub

    Function validar() As Boolean
        STATUS.Text = ""
        STATUS.ForeColor = System.Drawing.SystemColors.ControlText

        'Funcionarios
        Dim dr As DataTable = cbox_funcionario.DataSource
        Dim lista As New List(Of String)(dr.Rows.Count)
        For Each Row As DataRow In dr.Rows
            lista.Add(Row(1))
        Next

        MsgBox(lista.Contains(cbox_funcionario.Text.Trim)) 'arroja el valor si contiene o no (borrar)

        If Not lista.Contains(cbox_funcionario.Text.Trim) Then
            MsgBox("Ingrese funcionario correcto")
            Return False
        End If

        'Estudiantes
        Dim de As DataTable = cbox_RegistroMatricula.DataSource
        Dim est As New List(Of String)(de.Rows.Count)
        For Each row As DataRow In de.Rows
            est.Add(row(0))
        Next

        MsgBox(est.Contains(cbox_RegistroMatricula.Text.Trim)) 'arroja el valor si contiene o no (borrar)

        If Not est.Contains(cbox_RegistroMatricula.Text.Trim) Then
            MsgBox("ingrese estudiante correcto")
            Return False
        End If


        'ATENTO A ESTE RETURN
        'Return False
        'ATENTO ^^^^^(lo hice para probar el validador de arriba e ignorar los demás)

        If cbox_RegistroMatricula.Text.Trim = "" Then
            STATUS.Text = "ERROR: Ingrese el campo 'Registro de Matrícula'"
            STATUS.ForeColor = Color.Red
            Return False
        ElseIf cbox_TipoExamen.Text = "" Then
            MsgBox("Ingrese tipo de examen")
            Return False
        ElseIf cbox_funcionario.Text = "" Then
            MsgBox("Ingrese datos de funcionario")
            Return False
        ElseIf check_Certificado.Checked = False And cbox_TipoExamen.Text.Equals("Examen Visual") Then
            MsgBox("Debe de haber un certificado oftalmologico que almacenar")
            Return False
        ElseIf rbtn_Aprobado.Checked = False And rbtn_Reprobado.Checked = False And Not cbox_TipoExamen.Text.Equals("Cambio Rueda") Then
            MsgBox("Seleccione una opción de aprobación")
            Return False
        ElseIf tbox_Calificacion.Text.Trim.Equals("") And cbox_TipoExamen.SelectedValue.Equals("Examen Teórico") Then
            MsgBox("Ingrese Calificación")
            Return False
        ElseIf tbox_Calificacion.Text.Trim.Equals("") And cbox_TipoExamen.SelectedValue.Equals("Examen Práctico") Then
            MsgBox("Ingrese Calificación")
            Return False
        ElseIf CInt(sbox_Hora.Text) <> 10 And CInt(sbox_Hora.Text) <> 12 And CInt(sbox_Hora.Text) <> 17 And cbox_TipoExamen.Text.Equals("Cambio Rueda") Then
            MsgBox("La hora: " & sbox_Hora.Text & ":00 no es una hora dentro de las posibilidades de horarios de clases")
            Return False
        ElseIf CInt(sbox_Minutos.Text) <> 0 And cbox_TipoExamen.Text.Equals("Cambio Rueda") Then
            MsgBox("La hora debe ser exacta")
            Return False
        ElseIf aprovado(cbox_RegistroMatricula.SelectedValue.ToString, cbox_TipoExamen.SelectedValue.ToString) Then
            MsgBox("Estudiante aprovado en " & cbox_TipoExamen.SelectedValue.ToString & ". No se puede realizar operacion")
            Return False
        End If

        Return True
    End Function

    Function aprovado(ByVal Matricula As String, ByVal Examen As String) As Boolean
        Dim resultado As String = ""

        Dim d As DataTable = con.doQuery("SELECT d.Estado " _
                                    & "FROM Documento d, Estudiante_Documento e, Estudiante f" _
                                     & " WHERE d.idDOCUMENTO=e.Documento and e.Estudiante=f.idESTUDIANTE and d.Estado='Aprobado' and f.idESTUDIANTE= '" & Matricula & "' and d.Tipo = '" & Examen & "'")

        If d.Rows.Count > 0 Then
            resultado = d.Rows(0).Item(0).ToString
        Else
            resultado = ""
        End If
        If resultado = "Aprobado" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cbox_TipoExamen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbox_TipoExamen.SelectedIndexChanged
        cbox_RegistroMatricula.Text = ""
        cbox_funcionario.Text = ""
        tbox_Calificacion.Text = ""
        lbl_NombreEstudiante.Text = ""

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
            loadCBOX("Funcionario")
            tbox_Calificacion.Visible = True

        ElseIf cbox_TipoExamen.SelectedValue.Equals("Examen Práctico") Then
            Label.Text = "Calificación:"
            loadCBOX("Funcionario")
            tbox_Calificacion.Visible = True

        ElseIf cbox_TipoExamen.SelectedValue.Equals("Examen Municipal") Then
            Label.Text = "Comentario:"
            loadCBOX("Funcionario")
            tbox_Comentario.Visible = True

        ElseIf cbox_TipoExamen.SelectedValue.Equals("Examen Visual") Then
            Label.Text = "Certificado:"
            loadCBOX("Funcionario")
            check_Certificado.Visible = True

        ElseIf cbox_TipoExamen.SelectedValue.Equals("Examen Psicotécnico") Then
            Label.Text = ""
            loadCBOX("Funcionario")
        ElseIf cbox_TipoExamen.SelectedValue.Equals("Cambio Rueda") Then
            Label.Text = "Horario:"
            loadCBOX("Funcionario")
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
            cbox_funcionario.Text = cbox_funcionario.Text.Trim

            Dim Codigo As String = cbox_RegistroMatricula.Text
            Dim Fecha As String = Format(date_Fecha.Value, "yyyy-MM-dd")
            Dim Estado As String = ""
            Dim Comentario As String = tbox_Comentario.Text
            Dim Calificacion As String = tbox_Calificacion.Text
            'Dim Certificado As Boolean = check_Certificado.Checked
            Dim Funcionario As String = cbox_funcionario.SelectedValue
            Dim Horario As String = ""
            Dim Tipo As String = cbox_TipoExamen.SelectedValue

            Dim ID As Integer = 0
            Dim Columnas() As String = {}
            Dim Parametros() As String = {}

            If (CInt(sbox_Minutos.Text) <= 9) Then
                Horario = sbox_Hora.Text & ":" & "0" & sbox_Minutos.Text & ":00"
            Else
                Horario = sbox_Hora.Text & ":" & sbox_Minutos.Text & ":00"
            End If

            If rbtn_Aprobado.Checked Then Estado = "Aprobado" Else Estado = "Reprobado"

            MsgBox("Estado: " & Estado.ToString & ", Certificado: " & 1 & ", Funcionario: " & Funcionario & _
                   "Horario: " & Horario)
            Try
                con.beginTransaction()

                Columnas = {"Tipo", "Funcionario", "Fecha", "Estado"}
                Parametros = {Tipo, Funcionario, Fecha, Estado}
                ID = con.doInsert("Documento", Columnas, Parametros)
                Dim AUX As Integer = ID

                If cbox_TipoExamen.SelectedValue.Equals("Examen Teórico") Then
                    'insert
                    If ID <> -1 Then
                        Columnas = {"Documento", "Calificacion"}
                        Parametros = {AUX, Calificacion}
                        ID = con.doInsert("Examen_Teorico", Columnas, Parametros)
                        If ID <> -1 Then
                            Columnas = {"Estudiante", "Documento"}
                            Parametros = {Codigo, AUX}
                            ID = con.doInsert("Estudiante_Documento", Columnas, Parametros)
                        End If
                    End If

                ElseIf cbox_TipoExamen.SelectedValue.Equals("Examen Práctico") Then
                    'insert
                    If ID <> -1 Then
                        Columnas = {"Documento", "Calificacion"}
                        Parametros = {AUX, Calificacion}
                        ID = con.doInsert("Examen_Practico", Columnas, Parametros)
                        If ID <> -1 Then
                            Columnas = {"Estudiante", "Documento"}
                            Parametros = {Codigo, AUX}
                            ID = con.doInsert("Estudiante_Documento", Columnas, Parametros)
                        End If
                    End If
                ElseIf cbox_TipoExamen.SelectedValue.Equals("Examen Municipal") Then
                    'insert
                    If ID <> -1 Then
                        Columnas = {"Documento", "Comentario"}
                        Parametros = {AUX, Comentario}
                        ID = con.doInsert("Examen_Municipal", Columnas, Parametros)
                        If ID <> -1 Then
                            Columnas = {"Estudiante", "Documento"}
                            Parametros = {Codigo, AUX}
                            ID = con.doInsert("Estudiante_Documento", Columnas, Parametros)
                        End If
                    End If
                ElseIf cbox_TipoExamen.SelectedValue.Equals("Examen Visual") Then
                    'insert
                    If ID <> -1 Then
                        Columnas = {"Documento", "Certificado"}
                        Parametros = {AUX, 1}
                        ID = con.doInsert("Examen_Visual", Columnas, Parametros)
                        If AUX <> -1 Then
                            Columnas = {"Estudiante", "Documento"}
                            Parametros = {Codigo, AUX}
                            ID = con.doInsert("Estudiante_Documento", Columnas, Parametros)
                        End If
                    End If
                ElseIf cbox_TipoExamen.SelectedValue.Equals("Examen Psicotécnico") Then
                    'insert
                    If ID <> -1 Then
                        Columnas = {"Documento"}
                        Parametros = {AUX}
                        ID = con.doInsert("Psicotecnico", Columnas, Parametros)
                        If ID <> -1 Then
                            Columnas = {"Estudiante", "Documento"}
                            Parametros = {Codigo, AUX}
                            ID = con.doInsert("Estudiante_Documento", Columnas, Parametros)
                        End If
                    End If
                ElseIf cbox_TipoExamen.SelectedValue.Equals("Cambio Rueda") Then

                    If ID <> -1 Then
                        Columnas = {"Documento", "Horario"}
                        Parametros = {AUX, Horario}
                        ID = con.doInsert("Cambio_Rueda", Columnas, Parametros)
                        If ID <> -1 Then
                            Columnas = {"Estudiante", "Documento"}
                            Parametros = {Codigo, AUX}
                            ID = con.doInsert("Estudiante_Documento", Columnas, Parametros)
                        End If
                    End If
                End If

                If ID <> -1 Then
                    con.commitTransaction()
                    STATUS.Text = "Operación realizada con éxito."
                    STATUS.ForeColor = Color.Blue
                Else
                    STATUS.Text = "Hubo un error al realizar la operación."
                    STATUS.ForeColor = Color.Red
                End If

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End If
    End Sub

    Private Sub btn_reset_Click(sender As System.Object, e As System.EventArgs) Handles btn_reset.Click
        STATUS.ForeColor = Color.Black
        date_Fecha.Value = Now
        sbox_Hora.Value = "0"
        sbox_Minutos.Value = "0"
        lbl_NombreEstudiante.Text = ""
        tbox_Calificacion.Text = ""
        check_Certificado.Checked = False
        cbox_RegistroMatricula.Text = ""
        cbox_TipoExamen.Text = ""
        cbox_funcionario.Text = ""
        rbtn_Aprobado.Checked = False
        rbtn_Reprobado.Checked = False
        STATUS.Text = "Usuario " & USER & ""
    End Sub

End Class