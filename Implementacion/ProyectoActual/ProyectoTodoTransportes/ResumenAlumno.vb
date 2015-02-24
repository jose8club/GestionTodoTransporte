Public Class ResumenAlumno
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim dc As DataCBOX
    Dim Data As DataTable

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        dc = New DataCBOX(con)
        InitializeComponent()
    End Sub

    Private Sub ResumenAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDataGrid()

    End Sub

    Sub loadDataGrid()
        Data = con.doQuery("SELECT Rut, Nombre FROM Cliente WHERE Rut LIKE '%" & tbox_search.Text & "%' OR Nombre LIKE '%" & tbox_search.Text & "%'")
        list_Alumno.DataSource = Data
        list_Alumno.Columns(1).Width = 165

    End Sub

    Private Sub tbox_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbox_search.TextChanged
        loadDataGrid()
    End Sub

    Sub loadDataAlumno()
        If list_Alumno.RowCount > 0 Then
            lbl_Nombre.Text = "Nombre:                        " & list_Alumno.CurrentRow.Cells(1).Value.ToString
            lbl_Rut.Text = "Rut:                              " & list_Alumno.CurrentRow.Cells(0).Value.ToString

            Dim datatable As DataTable = con.doQuery("SELECT Telefono, e_Mail, TipoCliente FROM Cliente WHERE Rut = '" & list_Alumno.CurrentRow.Cells(0).Value.ToString & "'")


            lbl_fono.Text = "Teléfono / Email:          " & datatable.Rows(0).Item(0).ToString & " / " & datatable.Rows(0).Item(1).ToString
            lbl_tipo.Text = "Tipo Cliente:                  " & datatable.Rows(0).Item(2).ToString

            datatable = con.doQuery("SELECT m.Curso, co.Producto, m.HoraTeoria, m.HoraPractica FROM Cliente c, Compra co, Matricula m  WHERE c.Rut = '" & list_Alumno.CurrentRow.Cells(0).Value.ToString & "' AND c.idCliente = co.Cliente ANd co.idCompra = m.CodigoCompra")
            lbl_Curso.Text = "Curso:                            " & datatable.Rows(0).Item(0).ToString & "   -  (" & datatable.Rows(0).Item(1).ToString & ")"
            lbl_HTeoria.Text = "Horario Teoría:     " & datatable.Rows(0).Item(2).ToString
            lbl_HPractica.Text = "Horario Teoría:     " & datatable.Rows(0).Item(3).ToString

        Else
            lbl_Nombre.Text = "Nombre:"
            lbl_Rut.Text = "Rut:"
            lbl_fono.Text = "Teléfono / Email:"
            lbl_tipo.Text = "Tipo Cliente:"
            lbl_Curso.Text = "Curso:"

        End If

    End Sub

    Private Sub list_Alumno_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_Alumno.SelectionChanged
        loadDataAlumno()
    End Sub
End Class