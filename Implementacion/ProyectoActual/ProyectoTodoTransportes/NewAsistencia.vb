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
            lbl_docente.Text = "Profesor"
            loadCBOX("Curso Teorico")
        ElseIf rbtn_practica.Checked = False Then
            lbl_docente.Text = "Instructor"
            loadCBOX("Curso Practico")
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
        End If
    End Sub

    Private Sub cbox_curso_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_curso.SelectedValueChanged

    End Sub

    Private Sub cbox_profesor_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_profesor.SelectedValueChanged

    End Sub

    Private Sub cbox_dia_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_dia.SelectedValueChanged

    End Sub

    Private Sub cbox_horario_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_horario.SelectedValueChanged

    End Sub
End Class