
Public Class newFlota

    'Legislacion de matriculas automovilisticas de Chile
    'http://es.wikipedia.org/wiki/Matr%C3%ADculas_automovil%C3%ADsticas_de_Chile


    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim dc As DataCBOX
    Dim comp As DataTable
    Dim usuario As String = ""
    Dim l As Expresion
    Dim asignar As Boolean = False
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        dc = New DataCBOX(con)
        STATUS = estado
        InitializeComponent()
    End Sub
    Private Sub newFlota_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'esto para que solo usuario pueda ingresar
        loadCBOX("año")
        loadCBOX("Estado")
        loadCBOX("Instructor")
        loadCBOX("Matricula")
    End Sub

    Sub loadCBOX(ByVal s As String)
        If s.Equals("Estado") Then
            cbox_estado.DataSource = con.doQuery("SELECT * FROM Estado_Auto")
            cbox_estado.DisplayMember = "Estado"
            cbox_estado.ValueMember = "Estado"
            cbox_estado.SelectedIndex = -1
            cbox_estado2.DataSource = con.doQuery("SELECT * FROM Estado_Auto")
            cbox_estado2.DisplayMember = "Estado"
            cbox_estado2.ValueMember = "Estado"
            cbox_estado2.SelectedIndex = -1
        ElseIf s.Equals("Matricula") Then
            cbox_matricula.DataSource = con.doQuery("SELECT Matricula FROM Auto_Escuela WHERE Matricula<>'000000'")
            cbox_matricula.DisplayMember = "Matricula"
            cbox_matricula.ValueMember = "Matricula"
            cbox_matricula.SelectedIndex = -1

        ElseIf s.Equals("Instructor") Then
            cbox_instructor.DataSource = dc.Instructores
            cbox_instructor.DisplayMember = "Nombre"
            cbox_instructor.ValueMember = "idFuncionario"
            cbox_instructor.SelectedIndex = -1
            
        ElseIf s.Equals("año") Then
            Dim año As DataTable = New DataTable
            año.Columns.Add("Nombre")
            año.Rows.Add("Pre 2007")
            año.Rows.Add("Post 2007")

            cbox_anios.DataSource = año
            cbox_anios.DisplayMember = "Nombre"
            cbox_anios.ValueMember = "Nombre"
        End If

    End Sub

#Region "VALIDACION DE ENTRADA"

    Function validar1() As Boolean
        STATUS.Text = ""
        STATUS.ForeColor = System.Drawing.SystemColors.ControlText

        'Estado
        Dim de As DataTable = cbox_estado.DataSource
        Dim est As New List(Of String)(de.Rows.Count)
        For Each row As DataRow In de.Rows
            est.Add(row(0))
        Next

        MsgBox(est.Contains(cbox_estado.Text.Trim)) 'arroja el valor si contiene o no (borrar)

        If Not est.Contains(cbox_estado.Text.Trim) Then
            MsgBox("ingrese estado correcto")
            Return False
        End If

        If cbox_estado.Text = "" Then
            MsgBox("Ingrese estado")
            cbox_estado.Focus()
            Return False
        ElseIf tbox_modelo.Text = "" Then
            MsgBox("Ingrese modelo")
            tbox_modelo.Focus()
            Return False
        ElseIf tbox_mat1.Text = "" Or tbox_mat2.Text = "" Or tbox_mat3.Text = "" Then
            MsgBox("Ingrese matricula")
            Return False


        End If

        Return True
    End Function

    Function validar2() As Boolean
        STATUS.Text = ""
        STATUS.ForeColor = System.Drawing.SystemColors.ControlText

        'Matricula
        Dim dr As DataTable = cbox_matricula.DataSource
        Dim lista As New List(Of String)(dr.Rows.Count)
        For Each Row As DataRow In dr.Rows
            lista.Add(Row(0))
        Next

        MsgBox(lista.Contains(cbox_matricula.Text.Trim)) 'arroja el valor si contiene o no (borrar)

        If Not lista.Contains(cbox_matricula.Text.Trim) Then
            MsgBox("Ingrese patente correcta")
            Return False
        End If

        'Estado
        Dim de As DataTable = cbox_estado2.DataSource
        Dim est As New List(Of String)(de.Rows.Count)
        For Each row As DataRow In de.Rows
            est.Add(row(0))
        Next

        MsgBox(est.Contains(cbox_estado2.Text.Trim)) 'arroja el valor si contiene o no (borrar)

        If Not est.Contains(cbox_estado2.Text.Trim) Then
            MsgBox("ingrese estado correcto")
            Return False
        End If

        If cbox_matricula.Text.Trim = "" Then
            MsgBox("Ingrese datos de matricula de auto")
            cbox_matricula.Focus()
            Return False
        ElseIf cbox_estado2.Text = "" Then
            MsgBox("Ingrese estado")
            cbox_estado2.Focus()
            Return False
        
        End If

        Return True
    End Function

