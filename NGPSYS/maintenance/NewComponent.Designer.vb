<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewComponent
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
        Newcomaddbtn = New Button()
        newcomexitbtn = New Button()
        Label1 = New Label()
        txtcom = New TextBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Newcomaddbtn
        ' 
        Newcomaddbtn.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Newcomaddbtn.ForeColor = Color.White
        Newcomaddbtn.Location = New Point(13, 189)
        Newcomaddbtn.Name = "Newcomaddbtn"
        Newcomaddbtn.Size = New Size(108, 35)
        Newcomaddbtn.TabIndex = 0
        Newcomaddbtn.Text = "Add "
        Newcomaddbtn.UseVisualStyleBackColor = False
        ' 
        ' newcomexitbtn
        ' 
        newcomexitbtn.BackColor = Color.MediumAquamarine
        newcomexitbtn.ForeColor = Color.White
        newcomexitbtn.Location = New Point(229, 189)
        newcomexitbtn.Name = "newcomexitbtn"
        newcomexitbtn.Size = New Size(108, 35)
        newcomexitbtn.TabIndex = 1
        newcomexitbtn.Text = "Exit"
        newcomexitbtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 20)
        Label1.TabIndex = 2
        Label1.Text = "Component :"
        ' 
        ' txtcom
        ' 
        txtcom.Location = New Point(111, 124)
        txtcom.Name = "txtcom"
        txtcom.Size = New Size(226, 27)
        txtcom.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bauhaus 93", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(70, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(267, 39)
        Label2.TabIndex = 4
        Label2.Text = "New Component"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.newcomp
        PictureBox1.Location = New Point(25, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(39, 39)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' NewComponent
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(356, 260)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(txtcom)
        Controls.Add(Label1)
        Controls.Add(newcomexitbtn)
        Controls.Add(Newcomaddbtn)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MaximizeBox = False
        MinimizeBox = False
        Name = "NewComponent"
        StartPosition = FormStartPosition.CenterScreen
        Text = "New Component"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Newcomaddbtn As Button
    Friend WithEvents newcomexitbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
