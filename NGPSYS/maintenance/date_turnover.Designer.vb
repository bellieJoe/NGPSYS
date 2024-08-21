<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class date_turnover
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
        lblcode = New Label()
        MenuStrip1 = New MenuStrip()
        daterequest = New DateTimePicker()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblcode
        ' 
        lblcode.AutoSize = True
        lblcode.Location = New Point(25, 58)
        lblcode.Name = "lblcode"
        lblcode.Size = New Size(53, 20)
        lblcode.TabIndex = 66
        lblcode.Text = "Label4"
        lblcode.Visible = False
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
        MenuStrip1.Size = New Size(507, 24)
        MenuStrip1.TabIndex = 65
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' daterequest
        ' 
        daterequest.Location = New Point(25, 132)
        daterequest.Name = "daterequest"
        daterequest.Size = New Size(281, 27)
        daterequest.TabIndex = 62
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.newcom
        PictureBox1.Location = New Point(25, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(47, 39)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 61
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bauhaus 93", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(79, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(265, 39)
        Label2.TabIndex = 60
        Label2.Text = "Actual Turn-Over"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 20)
        Label1.TabIndex = 59
        Label1.Text = "Date of Actual Turn - Over :"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(325, 98)
        Button3.Name = "Button3"
        Button3.Size = New Size(170, 63)
        Button3.TabIndex = 236
        Button3.Text = "Submit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' date_turnover
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(507, 197)
        Controls.Add(Button3)
        Controls.Add(lblcode)
        Controls.Add(MenuStrip1)
        Controls.Add(daterequest)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "date_turnover"
        StartPosition = FormStartPosition.CenterScreen
        Text = "date_turnover"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblcode As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents daterequest As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
End Class
