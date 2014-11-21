Module Herramientas
    Public ReadOnly NoEspeciales As String = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789"

    Function isRut(ByVal rut As String, ByVal digito As String)

        'Verifica el Rut

        Dim largo As Integer = Len(rut)
        Dim suma As Integer = 0
        Dim actual As Integer
        Dim resto As Integer

        For i As Integer = 1 To largo
            actual = CInt(Left(Right(rut, i), 1))

            If i <= 6 Then
                actual = actual * (i + 1)
                suma = suma + actual
            Else
                actual = actual * (i - 5)
                suma = suma + actual
            End If
        Next

        resto = 11 - (suma Mod 11)

        If resto = 10 Then
            If digito.Equals("K") Or digito.Equals("k") Then Return True
        ElseIf resto = 11 Then
            If digito.Equals("0") Then Return True
        ElseIf digito.Equals(resto.ToString) Then
            Return True
        End If
        Return False

    End Function

    Sub soloNumeros(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        'Valida la entrada de solo números

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Sub soloTexto(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        'Valida la entrada de solo texto

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Sub textoDeseado(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal cadena As String)

        'Valida la entrada de caracteres deseados

        If InStr(cadena, e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Function edadPorNacimiento(ByVal fecha As String) As String

        'Devuelve la edad a partir de la fecha de nacimiento
        'Formato fecha = yyyy-MM-dd

        Dim edad As Integer = 0
        Dim dia_n As Integer = Right(fecha, 2)
        Dim mes_n As Integer = Left(Right(fecha, 5), 2)
        Dim ano_n As Integer = Left(fecha, 4)

        Dim fechaActual As String = Format(Date.Now, "yyyy-MM-dd")

        Dim dia_a As Integer = Right(fechaActual, 2)
        Dim mes_a As Integer = Left(Right(fechaActual, 5), 2)
        Dim ano_a As Integer = Left(fechaActual, 4)

        edad = ano_a - ano_n
        If mes_a < mes_n Then edad = edad - 1
        If mes_a = mes_n Then
            If dia_a < dia_n Then edad = edad - 1
        End If

        Return edad

    End Function

    Function filtroContiene(ByVal items() As String, ByVal compara As String) As String()
        Return items.Where(Function(s) s Like "*" & compara & "*").ToArray
    End Function

    Function HoraMaxima(ByVal H As Integer) As Integer
        If H > 23 Then
            Return 23
        End If
        Return H
    End Function

    Function MinutoMaximo(ByVal M As Integer) As Integer
        If M > 59 Then
            Return 59
        End If
        Return M
    End Function

End Module

