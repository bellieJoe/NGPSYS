﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Year3_inspection
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
        WelcomwToolStripMenuItem = New ToolStripMenuItem()
        AddTechnicalInspectionCommitteeToolStripMenuItem = New ToolStripMenuItem()
        AddRingWeddingAndRestakingToolStripMenuItem = New ToolStripMenuItem()
        dateinspection = New DateTimePicker()
        Label3 = New Label()
        daterequest = New DateTimePicker()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        TICInspectorToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblcode
        ' 
        lblcode.AutoSize = True
        lblcode.Location = New Point(25, 80)
        lblcode.Name = "lblcode"
        lblcode.Size = New Size(53, 20)
        lblcode.TabIndex = 82
        lblcode.Text = "Label4"
        lblcode.Visible = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(212))
        MenuStrip1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {WelcomwToolStripMenuItem, TICInspectorToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(556, 30)
        MenuStrip1.TabIndex = 81
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' WelcomwToolStripMenuItem
        ' 
        WelcomwToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddTechnicalInspectionCommitteeToolStripMenuItem, AddRingWeddingAndRestakingToolStripMenuItem})
        WelcomwToolStripMenuItem.ForeColor = Color.White
        WelcomwToolStripMenuItem.Name = "WelcomwToolStripMenuItem"
        WelcomwToolStripMenuItem.Size = New Size(111, 24)
        WelcomwToolStripMenuItem.Text = "Add Reports"
        ' 
        ' AddTechnicalInspectionCommitteeToolStripMenuItem
        ' 
        AddTechnicalInspectionCommitteeToolStripMenuItem.Name = "AddTechnicalInspectionCommitteeToolStripMenuItem"
        AddTechnicalInspectionCommitteeToolStripMenuItem.Size = New Size(348, 26)
        AddTechnicalInspectionCommitteeToolStripMenuItem.Text = "Add Technical Inspection Committee"
        ' 
        ' AddRingWeddingAndRestakingToolStripMenuItem
        ' 
        AddRingWeddingAndRestakingToolStripMenuItem.Name = "AddRingWeddingAndRestakingToolStripMenuItem"
        AddRingWeddingAndRestakingToolStripMenuItem.Size = New Size(348, 26)
        AddRingWeddingAndRestakingToolStripMenuItem.Text = "Add Ring wedding and Re-staking"
        ' 
        ' dateinspection
        ' 
        dateinspection.Location = New Point(257, 155)
        dateinspection.Name = "dateinspection"
        dateinspection.Size = New Size(281, 27)
        dateinspection.TabIndex = 80
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(163, 20)
        Label3.TabIndex = 79
        Label3.Text = "Date of TIC Inspection :"
        ' 
        ' daterequest
        ' 
        daterequest.Location = New Point(257, 113)
        daterequest.Name = "daterequest"
        daterequest.Size = New Size(281, 27)
        daterequest.TabIndex = 78
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.newcom
        PictureBox1.Location = New Point(25, 61)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(47, 39)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 77
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bauhaus 93", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(79, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 39)
        Label2.TabIndex = 76
        Label2.Text = "Date"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 20)
        Label1.TabIndex = 75
        Label1.Text = "Date of Stakeholder request :"
        ' 
        ' TICInspectorToolStripMenuItem
        ' 
        TICInspectorToolStripMenuItem.ForeColor = Color.White
        TICInspectorToolStripMenuItem.Name = "TICInspectorToolStripMenuItem"
        TICInspectorToolStripMenuItem.Size = New Size(116, 24)
        TICInspectorToolStripMenuItem.Text = "TIC Inspector"
        ' 
        ' Year3_inspection
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(556, 197)
        Controls.Add(lblcode)
        Controls.Add(MenuStrip1)
        Controls.Add(dateinspection)
        Controls.Add(Label3)
        Controls.Add(daterequest)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Year3_inspection"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Year3_inspection"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblcode As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents WelcomwToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddTechnicalInspectionCommitteeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddRingWeddingAndRestakingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dateinspection As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents daterequest As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TICInspectorToolStripMenuItem As ToolStripMenuItem
End Class
