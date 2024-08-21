<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_maintenanceprotection
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
        Label7 = New Label()
        txtorg = New TextBox()
        Label8 = New Label()
        txtuniquecode = New TextBox()
        Label9 = New Label()
        Panel1 = New Panel()
        MenuStrip1 = New MenuStrip()
        Panel9 = New Panel()
        txtunit = New TextBox()
        Label10 = New Label()
        Panel7 = New Panel()
        accom = New TextBox()
        Label5 = New Label()
        Panel6 = New Panel()
        totaltarget = New TextBox()
        Label4 = New Label()
        Panel5 = New Panel()
        totalcost = New TextBox()
        Label3 = New Label()
        Panel4 = New Panel()
        uwm = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        act1 = New TextBox()
        Label1 = New Label()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel9.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.orgicon
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 226
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(69, 14)
        Label7.Name = "Label7"
        Label7.Size = New Size(400, 34)
        Label7.TabIndex = 225
        Label7.Text = "Maintenance and Protection"
        ' 
        ' txtorg
        ' 
        txtorg.BackColor = Color.White
        txtorg.BorderStyle = BorderStyle.FixedSingle
        txtorg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtorg.Location = New Point(194, 108)
        txtorg.Name = "txtorg"
        txtorg.ReadOnly = True
        txtorg.Size = New Size(404, 27)
        txtorg.TabIndex = 224
        txtorg.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(10, 73)
        Label8.Name = "Label8"
        Label8.Size = New Size(167, 20)
        Label8.TabIndex = 221
        Label8.Text = "Project Unique Code :"
        ' 
        ' txtuniquecode
        ' 
        txtuniquecode.BackColor = Color.White
        txtuniquecode.BorderStyle = BorderStyle.FixedSingle
        txtuniquecode.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtuniquecode.Location = New Point(195, 72)
        txtuniquecode.Name = "txtuniquecode"
        txtuniquecode.ReadOnly = True
        txtuniquecode.Size = New Size(403, 27)
        txtuniquecode.TabIndex = 223
        txtuniquecode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(12, 111)
        Label9.Name = "Label9"
        Label9.Size = New Size(175, 20)
        Label9.TabIndex = 222
        Label9.Text = "Name of Implementer :"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(15, 157)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(977, 174)
        Panel1.TabIndex = 228
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
        MenuStrip1.Size = New Size(977, 24)
        MenuStrip1.TabIndex = 223
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.GradientActiveCaption
        Panel9.Controls.Add(txtunit)
        Panel9.Controls.Add(Label10)
        Panel9.Location = New Point(454, 31)
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
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.GradientActiveCaption
        Panel7.Controls.Add(accom)
        Panel7.Controls.Add(Label5)
        Panel7.Location = New Point(796, 30)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(170, 125)
        Panel7.TabIndex = 174
        ' 
        ' accom
        ' 
        accom.Location = New Point(5, 79)
        accom.Name = "accom"
        accom.Size = New Size(158, 27)
        accom.TabIndex = 8
        accom.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(2, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(163, 20)
        Label5.TabIndex = 4
        Label5.Text = "% of Accomplishment"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.GradientActiveCaption
        Panel6.Controls.Add(totaltarget)
        Panel6.Controls.Add(Label4)
        Panel6.Location = New Point(645, 31)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(145, 124)
        Panel6.TabIndex = 173
        ' 
        ' totaltarget
        ' 
        totaltarget.Location = New Point(9, 78)
        totaltarget.Name = "totaltarget"
        totaltarget.Size = New Size(129, 27)
        totaltarget.TabIndex = 7
        totaltarget.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(25, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 20)
        Label4.TabIndex = 3
        Label4.Text = "Total Target "
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.GradientActiveCaption
        Panel5.Controls.Add(totalcost)
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(263, 31)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(186, 124)
        Panel5.TabIndex = 172
        ' 
        ' totalcost
        ' 
        totalcost.Location = New Point(18, 78)
        totalcost.Name = "totalcost"
        totalcost.Size = New Size(158, 27)
        totalcost.TabIndex = 6
        totalcost.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(23, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 20)
        Label3.TabIndex = 2
        Label3.Text = "Total Contract Cost"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.GradientActiveCaption
        Panel4.Controls.Add(uwm)
        Panel4.Controls.Add(Label2)
        Panel4.Location = New Point(198, 31)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(59, 124)
        Panel4.TabIndex = 172
        ' 
        ' uwm
        ' 
        uwm.Location = New Point(6, 78)
        uwm.Name = "uwm"
        uwm.Size = New Size(46, 27)
        uwm.TabIndex = 6
        uwm.Text = "ha"
        uwm.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(3, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "UWM"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(act1)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(7, 31)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(186, 124)
        Panel2.TabIndex = 171
        ' 
        ' act1
        ' 
        act1.Location = New Point(12, 78)
        act1.Name = "act1"
        act1.Size = New Size(158, 27)
        act1.TabIndex = 4
        act1.Text = "Maintenance and Protection"
        act1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(47, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 20)
        Label1.TabIndex = 0
        Label1.Text = "ACTIVITIES"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(813, 343)
        Button3.Name = "Button3"
        Button3.Size = New Size(170, 63)
        Button3.TabIndex = 227
        Button3.Text = "Submit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Add_maintenanceprotection
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1030, 417)
        Controls.Add(Panel1)
        Controls.Add(Button3)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(txtorg)
        Controls.Add(Label8)
        Controls.Add(txtuniquecode)
        Controls.Add(Label9)
        Name = "Add_maintenanceprotection"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add_maintenanceprotection"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtorg As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtuniquecode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtunit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents accom As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents totaltarget As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents totalcost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents uwm As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents act1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
End Class
