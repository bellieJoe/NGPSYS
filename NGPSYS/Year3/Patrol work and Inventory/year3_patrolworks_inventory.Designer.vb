<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class year3_patrolworks_inventory
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
        lblfilter = New Label()
        lbltype = New Label()
        Panel1 = New Panel()
        MenuStrip1 = New MenuStrip()
        Panel9 = New Panel()
        txtunit = New TextBox()
        Label10 = New Label()
        btnsubmit = New Button()
        Panel7 = New Panel()
        txttotalcost = New TextBox()
        Label5 = New Label()
        Panel5 = New Panel()
        txtnoseed = New TextBox()
        Label3 = New Label()
        Panel2 = New Panel()
        cmbcom = New ComboBox()
        Label1 = New Label()
        btnnext = New Button()
        Label7 = New Label()
        Panel1.SuspendLayout()
        Panel9.SuspendLayout()
        Panel7.SuspendLayout()
        Panel5.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblfilter
        ' 
        lblfilter.AutoSize = True
        lblfilter.Location = New Point(444, 26)
        lblfilter.Name = "lblfilter"
        lblfilter.Size = New Size(53, 20)
        lblfilter.TabIndex = 238
        lblfilter.Text = "Label2"
        ' 
        ' lbltype
        ' 
        lbltype.AutoSize = True
        lbltype.Location = New Point(389, 26)
        lbltype.Name = "lbltype"
        lbltype.Size = New Size(49, 20)
        lbltype.TabIndex = 237
        lbltype.Text = "patrol"
        lbltype.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(btnsubmit)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(btnnext)
        Panel1.Location = New Point(21, 56)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(977, 249)
        Panel1.TabIndex = 236
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        MenuStrip1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(977, 24)
        MenuStrip1.TabIndex = 223
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.GradientActiveCaption
        Panel9.Controls.Add(txtunit)
        Panel9.Controls.Add(Label10)
        Panel9.Location = New Point(580, 24)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(186, 124)
        Panel9.TabIndex = 222
        ' 
        ' txtunit
        ' 
        txtunit.Location = New Point(14, 78)
        txtunit.Name = "txtunit"
        txtunit.Size = New Size(158, 27)
        txtunit.TabIndex = 7
        txtunit.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(55, 26)
        Label10.Name = "Label10"
        Label10.Size = New Size(74, 20)
        Label10.TabIndex = 3
        Label10.Text = "Unit Cost"
        ' 
        ' btnsubmit
        ' 
        btnsubmit.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnsubmit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnsubmit.ForeColor = Color.White
        btnsubmit.Location = New Point(795, 173)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New Size(170, 63)
        btnsubmit.TabIndex = 221
        btnsubmit.Text = "Submit"
        btnsubmit.UseVisualStyleBackColor = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.GradientActiveCaption
        Panel7.Controls.Add(txttotalcost)
        Panel7.Controls.Add(Label5)
        Panel7.Location = New Point(796, 24)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(170, 125)
        Panel7.TabIndex = 174
        ' 
        ' txttotalcost
        ' 
        txttotalcost.Location = New Point(6, 79)
        txttotalcost.Name = "txttotalcost"
        txttotalcost.ReadOnly = True
        txttotalcost.Size = New Size(158, 27)
        txttotalcost.TabIndex = 8
        txttotalcost.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(47, 26)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 20)
        Label5.TabIndex = 4
        Label5.Text = "Total Cost"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.GradientActiveCaption
        Panel5.Controls.Add(txtnoseed)
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(362, 24)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(186, 124)
        Panel5.TabIndex = 172
        ' 
        ' txtnoseed
        ' 
        txtnoseed.Location = New Point(18, 78)
        txtnoseed.Name = "txtnoseed"
        txtnoseed.Size = New Size(158, 27)
        txtnoseed.TabIndex = 6
        txtnoseed.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(59, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 2
        Label3.Text = "Quantity"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(cmbcom)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(3, 23)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(344, 124)
        Panel2.TabIndex = 171
        ' 
        ' cmbcom
        ' 
        cmbcom.DropDownStyle = ComboBoxStyle.DropDownList
        cmbcom.FormattingEnabled = True
        cmbcom.Location = New Point(87, 78)
        cmbcom.Name = "cmbcom"
        cmbcom.Size = New Size(151, 28)
        cmbcom.TabIndex = 225
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(122, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 20)
        Label1.TabIndex = 0
        Label1.Text = "Activities"
        ' 
        ' btnnext
        ' 
        btnnext.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnnext.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnnext.ForeColor = Color.White
        btnnext.Location = New Point(796, 173)
        btnnext.Name = "btnnext"
        btnnext.Size = New Size(170, 63)
        btnnext.TabIndex = 224
        btnnext.Text = "Next"
        btnnext.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(21, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(362, 34)
        Label7.TabIndex = 235
        Label7.Text = "Patrol Work and Inventory"
        ' 
        ' year3_patrolworks_inventory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1018, 325)
        Controls.Add(lblfilter)
        Controls.Add(lbltype)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        Name = "year3_patrolworks_inventory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "year3_patrolworks_inventory"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblfilter As Label
    Friend WithEvents lbltype As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtunit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnsubmit As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txttotalcost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtnoseed As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbcom As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnnext As Button
    Friend WithEvents Label7 As Label
End Class
