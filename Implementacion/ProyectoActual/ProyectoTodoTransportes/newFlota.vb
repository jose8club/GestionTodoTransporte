Public Class newFlota
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim dc As DataCBOX
    Dim comp As DataTable
    Dim usuario As String = ""
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        dc = New DataCBOX(con)
        STATUS = estado
        InitializeComponent()
    End Sub
    Private Sub newFlota_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("año")
        comp = con.doQuery("SELECT Tipo FROM Usuario WHERE Nombre ='" & USER & "'")
        If comp.Rows.Count > 0 Then
            usuario = comp.Rows(0).Item(0).ToString
        Else
            usuario = ""
        End If
        If usuario <> ("Recepcion") Then
            tbox_mat1.Enabled = False
            tbox_mat2.Enabled = False
            tbox_mat3.Enabled = False
            tbox_modelo.Enabled = False

            cbox_estado.Enabled = False
            cbox_estado2.Enabled = False
            cbox_instructor.Enabled = False
            cbox_instructor2.Enabled = False
            cbox_matricula.Enabled = False

            btn_agregar.Enabled = False
            btn_guardar.Enabled = False
            btn_resetear01.Enabled = False
            btn_resetear02.Enabled = False

        End If
        loadCBOX("Estado")
        loadCBOX("Instructor")
        loadCBOX("Matricula")
    End Sub

    Sub loadCBOX(ByVal s As String)
        If s.Equals("Estado") Then
            cbox_estado.DataSource = con.doQuery("SELECT * FROM Estado_Auto")
            cbox_estado.DisplayMember = "Estado"
            cbox_estado.ValueMember = "Estado"
            cbox_estado.SelectedIndex = -1
            cbox_estado2.DataSource = con.doQuery("SELECT * FROM Estado_Auto")
            cbox_estado2.DisplayMember = "Estado"
            cbox_estado2.ValueMember = "Estado"
            cbox_estado2.SelectedIndex = -1
        ElseIf s.Equals("Matricula") Then
            cbox_matricula.DataSource = con.doQuery("SELECT Matricula FROM Auto_Escuela")
            cbox_matricula.DisplayMember = "Matricula"
            cbox_matricula.ValueMember = "Matricula"
            cbox_matricula.SelectedIndex = -1
            
        ElseIf s.Equals("Instructor") Then
            cbox_instructor.DataSource = dc.Instructores
            cbox_instructor.DisplayMember = "Nombre"
            cbox_instructor.ValueMember = "idFuncionario"
            cbox_instructor.SelectedIndex = -1
            cbox_instructor2.DataSource = dc.Instructores
            cbox_instructor2.DisplayMember = "Nombre"
            cbox_instructor2.ValueMember = "idFuncionario"
            cbox_instructor2.SelectedIndex = -1
        ElseIf s.Equals("año") Then
            Dim año As DataTable = New DataTable
            año.Columns.Add("Nombre")
            año.Rows.Add("Pre 2007")
            año.Rows.Add("Post 2007")

            cbox_anio.DataSource = año
            cbox_anio.DisplayMember = "Nombre"
            cbox_anio.ValueMember = "Nombre"
        End If

    End Sub

#Region "VALIDACION DE ENTRADA"

    Private Sub tbox_mat1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_mat1.KeyPress
        Herramientas.soloTexto(e)
    End Sub

    Private Sub tbox_mat2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_mat2.KeyPress
        If cbox_anio.SelectedValue.Equals("Pre 2007") Then
            Herramientas.soloNumeros(e)
        ElseIf cbox_anio.SelectedValue.Equals("Post 2007") Then
            Herramientas.soloTexto(e)
        End If
    End Sub

    Private Sub tbox_mat3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_mat3.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

#End Region
End Class