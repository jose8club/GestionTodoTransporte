Public Class DataCBOX

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

    Function Instructores() As DataTable

        Dim Data As DataTable = con.doQuery("SELECT f.idFuncionario, f.nombre " _
                                           & "FROM funcionario AS f, docente AS d " _
                                           & "WHERE d.tipo = 'INS' AND f.idFuncionario = d.idDocente")
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

    Function Clientes() As DataTable
        Dim Data As DataTable = con.doQuery("SELECT * FROM TIPO_CLIENTE")
        Return Data
    End Function

    Function Productos() As DataTable
        Dim Data As DataTable = con.doQuery("SELECT * FROM PRODUCTO")
        Return Data
    End Function

    Function CursosDeProducto(ByVal Producto As String) As DataTable
        Dim Data As DataTable = con.doQuery("SELECT Codigo FROM Curso " _
                                            & "WHERE Producto = '" & Producto & "' AND" _
                                            & " FechaTermino >= DATE(NOW())")
        Return Data
    End Function

    Function HTeoriaDeCurso(ByVal Curso As String) As DataTable
        Dim Data As DataTable = con.doQuery("SELECT DISTINCT(horario) As 'Horario' FROM Clase " _
                                            & "WHERE Curso = '" & Curso & "' AND Tipo = 'T'")
        Return Data
    End Function

    Function HPracticaDeCurso(ByVal Curso As String) As DataTable
        Dim Data As DataTable = con.doQuery("SELECT DISTINCT(horario) As 'Horario' FROM Clase " _
                                            & "WHERE Curso = '" & Curso & "' AND Tipo = 'P'")
        Return Data
    End Function

    Function DocPago() As DataTable
        Dim Data As DataTable = con.doQuery("SELECT 'Boleta' as Value union select 'Factura' as Value ")
        Return Data
    End Function

    Function MedioPago() As DataTable
        Dim Data As DataTable = con.doQuery("SELECT * FROM MEDIO_PAGO")
        Return Data
    End Function

    Function Cupos(ByVal Curso As String) As DataTable
        Dim Data As DataTable = con.doQuery("SELECT Cupos FROM Curso " _
                                            & "WHERE Codigo = '" & Curso & "'")
        Return Data
    End Function

    Function MontoAPagar(ByVal Cliente As String, ByVal Producto As String) As DataTable
        Dim Data As DataTable = con.doQuery("SELECT Monto FROM Precio " _
                                            & "WHERE Producto = '" & Producto & "' AND Tipo_Cliente = '" & Cliente & "'")
        Return Data
    End Function

End Class


