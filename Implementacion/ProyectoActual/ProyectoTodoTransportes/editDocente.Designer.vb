<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editDocente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.list_Docente = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.check_profesores = New System.Windows.Forms.CheckBox()
        Me.check_instructores = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'list_Docente
        '
        Me.list_Docente.FormattingEnabled = True
        Me.list_Docente.Location = New System.Drawing.Point(12, 102)
        Me.list_Docente.Name = "list_Docente"
        Me.list_Docente.Size = New System.Drawing.Size(242, 173)
        Me.list_Docente.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(242, 20)
        Me.TextBox1.TabIndex = 1
        '
        'check_profesores
        '
        Me.check_profesores.AutoSize = True
        Me.check_profesores.Location = New System.Drawing.Point(12, 12)
        Me.check_profesores.Name = "check_profesores"
        Me.check_profesores.Size = New System.Drawing.Size(113, 17)
        Me.check_profesores.TabIndex = 2
        Me.check_profesores.Text = "Mostrar profesores"
        Me.check_profesores.UseVisualStyleBackColor = True
        '
        'check_instructores
        '
        Me.check_instructores.AutoSize = True
        Me.check_instructores.Location = New System.Drawing.Point(12, 35)
        Me.check_instructores.Name = "check_instructores"
        Me.check_instructores.Size = New System.Drawing.Size(118, 17)
        Me.check_instructores.TabIndex = 3
        Me.check_instructores.Text = "Mostrar instructores"
        Me.check_instructores.UseVisualStyleBackColor = True
        '
        'editDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 292)
        Me.Controls.Add(Me.check_instructores)
        Me.Controls.Add(Me.check_profesores)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.list_Docente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editDocente"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents list_Docente As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents check_profesores As System.Windows.Forms.CheckBox
    Friend WithEvents check_instructores As System.Windows.Forms.CheckBox
End Class
