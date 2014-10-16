Module Herramientas

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
        Else
            Return False
        End If

    End Function

End Module
