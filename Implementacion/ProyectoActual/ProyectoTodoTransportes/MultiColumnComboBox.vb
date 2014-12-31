Imports System.Drawing.Drawing2D
Imports System.Windows
Public Class MultiColumnComboBox
    'source:https://social.msdn.microsoft.com/Forums/windows/en-US/20840c53-f222-444e-9866-30517bb7f79e/multiple-columns-combo-box-vbnet?forum=winformsdatacontrols
    Inherits System.Windows.Forms.ComboBox
    Private _ColumnWidths As String = "100"
    Private _ColumnWidthsArray As String()
    Private _DoNotReact As Boolean = False
    Private _Textchanged As Boolean = False
    Sub New()
        MyBase.New()
        MyBase.DrawMode = DrawMode.OwnerDrawFixed
        'SetStyle(ControlStyles.UserPaint, True)
        'SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        'SetStyle(ControlStyles.DoubleBuffer, True)
    End Sub


    Public Property ColumnWidths() As String
        Get
            Return _ColumnWidths
        End Get
        Set(ByVal Value As String)
            _ColumnWidths = Value
            _ColumnWidthsArray = Value.Split(CType(";", Char))
            Dim w As Integer = 0
            For Each str As String In _ColumnWidthsArray
                w += CInt(str)
            Next str
            MyBase.DropDownWidth = w + 10
        End Set
    End Property

    Protected Overrides Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs)
        ' Set the DrawMode property to draw fixed sized items.

        '
        'If _Textchanged Then
        '    _Textchanged = False
        '    Exit Sub
        'End If

        Dim myBrush As Brush
        'If e.Bounds.Y = 0 Then
        '    ItemHeight = 32
        'Else
        '    ItemHeight = 16
        'End If
        '  e.DrawBackground()
        Dim LightColor As Color = Color.Blue
        Dim DarkColor As Color = Color.Black
        Dim GradBrush As Brush = New LinearGradientBrush(e.Bounds, LightColor, DarkColor, LinearGradientMode.Vertical)



        Select Case CInt((e.State And DrawItemState.Selected))
            'Case DrawItemState.Selected + DrawItemState.NoAccelerator + DrawItemState.NoFocusRect, DrawItemState.Selected
            Case DrawItemState.Selected
                myBrush = New SolidBrush(BackColor)
                e.Graphics.FillRectangle(GradBrush, e.Bounds)
            Case Else
                myBrush = New SolidBrush(ForeColor)
                'myBrush = GradBrush
                e.Graphics.FillRectangle(New SolidBrush(BackColor), e.Bounds)
        End Select



        Dim str As String
        ' Draw the current item text based on the current Font and the custom brush settings.
        Dim row As DataRowView = (CType(MyBase.Items(e.Index), DataRowView))
        Dim newpos As Integer = e.Bounds.X
        Dim endpos As Integer = e.Bounds.X

        For indx As Integer = 0 To UBound(_ColumnWidthsArray)
            Dim ColLength As Integer = CType(_ColumnWidthsArray(indx), Integer)
            endpos += ColLength

            Dim Charaant As Integer = CInt(Math.Round(CDbl(ColLength) / 6.2))
            Dim rawitem As String = row.Item(indx).ToString()

            If ColLength <> 0 Then


                If Charaant > rawitem.Length Then
                    str = rawitem

                Else

                    str = rawitem.Substring(0, Charaant)
                End If

                Dim r As RectangleF = New RectangleF(newpos + 2, e.Bounds.Y, endpos - 1, e.Bounds.Height)

                'e.Graphics.FillRectangle(myBrush, r)

                e.Graphics.DrawString(str, e.Font, myBrush, r)

                'ControlPaint.DrawBorder3D(e.Graphics, New Rectangle(endpos + 2, e.Bounds.Y, newpos, e.Bounds.Height))
                'e.Graphics.DrawString("mycol", e.Font, myBrush, New RectangleF(newpos, 0, CInt(_ColumnWidthsArray(indx)), ItemHeight))
                If indx <= UBound(_ColumnWidthsArray) Then
                    e.Graphics.DrawLine(New Pen(Color.Black), endpos, e.Bounds.Y, endpos, Me.ItemHeight * Me.MaxDropDownItems)
                    e.Graphics.DrawLine(New Pen(Color.LightGray), endpos + 1, e.Bounds.Y, endpos + 1, Me.ItemHeight * Me.MaxDropDownItems)
                End If
            End If

            newpos = endpos
        Next
        '        e.DrawFocusRectangle()
        myBrush.Dispose()
        GradBrush.Dispose()


    End Sub

    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)

        Dim foundIndex As Integer, textlngth As Integer
        If _DoNotReact = False Then
            If Me.AccessibilityObject.Value Is Nothing Then
                textlngth = 0
                Exit Sub
            Else
                textlngth = Me.AccessibilityObject.Value.Length
            End If

            If textlngth = 0 Then
                MyBase.OnTextChanged(e)
                _DoNotReact = False
                _Textchanged = False
                Exit Sub
            End If

            If textlngth <> 0 Then

                _DoNotReact = True
                foundIndex = FindString(Me.AccessibilityObject.Value)
                If foundIndex > -1 Then
                    Me.SelectedIndex = foundIndex
                    Me.Select(textlngth, Me.Text.Length - textlngth)
                    'Me.SelectionStart = textlngth
                    _Textchanged = True
                Else
                    _Textchanged = False
                End If
                _DoNotReact = False
            End If
            MyBase.OnTextChanged(e)
        End If
        _DoNotReact = False



    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Back, Keys.Enter, Keys.Delete
                _DoNotReact = True
            Case Keys.Down
                Me.DroppedDown = True
                Invalidate()

        End Select

        MyBase.OnKeyDown(e)

    End Sub


End Class
