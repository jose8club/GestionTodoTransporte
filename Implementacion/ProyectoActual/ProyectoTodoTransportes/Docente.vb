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

        cargaCBOX("Matrícula")

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

        If validar() Then
            Dim Nombre As String = tbox_Nombre.Text
            Dim Telefono As Integer = CInt(tbox_Telefono.Text)
            Dim Vehiculo As String = cbox_Vehiculo.Text

            Dim id As Integer

            Try
                con.regFuncionario(Nombre, "Docente")

                id = CInt(con.last("idFuncionario", "Funcionario"))

                If rad_Profesor.Checked Then
                    con.regDocente(id, Telefono, "PRO")
                    con.regProfesor(id)
                Else
                    con.regDocente(id, Telefono, "INS")
                    con.regInstructor(id, Vehiculo)
                End If

                STATUS.Text = "Docente " & Nombre & " agregado con éxito"
                reset()

            Catch ex As Exception
                STATUS.Text = ex.Message.ToString
            End Try
        End If
    End Sub

#Region "Metodos"

    Sub cargaCBOX(ByVal Nombre As String)
        Dim n As Integer
        Dim items() As String

        If Nombre.Equals("Matrícula") Then
            n = con.count("Auto_Escuela") - 1
            items = con.toArray(n, "Matricula", "Auto_Escuela")
            For i As Integer = 0 To n
                cbox_Vehiculo.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_Vehiculo.SelectedIndex = 0
        End If
    End Sub

    Function validar() As Boolean
        If tbox_Telefono.Text.Trim.Equals("") Then tbox_Telefono.Text = "0"
        If tbox_Nombre.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese los datos."
            Return False
        End If

        Return True
    End Function

    Sub reset()
        tbox_Nombre.Text = ""
        tbox_Telefono.Text = ""
        cbox_Vehiculo.SelectedIndex = 0
        rad_Profesor.Checked = True

    End Sub

#End Region
#Region "VALIDACIONES DE ENTRADA"

    Private Sub tbox_Nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_Nombre.KeyPress
        Herramientas.soloTexto(e)
    End Sub

    Private Sub tbox_Telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_Telefono.KeyPress
        Herramientas.soloNumeros(e)
    End Sub
#End Region

End Class