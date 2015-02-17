Option Strict On
Option Explicit On

Public Class Expresion
    Public estado(2) As String
    Public hacer As String

    Public Function val(ByVal a As String, ByVal vali As String) As Boolean
        If valcero(vali) = True Then
            Select Case a
                Case "expletrauno"
                    Dim s As String = "^[^(ijñoqIJÑOQ0123456789)]{0,1}[^(ijñoqmwIJÑOQMW0123456789)]{0,1}$"
                    Dim expreg As New System.Text.RegularExpressions.Regex(s)
                    Return (expreg.IsMatch(vali))
                Case "expletrados"
                    Dim s As String = "^[^(aeioumnñqAEIOUMNÑQ0123456789)]{0,2}$"
                    Dim expreg As New System.Text.RegularExpressions.Regex(s)
                    Return (expreg.IsMatch(vali))
                Case "expnumuno"
                    Dim s As String = "^[0-9]{0,2}$"
                    Dim expreg As New System.Text.RegularExpressions.Regex(s)
                    Return (expreg.IsMatch(vali))
                Case "expnumdos"
                    Dim s As String = "^[1-9]{0,1}[0-9]{0,1}$"
                    Dim expreg As New System.Text.RegularExpressions.Regex(s)
                    Return (expreg.IsMatch(vali))
            End Select
        End If
        Return valcero(vali)
    End Function

    Public Function valcero(ByVal c As String) As Boolean
        If c = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub Validando(ByVal Metodo As String, ByVal componente As Control)
        If val(Metodo, componente.Text) = False Then
            componente.ForeColor = Color.Red
            componente.Focus()

            Throw New Exception("Error")
        Else
            componente.ForeColor = Color.Black
        End If

    End Sub
End Class

