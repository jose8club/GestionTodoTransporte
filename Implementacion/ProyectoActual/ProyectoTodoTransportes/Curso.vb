Public Class Curso
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim dc As DataCBOX

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        dc = New DataCBOX(con)
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub Curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDataGridViews()
        loadCBOX("Area")
        loadCBOX("Producto")
        loadCBOX("Instructor")
        check_Lunes.Checked = True
        check_Martes.Checked = True
        check_Miercoles.Checked = True
        check_Jueves.Checked = True
        check_Viernes.Checked = True
        check_Sabado.Checked = False
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        If validar() Then
            Dim Codigo As String = tbox_Codigo.Text
            Dim Producto As String = cbox_Producto.Text
            Dim FechaInicio As String = Format(date_FechaInicio.Value, "yyyy-MM-dd")
            Dim FechaTermino As String = Format(date_FechaTermino.Value, "yyyy-MM-dd")
            Dim Cupos As String = tbox_Cupos.Text

            Dim Columnas() As String = {"Codigo", "Producto", "FechaInicio", "FechaTermino", "Cupos"}
            Dim Parametros() As String = {Codigo, Producto, FechaInicio, FechaTermino, Cupos}

            Dim cantidad_dias As Integer = (date_FechaTermino.Value - date_FechaInicio.Value).TotalDays + 1
            Dim dia_inicial As Integer = date_FechaInicio.Value.DayOfWeek
            Try
                con.beginTransaction()
                Dim ID As Integer = con.doInsert("Curso", Columnas, Parametros)

                If ID <> -1 Then
                    For Each Row As DataGridViewRow In DG_HT.Rows

                        Dim Hora As String = Row.Cells(0).Value & ":" & Row.Cells(1).Value & ":00"
                        Dim Profesor As Integer = Row.Cells(2).Value

                        Columnas = {"Curso", "Horario", "DIA", "Tipo"}
                        Dim Columnas2() As String = {"Clase", "Profesor"}

                        For i As Integer = dia_inicial To dia_inicial + cantidad_dias - 1
                            If ID <> -1 And check_Lunes.Checked And (i Mod 7 = 1) Then
                                Parametros = {Codigo, Hora, 1, "T"}
                                ID = con.doInsert("Clase", Columnas, Parametros)
                                If ID <> -1 Then
                                    Parametros = {ID, Profesor}
                                    ID = con.doInsert("Teoria", Columnas2, Parametros)
                                End If
                            End If

                            If ID <> -1 And check_Martes.Checked And (i Mod 7 = 2) Then
                                Parametros = {Codigo, Hora, 2, "T"}
                                ID = con.doInsert("Clase", Columnas, Parametros)
                                If ID <> -1 Then
                                    Parametros = {ID, Profesor}
                                    ID = con.doInsert("Teoria", Columnas2, Parametros)
                                End If
                            End If

                            If ID <> -1 And check_Miercoles.Checked And (i Mod 7 = 3) Then
                                Parametros = {Codigo, Hora, 3, "T"}
                                ID = con.doInsert("Clase", Columnas, Parametros)
                                If ID <> -1 Then
                                    Parametros = {ID, Profesor}
                                    ID = con.doInsert("Teoria", Columnas2, Parametros)
                                End If
                            End If

                            If ID <> -1 And check_Jueves.Checked And (i Mod 7 = 4) Then
                                Parametros = {Codigo, Hora, 4, "T"}
                                ID = con.doInsert("Clase", Columnas, Parametros)
                                If ID <> -1 Then
                                    Parametros = {ID, Profesor}
                                    ID = con.doInsert("Teoria", Columnas2, Parametros)
                                End If
                            End If

                            If ID <> -1 And check_Viernes.Checked And (i Mod 7 = 5) Then
                                Parametros = {Codigo, Hora, 5, "T"}
                                ID = con.doInsert("Clase", Columnas, Parametros)
                                If ID <> -1 Then
                                    Parametros = {ID, Profesor}
                                    ID = con.doInsert("Teoria", Columnas2, Parametros)
                                End If
                            End If

                            If ID <> -1 And check_Sabado.Checked And (i Mod 7 = 6) Then
                                Parametros = {Codigo, Hora, 6, "T"}
                                ID = con.doInsert("Clase", Columnas, Parametros)
                                If ID <> -1 Then
                                    Parametros = {ID, Profesor}
                                    ID = con.doInsert("Teoria", Columnas2, Parametros)
                                End If
                            End If
                        Next
                    Next

                    For Each Row As DataGridViewRow In DG_HP.Rows
                        Dim InstructorID As Integer = Row.Cells(0).Value

                        Dim Columnas2() As String = {"Clase", "Instructor"}

                        For j As Integer = dia_inicial To dia_inicial + cantidad_dias - 1

                            If check_Lunes.Checked And Row.Cells(2).Value And (j Mod 7 = 1) Then
                                For i As Integer = 9 To 22
                                    If ID <> -1 Then
                                        Parametros = {Codigo, i & ":00:00", 1, "P"}
                                        ID = con.doInsert("Clase", Columnas, Parametros)
                                        If ID <> -1 Then
                                            Parametros = {ID, InstructorID}
                                            ID = con.doInsert("Practica", Columnas2, Parametros)
                                        End If
                                    End If
                                Next
                            End If

                            If check_Martes.Checked And Row.Cells(3).Value And (j Mod 7 = 2) Then
                                For i As Integer = 9 To 22
                                    If ID <> -1 Then
                                        Parametros = {Codigo, i & ":00:00", 2, "P"}
                                        ID = con.doInsert("Clase", Columnas, Parametros)
                                        If ID <> -1 Then
                                            Parametros = {ID, InstructorID}
                                            ID = con.doInsert("Practica", Columnas2, Parametros)
                                        End If
                                    End If
                                Next
                            End If

                            If check_Miercoles.Checked And Row.Cells(4).Value And (j Mod 7 = 3) Then
                                For i As Integer = 9 To 22
                                    If ID <> -1 Then
                                        Parametros = {Codigo, i & ":00:00", 3, "P"}
                                        ID = con.doInsert("Clase", Columnas, Parametros)
                                        If ID <> -1 Then
                                            Parametros = {ID, InstructorID}
                                            ID = con.doInsert("Practica", Columnas2, Parametros)
                                        End If
                                    End If
                                Next
                            End If

                            If check_Jueves.Checked And Row.Cells(5).Value And (j Mod 7 = 4) Then
                                For i As Integer = 9 To 22
                                    If ID <> -1 Then
                                        Parametros = {Codigo, i & ":00:00", 4, "P"}
                                        ID = con.doInsert("Clase", Columnas, Parametros)
                                        If ID <> -1 Then
                                            Parametros = {ID, InstructorID}
                                            ID = con.doInsert("Practica", Columnas2, Parametros)
                                        End If
                                    End If
                                Next
                            End If

                            If check_Viernes.Checked And Row.Cells(6).Value And (j Mod 7 = 5) Then
                                For i As Integer = 9 To 22
                                    If ID <> -1 Then
                                        Parametros = {Codigo, i & ":00:00", 5, "P"}
                                        ID = con.doInsert("Clase", Columnas, Parametros)
                                        If ID <> -1 Then
                                            Parametros = {ID, InstructorID}
                                            ID = con.doInsert("Practica", Columnas2, Parametros)
                                        End If
                                    End If
                                Next
                            End If

                            If check_Sabado.Checked And Row.Cells(7).Value And (j Mod 7 = 6) Then
                                For i As Integer = 9 To 22
                                    If ID <> -1 Then
                                        Parametros = {Codigo, i & ":00:00", 6, "P"}
                                        ID = con.doInsert("Clase", Columnas, Parametros)
                                        If ID <> -1 Then
                                            Parametros = {ID, InstructorID}
                                            ID = con.doInsert("Practica", Columnas2, Parametros)
                                        End If
                                    End If
                                Next
                            End If

                        Next
                    Next
                End If

                If ID <> -1 Then
                    con.commitTransaction()
                    STATUS.Text = "Operación realizada con éxito"
                    STATUS.ForeColor = Color.Blue
                Else
                    STATUS.Text = "Hubo un error al realizar la operación."
                    STATUS.ForeColor = Color.Red
                End If
            Catch ex As Exception
                STATUS.Text = ex.Message.ToString
            End Try


            reset()
        End If

    End Sub

    Function validar() As Boolean
        STATUS.ForeColor = System.Drawing.SystemColors.ControlText
        STATUS.Text = ""

        If tbox_Codigo.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Falta ingresar el campo 'Código'."
            STATUS.ForeColor = Color.Red
            Return False
        Else
            Dim d As DataTable = con.doQuery("SELECT * FROM CURSO WHERE Codigo = '" & tbox_Codigo.Text.Trim & "'")
            If d.Rows.Count > 0 Then
                STATUS.Text = "ERROR: Código ya existe en la base de datos. Ingrese uno nuevo."
                STATUS.ForeColor = Color.Red
                Return False
            End If
        End If

        If tbox_Cupos.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Falta ingresar el campo 'Cupos'."
            STATUS.ForeColor = Color.Red
            Return False
        End If

        For Each Row As DataGridViewRow In DG_HT.Rows
            If Row.Cells(2).Value = Nothing Then
                STATUS.Text = "ERROR: Falta asignar un profesor al horario " & Row.Cells(0).Value & ":" & Row.Cells(1).Value & "."
                STATUS.ForeColor = Color.Red
                Return False
            End If
        Next

        For Each Row As DataGridViewRow In DG_HP.Rows
            If Not (Row.Cells(2).Value Or Row.Cells(3).Value Or Row.Cells(4).Value Or Row.Cells(5).Value Or
                Row.Cells(6).Value Or Row.Cells(7).Value) Then
                STATUS.Text = "ERROR: El instructor " & Row.Cells(1).Value & " no tiene días asignados en Horario Práctico"
                STATUS.ForeColor = Color.Red
                Return False
            End If
        Next

        If (date_FechaInicio.Value > date_FechaTermino.Value) Then
            STATUS.Text = "ERROR: La fecha de término debe ser mayor que la fecha de inicio."
            STATUS.ForeColor = Color.Red
            Return False
        End If

        Return True
    End Function

    Sub reset()
        tbox_Codigo.Text = ""
        tbox_Cupos.Text = ""
        date_FechaInicio.Value = Date.Now
        date_FechaTermino.Value = Date.Now

        DG_HT.Rows.Clear()
        DG_HP.Rows.Clear()

        loadCBOX("Area")
        loadCBOX("Producto")
        loadCBOX("Instructor")

        check_Lunes.Checked = True
        check_Martes.Checked = True
        check_Miercoles.Checked = True
        check_Jueves.Checked = True
        check_Viernes.Checked = True
        check_Sabado.Checked = False

        loadDataGridViews()
    End Sub

    Sub loadCBOX(ByVal Nombre As String)

        If Nombre.Equals("Area") Then

            cbox_Area.DataSource = dc.Area()
            cbox_Area.DisplayMember = "Nombre"
            cbox_Area.ValueMember = "Nombre"

        ElseIf Nombre.Equals("Producto") Then

            cbox_Producto.DataSource = dc.ProductoDeArea(cbox_Area.Text)
            cbox_Producto.DisplayMember = "Nombre"
            cbox_Producto.ValueMember = "Nombre"

        ElseIf Nombre.Equals("Instructor") Then
            Dim Data As DataTable = dc.Instructores()
            Data.PrimaryKey = New DataColumn() {Data.Columns(1)}

            For Each Row As DataGridViewRow In DG_HP.Rows
                If Data.Rows.Contains(DG_HP.Rows(Row.Index).Cells(1).Value.ToString) Then
                    Dim foundRow As DataRow = Data.Rows.Find(DG_HP.Rows(Row.Index).Cells(1).Value.ToString)
                    Data.Rows.Remove(foundRow)
                End If
            Next

            cbox_Instructor.DataSource = Data
            cbox_Instructor.DisplayMember = "Nombre"
            cbox_Instructor.ValueMember = "idFuncionario"

            If cbox_Instructor.Items.Count = 0 Then
                ADD_HP.Enabled = False
                cbox_Instructor.Enabled = False
            Else
                ADD_HP.Enabled = True
                cbox_Instructor.Enabled = True
            End If

        End If
    End Sub

    Sub loadDataGridViews()

        HT_Profesor.DataSource = dc.Profesores()
        HT_Profesor.DisplayMember = "Nombre"
        HT_Profesor.ValueMember = "idFuncionario"
        DG_HT.RowTemplate.Height = 22

    End Sub

