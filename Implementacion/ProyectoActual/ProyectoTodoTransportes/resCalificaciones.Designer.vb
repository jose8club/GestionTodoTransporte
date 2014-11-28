<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resCalificaciones
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
        Me.list_calificaciones = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cbox_estudiante
        '
        Me.cbox_estudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_estudiante.FormattingEnabled = True
        Me.cbox_estudiante.Location = New System.Drawing.Point(136, 24)
        Me.cbox_estudiante.Name = "cbox_estudiante"
        Me.cbox_estudiante.Size = New System.Drawing.Size(330, 21)
        Me.cbox_estudiante.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Estudiante:"
        '
        'list_calificaciones
        '
        Me.list_calificaciones.FormattingEnabled = True
        Me.list_calificaciones.Location = New System.Drawing.Point(22, 73)
        Me.list_calificaciones.Name = "list_calificaciones"
        Me.list_calificaciones.Size = New System.Drawing.Size(444, 212)
        Me.list_calificaciones.TabIndex = 6
        '
        'resCalificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 387)
        Me.Controls.Add(Me.list_calificaciones)
        Me.Controls.Add(Me.cbox_estudiante)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "resCalificaciones"
        Me.Text = "resCalificaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbox_estudiante As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents list_calificaciones As System.Windows.Forms.ListBox
End Class
