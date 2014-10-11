<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.RegistrarCliente = New System.Windows.Forms.TabPage()
        Me.tbox_Telefono1 = New System.Windows.Forms.TextBox()
        Me.lbl_Telefono1 = New System.Windows.Forms.Label()
        Me.date_Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.btn_Guardar1 = New System.Windows.Forms.Button()
        Me.lbl_Nombre1 = New System.Windows.Forms.Label()
        Me.tbox_Observaciones1 = New System.Windows.Forms.RichTextBox()
        Me.tbox_Nombre1 = New System.Windows.Forms.TextBox()
        Me.lbl_Observaciones1 = New System.Windows.Forms.Label()
        Me.lbl_Fecha1 = New System.Windows.Forms.Label()
        Me.cbox_CursoInteres1 = New System.Windows.Forms.ComboBox()
        Me.lbl_CursoInteres1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl.SuspendLayout()
        Me.RegistrarCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.RegistrarCliente)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(451, 294)
        Me.TabControl.TabIndex = 0
        '
        'RegistrarCliente
        '
        Me.RegistrarCliente.Controls.Add(Me.tbox_Telefono1)
        Me.RegistrarCliente.Controls.Add(Me.lbl_Telefono1)
        Me.RegistrarCliente.Controls.Add(Me.date_Fecha1)
        Me.RegistrarCliente.Controls.Add(Me.btn_Guardar1)
        Me.RegistrarCliente.Controls.Add(Me.lbl_Nombre1)
        Me.RegistrarCliente.Controls.Add(Me.tbox_Observaciones1)
        Me.RegistrarCliente.Controls.Add(Me.tbox_Nombre1)
        Me.RegistrarCliente.Controls.Add(Me.lbl_Observaciones1)
        Me.RegistrarCliente.Controls.Add(Me.lbl_Fecha1)
        Me.RegistrarCliente.Controls.Add(Me.cbox_CursoInteres1)
        Me.RegistrarCliente.Controls.Add(Me.lbl_CursoInteres1)
        Me.RegistrarCliente.Location = New System.Drawing.Point(4, 22)
        Me.RegistrarCliente.Name = "RegistrarCliente"
        Me.RegistrarCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.RegistrarCliente.Size = New System.Drawing.Size(443, 268)
        Me.RegistrarCliente.TabIndex = 0
        Me.RegistrarCliente.Text = "Registrar Cliente"
        Me.RegistrarCliente.UseVisualStyleBackColor = True
        '
        'tbox_Telefono1
        '
        Me.tbox_Telefono1.Location = New System.Drawing.Point(145, 37)
        Me.tbox_Telefono1.Name = "tbox_Telefono1"
        Me.tbox_Telefono1.Size = New System.Drawing.Size(278, 20)
        Me.tbox_Telefono1.TabIndex = 20
        '
        'lbl_Telefono1
        '
        Me.lbl_Telefono1.AutoSize = True
        Me.lbl_Telefono1.Location = New System.Drawing.Point(16, 40)
        Me.lbl_Telefono1.Name = "lbl_Telefono1"
        Me.lbl_Telefono1.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Telefono1.TabIndex = 19
        Me.lbl_Telefono1.Text = "Telefono:"
        '
        'date_Fecha1
        '
        Me.date_Fecha1.Location = New System.Drawing.Point(145, 96)
        Me.date_Fecha1.Name = "date_Fecha1"
        Me.date_Fecha1.Size = New System.Drawing.Size(278, 20)
        Me.date_Fecha1.TabIndex = 11
        '
        'btn_Guardar1
        '
        Me.btn_Guardar1.Location = New System.Drawing.Point(348, 237)
        Me.btn_Guardar1.Name = "btn_Guardar1"
        Me.btn_Guardar1.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar1.TabIndex = 15
        Me.btn_Guardar1.Text = "Guardar"
        Me.btn_Guardar1.UseVisualStyleBackColor = True
        '
        'lbl_Nombre1
        '
        Me.lbl_Nombre1.AutoSize = True
        Me.lbl_Nombre1.Location = New System.Drawing.Point(16, 12)
        Me.lbl_Nombre1.Name = "lbl_Nombre1"
        Me.lbl_Nombre1.Size = New System.Drawing.Size(47, 13)
        Me.lbl_Nombre1.TabIndex = 9
        Me.lbl_Nombre1.Text = "Nombre:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tbox_Observaciones1
        '
        Me.tbox_Observaciones1.Location = New System.Drawing.Point(145, 128)
        Me.tbox_Observaciones1.Name = "tbox_Observaciones1"
        Me.tbox_Observaciones1.Size = New System.Drawing.Size(278, 103)
        Me.tbox_Observaciones1.TabIndex = 14
        Me.tbox_Observaciones1.Text = ""
        '
        'tbox_Nombre1
        '
        Me.tbox_Nombre1.Location = New System.Drawing.Point(145, 9)
        Me.tbox_Nombre1.Name = "tbox_Nombre1"
        Me.tbox_Nombre1.Size = New System.Drawing.Size(278, 20)
        Me.tbox_Nombre1.TabIndex = 10
        '
        'lbl_Observaciones1
        '
        Me.lbl_Observaciones1.AutoSize = True
        Me.lbl_Observaciones1.Location = New System.Drawing.Point(16, 131)
        Me.lbl_Observaciones1.Name = "lbl_Observaciones1"
        Me.lbl_Observaciones1.Size = New System.Drawing.Size(81, 13)
        Me.lbl_Observaciones1.TabIndex = 17
        Me.lbl_Observaciones1.Text = "Observaciones:"
        '
        'lbl_Fecha1
        '
        Me.lbl_Fecha1.AutoSize = True
        Me.lbl_Fecha1.Location = New System.Drawing.Point(16, 99)
        Me.lbl_Fecha1.Name = "lbl_Fecha1"
        Me.lbl_Fecha1.Size = New System.Drawing.Size(100, 13)
        Me.lbl_Fecha1.TabIndex = 12
        Me.lbl_Fecha1.Text = "Fecha de Atención:"
        '
        'cbox_CursoInteres1
        '
        Me.cbox_CursoInteres1.FormattingEnabled = True
        Me.cbox_CursoInteres1.Location = New System.Drawing.Point(145, 66)
        Me.cbox_CursoInteres1.Name = "cbox_CursoInteres1"
        Me.cbox_CursoInteres1.Size = New System.Drawing.Size(278, 21)
        Me.cbox_CursoInteres1.TabIndex = 13
        '
        'lbl_CursoInteres1
        '
        Me.lbl_CursoInteres1.AutoSize = True
        Me.lbl_CursoInteres1.Location = New System.Drawing.Point(16, 69)
        Me.lbl_CursoInteres1.Name = "lbl_CursoInteres1"
        Me.lbl_CursoInteres1.Size = New System.Drawing.Size(87, 13)
        Me.lbl_CursoInteres1.TabIndex = 16
        Me.lbl_CursoInteres1.Text = "Curso de Interés:"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(443, 268)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 319)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "Principal"
        Me.Text = "Sistema de Gestión TodoTransporte"
        Me.TabControl.ResumeLayout(False)
        Me.RegistrarCliente.ResumeLayout(False)
        Me.RegistrarCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents RegistrarCliente As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tbox_Telefono1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Telefono1 As System.Windows.Forms.Label
    Friend WithEvents date_Fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Guardar1 As System.Windows.Forms.Button
    Friend WithEvents lbl_Nombre1 As System.Windows.Forms.Label
    Friend WithEvents tbox_Observaciones1 As System.Windows.Forms.RichTextBox
    Friend WithEvents tbox_Nombre1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Observaciones1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha1 As System.Windows.Forms.Label
    Friend WithEvents cbox_CursoInteres1 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_CursoInteres1 As System.Windows.Forms.Label
End Class
