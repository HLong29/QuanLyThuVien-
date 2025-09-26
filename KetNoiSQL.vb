Imports Microsoft.Data.SqlClient

Module KetNoiSQL
    Public conn As SqlConnection
    Public connectionString As String = "Data Source=LAPTOP-DAF74F23\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True;Trust Server Certificate=True"

    ' Hàm mở kết nối
    Public Sub MoKetNoi()
        If conn Is Nothing Then
            conn = New SqlConnection(connectionString)
        End If
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    ' Hàm đóng kết nối
    Public Sub DongKetNoi()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Module