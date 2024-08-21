<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewprojectcost_frm
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
        Panel4 = New Panel()
        txtactual = New TextBox()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        Panel3 = New Panel()
        txtyear3 = New TextBox()
        Label2 = New Label()
        MenuStrip1 = New MenuStrip()
        Panel9 = New Panel()
        txtyear1 = New TextBox()
        Label10 = New Label()
        Panel7 = New Panel()
        txtyear2 = New TextBox()
        Label5 = New Label()
        Panel2 = New Panel()
        txttotalyear = New TextBox()
        Label1 = New Label()
        txtid = New TextBox()
        btndelete = New Button()
        txtuniquecode = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        txtorg = New TextBox()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel9.SuspendLayout()
        Panel7.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(21, 124)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(981, 750)
        Panel1.TabIndex = 311
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.GradientActiveCaption
        Panel4.Controls.Add(txtactual)
        Panel4.Controls.Add(Label3)
        Panel4.Location = New Point(7, 610)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(291, 124)
        Panel4.TabIndex = 225
        ' 
        ' txtactual
        ' 
        txtactual.Location = New Point(16, 61)
        txtactual.Name = "txtactual"
        txtactual.Size = New Size(249, 27)
        txtactual.TabIndex = 7
        txtactual.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(6, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 20)
        Label3.TabIndex = 3
        Label3.Text = "Actual Gross Amount"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(304, 31)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(669, 703)
        DataGridView1.TabIndex = 225
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientActiveCaption
        Panel3.Controls.Add(txtyear3)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(7, 464)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(291, 124)
        Panel3.TabIndex = 224
        ' 
        ' txtyear3
        ' 
        txtyear3.Location = New Point(16, 61)
        txtyear3.Name = "txtyear3"
        txtyear3.Size = New Size(249, 27)
        txtyear3.TabIndex = 7
        txtyear3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(6, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 3
        Label2.Text = "Year 3 Cost"
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
        MenuStrip1.Size = New Size(981, 24)
        MenuStrip1.TabIndex = 223
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.GradientActiveCaption
        Panel9.Controls.Add(txtyear1)
        Panel9.Controls.Add(Label10)
        Panel9.Location = New Point(7, 173)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(291, 124)
        Panel9.TabIndex = 222
        ' 
        ' txtyear1
        ' 
        txtyear1.Location = New Point(14, 61)
        txtyear1.Name = "txtyear1"
        txtyear1.Size = New Size(251, 27)
        txtyear1.TabIndex = 7
        txtyear1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(14, 16)
        Label10.Name = "Label10"
        Label10.Size = New Size(87, 20)
        Label10.TabIndex = 3
        Label10.Text = "Year 1 Cost"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.GradientActiveCaption
        Panel7.Controls.Add(txtyear2)
        Panel7.Controls.Add(Label5)
        Panel7.Location = New Point(7, 316)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(291, 125)
        Panel7.TabIndex = 174
        ' 
        ' txtyear2
        ' 
        txtyear2.Location = New Point(13, 59)
        txtyear2.Name = "txtyear2"
        txtyear2.Size = New Size(252, 27)
        txtyear2.TabIndex = 8
        txtyear2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(13, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 20)
        Label5.TabIndex = 4
        Label5.Text = "Year 2 Cost"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(txttotalyear)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(7, 31)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(291, 124)
        Panel2.TabIndex = 171
        ' 
        ' txttotalyear
        ' 
        txttotalyear.Location = New Point(13, 58)
        txttotalyear.Name = "txttotalyear"
        txttotalyear.Size = New Size(251, 27)
        txttotalyear.TabIndex = 8
        txttotalyear.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(18, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 20)
        Label1.TabIndex = 0
        Label1.Text = "Project Cost (3 years)"
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(737, 13)
        txtid.Name = "txtid"
        txtid.Size = New Size(125, 27)
        txtid.TabIndex = 320
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.IndianRed
        btndelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btndelete.ForeColor = SystemColors.Window
        btndelete.Location = New Point(773, 51)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(161, 61)
        btndelete.TabIndex = 319
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' txtuniquecode
        ' 
        txtuniquecode.BackColor = Color.White
        txtuniquecode.BorderStyle = BorderStyle.FixedSingle
        txtuniquecode.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtuniquecode.Location = New Point(202, 58)
        txtuniquecode.Name = "txtuniquecode"
        txtuniquecode.ReadOnly = True
        txtuniquecode.Size = New Size(306, 27)
        txtuniquecode.TabIndex = 316
        txtuniquecode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(21, 92)
        Label9.Name = "Label9"
        Label9.Size = New Size(175, 20)
        Label9.TabIndex = 315
        Label9.Text = "Name of Implementer :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(21, 65)
        Label8.Name = "Label8"
        Label8.Size = New Size(167, 20)
        Label8.TabIndex = 314
        Label8.Text = "Project Unique Code :"
        ' 
        ' txtorg
        ' 
        txtorg.BackColor = Color.White
        txtorg.BorderStyle = BorderStyle.FixedSingle
        txtorg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtorg.Location = New Point(202, 90)
        txtorg.Name = "txtorg"
        txtorg.ReadOnly = True
        txtorg.Size = New Size(306, 27)
        txtorg.TabIndex = 317
        txtorg.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.orgicon
        PictureBox1.Location = New Point(21, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 313
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(78, 17)
        Label7.Name = "Label7"
        Label7.Size = New Size(183, 34)
        Label7.TabIndex = 312
        Label7.Text = "Project Cost"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(577, 51)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 61)
        Button1.TabIndex = 318
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' viewprojectcost_frm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1023, 886)
        Controls.Add(Panel1)
        Controls.Add(txtid)
        Controls.Add(btndelete)
        Controls.Add(txtuniquecode)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(txtorg)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Name = "viewprojectcost_frm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "viewprojectcost_frm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtactual As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtyear3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtyear1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtyear2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents btndelete As Button
    Friend WithEvents txtuniquecode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtorg As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txttotalyear As TextBox
End Class
