Public Class RegistrarCliente
    Dim con As New Conexion
    Dim USER As String = ""

    Sub New(ByVal usuario As String, ByVal conexion As Conexion)
        con = conexion
        USER = usuario
        InitializeComponent()
    End Sub

    Private Sub RegistrarCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cbox_CursoInteres.Items.Clear()
        Dim n As Integer
        n = con.registrosEnCURSO - 1
        Dim cursos(n) As String
        cursos = con.cursosToArray(n)
        For i As Integer = 0 To n
            cbox_CursoInteres.Items.Add(cursos(i))
        Next
        cbox_CursoInteres.SelectedIndex = 0
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        'MANEJA EL BOTÓN GUARDAR

        If tbox_Telefono.Text.Trim.Equals("") Then tbox_Telefono.Text = "0"
        If tbox_Nombre.Text.Trim.Equals("") Then
            lbl_Nombre.ForeColor = Color.Red
        Else
            lbl_Nombre.ForeColor = System.Drawing.SystemColors.ControlText
            Try
                Dim idcliente As Integer = CInt(con.obtenerUltimoIDCliente) + 1
                'falta validar que sucede cuando no hay clientes

                con.registrarCliente(idcliente, tbox_Nombre.Text, CInt(tbox_Telefono.Text), cbox_CursoInteres.Text,
                                Format(date_FechaAtencion.Value, "yyyy-MM-dd"), tbox_Observaciones.Text, USER)

                con.registrarAtencion(USER, idcliente)

                lbl_Mensaje1.ForeColor = Color.Blue
                lbl_Mensaje1.Text = "Cliente " & tbox_Nombre.Text & " fue agregado con éxito."

                tbox_Nombre.Text = ""
                tbox_Observaciones.Text = ""
                tbox_Telefono.Text = ""
                cbox_CursoInteres.SelectedIndex = 0

            Catch ex As Exception

                'MOMENTANEO
                lbl_Mensaje1.ForeColor = Color.Red
                lbl_Mensaje1.Text = ex.Message.ToString
            End Try

        End If
    End Sub

    Private Sub tbox_Telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_Telefono.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

    Private Sub tbox_Nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_Nombre.KeyPress
        Herramientas.soloTexto(e)
    End Sub

End Class