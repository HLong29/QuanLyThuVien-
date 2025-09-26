<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sach
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
        btnthem = New Button()
        btnsua = New Button()
        btnxoa = New Button()
        txttim = New TextBox()
        cbloc = New ComboBox()
        dgvsach = New DataGridView()
        Label1 = New Label()
        CType(dgvsach, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnthem
        ' 
        btnthem.Location = New Point(28, 88)
        btnthem.Name = "btnthem"
        btnthem.Size = New Size(88, 35)
        btnthem.TabIndex = 0
        btnthem.Text = "Thêm"
        btnthem.UseVisualStyleBackColor = True
        ' 
        ' btnsua
        ' 
        btnsua.Location = New Point(122, 88)
        btnsua.Name = "btnsua"
        btnsua.Size = New Size(88, 35)
        btnsua.TabIndex = 1
        btnsua.Text = "Sửa"
        btnsua.UseVisualStyleBackColor = True
        ' 
        ' btnxoa
        ' 
        btnxoa.Location = New Point(216, 88)
        btnxoa.Name = "btnxoa"
        btnxoa.Size = New Size(88, 35)
        btnxoa.TabIndex = 2
        btnxoa.Text = "Xóa"
        btnxoa.UseVisualStyleBackColor = True
        ' 
        ' txttim
        ' 
        txttim.Location = New Point(320, 88)
        txttim.Multiline = True
        txttim.Name = "txttim"
        txttim.Size = New Size(281, 35)
        txttim.TabIndex = 3
        ' 
        ' cbloc
        ' 
        cbloc.FormattingEnabled = True
        cbloc.Location = New Point(624, 92)
        cbloc.Name = "cbloc"
        cbloc.Size = New Size(151, 28)
        cbloc.TabIndex = 4
        ' 
        ' dgvsach
        ' 
        dgvsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvsach.Location = New Point(27, 153)
        dgvsach.Name = "dgvsach"
        dgvsach.RowHeadersWidth = 51
        dgvsach.Size = New Size(747, 376)
        dgvsach.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(280, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(204, 41)
        Label1.TabIndex = 6
        Label1.Text = "Quản Lý Sách"
        ' 
        ' Sach
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(807, 555)
        Controls.Add(Label1)
        Controls.Add(dgvsach)
        Controls.Add(cbloc)
        Controls.Add(txttim)
        Controls.Add(btnxoa)
        Controls.Add(btnsua)
        Controls.Add(btnthem)
        Name = "Sach"
        Text = "Sach"
        CType(dgvsach, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnthem As Button
    Friend WithEvents btnsua As Button
    Friend WithEvents btnxoa As Button
    Friend WithEvents txttim As TextBox
    Friend WithEvents cbloc As ComboBox
    Friend WithEvents dgvsach As DataGridView
    Friend WithEvents Label1 As Label
End Class
