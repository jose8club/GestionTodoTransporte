Public Class ResumenTabs
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub ResumenTabs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargaFORM("0")
    End Sub

    Sub cargaFORM(ByVal n As String)
        Dim Form As Form
        If n.Equals("0") Then
            Form = New ResumenDocente(USER, con, STATUS)
            form.TopLevel = False
            TabControl1.TabPages(0).Controls.Add(Form)
            form.Show()
        ElseIf n.Equals("1") Then
            Form = New ResumenCurso(USER, con, STATUS)
            Form.TopLevel = False
            TabControl1.TabPages(1).Controls.Add(Form)
            Form.Show()
        ElseIf n.Equals("2") Then
            Form = New ResumenAlumno(USER, con, STATUS)
            Form.TopLevel = False
            TabControl1.TabPages(2).Controls.Add(Form)
            Form.Show()
        End If
    End Sub



    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        cargaFORM(CStr(TabControl1.SelectedIndex))
    End Sub
End Class