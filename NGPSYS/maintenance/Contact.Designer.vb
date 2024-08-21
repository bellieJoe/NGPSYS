<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contact
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
        Label1 = New Label()
        Label2 = New Label()
        txtfirstname = New TextBox()
        txtmiddlename = New TextBox()
        Label3 = New Label()
        txtlastname = New TextBox()
        Label4 = New Label()
        txtphonenum = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        txtaddress = New TextBox()
        Btnsavecontact = New Button()
        btnexitcontact = New Button()
        Btnnewupdate = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(148, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 28)
        Label1.TabIndex = 0
        Label1.Text = "New Contact"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 15)
        Label2.TabIndex = 1
        Label2.Text = "Firstname :"
        ' 
        ' txtfirstname
        ' 
        txtfirstname.Location = New Point(136, 92)
        txtfirstname.Name = "txtfirstname"
        txtfirstname.Size = New Size(250, 23)
        txtfirstname.TabIndex = 2
        ' 
        ' txtmiddlename
        ' 
        txtmiddlename.Location = New Point(136, 125)
        txtmiddlename.Name = "txtmiddlename"
        txtmiddlename.Size = New Size(250, 23)
        txtmiddlename.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 15)
        Label3.TabIndex = 3
        Label3.Text = "Middlename :"
        ' 
        ' txtlastname
        ' 
        txtlastname.Location = New Point(136, 158)
        txtlastname.Name = "txtlastname"
        txtlastname.Size = New Size(250, 23)
        txtlastname.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(23, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 5
        Label4.Text = "Lastname :"
        ' 
        ' txtphonenum
        ' 
        txtphonenum.Location = New Point(136, 191)
        txtphonenum.Name = "txtphonenum"
        txtphonenum.Size = New Size(250, 23)
        txtphonenum.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(23, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 7
        Label5.Text = "Phone # :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(23, 237)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 9
        Label6.Text = "Address :"
        ' 
        ' txtaddress
        ' 
        txtaddress.Location = New Point(136, 230)
        txtaddress.Name = "txtaddress"
        txtaddress.Size = New Size(250, 23)
        txtaddress.TabIndex = 10
        ' 
        ' Btnsavecontact
        ' 
        Btnsavecontact.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Btnsavecontact.ForeColor = Color.White
        Btnsavecontact.Location = New Point(70, 302)
        Btnsavecontact.Name = "Btnsavecontact"
        Btnsavecontact.Size = New Size(123, 42)
        Btnsavecontact.TabIndex = 11
        Btnsavecontact.Text = "Save"
        Btnsavecontact.UseVisualStyleBackColor = False
        ' 
        ' btnexitcontact
        ' 
        btnexitcontact.BackColor = Color.MediumAquamarine
        btnexitcontact.ForeColor = Color.White
        btnexitcontact.Location = New Point(232, 302)
        btnexitcontact.Name = "btnexitcontact"
        btnexitcontact.Size = New Size(123, 42)
        btnexitcontact.TabIndex = 12
        btnexitcontact.Text = "Back"
        btnexitcontact.UseVisualStyleBackColor = False
        ' 
        ' Btnnewupdate
        ' 
        Btnnewupdate.Location = New Point(70, 302)
        Btnnewupdate.Name = "Btnnewupdate"
        Btnnewupdate.Size = New Size(123, 42)
        Btnnewupdate.TabIndex = 13
        Btnnewupdate.Text = "Update"
        Btnnewupdate.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.newcontact
        PictureBox1.Location = New Point(98, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(45, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Contact
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(410, 379)
        Controls.Add(PictureBox1)
        Controls.Add(btnexitcontact)
        Controls.Add(Btnsavecontact)
        Controls.Add(txtaddress)
        Controls.Add(Label6)
        Controls.Add(txtphonenum)
        Controls.Add(Label5)
        Controls.Add(txtlastname)
        Controls.Add(Label4)
        Controls.Add(txtmiddlename)
        Controls.Add(Label3)
        Controls.Add(txtfirstname)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Btnnewupdate)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Name = "Contact"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Contact"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtmiddlename As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtphonenum As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Btnsavecontact As Button
    Friend WithEvents btnexitcontact As Button
    Friend WithEvents Btnnewupdate As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
