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
        loadCBOX("Usuario")
        DataGridView1.DataSource = Nothing
    End Sub

#Region "Metodos"
    Sub loadCBOX(ByVal Nombre As String)
        
        If Nombre.Equals("Usuario") Then
            cbox_funcionario.DataSource = con.doQuery("SELECT Nombre FROM Usuario")

            cbox_funcionario.DisplayMember = "Nombre"
            cbox_funcionario.ValueMember = "Nombre"
            cbox_funcionario.SelectedIndex = -1

        End If
    End Sub

    Sub loadLista(ByVal fun As String)
        
        Dim data As DataTable = con.doQuery("select c.Nombre, c.telefono from atencion_cliente_potencial a, cliente_potencial c where a.Cliente_Potencial=c.idCliente_Potencial and a.usuario ='" & fun & "' and a.idATENCION_CLIENTE_POTENCIAL=(select min(idATENCION_CLIENTE_POTENCIAL) from atencion_cliente_potencial where usuario ='" & fun & "')")

        If data.Rows.Count > 0 Then
            DataGridView1.DataSource = data
        End If
    End Sub

#End Region

    Private Sub cbox_funcionario_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbox_funcionario.SelectedValueChanged
        loadLista(cbox_funcionario.Text)
    End Sub


End Class