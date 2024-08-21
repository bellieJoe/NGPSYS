<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class disturbances
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
        Panel1 = New Panel()
        Panel3 = New Panel()
        txtstatus = New TextBox()
        Label2 = New Label()
        MenuStrip1 = New MenuStrip()
        Panel9 = New Panel()
        txtareadamage = New TextBox()
        Label10 = New Label()
        Panel7 = New Panel()
        txttypedamage = New TextBox()
        Label5 = New Label()
        Panel2 = New Panel()
        date_occurence = New DateTimePicker()
        Label1 = New Label()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel9.SuspendLayout()
        Panel7.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(26, 73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1071, 174)
        Panel1.TabIndex = 236
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientActiveCaption
        Panel3.Controls.Add(txtstatus)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(875, 30)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(186, 124)
        Panel3.TabIndex = 224
        ' 
        ' txtstatus
        ' 
        txtstatus.Location = New Point(16, 61)
        txtstatus.Name = "txtstatus"
        txtstatus.Size = New Size(155, 27)
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
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        MenuStrip1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(1071, 24)
        MenuStrip1.TabIndex = 223
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.GradientActiveCaption
        Panel9.Controls.Add(txtareadamage)
        Panel9.Controls.Add(Label10)
        Panel9.Location = New Point(325, 31)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(186, 124)
        Panel9.TabIndex = 222
        ' 
        ' txtareadamage
        ' 
        txtareadamage.Location = New Point(14, 61)
        txtareadamage.Name = "txtareadamage"
        txtareadamage.Size = New Size(158, 27)
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
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.GradientActiveCaption
        Panel7.Controls.Add(txttypedamage)
        Panel7.Controls.Add(Label5)
        Panel7.Location = New Point(548, 30)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(291, 125)
        Panel7.TabIndex = 174
        ' 
        ' txttypedamage
        ' 
        txttypedamage.Location = New Point(13, 59)
        txttypedamage.Name = "txttypedamage"
        txttypedamage.Size = New Size(266, 27)
        txttypedamage.TabIndex = 8
        txttypedamage.TextAlign = HorizontalAlignment.Center
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
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(date_occurence)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(7, 31)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(278, 124)
        Panel2.TabIndex = 171
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
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(917, 268)
        Button3.Name = "Button3"
        Button3.Size = New Size(170, 63)
        Button3.TabIndex = 235
        Button3.Text = "Submit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.orgicon
        PictureBox1.Location = New Point(26, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 234
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(83, 13)
        Label7.Name = "Label7"
        Label7.Size = New Size(189, 34)
        Label7.TabIndex = 233
        Label7.Text = "Disturbances"
        ' 
        ' disturbances
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1132, 343)
        Controls.Add(Panel1)
        Controls.Add(Button3)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Name = "disturbances"
        StartPosition = FormStartPosition.CenterScreen
        Text = "disturbances"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtareadamage As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txttypedamage As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents date_occurence As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtstatus As TextBox
    Friend WithEvents Label2 As Label
End Class
