<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resProfesores
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.list_asistencias = New System.Windows.Forms.ListBox()
        Me.list_aprobados = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Docentes"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(132, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(348, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'list_asistencias
        '
        Me.list_asistencias.FormattingEnabled = True
        Me.list_asistencias.Location = New System.Drawing.Point(36, 101)
        Me.list_asistencias.Name = "list_asistencias"
        Me.list_asistencias.Size = New System.Drawing.Size(308, 186)
        Me.list_asistencias.TabIndex = 2
        '
        'list_aprobados
        '
        Me.list_aprobados.FormattingEnabled = True
        Me.list_aprobados.Location = New System.Drawing.Point(379, 101)
        Me.list_aprobados.Name = "list_aprobados"
        Me.list_aprobados.Size = New System.Drawing.Size(300, 186)
        Me.list_aprobados.TabIndex = 3
        '
        'resProfesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 461)
        Me.Controls.Add(Me.list_aprobados)
        Me.Controls.Add(Me.list_asistencias)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "resProfesores"
        Me.Text = "resProfesores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents list_asistencias As System.Windows.Forms.ListBox
    Friend WithEvents list_aprobados As System.Windows.Forms.ListBox
End Class
