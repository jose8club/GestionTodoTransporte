Public Class Encuesta
    Dim con As New Conexion
    Dim USER As String = ""

    Sub New(ByVal usuario As String, ByVal conexion As Conexion)
        con = conexion
        USER = usuario
        InitializeComponent()
    End Sub
    Private Sub Encuesta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub
End Class