﻿Imports MySql.Data.MySqlClient

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
    'AQUI EMPIEZAN LOS METODOS DEL CASO DE USO REGISTRAR CLIENTE'
    'Horarios estudiante practico caso de uso registar estudiante'
    
    Function registrosPractico() As String

        'Retorna el numero de clases practica
        'Usado para crear el combobox

        Dim cant As String = ""
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT COUNT(*) FROM PRACTICA"
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

    Function practicoToArray(ByVal n As Integer) As String()

        'Retorna un Array con los practicoss impartidos por la empresa

        Dim pract(n) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT Horario FROM PRACTICA"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                conn.Open()
                Dim i As Integer
                i = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        pract(i) = lector.GetString(0)
                        i = i + 1
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                conn.Close()
            End Try
        End Using

        Return pract
    End Function
    'Horarios estudiante teorico caso de uso registar estudiante'

    Function registrosTeorico() As String

        'Retorna el numero de clases practica
        'Usado para crear el combobox

        Dim cant As String = ""
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT COUNT(*) FROM TEORIA"
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

    Function teoricoToArray(ByVal n As Integer) As String()

        'Retorna un Array con los practicoss impartidos por la empresa

        Dim teo(n) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT Horario FROM TEORIA"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                conn.Open()
                Dim i As Integer
                i = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        teo(i) = lector.GetString(0)
                        i = i + 1
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                conn.Close()
            End Try
        End Using

        Return teo
    End Function

    Sub RegistrarMatricula(ByVal codMatricula As String, ByVal nombre As String, ByVal rut As String, ByVal edad As Integer, ByVal fecha As String, ByVal telefono As Integer, ByVal codPago As Integer, ByVal curso As String, ByVal horaT As String, ByVal horaP As String)
        'Registra Matricula'
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO MATRICULA (Codigo, Nombre, RUT, Edad, Fecha, Telefono, CodigoPago, Curso, HoraTeorica, HoraPractica) VALUES(@Codigo, @Nombre, @RUT, @Edad, @Fecha, @Telefono, @CodigoPago, @Curso, @HoraTeorica, @HoraPractica)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Codigo", codMatricula)
                .Parameters.AddWithValue("@Nombre", nombre)
                .Parameters.AddWithValue("@RUT", rut)
                .Parameters.AddWithValue("@Edad", edad)
                .Parameters.AddWithValue("@Fecha", fecha)
                .Parameters.AddWithValue("@Telefono", telefono)
                .Parameters.AddWithValue("@CodigoPago", codPago)
                .Parameters.AddWithValue("@Curso", curso)
                .Parameters.AddWithValue("@HoraTeorica", horaT)
                .Parameters.AddWithValue("@HoraPractica", horaP)

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

    Sub RegistrarEstudiante(ByVal Matricula As String, ByVal FotosCarnet As Integer, ByVal CertEstudios As Boolean, ByVal CertAlumnRegular As Boolean, ByVal AutNotarial As Boolean)
        'Registra Estudiante'
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO ESTUDIANTE (Matricula, FotosCarnet, CertEstudios, CertAlumnRegular, AutNotarial) VALUES(@Matricula, @FotosCarnet, @CertEstudios, @CertAlumnRegular, @AutNotarial)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Matricula", Matricula)
                .Parameters.AddWithValue("@FotosCarnet", FotosCarnet)
                .Parameters.AddWithValue("@CertEstudios", CertEstudios)
                .Parameters.AddWithValue("@CertAlumnRegular", CertAlumnRegular)
                .Parameters.AddWithValue("@AutNotarial", AutNotarial)
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

    'Caso de uso 03: examen visual: se necesitan estas clases debido a que no se han llenado ninguna'

    Function registrosMatricula() As String

        'Retorna el numero de estudiantes
        'Usado para crear el combobox

        Dim cant As String = ""
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT COUNT(*) FROM MATRICULA"
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

    Function estudiantesToArray(ByVal n As Integer) As String()

        'Retorna un Array con los nombres de los estudiantes registrados por la empresa

        Dim est(n) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT Nombre FROM MATRICULA"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                conn.Open()
                Dim i As Integer
                i = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        est(i) = lector.GetString(0)
                        i = i + 1
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                conn.Close()
            End Try
        End Using

        Return est
    End Function

    Function rutToArray(ByVal n As Integer) As String()

        'Retorna un Array con los rut de los estudiantes registrados por la empresa

        Dim r(n) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT Rut FROM MATRICULA"
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                conn.Open()
                Dim i As Integer
                i = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        r(i) = lector.GetString(0)
                        i = i + 1
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                conn.Close()
            End Try
        End Using

        Return r
    End Function

    'Crear clase'
    Sub RegistrarClase(ByVal Codigo As String, ByVal Curso As String, ByVal FechaInicio As String, ByVal FechaTermino As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO CLASE (Codigo, Curso, FechaInicio, FechaTermino) VALUES(@Codigo, @Curso, @FechaInicio, @FechaTermino)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Codigo", Codigo)
                .Parameters.AddWithValue("@Curso", Curso)
                .Parameters.AddWithValue("@FechaInicio", FechaInicio)
                .Parameters.AddWithValue("@FechaTermino", FechaTermino)

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
    'Crear clase-estudiante'
    Sub RegistrarClaseEstudiante(ByVal Clase As String, ByVal Estudiante As String, ByVal ExamenVisual As Integer, ByVal Psicotecnico As Integer, ByVal ClaseCambioRueda As Integer)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO CLASE_ESTUDIANTE (Clase, Estudiante, ExamenVisual, Psicotecnico, ClaseCambioRueda) VALUES(@Clase, @Estudiante, @ExamenVisual, @Psicotecnico, @ClaseCambioRueda)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Clase", Clase)
                .Parameters.AddWithValue("@Estudiante", Estudiante)
                .Parameters.AddWithValue("@ExamenVisual", ExamenVisual)
                .Parameters.AddWithValue("@Psicotecnico", Psicotecnico)
                .Parameters.AddWithValue("@ClaseCambioRueda", ClaseCambioRueda)
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
    'Crear examen visual'
    Sub RegistrarExamenVisual(ByVal Examinador As String, ByVal Estado As String, ByVal Certificado As Boolean, ByVal Fecha As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO EXAMEN_VISUAL (Examinador, Estado, Certificado, Fecha) VALUES(@Examinador, @Estado, @Certificado, @Fecha)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Examinador", Examinador)
                .Parameters.AddWithValue("@Estado", Estado)
                .Parameters.AddWithValue("@Certificado", Certificado)
                .Parameters.AddWithValue("@Fecha", Fecha)

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
    'Crear examen psicotecnico'
    Sub RegistrarExamenPsico(ByVal Fecha As String, ByVal Examinador As String, ByVal Estado As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO EXAMEN_PSICOTECNICO (Fecha, Examinador, Estado) VALUES(@Fecha, @Examinador, @Estado)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Fecha", Fecha)
                .Parameters.AddWithValue("@Examinador", Examinador)
                .Parameters.AddWithValue("@Estado", Estado)

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
End Class