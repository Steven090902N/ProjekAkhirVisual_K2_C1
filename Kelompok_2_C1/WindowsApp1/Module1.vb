Imports MySql.Data.MySqlClient
Module Koneksi
    Public Cn As MySqlConnection
    Public Cmd As MySqlCommand
    Public Rd As MySqlDataReader
    Public Da As MySqlDataAdapter
    Public Ds As DataSet
    Sub BukaDb()
        Cn = New MySqlConnection("server=localhost; user id=root; password=; database=rumah; convert zero datetime=true")
        Try
            Cn.Open()
            MsgBox("Selamat Datang")
        Catch ex As Exception
            MsgBox("Database Tidak Dapat Dibuka: " & ex.Message)
        End Try
    End Sub

    Sub konek()
        Try
            If Cn.State = ConnectionState.Open Then
                Cn.Close()
            End If
            Cn.ConnectionString = "server=Localhost; user id=root; password=; database=rumah convert zero datetime=true"
            Cn.Open()
            MsgBox("koneksi berhasil")
        Catch ex As Exception
            MsgBox("Koneksi Error: " & ex.Message)
        End Try
    End Sub

End Module
