<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhieuMuon
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
        dgvpm = New DataGridView()
        txttim = New TextBox()
        btnxoa = New Button()
        btnsua = New Button()
        btnthem = New Button()
        Label1 = New Label()
        CType(dgvpm, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvpm
        ' 
        dgvpm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvpm.Location = New Point(29, 152)
        dgvpm.Name = "dgvpm"
        dgvpm.RowHeadersWidth = 51
        dgvpm.Size = New Size(747, 376)
        dgvpm.TabIndex = 17
        ' 
        ' txttim
        ' 
        txttim.Location = New Point(336, 87)
        txttim.Multiline = True
        txttim.Name = "txttim"
        txttim.Size = New Size(426, 35)
        txttim.TabIndex = 15
        ' 
        ' btnxoa
        ' 
        btnxoa.Location = New Point(232, 87)
        btnxoa.Name = "btnxoa"
        btnxoa.Size = New Size(88, 35)
        btnxoa.TabIndex = 14
        btnxoa.Text = "Xóa"
        btnxoa.UseVisualStyleBackColor = True
        ' 
        ' btnsua
        ' 
        btnsua.Location = New Point(138, 87)
        btnsua.Name = "btnsua"
        btnsua.Size = New Size(88, 35)
        btnsua.TabIndex = 13
        btnsua.Text = "Sửa"
        btnsua.UseVisualStyleBackColor = True
        ' 
        ' btnthem
        ' 
        btnthem.Location = New Point(44, 87)
        btnthem.Name = "btnthem"
        btnthem.Size = New Size(88, 35)
        btnthem.TabIndex = 12
        btnthem.Text = "Thêm"
        btnthem.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(238, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(312, 41)
        Label1.TabIndex = 18
        Label1.Text = "Quản Lý Phiếu Mượn"
        ' 
        ' PhieuMuon
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(807, 557)
        Controls.Add(Label1)
        Controls.Add(dgvpm)
        Controls.Add(txttim)
        Controls.Add(btnxoa)
        Controls.Add(btnsua)
        Controls.Add(btnthem)
        Name = "PhieuMuon"
        Text = "PhieuMuon"
        CType(dgvpm, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvpm As DataGridView
    Friend WithEvents txttim As TextBox
    Friend WithEvents btnxoa As Button
    Friend WithEvents btnsua As Button
    Friend WithEvents btnthem As Button
    Friend WithEvents Label1 As Label
End Class
