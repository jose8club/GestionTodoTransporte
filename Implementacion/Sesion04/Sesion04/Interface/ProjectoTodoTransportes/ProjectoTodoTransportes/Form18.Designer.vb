<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form18
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.general = New System.Windows.Forms.TabPage()
        Me.profesores = New System.Windows.Forms.TabPage()
        Me.asistencia = New System.Windows.Forms.TabPage()
        Me.calificaciones = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.general)
        Me.TabControl1.Controls.Add(Me.profesores)
        Me.TabControl1.Controls.Add(Me.asistencia)
        Me.TabControl1.Controls.Add(Me.calificaciones)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(21, 22)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(560, 412)
        Me.TabControl1.TabIndex = 0
        '
        'general
        '
        Me.general.Location = New System.Drawing.Point(4, 22)
        Me.general.Name = "general"
        Me.general.Padding = New System.Windows.Forms.Padding(3)
        Me.general.Size = New System.Drawing.Size(552, 386)
        Me.general.TabIndex = 0
        Me.general.Text = "General"
        Me.general.UseVisualStyleBackColor = True
        '
        'profesores
        '
        Me.profesores.Location = New System.Drawing.Point(4, 22)
        Me.profesores.Name = "profesores"
        Me.profesores.Padding = New System.Windows.Forms.Padding(3)
        Me.profesores.Size = New System.Drawing.Size(552, 383)
        Me.profesores.TabIndex = 1
        Me.profesores.Text = "Profesores"
        Me.profesores.UseVisualStyleBackColor = True
        '
        'asistencia
        '
        Me.asistencia.Location = New System.Drawing.Point(4, 22)
        Me.asistencia.Name = "asistencia"
        Me.asistencia.Size = New System.Drawing.Size(552, 383)
        Me.asistencia.TabIndex = 2
        Me.asistencia.Text = "Asistencia"
        Me.asistencia.UseVisualStyleBackColor = True
        '
        'calificaciones
        '
        Me.calificaciones.Location = New System.Drawing.Point(4, 22)
        Me.calificaciones.Name = "calificaciones"
        Me.calificaciones.Size = New System.Drawing.Size(552, 383)
        Me.calificaciones.TabIndex = 3
        Me.calificaciones.Text = "Calificaciones"
        Me.calificaciones.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(552, 383)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "..."
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Form18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form18"
        Me.Text = "Resumenes"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents general As System.Windows.Forms.TabPage
    Friend WithEvents profesores As System.Windows.Forms.TabPage
    Friend WithEvents asistencia As System.Windows.Forms.TabPage
    Friend WithEvents calificaciones As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
End Class
