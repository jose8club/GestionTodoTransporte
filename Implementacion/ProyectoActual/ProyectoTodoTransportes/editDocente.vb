Public Class editDocente
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
            Data = con.doQuery("SELECT Nombre, idFuncionario FROM Funcionario f, Docente d WHERE d.idDocente = f.idFuncionario AND Nombre LIKE '%" & TextBox1.Text & "%'")
        ElseIf check_instructores.Checked Then
            Data = con.doQuery("SELECT Nombre, idFuncionario FROM Funcionario f, Instructor i WHERE i.idInstructor = f.idFuncionario AND Nombre LIKE '%" & TextBox1.Text & "%'")
        ElseIf check_profesores.Checked Then
            Data = con.doQuery("SELECT Nombre, idFuncionario FROM Funcionario f, Profesor p WHERE p.idProfesor = f.idFuncionario AND Nombre LIKE '%" & TextBox1.Text & "%'")
        Else
            Data = Nothing
        End If

    End Sub

    Sub cargaLIST(ByVal Nombre As String)
        
        If Nombre.Equals("Docente") Then

            list_Docente.DataSource = Data
            list_Docente.DisplayMember = "Nombre"
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

End Class