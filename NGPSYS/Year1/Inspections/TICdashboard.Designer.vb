<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TICdashboard
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
        Panel11 = New Panel()
        Panel4 = New Panel()
        Button4 = New Button()
        progress3 = New TextBox()
        PictureBox3 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        PaymentToolStripMenuItem = New ToolStripMenuItem()
        AddPaymentToolStripMenuItem = New ToolStripMenuItem()
        ViewPaymentToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        Button1 = New Button()
        Panel2 = New Panel()
        Button2 = New Button()
        progess = New TextBox()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Button3 = New Button()
        progress2 = New TextBox()
        PictureBox2 = New PictureBox()
        Panel7 = New Panel()
        ProgressBar3 = New ProgressBar()
        ProgressBar2 = New ProgressBar()
        ProgressBar1 = New ProgressBar()
        Label16 = New Label()
        txtorg = New TextBox()
        Label8 = New Label()
        txtuniquecode = New TextBox()
        Label9 = New Label()
        Timer1 = New Timer(components)
        tic_counted = New TextBox()
        txtOverallPercentage = New TextBox()
        Timer2 = New Timer(components)
        mainpro = New TextBox()
        Timer3 = New Timer(components)
        btnnext = New Button()
        txtmf = New TextBox()
        txtspPayment = New TextBox()
        txt3rd_mf = New TextBox()
        txt76pe = New TextBox()
        txtyearend = New TextBox()
        PictureBox4 = New PictureBox()
        ProgressBar4 = New ProgressBar()
        Label1 = New Label()
        progress4 = New TextBox()
        Timer4 = New Timer(components)
        txtsr = New TextBox()
        Panel5 = New Panel()
        Panel6 = New Panel()
        tic = New TextBox()
        txtsitecode = New TextBox()
        Panel8 = New Panel()
        MenuStrip2 = New MenuStrip()
        Panel11.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Panel11.Controls.Add(Panel4)
        Panel11.Controls.Add(MenuStrip1)
        Panel11.Controls.Add(Panel1)
        Panel11.Controls.Add(Panel2)
        Panel11.Controls.Add(Panel3)
        Panel11.Controls.Add(Panel7)
        Panel11.Location = New Point(95, 122)
        Panel11.Margin = New Padding(3, 2, 3, 2)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(670, 458)
        Panel11.TabIndex = 59
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.GradientActiveCaption
        Panel4.Controls.Add(Button4)
        Panel4.Controls.Add(progress3)
        Panel4.Controls.Add(PictureBox3)
        Panel4.Location = New Point(378, 259)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(214, 172)
        Panel4.TabIndex = 56
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(24, 42)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(169, 90)
        Button4.TabIndex = 1
        Button4.Text = "Protection Maintennace"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' progress3
        ' 
        progress3.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        progress3.BackColor = SystemColors.GradientActiveCaption
        progress3.BorderStyle = BorderStyle.None
        progress3.Font = New Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        progress3.ForeColor = Color.Black
        progress3.Location = New Point(76, 64)
        progress3.Margin = New Padding(3, 2, 3, 2)
        progress3.Multiline = True
        progress3.Name = "progress3"
        progress3.ReadOnly = True
        progress3.Size = New Size(71, 28)
        progress3.TabIndex = 203
        progress3.Text = "0%"
        progress3.TextAlign = HorizontalAlignment.Center
        progress3.Visible = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.GradientActiveCaption
        PictureBox3.Image = My.Resources.Resources.blank
        PictureBox3.Location = New Point(53, 24)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(113, 100)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 203
        PictureBox3.TabStop = False
        PictureBox3.Visible = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        MenuStrip1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {PaymentToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(670, 28)
        MenuStrip1.TabIndex = 56
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' PaymentToolStripMenuItem
        ' 
        PaymentToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddPaymentToolStripMenuItem, ViewPaymentToolStripMenuItem})
        PaymentToolStripMenuItem.ForeColor = Color.White
        PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        PaymentToolStripMenuItem.Size = New Size(85, 24)
        PaymentToolStripMenuItem.Text = "Payment"
        ' 
        ' AddPaymentToolStripMenuItem
        ' 
        AddPaymentToolStripMenuItem.Name = "AddPaymentToolStripMenuItem"
        AddPaymentToolStripMenuItem.Size = New Size(224, 26)
        AddPaymentToolStripMenuItem.Text = "Add Payment"
        ' 
        ' ViewPaymentToolStripMenuItem
        ' 
        ViewPaymentToolStripMenuItem.Name = "ViewPaymentToolStripMenuItem"
        ViewPaymentToolStripMenuItem.Size = New Size(224, 26)
        ViewPaymentToolStripMenuItem.Text = "View Payment"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(89, 55)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(214, 172)
        Panel1.TabIndex = 54
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(23, 41)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 90)
        Button1.TabIndex = 1
        Button1.Text = "TECHNICAL  INSPECTION COMMITTEE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(progess)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(378, 55)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(214, 172)
        Panel2.TabIndex = 55
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(24, 41)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(169, 90)
        Button2.TabIndex = 2
        Button2.Text = "SEEDLING PRODUCTION"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' progess
        ' 
        progess.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        progess.BackColor = SystemColors.GradientActiveCaption
        progess.BorderStyle = BorderStyle.None
        progess.Font = New Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        progess.ForeColor = Color.Black
        progess.Location = New Point(71, 64)
        progess.Margin = New Padding(3, 2, 3, 2)
        progess.Multiline = True
        progess.Name = "progess"
        progess.ReadOnly = True
        progess.Size = New Size(71, 28)
        progess.TabIndex = 199
        progess.Text = "0%"
        progess.TextAlign = HorizontalAlignment.Center
        progess.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.GradientActiveCaption
        PictureBox1.Image = My.Resources.Resources.blank
        PictureBox1.Location = New Point(48, 24)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(113, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 196
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientActiveCaption
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(progress2)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Location = New Point(89, 259)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(214, 172)
        Panel3.TabIndex = 55
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(23, 42)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(169, 90)
        Button3.TabIndex = 1
        Button3.Text = "Plantation Establishment "
        Button3.UseVisualStyleBackColor = False
        ' 
        ' progress2
        ' 
        progress2.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        progress2.BackColor = SystemColors.GradientActiveCaption
        progress2.BorderStyle = BorderStyle.None
        progress2.Font = New Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        progress2.ForeColor = Color.Black
        progress2.Location = New Point(76, 64)
        progress2.Margin = New Padding(3, 2, 3, 2)
        progress2.Multiline = True
        progress2.Name = "progress2"
        progress2.ReadOnly = True
        progress2.Size = New Size(71, 28)
        progress2.TabIndex = 202
        progress2.Text = "0%"
        progress2.TextAlign = HorizontalAlignment.Center
        progress2.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.GradientActiveCaption
        PictureBox2.Image = My.Resources.Resources.blank
        PictureBox2.Location = New Point(54, 24)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(113, 100)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 200
        PictureBox2.TabStop = False
        PictureBox2.Visible = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Location = New Point(3, 32)
        Panel7.Margin = New Padding(3, 2, 3, 2)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(664, 422)
        Panel7.TabIndex = 60
        ' 
        ' ProgressBar3
        ' 
        ProgressBar3.Location = New Point(915, 591)
        ProgressBar3.Margin = New Padding(3, 2, 3, 2)
        ProgressBar3.Name = "ProgressBar3"
        ProgressBar3.Size = New Size(125, 29)
        ProgressBar3.TabIndex = 59
        ProgressBar3.Visible = False
        ' 
        ' ProgressBar2
        ' 
        ProgressBar2.Location = New Point(1049, 591)
        ProgressBar2.Margin = New Padding(3, 2, 3, 2)
        ProgressBar2.Name = "ProgressBar2"
        ProgressBar2.Size = New Size(125, 29)
        ProgressBar2.TabIndex = 58
        ProgressBar2.Visible = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(974, 604)
        ProgressBar1.Margin = New Padding(3, 2, 3, 2)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(125, 29)
        ProgressBar1.TabIndex = 57
        ProgressBar1.Visible = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label16.Location = New Point(8, 22)
        Label16.Name = "Label16"
        Label16.Size = New Size(580, 40)
        Label16.TabIndex = 60
        Label16.Text = "Comprehensive Site Development"
        ' 
        ' txtorg
        ' 
        txtorg.BackColor = Color.White
        txtorg.BorderStyle = BorderStyle.FixedSingle
        txtorg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtorg.Location = New Point(6, 418)
        txtorg.Margin = New Padding(3, 2, 3, 2)
        txtorg.Name = "txtorg"
        txtorg.ReadOnly = True
        txtorg.Size = New Size(385, 27)
        txtorg.TabIndex = 177
        txtorg.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        Label8.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(6, 319)
        Label8.Name = "Label8"
        Label8.Size = New Size(167, 20)
        Label8.TabIndex = 174
        Label8.Text = "Project Unique Code :"
        ' 
        ' txtuniquecode
        ' 
        txtuniquecode.BackColor = Color.White
        txtuniquecode.BorderStyle = BorderStyle.FixedSingle
        txtuniquecode.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtuniquecode.Location = New Point(6, 349)
        txtuniquecode.Margin = New Padding(3, 2, 3, 2)
        txtuniquecode.Name = "txtuniquecode"
        txtuniquecode.ReadOnly = True
        txtuniquecode.Size = New Size(385, 27)
        txtuniquecode.TabIndex = 176
        txtuniquecode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        Label9.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(6, 386)
        Label9.Name = "Label9"
        Label9.Size = New Size(175, 20)
        Label9.TabIndex = 175
        Label9.Text = "Name of Implementer :"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 25
        ' 
        ' tic_counted
        ' 
        tic_counted.Location = New Point(653, 595)
        tic_counted.Margin = New Padding(3, 2, 3, 2)
        tic_counted.Name = "tic_counted"
        tic_counted.Size = New Size(125, 27)
        tic_counted.TabIndex = 178
        tic_counted.Visible = False
        ' 
        ' txtOverallPercentage
        ' 
        txtOverallPercentage.Location = New Point(653, 628)
        txtOverallPercentage.Margin = New Padding(3, 2, 3, 2)
        txtOverallPercentage.Name = "txtOverallPercentage"
        txtOverallPercentage.Size = New Size(125, 27)
        txtOverallPercentage.TabIndex = 179
        txtOverallPercentage.Visible = False
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 25
        ' 
        ' mainpro
        ' 
        mainpro.Location = New Point(784, 628)
        mainpro.Margin = New Padding(3, 2, 3, 2)
        mainpro.Name = "mainpro"
        mainpro.Size = New Size(125, 27)
        mainpro.TabIndex = 180
        mainpro.Visible = False
        ' 
        ' Timer3
        ' 
        Timer3.Interval = 25
        ' 
        ' btnnext
        ' 
        btnnext.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnnext.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnnext.ForeColor = Color.White
        btnnext.Location = New Point(95, 722)
        btnnext.Margin = New Padding(3, 2, 3, 2)
        btnnext.Name = "btnnext"
        btnnext.Size = New Size(115, 55)
        btnnext.TabIndex = 181
        btnnext.Text = "Back"
        btnnext.UseVisualStyleBackColor = False
        ' 
        ' txtmf
        ' 
        txtmf.Location = New Point(380, 595)
        txtmf.Margin = New Padding(3, 2, 3, 2)
        txtmf.Name = "txtmf"
        txtmf.Size = New Size(125, 27)
        txtmf.TabIndex = 182
        txtmf.Visible = False
        ' 
        ' txtspPayment
        ' 
        txtspPayment.Location = New Point(380, 622)
        txtspPayment.Margin = New Padding(3, 2, 3, 2)
        txtspPayment.Name = "txtspPayment"
        txtspPayment.Size = New Size(125, 27)
        txtspPayment.TabIndex = 183
        txtspPayment.Visible = False
        ' 
        ' txt3rd_mf
        ' 
        txt3rd_mf.Location = New Point(511, 595)
        txt3rd_mf.Margin = New Padding(3, 2, 3, 2)
        txt3rd_mf.Name = "txt3rd_mf"
        txt3rd_mf.Size = New Size(125, 27)
        txt3rd_mf.TabIndex = 184
        txt3rd_mf.Visible = False
        ' 
        ' txt76pe
        ' 
        txt76pe.Location = New Point(511, 622)
        txt76pe.Margin = New Padding(3, 2, 3, 2)
        txt76pe.Name = "txt76pe"
        txt76pe.Size = New Size(125, 27)
        txt76pe.TabIndex = 185
        txt76pe.Visible = False
        ' 
        ' txtyearend
        ' 
        txtyearend.Location = New Point(242, 622)
        txtyearend.Margin = New Padding(3, 2, 3, 2)
        txtyearend.Name = "txtyearend"
        txtyearend.Size = New Size(125, 27)
        txtyearend.TabIndex = 186
        txtyearend.Visible = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.GradientActiveCaption
        PictureBox4.Image = My.Resources.Resources.blank
        PictureBox4.Location = New Point(79, 72)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(234, 209)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 204
        PictureBox4.TabStop = False
        ' 
        ' ProgressBar4
        ' 
        ProgressBar4.Location = New Point(242, 588)
        ProgressBar4.Margin = New Padding(3, 2, 3, 2)
        ProgressBar4.Name = "ProgressBar4"
        ProgressBar4.Size = New Size(125, 29)
        ProgressBar4.TabIndex = 60
        ProgressBar4.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(16, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(380, 42)
        Label1.TabIndex = 205
        Label1.Text = "S u r v i v a l  R a t i n g "
        ' 
        ' progress4
        ' 
        progress4.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        progress4.BackColor = SystemColors.GradientActiveCaption
        progress4.BorderStyle = BorderStyle.None
        progress4.Font = New Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        progress4.ForeColor = Color.Black
        progress4.Location = New Point(153, 155)
        progress4.Margin = New Padding(3, 2, 3, 2)
        progress4.Multiline = True
        progress4.Name = "progress4"
        progress4.ReadOnly = True
        progress4.Size = New Size(83, 42)
        progress4.TabIndex = 206
        progress4.Text = "0%"
        progress4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Timer4
        ' 
        Timer4.Interval = 25
        ' 
        ' txtsr
        ' 
        txtsr.Location = New Point(784, 595)
        txtsr.Margin = New Padding(3, 2, 3, 2)
        txtsr.Name = "txtsr"
        txtsr.Size = New Size(125, 27)
        txtsr.TabIndex = 207
        txtsr.Visible = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.GradientActiveCaption
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(progress4)
        Panel5.Controls.Add(PictureBox4)
        Panel5.Controls.Add(Label8)
        Panel5.Controls.Add(Label9)
        Panel5.Controls.Add(txtorg)
        Panel5.Controls.Add(txtuniquecode)
        Panel5.Location = New Point(839, 122)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(398, 459)
        Panel5.TabIndex = 208
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Panel6.Controls.Add(Label1)
        Panel6.Location = New Point(0, 0)
        Panel6.Margin = New Padding(3, 2, 3, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(398, 52)
        Panel6.TabIndex = 207
        ' 
        ' tic
        ' 
        tic.Location = New Point(978, 628)
        tic.Margin = New Padding(3, 2, 3, 2)
        tic.Name = "tic"
        tic.Size = New Size(125, 27)
        tic.TabIndex = 209
        tic.Visible = False
        ' 
        ' txtsitecode
        ' 
        txtsitecode.BackColor = Color.White
        txtsitecode.BorderStyle = BorderStyle.FixedSingle
        txtsitecode.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtsitecode.Location = New Point(594, 12)
        txtsitecode.Margin = New Padding(3, 2, 3, 2)
        txtsitecode.Multiline = True
        txtsitecode.Name = "txtsitecode"
        txtsitecode.ReadOnly = True
        txtsitecode.Size = New Size(755, 60)
        txtsitecode.TabIndex = 210
        txtsitecode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(MenuStrip2)
        Panel8.Controls.Add(tic_counted)
        Panel8.Controls.Add(ProgressBar1)
        Panel8.Controls.Add(tic)
        Panel8.Controls.Add(Panel5)
        Panel8.Controls.Add(Panel11)
        Panel8.Controls.Add(txtOverallPercentage)
        Panel8.Controls.Add(txtsr)
        Panel8.Controls.Add(mainpro)
        Panel8.Controls.Add(ProgressBar4)
        Panel8.Controls.Add(btnnext)
        Panel8.Controls.Add(txtyearend)
        Panel8.Controls.Add(txtmf)
        Panel8.Controls.Add(txt76pe)
        Panel8.Controls.Add(txtspPayment)
        Panel8.Controls.Add(ProgressBar2)
        Panel8.Controls.Add(txt3rd_mf)
        Panel8.Controls.Add(ProgressBar3)
        Panel8.Location = New Point(12, 80)
        Panel8.Margin = New Padding(3, 2, 3, 2)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(1337, 808)
        Panel8.TabIndex = 211
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        MenuStrip2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.RenderMode = ToolStripRenderMode.Professional
        MenuStrip2.Size = New Size(1337, 24)
        MenuStrip2.TabIndex = 210
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' TICdashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(1361, 900)
        Controls.Add(txtsitecode)
        Controls.Add(Label16)
        Controls.Add(Panel8)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "TICdashboard"
        WindowState = FormWindowState.Maximized
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel11 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label16 As Label
    Friend WithEvents txtorg As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtuniquecode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tic_counted As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents progess As TextBox
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents progress2 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtOverallPercentage As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents mainpro As TextBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents progress3 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnnext As Button
    Friend WithEvents txtmf As TextBox
    Friend WithEvents txtspPayment As TextBox
    Friend WithEvents txt3rd_mf As TextBox
    Friend WithEvents txt76pe As TextBox
    Friend WithEvents txtyearend As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ProgressBar4 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents progress4 As TextBox
    Friend WithEvents Timer4 As Timer
    Friend WithEvents txtsr As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents tic As TextBox
    Friend WithEvents txtsitecode As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents AddPaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewPaymentToolStripMenuItem As ToolStripMenuItem
End Class
