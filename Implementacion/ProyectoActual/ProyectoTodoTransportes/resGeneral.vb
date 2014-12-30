Public Class resGeneral
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
    
    Private Sub resGeneral_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        Dim data As DataTable = con.doQuery("select p.monto as 'Monto del Pago', p.medio_pago as 'Medio de Pago', p.Fecha as 'Fecha de Pago', p.descuento as 'Descuento de Pago' " _
                                            & "from pago p, compra co, matricula m " _
                                            & "where m.codigocompra = co.idcompra and co.cliente = p.compra and m.codigo ='" & estudiante & "'")

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