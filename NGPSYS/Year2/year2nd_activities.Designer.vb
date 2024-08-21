<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class year2nd_activities
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
        Panel11 = New Panel()
        MenuStrip1 = New MenuStrip()
        Panel1 = New Panel()
        btnrandr = New Button()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel7 = New Panel()
        btnreplant = New Button()
        btnPatrol = New Button()
        Panel11.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        Panel11.Controls.Add(MenuStrip1)
        Panel11.Controls.Add(Panel1)
        Panel11.Controls.Add(Panel2)
        Panel11.Controls.Add(Panel7)
        Panel11.Location = New Point(12, 21)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(670, 458)
        Panel11.TabIndex = 214
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
        MenuStrip1.Size = New Size(670, 24)
        MenuStrip1.TabIndex = 56
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(btnrandr)
        Panel1.Location = New Point(89, 55)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(214, 173)
        Panel1.TabIndex = 54
        ' 
        ' btnrandr
        ' 
        btnrandr.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnrandr.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnrandr.ForeColor = Color.White
        btnrandr.Location = New Point(23, 41)
        btnrandr.Name = "btnrandr"
        btnrandr.Size = New Size(169, 90)
        btnrandr.TabIndex = 1
        btnrandr.Text = "Ring wedding and Re - staking"
        btnrandr.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(btnreplant)
        Panel2.Location = New Point(378, 55)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(214, 173)
        Panel2.TabIndex = 55
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientActiveCaption
        Panel3.Controls.Add(btnPatrol)
        Panel3.Location = New Point(233, 226)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(214, 173)
        Panel3.TabIndex = 55
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(Panel3)
        Panel7.Location = New Point(3, 33)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(664, 422)
        Panel7.TabIndex = 60
        ' 
        ' btnreplant
        ' 
        btnreplant.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnreplant.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnreplant.ForeColor = Color.White
        btnreplant.Location = New Point(23, 41)
        btnreplant.Name = "btnreplant"
        btnreplant.Size = New Size(169, 90)
        btnreplant.TabIndex = 2
        btnreplant.Text = "Replanting"
        btnreplant.UseVisualStyleBackColor = False
        ' 
        ' btnPatrol
        ' 
        btnPatrol.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        btnPatrol.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnPatrol.ForeColor = Color.White
        btnPatrol.Location = New Point(23, 41)
        btnPatrol.Name = "btnPatrol"
        btnPatrol.Size = New Size(169, 90)
        btnPatrol.TabIndex = 2
        btnPatrol.Text = "Patrol Work and Inventory"
        btnPatrol.UseVisualStyleBackColor = False
        ' 
        ' year2nd_activities
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(706, 491)
        Controls.Add(Panel11)
        Name = "year2nd_activities"
        Text = "year2nd_activities"
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel11 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnrandr As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnreplant As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnPatrol As Button
    Friend WithEvents Panel7 As Panel
End Class
