﻿Public Class DataCBOX

    Dim con As New Conexion

    Sub New(ByVal conexion As Conexion)
        con = conexion
    End Sub

    Function Profesores() As DataTable

        Dim Data As DataTable = con.doQuery("SELECT f.idFuncionario, f.nombre " _
                                           & "FROM funcionario AS f, docente AS d " _
                                           & "WHERE d.tipo = 'PRO' AND f.idFuncionario = d.idDocente")
        Return Data

    End Function

End Class
