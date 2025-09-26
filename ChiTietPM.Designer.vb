<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChiTietPM
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
        Label6 = New Label()
        txtmasach = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtmadg = New TextBox()
        Label2 = New Label()
        txtmapm = New TextBox()
        Label1 = New Label()
        dgvctpm = New DataGridView()
        dtpngaymuon = New DateTimePicker()
        dtptradukien = New DateTimePicker()
        dtptrathuc = New DateTimePicker()
        CType(dgvctpm, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnhuy
        ' 
        btnhuy.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnhuy.Location = New Point(466, 519)
        btnhuy.Name = "btnhuy"
        btnhuy.Size = New Size(99, 33)
        btnhuy.TabIndex = 27
        btnhuy.Text = "Hủy"
        btnhuy.UseVisualStyleBackColor = True
        ' 
        ' btnluu
        ' 
        btnluu.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnluu.Location = New Point(596, 519)
        btnluu.Name = "btnluu"
        btnluu.Size = New Size(99, 33)
        btnluu.TabIndex = 26
        btnluu.Text = "Lưu"
        btnluu.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F)
        Label6.Location = New Point(383, 181)
        Label6.Name = "Label6"
        Label6.Size = New Size(139, 23)
        Label6.TabIndex = 24
        Label6.Text = "Ngày trả thực tế:"
        ' 
        ' txtmasach
        ' 
        txtmasach.Font = New Font("Segoe UI", 10.2F)
        txtmasach.Location = New Point(36, 215)
        txtmasach.Name = "txtmasach"
        txtmasach.Size = New Size(312, 30)
        txtmasach.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F)
        Label5.Location = New Point(36, 181)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 23)
        Label5.TabIndex = 22
        Label5.Text = "Mã sách:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F)
        Label4.Location = New Point(383, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 23)
        Label4.TabIndex = 20
        Label4.Text = "Ngày trả dự kiến:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F)
        Label3.Location = New Point(36, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 23)
        Label3.TabIndex = 18
        Label3.Text = "Ngày mượn:"
        ' 
        ' txtmadg
        ' 
        txtmadg.Font = New Font("Segoe UI", 10.2F)
        txtmadg.Location = New Point(383, 61)
        txtmadg.Name = "txtmadg"
        txtmadg.Size = New Size(312, 30)
        txtmadg.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F)
        Label2.Location = New Point(384, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 23)
        Label2.TabIndex = 16
        Label2.Text = "Mã độc giả:"
        ' 
        ' txtmapm
        ' 
        txtmapm.Font = New Font("Segoe UI", 10.2F)
        txtmapm.Location = New Point(36, 61)
        txtmapm.Name = "txtmapm"
        txtmapm.Size = New Size(312, 30)
        txtmapm.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F)
        Label1.Location = New Point(36, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 23)
        Label1.TabIndex = 14
        Label1.Text = "Mã phiếu mượn:"
        ' 
        ' dgvctpm
        ' 
        dgvctpm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvctpm.Location = New Point(36, 275)
        dgvctpm.Name = "dgvctpm"
        dgvctpm.RowHeadersWidth = 51
        dgvctpm.Size = New Size(659, 220)
        dgvctpm.TabIndex = 28
        ' 
        ' dtpngaymuon
        ' 
        dtpngaymuon.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpngaymuon.Format = DateTimePickerFormat.Short
        dtpngaymuon.Location = New Point(36, 138)
        dtpngaymuon.Name = "dtpngaymuon"
        dtpngaymuon.Size = New Size(312, 31)
        dtpngaymuon.TabIndex = 29
        ' 
        ' dtptradukien
        ' 
        dtptradukien.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtptradukien.Format = DateTimePickerFormat.Short
        dtptradukien.Location = New Point(383, 138)
        dtptradukien.Name = "dtptradukien"
        dtptradukien.Size = New Size(312, 31)
        dtptradukien.TabIndex = 30
        ' 
        ' dtptrathuc
        ' 
        dtptrathuc.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtptrathuc.Format = DateTimePickerFormat.Short
        dtptrathuc.Location = New Point(384, 214)
        dtptrathuc.Name = "dtptrathuc"
        dtptrathuc.Size = New Size(312, 31)
        dtptrathuc.TabIndex = 31
        ' 
        ' ChiTietPM
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(740, 575)
        Controls.Add(dtptrathuc)
        Controls.Add(dtptradukien)
        Controls.Add(dtpngaymuon)
        Controls.Add(dgvctpm)
        Controls.Add(btnhuy)
        Controls.Add(btnluu)
        Controls.Add(Label6)
        Controls.Add(txtmasach)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtmadg)
        Controls.Add(Label2)
        Controls.Add(txtmapm)
        Controls.Add(Label1)
        Name = "ChiTietPM"
        Text = "ChiTietPM"
        CType(dgvctpm, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnhuy As Button
    Friend WithEvents btnluu As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtmasach As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmadg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmapm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvctpm As DataGridView
    Friend WithEvents dtpngaymuon As DateTimePicker
    Friend WithEvents dtptradukien As DateTimePicker
    Friend WithEvents dtptrathuc As DateTimePicker
End Class
