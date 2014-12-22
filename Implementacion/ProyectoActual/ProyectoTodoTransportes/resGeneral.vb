Public Class resGeneral
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim Estudiantes(,) As String
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub
    
    Private Sub resGeneral_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Matricula")
        lbl_estudiante.Text = con.selectWhereQuery("cl.nombre", "cliente cl, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_pago.Text & "'")
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)
        Dim n As Integer
        Dim items() As String
        If Nombre.Equals("Matricula") Then
            cbox_pago.Items.Clear()

            n = con.count("Estudiante") - 1
            items = con.toArray(n, "idEstudiante", "Estudiante")

            cbox_pago.Items.Add("")
            For i As Integer = 0 To n
                cbox_pago.Items.Add(items(i))
            Next

            If n >= 0 Then cbox_pago.SelectedIndex = 0

        End If
    End Sub

    Sub loadLista(ByVal estudiante As String)
        list_pago.Items.Clear()
        Dim n As Integer
        Dim items() As String
        Dim items2() As String
        Dim items3() As String
        Dim items4() As String
        n = con.count("Pago") - 1
        items = con.toArrayWhere(n, "p.Monto", "pago p, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = p.compra and m.codigo ='" & cbox_pago.Text & "'")
        items2 = con.toArrayWhere(n, "p.medio_pago", "pago p, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = p.compra and m.codigo ='" & cbox_pago.Text & "'")
        items3 = con.toArrayWhere(n, "p.Fecha", "pago p, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = p.compra and m.codigo ='" & cbox_pago.Text & "'")
        items4 = con.toArrayWhere(n, "p.descuento", "pago p, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = p.compra and m.codigo ='" & cbox_pago.Text & "'")
        For i As Integer = 0 To n
            Dim Pago As New ListViewItem("", 0)
            Pago.SubItems.Add(items(i))
            Pago.SubItems.Add(items2(i))
            Pago.SubItems.Add(items3(i))
            Pago.SubItems.Add(items4(i))
            list_pago.Items.AddRange(New ListViewItem() {Pago})
            'list_pago.Items.Add(items(i))
            'list_medio.Items.Add(items2(i))
            'list_fecha.Items.Add(items3(i))
            'list_descuento.Items.Add(items4(i))
        Next

    End Sub
#End Region

    Private Sub cbox_pago_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_pago.SelectedValueChanged
        lbl_estudiante.Text = con.selectWhereQuery("cl.nombre", "cliente cl, compra co, matricula m", "m.codigocompra = co.idcompra and co.cliente = cl.idcliente and m.codigo ='" & cbox_pago.Text & "'")
        loadLista(cbox_pago.Text)
    End Sub
End Class