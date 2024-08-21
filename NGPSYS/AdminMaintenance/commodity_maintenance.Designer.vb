<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class commodity_maintenance
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
        Label1 = New Label()
        txtname = New TextBox()
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
        txtid.Location = New Point(29, 79)
        txtid.Margin = New Padding(3, 2, 3, 2)
        txtid.Name = "txtid"
        txtid.Size = New Size(140, 27)
        txtid.TabIndex = 7
        txtid.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 20)
        Label1.TabIndex = 6
        Label1.Text = "Name :"
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(99, 131)
        txtname.Margin = New Padding(3, 2, 3, 2)
        txtname.Name = "txtname"
        txtname.Size = New Size(253, 27)
        txtname.TabIndex = 5
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.IndianRed
        btndelete.ForeColor = Color.White
        btndelete.Location = New Point(213, 252)
        btndelete.Margin = New Padding(3, 2, 3, 2)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(117, 51)
        btndelete.TabIndex = 9
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnupdate
        ' 
        btnupdate.BackColor = SystemColors.MenuHighlight
        btnupdate.ForeColor = Color.White
        btnupdate.Location = New Point(52, 252)
        btnupdate.Margin = New Padding(3, 2, 3, 2)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(117, 51)
        btnupdate.TabIndex = 8
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' usersdata
        ' 
        usersdata.AllowUserToAddRows = False
        usersdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        usersdata.Location = New Point(359, 10)
        usersdata.Margin = New Padding(3, 2, 3, 2)
        usersdata.Name = "usersdata"
        usersdata.RowHeadersWidth = 51
        usersdata.RowTemplate.Height = 29
        usersdata.Size = New Size(215, 275)
        usersdata.TabIndex = 7
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(18, 9)
        Label16.Name = "Label16"
        Label16.Size = New Size(443, 45)
        Label16.TabIndex = 240
        Label16.Text = "Commodity Information"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientInactiveCaption
        Panel1.Controls.Add(usersdata)
        Panel1.Location = New Point(15, 57)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(588, 291)
        Panel1.TabIndex = 241
        ' 
        ' commodity_maintenance
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(618, 360)
        Controls.Add(txtid)
        Controls.Add(Label16)
        Controls.Add(Label1)
        Controls.Add(txtname)
        Controls.Add(btndelete)
        Controls.Add(btnupdate)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(3, 2, 3, 2)
        Name = "commodity_maintenance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "commodity_maintenance"
        CType(usersdata, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents btndelete As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents usersdata As DataGridView
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel1 As Panel
End Class
