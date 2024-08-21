<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_user
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
        Panel3 = New Panel()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        Panel8 = New Panel()
        CheckBox2 = New CheckBox()
        Panel9 = New Panel()
        PictureBox5 = New PictureBox()
        TextBox3 = New TextBox()
        Panel6 = New Panel()
        CheckBox1 = New CheckBox()
        Panel7 = New Panel()
        PictureBox4 = New PictureBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Panel4 = New Panel()
        Panel5 = New Panel()
        PictureBox3 = New PictureBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        txtuser = New TextBox()
        Label1 = New Label()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label6 = New Label()
        Btncancel = New Button()
        Btnsub = New Button()
        Panel10 = New Panel()
        Panel19 = New Panel()
        Panel20 = New Panel()
        PictureBox11 = New PictureBox()
        txtphonenum = New TextBox()
        Label9 = New Label()
        Panel13 = New Panel()
        Panel14 = New Panel()
        PictureBox8 = New PictureBox()
        txtaddress = New TextBox()
        Label8 = New Label()
        Panel11 = New Panel()
        Panel12 = New Panel()
        PictureBox7 = New PictureBox()
        txtlastname = New TextBox()
        Label7 = New Label()
        Label10 = New Label()
        Panel15 = New Panel()
        Panel16 = New Panel()
        PictureBox9 = New PictureBox()
        txtmiddlename = New TextBox()
        Label11 = New Label()
        Panel17 = New Panel()
        Panel18 = New Panel()
        PictureBox10 = New PictureBox()
        txtfirstname = New TextBox()
        Label12 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel10.SuspendLayout()
        Panel19.SuspendLayout()
        Panel20.SuspendLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        Panel13.SuspendLayout()
        Panel14.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel11.SuspendLayout()
        Panel12.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel15.SuspendLayout()
        Panel16.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        Panel17.SuspendLayout()
        Panel18.SuspendLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources.login
        PictureBox1.Location = New Point(199, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(75, 71)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(ComboBox1)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Panel8)
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Panel1)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(37, 33)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(470, 662)
        Panel3.TabIndex = 28
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(171, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 24)
        Label3.TabIndex = 38
        Label3.Text = "Account - Type"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"ADMIN", "ORDINARY USER"})
        ComboBox1.Location = New Point(163, 80)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 37
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(14, 472)
        Label5.Name = "Label5"
        Label5.Size = New Size(163, 24)
        Label5.TabIndex = 33
        Label5.Text = "Confirm Password"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(CheckBox2)
        Panel8.Controls.Add(Panel9)
        Panel8.Controls.Add(TextBox3)
        Panel8.Location = New Point(14, 509)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(440, 53)
        Panel8.TabIndex = 32
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(358, 15)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(67, 24)
        CheckBox2.TabIndex = 31
        CheckBox2.Text = "Show"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.White
        Panel9.Controls.Add(PictureBox5)
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(57, 53)
        Panel9.TabIndex = 29
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.pass
        PictureBox5.Location = New Point(8, 7)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(40, 40)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 21
        PictureBox5.TabStop = False
        ' 
        ' TextBox3
        ' 
        TextBox3.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.ForeColor = Color.Gray
        TextBox3.Location = New Point(63, 15)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(362, 24)
        TextBox3.TabIndex = 8
        TextBox3.Text = "Re Enter Password"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(CheckBox1)
        Panel6.Controls.Add(Panel7)
        Panel6.Controls.Add(TextBox2)
        Panel6.Location = New Point(14, 405)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(440, 53)
        Panel6.TabIndex = 31
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(358, 17)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(67, 24)
        CheckBox1.TabIndex = 30
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(PictureBox4)
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(57, 53)
        Panel7.TabIndex = 29
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.pass
        PictureBox4.Location = New Point(8, 7)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(40, 40)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 21
        PictureBox4.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.ForeColor = Color.Gray
        TextBox2.Location = New Point(63, 13)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(362, 24)
        TextBox2.TabIndex = 8
        TextBox2.Text = "Enter Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(14, 364)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 24)
        Label4.TabIndex = 31
        Label4.Text = "Password"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(TextBox1)
        Panel4.Location = New Point(14, 296)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(440, 53)
        Panel4.TabIndex = 30
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(PictureBox3)
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(57, 53)
        Panel5.TabIndex = 29
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.newcontract1
        PictureBox3.Location = New Point(9, 8)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(40, 40)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 20
        PictureBox3.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.Gray
        TextBox1.Location = New Point(63, 13)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(362, 24)
        TextBox1.TabIndex = 8
        TextBox1.Text = "Enter Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(14, 253)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 24)
        Label2.TabIndex = 29
        Label2.Text = "Email Address"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(txtuser)
        Panel1.Location = New Point(14, 181)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(440, 53)
        Panel1.TabIndex = 28
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(57, 53)
        Panel2.TabIndex = 29
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.user2
        PictureBox2.Location = New Point(9, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(40, 40)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' txtuser
        ' 
        txtuser.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtuser.BorderStyle = BorderStyle.None
        txtuser.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtuser.ForeColor = Color.Gray
        txtuser.Location = New Point(63, 13)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(362, 24)
        txtuser.TabIndex = 8
        txtuser.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(14, 152)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 24)
        Label1.TabIndex = 27
        Label1.Text = "User Name"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        RadioButton2.Location = New Point(247, 621)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(79, 24)
        RadioButton2.TabIndex = 36
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        RadioButton1.Location = New Point(129, 621)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(64, 24)
        RadioButton1.TabIndex = 35
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(14, 621)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 24)
        Label6.TabIndex = 34
        Label6.Text = "Gender :"
        ' 
        ' Btncancel
        ' 
        Btncancel.BackColor = SystemColors.Control
        Btncancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Btncancel.Location = New Point(557, 715)
        Btncancel.Name = "Btncancel"
        Btncancel.Size = New Size(137, 49)
        Btncancel.TabIndex = 23
        Btncancel.Text = "Cancel"
        Btncancel.UseVisualStyleBackColor = False
        ' 
        ' Btnsub
        ' 
        Btnsub.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Btnsub.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Btnsub.ForeColor = Color.White
        Btnsub.Location = New Point(372, 711)
        Btnsub.Name = "Btnsub"
        Btnsub.Size = New Size(135, 53)
        Btnsub.TabIndex = 22
        Btnsub.Text = "Submit"
        Btnsub.UseVisualStyleBackColor = False
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.White
        Panel10.Controls.Add(Panel19)
        Panel10.Controls.Add(Label9)
        Panel10.Controls.Add(RadioButton2)
        Panel10.Controls.Add(Panel13)
        Panel10.Controls.Add(RadioButton1)
        Panel10.Controls.Add(Label8)
        Panel10.Controls.Add(Label6)
        Panel10.Controls.Add(Panel11)
        Panel10.Controls.Add(Label7)
        Panel10.Controls.Add(Label10)
        Panel10.Controls.Add(Panel15)
        Panel10.Controls.Add(Label11)
        Panel10.Controls.Add(Panel17)
        Panel10.Controls.Add(Label12)
        Panel10.Location = New Point(557, 33)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(470, 662)
        Panel10.TabIndex = 29
        ' 
        ' Panel19
        ' 
        Panel19.BackColor = Color.White
        Panel19.BorderStyle = BorderStyle.FixedSingle
        Panel19.Controls.Add(Panel20)
        Panel19.Controls.Add(txtphonenum)
        Panel19.Location = New Point(14, 555)
        Panel19.Name = "Panel19"
        Panel19.Size = New Size(440, 53)
        Panel19.TabIndex = 41
        ' 
        ' Panel20
        ' 
        Panel20.BackColor = Color.White
        Panel20.Controls.Add(PictureBox11)
        Panel20.Location = New Point(0, 0)
        Panel20.Name = "Panel20"
        Panel20.Size = New Size(57, 53)
        Panel20.TabIndex = 29
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Image = My.Resources.Resources.newcontact
        PictureBox11.Location = New Point(9, 8)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(40, 40)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 20
        PictureBox11.TabStop = False
        ' 
        ' txtphonenum
        ' 
        txtphonenum.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtphonenum.BorderStyle = BorderStyle.None
        txtphonenum.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtphonenum.ForeColor = Color.Gray
        txtphonenum.Location = New Point(63, 13)
        txtphonenum.Name = "txtphonenum"
        txtphonenum.Size = New Size(362, 24)
        txtphonenum.TabIndex = 8
        txtphonenum.Text = "Phone number"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(14, 520)
        Label9.Name = "Label9"
        Label9.Size = New Size(79, 24)
        Label9.TabIndex = 42
        Label9.Text = "Phone #"
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.White
        Panel13.BorderStyle = BorderStyle.FixedSingle
        Panel13.Controls.Add(Panel14)
        Panel13.Controls.Add(txtaddress)
        Panel13.Location = New Point(14, 444)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(440, 53)
        Panel13.TabIndex = 39
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.White
        Panel14.Controls.Add(PictureBox8)
        Panel14.Location = New Point(0, 0)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(57, 53)
        Panel14.TabIndex = 29
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.newcontract1
        PictureBox8.Location = New Point(9, 8)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(40, 40)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 20
        PictureBox8.TabStop = False
        ' 
        ' txtaddress
        ' 
        txtaddress.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtaddress.BorderStyle = BorderStyle.None
        txtaddress.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtaddress.ForeColor = Color.Gray
        txtaddress.Location = New Point(63, 13)
        txtaddress.Name = "txtaddress"
        txtaddress.Size = New Size(362, 24)
        txtaddress.TabIndex = 8
        txtaddress.Text = "Address"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(14, 407)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 24)
        Label8.TabIndex = 40
        Label8.Text = "Address"
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.White
        Panel11.BorderStyle = BorderStyle.FixedSingle
        Panel11.Controls.Add(Panel12)
        Panel11.Controls.Add(txtlastname)
        Panel11.Location = New Point(14, 341)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(440, 53)
        Panel11.TabIndex = 31
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.White
        Panel12.Controls.Add(PictureBox7)
        Panel12.Location = New Point(0, 0)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(57, 53)
        Panel12.TabIndex = 29
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.user11
        PictureBox7.Location = New Point(9, 8)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(40, 40)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 20
        PictureBox7.TabStop = False
        ' 
        ' txtlastname
        ' 
        txtlastname.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtlastname.BorderStyle = BorderStyle.None
        txtlastname.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtlastname.ForeColor = Color.Gray
        txtlastname.Location = New Point(63, 13)
        txtlastname.Name = "txtlastname"
        txtlastname.Size = New Size(362, 24)
        txtlastname.TabIndex = 8
        txtlastname.Text = "Lastname"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(14, 11)
        Label7.Name = "Label7"
        Label7.Size = New Size(179, 35)
        Label7.TabIndex = 38
        Label7.Text = "Profile Details"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.White
        Label10.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(14, 300)
        Label10.Name = "Label10"
        Label10.Size = New Size(90, 24)
        Label10.TabIndex = 31
        Label10.Text = "Lastname"
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.White
        Panel15.BorderStyle = BorderStyle.FixedSingle
        Panel15.Controls.Add(Panel16)
        Panel15.Controls.Add(txtmiddlename)
        Panel15.Location = New Point(14, 234)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(440, 53)
        Panel15.TabIndex = 30
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = Color.White
        Panel16.Controls.Add(PictureBox9)
        Panel16.Location = New Point(0, 0)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(57, 53)
        Panel16.TabIndex = 29
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = My.Resources.Resources.user1
        PictureBox9.Location = New Point(9, 8)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(40, 40)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 20
        PictureBox9.TabStop = False
        ' 
        ' txtmiddlename
        ' 
        txtmiddlename.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtmiddlename.BorderStyle = BorderStyle.None
        txtmiddlename.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtmiddlename.ForeColor = Color.Gray
        txtmiddlename.Location = New Point(63, 13)
        txtmiddlename.Name = "txtmiddlename"
        txtmiddlename.Size = New Size(362, 24)
        txtmiddlename.TabIndex = 8
        txtmiddlename.Text = "Middlename"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.White
        Label11.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(14, 191)
        Label11.Name = "Label11"
        Label11.Size = New Size(116, 24)
        Label11.TabIndex = 29
        Label11.Text = "Middlename"
        ' 
        ' Panel17
        ' 
        Panel17.BackColor = Color.White
        Panel17.BorderStyle = BorderStyle.FixedSingle
        Panel17.Controls.Add(Panel18)
        Panel17.Controls.Add(txtfirstname)
        Panel17.Location = New Point(14, 119)
        Panel17.Name = "Panel17"
        Panel17.Size = New Size(440, 53)
        Panel17.TabIndex = 28
        ' 
        ' Panel18
        ' 
        Panel18.BackColor = Color.White
        Panel18.Controls.Add(PictureBox10)
        Panel18.Location = New Point(0, 0)
        Panel18.Name = "Panel18"
        Panel18.Size = New Size(57, 53)
        Panel18.TabIndex = 29
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Image = My.Resources.Resources.user11
        PictureBox10.Location = New Point(9, 8)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(40, 40)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 20
        PictureBox10.TabStop = False
        ' 
        ' txtfirstname
        ' 
        txtfirstname.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtfirstname.BorderStyle = BorderStyle.None
        txtfirstname.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtfirstname.ForeColor = Color.Gray
        txtfirstname.Location = New Point(63, 13)
        txtfirstname.Name = "txtfirstname"
        txtfirstname.Size = New Size(362, 24)
        txtfirstname.TabIndex = 8
        txtfirstname.Text = "Firstname"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.White
        Label12.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(14, 90)
        Label12.Name = "Label12"
        Label12.Size = New Size(99, 24)
        Label12.TabIndex = 27
        Label12.Text = "Firstname:"
        ' 
        ' add_user
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1073, 776)
        Controls.Add(Panel10)
        Controls.Add(Panel3)
        Controls.Add(Btncancel)
        Controls.Add(Btnsub)
        Name = "add_user"
        StartPosition = FormStartPosition.CenterScreen
        Text = "add_user"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel9.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel19.ResumeLayout(False)
        Panel19.PerformLayout()
        Panel20.ResumeLayout(False)
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        Panel14.ResumeLayout(False)
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel12.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel15.ResumeLayout(False)
        Panel15.PerformLayout()
        Panel16.ResumeLayout(False)
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        Panel17.ResumeLayout(False)
        Panel17.PerformLayout()
        Panel18.ResumeLayout(False)
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btncancel As Button
    Friend WithEvents Btnsub As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents txtmiddlename As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents txtphonenum As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents txtlastname As TextBox
End Class
