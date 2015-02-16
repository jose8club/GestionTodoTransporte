Public Class ResumenCurso
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim dc As DataCBOX
    Dim Data As DataTable
    Dim Query As String
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        dc = New DataCBOX(con)
        InitializeComponent()
    End Sub

    Private Sub tbox_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbox_search.TextChanged
        componeQuery()
        Query = Query & " AND Codigo LIKE '%" & tbox_search.Text & "%'"
        setData()

    End Sub

    Private Sub ResumenCurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub setData()
        If (check_Maquinaria.Checked Or check_Otros.Checked Or check_Particular.Checked Or check_Profesional.Checked) Then
            Data = con.doQuery(Query)
            list_Curso.DataSource = Data
            list_Curso.DisplayMember = "Codigo"
        Else
            list_Curso.DataSource = Nothing
        End If
    End Sub

    Sub componeQuery()
        Query = "SELECT c.Codigo FROM Curso c, Producto p WHERE c.Producto = p.Nombre AND ("

        If check_Particular.Checked Then
            Query = Query & "p.Area = 'Particular' OR "
        End If

        If check_Profesional.Checked Then
            Query = Query & "p.Area = 'Profesional' OR "
        End If

        If check_Otros.Checked Then
            Query = Query & "p.Area = 'Otro' OR "
        End If

        If check_Maquinaria.Checked Then
            Query = Query & "p.Area = 'Maquinaria Pesada' OR "
        End If

        Query = Query.Trim.Remove(Query.Length - 3, 2)

        Query = Query & ")"
    End Sub

#Region "CheckedChanged"

    Private Sub check_Maquinaria_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_Maquinaria.CheckedChanged
        componeQuery()
        setData()
    End Sub

    Private Sub check_Otros_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_Otros.CheckedChanged
        componeQuery()
        setData()
    End Sub

    Private Sub check_Particular_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_Particular.CheckedChanged
        componeQuery()
        setData()
    End Sub

    Private Sub check_Profesional_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_Profesional.CheckedChanged
        componeQuery()
        setData()
    End Sub

#End Region

End Class