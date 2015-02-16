Public Class ResumenDocente
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim dc As DataCBOX
    Dim Data As DataTable

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        dc = New DataCBOX(con)
        InitializeComponent()
    End Sub

    Private Sub editDocente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        check_instructores.Checked = True
        check_profesores.Checked = True

        setItems()
        cargaLIST("Docente")
    End Sub

#Region "Metodos"

    Sub setItems()

        If check_instructores.Checked And check_profesores.Checked Then
            Data = con.doQuery("SELECT Nombre, idFuncionario FROM Funcionario f, Docente d WHERE d.idDocente = f.idFuncionario AND Nombre LIKE '%" & TextBox1.Text & "%' ORDER BY Nombre ASC")
        ElseIf check_instructores.Checked Then
            Data = con.doQuery("SELECT Nombre, idFuncionario FROM Funcionario f, Instructor i WHERE i.idInstructor = f.idFuncionario AND Nombre LIKE '%" & TextBox1.Text & "%' ORDER BY Nombre ASC")
        ElseIf check_profesores.Checked Then
            Data = con.doQuery("SELECT Nombre, idFuncionario FROM Funcionario f, Profesor p WHERE p.idProfesor = f.idFuncionario AND Nombre LIKE '%" & TextBox1.Text & "%' ORDER BY Nombre ASC")
        Else
            Data = Nothing
        End If

    End Sub

    Sub cargaLIST(ByVal Nombre As String)

        If Nombre.Equals("Docente") Then

            list_Docente.DataSource = Data
            list_Docente.DisplayMember = "Nombre"
            list_Docente.ValueMember = "idFuncionario"
        End If
    End Sub

#End Region

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        setItems()
        cargaLIST("Docente")
    End Sub

    Private Sub check_instructores_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_instructores.CheckedChanged
        setItems()
        cargaLIST("Docente")
    End Sub

    Private Sub check_profesores_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_profesores.CheckedChanged
        setItems()
        cargaLIST("Docente")
    End Sub

    Private Sub list_Docente_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_Docente.SelectedValueChanged

        Try
            Dim telefono As DataTable = con.doQuery("SELECT Telefono FROM Docente d, Funcionario f WHERE d.idDocente = f.idFuncionario and idFuncionario ='" & list_Docente.SelectedValue & "'")
            If telefono.Rows.Count > 0 Then
                lbl_Telefono.Text = "Teléfono:                 " & telefono.Rows(0).Item(0).ToString
            End If


            Dim cursos As DataTable = New DataTable
            Dim vehiculo As DataTable = New DataTable

            Dim aux As DataTable = con.doQuery("SELECT Tipo From Docente WHERE idDocente = '" & list_Docente.SelectedValue & "'")
            If aux.Rows(0).Item(0).Equals("I") Then
                cursos = con.doQuery("SELECT Curso FROM Clase c, Practica p  WHERE c.idClase = p.Clase AND p.Instructor = '" & list_Docente.SelectedValue & "' GROUP BY Curso ORDER BY Curso ASC")
                vehiculo = con.doQuery("SELECT Auto FROM Instructor WHERE idInstructor = '" & list_Docente.SelectedValue & "'")
                lbl_tipo.Text = "Tipo:                        Instructor"
            Else
                cursos = con.doQuery("SELECT Curso FROM Clase c, Teoria t  WHERE c.idClase = t.Clase AND t.Profesor = '" & list_Docente.SelectedValue & "' GROUP BY Curso ORDER BY Curso ASC")
                lbl_tipo.Text = "Tipo:                        Profesor"
            End If

            list_Cursos.DataSource = cursos
            list_Cursos.DisplayMember = "Curso"

            If vehiculo.Rows.Count > 0 Then
                lbl_patente.Text = "Patente vehículo:    " & vehiculo.Rows(0).Item(0).ToString()
            Else
                lbl_patente.Text = ""
            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub list_Docente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_Docente.SelectedIndexChanged

    End Sub

End Class