Imports MySql.Data.MySqlClient

Public Class Usuarios
    Dim con As New Conexion


    Private Sub Usuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con.iSesion()
        Dim n As Integer
        Dim items() As String

        cbox_TipoUsuario.Items.Clear()
        n = con.count("tipo_usuario") - 1
        items = con.toArray(n, "Tipo", "tipo_usuario")
        For i As Integer = 0 To n
            cbox_TipoUsuario.Items.Add(items(i))
        Next
        cbox_TipoUsuario.SelectedIndex = 0

    End Sub
End Class