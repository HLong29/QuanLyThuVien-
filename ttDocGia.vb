Imports Microsoft.Data.SqlClient

Public Class ttDocGia
    Public Shared Mode As String = ""
    Public Shared SelectedRow As DataGridViewRow = Nothing

    Private Sub ttDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Mode = "add" Then
            txtmadg.Text = ""
            txthoten.Text = ""
            txtdt.Text = ""
            txtdc.Text = ""
            txtmadg.ReadOnly = False
        ElseIf Mode = "edit" AndAlso SelectedRow IsNot Nothing Then
            txtmadg.Text = SelectedRow.Cells("MaDG").Value.ToString()
            txthoten.Text = SelectedRow.Cells("HoTen").Value.ToString()
            txtdt.Text = SelectedRow.Cells("DienThoai").Value.ToString()
            txtdc.Text = SelectedRow.Cells("DiaChi").Value.ToString()
            txtmadg.ReadOnly = True
        End If
    End Sub

    Private Sub btnluu_Click(sender As Object, e As EventArgs) Handles btnluu.Click
        Try
            If Mode = "add" AndAlso String.IsNullOrWhiteSpace(txtmadg.Text) Then
                MessageBox.Show("Vui lòng nhập mã độc giả!")
                txtmadg.Focus()
                Return
            End If

            MoKetNoi()
            If Mode = "add" Then
                Dim sql As String = "INSERT INTO DocGia (MaDG, HoTen, DienThoai, DiaChi) VALUES (@MaDG, @HoTen, @DienThoai, @DiaChi)"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@MaDG", txtmadg.Text)
                    cmd.Parameters.AddWithValue("@HoTen", txthoten.Text)
                    cmd.Parameters.AddWithValue("@DienThoai", txtdt.Text)
                    cmd.Parameters.AddWithValue("@DiaChi", txtdc.Text)
                    cmd.ExecuteNonQuery()
                End Using
            ElseIf Mode = "edit" Then
                Dim sql As String = "UPDATE DocGia SET HoTen=@HoTen, DienThoai=@DienThoai, DiaChi=@DiaChi WHERE MaDG=@MaDG"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@MaDG", txtmadg.Text)
                    cmd.Parameters.AddWithValue("@HoTen", txthoten.Text)
                    cmd.Parameters.AddWithValue("@DienThoai", txtdt.Text)
                    cmd.Parameters.AddWithValue("@DiaChi", txtdc.Text)
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