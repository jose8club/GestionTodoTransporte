Public Class Asistencias
    Dim con As New Conexion
    Dim USER As String = ""
    Dim datacbox As DataCBOX
    Dim tipo As String = ""
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal texto As String)
        con = conexion
        USER = usuario
        tipo = texto
        datacbox = New DataCBOX(con)
        InitializeComponent()
    End Sub
    Private Sub Asistencias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbl_estatus.Text = "Usuario: " & USER
        loadCBOX("Estudiantes")

        If tipo.Equals("Asistencia Teorica") Then
            lbl_vehiculo.Visible = False
            lbl_matricula.Visible = False
            lbl_marca.Visible = False
            lbl_docente.Text = "Profesor"
            loadCBOX("Profesor")
            loadCBOX("Clase Teorica")
        ElseIf tipo.Equals("Asistencia Práctica") Then
            lbl_docente.Text = "Instructor"
            loadCBOX("Instructores")
            loadCBOX("Clase Practica")
        End If
    End Sub

#Region "Métodos"

    Sub loadCBOX(ByVal Nombre As String)
        If Nombre.Equals("Profesor") Then
            cbox_docente.DataSource = datacbox.Profesores
            cbox_docente.DisplayMember = "Nombre"
            cbox_docente.ValueMember = "idFuncionario"
            cbox_docente.SelectedIndex = -1
        ElseIf Nombre.Equals("Instructores") Then
            cbox_docente.DataSource = datacbox.Instructores
            cbox_docente.DisplayMember = "Nombre"
            cbox_docente.ValueMember = "idFuncionario"
            cbox_docente.SelectedIndex = -1
        ElseIf Nombre.Equals("Estudiantes") Then
            cbox_estudiante.DataSource = datacbox.Estudiantes
            cbox_estudiante.DisplayMember = "idEstudiante"
            cbox_estudiante.ValueMember = "idEstudiante"
            cbox_estudiante.SelectedIndex = -1
        ElseIf Nombre.Equals("Clase Teorica") Then
            cbox_clasedia.DataSource = datacbox.ClaseTeorica
            cbox_clasedia.DisplayMember = "idClase"
            cbox_clasedia.ValueMember = "idClase"
            cbox_clasedia.SelectedIndex = -1
        ElseIf Nombre.Equals("Clase Practica") Then
            cbox_clasedia.DataSource = datacbox.ClasePractica
            cbox_clasedia.DisplayMember = "idClase"
            cbox_clasedia.ValueMember = "idClase"
            cbox_clasedia.SelectedIndex = -1
        End If
    End Sub

    Function validar() As Boolean
        lbl_estatus.Text = ""
        lbl_estatus.ForeColor = System.Drawing.SystemColors.ControlText

        'Docentes
        Dim dr As DataTable = cbox_docente.DataSource
        Dim lista As New List(Of String)(dr.Rows.Count)
        For Each Row As DataRow In dr.Rows
            lista.Add(Row(1))
        Next

        MsgBox(lista.Contains(cbox_docente.Text.Trim)) 'arroja el valor si contiene o no (borrar)

        If Not lista.Contains(cbox_docente.Text.Trim) Then
            MsgBox("Ingrese funcionario correcto")
            Return False
        End If

        'Estudiantes
        'Dim de As DataTable = cbox_estudiante.DataSource
        'Dim est As New List(Of String)(de.Rows.Count)
        'For Each Row As DataRow In de.Rows
        '    est.Add(Row(1))
        'Next

        'MsgBox(est.Contains(cbox_estudiante.Text.Trim)) 'arroja el valor si contiene o no (borrar)

        'If Not est.Contains(cbox_estudiante.Text.Trim) Then
        '    MsgBox("Ingrese estudiante correcto")
        '    Return False
        'End If

        'Curso
        'Dim dc As DataTable = cbox_clasedia.DataSource
        'Dim cl As New List(Of String)(dc.Rows.Count)
        'For Each Row As DataRow In dc.Rows
        '    cl.Add(Row(1))
        'Next

        'MsgBox(cl.Contains(cbox_clasedia.Text.Trim)) 'arroja el valor si contiene o no (borrar)

        'If Not cl.Contains(cbox_clasedia.Text.Trim) Then
        '    MsgBox("Ingrese dia correcto")
        '    Return False
        'End If

        If cbox_estudiante.Text.Trim = "" Then
            lbl_estatus.Text = "ERROR: Ingrese el campo 'Estudiante'"
            lbl_estatus.ForeColor = Color.Red
            Return False
        ElseIf cbox_docente.Text = "" Then
            MsgBox("Ingrese datos de funcionario")
            Return False
        ElseIf tbox_numero.Text = "" Or CInt(tbox_numero.Text) < 0 Then
            MsgBox("Ingrese numero de asistencia")
            Return False
        ElseIf cbox_clasedia.Text = "" Then
            MsgBox("Ingrese curso")
            Return False
        ElseIf CInt(sbox_hor2.Text) <> 0 Then
            MsgBox("La hora debe ser exacta")
            Return False
        ElseIf CInt(sbox_hor1.Text) < 8 Then
            MsgBox("La hora debe ser en horarios de oficina")
            Return False
        End If

        If tipo.Equals("Asistencia Práctica") Then
            If lbl_matricula.Text = "" Or lbl_marca.Text = "" Then
                Return False
            End If
        End If

        Return True
    End Function

