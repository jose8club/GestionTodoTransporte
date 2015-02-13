Imports System.Globalization

Public Class Matricula

    Private USER As String
    Private con As Conexion
    Private STATUS As ToolStripStatusLabel
    Dim dc As DataCBOX
    Dim MontoAPagar As Integer

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        dc = New DataCBOX(conexion)
        InitializeComponent()
    End Sub

    Private Sub Matricula_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("FranqTributaria")
        loadCBOX("Producto")
        loadCBOX("MedioPago")
    End Sub

#Region "METODOS"
    Sub loadCBOX(ByVal Nombre As String)
        If Nombre.Equals("Producto") Then

            ProductoCbBx.DataSource = dc.Productos
            ProductoCbBx.DisplayMember = "Nombre"
            ProductoCbBx.ValueMember = "Nombre"
            ProductoCbBx.SelectedIndex = -1

        ElseIf Nombre.Equals("FranqTributaria") Then

            ClienteCbBx.DataSource = dc.Clientes
            ClienteCbBx.DisplayMember = "Nombre"
            ClienteCbBx.ValueMember = "Nombre"

        ElseIf Nombre.Equals("CursosXProductos") Then
            CursoCbBx.DataSource = dc.CursosDeProducto(ProductoCbBx.Text)
            CursoCbBx.DisplayMember = "Codigo"
            CursoCbBx.ValueMember = "Codigo"
            CursoCbBx.SelectedItem = -1
            HraTeoriaCbBx.Enabled = True
            HraPracticaCbBx.Enabled = True
            DiasGBx.Enabled = True

        ElseIf Nombre.Equals("HTeoriaXCurso") Then 'terminar
            HraTeoriaCbBx.DataSource = dc.HTeoriaDeCurso(CursoCbBx.Text)
            HraTeoriaCbBx.DisplayMember = "Horario"
            HraTeoriaCbBx.ValueMember = "Horario"

        ElseIf Nombre.Equals("HPracticaXCurso") Then 'terminar
            HraPracticaCbBx.DataSource = dc.HPracticaDeCurso(CursoCbBx.Text)
            HraPracticaCbBx.DisplayMember = "Horario"
            HraPracticaCbBx.ValueMember = "Horario"

        ElseIf Nombre.Equals("DocumentoPago") Then 'terminar
            DocPagoCbBx.DataSource = dc.DocPago
            DocPagoCbBx.DisplayMember = "Value"
            DocPagoCbBx.ValueMember = "Value"

        ElseIf Nombre.Equals("MedioPago") Then 'terminar
            MedioPagoChBx.DataSource = dc.MedioPago
            MedioPagoChBx.ValueMember = "Nombre"

        End If
    End Sub

    Function validar() As Boolean
        STATUS.Text = ""
        STATUS.ForeColor = System.Drawing.SystemColors.ControlText

        If TelCTxBx.Text.Trim.Equals("") Then TelCTxBx.Text = "0"
        If NombreCTxBx.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese el nombre del cliente."
            STATUS.ForeColor = Color.Red
            Return False
        End If

        Return True
    End Function
#End Region

    Private Sub LimpiarBtn_Click(sender As System.Object, e As System.EventArgs) Handles LimpiarBtn.Click
        Me.NombreCTxBx.Text = ""
        Me.RutCTxBx.Text = ""
        Me.DVCTxBx.Text = ""
        Me.FNacDTiPckr.Value = Date.Today
        Me.TelCTxBx.Text = ""
        Me.ClienteCbBx.Text = ""
        Me.ProductoCbBx.Text = ""
        Me.CursoCbBx.Text = ""
        Me.HraPracticaCbBx.Text = ""
        Me.HraTeoriaCbBx.Text = ""
        Me.FotosChBx.Checked = False
        Me.FotocopiaCIChBx.Checked = False
        Me.FotocopiaLicenciaChBx.Checked = False
        Me.CertEstudiosChBx.Checked = False
        Me.CertNotarialChBx.Checked = False
        Me.ValorTxtLbl.Text = "$$$$"
        Me.DctoSpinBx.Value = 0
        Me.APagarTxtLbl.Text = "$$$$"
        Me.DocPagoCbBx.Text = ""
        Me.MedioPagoChBx.Text = ""
        Me.PagoRealizChBx.Enabled = False
        Me.CodPagoTxBx.Text = ""
    End Sub

    Private Sub GuardarBtn_Click(sender As System.Object, e As System.EventArgs) Handles GuardarBtn.Click
        'Format(Date.Today.ToString, "HH:mm:ss") & "','" & _
        'con.doQuery(
        Dim Query As String = "call MATRICULAR('" & Me.NRegCTxBx.Text & "', '" & _
                                     Me.NombreCTxBx.Text & "', '" & _
                                     Me.RutCTxBx.Text & "-" & Me.DVCTxBx.Text & "','" & _
                                     Format(Me.FNacDTiPckr.Value, "yyyy-MM-dd") & "','" & _
                                     Me.TelCTxBx.Text & "','" & _
                                     Me.EmailCTxBx.Text & "','" & _
                                     Me.ClienteCbBx.Text & "','" & _
                                     Me.ProductoCbBx.Text & "','" & _
                                     Format(Date.Today, "yyyy-MM-dd") & "','" & _
                                     Me.USER & "','" & _
                                     Me.CursoCbBx.Text & "','" & _
                                     Me.HraTeoriaCbBx.Text & "','" & _
                                     Me.HraPracticaCbBx.Text & "'," & _
                                     Me.LuViRaBtn.Enabled.ToString.ToLower() & "," & _
                                     Me.FotosChBx.Checked.ToString.ToLower() & "," & _
                                     Me.CertEstudiosChBx.Checked.ToString.ToLower() & "," & _
                                     Me.CertNotarialChBx.Checked.ToString.ToLower() & ",'" & _
                                     Me.DctoSpinBx.Value.ToString & "','" & _
                                     Me.DocPagoCbBx.Text & "','" & _
                                     Me.MedioPagoChBx.Text & "'," & _
                                     Me.PagoRealizChBx.Checked.ToString.ToLower() & ",'" & _
                                     Me.CodPagoTxBx.Text & "');" ')
        Me.LimpiarBtn.PerformClick()
        Me.QueryTb.Text = Query
    End Sub

    Private Sub ProductoCbBx_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ProductoCbBx.SelectedIndexChanged
        loadCBOX("CursosXProductos")
        CursoCbBx.Enabled = True
    End Sub

    Private Sub CursoCbBx_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CursoCbBx.SelectedIndexChanged
        If dc.Cupos(CursoCbBx.SelectedValue.ToString).Rows.Count > 0 Then
            CuposTxtLbl.Text = CInt(dc.Cupos(CursoCbBx.SelectedValue.ToString).Rows(0).Item(0).ToString())
        Else
            CuposTxtLbl.Text = 0
        End If
        loadCBOX("HTeoriaXCurso")
        loadCBOX("HPracticaXCurso")
        LuViRaBtn.PerformClick()
        If dc.MontoAPagar(ClienteCbBx.SelectedValue.ToString, ProductoCbBx.SelectedValue.ToString).Rows.Count > 0 Then
            MontoAPagar = CInt(dc.MontoAPagar(ClienteCbBx.SelectedValue.ToString, ProductoCbBx.SelectedValue.ToString).Rows(0).Item(0).ToString())
        Else
            MontoAPagar = 0
        End If
        APagarTxtLbl.Text = MontoAPagar
    End Sub

End Class