#End Region


    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        If validar2() Then
            cbox_matricula.Text = cbox_matricula.Text.Trim
            Dim Matricula As String = cbox_matricula.SelectedValue
            Dim Estado As String = cbox_estado2.SelectedValue

            Dim ID As Integer = 0
            Dim Columnas() As String = {}
            Dim Parametros() As String = {}

            Try
                con.beginTransaction()
                Dim modi As DataTable = con.doQuery("UPDATE auto_escuela SET Estado= '" & Estado & "' WHERE Matricula= '" & Matricula & "'")
                If modi.Rows.Count > 0 Then
                    ID = -1
                Else
                    ID = 0
                End If

                If ID <> -1 Then
                    con.commitTransaction()
                    MsgBox("Auto: " & Matricula & ", Estado: " & Estado & ".")
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

    Private Sub btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles btn_agregar.Click
        Dim Matricula As String = ""
        l = New Expresion
        Dim V As MsgBoxResult
        Dim ID As Integer = 0

        If asignar = False Then
            'COMIENZO DE LA FUNCION, SI FALLA ELIMINA IF Y SE VULEVE DESDE AQUI
            Try
                If cbox_anios.SelectedValue.Equals("Pre 2007") Then
                    l.Validando("expletrauno", tbox_mat1)
                    l.Validando("expnumdos", tbox_mat2)
                    l.Validando("expnumuno", tbox_mat3)

                ElseIf cbox_anios.SelectedValue.Equals("Post 2007") Then
                    l.Validando("expletrados", tbox_mat1)
                    l.Validando("expletrados", tbox_mat2)
                    l.Validando("expnumdos", tbox_mat3)
                End If
                If validar1() And (tbox_mat1.ForeColor <> Color.Red Or tbox_mat2.ForeColor <> Color.Red Or tbox_mat3.ForeColor <> Color.Red) Then
                    If cbox_anios.SelectedValue.Equals("Pre 2007") Then
                        Matricula = UCase(tbox_mat1.Text) & (tbox_mat2.Text) & (tbox_mat3.Text)

                    ElseIf cbox_anios.SelectedValue.Equals("Post 2007") Then
                        Matricula = UCase(tbox_mat1.Text) & UCase(tbox_mat2.Text) & (tbox_mat3.Text)

                    End If
                    Dim Modelo As String = tbox_modelo.Text

                    Dim Estado As String = cbox_estado.SelectedValue

                    'Dim ID As Integer = 0
                    Dim Columnas() As String = {}
                    Dim Parametros() As String = {}

                    Try
                        con.beginTransaction()
                        Columnas = {"Matricula", "Modelo", "Estado"}
                        Parametros = {Matricula, Modelo, Estado}
                        'Insertar auto_escuela
                        ID = insertar(Columnas, Parametros)
                        'ID = con.doInsert("auto_escuela", Columnas, Parametros)
                        If ID <> -1 Then
                            V = MsgBox("Desea agregar instructor ahora o no", 4, "Confirmacion")
                            If V = MsgBoxResult.Yes Then
                                lbl_pers.Visible = True
                                cbox_instructor.Visible = True
                                btn_retract.Visible = True
                                asignar = True
                                btn_agregar.Text = "Asignar"

                            ElseIf V = MsgBoxResult.No Then
                                ID = 0
                                If ID <> -1 Then
                                    con.commitTransaction()
                                    STATUS.Text = "Operación realizada con éxito."
                                    STATUS.ForeColor = Color.Blue
                                Else
                                    STATUS.Text = "Hubo un error al realizar la operación."
                                    STATUS.ForeColor = Color.Red
                                End If
                                tbox_mat1.Text = ""
                                tbox_mat2.Text = ""
                                tbox_mat3.Text = ""
                                tbox_modelo.Text = ""
                            End If
                        End If

                        
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
                End If
            Catch ex As Exception

            End Try
        ElseIf asignar = True Then
            
            If cbox_anios.SelectedValue.Equals("Pre 2007") Then
                Matricula = UCase(tbox_mat1.Text) & (tbox_mat2.Text) & (tbox_mat3.Text)

            ElseIf cbox_anios.SelectedValue.Equals("Post 2007") Then
                Matricula = UCase(tbox_mat1.Text) & UCase(tbox_mat2.Text) & (tbox_mat3.Text)

            End If
            Dim Instructor As String = cbox_instructor.SelectedValue.ToString

            Dim inst As DataTable = con.doQuery("UPDATE instructor SET Auto= '" & Matricula & "' WHERE idInstructor= '" & Instructor & "'")
            If inst.Rows.Count > 0 Then
                ID = -1
            Else
                ID = 0
            End If
            If ID <> -1 Then
                con.commitTransaction()
                STATUS.Text = "Operación realizada con éxito."
                STATUS.ForeColor = Color.Blue
            Else
                STATUS.Text = "Hubo un error al realizar la operación."
                STATUS.ForeColor = Color.Red
            End If
            tbox_mat1.Text = ""
            tbox_mat2.Text = ""
            tbox_mat3.Text = ""
            tbox_modelo.Text = ""
            cbox_instructor.Visible = False
            lbl_pers.Visible = False
            btn_retract.Visible = False
        End If
        
    End Sub

    Private Sub btn_resetear01_Click(sender As System.Object, e As System.EventArgs) Handles btn_resetear01.Click
        tbox_mat1.Text = ""
        tbox_mat2.Text = ""
        tbox_mat3.Text = ""
        cbox_estado.Text = ""
        tbox_modelo.Text = ""
        cbox_instructor.Visible = False
        lbl_pers.Visible = False
        btn_retract.Visible = False
    End Sub



    Private Sub cbox_anios_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbox_anios.SelectedIndexChanged
        If cbox_anios.SelectedValue.Equals("Pre 2007") Then
            'Formato AA-10.00
            tbox_mat1.Text = ""
            tbox_mat2.Text = ""
            tbox_mat3.Text = ""
            tbox_mat1.Tipo = CustomTxtBox.Custom2.Tipologia.LETRA
            tbox_mat2.Tipo = CustomTxtBox.Custom2.Tipologia.NUMERO
            tbox_mat3.Tipo = CustomTxtBox.Custom2.Tipologia.NUMERO
        ElseIf cbox_anios.SelectedValue.Equals("Post 2007") Then
            'Formato BB-BB.10
            tbox_mat1.Text = ""
            tbox_mat2.Text = ""
            tbox_mat3.Text = ""
            tbox_mat1.Tipo = CustomTxtBox.Custom2.Tipologia.LETRA
            tbox_mat2.Tipo = CustomTxtBox.Custom2.Tipologia.LETRA
            tbox_mat3.Tipo = CustomTxtBox.Custom2.Tipologia.NUMERO
        End If

    End Sub

    Private Sub btn_resetear02_Click(sender As System.Object, e As System.EventArgs) Handles btn_resetear02.Click
        cbox_matricula.Text = ""
        cbox_estado2.Text = ""

    End Sub

    
    Private Sub cbox_matricula_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbox_matricula.SelectedIndexChanged
        Dim label As DataTable = con.doQuery("SELECT f.Nombre " _
                                        & "FROM instructor i, docente d, funcionario f" _
                                         & " WHERE i.idINSTRUCTOR = d.idDOCENTE and d.idDOCENTE = f.idFUNCIONARIO and i.Auto ='" & cbox_matricula.Text & "'")

        If label.Rows.Count > 0 Then
            lbl_instructor.Text = label.Rows(0).Item(0).ToString
            lbl_fict.Visible = True
        Else
            lbl_instructor.Text = ""
            lbl_fict.Visible = False
        End If
    End Sub

    Function insertar(ByVal Columnas() As String, ByVal Parametros() As String) As Integer
        Dim ID As Integer = 0
        ID = con.doInsert("auto_escuela", Columnas, Parametros)
        Return ID
    End Function
    
    Private Sub btn_retract_Click(sender As System.Object, e As System.EventArgs) Handles btn_retract.Click
        asignar = False

    End Sub
End Class