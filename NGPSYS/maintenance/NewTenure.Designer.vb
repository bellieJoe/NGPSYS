<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTenure
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
        txttenure = New TextBox()
        Label1 = New Label()
        newtenexitbtn = New Button()
        Newtenaddbtn = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bauhaus 93", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(80, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(193, 39)
        Label2.TabIndex = 19
        Label2.Text = "New Tenure"
        ' 
        ' txttenure
        ' 
        txttenure.Location = New Point(100, 103)
        txttenure.Name = "txttenure"
        txttenure.Size = New Size(173, 27)
        txttenure.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 17
        Label1.Text = "Tenure :"
        ' 
        ' newtenexitbtn
        ' 
        newtenexitbtn.BackColor = Color.MediumAquamarine
        newtenexitbtn.ForeColor = Color.White
        newtenexitbtn.Location = New Point(172, 158)
        newtenexitbtn.Name = "newtenexitbtn"
        newtenexitbtn.Size = New Size(108, 35)
        newtenexitbtn.TabIndex = 16
        newtenexitbtn.Text = "Exit"
        newtenexitbtn.UseVisualStyleBackColor = False
        ' 
        ' Newtenaddbtn
        ' 
        Newtenaddbtn.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Newtenaddbtn.ForeColor = Color.White
        Newtenaddbtn.Location = New Point(30, 158)
        Newtenaddbtn.Name = "Newtenaddbtn"
        Newtenaddbtn.Size = New Size(108, 35)
        Newtenaddbtn.TabIndex = 15
        Newtenaddbtn.Text = "Add "
        Newtenaddbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.newtenure
        PictureBox1.Location = New Point(23, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 46)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' NewTenure
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(296, 227)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(txttenure)
        Controls.Add(Label1)
        Controls.Add(newtenexitbtn)
        Controls.Add(Newtenaddbtn)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MaximizeBox = False
        MinimizeBox = False
        Name = "NewTenure"
        StartPosition = FormStartPosition.CenterScreen
        Text = "New Tenure"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txttenure As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents newtenexitbtn As Button
    Friend WithEvents Newtenaddbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
