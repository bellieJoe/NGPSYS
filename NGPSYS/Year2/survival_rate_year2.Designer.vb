<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class survival_rate_year2
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
        Label1 = New Label()
        txtsurvival = New TextBox()
        btnsub1 = New Button()
        btnsub2 = New Button()
        btnsub3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 20)
        Label1.TabIndex = 0
        Label1.Text = "Survival Rate :"
        ' 
        ' txtsurvival
        ' 
        txtsurvival.Location = New Point(138, 57)
        txtsurvival.Name = "txtsurvival"
        txtsurvival.Size = New Size(179, 27)
        txtsurvival.TabIndex = 1
        ' 
        ' btnsub1
        ' 
        btnsub1.Location = New Point(223, 108)
        btnsub1.Name = "btnsub1"
        btnsub1.Size = New Size(94, 29)
        btnsub1.TabIndex = 2
        btnsub1.Text = "Submit"
        btnsub1.UseVisualStyleBackColor = True
        btnsub1.Visible = False
        ' 
        ' btnsub2
        ' 
        btnsub2.Location = New Point(101, 108)
        btnsub2.Name = "btnsub2"
        btnsub2.Size = New Size(94, 29)
        btnsub2.TabIndex = 3
        btnsub2.Text = "Submit"
        btnsub2.UseVisualStyleBackColor = True
        btnsub2.Visible = False
        ' 
        ' btnsub3
        ' 
        btnsub3.Location = New Point(-8, 108)
        btnsub3.Name = "btnsub3"
        btnsub3.Size = New Size(94, 29)
        btnsub3.TabIndex = 4
        btnsub3.Text = "Submit"
        btnsub3.UseVisualStyleBackColor = True
        btnsub3.Visible = False
        ' 
        ' survival_rate_year2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(347, 169)
        Controls.Add(btnsub3)
        Controls.Add(btnsub2)
        Controls.Add(btnsub1)
        Controls.Add(txtsurvival)
        Controls.Add(Label1)
        Name = "survival_rate_year2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "survival_rate_year2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtsurvival As TextBox
    Friend WithEvents btnsub1 As Button
    Friend WithEvents btnsub2 As Button
    Friend WithEvents btnsub3 As Button
End Class
