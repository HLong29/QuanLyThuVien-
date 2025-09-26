Imports Microsoft.Data.SqlClient

Public Class ttSach
    Public Shared Mode As String = ""
    Public Shared SelectedRow As DataGridViewRow = Nothing

    Private Sub ttSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Mode = "add" Then
            txtmasach.Text = ""
            txttensach.Text = ""
            txttg.Text = ""
            txttheloai.Text = ""
            txtnam.Text = ""
            txtsl.Text = ""
            txtmasach.ReadOnly = False
        ElseIf Mode = "edit" AndAlso SelectedRow IsNot Nothing Then
            txtmasach.Text = SelectedRow.Cells("MaSach").Value.ToString()
            txttensach.Text = SelectedRow.Cells("TenSach").Value.ToString()
            txttg.Text = SelectedRow.Cells("TacGia").Value.ToString()
            txttheloai.Text = SelectedRow.Cells("TheLoai").Value.ToString()
            txtnam.Text = SelectedRow.Cells("NamXuatBan").Value.ToString()
            txtsl.Text = SelectedRow.Cells("SoLuong").Value.ToString()
            txtmasach.ReadOnly = True
        End If
    End Sub

    Private Sub btnluu_Click(sender As Object, e As EventArgs) Handles btnluu.Click
        Try
            ' Kiểm tra bắt buộc nhập mã sách khi thêm mới
            If Mode = "add" AndAlso String.IsNullOrWhiteSpace(txtmasach.Text) Then
                MessageBox.Show("Vui lòng nhập mã sách!")
                txtmasach.Focus()
                Return
            End If

            MoKetNoi()
            If Mode = "add" Then
                Dim sql As String = "INSERT INTO Sach (MaSach, TenSach, TacGia, TheLoai, NamXuatBan, SoLuong) VALUES (@MaSach, @TenSach, @TacGia, @TheLoai, @NamXuatBan, @SoLuong)"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@MaSach", txtmasach.Text)
                    cmd.Parameters.AddWithValue("@TenSach", txttensach.Text)
                    cmd.Parameters.AddWithValue("@TacGia", txttg.Text)
                    cmd.Parameters.AddWithValue("@TheLoai", txttheloai.Text)
                    cmd.Parameters.AddWithValue("@NamXuatBan", txtnam.Text)
                    cmd.Parameters.AddWithValue("@SoLuong", txtsl.Text)
                    cmd.ExecuteNonQuery()
                End Using
            ElseIf Mode = "edit" Then
                Dim sql As String = "UPDATE Sach SET TenSach=@TenSach, TacGia=@TacGia, TheLoai=@TheLoai, NamXuatBan=@NamXuatBan, SoLuong=@SoLuong WHERE MaSach=@MaSach"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@MaSach", txtmasach.Text)
                    cmd.Parameters.AddWithValue("@TenSach", txttensach.Text)
                    cmd.Parameters.AddWithValue("@TacGia", txttg.Text)
                    cmd.Parameters.AddWithValue("@TheLoai", txttheloai.Text)
                    cmd.Parameters.AddWithValue("@NamXuatBan", txtnam.Text)
                    cmd.Parameters.AddWithValue("@SoLuong", txtsl.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi lưu dữ liệu: " & ex.Message)
        Finally
            DongKetNoi()
        End Try
    End Sub

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        Me.Close()
    End Sub
End Class