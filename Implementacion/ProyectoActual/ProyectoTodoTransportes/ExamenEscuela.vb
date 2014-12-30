Public Class ExamenEscuela
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

    Private Sub ExamenEscuela_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        rbtn_aprobado.Checked = True
        tbox_calTeo.Enabled = False
        tbox_calPract.Enabled = False
        rtbox_comentario.Enabled = False
        chbox_cert.Enabled = False
        
        cbox_funcionario.Enabled = False
        sbox_hor1.Enabled = False
        sbox_hor2.Enabled = False

        loadCBOX("Matricula")
        loadCBOX("Tipo")
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
        ElseIf Nombre.Equals("Tipo") Then
            cbox_tipo.DataSource = con.doQuery("SELECT Nombre FROM Tipo_Documento WHERE Nombre <> 'Matricula'")
            cbox_tipo.DisplayMember = "Nombre"
            cbox_tipo.ValueMember = "Nombre"
            cbox_tipo.SelectedIndex = -1
        ElseIf Nombre.Equals("Profesores") Then
            cbox_funcionario.DataSource = datacbox.Profesores
            cbox_funcionario.DisplayMember = "Nombre"
            cbox_funcionario.ValueMember = "Nombre"
            cbox_funcionario.SelectedIndex = -1
        ElseIf Nombre.Equals("Instructores") Then
            cbox_funcionario.DataSource = datacbox.Instructores
            cbox_funcionario.DisplayMember = "Nombre"
            cbox_funcionario.ValueMember = "Nombre"
            cbox_funcionario.SelectedIndex = -1
        End If

    End Sub

    Function validar() As Boolean

        If cbox_matricula.Text = "" Then
            MsgBox("Ingrese datos de matricula")
            Return False
        ElseIf cbox_tipo.Text = "" Then
            MsgBox("Ingrese tipo de examen")
            Return False
        ElseIf cbox_funcionario.Text = "" Then
            MsgBox("Ingrese datos de funcionario")
            Return False
        ElseIf chbox_cert.Checked = False And cbox_tipo.Text.Equals("Examen Visual") Then
            MsgBox("Debe de haber un certificado oftalmologico que almacenar")
            Return False
        ElseIf rbtn_aprobado.Checked = False And rbtn_reprobado.Checked = False And Not cbox_tipo.Text.Equals("Cambio Rueda") Then
            MsgBox("Seleccione una opción de aprobación")
            Return False
        ElseIf tbox_calTeo.Text.Trim.Equals("") And cbox_tipo.Text.Equals("Examen Teorico") Then
            MsgBox("Ingrese Calificación Teorica")
            Return False
        ElseIf tbox_calPract.Text.Trim.Equals("") And cbox_tipo.Text.Equals("Examen Practico") Then
            MsgBox("Ingrese Calificación Practica")
            Return False
        ElseIf CInt(sbox_hor1.Text) <> 10 And CInt(sbox_hor1.Text) <> 12 And CInt(sbox_hor1.Text) <> 17 And cbox_tipo.Text.Equals("Cambio Rueda") Then
            MsgBox("La hora: " & sbox_hor1.Text & ":00 no es una hora dentro de las posibilidades de horarios de clases")
            Return False
        ElseIf CInt(sbox_hor2.Text) <> 0 And cbox_tipo.Text.Equals("Cambio Rueda") Then
            MsgBox("La hora debe ser exacta")
            Return False
        
        End If

        Return True
    End Function
