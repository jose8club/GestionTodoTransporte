Public Class resProfesores
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub
    Private Sub resProfesores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Docentes")
        DataGridView1.DataSource = Nothing
        DataGridView2.DataSource = Nothing
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)
        If Nombre.Equals("Docentes") Then
            cbox_docente.DataSource = con.doQuery("SELECT a.Nombre FROM funcionario a, docente b WHERE a.idFuncionario=b.idDocente")
            cbox_docente.DisplayMember = "Nombre"
            cbox_docente.ValueMember = "Nombre"
            cbox_docente.SelectedIndex = -1
            
        End If
    End Sub

    Sub loadListaTeo(ByVal docente As String)
        Dim func As Integer = 0
        Dim f As DataTable = con.doQuery("select idfuncionario from funcionario where nombre ='" & docente & "'")

        If f.Rows.Count > 0 Then
            func = CInt(f.Rows(0).Item(0).ToString)
        Else
            func = 0
        End If

        Dim data As DataTable = con.doQuery("select c.nombre as 'Estudiantes Aprovados' " _
                                            & "from cliente c, documento d, estudiante_documento e, matricula m, compra co " _
                                            & "where d.idDocumento=e.Documento and e.estudiante=m.codigo and m.CodigoCompra=co.idCOMPRA and co.cliente=c.idCLIENTE and d.estado='Aprobado' and d.funcionario='" & func & "'")

        If data.Rows.Count > 0 Then
            DataGridView1.DataSource = data
        End If

        Dim rep As DataTable = con.doQuery("select c.nombre as 'Estudiantes Reprovados' " _
                                            & "from cliente c, documento d, estudiante_documento e, matricula m, compra co " _
                                            & "where d.idDocumento=e.Documento and e.estudiante=m.codigo and m.CodigoCompra=co.idCOMPRA and co.cliente=c.idCLIENTE and d.estado='Reprobado' and d.funcionario='" & func & "'")

        If rep.Rows.Count > 0 Then
            DataGridView2.DataSource = rep
        End If

    End Sub

#End Region

    Private Sub cbox_docente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbox_docente.SelectedIndexChanged
        loadListaTeo(cbox_docente.Text)
    End Sub

    
End Class