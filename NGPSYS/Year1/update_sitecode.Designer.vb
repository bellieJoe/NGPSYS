<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_sitecode
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
        Label2 = New Label()
        txtsitecode = New TextBox()
        Label1 = New Label()
        Newcomaddbtn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.newcomp
        PictureBox1.Location = New Point(12, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(39, 39)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bauhaus 93", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(57, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(283, 39)
        Label2.TabIndex = 18
        Label2.Text = "Project Site Code"
        ' 
        ' txtsitecode
        ' 
        txtsitecode.Location = New Point(114, 117)
        txtsitecode.Name = "txtsitecode"
        txtsitecode.Size = New Size(226, 27)
        txtsitecode.TabIndex = 21
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 20
        Label1.Text = "Site Code :"
        ' 
        ' Newcomaddbtn
        ' 
        Newcomaddbtn.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Newcomaddbtn.ForeColor = Color.White
        Newcomaddbtn.Location = New Point(232, 192)
        Newcomaddbtn.Name = "Newcomaddbtn"
        Newcomaddbtn.Size = New Size(108, 35)
        Newcomaddbtn.TabIndex = 22
        Newcomaddbtn.Text = "Update"
        Newcomaddbtn.UseVisualStyleBackColor = False
        ' 
        ' update_sitecode
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(363, 260)
        Controls.Add(Newcomaddbtn)
        Controls.Add(txtsitecode)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Name = "update_sitecode"
        StartPosition = FormStartPosition.CenterScreen
        Text = "update_sitecode"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsitecode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Newcomaddbtn As Button
End Class
