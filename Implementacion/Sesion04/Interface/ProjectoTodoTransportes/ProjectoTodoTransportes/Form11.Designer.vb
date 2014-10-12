<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Me.guradarEdEv = New System.Windows.Forms.Button()
        Me.personasEditarEv = New System.Windows.Forms.ListBox()
        Me.nombrePerEdEv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'guradarEdEv
        '
        Me.guradarEdEv.Location = New System.Drawing.Point(467, 397)
        Me.guradarEdEv.Name = "guradarEdEv"
        Me.guradarEdEv.Size = New System.Drawing.Size(123, 23)
        Me.guradarEdEv.TabIndex = 7
        Me.guradarEdEv.Text = "Guardar"
        Me.guradarEdEv.UseVisualStyleBackColor = True
        '
        'personasEditarEv
        '
        Me.personasEditarEv.FormattingEnabled = True
        Me.personasEditarEv.Location = New System.Drawing.Point(29, 87)
        Me.personasEditarEv.Name = "personasEditarEv"
        Me.personasEditarEv.Size = New System.Drawing.Size(561, 290)
        Me.personasEditarEv.TabIndex = 6
        '
        'nombrePerEdEv
        '
        Me.nombrePerEdEv.Location = New System.Drawing.Point(106, 34)
        Me.nombrePerEdEv.Name = "nombrePerEdEv"
        Me.nombrePerEdEv.Size = New System.Drawing.Size(484, 20)
        Me.nombrePerEdEv.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre:"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 433)
        Me.Controls.Add(Me.guradarEdEv)
        Me.Controls.Add(Me.personasEditarEv)
        Me.Controls.Add(Me.nombrePerEdEv)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form11"
        Me.Text = "Editar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents guradarEdEv As System.Windows.Forms.Button
    Friend WithEvents personasEditarEv As System.Windows.Forms.ListBox
    Friend WithEvents nombrePerEdEv As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
