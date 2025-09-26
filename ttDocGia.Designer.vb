<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ttDocGia
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
        btnhuy = New Button()
        btnluu = New Button()
        txtdc = New TextBox()
        Label4 = New Label()
        txtdt = New TextBox()
        Label3 = New Label()
        txthoten = New TextBox()
        Label2 = New Label()
        txtmadg = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnhuy
        ' 
        btnhuy.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnhuy.Location = New Point(471, 244)
        btnhuy.Name = "btnhuy"
        btnhuy.Size = New Size(99, 33)
        btnhuy.TabIndex = 27
        btnhuy.Text = "Hủy"
        btnhuy.UseVisualStyleBackColor = True
        ' 
        ' btnluu
        ' 
        btnluu.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnluu.Location = New Point(601, 244)
        btnluu.Name = "btnluu"
        btnluu.Size = New Size(99, 33)
        btnluu.TabIndex = 26
        btnluu.Text = "Lưu"
        btnluu.UseVisualStyleBackColor = True
        ' 
        ' txtdc
        ' 
        txtdc.Font = New Font("Segoe UI", 10.2F)
        txtdc.Location = New Point(388, 163)
        txtdc.Name = "txtdc"
        txtdc.Size = New Size(312, 30)
        txtdc.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F)
        Label4.Location = New Point(388, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 23)
        Label4.TabIndex = 20
        Label4.Text = "Địa chỉ:"
        ' 
        ' txtdt
        ' 
        txtdt.Font = New Font("Segoe UI", 10.2F)
        txtdt.Location = New Point(41, 163)
        txtdt.Name = "txtdt"
        txtdt.Size = New Size(312, 30)
        txtdt.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F)
        Label3.Location = New Point(41, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 23)
        Label3.TabIndex = 18
        Label3.Text = "Điện thoại:"
        ' 
        ' txthoten
        ' 
        txthoten.Font = New Font("Segoe UI", 10.2F)
        txthoten.Location = New Point(388, 69)
        txthoten.Name = "txthoten"
        txthoten.Size = New Size(312, 30)
        txthoten.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F)
        Label2.Location = New Point(388, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 23)
        Label2.TabIndex = 16
        Label2.Text = "Họ tên:"
        ' 
        ' txtmadg
        ' 
        txtmadg.Font = New Font("Segoe UI", 10.2F)
        txtmadg.Location = New Point(41, 69)
        txtmadg.Name = "txtmadg"
        txtmadg.Size = New Size(312, 30)
        txtmadg.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F)
        Label1.Location = New Point(41, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 23)
        Label1.TabIndex = 14
        Label1.Text = "Mã độc giả:"
        ' 
        ' ttDocGia
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(740, 325)
        Controls.Add(btnhuy)
        Controls.Add(btnluu)
        Controls.Add(txtdc)
        Controls.Add(Label4)
        Controls.Add(txtdt)
        Controls.Add(Label3)
        Controls.Add(txthoten)
        Controls.Add(Label2)
        Controls.Add(txtmadg)
        Controls.Add(Label1)
        Name = "ttDocGia"
        Text = "ttDocGia"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnhuy As Button
    Friend WithEvents btnluu As Button
    Friend WithEvents txtdc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txthoten As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmadg As TextBox
    Friend WithEvents Label1 As Label
End Class
