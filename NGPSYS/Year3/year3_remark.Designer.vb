<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class year3_remark
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
        btn3 = New Button()
        btn2 = New Button()
        MenuStrip1 = New MenuStrip()
        btn1 = New Button()
        Panel1 = New Panel()
        txtremarks = New TextBox()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn3
        ' 
        btn3.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btn3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn3.ForeColor = Color.White
        btn3.Location = New Point(617, 459)
        btn3.Name = "btn3"
        btn3.Size = New Size(170, 63)
        btn3.TabIndex = 245
        btn3.Text = "Submit"
        btn3.UseVisualStyleBackColor = False
        btn3.Visible = False
        ' 
        ' btn2
        ' 
        btn2.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btn2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn2.ForeColor = Color.White
        btn2.Location = New Point(618, 459)
        btn2.Name = "btn2"
        btn2.Size = New Size(170, 63)
        btn2.TabIndex = 244
        btn2.Text = "Submit"
        btn2.UseVisualStyleBackColor = False
        btn2.Visible = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(6), CByte(85), CByte(0))
        MenuStrip1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 243
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btn1
        ' 
        btn1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btn1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn1.ForeColor = Color.White
        btn1.Location = New Point(618, 459)
        btn1.Name = "btn1"
        btn1.Size = New Size(170, 63)
        btn1.TabIndex = 242
        btn1.Text = "Submit"
        btn1.UseVisualStyleBackColor = False
        btn1.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(txtremarks)
        Panel1.Location = New Point(12, 96)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(776, 354)
        Panel1.TabIndex = 241
        ' 
        ' txtremarks
        ' 
        txtremarks.Location = New Point(19, 19)
        txtremarks.Multiline = True
        txtremarks.Name = "txtremarks"
        txtremarks.Size = New Size(735, 314)
        txtremarks.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.orgicon
        PictureBox1.Location = New Point(8, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 240
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(65, 49)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 34)
        Label7.TabIndex = 239
        Label7.Text = "Remarks"
        ' 
        ' year3_remark
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 528)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(MenuStrip1)
        Controls.Add(btn1)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Name = "year3_remark"
        StartPosition = FormStartPosition.CenterScreen
        Text = "year3_remark"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btn1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtremarks As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
End Class
