<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamenMunicipal
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
        Me.btn_Municipal = New System.Windows.Forms.Button()
        Me.rtbox_comentario = New System.Windows.Forms.RichTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbox_estMun = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbox_instMun = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbox_docMunicipal = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbox_codMunicipal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Municipal
        '
        Me.btn_Municipal.Location = New System.Drawing.Point(322, 290)
        Me.btn_Municipal.Name = "btn_Municipal"
        Me.btn_Municipal.Size = New System.Drawing.Size(126, 23)
        Me.btn_Municipal.TabIndex = 47
        Me.btn_Municipal.Text = "Guardar"
        Me.btn_Municipal.UseVisualStyleBackColor = True
        '
        'rtbox_comentario
        '
        Me.rtbox_comentario.Location = New System.Drawing.Point(116, 177)
        Me.rtbox_comentario.Name = "rtbox_comentario"
        Me.rtbox_comentario.Size = New System.Drawing.Size(332, 96)
        Me.rtbox_comentario.TabIndex = 46
        Me.rtbox_comentario.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 177)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Comentario:"
        '
        'cbox_estMun
        '
        Me.cbox_estMun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_estMun.FormattingEnabled = True
        Me.cbox_estMun.Location = New System.Drawing.Point(116, 136)
        Me.cbox_estMun.Name = "cbox_estMun"
        Me.cbox_estMun.Size = New System.Drawing.Size(332, 21)
        Me.cbox_estMun.TabIndex = 44
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 139)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Estado:"
        '
        'cbox_instMun
        '
        Me.cbox_instMun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_instMun.FormattingEnabled = True
        Me.cbox_instMun.Location = New System.Drawing.Point(116, 98)
        Me.cbox_instMun.Name = "cbox_instMun"
        Me.cbox_instMun.Size = New System.Drawing.Size(332, 21)
        Me.cbox_instMun.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Instructor:"
        '
        'cbox_docMunicipal
        '
        Me.cbox_docMunicipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_docMunicipal.FormattingEnabled = True
        Me.cbox_docMunicipal.Location = New System.Drawing.Point(116, 59)
        Me.cbox_docMunicipal.Name = "cbox_docMunicipal"
        Me.cbox_docMunicipal.Size = New System.Drawing.Size(332, 21)
        Me.cbox_docMunicipal.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Documento:"
        '
        'tbox_codMunicipal
        '
        Me.tbox_codMunicipal.Location = New System.Drawing.Point(116, 21)
        Me.tbox_codMunicipal.Name = "tbox_codMunicipal"
        Me.tbox_codMunicipal.Size = New System.Drawing.Size(332, 20)
        Me.tbox_codMunicipal.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Codigo:"
        '
        'ExamenMunicipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 384)
        Me.Controls.Add(Me.btn_Municipal)
        Me.Controls.Add(Me.rtbox_comentario)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbox_estMun)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbox_instMun)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbox_docMunicipal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbox_codMunicipal)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExamenMunicipal"
        Me.Text = "ExamenMunicipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Municipal As System.Windows.Forms.Button
    Friend WithEvents rtbox_comentario As System.Windows.Forms.RichTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbox_estMun As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbox_instMun As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbox_docMunicipal As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbox_codMunicipal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
