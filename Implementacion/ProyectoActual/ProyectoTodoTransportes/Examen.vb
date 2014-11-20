Public Class Examen
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub
    Private Sub Examen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadTAB("Examen Teorico")
    End Sub

    Sub loadTAB(ByVal Nombre As String)
        Dim Form As Form
        If Nombre.Equals("Examen Teorico") Then
            Form = New ExamenTeorico(USER, con, STATUS)
            Form.TopLevel = False
            TabControl1.TabPages(0).Controls.Add(Form)
            Form.Show()
        ElseIf Nombre.Equals("Examen Practico") Then
            Form = New ExamenPractico(USER, con, STATUS)
            Form.TopLevel = False
            TabControl1.TabPages(1).Controls.Add(Form)
            Form.Show()
        ElseIf Nombre.Equals("Examen Municipal") Then
            Form = New ExamenMunicipal(USER, con, STATUS)
            Form.TopLevel = False
            TabControl1.TabPages(2).Controls.Add(Form)
            Form.Show()
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim tab As Integer = TabControl1.SelectedIndex
        If tab = 0 Then
            loadTAB("Examen Teorico")
        ElseIf tab = 1 Then
            loadTAB("Examen Practico")
        ElseIf tab = 2 Then
            loadTAB("Examen Municipal")
        End If
    End Sub
End Class