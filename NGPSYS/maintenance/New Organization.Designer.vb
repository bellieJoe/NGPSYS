<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Organization
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
        Ll1 = New Label()
        Label1 = New Label()
        txtorg = New TextBox()
        txtorgcon = New TextBox()
        Label2 = New Label()
        btnaddcontact = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        txtneworgtype = New ComboBox()
        txtneworgten = New ComboBox()
        Btnconupdate = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Ll1
        ' 
        Ll1.AutoSize = True
        Ll1.Font = New Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Ll1.Location = New Point(165, 43)
        Ll1.Name = "Ll1"
        Ll1.Size = New Size(317, 42)
        Ll1.TabIndex = 0
        Ll1.Text = "New Organization"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(30, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 20)
        Label1.TabIndex = 1
        Label1.Text = "Organization Name :"
        ' 
        ' txtorg
        ' 
        txtorg.Location = New Point(201, 116)
        txtorg.Name = "txtorg"
        txtorg.Size = New Size(350, 27)
        txtorg.TabIndex = 2
        ' 
        ' txtorgcon
        ' 
        txtorgcon.Location = New Point(201, 155)
        txtorgcon.Name = "txtorgcon"
        txtorgcon.Size = New Size(221, 27)
        txtorgcon.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(30, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 20)
        Label2.TabIndex = 3
        Label2.Text = "Contact Person :"
        ' 
        ' btnaddcontact
        ' 
        btnaddcontact.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnaddcontact.ForeColor = Color.White
        btnaddcontact.Location = New Point(440, 150)
        btnaddcontact.Name = "btnaddcontact"
        btnaddcontact.Size = New Size(112, 35)
        btnaddcontact.TabIndex = 5
        btnaddcontact.Text = "Add"
        btnaddcontact.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(30, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 20)
        Label3.TabIndex = 6
        Label3.Text = "Organization Type :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(30, 299)
        Label4.Name = "Label4"
        Label4.Size = New Size(157, 20)
        Label4.TabIndex = 8
        Label4.Text = "Organization Tenure :"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(112, 393)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 48)
        Button2.TabIndex = 10
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.MediumAquamarine
        Button3.ForeColor = Color.White
        Button3.Location = New Point(362, 393)
        Button3.Name = "Button3"
        Button3.Size = New Size(120, 48)
        Button3.TabIndex = 11
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' txtneworgtype
        ' 
        txtneworgtype.FormattingEnabled = True
        txtneworgtype.Items.AddRange(New Object() {"DENR-PENRO", "Government", "LGU", "Municipal LGU", "PO"})
        txtneworgtype.Location = New Point(201, 221)
        txtneworgtype.Name = "txtneworgtype"
        txtneworgtype.Size = New Size(350, 28)
        txtneworgtype.TabIndex = 12
        ' 
        ' txtneworgten
        ' 
        txtneworgten.FormattingEnabled = True
        txtneworgten.Items.AddRange(New Object() {"CBFM", "PA", "Other Area", "CBFMA", "ISF", "Mangrove", "Protected Area", "Riverbanks", "Untenured", "Within/conciding PA"})
        txtneworgten.Location = New Point(201, 299)
        txtneworgten.Name = "txtneworgten"
        txtneworgten.Size = New Size(350, 28)
        txtneworgten.TabIndex = 13
        ' 
        ' Btnconupdate
        ' 
        Btnconupdate.Location = New Point(440, 156)
        Btnconupdate.Name = "Btnconupdate"
        Btnconupdate.Size = New Size(112, 28)
        Btnconupdate.TabIndex = 14
        Btnconupdate.Text = "Update"
        Btnconupdate.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.orgicon
        PictureBox1.Location = New Point(82, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(76, 64)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' New_Organization
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        ClientSize = New Size(591, 482)
        Controls.Add(PictureBox1)
        Controls.Add(btnaddcontact)
        Controls.Add(Btnconupdate)
        Controls.Add(txtneworgten)
        Controls.Add(txtneworgtype)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtorgcon)
        Controls.Add(Label2)
        Controls.Add(txtorg)
        Controls.Add(Label1)
        Controls.Add(Ll1)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MaximizeBox = False
        MinimizeBox = False
        Name = "New_Organization"
        StartPosition = FormStartPosition.CenterScreen
        Text = "New Organization"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Ll1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtorg As TextBox
    Friend WithEvents txtorgcon As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnaddcontact As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtneworgtype As ComboBox
    Friend WithEvents txtneworgten As ComboBox
    Friend WithEvents Btnconupdate As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
