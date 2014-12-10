Public Class ClaseTeorica
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
    Private Sub ClaseTeorica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Curso")
        loadCBOX("Profesor")
    End Sub


#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)
        Dim n As Integer
        Dim items() As String
        If Nombre.Equals("Curso") Then
            cbox_Curso.Items.Clear()

            n = con.count("Curso") - 1
            items = con.toArray(n, "Codigo", "Curso")
            For i As Integer = 0 To n
                cbox_Curso.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_Curso.SelectedIndex = 0
        ElseIf Nombre.Equals("Profesor") Then

            cbox_Profesor.Items.Clear()

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
                cbox_Profesor.Items.Add(items2(i))
            Next
            If aux1 >= 0 Then cbox_Profesor.SelectedIndex = 0

        End If
    End Sub

    Function validar() As Boolean
        If tbox_Duracion.Text = "" Then tbox_Duracion.Text = "0"
        If tbox_Codigo.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese los datos."
            Return False
        End If
        Return True
    End Function
#End Region

#Region "VALIDACION DE ENTRADA"
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

    Private Sub tbox_Duracion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_Duracion.KeyPress
        Herramientas.soloNumeros(e)
    End Sub
#End Region

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text.Equals("") Then
            TextBox1.Text = "0"
        End If

        Dim H As Integer = Herramientas.HoraMaxima(TextBox1.Text)
        If H < 10 Then TextBox1.Text = "0" & H Else TextBox1.Text = H
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text.Equals("") Then
            TextBox2.Text = "0"
        End If
        Dim M As Integer = Herramientas.MinutoMaximo(TextBox2.Text)
        If M < 10 Then TextBox2.Text = "0" & M Else TextBox2.Text = M
    End Sub

    Private Sub btn_teorica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_teorica.Click
        If validar() Then
            Dim Codigo As String = tbox_Codigo.Text
            Dim Duracion As Integer = CInt(tbox_Duracion.Text)
            Dim Horario As String = TextBox1.Text & ":" & TextBox2.Text & ":00"
            Dim Profesor As String = Profesores(cbox_Profesor.SelectedIndex, 1)
            Dim Curso As String = cbox_Curso.Text
            Try
                con.regTeoria(Codigo, Curso, Horario, Duracion, Profesor)
                STATUS.Text = "Clase Teorica" & Codigo & " fue agregada exitosamente."
            Catch ex As Exception
                STATUS.Text = "Clase Teorica" & Codigo & " no fue agregada exitosamente."
            End Try
        End If
    End Sub

    Private Sub tbox_Codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbox_Codigo.KeyPress
        Herramientas.soloNumeros(e)
    End Sub

End Class