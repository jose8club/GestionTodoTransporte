Public Class Psicotecnico

    Dim con As New Conexion
    Dim USER As String = ""

    Sub New(ByVal usuario As String, ByVal conexion As Conexion)
        con = conexion
        USER = usuario
        InitializeComponent()
    End Sub

    Private Sub Psicotecnico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cbox_examinador.Items.Clear()
        Dim n As Integer
        n = con.registrosFuncionario - 1
        Dim fun(n) As String
        fun = con.funcionarioToArray(n)
        For i As Integer = 0 To n
            cbox_examinador.Items.Add(fun(i))
        Next
        cbox_examinador.SelectedIndex = 0

        cbox_documento.Items.Clear()
        Dim m As Integer
        m = con.registrosDocumento - 1
        Dim doc(m) As String
        doc = con.documentoToArray(m)
        For i As Integer = 0 To m
            cbox_documento.Items.Add(doc(i))
        Next
        cbox_documento.SelectedIndex = 0
    End Sub

    
    Private Sub guardarPsico_Click(sender As System.Object, e As System.EventArgs) Handles guardarPsico.Click
        Try
            con.RegistrarExamenPsico(Format(date_psico.Value, "yyyy-MM-dd"), cbox_examinador.Text, tbox_estado.Text)
            'con.RegistrarExamenPsico(cbox_documento.Text, Format(date_psico.Value, "yyyy-MM-dd"), cbox_examinador.Text, tbox_estado.Text)
            MsgBox("Operación realizada con éxito")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub tbox_estado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_estado.KeyPress
        Herramientas.soloTexto(e)
    End Sub

   
End Class