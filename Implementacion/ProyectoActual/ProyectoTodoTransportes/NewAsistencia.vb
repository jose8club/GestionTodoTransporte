Public Class NewAsistencia
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim dc As DataCBOX

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        dc = New DataCBOX(con)
        STATUS = estado
        InitializeComponent()
    End Sub
    Private Sub NewAsistencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If rbtn_teorica.Checked = True Then
            cbox_dia.Enabled = False
            cbox_horario.Enabled = False
            lbl_docente.Text = "Profesor"
            loadCBOX("Curso Teorico")
            loadCBOX("Profesores")
        ElseIf rbtn_practica.Checked = False Then
            cbox_dia.Enabled = False
            cbox_horario.Enabled = False
            lbl_docente.Text = "Instructor"
            loadCBOX("Curso Practico")
            loadCBOX("Instructores")
        End If
    End Sub

    Sub loadCBOX(ByVal s As String)
        If s.Equals("Curso Teorico") Then
            cbox_curso.DataSource = dc.ClaseTeorica
            cbox_curso.DisplayMember = "Curso"
            cbox_curso.ValueMember = "idClase"
            cbox_curso.SelectedIndex = -1
        ElseIf s.Equals("Curso Teorico") Then
            cbox_curso.DataSource = dc.ClasePractica
            cbox_curso.DisplayMember = "Curso"
            cbox_curso.ValueMember = "idClase"
            cbox_curso.SelectedIndex = -1
        ElseIf s.Equals("Profesores") Then
            cbox_docente.DataSource = dc.Profesores
            cbox_docente.DisplayMember = "Nombre"
            cbox_docente.ValueMember = "idFuncionario"
            cbox_docente.SelectedIndex = -1
        ElseIf s.Equals("Instructores") Then
            cbox_docente.DataSource = dc.Instructores
            cbox_docente.DisplayMember = "Nombre"
            cbox_docente.ValueMember = "idFuncionario"
            cbox_docente.SelectedIndex = -1
        End If
    End Sub

    Private Sub cbox_curso_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_curso.SelectedValueChanged

    End Sub

    Private Sub cbox_profesor_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_docente.SelectedValueChanged

    End Sub

    Private Sub cbox_dia_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_dia.SelectedValueChanged

    End Sub

    Private Sub cbox_horario_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_horario.SelectedValueChanged

    End Sub
End Class