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
        loadTAB(MainMenu.TabPages(MainMenu.SelectedIndex).Text, MainMenu.SelectedIndex)
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

    Private Sub MainMenu_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainMenu.SelectedIndexChanged
        Dim tab As Integer = MainMenu.SelectedIndex
        Dim Nombre As String = MainMenu.TabPages(tab).Text
        loadTAB(Nombre, tab)
    End Sub

    Sub loadTAB(ByVal Nombre As String, ByVal tab As Integer)
        'Se crea este método para poder editar el orden de las pestañas y no alterar el contenido
        Dim Form As Form
        Me.MainMenu.TabPages(tab).Controls.Clear()
        If Nombre.Equals("Atención al Cliente") Then
            Form = New RegistrarCliente(USER, con, ESTADO)
            Form.TopLevel = False
            Me.MainMenu.TabPages(tab).Controls.Add(Form)
            Form.Show()
        ElseIf Nombre.Equals("Matrícula") Then
            Form = New RegistrarMatricula(USER, con, ESTADO)
            Form.TopLevel = False
            Me.MainMenu.TabPages(tab).Controls.Add(Form)
            Form.Show()
        ElseIf Nombre.Equals("Profesores") Then
            Form = New DocenteTabs(USER, con, ESTADO)
            Form.TopLevel = False
            Me.MainMenu.TabPages(tab).Controls.Add(Form)
            Form.Show()
        ElseIf Nombre.Equals("Encuesta de Calidad") Then
            Form = New Encuesta(USER, con, ESTADO)
            Form.TopLevel = False
            Me.MainMenu.TabPages(tab).Controls.Add(Form)
            Form.Show()
        ElseIf Nombre.Equals("Vehículos") Then
            Form = New newFlota(USER, con, ESTADO)
            Form.TopLevel = False
            Me.MainMenu.TabPages(tab).Controls.Add(Form)
            Form.Show()
        ElseIf Nombre.Equals("Configuración") Then
            Form = New tab_Config(USER, con, ESTADO)
            Form.TopLevel = False
            Me.MainMenu.TabPages(tab).Controls.Add(Form)
            Form.Show()
        ElseIf Nombre.Equals("Examenes") Then
            Form = New newExamen(USER, con, ESTADO)
            Form.TopLevel = False
            Me.MainMenu.TabPages(tab).Controls.Add(Form)
            Form.Show()
        ElseIf Nombre.Equals("Cursos") Then
            Form = New Curso(USER, con, ESTADO)
            Form.TopLevel = False
            Me.MainMenu.TabPages(tab).Controls.Add(Form)
            Form.Show()
        ElseIf Nombre.Equals("Resumen") Then
            Form = New ResumenTabs(USER, con, ESTADO)
            Form.TopLevel = False
            Me.MainMenu.TabPages(tab).Controls.Add(Form)
            Form.Show()
        End If

    End Sub

End Class
