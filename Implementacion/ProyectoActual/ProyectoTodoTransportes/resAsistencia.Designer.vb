<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resAsistencia
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
        Me.cbox_estudiante = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.list_asistencias = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_estudiante = New System.Windows.Forms.Label()
        ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbox_estudiante
        '
        Me.cbox_estudiante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_estudiante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_estudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_estudiante.FormattingEnabled = True
        Me.cbox_estudiante.Location = New System.Drawing.Point(108, 46)
        Me.cbox_estudiante.Name = "cbox_estudiante"
        Me.cbox_estudiante.Size = New System.Drawing.Size(225, 21)
        Me.cbox_estudiante.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Estudiante:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_estudiante)
        Me.GroupBox1.Controls.Add(Me.list_asistencias)
        Me.GroupBox1.Controls.Add(Me.cbox_estudiante)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 284)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asistencias por Estudiante"
        '
        'list_asistencias
        '
        Me.list_asistencias.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.list_asistencias.GridLines = True
        Me.list_asistencias.LabelEdit = True
        Me.list_asistencias.Location = New System.Drawing.Point(28, 93)
        Me.list_asistencias.MultiSelect = False
        Me.list_asistencias.Name = "list_asistencias"
        Me.list_asistencias.Size = New System.Drawing.Size(523, 174)
        Me.list_asistencias.TabIndex = 40
        Me.list_asistencias.UseCompatibleStateImageBehavior = False
        Me.list_asistencias.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        ColumnHeader1.Text = "Numero"
        ColumnHeader1.Width = 1
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Asistencia Teorica"
        Me.ColumnHeader2.Width = 253
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Asistencia Teorica"
        Me.ColumnHeader3.Width = 260
        '
        'lbl_estudiante
        '
        Me.lbl_estudiante.AutoSize = True
        Me.lbl_estudiante.Location = New System.Drawing.Point(368, 49)
        Me.lbl_estudiante.Name = "lbl_estudiante"
        Me.lbl_estudiante.Size = New System.Drawing.Size(39, 13)
        Me.lbl_estudiante.TabIndex = 41
        Me.lbl_estudiante.Text = "Label8"
        '
        'resAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 419)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "resAsistencia"
        Me.Text = "resAsistencia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbox_estudiante As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents list_asistencias As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_estudiante As System.Windows.Forms.Label
End Class
