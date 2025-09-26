<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ttSach
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
        txtmasach = New TextBox()
        txttensach = New TextBox()
        Label2 = New Label()
        txttg = New TextBox()
        Label3 = New Label()
        txttheloai = New TextBox()
        Label4 = New Label()
        txtnam = New TextBox()
        Label5 = New Label()
        txtsl = New TextBox()
        Label6 = New Label()
        btnluu = New Button()
        btnhuy = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F)
        Label1.Location = New Point(32, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 23)
        Label1.TabIndex = 0
        Label1.Text = "Mã sách:"
        ' 
        ' txtmasach
        ' 
        txtmasach.Font = New Font("Segoe UI", 10.2F)
        txtmasach.Location = New Point(32, 65)
        txtmasach.Name = "txtmasach"
        txtmasach.Size = New Size(312, 30)
        txtmasach.TabIndex = 1
        ' 
        ' txttensach
        ' 
        txttensach.Font = New Font("Segoe UI", 10.2F)
        txttensach.Location = New Point(379, 65)
        txttensach.Name = "txttensach"
        txttensach.Size = New Size(312, 30)
        txttensach.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F)
        Label2.Location = New Point(379, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 2
        Label2.Text = "Tên sách:"
        ' 
        ' txttg
        ' 
        txttg.Font = New Font("Segoe UI", 10.2F)
        txttg.Location = New Point(32, 159)
        txttg.Name = "txttg"
        txttg.Size = New Size(312, 30)
        txttg.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F)
        Label3.Location = New Point(32, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 23)
        Label3.TabIndex = 4
        Label3.Text = "Tác giả:"
        ' 
        ' txttheloai
        ' 
        txttheloai.Font = New Font("Segoe UI", 10.2F)
        txttheloai.Location = New Point(379, 159)
        txttheloai.Name = "txttheloai"
        txttheloai.Size = New Size(312, 30)
        txttheloai.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F)
        Label4.Location = New Point(379, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 23)
        Label4.TabIndex = 6
        Label4.Text = "Thể loại:"
        ' 
        ' txtnam
        ' 
        txtnam.Font = New Font("Segoe UI", 10.2F)
        txtnam.Location = New Point(32, 261)
        txtnam.Name = "txtnam"
        txtnam.Size = New Size(312, 30)
        txtnam.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F)
        Label5.Location = New Point(32, 227)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 23)
        Label5.TabIndex = 8
        Label5.Text = "Năm xuất bản:"
        ' 
        ' txtsl
        ' 
        txtsl.Font = New Font("Segoe UI", 10.2F)
        txtsl.Location = New Point(379, 261)
        txtsl.Name = "txtsl"
        txtsl.Size = New Size(312, 30)
        txtsl.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F)
        Label6.Location = New Point(379, 227)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 23)
        Label6.TabIndex = 10
        Label6.Text = "Số lượng:"
        ' 
        ' btnluu
        ' 
        btnluu.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnluu.Location = New Point(592, 333)
        btnluu.Name = "btnluu"
        btnluu.Size = New Size(99, 33)
        btnluu.TabIndex = 12
        btnluu.Text = "Lưu"
        btnluu.UseVisualStyleBackColor = True
        ' 
        ' btnhuy
        ' 
        btnhuy.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnhuy.Location = New Point(462, 333)
        btnhuy.Name = "btnhuy"
        btnhuy.Size = New Size(99, 33)
        btnhuy.TabIndex = 13
        btnhuy.Text = "Hủy"
        btnhuy.UseVisualStyleBackColor = True
        ' 
        ' ttSach
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(740, 405)
        Controls.Add(btnhuy)
        Controls.Add(btnluu)
        Controls.Add(txtsl)
        Controls.Add(Label6)
        Controls.Add(txtnam)
        Controls.Add(Label5)
        Controls.Add(txttheloai)
        Controls.Add(Label4)
        Controls.Add(txttg)
        Controls.Add(Label3)
        Controls.Add(txttensach)
        Controls.Add(Label2)
        Controls.Add(txtmasach)
        Controls.Add(Label1)
        Name = "ttSach"
        Text = "ttSach"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtmasach As TextBox
    Friend WithEvents txttensach As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txttg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txttheloai As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnam As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsl As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnluu As Button
    Friend WithEvents btnhuy As Button
End Class
