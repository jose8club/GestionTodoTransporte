Public Class Principal

    Dim con As Conexion = New Conexion
    Dim USER As String = ""

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'CARGAR COMBOBOX
        Dim n As Integer
        n = con.registrosEnCURSO - 1
        Dim cursos(n) As String
        cursos = con.cursosToArray(n)
        For i As Integer = 0 To n
            cbox_CursoInteres1.Items.Add(cursos(i))
        Next
        cbox_CursoInteres1.SelectedIndex = 0

        'Carga el tamaño de la primera pestaña que se muestra
        TabControl.Size = New System.Drawing.Size(451, 294)
        Me.Size = New System.Drawing.Size(485, 351)

    End Sub

    Sub New(ByVal Usuario As String)
        USER = Usuario
        InitializeComponent()
    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged

        Dim tab As Integer = TabControl.SelectedIndex
        Me.CambiaTamaño(tab)    

    End Sub

    Sub CambiaTamaño(ByVal tab)

        'Al cambiar de pestaña ajusta el tamaño de la ventana

        If tab = 0 Then
            TabControl.Size = New System.Drawing.Size(451, 294)
            Me.Size = New System.Drawing.Size(485, 351)
        ElseIf tab = 1 Then
            TabControl.Size = New System.Drawing.Size(426, 417)
            Me.Size = New System.Drawing.Size(459, 472)
        ElseIf tab = 2 Then
            TabControl.Size = New System.Drawing.Size(416, 485)
            Me.Size = New System.Drawing.Size(449, 541)
        ElseIf tab = 3 Then
            TabControl.Size = New System.Drawing.Size(419, 220)
            Me.Size = New System.Drawing.Size(449, 275)
        End If

    End Sub

    Private Sub btn_Guardar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar1.Click

        'MANEJA EL BOTÓN GUARDAR

        If tbox_Telefono1.Text.Trim.Equals("") Then tbox_Telefono1.Text = "0"
        If tbox_Nombre1.Text.Trim.Equals("") Then
            lbl_Nombre1.ForeColor = Color.Red
        Else
            lbl_Nombre1.ForeColor = Color.DimGray
            Try

                con.registrarCliente(tbox_Nombre1.Text, CInt(tbox_Telefono1.Text), cbox_CursoInteres1.Text,
                                 Format(date_Fecha1.Value, "yyyy-MM-dd"), tbox_Observaciones1.Text, USER)

            Catch ex As Exception

                'MOMENTANEO
                lbl_Mensaje1.ForeColor = Color.Red
                lbl_Mensaje1.Text = "ERROR!"

            Finally

                lbl_Mensaje1.ForeColor = Color.Blue
                lbl_Mensaje1.Text = "Operación realizada con éxito"

                'Resetea valores
                tbox_Nombre1.Text = ""
                tbox_Observaciones1.Text = ""
                tbox_Telefono1.Text = ""
                cbox_CursoInteres1.SelectedIndex = 0

            End Try

        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'MOMENTANEO PROBANDO RUT
        Dim real As Boolean = Herramientas.isRut(TextBox4.Text, TextBox5.Text)
        If real Then MsgBox("REAL") Else MsgBox("FALSE")
    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click

    End Sub

    Private Sub horarioPsico_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles horarioPsico.TextChanged

    End Sub
End Class