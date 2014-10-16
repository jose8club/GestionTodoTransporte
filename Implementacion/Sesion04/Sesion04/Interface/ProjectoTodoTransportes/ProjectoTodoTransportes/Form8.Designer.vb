<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.nombreClase = New System.Windows.Forms.ComboBox()
        Me.profesorClase = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fechaClase = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cclase = New System.Windows.Forms.RichTextBox()
        Me.tablaClase = New System.Windows.Forms.ListBox()
        Me.guardarClase = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clase:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Profesor:"
        '
        'nombreClase
        '
        Me.nombreClase.FormattingEnabled = True
        Me.nombreClase.Location = New System.Drawing.Point(120, 32)
        Me.nombreClase.Name = "nombreClase"
        Me.nombreClase.Size = New System.Drawing.Size(338, 21)
        Me.nombreClase.TabIndex = 3
        '
        'profesorClase
        '
        Me.profesorClase.FormattingEnabled = True
        Me.profesorClase.Location = New System.Drawing.Point(120, 73)
        Me.profesorClase.Name = "profesorClase"
        Me.profesorClase.Size = New System.Drawing.Size(338, 21)
        Me.profesorClase.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha:"
        '
        'fechaClase
        '
        Me.fechaClase.Location = New System.Drawing.Point(120, 110)
        Me.fechaClase.Name = "fechaClase"
        Me.fechaClase.Size = New System.Drawing.Size(338, 20)
        Me.fechaClase.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Contenidos:"
        '
        'Cclase
        '
        Me.Cclase.Location = New System.Drawing.Point(120, 160)
        Me.Cclase.Name = "Cclase"
        Me.Cclase.Size = New System.Drawing.Size(338, 90)
        Me.Cclase.TabIndex = 8
        Me.Cclase.Text = ""
        '
        'tablaClase
        '
        Me.tablaClase.FormattingEnabled = True
        Me.tablaClase.Location = New System.Drawing.Point(62, 278)
        Me.tablaClase.Name = "tablaClase"
        Me.tablaClase.Size = New System.Drawing.Size(375, 251)
        Me.tablaClase.TabIndex = 9
        '
        'guardarClase
        '
        Me.guardarClase.Location = New System.Drawing.Point(383, 546)
        Me.guardarClase.Name = "guardarClase"
        Me.guardarClase.Size = New System.Drawing.Size(75, 23)
        Me.guardarClase.TabIndex = 10
        Me.guardarClase.Text = "Guardar"
        Me.guardarClase.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 591)
        Me.Controls.Add(Me.guardarClase)
        Me.Controls.Add(Me.tablaClase)
        Me.Controls.Add(Me.Cclase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fechaClase)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.profesorClase)
        Me.Controls.Add(Me.nombreClase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form8"
        Me.Text = "Registrar Clase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombreClase As System.Windows.Forms.ComboBox
    Friend WithEvents profesorClase As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fechaClase As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cclase As System.Windows.Forms.RichTextBox
    Friend WithEvents tablaClase As System.Windows.Forms.ListBox
    Friend WithEvents guardarClase As System.Windows.Forms.Button
End Class
