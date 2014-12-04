Public Class resGeneral
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim Estudiantes(,) As String
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub
    
    Private Sub resGeneral_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Matricula")
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)
        Dim n As Integer
        Dim items() As String
        If Nombre.Equals("Matricula") Then
            cbox_pago.Items.Clear()

            n = con.count("Matricula") - 1
            items = con.toArray(n, "Nombre", "Matricula")
            For i As Integer = 0 To n
                cbox_pago.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_pago.SelectedIndex = 0

        End If
    End Sub

#End Region

End Class