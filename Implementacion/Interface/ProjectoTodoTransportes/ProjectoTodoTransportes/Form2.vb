Public Class Form2

    Dim con As Conexion = New Conexion
    
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CARGAR COMBOBOX cursos'
        Dim n As Integer
        n = con.registrosEnCURSO - 1
        Dim cursos(n) As String
        cursos = con.cursosToArray(n)
        For i As Integer = 0 To n
            cbox_curso.Items.Add(cursos(i))
        Next
        cbox_curso.SelectedIndex = 0

        'CARGAR COMBOBOX teoria'
        Dim m As Integer
        m = con.registrosTeorico - 1
        Dim teo(m) As String
        teo = con.teoricoToArray(m)
        For i As Integer = 0 To m
            cbox_teorico.Items.Add(teo(i))
        Next
        'cbox_teorico.SelectedIndex = 0' 'Se descomentará cuando se haya llenado'

        'CARGAR COMBOBOX practica'
        Dim k As Integer
        k = con.registrosPractico - 1
        Dim pract(k) As String
        pract = con.practicoToArray(k)
        For i As Integer = 0 To k
            cbox_practico.Items.Add(pract(i))
        Next
        'cbox_practico.SelectedIndex = 0' 'Se descomentará cuando se haya llenado'

        'CARGAR COMBOBOX medio pago'
        Dim f As Integer '
        f = con.registrosMedio - 1 '
        Dim medio(k) As String '
        medio = con.MedioToArray(f) '
        For i As Integer = 0 To f
            cbox_medio.Items.Add(medio(i))
        Next
        cbox_medio.SelectedIndex = 0

        Me.verificar(cbox_curso.SelectedIndex)

    End Sub

    Private Sub btn_estudiante_Click(sender As System.Object, e As System.EventArgs) Handles btn_estudiante.Click

        Dim rut As String = ""
        Dim real As Boolean = Herramientas.isRut(tbox_rut1.Text, tbox_rut2.Text)
        If real Then
            rut = tbox_rut1.Text + tbox_rut2.Text
        Else
            lbl_mensaje_conf.Text = "RUT no concuerda"
        End If

        'Covertir checkbox en booleano e integer para colocarlas en la busqueda'
        'foto'
        Dim carnet As Integer
        carnet = chbox_foto.Checked
        'certificado de estudios'
        Dim cert As Boolean
        cert = chbox_estudios.Checked
        'certificado de alumno regular'
        Dim certAl As Boolean
        certAl = chbox_regular.Checked
        'autorizacion notarial'
        Dim notario As Boolean
        notario = chbox_regular.Checked

        Dim t As Date
        t = TimeValue("4:00:00 PM") 'Reemplaza a lo teorico'
        Dim p As Date
        p = TimeValue("5:00:00 PM") 'reemmplaza a lo practico'

        If tbox_telefono.Text.Trim.Equals("") Then
            tbox_telefono.Text = "0"
        ElseIf tbox_nombre.Text.Trim.Equals("") Then
            lbl_nombre.ForeColor = Color.Red
        ElseIf tbox_apellido.Text.Trim.Equals("") Then
            lbl_apellido.ForeColor = Color.Red
        ElseIf tbox_edad.Text.Trim.Equals("") Then
            lbl_edad.ForeColor = Color.Red
        ElseIf tbox_rut1.Text.Trim.Equals("") Or tbox_rut2.Text.Trim.Equals("") Then
            lbl_rut.ForeColor = Color.Red
        Else
            lbl_nombre.ForeColor = Color.DimGray
            lbl_apellido.ForeColor = Color.DimGray
            lbl_rut.ForeColor = Color.DimGray
            lbl_edad.ForeColor = Color.DimGray
            Try
                con.RegistrarPago(CInt(tbox_codigo_pago.Text), CInt("25000"), cbox_medio.Text)
                con.RegistrarMatricula(tbox_nmatricula.Text, tbox_nombre.Text, rut, CInt(tbox_edad.Text),
                                Format(datetp_atencion.Value, "yyyy-MM-dd"), CInt(tbox_telefono.Text),
                                CInt(tbox_codigo_pago.Text), cbox_curso.Text, t, p)

                con.RegistrarEstudiante(tbox_nmatricula.Text, carnet, cert, certAl, notario)
            Catch ex As Exception

                lbl_mensaje_conf.ForeColor = Color.Red
                lbl_mensaje_conf.Text = "ERROR!"

            Finally

                lbl_mensaje_conf.ForeColor = Color.Blue
                lbl_mensaje_conf.Text = "Operación realizada con éxito"

                'Resetea valores
                tbox_nombre.Text = ""
                tbox_apellido.Text = ""
                tbox_rut1.Text = ""
                tbox_rut2.Text = ""
                tbox_edad.Text = ""
                tbox_telefono.Text = ""
                cbox_curso.SelectedIndex = 0
                'cbox_teorico.SelectedIndex = 0
                'cbox_practico.SelectedIndex = 0
                cbox_medio.SelectedIndex = 0
                chbox_foto.Checked = False
                chbox_estudios.Checked = False
                chbox_regular.Checked = False
                chbox_notarial.Checked = False
                tbox_nmatricula.Text = ""
                lbl_valor_curso.Text = ""
                tbox_codigo_pago.Text = ""
            End Try
        End If
    End Sub

    Private Sub verificar(p1 As Integer)
        If p1 <> 0 Then
            'Cargar en label valor curso'
            Dim precio As Integer
            precio = con.buscarPago(tbox_edad.Text, cbox_curso.Text)
            lbl_valor_curso.Text = CStr(precio)
        Else
            lbl_mensaje_conf.ForeColor = Color.Red
            lbl_mensaje_conf.Text = "ERROR!"
        End If
    End Sub

End Class