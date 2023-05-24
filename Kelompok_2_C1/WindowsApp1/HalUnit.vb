Imports MySql.Data.MySqlClient
Public Class HalUnit

    Sub Tampil()
        Da = New MySqlDataAdapter("select * from rumahtb", Cn)
        Ds = New DataSet
        Da.Fill(Ds, "rumahtb")
        DataGridView1.DataSource = Ds.Tables("rumahtb")
        DataGridView1.ReadOnly = True
    End Sub

    Sub Kosong()
        txtidrum.Text = ""
        txttiperum.Text = ""
        txtblokrum.Text = ""
        txtnorum.Text = ""
        txtharga.Text = ""
        txtidrum.Focus()
    End Sub

    Private Sub HalUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call BukaDb()
        Call Tampil()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If txtidrum.Text = "" Then
            MsgBox("Wajib Diisi")
            Call Kosong()
        Else
            Cmd = New MySqlCommand("insert into rumahtb (Id_Rumah,Tipe_Rumah,Blok_Rumah,No.Rumah,Harga_Rumah)" & "values('" & txtidrum.Text & "','" & txttiperum.Text & "','" & txtblokrum.Text & "','" & txtnorum.Text & "','" & txtharga.Text & "')", Cn)
            Cmd.ExecuteNonQuery()
            MsgBox("unit berhasil ditambah")
            Call Kosong()
        End If
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Hide()
        HalManagement.Show()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        txtidrum.Text = ""
        txttiperum.Text = ""
        txtblokrum.Text = ""
        txtnorum.Text = ""
        txtharga.Text = ""
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If txtidrum.Text = "" Then
            MsgBox("Kode Buku belum diisi!")
            txtidrum.Focus()
        Else
            If MessageBox.Show("Yakin akan menghapus Data mobil " & txtidrum.Text &
                               " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Cmd = New MySqlCommand("Delete From rumahtb Where Id_Rumah = '" & txtidrum.Text & "'", Cn)
                Cmd.ExecuteNonQuery()
                Call Kosong()
                Call Tampil()
            Else
                Call Kosong()
            End If
        End If
    End Sub
End Class