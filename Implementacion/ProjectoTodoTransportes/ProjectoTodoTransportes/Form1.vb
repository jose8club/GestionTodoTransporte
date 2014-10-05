Public Class Form1
    Dim conexion As Coneccion = New Coneccion

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles FechAt.ValueChanged

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        conexion.Main()
    End Sub

    Private Sub GuardarBtn_Click(sender As System.Object, e As System.EventArgs) Handles GuardarBtn.Click
        'conexion.RegistrarCliente()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conexion.Conectar()
    End Sub

    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        conexion.Cerrar()
    End Sub
End Class
