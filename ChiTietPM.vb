Imports Microsoft.Data.SqlClient

Public Class ChiTietPM
    Public Shared Mode As String = ""
    Public Shared SelectedRow As DataGridViewRow = Nothing

    ' Thêm thuộc tính để nhận dữ liệu
    Private editMapm As String
    Private editMadg As String
    Private editNgayMuon As Date
    Private editNgayTraDuKien As Date
    Private editMaSach As String
    Private editNgayTraThucTe As Date

    ' Hàm nhận dữ liệu từ PhieuMuon
    Public Sub EditData(mapm As String, madg As String, ngaymuon As Date, ngaytradukien As Date, masach As String, ngaytrathucte As Date)
        editMapm = mapm
        editMadg = madg
        editNgayMuon = ngaymuon
        editNgayTraDuKien = ngaytradukien
        editMaSach = masach
        editNgayTraThucTe = ngaytrathucte
    End Sub

    Private Sub ChiTietPM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Mode = "add" Then
            txtmapm.Text = ""
            txtmadg.Text = ""
            dtpngaymuon.Value = DateTime.Now
            dtptradukien.Value = DateTime.Now
            txtmasach.Text = ""
            dtptrathuc.Value = DateTime.Now
            txtmapm.ReadOnly = False
            txtmadg.ReadOnly = False
        ElseIf Mode = "edit" Then
            txtmapm.Text = editMapm
            txtmadg.Text = editMadg
            dtpngaymuon.Value = editNgayMuon
            dtptradukien.Value = editNgayTraDuKien
            txtmasach.Text = editMaSach
            dtptrathuc.Value = editNgayTraThucTe
            txtmapm.ReadOnly = True
            txtmadg.ReadOnly = True
        End If
    End Sub

    Private Sub btnluu_Click(sender As Object, e As EventArgs) Handles btnluu.Click
        Try
            If Mode = "add" AndAlso (String.IsNullOrWhiteSpace(txtmapm.Text) OrElse String.IsNullOrWhiteSpace(txtmasach.Text)) Then
                MessageBox.Show("Vui lòng nhập mã phiếu mượn và mã sách!")
                txtmapm.Focus()
                Return
            End If

            MoKetNoi()
            If Mode = "add" Then
                Dim sql1 As String = "INSERT INTO PhieuMuon (MaPM, MaDG, NgayMuon, NgayTraDuKien) VALUES (@MaPM, @MaDG, @NgayMuon, @NgayTraDuKien)"
                Using cmd1 As New SqlCommand(sql1, conn)
                    cmd1.Parameters.AddWithValue("@MaPM", txtmapm.Text)
                    cmd1.Parameters.AddWithValue("@MaDG", txtmadg.Text)
                    cmd1.Parameters.AddWithValue("@NgayMuon", dtpngaymuon.Value)
                    cmd1.Parameters.AddWithValue("@NgayTraDuKien", dtptradukien.Value)
                    cmd1.ExecuteNonQuery()
                End Using
                Dim sql2 As String = "INSERT INTO ChiTietMuon (MaPM, MaSach, NgayTraThucTe) VALUES (@MaPM, @MaSach, @NgayTraThucTe)"
                Using cmd2 As New SqlCommand(sql2, conn)
                    cmd2.Parameters.AddWithValue("@MaPM", txtmapm.Text)
                    cmd2.Parameters.AddWithValue("@MaSach", txtmasach.Text)
                    cmd2.Parameters.AddWithValue("@NgayTraThucTe", dtptrathuc.Value)
                    cmd2.ExecuteNonQuery()
                End Using
            ElseIf Mode = "edit" Then
                Dim sql1 As String = "UPDATE PhieuMuon SET MaDG=@MaDG, NgayMuon=@NgayMuon, NgayTraDuKien=@NgayTraDuKien WHERE MaPM=@MaPM"
                Using cmd1 As New SqlCommand(sql1, conn)
                    cmd1.Parameters.AddWithValue("@MaPM", txtmapm.Text)
                    cmd1.Parameters.AddWithValue("@MaDG", txtmadg.Text)
                    cmd1.Parameters.AddWithValue("@NgayMuon", dtpngaymuon.Value)
                    cmd1.Parameters.AddWithValue("@NgayTraDuKien", dtptradukien.Value)
                    cmd1.ExecuteNonQuery()
                End Using
                Dim sql2 As String = "UPDATE ChiTietMuon SET NgayTraThucTe=@NgayTraThucTe, MaSach=@MaSach WHERE MaPM=@MaPM"
                Using cmd2 As New SqlCommand(sql2, conn)
                    cmd2.Parameters.AddWithValue("@MaPM", txtmapm.Text)
                    cmd2.Parameters.AddWithValue("@MaSach", txtmasach.Text)
                    cmd2.Parameters.AddWithValue("@NgayTraThucTe", dtptrathuc.Value)
                    cmd2.ExecuteNonQuery()
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