Public Class ExamenMunicipal
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
    Private Sub ExamenMunicipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Instructor")
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)

        If Nombre.Equals("Instructor") Then
            cbox_instMun.Items.Clear()

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
                cbox_instMun.Items.Add(items2(i))
            Next
            If aux1 >= 0 Then cbox_instMun.SelectedIndex = 0

        End If
    End Sub

    Function validar() As Boolean

        If tbox_codMunicipal.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese los datos."
            Return False
        End If
        Return True
    End Function
#End Region

#Region "VALIDACION DE ENTRADA"
    Private Sub tbox_codMunicipal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_codMunicipal.KeyPress
        Herramientas.soloNumeros(e)
    End Sub
#End Region

    Private Sub btn_Municipal_Click(sender As System.Object, e As System.EventArgs) Handles btn_Municipal.Click
        Dim Documento As Integer = 0
        Dim Instructor As String = Instructores(cbox_instMun.SelectedIndex, 1)
        If validar() Then
            Dim Codigo As Integer = CInt(tbox_codMunicipal.Text())
            Dim Estado As String = cbox_estMun.Text()
            Dim Comentario As String = rtbox_comentario.Text()
            Try
                con.regDocumento("Examen Municipal")
                Documento = CInt(con.last("idDOCUMENTO", "Documento"))
                con.regExMun(Codigo, Documento, Instructor, Estado, Comentario)
                STATUS.Text = "Examen Municipal: " & Codigo & " fue agregada exitosamente."
            Catch ex As Exception
                STATUS.Text = "Examen Municipal: " & Codigo & " no fue agregada exitosamente."
            End Try
        End If
    End Sub
End Class