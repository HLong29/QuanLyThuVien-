Imports Microsoft.Data.SqlClient

Public Class DangNhap
    Private Sub DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ẩn ký tự mật khẩu
        txtmk.UseSystemPasswordChar = True
    End Sub

    Private Sub btndn_Click(sender As Object, e As EventArgs) Handles btndn.Click
        MoKetNoi()
        Dim cmd As New SqlCommand("SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @tdn AND MatKhau = @mk", conn)
        cmd.Parameters.AddWithValue("@tdn", txttdn.Text.Trim())
        cmd.Parameters.AddWithValue("@mk", txtmk.Text.Trim())
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        DongKetNoi()

        If count > 0 Then
            Me.Hide()
            Main.Show()
        Else
            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtmk.Clear()
            txtmk.Focus()
        End If
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Application.Exit()
    End Sub
End Class