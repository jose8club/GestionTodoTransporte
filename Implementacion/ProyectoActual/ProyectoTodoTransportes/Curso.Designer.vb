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
        Me.DG_HTmanana = New System.Windows.Forms.DataGridView()
        Me.lbl_manana = New System.Windows.Forms.Label()
        Me.lbl_tarde = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ADD_tarde = New System.Windows.Forms.Button()
        Me.ADD_manana = New System.Windows.Forms.Button()
        Me.DG_HTtarde = New System.Windows.Forms.DataGridView()
        Me.HTM_Hora = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.HTM_Minutos = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.HTM_Profesor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.HTM_Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.HTT_Hora = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.HTT_Minutos = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.HTT_Profesor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.HTT_Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DG_HTmanana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_HTtarde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbox_Area
        '
        Me.cbox_Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Area.FormattingEnabled = True
        Me.cbox_Area.Location = New System.Drawing.Point(150, 12)
        Me.cbox_Area.Name = "cbox_Area"
        Me.cbox_Area.Size = New System.Drawing.Size(278, 21)
        Me.cbox_Area.TabIndex = 50
        '
        'lbl_Licencia
        '
        Me.lbl_Licencia.AutoSize = True
        Me.lbl_Licencia.Location = New System.Drawing.Point(21, 15)
        Me.lbl_Licencia.Name = "lbl_Licencia"
        Me.lbl_Licencia.Size = New System.Drawing.Size(89, 13)
        Me.lbl_Licencia.TabIndex = 51
        Me.lbl_Licencia.Text = "Tipo de Licencia:"
        '
        'cbox_Producto
        '
        Me.cbox_Producto.FormattingEnabled = True
        Me.cbox_Producto.Location = New System.Drawing.Point(150, 42)
        Me.cbox_Producto.Name = "cbox_Producto"
        Me.cbox_Producto.Size = New System.Drawing.Size(278, 21)
        Me.cbox_Producto.TabIndex = 48
        '
        'lbl_Producto
        '
        Me.lbl_Producto.AutoSize = True
        Me.lbl_Producto.Location = New System.Drawing.Point(21, 45)
        Me.lbl_Producto.Name = "lbl_Producto"
        Me.lbl_Producto.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Producto.TabIndex = 49
        Me.lbl_Producto.Text = "Producto:"
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(21, 74)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Codigo.TabIndex = 52
        Me.lbl_Codigo.Text = "Código:"
        '
        'tbox_Codigo
        '
        Me.tbox_Codigo.Location = New System.Drawing.Point(150, 71)
        Me.tbox_Codigo.MaxLength = 10
        Me.tbox_Codigo.Name = "tbox_Codigo"
        Me.tbox_Codigo.Size = New System.Drawing.Size(278, 20)
        Me.tbox_Codigo.TabIndex = 53
        '
        'lbl_FechaTermino
        '
        Me.lbl_FechaTermino.AutoSize = True
        Me.lbl_FechaTermino.Location = New System.Drawing.Point(443, 48)
        Me.lbl_FechaTermino.Name = "lbl_FechaTermino"
        Me.lbl_FechaTermino.Size = New System.Drawing.Size(96, 13)
        Me.lbl_FechaTermino.TabIndex = 54
        Me.lbl_FechaTermino.Text = "Fecha de Termino:"
        '
        'lbl_FechaInicio
        '
        Me.lbl_FechaInicio.AutoSize = True
        Me.lbl_FechaInicio.Location = New System.Drawing.Point(443, 18)
        Me.lbl_FechaInicio.Name = "lbl_FechaInicio"
        Me.lbl_FechaInicio.Size = New System.Drawing.Size(83, 13)
        Me.lbl_FechaInicio.TabIndex = 55
        Me.lbl_FechaInicio.Text = "Fecha de Inicio:"
        '
        'date_FechaInicio
        '
        Me.date_FechaInicio.Location = New System.Drawing.Point(572, 15)
        Me.date_FechaInicio.Name = "date_FechaInicio"
        Me.date_FechaInicio.Size = New System.Drawing.Size(278, 20)
        Me.date_FechaInicio.TabIndex = 56
        '
        'date_FechaTermino
        '
        Me.date_FechaTermino.Location = New System.Drawing.Point(572, 45)
        Me.date_FechaTermino.Name = "date_FechaTermino"
        Me.date_FechaTermino.Size = New System.Drawing.Size(278, 20)
        Me.date_FechaTermino.TabIndex = 57
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Location = New System.Drawing.Point(480, 74)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 58
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'DG_HTmanana
        '
        Me.DG_HTmanana.AllowUserToAddRows = False
        Me.DG_HTmanana.AllowUserToDeleteRows = False
        Me.DG_HTmanana.AllowUserToResizeColumns = False
        Me.DG_HTmanana.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        Me.DG_HTmanana.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_HTmanana.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DG_HTmanana.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DG_HTmanana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_HTmanana.ColumnHeadersVisible = False
        Me.DG_HTmanana.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HTM_Hora, Me.HTM_Minutos, Me.HTM_Profesor, Me.HTM_Eliminar})
        Me.DG_HTmanana.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DG_HTmanana.GridColor = System.Drawing.Color.White
        Me.DG_HTmanana.Location = New System.Drawing.Point(47, 164)
        Me.DG_HTmanana.Name = "DG_HTmanana"
        Me.DG_HTmanana.RowHeadersVisible = False
        Me.DG_HTmanana.Size = New System.Drawing.Size(322, 76)
        Me.DG_HTmanana.TabIndex = 59
        '
        'lbl_manana
        '
        Me.lbl_manana.AutoSize = True
        Me.lbl_manana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_manana.Location = New System.Drawing.Point(44, 140)
        Me.lbl_manana.Name = "lbl_manana"
        Me.lbl_manana.Size = New System.Drawing.Size(52, 13)
        Me.lbl_manana.TabIndex = 61
        Me.lbl_manana.Text = "Mañana"
        '
        'lbl_tarde
        '
        Me.lbl_tarde.AutoSize = True
        Me.lbl_tarde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tarde.Location = New System.Drawing.Point(44, 260)
        Me.lbl_tarde.Name = "lbl_tarde"
        Me.lbl_tarde.Size = New System.Drawing.Size(40, 13)
        Me.lbl_tarde.TabIndex = 64
        Me.lbl_tarde.Text = "Tarde"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn1.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON_16x1622_fw
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.ToolTipText = "Haz clic para eliminar."
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn2.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON_16x16_fw
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ADD_tarde
        '
        Me.ADD_tarde.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.ADD_BUTTON_16x16_fw
        Me.ADD_tarde.Location = New System.Drawing.Point(294, 255)
        Me.ADD_tarde.Margin = New System.Windows.Forms.Padding(0)
        Me.ADD_tarde.Name = "ADD_tarde"
        Me.ADD_tarde.Size = New System.Drawing.Size(75, 26)
        Me.ADD_tarde.TabIndex = 65
        Me.ADD_tarde.Text = "Agregar"
        Me.ADD_tarde.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ADD_tarde.UseVisualStyleBackColor = True
        '
        'ADD_manana
        '
        Me.ADD_manana.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.ADD_BUTTON_16x16_fw
        Me.ADD_manana.Location = New System.Drawing.Point(294, 135)
        Me.ADD_manana.Margin = New System.Windows.Forms.Padding(0)
        Me.ADD_manana.Name = "ADD_manana"
        Me.ADD_manana.Size = New System.Drawing.Size(75, 26)
        Me.ADD_manana.TabIndex = 62
        Me.ADD_manana.Text = "Agregar"
        Me.ADD_manana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ADD_manana.UseVisualStyleBackColor = True
        '
        'DG_HTtarde
        '
        Me.DG_HTtarde.AllowUserToAddRows = False
        Me.DG_HTtarde.AllowUserToDeleteRows = False
        Me.DG_HTtarde.AllowUserToResizeColumns = False
        Me.DG_HTtarde.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        Me.DG_HTtarde.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_HTtarde.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DG_HTtarde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DG_HTtarde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_HTtarde.ColumnHeadersVisible = False
        Me.DG_HTtarde.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HTT_Hora, Me.HTT_Minutos, Me.HTT_Profesor, Me.HTT_Eliminar})
        Me.DG_HTtarde.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DG_HTtarde.GridColor = System.Drawing.Color.White
        Me.DG_HTtarde.Location = New System.Drawing.Point(47, 284)
        Me.DG_HTtarde.Name = "DG_HTtarde"
        Me.DG_HTtarde.RowHeadersVisible = False
        Me.DG_HTtarde.Size = New System.Drawing.Size(322, 76)
        Me.DG_HTtarde.TabIndex = 66
        '
        'HTM_Hora
        '
        Me.HTM_Hora.HeaderText = "Hora"
        Me.HTM_Hora.Items.AddRange(New Object() {"08", "09", "10", "11"})
        Me.HTM_Hora.Name = "HTM_Hora"
        Me.HTM_Hora.Width = 50
        '
        'HTM_Minutos
        '
        Me.HTM_Minutos.HeaderText = "Minutos"
        Me.HTM_Minutos.Items.AddRange(New Object() {"00", "10", "20", "30", "40", "50"})
        Me.HTM_Minutos.Name = "HTM_Minutos"
        Me.HTM_Minutos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HTM_Minutos.Width = 50
        '
        'HTM_Profesor
        '
        Me.HTM_Profesor.HeaderText = "Profesor"
        Me.HTM_Profesor.Name = "HTM_Profesor"
        Me.HTM_Profesor.Width = 174
        '
        'HTM_Eliminar
        '
        Me.HTM_Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.HTM_Eliminar.HeaderText = "Eliminar"
        Me.HTM_Eliminar.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON_finale_fw
        Me.HTM_Eliminar.Name = "HTM_Eliminar"
        Me.HTM_Eliminar.ReadOnly = True
        Me.HTM_Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HTM_Eliminar.ToolTipText = "Haz clic para eliminar."
        Me.HTM_Eliminar.Width = 5
        '
        'HTT_Hora
        '
        Me.HTT_Hora.HeaderText = "Hora"
        Me.HTT_Hora.Items.AddRange(New Object() {"12", "13", "14", "15", "16", "17", "18", "19", "20", "21"})
        Me.HTT_Hora.Name = "HTT_Hora"
        Me.HTT_Hora.Width = 50
        '
        'HTT_Minutos
        '
        Me.HTT_Minutos.HeaderText = "Minutos"
        Me.HTT_Minutos.Items.AddRange(New Object() {"00", "10", "20", "30", "40", "50"})
        Me.HTT_Minutos.Name = "HTT_Minutos"
        Me.HTT_Minutos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HTT_Minutos.Width = 50
        '
        'HTT_Profesor
        '
        Me.HTT_Profesor.HeaderText = "Profesor"
        Me.HTT_Profesor.Name = "HTT_Profesor"
        Me.HTT_Profesor.Width = 174
        '
        'HTT_Eliminar
        '
        Me.HTT_Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.HTT_Eliminar.HeaderText = "Eliminar"
        Me.HTT_Eliminar.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON_finale_fw
        Me.HTT_Eliminar.Name = "HTT_Eliminar"
        Me.HTT_Eliminar.ReadOnly = True
        Me.HTT_Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HTT_Eliminar.ToolTipText = "Haz clic para eliminar."
        Me.HTT_Eliminar.Width = 5
        '
        'Curso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 400)
        Me.Controls.Add(Me.DG_HTtarde)
        Me.Controls.Add(Me.ADD_tarde)
        Me.Controls.Add(Me.lbl_tarde)
        Me.Controls.Add(Me.ADD_manana)
        Me.Controls.Add(Me.lbl_manana)
        Me.Controls.Add(Me.DG_HTmanana)
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
        CType(Me.DG_HTmanana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_HTtarde, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DG_HTmanana As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_manana As System.Windows.Forms.Label
    Friend WithEvents ADD_manana As System.Windows.Forms.Button
    Friend WithEvents ADD_tarde As System.Windows.Forms.Button
    Friend WithEvents lbl_tarde As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DG_HTtarde As System.Windows.Forms.DataGridView
    Friend WithEvents HTM_Hora As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents HTM_Minutos As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents HTM_Profesor As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents HTM_Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents HTT_Hora As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents HTT_Minutos As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents HTT_Profesor As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents HTT_Eliminar As System.Windows.Forms.DataGridViewImageColumn
End Class
