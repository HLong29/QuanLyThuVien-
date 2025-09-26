Imports Microsoft.Data.SqlClient

Public Class Sach
    Dim dt As New DataTable()

    Private Sub Sach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvsach.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvsach.MultiSelect = False
            LoadData()
            LoadTheLoai()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadData(Optional filter As String = "", Optional theloai As String = "")
        Try
            MoKetNoi()
            Dim sql As String = "SELECT * FROM Sach"
            If filter <> "" Then
                sql &= " WHERE (TenSach LIKE @filter OR MaSach LIKE @filter OR TacGia LIKE @filter)"
                If theloai <> "" Then
                    sql &= " AND TheLoai = @theloai"
                End If
            ElseIf theloai <> "" Then
                sql &= " WHERE TheLoai = @theloai"
            End If

            Using cmd As New SqlCommand(sql, conn)
                If filter <> "" Then cmd.Parameters.AddWithValue("@filter", "%" & filter & "%")
                If theloai <> "" Then cmd.Parameters.AddWithValue("@theloai", theloai)
                Using da As New SqlDataAdapter(cmd)
                    dt.Clear()
                    da.Fill(dt)
                    dgvsach.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu sách: " & ex.Message)
        Finally
            DongKetNoi()
        End Try
    End Sub

    Private Sub LoadTheLoai()
        Try
            MoKetNoi()
            Using cmd As New SqlCommand("SELECT DISTINCT TheLoai FROM Sach", conn)
                Using dr As SqlDataReader = cmd.ExecuteReader()
                    cbloc.Items.Clear()
                    cbloc.Items.Add("Tất cả")
                    While dr.Read()
                        cbloc.Items.Add(dr("TheLoai").ToString())
                    End While
                End Using
            End Using
            cbloc.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải thể loại: " & ex.Message)
        Finally
            DongKetNoi()
        End Try
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        ttSach.Mode = "add"
        ttSach.SelectedRow = Nothing
        Me.Hide()
        ttSach.ShowDialog()
        LoadData() ' Reload lại dữ liệu sau khi thêm
        Me.Show()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        If dgvsach.CurrentRow Is Nothing Then Return
        ttSach.Mode = "edit"
        ttSach.SelectedRow = dgvsach.CurrentRow
        Me.Hide()
        ttSach.ShowDialog()
        LoadData() ' Reload lại dữ liệu sau khi sửa
        Me.Show()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If dgvsach.CurrentRow Is Nothing Then Return
        Dim masach As String = dgvsach.CurrentRow.Cells("MaSach").Value.ToString()
        If MessageBox.Show("Bạn có chắc muốn xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                MoKetNoi()
                Using cmd As New SqlCommand("DELETE FROM Sach WHERE MaSach=@masach", conn)
                    cmd.Parameters.AddWithValue("@masach", masach)
                    cmd.ExecuteNonQuery()
                End Using
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Lỗi khi xóa sách: " & ex.Message)
            Finally
                DongKetNoi()
            End Try
        End If
    End Sub

    Private Sub txttim_TextChanged(sender As Object, e As EventArgs) Handles txttim.TextChanged
        Dim filter As String = txttim.Text.Trim()
        Dim theloai As String = If(cbloc.SelectedIndex > 0, cbloc.SelectedItem.ToString(), "")
        LoadData(filter, theloai)
    End Sub

    Private Sub cbloc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbloc.SelectedIndexChanged
        Dim filter As String = txttim.Text.Trim()
        Dim theloai As String = If(cbloc.SelectedIndex > 0, cbloc.SelectedItem.ToString(), "")
        LoadData(filter, theloai)
    End Sub

    ' Quay về Main khi đóng form Sach
    Private Sub Sach_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dim frm As New Main()
        frm.Show()
    End Sub
End Class