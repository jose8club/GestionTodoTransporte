Imports MySql.Data.MySqlClient


Public Class Conexion

    Dim cs As String = "Database=ttpt;Data Source=localhost;" _
     & "User Id=testUser;Password=12Test34@"
    Dim conn As New MySqlConnection(cs)
    Dim adaptador As MySqlDataAdapter
    Dim lector As MySqlDataReader
    Dim comando As MySqlCommand


#Region "DESARROLLO"

    Sub iSesion()
        'INICIA SESIÓN SIN PEDIR USER/PASS
        Using comando As New MySqlCommand()
            With comando
                .CommandType = CommandType.Text
                .Connection = conn

            End With
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using
    End Sub

#End Region

#Region "HERRAMIENTAS"

    Function count(ByVal NombreTabla As String) As String

        'Retorna el numero de registros en 'NombreTabla'

        Dim cant As String = ""
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT COUNT(*) FROM " & NombreTabla
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                comando.ExecuteNonQuery()
                cant = comando.ExecuteScalar()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return cant
    End Function

    Function countWhere(ByVal NombreTabla As String, ByVal Condicion As String) As String

        'Retorna el numero de registros en 'NombreTabla'

        Dim cant As String = ""
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT COUNT(*) FROM " & NombreTabla & " WHERE " & Condicion
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                comando.ExecuteNonQuery()
                cant = comando.ExecuteScalar()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return cant
    End Function

    Function last(ByVal columna As String, ByVal tabla As String) As String

        'Funcion que retorna el último 'columna' de la tabla 'tabla'
        Dim res As String = ""
        Using comando As New MySqlCommand()

            comando.CommandText = "SELECT max(" & columna & ") AS " & columna & " FROM " & tabla
            comando.CommandType = CommandType.Text
            comando.Connection = conn

            Try
                comando.ExecuteNonQuery()
                res = Convert.ToString(comando.ExecuteScalar)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using
        Return res
    End Function

    Function toArray(ByVal n As Integer, ByVal NombreCampo As String, ByVal NombreTabla As String) As String()

        'Retorna un arreglo con los datos 'NombreCampo' de la tabla 'NombreTabla'

        Dim arreglo(n) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT " & NombreCampo & " FROM " & NombreTabla
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                Dim i As Integer = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        arreglo(i) = lector.GetString(0)
                        i = i + 1
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return arreglo
    End Function

    Function toArrayWhere(ByVal n As Integer, ByVal NombreCampo As String, ByVal NombreTabla As String, ByVal Condicion As String) As String()

        'Retorna un arreglo con los datos 'NombreCampo' de la tabla 'NombreTabla'

        Dim arreglo(n) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT " & NombreCampo & " FROM " & NombreTabla & " WHERE " & Condicion
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                Dim i As Integer = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        arreglo(i) = lector.GetString(0)
                        i = i + 1
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using

        Return arreglo
    End Function

    Function selectWhereQuery(ByVal columna As String, ByVal tabla As String, ByVal condicion As String) As String

        'DEVUELVE UN DATO EN ESPECIFICO EN LA BD

        Dim res As String = ""
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT " & columna & " FROM " & tabla & " WHERE " & condicion
                .CommandType = CommandType.Text
                .Connection = conn
            End With
            Try
                comando.ExecuteNonQuery()
                res = comando.ExecuteScalar
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using
        Return res
    End Function

    Function iniciarSesion(ByVal usuario As String, ByVal contra As String) As Boolean

        'Verifica USUARIO/CONTRASEÑA y permite el ingreso al sistema
        'Abre la conexión

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

                If pass.Equals(contra) Then
                    Return True
                Else
                    conn.Close()
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
        Return False

    End Function

    Sub Close()

        'CIERRA LA BD

        Using comando As New MySqlCommand()
            comando.Connection = conn
        End Using
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

#End Region

