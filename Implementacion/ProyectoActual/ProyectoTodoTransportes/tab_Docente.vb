Public Class tab_Docente
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub tab_Docente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargaForm("0")
    End Sub

    Sub cargaForm(ByVal Nombre As String)
        Dim form As Form

        If Nombre.Equals("0") Then
            form = New Docente(USER, con, STATUS)
            form.TopLevel = False
            Tabs_docente.TabPages(0).Controls.Add(form)
            form.Show()
        ElseIf Nombre.Equals("1") Then
            form = New editDocente(USER, con, STATUS)
            form.TopLevel = False
            Tabs_docente.TabPages(1).Controls.Add(form)
            form.Show()
        End If
    End Sub



    Private Sub Menu_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tabs_docente.SelectedIndexChanged
        Dim tab As String = CStr(Tabs_docente.SelectedIndex)
        cargaForm(tab)
    End Sub

End Class