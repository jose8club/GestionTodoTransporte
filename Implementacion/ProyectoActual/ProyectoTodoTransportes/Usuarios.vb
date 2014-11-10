Imports MySql.Data.MySqlClient

Public Class Usuarios
    Dim con As New Conexion


    Private Sub Usuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con.iSesion()
        Dim n As Integer
        Dim cbox_items(n) As String

        cbox_TipoUsuario.Items.Clear()
        n = con.registrosEnTIPOUSUARIO - 1

        cbox_items = con.tipoUsuariosToArray(n)
        For i As Integer = 0 To n
            cbox_TipoUsuario.Items.Add(cbox_items(i))
        Next
        cbox_TipoUsuario.SelectedIndex = 0

        'cbox_Funcionario.Items.Clear()
        'n = con.count_FUNCIONARIO - 1
        'cbox_items = con.tipoUsuariosToArray(n)
        'For i As Integer = 0 To n
        'cbox_Funcionario.Items.Add(cbox_items(i))
        'Next
        'cbox_Funcionario.SelectedIndex = 0
    End Sub
End Class