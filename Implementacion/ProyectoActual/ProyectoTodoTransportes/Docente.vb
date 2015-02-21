Public Class Docente
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim dc As DataCBOX
    Dim V As MsgBoxResult

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        dc = New DataCBOX(con)
        InitializeComponent()
    End Sub

    Private Sub Docente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rad_Profesor.Checked = True
        cbox_Vehiculo.Enabled = False
        lbl_Vehiculo.Enabled = False

        cargaCBOX("Matrícula")

    End Sub

    Private Sub rad_Instructor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_Instructor.CheckedChanged

        If rad_Instructor.Checked Then
            'al seleccionar instructor se habilita el combobox de vehiculo
            cbox_Vehiculo.Enabled = True
            lbl_Vehiculo.Enabled = True
        Else
            cbox_Vehiculo.Enabled = False
            lbl_Vehiculo.Enabled = False
        End If

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim InstructorAntiguo As Integer = 0 'instructor antiguo
        Dim Vehiculonull As String = ""
        'vehiculo nulo '000000' el cual se encargará de poner a un instructor
        'cuando se le asigne a otro instructor el vehiculo que tenia a su cargo
        If validar() Then
            Dim Nombre As String = tbox_Nombre.Text
            Dim Telefono As Integer = CInt(tbox_Telefono.Text)
            Dim Vehiculo As String = cbox_Vehiculo.Text
            Dim Tipo As String
            If rad_Profesor.Checked Then
                'se escoge profesor
                Tipo = "P"
            Else
                'se escoge instructor
                Tipo = "I"
                InstructorAntiguo = instructor(Vehiculo)
                Vehiculonull = "000000"
            End If

            Try
                con.beginTransaction()

                Dim Columnas() As String = {"Nombre", "Tipo"}
                Dim Parametros() As String = {Nombre, "Docente"}

                'se agrega como funcionario
                Dim ID As Integer = con.doInsert("Funcionario", Columnas, Parametros)

                If ID <> -1 Then
                    'se agrega como docente
                    Columnas = {"idDocente", "Telefono", "Tipo"}
                    Parametros = {ID, Telefono, Tipo}
                    ID = con.doInsert("Docente", Columnas, Parametros)
                End If

                If Tipo.Equals("P") And ID <> -1 Then
                    'se agrega como profesor
                    Columnas = {"idProfesor"}
                    Parametros = {ID}
                    ID = con.doInsert("Profesor", Columnas, Parametros)
                ElseIf Tipo.Equals("I") And ID <> -1 Then
                    If disponibilidad(Vehiculo) Then
                        'si el vehiculo ya tiene un instructor
                        V = MsgBox("Ya posee un instructor asociado ¿Desea cambiar de instructor?", 4, "Confirmacion")
                        If V = MsgBoxResult.Yes Then
                            'si se escoge si se quiere reemplazar entonces se pone la pantente null al instructor antiguo
                            'y se pone la patente escogida al instructor nuevo
                            Dim f As DataTable = con.doQuery("UPDATE instructor SET Auto= '" & Vehiculonull & "' WHERE idInstructor= '" & InstructorAntiguo & "'")
                            Columnas = {"idInstructor", "Auto"}
                            Parametros = {ID, Vehiculo}
                            ID = con.doInsert("Instructor", Columnas, Parametros)
                        ElseIf V = MsgBoxResult.No Then
                            'si se escoge no entonces se pone la patente null al nuevo instructor
                            Columnas = {"idInstructor", "Auto"}
                            Parametros = {ID, Vehiculonull}
                            ID = con.doInsert("Instructor", Columnas, Parametros)
                        End If
                    ElseIf Not disponibilidad(Vehiculo) Then
                        'si el vehiculo no tiene a ningun instructor asignado entonces solo se le asigna ese vehiculo
                        'al nuevo instructor
                        Columnas = {"idInstructor", "Auto"}
                        Parametros = {ID, Vehiculo}
                        ID = con.doInsert("Instructor", Columnas, Parametros)
                    End If

                End If

                If ID <> -1 Then
                    con.commitTransaction()
                    STATUS.Text = "Docente " & Nombre & " agregado con éxito"
                    STATUS.ForeColor = Color.Blue
                Else
                    STATUS.Text = "Hubo un error en la operación."
                    STATUS.ForeColor = Color.Red
                End If

            Catch ex As Exception
                STATUS.Text = ex.Message.ToString
            End Try

            reset()
        End If
    End Sub

