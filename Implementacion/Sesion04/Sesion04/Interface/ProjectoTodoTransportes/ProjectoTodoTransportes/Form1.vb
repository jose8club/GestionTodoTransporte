Public Class Form1
    Dim con As Conexion = New Conexion

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles FechAt.ValueChanged

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub GuardarBtn_Click(sender As System.Object, e As System.EventArgs) Handles GuardarBtn.Click
        con.RegistrarCliente("asdas", "asd", "asd", "asd")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Crea Array con Cursos y los agrega al combobox

        Dim n As Integer
        n = con.registrosEnCURSO - 1
        Dim cursos(n) As String
        cursos = con.cursosToArray(n)
        For i As Integer = 0 To n
            CursoCbx.Items.Add(cursos(i))
        Next

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub



End Class
