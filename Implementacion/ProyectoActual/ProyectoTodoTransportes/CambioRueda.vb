Public Class CambioRueda
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim Instructores(,) As String
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub CambioRueda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'loadCBOX("Documento")
        'loadCBOX("Instructor")
    End Sub


#Region "Metodos"
    Sub loadCBOX(ByVal Nombre As String)
        Dim n As Integer
        Dim items() As String
        If Nombre.Equals("Documento") Then
            cbox_docRueda.Items.Clear()

            n = con.count("Documento") - 1
            items = con.toArray(n, "Codigo", "Documento")
            For i As Integer = 0 To n
                cbox_docRueda.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_docRueda.SelectedIndex = 0
        ElseIf Nombre.Equals("Instructor") Then

            cbox_instRueda.Items.Clear()

            Dim aux1 As String = con.countWhere("Docente", "Tipo = 'PRO'") - 1
            Dim aux2() As String = con.toArrayWhere(aux1, "idDocente", "Docente", "Tipo = 'PRO'")

            Dim arreglo(aux1, 2) As String
            For i As Integer = 0 To aux1
                arreglo(i, 0) = con.selectWhereQuery("Nombre", "Funcionario", "idFuncionario = '" & aux2(i) & "'")
                arreglo(i, 1) = aux2(i)
            Next

            Instructores = arreglo

            Dim items2(aux1) As String
            For i As Integer = 0 To aux1
                items2(i) = arreglo(i, 0)
            Next

            For i As Integer = 0 To aux1
                cbox_instRueda.Items.Add(items2(i))
            Next
            If aux1 >= 0 Then cbox_instRueda.SelectedIndex = 0

        End If
    End Sub
#End Region
    Private Sub tbox_codigoRueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_codigoRueda.KeyPress
        Herramientas.soloNumeros(e)
    End Sub
End Class