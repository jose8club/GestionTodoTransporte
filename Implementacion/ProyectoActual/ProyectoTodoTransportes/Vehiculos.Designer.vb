<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehiculos
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
        Me.lbl_Estado = New System.Windows.Forms.Label()
        Me.lbl_Modelo = New System.Windows.Forms.Label()
        Me.lbl_NombreUsuario = New System.Windows.Forms.Label()
        Me.tbox_modelo = New System.Windows.Forms.TextBox()
        Me.tbox_Patente = New System.Windows.Forms.TextBox()
        Me.cbox_Estado = New System.Windows.Forms.ComboBox()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Estado
        '
        Me.lbl_Estado.AutoSize = True
        Me.lbl_Estado.Location = New System.Drawing.Point(12, 69)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Estado.TabIndex = 12
        Me.lbl_Estado.Text = "Estado:"
        '
        'lbl_Modelo
        '
        Me.lbl_Modelo.AutoSize = True
        Me.lbl_Modelo.Location = New System.Drawing.Point(12, 41)
        Me.lbl_Modelo.Name = "lbl_Modelo"
        Me.lbl_Modelo.Size = New System.Drawing.Size(45, 13)
        Me.lbl_Modelo.TabIndex = 11
        Me.lbl_Modelo.Text = "Modelo:"
        '
        'lbl_NombreUsuario
        '
        Me.lbl_NombreUsuario.AutoSize = True
        Me.lbl_NombreUsuario.Location = New System.Drawing.Point(12, 15)
        Me.lbl_NombreUsuario.Name = "lbl_NombreUsuario"
        Me.lbl_NombreUsuario.Size = New System.Drawing.Size(97, 13)
        Me.lbl_NombreUsuario.TabIndex = 10
        Me.lbl_NombreUsuario.Text = "Matrícula/Patente:"
        '
        'tbox_modelo
        '
        Me.tbox_modelo.Location = New System.Drawing.Point(158, 38)
        Me.tbox_modelo.MaxLength = 45
        Me.tbox_modelo.Name = "tbox_modelo"
        Me.tbox_modelo.Size = New System.Drawing.Size(259, 20)
        Me.tbox_modelo.TabIndex = 1
        '
        'tbox_Patente
        '
        Me.tbox_Patente.Location = New System.Drawing.Point(158, 12)
        Me.tbox_Patente.MaxLength = 6
        Me.tbox_Patente.Name = "tbox_Patente"
        Me.tbox_Patente.Size = New System.Drawing.Size(259, 20)
        Me.tbox_Patente.TabIndex = 0
        '
        'cbox_Estado
        '
        Me.cbox_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Estado.FormattingEnabled = True
        Me.cbox_Estado.Location = New System.Drawing.Point(158, 66)
        Me.cbox_Estado.Name = "cbox_Estado"
        Me.cbox_Estado.Size = New System.Drawing.Size(259, 21)
        Me.cbox_Estado.TabIndex = 2
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Location = New System.Drawing.Point(340, 145)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 3
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Vehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 268)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.lbl_Estado)
        Me.Controls.Add(Me.lbl_Modelo)
        Me.Controls.Add(Me.lbl_NombreUsuario)
        Me.Controls.Add(Me.tbox_modelo)
        Me.Controls.Add(Me.tbox_Patente)
        Me.Controls.Add(Me.cbox_Estado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Vehiculos"
        Me.Text = "Vehiculos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Estado As System.Windows.Forms.Label
    Friend WithEvents lbl_Modelo As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreUsuario As System.Windows.Forms.Label
    Friend WithEvents tbox_modelo As System.Windows.Forms.TextBox
    Friend WithEvents tbox_Patente As System.Windows.Forms.TextBox
    Friend WithEvents cbox_Estado As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
End Class
