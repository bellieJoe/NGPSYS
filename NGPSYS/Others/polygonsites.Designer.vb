<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class polygonsites
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
        PictureBox1 = New PictureBox()
        txtpolycode = New TextBox()
        Panel3 = New Panel()
        Label2 = New Label()
        Panel1 = New Panel()
        txtrandom = New TextBox()
        Label1 = New Label()
        Button3 = New Button()
        MenuStrip1 = New MenuStrip()
        Label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.orgicon
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 242
        PictureBox1.TabStop = False
        ' 
        ' txtpolycode
        ' 
        txtpolycode.Location = New Point(18, 61)
        txtpolycode.Name = "txtpolycode"
        txtpolycode.Size = New Size(242, 27)
        txtpolycode.TabIndex = 8
        txtpolycode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientActiveCaption
        Panel3.Controls.Add(txtpolycode)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(27, 132)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(278, 124)
        Panel3.TabIndex = 172
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(18, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 20)
        Label2.TabIndex = 0
        Label2.Text = "Polygon Code"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtrandom)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Location = New Point(12, 74)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(337, 356)
        Panel1.TabIndex = 243
        ' 
        ' txtrandom
        ' 
        txtrandom.Location = New Point(27, 62)
        txtrandom.Name = "txtrandom"
        txtrandom.ReadOnly = True
        txtrandom.Size = New Size(278, 27)
        txtrandom.TabIndex = 241
        txtrandom.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(27, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 20)
        Label1.TabIndex = 240
        Label1.Text = "Random Code"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(83, 272)
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
        MenuStrip1.Size = New Size(337, 24)
        MenuStrip1.TabIndex = 223
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(69, 14)
        Label7.Name = "Label7"
        Label7.Size = New Size(262, 34)
        Label7.TabIndex = 241
        Label7.Text = "Polygon Site Code"
        ' 
        ' polygonsites
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(365, 442)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        Name = "polygonsites"
        StartPosition = FormStartPosition.CenterScreen
        Text = "polygonsites"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtpolycode As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label7 As Label
    Friend WithEvents txtrandom As TextBox
    Friend WithEvents Label1 As Label
End Class
