<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class status_frm
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
        Button3 = New Button()
        MenuStrip1 = New MenuStrip()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        txtcip = New TextBox()
        Panel7 = New Panel()
        Panel2 = New Panel()
        txtunder = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(88, 15)
        Label7.Name = "Label7"
        Label7.Size = New Size(569, 34)
        Label7.TabIndex = 237
        Label7.Text = "Status of Registry to the Book of Accounts"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(472, 268)
        Button3.Name = "Button3"
        Button3.Size = New Size(170, 63)
        Button3.TabIndex = 239
        Button3.Text = "Submit"
        Button3.UseVisualStyleBackColor = False
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
        MenuStrip1.Size = New Size(631, 24)
        MenuStrip1.TabIndex = 223
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(Panel7)
        Panel1.Location = New Point(31, 73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(631, 174)
        Panel1.TabIndex = 240
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.orgicon
        PictureBox1.Location = New Point(31, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 238
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(13, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 20)
        Label5.TabIndex = 4
        Label5.Text = "Amount still in CIP"
        ' 
        ' txtcip
        ' 
        txtcip.Location = New Point(13, 59)
        txtcip.Name = "txtcip"
        txtcip.Size = New Size(266, 27)
        txtcip.TabIndex = 8
        txtcip.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.GradientActiveCaption
        Panel7.Controls.Add(txtcip)
        Panel7.Controls.Add(Label5)
        Panel7.Location = New Point(11, 34)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(291, 125)
        Panel7.TabIndex = 174
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(txtunder)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(320, 34)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(291, 125)
        Panel2.TabIndex = 175
        ' 
        ' txtunder
        ' 
        txtunder.Location = New Point(13, 59)
        txtunder.Name = "txtunder"
        txtunder.Size = New Size(266, 27)
        txtunder.TabIndex = 8
        txtunder.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(13, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 20)
        Label1.TabIndex = 4
        Label1.Text = "Amount Underdevelopment"
        ' 
        ' status_frm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(709, 343)
        Controls.Add(Label7)
        Controls.Add(Button3)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "status_frm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "status_frm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtunder As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtcip As TextBox
    Friend WithEvents Label5 As Label
End Class
