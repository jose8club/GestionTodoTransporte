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

    Sub loadLista(ByVal fun As String)
        list_asistencias.Items.Clear()
        Dim s As Integer
        Dim n As Integer
        Dim items() As String
        Dim items2() As String
        If fun.Equals("") Then
            s = 0
        Else
            s = CInt(con.selectWhereQuery("min(idATENCION_CLIENTE_POTENCIAL)", "atencion_cliente_potencial", "usuario ='" & fun & "'"))
        End If
        n = con.count("Cliente_Potencial") - 1
        items = con.toArrayWhere(n, "c.Nombre", "atencion_cliente_potencial a, cliente_potencial c", "a.Cliente_Potencial=c.idCliente_Potencial and a.usuario ='" & fun & "' and a.idATENCION_CLIENTE_POTENCIAL = '" & s & "'")
        items2 = con.toArrayWhere(n, "c.Telefono", "atencion_cliente_potencial a, cliente_potencial c", "a.Cliente_Potencial=c.idCliente_Potencial and a.usuario ='" & fun & "' and a.idATENCION_CLIENTE_POTENCIAL = '" & s & "'")
        For i As Integer = 0 To n
            Dim Pago As New ListViewItem("", 0)
            Pago.SubItems.Add(items(i))
            Pago.SubItems.Add(items2(i))
            list_asistencias.Items.AddRange(New ListViewItem() {Pago})
        Next

    End Sub
#End Region

    Private Sub cbox_estudiante_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_estudiante.SelectedValueChanged
        lbl_estudiante.Text = con.selectWhereQuery("cl.nombre", "cliente cl, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_estudiante.Text & "'")
        loadLista(cbox_estudiante.Text)
    End Sub
End Class