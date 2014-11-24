Public Class Psicotecnico
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub
    
    Private Sub Psicotecnico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Funcionario")
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)
        Dim n As Integer
        Dim items() As String
        If Nombre.Equals("Funcionario") Then
            cbox_examinador.Items.Clear()

            n = con.count("Funcionario") - 1
            items = con.toArray(n, "Nombre", "Funcionario")
            For i As Integer = 0 To n
                cbox_examinador.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_examinador.SelectedIndex = 0

        End If
    End Sub

    Function validar() As Boolean

        If tbox_codigo.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese los datos."
            Return False
        End If
        Return True
    End Function
#End Region

#Region "VALIDACION DE ENTRADA"
    Private Sub tbox_codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_codigo.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

    Private Sub tbox_estado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Herramientas.soloTexto(e)
    End Sub

    Private Sub btn_psico_Click(sender As System.Object, e As System.EventArgs) Handles btn_psico.Click
        Dim Documento As Integer = 0
        Dim Funcionario As Integer = CInt(con.selectWhereQuery("idFuncionario", "Funcionario", "Nombre = '" & cbox_examinador.Text & "'"))
        If validar() Then
            Dim Codigo As Integer = tbox_codigo.Text()
            Dim Fecha As String = Format(date_examen.Value, "yyyy-MM-dd")
            Dim Estado As Integer = cbox_estado.Text()
            Try
                con.regDocumento("Examen Psicotecnico")
                Documento = con.last("idDOCUMENTO", "Documento")
                con.regPsico(Codigo, Documento, Fecha, Funcionario, Estado)
                STATUS.Text = "Examen Psicotecnico: " & Codigo & " fue agregada exitosamente."
            Catch ex As Exception

            End Try
        End If
    End Sub
#End Region

End Class