Public Class Bienvenido

    Dim con As Conexion = New Conexion
    Dim resultado As String = ""

    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        If validar() Then
            Dim login As Boolean = con.iniciarSesion(tbox_Usuario.Text, tbox_Contra.Text)
            Dim d As DataTable = con.doQuery("SELECT Tipo FROM Usuario WHERE Nombre='" & tbox_Usuario.Text & "'")
            If d.Rows.Count > 0 Then
                resultado = d.Rows(0).Item(0).ToString
            Else
                resultado = ""
            End If
            If login And resultado = "Desarrollador" Then
                Dim prueba As Prueba = New Prueba(tbox_Usuario.Text, con)
                prueba.Show()
                prueba.SendToBack()
                Dim principal As Principal = New Principal(tbox_Usuario.Text, con)
                principal.Show()
                Me.Close()
            ElseIf login And resultado = "Administrador" Then
                Dim principal As Principal = New Principal(tbox_Usuario.Text, con)
                principal.Show()
                Me.Close()
            End If
            'If login Then
            '    Dim prueba As Prueba = New Prueba(tbox_Usuario.Text, con)
            '    prueba.Show()
            '    prueba.SendToBack()
            '    Dim principal As Principal = New Principal(tbox_Usuario.Text, con)
            '    principal.Show()
            '    Me.Close()
            'Else
            '    Estado.Text = "El Usuario y Contraseña ingresados no son validos."
            'End If
        End If
    End Sub

    Private Sub Bienvenido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MOMENTANEO POR DESARROLLO
        tbox_Usuario.Text = "Desarrollador"
        tbox_Contra.Text = "desarrollador"
    End Sub

    Function validar() As Boolean
        If tbox_Usuario.Text.Trim.Equals("") And tbox_Contra.Text.Trim.Equals("") Then
            Estado.Text = "Debe ingresar sus datos de inicio de sesión para continuar."
            tbox_Usuario.Focus()
            Return False
        ElseIf tbox_Usuario.Text.Trim.Equals("") Then
            Estado.Text = "Debe ingresar sus datos de usuario de sesión para continuar."
            tbox_Usuario.Focus()
            Return False
        ElseIf tbox_Contra.Text.Trim.Equals("") Then
            Estado.Text = "Debe ingresar sus datos de usuario de sesión para continuar."
            tbox_Contra.Focus()
            Return False
        End If
        Return True
    End Function
End Class