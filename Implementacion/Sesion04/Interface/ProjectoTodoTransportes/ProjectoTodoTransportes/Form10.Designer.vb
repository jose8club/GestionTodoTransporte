<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.nombrePerEv = New System.Windows.Forms.TextBox()
        Me.personasEv = New System.Windows.Forms.ListBox()
        Me.guradarEv = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'nombrePerEv
        '
        Me.nombrePerEv.Location = New System.Drawing.Point(101, 28)
        Me.nombrePerEv.Name = "nombrePerEv"
        Me.nombrePerEv.Size = New System.Drawing.Size(484, 20)
        Me.nombrePerEv.TabIndex = 1
        '
        'personasEv
        '
        Me.personasEv.FormattingEnabled = True
        Me.personasEv.Location = New System.Drawing.Point(24, 81)
        Me.personasEv.Name = "personasEv"
        Me.personasEv.Size = New System.Drawing.Size(561, 290)
        Me.personasEv.TabIndex = 2
        '
        'guradarEv
        '
        Me.guradarEv.Location = New System.Drawing.Point(462, 391)
        Me.guradarEv.Name = "guradarEv"
        Me.guradarEv.Size = New System.Drawing.Size(123, 23)
        Me.guradarEv.TabIndex = 3
        Me.guradarEv.Text = "Guardar"
        Me.guradarEv.UseVisualStyleBackColor = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 437)
        Me.Controls.Add(Me.guradarEv)
        Me.Controls.Add(Me.personasEv)
        Me.Controls.Add(Me.nombrePerEv)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form10"
        Me.Text = "Nueva Evaluación Teoría"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nombrePerEv As System.Windows.Forms.TextBox
    Friend WithEvents personasEv As System.Windows.Forms.ListBox
    Friend WithEvents guradarEv As System.Windows.Forms.Button
End Class
