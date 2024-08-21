<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guest
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
        ProgressBar1 = New ProgressBar()
        userlabel = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(38, 286)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(645, 29)
        ProgressBar1.TabIndex = 0
        ' 
        ' userlabel
        ' 
        userlabel.AutoSize = True
        userlabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        userlabel.Location = New Point(71, 21)
        userlabel.Name = "userlabel"
        userlabel.Size = New Size(71, 28)
        userlabel.TabIndex = 3
        userlabel.Text = "admin"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cropped_3_logo
        PictureBox1.Location = New Point(125, 63)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(452, 118)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.login
        PictureBox2.Location = New Point(10, 10)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(55, 56)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bauhaus 93", 28.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(123, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(459, 53)
        Label2.TabIndex = 26
        Label2.Text = "MONITORING SYSTEM"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bell MT", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(149, 184)
        Label1.Name = "Label1"
        Label1.Size = New Size(405, 42)
        Label1.TabIndex = 25
        Label1.Text = "Plantation Establishment"
        ' 
        ' Guest
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(724, 335)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(userlabel)
        Controls.Add(ProgressBar1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Guest"
        Text = "Loading"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents userlabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
