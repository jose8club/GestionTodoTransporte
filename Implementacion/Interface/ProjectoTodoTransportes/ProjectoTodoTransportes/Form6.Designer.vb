<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nombrePsico = New System.Windows.Forms.ComboBox()
        Me.rutPsico = New System.Windows.Forms.ComboBox()
        Me.fechaPsico = New System.Windows.Forms.DateTimePicker()
        Me.horarioPsico = New System.Windows.Forms.TextBox()
        Me.estadoPsico = New System.Windows.Forms.ComboBox()
        Me.guardarPsico = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "R.U.T."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Horario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Estado"
        '
        'nombrePsico
        '
        Me.nombrePsico.FormattingEnabled = True
        Me.nombrePsico.Location = New System.Drawing.Point(113, 53)
        Me.nombrePsico.Name = "nombrePsico"
        Me.nombrePsico.Size = New System.Drawing.Size(334, 21)
        Me.nombrePsico.TabIndex = 5
        '
        'rutPsico
        '
        Me.rutPsico.FormattingEnabled = True
        Me.rutPsico.Location = New System.Drawing.Point(109, 106)
        Me.rutPsico.Name = "rutPsico"
        Me.rutPsico.Size = New System.Drawing.Size(334, 21)
        Me.rutPsico.TabIndex = 6
        '
        'fechaPsico
        '
        Me.fechaPsico.Location = New System.Drawing.Point(113, 156)
        Me.fechaPsico.Name = "fechaPsico"
        Me.fechaPsico.Size = New System.Drawing.Size(334, 20)
        Me.fechaPsico.TabIndex = 7
        '
        'horarioPsico
        '
        Me.horarioPsico.Location = New System.Drawing.Point(116, 211)
        Me.horarioPsico.Name = "horarioPsico"
        Me.horarioPsico.Size = New System.Drawing.Size(331, 20)
        Me.horarioPsico.TabIndex = 8
        '
        'estadoPsico
        '
        Me.estadoPsico.FormattingEnabled = True
        Me.estadoPsico.Location = New System.Drawing.Point(113, 270)
        Me.estadoPsico.Name = "estadoPsico"
        Me.estadoPsico.Size = New System.Drawing.Size(330, 21)
        Me.estadoPsico.TabIndex = 9
        '
        'guardarPsico
        '
        Me.guardarPsico.Location = New System.Drawing.Point(341, 335)
        Me.guardarPsico.Name = "guardarPsico"
        Me.guardarPsico.Size = New System.Drawing.Size(101, 28)
        Me.guardarPsico.TabIndex = 10
        Me.guardarPsico.Text = "Guardar"
        Me.guardarPsico.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 388)
        Me.Controls.Add(Me.guardarPsico)
        Me.Controls.Add(Me.estadoPsico)
        Me.Controls.Add(Me.horarioPsico)
        Me.Controls.Add(Me.fechaPsico)
        Me.Controls.Add(Me.rutPsico)
        Me.Controls.Add(Me.nombrePsico)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form6"
        Me.Text = "Practica Psicotecnico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nombrePsico As System.Windows.Forms.ComboBox
    Friend WithEvents rutPsico As System.Windows.Forms.ComboBox
    Friend WithEvents fechaPsico As System.Windows.Forms.DateTimePicker
    Friend WithEvents horarioPsico As System.Windows.Forms.TextBox
    Friend WithEvents estadoPsico As System.Windows.Forms.ComboBox
    Friend WithEvents guardarPsico As System.Windows.Forms.Button
End Class
