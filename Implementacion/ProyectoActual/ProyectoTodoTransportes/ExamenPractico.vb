﻿Public Class ExamenPractico
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub ExamenPractico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class