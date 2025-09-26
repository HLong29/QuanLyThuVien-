Imports Microsoft.Data.SqlClient

Public Class PhieuMuon
    Dim dt As New DataTable()

    Private Sub PhieuMuon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvpm.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvpm.MultiSelect = False
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadData(Optional filter As String = "")
        Try
            MoKetNoi()
            Dim sql As String = "SELECT * FROM PhieuMuon"
            If filter <> "" Then
                sql &= " WHERE (MaPM LIKE @filter OR MaDG LIKE @filter)"
            End If

            Using cmd As New SqlCommand(sql, conn)
                If filter <> "" Then cmd.Parameters.AddWithValue("@filter", "%" & filter & "%")
                Using da As New SqlDataAdapter(cmd)
                    dt.Clear()
                    da.Fill(dt)
                    dgvpm.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu phiếu mượn: " & ex.Message)
        Finally
            DongKetNoi()
        End Try
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        ChiTietPM.Mode = "add"
        ChiTietPM.SelectedRow = Nothing
        Me.Hide()
        ChiTietPM.ShowDialog()
        LoadData()
        Me.Show()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        If dgvpm.CurrentRow Is Nothing Then Return
        Dim mapm As String = dgvpm.CurrentRow.Cells("MaPM").Value.ToString()
        Dim madg As String = dgvpm.CurrentRow.Cells("MaDG").Value.ToString()
        Dim ngaymuon As Date = Convert.ToDateTime(dgvpm.CurrentRow.Cells("NgayMuon").Value)
        Dim ngaytradukien As Date = Convert.ToDateTime(dgvpm.CurrentRow.Cells("NgayTraDuKien").Value)

        ' Lấy chi tiết mượn
        Dim masach As String = ""
        Dim ngaytrathucte As Date = Date.Now
        Try
            MoKetNoi()
            Using cmd As New SqlCommand("SELECT TOP 1 MaSach, NgayTraThucTe FROM ChiTietMuon WHERE MaPM=@mapm", conn)
                cmd.Parameters.AddWithValue("@mapm", mapm)
                Using dr = cmd.ExecuteReader()
                    If dr.Read() Then
                        masach = dr("MaSach").ToString()
                        If Not IsDBNull(dr("NgayTraThucTe")) Then
                            ngaytrathucte = Convert.ToDateTime(dr("NgayTraThucTe"))
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi lấy chi tiết phiếu mượn: " & ex.Message)
        Finally
            DongKetNoi()
        End Try

        ' Truyền dữ liệu sang form ChiTietPM
        ChiTietPM.Mode = "edit"
        ChiTietPM.SelectedRow = Nothing
        ChiTietPM.EditData(mapm, madg, ngaymuon, ngaytradukien, masach, ngaytrathucte)
        Me.Hide()
        ChiTietPM.ShowDialog()
        LoadData()
        Me.Show()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If dgvpm.CurrentRow Is Nothing Then Return
        Dim mapm As String = dgvpm.CurrentRow.Cells("MaPM").Value.ToString()
        If MessageBox.Show("Bạn có chắc muốn xóa phiếu mượn này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                MoKetNoi()
                ' Xóa chi tiết mượn trước
                Using cmd1 As New SqlCommand("DELETE FROM ChiTietMuon WHERE MaPM=@mapm", conn)
                    cmd1.Parameters.AddWithValue("@mapm", mapm)
                    cmd1.ExecuteNonQuery()
                End Using
                ' Sau đó xóa phiếu mượn
                Using cmd2 As New SqlCommand("DELETE FROM PhieuMuon WHERE MaPM=@mapm", conn)
                    cmd2.Parameters.AddWithValue("@mapm", mapm)
                    cmd2.ExecuteNonQuery()
                End Using
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Lỗi khi xóa phiếu mượn: " & ex.Message)
            Finally
                DongKetNoi()
            End Try
        End If
    End Sub

    Private Sub txttim_TextChanged(sender As Object, e As EventArgs) Handles txttim.TextChanged
        Dim filter As String = txttim.Text.Trim()
        LoadData(filter)
    End Sub

    Private Sub PhieuMuon_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dim frm As New Main()
        frm.Show()
    End Sub
End Class