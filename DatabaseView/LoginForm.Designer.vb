<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Label1 = New Label()
        txtuser = New TextBox()
        txtpass = New TextBox()
        Label2 = New Label()
        Btnlog = New Button()
        Btncancel = New Button()
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(118, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 0
        Label1.Text = "Username :"
        ' 
        ' txtuser
        ' 
        txtuser.Location = New Point(207, 73)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(175, 27)
        txtuser.TabIndex = 1
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(207, 142)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(175, 27)
        txtpass.TabIndex = 3
        txtpass.UseSystemPasswordChar = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(118, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 20)
        Label2.TabIndex = 2
        Label2.Text = "Password :"
        ' 
        ' Btnlog
        ' 
        Btnlog.Location = New Point(118, 249)
        Btnlog.Name = "Btnlog"
        Btnlog.Size = New Size(94, 29)
        Btnlog.TabIndex = 4
        Btnlog.Text = "Log-in"
        Btnlog.UseVisualStyleBackColor = True
        ' 
        ' Btncancel
        ' 
        Btncancel.Location = New Point(288, 249)
        Btncancel.Name = "Btncancel"
        Btncancel.Size = New Size(94, 29)
        Btncancel.TabIndex = 5
        Btncancel.Text = "Cancel"
        Btncancel.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(207, 184)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(113, 24)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Show / Hide"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(508, 446)
        Controls.Add(CheckBox1)
        Controls.Add(Btncancel)
        Controls.Add(Btnlog)
        Controls.Add(txtpass)
        Controls.Add(Label2)
        Controls.Add(txtuser)
        Controls.Add(Label1)
        Name = "LoginForm"
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btnlog As Button
    Friend WithEvents Btncancel As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
