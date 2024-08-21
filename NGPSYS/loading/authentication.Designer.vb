<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class authentication
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
        CheckBox1 = New CheckBox()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        txtpass = New TextBox()
        PictureBox1 = New PictureBox()
        txtuser = New Label()
        Label1 = New Label()
        Btncancel = New Button()
        Btnsub = New Button()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.White
        CheckBox1.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.Location = New Point(255, 20)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(63, 21)
        CheckBox1.TabIndex = 13
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(CheckBox1)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(txtpass)
        Panel2.Location = New Point(98, 169)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(323, 58)
        Panel2.TabIndex = 21
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.pass
        PictureBox3.Location = New Point(13, 9)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(40, 40)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 20
        PictureBox3.TabStop = False
        ' 
        ' txtpass
        ' 
        txtpass.BorderStyle = BorderStyle.None
        txtpass.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtpass.ForeColor = Color.Gray
        txtpass.Location = New Point(66, 15)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(235, 24)
        txtpass.TabIndex = 16
        txtpass.Text = "Enter Password"
        txtpass.UseSystemPasswordChar = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources.login
        PictureBox1.Location = New Point(220, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(61, 66)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' txtuser
        ' 
        txtuser.AutoSize = True
        txtuser.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        txtuser.Font = New Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtuser.Location = New Point(190, 87)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(121, 42)
        txtuser.TabIndex = 22
        txtuser.Text = "admin"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(144, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(233, 20)
        Label1.TabIndex = 24
        Label1.Text = "Please Enter password to proceed"
        ' 
        ' Btncancel
        ' 
        Btncancel.BackColor = SystemColors.Control
        Btncancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Btncancel.Location = New Point(286, 250)
        Btncancel.Name = "Btncancel"
        Btncancel.Size = New Size(137, 49)
        Btncancel.TabIndex = 26
        Btncancel.Text = "Cancel"
        Btncancel.UseVisualStyleBackColor = False
        ' 
        ' Btnsub
        ' 
        Btnsub.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Btnsub.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Btnsub.ForeColor = Color.White
        Btnsub.Location = New Point(98, 249)
        Btnsub.Name = "Btnsub"
        Btnsub.Size = New Size(135, 53)
        Btnsub.TabIndex = 25
        Btnsub.Text = "Submit"
        Btnsub.UseVisualStyleBackColor = False
        ' 
        ' authentication
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(521, 314)
        Controls.Add(Btncancel)
        Controls.Add(Btnsub)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(txtuser)
        Controls.Add(Panel2)
        Name = "authentication"
        StartPosition = FormStartPosition.CenterScreen
        Text = "authentication"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtuser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btncancel As Button
    Friend WithEvents Btnsub As Button
End Class
