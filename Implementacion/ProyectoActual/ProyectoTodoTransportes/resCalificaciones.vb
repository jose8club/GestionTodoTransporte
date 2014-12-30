Public Class resCalificaciones
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
    Private Sub resCalificaciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Matricula")
        DataGridView1.DataSource = Nothing
        DataGridView2.DataSource = Nothing
        DataGridView3.DataSource = Nothing
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)
        If Nombre.Equals("Matricula") Then
            cbox_pago.DataSource = datacbox.Estudiantes
            cbox_pago.DisplayMember = "idEstudiante"
            cbox_pago.ValueMember = "idEstudiante"
            cbox_pago.SelectedIndex = -1
        End If
    End Sub

    Sub loadLista(ByVal estudiante As String)
        Dim exteo As DataTable = con.doQuery("select et.calificacion as 'Calificación Examen Teorico' " _
                                           & "from documento a, examen_teorico et, estudiante_documento d " _
                                           & "where et.Documento=a.idDOCUMENTO and a.idDOCUMENTO=d.Documento and d.Estudiante='" & estudiante & "'")
        If exteo.Rows.Count > 0 Then
            DataGridView1.DataSource = exteo
        End If

        Dim expract As DataTable = con.doQuery("select ep.calificacion as 'Calificación Examen Práctico' " _
                                           & "from documento b, examen_practico ep, estudiante_documento e " _
                                           & "where ep.Documento=b.idDOCUMENTO and b.idDOCUMENTO=e.Documento and e.Estudiante='" & estudiante & "'")
        If expract.Rows.Count > 0 Then
            DataGridView2.DataSource = expract
        End If

        Dim exmun As DataTable = con.doQuery("select c.estado as 'Calificación Examen Municipal' " _
                                           & "from documento c, examen_municipal em, estudiante_documento f " _
                                           & "where em.Documento=c.idDOCUMENTO and c.idDOCUMENTO=f.Documento and f.Estudiante='" & estudiante & "'")
        If exmun.Rows.Count > 0 Then
            DataGridView3.DataSource = exmun
        End If

    End Sub
#End Region

    Private Sub cbox_pago_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_pago.SelectedValueChanged
        Dim label As DataTable = con.doQuery("SELECT cl.nombre " _
                                        & "FROM cliente cl, compra co, matricula m" _
                                         & " WHERE m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_pago.Text & "'")

        If label.Rows.Count > 0 Then
            lbl_estudiante.Text = label.Rows(0).Item(0).ToString
        Else
            lbl_estudiante.Text = ""
        End If
        loadLista(cbox_pago.Text)
    End Sub

End Class