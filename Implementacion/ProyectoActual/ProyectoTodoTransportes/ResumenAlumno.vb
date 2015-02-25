Public Class ResumenAlumno
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim dc As DataCBOX
    Dim Data As DataTable
    Dim CodigoMatricula As String

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        dc = New DataCBOX(con)
        InitializeComponent()
    End Sub

    Private Sub ResumenAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDataGrid()
        Label1.Text = "PENDIENTE"
        Label2.Text = "PENDIENTE"
        Label3.Text = "PENDIENTE"
        Label4.Text = "PENDIENTE"
        Label5.Text = "PENDIENTE"
        Label6.Text = "PENDIENTE"
    End Sub

    Sub loadDataGrid()
        Data = con.doQuery("SELECT Rut, Nombre FROM Cliente WHERE Rut LIKE '%" & tbox_search.Text & "%' OR Nombre LIKE '%" & tbox_search.Text & "%'")
        list_Alumno.DataSource = Data
        list_Alumno.Columns(1).Width = 165

    End Sub

    Private Sub tbox_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbox_search.TextChanged
        loadDataGrid()
    End Sub

    Sub loadDataAlumno()
        Try
            If list_Alumno.RowCount > 0 Then
                lbl_Nombre.Text = "Nombre:                              " & list_Alumno.CurrentRow.Cells(1).Value.ToString
                lbl_Rut.Text = "Rut:                                    " & list_Alumno.CurrentRow.Cells(0).Value.ToString

                Dim datatable As DataTable = con.doQuery("SELECT Telefono, e_Mail, TipoCliente FROM Cliente WHERE Rut = '" & list_Alumno.CurrentRow.Cells(0).Value.ToString & "'")


                lbl_fono.Text = "Teléfono / Email:                " & datatable.Rows(0).Item(0).ToString & " / " & datatable.Rows(0).Item(1).ToString
                lbl_tipo.Text = "Tipo Cliente:                        " & datatable.Rows(0).Item(2).ToString

                datatable = con.doQuery("SELECT m.Curso, co.Producto, m.HoraTeoria, m.HoraPractica FROM Cliente c, Compra co, Matricula m  WHERE c.Rut = '" & list_Alumno.CurrentRow.Cells(0).Value.ToString & "' AND c.idCliente = co.Cliente ANd co.idCompra = m.CodigoCompra")
                lbl_Curso.Text = "Curso:                                  " & datatable.Rows(0).Item(0).ToString & "   -  (" & datatable.Rows(0).Item(1).ToString & ")"
                lbl_HTeoria.Text = "Horario Teoría:           " & datatable.Rows(0).Item(2).ToString
                lbl_HPractica.Text = "Horario Práctica:        " & datatable.Rows(0).Item(3).ToString

                datatable = con.doQuery("SELECT m.codigo FROM Cliente c, Compra co, Matricula m WHERE c.RUT = '" & list_Alumno.CurrentRow.Cells(0).Value.ToString & "' AND c.idCliente = co.Cliente AND co.idCompra = m.CodigoCompra ")
                CodigoMatricula = datatable.Rows(0).Item(0).ToString
                lbl_codigo.Text = "Código Matrícula:              " & CodigoMatricula



                datatable = con.doQuery("SELECT count(d.tipo) FROM estudiante_documento ed, estudiante e, documento d WHERE e.idEstudiante = '" & CodigoMatricula & "' AND ed.documento = d.idDocumento AND e.idEstudiante = ed.Estudiante AND d.Tipo = 'Examen Practico' AND d.Estado = 'Aprobado'")
                If datatable.Rows(0).Item(0) > 0 Then
                    Label5.Text = "APROBADO"
                    Label5.ForeColor = Color.Green
                Else
                    datatable = con.doQuery("SELECT count(d.tipo) FROM estudiante_documento ed, estudiante e, documento d WHERE e.idEstudiante = '" & CodigoMatricula & "' AND ed.documento = d.idDocumento AND e.idEstudiante = ed.Estudiante AND d.Tipo = 'Examen Practico' AND d.Estado = 'Reprobado'")
                    If datatable.Rows(0).Item(0) > 0 Then
                        Label5.Text = "REPROBADO"
                        Label5.ForeColor = Color.Red
                    Else
                        Label5.Text = "PENDIENTE"
                        Label5.ForeColor = System.Drawing.SystemColors.ControlText
                    End If
                End If



                datatable = con.doQuery("SELECT count(d.tipo) FROM estudiante_documento ed, estudiante e, documento d WHERE e.idEstudiante = '" & CodigoMatricula & "' AND ed.documento = d.idDocumento AND e.idEstudiante = ed.Estudiante AND d.Tipo = 'Examen Teorico' AND d.Estado = 'Aprobado'")
                If datatable.Rows(0).Item(0) > 0 Then
                    Label3.Text = "APROBADO"
                    Label3.ForeColor = Color.Green
                Else
                    datatable = con.doQuery("SELECT count(d.tipo) FROM estudiante_documento ed, estudiante e, documento d WHERE e.idEstudiante = '" & CodigoMatricula & "' AND ed.documento = d.idDocumento AND e.idEstudiante = ed.Estudiante AND d.Tipo = 'Examen Teorico' AND d.Estado = 'Reprobado'")
                    If datatable.Rows(0).Item(0) > 0 Then
                        Label3.Text = "REPROBADO"
                        Label3.ForeColor = Color.Red
                    Else
                        Label3.Text = "PENDIENTE"
                        Label3.ForeColor = System.Drawing.SystemColors.ControlText
                    End If
                End If



                datatable = con.doQuery("SELECT count(d.tipo) FROM estudiante_documento ed, estudiante e, documento d WHERE e.idEstudiante = '" & CodigoMatricula & "' AND ed.documento = d.idDocumento AND e.idEstudiante = ed.Estudiante AND d.Tipo = 'Examen Visual' AND d.Estado = 'Aprobado'")
                If datatable.Rows(0).Item(0) > 0 Then
                    Label1.Text = "APROBADO"
                    Label1.ForeColor = Color.Green
                Else
                    datatable = con.doQuery("SELECT count(d.tipo) FROM estudiante_documento ed, estudiante e, documento d WHERE e.idEstudiante = '" & CodigoMatricula & "' AND ed.documento = d.idDocumento AND e.idEstudiante = ed.Estudiante AND d.Tipo = 'Examen Visual' AND d.Estado = 'Reprobado'")
                    If datatable.Rows(0).Item(0) > 0 Then
                        Label1.Text = "REPROBADO"
                        Label1.ForeColor = Color.Red
                    Else
                        Label1.Text = "PENDIENTE"
                        Label1.ForeColor = System.Drawing.SystemColors.ControlText
                    End If
                End If



                datatable = con.doQuery("SELECT count(d.tipo) FROM estudiante_documento ed, estudiante e, documento d WHERE e.idEstudiante = '" & CodigoMatricula & "' AND ed.documento = d.idDocumento AND e.idEstudiante = ed.Estudiante AND d.Tipo = 'Examen Psicotécnico' AND d.Estado = 'Aprobado'")
                If datatable.Rows(0).Item(0) > 0 Then
                    Label2.Text = "APROBADO"
                    Label2.ForeColor = Color.Green
                Else
                    datatable = con.doQuery("SELECT count(d.tipo) FROM estudiante_documento ed, estudiante e, documento d WHERE e.idEstudiante = '" & CodigoMatricula & "' AND ed.documento = d.idDocumento AND e.idEstudiante = ed.Estudiante AND d.Tipo = 'Examen Psicotécnico' AND d.Estado = 'Reprobado'")
                    If datatable.Rows(0).Item(0) > 0 Then
                        Label2.Text = "REPROBADO"
                        Label2.ForeColor = Color.Red
                    Else
                        Label2.Text = "PENDIENTE"
                        Label2.ForeColor = System.Drawing.SystemColors.ControlText
                    End If
                End If



                datatable = con.doQuery("SELECT count(d.tipo) FROM estudiante_documento ed, estudiante e, documento d WHERE e.idEstudiante = '" & CodigoMatricula & "' AND ed.documento = d.idDocumento AND e.idEstudiante = ed.Estudiante AND d.Tipo = 'Cambio Rueda' AND d.Estado = 'Aprobado'")
                If datatable.Rows(0).Item(0) > 0 Then
                    Label4.Text = "APROBADO"
                    Label4.ForeColor = Color.Green
                Else
                    datatable = con.doQuery("SELECT count(d.tipo) FROM estudiante_documento ed, estudiante e, documento d WHERE e.idEstudiante = '" & CodigoMatricula & "' AND ed.documento = d.idDocumento AND e.idEstudiante = ed.Estudiante AND d.Tipo = 'Cambio Rueda' AND d.Estado = 'Reprobado'")
                    If datatable.Rows(0).Item(0) > 0 Then
                        Label4.Text = "REPROBADO"
                        Label4.ForeColor = Color.Red
                    Else
                        Label4.Text = "PENDIENTE"
                        Label4.ForeColor = System.Drawing.SystemColors.ControlText
                    End If
                End If



                datatable = con.doQuery("SELECT count(d.tipo) FROM estudiante_documento ed, estudiante e, documento d WHERE e.idEstudiante = '" & CodigoMatricula & "' AND ed.documento = d.idDocumento AND e.idEstudiante = ed.Estudiante AND d.Tipo = 'Examen Municipal' AND d.Estado = 'Aprobado'")
                If datatable.Rows(0).Item(0) > 0 Then
                    Label6.Text = "APROBADO"
                    Label6.ForeColor = Color.Green
                Else
                    datatable = con.doQuery("SELECT count(d.tipo) FROM estudiante_documento ed, estudiante e, documento d WHERE e.idEstudiante = '" & CodigoMatricula & "' AND ed.documento = d.idDocumento AND e.idEstudiante = ed.Estudiante AND d.Tipo = 'Examen Municipal' AND d.Estado = 'Reprobado'")
                    If datatable.Rows(0).Item(0) > 0 Then
                        Label6.Text = "REPROBADO"
                        Label6.ForeColor = Color.Red
                    Else
                        Label6.Text = "PENDIENTE"
                        Label6.ForeColor = System.Drawing.SystemColors.ControlText
                    End If
                End If

                datatable = con.doQuery("SELECT FotosCarnet, CertNotarial, CertEstudios FROM estudiante WHERE idEstudiante = '" & CodigoMatricula & "'")
                If datatable.Rows(0).Item(0) = True Then
                    Label7.Text = "Si"
                Else
                    Label7.Text = "No"
                End If

                If datatable.Rows(0).Item(1) = True Then
                    Label8.Text = "Si"
                Else
                    Label8.Text = "No"
                End If

                If datatable.Rows(0).Item(2) = True Then
                    Label9.Text = "Si"
                Else
                    Label9.Text = "No"
                End If
            Else
                lbl_Nombre.Text = "Nombre:"
                lbl_Rut.Text = "Rut:"
                lbl_fono.Text = "Teléfono / Email:"
                lbl_tipo.Text = "Tipo Cliente:"
                lbl_Curso.Text = "Curso:"

            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub list_Alumno_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_Alumno.SelectionChanged
        loadDataAlumno()
    End Sub
End Class