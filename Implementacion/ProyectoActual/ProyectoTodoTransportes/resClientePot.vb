Public Class resClientePot
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim items() As String
    Dim items3() As String
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub
    Private Sub resClientePot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("ñe")
        loadCBOX("Usuario")
    End Sub

#Region "Metodos"
    Sub loadCBOX(ByVal Nombre As String)
        Dim n As Integer
        Dim items2() As String
        If Nombre.Equals("usuario") Then
            cbox_funcionario.Items.Clear()

            n = con.count("usuario") - 1
            items2 = con.toArray(n, "nombre", "usuario")
            cbox_funcionario.Items.Add("")
            For i As Integer = 0 To n
                cbox_funcionario.Items.Add(items2(i))
            Next
            If n >= 0 Then cbox_funcionario.SelectedIndex = 0


        End If

        'Dim func As DataTable = con.doQuery("SELECT Nombre FROM Usuario")
        'cbox_funcionario.DataSource = func
        'cbox_funcionario.DisplayMember = "Nombre"
        ''cbox_funcionario.ValueMember = "Codigo"
    End Sub

    Sub loadLista(ByVal fun As String)
        list_pago.Items.Clear()
        Dim s As Integer
        Dim n As Integer
        Dim items() As String
        Dim items2() As String
        'Dim comp As String = (con.selectWhereQuery("min(c.idCliente_Potencial)", "atencion_cliente_potencial a, cliente_potencial c", "a.Cliente_Potencial=c.idCliente_Potencial and a.usuario ='" & fun & "'"))
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
            list_pago.Items.AddRange(New ListViewItem() {Pago})
        Next

    End Sub

#End Region

    Private Sub cbox_funcionario_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_funcionario.SelectedValueChanged
        'loadLista(cbox_funcionario.Text)
    End Sub

End Class