Public Class RegistrarCliente
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub RegistrarCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadCBOX("Area")
        loadCBOX("Producto")
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        'MANEJA EL BOTÓN GUARDAR

        If validar() Then
            Dim Nombre As String = tbox_Nombre.Text
            Dim Telefono As Integer = CInt(tbox_Telefono.Text)
            Dim Curso As String = cbox_CursoInteres.Text
            Dim Extra As String = tbox_Observaciones.Text
            Dim Fecha As String = Format(date_FechaAtencion.Value, "yyyy-MM-dd")
            Try
                Dim ID As Integer = con.regClientePotencial(Nombre, Telefono, Curso, Extra)
                con.regAtencion(USER, ID, Fecha, "OFF")

                STATUS.Text = "Cliente " & Nombre & "fue agregado exitosamente."
                reset()

            Catch ex As Exception
                STATUS.Text = "ERROR!"
            End Try
        End If
    End Sub

#Region "VALIDACION DE ENTRADA"

    Private Sub tbox_Telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_Telefono.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

    Private Sub tbox_Nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_Nombre.KeyPress
        Herramientas.soloTexto(e)
    End Sub

#End Region

#Region "Métodos"

    Sub reset()
        tbox_Nombre.Text = ""
        tbox_Observaciones.Text = ""
        tbox_Telefono.Text = ""
        cbox_CursoInteres.SelectedIndex = 0
    End Sub

    Sub loadCBOX(ByVal Nombre As String)
        Dim n As Integer
        Dim items() As String
        If Nombre.Equals("Producto") Then
            cbox_CursoInteres.Items.Clear()

            n = con.countWhere("producto", "Area = '" & cbox_TipoLicencia.Text & "'") - 1
            items = con.toArrayWhere(n, "Nombre", "Producto", "Area = '" & cbox_TipoLicencia.Text & "'")
            For i As Integer = 0 To n
                cbox_CursoInteres.Items.Add(items(i))
            Next
            If n >= 0 Then
                cbox_CursoInteres.SelectedIndex = 0
            End If

        ElseIf Nombre.Equals("Area") Then
            cbox_TipoLicencia.Items.Clear()

            n = con.count("Area") - 1
            items = con.toArray(n, "Nombre", "Area")

            For i As Integer = 0 To n
                cbox_TipoLicencia.Items.Add(items(i))
            Next
            If con.countWhere("Producto", "Area = 'Otros'") = 0 Then cbox_TipoLicencia.Items.Remove("Otros")
            If n >= 0 Then
                cbox_TipoLicencia.SelectedIndex = 0
            End If
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

#End Region

    Private Sub cbox_TipoLicencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbox_TipoLicencia.SelectedIndexChanged
        loadCBOX("Producto")
    End Sub
End Class