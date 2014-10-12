Imports MySql.Data.MySqlClient

Public Class Conexion
   
    Dim cs As String = "Database=ttpt;Data Source=localhost;" _
     & "User Id=testUser;Password=12Test34@"
    Dim conn As New MySqlConnection(cs)
    Dim adaptador As MySqlDataAdapter
    Dim lector As MySqlDataReader
    Dim comando As MySqlCommand

    Sub Main()

    End Sub

    Sub registrarAtencion(ByVal usuario As String, ByVal idcliente As Integer)

        'Realiza el registro en la tabla ATENCION_CLIENTE

        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO ATENCION_CLIENTE (Usuario, Cliente) VALUES(@Usuario,@Cliente)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Usuario", usuario)
                .Parameters.AddWithValue("@Cliente", idcliente)

            End With
            Try
                conn.Open()
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                conn.Close()
            End Try

        End Using
    End Sub

    Function obtenerIDCliente(ByVal Nombre As String) As String

        'Funcion que retorna idCliente de la tabla CLIENTE

        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT idCLIENTE FROM CLIENTE WHERE Nombre = '" & Nombre & "'"
                .CommandType = CommandType.Text
                .Connection = conn

            End With
            Try
                conn.Open()
                comando.ExecuteNonQuery()
                Dim name As String = Convert.ToString(comando.ExecuteScalar)
                Return name

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                conn.Close()
            End Try

        End Using

    End Function

    Sub registrarCliente(ByVal Nombre As String, ByVal Telefono As Integer, ByVal Curso As String, ByVal Fecha As String, ByVal Otros As String, ByVal USER As String)

        'Realiza el registro en la tabla CLIENTE

        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO CLIENTE (Nombre, Telefono, Curso, Fecha, Extra, Atención) VALUES(@Nombre, @Telefono, @Curso, @Fecha, @Extra, @Atencion)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Nombre", Nombre)
                .Parameters.AddWithValue("@Telefono", Telefono)
                .Parameters.AddWithValue("@Curso", Curso)
                .Parameters.AddWithValue("@Fecha", Fecha)
                .Parameters.AddWithValue("@Extra", Otros)
                .Parameters.AddWithValue("@Atencion", "Tipo1") 'MOMENTANEO
            End With
            Try
                conn.Open()
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                conn.Close()
            End Try

        End Using

        Dim idcliente As Integer = CInt(Me.obtenerIDCliente(Nombre))

        'Se hace porque las KEYS de CLIENTE usan AUTOINCREMENT
        'El procedimiento es:
        '  Se crea cliente
        '  Se busca su llave
        '  Se utiliza la llave en registrarAtencion

        Me.registrarAtencion(USER, idcliente)

    End Sub

    Function iniciarSesion(ByVal usuario As String, ByVal contra As String) As Boolean

        'Verifica USUARIO/CONTRASEÑA y permite el ingreso al sistema

        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT Contraseña FROM USUARIO WHERE Nombre = '" & usuario & "'"
                .CommandType = CommandType.Text
                .Connection = conn

            End With
            Try
                conn.Open()
                comando.ExecuteNonQuery()
                Dim pass As String = Convert.ToString(comando.ExecuteScalar)
                If pass.Equals(contra) Then Return True Else Return False

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                conn.Close()
            End Try

        End Using
        Return False
    End Function

    Function registrosEnCURSO() As String

        'Retorna el numero de cursos
        'Usado para crear el combobox

        Dim cant As String = ""
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT COUNT(*) FROM CURSO"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                conn.Open()
                comando.ExecuteNonQuery()
                cant = comando.ExecuteScalar()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                conn.Close()
            End Try
        End Using

        Return cant
    End Function

    Function cursosToArray(ByVal n As Integer) As String()

        'Retorna un Array con los cursos impartidos por la empresa

        Dim cursos(n) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT Codigo FROM CURSO"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                conn.Open()
                Dim i As Integer
                i = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        cursos(i) = lector.GetString(0)
                        i = i + 1
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                conn.Close()
            End Try
        End Using

        Return cursos
    End Function

End Class
