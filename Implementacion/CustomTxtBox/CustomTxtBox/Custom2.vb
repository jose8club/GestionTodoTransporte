Imports System.Windows.Forms

Public Class Custom2
    Inherits System.Windows.Forms.MaskedTextBox

    Public Sub New()
        Me.Mask.Max()
    End Sub

    Enum Tipologia As Integer
        EXPNUMERO1 = 0
        EXPNUMERO2 = 1
        EXPLETRA1 = 2
        EXPLETRA2 = 3
        TEXTO = 4
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
            'antes 2007
            Case Tipologia.EXPNUMERO1
                If Char.IsDigit(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsControl(e.KeyChar) Then
                    e.Handled = True
                ElseIf e.KeyChar = ChrW(Keys.NumPad0) Then
                    e.Handled = True
                Else
                    e.Handled = True
                End If

                'despues 2007
            Case Tipologia.EXPNUMERO2
                If Char.IsDigit(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsControl(e.KeyChar) Then
                    e.Handled = True
                Else
                    e.Handled = True
                End If

                'antes 2007
            Case Tipologia.EXPLETRA1
                If Not Char.IsDigit(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsControl(e.KeyChar) Then
                    e.Handled = True
                ElseIf e.KeyChar = ChrW(Keys.I) Or e.KeyChar = ChrW(Keys.Q) Or e.KeyChar = ChrW(Keys.O) Then
                    e.Handled = True
                Else
                    e.Handled = True
                End If

                'despues 2007
            Case Tipologia.EXPLETRA2
                If Not Char.IsDigit(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsControl(e.KeyChar) Then
                    e.Handled = True
                ElseIf e.KeyChar = ChrW(Keys.A) Or e.KeyChar = ChrW(Keys.M) Or e.KeyChar = ChrW(Keys.N) Or e.KeyChar = ChrW(Keys.Q) Or e.KeyChar = ChrW(Keys.O) Then
                    e.Handled = True
                Else
                    e.Handled = True
                End If
        End Select
        MyBase.OnKeyPress(e)
    End Sub
End Class
