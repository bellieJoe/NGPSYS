<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSpecies
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
        txtspecies = New TextBox()
        Label1 = New Label()
        newspecexitbtn = New Button()
        Newspecaddbtn = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bauhaus 93", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(90, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(204, 39)
        Label2.TabIndex = 9
        Label2.Text = "New Species"
        ' 
        ' txtspecies
        ' 
        txtspecies.Location = New Point(90, 106)
        txtspecies.Name = "txtspecies"
        txtspecies.Size = New Size(204, 27)
        txtspecies.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 7
        Label1.Text = "Species :"
        ' 
        ' newspecexitbtn
        ' 
        newspecexitbtn.BackColor = Color.MediumAquamarine
        newspecexitbtn.BackgroundImageLayout = ImageLayout.None
        newspecexitbtn.ForeColor = Color.White
        newspecexitbtn.Location = New Point(186, 164)
        newspecexitbtn.Name = "newspecexitbtn"
        newspecexitbtn.Size = New Size(108, 35)
        newspecexitbtn.TabIndex = 6
        newspecexitbtn.Text = "Exit"
        newspecexitbtn.UseVisualStyleBackColor = False
        ' 
        ' Newspecaddbtn
        ' 
        Newspecaddbtn.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Newspecaddbtn.BackgroundImageLayout = ImageLayout.None
        Newspecaddbtn.ForeColor = Color.White
        Newspecaddbtn.Location = New Point(17, 164)
        Newspecaddbtn.Name = "Newspecaddbtn"
        Newspecaddbtn.Size = New Size(108, 35)
        Newspecaddbtn.TabIndex = 5
        Newspecaddbtn.Text = "Add "
        Newspecaddbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.newspec
        PictureBox1.Location = New Point(27, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(57, 48)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' NewSpecies
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(320, 221)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(txtspecies)
        Controls.Add(Label1)
        Controls.Add(newspecexitbtn)
        Controls.Add(Newspecaddbtn)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MaximizeBox = False
        MinimizeBox = False
        Name = "NewSpecies"
        StartPosition = FormStartPosition.CenterScreen
        Text = "New Species"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtspecies As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents newspecexitbtn As Button
    Friend WithEvents Newspecaddbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
