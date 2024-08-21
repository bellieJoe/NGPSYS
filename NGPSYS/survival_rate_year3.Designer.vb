<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class survival_rate_year3
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
        btnsub3 = New Button()
        btnsub2 = New Button()
        btnsub1 = New Button()
        txtsurvival = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnsub3
        ' 
        btnsub3.Location = New Point(218, 95)
        btnsub3.Name = "btnsub3"
        btnsub3.Size = New Size(94, 29)
        btnsub3.TabIndex = 9
        btnsub3.Text = "Submit"
        btnsub3.UseVisualStyleBackColor = True
        btnsub3.Visible = False
        ' 
        ' btnsub2
        ' 
        btnsub2.Location = New Point(219, 95)
        btnsub2.Name = "btnsub2"
        btnsub2.Size = New Size(94, 29)
        btnsub2.TabIndex = 8
        btnsub2.Text = "Submit"
        btnsub2.UseVisualStyleBackColor = True
        btnsub2.Visible = False
        ' 
        ' btnsub1
        ' 
        btnsub1.Location = New Point(220, 95)
        btnsub1.Name = "btnsub1"
        btnsub1.Size = New Size(94, 29)
        btnsub1.TabIndex = 7
        btnsub1.Text = "Submit"
        btnsub1.UseVisualStyleBackColor = True
        btnsub1.Visible = False
        ' 
        ' txtsurvival
        ' 
        txtsurvival.Location = New Point(137, 44)
        txtsurvival.Name = "txtsurvival"
        txtsurvival.Size = New Size(179, 27)
        txtsurvival.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 20)
        Label1.TabIndex = 5
        Label1.Text = "Survival Rate :"
        ' 
        ' survival_rate_year3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 169)
        Controls.Add(btnsub3)
        Controls.Add(btnsub2)
        Controls.Add(btnsub1)
        Controls.Add(txtsurvival)
        Controls.Add(Label1)
        Name = "survival_rate_year3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "survival_rate_year3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnsub3 As Button
    Friend WithEvents btnsub2 As Button
    Friend WithEvents btnsub1 As Button
    Friend WithEvents txtsurvival As TextBox
    Friend WithEvents Label1 As Label
End Class
