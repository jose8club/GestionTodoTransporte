Public Class Asistencia
    Dim con As New Conexion

    Dim USER As String = ""
    Dim datacbox As DataCBOX
    Dim tipo As String = ""
    Dim dgvColumnCheck As DataGridViewCheckBoxColumn
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal texto As String)
        con = conexion
        USER = usuario
        tipo = texto
        datacbox = New DataCBOX(con)
        InitializeComponent()
    End Sub
    Private Sub Asistencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbl_estado.Text = "Usuario: " & USER
        If tipo.Equals("Asistencia Teorica") Then
            grp_asistencia.Text = "Asistencia Teorica"
            lbl_vehiculo.Visible = False
            lbl_matricula.Visible = False
            lbl_marca.Visible = False
            lbl_docente.Text = "Profesor"
            loadCBOX("Profesor")
            loadCBOX("Clase Teorica")
            loadLista()
        ElseIf tipo.Equals("Asistencia Práctica") Then
            grp_asistencia.Text = "Asistencia Práctica"
            lbl_docente.Text = "Instructor"
            loadCBOX("Instructores")
            loadCBOX("Clase Practica")
            loadLista()
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

    Sub loadLista()

        Dim HeaderText(1) As String
        HeaderText(0) = "Nombre Estudiante"
        HeaderText(1) = "Asistió o no"

        For i As Integer = 0 To 1
            If i = 1 Then
                dgvColumnCheck = New DataGridViewCheckBoxColumn()
                dgvColumnCheck.Name = HeaderText(i)
                dgvColumnCheck.HeaderText = HeaderText(i)
                DataGridView1.Columns.Add(dgvColumnCheck)
            Else
                Dim data As DataTable = con.doQuery("SELECT Nombre FROM Cliente WHERE TipoCliente='Estudiante'")

                If data.Rows.Count > 0 Then
                    DataGridView1.DataSource = data
                End If
            End If
        Next
        

    End Sub

    Function Horarios(ByVal Hora As String, ByVal Minutos As String) As String
        Dim Horario As String = ""
        If (CInt(Minutos) <= 9) Then
            Horario = Hora & ":" & "0" & Minutos & ":00"
        Else
            Horario = Hora & ":" & Minutos & ":00"
        End If
        Return Horario
    End Function

    Function validar() As Boolean
        lbl_estado.Text = ""
        lbl_estado.ForeColor = System.Drawing.SystemColors.ControlText

        'Docentes
        Dim dr As DataTable = cbox_docente.DataSource
        Dim lista As New List(Of String)(dr.Rows.Count)
        For Each Row As DataRow In dr.Rows
            lista.Add(Row(1))
        Next

        If Not lista.Contains(cbox_docente.Text.Trim) Then
            MsgBox("Ingrese funcionario correcto")
            Return False
        End If

        
        If cbox_docente.Text = "" Then
            MsgBox("Ingrese datos de funcionario")
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


    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        Dim Estudiante As String = ""
        Dim Valor As Boolean

        If validar() Then
            For Each Row As DataGridViewRow In DataGridView1.Rows
                Dim label As DataTable = con.doQuery("SELECT m.codigo " _
                                        & "FROM cliente cl, compra co, matricula m" _
                                         & " WHERE cl.idCliente = co.cliente and co.idCompra = m.codigocompra and cl.Nombre = '" & CStr(Row.Cells("Nombre").Value) & "'")

                If label.Rows.Count > 0 Then
                    Estudiante = label.Rows(0).Item(0).ToString
                End If

                Valor = CBool(Row.Cells("Asistió o no").Value)
                If Valor = True Then

                    Dim Fecha As String = Format(date_Fecha.Value, "yyyy-MM-dd")
                    cbox_docente.Text = cbox_docente.Text.Trim
                    cbox_clasedia.Text = cbox_clasedia.Text.Trim

                    Dim Funcionario As String = cbox_docente.SelectedValue
                    Dim Curso As Integer = cbox_clasedia.SelectedValue
                    Dim Horario As String = ""

                    Dim Auto As String = lbl_matricula.Text

                    If (CInt(sbox_hor2.Text) <= 9) Then
                        Horario = sbox_hor1.Text & ":" & "0" & sbox_hor2.Text & ":00"
                    Else
                        Horario = sbox_hor1.Text & ":" & sbox_hor2.Text & ":00"
                    End If

                    Dim ID As Integer = 0
                    Dim Columnas() As String = {}
                    Dim Parametros() As String = {}

                    Try
                        con.beginTransaction()
                        Columnas = {"Estudiante", "Fecha", "Horario"}
                        Parametros = {Estudiante, Fecha, Horario}
                        ID = con.doInsert("Asistencia", Columnas, Parametros)
                        Dim AUX As Integer = ID

                        If tipo.Equals("Asistencia Teorica") Then

                            If ID <> -1 Then
                                Columnas = {"Teoria", "Estudiante"}
                                Parametros = {Curso, Estudiante}
                                ID = con.doInsert("Teoria_Estudiante", Columnas, Parametros)
                                If ID <> -1 Then
                                    Columnas = {"Asistencia", "Teoria", "Estudiante"}
                                    Parametros = {AUX, Curso, Estudiante}
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
                                    Parametros = {AUX, Estudiante, Curso, Auto, Funcionario}
                                    ID = con.doInsert("Asistencia_Practica", Columnas, Parametros)
                                End If
                            End If

                        End If

                        If ID <> -1 Then
                            con.commitTransaction()
                            lbl_estado.Text = "Operación realizada con éxito."
                            lbl_estado.ForeColor = Color.Blue
                            date_Fecha.Value = Now
                            sbox_hor1.Text = "0"
                            sbox_hor2.Text = "0"
                        Else
                            lbl_estado.Text = "Hubo un error al realizar la operación."
                            lbl_estado.ForeColor = Color.Red
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try

                End If
            Next
            
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

    Private Sub btn_resetear_Click(sender As System.Object, e As System.EventArgs) Handles btn_resetear.Click
        
        date_Fecha.Value = Now
        sbox_hor1.Text = "0"
        sbox_hor2.Text = "0"
        cbox_docente.Text = ""
        cbox_clasedia.Text = ""
        lbl_matricula.Text = ""
        lbl_marca.Text = ""
        lbl_estado.Text = "Usuario: " & USER
        lbl_estado.ForeColor = Color.Black
    End Sub

    
End Class