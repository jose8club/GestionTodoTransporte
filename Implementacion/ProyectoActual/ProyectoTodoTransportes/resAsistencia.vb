Public Class resAsistencia
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
    Private Sub resAsistencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Matricula")
        DataGridView1.DataSource = Nothing
        DataGridView2.DataSource = Nothing
    End Sub
#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)
        If Nombre.Equals("Matricula") Then
            cbox_estudiante.DataSource = datacbox.Estudiantes
            cbox_estudiante.DisplayMember = "idEstudiante"
            cbox_estudiante.ValueMember = "idEstudiante"
            cbox_estudiante.SelectedIndex = -1
        End If
    End Sub

    Sub loadLista(ByVal est As String)
        Dim data As DataTable = con.doQuery("select a.Fecha as 'Asistencia Clases Teoricas' from asistencia a, asistencia_teoria ap where a.Estudiante=ap.Estudiante and a.Estudiante='" & est & "'")

        If data.Rows.Count > 0 Then
            DataGridView1.DataSource = data
        End If

        Dim rep As DataTable = con.doQuery("select a.Fecha as 'Asistencia Clases Prácticas' from asistencia a, asistencia_practica ap where a.Estudiante=ap.Estudiante and a.Estudiante='" & est & "'")

        If rep.Rows.Count > 0 Then
            DataGridView2.DataSource = rep
        End If
    End Sub

    
#End Region

    Private Sub cbox_estudiante_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_estudiante.SelectedValueChanged
        Dim label As DataTable = con.doQuery("SELECT cl.nombre " _
                                        & "FROM cliente cl, compra co, matricula m" _
                                         & " WHERE m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_estudiante.Text & "'")

        If label.Rows.Count > 0 Then
            lbl_estudiante.Text = label.Rows(0).Item(0).ToString
        Else
            lbl_estudiante.Text = ""
        End If
        loadLista(cbox_estudiante.Text)

    End Sub
End Class