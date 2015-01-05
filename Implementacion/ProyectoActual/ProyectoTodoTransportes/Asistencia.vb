Public Class Asistencia
    Dim con As New Conexion
    Dim USER As String = ""
    Dim datacbox As DataCBOX
    Dim tipo As String = ""
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal texto As String)
        con = conexion
        USER = usuario
        tipo = texto
        datacbox = New DataCBOX(con)
        InitializeComponent()
    End Sub
    Private Sub Asistencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If tipo.Equals("Asistencia Teorica") Then
            grp_asistencia.Text = "Asistencia Teorica"
            lbl_docente.Text = "Profesor"
            loadCBOX("Profesor")
        ElseIf tipo.Equals("Asistencia Práctica") Then
            grp_asistencia.Text = "Asistencia Práctica"
            lbl_docente.Text = "Instructor"
            loadCBOX("Instructores")
        End If
    End Sub

#Region "Métodos"

    Sub loadCBOX(ByVal Nombre As String)
        If Nombre.Equals("Instructores") Then
            cbox_docente.DataSource = datacbox.Instructores
            cbox_docente.DisplayMember = "Nombre"
            cbox_docente.ValueMember = "idFuncionario"
            cbox_docente.SelectedIndex = -1
        ElseIf Nombre.Equals("Profesor") Then
            cbox_docente.DataSource = datacbox.Profesores
            cbox_docente.DisplayMember = "Nombre"
            cbox_docente.ValueMember = "idFuncionario"
            cbox_docente.SelectedIndex = -1
        End If

    End Sub

    Sub loadLista(ByVal doc As String)
        Dim dgvColumnCheck As DataGridViewCheckBoxColumn
        Dim HeaderText(3) As String
        HeaderText(0) = "Nombre Estudiante"
        HeaderText(1) = "Asistió o no"

        For i As Integer = 0 To 1
            If i = 1 Then
                dgvColumnCheck = New DataGridViewCheckBoxColumn()
                dgvColumnCheck.Name = HeaderText(i)
                dgvColumnCheck.HeaderText = HeaderText(i)
                DataGridView1.Columns.Add(dgvColumnCheck)
            Else
                'Dim data As DataTable = con.doQuery("SELECT ")

                'If data.Rows.Count > 0 Then
                '    DataGridView1.DataSource = data
                'End If
            End If
        Next

    End Sub

#End Region


    Private Sub cbox_docente_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_docente.SelectedValueChanged
        loadLista(cbox_docente.Text)
    End Sub
End Class