Public Class HalManagement
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Keluar.Click
        Hide()
        MsgBox("Tutup Aplikasi Ini")
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        HalTransaksi.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        HalUnit.Show()
    End Sub

    Private Sub DataPembeli_Click(sender As Object, e As EventArgs) Handles DataPembeli.Click
        Hide()
        HalDataPembeli.Show()
    End Sub
End Class