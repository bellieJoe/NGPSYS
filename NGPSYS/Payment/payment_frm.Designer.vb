<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payment_frm
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
        DataGridView1 = New DataGridView()
        GroupBox5 = New GroupBox()
        chkrf = New CheckBox()
        Label3 = New Label()
        chkmf = New CheckBox()
        txtrf = New TextBox()
        txtmf = New TextBox()
        txtpc = New TextBox()
        GroupBox4 = New GroupBox()
        chkothers = New CheckBox()
        txtothers = New TextBox()
        txtamount = New TextBox()
        chklessrf = New CheckBox()
        chklessmf = New CheckBox()
        txtlessrf = New TextBox()
        txtlessmf = New TextBox()
        Label18 = New Label()
        GroupBox2 = New GroupBox()
        obdate = New DateTimePicker()
        txtob = New TextBox()
        Label1 = New Label()
        Label12 = New Label()
        GroupBox3 = New GroupBox()
        dvdate = New DateTimePicker()
        txtdv = New TextBox()
        Label4 = New Label()
        Label15 = New Label()
        GroupBox1 = New GroupBox()
        txtpayment = New TextBox()
        Label6 = New Label()
        date_released = New DateTimePicker()
        date_issued = New DateTimePicker()
        txtcheque = New TextBox()
        Label7 = New Label()
        Label10 = New Label()
        Label13 = New Label()
        txtuniquecode = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label16 = New Label()
        txtorg = New TextBox()
        lbltitle = New Label()
        txtpcy = New TextBox()
        Label2 = New Label()
        txtbal = New TextBox()
        Label5 = New Label()
        btnedit = New Button()
        btnsave = New Button()
        btndelete = New Button()
        txtid = New TextBox()
        txttitle = New TextBox()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(760, 396)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(571, 296)
        DataGridView1.TabIndex = 0
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(chkrf)
        GroupBox5.Controls.Add(Label3)
        GroupBox5.Controls.Add(chkmf)
        GroupBox5.Controls.Add(txtrf)
        GroupBox5.Controls.Add(txtmf)
        GroupBox5.Controls.Add(txtpc)
        GroupBox5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox5.Location = New Point(12, 154)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(337, 360)
        GroupBox5.TabIndex = 274
        GroupBox5.TabStop = False
        GroupBox5.Text = "Obligation Details"
        ' 
        ' chkrf
        ' 
        chkrf.AutoSize = True
        chkrf.Enabled = False
        chkrf.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        chkrf.Location = New Point(34, 196)
        chkrf.Name = "chkrf"
        chkrf.Size = New Size(174, 27)
        chkrf.TabIndex = 274
        chkrf.Text = "10% Retention Fee"
        chkrf.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(8, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 23)
        Label3.TabIndex = 275
        Label3.Text = "Amount"
        ' 
        ' chkmf
        ' 
        chkmf.AutoSize = True
        chkmf.Enabled = False
        chkmf.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        chkmf.Location = New Point(34, 98)
        chkmf.Name = "chkmf"
        chkmf.Size = New Size(194, 27)
        chkmf.TabIndex = 273
        chkmf.Text = "15% Mobilization Fee"
        chkmf.UseVisualStyleBackColor = True
        ' 
        ' txtrf
        ' 
        txtrf.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtrf.BackColor = Color.White
        txtrf.BorderStyle = BorderStyle.FixedSingle
        txtrf.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtrf.ForeColor = Color.Black
        txtrf.Location = New Point(56, 223)
        txtrf.Name = "txtrf"
        txtrf.ReadOnly = True
        txtrf.Size = New Size(238, 27)
        txtrf.TabIndex = 52
        ' 
        ' txtmf
        ' 
        txtmf.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtmf.BackColor = Color.White
        txtmf.BorderStyle = BorderStyle.FixedSingle
        txtmf.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtmf.ForeColor = Color.Black
        txtmf.Location = New Point(56, 125)
        txtmf.Name = "txtmf"
        txtmf.ReadOnly = True
        txtmf.Size = New Size(238, 27)
        txtmf.TabIndex = 52
        ' 
        ' txtpc
        ' 
        txtpc.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtpc.BackColor = Color.White
        txtpc.BorderStyle = BorderStyle.FixedSingle
        txtpc.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtpc.ForeColor = Color.Black
        txtpc.Location = New Point(8, 58)
        txtpc.Name = "txtpc"
        txtpc.ReadOnly = True
        txtpc.Size = New Size(309, 27)
        txtpc.TabIndex = 52
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(chkothers)
        GroupBox4.Controls.Add(txtothers)
        GroupBox4.Controls.Add(txtamount)
        GroupBox4.Controls.Add(chklessrf)
        GroupBox4.Controls.Add(chklessmf)
        GroupBox4.Controls.Add(txtlessrf)
        GroupBox4.Controls.Add(txtlessmf)
        GroupBox4.Controls.Add(Label18)
        GroupBox4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox4.Location = New Point(360, 154)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(380, 360)
        GroupBox4.TabIndex = 275
        GroupBox4.TabStop = False
        GroupBox4.Text = "Disbursemet Details"
        ' 
        ' chkothers
        ' 
        chkothers.AutoSize = True
        chkothers.Enabled = False
        chkothers.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        chkothers.Location = New Point(35, 271)
        chkothers.Name = "chkothers"
        chkothers.Size = New Size(80, 27)
        chkothers.TabIndex = 276
        chkothers.Text = "others"
        chkothers.UseVisualStyleBackColor = True
        ' 
        ' txtothers
        ' 
        txtothers.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtothers.BackColor = Color.White
        txtothers.BorderStyle = BorderStyle.FixedSingle
        txtothers.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtothers.ForeColor = Color.Black
        txtothers.Location = New Point(57, 298)
        txtothers.Name = "txtothers"
        txtothers.ReadOnly = True
        txtothers.Size = New Size(238, 27)
        txtothers.TabIndex = 275
        ' 
        ' txtamount
        ' 
        txtamount.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtamount.BackColor = Color.White
        txtamount.BorderStyle = BorderStyle.FixedSingle
        txtamount.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtamount.ForeColor = Color.Black
        txtamount.Location = New Point(12, 58)
        txtamount.Name = "txtamount"
        txtamount.ReadOnly = True
        txtamount.Size = New Size(282, 27)
        txtamount.TabIndex = 274
        ' 
        ' chklessrf
        ' 
        chklessrf.AutoSize = True
        chklessrf.Enabled = False
        chklessrf.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        chklessrf.Location = New Point(35, 192)
        chklessrf.Name = "chklessrf"
        chklessrf.Size = New Size(174, 27)
        chklessrf.TabIndex = 274
        chklessrf.Text = "10% Retention Fee"
        chklessrf.UseVisualStyleBackColor = True
        ' 
        ' chklessmf
        ' 
        chklessmf.AutoSize = True
        chklessmf.Enabled = False
        chklessmf.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        chklessmf.Location = New Point(35, 98)
        chklessmf.Name = "chklessmf"
        chklessmf.Size = New Size(194, 27)
        chklessmf.TabIndex = 273
        chklessmf.Text = "15% Mobilization Fee"
        chklessmf.TextAlign = ContentAlignment.MiddleRight
        chklessmf.UseVisualStyleBackColor = True
        ' 
        ' txtlessrf
        ' 
        txtlessrf.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtlessrf.BackColor = Color.White
        txtlessrf.BorderStyle = BorderStyle.FixedSingle
        txtlessrf.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtlessrf.ForeColor = Color.Black
        txtlessrf.Location = New Point(57, 219)
        txtlessrf.Name = "txtlessrf"
        txtlessrf.ReadOnly = True
        txtlessrf.Size = New Size(238, 27)
        txtlessrf.TabIndex = 52
        ' 
        ' txtlessmf
        ' 
        txtlessmf.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtlessmf.BackColor = Color.White
        txtlessmf.BorderStyle = BorderStyle.FixedSingle
        txtlessmf.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtlessmf.ForeColor = Color.Black
        txtlessmf.Location = New Point(57, 125)
        txtlessmf.Name = "txtlessmf"
        txtlessmf.ReadOnly = True
        txtlessmf.Size = New Size(238, 27)
        txtlessmf.TabIndex = 52
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = SystemColors.Control
        Label18.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(11, 31)
        Label18.Name = "Label18"
        Label18.Size = New Size(72, 23)
        Label18.TabIndex = 56
        Label18.Text = "Amount"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(obdate)
        GroupBox2.Controls.Add(txtob)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(12, 520)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(337, 172)
        GroupBox2.TabIndex = 276
        GroupBox2.TabStop = False
        GroupBox2.Text = "Obligation Details"
        ' 
        ' obdate
        ' 
        obdate.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        obdate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        obdate.Location = New Point(61, 134)
        obdate.Name = "obdate"
        obdate.Size = New Size(235, 27)
        obdate.TabIndex = 33
        ' 
        ' txtob
        ' 
        txtob.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtob.BorderStyle = BorderStyle.FixedSingle
        txtob.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtob.ForeColor = Color.Black
        txtob.Location = New Point(62, 57)
        txtob.Name = "txtob"
        txtob.Size = New Size(234, 27)
        txtob.TabIndex = 52
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(58, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 23)
        Label1.TabIndex = 56
        Label1.Text = "OB No :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = SystemColors.Control
        Label12.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(58, 108)
        Label12.Name = "Label12"
        Label12.Size = New Size(55, 23)
        Label12.TabIndex = 57
        Label12.Text = "Date :"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(dvdate)
        GroupBox3.Controls.Add(txtdv)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox3.Location = New Point(360, 520)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(380, 172)
        GroupBox3.TabIndex = 277
        GroupBox3.TabStop = False
        GroupBox3.Text = "Disbursement Details"
        ' 
        ' dvdate
        ' 
        dvdate.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dvdate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        dvdate.Location = New Point(60, 134)
        dvdate.Name = "dvdate"
        dvdate.Size = New Size(235, 27)
        dvdate.TabIndex = 33
        ' 
        ' txtdv
        ' 
        txtdv.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtdv.BorderStyle = BorderStyle.FixedSingle
        txtdv.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtdv.ForeColor = Color.Black
        txtdv.Location = New Point(61, 53)
        txtdv.Name = "txtdv"
        txtdv.Size = New Size(235, 27)
        txtdv.TabIndex = 52
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(58, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 23)
        Label4.TabIndex = 56
        Label4.Text = "DV No  :"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = SystemColors.Control
        Label15.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(57, 112)
        Label15.Name = "Label15"
        Label15.Size = New Size(55, 23)
        Label15.TabIndex = 57
        Label15.Text = "Date :"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtpayment)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(date_released)
        GroupBox1.Controls.Add(date_issued)
        GroupBox1.Controls.Add(txtcheque)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(760, 163)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(571, 214)
        GroupBox1.TabIndex = 278
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cheque Details"
        ' 
        ' txtpayment
        ' 
        txtpayment.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtpayment.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        txtpayment.BorderStyle = BorderStyle.FixedSingle
        txtpayment.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtpayment.ForeColor = Color.Black
        txtpayment.Location = New Point(301, 59)
        txtpayment.Name = "txtpayment"
        txtpayment.ReadOnly = True
        txtpayment.Size = New Size(234, 27)
        txtpayment.TabIndex = 62
        txtpayment.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.Control
        Label6.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(296, 34)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 23)
        Label6.TabIndex = 63
        Label6.Text = "Total Payment :"
        ' 
        ' date_released
        ' 
        date_released.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        date_released.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        date_released.Location = New Point(301, 134)
        date_released.Name = "date_released"
        date_released.Size = New Size(234, 27)
        date_released.TabIndex = 33
        ' 
        ' date_issued
        ' 
        date_issued.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        date_issued.CalendarTrailingForeColor = Color.Gray
        date_issued.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        date_issued.Location = New Point(42, 136)
        date_issued.Name = "date_issued"
        date_issued.Size = New Size(234, 27)
        date_issued.TabIndex = 33
        ' 
        ' txtcheque
        ' 
        txtcheque.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtcheque.BackColor = Color.White
        txtcheque.BorderStyle = BorderStyle.FixedSingle
        txtcheque.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtcheque.ForeColor = Color.Black
        txtcheque.Location = New Point(37, 60)
        txtcheque.Name = "txtcheque"
        txtcheque.ReadOnly = True
        txtcheque.Size = New Size(234, 27)
        txtcheque.TabIndex = 52
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.Control
        Label7.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(296, 108)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 23)
        Label7.TabIndex = 60
        Label7.Text = "Date Realesed :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.Control
        Label10.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(32, 34)
        Label10.Name = "Label10"
        Label10.Size = New Size(142, 23)
        Label10.TabIndex = 56
        Label10.Text = "Cheque Number "
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = SystemColors.Control
        Label13.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(37, 106)
        Label13.Name = "Label13"
        Label13.Size = New Size(104, 23)
        Label13.TabIndex = 57
        Label13.Text = "Date Issued "
        ' 
        ' txtuniquecode
        ' 
        txtuniquecode.BackColor = Color.White
        txtuniquecode.BorderStyle = BorderStyle.FixedSingle
        txtuniquecode.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtuniquecode.Location = New Point(203, 78)
        txtuniquecode.Name = "txtuniquecode"
        txtuniquecode.ReadOnly = True
        txtuniquecode.Size = New Size(537, 27)
        txtuniquecode.TabIndex = 282
        txtuniquecode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.Control
        Label8.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(22, 85)
        Label8.Name = "Label8"
        Label8.Size = New Size(167, 20)
        Label8.TabIndex = 280
        Label8.Text = "Project Unique Code :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.Control
        Label9.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(22, 113)
        Label9.Name = "Label9"
        Label9.Size = New Size(175, 20)
        Label9.TabIndex = 281
        Label9.Text = "Name of Implementer :"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Bauhaus 93", 24F, FontStyle.Underline, GraphicsUnit.Point)
        Label16.Location = New Point(16, 12)
        Label16.Name = "Label16"
        Label16.Size = New Size(305, 45)
        Label16.TabIndex = 279
        Label16.Text = "Billing Summary"
        ' 
        ' txtorg
        ' 
        txtorg.BackColor = Color.White
        txtorg.BorderStyle = BorderStyle.FixedSingle
        txtorg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtorg.Location = New Point(203, 111)
        txtorg.Name = "txtorg"
        txtorg.ReadOnly = True
        txtorg.Size = New Size(537, 27)
        txtorg.TabIndex = 283
        txtorg.TextAlign = HorizontalAlignment.Center
        ' 
        ' lbltitle
        ' 
        lbltitle.AutoSize = True
        lbltitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbltitle.Location = New Point(760, 85)
        lbltitle.Name = "lbltitle"
        lbltitle.Size = New Size(82, 41)
        lbltitle.TabIndex = 285
        lbltitle.Text = "Title"
        ' 
        ' txtpcy
        ' 
        txtpcy.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtpcy.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        txtpcy.BorderStyle = BorderStyle.FixedSingle
        txtpcy.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtpcy.ForeColor = Color.Black
        txtpcy.Location = New Point(77, 749)
        txtpcy.Name = "txtpcy"
        txtpcy.ReadOnly = True
        txtpcy.Size = New Size(234, 27)
        txtpcy.TabIndex = 286
        txtpcy.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(73, 723)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 23)
        Label2.TabIndex = 287
        Label2.Text = "Project Cost in a Year"
        ' 
        ' txtbal
        ' 
        txtbal.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtbal.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        txtbal.BorderStyle = BorderStyle.FixedSingle
        txtbal.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtbal.ForeColor = Color.Black
        txtbal.Location = New Point(422, 749)
        txtbal.Name = "txtbal"
        txtbal.ReadOnly = True
        txtbal.Size = New Size(234, 27)
        txtbal.TabIndex = 288
        txtbal.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(418, 723)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 23)
        Label5.TabIndex = 289
        Label5.Text = "Balance"
        ' 
        ' btnedit
        ' 
        btnedit.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnedit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnedit.ForeColor = Color.White
        btnedit.Location = New Point(988, 731)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(144, 61)
        btnedit.TabIndex = 294
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnsave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnsave.ForeColor = Color.White
        btnsave.Location = New Point(988, 731)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(144, 61)
        btnsave.TabIndex = 296
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.IndianRed
        btndelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btndelete.ForeColor = SystemColors.Window
        btndelete.Location = New Point(1152, 731)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(143, 61)
        btndelete.TabIndex = 295
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(318, 30)
        txtid.Name = "txtid"
        txtid.Size = New Size(125, 27)
        txtid.TabIndex = 297
        ' 
        ' txttitle
        ' 
        txttitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        txttitle.Location = New Point(760, 78)
        txttitle.Multiline = True
        txttitle.Name = "txttitle"
        txttitle.ReadOnly = True
        txttitle.Size = New Size(571, 60)
        txttitle.TabIndex = 298
        txttitle.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(1216, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(115, 58)
        Button4.TabIndex = 322
        Button4.Text = "Print Report"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' payment_frm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1343, 816)
        Controls.Add(Button4)
        Controls.Add(txttitle)
        Controls.Add(txtid)
        Controls.Add(btnedit)
        Controls.Add(btnsave)
        Controls.Add(btndelete)
        Controls.Add(txtbal)
        Controls.Add(Label5)
        Controls.Add(txtpcy)
        Controls.Add(Label2)
        Controls.Add(lbltitle)
        Controls.Add(txtuniquecode)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label16)
        Controls.Add(txtorg)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox5)
        Controls.Add(DataGridView1)
        Name = "payment_frm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "payment_frm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents chkrf As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkmf As CheckBox
    Friend WithEvents txtrf As TextBox
    Friend WithEvents txtmf As TextBox
    Friend WithEvents txtpc As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkothers As CheckBox
    Friend WithEvents txtothers As TextBox
    Friend WithEvents txtamount As TextBox
    Friend WithEvents chklessrf As CheckBox
    Friend WithEvents chklessmf As CheckBox
    Friend WithEvents txtlessrf As TextBox
    Friend WithEvents txtlessmf As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents obdate As DateTimePicker
    Friend WithEvents txtob As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dvdate As DateTimePicker
    Friend WithEvents txtdv As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents date_released As DateTimePicker
    Friend WithEvents date_issued As DateTimePicker
    Friend WithEvents txtcheque As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtpayment As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtuniquecode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtorg As TextBox
    Friend WithEvents lbltitle As Label
    Friend WithEvents txtpcy As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnedit As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents txttitle As TextBox
    Friend WithEvents Button4 As Button
End Class
