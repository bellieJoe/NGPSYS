<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userpass
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
        Panel3 = New Panel()
        Btnsub = New Button()
        lbluser = New Label()
        PictureBox1 = New PictureBox()
        Panel6 = New Panel()
        Panel7 = New Panel()
        PictureBox4 = New PictureBox()
        txtpass = New TextBox()
        Label4 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        txtuser = New TextBox()
        Label1 = New Label()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Btnsub)
        Panel3.Controls.Add(lbluser)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Panel1)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(12, 12)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(470, 420)
        Panel3.TabIndex = 29
        ' 
        ' Btnsub
        ' 
        Btnsub.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Btnsub.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Btnsub.ForeColor = Color.White
        Btnsub.Location = New Point(162, 351)
        Btnsub.Name = "Btnsub"
        Btnsub.Size = New Size(135, 53)
        Btnsub.TabIndex = 39
        Btnsub.Text = "add user"
        Btnsub.UseVisualStyleBackColor = False
        ' 
        ' lbluser
        ' 
        lbluser.AutoSize = True
        lbluser.BackColor = Color.White
        lbluser.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbluser.Location = New Point(170, 92)
        lbluser.Name = "lbluser"
        lbluser.Size = New Size(127, 24)
        lbluser.TabIndex = 38
        lbluser.Text = "Ordinary User"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources.login
        PictureBox1.Location = New Point(199, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(75, 71)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(Panel7)
        Panel6.Controls.Add(txtpass)
        Panel6.Location = New Point(14, 276)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(440, 53)
        Panel6.TabIndex = 31
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(PictureBox4)
        Panel7.Location = New Point(-1, -1)
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
        ' txtpass
        ' 
        txtpass.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtpass.BorderStyle = BorderStyle.None
        txtpass.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtpass.ForeColor = Color.Black
        txtpass.Location = New Point(63, 13)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(362, 24)
        txtpass.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(14, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 24)
        Label4.TabIndex = 31
        Label4.Text = "Password"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
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
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(-1, -1)
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
        txtuser.ForeColor = Color.Black
        txtuser.Location = New Point(63, 13)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(362, 24)
        txtuser.TabIndex = 8
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
        ' userpass
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(498, 463)
        Controls.Add(Panel3)
        Name = "userpass"
        StartPosition = FormStartPosition.CenterScreen
        Text = "New User"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbluser As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnsub As Button
End Class
