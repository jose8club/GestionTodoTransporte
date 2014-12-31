Public Class CustomTextBoxClass
    Inherits TextBox

    Enum TipoClase As Integer
        NUMERIC = 0 'Solo Números
        ALPHA_NUMERIC = 1 'Solo Números y letras
        ALPHA = 2 'Solo letras
        SYMBOLS = 3 'Solo símbolos
        TEXT = 4 'Cualquier texto
    End Enum

    Private _Tipo As TipoClase


    Public Property Tipo() As TipoClase
        'devuelve el valor de del tipo de texto según su categoría 
        Get
            Return _Tipo
        End Get
        Set(ByVal value As TipoClase)
            _Tipo = value
        End Set
    End Property

    Protected Overrides Sub OnKeyPress(e As System.Windows.Forms.KeyPressEventArgs)
        Select Case _Tipo
            Case TipoClase.NUMERIC
                If Not Char.IsNumber(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Space)) Then
                    e.Handled = True
                End If

            Case TipoClase.ALPHA
                If Not Char.IsLetter(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Space)) Then
                    e.Handled = True
                End If

            Case TipoClase.ALPHA_NUMERIC
                If Not Char.IsLetterOrDigit(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Space)) Then
                    e.Handled = True
                End If

            Case TipoClase.SYMBOLS
                If Char.IsLetterOrDigit(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Space)) Then
                    e.Handled = True
                End If
        End Select
        MyBase.OnKeyPress(e)
    End Sub


End Class
