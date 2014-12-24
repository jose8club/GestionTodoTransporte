<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Curso
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbox_Area = New System.Windows.Forms.ComboBox()
        Me.lbl_Licencia = New System.Windows.Forms.Label()
        Me.cbox_Producto = New System.Windows.Forms.ComboBox()
        Me.lbl_Producto = New System.Windows.Forms.Label()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.tbox_Codigo = New System.Windows.Forms.TextBox()
        Me.lbl_FechaTermino = New System.Windows.Forms.Label()
        Me.lbl_FechaInicio = New System.Windows.Forms.Label()
        Me.date_FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.date_FechaTermino = New System.Windows.Forms.DateTimePicker()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.DG_HT = New System.Windows.Forms.DataGridView()
        Me.HT_Hora = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.HT_Minutos = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.HT_Profesor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.HT_Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ADD_HT = New System.Windows.Forms.Button()
        Me.GB_HT = New System.Windows.Forms.GroupBox()
        Me.GB_HP = New System.Windows.Forms.GroupBox()
        CType(Me.DG_HT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_HT.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbox_Area
        '
        Me.cbox_Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Area.FormattingEnabled = True
        Me.cbox_Area.Location = New System.Drawing.Point(150, 38)
        Me.cbox_Area.Name = "cbox_Area"
        Me.cbox_Area.Size = New System.Drawing.Size(229, 21)
        Me.cbox_Area.TabIndex = 50
        '
        'lbl_Licencia
        '
        Me.lbl_Licencia.AutoSize = True
        Me.lbl_Licencia.Location = New System.Drawing.Point(21, 41)
        Me.lbl_Licencia.Name = "lbl_Licencia"
        Me.lbl_Licencia.Size = New System.Drawing.Size(89, 13)
        Me.lbl_Licencia.TabIndex = 51
        Me.lbl_Licencia.Text = "Tipo de Licencia:"
        '
        'cbox_Producto
        '
        Me.cbox_Producto.FormattingEnabled = True
        Me.cbox_Producto.Location = New System.Drawing.Point(150, 65)
        Me.cbox_Producto.Name = "cbox_Producto"
        Me.cbox_Producto.Size = New System.Drawing.Size(229, 21)
        Me.cbox_Producto.TabIndex = 48
        '
        'lbl_Producto
        '
        Me.lbl_Producto.AutoSize = True
        Me.lbl_Producto.Location = New System.Drawing.Point(21, 68)
        Me.lbl_Producto.Name = "lbl_Producto"
        Me.lbl_Producto.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Producto.TabIndex = 49
        Me.lbl_Producto.Text = "Producto:"
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(21, 15)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Codigo.TabIndex = 52
        Me.lbl_Codigo.Text = "Código:"
        '
        'tbox_Codigo
        '
        Me.tbox_Codigo.Location = New System.Drawing.Point(150, 12)
        Me.tbox_Codigo.MaxLength = 10
        Me.tbox_Codigo.Name = "tbox_Codigo"
        Me.tbox_Codigo.Size = New System.Drawing.Size(229, 20)
        Me.tbox_Codigo.TabIndex = 53
        '
        'lbl_FechaTermino
        '
        Me.lbl_FechaTermino.AutoSize = True
        Me.lbl_FechaTermino.Location = New System.Drawing.Point(399, 68)
        Me.lbl_FechaTermino.Name = "lbl_FechaTermino"
        Me.lbl_FechaTermino.Size = New System.Drawing.Size(96, 13)
        Me.lbl_FechaTermino.TabIndex = 54
        Me.lbl_FechaTermino.Text = "Fecha de Termino:"
        '
        'lbl_FechaInicio
        '
        Me.lbl_FechaInicio.AutoSize = True
        Me.lbl_FechaInicio.Location = New System.Drawing.Point(399, 42)
        Me.lbl_FechaInicio.Name = "lbl_FechaInicio"
        Me.lbl_FechaInicio.Size = New System.Drawing.Size(83, 13)
        Me.lbl_FechaInicio.TabIndex = 55
        Me.lbl_FechaInicio.Text = "Fecha de Inicio:"
        '
        'date_FechaInicio
        '
        Me.date_FechaInicio.Location = New System.Drawing.Point(507, 39)
        Me.date_FechaInicio.Name = "date_FechaInicio"
        Me.date_FechaInicio.Size = New System.Drawing.Size(226, 20)
        Me.date_FechaInicio.TabIndex = 56
        '
        'date_FechaTermino
        '
        Me.date_FechaTermino.Location = New System.Drawing.Point(507, 62)
        Me.date_FechaTermino.Name = "date_FechaTermino"
        Me.date_FechaTermino.Size = New System.Drawing.Size(226, 20)
        Me.date_FechaTermino.TabIndex = 57
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Location = New System.Drawing.Point(507, 349)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 58
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'DG_HT
        '
        Me.DG_HT.AllowUserToAddRows = False
        Me.DG_HT.AllowUserToDeleteRows = False
        Me.DG_HT.AllowUserToResizeColumns = False
        Me.DG_HT.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.DG_HT.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_HT.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DG_HT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DG_HT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_HT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_HT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_HT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HT_Hora, Me.HT_Minutos, Me.HT_Profesor, Me.HT_Eliminar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_HT.DefaultCellStyle = DataGridViewCellStyle3
        Me.DG_HT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DG_HT.GridColor = System.Drawing.SystemColors.Control
        Me.DG_HT.Location = New System.Drawing.Point(11, 20)
        Me.DG_HT.MultiSelect = False
        Me.DG_HT.Name = "DG_HT"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_HT.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_HT.RowHeadersVisible = False
        Me.DG_HT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DG_HT.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DG_HT.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_HT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DG_HT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DG_HT.ShowCellErrors = False
        Me.DG_HT.ShowEditingIcon = False
        Me.DG_HT.ShowRowErrors = False
        Me.DG_HT.Size = New System.Drawing.Size(332, 138)
        Me.DG_HT.TabIndex = 59
        '
        'HT_Hora
        '
        Me.HT_Hora.HeaderText = "Hora"
        Me.HT_Hora.Items.AddRange(New Object() {"08", "09", "10", "11"})
        Me.HT_Hora.Name = "HT_Hora"
        Me.HT_Hora.Width = 50
        '
        'HT_Minutos
        '
        Me.HT_Minutos.HeaderText = "Minutos"
        Me.HT_Minutos.Items.AddRange(New Object() {"00", "10", "20", "30", "40", "50"})
        Me.HT_Minutos.Name = "HT_Minutos"
        Me.HT_Minutos.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.HT_Minutos.Width = 50
        '
        'HT_Profesor
        '
        Me.HT_Profesor.HeaderText = "Profesor"
        Me.HT_Profesor.Items.AddRange(New Object() {"- Seleccionar Profesor -"})
        Me.HT_Profesor.Name = "HT_Profesor"
        Me.HT_Profesor.Width = 174
        '
        'HT_Eliminar
        '
        Me.HT_Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.HT_Eliminar.HeaderText = "Eliminar"
        Me.HT_Eliminar.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON
        Me.HT_Eliminar.Name = "HT_Eliminar"
        Me.HT_Eliminar.ReadOnly = True
        Me.HT_Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HT_Eliminar.ToolTipText = "Haz clic para eliminar."
        Me.HT_Eliminar.Width = 49
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.ToolTipText = "Haz clic para eliminar."
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewImageColumn2.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.ToolTipText = "Haz clic para eliminar."
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewImageColumn3.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn3.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.ToolTipText = "Haz clic para eliminar."
        '
        'ADD_HT
        '
        Me.ADD_HT.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.ADD_BUTTON
        Me.ADD_HT.Location = New System.Drawing.Point(268, 161)
        Me.ADD_HT.Margin = New System.Windows.Forms.Padding(0)
        Me.ADD_HT.Name = "ADD_HT"
        Me.ADD_HT.Size = New System.Drawing.Size(75, 26)
        Me.ADD_HT.TabIndex = 62
        Me.ADD_HT.Text = "Agregar"
        Me.ADD_HT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ADD_HT.UseVisualStyleBackColor = True
        '
        'GB_HT
        '
        Me.GB_HT.Controls.Add(Me.DG_HT)
        Me.GB_HT.Controls.Add(Me.ADD_HT)
        Me.GB_HT.Location = New System.Drawing.Point(24, 125)
        Me.GB_HT.Name = "GB_HT"
        Me.GB_HT.Size = New System.Drawing.Size(355, 207)
        Me.GB_HT.TabIndex = 68
        Me.GB_HT.TabStop = False
        Me.GB_HT.Text = "Horario Teórico"
        '
        'GB_HP
        '
        Me.GB_HP.Location = New System.Drawing.Point(402, 125)
        Me.GB_HP.Name = "GB_HP"
        Me.GB_HP.Size = New System.Drawing.Size(331, 207)
        Me.GB_HP.TabIndex = 69
        Me.GB_HP.TabStop = False
        Me.GB_HP.Text = "GroupBox1"
        '
        'Curso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 400)
        Me.Controls.Add(Me.GB_HP)
        Me.Controls.Add(Me.GB_HT)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.date_FechaTermino)
        Me.Controls.Add(Me.date_FechaInicio)
        Me.Controls.Add(Me.lbl_FechaInicio)
        Me.Controls.Add(Me.lbl_FechaTermino)
        Me.Controls.Add(Me.tbox_Codigo)
        Me.Controls.Add(Me.lbl_Codigo)
        Me.Controls.Add(Me.cbox_Area)
        Me.Controls.Add(Me.lbl_Licencia)
        Me.Controls.Add(Me.cbox_Producto)
        Me.Controls.Add(Me.lbl_Producto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Curso"
        Me.Text = "Curso"
        CType(Me.DG_HT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_HT.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbox_Area As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Licencia As System.Windows.Forms.Label
    Friend WithEvents cbox_Producto As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Producto As System.Windows.Forms.Label
    Friend WithEvents lbl_Codigo As System.Windows.Forms.Label
    Friend WithEvents tbox_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_FechaTermino As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaInicio As System.Windows.Forms.Label
    Friend WithEvents date_FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents date_FechaTermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents DG_HT As System.Windows.Forms.DataGridView
    Friend WithEvents ADD_HT As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents GB_HT As System.Windows.Forms.GroupBox
    Friend WithEvents GB_HP As System.Windows.Forms.GroupBox
    Friend WithEvents HT_Hora As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents HT_Minutos As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents HT_Profesor As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents HT_Eliminar As System.Windows.Forms.DataGridViewImageColumn
End Class
