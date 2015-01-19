Imports System.Windows.Forms

Public Class Customtbox
    Inherits MaskedTextBox

    Enum Tipologia As Integer
        EXPNUMERO1 = 0
        EXPNUMERO2 = 1
        EXPLETRA1 = 2
        EXPLETRA2 = 3
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
                If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Space)) And e.KeyChar = ChrW(Keys.NumPad0) Then
                    e.Handled = True
                End If
                'despues 2007
            Case Tipologia.EXPNUMERO2
                If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Space)) Then
                    e.Handled = True
                End If

                'antes 2007
            Case Tipologia.EXPLETRA1
                If Not Char.IsLetter(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Space)) And e.KeyChar = ChrW(Keys.Q) And e.KeyChar = ChrW(Keys.I) Then
                    e.Handled = True
                End If

                'despues 2007
            Case Tipologia.EXPLETRA2
                If Not Char.IsLetter(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Space)) And
                    e.KeyChar = ChrW(Keys.A) And e.KeyChar = ChrW(Keys.Q) And e.KeyChar = ChrW(Keys.I) Then
                    e.Handled = True

                End If
        End Select
        MyBase.OnKeyPress(e)
    End Sub


End Class
