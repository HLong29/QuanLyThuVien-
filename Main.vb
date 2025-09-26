Public Class Main
    Private Sub ĐăngNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngNhậpToolStripMenuItem.Click
        Dim frm As New DangNhap()
        frm.Show()
        Me.Close()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SahcsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SahcsToolStripMenuItem.Click
        Dim frm As New Sach()
        frm.Show()
        Me.Close()
    End Sub

    Private Sub ĐộcGiảToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ĐộcGiảToolStripMenuItem1.Click
        Dim frm As New DocGia()
        frm.Show()
        Me.Close()
    End Sub

    Private Sub PhiếuMượnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuMượnToolStripMenuItem.Click
        Dim frm As New PhieuMuon()
        frm.Show()
        Me.Close()
    End Sub
End Class