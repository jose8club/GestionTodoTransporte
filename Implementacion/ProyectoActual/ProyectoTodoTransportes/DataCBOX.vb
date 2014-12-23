Public Class DataCBOX

    Dim con As New Conexion

    Sub New(ByVal conexion As Conexion)
        con = conexion
    End Sub

    Function Profesores() As DataTable

        Dim n As Integer = con.countWhere("Docente", "Tipo='PRO'")
        Dim arreglo(n) As String
        Dim Data As DataTable

        'arreglo = con.doQuery("select f.nombre from funcionario as f, docente as d where d.tipo = 'PRO' And f.idFuncionario = d.idDocente")
        Data = con.doQuery("Select * from docente")
        Return(Data)
    End Function

End Class
