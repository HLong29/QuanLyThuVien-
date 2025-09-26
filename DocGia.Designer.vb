<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocGia
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
        dgvdocgia = New DataGridView()
        txttim = New TextBox()
        btnxoa = New Button()
        btnsua = New Button()
        btnthem = New Button()
        Label1 = New Label()
        CType(dgvdocgia, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvdocgia
        ' 
        dgvdocgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvdocgia.Location = New Point(28, 157)
        dgvdocgia.Name = "dgvdocgia"
        dgvdocgia.RowHeadersWidth = 51
        dgvdocgia.Size = New Size(747, 376)
        dgvdocgia.TabIndex = 11
        ' 
        ' txttim
        ' 
        txttim.Location = New Point(339, 92)
        txttim.Multiline = True
        txttim.Name = "txttim"
        txttim.Size = New Size(417, 35)
        txttim.TabIndex = 9
        ' 
        ' btnxoa
        ' 
        btnxoa.Location = New Point(230, 92)
        btnxoa.Name = "btnxoa"
        btnxoa.Size = New Size(88, 35)
        btnxoa.TabIndex = 8
        btnxoa.Text = "Xóa"
        btnxoa.UseVisualStyleBackColor = True
        ' 
        ' btnsua
        ' 
        btnsua.Location = New Point(136, 92)
        btnsua.Name = "btnsua"
        btnsua.Size = New Size(88, 35)
        btnsua.TabIndex = 7
        btnsua.Text = "Sửa"
        btnsua.UseVisualStyleBackColor = True
        ' 
        ' btnthem
        ' 
        btnthem.Location = New Point(42, 92)
        btnthem.Name = "btnthem"
        btnthem.Size = New Size(88, 35)
        btnthem.TabIndex = 6
        btnthem.Text = "Thêm"
        btnthem.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(267, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(247, 41)
        Label1.TabIndex = 12
        Label1.Text = "Quản Lý Độc Giả"
        ' 
        ' DocGia
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(807, 560)
        Controls.Add(Label1)
        Controls.Add(dgvdocgia)
        Controls.Add(txttim)
        Controls.Add(btnxoa)
        Controls.Add(btnsua)
        Controls.Add(btnthem)
        Name = "DocGia"
        Text = "DocGia"
        CType(dgvdocgia, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvdocgia As DataGridView
    Friend WithEvents txttim As TextBox
    Friend WithEvents btnxoa As Button
    Friend WithEvents btnsua As Button
    Friend WithEvents btnthem As Button
    Friend WithEvents Label1 As Label
End Class
