<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewZone
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
        Label2 = New Label()
        txtzone = New TextBox()
        Label1 = New Label()
        newzoneexitbtn = New Button()
        Newzoneaddbtn = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bauhaus 93", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(58, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(234, 39)
        Label2.TabIndex = 14
        Label2.Text = "Add New Zone"
        ' 
        ' txtzone
        ' 
        txtzone.Location = New Point(78, 107)
        txtzone.Name = "txtzone"
        txtzone.Size = New Size(214, 27)
        txtzone.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 12
        Label1.Text = "Zone :"
        ' 
        ' newzoneexitbtn
        ' 
        newzoneexitbtn.BackColor = Color.MediumAquamarine
        newzoneexitbtn.ForeColor = Color.White
        newzoneexitbtn.Location = New Point(184, 174)
        newzoneexitbtn.Name = "newzoneexitbtn"
        newzoneexitbtn.Size = New Size(108, 35)
        newzoneexitbtn.TabIndex = 11
        newzoneexitbtn.Text = "Exit"
        newzoneexitbtn.UseVisualStyleBackColor = False
        ' 
        ' Newzoneaddbtn
        ' 
        Newzoneaddbtn.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Newzoneaddbtn.ForeColor = Color.White
        Newzoneaddbtn.Location = New Point(15, 174)
        Newzoneaddbtn.Name = "Newzoneaddbtn"
        Newzoneaddbtn.Size = New Size(108, 35)
        Newzoneaddbtn.TabIndex = 10
        Newzoneaddbtn.Text = "Add "
        Newzoneaddbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.newzone
        PictureBox1.Location = New Point(20, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(39, 39)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' NewZone
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(311, 241)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(txtzone)
        Controls.Add(Label1)
        Controls.Add(newzoneexitbtn)
        Controls.Add(Newzoneaddbtn)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ForeColor = Color.Black
        MaximizeBox = False
        MinimizeBox = False
        Name = "NewZone"
        StartPosition = FormStartPosition.CenterScreen
        Text = "New Zone"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtzone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents newzoneexitbtn As Button
    Friend WithEvents Newzoneaddbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
