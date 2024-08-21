<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editinspector_frrm
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
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        tic_lastname = New TextBox()
        tic_mid = New TextBox()
        tic_position = New TextBox()
        tic_name = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnedit = New Button()
        SuspendLayout()
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(146, 82)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 0
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(146, 128)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(250, 27)
        DateTimePicker2.TabIndex = 1
        ' 
        ' tic_lastname
        ' 
        tic_lastname.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        tic_lastname.BorderStyle = BorderStyle.FixedSingle
        tic_lastname.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tic_lastname.ForeColor = SystemColors.WindowText
        tic_lastname.Location = New Point(146, 271)
        tic_lastname.Name = "tic_lastname"
        tic_lastname.Size = New Size(250, 27)
        tic_lastname.TabIndex = 252
        tic_lastname.TextAlign = HorizontalAlignment.Center
        ' 
        ' tic_mid
        ' 
        tic_mid.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        tic_mid.BorderStyle = BorderStyle.FixedSingle
        tic_mid.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tic_mid.ForeColor = SystemColors.WindowText
        tic_mid.Location = New Point(146, 223)
        tic_mid.Name = "tic_mid"
        tic_mid.Size = New Size(250, 27)
        tic_mid.TabIndex = 251
        tic_mid.TextAlign = HorizontalAlignment.Center
        ' 
        ' tic_position
        ' 
        tic_position.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        tic_position.BorderStyle = BorderStyle.FixedSingle
        tic_position.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tic_position.ForeColor = SystemColors.WindowText
        tic_position.Location = New Point(146, 324)
        tic_position.Name = "tic_position"
        tic_position.Size = New Size(250, 27)
        tic_position.TabIndex = 249
        tic_position.TextAlign = HorizontalAlignment.Center
        ' 
        ' tic_name
        ' 
        tic_name.AutoCompleteCustomSource.AddRange(New String() {"admin", "guest"})
        tic_name.BorderStyle = BorderStyle.FixedSingle
        tic_name.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tic_name.Location = New Point(146, 177)
        tic_name.Name = "tic_name"
        tic_name.Size = New Size(250, 27)
        tic_name.TabIndex = 250
        tic_name.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 20)
        Label1.TabIndex = 253
        Label1.Text = "Date of request :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 20)
        Label2.TabIndex = 254
        Label2.Text = "Date of Inspection:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 255
        Label3.Text = "Firstname :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 20)
        Label4.TabIndex = 256
        Label4.Text = "Middlename :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 273)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 20)
        Label5.TabIndex = 257
        Label5.Text = "Lastname :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 326)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 20)
        Label6.TabIndex = 258
        Label6.Text = "Position :"
        ' 
        ' btnedit
        ' 
        btnedit.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnedit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnedit.ForeColor = Color.White
        btnedit.Location = New Point(252, 367)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(144, 61)
        btnedit.TabIndex = 259
        btnedit.Text = "Save"
        btnedit.UseVisualStyleBackColor = False
        ' 
        ' editinspector_frrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(408, 440)
        Controls.Add(btnedit)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tic_lastname)
        Controls.Add(tic_mid)
        Controls.Add(tic_position)
        Controls.Add(tic_name)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Name = "editinspector_frrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "editinspector_frrm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents tic_lastname As TextBox
    Friend WithEvents tic_mid As TextBox
    Friend WithEvents tic_position As TextBox
    Friend WithEvents tic_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnedit As Button
End Class
