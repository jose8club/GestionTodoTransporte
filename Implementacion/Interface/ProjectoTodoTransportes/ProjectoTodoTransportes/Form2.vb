Public Class Form2

    Dim con As Conexion = New Conexion
    
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CARGAR COMBOBOX cursos'
        Dim n As Integer
        n = con.registrosEnCURSO - 1
        Dim cursos(n) As String
        cursos = con.cursosToArray(n)
        For i As Integer = 0 To n
            cbox_curso.Items.Add(cursos(i))
        Next
        cbox_curso.SelectedIndex = 0

        'CARGAR COMBOBOX teoria'
        Dim m As Integer
        m = con.registrosTeorico - 1
        Dim teo(m) As String
        cursos = con.teoricoToArray(m)
        For i As Integer = 0 To m
            cbox_teorico.Items.Add(teo(i))
        Next
        cbox_teorico.SelectedIndex = 0

        'CARGAR COMBOBOX practica'
        Dim k As Integer
        k = con.registrosPractico - 1
        Dim pract(k) As String
        cursos = con.teoricoToArray(k)
        For i As Integer = 0 To k
            cbox_practico.Items.Add(pract(i))
        Next
        cbox_practico.SelectedIndex = 0

    End Sub

    Private Sub btn_estudiante_Click(sender As System.Object, e As System.EventArgs) Handles btn_estudiante.Click
        If tbox_telefono.Text.Trim.Equals("") Then
            tbox_telefono.Text = "0"
        ElseIf tbox_nombre.Text.Trim.Equals("") Then
            lbl_nombre.ForeColor = Color.Red
        ElseIf tbox_apellido.Text.Trim.Equals("") Then
            lbl_apellido.ForeColor = Color.Red
        ElseIf tbox_rut1.Text.Trim.Equals("") Or tbox_rut2.Text.Trim.Equals("") Then
            lbl_rut.ForeColor = Color.Red
        Else
            lbl_nombre.ForeColor = Color.DimGray
            lbl_apellido.ForeColor = Color.DimGray
            lbl_rut.ForeColor = Color.DimGray
            Try

                

            Catch ex As Exception

                'MOMENTANEO
                lbl_mensaje_conf.ForeColor = Color.Red
                lbl_mensaje_conf.Text = "ERROR!"

            Finally

                lbl_mensaje_conf.ForeColor = Color.Blue
                lbl_mensaje_conf.Text = "Operación realizada con éxito"

                'Resetea valores
                tbox_nombre.Text = ""
                tbox_telefono.Text = ""
                cbox_curso.SelectedIndex = 0

            End Try
        End If
    End Sub
End Class