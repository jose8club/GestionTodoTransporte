Public Class RegistrarMatricula

    Dim con As New Conexion
    Dim USER As String = ""

    Sub New(ByVal usuario As String, ByVal conexion As Conexion)
        con = conexion
        USER = usuario
        InitializeComponent()
    End Sub

    Private Sub RegistrarMatricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class