#Region "INSERTS"

    Sub regFuncionario(ByVal Nombre As String, ByVal Tipo As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO FUNCIONARIO (Nombre, Tipo) VALUES(@Nombre, @Tipo)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Nombre", Nombre)
                .Parameters.AddWithValue("@Tipo", Tipo)

            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub regUsuario(ByVal Nombre As String, ByVal Contra As String, ByVal Tipo As String, ByVal Funcionario As String)
        Dim idFuncionario As String = Me.selectWhereQuery("idFUNCIONARIO", "FUNCIONARIO", "Nombre = '" & Funcionario & "'")
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO USUARIO (Nombre, Contraseña, Tipo, Funcionario) VALUES(@Nombre, @Contraseña, @Tipo, @Funcionario)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Nombre", Nombre)
                .Parameters.AddWithValue("@Contraseña", Contra)
                .Parameters.AddWithValue("@Tipo", Tipo)
                .Parameters.AddWithValue("@Funcionario", CInt(idFuncionario))
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub regAtencion(ByVal usuario As String, ByVal idcliente As Integer, ByVal fecha As String, ByVal Tipo As String)

        'Realiza el registro en la tabla ATENCION_CLIENTE

        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Atencion_cliente_potencial (Usuario, Cliente_Potencial, Fecha, Tipo) VALUES(@Usuario,@Cliente,@Fecha,@Tipo)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Usuario", usuario)
                .Parameters.AddWithValue("@Cliente", idcliente)
                .Parameters.AddWithValue("@Fecha", fecha)
                .Parameters.AddWithValue("@Tipo", Tipo) 'momentaneo'

            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Function regClientePotencial(ByVal Nombre As String, ByVal Telefono As Integer, ByVal Producto As String, ByVal Extra As String) As Integer

        'Realiza el registro en la tabla CLIENTE

        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Cliente_potencial (Nombre, Telefono, Producto, Extra) VALUES(@Nombre, @Telefono, @Producto, @Extra)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Nombre", Nombre)
                .Parameters.AddWithValue("@Telefono", Telefono)
                .Parameters.AddWithValue("@Producto", Producto)
                .Parameters.AddWithValue("@Extra", Extra)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

            Return comando.LastInsertedId
        End Using
    End Function

    Sub regVehiculo(ByVal Patente As String, ByVal Modelo As String, ByVal Estado As String)

        'Realiza el registro en la tabla CLIENTE

        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO  Auto_Escuela (Matricula, Modelo, Estado) VALUES(@Patente, @Modelo, @Estado)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Patente", Patente)
                .Parameters.AddWithValue("@Modelo", Modelo)
                .Parameters.AddWithValue("@Estado", Estado)

            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub regDocente(ByVal ID As Integer, ByVal Telefono As Integer, ByVal Tipo As String)
        'Realiza el registro en la tabla Docente

        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Docente (idDocente, Telefono, Tipo) VALUES(@id, @Telefono, @Tipo)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@id", ID)
                .Parameters.AddWithValue("@Telefono", Telefono)
                .Parameters.AddWithValue("@Tipo", Tipo)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using
    End Sub

    Sub regInstructor(ByVal id As Integer, ByVal Auto As String)

        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Instructor (idInstructor, Auto) VALUES(@id, @Auto)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@id", id)
                .Parameters.AddWithValue("@Auto", Auto)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using
    End Sub

    Sub regProfesor(ByVal id As Integer)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Profesor (idProfesor) VALUES(@id)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@id", id)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using
    End Sub

    Sub regCliente(ByVal Nombre As String, ByVal RUT As String, ByVal Fecha As String, ByVal Telefono As String, ByVal Email As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Cliente (Nombre,Rut,Fecha_Nac,Telefono,Email) VALUES(@Nombre,@Rut,@Fecha,@Telefono,@Email)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Nombre", Nombre)
                .Parameters.AddWithValue("@Rut", RUT)
                .Parameters.AddWithValue("@Fecha", Fecha)
                .Parameters.AddWithValue("@Telefono", Telefono)
                .Parameters.AddWithValue("@Email", Email)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using
    End Sub

    Sub regCompra(ByVal Cliente As Integer, ByVal Producto As String, ByVal Fecha As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Compra (Cliente,Producto,Fecha) VALUES(@Cliente,@Producto,@Fecha)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Cliente", Cliente)
                .Parameters.AddWithValue("@Producto", Producto)
                .Parameters.AddWithValue("@Fecha", Fecha)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using
    End Sub

    Sub regPago(ByVal Codigo As String, ByVal Monto As Integer, ByVal Medio_Pago As String, ByVal Compra As Integer, ByVal Fecha As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Pago (Codigo,Monto,Medio_Pago,Compra,Fecha) VALUES(@Codigo,@Monto,@Medio_Pago,@Compra,@Fecha)"
                .Connection = conn

                .Parameters.AddWithValue("@Codigo", Codigo)
                .Parameters.AddWithValue("@Monto", Monto)
                .Parameters.AddWithValue("@Medio_Pago", Medio_Pago)
                .Parameters.AddWithValue("@Compra", Compra)
                .Parameters.AddWithValue("@Fecha", Fecha)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using
    End Sub

    Sub regMatricula(ByVal Codigo As String, ByVal Nombre As String, ByVal RUT As String, ByVal Edad As Integer, ByVal Fecha As String, ByVal Telefono As Integer, ByVal CodigoCompra As Integer, ByVal Curso As String, ByVal HoraTeorica As String, ByVal HoraPractica As String, ByVal Documento As String, ByVal Estudiante As Integer)
        'Registra Matricula'

        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO MATRICULA (Codigo,Nombre,RUT,Edad,Fecha,Telefono,CodigoCompra,Curso,HoraTeoria,HoraPractica,Documento,Estudiante) VALUES(@Codigo,@Nombre,@RUT,@Edad,@Fecha,@Telefono,@CodigoCompra,@Curso,@HoraTeorica,@HoraPractica,@Documento,@Estudiante)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Codigo", Codigo)
                .Parameters.AddWithValue("@Nombre", Nombre)
                .Parameters.AddWithValue("@RUT", RUT)
                .Parameters.AddWithValue("@Edad", Edad)
                .Parameters.AddWithValue("@Fecha", Fecha)
                .Parameters.AddWithValue("@Telefono", Telefono)
                .Parameters.AddWithValue("@CodigoCompra", CodigoCompra)
                .Parameters.AddWithValue("@Curso", Curso)
                .Parameters.AddWithValue("@HoraTeorica", HoraTeorica)
                .Parameters.AddWithValue("@HoraPractica", HoraPractica)
                .Parameters.AddWithValue("@Documento", Documento)
                .Parameters.AddWithValue("@Estudiante", Estudiante)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using

    End Sub

    Sub regEstudiante(ByVal FotosCarnet As Integer, ByVal CertEstudios As Boolean, ByVal CertAlumnRegular As Boolean, ByVal AutNotarial As Boolean)
        'Registra Estudiante'
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO ESTUDIANTE (FotosCarnet, CertEstudios, CertAlumnRegular, AutNotarial) VALUES( @FotosCarnet, @CertEstudios, @CertAlumnRegular, @AutNotarial)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@FotosCarnet", FotosCarnet)
                .Parameters.AddWithValue("@CertEstudios", CertEstudios)
                .Parameters.AddWithValue("@CertAlumnRegular", CertAlumnRegular)
                .Parameters.AddWithValue("@AutNotarial", AutNotarial)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using

    End Sub

    Sub regDocumento(ByVal Tipo As String)
        'Registra Documento'
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Documento (Tipo) VALUES( @Tipo)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@FotosCarnet", Tipo)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub


#End Region

#Region "OTROS"

    Function buscarPago(ByVal edad As Integer, ByVal Codigo As String) As Integer
        Dim pago As Integer
        Using comando As New MySqlCommand()
            With comando
                If edad > 17 Then
                    .CommandText = "SELECT PrecioAdulto FROM CURSO WHERE Codigo = '" & Codigo & "'"
                    .CommandType = CommandType.Text
                    .Connection = conn
                ElseIf edad <= 17 Then
                    .CommandText = "SELECT PrecioEstudiante FROM CURSO WHERE Codigo = '" & Codigo & "'"
                    .CommandType = CommandType.Text
                    .Connection = conn
                End If
            End With
            Try
                comando.ExecuteNonQuery()
                pago = Convert.ToDecimal(comando.ExecuteScalar)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
        Return pago
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
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
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
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
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
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
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
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using

    End Sub

#End Region

End Class
