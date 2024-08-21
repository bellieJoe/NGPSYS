<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class totalprojectcost
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
        Label2 = New Label()
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        MenuStrip1 = New MenuStrip()
        Panel9 = New Panel()
        txtunit = New TextBox()
        Label10 = New Label()
        Button1 = New Button()
        Panel7 = New Panel()
        txttotalcost = New TextBox()
        Label5 = New Label()
        Panel5 = New Panel()
        txtnoseed = New TextBox()
        Label3 = New Label()
        Panel2 = New Panel()
        cmbcom = New ComboBox()
        Label6 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel9.SuspendLayout()
        Panel7.SuspendLayout()
        Panel5.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.newcom
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(47, 39)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bauhaus 93", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(66, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(204, 39)
        Label2.TabIndex = 22
        Label2.Text = "Project Cost"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(12, 59)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(758, 249)
        Panel1.TabIndex = 216
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(17, 186)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 27)
        TextBox1.TabIndex = 224
        TextBox1.Visible = False
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
        MenuStrip1.Size = New Size(758, 24)
        MenuStrip1.TabIndex = 223
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.GradientActiveCaption
        Panel9.Controls.Add(txtunit)
        Panel9.Controls.Add(Label10)
        Panel9.Location = New Point(387, 27)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(186, 124)
        Panel9.TabIndex = 222
        ' 
        ' txtunit
        ' 
        txtunit.Location = New Point(14, 78)
        txtunit.Name = "txtunit"
        txtunit.Size = New Size(158, 27)
        txtunit.TabIndex = 7
        txtunit.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(54, 17)
        Label10.Name = "Label10"
        Label10.Size = New Size(74, 20)
        Label10.TabIndex = 3
        Label10.Text = "Unit Cost"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(579, 168)
        Button1.Name = "Button1"
        Button1.Size = New Size(170, 63)
        Button1.TabIndex = 221
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.GradientActiveCaption
        Panel7.Controls.Add(txttotalcost)
        Panel7.Controls.Add(Label5)
        Panel7.Location = New Point(579, 27)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(170, 125)
        Panel7.TabIndex = 174
        ' 
        ' txttotalcost
        ' 
        txttotalcost.Location = New Point(5, 79)
        txttotalcost.Name = "txttotalcost"
        txttotalcost.Size = New Size(158, 27)
        txttotalcost.TabIndex = 8
        txttotalcost.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(43, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 20)
        Label5.TabIndex = 4
        Label5.Text = "Total Cost"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.GradientActiveCaption
        Panel5.Controls.Add(txtnoseed)
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(195, 27)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(186, 124)
        Panel5.TabIndex = 172
        ' 
        ' txtnoseed
        ' 
        txtnoseed.Location = New Point(18, 78)
        txtnoseed.Name = "txtnoseed"
        txtnoseed.Size = New Size(158, 27)
        txtnoseed.TabIndex = 6
        txtnoseed.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(35, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 20)
        Label3.TabIndex = 2
        Label3.Text = "No. of Seedlings"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(cmbcom)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(3, 27)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(186, 124)
        Panel2.TabIndex = 171
        ' 
        ' cmbcom
        ' 
        cmbcom.FormattingEnabled = True
        cmbcom.Location = New Point(14, 77)
        cmbcom.Name = "cmbcom"
        cmbcom.Size = New Size(151, 28)
        cmbcom.TabIndex = 224
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(42, 16)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 20)
        Label6.TabIndex = 0
        Label6.Text = "Commodity"
        ' 
        ' totalprojectcost
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(791, 317)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Name = "totalprojectcost"
        StartPosition = FormStartPosition.CenterScreen
        Text = "totalprojectcost"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtunit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txttotalcost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtnoseed As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbcom As ComboBox
    Friend WithEvents TextBox1 As TextBox
End Class
