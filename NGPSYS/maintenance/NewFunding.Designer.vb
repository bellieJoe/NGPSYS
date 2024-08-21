<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewFunding
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
        txtfund = New TextBox()
        Label1 = New Label()
        newfundexitbtn = New Button()
        Newfundaddbtn = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bauhaus 93", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(84, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(211, 39)
        Label2.TabIndex = 14
        Label2.Text = "New Funding"
        ' 
        ' txtfund
        ' 
        txtfund.Location = New Point(84, 99)
        txtfund.Name = "txtfund"
        txtfund.Size = New Size(211, 27)
        txtfund.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 20)
        Label1.TabIndex = 12
        Label1.Text = "Funds :"
        ' 
        ' newfundexitbtn
        ' 
        newfundexitbtn.BackColor = Color.MediumAquamarine
        newfundexitbtn.ForeColor = Color.White
        newfundexitbtn.Location = New Point(187, 157)
        newfundexitbtn.Name = "newfundexitbtn"
        newfundexitbtn.Size = New Size(108, 35)
        newfundexitbtn.TabIndex = 11
        newfundexitbtn.Text = "Exit"
        newfundexitbtn.UseVisualStyleBackColor = False
        ' 
        ' Newfundaddbtn
        ' 
        Newfundaddbtn.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Newfundaddbtn.ForeColor = Color.White
        Newfundaddbtn.Location = New Point(27, 157)
        Newfundaddbtn.Name = "Newfundaddbtn"
        Newfundaddbtn.Size = New Size(108, 35)
        Newfundaddbtn.TabIndex = 10
        Newfundaddbtn.Text = "Add "
        Newfundaddbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.newfund
        PictureBox1.Location = New Point(27, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 48)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' NewFunding
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(324, 222)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(txtfund)
        Controls.Add(Label1)
        Controls.Add(newfundexitbtn)
        Controls.Add(Newfundaddbtn)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MaximizeBox = False
        MinimizeBox = False
        Name = "NewFunding"
        StartPosition = FormStartPosition.CenterScreen
        Text = "New Funding"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtfund As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents newfundexitbtn As Button
    Friend WithEvents Newfundaddbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
