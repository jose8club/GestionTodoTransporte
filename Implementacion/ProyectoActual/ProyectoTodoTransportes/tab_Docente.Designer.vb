<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tab_Docente
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
        Me.Tabs_docente = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Tabs_docente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabs_docente
        '
        Me.Tabs_docente.Controls.Add(Me.TabPage1)
        Me.Tabs_docente.Controls.Add(Me.TabPage2)
        Me.Tabs_docente.Location = New System.Drawing.Point(12, 12)
        Me.Tabs_docente.Name = "Tabs_docente"
        Me.Tabs_docente.SelectedIndex = 0
        Me.Tabs_docente.Size = New System.Drawing.Size(683, 367)
        Me.Tabs_docente.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(675, 341)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Añadir Docente"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(675, 341)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Editar Docente"
        '
        'tab_Docente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 391)
        Me.Controls.Add(Me.Tabs_docente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tab_Docente"
        Me.Text = "tab_Docente"
        Me.Tabs_docente.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabs_docente As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class
