<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projectcost_frm
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
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        txtprojectcost = New TextBox()
        Panel2 = New Panel()
        Panel1 = New Panel()
        Panel5 = New Panel()
        txtyear3 = New TextBox()
        Label4 = New Label()
        Panel4 = New Panel()
        txtyear2 = New TextBox()
        Label3 = New Label()
        Panel3 = New Panel()
        txtyear1 = New TextBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Panel6 = New Panel()
        txtactual = New TextBox()
        Label5 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(88, 13)
        Label7.Name = "Label7"
        Label7.Size = New Size(191, 34)
        Label7.TabIndex = 237
        Label7.Text = "Project Cost "
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(379, 348)
        Button3.Name = "Button3"
        Button3.Size = New Size(170, 63)
        Button3.TabIndex = 239
        Button3.Text = "Submit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(18, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 20)
        Label1.TabIndex = 0
        Label1.Text = "Project Cost  (3 Years)"
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
        MenuStrip1.Size = New Size(637, 24)
        MenuStrip1.TabIndex = 223
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' txtprojectcost
        ' 
        txtprojectcost.Location = New Point(18, 61)
        txtprojectcost.Name = "txtprojectcost"
        txtprojectcost.Size = New Size(242, 27)
        txtprojectcost.TabIndex = 8
        txtprojectcost.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(txtprojectcost)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(327, 36)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(278, 124)
        Panel2.TabIndex = 171
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(31, 73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(637, 468)
        Panel1.TabIndex = 240
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.GradientActiveCaption
        Panel5.Controls.Add(txtyear3)
        Panel5.Controls.Add(Label4)
        Panel5.Location = New Point(22, 323)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(278, 124)
        Panel5.TabIndex = 172
        ' 
        ' txtyear3
        ' 
        txtyear3.Location = New Point(18, 61)
        txtyear3.Name = "txtyear3"
        txtyear3.Size = New Size(242, 27)
        txtyear3.TabIndex = 8
        txtyear3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(18, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 0
        Label4.Text = "Year 3"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.GradientActiveCaption
        Panel4.Controls.Add(txtyear2)
        Panel4.Controls.Add(Label3)
        Panel4.Location = New Point(22, 178)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(278, 124)
        Panel4.TabIndex = 172
        ' 
        ' txtyear2
        ' 
        txtyear2.Location = New Point(18, 61)
        txtyear2.Name = "txtyear2"
        txtyear2.Size = New Size(242, 27)
        txtyear2.TabIndex = 8
        txtyear2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(18, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 20)
        Label3.TabIndex = 0
        Label3.Text = "Year 2"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientActiveCaption
        Panel3.Controls.Add(txtyear1)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(22, 36)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(278, 124)
        Panel3.TabIndex = 172
        ' 
        ' txtyear1
        ' 
        txtyear1.Location = New Point(18, 61)
        txtyear1.Name = "txtyear1"
        txtyear1.Size = New Size(242, 27)
        txtyear1.TabIndex = 8
        txtyear1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(18, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 20)
        Label2.TabIndex = 0
        Label2.Text = "Year 1"
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
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.GradientActiveCaption
        Panel6.Controls.Add(txtactual)
        Panel6.Controls.Add(Label5)
        Panel6.Location = New Point(327, 178)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(278, 124)
        Panel6.TabIndex = 173
        ' 
        ' txtactual
        ' 
        txtactual.Location = New Point(18, 61)
        txtactual.Name = "txtactual"
        txtactual.Size = New Size(242, 27)
        txtactual.TabIndex = 8
        txtactual.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(18, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 20)
        Label5.TabIndex = 0
        Label5.Text = "Actual Gross Amount"
        ' 
        ' projectcost_frm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(711, 568)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "projectcost_frm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "projectcost_frm"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents txtprojectcost As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtyear3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtyear2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtyear1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtactual As TextBox
    Friend WithEvents Label5 As Label
End Class
