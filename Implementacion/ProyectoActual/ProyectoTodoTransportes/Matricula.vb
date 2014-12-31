Public Class Matricula

    Private _uSER As String
    Private _con As Conexion
    Private _toolStripStatusLabel As ToolStripStatusLabel

    Sub New(USER As String, con As Conexion, toolStripStatusLabel As ToolStripStatusLabel)
        ' TODO: Complete member initialization 
        _uSER = USER
        _con = con
        _toolStripStatusLabel = toolStripStatusLabel
    End Sub

    Private Sub Matricula_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class