#End Region

    Private Sub cbox_estudiante_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_estudiante.SelectedValueChanged
        Dim label As DataTable = con.doQuery("SELECT cl.nombre " _
                                        & "FROM cliente cl, compra co, matricula m" _
                                         & " WHERE m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_estudiante.Text & "'")

        If label.Rows.Count > 0 Then
            lbl_estudiante.Text = label.Rows(0).Item(0).ToString
        Else
            lbl_estudiante.Text = ""
        End If
    End Sub

    Private Sub cbox_docente_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_docente.SelectedValueChanged
        If tipo.Equals("Asistencia Práctica") Then
            Dim label As DataTable = con.doQuery("SELECT i.Auto FROM Instructor i, Docente d, Funcionario f WHERE i.idInstructor = d.idDocente and d.idDocente = f.idFuncionario and f.Nombre = '" & cbox_docente.Text & "'")

            If label.Rows.Count > 0 Then
                lbl_matricula.Text = label.Rows(0).Item(0).ToString
            Else
                lbl_matricula.Text = ""
            End If

        End If
    End Sub

    Private Sub lbl_matricula_TextChanged(sender As System.Object, e As System.EventArgs) Handles lbl_matricula.TextChanged
        Dim l As DataTable = con.doQuery("SELECT Modelo FROM Auto_Escuela WHERE Matricula = '" & lbl_matricula.Text & "'")

        If l.Rows.Count > 0 Then
            lbl_marca.Text = l.Rows(0).Item(0).ToString
        Else
            lbl_marca.Text = ""
        End If
    End Sub

    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        If validar() Then
            Dim Fecha As String = Format(date_Fecha.Value, "yyyy-MM-dd")
            cbox_docente.Text = cbox_docente.Text.Trim
            cbox_estudiante.Text = cbox_estudiante.Text.Trim
            cbox_clasedia.Text = cbox_clasedia.Text.Trim
            Dim Auto As String = lbl_matricula.Text
            Dim Funcionario As String = cbox_docente.SelectedValue
            Dim Estudiante As String = cbox_estudiante.SelectedValue
            Dim Curso As Integer = cbox_clasedia.SelectedValue
            Dim Horario As String = ""
            Dim Asis As Integer = CInt(tbox_numero.Text)

            Dim ID As Integer = 0
            Dim Columnas() As String = {}
            Dim Parametros() As String = {}

            If (CInt(sbox_hor2.Text) <= 9) Then
                Horario = sbox_hor1.Text & ":" & "0" & sbox_hor2.Text & ":00"
            Else
                Horario = sbox_hor1.Text & ":" & sbox_hor2.Text & ":00"
            End If

            Try
                con.beginTransaction()

                Columnas = {"idAsistencia", "Estudiante", "Fecha", "Horario"}
                Parametros = {Asis, Estudiante, Fecha, Horario}
                ID = con.doInsert("Asistencia", Columnas, Parametros)
                Dim AUX As Integer = ID

                If tipo.Equals("Asistencia Teorica") Then

                    If ID <> -1 Then
                        Columnas = {"Teoria", "Estudiante"}
                        Parametros = {Curso, Estudiante}
                        ID = con.doInsert("Teoria_Estudiante", Columnas, Parametros)
                        If ID <> -1 Then
                            Columnas = {"Asistencia", "Teoria", "Estudiante"}
                            Parametros = {Asis, Curso, Estudiante}
                            ID = con.doInsert("Asistencia_Teoria", Columnas, Parametros)
                        End If
                    End If

                ElseIf tipo.Equals("Asistencia Práctica") Then
                    
                    If ID <> -1 Then
                        Columnas = {"Practica", "Estudiante"}
                        Parametros = {Curso, Estudiante}
                        ID = con.doInsert("Practica_Estudiante", Columnas, Parametros)
                        If ID <> -1 Then
                            Columnas = {"Asistencia", "Estudiante", "Practica", "Auto", "Instructor"}
                            Parametros = {Asis, Estudiante, Curso, Auto, Funcionario}
                            ID = con.doInsert("Asistencia_Practica", Columnas, Parametros)
                        End If
                    End If

                End If

                If ID <> -1 Then
                    con.commitTransaction()
                    lbl_estatus.Text = "Operación realizada con éxito."
                    lbl_estatus.ForeColor = Color.Blue
                    cbox_estudiante.Text = ""
                    lbl_estudiante.Text = ""
                    tbox_numero.Text = ""
                    date_Fecha.Value = Now
                    sbox_hor1.Text = "0"
                    sbox_hor2.Text = "0"
                Else
                    lbl_estatus.Text = "Hubo un error al realizar la operación."
                    lbl_estatus.ForeColor = Color.Red
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub

    
    Private Sub btn_resetear_Click(sender As System.Object, e As System.EventArgs) Handles btn_resetear.Click
        cbox_estudiante.Text = ""
        lbl_estudiante.Text = ""
        tbox_numero.Text = ""
        date_Fecha.Value = Now
        sbox_hor1.Text = "0"
        sbox_hor2.Text = "0"
        cbox_docente.Text = ""
        cbox_clasedia.Text = ""
        lbl_matricula.Text = ""
        lbl_marca.Text = ""
        lbl_estatus.Text = "Usuario: " & USER
        lbl_estatus.ForeColor = Color.Black
    End Sub
End Class