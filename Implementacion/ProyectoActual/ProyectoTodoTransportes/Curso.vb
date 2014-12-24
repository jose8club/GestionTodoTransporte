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
    End Sub

    Sub loadCBOX(ByVal Nombre As String)

        If Nombre.Equals("Area") Then

            cbox_Area.DataSource = dc.Area()
            cbox_Area.DisplayMember = "Nombre"
            cbox_Area.ValueMember = "Nombre"

        ElseIf Nombre.Equals("Producto") Then

            cbox_Producto.DataSource = dc.ProductoDeArea(cbox_Area.Text)
            cbox_Area.DisplayMember = "Nombre"
            cbox_Area.ValueMember = "Nombre"


        End If
    End Sub

    Private Sub cbox_Area_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbox_Area.SelectedIndexChanged
        loadCBOX("Producto")
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
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

            For Each Row As DataGridViewRow In DG_HT.Rows

            Next
        End If

    End Sub

    Function validar() As Boolean
        'If tbox_Codigo.Text.Trim.Equals("") Then Return False
        'Return True
        For Each Row As DataGridViewRow In DG_HT.Rows
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

        HT_Profesor.DataSource = dc.Profesores()
        HT_Profesor.DisplayMember = "Nombre"
        HT_Profesor.ValueMember = "idFuncionario"
        DG_HT.RowTemplate.Height = 22


    End Sub

    'HORARIO TEORICO

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


    
End Class