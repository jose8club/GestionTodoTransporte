<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nombreal = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.resumen = New System.Windows.Forms.TabPage()
        Me.examenes = New System.Windows.Forms.TabPage()
        Me.ingaut = New System.Windows.Forms.Button()
        Me.ingexamen = New System.Windows.Forms.Button()
        Me.examengroup = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.situacion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.asistencia = New System.Windows.Forms.TabPage()
        Me.calificaciones = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.examenes.SuspendLayout()
        Me.examengroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de alumno"
        '
        'nombreal
        '
        Me.nombreal.FormattingEnabled = True
        Me.nombreal.Location = New System.Drawing.Point(147, 25)
        Me.nombreal.Name = "nombreal"
        Me.nombreal.Size = New System.Drawing.Size(431, 21)
        Me.nombreal.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.resumen)
        Me.TabControl1.Controls.Add(Me.examenes)
        Me.TabControl1.Controls.Add(Me.asistencia)
        Me.TabControl1.Controls.Add(Me.calificaciones)
        Me.TabControl1.Location = New System.Drawing.Point(12, 81)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(570, 293)
        Me.TabControl1.TabIndex = 2
        '
        'resumen
        '
        Me.resumen.Location = New System.Drawing.Point(4, 22)
        Me.resumen.Name = "resumen"
        Me.resumen.Padding = New System.Windows.Forms.Padding(3)
        Me.resumen.Size = New System.Drawing.Size(562, 267)
        Me.resumen.TabIndex = 0
        Me.resumen.Text = "Resumen"
        Me.resumen.UseVisualStyleBackColor = True
        '
        'examenes
        '
        Me.examenes.Controls.Add(Me.ingaut)
        Me.examenes.Controls.Add(Me.ingexamen)
        Me.examenes.Controls.Add(Me.examengroup)
        Me.examenes.Location = New System.Drawing.Point(4, 22)
        Me.examenes.Name = "examenes"
        Me.examenes.Padding = New System.Windows.Forms.Padding(3)
        Me.examenes.Size = New System.Drawing.Size(562, 267)
        Me.examenes.TabIndex = 1
        Me.examenes.Text = "Examenes"
        Me.examenes.UseVisualStyleBackColor = True
        '
        'ingaut
        '
        Me.ingaut.Location = New System.Drawing.Point(344, 100)
        Me.ingaut.Name = "ingaut"
        Me.ingaut.Size = New System.Drawing.Size(193, 23)
        Me.ingaut.TabIndex = 2
        Me.ingaut.Text = "Ingresar Autorización"
        Me.ingaut.UseVisualStyleBackColor = True
        '
        'ingexamen
        '
        Me.ingexamen.Location = New System.Drawing.Point(344, 56)
        Me.ingexamen.Name = "ingexamen"
        Me.ingexamen.Size = New System.Drawing.Size(193, 23)
        Me.ingexamen.TabIndex = 1
        Me.ingexamen.Text = "Ingresar Examen"
        Me.ingexamen.UseVisualStyleBackColor = True
        '
        'examengroup
        '
        Me.examengroup.Controls.Add(Me.Label4)
        Me.examengroup.Controls.Add(Me.Label3)
        Me.examengroup.Controls.Add(Me.situacion)
        Me.examengroup.Controls.Add(Me.Label2)
        Me.examengroup.Location = New System.Drawing.Point(20, 26)
        Me.examengroup.Name = "examengroup"
        Me.examengroup.Size = New System.Drawing.Size(280, 175)
        Me.examengroup.TabIndex = 0
        Me.examengroup.TabStop = False
        Me.examengroup.Text = "Examen Oftalmologico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(105, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "21/Julio/2015"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha:"
        '
        'situacion
        '
        Me.situacion.AutoSize = True
        Me.situacion.Location = New System.Drawing.Point(102, 41)
        Me.situacion.Name = "situacion"
        Me.situacion.Size = New System.Drawing.Size(69, 13)
        Me.situacion.TabIndex = 1
        Me.situacion.Text = "PENDIENTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Situación:"
        '
        'asistencia
        '
        Me.asistencia.Location = New System.Drawing.Point(4, 22)
        Me.asistencia.Name = "asistencia"
        Me.asistencia.Size = New System.Drawing.Size(562, 267)
        Me.asistencia.TabIndex = 2
        Me.asistencia.Text = "Asistencia"
        Me.asistencia.UseVisualStyleBackColor = True
        '
        'calificaciones
        '
        Me.calificaciones.Location = New System.Drawing.Point(4, 22)
        Me.calificaciones.Name = "calificaciones"
        Me.calificaciones.Size = New System.Drawing.Size(562, 267)
        Me.calificaciones.TabIndex = 3
        Me.calificaciones.Text = "Calificaciones"
        Me.calificaciones.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 402)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.nombreal)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = "Ficha de Alumnos"
        Me.TabControl1.ResumeLayout(False)
        Me.examenes.ResumeLayout(False)
        Me.examengroup.ResumeLayout(False)
        Me.examengroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nombreal As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents resumen As System.Windows.Forms.TabPage
    Friend WithEvents examenes As System.Windows.Forms.TabPage
    Friend WithEvents examengroup As System.Windows.Forms.GroupBox
    Friend WithEvents asistencia As System.Windows.Forms.TabPage
    Friend WithEvents calificaciones As System.Windows.Forms.TabPage
    Friend WithEvents situacion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ingaut As System.Windows.Forms.Button
    Friend WithEvents ingexamen As System.Windows.Forms.Button
End Class
