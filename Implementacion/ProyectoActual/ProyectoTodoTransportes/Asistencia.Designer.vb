<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asistencia
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grp_asistencia = New System.Windows.Forms.GroupBox()
        Me.cbox_docente = New System.Windows.Forms.ComboBox()
        Me.lbl_docente = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_asistencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(39, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 120
        Me.DataGridView1.Size = New System.Drawing.Size(522, 112)
        Me.DataGridView1.TabIndex = 38
        '
        'grp_asistencia
        '
        Me.grp_asistencia.Controls.Add(Me.cbox_docente)
        Me.grp_asistencia.Controls.Add(Me.lbl_docente)
        Me.grp_asistencia.Controls.Add(Me.DataGridView1)
        Me.grp_asistencia.Location = New System.Drawing.Point(56, 33)
        Me.grp_asistencia.Name = "grp_asistencia"
        Me.grp_asistencia.Size = New System.Drawing.Size(613, 232)
        Me.grp_asistencia.TabIndex = 39
        Me.grp_asistencia.TabStop = False
        Me.grp_asistencia.Text = "Asistencia"
        '
        'cbox_docente
        '
        Me.cbox_docente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_docente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_docente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_docente.FormattingEnabled = True
        Me.cbox_docente.Location = New System.Drawing.Point(115, 36)
        Me.cbox_docente.Name = "cbox_docente"
        Me.cbox_docente.Size = New System.Drawing.Size(210, 20)
        Me.cbox_docente.TabIndex = 115
        '
        'lbl_docente
        '
        Me.lbl_docente.AutoSize = True
        Me.lbl_docente.Location = New System.Drawing.Point(38, 39)
        Me.lbl_docente.Name = "lbl_docente"
        Me.lbl_docente.Size = New System.Drawing.Size(51, 13)
        Me.lbl_docente.TabIndex = 114
        Me.lbl_docente.Text = "Docente:"
        '
        'Asistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 312)
        Me.Controls.Add(Me.grp_asistencia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Asistencia"
        Me.Text = "Asistencia"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_asistencia.ResumeLayout(False)
        Me.grp_asistencia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents grp_asistencia As System.Windows.Forms.GroupBox
    Friend WithEvents cbox_docente As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_docente As System.Windows.Forms.Label
End Class
