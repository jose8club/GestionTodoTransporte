﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.MainMenu = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.lbl_Estado = New System.Windows.Forms.StatusStrip()
        Me.ESTADO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.MainMenu.SuspendLayout()
        Me.lbl_Estado.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.MainMenu.Controls.Add(Me.TabPage1)
        Me.MainMenu.Controls.Add(Me.TabPage2)
        Me.MainMenu.Controls.Add(Me.TabPage3)
        Me.MainMenu.Controls.Add(Me.TabPage4)
        Me.MainMenu.Controls.Add(Me.TabPage5)
        Me.MainMenu.Controls.Add(Me.TabPage6)
        Me.MainMenu.Controls.Add(Me.TabPage7)
        Me.MainMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.MainMenu.ItemSize = New System.Drawing.Size(25, 150)
        Me.MainMenu.Location = New System.Drawing.Point(21, 12)
        Me.MainMenu.Multiline = True
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.SelectedIndex = 0
        Me.MainMenu.Size = New System.Drawing.Size(912, 401)
        Me.MainMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.MainMenu.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Location = New System.Drawing.Point(154, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(754, 393)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Atención al Cliente"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Location = New System.Drawing.Point(154, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(754, 393)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Matrícula"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Location = New System.Drawing.Point(154, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(754, 393)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Profesores"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Location = New System.Drawing.Point(154, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(754, 393)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Encuesta de Calidad"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage5.Location = New System.Drawing.Point(154, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(754, 393)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Vehículos"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage6.Location = New System.Drawing.Point(154, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(754, 393)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Agregar Usuario"
        '
        'lbl_Estado
        '
        Me.lbl_Estado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ESTADO})
        Me.lbl_Estado.Location = New System.Drawing.Point(0, 428)
        Me.lbl_Estado.Name = "lbl_Estado"
        Me.lbl_Estado.Size = New System.Drawing.Size(945, 22)
        Me.lbl_Estado.TabIndex = 1
        Me.lbl_Estado.Text = "ESTADO"
        '
        'ESTADO
        '
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.Size = New System.Drawing.Size(124, 17)
        Me.ESTADO.Text = "ToolStripStatusLabel1"
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(154, 4)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(754, 393)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Clases"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 450)
        Me.Controls.Add(Me.lbl_Estado)
        Me.Controls.Add(Me.MainMenu)
        Me.Name = "Principal"
        Me.Text = "Sistema de Gestión TodoTransporte"
        Me.MainMenu.ResumeLayout(False)
        Me.lbl_Estado.ResumeLayout(False)
        Me.lbl_Estado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents lbl_Estado As System.Windows.Forms.StatusStrip
    Friend WithEvents ESTADO As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage

End Class
