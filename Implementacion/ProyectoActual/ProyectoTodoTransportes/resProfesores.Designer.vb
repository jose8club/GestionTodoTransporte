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
        Dim ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbox_docente = New System.Windows.Forms.ComboBox()
        Me.list_estudiantesTeo = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Docentes:"
        '
        'cbox_docente
        '
        Me.cbox_docente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_docente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_docente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_docente.FormattingEnabled = True
        Me.cbox_docente.Location = New System.Drawing.Point(113, 35)
        Me.cbox_docente.Name = "cbox_docente"
        Me.cbox_docente.Size = New System.Drawing.Size(427, 21)
        Me.cbox_docente.TabIndex = 1
        '
        'list_estudiantesTeo
        '
        Me.list_estudiantesTeo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.list_estudiantesTeo.GridLines = True
        Me.list_estudiantesTeo.LabelEdit = True
        Me.list_estudiantesTeo.Location = New System.Drawing.Point(17, 110)
        Me.list_estudiantesTeo.MultiSelect = False
        Me.list_estudiantesTeo.Name = "list_estudiantesTeo"
        Me.list_estudiantesTeo.Size = New System.Drawing.Size(523, 174)
        Me.list_estudiantesTeo.TabIndex = 39
        Me.list_estudiantesTeo.UseCompatibleStateImageBehavior = False
        Me.list_estudiantesTeo.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        ColumnHeader1.Text = "Numero"
        ColumnHeader1.Width = 1
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Aprobados"
        Me.ColumnHeader2.Width = 108
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Reprobados"
        Me.ColumnHeader3.Width = 126
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbox_docente)
        Me.GroupBox1.Controls.Add(Me.list_estudiantesTeo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(601, 318)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profesores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Estudiantes:"
        '
        'resProfesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 461)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "resProfesores"
        Me.Text = "resProfesores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbox_docente As System.Windows.Forms.ComboBox
    Friend WithEvents list_estudiantesTeo As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
