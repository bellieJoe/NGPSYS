<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class finalsurvivalrate_frm
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
        btnsub1 = New Button()
        txtsurvival = New TextBox()
        Label1 = New Label()
        btnsub2 = New Button()
        btnsub3 = New Button()
        btnyear3 = New Button()
        SuspendLayout()
        ' 
        ' btnsub1
        ' 
        btnsub1.Location = New Point(112, 82)
        btnsub1.Name = "btnsub1"
        btnsub1.Size = New Size(94, 29)
        btnsub1.TabIndex = 14
        btnsub1.Text = "Submit"
        btnsub1.UseVisualStyleBackColor = True
        ' 
        ' txtsurvival
        ' 
        txtsurvival.Location = New Point(137, 44)
        txtsurvival.Name = "txtsurvival"
        txtsurvival.Size = New Size(179, 27)
        txtsurvival.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 20)
        Label1.TabIndex = 10
        Label1.Text = "Survival Rate :"
        ' 
        ' btnsub2
        ' 
        btnsub2.Location = New Point(112, 117)
        btnsub2.Name = "btnsub2"
        btnsub2.Size = New Size(94, 29)
        btnsub2.TabIndex = 15
        btnsub2.Text = "Submit"
        btnsub2.UseVisualStyleBackColor = True
        btnsub2.Visible = False
        ' 
        ' btnsub3
        ' 
        btnsub3.Location = New Point(12, 117)
        btnsub3.Name = "btnsub3"
        btnsub3.Size = New Size(94, 29)
        btnsub3.TabIndex = 16
        btnsub3.Text = "Submit"
        btnsub3.UseVisualStyleBackColor = True
        btnsub3.Visible = False
        ' 
        ' btnyear3
        ' 
        btnyear3.Location = New Point(222, 117)
        btnyear3.Name = "btnyear3"
        btnyear3.Size = New Size(94, 29)
        btnyear3.TabIndex = 17
        btnyear3.Text = "Submit"
        btnyear3.UseVisualStyleBackColor = True
        btnyear3.Visible = False
        ' 
        ' finalsurvivalrate_frm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 169)
        Controls.Add(btnyear3)
        Controls.Add(btnsub3)
        Controls.Add(btnsub2)
        Controls.Add(btnsub1)
        Controls.Add(txtsurvival)
        Controls.Add(Label1)
        Name = "finalsurvivalrate_frm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "finalsurvivalrate_frm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnsub1 As Button
    Friend WithEvents txtsurvival As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnsub2 As Button
    Friend WithEvents btnsub3 As Button
    Friend WithEvents btnyear3 As Button
End Class
