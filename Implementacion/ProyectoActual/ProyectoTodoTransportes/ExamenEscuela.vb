Public Class ExamenEscuela
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim datacbox As DataCBOX
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        datacbox = New DataCBOX(con)
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub ExamenEscuela_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        rbtn_aprobado.Checked = True
        tbox_calTeo.Enabled = False
        tbox_calPract.Enabled = False
        rtbox_comentario.Enabled = False
        sbox_hor1.Enabled = False
        sbox_hor2.Enabled = False
        chbox_cert.Enabled = False
        rbtn_aprobadoPsico.Enabled = False
        rbtn_reprobadoPsico.Enabled = False
        cbox_funcionario.Enabled = False

        loadCBOX("Matricula")
        loadCBOX("Tipo")
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)
        If Nombre.Equals("Funcionario") Then
            cbox_funcionario.DataSource = datacbox.Funcionarios
            cbox_funcionario.DisplayMember = "Nombre"
            cbox_funcionario.ValueMember = "Nombre"
            cbox_funcionario.SelectedIndex = -1
        ElseIf Nombre.Equals("Matricula") Then
            cbox_matricula.DataSource = datacbox.Estudiantes
            cbox_matricula.DisplayMember = "idEstudiante"
            cbox_matricula.ValueMember = "idEstudiante"
            cbox_matricula.SelectedIndex = -1
        ElseIf Nombre.Equals("Tipo") Then
            cbox_tipo.DataSource = con.doQuery("SELECT Nombre FROM Tipo_Documento WHERE Nombre <> 'Matricula'")
            cbox_tipo.DisplayMember = "Nombre"
            cbox_tipo.ValueMember = "Nombre"
            cbox_tipo.SelectedIndex = -1
        ElseIf Nombre.Equals("Profesores") Then
            cbox_funcionario.DataSource = datacbox.Profesores
            cbox_funcionario.DisplayMember = "Nombre"
            cbox_funcionario.ValueMember = "Nombre"
            cbox_funcionario.SelectedIndex = -1
        ElseIf Nombre.Equals("Instructores") Then
            cbox_funcionario.DataSource = datacbox.Instructores
            cbox_funcionario.DisplayMember = "Nombre"
            cbox_funcionario.ValueMember = "Nombre"
            cbox_funcionario.SelectedIndex = -1
        End If

    End Sub

    Function validar() As Boolean

        If cbox_matricula.Text = "" Then
            MsgBox("Ingrese datos de matricula")
            Return False
        ElseIf cbox_funcionario.Text = "" Then
            MsgBox("Ingrese datos de funcionario")
            Return False
        ElseIf chbox_cert.Checked = False Then
            MsgBox("Debe de haber un certificado oftalmologico que almacenar")
            Return False
        ElseIf rbtn_aprobado.Checked = False And rbtn_reprobado.Checked = False Then
            MsgBox("Seleccione una opción de examenes")
            Return False
        End If

        Return True
    End Function
#End Region

    Private Sub cbox_matricula_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_matricula.SelectedValueChanged
        Dim label As DataTable = con.doQuery("SELECT cl.nombre " _
                                        & "FROM cliente cl, compra co, matricula m" _
                                         & " WHERE m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_matricula.Text & "'")

        If label.Rows.Count > 0 Then
            lbl_estudiante.Text = label.Rows(0).Item(0).ToString
        Else
            lbl_estudiante.Text = ""
        End If
    End Sub

    Private Sub cbox_tipo_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_tipo.SelectedValueChanged
        If cbox_tipo.Text.Equals("Examen Teorico") Then
            cbox_funcionario.Enabled = True
            loadCBOX("Profesores")
            tbox_calTeo.Enabled = True

            tbox_calPract.Enabled = False
            rtbox_comentario.Enabled = False
            sbox_hor1.Enabled = False
            sbox_hor2.Enabled = False
            chbox_cert.Enabled = False
            rbtn_aprobadoPsico.Enabled = False
            rbtn_reprobadoPsico.Enabled = False
        ElseIf cbox_tipo.Text.Equals("Examen Teorico") Then
            cbox_funcionario.Enabled = True
            loadCBOX("Instructores")
            tbox_calPract.Enabled = True

            tbox_calTeo.Enabled = False
            rtbox_comentario.Enabled = False
            sbox_hor1.Enabled = False
            sbox_hor2.Enabled = False
            chbox_cert.Enabled = False
            rbtn_aprobadoPsico.Enabled = False
            rbtn_reprobadoPsico.Enabled = False
            End If

    End Sub
End Class