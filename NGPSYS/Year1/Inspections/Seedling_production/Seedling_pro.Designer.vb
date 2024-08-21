<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seedling_pro
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
        txtboxinspection = New TextBox()
        txtboxrequest = New TextBox()
        Label5 = New Label()
        txtorg = New TextBox()
        Label8 = New Label()
        txtuniquecode = New TextBox()
        Label9 = New Label()
        Label1 = New Label()
        Label16 = New Label()
        Panel2 = New Panel()
        btnadd = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        btndelete = New Button()
        btnedit = New Button()
        verify = New TextBox()
        sproduce = New TextBox()
        sname = New TextBox()
        DataGridView1 = New DataGridView()
        txtprogress = New TextBox()
        progress = New Label()
        PictureBox1 = New PictureBox()
        tic_counted = New TextBox()
        Label2 = New Label()
        Panel3 = New Panel()
        Label11 = New Label()
        ListView1 = New ListView()
        ListBox1 = New ListBox()
        txtproduced = New TextBox()
        Label12 = New Label()
        txtreq = New TextBox()
        Label3 = New Label()
        txtmortality = New TextBox()
        Label10 = New Label()
        ListBox2 = New ListBox()
        btnsave = New Button()
        Timer1 = New Timer(components)
        ProgressBar1 = New ProgressBar()
        MenuStrip1 = New MenuStrip()
        txtseedproreport = New TextBox()
        txtid = New TextBox()
        txtseedcode = New TextBox()
        Button4 = New Button()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtboxinspection
        ' 
        txtboxinspection.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtboxinspection.Location = New Point(539, 222)
        txtboxinspection.Name = "txtboxinspection"
        txtboxinspection.ReadOnly = True
        txtboxinspection.Size = New Size(316, 27)
        txtboxinspection.TabIndex = 188
        txtboxinspection.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtboxrequest
        ' 
        txtboxrequest.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtboxrequest.Location = New Point(20, 223)
        txtboxrequest.Name = "txtboxrequest"
        txtboxrequest.ReadOnly = True
        txtboxrequest.Size = New Size(312, 27)
        txtboxrequest.TabIndex = 187
        txtboxrequest.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(539, 195)
        Label5.Name = "Label5"
        Label5.Size = New Size(195, 24)
        Label5.TabIndex = 182
        Label5.Text = "Date of TIC inspection"
        ' 
        ' txtorg
        ' 
        txtorg.BackColor = Color.White
        txtorg.BorderStyle = BorderStyle.FixedSingle
        txtorg.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtorg.Location = New Point(223, 143)
        txtorg.Name = "txtorg"
        txtorg.ReadOnly = True
        txtorg.Size = New Size(635, 27)
        txtorg.TabIndex = 186
        txtorg.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(16, 111)
        Label8.Name = "Label8"
        Label8.Size = New Size(184, 23)
        Label8.TabIndex = 183
        Label8.Text = "Project Unique Code :"
        ' 
        ' txtuniquecode
        ' 
        txtuniquecode.BackColor = Color.White
        txtuniquecode.BorderStyle = BorderStyle.FixedSingle
        txtuniquecode.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtuniquecode.Location = New Point(224, 110)
        txtuniquecode.Name = "txtuniquecode"
        txtuniquecode.ReadOnly = True
        txtuniquecode.Size = New Size(634, 27)
        txtuniquecode.TabIndex = 185
        txtuniquecode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(18, 146)
        Label9.Name = "Label9"
        Label9.Size = New Size(198, 23)
        Label9.TabIndex = 184
        Label9.Text = "Name of Implementer :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(20, 195)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 24)
        Label1.TabIndex = 181
        Label1.Text = "Date of Stakeholders Request :"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(20, 40)
        Label16.Name = "Label16"
        Label16.Size = New Size(376, 45)
        Label16.TabIndex = 180
        Label16.Text = "Seedling Production"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(btnadd)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(btndelete)
        Panel2.Controls.Add(btnedit)
        Panel2.Controls.Add(verify)
        Panel2.Controls.Add(sproduce)
        Panel2.Controls.Add(sname)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(txtprogress)
        Panel2.Controls.Add(progress)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(tic_counted)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(ListView1)
        Panel2.Controls.Add(ListBox1)
        Panel2.Controls.Add(txtproduced)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(txtreq)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(txtmortality)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(ListBox2)
        Panel2.Controls.Add(btnsave)
        Panel2.Location = New Point(20, 274)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(838, 414)
        Panel2.TabIndex = 189
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnadd.ForeColor = Color.White
        btnadd.Location = New Point(530, 275)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(79, 31)
        btnadd.TabIndex = 247
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(481, 147)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 20)
        Label7.TabIndex = 245
        Label7.Text = "Verified :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(481, 94)
        Label6.Name = "Label6"
        Label6.Size = New Size(137, 20)
        Label6.TabIndex = 244
        Label6.Text = "Seedling Produce :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(481, 39)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 20)
        Label4.TabIndex = 243
        Label4.Text = "Species Name :"
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.IndianRed
        btndelete.ForeColor = Color.White
        btndelete.Location = New Point(575, 219)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(79, 31)
        btndelete.TabIndex = 242
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnedit
        ' 
        btnedit.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnedit.ForeColor = Color.White
        btnedit.Location = New Point(481, 219)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(79, 31)
        btnedit.TabIndex = 241
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = False
        ' 
        ' verify
        ' 
        verify.Location = New Point(481, 168)
        verify.Name = "verify"
        verify.ReadOnly = True
        verify.Size = New Size(173, 27)
        verify.TabIndex = 240
        ' 
        ' sproduce
        ' 
        sproduce.Location = New Point(481, 117)
        sproduce.Name = "sproduce"
        sproduce.ReadOnly = True
        sproduce.Size = New Size(173, 27)
        sproduce.TabIndex = 239
        ' 
        ' sname
        ' 
        sname.Location = New Point(481, 62)
        sname.Name = "sname"
        sname.ReadOnly = True
        sname.Size = New Size(173, 27)
        sname.TabIndex = 238
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 37)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(463, 269)
        DataGridView1.TabIndex = 237
        ' 
        ' txtprogress
        ' 
        txtprogress.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtprogress.BackColor = SystemColors.GradientActiveCaption
        txtprogress.BorderStyle = BorderStyle.None
        txtprogress.Font = New Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtprogress.ForeColor = Color.Black
        txtprogress.Location = New Point(652, 266)
        txtprogress.Name = "txtprogress"
        txtprogress.ReadOnly = True
        txtprogress.Size = New Size(183, 21)
        txtprogress.TabIndex = 196
        txtprogress.TextAlign = HorizontalAlignment.Center
        ' 
        ' progress
        ' 
        progress.AutoSize = True
        progress.BackColor = SystemColors.GradientActiveCaption
        progress.Font = New Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        progress.Location = New Point(727, 154)
        progress.Name = "progress"
        progress.Size = New Size(49, 21)
        progress.TabIndex = 194
        progress.Text = "100%"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.GradientActiveCaption
        PictureBox1.Image = My.Resources.Resources.blank
        PictureBox1.Location = New Point(682, 110)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(140, 111)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 195
        PictureBox1.TabStop = False
        ' 
        ' tic_counted
        ' 
        tic_counted.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        tic_counted.BorderStyle = BorderStyle.FixedSingle
        tic_counted.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        tic_counted.ForeColor = Color.Gray
        tic_counted.Location = New Point(649, 324)
        tic_counted.Name = "tic_counted"
        tic_counted.ReadOnly = True
        tic_counted.Size = New Size(165, 30)
        tic_counted.TabIndex = 190
        tic_counted.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(444, 326)
        Label2.Name = "Label2"
        Label2.Size = New Size(178, 23)
        Label2.TabIndex = 189
        Label2.Text = "TIC counted survive :"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Panel3.Controls.Add(Label11)
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(0, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(838, 29)
        Panel3.TabIndex = 169
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(292, 4)
        Label11.Name = "Label11"
        Label11.Size = New Size(250, 20)
        Label11.TabIndex = 159
        Label11.Text = "S E E D L I N G P R O D U C T I O N "
        ' 
        ' ListView1
        ' 
        ListView1.GridLines = True
        ListView1.Location = New Point(12, 37)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(463, 196)
        ListView1.TabIndex = 68
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(201, 57)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(190, 164)
        ListBox1.TabIndex = 57
        ' 
        ' txtproduced
        ' 
        txtproduced.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtproduced.BorderStyle = BorderStyle.FixedSingle
        txtproduced.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        txtproduced.ForeColor = Color.Gray
        txtproduced.Location = New Point(175, 324)
        txtproduced.Name = "txtproduced"
        txtproduced.ReadOnly = True
        txtproduced.Size = New Size(232, 30)
        txtproduced.TabIndex = 65
        txtproduced.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = SystemColors.GradientActiveCaption
        Label12.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(9, 327)
        Label12.Name = "Label12"
        Label12.Size = New Size(160, 23)
        Label12.TabIndex = 64
        Label12.Text = "Seedling Produce :"
        ' 
        ' txtreq
        ' 
        txtreq.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtreq.BorderStyle = BorderStyle.FixedSingle
        txtreq.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        txtreq.ForeColor = Color.Gray
        txtreq.Location = New Point(649, 361)
        txtreq.Name = "txtreq"
        txtreq.ReadOnly = True
        txtreq.Size = New Size(165, 30)
        txtreq.TabIndex = 63
        txtreq.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(460, 360)
        Label3.Name = "Label3"
        Label3.Size = New Size(163, 23)
        Label3.TabIndex = 62
        Label3.Text = "Seedling Required:"
        ' 
        ' txtmortality
        ' 
        txtmortality.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtmortality.BorderStyle = BorderStyle.FixedSingle
        txtmortality.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        txtmortality.ForeColor = Color.Gray
        txtmortality.Location = New Point(175, 360)
        txtmortality.Name = "txtmortality"
        txtmortality.ReadOnly = True
        txtmortality.Size = New Size(232, 30)
        txtmortality.TabIndex = 61
        txtmortality.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.GradientActiveCaption
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(33, 360)
        Label10.Name = "Label10"
        Label10.Size = New Size(140, 23)
        Label10.TabIndex = 60
        Label10.Text = "10 % mortality :"
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 20
        ListBox2.Location = New Point(270, 57)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(193, 164)
        ListBox2.TabIndex = 58
        ' 
        ' btnsave
        ' 
        btnsave.Location = New Point(481, 218)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(79, 31)
        btnsave.TabIndex = 246
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 25
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(461, 659)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(388, 29)
        ProgressBar1.TabIndex = 193
        ProgressBar1.Visible = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(6), CByte(85), CByte(0))
        MenuStrip1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(878, 24)
        MenuStrip1.TabIndex = 232
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' txtseedproreport
        ' 
        txtseedproreport.Location = New Point(680, 616)
        txtseedproreport.Multiline = True
        txtseedproreport.Name = "txtseedproreport"
        txtseedproreport.ScrollBars = ScrollBars.Both
        txtseedproreport.Size = New Size(132, 37)
        txtseedproreport.TabIndex = 0
        txtseedproreport.Visible = False
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(407, 241)
        txtid.Name = "txtid"
        txtid.Size = New Size(67, 27)
        txtid.TabIndex = 239
        txtid.Visible = False
        ' 
        ' txtseedcode
        ' 
        txtseedcode.Location = New Point(407, 208)
        txtseedcode.Name = "txtseedcode"
        txtseedcode.Size = New Size(67, 27)
        txtseedcode.TabIndex = 240
        txtseedcode.Visible = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(743, 40)
        Button4.Name = "Button4"
        Button4.Size = New Size(115, 58)
        Button4.TabIndex = 241
        Button4.Text = "Print Report"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Seedling_pro
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(878, 700)
        Controls.Add(Button4)
        Controls.Add(txtseedcode)
        Controls.Add(txtid)
        Controls.Add(MenuStrip1)
        Controls.Add(Panel2)
        Controls.Add(txtorg)
        Controls.Add(Label8)
        Controls.Add(txtboxinspection)
        Controls.Add(txtuniquecode)
        Controls.Add(Label9)
        Controls.Add(Label5)
        Controls.Add(Label16)
        Controls.Add(txtboxrequest)
        Controls.Add(Label1)
        Controls.Add(ProgressBar1)
        Controls.Add(txtseedproreport)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Name = "Seedling_pro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Seedling_pro"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtboxinspection As TextBox
    Friend WithEvents txtboxrequest As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtorg As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtuniquecode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtproduced As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtreq As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmortality As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents tic_counted As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents progress As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtprogress As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents txtseedproreport As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents sname As TextBox
    Friend WithEvents btndelete As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents verify As TextBox
    Friend WithEvents sproduce As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents txtseedcode As TextBox
    Friend WithEvents Button4 As Button
End Class