#Region "HORARIO TEORICO"

    Private Sub DG_HT_click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_HT.CellClick
        'Controla el despliegue de los comboboxs y el botón eliminar

        If e.RowIndex <> -1 Then 'Si no es el Header

            If (DG_HT.Rows(e.RowIndex).Cells(HT_Profesor.Name).Selected = True Or
                DG_HT.Rows(e.RowIndex).Cells(HT_Hora.Name).Selected Or
                DG_HT.Rows(e.RowIndex).Cells(HT_Minutos.Name).Selected) Then
                DG_HT.BeginEdit(True)
                DirectCast(DG_HT.EditingControl, DataGridViewComboBoxEditingControl).DroppedDown = True
            End If

            If DG_HT.Columns(e.ColumnIndex).Name = "HT_Eliminar" Then
                DG_HT.Rows.RemoveAt(e.RowIndex)
            End If

        End If
    End Sub

    Private Sub ADD_HT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADD_HT.Click
        DG_HT.Rows.Add()
    End Sub

    Private Sub DG_HT_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DG_HT.RowsAdded
        DG_HT.Rows(e.RowIndex).Cells(0).Value = HT_Hora.Items(0)
        DG_HT.Rows(e.RowIndex).Cells(1).Value = HT_Minutos.Items(0)
        'DG_HTmanana.Rows(e.RowIndex).Cells(2).Value = HT_Profesor.Items(0) No funciona :'(

    End Sub

#End Region

#Region "HORARIO PRACTICO"

    Private Sub DG_HP_click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_HP.CellClick

        If e.RowIndex <> -1 Then 'Si no es el Header

            If DG_HP.Columns(e.ColumnIndex).Name = "HP_Eliminar" Then
                DG_HP.Rows.RemoveAt(e.RowIndex)
                loadCBOX("Instructor")
            End If

        End If
    End Sub

    Private Sub ADD_HP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADD_HP.Click
        DG_HP.Rows.Add()
        DG_HP.Rows(DG_HP.Rows.Count - 1).Cells(1).Value = cbox_Instructor.Text
        DG_HP.Rows(DG_HP.Rows.Count - 1).Cells(0).Value = cbox_Instructor.SelectedValue
        loadCBOX("Instructor")
    End Sub

#End Region

    Private Sub cbox_Area_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbox_Area.SelectedIndexChanged
        loadCBOX("Producto")
    End Sub

    Private Sub tbox_Codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_Codigo.KeyPress
        Herramientas.textoDeseado(e, Herramientas.NoEspeciales)
    End Sub

    Private Sub tbox_Cupos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_Cupos.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

    Private Sub check_Lunes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_Lunes.CheckedChanged
        If check_Lunes.Checked Then
            DG_HP.Columns(2).Visible = True
            DG_HP.Columns(1).Width = DG_HP.Columns(1).Width - 20
        Else
            DG_HP.Columns(2).Visible = False
            DG_HP.Columns(1).Width = DG_HP.Columns(1).Width + 20
        End If
    End Sub

    Private Sub check_Martes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_Martes.CheckedChanged
        If check_Martes.Checked Then
            DG_HP.Columns(3).Visible = True
            DG_HP.Columns(1).Width = DG_HP.Columns(1).Width - 20
        Else
            DG_HP.Columns(3).Visible = False
            DG_HP.Columns(1).Width = DG_HP.Columns(1).Width + 20
        End If
    End Sub

    Private Sub check_Miercoles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_Miercoles.CheckedChanged
        If check_Miercoles.Checked Then
            DG_HP.Columns(4).Visible = True
            DG_HP.Columns(1).Width = DG_HP.Columns(1).Width - 20
        Else
            DG_HP.Columns(4).Visible = False
            DG_HP.Columns(1).Width = DG_HP.Columns(1).Width + 20
        End If
    End Sub

    Private Sub check_Jueves_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_Jueves.CheckedChanged
        If check_Jueves.Checked Then
            DG_HP.Columns(5).Visible = True
            DG_HP.Columns(1).Width = DG_HP.Columns(1).Width - 20
        Else
            DG_HP.Columns(5).Visible = False
            DG_HP.Columns(1).Width = DG_HP.Columns(1).Width + 20
        End If
    End Sub

    Private Sub check_Viernes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_Viernes.CheckedChanged
        If check_Viernes.Checked Then
            DG_HP.Columns(6).Visible = True
            DG_HP.Columns(1).Width = DG_HP.Columns(1).Width - 20
        Else
            DG_HP.Columns(6).Visible = False
            DG_HP.Columns(1).Width = DG_HP.Columns(1).Width + 20
        End If
    End Sub

    Private Sub check_Sabado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_Sabado.CheckedChanged
        If check_Sabado.Checked Then
            DG_HP.Columns(7).Visible = True
            DG_HP.Columns(1).Width = DG_HP.Columns(1).Width - 20
        Else
            DG_HP.Columns(7).Visible = False
            DG_HP.Columns(1).Width = DG_HP.Columns(1).Width + 20
        End If
    End Sub

End Class