<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class organization_maintenance
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
        txtid = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txttenure = New TextBox()
        txtorgtype = New TextBox()
        txtorgname = New TextBox()
        btndelete = New Button()
        btnupdate = New Button()
        usersdata = New DataGridView()
        Label16 = New Label()
        Panel1 = New Panel()
        CType(usersdata, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(21, 68)
        txtid.Margin = New Padding(3, 2, 3, 2)
        txtid.Name = "txtid"
        txtid.Size = New Size(140, 27)
        txtid.TabIndex = 4
        txtid.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 220)
        Label3.Name = "Label3"
        Label3.Size = New Size(159, 20)
        Label3.TabIndex = 9
        Label3.Text = "Organization Tenure :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 20)
        Label2.TabIndex = 8
        Label2.Text = "Organization Type :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 20)
        Label1.TabIndex = 4
        Label1.Text = "Organization Name :"
        ' 
        ' txttenure
        ' 
        txttenure.Location = New Point(202, 217)
        txttenure.Margin = New Padding(3, 2, 3, 2)
        txttenure.Name = "txttenure"
        txttenure.Size = New Size(253, 27)
        txttenure.TabIndex = 3
        ' 
        ' txtorgtype
        ' 
        txtorgtype.Location = New Point(202, 158)
        txtorgtype.Margin = New Padding(3, 2, 3, 2)
        txtorgtype.Name = "txtorgtype"
        txtorgtype.Size = New Size(253, 27)
        txtorgtype.TabIndex = 1
        ' 
        ' txtorgname
        ' 
        txtorgname.Location = New Point(202, 102)
        txtorgname.Margin = New Padding(3, 2, 3, 2)
        txtorgname.Name = "txtorgname"
        txtorgname.Size = New Size(253, 27)
        txtorgname.TabIndex = 0
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.IndianRed
        btndelete.ForeColor = Color.White
        btndelete.Location = New Point(256, 379)
        btndelete.Margin = New Padding(3, 2, 3, 2)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(117, 52)
        btndelete.TabIndex = 6
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnupdate
        ' 
        btnupdate.BackColor = SystemColors.Highlight
        btnupdate.ForeColor = Color.White
        btnupdate.Location = New Point(76, 379)
        btnupdate.Margin = New Padding(3, 2, 3, 2)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(117, 52)
        btnupdate.TabIndex = 5
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' usersdata
        ' 
        usersdata.AllowUserToAddRows = False
        usersdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        usersdata.Location = New Point(463, 17)
        usersdata.Margin = New Padding(3, 2, 3, 2)
        usersdata.Name = "usersdata"
        usersdata.RowHeadersWidth = 51
        usersdata.RowTemplate.Height = 29
        usersdata.Size = New Size(511, 346)
        usersdata.TabIndex = 4
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(12, 13)
        Label16.Name = "Label16"
        Label16.Size = New Size(475, 45)
        Label16.TabIndex = 238
        Label16.Text = "Organization Credentials"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientInactiveCaption
        Panel1.Controls.Add(txtid)
        Panel1.Controls.Add(txtorgname)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(usersdata)
        Panel1.Controls.Add(txtorgtype)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txttenure)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 68)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(996, 396)
        Panel1.TabIndex = 239
        ' 
        ' organization_maintenance
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1019, 476)
        Controls.Add(Label16)
        Controls.Add(btndelete)
        Controls.Add(btnupdate)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 2, 3, 2)
        Name = "organization_maintenance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "organization_maintenance"
        CType(usersdata, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttenure As TextBox
    Friend WithEvents txtorgtype As TextBox
    Friend WithEvents txtorgname As TextBox
    Friend WithEvents btndelete As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents usersdata As DataGridView
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel1 As Panel
End Class
