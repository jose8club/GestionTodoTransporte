Public Class tab_Config
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub tab_Config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadTAB("Usuarios")
    End Sub

    Sub loadTAB(ByVal Nombre As String)
        If Nombre.Equals("Usuarios") Then
            Dim form As New Usuarios(USER, con, STATUS)
            form.TopLevel = False
            TabControl1.TabPages(0).Controls.Add(form)
            form.Show()
        End If
    End Sub
End Class