﻿Imports System.Globalization

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
        Me.LimpiarBtn.PerformClick()
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
            CursoCbBx.SelectedItem = 0
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

        If Me.NRegCTxBx.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese el Nro de Registro del cliente."
            Me.NRegCTxBx.Focus()
        ElseIf Me.NombreCTxBx.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese el Nombre del cliente."
            Me.NombreCTxBx.Focus()
        ElseIf Not isRut(Me.RutCTxBx.Text, Me.DVCTxBx.Text) Then
            STATUS.Text = "ERROR: Ingrese un RUT válido."
            Me.RutCTxBx.Focus()
        ElseIf Me.TelCTxBx.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese el Teléfono del cliente."
            Me.TelCTxBx.Focus()
        ElseIf Me.EmailCTxBx.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese el Email del cliente."
            Me.EmailCTxBx.Focus()
        ElseIf ((Date.Now - Me.FNacDTiPckr.Value).TotalDays / 365) < 17 Then
            STATUS.Text = "ERROR: El cliente no puede ser menor de 17 años."
            Me.FNacDTiPckr.Focus()
        ElseIf Me.CuposTxtLbl.Equals("0") Then
            STATUS.Text = "ERROR: No hay cupos."
            Me.CursoCbBx.Focus()
        Else
            Return True
        End If
        MsgBox("", MsgBoxStyle.Critical, AcceptButton)
        STATUS.ForeColor = Color.Red
        Return False
    End Function
