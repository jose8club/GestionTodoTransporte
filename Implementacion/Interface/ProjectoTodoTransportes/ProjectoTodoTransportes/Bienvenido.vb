Public Class Bienvenido

    Dim con As Conexion = New Conexion

    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click

        If tbox_Usuario.Text.Trim.Equals("") Or tbox_Contra.Text.Trim.Equals("") Then
            tbox_Mensaje.Text = "Debe ingresar sus datos de inicio de sesión para continuar."
        Else
            Dim login As Boolean = con.iniciarSesion(tbox_Usuario.Text, tbox_Contra.Text)
            If login Then
                Dim principal As Principal = New Principal(tbox_Usuario.Text, con)
                principal.Show()
                Me.Close()

            Else
                tbox_Mensaje.Text = "El Usuario y Contraseña ingresados no existen."
            End If
        End If

    End Sub

    Private Sub Bienvenido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'MOMENTANEO POR DESARROLLO
        tbox_Usuario.Text = "luzhow"
        tbox_Contra.Text = "1234asd"

    End Sub
End Class