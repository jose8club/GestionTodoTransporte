Public Class Principal

    Dim con As Conexion
    Dim USER As String = ""

    Sub New(ByVal Usuario As String, ByVal conexion As Conexion)

        'Guarda el nombre del usuario y la conexión
        USER = Usuario
        con = conexion
        InitializeComponent()
    End Sub

    Private Sub Principal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        con.Close()
        Application.Exit()
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim regCliente As New RegistrarCliente(USER, con, ESTADO)
        regCliente.TopLevel = False
        Me.MainMenu.TabPages(0).Controls.Add(regCliente)
        regCliente.Show()
        ESTADO.Text = "Usuario: " & USER
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

    Private Sub MainMenu_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles MainMenu.SelectedIndexChanged
        Dim tab As Integer = MainMenu.SelectedIndex
        Dim form As Form = New Form
        Me.MainMenu.TabPages(tab).Controls.Clear()

        If tab = 0 Then
            form = New RegistrarCliente(USER, con, ESTADO)
            form.TopLevel = False
            Me.MainMenu.TabPages(0).Controls.Add(form)
            form.Show()
        ElseIf tab = 1 Then
            form = New RegistrarMatricula(USER, con, ESTADO)
            form.TopLevel = False
            Me.MainMenu.TabPages(1).Controls.Add(form)
            form.Show()
        ElseIf tab = 2 Then
            form = New tab_Docente(USER, con, ESTADO)
            form.TopLevel = False
            Me.MainMenu.TabPages(2).Controls.Add(form)
            form.Show()
        ElseIf tab = 3 Then
            form = New Encuesta(USER, con, ESTADO)
            form.TopLevel = False
            Me.MainMenu.TabPages(3).Controls.Add(form)
            form.Show()
        ElseIf tab = 4 Then
            form = New Vehiculos(USER, con, ESTADO)
            form.TopLevel = False
            Me.MainMenu.TabPages(4).Controls.Add(form)
            form.Show()
        ElseIf tab = 5 Then
            form = New Usuarios(USER, con, ESTADO)
            form.TopLevel = False
            Me.MainMenu.TabPages(5).Controls.Add(form)
            form.Show()
        ElseIf tab = 6 Then
            form = New Clase(USER, con, ESTADO)
            form.TopLevel = False
            Me.MainMenu.TabPages(6).Controls.Add(form)
            form.Show()
        ElseIf tab = 7 Then
            form = New Psicotecnico(USER, con, ESTADO)
            form.TopLevel = False
            Me.MainMenu.TabPages(7).Controls.Add(form)
            form.Show()
        ElseIf tab = 8 Then
            form = New Visual(USER, con, ESTADO)
            form.TopLevel = False
            Me.MainMenu.TabPages(8).Controls.Add(form)
            form.Show()
        ElseIf tab = 9 Then
            form = New Examen(USER, con, ESTADO)
            form.TopLevel = False
            Me.MainMenu.TabPages(9).Controls.Add(form)
            form.Show()
        End If

    End Sub

End Class