#End Region

    Private Sub LimpiarBtn_Click(sender As System.Object, e As System.EventArgs) Handles LimpiarBtn.Click
        'Se reinician todos los controles a su estado inicial
        'primero se vacían los campos de textos
        Me.NRegCTxBx.Text = ""
        Me.NombreCTxBx.Text = ""
        Me.RutCTxBx.Text = ""
        Me.DVCTxBx.Text = ""
        Me.TelCTxBx.Text = ""
        Me.EmailCTxBx.Text = ""
        Me.CuposTxtLbl.Text = ""
        Me.ValorTxtLbl.Text = ""
        Me.APagarTxtLbl.Text = ""
        'Luego se reestablece el campo de fecha a la actual
        Me.FNacDTiPckr.Value = Date.Today
        'Después se deseleccionan los checkbox
        Me.LuSaRaBtn.Checked = True
        Me.FotosChBx.Checked = False
        Me.FotocopiaCIChBx.Checked = False
        Me.FotocopiaLicenciaChBx.Checked = False
        Me.CertEstudiosChBx.Checked = False
        Me.CertNotarialChBx.Checked = False
        'Se vacían los combobox secundarios
        'Me.CursoCbBx.DataSource = DBNull.Value
        'Me.HraPracticaCbBx.DataSource = DBNull.Value
        'Me.HraTeoriaCbBx.DataSource = DBNull.Value
        'Luego se reestablece el valor del spinBox y algunos comboBox
        Me.DctoSpinBx.Value = 0
        Me.DocPagoCbBx.SelectedIndex = 0
        Me.MedioPagoChBx.SelectedIndex = 0

        'Después la desabilitación
        Me.CursoCbBx.Enabled = False
        Me.HraTeoriaCbBx.Enabled = False
        Me.HraPracticaCbBx.Enabled = False
        Me.DctoSpinBx.Enabled = False
        Me.MedioPagoChBx.Enabled = False
        Me.PagoRealizChBx.Enabled = False
        Me.CodPagoTxBx.Enabled = False

        'Terminando, Se establecen los valores predeterminados necesarios
        Me.ClienteCbBx.SelectedIndex = 0
        Me.ProductoCbBx.SelectedIndex = 0
        
        Me.NRegCTxBx.Focus()
    End Sub

    Private Sub GuardarBtn_Click(sender As System.Object, e As System.EventArgs) Handles GuardarBtn.Click
        'Format(Date.Today.ToString, "HH:mm:ss") & "','" & _
        'con.doQuery(
        'comprobar variables nombre, rut, telefono
        If validar() Then
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
                                         Me.CertNotarialChBx.Checked.ToString.ToLower() & "," & _
                                         Me.FotocopiaCIChBx.Checked.ToString.ToLower() & ", '" & _
                                         Me.DctoSpinBx.Value.ToString & "','" & _
                                         Me.DocPagoCbBx.Text & "','" & _
                                         Me.MedioPagoChBx.Text & "'," & _
                                         Me.PagoRealizChBx.Checked.ToString.ToLower() & ",'" & _
                                         Me.CodPagoTxBx.Text & "');" ')
            'Me.LimpiarBtn.PerformClick()
            Me.QueryTb.Text = Query
            con.doQuery(Query)
            Dim res As String = con.selectWhereQuery("1", "MATRICULA", "Codigo = '" & Me.NRegCTxBx.Text & "'")
            If res.Trim.Equals("") Then
                STATUS.Text = "ERROR: Hubo un error al agregar la matrícula, por favor intente más tarde."
                STATUS.ForeColor = Color.Red
                Me.NRegCTxBx.Focus()
            Else
                STATUS.Text = "Alumno ingresado exitosamente."
                STATUS.ForeColor = Color.Blue
                Me.LimpiarBtn.PerformClick()
                Me.NRegCTxBx.Focus()
            End If
        End If
    End Sub

    Private Sub ProductoCbBx_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ProductoCbBx.SelectedIndexChanged
        loadCBOX("CursosXProductos")
        Me.CursoCbBx.Enabled = True
    End Sub

    Private Sub CursoCbBx_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CursoCbBx.SelectedIndexChanged
        'Revisa la cantidad de cupos en el curso
        If dc.Cupos(Me.CursoCbBx.SelectedValue.ToString).Rows.Count > 0 Then
            Me.CuposTxtLbl.Text = CInt(dc.Cupos(Me.CursoCbBx.SelectedValue.ToString).Rows(0).Item(0).ToString())
        Else
            Me.CuposTxtLbl.Text = 0
        End If
        loadCBOX("HTeoriaXCurso")
        loadCBOX("HPracticaXCurso")
        If dc.MontoAPagar(Me.ClienteCbBx.SelectedValue.ToString, ProductoCbBx.SelectedValue.ToString).Rows.Count > 0 Then
            MontoAPagar = CInt(dc.MontoAPagar(Me.ClienteCbBx.SelectedValue.ToString, ProductoCbBx.SelectedValue.ToString).Rows(0).Item(0).ToString())
        Else
            MontoAPagar = 0
        End If
        Me.ValorTxtLbl.Text = "$" & MontoAPagar
        Me.APagarTxtLbl.Text = "$" & MontoAPagar
        Me.DctoSpinBx.Enabled = True
        Me.DocPagoCbBx.Enabled = True
        Me.MedioPagoChBx.Enabled = True
        Me.PagoRealizChBx.Enabled = True
    End Sub

    Private Sub PagoRealizChBx_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles PagoRealizChBx.CheckedChanged
        Me.CodPagoTxBx.Enabled = Me.PagoRealizChBx.Checked
    End Sub

    Private Sub DctoSpinBx_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DctoSpinBx.ValueChanged
        'MsgBox(Me.ValorTxtLbl.Text.Substring(1))
        If Me.ValorTxtLbl.Text.Length <> 0 Then
            Try
                Dim MtoO As Integer = Convert.ToInt32(Me.ValorTxtLbl.Text.Substring(1))
                Dim Dcto As Integer = Me.DctoSpinBx.Value
                Dim MtoAPa As Integer = MtoO - ((MtoO * Dcto) / 100)
                Me.APagarTxtLbl.Text = MtoAPa
            Catch ex As Exception
                MsgBox(Me.ValorTxtLbl.Text.Substring(1))
            End Try
        End If
    End Sub


    Private Sub ClienteCbBx_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ClienteCbBx.SelectedIndexChanged
        Try
            If dc.MontoAPagar(Me.ClienteCbBx.SelectedValue.ToString, ProductoCbBx.SelectedValue.ToString).Rows.Count > 0 Then
                MontoAPagar = CInt(dc.MontoAPagar(Me.ClienteCbBx.SelectedValue.ToString, ProductoCbBx.SelectedValue.ToString).Rows(0).Item(0).ToString())
            Else
                MontoAPagar = 0
            End If
            Me.ValorTxtLbl.Text = "$" & MontoAPagar
            Me.APagarTxtLbl.Text = "$" & MontoAPagar
        Catch ex As Exception

        End Try
        
    End Sub
End Class