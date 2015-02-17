Imports System.Windows.Forms

Public Class Custom2
    Inherits TextBox

    Public Sub New()
        Me.MaxLength = 2
    End Sub

    Enum Tipologia As Integer
        NUMERO = 0
        LETRA = 1
        TEXTO = 2
    End Enum

    Public _T As Tipologia

    Public Property Tipo() As Tipologia
        'devuelve el valor de del tipo de texto según su categoría 
        Get
            Return _T
        End Get
        Set(ByVal value As Tipologia)
            _T = value
        End Set
    End Property

    Protected Overrides Sub OnKeyPress(e As System.Windows.Forms.KeyPressEventArgs)
        Select Case _T

            Case Tipologia.NUMERO
                If Char.IsDigit(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If


            Case Tipologia.LETRA
                If Not Char.IsDigit(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If

        End Select
        MyBase.OnKeyPress(e)
    End Sub
End Class
