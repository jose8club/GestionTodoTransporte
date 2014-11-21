Public Class tab_Clases
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub Clase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadTAB("Teoria")
    End Sub

    Sub loadTAB(ByVal Nombre As String)
        Dim Form As Form
        If Nombre.Equals("Teoria") Then
            Form = New ClaseTeorica(USER, con, STATUS)
            Form.TopLevel = False
            TabControl1.TabPages(0).Controls.Add(Form)
            Form.Show()
        ElseIf Nombre.Equals("Practica") Then
            Form = New ClasePractica(USER, con, STATUS)
            Form.TopLevel = False
            TabControl1.TabPages(1).Controls.Add(Form)
            Form.Show()
        End If
    End Sub


    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim tab As Integer = TabControl1.SelectedIndex
        If tab = 0 Then
            loadTAB("Teoria")
        ElseIf tab = 1 Then
            loadTAB("Practica")
        End If
    End Sub
End Class