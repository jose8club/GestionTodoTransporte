Imports MySql.Data.MySqlClient

Public Class Usuarios
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim dc As DataCBOX

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        dc = New DataCBOX(con)
        InitializeComponent()
    End Sub

    Private Sub Usuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cbox_TipoUsuario.DataSource = dc.TipoUsuario
        cbox_TipoUsuario.ValueMember = "Tipo"
        cbox_TipoUsuario.DisplayMember = "Tipo"

        Dim Funcionario As DataTable = con.doQuery("SELECT IDFuncionario, Nombre FROM Funcionario")
        cbox_Funcionario.DataSource = Funcionario
        cbox_Funcionario.ValueMember = "IDFuncionario"
        cbox_Funcionario.DisplayMember = "Nombre"

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        'con.regUsuario(tbox_NombreUsuario.Text, tbox_Contrasena.Text, cbox_TipoUsuario.Text, cbox_Funcionario.Text)

        Dim Columnas() As String = {"Nombre", "Contraseña", "Tipo", "Funcionario"}
        Dim Parametros() As String = {tbox_NombreUsuario.Text, _
                                      tbox_Contrasena.Text, _
                                      cbox_TipoUsuario.Text, _
                                      cbox_Funcionario.SelectedValue}

        con.beginTransaction()
        Dim res As Integer = con.doInsert("Usuario", Columnas, Parametros)

        If res <> -1 Then
            con.commitTransaction()
            STATUS.Text = "Usuario: '" & tbox_NombreUsuario.Text & "' fue agregado con éxito."
        Else
            STATUS.Text = "ERROR: El usuario no fue agregado a la base de datos."
        End If


    End Sub

    Private Sub tbox_NombreUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_NombreUsuario.KeyPress
        Herramientas.textoDeseado(e, Herramientas.NoEspeciales)
    End Sub
End Class