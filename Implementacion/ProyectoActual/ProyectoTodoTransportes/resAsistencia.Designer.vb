<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resAsistencia
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
        Me.cbox_estudiante = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.list_asistencia = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cbox_estudiante
        '
        Me.cbox_estudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_estudiante.FormattingEnabled = True
        Me.cbox_estudiante.Location = New System.Drawing.Point(141, 51)
        Me.cbox_estudiante.Name = "cbox_estudiante"
        Me.cbox_estudiante.Size = New System.Drawing.Size(330, 21)
        Me.cbox_estudiante.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Estudiante:"
        '
        'list_asistencia
        '
        Me.list_asistencia.FormattingEnabled = True
        Me.list_asistencia.Location = New System.Drawing.Point(27, 100)
        Me.list_asistencia.Name = "list_asistencia"
        Me.list_asistencia.Size = New System.Drawing.Size(444, 173)
        Me.list_asistencia.TabIndex = 4
        '
        'resAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 419)
        Me.Controls.Add(Me.list_asistencia)
        Me.Controls.Add(Me.cbox_estudiante)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "resAsistencia"
        Me.Text = "resAsistencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbox_estudiante As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents list_asistencia As System.Windows.Forms.ListBox
End Class
