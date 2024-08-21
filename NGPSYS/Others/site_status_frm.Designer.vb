<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class site_status_frm
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
        Label7 = New Label()
        Panel3 = New Panel()
        txtAe = New TextBox()
        Label2 = New Label()
        Button3 = New Button()
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        Panel9 = New Panel()
        txtstatus = New TextBox()
        Label10 = New Label()
        dateupdated = New DateTimePicker()
        Panel2 = New Panel()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Panel3.SuspendLayout()
        Panel9.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(96, 16)
        Label7.Name = "Label7"
        Label7.Size = New Size(245, 34)
        Label7.TabIndex = 241
        Label7.Text = "Status of the Sites"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientActiveCaption
        Panel3.Controls.Add(txtAe)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(550, 31)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(186, 124)
        Panel3.TabIndex = 224
        ' 
        ' txtAe
        ' 
        txtAe.Location = New Point(16, 61)
        txtAe.Name = "txtAe"
        txtAe.Size = New Size(155, 27)
        txtAe.TabIndex = 7
        txtAe.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(16, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 20)
        Label2.TabIndex = 3
        Label2.Text = "Adopting Entity"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(605, 268)
        Button3.Name = "Button3"
        Button3.Size = New Size(170, 63)
        Button3.TabIndex = 243
        Button3.Text = "Submit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(18, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 20)
        Label1.TabIndex = 0
        Label1.Text = "Date Updated "
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
        MenuStrip1.Size = New Size(745, 24)
        MenuStrip1.TabIndex = 223
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.GradientActiveCaption
        Panel9.Controls.Add(txtstatus)
        Panel9.Controls.Add(Label10)
        Panel9.Location = New Point(325, 31)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(186, 124)
        Panel9.TabIndex = 222
        ' 
        ' txtstatus
        ' 
        txtstatus.Location = New Point(14, 61)
        txtstatus.Name = "txtstatus"
        txtstatus.Size = New Size(158, 27)
        txtstatus.TabIndex = 7
        txtstatus.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(14, 16)
        Label10.Name = "Label10"
        Label10.Size = New Size(57, 20)
        Label10.TabIndex = 3
        Label10.Text = "Status "
        ' 
        ' dateupdated
        ' 
        dateupdated.Location = New Point(15, 61)
        dateupdated.Name = "dateupdated"
        dateupdated.Size = New Size(250, 27)
        dateupdated.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(dateupdated)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(7, 31)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(278, 124)
        Panel2.TabIndex = 171
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(39, 73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(745, 174)
        Panel1.TabIndex = 244
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.orgicon
        PictureBox1.Location = New Point(39, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 242
        PictureBox1.TabStop = False
        ' 
        ' site_status_frm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(823, 343)
        Controls.Add(Label7)
        Controls.Add(Button3)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "site_status_frm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "site_status_frm"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtAe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtstatus As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dateupdated As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
