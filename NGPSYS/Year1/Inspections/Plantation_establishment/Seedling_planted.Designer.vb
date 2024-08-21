<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seedling_planted
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Seedling_planted))
        txtboxinspection = New TextBox()
        Label5 = New Label()
        txtboxrequest = New TextBox()
        Label1 = New Label()
        txtorg = New TextBox()
        Label8 = New Label()
        txtuniquecode = New TextBox()
        Label9 = New Label()
        Label16 = New Label()
        Panel2 = New Panel()
        txtid = New TextBox()
        btnedit = New Button()
        btndelete = New Button()
        btnsave = New Button()
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
        DataGridView1 = New DataGridView()
        txtprogress = New TextBox()
        progress = New Label()
        PictureBox1 = New PictureBox()
        txtplanted = New TextBox()
        Label2 = New Label()
        Panel3 = New Panel()
        Label11 = New Label()
        ListView1 = New ListView()
        ListBox1 = New ListBox()
        txtreq = New TextBox()
        Label3 = New Label()
        ListBox2 = New ListBox()
        ProgressBar1 = New ProgressBar()
        Panel1 = New Panel()
        btnreadd = New Button()
        txtreid = New TextBox()
        btnreedit = New Button()
        txtremarks = New TextBox()
        MenuStrip2 = New MenuStrip()
        btnresave = New Button()
        btnredelete = New Button()
        Timer1 = New Timer(components)
        txtOverallPercentage = New TextBox()
        MenuStrip1 = New MenuStrip()
        PrintDialog1 = New PrintDialog()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        PageSetupDialog1 = New PageSetupDialog()
        Button4 = New Button()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtboxinspection
        ' 
        txtboxinspection.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtboxinspection.Location = New Point(782, 186)
        txtboxinspection.Name = "txtboxinspection"
        txtboxinspection.ReadOnly = True
        txtboxinspection.Size = New Size(281, 27)
        txtboxinspection.TabIndex = 188
        txtboxinspection.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(578, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(198, 23)
        Label5.TabIndex = 182
        Label5.Text = "Date of TIC inspection :"
        ' 
        ' txtboxrequest
        ' 
        txtboxrequest.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtboxrequest.Location = New Point(273, 186)
        txtboxrequest.Name = "txtboxrequest"
        txtboxrequest.ReadOnly = True
        txtboxrequest.Size = New Size(278, 27)
        txtboxrequest.TabIndex = 187
        txtboxrequest.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(19, 188)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 23)
        Label1.TabIndex = 181
        Label1.Text = "Date of Stakeholders Request :"
        ' 
        ' txtorg
        ' 
        txtorg.BackColor = Color.White
        txtorg.BorderStyle = BorderStyle.FixedSingle
        txtorg.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtorg.Location = New Point(233, 135)
        txtorg.Name = "txtorg"
        txtorg.ReadOnly = True
        txtorg.Size = New Size(565, 27)
        txtorg.TabIndex = 194
        txtorg.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(19, 101)
        Label8.Name = "Label8"
        Label8.Size = New Size(184, 23)
        Label8.TabIndex = 191
        Label8.Text = "Project Unique Code :"
        ' 
        ' txtuniquecode
        ' 
        txtuniquecode.BackColor = Color.White
        txtuniquecode.BorderStyle = BorderStyle.FixedSingle
        txtuniquecode.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtuniquecode.Location = New Point(233, 101)
        txtuniquecode.Name = "txtuniquecode"
        txtuniquecode.ReadOnly = True
        txtuniquecode.Size = New Size(564, 27)
        txtuniquecode.TabIndex = 193
        txtuniquecode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(21, 139)
        Label9.Name = "Label9"
        Label9.Size = New Size(198, 23)
        Label9.TabIndex = 192
        Label9.Text = "Name of Implementer :"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(339, 36)
        Label16.Name = "Label16"
        Label16.Size = New Size(458, 45)
        Label16.TabIndex = 190
        Label16.Text = "Plantation Establishment"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(txtid)
        Panel2.Controls.Add(btnedit)
        Panel2.Controls.Add(btndelete)
        Panel2.Controls.Add(btnsave)
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
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(txtprogress)
        Panel2.Controls.Add(progress)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(txtplanted)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(ListView1)
        Panel2.Controls.Add(ListBox1)
        Panel2.Controls.Add(txtreq)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(ListBox2)
        Panel2.Controls.Add(ProgressBar1)
        Panel2.Location = New Point(21, 233)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1042, 294)
        Panel2.TabIndex = 196
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(642, 174)
        txtid.Name = "txtid"
        txtid.Size = New Size(53, 27)
        txtid.TabIndex = 241
        txtid.Visible = False
        ' 
        ' btnedit
        ' 
        btnedit.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnedit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnedit.ForeColor = Color.White
        btnedit.Location = New Point(542, 192)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(94, 81)
        btnedit.TabIndex = 211
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.IndianRed
        btndelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btndelete.ForeColor = Color.White
        btndelete.Location = New Point(542, 235)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(94, 29)
        btndelete.TabIndex = 213
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnsave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnsave.ForeColor = Color.White
        btnsave.Location = New Point(542, 200)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(94, 29)
        btnsave.TabIndex = 212
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(365, 226)
        Label13.Name = "Label13"
        Label13.Size = New Size(134, 17)
        Label13.TabIndex = 210
        Label13.Text = "% of Accomplishment"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(188, 226)
        Label12.Name = "Label12"
        Label12.Size = New Size(75, 17)
        Label12.TabIndex = 209
        Label12.Text = "Total target"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(11, 226)
        Label10.Name = "Label10"
        Label10.Size = New Size(61, 17)
        Label10.TabIndex = 208
        Label10.Text = "Unit Cost"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(365, 174)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 17)
        Label7.TabIndex = 207
        Label7.Text = "Total Contract Cost"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(188, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 17)
        Label6.TabIndex = 206
        Label6.Text = "UWM"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(11, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 17)
        Label4.TabIndex = 205
        Label4.Text = "Activities"
        ' 
        ' txtpercent
        ' 
        txtpercent.Location = New Point(365, 246)
        txtpercent.Name = "txtpercent"
        txtpercent.ReadOnly = True
        txtpercent.Size = New Size(171, 27)
        txtpercent.TabIndex = 204
        ' 
        ' txtcost
        ' 
        txtcost.Location = New Point(365, 194)
        txtcost.Name = "txtcost"
        txtcost.ReadOnly = True
        txtcost.Size = New Size(171, 27)
        txtcost.TabIndex = 203
        ' 
        ' txttarget
        ' 
        txttarget.Location = New Point(188, 246)
        txttarget.Name = "txttarget"
        txttarget.ReadOnly = True
        txttarget.Size = New Size(171, 27)
        txttarget.TabIndex = 202
        ' 
        ' txtuwm
        ' 
        txtuwm.Location = New Point(188, 194)
        txtuwm.Name = "txtuwm"
        txtuwm.ReadOnly = True
        txtuwm.Size = New Size(171, 27)
        txtuwm.TabIndex = 201
        ' 
        ' txtunit
        ' 
        txtunit.Location = New Point(11, 246)
        txtunit.Name = "txtunit"
        txtunit.ReadOnly = True
        txtunit.Size = New Size(171, 27)
        txtunit.TabIndex = 200
        ' 
        ' txtact
        ' 
        txtact.Location = New Point(11, 194)
        txtact.Name = "txtact"
        txtact.ReadOnly = True
        txtact.Size = New Size(171, 27)
        txtact.TabIndex = 199
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
        DataGridView1.Size = New Size(765, 129)
        DataGridView1.TabIndex = 198
        ' 
        ' txtprogress
        ' 
        txtprogress.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtprogress.BackColor = SystemColors.GradientActiveCaption
        txtprogress.BorderStyle = BorderStyle.None
        txtprogress.Font = New Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtprogress.ForeColor = Color.Black
        txtprogress.Location = New Point(866, 162)
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
        progress.Location = New Point(920, 90)
        progress.Name = "progress"
        progress.Size = New Size(31, 21)
        progress.TabIndex = 194
        progress.Text = "0%"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.GradientActiveCaption
        PictureBox1.Image = My.Resources.Resources.blank
        PictureBox1.Location = New Point(880, 46)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(128, 110)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 195
        PictureBox1.TabStop = False
        ' 
        ' txtplanted
        ' 
        txtplanted.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtplanted.BorderStyle = BorderStyle.FixedSingle
        txtplanted.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtplanted.ForeColor = Color.Gray
        txtplanted.Location = New Point(883, 244)
        txtplanted.Name = "txtplanted"
        txtplanted.ReadOnly = True
        txtplanted.Size = New Size(147, 27)
        txtplanted.TabIndex = 190
        txtplanted.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(721, 246)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 23)
        Label2.TabIndex = 189
        Label2.Text = "Seedling Planted :"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Panel3.Controls.Add(Label11)
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(0, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1039, 29)
        Panel3.TabIndex = 169
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(416, 3)
        Label11.Name = "Label11"
        Label11.Size = New Size(250, 20)
        Label11.TabIndex = 159
        Label11.Text = "S E E D L I N G P R O D U C T I O N "
        ' 
        ' ListView1
        ' 
        ListView1.GridLines = True
        ListView1.Location = New Point(11, 37)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(766, 104)
        ListView1.TabIndex = 68
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(179, 57)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(169, 84)
        ListBox1.TabIndex = 57
        ' 
        ' txtreq
        ' 
        txtreq.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtreq.BorderStyle = BorderStyle.FixedSingle
        txtreq.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtreq.ForeColor = Color.Gray
        txtreq.Location = New Point(882, 194)
        txtreq.Name = "txtreq"
        txtreq.ReadOnly = True
        txtreq.Size = New Size(147, 27)
        txtreq.TabIndex = 63
        txtreq.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(714, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(163, 23)
        Label3.TabIndex = 62
        Label3.Text = "Seedling Required:"
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 20
        ListBox2.Location = New Point(374, 57)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(172, 84)
        ListBox2.TabIndex = 58
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(904, 244)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(125, 25)
        ProgressBar1.TabIndex = 197
        ProgressBar1.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(btnreadd)
        Panel1.Controls.Add(txtreid)
        Panel1.Controls.Add(btnreedit)
        Panel1.Controls.Add(txtremarks)
        Panel1.Controls.Add(MenuStrip2)
        Panel1.Controls.Add(btnresave)
        Panel1.Controls.Add(btnredelete)
        Panel1.Location = New Point(21, 533)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1042, 251)
        Panel1.TabIndex = 197
        ' 
        ' btnreadd
        ' 
        btnreadd.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnreadd.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnreadd.ForeColor = Color.White
        btnreadd.Location = New Point(892, 87)
        btnreadd.Name = "btnreadd"
        btnreadd.Size = New Size(94, 81)
        btnreadd.TabIndex = 255
        btnreadd.Text = "Add"
        btnreadd.UseVisualStyleBackColor = False
        ' 
        ' txtreid
        ' 
        txtreid.Location = New Point(920, 37)
        txtreid.Name = "txtreid"
        txtreid.Size = New Size(53, 27)
        txtreid.TabIndex = 242
        txtreid.Visible = False
        ' 
        ' btnreedit
        ' 
        btnreedit.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnreedit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnreedit.ForeColor = Color.White
        btnreedit.Location = New Point(892, 87)
        btnreedit.Name = "btnreedit"
        btnreedit.Size = New Size(94, 81)
        btnreedit.TabIndex = 212
        btnreedit.Text = "Edit"
        btnreedit.UseVisualStyleBackColor = False
        ' 
        ' txtremarks
        ' 
        txtremarks.BackColor = Color.White
        txtremarks.BorderStyle = BorderStyle.FixedSingle
        txtremarks.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtremarks.Location = New Point(9, 37)
        txtremarks.Multiline = True
        txtremarks.Name = "txtremarks"
        txtremarks.Size = New Size(834, 202)
        txtremarks.TabIndex = 195
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(1042, 24)
        MenuStrip2.TabIndex = 196
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' btnresave
        ' 
        btnresave.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnresave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnresave.ForeColor = Color.White
        btnresave.Location = New Point(892, 87)
        btnresave.Name = "btnresave"
        btnresave.Size = New Size(94, 29)
        btnresave.TabIndex = 213
        btnresave.Text = "Save"
        btnresave.UseVisualStyleBackColor = False
        ' 
        ' btnredelete
        ' 
        btnredelete.BackColor = Color.IndianRed
        btnredelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnredelete.ForeColor = Color.White
        btnredelete.Location = New Point(892, 139)
        btnredelete.Name = "btnredelete"
        btnredelete.Size = New Size(94, 29)
        btnredelete.TabIndex = 214
        btnredelete.Text = "Delete"
        btnredelete.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 25
        ' 
        ' txtOverallPercentage
        ' 
        txtOverallPercentage.Location = New Point(803, 53)
        txtOverallPercentage.Name = "txtOverallPercentage"
        txtOverallPercentage.Size = New Size(125, 27)
        txtOverallPercentage.TabIndex = 198
        txtOverallPercentage.Visible = False
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
        MenuStrip1.Size = New Size(1091, 24)
        MenuStrip1.TabIndex = 232
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(875, 101)
        Button4.Name = "Button4"
        Button4.Size = New Size(154, 61)
        Button4.TabIndex = 241
        Button4.Text = "Print Report"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Seedling_planted
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1091, 860)
        Controls.Add(Button4)
        Controls.Add(MenuStrip1)
        Controls.Add(txtOverallPercentage)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(txtboxinspection)
        Controls.Add(txtorg)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(txtuniquecode)
        Controls.Add(txtboxrequest)
        Controls.Add(Label9)
        Controls.Add(Label16)
        Controls.Add(Label1)
        MainMenuStrip = MenuStrip2
        Name = "Seedling_planted"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Seedling_planted"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtboxinspection As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtboxrequest As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtorg As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtuniquecode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtprogress As TextBox
    Friend WithEvents progress As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtplanted As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtreq As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtremarks As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtOverallPercentage As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtact As TextBox
    Friend WithEvents txtpercent As TextBox
    Friend WithEvents txtcost As TextBox
    Friend WithEvents txttarget As TextBox
    Friend WithEvents txtuwm As TextBox
    Friend WithEvents txtunit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents btnredelete As Button
    Friend WithEvents btnresave As Button
    Friend WithEvents btnreedit As Button
    Friend WithEvents txtreid As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents btnreadd As Button
End Class
