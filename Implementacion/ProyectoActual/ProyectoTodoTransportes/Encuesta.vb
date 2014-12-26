Public Class Encuesta
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub
    Private Sub Encuesta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

End Class