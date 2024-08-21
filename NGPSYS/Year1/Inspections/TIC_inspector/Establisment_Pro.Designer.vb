<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Establisment_Pro
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
        Label16 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Btncancel = New Button()
        Btnsub = New Button()
        tict_totalseed = New TextBox()
        tic_seedpro = New TextBox()
        Label8 = New Label()
        txtuniquecode = New TextBox()
        Label9 = New Label()
        txtorg = New TextBox()
        btndone = New Button()
        MenuStrip1 = New MenuStrip()
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        btnedit = New Button()
        btnsave = New Button()
        dateinspection = New DateTimePicker()
        datereq = New DateTimePicker()
        tic_lastname = New TextBox()
        tic_mid = New TextBox()
        btndelete = New Button()
        cmbinspected = New ComboBox()
        Label5 = New Label()
        Label1 = New Label()
        Panel6 = New Panel()
        Label35 = New Label()
        tic_position = New TextBox()
        tic_name = New TextBox()
        txtid = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(12, 40)
        Label16.Name = "Label16"
        Label16.Size = New Size(600, 45)
        Label16.TabIndex = 46
        Label16.Text = "Technical Committee Inspection"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.GradientActiveCaption
        Label6.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(14, 182)
        Label6.Name = "Label6"
        Label6.Size = New Size(195, 24)
        Label6.TabIndex = 57
        Label6.Text = "Name of TIC Inspector"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.GradientActiveCaption
        Label7.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(14, 360)
        Label7.Name = "Label7"
        Label7.Size = New Size(251, 24)
        Label7.TabIndex = 59
        Label7.Text = "Job position of the inspector"
        ' 
        ' Btncancel
        ' 
        Btncancel.BackColor = SystemColors.Control
        Btncancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Btncancel.Location = New Point(466, 754)
        Btncancel.Name = "Btncancel"
        Btncancel.Size = New Size(137, 49)
        Btncancel.TabIndex = 62
        Btncancel.Text = "Cancel"
        Btncancel.UseVisualStyleBackColor = False
        ' 
        ' Btnsub
        ' 
        Btnsub.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Btnsub.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Btnsub.ForeColor = Color.White
        Btnsub.Location = New Point(296, 754)
        Btnsub.Name = "Btnsub"
        Btnsub.Size = New Size(135, 53)
        Btnsub.TabIndex = 61
        Btnsub.Text = "Submit"
        Btnsub.UseVisualStyleBackColor = False
        ' 
        ' tict_totalseed
        ' 
        tict_totalseed.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        tict_totalseed.BorderStyle = BorderStyle.None
        tict_totalseed.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        tict_totalseed.ForeColor = Color.Gray
        tict_totalseed.Location = New Point(304, 875)
        tict_totalseed.Name = "tict_totalseed"
        tict_totalseed.Size = New Size(275, 24)
        tict_totalseed.TabIndex = 52
        ' 
        ' tic_seedpro
        ' 
        tic_seedpro.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        tic_seedpro.BorderStyle = BorderStyle.None
        tic_seedpro.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        tic_seedpro.ForeColor = Color.Gray
        tic_seedpro.Location = New Point(305, 766)
        tic_seedpro.Name = "tic_seedpro"
        tic_seedpro.Size = New Size(278, 24)
        tic_seedpro.TabIndex = 52
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(16, 108)
        Label8.Name = "Label8"
        Label8.Size = New Size(167, 20)
        Label8.TabIndex = 169
        Label8.Text = "Project Unique Code :"
        ' 
        ' txtuniquecode
        ' 
        txtuniquecode.BackColor = Color.White
        txtuniquecode.BorderStyle = BorderStyle.FixedSingle
        txtuniquecode.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtuniquecode.Location = New Point(197, 107)
        txtuniquecode.Name = "txtuniquecode"
        txtuniquecode.ReadOnly = True
        txtuniquecode.Size = New Size(406, 27)
        txtuniquecode.TabIndex = 172
        txtuniquecode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(16, 153)
        Label9.Name = "Label9"
        Label9.Size = New Size(175, 20)
        Label9.TabIndex = 170
        Label9.Text = "Name of Implementer :"
        ' 
        ' txtorg
        ' 
        txtorg.BackColor = Color.White
        txtorg.BorderStyle = BorderStyle.FixedSingle
        txtorg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtorg.Location = New Point(197, 153)
        txtorg.Name = "txtorg"
        txtorg.ReadOnly = True
        txtorg.Size = New Size(406, 27)
        txtorg.TabIndex = 173
        txtorg.TextAlign = HorizontalAlignment.Center
        ' 
        ' btndone
        ' 
        btndone.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btndone.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btndone.ForeColor = Color.White
        btndone.Location = New Point(140, 754)
        btndone.Name = "btndone"
        btndone.Size = New Size(135, 53)
        btndone.TabIndex = 174
        btndone.Text = "Done"
        btndone.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(6), CByte(85), CByte(0))
        MenuStrip1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(790, 24)
        MenuStrip1.TabIndex = 175
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(320, 86)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(410, 225)
        DataGridView1.TabIndex = 60
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(btnedit)
        Panel1.Controls.Add(btnsave)
        Panel1.Controls.Add(dateinspection)
        Panel1.Controls.Add(datereq)
        Panel1.Controls.Add(tic_lastname)
        Panel1.Controls.Add(tic_mid)
        Panel1.Controls.Add(btndelete)
        Panel1.Controls.Add(cmbinspected)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(tic_position)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(tic_name)
        Panel1.Location = New Point(16, 209)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(752, 456)
        Panel1.TabIndex = 176
        ' 
        ' btnedit
        ' 
        btnedit.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnedit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnedit.ForeColor = Color.White
        btnedit.Location = New Point(320, 345)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(144, 61)
        btnedit.TabIndex = 245
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnsave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnsave.ForeColor = Color.White
        btnsave.Location = New Point(320, 343)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(144, 61)
        btnsave.TabIndex = 250
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' dateinspection
        ' 
        dateinspection.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        dateinspection.Location = New Point(14, 141)
        dateinspection.Name = "dateinspection"
        dateinspection.Size = New Size(278, 27)
        dateinspection.TabIndex = 249
        ' 
        ' datereq
        ' 
        datereq.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        datereq.Location = New Point(14, 86)
        datereq.Name = "datereq"
        datereq.Size = New Size(278, 27)
        datereq.TabIndex = 177
        ' 
        ' tic_lastname
        ' 
        tic_lastname.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        tic_lastname.BorderStyle = BorderStyle.FixedSingle
        tic_lastname.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tic_lastname.ForeColor = SystemColors.WindowText
        tic_lastname.Location = New Point(14, 304)
        tic_lastname.Name = "tic_lastname"
        tic_lastname.ReadOnly = True
        tic_lastname.Size = New Size(281, 27)
        tic_lastname.TabIndex = 248
        tic_lastname.TextAlign = HorizontalAlignment.Center
        ' 
        ' tic_mid
        ' 
        tic_mid.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        tic_mid.BorderStyle = BorderStyle.FixedSingle
        tic_mid.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tic_mid.ForeColor = SystemColors.WindowText
        tic_mid.Location = New Point(14, 258)
        tic_mid.Name = "tic_mid"
        tic_mid.ReadOnly = True
        tic_mid.Size = New Size(281, 27)
        tic_mid.TabIndex = 247
        tic_mid.TextAlign = HorizontalAlignment.Center
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.IndianRed
        btndelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btndelete.ForeColor = SystemColors.Window
        btndelete.Location = New Point(587, 343)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(143, 61)
        btndelete.TabIndex = 246
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' cmbinspected
        ' 
        cmbinspected.DropDownStyle = ComboBoxStyle.DropDownList
        cmbinspected.FormattingEnabled = True
        cmbinspected.Location = New Point(435, 52)
        cmbinspected.Name = "cmbinspected"
        cmbinspected.Size = New Size(172, 28)
        cmbinspected.TabIndex = 177
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.GradientActiveCaption
        Label5.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(14, 114)
        Label5.Name = "Label5"
        Label5.Size = New Size(195, 24)
        Label5.TabIndex = 190
        Label5.Text = "Date of TIC inspection"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientActiveCaption
        Label1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 24)
        Label1.TabIndex = 189
        Label1.Text = "Date of Stakeholders Request :"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Panel6.Controls.Add(Label35)
        Panel6.ForeColor = Color.White
        Panel6.Location = New Point(0, 1)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(752, 29)
        Panel6.TabIndex = 167
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label35.Location = New Point(234, 6)
        Label35.Name = "Label35"
        Label35.Size = New Size(185, 20)
        Label35.TabIndex = 159
        Label35.Text = "TIC PERSONNEL DETAILS"
        ' 
        ' tic_position
        ' 
        tic_position.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        tic_position.BorderStyle = BorderStyle.FixedSingle
        tic_position.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tic_position.ForeColor = SystemColors.WindowText
        tic_position.Location = New Point(14, 387)
        tic_position.Name = "tic_position"
        tic_position.ReadOnly = True
        tic_position.Size = New Size(281, 27)
        tic_position.TabIndex = 52
        tic_position.TextAlign = HorizontalAlignment.Center
        ' 
        ' tic_name
        ' 
        tic_name.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        tic_name.BorderStyle = BorderStyle.FixedSingle
        tic_name.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tic_name.Location = New Point(14, 209)
        tic_name.Name = "tic_name"
        tic_name.ReadOnly = True
        tic_name.Size = New Size(281, 27)
        tic_name.TabIndex = 52
        tic_name.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(16, 176)
        txtid.Name = "txtid"
        txtid.Size = New Size(125, 27)
        txtid.TabIndex = 251
        txtid.Visible = False
        ' 
        ' Establisment_Pro
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(790, 689)
        Controls.Add(txtid)
        Controls.Add(tict_totalseed)
        Controls.Add(Panel1)
        Controls.Add(tic_seedpro)
        Controls.Add(MenuStrip1)
        Controls.Add(txtorg)
        Controls.Add(Label8)
        Controls.Add(txtuniquecode)
        Controls.Add(Label9)
        Controls.Add(Btncancel)
        Controls.Add(Btnsub)
        Controls.Add(Label16)
        Controls.Add(btndone)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Establisment_Pro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Establisment_Pro"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label16 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Btncancel As Button
    Friend WithEvents Btnsub As Button
    Friend WithEvents paneltwo As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents tict_totalseed As TextBox
    Friend WithEvents tic_seedpro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtuniquecode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtorg As TextBox
    Friend WithEvents btndone As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tic_position As TextBox
    Friend WithEvents tic_name As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbinspected As ComboBox
    Friend WithEvents btndelete As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents tic_lastname As TextBox
    Friend WithEvents tic_mid As TextBox
    Friend WithEvents datereq As DateTimePicker
    Friend WithEvents btnsave As Button
    Friend WithEvents dateinspection As DateTimePicker
    Friend WithEvents txtid As TextBox
End Class
