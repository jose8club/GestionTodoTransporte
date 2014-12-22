<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resGeneral
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cbox_pago = New System.Windows.Forms.ComboBox()
        Me.lbl_estudiante = New System.Windows.Forms.Label()
        Me.list_pago = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estudiante:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.list_pago)
        Me.GroupBox1.Controls.Add(Me.lbl_estudiante)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.cbox_pago)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 283)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pago Estudiante"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(9, 67)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Pagos:"
        '
        'cbox_pago
        '
        Me.cbox_pago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_pago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_pago.FormattingEnabled = True
        Me.cbox_pago.Location = New System.Drawing.Point(126, 30)
        Me.cbox_pago.Name = "cbox_pago"
        Me.cbox_pago.Size = New System.Drawing.Size(304, 21)
        Me.cbox_pago.TabIndex = 1
        '
        'lbl_estudiante
        '
        Me.lbl_estudiante.AutoSize = True
        Me.lbl_estudiante.Location = New System.Drawing.Point(466, 33)
        Me.lbl_estudiante.Name = "lbl_estudiante"
        Me.lbl_estudiante.Size = New System.Drawing.Size(39, 13)
        Me.lbl_estudiante.TabIndex = 36
        Me.lbl_estudiante.Text = "Label8"
        '
        'list_pago
        '
        Me.list_pago.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.list_pago.LabelEdit = True
        Me.list_pago.Location = New System.Drawing.Point(126, 67)
        Me.list_pago.Name = "list_pago"
        Me.list_pago.Size = New System.Drawing.Size(509, 175)
        Me.list_pago.TabIndex = 2
        Me.list_pago.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Monto"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Medio Pago"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Fecha Pago"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Descuento"
        '
        'resGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 467)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "resGeneral"
        Me.Text = "resGeneral"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents cbox_pago As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_estudiante As System.Windows.Forms.Label
    Friend WithEvents list_pago As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