#Region "Metodos"

    Sub cargaCBOX(ByVal Nombre As String)
        If Nombre.Equals("Matrícula") Then
            cbox_Vehiculo.DataSource = dc.Vehiculos
            cbox_Vehiculo.DisplayMember = "Matricula"
            cbox_Vehiculo.ValueMember = "Matricula"
        End If
    End Sub

    Function validar() As Boolean
        'si el telefono esta vacio entonces se reemplaza por un cero
        If tbox_Telefono.Text.Trim.Equals("") Then tbox_Telefono.Text = "0"
        If tbox_Nombre.Text.Trim.Equals("") Then
            'si no hay nombre entonces no deja ingresar un estudiante
            STATUS.Text = "ERROR: Ingrese los datos."
            tbox_Nombre.Focus()
            Return False

        ElseIf taller(cbox_Vehiculo.SelectedValue.ToString) And rad_Instructor.Checked Then
            'si el auto esta en el taller no se selecciona
            STATUS.Text = "ERROR: vehiculo no disponible. Se encuentra en taller en este momento."
            cbox_Vehiculo.Focus()
            Return False
        ElseIf debaja(cbox_Vehiculo.SelectedValue.ToString) And rad_Instructor.Checked Then
            'si el auto esta dado de baja no se selecciona
            STATUS.Text = "ERROR: vehiculo no disponible. Ha sido dado de baja."
            cbox_Vehiculo.Focus()
            Return False
        
        End If

        Return True
    End Function

    Function disponibilidad(ByVal Vehiculo As String) As Boolean
        'Verifica si ya está ocupado por otro instructor el vehiculo solicitado
        Dim estado As String = ""
        Dim d As DataTable = con.doQuery("SELECT idINSTRUCTOR " _
                                    & "FROM instructor" _
                                     & " WHERE Auto='" & Vehiculo & "'")

        If d.Rows.Count > 0 Then
            estado = d.Rows(0).Item(0).ToString
        Else
            estado = ""
        End If
        If estado = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Function instructor(ByVal Vehiculo As String) As Integer
        'retorna el instructor asignado a ese vehiculo puesto en el parametro
        Dim Inst As Integer = 0
        Dim d As DataTable = con.doQuery("SELECT idINSTRUCTOR " _
                                    & "FROM instructor" _
                                     & " WHERE Auto='" & Vehiculo & "'")

        If d.Rows.Count > 0 Then
            Inst = CInt(d.Rows(0).Item(0).ToString)
        Else
            Inst = 0
        End If
        Return Inst

    End Function

    Function taller(ByVal Matricula As String) As Boolean
        'impide que autos que esten en taller sean asignados
        Dim estado As String = ""
        Dim d As DataTable = con.doQuery("SELECT Estado " _
                                    & "FROM auto_escuela" _
                                     & " WHERE Matricula='" & Matricula & "'")

        If d.Rows.Count > 0 Then
            estado = d.Rows(0).Item(0).ToString
        Else
            estado = ""
        End If
        If estado = "En Taller" Then
            Return True
        Else
            Return False
        End If
    End Function

    Function debaja(ByVal Matricula As String) As Boolean
        'impide que autos que esten en dados de baja sean asignados
        Dim estado As String = ""
        Dim d As DataTable = con.doQuery("SELECT Estado " _
                                    & "FROM auto_escuela" _
                                     & " WHERE Matricula='" & Matricula & "'")

        If d.Rows.Count > 0 Then
            estado = d.Rows(0).Item(0).ToString
        Else
            estado = ""
        End If
        If estado = "De Baja" Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub reset()
        'resetea el formulario
        tbox_Nombre.Text = ""
        tbox_Telefono.Text = ""
        cargaCBOX("Matrícula")
        rad_Profesor.Checked = True
    End Sub

#End Region
#Region "VALIDACIONES DE ENTRADA"

    Private Sub tbox_Nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_Nombre.KeyPress
        Herramientas.soloTexto(e)
    End Sub

    Private Sub tbox_Telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_Telefono.KeyPress
        Herramientas.soloNumeros(e)
    End Sub
#End Region

End Class