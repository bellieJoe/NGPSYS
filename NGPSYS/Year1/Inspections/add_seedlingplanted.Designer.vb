<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_seedlingplanted
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
        Label14 = New Label()
        Label6 = New Label()
        Panel1 = New Panel()
        Label5 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        txtorg = New TextBox()
        Label8 = New Label()
        txtuniquecode = New TextBox()
        Label9 = New Label()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.orgicon
        PictureBox1.Location = New Point(158, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 117
        PictureBox1.TabStop = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(215, 39)
        Label14.Name = "Label14"
        Label14.Size = New Size(241, 34)
        Label14.TabIndex = 116
        Label14.Text = "Seedling Planted"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(33, 202)
        Label6.Name = "Label6"
        Label6.Size = New Size(110, 20)
        Label6.TabIndex = 204
        Label6.Text = "Species Name:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Location = New Point(33, 243)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(347, 378)
        Panel1.TabIndex = 202
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(174, 202)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 20)
        Label5.TabIndex = 203
        Label5.Text = "Died"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(437, 344)
        Button3.Name = "Button3"
        Button3.Size = New Size(137, 58)
        Button3.TabIndex = 206
        Button3.Text = "Submit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(437, 464)
        Button2.Name = "Button2"
        Button2.Size = New Size(137, 58)
        Button2.TabIndex = 205
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtorg
        ' 
        txtorg.BackColor = Color.White
        txtorg.BorderStyle = BorderStyle.FixedSingle
        txtorg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtorg.Location = New Point(197, 139)
        txtorg.Name = "txtorg"
        txtorg.ReadOnly = True
        txtorg.Size = New Size(404, 27)
        txtorg.TabIndex = 210
        txtorg.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(13, 104)
        Label8.Name = "Label8"
        Label8.Size = New Size(167, 20)
        Label8.TabIndex = 207
        Label8.Text = "Project Unique Code :"
        ' 
        ' txtuniquecode
        ' 
        txtuniquecode.BackColor = Color.White
        txtuniquecode.BorderStyle = BorderStyle.FixedSingle
        txtuniquecode.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtuniquecode.Location = New Point(198, 103)
        txtuniquecode.Name = "txtuniquecode"
        txtuniquecode.ReadOnly = True
        txtuniquecode.Size = New Size(403, 27)
        txtuniquecode.TabIndex = 209
        txtuniquecode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(15, 142)
        Label9.Name = "Label9"
        Label9.Size = New Size(175, 20)
        Label9.TabIndex = 208
        Label9.Text = "Name of Implementer :"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(416, 200)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(173, 44)
        ListBox1.TabIndex = 211
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 20
        ListBox2.Location = New Point(416, 250)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(173, 44)
        ListBox2.TabIndex = 212
        ' 
        ' add_seedlingplanted
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(625, 667)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Controls.Add(txtorg)
        Controls.Add(Label8)
        Controls.Add(txtuniquecode)
        Controls.Add(Label9)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label6)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(PictureBox1)
        Controls.Add(Label14)
        Name = "add_seedlingplanted"
        StartPosition = FormStartPosition.CenterScreen
        Text = "add_seedlingplanted"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtorg As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtuniquecode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
End Class