#End Region

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

    Private Sub cbox_tipo_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_tipo.SelectedValueChanged
        If cbox_tipo.Text.Equals("Examen Teorico") Then
            tbox_calPract.Enabled = False
            rtbox_comentario.Enabled = False
            sbox_hor1.Enabled = False
            sbox_hor2.Enabled = False
            chbox_cert.Enabled = False
            cbox_matricula.SelectedIndex = -1

            cbox_funcionario.Enabled = True
            loadCBOX("Profesores")
            tbox_calTeo.Enabled = True
        ElseIf cbox_tipo.Text.Equals("Examen Practico") Then
            tbox_calTeo.Enabled = False
            rtbox_comentario.Enabled = False
            sbox_hor1.Enabled = False
            sbox_hor2.Enabled = False
            chbox_cert.Enabled = False
            cbox_matricula.SelectedIndex = -1

            cbox_funcionario.Enabled = True
            loadCBOX("Instructores")
            tbox_calPract.Enabled = True
        ElseIf cbox_tipo.Text.Equals("Examen Municipal") Then
            tbox_calTeo.Enabled = False
            tbox_calPract.Enabled = False
            sbox_hor1.Enabled = False
            sbox_hor2.Enabled = False
            chbox_cert.Enabled = False
            cbox_matricula.SelectedIndex = -1

            cbox_funcionario.Enabled = True
            loadCBOX("Funcionario")
            rtbox_comentario.Enabled = True
        ElseIf cbox_tipo.Text.Equals("Cambio Rueda") Then
            tbox_calTeo.Enabled = False
            tbox_calPract.Enabled = False
            rtbox_comentario.Enabled = False
            chbox_cert.Enabled = False
            
            cbox_matricula.SelectedIndex = -1

            cbox_funcionario.Enabled = True
            loadCBOX("Funcionario")
            sbox_hor1.Enabled = True
            sbox_hor2.Enabled = True
        ElseIf cbox_tipo.Text.Equals("Examen Visual") Then
            tbox_calTeo.Enabled = False
            tbox_calPract.Enabled = False
            sbox_hor1.Enabled = False
            sbox_hor2.Enabled = False
            rtbox_comentario.Enabled = False
            cbox_matricula.SelectedIndex = -1

            cbox_funcionario.Enabled = True
            loadCBOX("Funcionario")
            chbox_cert.Enabled = True
        ElseIf cbox_tipo.Text.Equals("Examen Psicotécnico") Then
            tbox_calTeo.Enabled = False
            tbox_calPract.Enabled = False
            sbox_hor1.Enabled = False
            sbox_hor2.Enabled = False
            chbox_cert.Enabled = False
            rtbox_comentario.Enabled = False
            cbox_matricula.SelectedIndex = -1

            cbox_funcionario.Enabled = True
            loadCBOX("Funcionario")
        End If

    End Sub

    Private Sub btn_guradar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guradar.Click
        Dim Documento As Integer = 0
        Dim Funcionario As Integer = 0
        Dim Cliente As String = ""
        Dim Horario As String = ""
        Dim Comentario As String = ""
        'Queries de registro para documento
        Dim D As Integer = 0

        'Queries de registro para los seis documentos
        Dim Ev As Integer = 0
        Dim Et As Integer = 0
        Dim Ep As Integer = 0
        Dim Em As Integer = 0
        Dim Ps As Integer = 0
        Dim Cr As Integer = 0

        'Queries de registro para estudiante _documento
        Dim Ed As Integer = 0
        If validar() Then
            If cbox_tipo.Text.Equals("Examen Teorico") Then
                Dim Calificacion As Integer = CInt(tbox_calTeo.Text)
                Dim Fecha As String = Format(date_prueba.Value, "yyyy-MM-dd")
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
                'Columnas y parametros de la query documento'
                Dim ColDoc() As String = {"Tipo", "Funcionario", "Fecha", "Estado"}
                Dim ParDocAp() As String = {Tipo, Funcionario, Fecha, "Aprobado"}
                Dim ParDocRep() As String = {Tipo, Funcionario, Fecha, "Reprobado"}

                Try
                    con.beginTransaction()
                    If rbtn_aprobado.Checked Then
                        D = con.doInsert("Documento", ColDoc, ParDocAp)
                        MsgBox("El estudiante : " & Cliente & " puede dar la clase practica con calificacion " & (Calificacion / 10) & "")
                    ElseIf rbtn_reprobado.Checked Then
                        D = con.doInsert("Documento", ColDoc, ParDocRep)
                        MsgBox("El estudiante : " & Cliente & " no puede dar la clase practica con calificacion " & (Calificacion / 10) & "")
                    End If


                    Dim Doc As DataTable = con.doQuery("SELECT max(idDOCUMENTO) AS idDOCUMENTO  FROM Documento")
                    If Doc.Rows.Count > 0 Then
                        Documento = CInt(Doc.Rows(0).Item(0).ToString)
                    Else
                        Documento = 0
                    End If

                    'Examen Teorico'
                    'Columnas y parametros de la query examen teorico'

                    Dim ColEt() As String = {"Documento", "Calificacion"}
                    Dim ParEt() As String = {Documento, Calificacion}
                    Et = con.doInsert("EXAMEN_TEORICO", ColEt, ParEt)

                    'Estudiante Documento'
                    'Columnas y parametros de la query estudiante documento'
                    Dim ColEd() As String = {"Estudiante", "Documento"}
                    Dim ParEd() As String = {Estudiante, Documento}
                    Ed = con.doInsert("ESTUDIANTE_DOCUMENTO", ColEd, ParEd)

                    If D <> -1 And Et <> -1 And Ed <> -1 Then
                        con.commitTransaction()
                    Else
                        STATUS.Text = "Documento de Examen Teorico de: " & Cliente & " no fue agregado."
                    End If

                    STATUS.Text = "Examen Teorico de: " & Cliente & " fue agregada exitosamente."
                    cbox_matricula.Text = ""
                    tbox_calTeo.Text = ""
                    lbl_estudiante.Text = ""
                Catch ex As Exception
                    STATUS.Text = "Examen Teorico de: " & Cliente & " no fue agregado."
                End Try
            ElseIf cbox_tipo.Text.Equals("Examen Practico") Then
                Dim Calificacion As Integer = CInt(tbox_calPract.Text)
                Dim Fecha As String = Format(date_prueba.Value, "yyyy-MM-dd")
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
            ElseIf cbox_tipo.Text.Equals("Examen Municipal") Then
                Dim Fecha As String = Format(date_prueba.Value, "yyyy-MM-dd")
                Dim Fun As DataTable = con.doQuery("SELECT idFuncionario " _
                                            & "FROM Funcionario" _
                                             & " WHERE Nombre = '" & cbox_funcionario.Text & "'")
                If Fun.Rows.Count > 0 Then
                    Funcionario = CInt(Fun.Rows(0).Item(0).ToString)
                Else
                    Funcionario = 0
                End If
                Dim Tipo As String = "Examen Municipal"
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
                        MsgBox("El estudiante : " & Cliente & " puede obtener la licencia")
                    ElseIf rbtn_reprobado.Checked Then
                        D = con.doInsert("Documento", ColDoc, ParDocRep)
                        MsgBox("El estudiante : " & Cliente & " no puede obtener la licencia")
                    End If

                    Dim Doc As DataTable = con.doQuery("SELECT max(idDOCUMENTO) AS idDOCUMENTO  FROM Documento")
                    If Doc.Rows.Count > 0 Then
                        Documento = CInt(Doc.Rows(0).Item(0).ToString)
                    Else
                        Documento = 0
                    End If

                    'Examen Municipal'
                    'Columnas y parametros de la query examen municipal'

                    Dim ColEm() As String = {"Documento", "Comentario"}
                    Dim ParEm() As String = {Documento, Comentario}
                    Em = con.doInsert("EXAMEN_MUNICIPAL", ColEm, ParEm)

                    'Estudiante Documento'
                    'Columnas y parametros de la query estudiante documento'
                    Dim ColEd() As String = {"Estudiante", "Documento"}
                    Dim ParEd() As String = {Estudiante, Documento}
                    Ed = con.doInsert("ESTUDIANTE_DOCUMENTO", ColEd, ParEd)

                    If D <> -1 And Em <> -1 And Ed <> -1 Then
                        con.commitTransaction()
                    Else
                        STATUS.Text = "Documento de Examen Municipal de: " & Cliente & " no fue agregado."
                    End If

                    STATUS.Text = "Examen Municipal de: " & Cliente & " fue agregada exitosamente."
                    rtbox_comentario.Text = ""
                    cbox_matricula.Text = ""
                    lbl_estudiante.Text = ""
                Catch ex As Exception
                    STATUS.Text = "Examen Municipal de: " & Cliente & " no fue agregado."
                End Try
            ElseIf cbox_tipo.Text.Equals("Cambio Rueda") Then
                Dim Fecha As String = Format(date_prueba.Value, "yyyy-MM-dd")
                Dim Fun As DataTable = con.doQuery("SELECT idFuncionario " _
                                            & "FROM Funcionario" _
                                             & " WHERE Nombre = '" & cbox_funcionario.Text & "'")
                If (CInt(sbox_hor2.Text) <= 9) Then
                    Horario = sbox_hor1.Text & ":" & "0" & sbox_hor2.Text & ":00"
                Else
                    Horario = sbox_hor1.Text & ":" & sbox_hor2.Text & ":00"
                End If
                If Fun.Rows.Count > 0 Then
                    Funcionario = CInt(Fun.Rows(0).Item(0).ToString)
                Else
                    Funcionario = 0
                End If
                Dim Tipo As String = "Cambio Rueda"
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
                Try
                    con.beginTransaction()

                    D = con.doInsert("Documento", ColDoc, ParDocAp)


                    Dim Doc As DataTable = con.doQuery("SELECT max(idDOCUMENTO) AS idDOCUMENTO  FROM Documento")
                    If Doc.Rows.Count > 0 Then
                        Documento = CInt(Doc.Rows(0).Item(0).ToString)
                    Else
                        Documento = 0
                    End If

                    'Clase Cambio Rueda'
                    'Columnas y parametros de la query clase cambio rueda'

                    Dim ColCr() As String = {"Documento", "Horario"}
                    Dim ParCr() As String = {Documento, Horario}
                    Cr = con.doInsert("CAMBIO_RUEDA", ColCr, ParCr)

                    'Estudiante Documento'
                    'Columnas y parametros de la query estudiante documento'
                    Dim ColEd() As String = {"Estudiante", "Documento"}
                    Dim ParEd() As String = {Estudiante, Documento}
                    Ed = con.doInsert("ESTUDIANTE_DOCUMENTO", ColEd, ParEd)

                    If D <> -1 And Cr <> -1 And Ed <> -1 Then
                        con.commitTransaction()
                    Else
                        STATUS.Text = "Documento de Clase Cambio Rueda de: " & Cliente & " no fue agregado."
                    End If

                    STATUS.Text = "Clase Cambio Rueda de: " & Cliente & " fue agregada exitosamente."
                    cbox_matricula.Text = ""
                    lbl_estudiante.Text = ""
                Catch ex As Exception
                    STATUS.Text = "Clase Cambio Rueda de: " & Cliente & " no fue agregado."
                End Try
            ElseIf cbox_tipo.Text.Equals("Examen Visual") Then
                Dim Fecha As String = Format(date_prueba.Value, "yyyy-MM-dd")
                Dim Fun As DataTable = con.doQuery("SELECT idFuncionario " _
                                            & "FROM Funcionario" _
                                             & " WHERE Nombre = '" & cbox_funcionario.Text & "'")
                If Fun.Rows.Count > 0 Then
                    Funcionario = CInt(Fun.Rows(0).Item(0).ToString)
                Else
                    Funcionario = 0
                End If
                Dim Tipo As String = "Examen Visual"
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
                        MsgBox("El examen visual de : " & Cliente & " fue aprobado")
                    ElseIf rbtn_reprobado.Checked Then
                        D = con.doInsert("Documento", ColDoc, ParDocRep)
                        MsgBox("El examen visual de : " & Cliente & " fue reprobado")
                    End If

                    Dim Doc As DataTable = con.doQuery("SELECT max(idDOCUMENTO) AS idDOCUMENTO  FROM Documento")
                    If Doc.Rows.Count > 0 Then
                        Documento = CInt(Doc.Rows(0).Item(0).ToString)
                    Else
                        Documento = 0
                    End If

                    'examen visual'
                    'Columnas y parametros de la query examen visual'
                    Dim ColEv() As String = {"Documento", "Certificado"}
                    Dim ParEv() As String = {Documento, 1}
                    Ev = con.doInsert("EXAMEN_VISUAL", ColEv, ParEv)

                    'Estudiante Documento'
                    'Columnas y parametros de la query estudiante documento'
                    Dim ColEd() As String = {"Estudiante", "Documento"}
                    Dim ParEd() As String = {Estudiante, Documento}
                    Ed = con.doInsert("ESTUDIANTE_DOCUMENTO", ColEd, ParEd)

                    If D <> -1 And Ev <> -1 And Ed <> -1 Then
                        con.commitTransaction()
                    Else
                        STATUS.Text = "El examen visual de: " & Cliente & " no fue agregado como debe ser."
                    End If

                    STATUS.Text = "examen visual de: " & Cliente & " fue agregado exitosamente."
                    lbl_estudiante.Text = ""
                    cbox_matricula.Text = ""
                    chbox_cert.Checked = False
                Catch ex As Exception
                    STATUS.Text = "Examen Visual de: " & Cliente & " no fue agregado."
                End Try
            ElseIf cbox_tipo.Text.Equals("Examen Psicotécnico") Then
                Dim Fecha As String = Format(date_prueba.Value, "yyyy-MM-dd")

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

        End If
    End Sub

    Private Sub btn_reset_Click(sender As System.Object, e As System.EventArgs) Handles btn_reset.Click
        date_prueba.Value = Now
        sbox_hor1.Value = "0"
        sbox_hor2.Value = "0"
        tbox_calTeo.Text = ""
        chbox_cert.Checked = False
        tbox_calPract.Text = ""
        cbox_matricula.Text = ""
        cbox_tipo.Text = ""
        cbox_funcionario.Text = ""
        rbtn_aprobado.Checked = False
        rbtn_reprobado.Checked = False
        STATUS.Text = "Usuario " & USER & ""
    End Sub
End Class