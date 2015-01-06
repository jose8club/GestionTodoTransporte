Public Class Docente
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim dc As DataCBOX

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        dc = New DataCBOX(con)
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
            Dim Tipo As String
            If rad_Profesor.Checked Then
                Tipo = "P"
            Else
                Tipo = "I"
            End If

            Try
                con.beginTransaction()

                Dim Columnas() As String = {"Nombre", "Tipo"}
                Dim Parametros() As String = {Nombre, "Docente"}

                Dim ID As Integer = con.doInsert("Funcionario", Columnas, Parametros)

                If ID <> -1 Then
                    Columnas = {"idDocente", "Telefono", "Tipo"}
                    Parametros = {ID, Telefono, Tipo}
                    ID = con.doInsert("Docente", Columnas, Parametros)
                End If

                If Tipo.Equals("P") And ID <> -1 Then
                    Columnas = {"idProfesor"}
                    Parametros = {ID}
                    ID = con.doInsert("Profesor", Columnas, Parametros)
                ElseIf Tipo.Equals("I") And ID <> -1 Then
                    Columnas = {"idInstructor", "Auto"}
                    Parametros = {ID, Vehiculo}
                    ID = con.doInsert("Instructor", Columnas, Parametros)
                End If

                If ID <> -1 Then
                    con.commitTransaction()
                    STATUS.Text = "Docente " & Nombre & " agregado con éxito"
                    STATUS.ForeColor = Color.Blue
                Else
                    STATUS.Text = "Hubo un error en la operación."
                    STATUS.ForeColor = Color.Red
                End If

            Catch ex As Exception
                STATUS.Text = ex.Message.ToString
            End Try

            reset()
        End If
    End Sub

#Region "Metodos"

    Sub cargaCBOX(ByVal Nombre As String)
        If Nombre.Equals("Matrícula") Then
            cbox_Vehiculo.DataSource = dc.Vehiculos
            cbox_Vehiculo.DisplayMember = "Matricula"
            cbox_Vehiculo.ValueMember = "Matricula"
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
        cargaCBOX("Matrícula")
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