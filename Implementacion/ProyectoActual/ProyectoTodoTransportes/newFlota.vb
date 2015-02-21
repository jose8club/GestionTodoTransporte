
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
    'Flag utilizada para poder asignar un instructor después de presionar el boton por primera vez
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

    Function validarAgregar() As Boolean
        'Valida el primer formulario: agregar nuevo vehiculo
        STATUS.Text = ""
        STATUS.ForeColor = System.Drawing.SystemColors.ControlText

        'Estado
        Dim de As DataTable = cbox_estado.DataSource
        Dim est As New List(Of String)(de.Rows.Count)
        For Each row As DataRow In de.Rows
            est.Add(row(0))
        Next


        If Not est.Contains(cbox_estado.Text.Trim) Then
            'Si el combo box del estado del vehiculo esta vacio
            'entrega un mensaje que dice que entregue un estado correcto
            'en el caso de escribirlo manualmente
            MsgBox("ingrese estado correcto", MsgBoxStyle.Exclamation, "Atención")
            Return False
        End If

        If cbox_estado.Text = "" Then
            'Si el combo box de estado esta vacio
            'entrega un mensaje que dice que debe llenarlo
            MsgBox("Ingrese estado", MsgBoxStyle.Exclamation, "Atención")
            cbox_estado.Focus()
            Return False
        ElseIf tbox_modelo.Text = "" Then
            'Si el texto de modelo esta vacio
            'entrega un mensaje que dice que debe llenarlo
            MsgBox("Ingrese modelo", MsgBoxStyle.Exclamation, "Atención")
            tbox_modelo.Focus()
            Return False
        ElseIf tbox_mat1.Text = "" Or tbox_mat2.Text = "" Or tbox_mat3.Text = "" Then
            'Si cualquiera de los tres textos de matricula esta vacio
            'entrega un mensaje que dice que debe llenarlo
            MsgBox("Ingrese matricula", MsgBoxStyle.Exclamation, "Atención")
            Return False


        End If

        Return True
    End Function

    Function validarActualizar() As Boolean
        'Valida el segundo formulario: gestion de flota
        STATUS.Text = ""
        STATUS.ForeColor = System.Drawing.SystemColors.ControlText

        'Matricula
        Dim dr As DataTable = cbox_matricula.DataSource
        Dim lista As New List(Of String)(dr.Rows.Count)
        For Each Row As DataRow In dr.Rows
            lista.Add(Row(0))
        Next


        If Not lista.Contains(cbox_matricula.Text.Trim) Then
            'Si el combo box de la patente del vehiculo esta vacio
            'entrega un mensaje que dice que entregue un estado correcto
            'en el caso de escribirlo manualmente
            MsgBox("Ingrese patente correcta", MsgBoxStyle.Exclamation, "Atención")
            Return False
        End If

        'Estado
        Dim de As DataTable = cbox_estado2.DataSource
        Dim est As New List(Of String)(de.Rows.Count)
        For Each row As DataRow In de.Rows
            est.Add(row(0))
        Next

        'se debe ver el estado actual del vehiculo
        Dim estadoActual As String = ""
        Dim modi As DataTable = con.doQuery("SELECT Estado FROM auto_escuela WHERE Matricula='" & cbox_matricula.Text & "'")
        If modi.Rows.Count > 0 Then
            estadoActual = modi.Rows(0).Item(0).ToString
        Else
            estadoActual = ""
        End If

        If Not est.Contains(cbox_estado2.Text.Trim) Then
            'Si el combo box de estado de vehiculo esta vacio
            'entrega un mensaje que dice que entregue un estado correcto
            'en el caso de escribirlo manualmente
            MsgBox("ingrese estado correcto", MsgBoxStyle.Exclamation, "Atención")
            Return False
        End If

        If cbox_matricula.Text.Trim = "" Then
            'Si el combo box de matricula de vehiculo esta vacio
            'entrega un mensaje que dice que debe llenarlo
            MsgBox("Ingrese datos de matricula de auto", MsgBoxStyle.Exclamation, "Atención")
            cbox_matricula.Focus()
            Return False
        ElseIf cbox_estado2.Text = "" Then
            'Si el combo box de estado esta vacio
            'entrega un mensaje que dice que debe llenarlo
            MsgBox("Ingrese estado", MsgBoxStyle.Exclamation, "Atención")
            cbox_estado2.Focus()
            Return False
        ElseIf cbox_estado2.Text.Equals(estadoActual) Then
            'Si el estado actual es igual al que se quiere cambiar se debe impedir
            MsgBox("Ingrese un estado diferente al actual", MsgBoxStyle.Exclamation, "Atención")
            cbox_estado2.Focus()
            Return False
        End If

        Return True
    End Function

