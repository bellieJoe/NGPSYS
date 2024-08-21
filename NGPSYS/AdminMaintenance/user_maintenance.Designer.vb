<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_maintenance
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
        usersdata = New DataGridView()
        btnupdate = New Button()
        btndelete = New Button()
        txtid = New TextBox()
        Label8 = New Label()
        txtemail = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtgender = New TextBox()
        txtphone = New TextBox()
        txtadd = New TextBox()
        txtuser = New TextBox()
        txtpassword = New TextBox()
        txttype = New TextBox()
        txtname = New TextBox()
        Label16 = New Label()
        Panel1 = New Panel()
        CType(usersdata, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' usersdata
        ' 
        usersdata.AllowUserToAddRows = False
        usersdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        usersdata.Location = New Point(487, 95)
        usersdata.Margin = New Padding(3, 2, 3, 2)
        usersdata.Name = "usersdata"
        usersdata.RowHeadersWidth = 51
        usersdata.RowTemplate.Height = 29
        usersdata.Size = New Size(739, 578)
        usersdata.TabIndex = 0
        ' 
        ' btnupdate
        ' 
        btnupdate.BackColor = SystemColors.Highlight
        btnupdate.ForeColor = Color.White
        btnupdate.Location = New Point(88, 621)
        btnupdate.Margin = New Padding(3, 2, 3, 2)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(117, 52)
        btnupdate.TabIndex = 1
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.IndianRed
        btndelete.ForeColor = Color.White
        btndelete.Location = New Point(250, 621)
        btndelete.Margin = New Padding(3, 2, 3, 2)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(117, 52)
        btndelete.TabIndex = 2
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(14, 68)
        txtid.Margin = New Padding(3, 2, 3, 2)
        txtid.Name = "txtid"
        txtid.Size = New Size(140, 27)
        txtid.TabIndex = 4
        txtid.Visible = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.GradientInactiveCaption
        Label8.Location = New Point(61, 540)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 20)
        Label8.TabIndex = 15
        Label8.Text = "Email :"
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(195, 537)
        txtemail.Margin = New Padding(3, 2, 3, 2)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(253, 27)
        txtemail.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.GradientInactiveCaption
        Label7.Location = New Point(61, 477)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 20)
        Label7.TabIndex = 13
        Label7.Text = "Gender :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.GradientInactiveCaption
        Label6.Location = New Point(61, 411)
        Label6.Name = "Label6"
        Label6.Size = New Size(123, 20)
        Label6.TabIndex = 12
        Label6.Text = "Phone Number :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.GradientInactiveCaption
        Label5.Location = New Point(61, 354)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 20)
        Label5.TabIndex = 11
        Label5.Text = "Address :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.GradientInactiveCaption
        Label4.Location = New Point(61, 283)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 10
        Label4.Text = "Password :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientInactiveCaption
        Label3.Location = New Point(61, 220)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 20)
        Label3.TabIndex = 9
        Label3.Text = "Username :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientInactiveCaption
        Label2.Location = New Point(61, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 20)
        Label2.TabIndex = 8
        Label2.Text = "Account Type :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientInactiveCaption
        Label1.Location = New Point(61, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 20)
        Label1.TabIndex = 4
        Label1.Text = "Name :"
        ' 
        ' txtgender
        ' 
        txtgender.Location = New Point(195, 474)
        txtgender.Margin = New Padding(3, 2, 3, 2)
        txtgender.Name = "txtgender"
        txtgender.Size = New Size(253, 27)
        txtgender.TabIndex = 6
        ' 
        ' txtphone
        ' 
        txtphone.Location = New Point(195, 408)
        txtphone.Margin = New Padding(3, 2, 3, 2)
        txtphone.Name = "txtphone"
        txtphone.Size = New Size(253, 27)
        txtphone.TabIndex = 5
        ' 
        ' txtadd
        ' 
        txtadd.Location = New Point(195, 351)
        txtadd.Margin = New Padding(3, 2, 3, 2)
        txtadd.Name = "txtadd"
        txtadd.Size = New Size(253, 27)
        txtadd.TabIndex = 4
        ' 
        ' txtuser
        ' 
        txtuser.Location = New Point(195, 217)
        txtuser.Margin = New Padding(3, 2, 3, 2)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(253, 27)
        txtuser.TabIndex = 3
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(195, 280)
        txtpassword.Margin = New Padding(3, 2, 3, 2)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(253, 27)
        txtpassword.TabIndex = 2
        ' 
        ' txttype
        ' 
        txttype.Location = New Point(195, 158)
        txttype.Margin = New Padding(3, 2, 3, 2)
        txttype.Name = "txttype"
        txttype.Size = New Size(253, 27)
        txttype.TabIndex = 1
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(195, 102)
        txtname.Margin = New Padding(3, 2, 3, 2)
        txtname.Name = "txtname"
        txtname.Size = New Size(253, 27)
        txtname.TabIndex = 0
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(14, 21)
        Label16.Name = "Label16"
        Label16.Size = New Size(322, 45)
        Label16.TabIndex = 237
        Label16.Text = "User's Credential"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientInactiveCaption
        Panel1.Location = New Point(12, 69)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1231, 629)
        Panel1.TabIndex = 238
        ' 
        ' user_maintenance
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1255, 710)
        Controls.Add(txtid)
        Controls.Add(Label8)
        Controls.Add(txtemail)
        Controls.Add(Label16)
        Controls.Add(Label7)
        Controls.Add(btndelete)
        Controls.Add(Label6)
        Controls.Add(btnupdate)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtname)
        Controls.Add(Label3)
        Controls.Add(txttype)
        Controls.Add(Label2)
        Controls.Add(txtpassword)
        Controls.Add(Label1)
        Controls.Add(txtuser)
        Controls.Add(txtgender)
        Controls.Add(txtadd)
        Controls.Add(txtphone)
        Controls.Add(usersdata)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 2, 3, 2)
        Name = "user_maintenance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "user_maintenance"
        CType(usersdata, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents usersdata As DataGridView
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtgender As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtadd As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txttype As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel1 As Panel
End Class
