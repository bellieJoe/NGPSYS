<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formDocExplorer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvDocList = New DataGridView()
        docName = New DataGridViewTextBoxColumn()
        Id = New DataGridViewTextBoxColumn()
        Url = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Button2 = New Button()
        btnView = New Button()
        Button4 = New Button()
        CType(dgvDocList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDocList
        ' 
        dgvDocList.AllowUserToAddRows = False
        dgvDocList.BackgroundColor = Color.WhiteSmoke
        dgvDocList.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        dgvDocList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDocList.Columns.AddRange(New DataGridViewColumn() {docName, Id, Url})
        dgvDocList.Location = New Point(12, 12)
        dgvDocList.MultiSelect = False
        dgvDocList.Name = "dgvDocList"
        dgvDocList.ReadOnly = True
        dgvDocList.RowHeadersVisible = False
        dgvDocList.RowHeadersWidth = 51
        dgvDocList.RowTemplate.Height = 29
        dgvDocList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDocList.Size = New Size(566, 426)
        dgvDocList.TabIndex = 0
        ' 
        ' docName
        ' 
        docName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        docName.HeaderText = "Name"
        docName.MinimumWidth = 6
        docName.Name = "docName"
        docName.ReadOnly = True
        ' 
        ' Id
        ' 
        Id.HeaderText = "Id"
        Id.MinimumWidth = 6
        Id.Name = "Id"
        Id.ReadOnly = True
        Id.Visible = False
        Id.Width = 125
        ' 
        ' Url
        ' 
        Url.HeaderText = "Url"
        Url.MinimumWidth = 6
        Url.Name = "Url"
        Url.ReadOnly = True
        Url.Visible = False
        Url.Width = 125
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(463, 452)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 37)
        Button1.TabIndex = 1
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(342, 452)
        Button2.Name = "Button2"
        Button2.Size = New Size(115, 37)
        Button2.TabIndex = 2
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnView
        ' 
        btnView.Location = New Point(100, 452)
        btnView.Name = "btnView"
        btnView.Size = New Size(115, 37)
        btnView.TabIndex = 3
        btnView.Text = "View"
        btnView.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(221, 452)
        Button4.Name = "Button4"
        Button4.Size = New Size(115, 37)
        Button4.TabIndex = 4
        Button4.Text = "Download"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' formDocExplorer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(592, 501)
        Controls.Add(Button4)
        Controls.Add(btnView)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(dgvDocList)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "formDocExplorer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DocExplorer"
        CType(dgvDocList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvDocList As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnView As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents docName As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Url As DataGridViewTextBoxColumn
End Class
