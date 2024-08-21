<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCommodity
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
        txtcomm = New TextBox()
        Label1 = New Label()
        newcommexitbtn = New Button()
        Newcommcaddbtn = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bauhaus 93", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(74, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(266, 39)
        Label2.TabIndex = 14
        Label2.Text = "New Commodity"
        ' 
        ' txtcomm
        ' 
        txtcomm.Location = New Point(118, 99)
        txtcomm.Name = "txtcomm"
        txtcomm.Size = New Size(222, 27)
        txtcomm.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 20)
        Label1.TabIndex = 12
        Label1.Text = "Commodity :"
        ' 
        ' newcommexitbtn
        ' 
        newcommexitbtn.BackColor = Color.MediumAquamarine
        newcommexitbtn.ForeColor = Color.White
        newcommexitbtn.Location = New Point(232, 174)
        newcommexitbtn.Name = "newcommexitbtn"
        newcommexitbtn.Size = New Size(108, 35)
        newcommexitbtn.TabIndex = 11
        newcommexitbtn.Text = "Exit"
        newcommexitbtn.UseVisualStyleBackColor = False
        ' 
        ' Newcommcaddbtn
        ' 
        Newcommcaddbtn.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Newcommcaddbtn.ForeColor = Color.White
        Newcommcaddbtn.Location = New Point(16, 174)
        Newcommcaddbtn.Name = "Newcommcaddbtn"
        Newcommcaddbtn.Size = New Size(108, 35)
        Newcommcaddbtn.TabIndex = 10
        Newcommcaddbtn.Text = "Add "
        Newcommcaddbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.newcom
        PictureBox1.Location = New Point(26, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(42, 39)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' NewCommodity
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(360, 230)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(txtcomm)
        Controls.Add(Label1)
        Controls.Add(newcommexitbtn)
        Controls.Add(Newcommcaddbtn)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MaximizeBox = False
        MinimizeBox = False
        Name = "NewCommodity"
        StartPosition = FormStartPosition.CenterScreen
        Text = "New Commodity"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtcomm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents newcommexitbtn As Button
    Friend WithEvents Newcommcaddbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