#End Region


    Private Sub btn_actualizar_Click(sender As System.Object, e As System.EventArgs) Handles btn_actualizar.Click
        'boton que cambia el estado de un vehiculo segun su matricula
        'también muestra al instructor al que fue asignado ese vehiculo
        If validarActualizar() Then
            cbox_matricula.Text = cbox_matricula.Text.Trim
            Dim Patente As String = cbox_matricula.SelectedValue
            Dim Estado As String = cbox_estado2.SelectedValue

            Dim ID As Integer = 0
            Dim Columnas() As String = {}
            Dim Parametros() As String = {}

            Try
                con.beginTransaction()
                'proceso de cambio de estado de vehiculo
                Dim modi As DataTable = con.doQuery("UPDATE auto_escuela SET Estado= '" & Estado & "' WHERE Matricula= '" & Patente & "'")
                If modi.Rows.Count > 0 Then
                    ID = -1
                Else
                    ID = 0
                End If

                If ID <> -1 Then
                    'Commit a la modificacion
                    con.commitTransaction()
                    MsgBox("Auto: " & Patente & ", Estado: " & Estado & ".")
                    STATUS.Text = "Operación realizada con éxito."
                    STATUS.ForeColor = Color.Blue
                    resetActualizar()

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
        'Se agrega el nuevo auto cuya cada una de las partes de la patente tiene dos letras
        Dim Patente As String = ""
        l = New Expresion
        'llama a la clase Expresion de Expresion.vb
        Dim V As MsgBoxResult
        Dim ID As Integer = 0
        'Si asignar = false entonces significa que aun no se ha asignado un instructor asociado a un vehiculo
        If Not asignar Then
            Try
                If cbox_anios.SelectedValue.Equals("Pre 2007") Then
                    'Si escoge el estandar de patentes del año Pre 2007 entonces la expresion regular pondrá en rojo
                    'aquellas dos letras escritas en cada cuadro de matricula que no correspondan al protocolo de patentes automovilisticas de 
                    'Chile de antes del 2007 (AA-10-00)
                    l.Validando("expletrauno", tbox_mat1)
                    l.Validando("expnumdos", tbox_mat2)
                    l.Validando("expnumuno", tbox_mat3)

                ElseIf cbox_anios.SelectedValue.Equals("Post 2007") Then
                    'Si escoge el estandar de patentes del Post año 2007 entonces la expresion regular pondrá en rojo
                    'aquellas dos letras escritas en cada cuadro de matricula que no correspondan al protocolo de patentes automovilisticas de 
                    'Chile de despues del 2007 (BB-BB-00)
                    l.Validando("expletrados", tbox_mat1)
                    l.Validando("expletrados", tbox_mat2)
                    l.Validando("expnumdos", tbox_mat3)
                End If
                'l.validando llama a la clase (validando) que mediante su primer parametro indica que expresion regular 
                'debe cumplir cada uno de los textbox de matricula
                '1) expletrauno: su expresion regular niega las letras i,j,k,ñ,o,q en la primera letra y las letras i,j,k,ñ,o,q,m,w en la segunda letra
                '2) expletrados: su expresion regular niega las vocales y las letras m,n,ñ,q en ambas letras
                '3) expnumuno: su expresion regular acepta numeros del 0 al 9 en ambas letras
                '4) expnumdos: su expresion regular acepta numeros del 1 al 9 en la primera letra y del 0 al 9 en la segunda letra
                If validarAgregar() And (tbox_mat1.ForeColor <> Color.Red Or tbox_mat2.ForeColor <> Color.Red Or tbox_mat3.ForeColor <> Color.Red) Then
                    'cuando esta bien escrita cada una de las tres partes son unidas en una sola patente llamada matricula
                    If cbox_anios.SelectedValue.Equals("Pre 2007") Then
                        Patente = UCase(tbox_mat1.Text) & (tbox_mat2.Text) & (tbox_mat3.Text)

                    ElseIf cbox_anios.SelectedValue.Equals("Post 2007") Then
                        Patente = UCase(tbox_mat1.Text) & UCase(tbox_mat2.Text) & (tbox_mat3.Text)

                    End If
                    Dim Modelo As String = tbox_modelo.Text
                    Dim Estado As String = cbox_estado.SelectedValue
                    Dim Columnas() As String = {}
                    Dim Parametros() As String = {}
                    Try
                        con.beginTransaction()
                        Columnas = {"Matricula", "Modelo", "Estado"}
                        Parametros = {Patente, Modelo, Estado}
                        ID = con.doInsert("auto_escuela", Columnas, Parametros)
                        If ID <> -1 Then
                            V = MsgBox("Desea agregar instructor ahora o no", 4, "Confirmacion")
                            If V = MsgBoxResult.Yes Then
                                'Si acepta agregar un nuevo instructor entonces hace visible el agregar un instructor
                                lbl_encInstAgregar.Visible = True
                                cbox_instructor.Visible = True
                                btn_retract.Visible = True  'boton de retroceso que se activa cuando uno cambia de opinion sobre agregar instructor
                                asignar = True
                                btn_agregar.Text = "Asignar" 'cambia de nombre el boton de agregar a asignar

                            ElseIf V = MsgBoxResult.No Then
                                ID = 0
                                modularizar(ID) 'llama a la funcion modularizar que hace commit solo al nuevo vehiculo ingresado

                            End If
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
                End If
            Catch ex As Exception

            End Try
        ElseIf asignar Then
            'Si se acepta asignar a un instructor al ser asignar = True lo actualiza
            If cbox_anios.SelectedValue.Equals("Pre 2007") Then
                Patente = UCase(tbox_mat1.Text) & (tbox_mat2.Text) & (tbox_mat3.Text)

            ElseIf cbox_anios.SelectedValue.Equals("Post 2007") Then
                Patente = UCase(tbox_mat1.Text) & UCase(tbox_mat2.Text) & (tbox_mat3.Text)

            End If
            Dim Instructor As String = cbox_instructor.SelectedValue.ToString

            Dim inst As DataTable = con.doQuery("UPDATE instructor SET Auto= '" & Patente & "' WHERE idInstructor= '" & Instructor & "'")
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
            resetAgregar()
        End If

    End Sub

    Private Sub cbox_anios_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbox_anios.SelectedIndexChanged
        'Cambia el formato de las matriculas según el estandar determinado por el combobox
        'Para mas informacion observen el link de la seccion superiro
        If cbox_anios.SelectedValue.Equals("Pre 2007") Then
            'Formato AA-10.00 antes del 2007
            tbox_mat1.Text = ""
            tbox_mat2.Text = ""
            tbox_mat3.Text = ""
            tbox_mat1.Tipo = CustomTxtBox.Custom2.Tipologia.LETRA
            tbox_mat2.Tipo = CustomTxtBox.Custom2.Tipologia.NUMERO
            tbox_mat3.Tipo = CustomTxtBox.Custom2.Tipologia.NUMERO
        ElseIf cbox_anios.SelectedValue.Equals("Post 2007") Then
            'Formato BB-BB.10 despues del 2007
            tbox_mat1.Text = ""
            tbox_mat2.Text = ""
            tbox_mat3.Text = ""
            tbox_mat1.Tipo = CustomTxtBox.Custom2.Tipologia.LETRA
            tbox_mat2.Tipo = CustomTxtBox.Custom2.Tipologia.LETRA
            tbox_mat3.Tipo = CustomTxtBox.Custom2.Tipologia.NUMERO
        End If

    End Sub


    Private Sub cbox_matricula_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbox_matricula.SelectedIndexChanged
        'Cada vez que cambia la matricula de un automovil cambia el label 'Instructor'
        'al nombre del instructor al cual está asignado el vehiculo personalmente
        Dim label As DataTable = con.doQuery("SELECT f.Nombre " _
                                        & "FROM instructor i, docente d, funcionario f" _
                                         & " WHERE i.idINSTRUCTOR = d.idDOCENTE and d.idDOCENTE = f.idFUNCIONARIO and i.Auto ='" & cbox_matricula.Text & "'")

        If label.Rows.Count > 0 Then
            lbl_instructor.Text = label.Rows(0).Item(0).ToString
            lbl_encInstActualizar.Visible = True
        Else
            lbl_instructor.Text = ""
            lbl_encInstActualizar.Visible = False
        End If
    End Sub

    Private Sub modularizar(ByVal ID As Integer)
        'Dado que el boton retractar y el boton "no" del msgbox realizan la misma funcionalidad
        'se modulariza en esta subrutina el commit final que asegurará que el auto se ingresará correctamente
        btn_agregar.Text = "Agregar"
        If ID <> -1 Then
            con.commitTransaction()
            STATUS.Text = "Operación realizada con éxito."
            STATUS.ForeColor = Color.Blue
        Else
            STATUS.Text = "Hubo un error al realizar la operación."
            STATUS.ForeColor = Color.Red
        End If
        resetAgregar()
    End Sub

    Private Sub btn_retract_Click(sender As System.Object, e As System.EventArgs) Handles btn_retract.Click
        'El boton retractar [X] se encarga de que cuando una persona escoga ingresar un auto mas un instructor
        'cambie de idea y solo ingrese el nuevo vehiculo
        asignar = False
        Dim ID As Integer = 0
        modularizar(ID)
    End Sub

    Private Sub resetAgregar()
        'La subrutina de reseteo de la seccion de agregar vehiculo 
        tbox_mat1.Text = ""
        tbox_mat2.Text = ""
        tbox_mat3.Text = ""
        cbox_estado.Text = ""
        tbox_modelo.Text = ""
        cbox_instructor.Text = ""
        lbl_encInstAgregar.Visible = False
        cbox_instructor.Visible = False
        btn_retract.Visible = False
    End Sub

    Private Sub resetActualizar()
        'La subrutina de reseteo de la seccion gestion de flota: cambio de estado de vehiculo
        cbox_matricula.Text = ""
        cbox_estado2.Text = ""
        lbl_encInstActualizar.Visible = False
        lbl_instructor.Text = ""
    End Sub

    Private Sub btn_resetear02_Click(sender As System.Object, e As System.EventArgs) Handles btn_resetear02.Click
        'El boton de resetear limpia todo el formulario llamando simultaneamente a las dos rutinas
        resetAgregar()
        resetActualizar()
    End Sub
End Class