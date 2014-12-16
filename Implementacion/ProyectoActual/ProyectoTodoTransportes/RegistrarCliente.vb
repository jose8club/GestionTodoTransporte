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
        loadImage()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        'MANEJA EL BOTÓN GUARDAR

        If validar() Then
            Dim Nombre As String = tbox_Nombre.Text
            Dim Telefono As Integer = CInt(tbox_Telefono.Text)
            Dim Curso As String = cbox_CursoInteres.Text
            Dim Extra As String = tbox_Consultas.Text
            Dim Fecha As String = Format(date_FechaAtencion.Value, "yyyy-MM-dd")
            Try
                Dim ID As Integer = con.regClientePotencial(Nombre, Telefono, Curso, Extra)
                con.regAtencion(USER, ID, Fecha, "OFF")
                'Manejar transacción COMMIT - ROLLBACK

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
        tbox_Consultas.Text = ""
        tbox_Telefono.Text = ""
        cbox_CursoInteres.SelectedIndex = 0
    End Sub

    Sub loadCBOX(ByVal Nombre As String)
        Dim n As Integer
        Dim items() As String
        If Nombre.Equals("Producto") Then
            cbox_CursoInteres.Items.Clear()

            n = con.countWhere("producto", "Area = '" & cbox_Area.Text & "'") - 1
            items = con.toArrayWhere(n, "Nombre", "Producto", "Area = '" & cbox_Area.Text & "'")
            For i As Integer = 0 To n
                cbox_CursoInteres.Items.Add(items(i))
            Next
            If n >= 0 Then
                cbox_CursoInteres.SelectedIndex = 0
            End If

        ElseIf Nombre.Equals("Area") Then
            cbox_Area.Items.Clear()

            n = con.count("Area") - 1
            items = con.toArray(n, "Nombre", "Area")

            For i As Integer = 0 To n
                cbox_Area.Items.Add(items(i))
            Next

            'If con.countWhere("Producto", "Area = 'Otros'") = 0 Then cbox_TipoLicencia.Items.Remove("Otros")

            If n >= 0 Then
                cbox_Area.SelectedIndex = 0
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

    Sub loadImage()
        Dim s As String = cbox_CursoInteres.Text

        If s.Equals("Clase B") Then
            PictureBox.Image = My.Resources.b
        ElseIf s.Equals("A-2: Taxis y Minibuses") Then
            PictureBox.Image = My.Resources.a2
        ElseIf s.Equals("A-3: Buses") Then
            PictureBox.Image = My.Resources.a3
        ElseIf s.Equals("A-4: Camiones") Then
            PictureBox.Image = My.Resources.a4
        ElseIf s.Equals("Retroexcavadora") Then
            PictureBox.Image = My.Resources.retro
        ElseIf s.Equals("Grua Horquilla") Then
            PictureBox.Image = My.Resources.grua
        ElseIf s.Equals("A-5: Camiones Articulados") Then
            PictureBox.Image = My.Resources.LOGO
        End If
    End Sub

#End Region

    Private Sub cbox_TipoLicencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbox_Area.SelectedIndexChanged
        loadCBOX("Producto")
        If cbox_Area.Text.Equals("Otros") And con.countWhere("Producto", "Area = 'Otros'") = 0 Then
            cbox_CursoInteres.Enabled = False
            lbl_CursoInteres.Enabled = False

        Else
            cbox_CursoInteres.Enabled = True
            lbl_CursoInteres.Enabled = True
        End If
    End Sub

    Private Sub cbox_CursoInteres_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbox_CursoInteres.SelectedIndexChanged
        loadImage()
    End Sub

End Class