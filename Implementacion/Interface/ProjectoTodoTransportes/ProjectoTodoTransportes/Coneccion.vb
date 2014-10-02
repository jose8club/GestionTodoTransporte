Imports MySql.Data.MySqlClient

Public Class Coneccion

    Dim cs As String = "Database=ttpt;Data Source=localhost;" _
            & "User Id=testUser;Password=12Test34@"
    Dim conn As MySqlConnection
    Dim adaptador As MySqlDataAdapter
    Dim lector As MySqlDataReader
    Dim comando As MySqlCommand

    Sub Main()

        Dim cs As String = "Database=ttpt;Data Source=localhost;" _
            & "User Id=testUser;Password=12Test34@"

        Dim conn As New MySqlConnection(cs)

        Try
            conn.Open()
            MsgBox("MySQL version : " & conn.ServerVersion, MsgBoxStyle.Information, "OK")

        Catch ex As MySqlException
            MsgBox("Error: " & ex.ToString(), MsgBoxStyle.Critical, "Fails")
        Finally
            conn.Close()
        End Try

    End Sub

    Sub Conectar()
        conn = New MySqlConnection(cs)
        conn.Open()
    End Sub

    Sub Cerrar()
        conn.Close()
    End Sub

    Sub RegistrarCliente(ByVal Nombre As String, ByVal Fecha As String, ByVal Curso As String, ByVal Otros As String)

    End Sub

End Class
