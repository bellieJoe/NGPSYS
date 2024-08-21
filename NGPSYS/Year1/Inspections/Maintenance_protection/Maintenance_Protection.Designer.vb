<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maintenance_Protection
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
        components = New ComponentModel.Container()
        txtOverallPercentage = New TextBox()
        Panel1 = New Panel()
        btnreadd = New Button()
        txtreid = New TextBox()
        btnreedit = New Button()
        btnresave = New Button()
        btnredelete = New Button()
        MenuStrip1 = New MenuStrip()
        AddRemarksToolStripMenuItem = New ToolStripMenuItem()
        txtremarks = New TextBox()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        txtid = New TextBox()
        btnedit = New Button()
        Label13 = New Label()
        Label12 = New Label()
        Label10 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        txtpercent = New TextBox()
        txtcost = New TextBox()
        txttarget = New TextBox()
        txtuwm = New TextBox()
        txtunit = New TextBox()
        txtact = New TextBox()
        Panel3 = New Panel()
        ProgressBar2 = New ProgressBar()
        ListView1 = New ListView()
        progress2 = New Label()
        ListBox1 = New ListBox()
        txtprogress2 = New TextBox()
        ListBox2 = New ListBox()
        PictureBox2 = New PictureBox()
        btndelete = New Button()
        btnsave = New Button()
        ProgressBar1 = New ProgressBar()
        txtprogress = New TextBox()
        progress = New Label()
        PictureBox1 = New PictureBox()
        txtboxinspection = New TextBox()
        txtorg = New TextBox()
        Label8 = New Label()
        Label5 = New Label()
        txtuniquecode = New TextBox()
        txtboxrequest = New TextBox()
        Label9 = New Label()
        Label16 = New Label()
        Label1 = New Label()
        Panel5 = New Panel()
        txtidsurvival = New TextBox()
        btneditSurvival = New Button()
        btnsaveSurvival = New Button()
        btndeleteSurvival = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label11 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        txtsurvivalrate = New TextBox()
        txtseedlingsurvive = New TextBox()
        txtareaplanted = New TextBox()
        txtseedplanted = New TextBox()
        txtcommodity = New TextBox()
        DataGridView2 = New DataGridView()
        MenuStrip3 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ListView2 = New ListView()
        ListBox3 = New ListBox()
        ListBox4 = New ListBox()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        txtOverallPercentage2 = New TextBox()
        MenuStrip2 = New MenuStrip()
        coderemark1 = New TextBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        PrintDialog1 = New PrintDialog()
        Button4 = New Button()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip3.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtOverallPercentage
        ' 
        txtOverallPercentage.Location = New Point(907, 49)
        txtOverallPercentage.Name = "txtOverallPercentage"
        txtOverallPercentage.Size = New Size(125, 27)
        txtOverallPercentage.TabIndex = 210
        txtOverallPercentage.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(btnreadd)
        Panel1.Controls.Add(txtreid)
        Panel1.Controls.Add(btnreedit)
        Panel1.Controls.Add(btnresave)
        Panel1.Controls.Add(btnredelete)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(txtremarks)
        Panel1.Location = New Point(25, 577)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1052, 246)
        Panel1.TabIndex = 209
        ' 
        ' btnreadd
        ' 
        btnreadd.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnreadd.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnreadd.ForeColor = Color.White
        btnreadd.Location = New Point(911, 85)
        btnreadd.Name = "btnreadd"
        btnreadd.Size = New Size(94, 81)
        btnreadd.TabIndex = 256
        btnreadd.Text = "Add"
        btnreadd.UseVisualStyleBackColor = False
        ' 
        ' txtreid
        ' 
        txtreid.Location = New Point(938, 35)
        txtreid.Name = "txtreid"
        txtreid.Size = New Size(53, 27)
        txtreid.TabIndex = 246
        ' 
        ' btnreedit
        ' 
        btnreedit.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnreedit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnreedit.ForeColor = Color.White
        btnreedit.Location = New Point(911, 85)
        btnreedit.Name = "btnreedit"
        btnreedit.Size = New Size(94, 81)
        btnreedit.TabIndex = 243
        btnreedit.Text = "Edit"
        btnreedit.UseVisualStyleBackColor = False
        ' 
        ' btnresave
        ' 
        btnresave.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnresave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnresave.ForeColor = Color.White
        btnresave.Location = New Point(910, 85)
        btnresave.Name = "btnresave"
        btnresave.Size = New Size(94, 29)
        btnresave.TabIndex = 244
        btnresave.Text = "Save"
        btnresave.UseVisualStyleBackColor = False
        ' 
        ' btnredelete
        ' 
        btnredelete.BackColor = Color.IndianRed
        btnredelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnredelete.ForeColor = Color.White
        btnredelete.Location = New Point(910, 137)
        btnredelete.Name = "btnredelete"
        btnredelete.Size = New Size(94, 29)
        btnredelete.TabIndex = 245
        btnredelete.Text = "Delete"
        btnredelete.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AddRemarksToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1052, 28)
        MenuStrip1.TabIndex = 197
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AddRemarksToolStripMenuItem
        ' 
        AddRemarksToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AddRemarksToolStripMenuItem.ForeColor = Color.White
        AddRemarksToolStripMenuItem.Name = "AddRemarksToolStripMenuItem"
        AddRemarksToolStripMenuItem.Size = New Size(113, 24)
        AddRemarksToolStripMenuItem.Text = "Add remarks"
        ' 
        ' txtremarks
        ' 
        txtremarks.BackColor = Color.White
        txtremarks.BorderStyle = BorderStyle.FixedSingle
        txtremarks.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtremarks.Location = New Point(9, 38)
        txtremarks.Multiline = True
        txtremarks.Name = "txtremarks"
        txtremarks.Size = New Size(834, 202)
        txtremarks.TabIndex = 195
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(txtid)
        Panel2.Controls.Add(btnedit)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(txtpercent)
        Panel2.Controls.Add(txtcost)
        Panel2.Controls.Add(txttarget)
        Panel2.Controls.Add(txtuwm)
        Panel2.Controls.Add(txtunit)
        Panel2.Controls.Add(txtact)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(ProgressBar2)
        Panel2.Controls.Add(ListView1)
        Panel2.Controls.Add(progress2)
        Panel2.Controls.Add(ListBox1)
        Panel2.Controls.Add(txtprogress2)
        Panel2.Controls.Add(ListBox2)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(btndelete)
        Panel2.Controls.Add(btnsave)
        Panel2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Panel2.Location = New Point(6, 17)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1042, 279)
        Panel2.TabIndex = 208
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(11, 37)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(762, 129)
        DataGridView1.TabIndex = 245
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(678, 188)
        txtid.Name = "txtid"
        txtid.Size = New Size(53, 27)
        txtid.TabIndex = 242
        txtid.Visible = False
        ' 
        ' btnedit
        ' 
        btnedit.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnedit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnedit.ForeColor = Color.White
        btnedit.Location = New Point(578, 188)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(94, 81)
        btnedit.TabIndex = 224
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(401, 222)
        Label13.Name = "Label13"
        Label13.Size = New Size(134, 17)
        Label13.TabIndex = 223
        Label13.Text = "% of Accomplishment"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(224, 222)
        Label12.Name = "Label12"
        Label12.Size = New Size(75, 17)
        Label12.TabIndex = 222
        Label12.Text = "Total target"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(47, 222)
        Label10.Name = "Label10"
        Label10.Size = New Size(61, 17)
        Label10.TabIndex = 221
        Label10.Text = "Unit Cost"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(401, 170)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 17)
        Label7.TabIndex = 220
        Label7.Text = "Total Contract Cost"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(224, 170)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 17)
        Label6.TabIndex = 219
        Label6.Text = "UWM"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(47, 170)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 17)
        Label4.TabIndex = 218
        Label4.Text = "Activities"
        ' 
        ' txtpercent
        ' 
        txtpercent.Location = New Point(401, 242)
        txtpercent.Name = "txtpercent"
        txtpercent.ReadOnly = True
        txtpercent.Size = New Size(171, 27)
        txtpercent.TabIndex = 217
        ' 
        ' txtcost
        ' 
        txtcost.Location = New Point(401, 190)
        txtcost.Name = "txtcost"
        txtcost.ReadOnly = True
        txtcost.Size = New Size(171, 27)
        txtcost.TabIndex = 216
        ' 
        ' txttarget
        ' 
        txttarget.Location = New Point(224, 242)
        txttarget.Name = "txttarget"
        txttarget.ReadOnly = True
        txttarget.Size = New Size(171, 27)
        txttarget.TabIndex = 215
        ' 
        ' txtuwm
        ' 
        txtuwm.Location = New Point(224, 190)
        txtuwm.Name = "txtuwm"
        txtuwm.ReadOnly = True
        txtuwm.Size = New Size(171, 27)
        txtuwm.TabIndex = 214
        ' 
        ' txtunit
        ' 
        txtunit.Location = New Point(47, 242)
        txtunit.Name = "txtunit"
        txtunit.ReadOnly = True
        txtunit.Size = New Size(171, 27)
        txtunit.TabIndex = 213
        ' 
        ' txtact
        ' 
        txtact.Location = New Point(47, 190)
        txtact.Name = "txtact"
        txtact.ReadOnly = True
        txtact.Size = New Size(171, 27)
        txtact.TabIndex = 212
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(0, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1039, 29)
        Panel3.TabIndex = 169
        ' 
        ' ProgressBar2
        ' 
        ProgressBar2.Location = New Point(879, 195)
        ProgressBar2.Name = "ProgressBar2"
        ProgressBar2.Size = New Size(125, 29)
        ProgressBar2.TabIndex = 197
        ProgressBar2.Visible = False
        ' 
        ' ListView1
        ' 
        ListView1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ListView1.GridLines = True
        ListView1.Location = New Point(11, 37)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(762, 99)
        ListView1.TabIndex = 68
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' progress2
        ' 
        progress2.AutoSize = True
        progress2.BackColor = SystemColors.GradientActiveCaption
        progress2.Font = New Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        progress2.Location = New Point(919, 84)
        progress2.Name = "progress2"
        progress2.Size = New Size(31, 21)
        progress2.TabIndex = 194
        progress2.Text = "0%"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(179, 57)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(169, 64)
        ListBox1.TabIndex = 57
        ' 
        ' txtprogress2
        ' 
        txtprogress2.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtprogress2.BackColor = SystemColors.GradientActiveCaption
        txtprogress2.BorderStyle = BorderStyle.None
        txtprogress2.Font = New Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtprogress2.ForeColor = Color.Black
        txtprogress2.Location = New Point(865, 153)
        txtprogress2.Name = "txtprogress2"
        txtprogress2.ReadOnly = True
        txtprogress2.Size = New Size(163, 21)
        txtprogress2.TabIndex = 196
        txtprogress2.TextAlign = HorizontalAlignment.Center
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 20
        ListBox2.Location = New Point(374, 57)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(172, 64)
        ListBox2.TabIndex = 58
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.GradientActiveCaption
        PictureBox2.Image = My.Resources.Resources.blank
        PictureBox2.Location = New Point(879, 37)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(128, 110)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 195
        PictureBox2.TabStop = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.IndianRed
        btndelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btndelete.ForeColor = Color.White
        btndelete.Location = New Point(578, 230)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(94, 29)
        btndelete.TabIndex = 244
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnsave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnsave.ForeColor = Color.White
        btnsave.Location = New Point(578, 195)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(94, 29)
        btnsave.TabIndex = 243
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(876, 195)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(125, 29)
        ProgressBar1.TabIndex = 197
        ProgressBar1.Visible = False
        ' 
        ' txtprogress
        ' 
        txtprogress.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtprogress.BackColor = SystemColors.GradientActiveCaption
        txtprogress.BorderStyle = BorderStyle.None
        txtprogress.Font = New Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtprogress.ForeColor = Color.Black
        txtprogress.Location = New Point(862, 153)
        txtprogress.Name = "txtprogress"
        txtprogress.ReadOnly = True
        txtprogress.Size = New Size(163, 21)
        txtprogress.TabIndex = 196
        txtprogress.TextAlign = HorizontalAlignment.Center
        ' 
        ' progress
        ' 
        progress.AutoSize = True
        progress.BackColor = SystemColors.GradientActiveCaption
        progress.Font = New Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        progress.Location = New Point(916, 81)
        progress.Name = "progress"
        progress.Size = New Size(31, 21)
        progress.TabIndex = 194
        progress.Text = "0%"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.GradientActiveCaption
        PictureBox1.Image = My.Resources.Resources.blank
        PictureBox1.Location = New Point(876, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(128, 110)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 195
        PictureBox1.TabStop = False
        ' 
        ' txtboxinspection
        ' 
        txtboxinspection.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtboxinspection.Location = New Point(792, 188)
        txtboxinspection.Name = "txtboxinspection"
        txtboxinspection.ReadOnly = True
        txtboxinspection.Size = New Size(281, 27)
        txtboxinspection.TabIndex = 202
        txtboxinspection.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtorg
        ' 
        txtorg.BackColor = Color.White
        txtorg.BorderStyle = BorderStyle.FixedSingle
        txtorg.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtorg.Location = New Point(233, 137)
        txtorg.Name = "txtorg"
        txtorg.ReadOnly = True
        txtorg.Size = New Size(565, 27)
        txtorg.TabIndex = 207
        txtorg.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(19, 105)
        Label8.Name = "Label8"
        Label8.Size = New Size(184, 23)
        Label8.TabIndex = 204
        Label8.Text = "Project Unique Code :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(588, 189)
        Label5.Name = "Label5"
        Label5.Size = New Size(198, 23)
        Label5.TabIndex = 200
        Label5.Text = "Date of TIC inspection :"
        ' 
        ' txtuniquecode
        ' 
        txtuniquecode.BackColor = Color.White
        txtuniquecode.BorderStyle = BorderStyle.FixedSingle
        txtuniquecode.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtuniquecode.Location = New Point(234, 101)
        txtuniquecode.Name = "txtuniquecode"
        txtuniquecode.ReadOnly = True
        txtuniquecode.Size = New Size(564, 27)
        txtuniquecode.TabIndex = 206
        txtuniquecode.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtboxrequest
        ' 
        txtboxrequest.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtboxrequest.Location = New Point(293, 188)
        txtboxrequest.Name = "txtboxrequest"
        txtboxrequest.ReadOnly = True
        txtboxrequest.Size = New Size(278, 27)
        txtboxrequest.TabIndex = 201
        txtboxrequest.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(19, 142)
        Label9.Name = "Label9"
        Label9.Size = New Size(198, 23)
        Label9.TabIndex = 205
        Label9.Text = "Name of Implementer :"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(234, 32)
        Label16.Name = "Label16"
        Label16.Size = New Size(651, 45)
        Label16.TabIndex = 203
        Label16.Text = "Year 1 Maintenance and Protection"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(19, 188)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 23)
        Label1.TabIndex = 199
        Label1.Text = "Date of Stakeholders Request :"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.GradientActiveCaption
        Panel5.Controls.Add(txtidsurvival)
        Panel5.Controls.Add(btneditSurvival)
        Panel5.Controls.Add(btnsaveSurvival)
        Panel5.Controls.Add(btndeleteSurvival)
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(Label11)
        Panel5.Controls.Add(Label14)
        Panel5.Controls.Add(Label15)
        Panel5.Controls.Add(txtsurvivalrate)
        Panel5.Controls.Add(txtseedlingsurvive)
        Panel5.Controls.Add(txtareaplanted)
        Panel5.Controls.Add(txtseedplanted)
        Panel5.Controls.Add(txtcommodity)
        Panel5.Controls.Add(DataGridView2)
        Panel5.Controls.Add(MenuStrip3)
        Panel5.Controls.Add(ProgressBar1)
        Panel5.Controls.Add(txtprogress)
        Panel5.Controls.Add(progress)
        Panel5.Controls.Add(PictureBox1)
        Panel5.Controls.Add(ListView2)
        Panel5.Controls.Add(ListBox3)
        Panel5.Controls.Add(ListBox4)
        Panel5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Panel5.Location = New Point(6, 17)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1042, 279)
        Panel5.TabIndex = 211
        ' 
        ' txtidsurvival
        ' 
        txtidsurvival.Location = New Point(667, 190)
        txtidsurvival.Name = "txtidsurvival"
        txtidsurvival.Size = New Size(53, 27)
        txtidsurvival.TabIndex = 248
        txtidsurvival.Visible = False
        ' 
        ' btneditSurvival
        ' 
        btneditSurvival.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btneditSurvival.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btneditSurvival.ForeColor = Color.White
        btneditSurvival.Location = New Point(567, 188)
        btneditSurvival.Name = "btneditSurvival"
        btneditSurvival.Size = New Size(94, 81)
        btneditSurvival.TabIndex = 225
        btneditSurvival.Text = "Edit"
        btneditSurvival.UseVisualStyleBackColor = False
        ' 
        ' btnsaveSurvival
        ' 
        btnsaveSurvival.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnsaveSurvival.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnsaveSurvival.ForeColor = Color.White
        btnsaveSurvival.Location = New Point(567, 188)
        btnsaveSurvival.Name = "btnsaveSurvival"
        btnsaveSurvival.Size = New Size(94, 29)
        btnsaveSurvival.TabIndex = 246
        btnsaveSurvival.Text = "Save"
        btnsaveSurvival.UseVisualStyleBackColor = False
        ' 
        ' btndeleteSurvival
        ' 
        btndeleteSurvival.BackColor = Color.IndianRed
        btndeleteSurvival.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btndeleteSurvival.ForeColor = Color.White
        btndeleteSurvival.Location = New Point(567, 240)
        btndeleteSurvival.Name = "btndeleteSurvival"
        btndeleteSurvival.Size = New Size(94, 29)
        btndeleteSurvival.TabIndex = 247
        btndeleteSurvival.Text = "Delete"
        btndeleteSurvival.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(303, 222)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 17)
        Label2.TabIndex = 235
        Label2.Text = "No. of Seedling Survive"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(126, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 17)
        Label3.TabIndex = 234
        Label3.Text = "No. of Seedling Planted"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(389, 172)
        Label11.Name = "Label11"
        Label11.Size = New Size(82, 17)
        Label11.TabIndex = 233
        Label11.Text = "Survival Rate"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(212, 172)
        Label14.Name = "Label14"
        Label14.Size = New Size(82, 17)
        Label14.TabIndex = 232
        Label14.Text = "Area Planted"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(35, 172)
        Label15.Name = "Label15"
        Label15.Size = New Size(75, 17)
        Label15.TabIndex = 231
        Label15.Text = "Commodity"
        ' 
        ' txtsurvivalrate
        ' 
        txtsurvivalrate.Location = New Point(389, 192)
        txtsurvivalrate.Name = "txtsurvivalrate"
        txtsurvivalrate.ReadOnly = True
        txtsurvivalrate.Size = New Size(171, 27)
        txtsurvivalrate.TabIndex = 230
        ' 
        ' txtseedlingsurvive
        ' 
        txtseedlingsurvive.Location = New Point(303, 242)
        txtseedlingsurvive.Name = "txtseedlingsurvive"
        txtseedlingsurvive.ReadOnly = True
        txtseedlingsurvive.Size = New Size(171, 27)
        txtseedlingsurvive.TabIndex = 229
        ' 
        ' txtareaplanted
        ' 
        txtareaplanted.Location = New Point(212, 192)
        txtareaplanted.Name = "txtareaplanted"
        txtareaplanted.ReadOnly = True
        txtareaplanted.Size = New Size(171, 27)
        txtareaplanted.TabIndex = 228
        ' 
        ' txtseedplanted
        ' 
        txtseedplanted.Location = New Point(126, 242)
        txtseedplanted.Name = "txtseedplanted"
        txtseedplanted.ReadOnly = True
        txtseedplanted.Size = New Size(171, 27)
        txtseedplanted.TabIndex = 227
        ' 
        ' txtcommodity
        ' 
        txtcommodity.Location = New Point(35, 192)
        txtcommodity.Name = "txtcommodity"
        txtcommodity.ReadOnly = True
        txtcommodity.Size = New Size(171, 27)
        txtcommodity.TabIndex = 226
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(11, 37)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 29
        DataGridView2.Size = New Size(689, 129)
        DataGridView2.TabIndex = 199
        ' 
        ' MenuStrip3
        ' 
        MenuStrip3.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        MenuStrip3.ImageScalingSize = New Size(20, 20)
        MenuStrip3.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1})
        MenuStrip3.Location = New Point(0, 0)
        MenuStrip3.Name = "MenuStrip3"
        MenuStrip3.Size = New Size(1042, 28)
        MenuStrip3.TabIndex = 198
        MenuStrip3.Text = "MenuStrip3"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ToolStripMenuItem1.ForeColor = Color.White
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(148, 24)
        ToolStripMenuItem1.Text = "Add Survival Rate"
        ' 
        ' ListView2
        ' 
        ListView2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ListView2.GridLines = True
        ListView2.Location = New Point(11, 37)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(660, 129)
        ListView2.TabIndex = 68
        ListView2.UseCompatibleStateImageBehavior = False
        ' 
        ' ListBox3
        ' 
        ListBox3.FormattingEnabled = True
        ListBox3.ItemHeight = 20
        ListBox3.Location = New Point(179, 57)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(169, 104)
        ListBox3.TabIndex = 57
        ' 
        ' ListBox4
        ' 
        ListBox4.FormattingEnabled = True
        ListBox4.ItemHeight = 20
        ListBox4.Location = New Point(374, 57)
        ListBox4.Name = "ListBox4"
        ListBox4.Size = New Size(172, 104)
        ListBox4.TabIndex = 58
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 25
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 25
        ' 
        ' txtOverallPercentage2
        ' 
        txtOverallPercentage2.Location = New Point(907, 79)
        txtOverallPercentage2.Name = "txtOverallPercentage2"
        txtOverallPercentage2.Size = New Size(125, 27)
        txtOverallPercentage2.TabIndex = 212
        txtOverallPercentage2.Visible = False
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
        MenuStrip2.Size = New Size(1093, 24)
        MenuStrip2.TabIndex = 230
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' coderemark1
        ' 
        coderemark1.Location = New Point(907, 112)
        coderemark1.Name = "coderemark1"
        coderemark1.Size = New Size(125, 27)
        coderemark1.TabIndex = 231
        coderemark1.Visible = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl1.Location = New Point(15, 236)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1062, 335)
        TabControl1.TabIndex = 232
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Panel2)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1054, 302)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Maintenance / Protection Details"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Panel5)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1054, 302)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Survival Rate"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(894, 94)
        Button4.Name = "Button4"
        Button4.Size = New Size(156, 71)
        Button4.TabIndex = 245
        Button4.Text = "Print Report"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Maintenance_Protection
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1093, 851)
        Controls.Add(Button4)
        Controls.Add(TabControl1)
        Controls.Add(coderemark1)
        Controls.Add(MenuStrip2)
        Controls.Add(txtOverallPercentage2)
        Controls.Add(txtOverallPercentage)
        Controls.Add(Panel1)
        Controls.Add(txtboxinspection)
        Controls.Add(txtorg)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(txtuniquecode)
        Controls.Add(txtboxrequest)
        Controls.Add(Label9)
        Controls.Add(Label16)
        Controls.Add(Label1)
        Name = "Maintenance_Protection"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Maintenance_Protection"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip3.ResumeLayout(False)
        MenuStrip3.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtOverallPercentage As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtremarks As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents txtprogress As TextBox
    Friend WithEvents progress As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents txtboxinspection As TextBox
    Friend WithEvents txtorg As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtuniquecode As TextBox
    Friend WithEvents txtboxrequest As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents txtprogress2 As TextBox
    Friend WithEvents progress2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents txtOverallPercentage2 As TextBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents coderemark1 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddRemarksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnedit As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpercent As TextBox
    Friend WithEvents txtcost As TextBox
    Friend WithEvents txttarget As TextBox
    Friend WithEvents txtuwm As TextBox
    Friend WithEvents txtunit As TextBox
    Friend WithEvents txtact As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtreid As TextBox
    Friend WithEvents btnreedit As Button
    Friend WithEvents btnresave As Button
    Friend WithEvents btnredelete As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btneditSurvival As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txtsurvivalrate As TextBox
    Friend WithEvents txtseedlingsurvive As TextBox
    Friend WithEvents txtareaplanted As TextBox
    Friend WithEvents txtseedplanted As TextBox
    Friend WithEvents txtcommodity As TextBox
    Friend WithEvents btnsaveSurvival As Button
    Friend WithEvents btndeleteSurvival As Button
    Friend WithEvents txtidsurvival As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents btnreadd As Button
End Class
