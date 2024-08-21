<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Disburstment_1stquarter
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Disburstment_1stquarter))
        Label16 = New Label()
        Label2 = New Label()
        txtpayment = New TextBox()
        Label1 = New Label()
        date_issued = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        txtcheque = New TextBox()
        date_released = New DateTimePicker()
        Label3 = New Label()
        txtbill = New TextBox()
        Btnsub = New Button()
        Label8 = New Label()
        Label9 = New Label()
        txtorg = New TextBox()
        txtuniquecode = New TextBox()
        MenuStrip1 = New MenuStrip()
        obdate = New DateTimePicker()
        Label11 = New Label()
        txtob = New TextBox()
        Label12 = New Label()
        dvdate = New DateTimePicker()
        Label4 = New Label()
        txtdv = New TextBox()
        txtbill2 = New TextBox()
        ListView1 = New ListView()
        lblstatus = New Label()
        cmbfund = New ComboBox()
        Label42 = New Label()
        PrintDialog1 = New PrintDialog()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        PageSetupDialog1 = New PageSetupDialog()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        txtseedproreport = New TextBox()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        Label15 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Bauhaus 93", 24F, FontStyle.Underline, GraphicsUnit.Point)
        Label16.Location = New Point(12, 38)
        Label16.Name = "Label16"
        Label16.Size = New Size(412, 45)
        Label16.TabIndex = 47
        Label16.Text = "15% Mobilization Fee"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(52, 271)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 23)
        Label2.TabIndex = 61
        Label2.Text = "Total Payment :"
        ' 
        ' txtpayment
        ' 
        txtpayment.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtpayment.BackColor = Color.White
        txtpayment.BorderStyle = BorderStyle.FixedSingle
        txtpayment.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtpayment.ForeColor = Color.Gray
        txtpayment.Location = New Point(57, 296)
        txtpayment.Name = "txtpayment"
        txtpayment.ReadOnly = True
        txtpayment.Size = New Size(234, 27)
        txtpayment.TabIndex = 52
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(52, 196)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 23)
        Label1.TabIndex = 60
        Label1.Text = "Date Realesed :"
        ' 
        ' date_issued
        ' 
        date_issued.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        date_issued.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        date_issued.Location = New Point(57, 141)
        date_issued.Name = "date_issued"
        date_issued.Size = New Size(234, 27)
        date_issued.TabIndex = 33
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(52, 34)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 23)
        Label5.TabIndex = 56
        Label5.Text = "Cheque Number "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(52, 111)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 23)
        Label6.TabIndex = 57
        Label6.Text = "Date Issued "
        ' 
        ' txtcheque
        ' 
        txtcheque.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtcheque.BorderStyle = BorderStyle.FixedSingle
        txtcheque.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtcheque.ForeColor = Color.Gray
        txtcheque.Location = New Point(57, 60)
        txtcheque.Name = "txtcheque"
        txtcheque.Size = New Size(234, 27)
        txtcheque.TabIndex = 52
        ' 
        ' date_released
        ' 
        date_released.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        date_released.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        date_released.Location = New Point(57, 222)
        date_released.Name = "date_released"
        date_released.Size = New Size(234, 27)
        date_released.TabIndex = 33
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(439, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 20)
        Label3.TabIndex = 129
        Label3.Text = "Project Total Cost :"
        ' 
        ' txtbill
        ' 
        txtbill.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtbill.BackColor = Color.White
        txtbill.BorderStyle = BorderStyle.FixedSingle
        txtbill.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtbill.ForeColor = Color.Black
        txtbill.Location = New Point(594, 188)
        txtbill.Name = "txtbill"
        txtbill.Size = New Size(203, 27)
        txtbill.TabIndex = 52
        ' 
        ' Btnsub
        ' 
        Btnsub.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Btnsub.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Btnsub.ForeColor = Color.White
        Btnsub.Location = New Point(638, 765)
        Btnsub.Name = "Btnsub"
        Btnsub.Size = New Size(159, 52)
        Btnsub.TabIndex = 65
        Btnsub.Text = "Submit"
        Btnsub.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(17, 109)
        Label8.Name = "Label8"
        Label8.Size = New Size(167, 20)
        Label8.TabIndex = 175
        Label8.Text = "Project Unique Code :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(17, 137)
        Label9.Name = "Label9"
        Label9.Size = New Size(175, 20)
        Label9.TabIndex = 176
        Label9.Text = "Name of Implementer :"
        ' 
        ' txtorg
        ' 
        txtorg.BackColor = Color.White
        txtorg.BorderStyle = BorderStyle.FixedSingle
        txtorg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtorg.Location = New Point(190, 135)
        txtorg.Name = "txtorg"
        txtorg.ReadOnly = True
        txtorg.Size = New Size(415, 27)
        txtorg.TabIndex = 178
        txtorg.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtuniquecode
        ' 
        txtuniquecode.BackColor = Color.White
        txtuniquecode.BorderStyle = BorderStyle.FixedSingle
        txtuniquecode.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtuniquecode.Location = New Point(190, 102)
        txtuniquecode.Name = "txtuniquecode"
        txtuniquecode.ReadOnly = True
        txtuniquecode.Size = New Size(415, 27)
        txtuniquecode.TabIndex = 177
        txtuniquecode.TextAlign = HorizontalAlignment.Center
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(817, 24)
        MenuStrip1.TabIndex = 180
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' obdate
        ' 
        obdate.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        obdate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        obdate.Location = New Point(61, 134)
        obdate.Name = "obdate"
        obdate.Size = New Size(235, 27)
        obdate.TabIndex = 33
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.White
        Label11.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(58, 31)
        Label11.Name = "Label11"
        Label11.Size = New Size(70, 23)
        Label11.TabIndex = 56
        Label11.Text = "OB No :"
        ' 
        ' txtob
        ' 
        txtob.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtob.BorderStyle = BorderStyle.FixedSingle
        txtob.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtob.ForeColor = Color.Gray
        txtob.Location = New Point(62, 57)
        txtob.Name = "txtob"
        txtob.Size = New Size(234, 27)
        txtob.TabIndex = 52
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.White
        Label12.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(58, 108)
        Label12.Name = "Label12"
        Label12.Size = New Size(55, 23)
        Label12.TabIndex = 57
        Label12.Text = "Date :"
        ' 
        ' dvdate
        ' 
        dvdate.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dvdate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        dvdate.Location = New Point(61, 121)
        dvdate.Name = "dvdate"
        dvdate.Size = New Size(235, 27)
        dvdate.TabIndex = 33
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(58, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 23)
        Label4.TabIndex = 56
        Label4.Text = "DV No  :"
        ' 
        ' txtdv
        ' 
        txtdv.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtdv.BorderStyle = BorderStyle.FixedSingle
        txtdv.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtdv.ForeColor = Color.Gray
        txtdv.Location = New Point(61, 53)
        txtdv.Name = "txtdv"
        txtdv.Size = New Size(235, 27)
        txtdv.TabIndex = 52
        ' 
        ' txtbill2
        ' 
        txtbill2.Location = New Point(439, 727)
        txtbill2.Name = "txtbill2"
        txtbill2.Size = New Size(158, 27)
        txtbill2.TabIndex = 183
        txtbill2.Visible = False
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(17, 237)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(780, 128)
        ListView1.TabIndex = 184
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' lblstatus
        ' 
        lblstatus.AutoSize = True
        lblstatus.Font = New Font("Bauhaus 93", 45F, FontStyle.Regular, GraphicsUnit.Point)
        lblstatus.ForeColor = Color.ForestGreen
        lblstatus.Location = New Point(611, 86)
        lblstatus.Name = "lblstatus"
        lblstatus.Size = New Size(201, 84)
        lblstatus.TabIndex = 185
        lblstatus.Text = "PAID"
        lblstatus.Visible = False
        ' 
        ' cmbfund
        ' 
        cmbfund.DropDownStyle = ComboBoxStyle.DropDownList
        cmbfund.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        cmbfund.FormattingEnabled = True
        cmbfund.Location = New Point(17, 191)
        cmbfund.Name = "cmbfund"
        cmbfund.Size = New Size(262, 28)
        cmbfund.TabIndex = 127
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.BackColor = Color.White
        Label42.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label42.Location = New Point(17, 168)
        Label42.Name = "Label42"
        Label42.Size = New Size(52, 20)
        Label42.TabIndex = 128
        Label42.Text = "Fund :"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(326, 765)
        Button3.Name = "Button3"
        Button3.Size = New Size(98, 52)
        Button3.TabIndex = 247
        Button3.Text = "Page Setup"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(17, 765)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 50)
        Button2.TabIndex = 246
        Button2.Text = "Print Report"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(164, 765)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 49)
        Button1.TabIndex = 245
        Button1.Text = "Print Preview"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtseedproreport
        ' 
        txtseedproreport.Location = New Point(439, 765)
        txtseedproreport.Multiline = True
        txtseedproreport.Name = "txtseedproreport"
        txtseedproreport.ScrollBars = ScrollBars.Both
        txtseedproreport.Size = New Size(146, 52)
        txtseedproreport.TabIndex = 248
        txtseedproreport.Visible = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtpayment)
        GroupBox1.Controls.Add(date_released)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(date_issued)
        GroupBox1.Controls.Add(txtcheque)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(20, 379)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(380, 360)
        GroupBox1.TabIndex = 249
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cheque Details"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(obdate)
        GroupBox2.Controls.Add(txtob)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(417, 379)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(380, 183)
        GroupBox2.TabIndex = 250
        GroupBox2.TabStop = False
        GroupBox2.Text = "Obligation Details"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(dvdate)
        GroupBox3.Controls.Add(txtdv)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox3.Location = New Point(417, 567)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(380, 172)
        GroupBox3.TabIndex = 251
        GroupBox3.TabStop = False
        GroupBox3.Text = "Disbursement Details"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.White
        Label15.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(58, 99)
        Label15.Name = "Label15"
        Label15.Size = New Size(55, 23)
        Label15.TabIndex = 57
        Label15.Text = "Date :"
        ' 
        ' Disburstment_1stquarter
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(817, 838)
        Controls.Add(txtbill)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(txtseedproreport)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(ListView1)
        Controls.Add(MenuStrip1)
        Controls.Add(txtorg)
        Controls.Add(cmbfund)
        Controls.Add(txtuniquecode)
        Controls.Add(Label42)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Btnsub)
        Controls.Add(Label16)
        Controls.Add(txtbill2)
        Controls.Add(lblstatus)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Disburstment_1stquarter"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Disburstment_1stquarter"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label16 As Label
    Friend WithEvents date_issued As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcheque As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents date_released As DateTimePicker
    Friend WithEvents Btnsub As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpayment As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtorg As TextBox
    Friend WithEvents txtuniquecode As TextBox
    Friend WithEvents txtbill As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label3 As Label
    Friend WithEvents obdate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtob As TextBox
    Friend WithEvents dvdate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdv As TextBox
    Friend WithEvents txtbill2 As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents lblstatus As Label
    Friend WithEvents cmbfund As ComboBox
    Friend WithEvents Label42 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtseedproreport As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label15 As Label
End Class
