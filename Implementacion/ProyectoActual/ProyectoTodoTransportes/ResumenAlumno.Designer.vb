<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenAlumno
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
        Me.list_Alumno = New System.Windows.Forms.DataGridView()
        Me.tbox_search = New System.Windows.Forms.TextBox()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Rut = New System.Windows.Forms.Label()
        Me.lbl_Curso = New System.Windows.Forms.Label()
        Me.lbl_HTeoria = New System.Windows.Forms.Label()
        Me.lbl_HPractica = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.list_Alumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'list_Alumno
        '
        Me.list_Alumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.list_Alumno.Location = New System.Drawing.Point(12, 80)
        Me.list_Alumno.Name = "list_Alumno"
        Me.list_Alumno.Size = New System.Drawing.Size(268, 217)
        Me.list_Alumno.TabIndex = 0
        '
        'tbox_search
        '
        Me.tbox_search.Location = New System.Drawing.Point(12, 41)
        Me.tbox_search.Name = "tbox_search"
        Me.tbox_search.Size = New System.Drawing.Size(268, 20)
        Me.tbox_search.TabIndex = 1
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(325, 80)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Nombre.TabIndex = 2
        Me.lbl_Nombre.Tag = ""
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'lbl_Rut
        '
        Me.lbl_Rut.AutoSize = True
        Me.lbl_Rut.Location = New System.Drawing.Point(325, 103)
        Me.lbl_Rut.Name = "lbl_Rut"
        Me.lbl_Rut.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Rut.TabIndex = 3
        Me.lbl_Rut.Tag = ""
        Me.lbl_Rut.Text = "R.U.T.:"
        '
        'lbl_Curso
        '
        Me.lbl_Curso.AutoSize = True
        Me.lbl_Curso.Location = New System.Drawing.Point(325, 125)
        Me.lbl_Curso.Name = "lbl_Curso"
        Me.lbl_Curso.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Curso.TabIndex = 4
        Me.lbl_Curso.Tag = ""
        Me.lbl_Curso.Text = "Curso:"
        '
        'lbl_HTeoria
        '
        Me.lbl_HTeoria.AutoSize = True
        Me.lbl_HTeoria.Location = New System.Drawing.Point(351, 151)
        Me.lbl_HTeoria.Name = "lbl_HTeoria"
        Me.lbl_HTeoria.Size = New System.Drawing.Size(79, 13)
        Me.lbl_HTeoria.TabIndex = 5
        Me.lbl_HTeoria.Tag = ""
        Me.lbl_HTeoria.Text = "Horario Teoría:"
        '
        'lbl_HPractica
        '
        Me.lbl_HPractica.AutoSize = True
        Me.lbl_HPractica.Location = New System.Drawing.Point(351, 174)
        Me.lbl_HPractica.Name = "lbl_HPractica"
        Me.lbl_HPractica.Size = New System.Drawing.Size(86, 13)
        Me.lbl_HPractica.TabIndex = 6
        Me.lbl_HPractica.Tag = ""
        Me.lbl_HPractica.Text = "Horario Práctica:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(325, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Tag = ""
        Me.Label1.Text = "Curso:"
        '
        'ResumenAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_HPractica)
        Me.Controls.Add(Me.lbl_HTeoria)
        Me.Controls.Add(Me.lbl_Curso)
        Me.Controls.Add(Me.lbl_Rut)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.tbox_search)
        Me.Controls.Add(Me.list_Alumno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ResumenAlumno"
        Me.Text = "ResumenAlumno"
        CType(Me.list_Alumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents list_Alumno As System.Windows.Forms.DataGridView
    Friend WithEvents tbox_search As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_Rut As System.Windows.Forms.Label
    Friend WithEvents lbl_Curso As System.Windows.Forms.Label
    Friend WithEvents lbl_HTeoria As System.Windows.Forms.Label
    Friend WithEvents lbl_HPractica As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
