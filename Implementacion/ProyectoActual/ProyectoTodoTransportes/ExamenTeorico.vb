Public Class ExamenTeorico
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim Profesores(,) As String
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub
    Private Sub ExamenTeorico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Profesor")
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)
        
        If Nombre.Equals("Profesor") Then
            cbox_examinador.Items.Clear()

            Dim aux1 As String = con.countWhere("Docente", "Tipo = 'PRO'") - 1
            Dim aux2() As String = con.toArrayWhere(aux1, "idDocente", "Docente", "Tipo = 'PRO'")

            Dim arreglo(aux1, 2) As String
            For i As Integer = 0 To aux1
                arreglo(i, 0) = con.selectWhereQuery("Nombre", "Funcionario", "idFuncionario = '" & aux2(i) & "'")
                arreglo(i, 1) = aux2(i)
            Next

            Profesores = arreglo

            Dim items2(aux1) As String
            For i As Integer = 0 To aux1
                items2(i) = arreglo(i, 0)
            Next

            For i As Integer = 0 To aux1
                cbox_examinador.Items.Add(items2(i))
            Next
            If aux1 >= 0 Then cbox_examinador.SelectedIndex = 0

        End If
    End Sub

    Function validar() As Boolean

        If tbox_codigoTeo.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese los datos."
            Return False
        End If
        Return True
    End Function
#End Region

#Region "VALIDACION DE ENTRADA"
    Private Sub tbox_codigoTeo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_codigoTeo.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

    Private Sub tbox_calificacionTeo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_calificacionTeo.KeyPress
        Herramientas.soloNumeros(e)
    End Sub
#End Region

    Private Sub btn_exTeo_Click(sender As System.Object, e As System.EventArgs) Handles btn_exTeo.Click
        Dim Documento As Integer = 0
        Dim Profesor As String = cbox_examinador.Text
        If validar() Then
            Dim Codigo As Integer = tbox_codigoTeo.Text()
            Dim Fecha As String = Format(date_examenTeo.Value, "yyyy-MM-dd")
            Dim Calificacion As String = tbox_calificacionTeo.Text()
            Try
                con.regDocumento("Examen Teorico")
                Documento = CInt(con.last("idDOCUMENTO", "Documento"))
                con.regExTeo(Codigo, Documento, Fecha, Profesor, Calificacion)
                STATUS.Text = "Examen Teorico: " & Codigo & " fue agregada exitosamente."
            Catch ex As Exception
                STATUS.Text = "Examen Teorico: " & Codigo & " no fue agregada exitosamente."
            End Try
        End If
    End Sub
End Class