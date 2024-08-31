<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ongoingcon
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
        Panel2 = New Panel()
        chkall = New CheckBox()
        txtrecords = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        cmborg = New ComboBox()
        Label37 = New Label()
        chkorg = New CheckBox()
        Label35 = New Label()
        txtarea = New TextBox()
        chkarea = New CheckBox()
        lblrow = New Label()
        Newtxtuniquecode = New TextBox()
        cmbyear = New ComboBox()
        txtnewcode = New TextBox()
        cmbmuni = New ComboBox()
        txtnewuni = New TextBox()
        chkmuni = New CheckBox()
        Label36 = New Label()
        chkyear = New CheckBox()
        Label33 = New Label()
        Label34 = New Label()
        newtxtcode = New TextBox()
        MenuStrip1 = New MenuStrip()
        btnnext = New Button()
        newyear = New DateTimePicker()
        code = New TextBox()
        btnprintreport = New Button()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label16.Location = New Point(21, 22)
        Label16.Name = "Label16"
        Label16.Size = New Size(398, 40)
        Label16.TabIndex = 57
        Label16.Text = "ON - GOING PROJECTS"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(chkall)
        Panel2.Controls.Add(txtrecords)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(cmborg)
        Panel2.Controls.Add(Label37)
        Panel2.Controls.Add(chkorg)
        Panel2.Controls.Add(Label35)
        Panel2.Controls.Add(txtarea)
        Panel2.Controls.Add(chkarea)
        Panel2.Controls.Add(lblrow)
        Panel2.Controls.Add(Newtxtuniquecode)
        Panel2.Controls.Add(cmbyear)
        Panel2.Controls.Add(txtnewcode)
        Panel2.Controls.Add(cmbmuni)
        Panel2.Controls.Add(txtnewuni)
        Panel2.Controls.Add(chkmuni)
        Panel2.Controls.Add(Label36)
        Panel2.Controls.Add(chkyear)
        Panel2.Controls.Add(Label33)
        Panel2.Controls.Add(Label34)
        Panel2.Controls.Add(newtxtcode)
        Panel2.Controls.Add(MenuStrip1)
        Panel2.Controls.Add(btnnext)
        Panel2.Location = New Point(12, 80)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1337, 809)
        Panel2.TabIndex = 56
        ' 
        ' chkall
        ' 
        chkall.AutoSize = True
        chkall.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        chkall.Location = New Point(853, 108)
        chkall.Margin = New Padding(3, 2, 3, 2)
        chkall.Name = "chkall"
        chkall.Size = New Size(86, 24)
        chkall.TabIndex = 186
        chkall.Text = "All Data"
        chkall.UseVisualStyleBackColor = True
        ' 
        ' txtrecords
        ' 
        txtrecords.BackColor = Color.White
        txtrecords.Location = New Point(1253, 40)
        txtrecords.Margin = New Padding(3, 2, 3, 2)
        txtrecords.Name = "txtrecords"
        txtrecords.Size = New Size(65, 22)
        txtrecords.TabIndex = 185
        txtrecords.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(1124, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 20)
        Label1.TabIndex = 184
        Label1.Text = "No. of Records :"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.Font = New Font("Microsoft Sans Serif", 6F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(508, 40)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 29)
        Button1.TabIndex = 183
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(14, 138)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1310, 669)
        DataGridView1.TabIndex = 0
        ' 
        ' cmborg
        ' 
        cmborg.DropDownStyle = ComboBoxStyle.DropDownList
        cmborg.FormattingEnabled = True
        cmborg.Items.AddRange(New Object() {"BOAC", "BUENAVISTA", "GASAN", "MOGPOG", "TORRIJOS", "STA. CRUZ"})
        cmborg.Location = New Point(375, 80)
        cmborg.Margin = New Padding(3, 2, 3, 2)
        cmborg.Name = "cmborg"
        cmborg.Size = New Size(564, 24)
        cmborg.TabIndex = 182
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.BackColor = Color.White
        Label37.Location = New Point(23, 19)
        Label37.Name = "Label37"
        Label37.Size = New Size(55, 16)
        Label37.TabIndex = 118
        Label37.Text = "Label37"
        Label37.Visible = False
        ' 
        ' chkorg
        ' 
        chkorg.AutoSize = True
        chkorg.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        chkorg.Location = New Point(374, 107)
        chkorg.Margin = New Padding(3, 2, 3, 2)
        chkorg.Name = "chkorg"
        chkorg.Size = New Size(142, 24)
        chkorg.TabIndex = 181
        chkorg.Text = "By Organization"
        chkorg.UseVisualStyleBackColor = True
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.BackColor = Color.White
        Label35.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label35.Location = New Point(18, 42)
        Label35.Name = "Label35"
        Label35.Size = New Size(167, 20)
        Label35.TabIndex = 108
        Label35.Text = "Project Unique Code :"
        ' 
        ' txtarea
        ' 
        txtarea.Location = New Point(631, 45)
        txtarea.Margin = New Padding(3, 2, 3, 2)
        txtarea.Name = "txtarea"
        txtarea.Size = New Size(125, 22)
        txtarea.TabIndex = 180
        ' 
        ' chkarea
        ' 
        chkarea.AutoSize = True
        chkarea.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        chkarea.Location = New Point(762, 45)
        chkarea.Margin = New Padding(3, 2, 3, 2)
        chkarea.Name = "chkarea"
        chkarea.Size = New Size(85, 24)
        chkarea.TabIndex = 179
        chkarea.Text = "By Area"
        chkarea.UseVisualStyleBackColor = True
        ' 
        ' lblrow
        ' 
        lblrow.AutoSize = True
        lblrow.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(247))
        lblrow.Location = New Point(192, 562)
        lblrow.Name = "lblrow"
        lblrow.Size = New Size(55, 16)
        lblrow.TabIndex = 49
        lblrow.Text = "Label18"
        lblrow.Visible = False
        ' 
        ' Newtxtuniquecode
        ' 
        Newtxtuniquecode.BackColor = Color.White
        Newtxtuniquecode.Location = New Point(192, 42)
        Newtxtuniquecode.Margin = New Padding(3, 2, 3, 2)
        Newtxtuniquecode.Name = "Newtxtuniquecode"
        Newtxtuniquecode.Size = New Size(32, 22)
        Newtxtuniquecode.TabIndex = 109
        Newtxtuniquecode.TextAlign = HorizontalAlignment.Center
        ' 
        ' cmbyear
        ' 
        cmbyear.DropDownStyle = ComboBoxStyle.DropDownList
        cmbyear.FormattingEnabled = True
        cmbyear.Location = New Point(18, 80)
        cmbyear.Margin = New Padding(3, 2, 3, 2)
        cmbyear.Name = "cmbyear"
        cmbyear.Size = New Size(151, 24)
        cmbyear.TabIndex = 174
        ' 
        ' txtnewcode
        ' 
        txtnewcode.Location = New Point(423, 43)
        txtnewcode.Margin = New Padding(3, 2, 3, 2)
        txtnewcode.Name = "txtnewcode"
        txtnewcode.Size = New Size(65, 22)
        txtnewcode.TabIndex = 114
        txtnewcode.TextAlign = HorizontalAlignment.Center
        ' 
        ' cmbmuni
        ' 
        cmbmuni.DropDownStyle = ComboBoxStyle.DropDownList
        cmbmuni.FormattingEnabled = True
        cmbmuni.Items.AddRange(New Object() {"BOAC", "BUENAVISTA", "GASAN", "MOGPOG", "TORRIJOS", "STA. CRUZ"})
        cmbmuni.Location = New Point(192, 80)
        cmbmuni.Margin = New Padding(3, 2, 3, 2)
        cmbmuni.Name = "cmbmuni"
        cmbmuni.Size = New Size(151, 24)
        cmbmuni.TabIndex = 175
        ' 
        ' txtnewuni
        ' 
        txtnewuni.Location = New Point(335, 43)
        txtnewuni.Margin = New Padding(3, 2, 3, 2)
        txtnewuni.Name = "txtnewuni"
        txtnewuni.Size = New Size(65, 22)
        txtnewuni.TabIndex = 113
        txtnewuni.TextAlign = HorizontalAlignment.Center
        ' 
        ' chkmuni
        ' 
        chkmuni.AutoSize = True
        chkmuni.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        chkmuni.Location = New Point(191, 108)
        chkmuni.Margin = New Padding(3, 2, 3, 2)
        chkmuni.Name = "chkmuni"
        chkmuni.Size = New Size(138, 24)
        chkmuni.TabIndex = 177
        chkmuni.Text = "By Municipality"
        chkmuni.UseVisualStyleBackColor = True
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.BackColor = Color.White
        Label36.Location = New Point(230, 45)
        Label36.Name = "Label36"
        Label36.Size = New Size(11, 16)
        Label36.TabIndex = 110
        Label36.Text = "-"
        ' 
        ' chkyear
        ' 
        chkyear.AutoSize = True
        chkyear.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        chkyear.Location = New Point(18, 108)
        chkyear.Margin = New Padding(3, 2, 3, 2)
        chkyear.Name = "chkyear"
        chkyear.Size = New Size(84, 24)
        chkyear.TabIndex = 176
        chkyear.Text = "By Year"
        chkyear.UseVisualStyleBackColor = True
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.BackColor = Color.White
        Label33.Location = New Point(406, 46)
        Label33.Name = "Label33"
        Label33.Size = New Size(11, 16)
        Label33.TabIndex = 115
        Label33.Text = "-"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.BackColor = Color.White
        Label34.Location = New Point(318, 45)
        Label34.Name = "Label34"
        Label34.Size = New Size(11, 16)
        Label34.TabIndex = 112
        Label34.Text = "-"
        ' 
        ' newtxtcode
        ' 
        newtxtcode.BackColor = Color.White
        newtxtcode.Location = New Point(247, 43)
        newtxtcode.Margin = New Padding(3, 2, 3, 2)
        newtxtcode.Name = "newtxtcode"
        newtxtcode.Size = New Size(65, 22)
        newtxtcode.TabIndex = 111
        newtxtcode.TextAlign = HorizontalAlignment.Center
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1337, 24)
        MenuStrip1.TabIndex = 123
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btnnext
        ' 
        btnnext.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnnext.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnnext.ForeColor = Color.White
        btnnext.Location = New Point(41, 517)
        btnnext.Margin = New Padding(3, 2, 3, 2)
        btnnext.Name = "btnnext"
        btnnext.Size = New Size(115, 44)
        btnnext.TabIndex = 2
        btnnext.Text = "Back"
        btnnext.UseVisualStyleBackColor = False
        ' 
        ' newyear
        ' 
        newyear.CustomFormat = "yyyy"
        newyear.Format = DateTimePickerFormat.Custom
        newyear.Location = New Point(668, 28)
        newyear.Margin = New Padding(3, 2, 3, 2)
        newyear.Name = "newyear"
        newyear.Size = New Size(151, 22)
        newyear.TabIndex = 178
        newyear.Visible = False
        ' 
        ' code
        ' 
        code.Location = New Point(412, 30)
        code.Margin = New Padding(3, 2, 3, 2)
        code.Name = "code"
        code.Size = New Size(236, 22)
        code.TabIndex = 123
        code.Visible = False
        ' 
        ' btnprintreport
        ' 
        btnprintreport.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnprintreport.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnprintreport.ForeColor = Color.White
        btnprintreport.Location = New Point(1234, 11)
        btnprintreport.Name = "btnprintreport"
        btnprintreport.Size = New Size(115, 58)
        btnprintreport.TabIndex = 265
        btnprintreport.Text = "Print Report"
        btnprintreport.UseVisualStyleBackColor = False
        ' 
        ' Ongoingcon
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1361, 900)
        Controls.Add(btnprintreport)
        Controls.Add(Panel2)
        Controls.Add(code)
        Controls.Add(Label16)
        Controls.Add(newyear)
        Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Ongoingcon"
        WindowState = FormWindowState.Maximized
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label16 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label37 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txtnewcode As TextBox
    Friend WithEvents txtnewuni As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents newtxtcode As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Newtxtuniquecode As TextBox
    Friend WithEvents lblrow As Label
    Friend WithEvents btnnext As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents code As TextBox
    Friend WithEvents cmborg As ComboBox
    Friend WithEvents chkorg As CheckBox
    Friend WithEvents txtarea As TextBox
    Friend WithEvents chkarea As CheckBox
    Friend WithEvents newyear As DateTimePicker
    Friend WithEvents cmbyear As ComboBox
    Friend WithEvents cmbmuni As ComboBox
    Friend WithEvents chkmuni As CheckBox
    Friend WithEvents chkyear As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnprintreport As Button
    Friend WithEvents txtrecords As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkall As CheckBox
End Class
