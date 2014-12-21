Public Class DataCBOX

    Dim con As New Conexion

    Sub New(ByVal conexion As Conexion)
        con = conexion
    End Sub

    Function Profesores() As String()

        Dim n As Integer = con.countWhere("Docente", "Tipo='PRO'")
        Dim arreglo(n) As String
        'arreglo = con.doQuery("select f.nombre from funcionario as f, docente as d where d.tipo = 'PRO' And f.idFuncionario = d.idDocente")
        arreglo = con.doQuery("Select * from docente")
        Return arreglo
    End Function

End Class
