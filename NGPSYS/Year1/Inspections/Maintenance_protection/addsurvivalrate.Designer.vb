<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addsurvivalrate
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
        Panel1 = New Panel()
        MenuStrip1 = New MenuStrip()
        Panel9 = New Panel()
        txtsurvive = New TextBox()
        Label10 = New Label()
        Button1 = New Button()
        Panel7 = New Panel()
        txtsurvivalrate = New TextBox()
        Label5 = New Label()
        Panel5 = New Panel()
        txtplanted = New TextBox()
        Label3 = New Label()
        Panel4 = New Panel()
        txtarea = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        cmbcom = New ComboBox()
        Label1 = New Label()
        Label7 = New Label()
        MenuStrip2 = New MenuStrip()
        Panel1.SuspendLayout()
        Panel9.SuspendLayout()
        Panel7.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(12, 74)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(977, 249)
        Panel1.TabIndex = 217
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        MenuStrip1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(977, 30)
        MenuStrip1.TabIndex = 223
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.GradientActiveCaption
        Panel9.Controls.Add(txtsurvive)
        Panel9.Controls.Add(Label10)
        Panel9.Location = New Point(580, 24)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(186, 124)
        Panel9.TabIndex = 222
        ' 
        ' txtsurvive
        ' 
        txtsurvive.Location = New Point(14, 78)
        txtsurvive.Name = "txtsurvive"
        txtsurvive.Size = New Size(158, 27)
        txtsurvive.TabIndex = 7
        txtsurvive.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(10, 16)
        Label10.Name = "Label10"
        Label10.Size = New Size(172, 20)
        Label10.TabIndex = 3
        Label10.Text = "No. of Seedling Survive"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(796, 173)
        Button1.Name = "Button1"
        Button1.Size = New Size(170, 63)
        Button1.TabIndex = 221
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.GradientActiveCaption
        Panel7.Controls.Add(txtsurvivalrate)
        Panel7.Controls.Add(Label5)
        Panel7.Location = New Point(796, 24)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(170, 125)
        Panel7.TabIndex = 174
        ' 
        ' txtsurvivalrate
        ' 
        txtsurvivalrate.Location = New Point(6, 79)
        txtsurvivalrate.Name = "txtsurvivalrate"
        txtsurvivalrate.ReadOnly = True
        txtsurvivalrate.Size = New Size(158, 27)
        txtsurvivalrate.TabIndex = 8
        txtsurvivalrate.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(30, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 20)
        Label5.TabIndex = 4
        Label5.Text = "Survival Rate "
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.GradientActiveCaption
        Panel5.Controls.Add(txtplanted)
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(362, 24)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(186, 124)
        Panel5.TabIndex = 172
        ' 
        ' txtplanted
        ' 
        txtplanted.Location = New Point(18, 78)
        txtplanted.Name = "txtplanted"
        txtplanted.Size = New Size(158, 27)
        txtplanted.TabIndex = 6
        txtplanted.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(6, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(177, 20)
        Label3.TabIndex = 2
        Label3.Text = " No. of Seedling Planted"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.GradientActiveCaption
        Panel4.Controls.Add(txtarea)
        Panel4.Controls.Add(Label2)
        Panel4.Location = New Point(227, 24)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(103, 124)
        Panel4.TabIndex = 172
        ' 
        ' txtarea
        ' 
        txtarea.Location = New Point(15, 78)
        txtarea.Name = "txtarea"
        txtarea.Size = New Size(71, 27)
        txtarea.TabIndex = 6
        txtarea.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(3, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 20)
        Label2.TabIndex = 1
        Label2.Text = "Area Planted"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(cmbcom)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(3, 23)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(203, 124)
        Panel2.TabIndex = 171
        ' 
        ' cmbcom
        ' 
        cmbcom.DropDownStyle = ComboBoxStyle.DropDownList
        cmbcom.FormattingEnabled = True
        cmbcom.Location = New Point(13, 78)
        cmbcom.Name = "cmbcom"
        cmbcom.Size = New Size(178, 28)
        cmbcom.TabIndex = 226
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(50, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 0
        Label1.Text = "Commodity"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(12, 34)
        Label7.Name = "Label7"
        Label7.Size = New Size(184, 34)
        Label7.TabIndex = 226
        Label7.Text = "Survival Rate"
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.FromArgb(CByte(6), CByte(85), CByte(0))
        MenuStrip2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Padding = New Padding(6, 3, 0, 3)
        MenuStrip2.RenderMode = ToolStripRenderMode.Professional
        MenuStrip2.Size = New Size(1018, 24)
        MenuStrip2.TabIndex = 227
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' addsurvivalrate
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1018, 338)
        Controls.Add(MenuStrip2)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        Name = "addsurvivalrate"
        StartPosition = FormStartPosition.CenterScreen
        Text = "addsurvivalrate"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtsurvive As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtsurvivalrate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtplanted As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtarea As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents cmbcom As ComboBox
End Class
