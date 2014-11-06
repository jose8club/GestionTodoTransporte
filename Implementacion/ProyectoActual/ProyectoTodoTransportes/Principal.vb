Public Class Principal

    Dim con As Conexion
    Dim USER As String = ""

    Sub New(ByVal Usuario As String, ByVal conexion As Conexion)

        'Guarda el nombre del usuario y la conexión
        USER = Usuario
        con = conexion
        InitializeComponent()
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim regCliente As New RegistrarCliente(USER, con)
        regCliente.TopLevel = False
        Me.MainMenu.TabPages(0).Controls.Add(regCliente)
        regCliente.Show()

        Dim regMatricula As New RegistrarMatricula(USER, con)
        regMatricula.TopLevel = False
        Me.MainMenu.TabPages(1).Controls.Add(regMatricula)
        regMatricula.Show()

     

    End Sub

    Private Sub MainMenu_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles MainMenu.DrawItem

        'Método extraido desde 'http://msdn.microsoft.com/en-us/library/ms404305(v=vs.90).aspx'

        Dim g As Graphics = e.Graphics
        Dim _TextBrush As Brush
        Dim _TabPage As TabPage = MainMenu.TabPages(e.Index)
        Dim _TabBounds As Rectangle = MainMenu.GetTabRect(e.Index)

        If (e.State = DrawItemState.Selected) Then
            _TextBrush = New SolidBrush(System.Drawing.SystemColors.ControlText)
            g.FillRectangle(System.Drawing.SystemBrushes.ControlLight, e.Bounds)
        Else
            _TextBrush = New System.Drawing.SolidBrush(System.Drawing.SystemColors.ControlText)
        End If

        Dim _TabFont As New Font("Microsoft Sans Serif", 12.0, FontStyle.Regular, GraphicsUnit.Pixel)

        Dim _StringFlags As New StringFormat()
        _StringFlags.Alignment = StringAlignment.Center
        _StringFlags.LineAlignment = StringAlignment.Center
        g.DrawString(_TabPage.Text, _TabFont, _TextBrush, _TabBounds, New StringFormat(_StringFlags))
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        con.Close()

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As System.EventArgs) Handles TabPage4.Click

    End Sub


    Private Sub MainMenu_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles MainMenu.SelectedIndexChanged
        Dim tab As Integer = MainMenu.SelectedIndex
        If tab = 3 Then
            Dim encuesta As New Encuesta(USER, con)
            encuesta.TopLevel = False
            Me.MainMenu.TabPages(3).Controls.Add(encuesta)
            encuesta.Show()
        End If
    End Sub


End Class
