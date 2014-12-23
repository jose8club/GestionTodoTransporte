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
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)
        Dim n As Integer
        Dim items() As String
        If Nombre.Equals("Docentes") Then
            cbox_docente.Items.Clear()

            n = con.count("Docente") - 1
            items = con.toArrayWhere(n, "a.Nombre", "funcionario a, docente b", "a.idFuncionario=b.idDocente")

            cbox_docente.Items.Add("")
            For i As Integer = 0 To n
                cbox_docente.Items.Add(items(i))
            Next

            If n >= 0 Then cbox_docente.SelectedIndex = 0

        End If
    End Sub

    Sub loadListaTeo(ByVal docente As String)
        list_estudiantesTeo.Items.Clear()
        Dim n As Integer
        Dim items() As String
        Dim items2() As String
        Dim func As Integer = CInt(con.selectWhereQuery("idfuncionario", "funcionario", "nombre ='" & docente & "'"))
        n = con.count("documento") - 1
        items = con.toArrayWhere(n, "c.nombre", "cliente c, documento d, estudiante_documento e, matricula m, compra co ", "d.idDocumento=e.Documento and e.estudiante=m.codigo and m.CodigoCompra=co.idCOMPRA and co.cliente=c.idCLIENTE and d.estado='Aprobado' and d.funcionario='" & func & "'")
        items2 = con.toArrayWhere(n, "c.nombre", "cliente c, documento d, estudiante_documento e, matricula m, compra co ", "d.idDocumento=e.Documento and e.estudiante=m.codigo and m.CodigoCompra=co.idCOMPRA and co.cliente=c.idCLIENTE and d.estado='Reprobado' and d.funcionario='" & func & "'")

        For i As Integer = 0 To n
            Dim est As New ListViewItem("", 0)
            est.SubItems.Add(items(i))
            est.SubItems.Add(items2(i))

            list_estudiantesTeo.Items.AddRange(New ListViewItem() {est})
        Next

    End Sub

#End Region

    Private Sub cbox_docente_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbox_docente.SelectedIndexChanged
        loadListaTeo(cbox_docente.Text)
    End Sub
End Class