<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _2MP_mf_dibursement
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
        Panel15 = New Panel()
        Label14 = New Label()
        Panel3 = New Panel()
        txtbill = New TextBox()
        Label3 = New Label()
        ListView1 = New ListView()
        Panel14 = New Panel()
        Label13 = New Label()
        Panel13 = New Panel()
        Label10 = New Label()
        Panel8 = New Panel()
        Panel9 = New Panel()
        dvdate = New DateTimePicker()
        Label4 = New Label()
        Panel12 = New Panel()
        txtdv = New TextBox()
        Label7 = New Label()
        Panel6 = New Panel()
        Panel10 = New Panel()
        obdate = New DateTimePicker()
        Label11 = New Label()
        Panel11 = New Panel()
        txtob = New TextBox()
        Label12 = New Label()
        MenuStrip1 = New MenuStrip()
        txtorg = New TextBox()
        txtuniquecode = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Panel7 = New Panel()
        Label2 = New Label()
        Panel1 = New Panel()
        txtpayment = New TextBox()
        Label1 = New Label()
        Panel4 = New Panel()
        date_issued = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        Panel5 = New Panel()
        txtcheque = New TextBox()
        Panel2 = New Panel()
        date_released = New DateTimePicker()
        Label16 = New Label()
        lblstatus = New Label()
        Btnsub = New Button()
        txtbill2 = New TextBox()
        Panel15.SuspendLayout()
        Panel3.SuspendLayout()
        Panel14.SuspendLayout()
        Panel13.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        Panel12.SuspendLayout()
        Panel6.SuspendLayout()
        Panel10.SuspendLayout()
        Panel11.SuspendLayout()
        Panel7.SuspendLayout()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Panel15.Controls.Add(Label14)
        Panel15.ForeColor = Color.White
        Panel15.Location = New Point(20, 340)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(433, 29)
        Panel15.TabIndex = 193
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(102, 4)
        Label14.Name = "Label14"
        Label14.Size = New Size(230, 20)
        Label14.TabIndex = 159
        Label14.Text = "O B L I G A T I O N  D E T A I L S"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientActiveCaption
        Panel3.Controls.Add(txtbill)
        Panel3.Location = New Point(618, 267)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(262, 43)
        Panel3.TabIndex = 191
        ' 
        ' txtbill
        ' 
        txtbill.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtbill.BorderStyle = BorderStyle.None
        txtbill.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtbill.ForeColor = Color.Gray
        txtbill.Location = New Point(3, 10)
        txtbill.Name = "txtbill"
        txtbill.Size = New Size(256, 24)
        txtbill.TabIndex = 52
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientActiveCaption
        Label3.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(618, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 24)
        Label3.TabIndex = 190
        Label3.Text = "Project Total Cost :"
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(20, 182)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(592, 128)
        ListView1.TabIndex = 202
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Panel14.Controls.Add(Label13)
        Panel14.ForeColor = Color.White
        Panel14.Location = New Point(459, 544)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(433, 29)
        Panel14.TabIndex = 194
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(93, 4)
        Label13.Name = "Label13"
        Label13.Size = New Size(259, 20)
        Label13.TabIndex = 159
        Label13.Text = "D I S B U R S E M E N T  D E T A I L S"
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Panel13.Controls.Add(Label10)
        Panel13.ForeColor = Color.White
        Panel13.Location = New Point(459, 340)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(433, 29)
        Panel13.TabIndex = 192
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(102, 4)
        Label10.Name = "Label10"
        Label10.Size = New Size(230, 20)
        Label10.TabIndex = 159
        Label10.Text = "O B L I G A T I O N  D E T A I L S"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.GradientActiveCaption
        Panel8.Controls.Add(Panel9)
        Panel8.Controls.Add(Label4)
        Panel8.Controls.Add(Panel12)
        Panel8.Controls.Add(Label7)
        Panel8.Location = New Point(459, 544)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(433, 198)
        Panel8.TabIndex = 201
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.White
        Panel9.Controls.Add(dvdate)
        Panel9.Location = New Point(7, 142)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(405, 45)
        Panel9.TabIndex = 55
        ' 
        ' dvdate
        ' 
        dvdate.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dvdate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        dvdate.Location = New Point(3, 9)
        dvdate.Name = "dvdate"
        dvdate.Size = New Size(399, 27)
        dvdate.TabIndex = 33
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.GradientActiveCaption
        Label4.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(6, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 24)
        Label4.TabIndex = 56
        Label4.Text = "DV No  :"
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.White
        Panel12.Controls.Add(txtdv)
        Panel12.Location = New Point(7, 68)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(405, 43)
        Panel12.TabIndex = 58
        ' 
        ' txtdv
        ' 
        txtdv.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtdv.BorderStyle = BorderStyle.None
        txtdv.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtdv.ForeColor = Color.Gray
        txtdv.Location = New Point(3, 10)
        txtdv.Name = "txtdv"
        txtdv.Size = New Size(399, 24)
        txtdv.TabIndex = 52
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.GradientActiveCaption
        Label7.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(6, 114)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 24)
        Label7.TabIndex = 57
        Label7.Text = "Date :"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.GradientActiveCaption
        Panel6.Controls.Add(Panel10)
        Panel6.Controls.Add(Label11)
        Panel6.Controls.Add(Panel11)
        Panel6.Controls.Add(Label12)
        Panel6.Location = New Point(459, 340)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(433, 198)
        Panel6.TabIndex = 200
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.White
        Panel10.Controls.Add(obdate)
        Panel10.Location = New Point(7, 142)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(405, 45)
        Panel10.TabIndex = 55
        ' 
        ' obdate
        ' 
        obdate.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        obdate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        obdate.Location = New Point(3, 9)
        obdate.Name = "obdate"
        obdate.Size = New Size(399, 27)
        obdate.TabIndex = 33
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.GradientActiveCaption
        Label11.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(6, 40)
        Label11.Name = "Label11"
        Label11.Size = New Size(75, 24)
        Label11.TabIndex = 56
        Label11.Text = "OB No :"
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.White
        Panel11.Controls.Add(txtob)
        Panel11.Location = New Point(7, 68)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(405, 43)
        Panel11.TabIndex = 58
        ' 
        ' txtob
        ' 
        txtob.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtob.BorderStyle = BorderStyle.None
        txtob.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtob.ForeColor = Color.Gray
        txtob.Location = New Point(3, 10)
        txtob.Name = "txtob"
        txtob.Size = New Size(399, 24)
        txtob.TabIndex = 52
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = SystemColors.GradientActiveCaption
        Label12.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(6, 114)
        Label12.Name = "Label12"
        Label12.Size = New Size(61, 24)
        Label12.TabIndex = 57
        Label12.Text = "Date :"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(927, 24)
        MenuStrip1.TabIndex = 199
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' txtorg
        ' 
        txtorg.BackColor = Color.White
        txtorg.BorderStyle = BorderStyle.FixedSingle
        txtorg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtorg.Location = New Point(190, 126)
        txtorg.Name = "txtorg"
        txtorg.ReadOnly = True
        txtorg.Size = New Size(415, 27)
        txtorg.TabIndex = 198
        txtorg.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtuniquecode
        ' 
        txtuniquecode.BackColor = Color.White
        txtuniquecode.BorderStyle = BorderStyle.FixedSingle
        txtuniquecode.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtuniquecode.Location = New Point(190, 93)
        txtuniquecode.Name = "txtuniquecode"
        txtuniquecode.ReadOnly = True
        txtuniquecode.Size = New Size(415, 27)
        txtuniquecode.TabIndex = 197
        txtuniquecode.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(17, 100)
        Label8.Name = "Label8"
        Label8.Size = New Size(167, 20)
        Label8.TabIndex = 195
        Label8.Text = "Project Unique Code :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(17, 128)
        Label9.Name = "Label9"
        Label9.Size = New Size(175, 20)
        Label9.TabIndex = 196
        Label9.Text = "Name of Implementer :"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.GradientActiveCaption
        Panel7.Controls.Add(Label2)
        Panel7.Controls.Add(Panel1)
        Panel7.Controls.Add(Label1)
        Panel7.Controls.Add(Panel4)
        Panel7.Controls.Add(Label5)
        Panel7.Controls.Add(Label6)
        Panel7.Controls.Add(Panel5)
        Panel7.Controls.Add(Panel2)
        Panel7.Location = New Point(20, 341)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(433, 401)
        Panel7.TabIndex = 187
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientActiveCaption
        Label2.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(11, 315)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 24)
        Label2.TabIndex = 61
        Label2.Text = "Total Payment :"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(txtpayment)
        Panel1.Location = New Point(13, 343)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(402, 43)
        Panel1.TabIndex = 62
        ' 
        ' txtpayment
        ' 
        txtpayment.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtpayment.BorderStyle = BorderStyle.None
        txtpayment.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtpayment.ForeColor = Color.Gray
        txtpayment.Location = New Point(3, 10)
        txtpayment.Name = "txtpayment"
        txtpayment.ReadOnly = True
        txtpayment.Size = New Size(396, 24)
        txtpayment.TabIndex = 52
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientActiveCaption
        Label1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(11, 237)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 24)
        Label1.TabIndex = 60
        Label1.Text = "Date Realesed :"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(date_issued)
        Panel4.Location = New Point(13, 180)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(405, 45)
        Panel4.TabIndex = 55
        ' 
        ' date_issued
        ' 
        date_issued.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        date_issued.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        date_issued.Location = New Point(3, 9)
        date_issued.Name = "date_issued"
        date_issued.Size = New Size(399, 27)
        date_issued.TabIndex = 33
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.GradientActiveCaption
        Label5.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(13, 74)
        Label5.Name = "Label5"
        Label5.Size = New Size(158, 24)
        Label5.TabIndex = 56
        Label5.Text = "Cheque Number :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.GradientActiveCaption
        Label6.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(12, 152)
        Label6.Name = "Label6"
        Label6.Size = New Size(119, 24)
        Label6.TabIndex = 57
        Label6.Text = "Date Issued :"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(txtcheque)
        Panel5.Location = New Point(13, 102)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(405, 43)
        Panel5.TabIndex = 58
        ' 
        ' txtcheque
        ' 
        txtcheque.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        txtcheque.BorderStyle = BorderStyle.None
        txtcheque.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtcheque.ForeColor = Color.Gray
        txtcheque.Location = New Point(3, 10)
        txtcheque.Name = "txtcheque"
        txtcheque.Size = New Size(399, 24)
        txtcheque.TabIndex = 52
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(date_released)
        Panel2.Location = New Point(13, 265)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(405, 45)
        Panel2.TabIndex = 58
        ' 
        ' date_released
        ' 
        date_released.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        date_released.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        date_released.Location = New Point(3, 9)
        date_released.Name = "date_released"
        date_released.Size = New Size(399, 27)
        date_released.TabIndex = 33
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(12, 36)
        Label16.Name = "Label16"
        Label16.Size = New Size(412, 45)
        Label16.TabIndex = 186
        Label16.Text = "15% Mobilization Fee"
        ' 
        ' lblstatus
        ' 
        lblstatus.AutoSize = True
        lblstatus.Font = New Font("Bauhaus 93", 72F, FontStyle.Regular, GraphicsUnit.Point)
        lblstatus.ForeColor = Color.ForestGreen
        lblstatus.Location = New Point(608, 45)
        lblstatus.Name = "lblstatus"
        lblstatus.Size = New Size(323, 136)
        lblstatus.TabIndex = 203
        lblstatus.Text = "PAID"
        lblstatus.Visible = False
        ' 
        ' Btnsub
        ' 
        Btnsub.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Btnsub.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Btnsub.ForeColor = Color.White
        Btnsub.Location = New Point(740, 759)
        Btnsub.Name = "Btnsub"
        Btnsub.Size = New Size(159, 70)
        Btnsub.TabIndex = 204
        Btnsub.Text = "Submit"
        Btnsub.UseVisualStyleBackColor = False
        ' 
        ' txtbill2
        ' 
        txtbill2.Location = New Point(618, 759)
        txtbill2.Name = "txtbill2"
        txtbill2.Size = New Size(158, 27)
        txtbill2.TabIndex = 205
        txtbill2.Visible = False
        ' 
        ' _2MP_mf_dibursement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 838)
        Controls.Add(Btnsub)
        Controls.Add(txtbill2)
        Controls.Add(Panel15)
        Controls.Add(Panel3)
        Controls.Add(Label3)
        Controls.Add(ListView1)
        Controls.Add(Panel14)
        Controls.Add(Panel13)
        Controls.Add(Panel8)
        Controls.Add(Panel6)
        Controls.Add(MenuStrip1)
        Controls.Add(txtorg)
        Controls.Add(txtuniquecode)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Panel7)
        Controls.Add(Label16)
        Controls.Add(lblstatus)
        Name = "_2MP_mf_dibursement"
        Text = "_2MP_mf_dibursement"
        Panel15.ResumeLayout(False)
        Panel15.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtbill As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dvdate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents txtdv As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents obdate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txtob As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents txtorg As TextBox
    Friend WithEvents txtuniquecode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtpayment As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents date_issued As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtcheque As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents date_released As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents lblstatus As Label
    Friend WithEvents Btnsub As Button
    Friend WithEvents txtbill2 As TextBox
End Class
