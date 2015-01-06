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
        rbtn_teorica.Checked = True
        cbox_dia.Enabled = False
        cbox_horario.Enabled = False
        lbl_docente.Text = "Profesor"
        loadCBOX("Curso Teorico")
        loadCBOX("Profesores")
        
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
        ElseIf s.Equals("dia") Then
            cbox_dia.DataSource = con.doQuery("SELECT DIA FROM Clase WHERE Curso = '" & cbox_curso.Text & "'")
            cbox_dia.DisplayMember = "DIA"
            cbox_dia.ValueMember = "DIA"
            cbox_dia.SelectedIndex = -1
        ElseIf s.Equals("Horario") Then
            cbox_horario.DataSource = con.doQuery("SELECT Horario FROM Clase WHERE Curso = '" & cbox_curso.Text & "'")
            cbox_horario.DisplayMember = "Horario"
            cbox_horario.ValueMember = "Horario"
            cbox_horario.SelectedIndex = -1
        End If
    End Sub

    Private Sub cbox_curso_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_curso.SelectedValueChanged
        cbox_dia.Enabled = False
        cbox_horario.Enabled = False
        If cbox_curso.SelectedIndex <> -1 Then
            cbox_dia.Enabled = True
            cbox_horario.Enabled = True
            loadCBOX("dia")
            loadCBOX("Horario")
        End If
    End Sub

    Private Sub cbox_profesor_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_docente.SelectedValueChanged

    End Sub

    Private Sub cbox_dia_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_dia.SelectedValueChanged

    End Sub

    Private Sub cbox_horario_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_horario.SelectedValueChanged

    End Sub

    Private Sub rbtn_practica_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtn_practica.CheckedChanged
        cbox_dia.Enabled = False
        cbox_horario.Enabled = False
        lbl_docente.Text = "Instructor"
        cbox_curso.Text = ""
        cbox_docente.Text = ""

        loadCBOX("Curso Practico")
        loadCBOX("Instructores")
    End Sub

    Private Sub rbtn_teorica_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtn_teorica.CheckedChanged
        cbox_dia.Enabled = False
        cbox_horario.Enabled = False
        lbl_docente.Text = "Profesor"
        cbox_curso.Text = ""
        cbox_docente.Text = ""

        loadCBOX("Curso Teorico")
        loadCBOX("Profesores")
    End Sub
End Class