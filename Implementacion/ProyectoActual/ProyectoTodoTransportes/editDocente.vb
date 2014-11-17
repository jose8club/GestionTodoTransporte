Public Class editDocente
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim items() As String

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
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
        Dim aux2() As String
        Dim aux1, n As Integer
        If check_instructores.Checked And check_profesores.Checked Then
            n = con.countWhere("Funcionario", "Tipo = 'Docente'") - 1
            items = con.toArrayWhere(n, "Nombre", "Funcionario", "Tipo = 'Docente'")
        ElseIf check_instructores.Checked Then
            aux1 = con.countWhere("Docente", "Tipo = 'INS'") - 1
            aux2 = con.toArrayWhere(aux1, "idDocente", "Docente", "Tipo = 'INS'")

            Dim arreglo(aux1) As String
            For i As Integer = 0 To aux1
                arreglo(i) = con.selectWhereQuery("Nombre", "Funcionario", "idFuncionario = '" & aux2(i) & "'")
            Next
            items = arreglo
        ElseIf check_profesores.Checked Then
            aux1 = con.countWhere("Docente", "Tipo = 'PRO'") - 1
            aux2 = con.toArrayWhere(aux1, "idDocente", "Docente", "Tipo = 'PRO'")

            Dim arreglo(aux1) As String
            For i As Integer = 0 To aux1
                arreglo(i) = con.selectWhereQuery("Nombre", "Funcionario", "idFuncionario = '" & aux2(i) & "'")
            Next
            items = arreglo
        Else
            items = {}
        End If

    End Sub

    Sub cargaLIST(ByVal Nombre As String)
        list_Docente.Items.Clear()

        Dim n As Integer
        If Nombre.Equals("Docente") Then
            n = items.Length - 1
            For i As Integer = 0 To n
                list_Docente.Items.Add(items(i))
            Next
            If list_Docente.Items.Count > 0 Then list_Docente.SelectedIndex = 0

        End If
    End Sub

#End Region

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        list_Docente.Items.Clear()

        Dim n As Integer = items.Length - 1
        If TextBox1.Text = "" Then
            For i As Integer = 0 To n
                list_Docente.Items.Add(items(i))
            Next
            If list_Docente.Items.Count > 0 Then list_Docente.SelectedIndex = 0
        Else
            list_Docente.Items.AddRange(filtroContiene(items, TextBox1.Text))
            If list_Docente.Items.Count > 0 Then list_Docente.SelectedIndex = 0
        End If
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