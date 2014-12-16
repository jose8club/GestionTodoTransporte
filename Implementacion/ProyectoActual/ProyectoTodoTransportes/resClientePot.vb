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
    Private Sub resClientePot_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Usuario")
    End Sub

#Region "Metodos"
    Sub loadCBOX(ByVal Nombre As String)
        Dim n As Integer
        Dim items2() As String
        If Nombre.Equals("Usuario") Then
            cbox_funcionario.Items.Clear()

            n = con.count("Usuario") - 1
            items2 = con.toArray(n, "Nombre", "Usuario")
            For i As Integer = 0 To n
                cbox_funcionario.Items.Add(items2(i))
            Next
            If n >= 0 Then cbox_funcionario.SelectedIndex = 0

            setItems(cbox_funcionario.Text)
            cargaLIST("Usuario")
            'list_clientes.Items.Clear()
        End If
    End Sub

    Sub setItems(ByVal Nombre As String)
        Dim n As Integer

        n = con.countWhere("Atencion_Cliente_Potencial", "Usuario = '" & Nombre & "'") - 1
        items = con.toArrayWhere(n, "Cliente_Potencial", "Atencion_Cliente_Potencial", "Usuario = '" & Nombre & "'")
        'items = con.toArray3Where(n, "Nombre", "Cliente_Potencial", "Atencion_Cliente_Potencial", "Usuario = '" & Nombre & "'")
        'For i As Integer = 0 To n
        'items(i) = con.selectWhereQuery("Nombre", "Cliente_Potencial", "idCLIENTE_POTENCIAL = '" & items3(i) & "'")
        'Next
    End Sub

    Sub cargaLIST(ByVal Nombre As String)
        list_clientes.Items.Clear()

        Dim n As Integer
        If Nombre.Equals("Usuario") Then
            n = items.Length - 1
            For i As Integer = 0 To n
                list_clientes.Items.Add(items(i))
            Next
            If list_clientes.Items.Count > 0 Then list_clientes.SelectedIndex = 0

        End If
    End Sub

#End Region

End Class