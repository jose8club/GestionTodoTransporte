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
        loadCBOX("Instructor")
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)

        If Nombre.Equals("Instructor") Then
            cbox_instructor.Items.Clear()

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
                cbox_instructor.Items.Add(items2(i))
            Next
            If aux1 >= 0 Then cbox_instructor.SelectedIndex = 0

        End If
    End Sub

    Function validar() As Boolean

        If tbox_codigoPract.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese los datos."
            Return False
        End If
        Return True
    End Function
#End Region

#Region "VALIDACION DE ENTRADA"
    Private Sub tbox_codigoPract_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_codigoPract.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

    Private Sub tbox_calPract_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_calPract.KeyPress
        Herramientas.soloNumeros(e)
    End Sub
#End Region

    Private Sub btn_exPract_Click(sender As System.Object, e As System.EventArgs) Handles btn_exPract.Click
        Dim Documento As Integer = 0
        Dim Instructor As String = Instructores(cbox_instructor.SelectedIndex, 1)
        If validar() Then
            Dim Codigo As Integer = tbox_codigoPract.Text()
            Dim Fecha As String = Format(date_fechaPract.Value, "yyyy-MM-dd")
            Dim Calificacion As String = tbox_calPract.Text()
            Try
                con.regDocumento("Examen Practico")
                Documento = CInt(con.last("idDOCUMENTO", "Documento"))
                con.regExPract(Codigo, Documento, Fecha, Instructor, Calificacion)
                STATUS.Text = "Examen Practico: " & Codigo & " fue agregada exitosamente."
            Catch ex As Exception
                STATUS.Text = "Examen Practico: " & Codigo & " no fue agregada exitosamente."
            End Try
        End If
    End Sub
End Class