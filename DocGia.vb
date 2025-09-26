Imports Microsoft.Data.SqlClient

Public Class DocGia
    Dim dt As New DataTable()

    Private Sub DocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvdocgia.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvdocgia.MultiSelect = False
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadData(Optional filter As String = "")
        Try
            MoKetNoi()
            Dim sql As String = "SELECT * FROM DocGia"
            If filter <> "" Then
                sql &= " WHERE (MaDG LIKE @filter OR HoTen LIKE @filter OR DienThoai LIKE @filter OR DiaChi LIKE @filter)"
            End If

            Using cmd As New SqlCommand(sql, conn)
                If filter <> "" Then cmd.Parameters.AddWithValue("@filter", "%" & filter & "%")
                Using da As New SqlDataAdapter(cmd)
                    dt.Clear()
                    da.Fill(dt)
                    dgvdocgia.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu độc giả: " & ex.Message)
        Finally
            DongKetNoi()
        End Try
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        ttDocGia.Mode = "add"
        ttDocGia.SelectedRow = Nothing
        Me.Hide()
        ttDocGia.ShowDialog()
        LoadData()
        Me.Show()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        If dgvdocgia.CurrentRow Is Nothing Then Return
        ttDocGia.Mode = "edit"
        ttDocGia.SelectedRow = dgvdocgia.CurrentRow
        Me.Hide()
        ttDocGia.ShowDialog()
        LoadData()
        Me.Show()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If dgvdocgia.CurrentRow Is Nothing Then Return
        Dim madg As String = dgvdocgia.CurrentRow.Cells("MaDG").Value.ToString()
        If MessageBox.Show("Bạn có chắc muốn xóa độc giả này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                MoKetNoi()
                Using cmd As New SqlCommand("DELETE FROM DocGia WHERE MaDG=@madg", conn)
                    cmd.Parameters.AddWithValue("@madg", madg)
                    cmd.ExecuteNonQuery()
                End Using
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Lỗi khi xóa độc giả: " & ex.Message)
            Finally
                DongKetNoi()
            End Try
        End If
    End Sub

    Private Sub txttim_TextChanged(sender As Object, e As EventArgs) Handles txttim.TextChanged
        Dim filter As String = txttim.Text.Trim()
        LoadData(filter)
    End Sub

    Private Sub DocGia_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dim frm As New Main()
        frm.Show()
    End Sub
End Class