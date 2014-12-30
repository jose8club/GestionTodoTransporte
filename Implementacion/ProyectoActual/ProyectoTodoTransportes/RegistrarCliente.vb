Public Class RegistrarCliente
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim dc As DataCBOX

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        dc = New DataCBOX(conexion)
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub RegistrarCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        STATUS.Text = ""
        loadCBOX("Area")
        loadCBOX("Producto")
        loadCBOX("Tipo de Atencion")
        loadImage()
        tbox_CodigoCurso.ForeColor = Color.Gray

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        'MANEJA EL BOTÓN GUARDAR

        If validar() Then
            Dim Nombre As String = tbox_Nombre.Text
            Dim Telefono As String = tbox_Telefono.Text
            Dim Curso As String = cbox_CursoInteres.Text
            Dim Extra As String = tbox_Consultas.Text
            Dim Fecha As String = Format(date_FechaAtencion.Value, "yyyy-MM-dd")
            Dim TipoAtencion As String = cbox_TipoAtencion.SelectedValue.ToString

            Try
                con.beginTransaction()

                Dim Columnas() As String = {"Nombre", "Telefono", "Producto", "Extra"}
                Dim Parametros() As String = {Nombre, Telefono, Curso, Extra}

                Dim id As Integer = con.doInsert("Cliente_Potencial", Columnas, Parametros)

                If id <> -1 Then
                    Columnas = {"Usuario", "Cliente_Potencial", "Fecha", "Tipo"}
                    Parametros = {USER, id, Fecha, TipoAtencion}

                    id = con.doInsert("Atencion_cliente_potencial", Columnas, Parametros)
                    If id <> -1 Then
                        con.commitTransaction()
                    Else
                        con.rollbackTransaction()
                    End If
                End If

                STATUS.Text = "Cliente '" & Nombre & "' fue agregado exitosamente."
                STATUS.ForeColor = Color.Blue

                reset()

            Catch ex As Exception
                STATUS.Text = "ERROR!" + ex.Message.ToString
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
        tbox_CodigoCurso.Text = "Código"
        tbox_CodigoCurso.ForeColor = Color.Gray

    End Sub

    Sub loadCBOX(ByVal Nombre As String)
        If Nombre.Equals("Producto") Then

            cbox_CursoInteres.DataSource = dc.ProductoDeArea(cbox_Area.Text)
            cbox_CursoInteres.DisplayMember = "Nombre"
            cbox_CursoInteres.ValueMember = "Nombre"

        ElseIf Nombre.Equals("Area") Then

            cbox_Area.DataSource = dc.Area
            cbox_Area.DisplayMember = "Nombre"
            cbox_Area.ValueMember = "Nombre"

        ElseIf Nombre.Equals("Tipo de Atencion") Then

            Dim tipoAtencion As DataTable = New DataTable
            Dim columnas() As DataColumn = {New DataColumn("Nombre"), New DataColumn("Valor")}
            tipoAtencion.Columns.AddRange(columnas)
            tipoAtencion.Rows.Add("Oficina", "OFF")
            tipoAtencion.Rows.Add("Teléfono", "TEL")
            cbox_TipoAtencion.DataSource = tipoAtencion
            cbox_TipoAtencion.ValueMember = "Valor"
            cbox_TipoAtencion.DisplayMember = "Nombre"
        End If
    End Sub

    Function validar() As Boolean
        STATUS.Text = ""
        STATUS.ForeColor = System.Drawing.SystemColors.ControlText

        If tbox_Telefono.Text.Trim.Equals("") Then tbox_Telefono.Text = "0"
        If tbox_Nombre.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese el nombre del cliente."
            STATUS.ForeColor = Color.Red
            Return False
        End If
        If tbox_CodigoCurso.Text = "Código" Then
            STATUS.Text = "ERROR: Ingrese el código del curso asociado."
            STATUS.ForeColor = Color.Red
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

    Private Sub tbox_CodigoCurso_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbox_CodigoCurso.GotFocus
        If tbox_CodigoCurso.Text = "Código" Then
            tbox_CodigoCurso.Text = ""
            tbox_CodigoCurso.ForeColor = System.Drawing.SystemColors.ControlText
        End If
    End Sub


    Private Sub tbox_CodigoCurso_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbox_CodigoCurso.LostFocus
        If tbox_CodigoCurso.Text.Trim = "" Then
            tbox_CodigoCurso.Text = "Código"
            tbox_CodigoCurso.ForeColor = Color.Gray
        End If
    End Sub
End Class