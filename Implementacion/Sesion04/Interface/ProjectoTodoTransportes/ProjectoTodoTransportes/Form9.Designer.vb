<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.cursoEv = New System.Windows.Forms.ComboBox()
        Me.listEv = New System.Windows.Forms.ListBox()
        Me.tipoEv = New System.Windows.Forms.ListBox()
        Me.nuevaEv = New System.Windows.Forms.Button()
        Me.editarEv = New System.Windows.Forms.Button()
        Me.eliminarEv = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Curso:"
        '
        'cursoEv
        '
        Me.cursoEv.FormattingEnabled = True
        Me.cursoEv.Location = New System.Drawing.Point(149, 32)
        Me.cursoEv.Name = "cursoEv"
        Me.cursoEv.Size = New System.Drawing.Size(537, 21)
        Me.cursoEv.TabIndex = 1
        '
        'listEv
        '
        Me.listEv.FormattingEnabled = True
        Me.listEv.Location = New System.Drawing.Point(29, 79)
        Me.listEv.Name = "listEv"
        Me.listEv.Size = New System.Drawing.Size(657, 290)
        Me.listEv.TabIndex = 2
        '
        'tipoEv
        '
        Me.tipoEv.FormattingEnabled = True
        Me.tipoEv.Location = New System.Drawing.Point(29, 391)
        Me.tipoEv.Name = "tipoEv"
        Me.tipoEv.Size = New System.Drawing.Size(285, 134)
        Me.tipoEv.TabIndex = 3
        '
        'nuevaEv
        '
        Me.nuevaEv.Location = New System.Drawing.Point(363, 391)
        Me.nuevaEv.Name = "nuevaEv"
        Me.nuevaEv.Size = New System.Drawing.Size(323, 28)
        Me.nuevaEv.TabIndex = 4
        Me.nuevaEv.Text = "Nueva Evaluación"
        Me.nuevaEv.UseVisualStyleBackColor = True
        '
        'editarEv
        '
        Me.editarEv.Location = New System.Drawing.Point(363, 442)
        Me.editarEv.Name = "editarEv"
        Me.editarEv.Size = New System.Drawing.Size(323, 28)
        Me.editarEv.TabIndex = 5
        Me.editarEv.Text = "Editar Evaluación"
        Me.editarEv.UseVisualStyleBackColor = True
        '
        'eliminarEv
        '
        Me.eliminarEv.Location = New System.Drawing.Point(363, 497)
        Me.eliminarEv.Name = "eliminarEv"
        Me.eliminarEv.Size = New System.Drawing.Size(323, 28)
        Me.eliminarEv.TabIndex = 6
        Me.eliminarEv.Text = "Eliminar Evaluación"
        Me.eliminarEv.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 540)
        Me.Controls.Add(Me.eliminarEv)
        Me.Controls.Add(Me.editarEv)
        Me.Controls.Add(Me.nuevaEv)
        Me.Controls.Add(Me.tipoEv)
        Me.Controls.Add(Me.listEv)
        Me.Controls.Add(Me.cursoEv)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form9"
        Me.Text = "Evaluaciones Teoría"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cursoEv As System.Windows.Forms.ComboBox
    Friend WithEvents listEv As System.Windows.Forms.ListBox
    Friend WithEvents tipoEv As System.Windows.Forms.ListBox
    Friend WithEvents nuevaEv As System.Windows.Forms.Button
    Friend WithEvents editarEv As System.Windows.Forms.Button
    Friend WithEvents eliminarEv As System.Windows.Forms.Button
End Class
