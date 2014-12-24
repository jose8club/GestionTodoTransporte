Public Class Curso
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim datacbox As DataCBOX

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        datacbox = New DataCBOX(con)
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub Curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDataGridViews()
        loadCBOX("Area")
        loadCBOX("Producto")
    End Sub

    Sub loadCBOX(ByVal Nombre As String)

        Dim items() As String
        Dim n As Integer

        If Nombre.Equals("Area") Then
            cbox_Area.Items.Clear()

            cbox_Area.DataSource = datacbox.Area
            cbox_Area.DisplayMember = "Nombre"
            cbox_Area.ValueMember = "Nombre"

            If cbox_Area.Items.Count > 0 Then cbox_Area.SelectedIndex = 0

        ElseIf Nombre.Equals("Producto") Then

            cbox_Producto.Items.Clear()

            n = con.countWhere("producto", "Area = '" & cbox_Area.Text & "'") - 1
            items = con.toArrayWhere(n, "Nombre", "Producto", "Area = '" & cbox_Area.Text & "'")
            For i As Integer = 0 To n
                cbox_Producto.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_Producto.SelectedIndex = 0
        End If
    End Sub

    Private Sub cbox_Area_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbox_Area.SelectedIndexChanged
        loadCBOX("Producto")
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        MsgBox("-ÑIE")
        'If validar() Then
        '    Dim Codigo As String = tbox_Codigo.Text
        '    Dim Producto As String = cbox_Producto.Text
        '    Dim FechaInicio As String = Format(date_FechaInicio.Value, "yyyy-MM-dd")
        '    Dim FechaTermino As String = Format(date_FechaTermino.Value, "yyyy-MM-dd")

        '    Try
        '        con.regCurso(Codigo, Producto, FechaInicio, FechaTermino)
        '        STATUS.Text = "Curso " & Codigo & " fue agregado exitosamente."
        '    Catch ex As Exception
        '        STATUS.Text = "Curso no" & Codigo & " fue agregado exitosamente."
        '    End Try
        'End If
        If validar() Then

            For Each Row As DataGridViewRow In DG_HTmanana.Rows

            Next
        End If

    End Sub

    Function validar() As Boolean
        'If tbox_Codigo.Text.Trim.Equals("") Then Return False
        'Return True
        For Each Row As DataGridViewRow In DG_HTmanana.Rows
            For Each Cell As DataGridViewCell In Row.Cells
                If Cell.ColumnIndex = 3 Then
                    Continue For
                End If

                If Cell.Value = Nothing Then
                    STATUS.Text = "ERROR: Faltan datos en Horario Mañana. (Fila: " _
                                & Row.Index + 1 & ", Columna: " & Cell.OwningColumn.HeaderText & ")"
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Sub reset()
        tbox_Codigo.Text = ""
        date_FechaInicio.Value = Date.Now
        date_FechaTermino.Value = Date.Now
    End Sub

    Sub loadDataGridViews()
        Dim Data As DataTable = datacbox.Profesores()

        HTM_Profesor.DataSource = Data
        HTM_Profesor.DisplayMember = "Nombre"
        HTM_Profesor.ValueMember = "idFuncionario"
        DG_HTmanana.RowTemplate.Height = 22
    End Sub

    'MAÑANA

    Private Sub DG_HTmanana_click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_HTmanana.CellClick
        'Controla el despliegue de los comboboxs y el botón eliminar

        If e.RowIndex <> -1 Then 'Si no es el Header

            If (DG_HTmanana.Rows(e.RowIndex).Cells(HTM_Profesor.Name).Selected = True Or
                DG_HTmanana.Rows(e.RowIndex).Cells(HTM_Hora.Name).Selected Or
                DG_HTmanana.Rows(e.RowIndex).Cells(HTM_Minutos.Name).Selected) Then
                DG_HTmanana.BeginEdit(True)
                DirectCast(DG_HTmanana.EditingControl, DataGridViewComboBoxEditingControl).DroppedDown = True
            End If

            If DG_HTmanana.Columns(e.ColumnIndex).Name = "HTM_Eliminar" Then
                DG_HTmanana.Rows.RemoveAt(e.RowIndex)
            End If

        End If
    End Sub

    Private Sub ADD_manana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADD_manana.Click
        DG_HTmanana.Rows.Add()
    End Sub

    Private Sub DG_HTmanana_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DG_HTmanana.RowsAdded
        DG_HTmanana.Rows(e.RowIndex).Cells(0).Value = HTM_Hora.Items(0)
        DG_HTmanana.Rows(e.RowIndex).Cells(1).Value = HTM_Minutos.Items(0)
        'DG_HTmanana.Rows(e.RowIndex).Cells(2).Value = HTM_Profesor.Items(0) No funciona :'(

    End Sub

    'TARDE

    'Private Sub DG_HTtarde_click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

<<<<<<< HEAD
    '    DG_HTtarde.BeginEdit(True)
    '    If DG_HTtarde.Rows(e.RowIndex).Cells(HTT_Profesor.Name).Selected = True Or
    '        DG_HTtarde.Rows(e.RowIndex).Cells(HTT_Hora.Name).Selected Or
    '        DG_HTtarde.Rows(e.RowIndex).Cells(HTT_Minutos.Name).Selected Then

    '        DirectCast(DG_HTtarde.EditingControl, DataGridViewComboBoxEditingControl).DroppedDown = True
    '    End If


    '    If DG_HTtarde.Columns(e.ColumnIndex).Name = "HTT_Eliminar" Then
    '        DG_HTtarde.Rows.RemoveAt(e.RowIndex)
    '    End If
    'End Sub

    'Private Sub ADD_tarde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    DG_HTtarde.Rows.Add()
    'End Sub
=======
        'DG_HTtarde.BeginEdit(True)
        'If DG_HTtarde.Rows(e.RowIndex).Cells(HTT_Profesor.Name).Selected = True Or
        '    DG_HTtarde.Rows(e.RowIndex).Cells(HTT_Hora.Name).Selected Or
        '    DG_HTtarde.Rows(e.RowIndex).Cells(HTT_Minutos.Name).Selected Then

        '    DirectCast(DG_HTtarde.EditingControl, DataGridViewComboBoxEditingControl).DroppedDown = True
        'End If


        'If DG_HTtarde.Columns(e.ColumnIndex).Name = "HTT_Eliminar" Then
        '    DG_HTtarde.Rows.RemoveAt(e.RowIndex)
        'End If
    End Sub

    Private Sub ADD_tarde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '.Rows.Add()
    End Sub
>>>>>>> origin/master

    
End Class