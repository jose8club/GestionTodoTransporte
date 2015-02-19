Imports MySql.Data.MySqlClient


Public Class Conexion

    Dim cs As String = "Database=ttpt;Data Source=localhost;" _
     & "User Id=testUser;Password=12Test34@"
    Dim conn As New MySqlConnection(cs)
    Dim adaptador As MySqlDataAdapter
    Dim lector As MySqlDataReader
    Dim comando As New MySqlCommand
    Dim transaccion As MySqlTransaction

    Sub New()
        comando.CommandType = CommandType.Text
        comando.Connection = conn
    End Sub

    Function doQuery(ByVal SQLQuery As String) As DataTable

        'Realiza cualquier consulta y retorna los resultados en una tabla (DataTable).

        Dim Data As DataTable = New DataTable

        Using comando As New MySqlCommand()
            comando.Connection = conn
            comando.CommandText = SQLQuery

            Try
                Dim SQLAdapter As New MySqlDataAdapter(comando)
                SQLAdapter.Fill(Data)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using

        Return Data

    End Function

    Function doInsert(ByVal Tabla As String, ByVal Columnas() As String, ByVal Parametros() As String) As Integer

        'Realiza cualquier insert y retorna la PK (Si es autoincrementable)
        Dim r As Integer = -1

        Using comando As New MySqlCommand()
            comando.Connection = conn
            comando.CommandType = CommandType.Text
            comando.Transaction = transaccion

            Dim SQLQuery As String = "INSERT INTO " & Tabla & " ("
            Dim Values As String = ""
            For i As Integer = 0 To Columnas.Length - 1
                If i < Columnas.Length - 1 Then
                    SQLQuery = SQLQuery & Columnas(i) & ", "
                    Values = Values & "@param" & i & ", "
                Else
                    SQLQuery = SQLQuery & Columnas(i) & ") VALUES ("
                    Values = Values & "@param" & i & ") "
                    SQLQuery = SQLQuery & Values
                End If
            Next

            comando.CommandText = SQLQuery

            For i As Integer = 0 To Parametros.Length - 1
                comando.Parameters.AddWithValue("@param" & i, Parametros(i))
            Next

            Try
                comando.ExecuteNonQuery()
                r = comando.LastInsertedId()
            Catch ex As Exception
                rollbackTransaction()
                MsgBox(ex.Message.ToString)
                Return r
            End Try

        End Using

        Return r
    End Function

    Sub beginTransaction()
        transaccion = conn.BeginTransaction
    End Sub

    Sub commitTransaction()
        transaccion.Commit()
    End Sub

    Sub rollbackTransaction()
        transaccion.Rollback()
    End Sub


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

    Function toArray2Where(ByVal n As Integer, ByVal NombreCampos As String, ByVal NombreTabla As String, ByVal Condicion As String) As String(,)

        'Retorna un arreglo con los datos 'NombreCampo' de la tabla 'NombreTabla'

        Dim arreglo(n, 2) As String
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT " & NombreCampos & " FROM " & NombreTabla & " WHERE " & Condicion
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try
                Dim i As Integer = 0
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        arreglo(i, 0) = lector.GetString(0)
                        arreglo(i, 1) = lector.GetString(1)
                        MsgBox(arreglo(i, 1))
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

    Sub regDocumento(ByVal Documento As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Documento (Tipo) VALUES(@Tipo)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Tipo", Documento)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub regDocumento2(ByVal Tipo As String, ByVal Funcionario As Integer, ByVal Fecha As String, ByVal Estado As String)
        'Registra Documento'
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Documento (Tipo, Funcionario, Fecha, Estado) VALUES(@Tipo, @Funcionario, @Fecha, @Estado)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Tipo", Tipo)
                .Parameters.AddWithValue("@Funcionario", Funcionario)
                .Parameters.AddWithValue("@Fecha", Fecha)
                .Parameters.AddWithValue("@Estado", Estado)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub



    Sub regCurso(ByVal Codigo As String, ByVal Producto As String, ByVal FechaInicio As String, ByVal FechaTermino As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Curso (Codigo, Producto, FechaInicio, FechaTermino) VALUES(@Codigo, @Producto, @FechaInicio, @FechaTermino)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Codigo", Codigo)
                .Parameters.AddWithValue("@Producto", Producto)
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

    Sub regTeoria(ByVal Codigo As String, ByVal Curso As String, ByVal Horario As String, ByVal Duracion As Integer, ByVal idProfesor As Integer)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Teoria (idTeoria,Clase,Horario,Duracion,Profesor) VALUES(@Codigo,@Curso,@Horario,@Duracion,@idProfesor)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Codigo", Codigo)
                .Parameters.AddWithValue("@Curso", Curso)
                .Parameters.AddWithValue("@Horario", Horario)
                .Parameters.AddWithValue("@Duracion", Duracion)
                .Parameters.AddWithValue("@idProfesor", idProfesor)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub regRueda(ByVal Documento As Integer, ByVal Horario As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO CAMBIO_RUEDA (Documento,Horario) VALUES(@Documento,@Horario)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Documento", Documento)
                .Parameters.AddWithValue("@Horario", Horario)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub regPsico(ByVal Documento As Integer)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO PSICOTECNICO (Documento) VALUES(@Documento)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Documento", Documento)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub regVisual(ByVal Documento As Integer, ByVal Certificado As Boolean)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO EXAMEN_VISUAL (Documento,Certificado) VALUES(@Documento,@Certificado)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Documento", Documento)
                .Parameters.AddWithValue("@Certificado", Certificado)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub regPractica(ByVal Codigo As String, ByVal Clase As String, ByVal Instructor As Integer, ByVal Horario As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO Practica (idPractica,Clase,Instructor,Horario) VALUES(@Codigo,@Clase,@Instructor,@Horario)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Codigo", Codigo)
                .Parameters.AddWithValue("@Clase", Clase)
                .Parameters.AddWithValue("@Instructor", Instructor)
                .Parameters.AddWithValue("@Horario", Horario)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub regExTeo(ByVal Documento As Integer, ByVal Calificacion As Integer)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO EXAMEN_TEORICO (Documento,Calificacion) VALUES(@Documento,@Calificacion)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Documento", Documento)
                .Parameters.AddWithValue("@Calificacion", Calificacion)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub regExPract(ByVal Documento As Integer, ByVal Calificacion As Integer)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO EXAMEN_PRACTICO (Documento,Calificacion) VALUES(@Documento,@Calificacion)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Documento", Documento)
                .Parameters.AddWithValue("@Calificacion", Calificacion)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub regExMun(ByVal Documento As Integer, ByVal Comentario As String)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO EXAMEN_MUNICIPAL (Documento,Comentario) VALUES(@Documento,@Comentario)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Documento", Documento)
                .Parameters.AddWithValue("@Comentario", Comentario)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

    Sub regEstDoc(ByVal Estudiante As String, ByVal Documento As Integer)
        Using comando As New MySqlCommand()
            With comando
                .CommandText = "INSERT INTO ESTUDIANTE_DOCUMENTO (Estudiante, Documento) VALUES(@Estudiante, @Documento)"
                .CommandType = CommandType.Text
                .Connection = conn

                .Parameters.AddWithValue("@Estudiante", Estudiante)
                .Parameters.AddWithValue("@Documento", Documento)
            End With
            Try
                comando.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        End Using
    End Sub

#End Region


    Sub CargarDatos(ByRef Sugs As AutoCompleteStringCollection, ByVal tabla As String, ByVal columnas As String())

        Using comando As New MySqlCommand()
            With comando
                .CommandText = "SELECT DISTINCT [@Cols] FROM [@Tabla]"
                .Parameters.AddWithValue("@Cols", [String].Join(",", columnas))
                .Parameters.AddWithValue("@Tabla", tabla)
                .CommandType = CommandType.Text
                .Connection = conn
            End With

            Try 'arreglar
                Using lector As MySqlDataReader = comando.ExecuteReader()
                    While lector.Read()
                        Sugs.Add(lector.GetString(0))
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Using
    End Sub

End Class
