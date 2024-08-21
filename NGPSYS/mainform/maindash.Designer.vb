<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class maindash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(maindash))
        Panel1 = New Panel()
        Button5 = New Button()
        btnAdminNav = New Button()
        Button6 = New Button()
        Button8 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel4 = New Panel()
        txtusername = New TextBox()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel7 = New Panel()
        MenuStrip1 = New MenuStrip()
        AddOrganizationToolStripMenuItem = New ToolStripMenuItem()
        AddUserToolStripMenuItem1 = New ToolStripMenuItem()
        AddNewContractToolStripMenuItem = New ToolStripMenuItem()
        AddOrganizationToolStripMenuItem1 = New ToolStripMenuItem()
        AddComponentToolStripMenuItem = New ToolStripMenuItem()
        AddCommodityToolStripMenuItem = New ToolStripMenuItem()
        AddToolStripMenuItem = New ToolStripMenuItem()
        AddNewTenureToolStripMenuItem = New ToolStripMenuItem()
        Panel8 = New Panel()
        MenuStrip2 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripMenuItem()
        ToolStripMenuItem6 = New ToolStripMenuItem()
        Panel3 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        MenuStrip1.SuspendLayout()
        Panel8.SuspendLayout()
        MenuStrip2.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(34), CByte(47), CByte(62))
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(btnAdminNav)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel7)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(189, 932)
        Panel1.TabIndex = 0
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(75, 342)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 12
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        Button5.Visible = False
        ' 
        ' btnAdminNav
        ' 
        btnAdminNav.Cursor = Cursors.Hand
        btnAdminNav.Dock = DockStyle.Top
        btnAdminNav.FlatAppearance.BorderSize = 0
        btnAdminNav.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(179), CByte(55), CByte(113))
        btnAdminNav.FlatStyle = FlatStyle.Flat
        btnAdminNav.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnAdminNav.Image = CType(resources.GetObject("btnAdminNav.Image"), Image)
        btnAdminNav.ImageAlign = ContentAlignment.MiddleLeft
        btnAdminNav.Location = New Point(0, 266)
        btnAdminNav.Name = "btnAdminNav"
        btnAdminNav.Padding = New Padding(5, 0, 0, 0)
        btnAdminNav.Size = New Size(189, 35)
        btnAdminNav.TabIndex = 11
        btnAdminNav.Text = "   Admin"
        btnAdminNav.TextAlign = ContentAlignment.MiddleLeft
        btnAdminNav.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAdminNav.UseVisualStyleBackColor = True
        btnAdminNav.Visible = False
        ' 
        ' Button6
        ' 
        Button6.Cursor = Cursors.Hand
        Button6.Dock = DockStyle.Top
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(179), CByte(55), CByte(113))
        Button6.FlatStyle = FlatStyle.Flat
        Button6.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.ImageAlign = ContentAlignment.MiddleLeft
        Button6.Location = New Point(0, 231)
        Button6.Name = "Button6"
        Button6.Padding = New Padding(5, 0, 0, 0)
        Button6.Size = New Size(189, 35)
        Button6.TabIndex = 7
        Button6.Text = "   Maintenance"
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.TextImageRelation = TextImageRelation.ImageBeforeText
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Cursor = Cursors.Hand
        Button8.Dock = DockStyle.Bottom
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(179), CByte(55), CByte(113))
        Button8.FlatStyle = FlatStyle.Flat
        Button8.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button8.Image = CType(resources.GetObject("Button8.Image"), Image)
        Button8.ImageAlign = ContentAlignment.MiddleLeft
        Button8.Location = New Point(0, 904)
        Button8.Name = "Button8"
        Button8.Padding = New Padding(5, 0, 0, 0)
        Button8.Size = New Size(189, 28)
        Button8.TabIndex = 9
        Button8.Text = "  Logout"
        Button8.TextAlign = ContentAlignment.MiddleLeft
        Button8.TextImageRelation = TextImageRelation.ImageBeforeText
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.Dock = DockStyle.Top
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(179), CByte(55), CByte(113))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(0, 199)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(5, 0, 0, 0)
        Button3.Size = New Size(189, 32)
        Button3.TabIndex = 4
        Button3.Text = "   Completed Projects"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Dock = DockStyle.Top
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(179), CByte(55), CByte(113))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(0, 167)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(5, 0, 0, 0)
        Button2.Size = New Size(189, 32)
        Button2.TabIndex = 3
        Button2.Text = "   On-going Projects"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Dock = DockStyle.Top
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(179), CByte(55), CByte(113))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(0, 135)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(5, 0, 0, 0)
        Button1.Size = New Size(189, 32)
        Button1.TabIndex = 2
        Button1.Text = "   Dashboard"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(txtusername)
        Panel4.Controls.Add(PictureBox1)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 32)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(189, 103)
        Panel4.TabIndex = 1
        ' 
        ' txtusername
        ' 
        txtusername.BackColor = Color.FromArgb(CByte(34), CByte(47), CByte(62))
        txtusername.BorderStyle = BorderStyle.None
        txtusername.Font = New Font("Bauhaus 93", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtusername.ForeColor = Color.White
        txtusername.Location = New Point(4, 61)
        txtusername.Multiline = True
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(180, 37)
        txtusername.TabIndex = 59
        txtusername.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.login
        PictureBox1.Location = New Point(70, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(52, 47)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 53
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(16), CByte(172), CByte(132))
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(189, 32)
        Panel2.TabIndex = 0
        ' 
        ' Panel7
        ' 
        Panel7.BackgroundImageLayout = ImageLayout.None
        Panel7.Controls.Add(MenuStrip1)
        Panel7.Controls.Add(Panel8)
        Panel7.Location = New Point(70, 237)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(72, 43)
        Panel7.TabIndex = 10
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(34), CByte(47), CByte(62))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AddOrganizationToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(72, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "Maintenance"
        ' 
        ' AddOrganizationToolStripMenuItem
        ' 
        AddOrganizationToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddUserToolStripMenuItem1, AddNewContractToolStripMenuItem, AddOrganizationToolStripMenuItem1, AddComponentToolStripMenuItem, AddCommodityToolStripMenuItem, AddToolStripMenuItem, AddNewTenureToolStripMenuItem})
        AddOrganizationToolStripMenuItem.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        AddOrganizationToolStripMenuItem.ForeColor = Color.White
        AddOrganizationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        AddOrganizationToolStripMenuItem.Name = "AddOrganizationToolStripMenuItem"
        AddOrganizationToolStripMenuItem.Size = New Size(12, 20)
        ' 
        ' AddUserToolStripMenuItem1
        ' 
        AddUserToolStripMenuItem1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        AddUserToolStripMenuItem1.ForeColor = Color.White
        AddUserToolStripMenuItem1.Name = "AddUserToolStripMenuItem1"
        AddUserToolStripMenuItem1.Size = New Size(195, 22)
        AddUserToolStripMenuItem1.Text = "Add New User"
        ' 
        ' AddNewContractToolStripMenuItem
        ' 
        AddNewContractToolStripMenuItem.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        AddNewContractToolStripMenuItem.ForeColor = Color.White
        AddNewContractToolStripMenuItem.Name = "AddNewContractToolStripMenuItem"
        AddNewContractToolStripMenuItem.Size = New Size(195, 22)
        AddNewContractToolStripMenuItem.Text = "Add New Project"
        ' 
        ' AddOrganizationToolStripMenuItem1
        ' 
        AddOrganizationToolStripMenuItem1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        AddOrganizationToolStripMenuItem1.ForeColor = Color.White
        AddOrganizationToolStripMenuItem1.Name = "AddOrganizationToolStripMenuItem1"
        AddOrganizationToolStripMenuItem1.Size = New Size(195, 22)
        AddOrganizationToolStripMenuItem1.Text = "Add New Organization"
        ' 
        ' AddComponentToolStripMenuItem
        ' 
        AddComponentToolStripMenuItem.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        AddComponentToolStripMenuItem.ForeColor = Color.White
        AddComponentToolStripMenuItem.Name = "AddComponentToolStripMenuItem"
        AddComponentToolStripMenuItem.Size = New Size(195, 22)
        AddComponentToolStripMenuItem.Text = "Add New Component"
        ' 
        ' AddCommodityToolStripMenuItem
        ' 
        AddCommodityToolStripMenuItem.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        AddCommodityToolStripMenuItem.ForeColor = Color.White
        AddCommodityToolStripMenuItem.Name = "AddCommodityToolStripMenuItem"
        AddCommodityToolStripMenuItem.Size = New Size(195, 22)
        AddCommodityToolStripMenuItem.Text = "Add New Commodity"
        ' 
        ' AddToolStripMenuItem
        ' 
        AddToolStripMenuItem.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        AddToolStripMenuItem.ForeColor = Color.White
        AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        AddToolStripMenuItem.Size = New Size(195, 22)
        AddToolStripMenuItem.Text = "Add New Species"
        ' 
        ' AddNewTenureToolStripMenuItem
        ' 
        AddNewTenureToolStripMenuItem.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        AddNewTenureToolStripMenuItem.ForeColor = Color.White
        AddNewTenureToolStripMenuItem.Name = "AddNewTenureToolStripMenuItem"
        AddNewTenureToolStripMenuItem.Size = New Size(195, 22)
        AddNewTenureToolStripMenuItem.Text = "Add New Tenure"
        ' 
        ' Panel8
        ' 
        Panel8.BackgroundImageLayout = ImageLayout.None
        Panel8.Controls.Add(MenuStrip2)
        Panel8.Location = New Point(0, 35)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(85, 44)
        Panel8.TabIndex = 11
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.FromArgb(CByte(34), CByte(47), CByte(62))
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(85, 24)
        MenuStrip2.TabIndex = 0
        MenuStrip2.Text = "Maintenance"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem2, ToolStripMenuItem3, ToolStripMenuItem4, ToolStripMenuItem5, ToolStripMenuItem6})
        ToolStripMenuItem1.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripMenuItem1.ForeColor = Color.White
        ToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(12, 20)
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        ToolStripMenuItem2.ForeColor = Color.White
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(145, 22)
        ToolStripMenuItem2.Text = "User"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        ToolStripMenuItem3.ForeColor = Color.White
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(145, 22)
        ToolStripMenuItem3.Text = "Organization"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        ToolStripMenuItem4.ForeColor = Color.White
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(145, 22)
        ToolStripMenuItem4.Text = "Component"
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        ToolStripMenuItem5.ForeColor = Color.White
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(145, 22)
        ToolStripMenuItem5.Text = "Commodity"
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        ToolStripMenuItem6.ForeColor = Color.White
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(145, 22)
        ToolStripMenuItem6.Text = "Species"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(29), CByte(209), CByte(161))
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(189, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1361, 32)
        Panel3.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(Panel6)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(189, 32)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1361, 900)
        Panel5.TabIndex = 2
        ' 
        ' Panel6
        ' 
        Panel6.Location = New Point(-189, -32)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1550, 884)
        Panel6.TabIndex = 0
        ' 
        ' maindash
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1550, 932)
        Controls.Add(Panel5)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "maindash"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        Panel5.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddOrganizationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddNewContractToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddOrganizationToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddComponentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCommodityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewTenureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel8 As Panel
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents btnAdminNav As Button
    Friend WithEvents Button5 As Button
End Class
