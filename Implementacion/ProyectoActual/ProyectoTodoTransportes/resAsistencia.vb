Public Class resAsistencia
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub
    Private Sub resAsistencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Matricula")
        lbl_estudiante.Text = con.selectWhereQuery("cl.nombre", "cliente cl, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_estudiante.Text & "'")
    End Sub
#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)

        Dim n As Integer
        Dim items() As String

        If Nombre.Equals("Matricula") Then
            cbox_estudiante.Items.Clear()

            n = con.count("Estudiante") - 1
            items = con.toArray(n, "idEstudiante", "Estudiante")

            cbox_estudiante.Items.Add("")
            For i As Integer = 0 To n
                cbox_estudiante.Items.Add(items(i))
            Next

            If n >= 0 Then cbox_estudiante.SelectedIndex = 0

        End If
    End Sub

    Sub loadListateo(ByVal est As String)
        list_asistenciasteo.Items.Clear()
        Dim n As Integer
        Dim items() As String
        n = con.count("Asistencia_Teoria") - 1
        items = con.toArrayWhere(n, "a.Fecha", "asistencia a, asistencia_teoria ap", "a.Estudiante=ap.Estudiante and a.Estudiante='" & est & "'")
        For i As Integer = 0 To n
            Dim ast As New ListViewItem("", 0)
            ast.SubItems.Add(items(i))
            list_asistenciasteo.Items.AddRange(New ListViewItem() {ast})
        Next

    End Sub

    Sub loadListapract(ByVal est As String)
        list_asistenciapract.Items.Clear()
        Dim n As Integer
        Dim items() As String
        n = con.count("Asistencia_Practica") - 1
        items = con.toArrayWhere(n, "a.Fecha", "asistencia a, asistencia_practica ap", "a.Estudiante=ap.Estudiante and a.Estudiante='" & est & "'")
        For i As Integer = 0 To n
            Dim asp As New ListViewItem("", 0)
            asp.SubItems.Add(items(i))
            list_asistenciapract.Items.AddRange(New ListViewItem() {asp})
        Next

    End Sub
#End Region

    Private Sub cbox_estudiante_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_estudiante.SelectedValueChanged
        lbl_estudiante.Text = con.selectWhereQuery("cl.nombre", "cliente cl, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_estudiante.Text & "'")
        loadListateo(cbox_estudiante.Text)
        loadListapract(cbox_estudiante.Text)
    End Sub
End Class