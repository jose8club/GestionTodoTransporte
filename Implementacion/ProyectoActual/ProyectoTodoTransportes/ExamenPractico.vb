Public Class ExamenPractico
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

    Private Sub ExamenPractico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Estudiante")
        loadCBOX("Funcionario")
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)

       Dim n As Integer
        Dim items() As String
        If Nombre.Equals("Funcionario") Then
            cbox_funcionario.Items.Clear()

            n = con.count("Funcionario") - 1
            items = con.toArray(n, "Nombre", "Funcionario")
            For i As Integer = 0 To n
                cbox_funcionario.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_funcionario.SelectedIndex = 0

        ElseIf Nombre.Equals("Estudiante") Then
            cbox_estudiante.Items.Clear()

            n = con.count("Cliente") - 1
            items = con.toArrayWhere(n, "Nombre", "Cliente", "TipoCliente = 'Estudiante'")
            For i As Integer = 0 To n
                cbox_estudiante.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_estudiante.SelectedIndex = 0
        End If
    End Sub

    Function validar() As Boolean

        If tbox_estado.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese los datos."
            Return False
        End If
        Return True
    End Function
#End Region

#Region "VALIDACION DE ENTRADA"
    Private Sub tbox_calPract_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Herramientas.soloNumeros(e)
    End Sub
#End Region

    Private Sub btn_exPract_Click(sender As System.Object, e As System.EventArgs) Handles btn_exPract.Click
        Dim Documento As Integer = 0
        Dim Funcionario As Integer = CInt(con.selectWhereQuery("idFuncionario", "Funcionario", "Nombre = '" & cbox_funcionario.Text & "'"))
        If validar() Then
            Dim Fecha As String = Format(date_fechaPract.Value, "yyyy-MM-dd")
            Dim Estado As String = tbox_estado.Text()
            Dim Tipo As String = "Examen Practico"
            Dim Calificacion As Integer = CInt(tbox_calPract.Text)
            Dim Cliente As Integer = CInt(con.selectWhereQuery("idCliente", "Cliente", "Nombre = '" & cbox_estudiante.Text & "' AND TipoCliente = 'Estudiante'"))
            Dim Compra As Integer = CInt(con.selectWhereQuery("idCompra", "Compra", "Cliente = '" & Cliente & "'"))
            Dim Matricula As String = con.selectWhereQuery("Codigo", "Matricula", "CodigoCompra = '" & Compra & "'")
            Dim Estudiante As String = con.selectWhereQuery("idEstudiante", "Estudiante", "idEstudiante = '" & Matricula & "'")
            Try
                con.regDocumento2(Tipo, Funcionario, Fecha, Estado)
                Documento = CInt(con.last("idDOCUMENTO", "Documento"))
                con.regExPract(Documento, Calificacion)
                con.regEstDoc(Estudiante, Documento)
                STATUS.Text = "Examen Practico de: " & cbox_estudiante.Text() & " fue agregada exitosamente."
                If (Calificacion >= 4 Or Estado = "Aprobado") Then
                    MsgBox("El estudiante : " & cbox_estudiante.Text() & " puede dar el examen municipal")
                Else
                    MsgBox("El estudiante : " & cbox_estudiante.Text() & " no puede dar el examen municipal")
                End If
            Catch ex As Exception
                STATUS.Text = "Examen Practico de: " & cbox_estudiante.Text() & " no fue agregada."
            End Try
        End If
    End Sub
End Class