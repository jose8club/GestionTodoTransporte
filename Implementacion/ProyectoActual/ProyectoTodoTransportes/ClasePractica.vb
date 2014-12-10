Public Class ClasePractica
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
    Private Sub ClasePractica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Curso")
        loadCBOX("Instructor")
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)
        Dim n As Integer
        Dim items() As String
        If Nombre.Equals("Curso") Then
            cbox_cursoPract.Items.Clear()

            n = con.count("Curso") - 1
            items = con.toArray(n, "Codigo", "Curso")
            For i As Integer = 0 To n
                cbox_cursoPract.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_cursoPract.SelectedIndex = 0
        ElseIf Nombre.Equals("Instructor") Then

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

        If tbox_idPractica.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese los datos."
            Return False
        End If
        Return True
    End Function
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

    
    Private Sub btn_guardarPract_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardarPract.Click
        If validar() Then
            Dim Codigo As String = tbox_idPractica.Text
            Dim Horario As String = TextBox1.Text & ":" & TextBox2.Text & ":00"
            Dim Instructor As String = Instructores(cbox_instructor.SelectedIndex, 1)
            Dim Curso As String = cbox_cursoPract.Text
            Try
                con.regPractica(Codigo, Curso, Instructor, Horario)
                STATUS.Text = "Clase Practica" & Codigo & " fue agregada exitosamente."
            Catch ex As Exception
                STATUS.Text = "Clase Practica" & Codigo & " no fue agregada exitosamente."
            End Try
        End If
    End Sub
End Class