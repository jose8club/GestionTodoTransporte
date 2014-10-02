<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.fex = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sitEx = New System.Windows.Forms.ComboBox()
        Me.Bg = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'fex
        '
        Me.fex.Location = New System.Drawing.Point(101, 18)
        Me.fex.Name = "fex"
        Me.fex.Size = New System.Drawing.Size(372, 20)
        Me.fex.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Situación:"
        '
        'sitEx
        '
        Me.sitEx.FormattingEnabled = True
        Me.sitEx.Location = New System.Drawing.Point(100, 75)
        Me.sitEx.Name = "sitEx"
        Me.sitEx.Size = New System.Drawing.Size(372, 21)
        Me.sitEx.TabIndex = 3
        Me.sitEx.Text = "PENDIENTE"
        '
        'Bg
        '
        Me.Bg.Location = New System.Drawing.Point(334, 136)
        Me.Bg.Name = "Bg"
        Me.Bg.Size = New System.Drawing.Size(138, 34)
        Me.Bg.TabIndex = 4
        Me.Bg.Text = "Guardar"
        Me.Bg.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 199)
        Me.Controls.Add(Me.Bg)
        Me.Controls.Add(Me.sitEx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fex)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.Text = "Ingresar Examen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fex As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents sitEx As System.Windows.Forms.ComboBox
    Friend WithEvents Bg As System.Windows.Forms.Button
End Class
