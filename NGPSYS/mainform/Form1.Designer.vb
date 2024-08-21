<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        CheckBox1 = New CheckBox()
        Btnlog = New Button()
        txtuser = New TextBox()
        txtpass = New TextBox()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        Panel3 = New Panel()
        Btncancel = New Button()
        Button1 = New Button()
        PictureBox4 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        Panel4 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.White
        CheckBox1.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.Location = New Point(223, 15)
        CheckBox1.Margin = New Padding(3, 2, 3, 2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(55, 17)
        CheckBox1.TabIndex = 13
        CheckBox1.TabStop = False
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Btnlog
        ' 
        Btnlog.BackColor = Color.FromArgb(CByte(46), CByte(134), CByte(222))
        Btnlog.FlatStyle = FlatStyle.Flat
        Btnlog.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Btnlog.ForeColor = Color.White
        Btnlog.Location = New Point(47, 208)
        Btnlog.Margin = New Padding(3, 2, 3, 2)
        Btnlog.Name = "Btnlog"
        Btnlog.Size = New Size(283, 40)
        Btnlog.TabIndex = 11
        Btnlog.Text = "Log-in"
        Btnlog.UseVisualStyleBackColor = False
        ' 
        ' txtuser
        ' 
        txtuser.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtuser.BorderStyle = BorderStyle.None
        txtuser.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtuser.ForeColor = Color.Gray
        txtuser.Location = New Point(56, 12)
        txtuser.Margin = New Padding(3, 2, 3, 2)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(206, 20)
        txtuser.TabIndex = 8
        txtuser.Text = "Username"
        ' 
        ' txtpass
        ' 
        txtpass.BorderStyle = BorderStyle.None
        txtpass.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtpass.ForeColor = Color.Gray
        txtpass.Location = New Point(58, 11)
        txtpass.Margin = New Padding(3, 2, 3, 2)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(206, 20)
        txtpass.TabIndex = 9
        txtpass.Text = "Enter Password"
        txtpass.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(34), CByte(47), CByte(62))
        Label3.Font = New Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(133, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 34)
        Label3.TabIndex = 17
        Label3.Text = "Sign in"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(34), CByte(47), CByte(62))
        PictureBox1.Image = My.Resources.Resources.login
        PictureBox1.Location = New Point(158, 6)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(56, 53)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(txtuser)
        Panel1.Location = New Point(47, 94)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(283, 44)
        Panel1.TabIndex = 19
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.user1
        PictureBox2.Location = New Point(10, 8)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(35, 30)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False

        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(CheckBox1)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(txtpass)
        Panel2.Location = New Point(47, 142)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(283, 44)
        Panel2.TabIndex = 20
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.pass
        PictureBox3.Location = New Point(11, 7)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(35, 30)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 20
        PictureBox3.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(34), CByte(47), CByte(62))
        Panel3.Controls.Add(Panel1)
        Panel3.Controls.Add(Btncancel)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(Btnlog)
        Panel3.Controls.Add(Panel2)
        Panel3.Location = New Point(514, 52)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(376, 386)
        Panel3.TabIndex = 21
        ' 
        ' Btncancel
        ' 
        Btncancel.BackColor = SystemColors.Control
        Btncancel.FlatStyle = FlatStyle.Flat
        Btncancel.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Btncancel.ForeColor = Color.Black
        Btncancel.Location = New Point(47, 252)
        Btncancel.Margin = New Padding(3, 2, 3, 2)
        Btncancel.Name = "Btncancel"
        Btncancel.Size = New Size(283, 40)
        Btncancel.TabIndex = 25
        Btncancel.Text = "Cancel"
        Btncancel.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(16), CByte(172), CByte(132))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(47, 323)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(283, 41)
        Button1.TabIndex = 24
        Button1.Text = "Create new account"
        Button1.UseVisualStyleBackColor = False
        Button1.Visible = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.cropped_3_logo
        PictureBox4.Location = New Point(15, 12)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(449, 122)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 22
        PictureBox4.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bell MT", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(61, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(326, 34)
        Label1.TabIndex = 23
        Label1.Text = "Plantation Establishment"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bauhaus 93", 28.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(38, 189)
        Label2.Name = "Label2"
        Label2.Size = New Size(374, 43)
        Label2.TabIndex = 24
        Label2.Text = "MONITORING SYSTEM"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(370, 374)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(82, 22)
        Button2.TabIndex = 25
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        Button2.Visible = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(PictureBox4)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(Label2)
        Panel4.Location = New Point(14, 98)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(479, 238)
        Panel4.TabIndex = 26
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(940, 462)
        Controls.Add(Panel4)
        Controls.Add(Button2)
        Controls.Add(Panel3)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User Log-in"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Btnlog As Button
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Btncancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel4 As Panel
End Class
