﻿Public Class Curso
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

            con.beginTransaction()
            con.doInsert("Curso", Columnas, Parametros)


            '    Try
            '        con.regCurso(Codigo, Producto, FechaInicio, FechaTermino, Cupos)
            '        STATUS.Text = "Curso " & Codigo & " fue agregado exitosamente."
            '    Catch ex As Exception
            '        STATUS.Text = "Curso no" & Codigo & " fue agregado exitosamente."
            '    End Try

            For Each Row As DataGridViewRow In DG_HT.Rows
                Dim Hora As String = Row.Cells(0).Value & ":" & Row.Cells(1).Value & ":00"
                Dim Profesor As Integer = Row.Cells(2).Value

                If check_Lunes.Checked Then
                    'ID = inserta CLASE(Codigo, Hora, 1)
                    'inserta TEORIA(ID, Profesor)
                End If
                If check_Martes.Checked Then
                    'ID = inserta CLASE(Codigo, Hora, 2)
                    'inserta TEORIA(ID, Profesor)
                End If
                If check_Miercoles.Checked Then
                    'ID = inserta CLASE(Codigo, Hora, 3)
                    'inserta TEORIA(ID, Profesor)
                End If
                If check_Jueves.Checked Then
                    'ID = inserta CLASE(Codigo, Hora, 4)
                    'inserta TEORIA(ID, Profesor)
                End If
                If check_Viernes.Checked Then
                    'ID = inserta CLASE(Codigo, Hora, 5)
                    'inserta TEORIA(ID, Profesor)
                End If
                If check_Sabado.Checked Then
                    'ID = inserta CLASE(Codigo, Hora, 6)
                    'inserta TEORIA(ID, Profesor)
                End If
                If check_Domingo.Checked Then
                    'ID = inserta CLASE(Codigo, Hora, 7)
                    'inserta TEORIA(ID, Profesor)
                End If

            Next

            For Each Row As DataGridViewRow In DG_HP.Rows
                Dim InstructorID As Integer = Row.Cells(0).Value

                For Each Cell As DataGridViewCell In Row.Cells
                    If Cell.ColumnIndex < 2 Or Cell.ColumnIndex = 9 Then
                        Continue For
                    End If

                    If Cell.Value Then
                        Dim Dia As Integer = Cell.ColumnIndex - 1
                        'ID = inserta CLASE(Codigo, ?????, Dia)
                        'inserta PRACTICA(ID, InstructorID) 
                    End If

                Next
            Next

            reset()
        End If

    End Sub

    Function validar() As Boolean
        Return True
        STATUS.ForeColor = System.Drawing.SystemColors.ControlText
        STATUS.Text = ""

        'If tbox_Codigo.Text.Trim.Equals("") Then
        '    STATUS.Text = "ERROR: Falta código del curso."
        '    STATUS.ForeColor = Color.Red
        '    Return False
        'End If

        For Each Row As DataGridViewRow In DG_HT.Rows
            If Row.Cells(2).Value = Nothing Then
                STATUS.Text = "ERROR: Falta asignar un profesor al horario " & Row.Cells(0).Value & ":" & Row.Cells(1).Value & "."
                STATUS.ForeColor = Color.Red
                Return False
            End If
        Next

        For Each Row As DataGridViewRow In DG_HP.Rows
            If Not (Row.Cells(2).Value Or Row.Cells(3).Value Or Row.Cells(4).Value Or Row.Cells(5).Value Or
                Row.Cells(6).Value Or Row.Cells(7).Value Or Row.Cells(8).Value) Then
                STATUS.Text = "ERROR: El instructor " & Row.Cells(1).Value & " no tiene días asignados en Horario Práctico"
                STATUS.ForeColor = Color.Red
                Return False
            End If
        Next

        'If (date_FechaInicio.Value > date_FechaTermino.Value) Then
        '    STATUS.Text = "ERROR: La fecha de término debe ser mayor que la fecha de inicio."
        '    STATUS.ForeColor = Color.Red
        '    Return False
        'End If

        Return True
    End Function

    Sub reset()
        tbox_Codigo.Text = ""
        date_FechaInicio.Value = Date.Now
        date_FechaTermino.Value = Date.Now

        loadCBOX("Area")
        loadCBOX("Producto")
        loadCBOX("Instructor")

        check_Lunes.Checked = False
        check_Martes.Checked = False
        check_Miercoles.Checked = False
        check_Jueves.Checked = False
        check_Viernes.Checked = False
        check_Sabado.Checked = False
        check_Domingo.Checked = False

        DG_HT.Rows.Clear()
        DG_HP.Rows.Clear()

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

End Class