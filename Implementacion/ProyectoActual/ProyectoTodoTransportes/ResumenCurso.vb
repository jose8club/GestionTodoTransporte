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

    End Sub

    Private Sub ResumenCurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub componeQuery()
        Query = "SELECT Codigo FROM CURSO WHERE Tipo"
        If check_Particular.Checked Then

        End If

    End Sub
End Class