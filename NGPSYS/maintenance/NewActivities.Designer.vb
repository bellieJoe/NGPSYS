<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewActivities
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
        Txtact = New TextBox()
        Label1 = New Label()
        newactexitbtn = New Button()
        Newactcaddbtn = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bauhaus 93", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(73, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 30)
        Label2.TabIndex = 14
        Label2.Text = "New Activities"
        ' 
        ' Txtact
        ' 
        Txtact.Location = New Point(97, 103)
        Txtact.Name = "Txtact"
        Txtact.Size = New Size(202, 23)
        Txtact.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 12
        Label1.Text = "Activities :"
        ' 
        ' newactexitbtn
        ' 
        newactexitbtn.BackColor = Color.MediumAquamarine
        newactexitbtn.ForeColor = Color.White
        newactexitbtn.Location = New Point(176, 168)
        newactexitbtn.Name = "newactexitbtn"
        newactexitbtn.Size = New Size(108, 35)
        newactexitbtn.TabIndex = 11
        newactexitbtn.Text = "Exit"
        newactexitbtn.UseVisualStyleBackColor = False
        ' 
        ' Newactcaddbtn
        ' 
        Newactcaddbtn.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Newactcaddbtn.ForeColor = Color.White
        Newactcaddbtn.Location = New Point(13, 168)
        Newactcaddbtn.Name = "Newactcaddbtn"
        Newactcaddbtn.Size = New Size(108, 35)
        Newactcaddbtn.TabIndex = 10
        Newactcaddbtn.Text = "Add "
        Newactcaddbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.newact
        PictureBox1.Location = New Point(22, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(45, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' NewActivities
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(311, 226)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Txtact)
        Controls.Add(Label1)
        Controls.Add(newactexitbtn)
        Controls.Add(Newactcaddbtn)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MaximizeBox = False
        MinimizeBox = False
        Name = "NewActivities"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NewActivities"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Txtact As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents newactexitbtn As Button
    Friend WithEvents Newactcaddbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
