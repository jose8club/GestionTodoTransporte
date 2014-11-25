Public Class CambioRueda
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim Instructores(,) As String
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub CambioRueda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Instructor")
    End Sub

#Region "Metodos"
    Sub loadCBOX(ByVal Nombre As String)
        If Nombre.Equals("Instructor") Then
            cbox_instRueda.Items.Clear()

            Dim aux1 As String = con.countWhere("Docente", "Tipo = 'INS'") - 1
            Dim aux2() As String = con.toArrayWhere(aux1, "idDocente", "Docente", "Tipo = 'INS'")

            Dim arreglo(aux1, 2) As String
            For i As Integer = 0 To aux1
                arreglo(i, 0) = con.selectWhereQuery("Nombre", "Funcionario", "idFuncionario = '" & aux2(i) & "'")
                arreglo(i, 1) = aux2(i)
            Next

            Instructores = arreglo

            Dim items2(aux1) As String
            For i As Integer = 0 To aux1
                items2(i) = arreglo(i, 0)
            Next

            For i As Integer = 0 To aux1
                cbox_instRueda.Items.Add(items2(i))
            Next
            If aux1 >= 0 Then cbox_instRueda.SelectedIndex = 0
        End If

    End Sub
    Function validar() As Boolean
        If tbox_codigoRueda.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese los datos."
            MsgBox("ERROR: Ingrese los datos.")
            Return False
        End If
        Return True
    End Function
#End Region

#Region "VALIDACION DE ENTRADA"
    Private Sub tbox_codigoRueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_codigoRueda.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

    Private Sub tbox_hor1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_hor1.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

    Private Sub tbox_hor2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_hor2.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

    Private Sub btn_rueda_Click(sender As System.Object, e As System.EventArgs) Handles btn_rueda.Click
        If validar() Then
            Dim Codigo As Integer = tbox_codigoRueda.Text()
            Dim Documento As Integer = 0
            Dim Fecha As String = Format(date_rueda.Value, "yyyy-MM-dd")
            Dim Horario As String = tbox_hor1.Text & ":" & tbox_hor2.Text & ":00"
            Dim Instructor As Integer = Instructores(cbox_instRueda.SelectedIndex, 1)
            Try
                con.regDocumento("Cambio Rueda")
                Documento = CInt(con.last("idDOCUMENTO", "Documento"))
                con.regRueda(Codigo, Documento, Fecha, Horario, Instructor)
                STATUS.Text = "Clase cambio rueda" & Codigo & " fue agregada exitosamente."
            Catch ex As Exception

            End Try
        End If
    End Sub
#End Region
End Class