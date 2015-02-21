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

    End Sub

    Private Sub tbox_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbox_search.TextChanged
        loadDataGrid()
    End Sub
End Class