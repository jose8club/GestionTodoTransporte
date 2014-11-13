Imports MySql.Data.MySqlClient

Public Class Usuarios
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub Usuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim n As Integer
        Dim items() As String

        cbox_TipoUsuario.Items.Clear()
        n = con.count("tipo_usuario") - 1
        items = con.toArray(n, "Tipo", "tipo_usuario")
        For i As Integer = 0 To n
            cbox_TipoUsuario.Items.Add(items(i))
        Next
        If n >= 0 Then cbox_TipoUsuario.SelectedIndex = 0

        cbox_Funcionario.Items.Clear()
        n = con.count("funcionario") - 1
        items = con.toArray(n, "Nombre", "Funcionario")
        For i As Integer = 0 To n
            cbox_Funcionario.Items.Add(items(i))
        Next
        If n >= 0 Then cbox_Funcionario.SelectedIndex = 0


    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        con.regUsuario(tbox_NombreUsuario.Text, tbox_Contrasena.Text, cbox_TipoUsuario.Text, cbox_Funcionario.Text)
    End Sub


    Private Sub tbox_NombreUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_NombreUsuario.KeyPress
        Herramientas.textoDeseado(e, Herramientas.NoEspeciales)
    End Sub
End Class