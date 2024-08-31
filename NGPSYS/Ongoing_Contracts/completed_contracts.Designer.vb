<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class completed_contracts
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
        Panel2 = New Panel()
        chkall = New CheckBox()
        Button1 = New Button()
        txtrecords = New TextBox()
        cmborg = New ComboBox()
        Label1 = New Label()
        chkorg = New CheckBox()
        DataGridView1 = New DataGridView()
        Label35 = New Label()
        txtarea = New TextBox()
        Label37 = New Label()
        chkarea = New CheckBox()
        lblrow = New Label()
        Newtxtuniquecode = New TextBox()
        MenuStrip1 = New MenuStrip()
        cmbyear = New ComboBox()
        btnnext = New Button()
        txtnewcode = New TextBox()
        newtxtcode = New TextBox()
        cmbmuni = New ComboBox()
        Label34 = New Label()
        txtnewuni = New TextBox()
        Label33 = New Label()
        chkmuni = New CheckBox()
        chkyear = New CheckBox()
        Label36 = New Label()
        newyear = New DateTimePicker()
        code = New TextBox()
        Label16 = New Label()
        btnprintreport = New Button()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(chkall)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(txtrecords)
        Panel2.Controls.Add(cmborg)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(chkorg)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(Label35)
        Panel2.Controls.Add(txtarea)
        Panel2.Controls.Add(Label37)
        Panel2.Controls.Add(chkarea)
        Panel2.Controls.Add(lblrow)
        Panel2.Controls.Add(Newtxtuniquecode)
        Panel2.Controls.Add(MenuStrip1)
        Panel2.Controls.Add(cmbyear)
        Panel2.Controls.Add(btnnext)
        Panel2.Controls.Add(txtnewcode)
        Panel2.Controls.Add(newtxtcode)
        Panel2.Controls.Add(cmbmuni)
        Panel2.Controls.Add(Label34)
        Panel2.Controls.Add(txtnewuni)
        Panel2.Controls.Add(Label33)
        Panel2.Controls.Add(chkmuni)
        Panel2.Controls.Add(chkyear)
        Panel2.Controls.Add(Label36)
        Panel2.Location = New Point(12, 75)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1337, 809)
        Panel2.TabIndex = 125
        ' 
        ' chkall
        ' 
        chkall.AutoSize = True
        chkall.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        chkall.Location = New Point(849, 105)
        chkall.Margin = New Padding(3, 2, 3, 2)
        chkall.Name = "chkall"
        chkall.Size = New Size(86, 24)
        chkall.TabIndex = 284
        chkall.Text = "All Data"
        chkall.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.Font = New Font("Microsoft Sans Serif", 6F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(504, 37)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 29)
        Button1.TabIndex = 283
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtrecords
        ' 
        txtrecords.BackColor = Color.White
        txtrecords.Location = New Point(1266, 37)
        txtrecords.Margin = New Padding(3, 2, 3, 2)
        txtrecords.Name = "txtrecords"
        txtrecords.Size = New Size(65, 22)
        txtrecords.TabIndex = 187
        txtrecords.TextAlign = HorizontalAlignment.Center
        ' 
        ' cmborg
        ' 
        cmborg.DropDownStyle = ComboBoxStyle.DropDownList
        cmborg.FormattingEnabled = True
        cmborg.Items.AddRange(New Object() {"BOAC", "BUENAVISTA", "GASAN", "MOGPOG", "TORRIJOS", "STA. CRUZ"})
        cmborg.Location = New Point(371, 77)
        cmborg.Margin = New Padding(3, 2, 3, 2)
        cmborg.Name = "cmborg"
        cmborg.Size = New Size(564, 24)
        cmborg.TabIndex = 282
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(1137, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 20)
        Label1.TabIndex = 186
        Label1.Text = "No. of Records :"
        ' 
        ' chkorg
        ' 
        chkorg.AutoSize = True
        chkorg.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        chkorg.Location = New Point(370, 104)
        chkorg.Margin = New Padding(3, 2, 3, 2)
        chkorg.Name = "chkorg"
        chkorg.Size = New Size(142, 24)
        chkorg.TabIndex = 281
        chkorg.Text = "By Organization"
        chkorg.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(14, 138)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1310, 669)
        DataGridView1.TabIndex = 0
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.BackColor = Color.White
        Label35.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label35.Location = New Point(14, 39)
        Label35.Name = "Label35"
        Label35.Size = New Size(167, 20)
        Label35.TabIndex = 267
        Label35.Text = "Project Unique Code :"
        ' 
        ' txtarea
        ' 
        txtarea.Location = New Point(627, 42)
        txtarea.Margin = New Padding(3, 2, 3, 2)
        txtarea.Name = "txtarea"
        txtarea.Size = New Size(125, 22)
        txtarea.TabIndex = 280
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
        ' chkarea
        ' 
        chkarea.AutoSize = True
        chkarea.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        chkarea.Location = New Point(758, 42)
        chkarea.Margin = New Padding(3, 2, 3, 2)
        chkarea.Name = "chkarea"
        chkarea.Size = New Size(85, 24)
        chkarea.TabIndex = 279
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
        Newtxtuniquecode.Location = New Point(188, 39)
        Newtxtuniquecode.Margin = New Padding(3, 2, 3, 2)
        Newtxtuniquecode.Name = "Newtxtuniquecode"
        Newtxtuniquecode.Size = New Size(32, 22)
        Newtxtuniquecode.TabIndex = 268
        Newtxtuniquecode.TextAlign = HorizontalAlignment.Center
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
        ' cmbyear
        ' 
        cmbyear.DropDownStyle = ComboBoxStyle.DropDownList
        cmbyear.FormattingEnabled = True
        cmbyear.Location = New Point(14, 77)
        cmbyear.Margin = New Padding(3, 2, 3, 2)
        cmbyear.Name = "cmbyear"
        cmbyear.Size = New Size(151, 24)
        cmbyear.TabIndex = 275
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
        ' txtnewcode
        ' 
        txtnewcode.Location = New Point(419, 40)
        txtnewcode.Margin = New Padding(3, 2, 3, 2)
        txtnewcode.Name = "txtnewcode"
        txtnewcode.Size = New Size(65, 22)
        txtnewcode.TabIndex = 273
        txtnewcode.TextAlign = HorizontalAlignment.Center
        ' 
        ' newtxtcode
        ' 
        newtxtcode.BackColor = Color.White
        newtxtcode.Location = New Point(243, 40)
        newtxtcode.Margin = New Padding(3, 2, 3, 2)
        newtxtcode.Name = "newtxtcode"
        newtxtcode.Size = New Size(65, 22)
        newtxtcode.TabIndex = 270
        newtxtcode.TextAlign = HorizontalAlignment.Center
        ' 
        ' cmbmuni
        ' 
        cmbmuni.DropDownStyle = ComboBoxStyle.DropDownList
        cmbmuni.FormattingEnabled = True
        cmbmuni.Items.AddRange(New Object() {"BOAC", "BUENAVISTA", "GASAN", "MOGPOG", "TORRIJOS", "STA. CRUZ"})
        cmbmuni.Location = New Point(188, 77)
        cmbmuni.Margin = New Padding(3, 2, 3, 2)
        cmbmuni.Name = "cmbmuni"
        cmbmuni.Size = New Size(151, 24)
        cmbmuni.TabIndex = 276
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.BackColor = Color.White
        Label34.Location = New Point(314, 42)
        Label34.Name = "Label34"
        Label34.Size = New Size(11, 16)
        Label34.TabIndex = 271
        Label34.Text = "-"
        ' 
        ' txtnewuni
        ' 
        txtnewuni.Location = New Point(331, 40)
        txtnewuni.Margin = New Padding(3, 2, 3, 2)
        txtnewuni.Name = "txtnewuni"
        txtnewuni.Size = New Size(65, 22)
        txtnewuni.TabIndex = 272
        txtnewuni.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.BackColor = Color.White
        Label33.Location = New Point(402, 43)
        Label33.Name = "Label33"
        Label33.Size = New Size(11, 16)
        Label33.TabIndex = 274
        Label33.Text = "-"
        ' 
        ' chkmuni
        ' 
        chkmuni.AutoSize = True
        chkmuni.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        chkmuni.Location = New Point(187, 105)
        chkmuni.Margin = New Padding(3, 2, 3, 2)
        chkmuni.Name = "chkmuni"
        chkmuni.Size = New Size(138, 24)
        chkmuni.TabIndex = 278
        chkmuni.Text = "By Municipality"
        chkmuni.UseVisualStyleBackColor = True
        ' 
        ' chkyear
        ' 
        chkyear.AutoSize = True
        chkyear.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        chkyear.Location = New Point(14, 103)
        chkyear.Margin = New Padding(3, 2, 3, 2)
        chkyear.Name = "chkyear"
        chkyear.Size = New Size(84, 24)
        chkyear.TabIndex = 277
        chkyear.Text = "By Year"
        chkyear.UseVisualStyleBackColor = True
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.BackColor = Color.White
        Label36.Location = New Point(226, 42)
        Label36.Name = "Label36"
        Label36.Size = New Size(11, 16)
        Label36.TabIndex = 269
        Label36.Text = "-"
        ' 
        ' newyear
        ' 
        newyear.CustomFormat = "yyyy"
        newyear.Format = DateTimePickerFormat.Custom
        newyear.Location = New Point(670, 23)
        newyear.Margin = New Padding(3, 2, 3, 2)
        newyear.Name = "newyear"
        newyear.Size = New Size(151, 22)
        newyear.TabIndex = 122
        newyear.Visible = False
        ' 
        ' code
        ' 
        code.Location = New Point(412, 25)
        code.Margin = New Padding(3, 2, 3, 2)
        code.Name = "code"
        code.Size = New Size(236, 22)
        code.TabIndex = 127
        code.Visible = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label16.Location = New Point(21, 17)
        Label16.Name = "Label16"
        Label16.Size = New Size(344, 40)
        Label16.TabIndex = 126
        Label16.Text = "Completed Projects"
        ' 
        ' btnprintreport
        ' 
        btnprintreport.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnprintreport.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnprintreport.ForeColor = Color.White
        btnprintreport.Location = New Point(1234, 7)
        btnprintreport.Name = "btnprintreport"
        btnprintreport.Size = New Size(115, 58)
        btnprintreport.TabIndex = 266
        btnprintreport.Text = "Print Report"
        btnprintreport.UseVisualStyleBackColor = False
        ' 
        ' completed_contracts
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1361, 900)
        Controls.Add(btnprintreport)
        Controls.Add(Panel2)
        Controls.Add(code)
        Controls.Add(Label16)
        Controls.Add(newyear)
        Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "completed_contracts"
        Text = "completed_contracts"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents newyear As DateTimePicker
    Friend WithEvents Label37 As Label
    Friend WithEvents lblrow As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnnext As Button
    Friend WithEvents code As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnprintreport As Button
    Friend WithEvents txtrecords As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cmborg As ComboBox
    Friend WithEvents chkorg As CheckBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtarea As TextBox
    Friend WithEvents chkarea As CheckBox
    Friend WithEvents Newtxtuniquecode As TextBox
    Friend WithEvents cmbyear As ComboBox
    Friend WithEvents txtnewcode As TextBox
    Friend WithEvents newtxtcode As TextBox
    Friend WithEvents cmbmuni As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtnewuni As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents chkmuni As CheckBox
    Friend WithEvents chkyear As CheckBox
    Friend WithEvents Label36 As Label
    Friend WithEvents chkall As CheckBox
End Class
