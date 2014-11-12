Imports MySql.Data.MySqlClient
Public Class Funcionario
    Dim con As New Conexion

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        con.regFuncionario(tbox_NombreFuncionario.Text, tbox_Tipo.Text)
    End Sub

    Private Sub Funcionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.iSesion()
    End Sub
End Class