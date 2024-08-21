<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_TICinspector
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
        Btnsavecontact = New Button()
        txtjob = New TextBox()
        Label6 = New Label()
        txtlastname = New TextBox()
        Label4 = New Label()
        txtmiddlename = New TextBox()
        Label3 = New Label()
        txtfirstname = New TextBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        MenuStrip2 = New MenuStrip()
        Btn2tic = New Button()
        btn3save = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Btnsavecontact
        ' 
        Btnsavecontact.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Btnsavecontact.ForeColor = Color.White
        Btnsavecontact.Location = New Point(297, 275)
        Btnsavecontact.Name = "Btnsavecontact"
        Btnsavecontact.Size = New Size(138, 64)
        Btnsavecontact.TabIndex = 20
        Btnsavecontact.Text = "Add"
        Btnsavecontact.UseVisualStyleBackColor = False
        ' 
        ' txtjob
        ' 
        txtjob.Location = New Point(154, 216)
        txtjob.Name = "txtjob"
        txtjob.Size = New Size(281, 27)
        txtjob.TabIndex = 19
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(27, 223)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 20)
        Label6.TabIndex = 18
        Label6.Text = "Job Position :"
        ' 
        ' txtlastname
        ' 
        txtlastname.Location = New Point(154, 183)
        txtlastname.Name = "txtlastname"
        txtlastname.Size = New Size(281, 27)
        txtlastname.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 20)
        Label4.TabIndex = 16
        Label4.Text = "Lastname :"
        ' 
        ' txtmiddlename
        ' 
        txtmiddlename.Location = New Point(154, 147)
        txtmiddlename.Name = "txtmiddlename"
        txtmiddlename.Size = New Size(281, 27)
        txtmiddlename.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 20)
        Label3.TabIndex = 14
        Label3.Text = "Middlename :"
        ' 
        ' txtfirstname
        ' 
        txtfirstname.Location = New Point(154, 111)
        txtfirstname.Name = "txtfirstname"
        txtfirstname.Size = New Size(281, 27)
        txtfirstname.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 12
        Label2.Text = "Firstname :"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.orgicon
        PictureBox1.Location = New Point(30, 49)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(87, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 34)
        Label1.TabIndex = 21
        Label1.Text = "TIC Inspector"
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.FromArgb(CByte(6), CByte(85), CByte(0))
        MenuStrip2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Padding = New Padding(6, 3, 0, 3)
        MenuStrip2.RenderMode = ToolStripRenderMode.Professional
        MenuStrip2.Size = New Size(461, 24)
        MenuStrip2.TabIndex = 230
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' Btn2tic
        ' 
        Btn2tic.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Btn2tic.ForeColor = Color.White
        Btn2tic.Location = New Point(297, 275)
        Btn2tic.Name = "Btn2tic"
        Btn2tic.Size = New Size(138, 64)
        Btn2tic.TabIndex = 231
        Btn2tic.Text = "Add"
        Btn2tic.UseVisualStyleBackColor = False
        ' 
        ' btn3save
        ' 
        btn3save.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btn3save.ForeColor = Color.White
        btn3save.Location = New Point(297, 275)
        btn3save.Name = "btn3save"
        btn3save.Size = New Size(138, 64)
        btn3save.TabIndex = 232
        btn3save.Text = "Add"
        btn3save.UseVisualStyleBackColor = False
        ' 
        ' add_TICinspector
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(461, 356)
        Controls.Add(MenuStrip2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Btnsavecontact)
        Controls.Add(txtjob)
        Controls.Add(Label6)
        Controls.Add(txtlastname)
        Controls.Add(Label4)
        Controls.Add(txtmiddlename)
        Controls.Add(Label3)
        Controls.Add(txtfirstname)
        Controls.Add(Label2)
        Controls.Add(Btn2tic)
        Controls.Add(btn3save)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ForeColor = Color.Black
        Name = "add_TICinspector"
        StartPosition = FormStartPosition.CenterScreen
        Text = "add_TICinspector"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btnsavecontact As Button
    Friend WithEvents txtjob As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmiddlename As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents Btn2tic As Button
    Friend WithEvents btn3save As Button
End Class
