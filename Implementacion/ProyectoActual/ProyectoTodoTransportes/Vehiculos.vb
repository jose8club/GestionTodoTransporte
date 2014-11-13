Public Class Vehiculos
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub Vehiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim n As Integer
        Dim items() As String
        n = con.count("Estado_Auto") - 1
        items = con.toArray(n, "Estado", "Estado_Auto")
        For i As Integer = 0 To n
            cbox_Estado.Items.Add(items(i))
        Next
        If n >= 0 Then cbox_Estado.SelectedIndex = 0
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        If tbox_Patente.Text.Equals("") Then
            STATUS.Text = "ERROR: Debe ingresar los datos asociados al vehículo"
        Else
            Try
                con.regVehiculo(tbox_Patente.Text, tbox_modelo.Text, cbox_Estado.Text)
                STATUS.Text = "Vehículo " & tbox_Patente.Text & " fue agregado correctamente."
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

End Class