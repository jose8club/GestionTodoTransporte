Public Class tab_resumen
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub
    Private Sub tab_resumen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadTAB(MainMenu.TabPages(MainMenu.SelectedIndex).Text, MainMenu.SelectedIndex)
    End Sub

    Private Sub MainMenu_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainMenu.SelectedIndexChanged
        Dim tab As Integer = MainMenu.SelectedIndex
        Dim Nombre As String = MainMenu.TabPages(tab).Text
        loadTAB(Nombre, tab)
    End Sub

    Sub loadTAB(ByVal Nombre As String, ByVal tab As Integer)
        'Se crea este método para poder editar el orden de las pestañas y no alterar el contenido
        Dim Form As Form
        Me.MainMenu.TabPages(tab).Controls.Clear()
        If Nombre.Equals("Pago Estudiante") Then
            Form = New resGeneral(USER, con, STATUS)
            Form.TopLevel = False
            Me.MainMenu.TabPages(tab).Controls.Add(Form)
            Form.Show()
        ElseIf Nombre.Equals("Docentes") Then
            Form = New resProfesores(USER, con, STATUS)
            Form.TopLevel = False
            Me.MainMenu.TabPages(tab).Controls.Add(Form)
            Form.Show()
        ElseIf Nombre.Equals("Asistencia") Then
            Form = New resAsistencia(USER, con, STATUS)
            Form.TopLevel = False
            Me.MainMenu.TabPages(tab).Controls.Add(Form)
            Form.Show()
        ElseIf Nombre.Equals("Calificaciones") Then
            Form = New resCalificaciones(USER, con, STATUS)
            Form.TopLevel = False
            Me.MainMenu.TabPages(tab).Controls.Add(Form)
            Form.Show()
        ElseIf Nombre.Equals("Clientes Potenciales") Then
            Form = New resClientePot(USER, con, STATUS)
            Form.TopLevel = False
            Me.MainMenu.TabPages(tab).Controls.Add(Form)
            Form.Show()
        End If
    End Sub


End Class