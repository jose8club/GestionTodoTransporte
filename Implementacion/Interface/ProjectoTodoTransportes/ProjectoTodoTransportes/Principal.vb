Public Class Principal

    Dim con As Conexion = New Conexion
    Dim USER As String = ""

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'CARGAR COMBOBOX
        Dim n As Integer
        n = con.registrosEnCURSO - 1
        Dim cursos(n) As String
        cursos = con.cursosToArray(n)
        For i As Integer = 0 To n
            cbox_CursoInteres1.Items.Add(cursos(i))
        Next

    End Sub



    Sub New(ByVal Usuario As String)
        USER = Usuario
        InitializeComponent()
    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged

        Dim tab As Integer = TabControl.SelectedIndex
        Me.CambiaTamaño(tab)
        

    End Sub

    Sub CambiaTamaño(ByVal tab)
        If tab = 0 Then
            TabControl.Size = New System.Drawing.Size(451, 294)
            Me.Size = New System.Drawing.Size(485, 351)
        ElseIf tab = 1 Then
            TabControl.Size = New System.Drawing.Size(600, 600)
            Me.Size = New System.Drawing.Size(600, 600)
        End If
    End Sub

End Class