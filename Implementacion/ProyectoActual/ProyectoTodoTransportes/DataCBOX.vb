Public Class DataCBOX

    Dim con As New Conexion

    Sub New(ByVal conexion As Conexion)
        con = conexion
    End Sub

    Function Profesores() As DataTable

        Dim Data As DataTable = con.doQuery("SELECT f.idFuncionario, f.nombre " _
                                           & "FROM funcionario AS f, docente AS d " _
                                           & "WHERE d.tipo = 'P' AND f.idFuncionario = d.idDocente")
        Return Data

    End Function

    Function Instructores() As DataTable

        Dim Data As DataTable = con.doQuery("SELECT f.idFuncionario, f.nombre " _
                                           & "FROM funcionario AS f, docente AS d " _
                                           & "WHERE d.tipo = 'I' AND f.idFuncionario = d.idDocente")
        Return Data

    End Function

    Function Funcionarios() As DataTable
        Dim Data As DataTable = con.doQuery("SELECT * FROM Funcionario")
        Return Data
    End Function

    Function Area() As DataTable
        Dim Data As DataTable = con.doQuery("SELECT Nombre FROM Area")
        Return Data
    End Function

    Function ProductoDeArea(ByVal Area As String)
        Dim Data As DataTable = con.doQuery("SELECT Nombre FROM Producto " _
                                            & "WHERE Area = '" & Area & "'")
        Return Data
    End Function

    Function Estudiantes() As DataTable
        Dim Data As DataTable = con.doQuery("SELECT * FROM Estudiante")
        Return Data
    End Function

    Function ClaseTeorica() As DataTable
        Dim Data As DataTable = con.doQuery("SELECT c.idClase, c.Curso FROM Clase c, Teoria t WHERE t.clase=c.idClase ")
        Return Data
    End Function

    Function ClasePractica() As DataTable
        Dim Data As DataTable = con.doQuery("SELECT c.idClase, c.Curso FROM Clase c, Practica p WHERE p.clase=c.idClase ")
        Return Data
    End Function

    Function Horarios(ByVal Curso As String) As DataTable
        Dim Data As DataTable = con.doQuery("SELECT Horario FROM Clase WHERE Curso = '" & Curso & "'")
        Return Data
    End Function

    Function Vehiculos() As DataTable
        Dim Data As DataTable = con.doQuery("SELECT * FROM auto_escuela WHERE Matricula<>'000000'")
        Return Data
    End Function

    Function TipoUsuario() As DataTable
        Dim Data As DataTable = con.doQuery("SELECT * FROM tipo_usuario")
        Return Data
    End Function
End Class
