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
        Dim data As DataTable = con.doQuery("select et.calificacion, ep.calificacion, c.estado " _
                                           & "from documento a, documento b, documento c, examen_teorico et, examen_practico ep, examen_municipal em, estudiante_documento d, estudiante_documento e, estudiante_documento f " _
                                           & "where et.Documento=a.idDOCUMENTO and a.idDOCUMENTO=d.Documento and d.Estudiante='" & estudiante & "' and " _
                                                   & "ep.Documento=b.idDOCUMENTO and b.idDOCUMENTO=e.Documento and e.Estudiante='" & estudiante & "' and " _
                                                   & "em.Documento=c.idDOCUMENTO and c.idDOCUMENTO=f.Documento and f.Estudiante='" & estudiante & "'")
        If data.Rows.Count > 0 Then
            DataGridView1.DataSource = data
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