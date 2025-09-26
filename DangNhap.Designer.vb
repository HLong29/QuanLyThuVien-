<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DangNhap
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
        txttdn = New TextBox()
        txtmk = New TextBox()
        Label2 = New Label()
        btndn = New Button()
        btnthoat = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F)
        Label1.Location = New Point(54, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 25)
        Label1.TabIndex = 0
        Label1.Text = "Tên đăng nhập:"
        ' 
        ' txttdn
        ' 
        txttdn.Font = New Font("Segoe UI", 10.8F)
        txttdn.Location = New Point(54, 153)
        txttdn.Name = "txttdn"
        txttdn.Size = New Size(312, 31)
        txttdn.TabIndex = 1
        ' 
        ' txtmk
        ' 
        txtmk.Font = New Font("Segoe UI", 10.8F)
        txtmk.Location = New Point(54, 242)
        txtmk.Name = "txtmk"
        txtmk.Size = New Size(312, 31)
        txtmk.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F)
        Label2.Location = New Point(54, 202)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 25)
        Label2.TabIndex = 2
        Label2.Text = "Mật khẩu:"
        ' 
        ' btndn
        ' 
        btndn.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btndn.Location = New Point(56, 314)
        btndn.Name = "btndn"
        btndn.Size = New Size(124, 40)
        btndn.TabIndex = 4
        btndn.Text = "Đăng nhập"
        btndn.UseVisualStyleBackColor = True
        ' 
        ' btnthoat
        ' 
        btnthoat.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnthoat.Location = New Point(232, 314)
        btnthoat.Name = "btnthoat"
        btnthoat.Size = New Size(124, 40)
        btnthoat.TabIndex = 5
        btnthoat.Text = "Thoát"
        btnthoat.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(111, 29)
        Label3.Name = "Label3"
        Label3.Size = New Size(200, 46)
        Label3.TabIndex = 6
        Label3.Text = "Đăng Nhập"
        ' 
        ' DangNhap
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(432, 412)
        Controls.Add(Label3)
        Controls.Add(btnthoat)
        Controls.Add(btndn)
        Controls.Add(txtmk)
        Controls.Add(Label2)
        Controls.Add(txttdn)
        Controls.Add(Label1)
        Name = "DangNhap"
        Text = "DangNhap"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txttdn As TextBox
    Friend WithEvents txtmk As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btndn As Button
    Friend WithEvents btnthoat As Button
    Friend WithEvents Label3 As Label
End Class
