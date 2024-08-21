<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewforestdisturbances
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
        txtid = New TextBox()
        btndelete = New Button()
        txtuniquecode = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        txtorg = New TextBox()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        date_occurence = New DateTimePicker()
        Label1 = New Label()
        txttypedamage = New TextBox()
        Panel2 = New Panel()
        Label5 = New Label()
        Panel7 = New Panel()
        txtareadamage = New TextBox()
        Label10 = New Label()
        MenuStrip1 = New MenuStrip()
        Panel9 = New Panel()
        txtstatus = New TextBox()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        Panel3 = New Panel()
        Button1 = New Button()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel7.SuspendLayout()
        Panel9.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(737, 13)
        txtid.Name = "txtid"
        txtid.Size = New Size(125, 27)
        txtid.TabIndex = 310
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.IndianRed
        btndelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btndelete.ForeColor = SystemColors.Window
        btndelete.Location = New Point(773, 51)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(161, 61)
        btndelete.TabIndex = 309
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' txtuniquecode
        ' 
        txtuniquecode.BackColor = Color.White
        txtuniquecode.BorderStyle = BorderStyle.FixedSingle
        txtuniquecode.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtuniquecode.Location = New Point(202, 58)
        txtuniquecode.Name = "txtuniquecode"
        txtuniquecode.ReadOnly = True
        txtuniquecode.Size = New Size(306, 27)
        txtuniquecode.TabIndex = 306
        txtuniquecode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(21, 92)
        Label9.Name = "Label9"
        Label9.Size = New Size(175, 20)
        Label9.TabIndex = 305
        Label9.Text = "Name of Implementer :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(21, 65)
        Label8.Name = "Label8"
        Label8.Size = New Size(167, 20)
        Label8.TabIndex = 304
        Label8.Text = "Project Unique Code :"
        ' 
        ' txtorg
        ' 
        txtorg.BackColor = Color.White
        txtorg.BorderStyle = BorderStyle.FixedSingle
        txtorg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtorg.Location = New Point(202, 90)
        txtorg.Name = "txtorg"
        txtorg.ReadOnly = True
        txtorg.Size = New Size(306, 27)
        txtorg.TabIndex = 307
        txtorg.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.orgicon
        PictureBox1.Location = New Point(21, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 303
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(78, 17)
        Label7.Name = "Label7"
        Label7.Size = New Size(189, 34)
        Label7.TabIndex = 302
        Label7.Text = "Disturbances"
        ' 
        ' date_occurence
        ' 
        date_occurence.Location = New Point(15, 61)
        date_occurence.Name = "date_occurence"
        date_occurence.Size = New Size(250, 27)
        date_occurence.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(18, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 20)
        Label1.TabIndex = 0
        Label1.Text = "Date of Occurence"
        ' 
        ' txttypedamage
        ' 
        txttypedamage.Location = New Point(13, 59)
        txttypedamage.Name = "txttypedamage"
        txttypedamage.Size = New Size(252, 27)
        txttypedamage.TabIndex = 8
        txttypedamage.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(date_occurence)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(7, 31)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(291, 124)
        Panel2.TabIndex = 171
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(13, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 20)
        Label5.TabIndex = 4
        Label5.Text = "Type of Damaged"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.GradientActiveCaption
        Panel7.Controls.Add(txttypedamage)
        Panel7.Controls.Add(Label5)
        Panel7.Location = New Point(7, 316)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(291, 125)
        Panel7.TabIndex = 174
        ' 
        ' txtareadamage
        ' 
        txtareadamage.Location = New Point(14, 61)
        txtareadamage.Name = "txtareadamage"
        txtareadamage.Size = New Size(251, 27)
        txtareadamage.TabIndex = 7
        txtareadamage.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(14, 16)
        Label10.Name = "Label10"
        Label10.Size = New Size(146, 20)
        Label10.TabIndex = 3
        Label10.Text = "Area Damaged (ha)"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        MenuStrip1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(981, 24)
        MenuStrip1.TabIndex = 223
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.GradientActiveCaption
        Panel9.Controls.Add(txtareadamage)
        Panel9.Controls.Add(Label10)
        Panel9.Location = New Point(7, 173)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(291, 124)
        Panel9.TabIndex = 222
        ' 
        ' txtstatus
        ' 
        txtstatus.Location = New Point(16, 61)
        txtstatus.Name = "txtstatus"
        txtstatus.Size = New Size(249, 27)
        txtstatus.TabIndex = 7
        txtstatus.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(6, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 20)
        Label2.TabIndex = 3
        Label2.Text = "Status of Derecognition"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(304, 31)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(669, 557)
        DataGridView1.TabIndex = 225
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientActiveCaption
        Panel3.Controls.Add(txtstatus)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(7, 464)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(291, 124)
        Panel3.TabIndex = 224
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(577, 51)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 61)
        Button1.TabIndex = 308
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(21, 124)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(981, 608)
        Panel1.TabIndex = 301
        ' 
        ' viewforestdisturbances
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1023, 745)
        Controls.Add(txtid)
        Controls.Add(btndelete)
        Controls.Add(txtuniquecode)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(txtorg)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Name = "viewforestdisturbances"
        StartPosition = FormStartPosition.CenterScreen
        Text = "viewforestdisturbances"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtid As TextBox
    Friend WithEvents btndelete As Button
    Friend WithEvents txtuniquecode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtorg As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents date_occurence As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txttypedamage As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtareadamage As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtstatus As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
