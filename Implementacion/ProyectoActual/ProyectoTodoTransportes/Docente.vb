Public Class Docente
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub Docente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rad_Profesor.Checked = True
        cbox_Vehiculo.Enabled = False
        lbl_Vehiculo.Enabled = False

        Dim n As Integer
        Dim items() As String

        n = con.count("Auto_Escuela") - 1
        items = con.toArray(n, "Matricula", "Auto_Escuela")
        For i As Integer = 0 To n
            cbox_Vehiculo.Items.Add(items(i))
        Next
        If n >= 0 Then cbox_Vehiculo.SelectedIndex = 0

    End Sub

    Private Sub rad_Instructor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_Instructor.CheckedChanged
        If rad_Instructor.Checked Then
            cbox_Vehiculo.Enabled = True
            lbl_Vehiculo.Enabled = True
        Else
            cbox_Vehiculo.Enabled = False
            lbl_Vehiculo.Enabled = False
        End If

    End Sub


    Private Sub btn_Guardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If tbox_Telefono.Text.Equals("") Then tbox_Telefono.Text = "0"
        If tbox_Nombre.Text.Equals("") Then
            STATUS.Text = "ERROR: Ingrese los datos"
        Else
            Try
                con.regFuncionario(tbox_Nombre.Text, "Docente")
                Dim id As Integer = CInt(con.last("idFuncionario", "Funcionario"))
                If rad_Profesor.Checked Then
                    con.regDocente(id, CInt(tbox_Telefono.Text), "PRO")
                    con.regProfesor(id)
                Else
                    con.regDocente(id, CInt(tbox_Telefono.Text), "INS")
                    con.regInstructor(id, cbox_Vehiculo.Text)
                End If
                STATUS.Text = "Operación realizada con éxito"
            Catch ex As Exception
                STATUS.Text = ex.Message.ToString
            End Try
        End If
    End Sub
End Class